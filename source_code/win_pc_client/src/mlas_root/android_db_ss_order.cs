using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class android_db_ss_order : Form
{
	private class addressClass
	{
		private int _index;

		private string _zipNo;

		private string _lnmAdres;

		private string _rnAdres;

		public addressClass(object index, object zipNo, object lnmAdres, object rnAdres)
		{
			_index = Conversions.ToInteger(index);
			_zipNo = Conversions.ToString(zipNo);
			_lnmAdres = Conversions.ToString(lnmAdres);
			_rnAdres = Conversions.ToString(rnAdres);
		}

		public string[] getArray()
		{
			return new string[4]
			{
				Conversions.ToString(_index),
				_zipNo,
				_lnmAdres,
				_rnAdres
			};
		}
	}

	private IContainer components;

	private bool busy;

	private bool isOrderPageInit;

	public string errorIndex;

	private List<db_ss_order> ss_order;

	public List<db_ss_account> ss_account;

	private object failCount;

	private ssorder_orderClass.deepClass nowOrderProducts;

	private List<addressClass> addressArray;

	private DataGridView nowDatagridView;

	private bool searchBoolean;

	private bool isProductPageInit;

	private bool isAccountPageInit;

	private bool isSetOrderPageInit;

	private ssorder_customerClass.deepClass selectedCustomer;

	private Form ProductDiag;

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p1")]
	internal virtual DoubleBufferPanel p1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel68")]
	internal virtual DoubleBufferPanel Panel68
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button158
	{
		[CompilerGenerated]
		get
		{
			return _Button158;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button158_Click;
			Button button = _Button158;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button158 = value;
			button = _Button158;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label90")]
	internal virtual Label Label90
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox order_account
	{
		[CompilerGenerated]
		get
		{
			return _order_account;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = order_account_KeyDown;
			TextBox textBox = _order_account;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_order_account = value;
			textBox = _order_account;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label87")]
	internal virtual Label Label87
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBoxEx order_status
	{
		[CompilerGenerated]
		get
		{
			return _order_status;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = order_account_KeyDown;
			ComboBoxEx comboBoxEx = _order_status;
			if (comboBoxEx != null)
			{
				comboBoxEx.KeyDown -= value2;
			}
			_order_status = value;
			comboBoxEx = _order_status;
			if (comboBoxEx != null)
			{
				comboBoxEx.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label81")]
	internal virtual Label Label81
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label82")]
	internal virtual Label Label82
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel69")]
	internal virtual DoubleBufferPanel Panel69
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel70")]
	internal virtual DoubleBufferPanel Panel70
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel71")]
	internal virtual DoubleBufferPanel Panel71
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel72")]
	internal virtual DoubleBufferPanel Panel72
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button77
	{
		[CompilerGenerated]
		get
		{
			return _Button77;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button77_Click;
			Button button = _Button77;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button77 = value;
			button = _Button77;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("diag_address")]
	internal virtual DoubleBufferPanel diag_address
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel163")]
	internal virtual DoubleBufferPanel Panel163
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label126")]
	internal virtual Label Label126
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button diag_searchMove
	{
		[CompilerGenerated]
		get
		{
			return _diag_searchMove;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = diag_searchMove_Click;
			Button button = _diag_searchMove;
			if (button != null)
			{
				button.Click -= value2;
			}
			_diag_searchMove = value;
			button = _diag_searchMove;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel99")]
	internal virtual DoubleBufferPanel Panel99
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button122
	{
		[CompilerGenerated]
		get
		{
			return _Button122;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button122_Click;
			Button button = _Button122;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button122 = value;
			button = _Button122;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel120")]
	internal virtual DoubleBufferPanel Panel120
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox13
	{
		[CompilerGenerated]
		get
		{
			return _TextBox13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox13_KeyDown;
			TextBox textBox = _TextBox13;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox13 = value;
			textBox = _TextBox13;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel101")]
	internal virtual DoubleBufferPanel Panel101
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DoubleBufferPanel Panel100
	{
		[CompilerGenerated]
		get
		{
			return _Panel100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel100_MouseDown;
			DoubleBufferPanel panel = _Panel100;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel100 = value;
			panel = _Panel100;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox17")]
	internal virtual PictureBox PictureBox17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label31
	{
		[CompilerGenerated]
		get
		{
			return _Label31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel100_MouseDown;
			Label label = _Label31;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label31 = value;
			label = _Label31;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	internal virtual Button Button104
	{
		[CompilerGenerated]
		get
		{
			return _Button104;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button104_Click;
			Button button = _Button104;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button104 = value;
			button = _Button104;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Label Label51
	{
		[CompilerGenerated]
		get
		{
			return _Label51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel100_MouseDown;
			Label label = _Label51;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label51 = value;
			label = _Label51;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	internal virtual DataGridView orderGrid
	{
		[CompilerGenerated]
		get
		{
			return _orderGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = orderGrid_CellContentClick;
			DataGridViewCellEventHandler value3 = orderGrid_CellDoubleClick;
			DataGridView dataGridView = _orderGrid;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_orderGrid = value;
			dataGridView = _orderGrid;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DateTimePicker2")]
	internal virtual DateTimePicker DateTimePicker2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox order_phone
	{
		[CompilerGenerated]
		get
		{
			return _order_phone;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = order_account_KeyDown;
			TextBox textBox = _order_phone;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_order_phone = value;
			textBox = _order_phone;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox order_customer
	{
		[CompilerGenerated]
		get
		{
			return _order_customer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = order_account_KeyDown;
			TextBox textBox = _order_customer;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_order_customer = value;
			textBox = _order_customer;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button2_Click;
			Button button = _Button2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button4_Click;
			Button button = _Button4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button5_Click;
			Button button = _Button5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage5")]
	internal virtual TabPage TabPage5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button7_Click;
			Button button = _Button7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p2")]
	internal virtual DoubleBufferPanel p2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView customerGrid
	{
		[CompilerGenerated]
		get
		{
			return _customerGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = customerGrid_CellDoubleClick;
			DataGridViewCellEventHandler value3 = DataGridView1_CellContentClick;
			DataGridView dataGridView = _customerGrid;
			if (dataGridView != null)
			{
				dataGridView.CellDoubleClick -= value2;
				dataGridView.CellContentClick -= value3;
			}
			_customerGrid = value;
			dataGridView = _customerGrid;
			if (dataGridView != null)
			{
				dataGridView.CellDoubleClick += value2;
				dataGridView.CellContentClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel2")]
	internal virtual DoubleBufferPanel DoubleBufferPanel2
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox customer_name
	{
		[CompilerGenerated]
		get
		{
			return _customer_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = customer_code_KeyDown;
			TextBox textBox = _customer_name;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_customer_name = value;
			textBox = _customer_name;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button8_Click;
			Button button = _Button8;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button8 = value;
			button = _Button8;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel3")]
	internal virtual DoubleBufferPanel DoubleBufferPanel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel4")]
	internal virtual DoubleBufferPanel DoubleBufferPanel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel5")]
	internal virtual DoubleBufferPanel DoubleBufferPanel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel6")]
	internal virtual DoubleBufferPanel DoubleBufferPanel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button16
	{
		[CompilerGenerated]
		get
		{
			return _Button16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button16_Click;
			Button button = _Button16;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button16 = value;
			button = _Button16;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button18
	{
		[CompilerGenerated]
		get
		{
			return _Button18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button18_Click;
			Button button = _Button18;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button18 = value;
			button = _Button18;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button20
	{
		[CompilerGenerated]
		get
		{
			return _Button20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button20_Click;
			Button button = _Button20;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button20 = value;
			button = _Button20;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox customer_code
	{
		[CompilerGenerated]
		get
		{
			return _customer_code;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = customer_code_KeyDown;
			TextBox textBox = _customer_code;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_customer_code = value;
			textBox = _customer_code;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	internal virtual Button Button9
	{
		[CompilerGenerated]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button9_Click;
			Button button = _Button9;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button9 = value;
			button = _Button9;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel1")]
	internal virtual DoubleBufferPanel DoubleBufferPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rb_road")]
	internal virtual RadioButton rb_road
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rb_dong")]
	internal virtual RadioButton rb_dong
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox CheckBox1
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox1_CheckedChanged;
			CheckBox checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox1 = value;
			checkBox = _CheckBox1;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView addressGrid
	{
		[CompilerGenerated]
		get
		{
			return _addressGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = addressGrid_CellClick;
			DataGridView dataGridView = _addressGrid;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
			}
			_addressGrid = value;
			dataGridView = _addressGrid;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Column12")]
	internal virtual DataGridViewTextBoxColumn Column12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn6")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn7")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox customer_phone
	{
		[CompilerGenerated]
		get
		{
			return _customer_phone;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = customer_code_KeyDown;
			TextBox textBox = _customer_phone;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_customer_phone = value;
			textBox = _customer_phone;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p3")]
	internal virtual DoubleBufferPanel p3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView productGrid
	{
		[CompilerGenerated]
		get
		{
			return _productGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = productGrid_CellDoubleClick;
			DataGridViewCellEventHandler value3 = productGrid_CellClick;
			DataGridViewCellEventHandler value4 = productGrid_CellContentClick_1;
			DataGridView dataGridView = _productGrid;
			if (dataGridView != null)
			{
				dataGridView.CellDoubleClick -= value2;
				dataGridView.CellClick -= value3;
				dataGridView.CellContentClick -= value4;
			}
			_productGrid = value;
			dataGridView = _productGrid;
			if (dataGridView != null)
			{
				dataGridView.CellDoubleClick += value2;
				dataGridView.CellClick += value3;
				dataGridView.CellContentClick += value4;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel8")]
	internal virtual DoubleBufferPanel DoubleBufferPanel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("product_gb")]
	internal virtual ComboBoxEx product_gb
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("product_team")]
	internal virtual ComboBoxEx product_team
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox product_code
	{
		[CompilerGenerated]
		get
		{
			return _product_code;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = product_code_KeyDown;
			TextBox textBox = _product_code;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_product_code = value;
			textBox = _product_code;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox product_name
	{
		[CompilerGenerated]
		get
		{
			return _product_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = product_code_KeyDown;
			TextBox textBox = _product_name;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_product_name = value;
			textBox = _product_name;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	internal virtual Button Button10
	{
		[CompilerGenerated]
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button10_Click;
			Button button = _Button10;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button10 = value;
			button = _Button10;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button11
	{
		[CompilerGenerated]
		get
		{
			return _Button11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button11_Click;
			Button button = _Button11;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button11 = value;
			button = _Button11;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel9")]
	internal virtual DoubleBufferPanel DoubleBufferPanel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel10")]
	internal virtual DoubleBufferPanel DoubleBufferPanel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel11")]
	internal virtual DoubleBufferPanel DoubleBufferPanel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel12")]
	internal virtual DoubleBufferPanel DoubleBufferPanel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button12
	{
		[CompilerGenerated]
		get
		{
			return _Button12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button12_Click;
			Button button = _Button12;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button12 = value;
			button = _Button12;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button13
	{
		[CompilerGenerated]
		get
		{
			return _Button13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button13_Click;
			Button button = _Button13;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button13 = value;
			button = _Button13;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button14
	{
		[CompilerGenerated]
		get
		{
			return _Button14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button14_Click;
			Button button = _Button14;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button14 = value;
			button = _Button14;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button15
	{
		[CompilerGenerated]
		get
		{
			return _Button15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button15_Click;
			Button button = _Button15;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button15 = value;
			button = _Button15;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button17
	{
		[CompilerGenerated]
		get
		{
			return _Button17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button17_Click;
			Button button = _Button17;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button17 = value;
			button = _Button17;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p4")]
	internal virtual DoubleBufferPanel p4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView accountGrid
	{
		[CompilerGenerated]
		get
		{
			return _accountGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = accountGrid_CellClick;
			DataGridViewCellEventHandler value3 = accountGrid_CellDoubleClick;
			DataGridViewCellEventHandler value4 = accountGrid_CellContentClick;
			DataGridView dataGridView = _accountGrid;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
				dataGridView.CellDoubleClick -= value3;
				dataGridView.CellContentClick -= value4;
			}
			_accountGrid = value;
			dataGridView = _accountGrid;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
				dataGridView.CellDoubleClick += value3;
				dataGridView.CellContentClick += value4;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel13")]
	internal virtual DoubleBufferPanel DoubleBufferPanel13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("acc_teamgb")]
	internal virtual ComboBoxEx acc_teamgb
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("acc_gb")]
	internal virtual ComboBoxEx acc_gb
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox acc_id
	{
		[CompilerGenerated]
		get
		{
			return _acc_id;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = acc_index_KeyDown;
			TextBox textBox = _acc_id;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_acc_id = value;
			textBox = _acc_id;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox acc_name
	{
		[CompilerGenerated]
		get
		{
			return _acc_name;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = acc_index_KeyDown;
			TextBox textBox = _acc_name;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_acc_name = value;
			textBox = _acc_name;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	internal virtual Button Button19
	{
		[CompilerGenerated]
		get
		{
			return _Button19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button19_Click;
			Button button = _Button19;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button19 = value;
			button = _Button19;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button21
	{
		[CompilerGenerated]
		get
		{
			return _Button21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button21_Click;
			Button button = _Button21;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button21 = value;
			button = _Button21;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel14")]
	internal virtual DoubleBufferPanel DoubleBufferPanel14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel15")]
	internal virtual DoubleBufferPanel DoubleBufferPanel15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel16")]
	internal virtual DoubleBufferPanel DoubleBufferPanel16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel17")]
	internal virtual DoubleBufferPanel DoubleBufferPanel17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button24
	{
		[CompilerGenerated]
		get
		{
			return _Button24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button24_Click;
			Button button = _Button24;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button24 = value;
			button = _Button24;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button25
	{
		[CompilerGenerated]
		get
		{
			return _Button25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button25_Click;
			Button button = _Button25;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button25 = value;
			button = _Button25;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button26
	{
		[CompilerGenerated]
		get
		{
			return _Button26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button26_Click;
			Button button = _Button26;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button26 = value;
			button = _Button26;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button27
	{
		[CompilerGenerated]
		get
		{
			return _Button27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button27_Click;
			Button button = _Button27;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button27 = value;
			button = _Button27;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox acc_index
	{
		[CompilerGenerated]
		get
		{
			return _acc_index;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = acc_index_KeyDown;
			TextBox textBox = _acc_index;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_acc_index = value;
			textBox = _acc_index;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("diag_orderList")]
	internal virtual DoubleBufferPanel diag_orderList
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgv_orderList
	{
		[CompilerGenerated]
		get
		{
			return _dgv_orderList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = dgv_orderList_CellContentClick;
			DataGridView dataGridView = _dgv_orderList;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick -= value2;
			}
			_dgv_orderList = value;
			dataGridView = _dgv_orderList;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel22")]
	internal virtual DoubleBufferPanel DoubleBufferPanel22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DoubleBufferPanel DoubleBufferPanel23
	{
		[CompilerGenerated]
		get
		{
			return _DoubleBufferPanel23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DoubleBufferPanel23_MouseDown;
			DoubleBufferPanel doubleBufferPanel = _DoubleBufferPanel23;
			if (doubleBufferPanel != null)
			{
				doubleBufferPanel.MouseDown -= value2;
			}
			_DoubleBufferPanel23 = value;
			doubleBufferPanel = _DoubleBufferPanel23;
			if (doubleBufferPanel != null)
			{
				doubleBufferPanel.MouseDown += value2;
			}
		}
	}

	internal virtual Label Label27
	{
		[CompilerGenerated]
		get
		{
			return _Label27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DoubleBufferPanel23_MouseDown;
			Label label = _Label27;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label27 = value;
			label = _Label27;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	internal virtual Button Button29
	{
		[CompilerGenerated]
		get
		{
			return _Button29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button29_Click;
			KeyEventHandler value3 = Button29_KeyDown;
			Button button = _Button29;
			if (button != null)
			{
				button.Click -= value2;
				button.KeyDown -= value3;
			}
			_Button29 = value;
			button = _Button29;
			if (button != null)
			{
				button.Click += value2;
				button.KeyDown += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DataGridViewCheckBoxColumn1")]
	internal virtual DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column20")]
	internal virtual DataGridViewTextBoxColumn Column20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column18")]
	internal virtual DataGridViewTextBoxColumn Column18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	internal virtual DataGridViewButtonColumn DataGridViewTextBoxColumn4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage6")]
	internal virtual TabPage TabPage6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button23
	{
		[CompilerGenerated]
		get
		{
			return _Button23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button23_Click;
			Button button = _Button23;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button23 = value;
			button = _Button23;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button22
	{
		[CompilerGenerated]
		get
		{
			return _Button22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button22_Click;
			Button button = _Button22;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button22 = value;
			button = _Button22;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_lb5")]
	internal virtual Label order_lb5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_lb4")]
	internal virtual Label order_lb4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_lb3")]
	internal virtual Label order_lb3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_lb2")]
	internal virtual Label order_lb2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pHome")]
	internal virtual DoubleBufferPanel pHome
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ImageList1")]
	internal virtual ImageList ImageList1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_lb1")]
	internal virtual Label order_lb1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button28
	{
		[CompilerGenerated]
		get
		{
			return _Button28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button77_Click;
			Button button = _Button28;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button28 = value;
			button = _Button28;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel18")]
	internal virtual DoubleBufferPanel DoubleBufferPanel18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage7")]
	internal virtual TabPage TabPage7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p5")]
	internal virtual DoubleBufferPanel p5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox8
	{
		[CompilerGenerated]
		get
		{
			return _TextBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox8_KeyUp;
			TextBox textBox = _TextBox8;
			if (textBox != null)
			{
				textBox.KeyUp -= value2;
			}
			_TextBox8 = value;
			textBox = _TextBox8;
			if (textBox != null)
			{
				textBox.KeyUp += value2;
			}
		}
	}

	[field: AccessedThroughProperty("orderProductGrid")]
	internal virtual DataGridView orderProductGrid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label35")]
	internal virtual Label Label35
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_etc")]
	internal virtual TextBox order_etc
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label34")]
	internal virtual Label Label34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox CheckBox4
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = delegate(object a0, EventArgs a1)
			{
				CheckBox4_CheckedChanged((CheckBox)a0, a1);
			};
			EventHandler value3 = CheckBox4_CheckedChanged;
			CheckBox checkBox = _CheckBox4;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
				checkBox.CheckedChanged -= value3;
			}
			_CheckBox4 = value;
			checkBox = _CheckBox4;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
				checkBox.CheckedChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label32")]
	internal virtual Label Label32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_address_more")]
	internal virtual TextBox order_address_more
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_address")]
	internal virtual TextBox order_address
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button32
	{
		[CompilerGenerated]
		get
		{
			return _Button32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button32_Click;
			Button button = _Button32;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button32 = value;
			button = _Button32;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label33")]
	internal virtual Label Label33
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label30")]
	internal virtual Label Label30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_delivery_more")]
	internal virtual TextBox order_delivery_more
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_delivery")]
	internal virtual TextBox order_delivery
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button31
	{
		[CompilerGenerated]
		get
		{
			return _Button31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button31_Click;
			Button button = _Button31;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button31 = value;
			button = _Button31;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label29")]
	internal virtual Label Label29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox3")]
	internal virtual CheckBox CheckBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label28")]
	internal virtual Label Label28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label26")]
	internal virtual Label Label26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("order_name")]
	internal virtual TextBox order_name
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button30
	{
		[CompilerGenerated]
		get
		{
			return _Button30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button30_Click;
			Button button = _Button30;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button30 = value;
			button = _Button30;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox order_phone3
	{
		[CompilerGenerated]
		get
		{
			return _order_phone3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = order_phone1_TextChanged;
			TextBox textBox = _order_phone3;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_order_phone3 = value;
			textBox = _order_phone3;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	internal virtual TextBox order_phone2
	{
		[CompilerGenerated]
		get
		{
			return _order_phone2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = order_phone1_TextChanged;
			TextBox textBox = _order_phone2;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_order_phone2 = value;
			textBox = _order_phone2;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	internal virtual TextBox order_phone1
	{
		[CompilerGenerated]
		get
		{
			return _order_phone1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = order_phone1_TextChanged;
			TextBox textBox = _order_phone1;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_order_phone1 = value;
			textBox = _order_phone1;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label40")]
	internal virtual Label Label40
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label41")]
	internal virtual Label Label41
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox order_call3
	{
		[CompilerGenerated]
		get
		{
			return _order_call3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = order_call1_TextChanged;
			TextBox textBox = _order_call3;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_order_call3 = value;
			textBox = _order_call3;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	internal virtual TextBox order_call2
	{
		[CompilerGenerated]
		get
		{
			return _order_call2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = order_call1_TextChanged;
			TextBox textBox = _order_call2;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_order_call2 = value;
			textBox = _order_call2;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	internal virtual TextBox order_call1
	{
		[CompilerGenerated]
		get
		{
			return _order_call1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = order_call1_TextChanged;
			TextBox textBox = _order_call1;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_order_call1 = value;
			textBox = _order_call1;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label37")]
	internal virtual Label Label37
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label36")]
	internal virtual Label Label36
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel7")]
	internal virtual DoubleBufferPanel DoubleBufferPanel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button41
	{
		[CompilerGenerated]
		get
		{
			return _Button41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button41_Click;
			Button button = _Button41;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button41 = value;
			button = _Button41;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button39
	{
		[CompilerGenerated]
		get
		{
			return _Button39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button39_Click;
			Button button = _Button39;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button39 = value;
			button = _Button39;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel19")]
	internal virtual DoubleBufferPanel DoubleBufferPanel19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewCheckBoxColumn4")]
	internal virtual DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn4")]
	internal virtual DataGridViewTextBoxColumn DataGridViewComboBoxColumn4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn19")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn20")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn21")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label42")]
	internal virtual Label Label42
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button33
	{
		[CompilerGenerated]
		get
		{
			return _Button33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button33_Click_1;
			Button button = _Button33;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button33 = value;
			button = _Button33;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel24")]
	internal virtual DoubleBufferPanel DoubleBufferPanel24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel25")]
	internal virtual DoubleBufferPanel DoubleBufferPanel25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel20")]
	internal virtual DoubleBufferPanel DoubleBufferPanel20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel21")]
	internal virtual DoubleBufferPanel DoubleBufferPanel21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button36
	{
		[CompilerGenerated]
		get
		{
			return _Button36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button36_Click;
			Button button = _Button36;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button36 = value;
			button = _Button36;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("diag_customer")]
	internal virtual DoubleBufferPanel diag_customer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgv_customer
	{
		[CompilerGenerated]
		get
		{
			return _dgv_customer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = dgv_customer_CellClick;
			DataGridView dataGridView = _dgv_customer;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
			}
			_dgv_customer = value;
			dataGridView = _dgv_customer;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel27")]
	internal virtual DoubleBufferPanel DoubleBufferPanel27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DoubleBufferPanel DoubleBufferPanel28
	{
		[CompilerGenerated]
		get
		{
			return _DoubleBufferPanel28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DoubleBufferPanel28_MouseDown;
			DoubleBufferPanel doubleBufferPanel = _DoubleBufferPanel28;
			if (doubleBufferPanel != null)
			{
				doubleBufferPanel.MouseDown -= value2;
			}
			_DoubleBufferPanel28 = value;
			doubleBufferPanel = _DoubleBufferPanel28;
			if (doubleBufferPanel != null)
			{
				doubleBufferPanel.MouseDown += value2;
			}
		}
	}

	internal virtual Label Label43
	{
		[CompilerGenerated]
		get
		{
			return _Label43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = DoubleBufferPanel28_MouseDown;
			Label label = _Label43;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label43 = value;
			label = _Label43;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	internal virtual Button Button37
	{
		[CompilerGenerated]
		get
		{
			return _Button37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button37_Click;
			Button button = _Button37;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button37 = value;
			button = _Button37;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Column21")]
	internal virtual DataGridViewTextBoxColumn Column21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn23")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn24")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn25")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewButtonColumn2")]
	internal virtual DataGridViewTextBoxColumn DataGridViewButtonColumn2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox1_KeyDown;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	internal virtual Button Button38
	{
		[CompilerGenerated]
		get
		{
			return _Button38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button30_Click;
			Button button = _Button38;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button38 = value;
			button = _Button38;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual CheckBox CheckBox5
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox5_CheckedChanged;
			CheckBox checkBox = _CheckBox5;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox5 = value;
			checkBox = _CheckBox5;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	internal virtual Button Button40
	{
		[CompilerGenerated]
		get
		{
			return _Button40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button40_Click;
			Button button = _Button40;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button40 = value;
			button = _Button40;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p3_centerpanel")]
	internal virtual DoubleBufferPanel p3_centerpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button35
	{
		[CompilerGenerated]
		get
		{
			return _Button35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button35_Click;
			Button button = _Button35;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button35 = value;
			button = _Button35;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button34
	{
		[CompilerGenerated]
		get
		{
			return _Button34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button34_Click;
			Button button = _Button34;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button34 = value;
			button = _Button34;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DataGridViewCheckBoxColumn2")]
	internal virtual DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn8")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn9")]
	internal virtual DataGridViewComboBoxColumn DataGridViewTextBoxColumn9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn10")]
	internal virtual DataGridViewComboBoxColumn DataGridViewTextBoxColumn10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewButtonColumn1")]
	internal virtual DataGridViewTextBoxColumn DataGridViewButtonColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column13")]
	internal virtual DataGridViewTextBoxColumn Column13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column14")]
	internal virtual DataGridViewTextBoxColumn Column14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button42
	{
		[CompilerGenerated]
		get
		{
			return _Button42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button42_Click;
			Button button = _Button42;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button42 = value;
			button = _Button42;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button43
	{
		[CompilerGenerated]
		get
		{
			return _Button43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button43_Click;
			Button button = _Button43;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button43 = value;
			button = _Button43;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label38")]
	internal virtual Label Label38
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("customer_call")]
	internal virtual TextBox customer_call
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column10")]
	internal virtual DataGridViewCheckBoxColumn Column10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column22")]
	internal virtual DataGridViewTextBoxColumn Column22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column11")]
	internal virtual DataGridViewTextBoxColumn Column11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column4")]
	internal virtual DataGridViewTextBoxColumn Column4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column16")]
	internal virtual DataGridViewTextBoxColumn Column16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewButtonColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column19")]
	internal virtual DataGridViewButtonColumn Column19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column3")]
	internal virtual DataGridViewButtonColumn Column3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column5")]
	internal virtual DataGridViewButtonColumn Column5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column6")]
	internal virtual DataGridViewButtonColumn Column6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column8")]
	internal virtual DataGridViewTextBoxColumn Column8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column9")]
	internal virtual DataGridViewTextBoxColumn Column9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column15")]
	internal virtual DataGridViewTextBoxColumn Column15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column17")]
	internal virtual DataGridViewTextBoxColumn Column17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn16")]
	internal virtual DataGridViewButtonColumn DataGridViewTextBoxColumn16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn17")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn18")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column7")]
	internal virtual DataGridViewTextBoxColumn Column7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p4_centerpanel")]
	internal virtual DoubleBufferPanel p4_centerpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button44
	{
		[CompilerGenerated]
		get
		{
			return _Button44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button44_Click;
			Button button = _Button44;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button44 = value;
			button = _Button44;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button45
	{
		[CompilerGenerated]
		get
		{
			return _Button45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button45_Click;
			Button button = _Button45;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button45 = value;
			button = _Button45;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DataGridViewCheckBoxColumn3")]
	internal virtual DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn11")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn1")]
	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewComboBoxColumn2")]
	internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn12")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn13")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn14")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column23")]
	internal virtual DataGridViewTextBoxColumn Column23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public android_db_ss_order()
	{
		busy = false;
		isOrderPageInit = false;
		failCount = 0;
		searchBoolean = false;
		isProductPageInit = false;
		isAccountPageInit = false;
		isSetOrderPageInit = false;
		selectedCustomer = null;
		ProductDiag = new Form();
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
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.android_db_ss_order));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage6 = new System.Windows.Forms.TabPage();
		this.pHome = new mlas_root.DoubleBufferPanel();
		this.Label24 = new System.Windows.Forms.Label();
		this.Button23 = new System.Windows.Forms.Button();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.Panel9 = new System.Windows.Forms.Panel();
		this.order_lb5 = new System.Windows.Forms.Label();
		this.order_lb4 = new System.Windows.Forms.Label();
		this.order_lb3 = new System.Windows.Forms.Label();
		this.order_lb2 = new System.Windows.Forms.Label();
		this.order_lb1 = new System.Windows.Forms.Label();
		this.Label22 = new System.Windows.Forms.Label();
		this.Button22 = new System.Windows.Forms.Button();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.p1 = new mlas_root.DoubleBufferPanel();
		this.orderGrid = new System.Windows.Forms.DataGridView();
		this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
		this.Column19 = new System.Windows.Forms.DataGridViewButtonColumn();
		this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
		this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
		this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
		this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DoubleBufferPanel18 = new mlas_root.DoubleBufferPanel();
		this.Button28 = new System.Windows.Forms.Button();
		this.Label23 = new System.Windows.Forms.Label();
		this.Panel68 = new mlas_root.DoubleBufferPanel();
		this.Button7 = new System.Windows.Forms.Button();
		this.Label2 = new System.Windows.Forms.Label();
		this.order_phone = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.order_customer = new System.Windows.Forms.TextBox();
		this.Button77 = new System.Windows.Forms.Button();
		this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
		this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.Button158 = new System.Windows.Forms.Button();
		this.Label90 = new System.Windows.Forms.Label();
		this.order_account = new System.Windows.Forms.TextBox();
		this.Label87 = new System.Windows.Forms.Label();
		this.order_status = new mlas_root.ComboBoxEx();
		this.Label81 = new System.Windows.Forms.Label();
		this.Label82 = new System.Windows.Forms.Label();
		this.Panel69 = new mlas_root.DoubleBufferPanel();
		this.Panel70 = new mlas_root.DoubleBufferPanel();
		this.Panel71 = new mlas_root.DoubleBufferPanel();
		this.Panel72 = new mlas_root.DoubleBufferPanel();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button42 = new System.Windows.Forms.Button();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Button40 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.p2 = new mlas_root.DoubleBufferPanel();
		this.customerGrid = new System.Windows.Forms.DataGridView();
		this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
		this.DoubleBufferPanel2 = new mlas_root.DoubleBufferPanel();
		this.Label38 = new System.Windows.Forms.Label();
		this.customer_call = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.customer_code = new System.Windows.Forms.TextBox();
		this.Button6 = new System.Windows.Forms.Button();
		this.Label3 = new System.Windows.Forms.Label();
		this.customer_phone = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.customer_name = new System.Windows.Forms.TextBox();
		this.Button8 = new System.Windows.Forms.Button();
		this.Label8 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel3 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel4 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel5 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel6 = new mlas_root.DoubleBufferPanel();
		this.Button18 = new System.Windows.Forms.Button();
		this.Button9 = new System.Windows.Forms.Button();
		this.Button16 = new System.Windows.Forms.Button();
		this.Button20 = new System.Windows.Forms.Button();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.p3 = new mlas_root.DoubleBufferPanel();
		this.p3_centerpanel = new mlas_root.DoubleBufferPanel();
		this.productGrid = new System.Windows.Forms.DataGridView();
		this.DataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.DataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DoubleBufferPanel8 = new mlas_root.DoubleBufferPanel();
		this.Label15 = new System.Windows.Forms.Label();
		this.product_gb = new mlas_root.ComboBoxEx();
		this.Label14 = new System.Windows.Forms.Label();
		this.product_team = new mlas_root.ComboBoxEx();
		this.Label16 = new System.Windows.Forms.Label();
		this.product_code = new System.Windows.Forms.TextBox();
		this.Label17 = new System.Windows.Forms.Label();
		this.product_name = new System.Windows.Forms.TextBox();
		this.Button10 = new System.Windows.Forms.Button();
		this.Button11 = new System.Windows.Forms.Button();
		this.Label13 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel9 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel10 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel11 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel12 = new mlas_root.DoubleBufferPanel();
		this.Button14 = new System.Windows.Forms.Button();
		this.Button17 = new System.Windows.Forms.Button();
		this.Button12 = new System.Windows.Forms.Button();
		this.Button13 = new System.Windows.Forms.Button();
		this.Button15 = new System.Windows.Forms.Button();
		this.TabPage5 = new System.Windows.Forms.TabPage();
		this.p4 = new mlas_root.DoubleBufferPanel();
		this.p4_centerpanel = new mlas_root.DoubleBufferPanel();
		this.accountGrid = new System.Windows.Forms.DataGridView();
		this.DataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.DataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.DataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DoubleBufferPanel13 = new mlas_root.DoubleBufferPanel();
		this.Label20 = new System.Windows.Forms.Label();
		this.acc_index = new System.Windows.Forms.TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.acc_teamgb = new mlas_root.ComboBoxEx();
		this.Label11 = new System.Windows.Forms.Label();
		this.acc_gb = new mlas_root.ComboBoxEx();
		this.Label12 = new System.Windows.Forms.Label();
		this.acc_id = new System.Windows.Forms.TextBox();
		this.Label18 = new System.Windows.Forms.Label();
		this.acc_name = new System.Windows.Forms.TextBox();
		this.Button19 = new System.Windows.Forms.Button();
		this.Button21 = new System.Windows.Forms.Button();
		this.Label19 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel14 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel15 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel16 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel17 = new mlas_root.DoubleBufferPanel();
		this.Button26 = new System.Windows.Forms.Button();
		this.Button24 = new System.Windows.Forms.Button();
		this.Button25 = new System.Windows.Forms.Button();
		this.Button27 = new System.Windows.Forms.Button();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.diag_orderList = new mlas_root.DoubleBufferPanel();
		this.dgv_orderList = new System.Windows.Forms.DataGridView();
		this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewButtonColumn();
		this.DataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DoubleBufferPanel22 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel23 = new mlas_root.DoubleBufferPanel();
		this.Button35 = new System.Windows.Forms.Button();
		this.Button34 = new System.Windows.Forms.Button();
		this.Label27 = new System.Windows.Forms.Label();
		this.Button29 = new System.Windows.Forms.Button();
		this.diag_customer = new mlas_root.DoubleBufferPanel();
		this.dgv_customer = new System.Windows.Forms.DataGridView();
		this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DoubleBufferPanel27 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel28 = new mlas_root.DoubleBufferPanel();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button38 = new System.Windows.Forms.Button();
		this.Label43 = new System.Windows.Forms.Label();
		this.Button37 = new System.Windows.Forms.Button();
		this.diag_address = new mlas_root.DoubleBufferPanel();
		this.addressGrid = new System.Windows.Forms.DataGridView();
		this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel163 = new mlas_root.DoubleBufferPanel();
		this.Label9 = new System.Windows.Forms.Label();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel1 = new mlas_root.DoubleBufferPanel();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label126 = new System.Windows.Forms.Label();
		this.diag_searchMove = new System.Windows.Forms.Button();
		this.Panel99 = new mlas_root.DoubleBufferPanel();
		this.Label21 = new System.Windows.Forms.Label();
		this.rb_road = new System.Windows.Forms.RadioButton();
		this.rb_dong = new System.Windows.Forms.RadioButton();
		this.Button122 = new System.Windows.Forms.Button();
		this.Panel120 = new mlas_root.DoubleBufferPanel();
		this.TextBox13 = new System.Windows.Forms.TextBox();
		this.Panel101 = new mlas_root.DoubleBufferPanel();
		this.Panel100 = new mlas_root.DoubleBufferPanel();
		this.Button43 = new System.Windows.Forms.Button();
		this.PictureBox17 = new System.Windows.Forms.PictureBox();
		this.Label31 = new System.Windows.Forms.Label();
		this.Button104 = new System.Windows.Forms.Button();
		this.Label51 = new System.Windows.Forms.Label();
		this.TabPage7 = new System.Windows.Forms.TabPage();
		this.p5 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel24 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel25 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel20 = new mlas_root.DoubleBufferPanel();
		this.orderProductGrid = new System.Windows.Forms.DataGridView();
		this.DataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.DataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DoubleBufferPanel21 = new mlas_root.DoubleBufferPanel();
		this.CheckBox5 = new System.Windows.Forms.CheckBox();
		this.Button36 = new System.Windows.Forms.Button();
		this.Label42 = new System.Windows.Forms.Label();
		this.TextBox8 = new System.Windows.Forms.TextBox();
		this.Label35 = new System.Windows.Forms.Label();
		this.Button33 = new System.Windows.Forms.Button();
		this.DoubleBufferPanel19 = new mlas_root.DoubleBufferPanel();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Button44 = new System.Windows.Forms.Button();
		this.Button45 = new System.Windows.Forms.Button();
		this.Label40 = new System.Windows.Forms.Label();
		this.order_address = new System.Windows.Forms.TextBox();
		this.order_delivery = new System.Windows.Forms.TextBox();
		this.order_name = new System.Windows.Forms.TextBox();
		this.Label25 = new System.Windows.Forms.Label();
		this.Label36 = new System.Windows.Forms.Label();
		this.order_phone3 = new System.Windows.Forms.TextBox();
		this.Label37 = new System.Windows.Forms.Label();
		this.order_phone2 = new System.Windows.Forms.TextBox();
		this.Button30 = new System.Windows.Forms.Button();
		this.order_phone1 = new System.Windows.Forms.TextBox();
		this.Label26 = new System.Windows.Forms.Label();
		this.Label41 = new System.Windows.Forms.Label();
		this.Label28 = new System.Windows.Forms.Label();
		this.order_call3 = new System.Windows.Forms.TextBox();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		this.order_call2 = new System.Windows.Forms.TextBox();
		this.CheckBox3 = new System.Windows.Forms.CheckBox();
		this.order_call1 = new System.Windows.Forms.TextBox();
		this.Label29 = new System.Windows.Forms.Label();
		this.Button31 = new System.Windows.Forms.Button();
		this.order_delivery_more = new System.Windows.Forms.TextBox();
		this.Label30 = new System.Windows.Forms.Label();
		this.order_etc = new System.Windows.Forms.TextBox();
		this.Label33 = new System.Windows.Forms.Label();
		this.Label34 = new System.Windows.Forms.Label();
		this.Button32 = new System.Windows.Forms.Button();
		this.CheckBox4 = new System.Windows.Forms.CheckBox();
		this.Label32 = new System.Windows.Forms.Label();
		this.order_address_more = new System.Windows.Forms.TextBox();
		this.DoubleBufferPanel7 = new mlas_root.DoubleBufferPanel();
		this.Button41 = new System.Windows.Forms.Button();
		this.Button39 = new System.Windows.Forms.Button();
		this.TabControl1.SuspendLayout();
		this.TabPage6.SuspendLayout();
		this.pHome.SuspendLayout();
		this.Panel9.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.p1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.orderGrid).BeginInit();
		this.DoubleBufferPanel18.SuspendLayout();
		this.Panel68.SuspendLayout();
		this.Panel72.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.p2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.customerGrid).BeginInit();
		this.DoubleBufferPanel2.SuspendLayout();
		this.DoubleBufferPanel6.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.p3.SuspendLayout();
		this.p3_centerpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.productGrid).BeginInit();
		this.DoubleBufferPanel8.SuspendLayout();
		this.DoubleBufferPanel12.SuspendLayout();
		this.TabPage5.SuspendLayout();
		this.p4.SuspendLayout();
		this.p4_centerpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.accountGrid).BeginInit();
		this.DoubleBufferPanel13.SuspendLayout();
		this.DoubleBufferPanel17.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.diag_orderList.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgv_orderList).BeginInit();
		this.DoubleBufferPanel23.SuspendLayout();
		this.diag_customer.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgv_customer).BeginInit();
		this.DoubleBufferPanel28.SuspendLayout();
		this.diag_address.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.addressGrid).BeginInit();
		this.Panel163.SuspendLayout();
		this.DoubleBufferPanel1.SuspendLayout();
		this.Panel99.SuspendLayout();
		this.Panel120.SuspendLayout();
		this.Panel100.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox17).BeginInit();
		this.TabPage7.SuspendLayout();
		this.p5.SuspendLayout();
		this.DoubleBufferPanel24.SuspendLayout();
		this.DoubleBufferPanel25.SuspendLayout();
		this.DoubleBufferPanel20.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.orderProductGrid).BeginInit();
		this.DoubleBufferPanel21.SuspendLayout();
		this.DoubleBufferPanel19.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.DoubleBufferPanel7.SuspendLayout();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage6);
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Controls.Add(this.TabPage5);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Controls.Add(this.TabPage7);
		this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabControl1.Location = new System.Drawing.Point(0, 0);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(1246, 834);
		this.TabControl1.TabIndex = 17;
		this.TabPage6.Controls.Add(this.pHome);
		this.TabPage6.Location = new System.Drawing.Point(4, 22);
		this.TabPage6.Name = "TabPage6";
		this.TabPage6.Size = new System.Drawing.Size(1238, 808);
		this.TabPage6.TabIndex = 13;
		this.TabPage6.Text = "메인";
		this.TabPage6.UseVisualStyleBackColor = true;
		this.pHome.Controls.Add(this.Label24);
		this.pHome.Controls.Add(this.Button23);
		this.pHome.Controls.Add(this.Panel9);
		this.pHome.Controls.Add(this.Button22);
		this.pHome.Dock = System.Windows.Forms.DockStyle.Fill;
		this.pHome.Location = new System.Drawing.Point(0, 0);
		this.pHome.Name = "pHome";
		this.pHome.Size = new System.Drawing.Size(1238, 808);
		this.pHome.TabIndex = 35;
		this.Label24.Font = new System.Drawing.Font("맑은 고딕", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label24.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label24.Location = new System.Drawing.Point(38, 26);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(189, 37);
		this.Label24.TabIndex = 32;
		this.Label24.Text = "성신 판매접수";
		this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button23.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.Button23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.Button23.FlatAppearance.BorderSize = 5;
		this.Button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.Button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button23.Font = new System.Drawing.Font("굴림", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Button23.ImageIndex = 1;
		this.Button23.ImageList = this.ImageList1;
		this.Button23.Location = new System.Drawing.Point(465, 197);
		this.Button23.Name = "Button23";
		this.Button23.Size = new System.Drawing.Size(414, 98);
		this.Button23.TabIndex = 34;
		this.Button23.Text = "조회";
		this.Button23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button23.UseVisualStyleBackColor = false;
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.White;
		this.ImageList1.Images.SetKeyName(0, "icon_info_circle_alt.png");
		this.ImageList1.Images.SetKeyName(1, "icon_ol.png");
		this.ImageList1.Images.SetKeyName(2, "icon_pencil_edit.png");
		this.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel9.Controls.Add(this.order_lb5);
		this.Panel9.Controls.Add(this.order_lb4);
		this.Panel9.Controls.Add(this.order_lb3);
		this.Panel9.Controls.Add(this.order_lb2);
		this.Panel9.Controls.Add(this.order_lb1);
		this.Panel9.Controls.Add(this.Label22);
		this.Panel9.Location = new System.Drawing.Point(38, 86);
		this.Panel9.Margin = new System.Windows.Forms.Padding(20, 10, 3, 3);
		this.Panel9.Name = "Panel9";
		this.Panel9.Padding = new System.Windows.Forms.Padding(10);
		this.Panel9.Size = new System.Drawing.Size(414, 209);
		this.Panel9.TabIndex = 32;
		this.order_lb5.Dock = System.Windows.Forms.DockStyle.Top;
		this.order_lb5.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_lb5.ForeColor = System.Drawing.Color.Black;
		this.order_lb5.Location = new System.Drawing.Point(10, 165);
		this.order_lb5.Name = "order_lb5";
		this.order_lb5.Size = new System.Drawing.Size(392, 30);
		this.order_lb5.TabIndex = 20;
		this.order_lb5.Text = "소속 구분 : ";
		this.order_lb5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.order_lb4.Dock = System.Windows.Forms.DockStyle.Top;
		this.order_lb4.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_lb4.ForeColor = System.Drawing.Color.Black;
		this.order_lb4.Location = new System.Drawing.Point(10, 135);
		this.order_lb4.Name = "order_lb4";
		this.order_lb4.Size = new System.Drawing.Size(392, 30);
		this.order_lb4.TabIndex = 12;
		this.order_lb4.Text = "계정 구분 : ";
		this.order_lb4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.order_lb3.Dock = System.Windows.Forms.DockStyle.Top;
		this.order_lb3.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_lb3.ForeColor = System.Drawing.Color.Black;
		this.order_lb3.Location = new System.Drawing.Point(10, 105);
		this.order_lb3.Name = "order_lb3";
		this.order_lb3.Size = new System.Drawing.Size(392, 30);
		this.order_lb3.TabIndex = 13;
		this.order_lb3.Text = "회원 번호 : ";
		this.order_lb3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.order_lb2.Dock = System.Windows.Forms.DockStyle.Top;
		this.order_lb2.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_lb2.ForeColor = System.Drawing.Color.Black;
		this.order_lb2.Location = new System.Drawing.Point(10, 75);
		this.order_lb2.Name = "order_lb2";
		this.order_lb2.Size = new System.Drawing.Size(392, 30);
		this.order_lb2.TabIndex = 6;
		this.order_lb2.Text = "서버 위치 : ";
		this.order_lb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.order_lb1.Dock = System.Windows.Forms.DockStyle.Top;
		this.order_lb1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_lb1.ForeColor = System.Drawing.Color.Black;
		this.order_lb1.Location = new System.Drawing.Point(10, 45);
		this.order_lb1.Name = "order_lb1";
		this.order_lb1.Size = new System.Drawing.Size(392, 30);
		this.order_lb1.TabIndex = 21;
		this.order_lb1.Text = "이름 : ";
		this.order_lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label22.AutoSize = true;
		this.Label22.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label22.Font = new System.Drawing.Font("맑은 고딕", 14.25f, System.Drawing.FontStyle.Bold);
		this.Label22.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label22.Location = new System.Drawing.Point(10, 10);
		this.Label22.Name = "Label22";
		this.Label22.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
		this.Label22.Size = new System.Drawing.Size(95, 35);
		this.Label22.TabIndex = 4;
		this.Label22.Text = "기본 정보";
		this.Button22.BackColor = System.Drawing.Color.FromArgb(255, 240, 0);
		this.Button22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 220, 0);
		this.Button22.FlatAppearance.BorderSize = 5;
		this.Button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 220, 0);
		this.Button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 240, 0);
		this.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button22.Font = new System.Drawing.Font("굴림", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Button22.ImageIndex = 2;
		this.Button22.ImageList = this.ImageList1;
		this.Button22.Location = new System.Drawing.Point(465, 86);
		this.Button22.Name = "Button22";
		this.Button22.Size = new System.Drawing.Size(414, 98);
		this.Button22.TabIndex = 33;
		this.Button22.Text = "주문접수";
		this.Button22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.Button22.UseVisualStyleBackColor = false;
		this.TabPage1.Controls.Add(this.p1);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new System.Drawing.Size(1238, 808);
		this.TabPage1.TabIndex = 9;
		this.TabPage1.Text = "주문 관리";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.p1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p1.Controls.Add(this.orderGrid);
		this.p1.Controls.Add(this.DoubleBufferPanel18);
		this.p1.Controls.Add(this.Panel68);
		this.p1.Controls.Add(this.Panel69);
		this.p1.Controls.Add(this.Panel70);
		this.p1.Controls.Add(this.Panel71);
		this.p1.Controls.Add(this.Panel72);
		this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p1.Location = new System.Drawing.Point(0, 0);
		this.p1.Name = "p1";
		this.p1.Size = new System.Drawing.Size(1238, 808);
		this.p1.TabIndex = 14;
		this.orderGrid.AllowUserToAddRows = false;
		this.orderGrid.AllowUserToDeleteRows = false;
		this.orderGrid.AllowUserToOrderColumns = true;
		this.orderGrid.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.orderGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.orderGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.orderGrid.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.Format = "C2";
		dataGridViewCellStyle2.NullValue = "0";
		dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.orderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.orderGrid.Columns.AddRange(this.Column10, this.Column22, this.Column11, this.Column4, this.Column16, this.Column2, this.Column19, this.Column3, this.Column5, this.Column6, this.Column8, this.Column9, this.Column15);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.orderGrid.DefaultCellStyle = dataGridViewCellStyle3;
		this.orderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.orderGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
		this.orderGrid.EnableHeadersVisualStyles = false;
		this.orderGrid.GridColor = System.Drawing.Color.DarkGray;
		this.orderGrid.Location = new System.Drawing.Point(23, 217);
		this.orderGrid.Name = "orderGrid";
		this.orderGrid.RowHeadersVisible = false;
		this.orderGrid.RowHeadersWidth = 40;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.orderGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
		this.orderGrid.RowTemplate.Height = 35;
		this.orderGrid.Size = new System.Drawing.Size(1192, 524);
		this.orderGrid.StandardTab = true;
		this.orderGrid.TabIndex = 56;
		this.Column10.Frozen = true;
		this.Column10.HeaderText = "";
		this.Column10.Name = "Column10";
		this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Column10.Width = 30;
		this.Column22.Frozen = true;
		this.Column22.HeaderText = "판매자명";
		this.Column22.Name = "Column22";
		this.Column22.ReadOnly = true;
		this.Column11.Frozen = true;
		this.Column11.HeaderText = "번호";
		this.Column11.Name = "Column11";
		this.Column11.ReadOnly = true;
		this.Column11.Width = 45;
		this.Column4.Frozen = true;
		this.Column4.HeaderText = "접수 일자";
		this.Column4.Name = "Column4";
		this.Column4.ReadOnly = true;
		this.Column4.Width = 140;
		this.Column16.Frozen = true;
		this.Column16.HeaderText = "비고";
		this.Column16.Name = "Column16";
		this.Column2.HeaderText = "고객명";
		this.Column2.Name = "Column2";
		this.Column2.ReadOnly = true;
		this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.Column2.Width = 60;
		this.Column19.HeaderText = "자택전화";
		this.Column19.Name = "Column19";
		this.Column19.ReadOnly = true;
		this.Column19.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.Column3.HeaderText = "휴대전화";
		this.Column3.Name = "Column3";
		this.Column3.ReadOnly = true;
		this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.Column3.Width = 90;
		this.Column5.HeaderText = "배송지주소";
		this.Column5.Name = "Column5";
		this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.Column5.Width = 140;
		this.Column6.HeaderText = "주문상세";
		this.Column6.Name = "Column6";
		this.Column6.ReadOnly = true;
		this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.Column6.Width = 140;
		dataGridViewCellStyle5.Format = "C0";
		dataGridViewCellStyle5.NullValue = "0";
		this.Column8.DefaultCellStyle = dataGridViewCellStyle5;
		this.Column8.HeaderText = "금액";
		this.Column8.Name = "Column8";
		this.Column8.ReadOnly = true;
		this.Column8.Width = 80;
		this.Column9.HeaderText = "접수상태";
		this.Column9.Name = "Column9";
		this.Column9.ReadOnly = true;
		this.Column9.Width = 70;
		this.Column15.HeaderText = "송장번호";
		this.Column15.Name = "Column15";
		this.DoubleBufferPanel18.Controls.Add(this.Button28);
		this.DoubleBufferPanel18.Controls.Add(this.Label23);
		this.DoubleBufferPanel18.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel18.Location = new System.Drawing.Point(23, 179);
		this.DoubleBufferPanel18.Name = "DoubleBufferPanel18";
		this.DoubleBufferPanel18.Size = new System.Drawing.Size(1192, 38);
		this.DoubleBufferPanel18.TabIndex = 58;
		this.DoubleBufferPanel18.Visible = false;
		this.Button28.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button28.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button28.ForeColor = System.Drawing.Color.White;
		this.Button28.Location = new System.Drawing.Point(6, 5);
		this.Button28.Name = "Button28";
		this.Button28.Size = new System.Drawing.Size(166, 28);
		this.Button28.TabIndex = 9;
		this.Button28.Text = "새로고침";
		this.Button28.UseVisualStyleBackColor = false;
		this.Button28.Visible = false;
		this.Label23.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label23.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label23.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label23.Location = new System.Drawing.Point(0, 0);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(1192, 38);
		this.Label23.TabIndex = 49;
		this.Label23.Text = "주문 관리 - 조회";
		this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Panel68.BackColor = System.Drawing.Color.Transparent;
		this.Panel68.Controls.Add(this.Button7);
		this.Panel68.Controls.Add(this.Label2);
		this.Panel68.Controls.Add(this.order_phone);
		this.Panel68.Controls.Add(this.Label1);
		this.Panel68.Controls.Add(this.order_customer);
		this.Panel68.Controls.Add(this.Button77);
		this.Panel68.Controls.Add(this.DateTimePicker2);
		this.Panel68.Controls.Add(this.DateTimePicker1);
		this.Panel68.Controls.Add(this.Button158);
		this.Panel68.Controls.Add(this.Label90);
		this.Panel68.Controls.Add(this.order_account);
		this.Panel68.Controls.Add(this.Label87);
		this.Panel68.Controls.Add(this.order_status);
		this.Panel68.Controls.Add(this.Label81);
		this.Panel68.Controls.Add(this.Label82);
		this.Panel68.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel68.Location = new System.Drawing.Point(23, 0);
		this.Panel68.Name = "Panel68";
		this.Panel68.Size = new System.Drawing.Size(1192, 179);
		this.Panel68.TabIndex = 54;
		this.Button7.BackColor = System.Drawing.Color.Fuchsia;
		this.Button7.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button7.ForeColor = System.Drawing.Color.White;
		this.Button7.Location = new System.Drawing.Point(496, 117);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(148, 23);
		this.Button7.TabIndex = 7;
		this.Button7.Text = "조건 초기화";
		this.Button7.UseVisualStyleBackColor = false;
		this.Label2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(9, 117);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(68, 24);
		this.Label2.TabIndex = 82;
		this.Label2.Text = "연락처";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.order_phone.BackColor = System.Drawing.Color.White;
		this.order_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_phone.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_phone.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_phone.Location = new System.Drawing.Point(84, 117);
		this.order_phone.Name = "order_phone";
		this.order_phone.Size = new System.Drawing.Size(406, 22);
		this.order_phone.TabIndex = 5;
		this.Label1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(9, 91);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(68, 24);
		this.Label1.TabIndex = 80;
		this.Label1.Text = "고객명";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.order_customer.BackColor = System.Drawing.Color.White;
		this.order_customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_customer.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_customer.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_customer.Location = new System.Drawing.Point(84, 91);
		this.order_customer.Name = "order_customer";
		this.order_customer.Size = new System.Drawing.Size(406, 22);
		this.order_customer.TabIndex = 4;
		this.Button77.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button77.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button77.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button77.ForeColor = System.Drawing.Color.White;
		this.Button77.Location = new System.Drawing.Point(496, 143);
		this.Button77.Name = "Button77";
		this.Button77.Size = new System.Drawing.Size(148, 23);
		this.Button77.TabIndex = 8;
		this.Button77.Text = "검색";
		this.Button77.UseVisualStyleBackColor = false;
		this.DateTimePicker2.Location = new System.Drawing.Point(290, 39);
		this.DateTimePicker2.Name = "DateTimePicker2";
		this.DateTimePicker2.Size = new System.Drawing.Size(200, 21);
		this.DateTimePicker2.TabIndex = 1;
		this.DateTimePicker1.Location = new System.Drawing.Point(84, 39);
		this.DateTimePicker1.Name = "DateTimePicker1";
		this.DateTimePicker1.Size = new System.Drawing.Size(200, 21);
		this.DateTimePicker1.TabIndex = 0;
		this.Button158.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button158.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button158.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button158.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button158.ForeColor = System.Drawing.Color.White;
		this.Button158.Location = new System.Drawing.Point(496, 38);
		this.Button158.Name = "Button158";
		this.Button158.Size = new System.Drawing.Size(148, 23);
		this.Button158.TabIndex = 2;
		this.Button158.Text = "오늘";
		this.Button158.UseVisualStyleBackColor = false;
		this.Label90.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label90.ForeColor = System.Drawing.Color.Black;
		this.Label90.Location = new System.Drawing.Point(9, 65);
		this.Label90.Name = "Label90";
		this.Label90.Size = new System.Drawing.Size(68, 24);
		this.Label90.TabIndex = 65;
		this.Label90.Text = "판매자";
		this.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.order_account.BackColor = System.Drawing.Color.White;
		this.order_account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_account.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_account.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_account.Location = new System.Drawing.Point(84, 65);
		this.order_account.Name = "order_account";
		this.order_account.Size = new System.Drawing.Size(406, 22);
		this.order_account.TabIndex = 3;
		this.Label87.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label87.ForeColor = System.Drawing.Color.Black;
		this.Label87.Location = new System.Drawing.Point(9, 143);
		this.Label87.Name = "Label87";
		this.Label87.Size = new System.Drawing.Size(68, 25);
		this.Label87.TabIndex = 61;
		this.Label87.Text = "접수상태";
		this.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.order_status.BackColor = System.Drawing.Color.White;
		this.order_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.order_status.DropDownHeight = 400;
		this.order_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.order_status.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_status.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_status.FormattingEnabled = true;
		this.order_status.IntegralHeight = false;
		this.order_status.Items.AddRange(new object[5] { "전체", "접수대기", "발송전", "발송전취소", "발송완료" });
		this.order_status.Location = new System.Drawing.Point(84, 143);
		this.order_status.Name = "order_status";
		this.order_status.Size = new System.Drawing.Size(406, 23);
		this.order_status.TabIndex = 6;
		this.Label81.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label81.ForeColor = System.Drawing.Color.Black;
		this.Label81.Location = new System.Drawing.Point(9, 39);
		this.Label81.Name = "Label81";
		this.Label81.Size = new System.Drawing.Size(68, 21);
		this.Label81.TabIndex = 51;
		this.Label81.Text = "조회 기간";
		this.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label82.AutoSize = true;
		this.Label82.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label82.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label82.Location = new System.Drawing.Point(5, 10);
		this.Label82.Name = "Label82";
		this.Label82.Size = new System.Drawing.Size(131, 21);
		this.Label82.TabIndex = 48;
		this.Label82.Text = "주문 관리 - 조회";
		this.Label82.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.Panel69.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel69.Location = new System.Drawing.Point(23, 741);
		this.Panel69.Name = "Panel69";
		this.Panel69.Size = new System.Drawing.Size(1192, 23);
		this.Panel69.TabIndex = 53;
		this.Panel70.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel70.Location = new System.Drawing.Point(0, 0);
		this.Panel70.Name = "Panel70";
		this.Panel70.Size = new System.Drawing.Size(23, 764);
		this.Panel70.TabIndex = 43;
		this.Panel71.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel71.Location = new System.Drawing.Point(1215, 0);
		this.Panel71.Name = "Panel71";
		this.Panel71.Size = new System.Drawing.Size(23, 764);
		this.Panel71.TabIndex = 44;
		this.Panel72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel72.Controls.Add(this.Button4);
		this.Panel72.Controls.Add(this.Button3);
		this.Panel72.Controls.Add(this.Button2);
		this.Panel72.Controls.Add(this.Button1);
		this.Panel72.Controls.Add(this.Button42);
		this.Panel72.Controls.Add(this.Panel2);
		this.Panel72.Controls.Add(this.Button40);
		this.Panel72.Controls.Add(this.Button5);
		this.Panel72.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel72.Location = new System.Drawing.Point(0, 764);
		this.Panel72.Name = "Panel72";
		this.Panel72.Padding = new System.Windows.Forms.Padding(4);
		this.Panel72.Size = new System.Drawing.Size(1238, 44);
		this.Panel72.TabIndex = 46;
		this.Button4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button4.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button4.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button4.ForeColor = System.Drawing.Color.White;
		this.Button4.Location = new System.Drawing.Point(1126, 4);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(106, 34);
		this.Button4.TabIndex = 71;
		this.Button4.Text = "체크된 자료\r\n엑셀 내보내기";
		this.Button4.UseVisualStyleBackColor = false;
		this.Button3.BackColor = System.Drawing.Color.DarkGreen;
		this.Button3.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.ForeColor = System.Drawing.Color.White;
		this.Button3.Location = new System.Drawing.Point(473, 4);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(90, 34);
		this.Button3.TabIndex = 53;
		this.Button3.Text = "발송완료";
		this.Button3.UseVisualStyleBackColor = false;
		this.Button2.BackColor = System.Drawing.Color.Red;
		this.Button2.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = System.Drawing.Color.White;
		this.Button2.Location = new System.Drawing.Point(383, 4);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(90, 34);
		this.Button2.TabIndex = 52;
		this.Button2.Text = "발송전취소";
		this.Button2.UseVisualStyleBackColor = false;
		this.Button1.BackColor = System.Drawing.Color.DarkOrange;
		this.Button1.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(293, 4);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(90, 34);
		this.Button1.TabIndex = 51;
		this.Button1.Text = "접수완료";
		this.Button1.UseVisualStyleBackColor = false;
		this.Button42.BackColor = System.Drawing.Color.BlueViolet;
		this.Button42.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button42.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button42.ForeColor = System.Drawing.Color.White;
		this.Button42.Location = new System.Drawing.Point(203, 4);
		this.Button42.Name = "Button42";
		this.Button42.Size = new System.Drawing.Size(90, 34);
		this.Button42.TabIndex = 79;
		this.Button42.Text = "접수대기";
		this.Button42.UseVisualStyleBackColor = false;
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel2.Location = new System.Drawing.Point(184, 4);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(19, 34);
		this.Panel2.TabIndex = 80;
		this.Button40.BackColor = System.Drawing.Color.Blue;
		this.Button40.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button40.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button40.ForeColor = System.Drawing.Color.White;
		this.Button40.Location = new System.Drawing.Point(94, 4);
		this.Button40.Name = "Button40";
		this.Button40.Size = new System.Drawing.Size(90, 34);
		this.Button40.TabIndex = 78;
		this.Button40.Text = "저장";
		this.Button40.UseVisualStyleBackColor = false;
		this.Button5.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button5.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button5.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button5.ForeColor = System.Drawing.Color.White;
		this.Button5.Location = new System.Drawing.Point(4, 4);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(90, 34);
		this.Button5.TabIndex = 77;
		this.Button5.Text = "전체 선택";
		this.Button5.UseVisualStyleBackColor = false;
		this.TabPage2.Controls.Add(this.p2);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new System.Drawing.Size(1238, 808);
		this.TabPage2.TabIndex = 10;
		this.TabPage2.Text = "고객관리";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.p2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p2.Controls.Add(this.customerGrid);
		this.p2.Controls.Add(this.DoubleBufferPanel2);
		this.p2.Controls.Add(this.DoubleBufferPanel3);
		this.p2.Controls.Add(this.DoubleBufferPanel4);
		this.p2.Controls.Add(this.DoubleBufferPanel5);
		this.p2.Controls.Add(this.DoubleBufferPanel6);
		this.p2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p2.Location = new System.Drawing.Point(0, 0);
		this.p2.Name = "p2";
		this.p2.Size = new System.Drawing.Size(1238, 808);
		this.p2.TabIndex = 15;
		this.customerGrid.AllowUserToDeleteRows = false;
		this.customerGrid.AllowUserToOrderColumns = true;
		this.customerGrid.AllowUserToResizeRows = false;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.customerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
		this.customerGrid.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle7.Format = "C2";
		dataGridViewCellStyle7.NullValue = "0";
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.customerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
		this.customerGrid.ColumnHeadersHeight = 28;
		this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.customerGrid.Columns.AddRange(this.DataGridViewCheckBoxColumn1, this.DataGridViewTextBoxColumn1, this.Column20, this.DataGridViewTextBoxColumn2, this.Column18, this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn4);
		this.customerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.customerGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
		this.customerGrid.EnableHeadersVisualStyles = false;
		this.customerGrid.GridColor = System.Drawing.Color.DarkGray;
		this.customerGrid.Location = new System.Drawing.Point(23, 151);
		this.customerGrid.Name = "customerGrid";
		this.customerGrid.RowHeadersVisible = false;
		this.customerGrid.RowHeadersWidth = 40;
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.customerGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
		this.customerGrid.RowTemplate.Height = 35;
		this.customerGrid.Size = new System.Drawing.Size(1192, 590);
		this.customerGrid.TabIndex = 56;
		this.DataGridViewCheckBoxColumn1.Frozen = true;
		this.DataGridViewCheckBoxColumn1.HeaderText = "";
		this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
		this.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridViewCheckBoxColumn1.Width = 30;
		this.DataGridViewTextBoxColumn1.Frozen = true;
		this.DataGridViewTextBoxColumn1.HeaderText = "고객번호";
		this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
		this.DataGridViewTextBoxColumn1.ReadOnly = true;
		this.Column20.HeaderText = "등록자ID";
		this.Column20.Name = "Column20";
		this.DataGridViewTextBoxColumn2.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
		this.DataGridViewTextBoxColumn2.Width = 120;
		this.Column18.HeaderText = "자택전화";
		this.Column18.Name = "Column18";
		this.Column18.Width = 120;
		dataGridViewCellStyle9.Format = "****";
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
		this.DataGridViewTextBoxColumn3.HeaderText = "휴대전화";
		this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
		this.DataGridViewTextBoxColumn3.Width = 120;
		this.DataGridViewTextBoxColumn4.HeaderText = "자택주소";
		this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
		this.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.DataGridViewTextBoxColumn4.Width = 350;
		this.DoubleBufferPanel2.BackColor = System.Drawing.Color.Transparent;
		this.DoubleBufferPanel2.Controls.Add(this.Label38);
		this.DoubleBufferPanel2.Controls.Add(this.customer_call);
		this.DoubleBufferPanel2.Controls.Add(this.Label5);
		this.DoubleBufferPanel2.Controls.Add(this.customer_code);
		this.DoubleBufferPanel2.Controls.Add(this.Button6);
		this.DoubleBufferPanel2.Controls.Add(this.Label3);
		this.DoubleBufferPanel2.Controls.Add(this.customer_phone);
		this.DoubleBufferPanel2.Controls.Add(this.Label4);
		this.DoubleBufferPanel2.Controls.Add(this.customer_name);
		this.DoubleBufferPanel2.Controls.Add(this.Button8);
		this.DoubleBufferPanel2.Controls.Add(this.Label8);
		this.DoubleBufferPanel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel2.Location = new System.Drawing.Point(23, 0);
		this.DoubleBufferPanel2.Name = "DoubleBufferPanel2";
		this.DoubleBufferPanel2.Size = new System.Drawing.Size(1192, 151);
		this.DoubleBufferPanel2.TabIndex = 54;
		this.Label38.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label38.ForeColor = System.Drawing.Color.Black;
		this.Label38.Location = new System.Drawing.Point(9, 91);
		this.Label38.Name = "Label38";
		this.Label38.Size = new System.Drawing.Size(68, 24);
		this.Label38.TabIndex = 86;
		this.Label38.Text = "자택전화";
		this.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.customer_call.BackColor = System.Drawing.Color.White;
		this.customer_call.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.customer_call.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.customer_call.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.customer_call.Location = new System.Drawing.Point(84, 91);
		this.customer_call.Name = "customer_call";
		this.customer_call.Size = new System.Drawing.Size(406, 22);
		this.customer_call.TabIndex = 85;
		this.Label5.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label5.ForeColor = System.Drawing.Color.Black;
		this.Label5.Location = new System.Drawing.Point(9, 38);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(68, 24);
		this.Label5.TabIndex = 84;
		this.Label5.Text = "고객번호";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.customer_code.BackColor = System.Drawing.Color.White;
		this.customer_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.customer_code.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.customer_code.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.customer_code.Location = new System.Drawing.Point(84, 39);
		this.customer_code.Name = "customer_code";
		this.customer_code.Size = new System.Drawing.Size(406, 22);
		this.customer_code.TabIndex = 0;
		this.Button6.BackColor = System.Drawing.Color.Fuchsia;
		this.Button6.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button6.ForeColor = System.Drawing.Color.White;
		this.Button6.Location = new System.Drawing.Point(496, 90);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(148, 23);
		this.Button6.TabIndex = 3;
		this.Button6.Text = "조건 초기화";
		this.Button6.UseVisualStyleBackColor = false;
		this.Label3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label3.ForeColor = System.Drawing.Color.Black;
		this.Label3.Location = new System.Drawing.Point(9, 117);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(68, 24);
		this.Label3.TabIndex = 82;
		this.Label3.Text = "휴대전화";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.customer_phone.BackColor = System.Drawing.Color.White;
		this.customer_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.customer_phone.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.customer_phone.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.customer_phone.Location = new System.Drawing.Point(84, 117);
		this.customer_phone.Name = "customer_phone";
		this.customer_phone.Size = new System.Drawing.Size(406, 22);
		this.customer_phone.TabIndex = 2;
		this.Label4.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label4.ForeColor = System.Drawing.Color.Black;
		this.Label4.Location = new System.Drawing.Point(9, 65);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(68, 24);
		this.Label4.TabIndex = 80;
		this.Label4.Text = "고객명";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.customer_name.BackColor = System.Drawing.Color.White;
		this.customer_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.customer_name.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.customer_name.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.customer_name.Location = new System.Drawing.Point(84, 65);
		this.customer_name.Name = "customer_name";
		this.customer_name.Size = new System.Drawing.Size(406, 22);
		this.customer_name.TabIndex = 1;
		this.Button8.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button8.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button8.ForeColor = System.Drawing.Color.White;
		this.Button8.Location = new System.Drawing.Point(496, 116);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(148, 23);
		this.Button8.TabIndex = 4;
		this.Button8.Text = "검색";
		this.Button8.UseVisualStyleBackColor = false;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label8.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label8.Location = new System.Drawing.Point(5, 10);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(131, 21);
		this.Label8.TabIndex = 48;
		this.Label8.Text = "고객 관리 - 조회";
		this.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.DoubleBufferPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel3.Location = new System.Drawing.Point(23, 741);
		this.DoubleBufferPanel3.Name = "DoubleBufferPanel3";
		this.DoubleBufferPanel3.Size = new System.Drawing.Size(1192, 23);
		this.DoubleBufferPanel3.TabIndex = 53;
		this.DoubleBufferPanel4.Dock = System.Windows.Forms.DockStyle.Left;
		this.DoubleBufferPanel4.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel4.Name = "DoubleBufferPanel4";
		this.DoubleBufferPanel4.Size = new System.Drawing.Size(23, 764);
		this.DoubleBufferPanel4.TabIndex = 43;
		this.DoubleBufferPanel5.Dock = System.Windows.Forms.DockStyle.Right;
		this.DoubleBufferPanel5.Location = new System.Drawing.Point(1215, 0);
		this.DoubleBufferPanel5.Name = "DoubleBufferPanel5";
		this.DoubleBufferPanel5.Size = new System.Drawing.Size(23, 764);
		this.DoubleBufferPanel5.TabIndex = 44;
		this.DoubleBufferPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel6.Controls.Add(this.Button18);
		this.DoubleBufferPanel6.Controls.Add(this.Button9);
		this.DoubleBufferPanel6.Controls.Add(this.Button16);
		this.DoubleBufferPanel6.Controls.Add(this.Button20);
		this.DoubleBufferPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel6.Location = new System.Drawing.Point(0, 764);
		this.DoubleBufferPanel6.Name = "DoubleBufferPanel6";
		this.DoubleBufferPanel6.Padding = new System.Windows.Forms.Padding(4);
		this.DoubleBufferPanel6.Size = new System.Drawing.Size(1238, 44);
		this.DoubleBufferPanel6.TabIndex = 46;
		this.Button18.BackColor = System.Drawing.Color.Red;
		this.Button18.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button18.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button18.ForeColor = System.Drawing.Color.White;
		this.Button18.Location = new System.Drawing.Point(222, 4);
		this.Button18.Name = "Button18";
		this.Button18.Size = new System.Drawing.Size(109, 34);
		this.Button18.TabIndex = 52;
		this.Button18.Text = "선택 삭제";
		this.Button18.UseVisualStyleBackColor = false;
		this.Button9.BackColor = System.Drawing.Color.Blue;
		this.Button9.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button9.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button9.ForeColor = System.Drawing.Color.White;
		this.Button9.Location = new System.Drawing.Point(113, 4);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(109, 34);
		this.Button9.TabIndex = 78;
		this.Button9.Text = "선택 저장";
		this.Button9.UseVisualStyleBackColor = false;
		this.Button16.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button16.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button16.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button16.ForeColor = System.Drawing.Color.White;
		this.Button16.Location = new System.Drawing.Point(1126, 4);
		this.Button16.Name = "Button16";
		this.Button16.Size = new System.Drawing.Size(106, 34);
		this.Button16.TabIndex = 71;
		this.Button16.Text = "체크된 자료\r\n엑셀 내보내기";
		this.Button16.UseVisualStyleBackColor = false;
		this.Button20.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button20.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button20.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button20.ForeColor = System.Drawing.Color.White;
		this.Button20.Location = new System.Drawing.Point(4, 4);
		this.Button20.Name = "Button20";
		this.Button20.Size = new System.Drawing.Size(109, 34);
		this.Button20.TabIndex = 77;
		this.Button20.Text = "전체 선택";
		this.Button20.UseVisualStyleBackColor = false;
		this.TabPage3.Controls.Add(this.p3);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(1238, 808);
		this.TabPage3.TabIndex = 11;
		this.TabPage3.Text = "제품관리";
		this.TabPage3.UseVisualStyleBackColor = true;
		this.p3.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p3.Controls.Add(this.p3_centerpanel);
		this.p3.Controls.Add(this.DoubleBufferPanel9);
		this.p3.Controls.Add(this.DoubleBufferPanel10);
		this.p3.Controls.Add(this.DoubleBufferPanel11);
		this.p3.Controls.Add(this.DoubleBufferPanel12);
		this.p3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p3.Location = new System.Drawing.Point(0, 0);
		this.p3.Name = "p3";
		this.p3.Size = new System.Drawing.Size(1238, 808);
		this.p3.TabIndex = 16;
		this.p3_centerpanel.Controls.Add(this.productGrid);
		this.p3_centerpanel.Controls.Add(this.DoubleBufferPanel8);
		this.p3_centerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p3_centerpanel.Location = new System.Drawing.Point(23, 0);
		this.p3_centerpanel.Name = "p3_centerpanel";
		this.p3_centerpanel.Size = new System.Drawing.Size(1192, 741);
		this.p3_centerpanel.TabIndex = 57;
		this.productGrid.AllowUserToDeleteRows = false;
		this.productGrid.AllowUserToOrderColumns = true;
		this.productGrid.AllowUserToResizeRows = false;
		dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.productGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
		this.productGrid.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle11.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle11.Format = "C2";
		dataGridViewCellStyle11.NullValue = "0";
		dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.productGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
		this.productGrid.ColumnHeadersHeight = 28;
		this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.productGrid.Columns.AddRange(this.DataGridViewCheckBoxColumn2, this.DataGridViewTextBoxColumn8, this.DataGridViewTextBoxColumn9, this.DataGridViewTextBoxColumn10, this.DataGridViewButtonColumn1, this.Column13, this.Column14);
		this.productGrid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.productGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
		this.productGrid.EnableHeadersVisualStyles = false;
		this.productGrid.GridColor = System.Drawing.Color.DarkGray;
		this.productGrid.Location = new System.Drawing.Point(0, 157);
		this.productGrid.Name = "productGrid";
		this.productGrid.RowHeadersVisible = false;
		this.productGrid.RowHeadersWidth = 40;
		dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.productGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
		this.productGrid.RowTemplate.Height = 35;
		this.productGrid.Size = new System.Drawing.Size(1192, 584);
		this.productGrid.TabIndex = 56;
		this.DataGridViewCheckBoxColumn2.Frozen = true;
		this.DataGridViewCheckBoxColumn2.HeaderText = "";
		this.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2";
		this.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridViewCheckBoxColumn2.Width = 30;
		this.DataGridViewTextBoxColumn8.Frozen = true;
		this.DataGridViewTextBoxColumn8.HeaderText = "제품코드";
		this.DataGridViewTextBoxColumn8.MaxInputLength = 4;
		this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
		this.DataGridViewTextBoxColumn9.HeaderText = "소속구분";
		this.DataGridViewTextBoxColumn9.Items.AddRange("직판", "TM");
		this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
		this.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.DataGridViewTextBoxColumn9.Width = 120;
		dataGridViewCellStyle13.Format = "****";
		dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle13;
		this.DataGridViewTextBoxColumn10.HeaderText = "제품구분";
		this.DataGridViewTextBoxColumn10.Items.AddRange("본품", "사례");
		this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
		this.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.DataGridViewTextBoxColumn10.Width = 120;
		this.DataGridViewButtonColumn1.HeaderText = "제품명";
		this.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1";
		this.DataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewButtonColumn1.Width = 200;
		this.Column13.HeaderText = "가격";
		this.Column13.Name = "Column13";
		this.Column13.Width = 120;
		this.Column14.HeaderText = "재고";
		this.Column14.Name = "Column14";
		this.DoubleBufferPanel8.BackColor = System.Drawing.Color.Transparent;
		this.DoubleBufferPanel8.Controls.Add(this.Label15);
		this.DoubleBufferPanel8.Controls.Add(this.product_gb);
		this.DoubleBufferPanel8.Controls.Add(this.Label14);
		this.DoubleBufferPanel8.Controls.Add(this.product_team);
		this.DoubleBufferPanel8.Controls.Add(this.Label16);
		this.DoubleBufferPanel8.Controls.Add(this.product_code);
		this.DoubleBufferPanel8.Controls.Add(this.Label17);
		this.DoubleBufferPanel8.Controls.Add(this.product_name);
		this.DoubleBufferPanel8.Controls.Add(this.Button10);
		this.DoubleBufferPanel8.Controls.Add(this.Button11);
		this.DoubleBufferPanel8.Controls.Add(this.Label13);
		this.DoubleBufferPanel8.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel8.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel8.Name = "DoubleBufferPanel8";
		this.DoubleBufferPanel8.Size = new System.Drawing.Size(1192, 157);
		this.DoubleBufferPanel8.TabIndex = 54;
		this.Label15.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label15.ForeColor = System.Drawing.Color.Black;
		this.Label15.Location = new System.Drawing.Point(9, 66);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(68, 25);
		this.Label15.TabIndex = 96;
		this.Label15.Text = "제품구분";
		this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.product_gb.BackColor = System.Drawing.Color.White;
		this.product_gb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.product_gb.DropDownHeight = 400;
		this.product_gb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.product_gb.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.product_gb.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.product_gb.FormattingEnabled = true;
		this.product_gb.IntegralHeight = false;
		this.product_gb.Items.AddRange(new object[3] { "전체", "본품", "사례" });
		this.product_gb.Location = new System.Drawing.Point(84, 66);
		this.product_gb.Name = "product_gb";
		this.product_gb.Size = new System.Drawing.Size(406, 23);
		this.product_gb.TabIndex = 1;
		this.Label14.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label14.ForeColor = System.Drawing.Color.Black;
		this.Label14.Location = new System.Drawing.Point(9, 39);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(68, 25);
		this.Label14.TabIndex = 94;
		this.Label14.Text = "소속구분";
		this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.product_team.BackColor = System.Drawing.Color.White;
		this.product_team.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.product_team.DropDownHeight = 400;
		this.product_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.product_team.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.product_team.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.product_team.FormattingEnabled = true;
		this.product_team.IntegralHeight = false;
		this.product_team.Items.AddRange(new object[3] { "전체", "직판", "TM" });
		this.product_team.Location = new System.Drawing.Point(84, 39);
		this.product_team.Name = "product_team";
		this.product_team.Size = new System.Drawing.Size(406, 23);
		this.product_team.TabIndex = 0;
		this.Label16.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label16.ForeColor = System.Drawing.Color.Black;
		this.Label16.Location = new System.Drawing.Point(9, 92);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(68, 24);
		this.Label16.TabIndex = 92;
		this.Label16.Text = "제품코드";
		this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.product_code.BackColor = System.Drawing.Color.White;
		this.product_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.product_code.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.product_code.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.product_code.Location = new System.Drawing.Point(84, 93);
		this.product_code.Name = "product_code";
		this.product_code.Size = new System.Drawing.Size(406, 22);
		this.product_code.TabIndex = 2;
		this.Label17.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label17.ForeColor = System.Drawing.Color.Black;
		this.Label17.Location = new System.Drawing.Point(9, 119);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(68, 24);
		this.Label17.TabIndex = 90;
		this.Label17.Text = "제품명";
		this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.product_name.BackColor = System.Drawing.Color.White;
		this.product_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.product_name.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.product_name.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.product_name.Location = new System.Drawing.Point(84, 119);
		this.product_name.Name = "product_name";
		this.product_name.Size = new System.Drawing.Size(406, 22);
		this.product_name.TabIndex = 3;
		this.Button10.BackColor = System.Drawing.Color.Fuchsia;
		this.Button10.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button10.ForeColor = System.Drawing.Color.White;
		this.Button10.Location = new System.Drawing.Point(496, 95);
		this.Button10.Name = "Button10";
		this.Button10.Size = new System.Drawing.Size(148, 23);
		this.Button10.TabIndex = 4;
		this.Button10.Text = "조건 초기화";
		this.Button10.UseVisualStyleBackColor = false;
		this.Button11.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button11.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button11.ForeColor = System.Drawing.Color.White;
		this.Button11.Location = new System.Drawing.Point(496, 119);
		this.Button11.Name = "Button11";
		this.Button11.Size = new System.Drawing.Size(148, 23);
		this.Button11.TabIndex = 5;
		this.Button11.Text = "검색";
		this.Button11.UseVisualStyleBackColor = false;
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label13.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label13.Location = new System.Drawing.Point(5, 10);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(131, 21);
		this.Label13.TabIndex = 48;
		this.Label13.Text = "제품 관리 - 조회";
		this.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.DoubleBufferPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel9.Location = new System.Drawing.Point(23, 741);
		this.DoubleBufferPanel9.Name = "DoubleBufferPanel9";
		this.DoubleBufferPanel9.Size = new System.Drawing.Size(1192, 23);
		this.DoubleBufferPanel9.TabIndex = 53;
		this.DoubleBufferPanel10.Dock = System.Windows.Forms.DockStyle.Left;
		this.DoubleBufferPanel10.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel10.Name = "DoubleBufferPanel10";
		this.DoubleBufferPanel10.Size = new System.Drawing.Size(23, 764);
		this.DoubleBufferPanel10.TabIndex = 43;
		this.DoubleBufferPanel11.Dock = System.Windows.Forms.DockStyle.Right;
		this.DoubleBufferPanel11.Location = new System.Drawing.Point(1215, 0);
		this.DoubleBufferPanel11.Name = "DoubleBufferPanel11";
		this.DoubleBufferPanel11.Size = new System.Drawing.Size(23, 764);
		this.DoubleBufferPanel11.TabIndex = 44;
		this.DoubleBufferPanel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel12.Controls.Add(this.Button14);
		this.DoubleBufferPanel12.Controls.Add(this.Button17);
		this.DoubleBufferPanel12.Controls.Add(this.Button12);
		this.DoubleBufferPanel12.Controls.Add(this.Button13);
		this.DoubleBufferPanel12.Controls.Add(this.Button15);
		this.DoubleBufferPanel12.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel12.Location = new System.Drawing.Point(0, 764);
		this.DoubleBufferPanel12.Name = "DoubleBufferPanel12";
		this.DoubleBufferPanel12.Padding = new System.Windows.Forms.Padding(4);
		this.DoubleBufferPanel12.Size = new System.Drawing.Size(1238, 44);
		this.DoubleBufferPanel12.TabIndex = 46;
		this.Button14.BackColor = System.Drawing.Color.Red;
		this.Button14.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button14.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button14.ForeColor = System.Drawing.Color.White;
		this.Button14.Location = new System.Drawing.Point(222, 4);
		this.Button14.Name = "Button14";
		this.Button14.Size = new System.Drawing.Size(109, 34);
		this.Button14.TabIndex = 52;
		this.Button14.Text = "선택 삭제";
		this.Button14.UseVisualStyleBackColor = false;
		this.Button17.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button17.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button17.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button17.ForeColor = System.Drawing.Color.White;
		this.Button17.Location = new System.Drawing.Point(1020, 4);
		this.Button17.Name = "Button17";
		this.Button17.Size = new System.Drawing.Size(106, 34);
		this.Button17.TabIndex = 79;
		this.Button17.Text = "데이터\r\n가져오기";
		this.Button17.UseVisualStyleBackColor = false;
		this.Button12.BackColor = System.Drawing.Color.Blue;
		this.Button12.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button12.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button12.ForeColor = System.Drawing.Color.White;
		this.Button12.Location = new System.Drawing.Point(113, 4);
		this.Button12.Name = "Button12";
		this.Button12.Size = new System.Drawing.Size(109, 34);
		this.Button12.TabIndex = 78;
		this.Button12.Text = "선택 저장";
		this.Button12.UseVisualStyleBackColor = false;
		this.Button13.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button13.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button13.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button13.ForeColor = System.Drawing.Color.White;
		this.Button13.Location = new System.Drawing.Point(1126, 4);
		this.Button13.Name = "Button13";
		this.Button13.Size = new System.Drawing.Size(106, 34);
		this.Button13.TabIndex = 71;
		this.Button13.Text = "체크된 자료\r\n엑셀 내보내기";
		this.Button13.UseVisualStyleBackColor = false;
		this.Button15.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button15.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button15.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button15.ForeColor = System.Drawing.Color.White;
		this.Button15.Location = new System.Drawing.Point(4, 4);
		this.Button15.Name = "Button15";
		this.Button15.Size = new System.Drawing.Size(109, 34);
		this.Button15.TabIndex = 77;
		this.Button15.Text = "전체 선택";
		this.Button15.UseVisualStyleBackColor = false;
		this.TabPage5.Controls.Add(this.p4);
		this.TabPage5.Location = new System.Drawing.Point(4, 22);
		this.TabPage5.Name = "TabPage5";
		this.TabPage5.Size = new System.Drawing.Size(1238, 808);
		this.TabPage5.TabIndex = 12;
		this.TabPage5.Text = "사용자관리";
		this.TabPage5.UseVisualStyleBackColor = true;
		this.p4.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p4.Controls.Add(this.p4_centerpanel);
		this.p4.Controls.Add(this.DoubleBufferPanel14);
		this.p4.Controls.Add(this.DoubleBufferPanel15);
		this.p4.Controls.Add(this.DoubleBufferPanel16);
		this.p4.Controls.Add(this.DoubleBufferPanel17);
		this.p4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p4.Location = new System.Drawing.Point(0, 0);
		this.p4.Name = "p4";
		this.p4.Size = new System.Drawing.Size(1238, 808);
		this.p4.TabIndex = 17;
		this.p4_centerpanel.Controls.Add(this.accountGrid);
		this.p4_centerpanel.Controls.Add(this.DoubleBufferPanel13);
		this.p4_centerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p4_centerpanel.Location = new System.Drawing.Point(23, 0);
		this.p4_centerpanel.Name = "p4_centerpanel";
		this.p4_centerpanel.Size = new System.Drawing.Size(1192, 741);
		this.p4_centerpanel.TabIndex = 57;
		this.accountGrid.AllowUserToDeleteRows = false;
		this.accountGrid.AllowUserToOrderColumns = true;
		this.accountGrid.AllowUserToResizeRows = false;
		dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.accountGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
		this.accountGrid.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle15.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle15.Format = "C2";
		dataGridViewCellStyle15.NullValue = "0";
		dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.accountGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
		this.accountGrid.ColumnHeadersHeight = 28;
		this.accountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.accountGrid.Columns.AddRange(this.DataGridViewCheckBoxColumn3, this.DataGridViewTextBoxColumn11, this.DataGridViewComboBoxColumn1, this.DataGridViewComboBoxColumn2, this.DataGridViewTextBoxColumn12, this.DataGridViewTextBoxColumn13, this.DataGridViewTextBoxColumn14, this.Column23);
		this.accountGrid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.accountGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
		this.accountGrid.EnableHeadersVisualStyles = false;
		this.accountGrid.GridColor = System.Drawing.Color.DarkGray;
		this.accountGrid.Location = new System.Drawing.Point(0, 182);
		this.accountGrid.Name = "accountGrid";
		this.accountGrid.RowHeadersVisible = false;
		this.accountGrid.RowHeadersWidth = 40;
		dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.accountGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
		this.accountGrid.RowTemplate.Height = 35;
		this.accountGrid.Size = new System.Drawing.Size(1192, 559);
		this.accountGrid.TabIndex = 56;
		this.DataGridViewCheckBoxColumn3.Frozen = true;
		this.DataGridViewCheckBoxColumn3.HeaderText = "";
		this.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3";
		this.DataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridViewCheckBoxColumn3.Width = 30;
		this.DataGridViewTextBoxColumn11.Frozen = true;
		this.DataGridViewTextBoxColumn11.HeaderText = "번호";
		this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
		this.DataGridViewTextBoxColumn11.ReadOnly = true;
		this.DataGridViewTextBoxColumn11.Width = 60;
		this.DataGridViewComboBoxColumn1.HeaderText = "계정구분";
		this.DataGridViewComboBoxColumn1.Items.AddRange("최고관리자", "관리자", "일반", "재고관리자", "루트계정");
		this.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1";
		this.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.DataGridViewComboBoxColumn1.Width = 120;
		dataGridViewCellStyle17.Format = "****";
		dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewComboBoxColumn2.DefaultCellStyle = dataGridViewCellStyle17;
		this.DataGridViewComboBoxColumn2.HeaderText = "소속구분";
		this.DataGridViewComboBoxColumn2.Items.AddRange("직판", "TM");
		this.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2";
		this.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.DataGridViewComboBoxColumn2.Width = 120;
		this.DataGridViewTextBoxColumn12.HeaderText = "아이디";
		this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
		this.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn12.Width = 150;
		this.DataGridViewTextBoxColumn13.HeaderText = "비밀번호";
		this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
		this.DataGridViewTextBoxColumn13.Width = 150;
		this.DataGridViewTextBoxColumn14.HeaderText = "이름";
		this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
		this.Column23.HeaderText = "허용 IP";
		this.Column23.Name = "Column23";
		this.Column23.Width = 120;
		this.DoubleBufferPanel13.BackColor = System.Drawing.Color.Transparent;
		this.DoubleBufferPanel13.Controls.Add(this.Label20);
		this.DoubleBufferPanel13.Controls.Add(this.acc_index);
		this.DoubleBufferPanel13.Controls.Add(this.Label10);
		this.DoubleBufferPanel13.Controls.Add(this.acc_teamgb);
		this.DoubleBufferPanel13.Controls.Add(this.Label11);
		this.DoubleBufferPanel13.Controls.Add(this.acc_gb);
		this.DoubleBufferPanel13.Controls.Add(this.Label12);
		this.DoubleBufferPanel13.Controls.Add(this.acc_id);
		this.DoubleBufferPanel13.Controls.Add(this.Label18);
		this.DoubleBufferPanel13.Controls.Add(this.acc_name);
		this.DoubleBufferPanel13.Controls.Add(this.Button19);
		this.DoubleBufferPanel13.Controls.Add(this.Button21);
		this.DoubleBufferPanel13.Controls.Add(this.Label19);
		this.DoubleBufferPanel13.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel13.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel13.Name = "DoubleBufferPanel13";
		this.DoubleBufferPanel13.Size = new System.Drawing.Size(1192, 182);
		this.DoubleBufferPanel13.TabIndex = 54;
		this.Label20.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label20.ForeColor = System.Drawing.Color.Black;
		this.Label20.Location = new System.Drawing.Point(9, 38);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(68, 24);
		this.Label20.TabIndex = 98;
		this.Label20.Text = "번호";
		this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.acc_index.BackColor = System.Drawing.Color.White;
		this.acc_index.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.acc_index.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.acc_index.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.acc_index.Location = new System.Drawing.Point(84, 39);
		this.acc_index.Name = "acc_index";
		this.acc_index.Size = new System.Drawing.Size(406, 22);
		this.acc_index.TabIndex = 0;
		this.Label10.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label10.ForeColor = System.Drawing.Color.Black;
		this.Label10.Location = new System.Drawing.Point(9, 92);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(68, 25);
		this.Label10.TabIndex = 96;
		this.Label10.Text = "소속구분";
		this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.acc_teamgb.BackColor = System.Drawing.Color.White;
		this.acc_teamgb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.acc_teamgb.DropDownHeight = 400;
		this.acc_teamgb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.acc_teamgb.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.acc_teamgb.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.acc_teamgb.FormattingEnabled = true;
		this.acc_teamgb.IntegralHeight = false;
		this.acc_teamgb.Items.AddRange(new object[3] { "전체", "직판", "TM" });
		this.acc_teamgb.Location = new System.Drawing.Point(84, 92);
		this.acc_teamgb.Name = "acc_teamgb";
		this.acc_teamgb.Size = new System.Drawing.Size(406, 23);
		this.acc_teamgb.TabIndex = 2;
		this.Label11.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label11.ForeColor = System.Drawing.Color.Black;
		this.Label11.Location = new System.Drawing.Point(9, 65);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(68, 25);
		this.Label11.TabIndex = 94;
		this.Label11.Text = "계정구분";
		this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.acc_gb.BackColor = System.Drawing.Color.White;
		this.acc_gb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.acc_gb.DropDownHeight = 400;
		this.acc_gb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.acc_gb.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.acc_gb.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.acc_gb.FormattingEnabled = true;
		this.acc_gb.IntegralHeight = false;
		this.acc_gb.Items.AddRange(new object[6] { "전체", "관리자", "일반", "최고관리자", "재고관리자", "루트계정" });
		this.acc_gb.Location = new System.Drawing.Point(84, 65);
		this.acc_gb.Name = "acc_gb";
		this.acc_gb.Size = new System.Drawing.Size(406, 23);
		this.acc_gb.TabIndex = 1;
		this.Label12.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label12.ForeColor = System.Drawing.Color.Black;
		this.Label12.Location = new System.Drawing.Point(9, 118);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(68, 24);
		this.Label12.TabIndex = 92;
		this.Label12.Text = "아이디";
		this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.acc_id.BackColor = System.Drawing.Color.White;
		this.acc_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.acc_id.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.acc_id.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.acc_id.Location = new System.Drawing.Point(84, 119);
		this.acc_id.Name = "acc_id";
		this.acc_id.Size = new System.Drawing.Size(406, 22);
		this.acc_id.TabIndex = 3;
		this.Label18.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label18.ForeColor = System.Drawing.Color.Black;
		this.Label18.Location = new System.Drawing.Point(9, 145);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(68, 24);
		this.Label18.TabIndex = 90;
		this.Label18.Text = "이름";
		this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.acc_name.BackColor = System.Drawing.Color.White;
		this.acc_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.acc_name.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.acc_name.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.acc_name.Location = new System.Drawing.Point(84, 145);
		this.acc_name.Name = "acc_name";
		this.acc_name.Size = new System.Drawing.Size(406, 22);
		this.acc_name.TabIndex = 4;
		this.Button19.BackColor = System.Drawing.Color.Fuchsia;
		this.Button19.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button19.ForeColor = System.Drawing.Color.White;
		this.Button19.Location = new System.Drawing.Point(496, 121);
		this.Button19.Name = "Button19";
		this.Button19.Size = new System.Drawing.Size(148, 23);
		this.Button19.TabIndex = 5;
		this.Button19.Text = "조건 초기화";
		this.Button19.UseVisualStyleBackColor = false;
		this.Button21.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button21.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button21.ForeColor = System.Drawing.Color.White;
		this.Button21.Location = new System.Drawing.Point(496, 145);
		this.Button21.Name = "Button21";
		this.Button21.Size = new System.Drawing.Size(148, 23);
		this.Button21.TabIndex = 6;
		this.Button21.Text = "검색";
		this.Button21.UseVisualStyleBackColor = false;
		this.Label19.AutoSize = true;
		this.Label19.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label19.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label19.Location = new System.Drawing.Point(5, 10);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(147, 21);
		this.Label19.TabIndex = 48;
		this.Label19.Text = "사용자 관리 - 조회";
		this.Label19.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.DoubleBufferPanel14.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel14.Location = new System.Drawing.Point(23, 741);
		this.DoubleBufferPanel14.Name = "DoubleBufferPanel14";
		this.DoubleBufferPanel14.Size = new System.Drawing.Size(1192, 23);
		this.DoubleBufferPanel14.TabIndex = 53;
		this.DoubleBufferPanel15.Dock = System.Windows.Forms.DockStyle.Left;
		this.DoubleBufferPanel15.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel15.Name = "DoubleBufferPanel15";
		this.DoubleBufferPanel15.Size = new System.Drawing.Size(23, 764);
		this.DoubleBufferPanel15.TabIndex = 43;
		this.DoubleBufferPanel16.Dock = System.Windows.Forms.DockStyle.Right;
		this.DoubleBufferPanel16.Location = new System.Drawing.Point(1215, 0);
		this.DoubleBufferPanel16.Name = "DoubleBufferPanel16";
		this.DoubleBufferPanel16.Size = new System.Drawing.Size(23, 764);
		this.DoubleBufferPanel16.TabIndex = 44;
		this.DoubleBufferPanel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel17.Controls.Add(this.Button26);
		this.DoubleBufferPanel17.Controls.Add(this.Button24);
		this.DoubleBufferPanel17.Controls.Add(this.Button25);
		this.DoubleBufferPanel17.Controls.Add(this.Button27);
		this.DoubleBufferPanel17.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel17.Location = new System.Drawing.Point(0, 764);
		this.DoubleBufferPanel17.Name = "DoubleBufferPanel17";
		this.DoubleBufferPanel17.Padding = new System.Windows.Forms.Padding(4);
		this.DoubleBufferPanel17.Size = new System.Drawing.Size(1238, 44);
		this.DoubleBufferPanel17.TabIndex = 46;
		this.Button26.BackColor = System.Drawing.Color.Red;
		this.Button26.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button26.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button26.ForeColor = System.Drawing.Color.White;
		this.Button26.Location = new System.Drawing.Point(222, 4);
		this.Button26.Name = "Button26";
		this.Button26.Size = new System.Drawing.Size(109, 34);
		this.Button26.TabIndex = 52;
		this.Button26.Text = "선택 삭제";
		this.Button26.UseVisualStyleBackColor = false;
		this.Button24.BackColor = System.Drawing.Color.Blue;
		this.Button24.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button24.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button24.ForeColor = System.Drawing.Color.White;
		this.Button24.Location = new System.Drawing.Point(113, 4);
		this.Button24.Name = "Button24";
		this.Button24.Size = new System.Drawing.Size(109, 34);
		this.Button24.TabIndex = 78;
		this.Button24.Text = "선택 저장";
		this.Button24.UseVisualStyleBackColor = false;
		this.Button25.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button25.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button25.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button25.ForeColor = System.Drawing.Color.White;
		this.Button25.Location = new System.Drawing.Point(1126, 4);
		this.Button25.Name = "Button25";
		this.Button25.Size = new System.Drawing.Size(106, 34);
		this.Button25.TabIndex = 71;
		this.Button25.Text = "체크된 자료\r\n엑셀 내보내기";
		this.Button25.UseVisualStyleBackColor = false;
		this.Button27.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button27.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button27.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button27.ForeColor = System.Drawing.Color.White;
		this.Button27.Location = new System.Drawing.Point(4, 4);
		this.Button27.Name = "Button27";
		this.Button27.Size = new System.Drawing.Size(109, 34);
		this.Button27.TabIndex = 77;
		this.Button27.Text = "전체 선택";
		this.Button27.UseVisualStyleBackColor = false;
		this.TabPage4.Controls.Add(this.diag_orderList);
		this.TabPage4.Controls.Add(this.diag_customer);
		this.TabPage4.Controls.Add(this.diag_address);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(1238, 808);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Dialogs";
		this.TabPage4.UseVisualStyleBackColor = true;
		this.diag_orderList.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.diag_orderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.diag_orderList.Controls.Add(this.dgv_orderList);
		this.diag_orderList.Controls.Add(this.DoubleBufferPanel22);
		this.diag_orderList.Controls.Add(this.DoubleBufferPanel23);
		this.diag_orderList.Location = new System.Drawing.Point(865, 114);
		this.diag_orderList.Name = "diag_orderList";
		this.diag_orderList.Size = new System.Drawing.Size(570, 290);
		this.diag_orderList.TabIndex = 17;
		this.diag_orderList.Visible = false;
		this.dgv_orderList.AllowUserToAddRows = false;
		this.dgv_orderList.AllowUserToDeleteRows = false;
		this.dgv_orderList.AllowUserToResizeRows = false;
		dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.dgv_orderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
		this.dgv_orderList.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle19.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle19.Format = "C2";
		dataGridViewCellStyle19.NullValue = "0";
		dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgv_orderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
		this.dgv_orderList.ColumnHeadersHeight = 28;
		this.dgv_orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.dgv_orderList.Columns.AddRange(this.Column17, this.DataGridViewTextBoxColumn16, this.DataGridViewTextBoxColumn17, this.DataGridViewTextBoxColumn18, this.Column7, this.Column1);
		this.dgv_orderList.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dgv_orderList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.dgv_orderList.EnableHeadersVisualStyles = false;
		this.dgv_orderList.GridColor = System.Drawing.Color.DarkGray;
		this.dgv_orderList.Location = new System.Drawing.Point(0, 40);
		this.dgv_orderList.Name = "dgv_orderList";
		this.dgv_orderList.RowHeadersVisible = false;
		this.dgv_orderList.RowHeadersWidth = 40;
		dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.dgv_orderList.RowsDefaultCellStyle = dataGridViewCellStyle20;
		this.dgv_orderList.RowTemplate.Height = 35;
		this.dgv_orderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgv_orderList.Size = new System.Drawing.Size(568, 248);
		this.dgv_orderList.TabIndex = 57;
		this.Column17.HeaderText = "제품구분";
		this.Column17.Name = "Column17";
		this.Column17.ReadOnly = true;
		this.Column17.Width = 60;
		this.DataGridViewTextBoxColumn16.HeaderText = "제품명";
		this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
		this.DataGridViewTextBoxColumn16.ReadOnly = true;
		this.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		this.DataGridViewTextBoxColumn16.Width = 160;
		this.DataGridViewTextBoxColumn17.HeaderText = "단가";
		this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
		this.DataGridViewTextBoxColumn17.Width = 80;
		dataGridViewCellStyle21.Format = "****";
		dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle21;
		this.DataGridViewTextBoxColumn18.HeaderText = "개수";
		this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
		this.DataGridViewTextBoxColumn18.Width = 60;
		this.Column7.HeaderText = "비고";
		this.Column7.Name = "Column7";
		this.Column7.Width = 200;
		this.Column1.HeaderText = "제품코드";
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.Column1.Visible = false;
		this.DoubleBufferPanel22.BackColor = System.Drawing.Color.DimGray;
		this.DoubleBufferPanel22.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel22.Location = new System.Drawing.Point(0, 39);
		this.DoubleBufferPanel22.Name = "DoubleBufferPanel22";
		this.DoubleBufferPanel22.Size = new System.Drawing.Size(568, 1);
		this.DoubleBufferPanel22.TabIndex = 19;
		this.DoubleBufferPanel23.BackColor = System.Drawing.Color.Gainsboro;
		this.DoubleBufferPanel23.Controls.Add(this.Button35);
		this.DoubleBufferPanel23.Controls.Add(this.Button34);
		this.DoubleBufferPanel23.Controls.Add(this.Label27);
		this.DoubleBufferPanel23.Controls.Add(this.Button29);
		this.DoubleBufferPanel23.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.DoubleBufferPanel23.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel23.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel23.Name = "DoubleBufferPanel23";
		this.DoubleBufferPanel23.Size = new System.Drawing.Size(568, 39);
		this.DoubleBufferPanel23.TabIndex = 18;
		this.Button35.BackColor = System.Drawing.Color.DarkGreen;
		this.Button35.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button35.BackgroundImage");
		this.Button35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button35.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button35.ForeColor = System.Drawing.Color.White;
		this.Button35.Location = new System.Drawing.Point(338, 8);
		this.Button35.Name = "Button35";
		this.Button35.Size = new System.Drawing.Size(73, 24);
		this.Button35.TabIndex = 56;
		this.Button35.Text = "제품 추가";
		this.Button35.UseVisualStyleBackColor = false;
		this.Button34.BackColor = System.Drawing.Color.Red;
		this.Button34.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button34.BackgroundImage");
		this.Button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button34.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button34.ForeColor = System.Drawing.Color.White;
		this.Button34.Location = new System.Drawing.Point(414, 8);
		this.Button34.Name = "Button34";
		this.Button34.Size = new System.Drawing.Size(73, 24);
		this.Button34.TabIndex = 55;
		this.Button34.Text = "선택 삭제";
		this.Button34.UseVisualStyleBackColor = false;
		this.Label27.AutoSize = true;
		this.Label27.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.Label27.Font = new System.Drawing.Font("맑은 고딕", 14f, System.Drawing.FontStyle.Bold);
		this.Label27.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label27.Location = new System.Drawing.Point(7, 7);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(140, 25);
		this.Label27.TabIndex = 0;
		this.Label27.Text = "제품 주문 목록";
		this.Button29.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button29.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button29.BackgroundImage");
		this.Button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button29.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button29.ForeColor = System.Drawing.Color.White;
		this.Button29.Location = new System.Drawing.Point(489, 8);
		this.Button29.Name = "Button29";
		this.Button29.Size = new System.Drawing.Size(73, 24);
		this.Button29.TabIndex = 4;
		this.Button29.Text = "창 닫기";
		this.Button29.UseVisualStyleBackColor = false;
		this.diag_customer.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.diag_customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.diag_customer.Controls.Add(this.dgv_customer);
		this.diag_customer.Controls.Add(this.DoubleBufferPanel27);
		this.diag_customer.Controls.Add(this.DoubleBufferPanel28);
		this.diag_customer.Location = new System.Drawing.Point(22, 460);
		this.diag_customer.Name = "diag_customer";
		this.diag_customer.Size = new System.Drawing.Size(570, 290);
		this.diag_customer.TabIndex = 18;
		this.diag_customer.Visible = false;
		this.dgv_customer.AllowUserToAddRows = false;
		this.dgv_customer.AllowUserToDeleteRows = false;
		this.dgv_customer.AllowUserToOrderColumns = true;
		this.dgv_customer.AllowUserToResizeRows = false;
		dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.dgv_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
		this.dgv_customer.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle23.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle23.Format = "C2";
		dataGridViewCellStyle23.NullValue = "0";
		dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgv_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
		this.dgv_customer.ColumnHeadersHeight = 28;
		this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.dgv_customer.Columns.AddRange(this.Column21, this.DataGridViewTextBoxColumn23, this.DataGridViewTextBoxColumn24, this.DataGridViewTextBoxColumn25, this.DataGridViewButtonColumn2);
		this.dgv_customer.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dgv_customer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
		this.dgv_customer.EnableHeadersVisualStyles = false;
		this.dgv_customer.GridColor = System.Drawing.Color.DarkGray;
		this.dgv_customer.Location = new System.Drawing.Point(0, 40);
		this.dgv_customer.MultiSelect = false;
		this.dgv_customer.Name = "dgv_customer";
		this.dgv_customer.RowHeadersVisible = false;
		this.dgv_customer.RowHeadersWidth = 40;
		dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.dgv_customer.RowsDefaultCellStyle = dataGridViewCellStyle24;
		this.dgv_customer.RowTemplate.Height = 35;
		this.dgv_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgv_customer.Size = new System.Drawing.Size(568, 248);
		this.dgv_customer.TabIndex = 57;
		this.Column21.HeaderText = "Column21";
		this.Column21.Name = "Column21";
		this.Column21.ReadOnly = true;
		this.Column21.Visible = false;
		this.DataGridViewTextBoxColumn23.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23";
		this.DataGridViewTextBoxColumn23.ReadOnly = true;
		this.DataGridViewTextBoxColumn23.Width = 80;
		this.DataGridViewTextBoxColumn24.HeaderText = "자택전화";
		this.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24";
		this.DataGridViewTextBoxColumn24.ReadOnly = true;
		this.DataGridViewTextBoxColumn24.Width = 120;
		dataGridViewCellStyle25.Format = "****";
		dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle25;
		this.DataGridViewTextBoxColumn25.HeaderText = "휴대전화";
		this.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25";
		this.DataGridViewTextBoxColumn25.ReadOnly = true;
		this.DataGridViewTextBoxColumn25.Width = 120;
		this.DataGridViewButtonColumn2.HeaderText = "자택주소";
		this.DataGridViewButtonColumn2.Name = "DataGridViewButtonColumn2";
		this.DataGridViewButtonColumn2.ReadOnly = true;
		this.DataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewButtonColumn2.Width = 220;
		this.DoubleBufferPanel27.BackColor = System.Drawing.Color.DimGray;
		this.DoubleBufferPanel27.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel27.Location = new System.Drawing.Point(0, 39);
		this.DoubleBufferPanel27.Name = "DoubleBufferPanel27";
		this.DoubleBufferPanel27.Size = new System.Drawing.Size(568, 1);
		this.DoubleBufferPanel27.TabIndex = 19;
		this.DoubleBufferPanel28.BackColor = System.Drawing.Color.Gainsboro;
		this.DoubleBufferPanel28.Controls.Add(this.TextBox1);
		this.DoubleBufferPanel28.Controls.Add(this.Button38);
		this.DoubleBufferPanel28.Controls.Add(this.Label43);
		this.DoubleBufferPanel28.Controls.Add(this.Button37);
		this.DoubleBufferPanel28.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.DoubleBufferPanel28.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel28.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel28.Name = "DoubleBufferPanel28";
		this.DoubleBufferPanel28.Size = new System.Drawing.Size(568, 39);
		this.DoubleBufferPanel28.TabIndex = 18;
		this.TextBox1.BackColor = System.Drawing.Color.White;
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox1.Location = new System.Drawing.Point(249, 9);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(175, 22);
		this.TextBox1.TabIndex = 5;
		this.Button38.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button38.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button38.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button38.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button38.ForeColor = System.Drawing.Color.White;
		this.Button38.Location = new System.Drawing.Point(427, 8);
		this.Button38.Name = "Button38";
		this.Button38.Size = new System.Drawing.Size(65, 24);
		this.Button38.TabIndex = 6;
		this.Button38.Text = "검색";
		this.Button38.UseVisualStyleBackColor = false;
		this.Label43.AutoSize = true;
		this.Label43.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.Label43.Font = new System.Drawing.Font("맑은 고딕", 14f, System.Drawing.FontStyle.Bold);
		this.Label43.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label43.Location = new System.Drawing.Point(7, 7);
		this.Label43.Name = "Label43";
		this.Label43.Size = new System.Drawing.Size(121, 25);
		this.Label43.TabIndex = 0;
		this.Label43.Text = "내 고객 검색";
		this.Button37.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button37.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button37.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button37.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button37.ForeColor = System.Drawing.Color.White;
		this.Button37.Location = new System.Drawing.Point(499, 8);
		this.Button37.Name = "Button37";
		this.Button37.Size = new System.Drawing.Size(63, 24);
		this.Button37.TabIndex = 4;
		this.Button37.Text = "창 닫기";
		this.Button37.UseVisualStyleBackColor = false;
		this.diag_address.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.diag_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.diag_address.Controls.Add(this.addressGrid);
		this.diag_address.Controls.Add(this.Panel163);
		this.diag_address.Controls.Add(this.Panel99);
		this.diag_address.Controls.Add(this.Panel101);
		this.diag_address.Controls.Add(this.Panel100);
		this.diag_address.Location = new System.Drawing.Point(8, 28);
		this.diag_address.Name = "diag_address";
		this.diag_address.Size = new System.Drawing.Size(693, 346);
		this.diag_address.TabIndex = 16;
		this.diag_address.Visible = false;
		this.addressGrid.AllowUserToAddRows = false;
		this.addressGrid.AllowUserToDeleteRows = false;
		this.addressGrid.AllowUserToResizeRows = false;
		dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.addressGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
		this.addressGrid.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle27.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle27.Format = "C2";
		dataGridViewCellStyle27.NullValue = "0";
		dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.addressGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
		this.addressGrid.ColumnHeadersHeight = 28;
		this.addressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.addressGrid.Columns.AddRange(this.Column12, this.DataGridViewTextBoxColumn5, this.DataGridViewTextBoxColumn6, this.DataGridViewTextBoxColumn7);
		this.addressGrid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.addressGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
		this.addressGrid.EnableHeadersVisualStyles = false;
		this.addressGrid.GridColor = System.Drawing.Color.DarkGray;
		this.addressGrid.Location = new System.Drawing.Point(0, 110);
		this.addressGrid.MultiSelect = false;
		this.addressGrid.Name = "addressGrid";
		this.addressGrid.RowHeadersVisible = false;
		this.addressGrid.RowHeadersWidth = 40;
		dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.addressGrid.RowsDefaultCellStyle = dataGridViewCellStyle28;
		this.addressGrid.RowTemplate.Height = 35;
		this.addressGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.addressGrid.Size = new System.Drawing.Size(691, 150);
		this.addressGrid.TabIndex = 57;
		this.Column12.HeaderText = "index";
		this.Column12.Name = "Column12";
		this.Column12.ReadOnly = true;
		this.Column12.Visible = false;
		this.DataGridViewTextBoxColumn5.HeaderText = "우편번호";
		this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
		this.DataGridViewTextBoxColumn5.ReadOnly = true;
		this.DataGridViewTextBoxColumn5.Width = 80;
		this.DataGridViewTextBoxColumn6.HeaderText = "도로명 주소";
		this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
		this.DataGridViewTextBoxColumn6.ReadOnly = true;
		this.DataGridViewTextBoxColumn6.Width = 300;
		dataGridViewCellStyle29.Format = "****";
		dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle29;
		this.DataGridViewTextBoxColumn7.HeaderText = "지번 주소";
		this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
		this.DataGridViewTextBoxColumn7.ReadOnly = true;
		this.DataGridViewTextBoxColumn7.Width = 300;
		this.Panel163.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.Panel163.Controls.Add(this.Label9);
		this.Panel163.Controls.Add(this.CheckBox1);
		this.Panel163.Controls.Add(this.Label7);
		this.Panel163.Controls.Add(this.Label6);
		this.Panel163.Controls.Add(this.DoubleBufferPanel1);
		this.Panel163.Controls.Add(this.Label126);
		this.Panel163.Controls.Add(this.diag_searchMove);
		this.Panel163.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel163.Location = new System.Drawing.Point(0, 260);
		this.Panel163.Name = "Panel163";
		this.Panel163.Size = new System.Drawing.Size(691, 84);
		this.Panel163.TabIndex = 56;
		this.Panel163.Visible = false;
		this.Label9.AutoSize = true;
		this.Label9.Location = new System.Drawing.Point(173, 9);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(42, 12);
		this.Label9.TabIndex = 61;
		this.Label9.Text = "Label9";
		this.Label9.Visible = false;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(91, 9);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(76, 16);
		this.CheckBox1.TabIndex = 60;
		this.CheckBox1.Text = "지번 사용";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.Label7.BackColor = System.Drawing.Color.White;
		this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
		this.Label7.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label7.ForeColor = System.Drawing.Color.Blue;
		this.Label7.Location = new System.Drawing.Point(8, 29);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(668, 20);
		this.Label7.TabIndex = 59;
		this.Label7.Text = "선택한 주소";
		this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
		this.Label6.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label6.ForeColor = System.Drawing.Color.Black;
		this.Label6.Location = new System.Drawing.Point(-3, 7);
		this.Label6.Name = "Label6";
		this.Label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
		this.Label6.Size = new System.Drawing.Size(86, 20);
		this.Label6.TabIndex = 58;
		this.Label6.Text = "선택한 주소";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DoubleBufferPanel1.BackColor = System.Drawing.Color.Gray;
		this.DoubleBufferPanel1.Controls.Add(this.TextBox2);
		this.DoubleBufferPanel1.Location = new System.Drawing.Point(90, 55);
		this.DoubleBufferPanel1.Name = "DoubleBufferPanel1";
		this.DoubleBufferPanel1.Padding = new System.Windows.Forms.Padding(2);
		this.DoubleBufferPanel1.Size = new System.Drawing.Size(525, 22);
		this.DoubleBufferPanel1.TabIndex = 57;
		this.TextBox2.BackColor = System.Drawing.Color.White;
		this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox2.Font = new System.Drawing.Font("굴림", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox2.Location = new System.Drawing.Point(2, 2);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(521, 18);
		this.TextBox2.TabIndex = 16;
		this.Label126.Cursor = System.Windows.Forms.Cursors.Default;
		this.Label126.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label126.ForeColor = System.Drawing.Color.Black;
		this.Label126.Location = new System.Drawing.Point(-3, 56);
		this.Label126.Name = "Label126";
		this.Label126.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
		this.Label126.Size = new System.Drawing.Size(86, 20);
		this.Label126.TabIndex = 56;
		this.Label126.Text = "나머지 주소";
		this.Label126.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.diag_searchMove.BackColor = System.Drawing.Color.DarkGreen;
		this.diag_searchMove.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.diag_searchMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.diag_searchMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.diag_searchMove.ForeColor = System.Drawing.Color.White;
		this.diag_searchMove.Location = new System.Drawing.Point(621, 55);
		this.diag_searchMove.Name = "diag_searchMove";
		this.diag_searchMove.Size = new System.Drawing.Size(55, 22);
		this.diag_searchMove.TabIndex = 54;
		this.diag_searchMove.Text = "완료";
		this.diag_searchMove.UseVisualStyleBackColor = false;
		this.Panel99.BackColor = System.Drawing.Color.White;
		this.Panel99.Controls.Add(this.Label21);
		this.Panel99.Controls.Add(this.rb_road);
		this.Panel99.Controls.Add(this.rb_dong);
		this.Panel99.Controls.Add(this.Button122);
		this.Panel99.Controls.Add(this.Panel120);
		this.Panel99.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel99.Location = new System.Drawing.Point(0, 53);
		this.Panel99.Name = "Panel99";
		this.Panel99.Size = new System.Drawing.Size(691, 57);
		this.Panel99.TabIndex = 22;
		this.Label21.AutoSize = true;
		this.Label21.ForeColor = System.Drawing.Color.Red;
		this.Label21.Location = new System.Drawing.Point(566, 8);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(97, 12);
		this.Label21.TabIndex = 25;
		this.Label21.Text = "결과가 없습니다.";
		this.Label21.Visible = false;
		this.rb_road.AutoSize = true;
		this.rb_road.Checked = true;
		this.rb_road.Location = new System.Drawing.Point(34, 6);
		this.rb_road.Name = "rb_road";
		this.rb_road.Size = new System.Drawing.Size(111, 16);
		this.rb_road.TabIndex = 24;
		this.rb_road.TabStop = true;
		this.rb_road.Text = "도로명으로 찾기";
		this.rb_road.UseVisualStyleBackColor = true;
		this.rb_dong.AutoSize = true;
		this.rb_dong.Location = new System.Drawing.Point(151, 6);
		this.rb_dong.Name = "rb_dong";
		this.rb_dong.Size = new System.Drawing.Size(161, 16);
		this.rb_dong.TabIndex = 23;
		this.rb_dong.Text = "지번으로 찾기 (동/읍/면)";
		this.rb_dong.UseVisualStyleBackColor = true;
		this.Button122.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button122.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button122.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button122.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button122.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button122.ForeColor = System.Drawing.Color.White;
		this.Button122.Location = new System.Drawing.Point(594, 24);
		this.Button122.Name = "Button122";
		this.Button122.Size = new System.Drawing.Size(67, 24);
		this.Button122.TabIndex = 22;
		this.Button122.Text = "검색";
		this.Button122.UseVisualStyleBackColor = false;
		this.Panel120.BackColor = System.Drawing.Color.Green;
		this.Panel120.Controls.Add(this.TextBox13);
		this.Panel120.Location = new System.Drawing.Point(32, 24);
		this.Panel120.Name = "Panel120";
		this.Panel120.Padding = new System.Windows.Forms.Padding(2);
		this.Panel120.Size = new System.Drawing.Size(556, 24);
		this.Panel120.TabIndex = 21;
		this.TextBox13.BackColor = System.Drawing.Color.White;
		this.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.TextBox13.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox13.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox13.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox13.Location = new System.Drawing.Point(2, 2);
		this.TextBox13.Name = "TextBox13";
		this.TextBox13.Size = new System.Drawing.Size(552, 20);
		this.TextBox13.TabIndex = 16;
		this.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Panel101.BackColor = System.Drawing.Color.DimGray;
		this.Panel101.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel101.Location = new System.Drawing.Point(0, 52);
		this.Panel101.Name = "Panel101";
		this.Panel101.Size = new System.Drawing.Size(691, 1);
		this.Panel101.TabIndex = 19;
		this.Panel100.BackColor = System.Drawing.Color.Gainsboro;
		this.Panel100.Controls.Add(this.Button43);
		this.Panel100.Controls.Add(this.PictureBox17);
		this.Panel100.Controls.Add(this.Label31);
		this.Panel100.Controls.Add(this.Button104);
		this.Panel100.Controls.Add(this.Label51);
		this.Panel100.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.Panel100.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel100.Location = new System.Drawing.Point(0, 0);
		this.Panel100.Name = "Panel100";
		this.Panel100.Size = new System.Drawing.Size(691, 52);
		this.Panel100.TabIndex = 18;
		this.Button43.BackColor = System.Drawing.Color.DarkGreen;
		this.Button43.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button43.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button43.ForeColor = System.Drawing.Color.White;
		this.Button43.Location = new System.Drawing.Point(524, 14);
		this.Button43.Name = "Button43";
		this.Button43.Size = new System.Drawing.Size(74, 24);
		this.Button43.TabIndex = 19;
		this.Button43.Text = "직접 수정";
		this.Button43.UseVisualStyleBackColor = false;
		this.PictureBox17.Image = mlas_root.My.Resources.Resources.search;
		this.PictureBox17.Location = new System.Drawing.Point(13, 8);
		this.PictureBox17.Name = "PictureBox17";
		this.PictureBox17.Size = new System.Drawing.Size(36, 35);
		this.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox17.TabIndex = 18;
		this.PictureBox17.TabStop = false;
		this.Label31.AutoSize = true;
		this.Label31.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.Label31.Font = new System.Drawing.Font("맑은 고딕", 14f, System.Drawing.FontStyle.Bold);
		this.Label31.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label31.Location = new System.Drawing.Point(50, 7);
		this.Label31.Name = "Label31";
		this.Label31.Size = new System.Drawing.Size(95, 25);
		this.Label31.TabIndex = 0;
		this.Label31.Text = "주소 찾기";
		this.Button104.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button104.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button104.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button104.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button104.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button104.ForeColor = System.Drawing.Color.White;
		this.Button104.Location = new System.Drawing.Point(604, 14);
		this.Button104.Name = "Button104";
		this.Button104.Size = new System.Drawing.Size(63, 24);
		this.Button104.TabIndex = 4;
		this.Button104.Text = "창 닫기";
		this.Button104.UseVisualStyleBackColor = false;
		this.Label51.AutoSize = true;
		this.Label51.Cursor = System.Windows.Forms.Cursors.SizeAll;
		this.Label51.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label51.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
		this.Label51.Location = new System.Drawing.Point(53, 30);
		this.Label51.Name = "Label51";
		this.Label51.Size = new System.Drawing.Size(227, 15);
		this.Label51.TabIndex = 17;
		this.Label51.Text = "도로명 / 지번 주소로 찾기가 가능합니다.";
		this.TabPage7.Controls.Add(this.p5);
		this.TabPage7.Location = new System.Drawing.Point(4, 22);
		this.TabPage7.Name = "TabPage7";
		this.TabPage7.Size = new System.Drawing.Size(1238, 808);
		this.TabPage7.TabIndex = 14;
		this.TabPage7.Text = "주문접수";
		this.TabPage7.UseVisualStyleBackColor = true;
		this.p5.BackColor = System.Drawing.Color.LightGray;
		this.p5.Controls.Add(this.DoubleBufferPanel24);
		this.p5.Controls.Add(this.DoubleBufferPanel7);
		this.p5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p5.Location = new System.Drawing.Point(0, 0);
		this.p5.Name = "p5";
		this.p5.Size = new System.Drawing.Size(1238, 808);
		this.p5.TabIndex = 0;
		this.DoubleBufferPanel24.Controls.Add(this.DoubleBufferPanel25);
		this.DoubleBufferPanel24.Controls.Add(this.DoubleBufferPanel19);
		this.DoubleBufferPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DoubleBufferPanel24.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel24.Name = "DoubleBufferPanel24";
		this.DoubleBufferPanel24.Padding = new System.Windows.Forms.Padding(10);
		this.DoubleBufferPanel24.Size = new System.Drawing.Size(1238, 764);
		this.DoubleBufferPanel24.TabIndex = 105;
		this.DoubleBufferPanel25.Controls.Add(this.DoubleBufferPanel20);
		this.DoubleBufferPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DoubleBufferPanel25.Location = new System.Drawing.Point(388, 10);
		this.DoubleBufferPanel25.Name = "DoubleBufferPanel25";
		this.DoubleBufferPanel25.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
		this.DoubleBufferPanel25.Size = new System.Drawing.Size(840, 744);
		this.DoubleBufferPanel25.TabIndex = 105;
		this.DoubleBufferPanel20.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.DoubleBufferPanel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel20.Controls.Add(this.orderProductGrid);
		this.DoubleBufferPanel20.Controls.Add(this.DoubleBufferPanel21);
		this.DoubleBufferPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DoubleBufferPanel20.Location = new System.Drawing.Point(10, 0);
		this.DoubleBufferPanel20.Name = "DoubleBufferPanel20";
		this.DoubleBufferPanel20.Size = new System.Drawing.Size(830, 744);
		this.DoubleBufferPanel20.TabIndex = 104;
		this.orderProductGrid.AllowUserToAddRows = false;
		this.orderProductGrid.AllowUserToDeleteRows = false;
		this.orderProductGrid.AllowUserToResizeRows = false;
		dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.orderProductGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle30;
		this.orderProductGrid.BackgroundColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.orderProductGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle31.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle31.Format = "C2";
		dataGridViewCellStyle31.NullValue = "0";
		dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.orderProductGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
		this.orderProductGrid.ColumnHeadersHeight = 28;
		this.orderProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.orderProductGrid.Columns.AddRange(this.DataGridViewCheckBoxColumn4, this.DataGridViewComboBoxColumn4, this.DataGridViewTextBoxColumn19, this.DataGridViewTextBoxColumn20, this.DataGridViewTextBoxColumn21);
		this.orderProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.orderProductGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.orderProductGrid.EnableHeadersVisualStyles = false;
		this.orderProductGrid.GridColor = System.Drawing.Color.DarkGray;
		this.orderProductGrid.Location = new System.Drawing.Point(0, 63);
		this.orderProductGrid.MultiSelect = false;
		this.orderProductGrid.Name = "orderProductGrid";
		this.orderProductGrid.RowHeadersVisible = false;
		this.orderProductGrid.RowHeadersWidth = 40;
		dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.orderProductGrid.RowsDefaultCellStyle = dataGridViewCellStyle32;
		this.orderProductGrid.RowTemplate.Height = 35;
		this.orderProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.orderProductGrid.Size = new System.Drawing.Size(828, 679);
		this.orderProductGrid.TabIndex = 87;
		this.DataGridViewCheckBoxColumn4.Frozen = true;
		this.DataGridViewCheckBoxColumn4.HeaderText = "";
		this.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4";
		this.DataGridViewCheckBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridViewCheckBoxColumn4.Width = 30;
		this.DataGridViewComboBoxColumn4.HeaderText = "제품구분";
		this.DataGridViewComboBoxColumn4.Name = "DataGridViewComboBoxColumn4";
		this.DataGridViewComboBoxColumn4.ReadOnly = true;
		this.DataGridViewComboBoxColumn4.Width = 60;
		this.DataGridViewTextBoxColumn19.HeaderText = "제품명";
		this.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
		this.DataGridViewTextBoxColumn19.ReadOnly = true;
		this.DataGridViewTextBoxColumn19.Width = 200;
		this.DataGridViewTextBoxColumn20.HeaderText = "가격";
		this.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
		this.DataGridViewTextBoxColumn20.ReadOnly = true;
		this.DataGridViewTextBoxColumn21.HeaderText = "재고";
		this.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
		this.DataGridViewTextBoxColumn21.ReadOnly = true;
		this.DoubleBufferPanel21.Controls.Add(this.CheckBox5);
		this.DoubleBufferPanel21.Controls.Add(this.Button36);
		this.DoubleBufferPanel21.Controls.Add(this.Label42);
		this.DoubleBufferPanel21.Controls.Add(this.TextBox8);
		this.DoubleBufferPanel21.Controls.Add(this.Label35);
		this.DoubleBufferPanel21.Controls.Add(this.Button33);
		this.DoubleBufferPanel21.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel21.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel21.Name = "DoubleBufferPanel21";
		this.DoubleBufferPanel21.Size = new System.Drawing.Size(828, 63);
		this.DoubleBufferPanel21.TabIndex = 88;
		this.CheckBox5.AutoSize = true;
		this.CheckBox5.ForeColor = System.Drawing.Color.Blue;
		this.CheckBox5.Location = new System.Drawing.Point(420, 12);
		this.CheckBox5.Name = "CheckBox5";
		this.CheckBox5.Size = new System.Drawing.Size(112, 16);
		this.CheckBox5.TabIndex = 106;
		this.CheckBox5.Text = "체크된 제품보기";
		this.CheckBox5.UseVisualStyleBackColor = true;
		this.Button36.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button36.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button36.ForeColor = System.Drawing.Color.White;
		this.Button36.Location = new System.Drawing.Point(386, 32);
		this.Button36.Name = "Button36";
		this.Button36.Size = new System.Drawing.Size(146, 24);
		this.Button36.TabIndex = 105;
		this.Button36.Text = "제품목록 새로고침";
		this.Button36.UseVisualStyleBackColor = false;
		this.Label42.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label42.ForeColor = System.Drawing.Color.Blue;
		this.Label42.Location = new System.Drawing.Point(3, 38);
		this.Label42.Name = "Label42";
		this.Label42.Size = new System.Drawing.Size(35, 12);
		this.Label42.TabIndex = 102;
		this.Label42.Text = "검색";
		this.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox8.BackColor = System.Drawing.Color.White;
		this.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox8.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox8.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox8.Location = new System.Drawing.Point(38, 33);
		this.TextBox8.Name = "TextBox8";
		this.TextBox8.Size = new System.Drawing.Size(254, 22);
		this.TextBox8.TabIndex = 18;
		this.Label35.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label35.ForeColor = System.Drawing.Color.Black;
		this.Label35.Location = new System.Drawing.Point(12, 12);
		this.Label35.Name = "Label35";
		this.Label35.Size = new System.Drawing.Size(257, 12);
		this.Label35.TabIndex = 86;
		this.Label35.Text = "* 제품 주문 (체크된 제품이 주문됩니다.)";
		this.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button33.BackColor = System.Drawing.Color.Magenta;
		this.Button33.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button33.ForeColor = System.Drawing.Color.White;
		this.Button33.Location = new System.Drawing.Point(293, 32);
		this.Button33.Name = "Button33";
		this.Button33.Size = new System.Drawing.Size(93, 24);
		this.Button33.TabIndex = 104;
		this.Button33.Text = "검색 초기화";
		this.Button33.UseVisualStyleBackColor = false;
		this.DoubleBufferPanel19.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.DoubleBufferPanel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel19.Controls.Add(this.Panel1);
		this.DoubleBufferPanel19.Controls.Add(this.Label40);
		this.DoubleBufferPanel19.Controls.Add(this.order_address);
		this.DoubleBufferPanel19.Controls.Add(this.order_delivery);
		this.DoubleBufferPanel19.Controls.Add(this.order_name);
		this.DoubleBufferPanel19.Controls.Add(this.Label25);
		this.DoubleBufferPanel19.Controls.Add(this.Label36);
		this.DoubleBufferPanel19.Controls.Add(this.order_phone3);
		this.DoubleBufferPanel19.Controls.Add(this.Label37);
		this.DoubleBufferPanel19.Controls.Add(this.order_phone2);
		this.DoubleBufferPanel19.Controls.Add(this.Button30);
		this.DoubleBufferPanel19.Controls.Add(this.order_phone1);
		this.DoubleBufferPanel19.Controls.Add(this.Label26);
		this.DoubleBufferPanel19.Controls.Add(this.Label41);
		this.DoubleBufferPanel19.Controls.Add(this.Label28);
		this.DoubleBufferPanel19.Controls.Add(this.order_call3);
		this.DoubleBufferPanel19.Controls.Add(this.CheckBox2);
		this.DoubleBufferPanel19.Controls.Add(this.order_call2);
		this.DoubleBufferPanel19.Controls.Add(this.CheckBox3);
		this.DoubleBufferPanel19.Controls.Add(this.order_call1);
		this.DoubleBufferPanel19.Controls.Add(this.Label29);
		this.DoubleBufferPanel19.Controls.Add(this.Button31);
		this.DoubleBufferPanel19.Controls.Add(this.order_delivery_more);
		this.DoubleBufferPanel19.Controls.Add(this.Label30);
		this.DoubleBufferPanel19.Controls.Add(this.order_etc);
		this.DoubleBufferPanel19.Controls.Add(this.Label33);
		this.DoubleBufferPanel19.Controls.Add(this.Label34);
		this.DoubleBufferPanel19.Controls.Add(this.Button32);
		this.DoubleBufferPanel19.Controls.Add(this.CheckBox4);
		this.DoubleBufferPanel19.Controls.Add(this.Label32);
		this.DoubleBufferPanel19.Controls.Add(this.order_address_more);
		this.DoubleBufferPanel19.Dock = System.Windows.Forms.DockStyle.Left;
		this.DoubleBufferPanel19.Location = new System.Drawing.Point(10, 10);
		this.DoubleBufferPanel19.Name = "DoubleBufferPanel19";
		this.DoubleBufferPanel19.Size = new System.Drawing.Size(378, 744);
		this.DoubleBufferPanel19.TabIndex = 103;
		this.Panel1.Controls.Add(this.Button44);
		this.Panel1.Controls.Add(this.Button45);
		this.Panel1.Location = new System.Drawing.Point(160, 467);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(200, 100);
		this.Panel1.TabIndex = 104;
		this.Panel1.Visible = false;
		this.Button44.BackColor = System.Drawing.Color.DarkGreen;
		this.Button44.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button44.ForeColor = System.Drawing.Color.White;
		this.Button44.Location = new System.Drawing.Point(83, 3);
		this.Button44.Name = "Button44";
		this.Button44.Size = new System.Drawing.Size(114, 38);
		this.Button44.TabIndex = 102;
		this.Button44.Text = "주문 완료";
		this.Button44.UseVisualStyleBackColor = false;
		this.Button45.BackColor = System.Drawing.Color.Red;
		this.Button45.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button45.ForeColor = System.Drawing.Color.White;
		this.Button45.Location = new System.Drawing.Point(83, 47);
		this.Button45.Name = "Button45";
		this.Button45.Size = new System.Drawing.Size(114, 38);
		this.Button45.TabIndex = 103;
		this.Button45.Text = "주문서 초기화";
		this.Button45.UseVisualStyleBackColor = false;
		this.Label40.AutoSize = true;
		this.Label40.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label40.ForeColor = System.Drawing.Color.Black;
		this.Label40.Location = new System.Drawing.Point(143, 175);
		this.Label40.Name = "Label40";
		this.Label40.Size = new System.Drawing.Size(12, 12);
		this.Label40.TabIndex = 101;
		this.Label40.Text = "-";
		this.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.order_address.BackColor = System.Drawing.Color.White;
		this.order_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_address.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_address.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_address.Location = new System.Drawing.Point(26, 346);
		this.order_address.Name = "order_address";
		this.order_address.ReadOnly = true;
		this.order_address.Size = new System.Drawing.Size(333, 22);
		this.order_address.TabIndex = 15;
		this.order_delivery.BackColor = System.Drawing.Color.White;
		this.order_delivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_delivery.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_delivery.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_delivery.Location = new System.Drawing.Point(26, 235);
		this.order_delivery.Name = "order_delivery";
		this.order_delivery.ReadOnly = true;
		this.order_delivery.Size = new System.Drawing.Size(333, 22);
		this.order_delivery.TabIndex = 11;
		this.order_name.BackColor = System.Drawing.Color.White;
		this.order_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_name.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_name.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_name.Location = new System.Drawing.Point(26, 40);
		this.order_name.Name = "order_name";
		this.order_name.Size = new System.Drawing.Size(175, 22);
		this.order_name.TabIndex = 0;
		this.Label25.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label25.ForeColor = System.Drawing.Color.Black;
		this.Label25.Location = new System.Drawing.Point(14, 25);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(112, 12);
		this.Label25.TabIndex = 64;
		this.Label25.Text = "* 고객명";
		this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label36.AutoSize = true;
		this.Label36.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label36.ForeColor = System.Drawing.Color.Black;
		this.Label36.Location = new System.Drawing.Point(71, 110);
		this.Label36.Name = "Label36";
		this.Label36.Size = new System.Drawing.Size(12, 12);
		this.Label36.TabIndex = 95;
		this.Label36.Text = "-";
		this.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.order_phone3.BackColor = System.Drawing.Color.White;
		this.order_phone3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_phone3.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_phone3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_phone3.Location = new System.Drawing.Point(158, 170);
		this.order_phone3.MaxLength = 4;
		this.order_phone3.Name = "order_phone3";
		this.order_phone3.Size = new System.Drawing.Size(54, 22);
		this.order_phone3.TabIndex = 8;
		this.order_phone3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label37.AutoSize = true;
		this.Label37.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label37.ForeColor = System.Drawing.Color.Black;
		this.Label37.Location = new System.Drawing.Point(143, 110);
		this.Label37.Name = "Label37";
		this.Label37.Size = new System.Drawing.Size(12, 12);
		this.Label37.TabIndex = 96;
		this.Label37.Text = "-";
		this.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.order_phone2.BackColor = System.Drawing.Color.White;
		this.order_phone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_phone2.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_phone2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_phone2.Location = new System.Drawing.Point(86, 170);
		this.order_phone2.MaxLength = 4;
		this.order_phone2.Name = "order_phone2";
		this.order_phone2.Size = new System.Drawing.Size(53, 22);
		this.order_phone2.TabIndex = 7;
		this.order_phone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Button30.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button30.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button30.ForeColor = System.Drawing.Color.White;
		this.Button30.Location = new System.Drawing.Point(199, 39);
		this.Button30.Name = "Button30";
		this.Button30.Size = new System.Drawing.Size(160, 24);
		this.Button30.TabIndex = 1;
		this.Button30.Text = "내 고객 검색";
		this.Button30.UseVisualStyleBackColor = false;
		this.order_phone1.BackColor = System.Drawing.Color.White;
		this.order_phone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_phone1.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_phone1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_phone1.Location = new System.Drawing.Point(26, 170);
		this.order_phone1.MaxLength = 3;
		this.order_phone1.Name = "order_phone1";
		this.order_phone1.Size = new System.Drawing.Size(43, 22);
		this.order_phone1.TabIndex = 6;
		this.order_phone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label26.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label26.ForeColor = System.Drawing.Color.Black;
		this.Label26.Location = new System.Drawing.Point(14, 90);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(112, 12);
		this.Label26.TabIndex = 66;
		this.Label26.Text = "* 자택 전화번호";
		this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label41.AutoSize = true;
		this.Label41.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label41.ForeColor = System.Drawing.Color.Black;
		this.Label41.Location = new System.Drawing.Point(71, 175);
		this.Label41.Name = "Label41";
		this.Label41.Size = new System.Drawing.Size(12, 12);
		this.Label41.TabIndex = 100;
		this.Label41.Text = "-";
		this.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label28.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label28.ForeColor = System.Drawing.Color.Black;
		this.Label28.Location = new System.Drawing.Point(14, 155);
		this.Label28.Name = "Label28";
		this.Label28.Size = new System.Drawing.Size(112, 12);
		this.Label28.TabIndex = 69;
		this.Label28.Text = "* 휴대전화";
		this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.order_call3.BackColor = System.Drawing.Color.White;
		this.order_call3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_call3.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_call3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_call3.Location = new System.Drawing.Point(158, 105);
		this.order_call3.MaxLength = 4;
		this.order_call3.Name = "order_call3";
		this.order_call3.Size = new System.Drawing.Size(54, 22);
		this.order_call3.TabIndex = 4;
		this.order_call3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.ForeColor = System.Drawing.Color.Blue;
		this.CheckBox2.Location = new System.Drawing.Point(257, 108);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(100, 16);
		this.CheckBox2.TabIndex = 5;
		this.CheckBox2.Text = "자택전화 없음";
		this.CheckBox2.UseVisualStyleBackColor = true;
		this.order_call2.BackColor = System.Drawing.Color.White;
		this.order_call2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_call2.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_call2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_call2.Location = new System.Drawing.Point(86, 105);
		this.order_call2.MaxLength = 4;
		this.order_call2.Name = "order_call2";
		this.order_call2.Size = new System.Drawing.Size(53, 22);
		this.order_call2.TabIndex = 3;
		this.order_call2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.CheckBox3.AutoSize = true;
		this.CheckBox3.ForeColor = System.Drawing.Color.Blue;
		this.CheckBox3.Location = new System.Drawing.Point(257, 174);
		this.CheckBox3.Name = "CheckBox3";
		this.CheckBox3.Size = new System.Drawing.Size(100, 16);
		this.CheckBox3.TabIndex = 9;
		this.CheckBox3.Text = "휴대전화 없음";
		this.CheckBox3.UseVisualStyleBackColor = true;
		this.order_call1.BackColor = System.Drawing.Color.White;
		this.order_call1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_call1.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_call1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_call1.Location = new System.Drawing.Point(26, 105);
		this.order_call1.MaxLength = 3;
		this.order_call1.Name = "order_call1";
		this.order_call1.Size = new System.Drawing.Size(43, 22);
		this.order_call1.TabIndex = 2;
		this.order_call1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label29.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label29.ForeColor = System.Drawing.Color.Black;
		this.Label29.Location = new System.Drawing.Point(14, 220);
		this.Label29.Name = "Label29";
		this.Label29.Size = new System.Drawing.Size(112, 12);
		this.Label29.TabIndex = 73;
		this.Label29.Text = "* 상품 배송지";
		this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button31.BackColor = System.Drawing.Color.Blue;
		this.Button31.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button31.ForeColor = System.Drawing.Color.White;
		this.Button31.Location = new System.Drawing.Point(200, 213);
		this.Button31.Name = "Button31";
		this.Button31.Size = new System.Drawing.Size(160, 24);
		this.Button31.TabIndex = 10;
		this.Button31.Text = "우편번호 조회";
		this.Button31.UseVisualStyleBackColor = false;
		this.order_delivery_more.BackColor = System.Drawing.Color.White;
		this.order_delivery_more.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_delivery_more.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_delivery_more.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_delivery_more.Location = new System.Drawing.Point(90, 259);
		this.order_delivery_more.Name = "order_delivery_more";
		this.order_delivery_more.Size = new System.Drawing.Size(269, 22);
		this.order_delivery_more.TabIndex = 12;
		this.Label30.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label30.ForeColor = System.Drawing.Color.Black;
		this.Label30.Location = new System.Drawing.Point(16, 264);
		this.Label30.Name = "Label30";
		this.Label30.Size = new System.Drawing.Size(73, 12);
		this.Label30.TabIndex = 77;
		this.Label30.Text = "나머지 주소";
		this.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.order_etc.BackColor = System.Drawing.Color.White;
		this.order_etc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_etc.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_etc.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_etc.Location = new System.Drawing.Point(26, 434);
		this.order_etc.Name = "order_etc";
		this.order_etc.Size = new System.Drawing.Size(333, 22);
		this.order_etc.TabIndex = 17;
		this.Label33.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label33.ForeColor = System.Drawing.Color.Black;
		this.Label33.Location = new System.Drawing.Point(14, 308);
		this.Label33.Name = "Label33";
		this.Label33.Size = new System.Drawing.Size(130, 12);
		this.Label33.TabIndex = 78;
		this.Label33.Text = "* 자택 및 직장주소";
		this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label34.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label34.ForeColor = System.Drawing.Color.Black;
		this.Label34.Location = new System.Drawing.Point(14, 419);
		this.Label34.Name = "Label34";
		this.Label34.Size = new System.Drawing.Size(112, 12);
		this.Label34.TabIndex = 84;
		this.Label34.Text = "비고";
		this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button32.BackColor = System.Drawing.Color.Blue;
		this.Button32.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button32.ForeColor = System.Drawing.Color.White;
		this.Button32.Location = new System.Drawing.Point(200, 324);
		this.Button32.Name = "Button32";
		this.Button32.Size = new System.Drawing.Size(160, 24);
		this.Button32.TabIndex = 14;
		this.Button32.Text = "우편번호 조회";
		this.Button32.UseVisualStyleBackColor = false;
		this.CheckBox4.AutoSize = true;
		this.CheckBox4.ForeColor = System.Drawing.Color.Blue;
		this.CheckBox4.Location = new System.Drawing.Point(26, 327);
		this.CheckBox4.Name = "CheckBox4";
		this.CheckBox4.Size = new System.Drawing.Size(100, 16);
		this.CheckBox4.TabIndex = 13;
		this.CheckBox4.Text = "배송지와 동일";
		this.CheckBox4.UseVisualStyleBackColor = true;
		this.Label32.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label32.ForeColor = System.Drawing.Color.Black;
		this.Label32.Location = new System.Drawing.Point(16, 375);
		this.Label32.Name = "Label32";
		this.Label32.Size = new System.Drawing.Size(73, 12);
		this.Label32.TabIndex = 82;
		this.Label32.Text = "나머지 주소";
		this.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.order_address_more.BackColor = System.Drawing.Color.White;
		this.order_address_more.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.order_address_more.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.order_address_more.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.order_address_more.Location = new System.Drawing.Point(90, 370);
		this.order_address_more.Name = "order_address_more";
		this.order_address_more.Size = new System.Drawing.Size(269, 22);
		this.order_address_more.TabIndex = 16;
		this.DoubleBufferPanel7.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.DoubleBufferPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel7.Controls.Add(this.Button41);
		this.DoubleBufferPanel7.Controls.Add(this.Button39);
		this.DoubleBufferPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel7.Location = new System.Drawing.Point(0, 764);
		this.DoubleBufferPanel7.Name = "DoubleBufferPanel7";
		this.DoubleBufferPanel7.Padding = new System.Windows.Forms.Padding(4);
		this.DoubleBufferPanel7.Size = new System.Drawing.Size(1238, 44);
		this.DoubleBufferPanel7.TabIndex = 102;
		this.Button41.BackColor = System.Drawing.Color.Red;
		this.Button41.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button41.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button41.ForeColor = System.Drawing.Color.White;
		this.Button41.Location = new System.Drawing.Point(1118, 4);
		this.Button41.Name = "Button41";
		this.Button41.Size = new System.Drawing.Size(114, 34);
		this.Button41.TabIndex = 52;
		this.Button41.Text = "주문서 초기화";
		this.Button41.UseVisualStyleBackColor = false;
		this.Button39.BackColor = System.Drawing.Color.DarkGreen;
		this.Button39.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button39.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button39.ForeColor = System.Drawing.Color.White;
		this.Button39.Location = new System.Drawing.Point(4, 4);
		this.Button39.Name = "Button39";
		this.Button39.Size = new System.Drawing.Size(114, 34);
		this.Button39.TabIndex = 78;
		this.Button39.Text = "주문 완료";
		this.Button39.UseVisualStyleBackColor = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1246, 834);
		base.Controls.Add(this.TabControl1);
		this.DoubleBuffered = true;
		base.Name = "android_db_ss_order";
		this.Text = "android_db_ss_order";
		this.TabControl1.ResumeLayout(false);
		this.TabPage6.ResumeLayout(false);
		this.pHome.ResumeLayout(false);
		this.Panel9.ResumeLayout(false);
		this.Panel9.PerformLayout();
		this.TabPage1.ResumeLayout(false);
		this.p1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.orderGrid).EndInit();
		this.DoubleBufferPanel18.ResumeLayout(false);
		this.Panel68.ResumeLayout(false);
		this.Panel68.PerformLayout();
		this.Panel72.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.p2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.customerGrid).EndInit();
		this.DoubleBufferPanel2.ResumeLayout(false);
		this.DoubleBufferPanel2.PerformLayout();
		this.DoubleBufferPanel6.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.p3.ResumeLayout(false);
		this.p3_centerpanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.productGrid).EndInit();
		this.DoubleBufferPanel8.ResumeLayout(false);
		this.DoubleBufferPanel8.PerformLayout();
		this.DoubleBufferPanel12.ResumeLayout(false);
		this.TabPage5.ResumeLayout(false);
		this.p4.ResumeLayout(false);
		this.p4_centerpanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.accountGrid).EndInit();
		this.DoubleBufferPanel13.ResumeLayout(false);
		this.DoubleBufferPanel13.PerformLayout();
		this.DoubleBufferPanel17.ResumeLayout(false);
		this.TabPage4.ResumeLayout(false);
		this.diag_orderList.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgv_orderList).EndInit();
		this.DoubleBufferPanel23.ResumeLayout(false);
		this.DoubleBufferPanel23.PerformLayout();
		this.diag_customer.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgv_customer).EndInit();
		this.DoubleBufferPanel28.ResumeLayout(false);
		this.DoubleBufferPanel28.PerformLayout();
		this.diag_address.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.addressGrid).EndInit();
		this.Panel163.ResumeLayout(false);
		this.Panel163.PerformLayout();
		this.DoubleBufferPanel1.ResumeLayout(false);
		this.DoubleBufferPanel1.PerformLayout();
		this.Panel99.ResumeLayout(false);
		this.Panel99.PerformLayout();
		this.Panel120.ResumeLayout(false);
		this.Panel120.PerformLayout();
		this.Panel100.ResumeLayout(false);
		this.Panel100.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox17).EndInit();
		this.TabPage7.ResumeLayout(false);
		this.p5.ResumeLayout(false);
		this.DoubleBufferPanel24.ResumeLayout(false);
		this.DoubleBufferPanel25.ResumeLayout(false);
		this.DoubleBufferPanel20.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.orderProductGrid).EndInit();
		this.DoubleBufferPanel21.ResumeLayout(false);
		this.DoubleBufferPanel21.PerformLayout();
		this.DoubleBufferPanel19.ResumeLayout(false);
		this.DoubleBufferPanel19.PerformLayout();
		this.Panel1.ResumeLayout(false);
		this.DoubleBufferPanel7.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void backupSub(string name, object cls)
	{
		if (busy)
		{
			return;
		}
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			SaveFileDialog saveFileDialog2 = saveFileDialog;
			saveFileDialog2.Filter = "*.csv|*.csv";
			saveFileDialog2.FileName = name + "_" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd(HH시mm분ss초)") + ".csv";
			saveFileDialog2.InitialDirectory = Environment.CurrentDirectory;
			saveFileDialog2.Title = "백업 경로를 지정하세요.";
			if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			if (saveFileDialog2.FileName.ToLower().LastIndexOf("csv") < 0)
			{
				MessageBox.Show("CSV 확장자가 아니면 백업할 수 없습니다!", "확장자 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			saveFileDialog2 = null;
			base.Enabled = false;
			busy = true;
			string text = null;
			using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, append: false, Encoding.Default))
			{
				streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(cls, null, "ColumnHeaderText", new object[0], null, null, null)));
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((IEnumerable)NewLateBinding.LateGet(cls, null, "getData", new object[0], null, null, null)).GetEnumerator();
					IEnumerator enumerator2 = default(IEnumerator);
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						try
						{
							if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue, null, "_check", new object[0], null, null, null))))
							{
								continue;
							}
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						text = null;
						try
						{
							enumerator2 = ((IEnumerable)NewLateBinding.LateGet(objectValue, null, "getArray", new object[0], null, null, null)).GetEnumerator();
							while (enumerator2.MoveNext())
							{
								string text2 = Conversions.ToString(enumerator2.Current);
								text = ((Operators.CompareString(text2, null, TextCompare: false) != 0) ? ((!text2.Contains(",")) ? (text + text2.Trim() + ",") : (text + "\"" + text2.Trim() + "\",")) : (text + ","));
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						streamWriter.WriteLine(text.Replace("\r\n", ""));
						Application.DoEvents();
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			MessageBox.Show("테이블 백업이 완료되었습니다.", "백업 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			MessageBox.Show("테이블 백업에 실패 했습니다.\r\n\r\n" + ex4.Message, "백업 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			ProjectData.ClearProjectError();
		}
		busy = false;
		base.Enabled = true;
	}

	private void Button22_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = MyProject.Forms.mlas.ListBox1.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(MyProject.Forms.mlas.ListBox1.Items[i].ToString().Trim(), "주문 접수", TextCompare: false) == 0)
				{
					MyProject.Forms.mlas.ListBox1.SelectedIndex = i;
					break;
				}
			}
		}
	}

	private void Button23_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = MyProject.Forms.mlas.ListBox1.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (MyProject.Forms.mlas.ListBox1.Items[i].ToString().Trim().Equals("조회") | MyProject.Forms.mlas.ListBox1.Items[i].ToString().Trim().Equals("주문 관리"))
				{
					MyProject.Forms.mlas.ListBox1.SelectedIndex = i;
					break;
				}
			}
		}
	}

	private void Button77_Click(object sender, EventArgs e)
	{
		errorIndex = null;
		orderProduct();
		Label23.Text = Conversions.ToString(DateAndTime.Now.AddDays(-7.0).Date) + " ~ " + Conversions.ToString(DateAndTime.Now.Date);
		searchOrder();
	}

	private void Button158_Click(object sender, EventArgs e)
	{
		DateTimePicker1.Value = DateAndTime.Now.Date;
		DateTimePicker2.Value = DateAndTime.Now.Date;
	}

	public void ss_order_init()
	{
		if (isOrderPageInit)
		{
			return;
		}
		isOrderPageInit = true;
		if ((ssorder.ssorder_acgb == 1) | (ssorder.ssorder_acgb == 2))
		{
			orderGrid.Columns[4].ReadOnly = true;
			Button40.Hide();
			Button34.Hide();
			Button35.Hide();
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dgv_orderList.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					((DataGridViewColumn)enumerator.Current).ReadOnly = true;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		if (ssorder.ssorder_acgb == 2)
		{
			Button28.Show();
			Panel68.Visible = false;
			Panel72.Visible = false;
			DoubleBufferPanel18.Show();
			Label23.Text = Conversions.ToString(DateAndTime.Now.AddDays(-7.0).Date) + " ~ " + Conversions.ToString(DateAndTime.Now.Date);
			orderGrid.Columns[0].Visible = false;
			orderGrid.Columns[1].HeaderText = "판매자명";
			orderGrid.Columns[2].HeaderText = "번호";
			orderGrid.Columns[4].ReadOnly = true;
			orderGrid.Columns[12].ReadOnly = true;
			orderGrid.Columns.Add(new DataGridViewButtonColumn());
			orderGrid.Columns[checked(orderGrid.Columns.Count - 1)].HeaderText = "발송전 취소";
			_ = null;
		}
		DateTimePicker1.Value = DateAndTime.Now.AddDays(-3.0).Date;
		DateTimePicker2.Value = DateAndTime.Now.Date;
		order_status.SelectedIndex = 0;
	}

	public void searchOrder()
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = order_account.Text.Trim();
		string text2 = order_customer.Text.Trim();
		string text3 = order_phone.Text;
		int selectedIndex = order_status.SelectedIndex;
		orderGrid.Rows.Clear();
		string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=getOrderV3&dateFrom="), DateTimePicker1.Value.Date), "&dateTo="), DateTimePicker2.Value.Date)), Conversions.ToString(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 2, "&tc=99&ac=" + Conversions.ToString(ssorder.ssorder_account_code), ""))), progress: true).getHTML(this);
		if (hTML.Equals("fail"))
		{
			Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
			busy = false;
			return;
		}
		checked
		{
			try
			{
				JObject jObject = JObject.Parse(hTML);
				ss_order = JsonConvert.DeserializeObject<List<db_ss_order>>((string)jObject.SelectToken("ss_order"));
				ss_account = JsonConvert.DeserializeObject<List<db_ss_account>>((string)jObject.SelectToken("ss_account"));
				ssorder.orderClass = new ssorder_orderClass(ss_order);
				foreach (ssorder_orderClass.deepClass datum in ssorder.orderClass.getData())
				{
					try
					{
						if ((Operators.CompareString(text, null, TextCompare: false) != 0) & !datum.getAccountName().Contains(text))
						{
							datum._visible = false;
							continue;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					try
					{
						if ((Operators.CompareString(text2, null, TextCompare: false) != 0) & !datum.getCustomerName().Contains(text2))
						{
							datum._visible = false;
							continue;
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
					try
					{
						if ((Operators.CompareString(text3, null, TextCompare: false) != 0) & !datum.getCustomerPhoneNumber().Contains(text3))
						{
							datum._visible = false;
							continue;
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ProjectData.ClearProjectError();
					}
					try
					{
						if ((selectedIndex != 0) & (datum.getOrderStatus() != selectedIndex))
						{
							datum._visible = false;
							continue;
						}
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						ProjectData.ClearProjectError();
					}
					orderGrid.Rows.Add(datum.getGridData());
					int index = 11;
					switch (datum.getOrderStatus())
					{
					case 1:
						orderGrid.Rows[orderGrid.Rows.Count - 1].Cells[index].Style.BackColor = Color.Purple;
						orderGrid.Rows[orderGrid.Rows.Count - 1].Cells[index].Style.ForeColor = Color.White;
						break;
					case 2:
						orderGrid.Rows[orderGrid.Rows.Count - 1].Cells[index].Style.BackColor = Color.Orange;
						break;
					case 3:
						orderGrid.Rows[orderGrid.Rows.Count - 1].Cells[index].Style.BackColor = Color.Red;
						orderGrid.Rows[orderGrid.Rows.Count - 1].Cells[index].Style.ForeColor = Color.White;
						break;
					case 4:
						orderGrid.Rows[orderGrid.Rows.Count - 1].Cells[index].Style.BackColor = Color.Green;
						orderGrid.Rows[orderGrid.Rows.Count - 1].Cells[index].Style.ForeColor = Color.White;
						break;
					}
					if (ssorder.ssorder_acgb == 2)
					{
						DataGridViewButtonCell obj = (DataGridViewButtonCell)orderGrid.Rows[orderGrid.Rows.Count - 1].Cells[orderGrid.ColumnCount - 1];
						obj.Style.BackColor = Color.Red;
						obj.Style.ForeColor = Color.White;
						obj.Value = "취소하기";
						if (datum.getOrderStatus() > 2)
						{
							orderGrid.Rows[orderGrid.Rows.Count - 1].Cells[orderGrid.ColumnCount - 1] = new DataGridViewTextBoxCell();
							orderGrid.Rows[orderGrid.Rows.Count - 1].Cells[orderGrid.ColumnCount - 1].ReadOnly = true;
						}
					}
				}
				int num = ssorder.orderClass.getData().Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						if (!ssorder.orderClass.getData(i)._visible)
						{
							ssorder.orderClass.getData().RemoveAt(i);
							i--;
						}
					}
					catch (Exception ex9)
					{
						ProjectData.SetProjectError(ex9);
						Exception ex10 = ex9;
						ProjectData.ClearProjectError();
					}
				}
				if (Operators.CompareString(errorIndex, null, TextCompare: false) != 0)
				{
					CustomMsgBox.CMsgBox("특정 레코드에 문제가 있습니다. 데이터를 불러올 수 없습니다. DB에서 직접 보정하십시오.\r\n문제가 되는 INDEX번호: " + errorIndex.Trim(), "파싱 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					errorIndex = null;
				}
			}
			catch (Exception ex11)
			{
				ProjectData.SetProjectError(ex11);
				Exception ex12 = ex11;
				busy = false;
				if (Operators.ConditionalCompareObjectEqual(failCount, 0, TextCompare: false))
				{
					ref object reference = ref failCount;
					reference = Operators.AddObject(reference, 1);
					searchOrder();
				}
				else
				{
					CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다.\r\n검색을 다시 시도 하십시오. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex12.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				}
				ProjectData.ClearProjectError();
			}
			busy = false;
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		bool flag = false;
		int num = 0;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)orderGrid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)((DataGridViewRow)enumerator.Current).Cells[0];
				if (num == 0)
				{
					flag = Conversions.ToBoolean(Interaction.IIf(Conversions.ToBoolean(dataGridViewCheckBoxCell.Value), false, true));
				}
				dataGridViewCheckBoxCell.Value = flag;
				num = checked(num + 1);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		try
		{
			foreach (ssorder_orderClass.deepClass datum in ssorder.orderClass.getData())
			{
				datum._check = flag;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button42_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)orderGrid.Rows).GetEnumerator();
			_Closure_0024__1094_002D0 closure_0024__1094_002D = default(_Closure_0024__1094_002D0);
			while (enumerator.MoveNext())
			{
				closure_0024__1094_002D = new _Closure_0024__1094_002D0(closure_0024__1094_002D);
				closure_0024__1094_002D._0024VB_0024Local_a = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToBoolean(closure_0024__1094_002D._0024VB_0024Local_a.Cells[0].Value))
				{
					ssorder_orderClass.deepClass deepClass = ssorder.orderClass.getData().Find(closure_0024__1094_002D._Lambda_0024__0);
					string str;
					try
					{
						str = Conversions.ToString(Interaction.IIf(closure_0024__1094_002D._0024VB_0024Local_a.Cells[12].Value == null, "", closure_0024__1094_002D._0024VB_0024Local_a.Cells[12].Value.ToString()));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						str = "";
						ProjectData.ClearProjectError();
					}
					string str2;
					try
					{
						str2 = Conversions.ToString(Interaction.IIf(closure_0024__1094_002D._0024VB_0024Local_a.Cells[4].Value == null, "", closure_0024__1094_002D._0024VB_0024Local_a.Cells[4].Value.ToString()));
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						str2 = "";
						ProjectData.ClearProjectError();
					}
					string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=setOrderStatus&i="), closure_0024__1094_002D._0024VB_0024Local_a.Cells[2].Value.ToString()), "&s=1"), "&od="), HttpUtility.UrlEncode(str)), "&oe="), HttpUtility.UrlEncode(str2))), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 2, "&tc=99&ac=" + Conversions.ToString(ssorder.ssorder_account_code), "")), "&oa="), HttpUtility.UrlEncode(closure_0024__1094_002D._0024VB_0024Local_a.Cells[8].Value.ToString())), "&pc="), HttpUtility.UrlEncode(deepClass.getProducts()))), progress: true).getHTML(this);
					if (hTML.Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					if (!hTML.Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 주문 번호 '", closure_0024__1094_002D._0024VB_0024Local_a.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), hTML), "\r\n")));
					}
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
		busy = false;
		searchOrder();
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)orderGrid.Rows).GetEnumerator();
			_Closure_0024__1095_002D0 closure_0024__1095_002D = default(_Closure_0024__1095_002D0);
			while (enumerator.MoveNext())
			{
				closure_0024__1095_002D = new _Closure_0024__1095_002D0(closure_0024__1095_002D);
				closure_0024__1095_002D._0024VB_0024Local_a = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToBoolean(closure_0024__1095_002D._0024VB_0024Local_a.Cells[0].Value))
				{
					ssorder_orderClass.deepClass deepClass = ssorder.orderClass.getData().Find(closure_0024__1095_002D._Lambda_0024__0);
					string str;
					try
					{
						str = Conversions.ToString(Interaction.IIf(closure_0024__1095_002D._0024VB_0024Local_a.Cells[12].Value == null, "", closure_0024__1095_002D._0024VB_0024Local_a.Cells[12].Value.ToString()));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						str = "";
						ProjectData.ClearProjectError();
					}
					string str2;
					try
					{
						str2 = Conversions.ToString(Interaction.IIf(closure_0024__1095_002D._0024VB_0024Local_a.Cells[4].Value == null, "", closure_0024__1095_002D._0024VB_0024Local_a.Cells[4].Value.ToString()));
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						str2 = "";
						ProjectData.ClearProjectError();
					}
					string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=setOrderStatus&i="), closure_0024__1095_002D._0024VB_0024Local_a.Cells[2].Value.ToString()), "&s=2"), "&od="), HttpUtility.UrlEncode(str)), "&oe="), HttpUtility.UrlEncode(str2))), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 2, "&tc=99&ac=" + Conversions.ToString(ssorder.ssorder_account_code), "")), "&oa="), HttpUtility.UrlEncode(closure_0024__1095_002D._0024VB_0024Local_a.Cells[8].Value.ToString())), "&pc="), HttpUtility.UrlEncode(deepClass.getProducts()))), progress: true).getHTML(this);
					if (hTML.Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					if (!hTML.Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 주문 번호 '", closure_0024__1095_002D._0024VB_0024Local_a.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), hTML), "\r\n")));
					}
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
		busy = false;
		searchOrder();
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)orderGrid.Rows).GetEnumerator();
			_Closure_0024__1096_002D0 closure_0024__1096_002D = default(_Closure_0024__1096_002D0);
			while (enumerator.MoveNext())
			{
				closure_0024__1096_002D = new _Closure_0024__1096_002D0(closure_0024__1096_002D);
				closure_0024__1096_002D._0024VB_0024Local_a = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToBoolean(closure_0024__1096_002D._0024VB_0024Local_a.Cells[0].Value))
				{
					ssorder_orderClass.deepClass deepClass = ssorder.orderClass.getData().Find(closure_0024__1096_002D._Lambda_0024__0);
					string str;
					try
					{
						str = Conversions.ToString(Interaction.IIf(closure_0024__1096_002D._0024VB_0024Local_a.Cells[12].Value == null, "", closure_0024__1096_002D._0024VB_0024Local_a.Cells[12].Value.ToString()));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						str = "";
						ProjectData.ClearProjectError();
					}
					string str2;
					try
					{
						str2 = Conversions.ToString(Interaction.IIf(closure_0024__1096_002D._0024VB_0024Local_a.Cells[4].Value == null, "", closure_0024__1096_002D._0024VB_0024Local_a.Cells[4].Value.ToString()));
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						str2 = "";
						ProjectData.ClearProjectError();
					}
					string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=setOrderStatus&i="), closure_0024__1096_002D._0024VB_0024Local_a.Cells[2].Value.ToString()), "&s=3"), "&od="), HttpUtility.UrlEncode(str)), "&oe="), HttpUtility.UrlEncode(str2))), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 2, "&tc=99&ac=" + Conversions.ToString(ssorder.ssorder_account_code), "")), "&oa="), HttpUtility.UrlEncode(closure_0024__1096_002D._0024VB_0024Local_a.Cells[8].Value.ToString())), "&pc="), HttpUtility.UrlEncode(deepClass.getProducts()))), progress: true).getHTML(this);
					if (hTML.Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					if (!hTML.Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 주문 번호 '", closure_0024__1096_002D._0024VB_0024Local_a.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), hTML), "\r\n")));
					}
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
		busy = false;
		searchOrder();
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)orderGrid.Rows).GetEnumerator();
			_Closure_0024__1097_002D0 closure_0024__1097_002D = default(_Closure_0024__1097_002D0);
			while (enumerator.MoveNext())
			{
				closure_0024__1097_002D = new _Closure_0024__1097_002D0(closure_0024__1097_002D);
				closure_0024__1097_002D._0024VB_0024Local_a = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToBoolean(closure_0024__1097_002D._0024VB_0024Local_a.Cells[0].Value))
				{
					ssorder_orderClass.deepClass deepClass = ssorder.orderClass.getData().Find(closure_0024__1097_002D._Lambda_0024__0);
					string str;
					try
					{
						str = Conversions.ToString(Interaction.IIf(closure_0024__1097_002D._0024VB_0024Local_a.Cells[12].Value == null, "", closure_0024__1097_002D._0024VB_0024Local_a.Cells[12].Value.ToString()));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						str = "";
						ProjectData.ClearProjectError();
					}
					string str2;
					try
					{
						str2 = Conversions.ToString(Interaction.IIf(closure_0024__1097_002D._0024VB_0024Local_a.Cells[4].Value == null, "", closure_0024__1097_002D._0024VB_0024Local_a.Cells[4].Value.ToString()));
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						str2 = "";
						ProjectData.ClearProjectError();
					}
					string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=setOrderStatus&i="), closure_0024__1097_002D._0024VB_0024Local_a.Cells[2].Value.ToString()), "&s=4"), "&od="), HttpUtility.UrlEncode(str)), "&oe="), HttpUtility.UrlEncode(str2))), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 2, "&tc=99&ac=" + Conversions.ToString(ssorder.ssorder_account_code), "")), "&oa="), HttpUtility.UrlEncode(closure_0024__1097_002D._0024VB_0024Local_a.Cells[8].Value.ToString())), "&pc="), HttpUtility.UrlEncode(deepClass.getProducts()))), progress: true).getHTML(this);
					if (hTML.Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					if (!hTML.Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 주문 번호 '", closure_0024__1097_002D._0024VB_0024Local_a.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), hTML), "\r\n")));
					}
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
		busy = false;
		searchOrder();
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void Button40_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)orderGrid.Rows).GetEnumerator();
			_Closure_0024__1098_002D0 closure_0024__1098_002D = default(_Closure_0024__1098_002D0);
			while (enumerator.MoveNext())
			{
				closure_0024__1098_002D = new _Closure_0024__1098_002D0(closure_0024__1098_002D);
				closure_0024__1098_002D._0024VB_0024Local_a = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToBoolean(closure_0024__1098_002D._0024VB_0024Local_a.Cells[0].Value))
				{
					ssorder_orderClass.deepClass deepClass = ssorder.orderClass.getData().Find(closure_0024__1098_002D._Lambda_0024__0);
					string str;
					try
					{
						str = Conversions.ToString(Interaction.IIf(closure_0024__1098_002D._0024VB_0024Local_a.Cells[12].Value == null, "", closure_0024__1098_002D._0024VB_0024Local_a.Cells[12].Value.ToString()));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						str = "";
						ProjectData.ClearProjectError();
					}
					string str2;
					try
					{
						str2 = Conversions.ToString(Interaction.IIf(closure_0024__1098_002D._0024VB_0024Local_a.Cells[4].Value == null, "", closure_0024__1098_002D._0024VB_0024Local_a.Cells[4].Value.ToString()));
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						str2 = "";
						ProjectData.ClearProjectError();
					}
					string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ssorder.ssorder_server, "admin.php?t=orderMod&i="), closure_0024__1098_002D._0024VB_0024Local_a.Cells[2].Value), "&od="), HttpUtility.UrlEncode(str)), "&oe="), HttpUtility.UrlEncode(str2))), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 2, "&tc=99&ac=" + Conversions.ToString(ssorder.ssorder_account_code), "")), "&oa="), HttpUtility.UrlEncode(closure_0024__1098_002D._0024VB_0024Local_a.Cells[8].Value.ToString())), "&pc="), HttpUtility.UrlEncode(deepClass.getProducts()))), progress: true).getHTML(this);
					if (hTML.Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					if (!hTML.Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 주문 번호 '", closure_0024__1098_002D._0024VB_0024Local_a.Cells[2].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), hTML), "\r\n")));
					}
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
		busy = false;
		searchOrder();
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		DateTimePicker1.Value = DateAndTime.Now.AddDays(-3.0).Date;
		DateTimePicker2.Value = DateAndTime.Now.Date;
		order_account.Text = null;
		order_customer.Text = null;
		order_phone.Text = null;
		order_status.SelectedIndex = 0;
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		customer_code.Text = null;
		customer_name.Text = null;
		customer_call.Text = null;
		customer_phone.Text = null;
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		bool flag = false;
		try
		{
			foreach (ssorder_orderClass.deepClass datum in ssorder.orderClass.getData())
			{
				if (datum._check)
				{
					flag = datum._check;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		if (!flag)
		{
			CustomMsgBox.CMsgBox("\r\n선택된 항목이 없습니다.", "메시지", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Exclamation);
		}
		else
		{
			if (busy)
			{
				return;
			}
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				SaveFileDialog saveFileDialog2 = saveFileDialog;
				saveFileDialog2.Filter = "*.csv|*.csv";
				saveFileDialog2.FileName = "주문관리_" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd(HH시mm분ss초)") + ".csv";
				saveFileDialog2.InitialDirectory = Environment.CurrentDirectory;
				saveFileDialog2.Title = "백업 경로를 지정하세요.";
				if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
				{
					return;
				}
				if (saveFileDialog2.FileName.ToLower().LastIndexOf("csv") < 0)
				{
					MessageBox.Show("CSV 확장자가 아니면 백업할 수 없습니다!", "확장자 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				saveFileDialog2 = null;
				base.Enabled = false;
				busy = true;
				string text = null;
				using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, append: false, Encoding.Default))
				{
					streamWriter.WriteLine(ssorder.orderClass.ColumnHeaderText());
					foreach (ssorder_orderClass.deepClass datum2 in ssorder.orderClass.getData())
					{
						try
						{
							if (!datum2._check)
							{
								continue;
							}
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
						text = null;
						string[] array = datum2.getArray();
						foreach (string text2 in array)
						{
							text = ((Operators.CompareString(text2, null, TextCompare: false) != 0) ? (text + "\"" + text2 + "\",") : (text + ","));
						}
						text += "\"";
						foreach (ssorder_orderClass.deepClass.product product in datum2._products)
						{
							text = text + "[제품:" + product._name + ", 단가:\\" + Conversions.ToString(product._price) + ",수량:" + product._count + "개,비고:" + product._etc.Replace("\"", "") + "] ";
						}
						streamWriter.WriteLine(text + "\"");
						Application.DoEvents();
					}
				}
				MessageBox.Show("테이블 백업이 완료되었습니다.", "백업 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				MessageBox.Show("테이블 백업에 실패 했습니다.\r\n\r\n" + ex6.Message, "백업 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			busy = false;
			base.Enabled = true;
		}
	}

	private void order_account_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button77_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void orderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		_Closure_0024__1104_002D0 arg = default(_Closure_0024__1104_002D0);
		_Closure_0024__1104_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__1104_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_e = e;
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.Columns[CS_0024_003C_003E8__locals0._0024VB_0024Local_e.ColumnIndex] is DataGridViewCheckBoxColumn && CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex >= 0)
		{
			try
			{
				ssorder.orderClass.getData(CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex)._check = !bool.Parse(Conversions.ToString(dataGridView.Rows[CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex].Cells[0].Value));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (!(dataGridView.Columns[CS_0024_003C_003E8__locals0._0024VB_0024Local_e.ColumnIndex] is DataGridViewButtonColumn) || CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex < 0)
		{
			return;
		}
		checked
		{
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_e.ColumnIndex == orderGrid.ColumnCount - 1)
			{
				DataGridViewCheckBoxCell obj = (DataGridViewCheckBoxCell)orderGrid.Rows[CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex].Cells[0];
				obj.Value = true;
				Button2_Click(RuntimeHelpers.GetObjectValue(sender), CS_0024_003C_003E8__locals0._0024VB_0024Local_e);
				obj.Value = false;
			}
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_e.ColumnIndex == 5)
			{
				if (ssorder.ssorder_acgb == 2)
				{
					return;
				}
				int num = MyProject.Forms.mlas.ListBox1.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(MyProject.Forms.mlas.ListBox1.Items[i].ToString().Trim(), "고객 관리", TextCompare: false) == 0)
					{
						MyProject.Forms.mlas.ListBox1.SelectedIndex = i;
						break;
					}
				}
				Button6_Click(RuntimeHelpers.GetObjectValue(sender), CS_0024_003C_003E8__locals0._0024VB_0024Local_e);
				DataGridView dataGridView2 = (DataGridView)sender;
				customer_name.Text = Conversions.ToString(dataGridView2.Rows[CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex].Cells[5].Value);
				Button8_Click(RuntimeHelpers.GetObjectValue(sender), CS_0024_003C_003E8__locals0._0024VB_0024Local_e);
			}
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_e.ColumnIndex == 6)
			{
				if (ssorder.ssorder_acgb == 2)
				{
					return;
				}
				int num2 = MyProject.Forms.mlas.ListBox1.Items.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (Operators.CompareString(MyProject.Forms.mlas.ListBox1.Items[j].ToString().Trim(), "고객 관리", TextCompare: false) == 0)
					{
						MyProject.Forms.mlas.ListBox1.SelectedIndex = j;
						break;
					}
				}
				Button6_Click(RuntimeHelpers.GetObjectValue(sender), CS_0024_003C_003E8__locals0._0024VB_0024Local_e);
				DataGridView dataGridView3 = (DataGridView)sender;
				customer_call.Text = Conversions.ToString(dataGridView3.Rows[CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex].Cells[6].Value);
				Button8_Click(RuntimeHelpers.GetObjectValue(sender), CS_0024_003C_003E8__locals0._0024VB_0024Local_e);
			}
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_e.ColumnIndex == 7)
			{
				if (ssorder.ssorder_acgb == 2)
				{
					return;
				}
				int num3 = MyProject.Forms.mlas.ListBox1.Items.Count - 1;
				for (int k = 0; k <= num3; k++)
				{
					if (Operators.CompareString(MyProject.Forms.mlas.ListBox1.Items[k].ToString().Trim(), "고객 관리", TextCompare: false) == 0)
					{
						MyProject.Forms.mlas.ListBox1.SelectedIndex = k;
						break;
					}
				}
				Button6_Click(RuntimeHelpers.GetObjectValue(sender), CS_0024_003C_003E8__locals0._0024VB_0024Local_e);
				DataGridView dataGridView4 = (DataGridView)sender;
				customer_phone.Text = Conversions.ToString(dataGridView4.Rows[CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex].Cells[7].Value);
				Button8_Click(RuntimeHelpers.GetObjectValue(sender), CS_0024_003C_003E8__locals0._0024VB_0024Local_e);
			}
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_e.ColumnIndex == 8)
			{
				if ((ssorder.ssorder_acgb == 1) | (ssorder.ssorder_acgb == 2))
				{
					return;
				}
				nowDatagridView = orderGrid;
				Label21.Hide();
				Button122.BackColor = Color.FromArgb(64, 64, 64);
				searchBoolean = false;
				p1.Controls.Add(diag_address);
				diag_address.Size = new Size(diag_address.Width, 109);
				Point point = Module1.ControlCenter(p1, diag_address);
				diag_address.Top = point.X;
				diag_address.Left = point.Y;
				Button43.Tag = orderGrid.Rows[CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex].Cells[8].Value.ToString().Replace("<other>", "");
				rb_dong.Show();
				rb_road.Show();
				Button122.Text = "검색";
				Button43.Text = "직접 수정";
				diag_address.Show();
				diag_address.Tag = new Point(CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex, CS_0024_003C_003E8__locals0._0024VB_0024Local_e.ColumnIndex);
				p1.Controls.SetChildIndex(diag_address, 0);
				TextBox2.Text = null;
				Panel163.Hide();
				TextBox13.Text = null;
				TextBox13.Focus();
			}
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_e.ColumnIndex != 9)
			{
				return;
			}
			p1.Controls.Add(diag_orderList);
			Point point2 = Module1.ControlCenter(p1, diag_orderList);
			diag_orderList.Top = point2.X;
			diag_orderList.Left = point2.Y;
			diag_orderList.Show();
			dgv_orderList.Rows.Clear();
			ssorder_orderClass.deepClass deepClass = (nowOrderProducts = ssorder.orderClass.getData().Find((ssorder_orderClass.deepClass item) => ((double)item.getIndex() == Conversion.Val(RuntimeHelpers.GetObjectValue(CS_0024_003C_003E8__locals0._0024VB_0024Me.orderGrid.Rows[CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex].Cells[2].Value))) ? true : false));
			dgv_orderList.Tag = new Point(CS_0024_003C_003E8__locals0._0024VB_0024Local_e.RowIndex, 0);
			foreach (ssorder_orderClass.deepClass.product product in deepClass._products)
			{
				dgv_orderList.Rows.Add(Interaction.IIf(Conversion.Val(product._gb) == 1.0, "본품", "사례"), product._name, "\\" + Conversion.Val(product._price).ToString("N0"), product._count, product._etc, product._code);
			}
			p1.Controls.SetChildIndex(diag_orderList, 0);
			Button29.Focus();
		}
	}

	private void orderGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		_ = (DataGridView)sender;
		try
		{
			orderGrid.CurrentRow.Cells[0].Value = true;
			ssorder.orderClass.getData(e.RowIndex)._check = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button29_Click(object sender, EventArgs e)
	{
		diag_orderList.Hide();
		checked
		{
			int num = dgv_orderList.RowCount - 1;
			for (int i = 0; i <= num; i++)
			{
				ssorder_orderClass.deepClass.product product = nowOrderProducts._products[i];
				product._price = Conversions.ToInteger(dgv_orderList.Rows[i].Cells[2].Value.ToString().Replace("\\", "").Replace(",", "")
					.Trim());
				product._count = dgv_orderList.Rows[i].Cells[3].Value.ToString().Trim();
				product._etc = dgv_orderList.Rows[i].Cells[4].Value.ToString().Trim();
			}
			orderGrid.Rows[Conversions.ToInteger(NewLateBinding.LateGet(dgv_orderList.Tag, null, "X", new object[0], null, null, null))].Cells[9].Value = RuntimeHelpers.GetObjectValue(nowOrderProducts.getProductNames());
			orderGrid.Rows[Conversions.ToInteger(NewLateBinding.LateGet(dgv_orderList.Tag, null, "X", new object[0], null, null, null))].Cells[10].Value = "\\" + nowOrderProducts.getPrice().ToString("N0");
		}
	}

	private void Button29_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			diag_orderList.Hide();
		}
	}

	public void searchCustomer()
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string right = customer_code.Text.Trim();
		string right2 = customer_name.Text.Trim();
		string right3 = customer_phone.Text;
		string right4 = customer_call.Text;
		customerGrid.Rows.Clear();
		string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=getCustomer&cc="), right), "&cn="), right2), "&cp="), right3), "&call="), right4)), "id=" + Module1._id + "&pw=" + Module1._pw, progress: true).getHTML(this);
		if (hTML.Equals("fail"))
		{
			Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
			busy = false;
			return;
		}
		ssorder.customerClass = new ssorder_customerClass(hTML);
		foreach (ssorder_customerClass.deepClass datum in ssorder.customerClass.getData())
		{
			customerGrid.Rows.Add(datum.getGridData());
		}
		busy = false;
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		searchCustomer();
	}

	private void Button18_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)customerGrid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToBoolean(dataGridViewRow.Cells[0].Value) && MessageBox.Show(Conversions.ToString(Operators.AddObject(Operators.AddObject("고객 번호 '", dataGridViewRow.Cells[1].Value), "' 데이터를 정말 삭제 하시겠습니까?")), "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
				{
					string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=delCustomer&cc="), dataGridViewRow.Cells[1].Value)), "id=" + Module1._id + "&pw=" + Module1._pw, progress: true).getHTML(this);
					if (hTML.Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					if (!hTML.Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 고객 번호 '", dataGridViewRow.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), hTML), "\r\n")));
					}
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
		busy = false;
		searchCustomer();
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)customerGrid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToBoolean(dataGridViewRow.Cells[0].Value))
				{
					string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=modCustomer&cc="), Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells[1].Value, null, TextCompare: false), RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value), "")), "&ac="), NewLateBinding.LateGet(null, typeof(HttpUtility), "UrlEncode", new object[1] { Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells[2].Value, null, TextCompare: false), RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value), "") }, null, null, null)), "&cn="), NewLateBinding.LateGet(null, typeof(HttpUtility), "UrlEncode", new object[1] { Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells[3].Value, null, TextCompare: false), RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[3].Value), "") }, null, null, null)), "&call="), NewLateBinding.LateGet(null, typeof(HttpUtility), "UrlEncode", new object[1] { Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells[4].Value, null, TextCompare: false), RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[4].Value), "") }, null, null, null)), "&cp="), NewLateBinding.LateGet(null, typeof(HttpUtility), "UrlEncode", new object[1] { Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells[5].Value, null, TextCompare: false), RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[5].Value), "") }, null, null, null)), "&ca="), NewLateBinding.LateGet(null, typeof(HttpUtility), "UrlEncode", new object[1] { Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells[6].Value, null, TextCompare: false), RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[6].Value), "") }, null, null, null))), "id=" + Module1._id + "&pw=" + Module1._pw, progress: true).getHTML(this);
					if (hTML.Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					if (!hTML.Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 고객 번호 '", dataGridViewRow.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), hTML), "\r\n")));
					}
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
		busy = false;
		searchCustomer();
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void customerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		_ = (DataGridView)sender;
		try
		{
			customerGrid.CurrentRow.Cells[0].Value = true;
			ssorder.customerClass.getData(e.RowIndex)._check = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
		{
			try
			{
				ssorder.customerClass.getData(e.RowIndex)._check = !bool.Parse(Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells[0].Value));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
		{
			nowDatagridView = customerGrid;
			Label21.Hide();
			Button122.BackColor = Color.FromArgb(64, 64, 64);
			searchBoolean = false;
			p2.Controls.Add(diag_address);
			diag_address.Size = new Size(diag_address.Width, 109);
			Point point = Module1.ControlCenter(p2, diag_address);
			diag_address.Top = point.X;
			diag_address.Left = point.Y;
			diag_address.Show();
			diag_address.Tag = new Point(e.RowIndex, e.ColumnIndex);
			Button43.Tag = RuntimeHelpers.GetObjectValue(dataGridView.Rows[e.RowIndex].Cells[6].Value);
			rb_dong.Show();
			rb_road.Show();
			Button122.Text = "검색";
			Button43.Text = "직접 수정";
			p2.Controls.SetChildIndex(diag_address, 0);
			TextBox2.Text = null;
			Panel163.Hide();
			TextBox13.Text = null;
			TextBox13.Focus();
		}
	}

	private void Panel100_MouseDown(object sender, MouseEventArgs e)
	{
		ObjectMover.FocusObject(diag_address.Handle);
		ObjectMover.MoveObject(diag_address.Handle);
	}

	private void Button104_Click(object sender, EventArgs e)
	{
		diag_address.Hide();
		rb_dong.Show();
		rb_road.Show();
		Button122.Text = "검색";
		Button43.Text = "직접 수정";
	}

	private void Button122_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		if (Button122.Text.Equals("확인"))
		{
			Label7.Text = TextBox13.Text;
			TextBox2.Text = null;
			diag_searchMove_Click(RuntimeHelpers.GetObjectValue(sender), e);
			Button43.Text = "직접 수정";
			Button122.Text = "검색";
			rb_dong.Show();
			rb_road.Show();
		}
		addressGrid.Rows.Clear();
		Panel163.Hide();
		addressArray = new List<addressClass>();
		string text = "dong";
		if (rb_road.Checked)
		{
			text = "road";
		}
		string hTML = new GetHtmlClass("http://openapi.epost.go.kr/postal/retrieveNewAdressAreaCdService/retrieveNewAdressAreaCdService/getNewAddressListAreaCd?ServiceKey=wQ%2FAbKiAjfgBNNG5F%2FGgFypOBN8CyMtru7UsQjAcgMKc50%2BhY7D0aHspt9HIFoUifdgTmEbPK8%2BdumuI9EWVvQ%3D%3D&countPerPage=100&currentPage=1&searchSe=" + text + "&srchwrd=" + TextBox13.Text, null, progress: true).getHTML(this);
		if (!hTML.Contains("<newAddressListAreaCd>"))
		{
			Label21.Show();
			Button122.BackColor = Color.Red;
			searchBoolean = true;
			busy = false;
			return;
		}
		int num = 0;
		string[] array = hTML.Split(new string[1] { "<newAddressListAreaCd>" }, StringSplitOptions.RemoveEmptyEntries);
		checked
		{
			foreach (string text2 in array)
			{
				if (num == 0)
				{
					num = 1;
					continue;
				}
				string zipNo = text2.Substring(text2.IndexOf("<zipNo>") + "<zipNo>".Length, text2.IndexOf("</zipNo>") - "<zipNo>".Length);
				string lnmAdres = text2.Substring(text2.IndexOf("<lnmAdres>") + "<lnmAdres>".Length, text2.IndexOf("</lnmAdres>") - text2.IndexOf("<lnmAdres>") - "<lnmAdres>".Length);
				string rnAdres = text2.Substring(text2.IndexOf("<rnAdres>") + "<rnAdres>".Length, text2.IndexOf("</rnAdres>") - text2.IndexOf("<rnAdres>") - "<rnAdres>".Length);
				addressArray.Add(new addressClass(num, zipNo, lnmAdres, rnAdres));
				addressGrid.Rows.Add(addressArray[addressArray.Count - 1].getArray());
				num++;
			}
			diag_address.Size = new Size(diag_address.Width, 500);
			Point point = Module1.ControlCenter(p2, diag_address);
			diag_address.Top = point.X;
			diag_address.Left = point.Y;
			busy = false;
		}
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		checked
		{
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null)))
			{
				Label7.Text = "(우)" + addressArray[(int)Math.Round(Conversion.Val(Label9.Text) - 1.0)].getArray()[1] + " " + addressArray[(int)Math.Round(Conversion.Val(Label9.Text) - 1.0)].getArray()[3];
			}
			else
			{
				Label7.Text = "(우)" + addressArray[(int)Math.Round(Conversion.Val(Label9.Text) - 1.0)].getArray()[1] + " " + addressArray[(int)Math.Round(Conversion.Val(Label9.Text) - 1.0)].getArray()[2];
			}
			Button43.Tag = Label7.Text.Trim();
			TextBox2.Focus();
		}
	}

	private void addressGrid_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		Panel163.Show();
		Label9.Text = Conversions.ToString(addressGrid.CurrentRow.Cells[0].Value);
		checked
		{
			if (CheckBox1.Checked)
			{
				Label7.Text = "(우)" + addressArray[(int)Math.Round(Conversion.Val(Label9.Text) - 1.0)].getArray()[1] + " " + addressArray[(int)Math.Round(Conversion.Val(Label9.Text) - 1.0)].getArray()[3];
			}
			else
			{
				Label7.Text = "(우)" + addressArray[(int)Math.Round(Conversion.Val(Label9.Text) - 1.0)].getArray()[1] + " " + addressArray[(int)Math.Round(Conversion.Val(Label9.Text) - 1.0)].getArray()[2];
			}
			Button43.Tag = Label7.Text.Trim();
			TextBox2.Focus();
		}
	}

	private void diag_searchMove_Click(object sender, EventArgs e)
	{
		object tag = diag_address.Tag;
		Point point = ((tag != null) ? ((Point)tag) : default(Point));
		if (point.X == 999)
		{
			switch (point.Y)
			{
			case 0:
				order_delivery.Text = Label7.Text;
				order_delivery_more.Text = TextBox2.Text;
				break;
			case 1:
				order_address.Text = Label7.Text;
				order_address_more.Text = TextBox2.Text;
				break;
			}
			diag_address.Hide();
		}
		else
		{
			if (Operators.CompareString(TextBox2.Text.Trim(), null, TextCompare: false) == 0)
			{
				nowDatagridView.Rows[point.X].Cells[point.Y].Value = Label7.Text;
			}
			else
			{
				nowDatagridView.Rows[point.X].Cells[point.Y].Value = Label7.Text + "<other>" + TextBox2.Text;
			}
			nowDatagridView.Rows[point.X].Cells[0].Value = true;
			diag_address.Hide();
		}
	}

	private void TextBox13_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button122_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		else if (searchBoolean)
		{
			Label21.Hide();
			Button122.BackColor = Color.FromArgb(64, 64, 64);
			searchBoolean = false;
		}
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		bool flag = false;
		int num = 0;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)customerGrid.Rows).GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
					if (customerGrid.Rows.Count - 1 != num)
					{
						DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)dataGridViewRow.Cells[0];
						if (num == 0)
						{
							flag = Conversions.ToBoolean(Interaction.IIf(Conversions.ToBoolean(dataGridViewCheckBoxCell.Value), false, true));
						}
						dataGridViewCheckBoxCell.Value = flag;
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
			try
			{
				foreach (ssorder_customerClass.deepClass datum in ssorder.customerClass.getData())
				{
					datum._check = flag;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button16_Click(object sender, EventArgs e)
	{
		bool flag = false;
		try
		{
			foreach (ssorder_customerClass.deepClass datum in ssorder.customerClass.getData())
			{
				if (datum._check)
				{
					flag = datum._check;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		if (!flag)
		{
			CustomMsgBox.CMsgBox("\r\n선택된 항목이 없습니다.", "메시지", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Exclamation);
		}
		else
		{
			backupSub("고객관리", ssorder.customerClass);
		}
	}

	private void customer_code_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button8_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	public void ss_product_init()
	{
		if (!isProductPageInit)
		{
			isProductPageInit = true;
			if (ProductDiag.IsHandleCreated)
			{
				ProductDiag.Close();
			}
			product_team.SelectedIndex = 0;
			product_gb.SelectedIndex = 0;
			productGrid.Rows.Clear();
		}
	}

	public void orderProduct()
	{
		if (!busy)
		{
			busy = true;
			string text = Conversions.ToString(product_team.SelectedIndex);
			string text2 = Conversions.ToString(product_gb.SelectedIndex);
			string right = "";
			string right2 = "";
			text = null;
			text2 = null;
			string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=getProduct&pt="), text), "&pg="), text2), "&pc="), right), "&pn="), right2)), Conversions.ToString(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 2, "&tc=99&ac=" + Conversions.ToString(ssorder.ssorder_account_code), ""))), progress: true).getHTML(this);
			if (hTML.Equals("fail"))
			{
				Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
				busy = false;
			}
			else
			{
				ssorder.order_productClass = new ssorder_productClass(hTML);
				busy = false;
			}
		}
	}

	public void searchProduct()
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = Conversions.ToString(product_team.SelectedIndex);
		string text2 = Conversions.ToString(product_gb.SelectedIndex);
		string right = product_code.Text;
		string right2 = product_name.Text;
		if (Conversion.Val(text) < 1.0)
		{
			text = null;
		}
		if (Conversion.Val(text2) < 1.0)
		{
			text2 = null;
		}
		productGrid.Rows.Clear();
		string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=getProduct&pt="), text), "&pg="), text2), "&pc="), right), "&pn="), right2)), Conversions.ToString(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 4, "&tc=99&ac=" + Conversions.ToString(ssorder.ssorder_account_code), ""))), progress: true).getHTML(this);
		if (hTML.Equals("fail"))
		{
			Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
			busy = false;
			return;
		}
		ssorder.productClass = new ssorder_productClass(hTML);
		ssorder.order_productClass = new ssorder_productClass(hTML);
		foreach (ssorder_productClass.deepClass datum in ssorder.productClass.getData())
		{
			productGrid.Rows.Add(datum.getGridData());
		}
		busy = false;
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		searchProduct();
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)productGrid.Rows).GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, null, TextCompare: false))
				{
					continue;
				}
				try
				{
					enumerator2 = ((IEnumerable)productGrid.Rows).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)enumerator2.Current;
						if (dataGridViewRow.Index != dataGridViewRow2.Index && !Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells[1].Value, null, TextCompare: false) && Operators.CompareString(dataGridViewRow.Cells[1].Value.ToString().ToUpper().Trim(), dataGridViewRow2.Cells[1].Value.ToString().ToUpper().Trim(), TextCompare: false) == 0)
						{
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 고객 번호 '", NewLateBinding.LateGet(dataGridViewRow.Cells[1].Value, null, "trim", new object[0], null, null, null)), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), checked(dataGridViewRow.Index + 1)), "행과 제품번호가 중복됩니다."), "\r\n")));
							MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							busy = false;
							return;
						}
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
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
		IEnumerator enumerator3 = default(IEnumerator);
		try
		{
			enumerator3 = ((IEnumerable)productGrid.Rows).GetEnumerator();
			while (enumerator3.MoveNext())
			{
				DataGridViewRow dataGridViewRow3 = (DataGridViewRow)enumerator3.Current;
				if (!Conversions.ToBoolean(dataGridViewRow3.Cells[0].Value))
				{
					continue;
				}
				if (dataGridViewRow3.Cells[1].Value.ToString().Trim().Length < 4)
				{
					MessageBox.Show("제품코드는 항상 4자리여야 합니다.", "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					busy = false;
					return;
				}
				string right = null;
				object value = dataGridViewRow3.Cells[2].Value;
				if (Operators.ConditionalCompareObjectEqual(value, "직판", TextCompare: false))
				{
					right = "1";
				}
				else if (Operators.ConditionalCompareObjectEqual(value, "TM", TextCompare: false))
				{
					right = "2";
				}
				string right2 = null;
				object value2 = dataGridViewRow3.Cells[3].Value;
				if (Operators.ConditionalCompareObjectEqual(value2, "본품", TextCompare: false))
				{
					right2 = "1";
				}
				else if (Operators.ConditionalCompareObjectEqual(value2, "사례", TextCompare: false))
				{
					right2 = "2";
				}
				try
				{
					string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ssorder.ssorder_server, "admin.php?t=modProduct&pc="), dataGridViewRow3.Cells[1].Value.ToString().ToUpper().Trim()), "&pt="), right), "&pg="), right2), "&pn="), NewLateBinding.LateGet(dataGridViewRow3.Cells[4].Value, null, "trim", new object[0], null, null, null)), "&pp="), dataGridViewRow3.Cells[5].Value.ToString().Replace("\\", "").Replace(",", "")), "&ps="), dataGridViewRow3.Cells[6].Value)), Conversions.ToString(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 4, "&tc=99&ac=" + Conversions.ToString(ssorder.ssorder_account_code), ""))), progress: true).getHTML(this);
					if (hTML.Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					if (!hTML.Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 고객 번호 '", dataGridViewRow3.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), hTML), "\r\n")));
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 고객 번호 '", dataGridViewRow3.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), ex2.Message), "\r\n")));
					ProjectData.ClearProjectError();
				}
			}
		}
		finally
		{
			if (enumerator3 is IDisposable)
			{
				(enumerator3 as IDisposable).Dispose();
			}
		}
		busy = false;
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			searchProduct();
		}
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		product_team.SelectedIndex = 0;
		product_gb.SelectedIndex = 0;
		product_code.Text = null;
		product_name.Text = null;
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)productGrid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (!Conversions.ToBoolean(dataGridViewRow.Cells[0].Value))
				{
					continue;
				}
				switch (MessageBox.Show(Conversions.ToString(Operators.AddObject(Operators.AddObject("제품코드 '", dataGridViewRow.Cells[1].Value), "' 데이터를 정말 삭제 하시겠습니까?")), "삭제 확인", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
				case DialogResult.Cancel:
					busy = false;
					searchProduct();
					return;
				case DialogResult.No:
					continue;
				}
				string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=delProduct&pc="), dataGridViewRow.Cells[1].Value)), "id=" + Module1._id + "&pw=" + Module1._pw, progress: true).getHTML(this);
				if (hTML.Equals("fail"))
				{
					Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
					busy = false;
					return;
				}
				if (!hTML.Equals("ok"))
				{
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 고객 번호 '", dataGridViewRow.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), hTML), "\r\n")));
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
		busy = false;
		searchProduct();
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void Button15_Click(object sender, EventArgs e)
	{
		bool flag = false;
		int num = 0;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)productGrid.Rows).GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
					if (productGrid.Rows.Count - 1 != num)
					{
						DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)dataGridViewRow.Cells[0];
						if (num == 0)
						{
							flag = Conversions.ToBoolean(Interaction.IIf(Conversions.ToBoolean(dataGridViewCheckBoxCell.Value), false, true));
						}
						dataGridViewCheckBoxCell.Value = flag;
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
			try
			{
				foreach (ssorder_productClass.deepClass datum in ssorder.productClass.getData())
				{
					datum._check = flag;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void productGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		_ = (DataGridView)sender;
		checked
		{
			if ((e.ColumnIndex == 1) & ProductDiag.IsHandleCreated)
			{
				int num = dgv_orderList.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					ssorder_orderClass.deepClass.product product = nowOrderProducts._products[i];
					product._price = Conversions.ToInteger(dgv_orderList.Rows[i].Cells[2].Value.ToString().Replace("\\", "").Replace(",", "")
						.Trim());
					product._count = dgv_orderList.Rows[i].Cells[3].Value.ToString().Trim();
					product._etc = dgv_orderList.Rows[i].Cells[4].Value.ToString().Trim();
				}
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(dgv_orderList.Tag, null, "Y", new object[0], null, null, null), -1, TextCompare: false))
				{
					ssorder_orderClass.deepClass.product product2 = nowOrderProducts._products[Conversions.ToInteger(NewLateBinding.LateGet(dgv_orderList.Tag, null, "Y", new object[0], null, null, null))];
					product2._code = productGrid.CurrentRow.Cells[1].Value.ToString().Trim();
					product2._gb = Conversions.ToString(Interaction.IIf(productGrid.CurrentRow.Cells[3].Value.ToString().Trim().Equals("본품"), 1, 2));
					product2._name = productGrid.CurrentRow.Cells[4].Value.ToString().Trim();
					product2._price = Conversions.ToInteger(productGrid.CurrentRow.Cells[5].Value.ToString().Replace("\\", "").Replace(",", ""));
				}
				else
				{
					nowOrderProducts._products.Add(new ssorder_orderClass.deepClass.product(addmode: true, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(productGrid.CurrentRow.Cells[4].Value.ToString().Trim() + "<br>" + productGrid.CurrentRow.Cells[5].Value.ToString().Replace("\\", "").Replace(",", "") + "<br>1<br><br>", Interaction.IIf(productGrid.CurrentRow.Cells[3].Value.ToString().Trim().Equals("본품"), 1, 2)), "<br>"), productGrid.CurrentRow.Cells[1].Value.ToString().Trim()))));
				}
				dgv_orderList.Rows.Clear();
				foreach (ssorder_orderClass.deepClass.product product3 in nowOrderProducts._products)
				{
					dgv_orderList.Rows.Add(Interaction.IIf(Conversion.Val(product3._gb) == 1.0, "본품", "사례"), product3._name, "\\" + Conversion.Val(product3._price).ToString("N0"), product3._count, product3._etc, product3._code);
				}
				dgv_orderList.Rows[0].Selected = false;
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(dgv_orderList.Tag, null, "Y", new object[0], null, null, null), -1, TextCompare: false))
				{
					dgv_orderList.Rows[Conversions.ToInteger(NewLateBinding.LateGet(dgv_orderList.Tag, null, "Y", new object[0], null, null, null))].Selected = true;
				}
				else
				{
					dgv_orderList.Rows[dgv_orderList.RowCount - 1].Selected = true;
				}
				ProductDiag.Close();
				return;
			}
			try
			{
				productGrid.CurrentRow.Cells[0].Value = true;
				ssorder.productClass.getData(e.RowIndex)._check = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void productGrid_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && e.RowIndex >= 0)
		{
			productGrid.CurrentRow.Cells[0].Value = true;
		}
	}

	private void productGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void Button17_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "모든 파일|*.*|Excel 통합 문서|*.xlsx|CSV 파일|*.csv";
		checked
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (openFileDialog.FileName.EndsWith("csv"))
				{
					try
					{
						string text = null;
						using StreamReader streamReader = new StreamReader(openFileDialog.FileName, Encoding.Default, detectEncodingFromByteOrderMarks: false);
						streamReader.ReadLine();
						while (!streamReader.EndOfStream)
						{
							text = text + "<split>" + Module1.csvChar34Replace(streamReader.ReadLine()).Replace(",직판,", ",1,").Replace(",본품,", ",1,")
								.Replace(",TM,", ",2,")
								.Replace(",사례,", ",2,")
								.Replace(",", "<next>")
								.Replace("&quot;", ",")
								.Replace("&chr34;", "\"");
						}
						ssorder.productClass = new ssorder_productClass(text);
						productGrid.Rows.Clear();
						foreach (ssorder_productClass.deepClass datum in ssorder.productClass.getData())
						{
							productGrid.Rows.Add(datum.getGridData());
						}
					}
					catch (IOException ex)
					{
						ProjectData.SetProjectError(ex);
						IOException ex2 = ex;
						MessageBox.Show("파일을 열 수 없습니다! : 다른 프로그램에서 해당 파일을 사용 중 입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						MessageBox.Show("파일을 열 수 없습니다! : 파일이 손상되었거나 경로가 잘못 되었습니다.\r\n\r\n다른 파일로 다시 시도하십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
					}
				}
				else if (openFileDialog.FileName.EndsWith("xlsx"))
				{
					try
					{
						DataSet dataSet = ssorder.openExcel(openFileDialog.FileName);
						_ = dataSet.Tables[0].Rows.Count - 1;
						string text2 = null;
						int num = 0;
						int num2 = 0;
						IEnumerator enumerator2 = default(IEnumerator);
						try
						{
							enumerator2 = dataSet.Tables[0].Rows.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator2.Current;
								if (num == 0)
								{
									num++;
									continue;
								}
								string text3 = "<split>";
								num2 = 0;
								object[] itemArray = dataRow.ItemArray;
								for (int i = 0; i < itemArray.Length; i++)
								{
									string text4 = RuntimeHelpers.GetObjectValue(itemArray[i]).ToString();
									if (Operators.CompareString(text4, null, TextCompare: false) == 0)
									{
										text3 += "<next>";
										num2++;
									}
									else
									{
										text3 = ((!unchecked(num2 == 1 || num2 == 2)) ? (text3 + text4.ToString() + "<next>") : ((text4.Trim().Equals("직판") | text4.Trim().Equals("본품")) ? (text3 + "1<next>") : ((!(text4.Trim().Equals("TM") | text4.Trim().Equals("사례"))) ? (text3 + text4.ToString() + "<next>") : (text3 + "2<next>"))));
										num2++;
									}
								}
								text2 += text3;
								num++;
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						ssorder.productClass = new ssorder_productClass(text2);
						productGrid.Rows.Clear();
						foreach (ssorder_productClass.deepClass datum2 in ssorder.productClass.getData())
						{
							productGrid.Rows.Add(datum2.getGridData());
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						MessageBox.Show("파일을 열 수 없습니다! : " + ex6.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					MessageBox.Show("파일을 열 수 없습니다! : 지원하지 않는 파일 확장자입니다.\r\n\r\n다른 파일로 다시 시도하십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			openFileDialog = null;
			busy = false;
		}
	}

	private void Button13_Click(object sender, EventArgs e)
	{
		bool flag = false;
		try
		{
			foreach (ssorder_productClass.deepClass datum in ssorder.productClass.getData())
			{
				if (datum._check)
				{
					flag = datum._check;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		if (!flag)
		{
			CustomMsgBox.CMsgBox("\r\n선택된 항목이 없습니다.", "메시지", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Exclamation);
		}
		else
		{
			backupSub("제품관리", ssorder.productClass);
		}
	}

	private void product_code_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button11_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void productGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
		{
			try
			{
				ssorder.productClass.getData(e.RowIndex)._check = !bool.Parse(Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells[0].Value));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ss_account_init()
	{
		if (!isAccountPageInit)
		{
			isAccountPageInit = true;
			if (ssorder.ssorder_acgb != 5)
			{
				acc_gb.Items.Clear();
				acc_gb.Items.AddRange(new object[5] { "전체", "관리자", "일반", "최고관리자", "재고관리자" });
			}
			acc_gb.SelectedIndex = 0;
			acc_teamgb.SelectedIndex = 0;
		}
	}

	public void searchAccount()
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string right = acc_index.Text.Trim();
		string text = Conversions.ToString(acc_gb.SelectedIndex);
		string text2 = Conversions.ToString(acc_teamgb.SelectedIndex);
		string right2 = acc_id.Text;
		string right3 = acc_name.Text;
		if (Conversion.Val(text) < 1.0)
		{
			text = null;
		}
		if (Conversion.Val(text2) < 1.0)
		{
			text2 = null;
		}
		accountGrid.Rows.Clear();
		string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ssorder.ssorder_server, "admin.php?t=getAccount&ac="), right), "&acgb="), text), "&gb="), text2), "&ai="), right2), "&an="), right3)), "id=" + Module1._id + "&pw=" + Module1._pw, progress: true).getHTML(this);
		if (hTML.Equals("fail"))
		{
			Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
			busy = false;
			return;
		}
		ssorder.accountClass = new ssorder_accountClass(hTML);
		foreach (ssorder_accountClass.deepClass datum in ssorder.accountClass.getData())
		{
			accountGrid.Rows.Add(datum.getGridData());
		}
		busy = false;
	}

	private void Button19_Click(object sender, EventArgs e)
	{
		acc_index.Text = null;
		acc_gb.SelectedIndex = 0;
		acc_teamgb.SelectedIndex = 0;
		acc_id.Text = null;
		acc_name.Text = null;
	}

	private void Button21_Click(object sender, EventArgs e)
	{
		try
		{
			searchAccount();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("오류가 발생하였습니다. 현재 사용중인 프로그램이 새 버전이 아닐 수 있습니다.\r\n개발사에 문의하십시오.", "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			ProjectData.ClearProjectError();
		}
	}

	private void Button25_Click(object sender, EventArgs e)
	{
		bool flag = false;
		try
		{
			foreach (ssorder_accountClass.deepClass datum in ssorder.accountClass.getData())
			{
				if (datum._check)
				{
					flag = datum._check;
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		if (!flag)
		{
			CustomMsgBox.CMsgBox("\r\n선택된 항목이 없습니다.", "메시지", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Exclamation);
		}
		else
		{
			backupSub("사용자관리", ssorder.accountClass);
		}
	}

	private void Button24_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)accountGrid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (!Conversions.ToBoolean(dataGridViewRow.Cells[0].Value))
				{
					continue;
				}
				string right = null;
				object value = dataGridViewRow.Cells[2].Value;
				if (Operators.ConditionalCompareObjectEqual(value, "관리자", TextCompare: false))
				{
					right = "1";
				}
				else if (Operators.ConditionalCompareObjectEqual(value, "일반", TextCompare: false))
				{
					right = "2";
				}
				else if (Operators.ConditionalCompareObjectEqual(value, "최고관리자", TextCompare: false))
				{
					right = "3";
				}
				else if (Operators.ConditionalCompareObjectEqual(value, "재고관리자", TextCompare: false))
				{
					right = "4";
				}
				else if (Operators.ConditionalCompareObjectEqual(value, "루트계정", TextCompare: false))
				{
					right = "5";
				}
				string right2 = null;
				object value2 = dataGridViewRow.Cells[3].Value;
				if (Operators.ConditionalCompareObjectEqual(value2, "직판", TextCompare: false))
				{
					right2 = "1";
				}
				else if (Operators.ConditionalCompareObjectEqual(value2, "TM", TextCompare: false))
				{
					right2 = "2";
				}
				try
				{
					string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ssorder.ssorder_server, "admin.php?t=modAccount&ac="), dataGridViewRow.Cells[1].Value), "&acgb="), right), "&gb="), right2), "&ai="), dataGridViewRow.Cells[4].Value), "&ap="), dataGridViewRow.Cells[5].Value), "&an="), dataGridViewRow.Cells[6].Value), "&allow_ip="), dataGridViewRow.Cells[7].Value)), "id=" + Module1._id + "&pw=" + Module1._pw, progress: true).getHTML(this);
					if (hTML.Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					if (!hTML.Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("\r\n트랜잭션 롤백 발생: 번호 '", dataGridViewRow.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다.\r\n사유: " + hTML), "\r\n")));
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("\r\n트랜잭션 롤백 발생: 번호 '", dataGridViewRow.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다.\r\n사유: " + ex2.Message), "\r\n")));
					ProjectData.ClearProjectError();
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
		busy = false;
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			searchAccount();
		}
	}

	private void Button27_Click(object sender, EventArgs e)
	{
		bool flag = false;
		int num = 0;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)accountGrid.Rows).GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
					if (accountGrid.Rows.Count - 1 != num)
					{
						DataGridViewCheckBoxCell dataGridViewCheckBoxCell = (DataGridViewCheckBoxCell)dataGridViewRow.Cells[0];
						if (num == 0)
						{
							flag = Conversions.ToBoolean(Interaction.IIf(Conversions.ToBoolean(dataGridViewCheckBoxCell.Value), false, true));
						}
						dataGridViewCheckBoxCell.Value = flag;
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
			try
			{
				foreach (ssorder_accountClass.deepClass datum in ssorder.accountClass.getData())
				{
					datum._check = flag;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button26_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)accountGrid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToBoolean(dataGridViewRow.Cells[0].Value) && MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("번호 '", dataGridViewRow.Cells[1].Value), "' 데이터를 정말 삭제 하시겠습니까?")), "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
				{
					string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ssorder.ssorder_server, "admin.php?t=delAccount&ac="), dataGridViewRow.Cells[1].Value)), "id=" + Module1._id + "&pw=" + Module1._pw, progress: true).getHTML(this);
					if (hTML.Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					if (!hTML.Equals("ok"))
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("\r\n트랜잭션 롤백 발생: 번호 '", dataGridViewRow.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n"), "사유: "), hTML), "\r\n")));
					}
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
		busy = false;
		searchAccount();
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void accountGrid_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && e.RowIndex >= 0)
		{
			dataGridView.CurrentRow.Cells[0].Value = true;
		}
	}

	private void accountGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (MyProject.Forms.ssorder_cti.AgentSelectDiag.IsHandleCreated)
		{
			DataGridView dataGridView = (DataGridView)sender;
			if (MyProject.Forms.ssorder_cti.addAgent(dataGridView.SelectedRows[0]))
			{
				MyProject.Forms.ssorder_cti.AgentSelectDiag.Close();
			}
			return;
		}
		try
		{
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "CurrentRow", new object[0], null, null, null), null, "Cells", new object[1] { 0 }, null, null, null), null, "Value", new object[1] { true }, null, null, OptimisticSet: false, RValueBase: true);
			ssorder.accountClass.getData(e.RowIndex)._check = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void acc_index_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button21_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void TextBox13_KeyUp(object sender, KeyEventArgs e)
	{
	}

	private void DoubleBufferPanel23_MouseDown(object sender, MouseEventArgs e)
	{
		ObjectMover.FocusObject(diag_orderList.Handle);
		ObjectMover.MoveObject(diag_orderList.Handle);
	}

	private void accountGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
		{
			try
			{
				ssorder.accountClass.getData(e.RowIndex)._check = !bool.Parse(Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells[0].Value));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void ss_setorder_init()
	{
		if (!isSetOrderPageInit)
		{
			isSetOrderPageInit = true;
			Button41_Click(Button41, new EventArgs());
		}
	}

	public void searchProductSetOrder()
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string inputStr = Conversions.ToString(product_team.SelectedIndex);
		string text = Conversions.ToString(product_gb.SelectedIndex);
		string text2 = product_code.Text;
		string text3 = product_name.Text;
		Conversion.Val(inputStr);
		_ = 1.0;
		if (Conversion.Val(text) < 1.0)
		{
			text = null;
		}
		string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=getProduct&pt="), ssorder.ssorder_team_code), "&pg=" + text + "&pc=" + text2 + "&pn=" + text3)), Conversions.ToString(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 2, "&tc=99&ac=" + Conversions.ToString(ssorder.ssorder_account_code), ""))), progress: true).getHTML(this);
		if (hTML.Equals("fail"))
		{
			Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
			busy = false;
			return;
		}
		ssorder.orderProductClass = new ssorder_productClass(hTML);
		try
		{
			orderProductGrid.DataSource = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			orderProductGrid.Rows.Clear();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		try
		{
			orderProductGrid.Columns.Clear();
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		ssorder.orderProductClass.setDataTable();
		orderProductGrid.DataSource = ssorder.orderProductClass.getDataTable();
		orderProductGrid.Columns[0].Width = 40;
		orderProductGrid.Columns[1].Visible = false;
		orderProductGrid.Columns[2].Width = 60;
		orderProductGrid.Columns[3].Width = 180;
		orderProductGrid.Columns[4].Width = 60;
		orderProductGrid.Columns[5].Width = 60;
		orderProductGrid.Columns[6].Width = 60;
		orderProductGrid.Columns[7].Width = 100;
		busy = false;
	}

	private void Button33_Click_1(object sender, EventArgs e)
	{
		try
		{
			TextBox8.Text = null;
			ssorder.orderProductClass.getDataTable().DefaultView.RowFilter = $"제품명 LIKE '%{TextBox8.Text}%'";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button36_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("제품목록을 새로고치면 선택된 항목, 비고란 등 초기화 됩니다.\r\n새로고침 하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.No)
		{
			searchProductSetOrder();
		}
	}

	private void Button39_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(order_name.Text.Trim(), null, TextCompare: false) == 0)
		{
			CustomMsgBox.CMsgBox("\r\n고객 이름을 입력 해 주십시오.", "항목 검사", "확인", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Error, custom_msgbox.ShowLocation.MiddleCenter, autoClose: true, 1000);
			return;
		}
		if (!CheckBox2.Checked & (Operators.CompareString(order_call1.Text.Trim(), null, TextCompare: false) == 0))
		{
			CustomMsgBox.CMsgBox("\r\n자택 전화번호를 입력 해 주십시오.", "항목 검사", "확인", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Error, custom_msgbox.ShowLocation.MiddleCenter, autoClose: true, 1000);
			return;
		}
		if (!CheckBox3.Checked & (Operators.CompareString(order_phone1.Text.Trim(), null, TextCompare: false) == 0))
		{
			CustomMsgBox.CMsgBox("\r\n휴대전화를 입력 해 주십시오.", "항목 검사", "확인", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Error, custom_msgbox.ShowLocation.MiddleCenter, autoClose: true, 1000);
			return;
		}
		if (Operators.CompareString(order_delivery.Text.Trim(), null, TextCompare: false) == 0)
		{
			CustomMsgBox.CMsgBox("\r\n배송지 주소를 입력 해 주십시오.", "항목 검사", "확인", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Error, custom_msgbox.ShowLocation.MiddleCenter, autoClose: true, 1000);
			return;
		}
		if (Operators.CompareString(order_address.Text.Trim(), null, TextCompare: false) == 0)
		{
			CustomMsgBox.CMsgBox("\r\n자택 및 직장주소를 입력 해 주십시오.", "항목 검사", "확인", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Error, custom_msgbox.ShowLocation.MiddleCenter, autoClose: true, 1000);
			return;
		}
		TextBox8.Text = null;
		string text = null;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)orderProductGrid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (dataGridViewRow.Cells[0].Value.ToString().ToLower().Trim()
					.Equals("true"))
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<product>", dataGridViewRow.Cells[1].Value), "<br>"), dataGridViewRow.Cells[4].Value), "<br>"), dataGridViewRow.Cells[5].Value), "<br>"), dataGridViewRow.Cells[7].Value.ToString().Trim())));
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
		if (Operators.CompareString(text, null, TextCompare: false) == 0)
		{
			CustomMsgBox.CMsgBox("\r\n제품을 한 개 이상 선택 해 주십시오.", "항목 검사", "확인", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Error, custom_msgbox.ShowLocation.MiddleCenter, autoClose: true, 1000);
			return;
		}
		string right = "";
		try
		{
			right = selectedCustomer.getCustomerCode();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		string str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(order_call1.Text, Interaction.IIf(Operators.CompareString(order_call2.Text, null, TextCompare: false) != 0, "-" + order_call2.Text, "")), Interaction.IIf(Operators.CompareString(order_call3.Text, null, TextCompare: false) != 0, "-" + order_call3.Text, "")));
		string str2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(order_phone1.Text, Interaction.IIf(Operators.CompareString(order_phone2.Text, null, TextCompare: false) != 0, "-" + order_phone2.Text, "")), Interaction.IIf(Operators.CompareString(order_phone3.Text, null, TextCompare: false) != 0, "-" + order_phone3.Text, "")));
		string hTML = new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=setOrder"), "&ac="), ssorder.ssorder_account_code), "&cc="), right), "&ca="), HttpUtility.UrlEncode(order_address.Text + "<other>" + order_address_more.Text)), "&call="), HttpUtility.UrlEncode(str)), "&od="), HttpUtility.UrlEncode(order_delivery.Text + "<other>" + order_delivery_more.Text)), "&cp="), HttpUtility.UrlEncode(str2)), "&cn="), HttpUtility.UrlEncode(order_name.Text)), "&oe="), HttpUtility.UrlEncode(order_etc.Text))), Conversions.ToString(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 2, "&tc=99&pc=" + text + "&acc_code=" + Conversions.ToString(ssorder.ssorder_account_code), "&pc=" + text + "&acc_code=" + Conversions.ToString(ssorder.ssorder_account_code)))), progress: true).getHTML(this);
		if (hTML.Equals("fail"))
		{
			Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
			busy = false;
		}
		else if (hTML.Equals("ok"))
		{
			MessageBox.Show("주문이 완료되었습니다.", "주문 완료!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Button41_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		else
		{
			MessageBox.Show(hTML, "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	private void Button31_Click(object sender, EventArgs e)
	{
		Label21.Hide();
		Button122.BackColor = Color.FromArgb(64, 64, 64);
		searchBoolean = false;
		DoubleBufferPanel24.Controls.Add(diag_address);
		diag_address.Size = new Size(diag_address.Width, 109);
		Point point = Module1.ControlCenter(DoubleBufferPanel24, diag_address);
		diag_address.Top = point.X;
		diag_address.Left = point.Y;
		diag_address.Show();
		diag_address.Tag = new Point(999, 0);
		Button43.Tag = (order_delivery.Text + " " + order_delivery_more.Text).Trim();
		DoubleBufferPanel24.Controls.SetChildIndex(diag_address, 0);
		TextBox2.Text = null;
		Panel163.Hide();
		TextBox13.Text = null;
		TextBox13.Focus();
	}

	private void Button32_Click(object sender, EventArgs e)
	{
		Label21.Hide();
		Button122.BackColor = Color.FromArgb(64, 64, 64);
		searchBoolean = false;
		DoubleBufferPanel24.Controls.Add(diag_address);
		diag_address.Size = new Size(diag_address.Width, 109);
		Point point = Module1.ControlCenter(DoubleBufferPanel24, diag_address);
		diag_address.Top = point.X;
		diag_address.Left = point.Y;
		diag_address.Show();
		diag_address.Tag = new Point(999, 1);
		Button43.Tag = (order_address.Text + " " + order_address_more.Text).Trim();
		DoubleBufferPanel24.Controls.SetChildIndex(diag_address, 0);
		TextBox2.Text = null;
		Panel163.Hide();
		TextBox13.Text = null;
		TextBox13.Focus();
	}

	private void CheckBox4_CheckedChanged(CheckBox sender, EventArgs e)
	{
		if (sender.Checked)
		{
			order_address.Text = order_delivery.Text;
			order_address_more.Text = order_delivery_more.Text;
		}
		else
		{
			order_address.Text = null;
			order_address_more.Text = null;
		}
	}

	private void Button37_Click(object sender, EventArgs e)
	{
		diag_customer.Hide();
	}

	private void Button30_Click(object sender, EventArgs e)
	{
		DoubleBufferPanel24.Controls.Add(diag_customer);
		Point point = Module1.ControlCenter(DoubleBufferPanel24, diag_customer);
		diag_customer.Top = point.X;
		diag_customer.Left = point.Y;
		diag_customer.Show();
		dgv_orderList.Rows.Clear();
		setOrderSearchCustomer();
		DoubleBufferPanel24.Controls.SetChildIndex(diag_customer, 0);
		TextBox1.Focus();
	}

	public void setOrderSearchCustomer()
	{
		if (busy)
		{
			return;
		}
		busy = true;
		dgv_customer.Rows.Clear();
		string text = ((ssorder.ssorder_acgb == 2) ? Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=searchCustomer&cc=")) : Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "admin.php?t=cusSearchA&cc=")));
		string hTML = new GetHtmlClass(text + HttpUtility.UrlEncode(TextBox1.Text), Conversions.ToString(Operators.ConcatenateObject("id=" + Module1._id + "&pw=" + Module1._pw, Interaction.IIf(ssorder.ssorder_acgb == 2, "&tc=99&acc_code=" + Conversions.ToString(ssorder.ssorder_account_code), "&acc_code=" + Conversions.ToString(ssorder.ssorder_account_code)))), progress: true).getHTML(this);
		if (hTML.Equals("fail"))
		{
			Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
			busy = false;
			return;
		}
		ssorder.setOrderCustomerClass = new ssorder_customerClass(hTML, diagMode: true);
		foreach (ssorder_customerClass.deepClass datum in ssorder.setOrderCustomerClass.getData())
		{
			dgv_customer.Rows.Add(datum.getGridDataDiagMode());
		}
		busy = false;
	}

	public void Button41_Click(object sender, EventArgs e)
	{
		selectedCustomer = null;
		CheckBox2.Checked = false;
		CheckBox3.Checked = false;
		CheckBox4.Checked = false;
		CheckBox5.Checked = false;
		order_name.Text = null;
		order_call1.Text = null;
		order_call2.Text = null;
		order_call3.Text = null;
		order_phone1.Text = null;
		order_phone2.Text = null;
		order_phone3.Text = null;
		order_delivery.Text = null;
		order_delivery_more.Text = null;
		TextBox8.Text = null;
		order_etc.Text = null;
		searchProductSetOrder();
	}

	private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			CheckBox2.Checked = false;
			CheckBox3.Checked = false;
			CheckBox4.Checked = false;
			order_call1.Text = null;
			order_call2.Text = null;
			order_call3.Text = null;
			order_phone1.Text = null;
			order_phone2.Text = null;
			order_phone3.Text = null;
			order_delivery.Text = null;
			order_delivery_more.Text = null;
			selectedCustomer = ssorder.setOrderCustomerClass.getData(dgv_customer.Rows[e.RowIndex].Cells[0].Value.ToString());
			diag_customer.Hide();
			order_name.Text = selectedCustomer.getCustomerName();
			string[] array = selectedCustomer.getCustomerCallNumber().Split(new string[1] { "-" }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 3)
			{
				order_call1.Text = array[0];
				order_call2.Text = array[1];
				order_call3.Text = array[2];
			}
			if (array.Length == 2)
			{
				order_call1.Text = array[0];
				order_call2.Text = array[1];
			}
			if (array.Length == 1)
			{
				order_call1.Text = array[0];
			}
			if (array.Length == 0)
			{
				CheckBox2.Checked = true;
			}
			string[] array2 = selectedCustomer.getCustomerPhoneNumber().Split(new string[1] { "-" }, StringSplitOptions.RemoveEmptyEntries);
			if (array2.Length == 3)
			{
				order_phone1.Text = array2[0];
				order_phone2.Text = array2[1];
				order_phone3.Text = array2[2];
			}
			if (array2.Length == 2)
			{
				order_phone1.Text = array2[0];
				order_phone2.Text = array2[1];
			}
			if (array2.Length == 1)
			{
				order_phone1.Text = array2[0];
			}
			if (array2.Length == 0)
			{
				CheckBox3.Checked = true;
			}
			string[] array3 = selectedCustomer.getCustomerAddress().Split(new string[1] { "<other>" }, StringSplitOptions.RemoveEmptyEntries);
			if (array3.Length == 2)
			{
				order_delivery.Text = array3[0];
				order_delivery_more.Text = array3[1];
				CheckBox4.Checked = true;
			}
			if (array3.Length == 1)
			{
				order_delivery.Text = array3[0];
				CheckBox4.Checked = true;
			}
		}
	}

	private void CheckBox4_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void order_call1_TextChanged(object sender, EventArgs e)
	{
		CheckBox2.Checked = false;
	}

	private void order_phone1_TextChanged(object sender, EventArgs e)
	{
		CheckBox3.Checked = false;
	}

	private void DoubleBufferPanel28_MouseDown(object sender, MouseEventArgs e)
	{
		ObjectMover.FocusObject(diag_customer.Handle);
		ObjectMover.MoveObject(diag_customer.Handle);
	}

	private void CheckBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckBox5.Checked)
		{
			ssorder.orderProductClass.getDataTable().DefaultView.RowFilter = "체크 = true";
		}
		else
		{
			ssorder.orderProductClass.getDataTable().DefaultView.RowFilter = $"제품명 LIKE '%{TextBox8.Text}%'";
		}
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button30_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	public void productDialog(bool show)
	{
		if (show)
		{
			productGrid.Columns[0].Visible = false;
			productGrid.AllowUserToAddRows = false;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = productGrid.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					((DataGridViewColumn)enumerator.Current).ReadOnly = true;
				}
				return;
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		productGrid.Columns[0].Visible = true;
		productGrid.AllowUserToAddRows = true;
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = productGrid.Columns.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				((DataGridViewColumn)enumerator2.Current).ReadOnly = false;
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
	}

	private void productDiagClosing(Form sender, FormClosingEventArgs e)
	{
		p3.Controls.Add(p3_centerpanel);
		p3.Controls.SetChildIndex(p3_centerpanel, 0);
		productDialog(show: false);
		isProductPageInit = false;
	}

	private void dgv_orderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && !((ssorder.ssorder_acgb == 1) | (ssorder.ssorder_acgb == 2)))
		{
			if (ProductDiag.IsHandleCreated)
			{
				ProductDiag.Close();
			}
			ProductDiag = new Form();
			Form productDiag = ProductDiag;
			productDiag.MinimumSize = new Size(800, 600);
			productDiag.Size = new Size(800, 600);
			productDiag.StartPosition = FormStartPosition.CenterScreen;
			productDiag.FormBorderStyle = FormBorderStyle.Sizable;
			productDiag.Text = "제품 선택 (제품코드를 더블클릭 하면 선택됩니다.)";
			productDiag.ShowIcon = false;
			productDiag.Controls.Add(p3_centerpanel);
			_ = null;
			ProductDiag.FormClosing += delegate(object a0, FormClosingEventArgs a1)
			{
				productDiagClosing((Form)a0, a1);
			};
			nowDatagridView = dgv_orderList;
			dgv_orderList.Tag = new Point(Conversions.ToInteger(NewLateBinding.LateGet(dgv_orderList.Tag, null, "X", new object[0], null, null, null)), e.RowIndex);
			productDialog(show: true);
			ss_product_init();
			isProductPageInit = false;
			p3.Dock = DockStyle.Fill;
			ProductDiag.Show();
		}
	}

	private void Button35_Click(object sender, EventArgs e)
	{
		if (ProductDiag.IsHandleCreated)
		{
			ProductDiag.Close();
		}
		ProductDiag = new Form();
		Form productDiag = ProductDiag;
		productDiag.Size = new Size(800, 600);
		productDiag.StartPosition = FormStartPosition.CenterScreen;
		productDiag.FormBorderStyle = FormBorderStyle.SizableToolWindow;
		productDiag.Text = "제품 선택 (제품코드를 더블클릭 하면 선택됩니다.)";
		productDiag.ShowIcon = false;
		productDiag.Controls.Add(p3_centerpanel);
		_ = null;
		ProductDiag.FormClosing += delegate(object a0, FormClosingEventArgs a1)
		{
			productDiagClosing((Form)a0, a1);
		};
		nowDatagridView = dgv_orderList;
		dgv_orderList.Tag = new Point(Conversions.ToInteger(NewLateBinding.LateGet(dgv_orderList.Tag, null, "X", new object[0], null, null, null)), -1);
		productDialog(show: true);
		ss_product_init();
		isProductPageInit = false;
		p3.Dock = DockStyle.Fill;
		ProductDiag.Show();
	}

	private void Button34_Click(object sender, EventArgs e)
	{
		int num = 0;
		int index = 0;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dgv_orderList.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (num == 0)
				{
					index = dataGridViewRow.Index;
				}
				nowOrderProducts._products.RemoveAt(dataGridViewRow.Index);
				num = checked(num + 1);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		dgv_orderList.Rows.Clear();
		foreach (ssorder_orderClass.deepClass.product product in nowOrderProducts._products)
		{
			dgv_orderList.Rows.Add(Interaction.IIf(Conversion.Val(product._gb) == 1.0, "본품", "사례"), product._name, "\\" + Conversion.Val(product._price).ToString("N0"), product._count, product._etc);
		}
		try
		{
			dgv_orderList.Rows[0].Selected = false;
			dgv_orderList.Rows[index].Selected = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button43_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Button43.Text, "주소 검색", TextCompare: false) == 0)
		{
			rb_dong.Show();
			rb_road.Show();
			Button122.Text = "검색";
			Button43.Text = "직접 수정";
			return;
		}
		rb_dong.Hide();
		rb_road.Hide();
		Button122.Text = "확인";
		TextBox13.Text = Conversions.ToString(Button43.Tag);
		TextBox13.Focus();
		TextBox13.SelectionStart = TextBox13.Text.Length;
		Button43.Text = "주소 검색";
		Panel163.Hide();
		diag_address.Size = new Size(diag_address.Width, 109);
		Point point = Module1.ControlCenter(p2, diag_address);
		diag_address.Top = point.X;
		diag_address.Left = point.Y;
	}

	private void TextBox8_KeyUp(object sender, KeyEventArgs e)
	{
		try
		{
			ssorder.orderProductClass.getDataTable().DefaultView.RowFilter = $"제품명 LIKE '%{TextBox8.Text}%'";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button44_Click(object sender, EventArgs e)
	{
		Button39_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Button45_Click(object sender, EventArgs e)
	{
		Button41_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}
}
