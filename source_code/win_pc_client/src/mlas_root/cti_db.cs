using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using mlas_root.My;

namespace mlas_root;

public class cti_db
{
	public int count;

	public int max_page;

	public int now_page;

	private int current_page;

	public int now_item_idx;

	public List<cti_tm_list> ctiTMList;

	private bool returnFlag;

	public object blacklistViewMode;

	public int idx { get; set; }

	public string name { get; set; }

	public int status { get; set; }

	public string call_counts { get; set; }

	public string last_date { get; set; }

	public int nosplit_count { get; set; }

	public int blacklist_count { get; set; }

	public cti_db(int idx, string name, int count)
	{
		blacklist_count = 0;
		now_page = -1;
		current_page = -1;
		now_item_idx = 0;
		ctiTMList = null;
		returnFlag = true;
		blacklistViewMode = false;
		this.idx = idx;
		this.name = name;
		status = 0;
		nosplit_count = count;
		call_counts = "[" + Conversions.ToString(count) + ",0,0,0,0]";
	}

	public void setAgentData(List<cti_tm_list> item)
	{
		ctiTMList = item;
		count = ctiTMList.Count;
		max_page = checked((int)Math.Ceiling((double)count / 500.0));
	}

	public int setAgentDataGridView(bool callLogType, DataGridView table_grid, int opt, bool blacklistVisible)
	{
		current_page = -1;
		return setAgentDataGridView(callLogType, table_grid, Conversions.ToString(0), opt, blacklistVisible);
	}

	public int setAgentDataGridView(bool callLogType, DataGridView table_grid, string page, int opt, bool blacklistVisible)
	{
		now_page = Conversions.ToInteger(page);
		current_page = Conversions.ToInteger(page);
		MyProject.Forms.ssorder_cti.ComboBoxEx2.Items.Clear();
		checked
		{
			int num = max_page - 1;
			for (int i = 0; i <= num; i++)
			{
				MyProject.Forms.ssorder_cti.ComboBoxEx2.Items.Add(i + 1 + " 페이지");
			}
			if (max_page >= current_page)
			{
				MyProject.Forms.ssorder_cti.ComboBoxEx2.SelectedIndex = current_page;
			}
			else
			{
				now_page = 0;
				current_page = 0;
				MyProject.Forms.ssorder_cti.ComboBoxEx2.SelectedIndex = current_page;
			}
			now_item_idx = now_page * 500;
			table_grid.Rows.Clear();
			int num2 = 0;
			foreach (cti_tm_list ctiTM in ctiTMList)
			{
				if ((num2 < now_item_idx) & (now_item_idx != 0))
				{
					num2++;
					continue;
				}
				if (num2 >= now_item_idx + 500)
				{
					break;
				}
				switch (opt)
				{
				case 1:
				{
					int? call_count = ctiTM.call_count;
					bool? flag = (call_count.HasValue ? new bool?(call_count.GetValueOrDefault() <= 0) : null);
					if (((!ctiTM.call_count.HasValue) ? new bool?(true) : flag).GetValueOrDefault())
					{
						continue;
					}
					break;
				}
				case 2:
				{
					if (ctiTM.result != 0)
					{
						continue;
					}
					int? call_count = ctiTM.call_count;
					if ((call_count.HasValue ? new bool?(call_count.GetValueOrDefault() > 0) : null).GetValueOrDefault())
					{
						continue;
					}
					break;
				}
				case 3:
				{
					int? call_count = ctiTM.call_count;
					bool? obj = (call_count.HasValue ? new bool?(call_count.GetValueOrDefault() <= 0) : null);
					bool? obj2 = (ctiTM.result == 5) | obj;
					if (((ctiTM.result == 6) | obj2).GetValueOrDefault())
					{
						continue;
					}
					break;
				}
				case 4:
					if (ctiTM.result != 1)
					{
						continue;
					}
					break;
				case 5:
					if (ctiTM.result != 6)
					{
						continue;
					}
					break;
				case 6:
					if (ctiTM.blacklist == 0)
					{
						continue;
					}
					break;
				}
				if (callLogType)
				{
					table_grid.Rows.Add(ctiTM.idx, ctiTM.call_time, ctiTM.name, ctiTM.product_name, ctiTM.seller, ctiTM.price, ctiTM.call_count, ctiTM.call_phone, ctiTM.ResultString());
				}
				else if (opt != 6)
				{
					if (!blacklistVisible)
					{
						if (ctiTM.blacklist == 0)
						{
							table_grid.Rows.Add(ctiTM.idx, ctiTM.name, ctiTM.home_number, ctiTM.phone_number, ctiTM.address, ctiTM.product_name, ctiTM.seller, ctiTM.price, ctiTM.comment, ctiTM.comment2);
						}
					}
					else
					{
						table_grid.Rows.Add(ctiTM.idx, ctiTM.name, ctiTM.home_number, ctiTM.phone_number, ctiTM.address, ctiTM.product_name, ctiTM.seller, ctiTM.price, ctiTM.comment, ctiTM.comment2);
					}
				}
				else
				{
					table_grid.Rows.Add(ctiTM.idx, ctiTM.name, ctiTM.home_number, ctiTM.phone_number, ctiTM.address, ctiTM.product_name, ctiTM.seller, ctiTM.price, ctiTM.comment, ctiTM.comment2);
				}
				num2++;
			}
		}
		if (opt == 1 || opt == 3)
		{
			table_grid.Sort(table_grid.Columns[1], ListSortDirection.Descending);
		}
		MyProject.Forms.ssorder_cti.page_busy = false;
		return count;
	}

	public object getCusData(DataGridView table_grid, string page, bool returnFlag)
	{
		if (Conversions.ToDouble(page) == -1.0)
		{
			page = Conversions.ToString(0);
		}
		this.returnFlag = returnFlag;
		return getCusData(table_grid, page);
	}

	public int getCusData(DataGridView table_grid)
	{
		returnFlag = true;
		current_page = -1;
		return getCusData(table_grid, Conversions.ToString(0));
	}

	private int getCusData(DataGridView table_grid, string page)
	{
		if (((double)current_page == Conversions.ToDouble(page)) & returnFlag)
		{
			MyProject.Forms.ssorder_cti.page_busy = false;
			return count;
		}
		now_page = Conversions.ToInteger(page);
		current_page = Conversions.ToInteger(page);
		JObject jObject = new JObject();
		jObject.Add("type", "getCusData");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("page", page);
		jObject.Add("db_idx", idx);
		jObject.Add("blacklistViewMode", Conversion.Val(RuntimeHelpers.GetObjectValue(Interaction.IIf(Conversions.ToBoolean(blacklistViewMode), 1, 0))));
		string postData = "args=" + jObject.ToString(Formatting.None);
		string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_get.php")), postData, progress: true).getHTML(MyProject.Forms.ssorder_cti);
		checked
		{
			try
			{
				JObject jObject2 = JObject.Parse(hTML);
				if (jObject2.SelectToken("response").Equals("fail"))
				{
					Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
					return 0;
				}
				count = Conversions.ToInteger(jObject2.SelectToken("count").ToString());
				max_page = (int)jObject2.SelectToken("max_page");
				MyProject.Forms.ssorder_cti.ComboBoxEx1.Items.Clear();
				int num = max_page - 1;
				for (int i = 0; i <= num; i++)
				{
					MyProject.Forms.ssorder_cti.ComboBoxEx1.Items.Add(i + 1 + " 페이지");
				}
				try
				{
					ctiTMList = JsonConvert.DeserializeObject<List<cti_tm_list>>((string)jObject2.SelectToken("output"));
					MyProject.Forms.ssorder_cti.ComboBoxEx1.SelectedIndex = current_page;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ctiTMList = new List<cti_tm_list>();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다.\r\n검색을 다시 시도 하십시오. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex4.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				MyProject.Forms.ssorder_cti.page_busy = false;
				int result = 0;
				ProjectData.ClearProjectError();
				return result;
			}
			table_grid.Rows.Clear();
			using (List<cti_tm_list>.Enumerator enumerator = ctiTMList.GetEnumerator())
			{
				_Closure_0024__42_002D0 closure_0024__42_002D = default(_Closure_0024__42_002D0);
				while (enumerator.MoveNext())
				{
					closure_0024__42_002D = new _Closure_0024__42_002D0(closure_0024__42_002D);
					closure_0024__42_002D._0024VB_0024Local_db = enumerator.Current;
					string text = MyProject.Forms.ssorder_cti.ctiAgents.Find(closure_0024__42_002D._Lambda_0024__0)?.account_name;
					table_grid.Rows.Add(closure_0024__42_002D._0024VB_0024Local_db.idx, text, closure_0024__42_002D._0024VB_0024Local_db.name, closure_0024__42_002D._0024VB_0024Local_db.home_number, closure_0024__42_002D._0024VB_0024Local_db.phone_number, closure_0024__42_002D._0024VB_0024Local_db.address, closure_0024__42_002D._0024VB_0024Local_db.product_name, closure_0024__42_002D._0024VB_0024Local_db.seller, closure_0024__42_002D._0024VB_0024Local_db.price, closure_0024__42_002D._0024VB_0024Local_db.comment, closure_0024__42_002D._0024VB_0024Local_db.comment2);
				}
			}
			MyProject.Forms.ssorder_cti.page_busy = false;
			return count;
		}
	}

	public List<cti_tm_list> ExportReport(object context = null, int? resultNumber = null, bool blacklistOutput = false)
	{
		if (context == null)
		{
			context = MyProject.Forms.ssorder_cti;
		}
		JObject jObject = new JObject();
		jObject.Add("type", "getCusData");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("db_idx", idx);
		jObject.Add("all", 1);
		jObject.Add("blacklistViewMode", Conversion.Val(RuntimeHelpers.GetObjectValue(Interaction.IIf(blacklistOutput, 2, 0))));
		if (resultNumber.HasValue)
		{
			jObject.Add("option", resultNumber);
		}
		string postData = "args=" + jObject.ToString(Formatting.None);
		string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_get.php")), postData, progress: true).getHTML((Form)context);
		try
		{
			JObject jObject2 = JObject.Parse(hTML);
			if (jObject2.SelectToken("response").Equals("fail"))
			{
				Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
				return null;
			}
			return JsonConvert.DeserializeObject<List<cti_tm_list>>((string)jObject2.SelectToken("output"));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다.\r\n검색을 다시 시도 하십시오. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex2.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			List<cti_tm_list> result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
