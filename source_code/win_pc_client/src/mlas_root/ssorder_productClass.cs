using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class ssorder_productClass
{
	public class deepClass
	{
		public bool _check;

		public string product_code;

		public string team_code;

		public string gb_code;

		public string product_name;

		public double product_price;

		public int product_stock;

		public deepClass(string[] arr)
		{
			string s = arr[0];
			int result = 0;
			if (int.TryParse(s, out result))
			{
				product_code = Conversion.Val(arr[0]).ToString("0###");
			}
			else
			{
				product_code = arr[0];
			}
			team_code = arr[1];
			gb_code = arr[2];
			product_name = arr[3];
			product_price = Conversions.ToDouble(arr[4]);
			product_stock = Conversions.ToInteger(arr[5]);
		}

		public string getGB()
		{
			if (Conversions.ToDouble(gb_code) == 1.0)
			{
				return "본품";
			}
			return "사례";
		}

		public string[] getArray()
		{
			string text = ((Conversions.ToDouble(team_code) != 1.0) ? "TM" : "직판");
			string text2 = ((Conversions.ToDouble(gb_code) != 1.0) ? "사례" : "본품");
			return new string[6]
			{
				product_code,
				text,
				text2,
				product_name,
				Conversions.ToString(product_price),
				Conversions.ToString(product_stock)
			};
		}

		public string[] getGridOrderData()
		{
			string text = ((Conversions.ToDouble(gb_code) != 1.0) ? "사례" : "본품");
			return new string[5]
			{
				Conversions.ToString(Value: false),
				text,
				product_name,
				Conversions.ToString(product_price),
				Conversions.ToString(product_stock)
			};
		}

		public DataGridViewRow getGridData()
		{
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			string[] dataSource = new string[2] { "직판", "TM" };
			string[] dataSource2 = new string[2] { "본품", "사례" };
			DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
			dataGridViewComboBoxCell.DataSource = dataSource;
			string left = team_code;
			if (Operators.CompareString(left, Conversions.ToString(1), TextCompare: false) == 0)
			{
				dataGridViewComboBoxCell.Value = "직판";
			}
			else if (Operators.CompareString(left, Conversions.ToString(2), TextCompare: false) == 0)
			{
				dataGridViewComboBoxCell.Value = "TM";
			}
			DataGridViewComboBoxCell dataGridViewComboBoxCell2 = new DataGridViewComboBoxCell();
			dataGridViewComboBoxCell2.DataSource = dataSource2;
			string left2 = gb_code;
			if (Operators.CompareString(left2, Conversions.ToString(1), TextCompare: false) == 0)
			{
				dataGridViewComboBoxCell2.Value = "본품";
			}
			else if (Operators.CompareString(left2, Conversions.ToString(2), TextCompare: false) == 0)
			{
				dataGridViewComboBoxCell2.Value = "사례";
			}
			dataGridViewRow.Cells.Add(new DataGridViewCheckBoxCell
			{
				Value = false
			});
			dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = product_code
			});
			dataGridViewRow.Cells.Add(dataGridViewComboBoxCell);
			dataGridViewRow.Cells.Add(dataGridViewComboBoxCell2);
			dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = product_name
			});
			dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = "\\" + Conversion.Val(product_price).ToString("N0")
			});
			dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = product_stock
			});
			dataGridViewRow.Cells[1].ReadOnly = true;
			if (ssorder.ssorder_acgb == 4)
			{
				dataGridViewRow.Cells[2].ReadOnly = true;
				dataGridViewRow.Cells[3].ReadOnly = true;
				dataGridViewRow.Cells[4].ReadOnly = true;
				dataGridViewRow.Cells[5].ReadOnly = true;
			}
			dataGridViewRow.Height = 35;
			return dataGridViewRow;
		}
	}

	private List<deepClass> datalist;

	private DataTable dt;

	public ssorder_productClass(string parse)
	{
		datalist = new List<deepClass>();
		dt = new DataTable();
		string[] array = parse.Split(new string[1] { "<split>" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			datalist.Add(new deepClass(text.Split(new string[1] { "<next>" }, StringSplitOptions.None)));
		}
	}

	public void setDataTable()
	{
		dt = GetDataTableFromDGV();
	}

	public DataTable getDataTable()
	{
		return dt;
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
		return "제품코드,소속구분,제품구분,제품명,가격,재고";
	}

	private DataTable GetDataTableFromDGV()
	{
		DataTable dataTable = new DataTable();
		string[] array = new string[8] { "체크", "제품코드", "제품구분", "제품명", "가격", "수량", "재고", "비고" };
		foreach (string text in array)
		{
			if (Operators.CompareString(text, "체크", TextCompare: false) == 0)
			{
				dataTable.Columns.Add(new DataColumn(text, typeof(bool)));
				continue;
			}
			dataTable.Columns.Add(new DataColumn(text, typeof(string)));
			if ((dataTable.Columns.Count != 5) & (dataTable.Columns.Count != 6) & (dataTable.Columns.Count != 8))
			{
				dataTable.Columns[checked(dataTable.Columns.Count - 1)].ReadOnly = true;
			}
		}
		foreach (deepClass item in datalist)
		{
			dataTable.Rows.Add(item._check, item.product_code, item.getGB(), item.product_name, item.product_price, 1, item.product_stock);
		}
		return dataTable;
	}
}
