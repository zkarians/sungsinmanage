using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class cti_blacklist_filter : Form
{
	private IContainer components;

	private cti_import ctiImportForm;

	private List<cti_db> ctiDbClass;

	private object busy;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button6_Click;
			Button button = _Button6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public cti_blacklist_filter()
	{
		base.Load += cti_blacklist_filter_Load;
		base.FormClosed += cti_blacklist_filter_FormClosed;
		busy = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Label1 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.Panel1.Location = new System.Drawing.Point(12, 40);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(491, 298);
		this.Panel1.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label1.Location = new System.Drawing.Point(12, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(85, 12);
		this.Label1.TabIndex = 24;
		this.Label1.Text = "필터링 대상: ";
		this.Button1.BackColor = System.Drawing.Color.Red;
		this.Button1.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(199, 344);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(107, 28);
		this.Button1.TabIndex = 25;
		this.Button1.Text = "닫기";
		this.Button1.UseVisualStyleBackColor = false;
		this.Button6.BackColor = System.Drawing.Color.Blue;
		this.Button6.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button6.ForeColor = System.Drawing.Color.White;
		this.Button6.Location = new System.Drawing.Point(312, 344);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(191, 28);
		this.Button6.TabIndex = 23;
		this.Button6.Text = "시작";
		this.Button6.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(515, 381);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Button6);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "cti_blacklist_filter";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "블랙리스트 필터";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void cti_blacklist_filter_Load(object sender, EventArgs e)
	{
		Label1.Text = "필터링 대상: " + MyProject.Forms.ssorder_cti.selectDb.name;
		ctiImportForm = new cti_import();
		Panel1.Controls.Add(ctiImportForm.Panel1);
		ctiImportForm.Panel1.Visible = true;
		ctiImportForm.Panel1.Dock = DockStyle.Fill;
		ctiDbClass = MyProject.Forms.ssorder_cti.getDB(refresh: false, "blacklist");
		if (ctiDbClass.Count <= 0)
		{
			return;
		}
		ctiImportForm.blacklist_grid.Rows.Clear();
		foreach (cti_db item in ctiDbClass)
		{
			ctiImportForm.blacklist_grid.Rows.Add(item.idx, false, item.name, item.nosplit_count);
		}
		ctiImportForm.db_status.Text = "총 " + Conversions.ToString(ctiDbClass.Count) + "개 데이터베이스 발견.";
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(busy))
		{
			return;
		}
		busy = true;
		int num = 0;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)ctiImportForm.blacklist_grid.Rows).GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.ConditionalCompareObjectEqual(((DataGridViewCheckBoxCell)((DataGridViewRow)enumerator.Current).Cells[1]).Value, true, TextCompare: false))
					{
						num++;
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (num <= 0)
			{
				MessageBox.Show("블랙리스트 데이터베이스를 한 개 이상 선택하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				busy = false;
				return;
			}
			if (ctiImportForm.ListBox3.SelectedIndices.Count <= 0)
			{
				MessageBox.Show("블랙리스트 비교군을 한 개 이상 선택하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				busy = false;
				return;
			}
			if ((ctiImportForm.ListBox3.SelectedIndices.Count < ctiImportForm.ListBox4.SelectedIndex + 1) & (ctiImportForm.ListBox4.SelectedIndex != 6))
			{
				MessageBox.Show("필터링 조건 갯수보다 비교군 갯수가 작을 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				busy = false;
				return;
			}
			ctiImportForm.indices = ctiImportForm.ListBox3.SelectedIndices;
			ctiImportForm.selectIndex = ctiImportForm.ListBox4.SelectedIndex;
			ctiImportForm.dbName = MyProject.Forms.ssorder_cti.selectDb.name;
			MyProject.Forms.cti_blacklist_progress.parent_form = ctiImportForm;
			ctiImportForm.ctiTMList = MyProject.Forms.ssorder_cti.selectDb.ExportReport();
			if (MyProject.Forms.cti_blacklist_progress.ShowDialog() != DialogResult.OK)
			{
				busy = false;
				return;
			}
			List<string> list = new List<string>();
			if (ctiImportForm.correctData == null)
			{
				MessageBox.Show("일치하는 레코드를 찾지 못했습니다.", "필터링 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			foreach (cti_tm_list correctDatum in ctiImportForm.correctData)
			{
				list.Add(Conversions.ToString(correctDatum.idx));
			}
			if (list.Count <= 0)
			{
				MessageBox.Show("일치하는 레코드를 찾지 못했습니다.", "필터링 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				busy = false;
				return;
			}
			string text = JsonConvert.SerializeObject(list);
			JObject jObject = new JObject();
			jObject.Add("type", "setBlacklist");
			jObject.Add("id", Module1._id);
			jObject.Add("pw", Module1._pw);
			jObject.Add("deleteMode", Conversion.Val(RuntimeHelpers.GetObjectValue(Interaction.IIf(ctiImportForm.RadioButton4.Checked, 1, 0))));
			jObject.Add("idxs", Module1.Base64Encode(text.ToString()));
			string postData = "args=" + jObject.ToString(Formatting.None);
			try
			{
				JObject jObject2 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_set.php")), postData, progress: true).getHTML(this));
				if (jObject2.SelectToken("response").Equals("fail"))
				{
					Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
					busy = false;
					return;
				}
				JToken jToken = jObject2.SelectToken("response");
				if ((string)jToken == "ok")
				{
					MessageBox.Show(MyProject.Forms.ssorder_cti.selectDb.name + "에서 " + Conversions.ToString(ctiImportForm.correctData.Count) + "개의 항목이 블랙리스트 처리 되었습니다", "필터링 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					MyProject.Forms.ssorder_cti.getDB(refresh: true);
					Hide();
					Dispose();
				}
				else if ((string)jToken == "fail")
				{
					CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex2.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				busy = false;
				ProjectData.ClearProjectError();
				return;
			}
			busy = false;
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Dispose();
	}

	private void cti_blacklist_filter_FormClosed(object sender, FormClosedEventArgs e)
	{
		Dispose();
	}
}
