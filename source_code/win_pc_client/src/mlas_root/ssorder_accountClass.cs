using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class ssorder_accountClass
{
	public class deepClass
	{
		private enum team_enum
		{
			직판,
			TM
		}

		private enum acgb_enum
		{
			관리자,
			일반,
			최고관리자,
			재고관리자,
			루트계정
		}

		public bool _check;

		private int account_code;

		private int acgb_code;

		private int team_code;

		private string account_id;

		private string account_pw;

		private string account_name;

		private string allow_ip;

		public deepClass(string[] arr)
		{
			account_code = Conversions.ToInteger(arr[0]);
			acgb_code = Conversions.ToInteger(arr[1]);
			team_code = Conversions.ToInteger(arr[2]);
			account_id = arr[3];
			account_pw = arr[4];
			account_name = arr[5];
			allow_ip = arr[6];
		}

		public string[] getArray()
		{
			string text = acgb_code switch
			{
				1 => "관리자", 
				2 => "일반", 
				3 => "최고관리자", 
				4 => "재고관리자", 
				5 => "루트계정", 
				_ => "모름", 
			};
			string text2 = ((team_code != 1) ? "TM" : "직판");
			return new string[6]
			{
				Conversions.ToString(account_code),
				text,
				text2,
				account_id,
				account_pw,
				account_name
			};
		}

		public DataGridViewRow getGridData()
		{
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
			dataGridViewComboBoxCell.DataSource = Enum.GetNames(typeof(team_enum));
			switch (team_code)
			{
			case 1:
				dataGridViewComboBoxCell.Value = "직판";
				break;
			case 2:
				dataGridViewComboBoxCell.Value = "TM";
				break;
			}
			DataGridViewComboBoxCell dataGridViewComboBoxCell2 = new DataGridViewComboBoxCell();
			if (ssorder.ssorder_acgb == 5)
			{
				dataGridViewComboBoxCell2.DataSource = new string[5] { "최고관리자", "관리자", "일반", "재고관리자", "루트계정" };
			}
			else
			{
				dataGridViewComboBoxCell2.DataSource = new string[4] { "최고관리자", "관리자", "일반", "재고관리자" };
			}
			switch (acgb_code)
			{
			case 1:
				dataGridViewComboBoxCell2.Value = "관리자";
				break;
			case 2:
				dataGridViewComboBoxCell2.Value = "일반";
				break;
			case 3:
				dataGridViewComboBoxCell2.Value = "최고관리자";
				break;
			case 4:
				dataGridViewComboBoxCell2.Value = "재고관리자";
				break;
			case 5:
				dataGridViewComboBoxCell2.Value = "루트계정";
				break;
			}
			dataGridViewRow.Cells.Add(new DataGridViewCheckBoxCell
			{
				Value = false
			});
			dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = account_code
			});
			dataGridViewRow.Cells.Add(dataGridViewComboBoxCell2);
			dataGridViewRow.Cells.Add(dataGridViewComboBoxCell);
			dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = account_id
			});
			dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = account_pw
			});
			dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = account_name
			});
			dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = allow_ip
			});
			dataGridViewRow.Height = 35;
			return dataGridViewRow;
		}
	}

	private List<deepClass> datalist;

	public ssorder_accountClass(string parse)
	{
		datalist = new List<deepClass>();
		string[] array = parse.Split(new string[1] { "<split>" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			datalist.Add(new deepClass(text.Split(new string[1] { "<next>" }, StringSplitOptions.None)));
		}
	}

	public List<deepClass> getData()
	{
		return datalist;
	}

	public deepClass getData(int index)
	{
		return datalist[index];
	}

	public void add(string[] data)
	{
		datalist.Add(new deepClass(data));
	}

	public string ColumnHeaderText()
	{
		return "번호,계정구분,소속구분,아이디,비밀번호,이름,허용 IP";
	}
}
