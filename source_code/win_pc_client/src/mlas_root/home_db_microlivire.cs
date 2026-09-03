using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class home_db_microlivire : Form
{
	private IContainer components;

	public List<string> Customer;

	public List<string> Project;

	public List<string> ProjectNames;

	public List<string> ASBoard;

	public List<string> Notice;

	private object notice_detail;

	private myftp ftp;

	private bool loginOK;

	private string filename;

	private object tcount;

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

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p1")]
	internal virtual Panel p1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
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

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel8")]
	internal virtual Panel Panel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button10")]
	internal virtual Button Button10
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

	[field: AccessedThroughProperty("Button3")]
	internal virtual Button Button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListView ListView4
	{
		[CompilerGenerated]
		get
		{
			return _ListView4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ListView4_MouseDoubleClick;
			ListView listView = _ListView4;
			if (listView != null)
			{
				listView.MouseDoubleClick -= value2;
			}
			_ListView4 = value;
			listView = _ListView4;
			if (listView != null)
			{
				listView.MouseDoubleClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ColumnHeader29")]
	internal virtual ColumnHeader ColumnHeader29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader32")]
	internal virtual ColumnHeader ColumnHeader32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader28")]
	internal virtual ColumnHeader ColumnHeader28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader2")]
	internal virtual ColumnHeader ColumnHeader2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader1")]
	internal virtual ColumnHeader ColumnHeader1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader3")]
	internal virtual ColumnHeader ColumnHeader3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p2")]
	internal virtual Panel p2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListView ListView1
	{
		[CompilerGenerated]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ListView1_MouseDoubleClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.MouseDoubleClick -= value2;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.MouseDoubleClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ColumnHeader4")]
	internal virtual ColumnHeader ColumnHeader4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader5")]
	internal virtual ColumnHeader ColumnHeader5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader6")]
	internal virtual ColumnHeader ColumnHeader6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader7")]
	internal virtual ColumnHeader ColumnHeader7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader8")]
	internal virtual ColumnHeader ColumnHeader8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader9")]
	internal virtual ColumnHeader ColumnHeader9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader10")]
	internal virtual ColumnHeader ColumnHeader10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader11")]
	internal virtual ColumnHeader ColumnHeader11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader12")]
	internal virtual ColumnHeader ColumnHeader12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader13")]
	internal virtual ColumnHeader ColumnHeader13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader14")]
	internal virtual ColumnHeader ColumnHeader14
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual Panel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel11")]
	internal virtual Panel Panel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel12")]
	internal virtual Panel Panel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Button4")]
	internal virtual Button Button4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("ColumnHeader15")]
	internal virtual ColumnHeader ColumnHeader15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader16")]
	internal virtual ColumnHeader ColumnHeader16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p3")]
	internal virtual Panel p3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p3_text3")]
	internal virtual TextBox p3_text3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel13")]
	internal virtual Panel Panel13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel109")]
	internal virtual Panel Panel109
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p3_text1")]
	internal virtual TextBox p3_text1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label84")]
	internal virtual Label Label84
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label85")]
	internal virtual Label Label85
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button p3_btn1
	{
		[CompilerGenerated]
		get
		{
			return _p3_btn1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = p3_btn1_Click;
			Button button = _p3_btn1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_p3_btn1 = value;
			button = _p3_btn1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label86")]
	internal virtual Label Label86
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox p3_combobox1
	{
		[CompilerGenerated]
		get
		{
			return _p3_combobox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = DrawItem;
			EventHandler value3 = p3_combobox1_SelectedIndexChanged;
			ComboBox comboBox = _p3_combobox1;
			if (comboBox != null)
			{
				comboBox.DrawItem -= value2;
				comboBox.SelectedIndexChanged -= value3;
			}
			_p3_combobox1 = value;
			comboBox = _p3_combobox1;
			if (comboBox != null)
			{
				comboBox.DrawItem += value2;
				comboBox.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Panel112")]
	internal virtual Panel Panel112
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel113")]
	internal virtual Panel Panel113
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label88")]
	internal virtual Label Label88
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel114")]
	internal virtual Panel Panel114
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label89")]
	internal virtual Label Label89
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel117")]
	internal virtual Panel Panel117
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel118")]
	internal virtual Panel Panel118
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel103")]
	internal virtual Panel Panel103
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button p3_btn3
	{
		[CompilerGenerated]
		get
		{
			return _p3_btn3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = p3_btn3_Click;
			Button button = _p3_btn3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_p3_btn3 = value;
			button = _p3_btn3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button p3_btn2
	{
		[CompilerGenerated]
		get
		{
			return _p3_btn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = p3_btn2_Click;
			Button button = _p3_btn2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_p3_btn2 = value;
			button = _p3_btn2;
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

	internal virtual ComboBox p3_combobox2
	{
		[CompilerGenerated]
		get
		{
			return _p3_combobox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = DrawItem;
			EventHandler value3 = p3_combobox2_SelectedIndexChanged;
			ComboBox comboBox = _p3_combobox2;
			if (comboBox != null)
			{
				comboBox.DrawItem -= value2;
				comboBox.SelectedIndexChanged -= value3;
			}
			_p3_combobox2 = value;
			comboBox = _p3_combobox2;
			if (comboBox != null)
			{
				comboBox.DrawItem += value2;
				comboBox.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("p3_text2")]
	internal virtual TextBox p3_text2
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

	[field: AccessedThroughProperty("p3_count")]
	internal virtual Label p3_count
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p3_filesearch")]
	internal virtual Button p3_filesearch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p3_kb")]
	internal virtual TextBox p3_kb
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p3_writer")]
	internal virtual TextBox p3_writer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("p3_num")]
	internal virtual Label p3_num
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

	[field: AccessedThroughProperty("p3_date")]
	internal virtual Label p3_date
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p4")]
	internal virtual Panel p4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox p4_text2
	{
		[CompilerGenerated]
		get
		{
			return _p4_text2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox1_TextChanged;
			TextBox textBox = _p4_text2;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_p4_text2 = value;
			textBox = _p4_text2;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel15")]
	internal virtual Panel Panel15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel16")]
	internal virtual Panel Panel16
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

	internal virtual TextBox p4_text1
	{
		[CompilerGenerated]
		get
		{
			return _p4_text1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox5_TextChanged;
			TextBox textBox = _p4_text1;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_p4_text1 = value;
			textBox = _p4_text1;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
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

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox p4_ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _p4_ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = DrawItem;
			EventHandler value3 = p4_ComboBox1_SelectedIndexChanged;
			ComboBox comboBox = _p4_ComboBox1;
			if (comboBox != null)
			{
				comboBox.DrawItem -= value2;
				comboBox.SelectedIndexChanged -= value3;
			}
			_p4_ComboBox1 = value;
			comboBox = _p4_ComboBox1;
			if (comboBox != null)
			{
				comboBox.DrawItem += value2;
				comboBox.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Panel17")]
	internal virtual Panel Panel17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel18")]
	internal virtual Panel Panel18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label21")]
	internal virtual Label Label21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel19")]
	internal virtual Panel Panel19
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

	[field: AccessedThroughProperty("Panel20")]
	internal virtual Panel Panel20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel21")]
	internal virtual Panel Panel21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel22")]
	internal virtual Panel Panel22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Panel53")]
	internal virtual Panel Panel53
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txt_noticedetail")]
	internal virtual Label txt_noticedetail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txt_notice")]
	internal virtual Label txt_notice
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label p4_color1
	{
		[CompilerGenerated]
		get
		{
			return _p4_color1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = p4_color1_Click;
			Label label = _p4_color1;
			if (label != null)
			{
				label.Click -= value2;
			}
			_p4_color1 = value;
			label = _p4_color1;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label p4_color4
	{
		[CompilerGenerated]
		get
		{
			return _p4_color4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = p4_color4_Click;
			Label label = _p4_color4;
			if (label != null)
			{
				label.Click -= value2;
			}
			_p4_color4 = value;
			label = _p4_color4;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label p4_color3
	{
		[CompilerGenerated]
		get
		{
			return _p4_color3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = p4_color3_Click;
			Label label = _p4_color3;
			if (label != null)
			{
				label.Click -= value2;
			}
			_p4_color3 = value;
			label = _p4_color3;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label p4_color2
	{
		[CompilerGenerated]
		get
		{
			return _p4_color2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = p4_color2_Click;
			Label label = _p4_color2;
			if (label != null)
			{
				label.Click -= value2;
			}
			_p4_color2 = value;
			label = _p4_color2;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p4_num")]
	internal virtual Label p4_num
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

	[field: AccessedThroughProperty("TabPage5")]
	internal virtual TabPage TabPage5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p5")]
	internal virtual Panel p5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel25")]
	internal virtual Panel Panel25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel26")]
	internal virtual Panel Panel26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel27")]
	internal virtual Panel Panel27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label31")]
	internal virtual Label Label31
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel28")]
	internal virtual Panel Panel28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label32")]
	internal virtual Label Label32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel29")]
	internal virtual Panel Panel29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel30")]
	internal virtual Panel Panel30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel31")]
	internal virtual Panel Panel31
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

	internal virtual FastColoredTextBox FastColoredTextBox1
	{
		[CompilerGenerated]
		get
		{
			return _FastColoredTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = code_tb_KeyDown;
			FastColoredTextBox fastColoredTextBox = _FastColoredTextBox1;
			if (fastColoredTextBox != null)
			{
				fastColoredTextBox.KeyDown -= value2;
			}
			_FastColoredTextBox1 = value;
			fastColoredTextBox = _FastColoredTextBox1;
			if (fastColoredTextBox != null)
			{
				fastColoredTextBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel14")]
	internal virtual Panel Panel14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Splitter Splitter1
	{
		[CompilerGenerated]
		get
		{
			return _Splitter1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			SplitterEventHandler value2 = Splitter1_SplitterMoved;
			Splitter splitter = _Splitter1;
			if (splitter != null)
			{
				splitter.SplitterMoved -= value2;
			}
			_Splitter1 = value;
			splitter = _Splitter1;
			if (splitter != null)
			{
				splitter.SplitterMoved += value2;
			}
		}
	}

	internal virtual ListBox ListBox2
	{
		[CompilerGenerated]
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = DrawItem;
			MouseEventHandler value3 = ListBox2_MouseDoubleClick;
			ListBox listBox = _ListBox2;
			if (listBox != null)
			{
				listBox.DrawItem -= value2;
				listBox.MouseDoubleClick -= value3;
			}
			_ListBox2 = value;
			listBox = _ListBox2;
			if (listBox != null)
			{
				listBox.DrawItem += value2;
				listBox.MouseDoubleClick += value3;
			}
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = DrawItem;
			EventHandler value3 = ComboBox1_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.DrawItem -= value2;
				comboBox.SelectedIndexChanged -= value3;
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.DrawItem += value2;
				comboBox.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage6")]
	internal virtual TabPage TabPage6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_ftp_login")]
	internal virtual Panel p_ftp_login
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel24")]
	internal virtual Panel Panel24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual TextBox TextBox2
	{
		[CompilerGenerated]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox3_KeyDown;
			TextBox textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox2 = value;
			textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
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
			KeyEventHandler value2 = TextBox3_KeyDown;
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

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label11
	{
		[CompilerGenerated]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Label11_MouseDown;
			Label label = _Label11;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label11 = value;
			label = _Label11;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	internal virtual TextBox TextBox3
	{
		[CompilerGenerated]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox3_KeyDown;
			TextBox textBox = _TextBox3;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox3 = value;
			textBox = _TextBox3;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = DrawItem;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.DrawItem -= value2;
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.DrawItem += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
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

	[field: AccessedThroughProperty("Label24")]
	internal virtual Label Label24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = Button17_Click;
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

	internal virtual System.Windows.Forms.Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer1_Tick;
			System.Windows.Forms.Timer timer = _Timer1;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel23")]
	internal virtual Panel Panel23
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

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox3
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = DrawItem;
			EventHandler value3 = ComboBox3_SelectedIndexChanged;
			ComboBox comboBox = _ComboBox3;
			if (comboBox != null)
			{
				comboBox.DrawItem -= value2;
				comboBox.SelectedIndexChanged -= value3;
			}
			_ComboBox3 = value;
			comboBox = _ComboBox3;
			if (comboBox != null)
			{
				comboBox.DrawItem += value2;
				comboBox.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label27")]
	internal virtual Label Label27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox code_tb
	{
		[CompilerGenerated]
		get
		{
			return _code_tb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = code_tb_KeyDown;
			TextBox textBox = _code_tb;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_code_tb = value;
			textBox = _code_tb;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	internal virtual Panel p_ftp_file
	{
		[CompilerGenerated]
		get
		{
			return _p_ftp_file;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PaintEventHandler value2 = p_ftp_file_Paint;
			Panel panel = _p_ftp_file;
			if (panel != null)
			{
				panel.Paint -= value2;
			}
			_p_ftp_file = value;
			panel = _p_ftp_file;
			if (panel != null)
			{
				panel.Paint += value2;
			}
		}
	}

	internal virtual TextBox TextBox4
	{
		[CompilerGenerated]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox4_KeyDown;
			TextBox textBox = _TextBox4;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox4 = value;
			textBox = _TextBox4;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label28")]
	internal virtual Label Label28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel33")]
	internal virtual Panel Panel33
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

	internal virtual Label Label33
	{
		[CompilerGenerated]
		get
		{
			return _Label33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Label33_MouseDown;
			Label label = _Label33;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label33 = value;
			label = _Label33;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label29")]
	internal virtual Label Label29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("p_ftp_mname")]
	internal virtual Panel p_ftp_mname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox6
	{
		[CompilerGenerated]
		get
		{
			return _TextBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox6_KeyDown;
			TextBox textBox = _TextBox6;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox6 = value;
			textBox = _TextBox6;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label35")]
	internal virtual Label Label35
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
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

	[field: AccessedThroughProperty("Panel34")]
	internal virtual Panel Panel34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Label Label34
	{
		[CompilerGenerated]
		get
		{
			return _Label34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Label34_MouseDown;
			Label label = _Label34;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label34 = value;
			label = _Label34;
			if (label != null)
			{
				label.MouseDown += value2;
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

	[field: AccessedThroughProperty("Label37")]
	internal virtual Label Label37
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel32")]
	internal virtual Panel Panel32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
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

	[field: AccessedThroughProperty("p_diag1")]
	internal virtual Panel p_diag1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag1_t1")]
	internal virtual TextBox p_diag1_t1
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

	[field: AccessedThroughProperty("Panel36")]
	internal virtual Panel Panel36
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			Button button = _Button29;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button29 = value;
			button = _Button29;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	internal virtual Label Label40
	{
		[CompilerGenerated]
		get
		{
			return _Label40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Label40_MouseDown;
			Label label = _Label40;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label40 = value;
			label = _Label40;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p_diag1_t6")]
	internal virtual TextBox p_diag1_t6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label43")]
	internal virtual Label Label43
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag1_t5")]
	internal virtual TextBox p_diag1_t5
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

	[field: AccessedThroughProperty("p_diag1_t4")]
	internal virtual TextBox p_diag1_t4
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

	[field: AccessedThroughProperty("p_diag1_t3")]
	internal virtual TextBox p_diag1_t3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label39")]
	internal virtual Label Label39
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag1_t2")]
	internal virtual TextBox p_diag1_t2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label38")]
	internal virtual Label Label38
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag2")]
	internal virtual Panel p_diag2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label54")]
	internal virtual Label Label54
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label52")]
	internal virtual Label Label52
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label44")]
	internal virtual Label Label44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag2_t4")]
	internal virtual TextBox p_diag2_t4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label45")]
	internal virtual Label Label45
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label46")]
	internal virtual Label Label46
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag2_t2")]
	internal virtual TextBox p_diag2_t2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label48")]
	internal virtual Label Label48
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag2_t1")]
	internal virtual TextBox p_diag2_t1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label49")]
	internal virtual Label Label49
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel38")]
	internal virtual Panel Panel38
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = Button28_Click;
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

	internal virtual Label Label50
	{
		[CompilerGenerated]
		get
		{
			return _Label50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Label50_MouseDown;
			Label label = _Label50;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label50 = value;
			label = _Label50;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p_diag2_t3")]
	internal virtual TextBox p_diag2_t3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label47")]
	internal virtual Label Label47
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label51")]
	internal virtual Label Label51
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag2_t6")]
	internal virtual TextBox p_diag2_t6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label53")]
	internal virtual Label Label53
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox p_diag2_c2
	{
		[CompilerGenerated]
		get
		{
			return _p_diag2_c2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = DrawItem;
			ComboBox comboBox = _p_diag2_c2;
			if (comboBox != null)
			{
				comboBox.DrawItem -= value2;
			}
			_p_diag2_c2 = value;
			comboBox = _p_diag2_c2;
			if (comboBox != null)
			{
				comboBox.DrawItem += value2;
			}
		}
	}

	internal virtual ComboBox p_diag2_c1
	{
		[CompilerGenerated]
		get
		{
			return _p_diag2_c1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = DrawItem;
			ComboBox comboBox = _p_diag2_c1;
			if (comboBox != null)
			{
				comboBox.DrawItem -= value2;
			}
			_p_diag2_c1 = value;
			comboBox = _p_diag2_c1;
			if (comboBox != null)
			{
				comboBox.DrawItem += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p_diag2_chk1")]
	internal virtual CheckBox p_diag2_chk1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag2_rb2")]
	internal virtual RadioButton p_diag2_rb2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag2_rb1")]
	internal virtual RadioButton p_diag2_rb1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag2_num")]
	internal virtual Label p_diag2_num
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_diag1_num")]
	internal virtual Label p_diag1_num
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
			EventHandler value2 = Button33_Click;
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

	[field: AccessedThroughProperty("p_diag2_t5")]
	internal virtual NumericUpDown p_diag2_t5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage8")]
	internal virtual TabPage TabPage8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p6")]
	internal virtual Panel p6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListView2")]
	internal virtual ListView ListView2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader17")]
	internal virtual ColumnHeader ColumnHeader17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader18")]
	internal virtual ColumnHeader ColumnHeader18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader19")]
	internal virtual ColumnHeader ColumnHeader19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader20")]
	internal virtual ColumnHeader ColumnHeader20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader21")]
	internal virtual ColumnHeader ColumnHeader21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel37")]
	internal virtual Panel Panel37
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label55")]
	internal virtual Label Label55
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel39")]
	internal virtual Panel Panel39
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label56")]
	internal virtual Label Label56
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel40")]
	internal virtual Panel Panel40
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel41")]
	internal virtual Panel Panel41
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel42")]
	internal virtual Panel Panel42
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel43")]
	internal virtual Panel Panel43
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	public home_db_microlivire()
	{
		base.Load += home_db_microlivire_Load;
		notice_detail = false;
		loginOK = false;
		filename = null;
		tcount = 0;
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
		System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem(new string[8] { "1000", "김민재", "010-3889-1719", "051-385-9512", "211-59445-211", "microlivire@gmail.com", "서울 관악구 신림동 1576-13번지 501호", "5" }, -1);
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.home_db_microlivire));
		System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[11]
		{
			"38", "android_db_sjka_application_noteapp", "sjka", "micro036sjka", "성운환경조경학원", "http://www.vlv.kr/sjka", "UTF8", "true", "54", "5",
			"0000-00-00 00:00:00"
		}, -1);
		System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[11]
		{
			"38", "android_db_sjka_application_noteapp", "sjka", "micro036sjka", "성운환경조경학원", "http://www.vlv.kr/sjka", "UTF8", "true", "54", "5",
			"0000-00-00 00:00:00"
		}, -1);
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.p1 = new System.Windows.Forms.Panel();
		this.ListView4 = new System.Windows.Forms.ListView();
		this.ColumnHeader29 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader32 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader28 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader15 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader16 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Label2 = new System.Windows.Forms.Label();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Label3 = new System.Windows.Forms.Label();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.Panel8 = new System.Windows.Forms.Panel();
		this.Button18 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button10 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.p2 = new System.Windows.Forms.Panel();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader7 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader8 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader9 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader10 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader11 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader12 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader13 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader14 = new System.Windows.Forms.ColumnHeader();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Label1 = new System.Windows.Forms.Label();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Label4 = new System.Windows.Forms.Label();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.Panel10 = new System.Windows.Forms.Panel();
		this.Panel11 = new System.Windows.Forms.Panel();
		this.Panel12 = new System.Windows.Forms.Panel();
		this.Button9 = new System.Windows.Forms.Button();
		this.Button8 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		this.TabPage8 = new System.Windows.Forms.TabPage();
		this.p6 = new System.Windows.Forms.Panel();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.ColumnHeader17 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader18 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader19 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader20 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader21 = new System.Windows.Forms.ColumnHeader();
		this.Panel37 = new System.Windows.Forms.Panel();
		this.Label55 = new System.Windows.Forms.Label();
		this.Panel39 = new System.Windows.Forms.Panel();
		this.Label56 = new System.Windows.Forms.Label();
		this.Panel40 = new System.Windows.Forms.Panel();
		this.Panel41 = new System.Windows.Forms.Panel();
		this.Panel42 = new System.Windows.Forms.Panel();
		this.Panel43 = new System.Windows.Forms.Panel();
		this.Button39 = new System.Windows.Forms.Button();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.p3 = new System.Windows.Forms.Panel();
		this.p3_text3 = new System.Windows.Forms.TextBox();
		this.Panel13 = new System.Windows.Forms.Panel();
		this.Panel109 = new System.Windows.Forms.Panel();
		this.p3_num = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.p3_date = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.p3_writer = new System.Windows.Forms.TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.p3_kb = new System.Windows.Forms.TextBox();
		this.p3_filesearch = new System.Windows.Forms.Button();
		this.p3_count = new System.Windows.Forms.Label();
		this.p3_text2 = new System.Windows.Forms.TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.p3_combobox2 = new System.Windows.Forms.ComboBox();
		this.p3_text1 = new System.Windows.Forms.TextBox();
		this.Label84 = new System.Windows.Forms.Label();
		this.Label85 = new System.Windows.Forms.Label();
		this.p3_btn1 = new System.Windows.Forms.Button();
		this.Label86 = new System.Windows.Forms.Label();
		this.p3_combobox1 = new System.Windows.Forms.ComboBox();
		this.Panel112 = new System.Windows.Forms.Panel();
		this.Panel113 = new System.Windows.Forms.Panel();
		this.Label88 = new System.Windows.Forms.Label();
		this.Panel114 = new System.Windows.Forms.Panel();
		this.Label89 = new System.Windows.Forms.Label();
		this.Panel117 = new System.Windows.Forms.Panel();
		this.Panel118 = new System.Windows.Forms.Panel();
		this.Panel103 = new System.Windows.Forms.Panel();
		this.p3_btn3 = new System.Windows.Forms.Button();
		this.p3_btn2 = new System.Windows.Forms.Button();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.p4 = new System.Windows.Forms.Panel();
		this.p4_text2 = new System.Windows.Forms.TextBox();
		this.Panel16 = new System.Windows.Forms.Panel();
		this.p4_num = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.p4_color4 = new System.Windows.Forms.Label();
		this.p4_color3 = new System.Windows.Forms.Label();
		this.p4_color2 = new System.Windows.Forms.Label();
		this.p4_color1 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.p4_text1 = new System.Windows.Forms.TextBox();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.Button12 = new System.Windows.Forms.Button();
		this.Label20 = new System.Windows.Forms.Label();
		this.p4_ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Panel53 = new System.Windows.Forms.Panel();
		this.txt_noticedetail = new System.Windows.Forms.Label();
		this.txt_notice = new System.Windows.Forms.Label();
		this.Panel15 = new System.Windows.Forms.Panel();
		this.Panel17 = new System.Windows.Forms.Panel();
		this.Panel18 = new System.Windows.Forms.Panel();
		this.Label21 = new System.Windows.Forms.Label();
		this.Panel19 = new System.Windows.Forms.Panel();
		this.Label22 = new System.Windows.Forms.Label();
		this.Panel20 = new System.Windows.Forms.Panel();
		this.Panel21 = new System.Windows.Forms.Panel();
		this.Panel22 = new System.Windows.Forms.Panel();
		this.Button13 = new System.Windows.Forms.Button();
		this.Button14 = new System.Windows.Forms.Button();
		this.TabPage5 = new System.Windows.Forms.TabPage();
		this.p5 = new System.Windows.Forms.Panel();
		this.Panel32 = new System.Windows.Forms.Panel();
		this.code_tb = new System.Windows.Forms.TextBox();
		this.FastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
		this.Panel23 = new System.Windows.Forms.Panel();
		this.Label26 = new System.Windows.Forms.Label();
		this.Label25 = new System.Windows.Forms.Label();
		this.Splitter1 = new System.Windows.Forms.Splitter();
		this.Panel14 = new System.Windows.Forms.Panel();
		this.ListBox2 = new System.Windows.Forms.ListBox();
		this.Button21 = new System.Windows.Forms.Button();
		this.Label17 = new System.Windows.Forms.Label();
		this.ComboBox3 = new System.Windows.Forms.ComboBox();
		this.Label27 = new System.Windows.Forms.Label();
		this.ComboBox2 = new System.Windows.Forms.ComboBox();
		this.Label23 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label24 = new System.Windows.Forms.Label();
		this.Button27 = new System.Windows.Forms.Button();
		this.Button22 = new System.Windows.Forms.Button();
		this.Panel25 = new System.Windows.Forms.Panel();
		this.Panel26 = new System.Windows.Forms.Panel();
		this.Panel27 = new System.Windows.Forms.Panel();
		this.Label31 = new System.Windows.Forms.Label();
		this.Panel28 = new System.Windows.Forms.Panel();
		this.Label32 = new System.Windows.Forms.Label();
		this.Panel29 = new System.Windows.Forms.Panel();
		this.Panel30 = new System.Windows.Forms.Panel();
		this.Panel31 = new System.Windows.Forms.Panel();
		this.Button16 = new System.Windows.Forms.Button();
		this.TabPage7 = new System.Windows.Forms.TabPage();
		this.p_diag2 = new System.Windows.Forms.Panel();
		this.p_diag2_t5 = new System.Windows.Forms.NumericUpDown();
		this.Button32 = new System.Windows.Forms.Button();
		this.p_diag2_num = new System.Windows.Forms.Label();
		this.p_diag2_rb2 = new System.Windows.Forms.RadioButton();
		this.p_diag2_rb1 = new System.Windows.Forms.RadioButton();
		this.p_diag2_chk1 = new System.Windows.Forms.CheckBox();
		this.p_diag2_c1 = new System.Windows.Forms.ComboBox();
		this.p_diag2_c2 = new System.Windows.Forms.ComboBox();
		this.Label54 = new System.Windows.Forms.Label();
		this.Label52 = new System.Windows.Forms.Label();
		this.Label44 = new System.Windows.Forms.Label();
		this.p_diag2_t4 = new System.Windows.Forms.TextBox();
		this.Label45 = new System.Windows.Forms.Label();
		this.Label46 = new System.Windows.Forms.Label();
		this.p_diag2_t2 = new System.Windows.Forms.TextBox();
		this.Label48 = new System.Windows.Forms.Label();
		this.p_diag2_t1 = new System.Windows.Forms.TextBox();
		this.Label49 = new System.Windows.Forms.Label();
		this.Panel38 = new System.Windows.Forms.Panel();
		this.Button31 = new System.Windows.Forms.Button();
		this.Button15 = new System.Windows.Forms.Button();
		this.Button28 = new System.Windows.Forms.Button();
		this.Label50 = new System.Windows.Forms.Label();
		this.p_diag2_t3 = new System.Windows.Forms.TextBox();
		this.Label47 = new System.Windows.Forms.Label();
		this.Label51 = new System.Windows.Forms.Label();
		this.p_diag2_t6 = new System.Windows.Forms.TextBox();
		this.Label53 = new System.Windows.Forms.Label();
		this.p_diag1 = new System.Windows.Forms.Panel();
		this.p_diag1_num = new System.Windows.Forms.Label();
		this.p_diag1_t6 = new System.Windows.Forms.TextBox();
		this.Label43 = new System.Windows.Forms.Label();
		this.p_diag1_t5 = new System.Windows.Forms.TextBox();
		this.Label42 = new System.Windows.Forms.Label();
		this.p_diag1_t4 = new System.Windows.Forms.TextBox();
		this.Label41 = new System.Windows.Forms.Label();
		this.p_diag1_t3 = new System.Windows.Forms.TextBox();
		this.Label39 = new System.Windows.Forms.Label();
		this.p_diag1_t2 = new System.Windows.Forms.TextBox();
		this.Label38 = new System.Windows.Forms.Label();
		this.p_diag1_t1 = new System.Windows.Forms.TextBox();
		this.Label36 = new System.Windows.Forms.Label();
		this.Panel36 = new System.Windows.Forms.Panel();
		this.Button33 = new System.Windows.Forms.Button();
		this.Button29 = new System.Windows.Forms.Button();
		this.Button30 = new System.Windows.Forms.Button();
		this.Label40 = new System.Windows.Forms.Label();
		this.TabPage6 = new System.Windows.Forms.TabPage();
		this.p_ftp_mname = new System.Windows.Forms.Panel();
		this.Label37 = new System.Windows.Forms.Label();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.Label35 = new System.Windows.Forms.Label();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.Label30 = new System.Windows.Forms.Label();
		this.Panel34 = new System.Windows.Forms.Panel();
		this.Button25 = new System.Windows.Forms.Button();
		this.Button26 = new System.Windows.Forms.Button();
		this.Label34 = new System.Windows.Forms.Label();
		this.p_ftp_file = new System.Windows.Forms.Panel();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.Label28 = new System.Windows.Forms.Label();
		this.Panel33 = new System.Windows.Forms.Panel();
		this.Button23 = new System.Windows.Forms.Button();
		this.Button24 = new System.Windows.Forms.Button();
		this.Label33 = new System.Windows.Forms.Label();
		this.Label29 = new System.Windows.Forms.Label();
		this.p_ftp_login = new System.Windows.Forms.Panel();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.Button20 = new System.Windows.Forms.Button();
		this.Button17 = new System.Windows.Forms.Button();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.Panel24 = new System.Windows.Forms.Panel();
		this.Button11 = new System.Windows.Forms.Button();
		this.Button19 = new System.Windows.Forms.Button();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Button34 = new System.Windows.Forms.Button();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.p1.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel8.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.p2.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.Panel12.SuspendLayout();
		this.TabPage8.SuspendLayout();
		this.p6.SuspendLayout();
		this.Panel37.SuspendLayout();
		this.Panel43.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.p3.SuspendLayout();
		this.Panel109.SuspendLayout();
		this.Panel112.SuspendLayout();
		this.Panel113.SuspendLayout();
		this.Panel103.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.p4.SuspendLayout();
		this.Panel16.SuspendLayout();
		this.Panel53.SuspendLayout();
		this.Panel17.SuspendLayout();
		this.Panel18.SuspendLayout();
		this.Panel22.SuspendLayout();
		this.TabPage5.SuspendLayout();
		this.p5.SuspendLayout();
		this.Panel32.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.FastColoredTextBox1).BeginInit();
		this.Panel23.SuspendLayout();
		this.Panel14.SuspendLayout();
		this.Panel26.SuspendLayout();
		this.Panel27.SuspendLayout();
		this.Panel31.SuspendLayout();
		this.TabPage7.SuspendLayout();
		this.p_diag2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.p_diag2_t5).BeginInit();
		this.Panel38.SuspendLayout();
		this.p_diag1.SuspendLayout();
		this.Panel36.SuspendLayout();
		this.TabPage6.SuspendLayout();
		this.p_ftp_mname.SuspendLayout();
		this.Panel34.SuspendLayout();
		this.p_ftp_file.SuspendLayout();
		this.Panel33.SuspendLayout();
		this.p_ftp_login.SuspendLayout();
		this.Panel24.SuspendLayout();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage8);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Controls.Add(this.TabPage5);
		this.TabControl1.Controls.Add(this.TabPage7);
		this.TabControl1.Controls.Add(this.TabPage6);
		this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabControl1.Location = new System.Drawing.Point(0, 0);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(845, 662);
		this.TabControl1.TabIndex = 0;
		this.TabPage1.Controls.Add(this.p1);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new System.Drawing.Size(837, 636);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "고객관리";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.p1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p1.Controls.Add(this.ListView4);
		this.p1.Controls.Add(this.Panel2);
		this.p1.Controls.Add(this.Panel5);
		this.p1.Controls.Add(this.Panel6);
		this.p1.Controls.Add(this.Panel7);
		this.p1.Controls.Add(this.Panel8);
		this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p1.Location = new System.Drawing.Point(0, 0);
		this.p1.Name = "p1";
		this.p1.Size = new System.Drawing.Size(837, 636);
		this.p1.TabIndex = 15;
		this.ListView4.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.ListView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[8] { this.ColumnHeader29, this.ColumnHeader32, this.ColumnHeader28, this.ColumnHeader2, this.ColumnHeader15, this.ColumnHeader1, this.ColumnHeader16, this.ColumnHeader3 });
		this.ListView4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView4.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListView4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListView4.FullRowSelect = true;
		this.ListView4.HideSelection = false;
		listViewItem.StateImageIndex = 0;
		this.ListView4.Items.AddRange(new System.Windows.Forms.ListViewItem[1] { listViewItem });
		this.ListView4.Location = new System.Drawing.Point(23, 56);
		this.ListView4.MultiSelect = false;
		this.ListView4.Name = "ListView4";
		this.ListView4.Size = new System.Drawing.Size(791, 513);
		this.ListView4.TabIndex = 55;
		this.ListView4.UseCompatibleStateImageBehavior = false;
		this.ListView4.View = System.Windows.Forms.View.Details;
		this.ColumnHeader29.Text = "";
		this.ColumnHeader29.Width = 40;
		this.ColumnHeader32.Text = "이름";
		this.ColumnHeader28.Text = "전화번호";
		this.ColumnHeader28.Width = 100;
		this.ColumnHeader2.Text = "팩스";
		this.ColumnHeader2.Width = 100;
		this.ColumnHeader15.Text = "사업자번호";
		this.ColumnHeader15.Width = 100;
		this.ColumnHeader1.Text = "이메일";
		this.ColumnHeader1.Width = 160;
		this.ColumnHeader16.Text = "주소";
		this.ColumnHeader16.Width = 80;
		this.ColumnHeader3.Text = "계약수";
		this.Panel2.Controls.Add(this.Label2);
		this.Panel2.Controls.Add(this.Panel3);
		this.Panel2.Controls.Add(this.Label3);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(23, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(791, 56);
		this.Panel2.TabIndex = 45;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label2.Location = new System.Drawing.Point(0, 15);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(109, 30);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "고객 관리";
		this.Panel3.BackColor = System.Drawing.Color.Gray;
		this.Panel3.Location = new System.Drawing.Point(110, 41);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(2000, 1);
		this.Panel3.TabIndex = 3;
		this.Label3.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label3.Location = new System.Drawing.Point(108, 15);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(901, 30);
		this.Label3.TabIndex = 2;
		this.Label3.Text = "Microlivire 고객 관리 페이지";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel5.Location = new System.Drawing.Point(23, 569);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(791, 23);
		this.Panel5.TabIndex = 53;
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel6.Location = new System.Drawing.Point(0, 0);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(23, 592);
		this.Panel6.TabIndex = 43;
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel7.Location = new System.Drawing.Point(814, 0);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new System.Drawing.Size(23, 592);
		this.Panel7.TabIndex = 44;
		this.Panel8.Controls.Add(this.Button18);
		this.Panel8.Controls.Add(this.Button1);
		this.Panel8.Controls.Add(this.Button10);
		this.Panel8.Controls.Add(this.Button7);
		this.Panel8.Controls.Add(this.Button3);
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel8.Location = new System.Drawing.Point(0, 592);
		this.Panel8.Name = "Panel8";
		this.Panel8.Padding = new System.Windows.Forms.Padding(5);
		this.Panel8.Size = new System.Drawing.Size(837, 44);
		this.Panel8.TabIndex = 46;
		this.Button18.BackColor = System.Drawing.Color.OliveDrab;
		this.Button18.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button18.BackgroundImage");
		this.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button18.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button18.ForeColor = System.Drawing.Color.White;
		this.Button18.Location = new System.Drawing.Point(678, 5);
		this.Button18.Name = "Button18";
		this.Button18.Size = new System.Drawing.Size(65, 34);
		this.Button18.TabIndex = 33;
		this.Button18.Text = "열 맞춤";
		this.Button18.UseVisualStyleBackColor = false;
		this.Button1.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.Button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button1.BackgroundImage");
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(169, 5);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(84, 34);
		this.Button1.TabIndex = 32;
		this.Button1.Text = "삭제";
		this.Button1.UseVisualStyleBackColor = false;
		this.Button10.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button10.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button10.BackgroundImage");
		this.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button10.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button10.ForeColor = System.Drawing.Color.White;
		this.Button10.Location = new System.Drawing.Point(743, 5);
		this.Button10.Name = "Button10";
		this.Button10.Size = new System.Drawing.Size(89, 34);
		this.Button10.TabIndex = 31;
		this.Button10.Text = "내보내기";
		this.Button10.UseVisualStyleBackColor = false;
		this.Button10.Visible = false;
		this.Button7.BackColor = System.Drawing.Color.DarkGreen;
		this.Button7.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button7.BackgroundImage");
		this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button7.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button7.ForeColor = System.Drawing.Color.White;
		this.Button7.Location = new System.Drawing.Point(85, 5);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(84, 34);
		this.Button7.TabIndex = 29;
		this.Button7.Text = "새 고객";
		this.Button7.UseVisualStyleBackColor = false;
		this.Button3.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button3.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.ForeColor = System.Drawing.Color.White;
		this.Button3.Location = new System.Drawing.Point(5, 5);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(80, 34);
		this.Button3.TabIndex = 28;
		this.Button3.Text = "새로고침";
		this.Button3.UseVisualStyleBackColor = false;
		this.TabPage2.Controls.Add(this.p2);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new System.Drawing.Size(837, 636);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "프로젝트관리";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.p2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p2.Controls.Add(this.ListView1);
		this.p2.Controls.Add(this.Panel1);
		this.p2.Controls.Add(this.Panel9);
		this.p2.Controls.Add(this.Panel10);
		this.p2.Controls.Add(this.Panel11);
		this.p2.Controls.Add(this.Panel12);
		this.p2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p2.Location = new System.Drawing.Point(0, 0);
		this.p2.Name = "p2";
		this.p2.Size = new System.Drawing.Size(837, 636);
		this.p2.TabIndex = 16;
		this.ListView1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[11]
		{
			this.ColumnHeader4, this.ColumnHeader5, this.ColumnHeader6, this.ColumnHeader7, this.ColumnHeader8, this.ColumnHeader9, this.ColumnHeader10, this.ColumnHeader11, this.ColumnHeader12, this.ColumnHeader13,
			this.ColumnHeader14
		});
		this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListView1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListView1.FullRowSelect = true;
		this.ListView1.HideSelection = false;
		listViewItem2.StateImageIndex = 0;
		this.ListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[1] { listViewItem2 });
		this.ListView1.Location = new System.Drawing.Point(23, 56);
		this.ListView1.MultiSelect = false;
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(791, 513);
		this.ListView1.TabIndex = 55;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader4.Text = "";
		this.ColumnHeader4.Width = 40;
		this.ColumnHeader5.Text = "프로젝트 명";
		this.ColumnHeader5.Width = 260;
		this.ColumnHeader6.Text = "계정";
		this.ColumnHeader6.Width = 100;
		this.ColumnHeader7.Text = "암호";
		this.ColumnHeader7.Width = 100;
		this.ColumnHeader8.Text = "고객명";
		this.ColumnHeader8.Width = 120;
		this.ColumnHeader9.Text = "위치";
		this.ColumnHeader9.Width = 250;
		this.ColumnHeader10.Text = "인코딩";
		this.ColumnHeader11.Text = "권한";
		this.ColumnHeader12.Text = "버전";
		this.ColumnHeader13.Text = "공지";
		this.ColumnHeader14.Text = "최종 접속일";
		this.ColumnHeader14.Width = 140;
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Controls.Add(this.Panel4);
		this.Panel1.Controls.Add(this.Label4);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(23, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(791, 56);
		this.Panel1.TabIndex = 45;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label1.Location = new System.Drawing.Point(0, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(153, 30);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "프로젝트 관리";
		this.Panel4.BackColor = System.Drawing.Color.Gray;
		this.Panel4.Location = new System.Drawing.Point(155, 41);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(2000, 1);
		this.Panel4.TabIndex = 3;
		this.Label4.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label4.Location = new System.Drawing.Point(153, 15);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(901, 30);
		this.Label4.TabIndex = 2;
		this.Label4.Text = "프로젝트 집합을 표시합니다.";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel9.Location = new System.Drawing.Point(23, 569);
		this.Panel9.Name = "Panel9";
		this.Panel9.Size = new System.Drawing.Size(791, 23);
		this.Panel9.TabIndex = 53;
		this.Panel10.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel10.Location = new System.Drawing.Point(0, 0);
		this.Panel10.Name = "Panel10";
		this.Panel10.Size = new System.Drawing.Size(23, 592);
		this.Panel10.TabIndex = 43;
		this.Panel11.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel11.Location = new System.Drawing.Point(814, 0);
		this.Panel11.Name = "Panel11";
		this.Panel11.Size = new System.Drawing.Size(23, 592);
		this.Panel11.TabIndex = 44;
		this.Panel12.Controls.Add(this.Button34);
		this.Panel12.Controls.Add(this.Button9);
		this.Panel12.Controls.Add(this.Button8);
		this.Panel12.Controls.Add(this.Button2);
		this.Panel12.Controls.Add(this.Button4);
		this.Panel12.Controls.Add(this.Button5);
		this.Panel12.Controls.Add(this.Button6);
		this.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel12.Location = new System.Drawing.Point(0, 592);
		this.Panel12.Name = "Panel12";
		this.Panel12.Padding = new System.Windows.Forms.Padding(5);
		this.Panel12.Size = new System.Drawing.Size(837, 44);
		this.Panel12.TabIndex = 46;
		this.Button9.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button9.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button9.BackgroundImage");
		this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button9.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button9.ForeColor = System.Drawing.Color.White;
		this.Button9.Location = new System.Drawing.Point(253, 5);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(80, 34);
		this.Button9.TabIndex = 34;
		this.Button9.Text = "고객센터";
		this.Button9.UseVisualStyleBackColor = false;
		this.Button8.BackColor = System.Drawing.Color.OliveDrab;
		this.Button8.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button8.BackgroundImage");
		this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button8.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button8.ForeColor = System.Drawing.Color.White;
		this.Button8.Location = new System.Drawing.Point(678, 5);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(65, 34);
		this.Button8.TabIndex = 33;
		this.Button8.Text = "열 맞춤";
		this.Button8.UseVisualStyleBackColor = false;
		this.Button2.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.Button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button2.BackgroundImage");
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = System.Drawing.Color.White;
		this.Button2.Location = new System.Drawing.Point(169, 5);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(84, 34);
		this.Button2.TabIndex = 32;
		this.Button2.Text = "삭제";
		this.Button2.UseVisualStyleBackColor = false;
		this.Button4.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button4.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button4.BackgroundImage");
		this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button4.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button4.ForeColor = System.Drawing.Color.White;
		this.Button4.Location = new System.Drawing.Point(743, 5);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(89, 34);
		this.Button4.TabIndex = 31;
		this.Button4.Text = "내보내기";
		this.Button4.UseVisualStyleBackColor = false;
		this.Button4.Visible = false;
		this.Button5.BackColor = System.Drawing.Color.DarkGreen;
		this.Button5.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button5.BackgroundImage");
		this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button5.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button5.ForeColor = System.Drawing.Color.White;
		this.Button5.Location = new System.Drawing.Point(85, 5);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(84, 34);
		this.Button5.TabIndex = 29;
		this.Button5.Text = "새 프로젝트";
		this.Button5.UseVisualStyleBackColor = false;
		this.Button6.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button6.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button6.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button6.ForeColor = System.Drawing.Color.White;
		this.Button6.Location = new System.Drawing.Point(5, 5);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(80, 34);
		this.Button6.TabIndex = 28;
		this.Button6.Text = "새로고침";
		this.Button6.UseVisualStyleBackColor = false;
		this.TabPage8.Controls.Add(this.p6);
		this.TabPage8.Location = new System.Drawing.Point(4, 22);
		this.TabPage8.Name = "TabPage8";
		this.TabPage8.Size = new System.Drawing.Size(837, 636);
		this.TabPage8.TabIndex = 7;
		this.TabPage8.Text = "접속 로그";
		this.TabPage8.UseVisualStyleBackColor = true;
		this.p6.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p6.Controls.Add(this.ListView2);
		this.p6.Controls.Add(this.Panel37);
		this.p6.Controls.Add(this.Panel40);
		this.p6.Controls.Add(this.Panel41);
		this.p6.Controls.Add(this.Panel42);
		this.p6.Controls.Add(this.Panel43);
		this.p6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p6.Location = new System.Drawing.Point(0, 0);
		this.p6.Name = "p6";
		this.p6.Size = new System.Drawing.Size(837, 636);
		this.p6.TabIndex = 17;
		this.ListView2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[5] { this.ColumnHeader17, this.ColumnHeader18, this.ColumnHeader19, this.ColumnHeader20, this.ColumnHeader21 });
		this.ListView2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView2.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListView2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListView2.FullRowSelect = true;
		this.ListView2.HideSelection = false;
		listViewItem3.StateImageIndex = 0;
		this.ListView2.Items.AddRange(new System.Windows.Forms.ListViewItem[1] { listViewItem3 });
		this.ListView2.Location = new System.Drawing.Point(23, 56);
		this.ListView2.MultiSelect = false;
		this.ListView2.Name = "ListView2";
		this.ListView2.Size = new System.Drawing.Size(791, 513);
		this.ListView2.TabIndex = 55;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.ListView2.View = System.Windows.Forms.View.Details;
		this.ColumnHeader17.Text = "";
		this.ColumnHeader17.Width = 40;
		this.ColumnHeader18.Text = "프로젝트 명";
		this.ColumnHeader18.Width = 260;
		this.ColumnHeader19.Text = "계정";
		this.ColumnHeader19.Width = 100;
		this.ColumnHeader20.Text = "접속 시간";
		this.ColumnHeader20.Width = 150;
		this.ColumnHeader21.Text = "IP";
		this.ColumnHeader21.Width = 150;
		this.Panel37.Controls.Add(this.Label55);
		this.Panel37.Controls.Add(this.Panel39);
		this.Panel37.Controls.Add(this.Label56);
		this.Panel37.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel37.Location = new System.Drawing.Point(23, 0);
		this.Panel37.Name = "Panel37";
		this.Panel37.Size = new System.Drawing.Size(791, 56);
		this.Panel37.TabIndex = 45;
		this.Label55.AutoSize = true;
		this.Label55.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label55.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label55.Location = new System.Drawing.Point(0, 15);
		this.Label55.Name = "Label55";
		this.Label55.Size = new System.Drawing.Size(109, 30);
		this.Label55.TabIndex = 1;
		this.Label55.Text = "접속 로그";
		this.Panel39.BackColor = System.Drawing.Color.Gray;
		this.Panel39.Location = new System.Drawing.Point(109, 41);
		this.Panel39.Name = "Panel39";
		this.Panel39.Size = new System.Drawing.Size(2000, 1);
		this.Panel39.TabIndex = 3;
		this.Label56.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label56.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label56.Location = new System.Drawing.Point(107, 15);
		this.Label56.Name = "Label56";
		this.Label56.Size = new System.Drawing.Size(901, 30);
		this.Label56.TabIndex = 2;
		this.Label56.Text = "접속 로그를 확인합니다.";
		this.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel40.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel40.Location = new System.Drawing.Point(23, 569);
		this.Panel40.Name = "Panel40";
		this.Panel40.Size = new System.Drawing.Size(791, 23);
		this.Panel40.TabIndex = 53;
		this.Panel41.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel41.Location = new System.Drawing.Point(0, 0);
		this.Panel41.Name = "Panel41";
		this.Panel41.Size = new System.Drawing.Size(23, 592);
		this.Panel41.TabIndex = 43;
		this.Panel42.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel42.Location = new System.Drawing.Point(814, 0);
		this.Panel42.Name = "Panel42";
		this.Panel42.Size = new System.Drawing.Size(23, 592);
		this.Panel42.TabIndex = 44;
		this.Panel43.Controls.Add(this.Button39);
		this.Panel43.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel43.Location = new System.Drawing.Point(0, 592);
		this.Panel43.Name = "Panel43";
		this.Panel43.Padding = new System.Windows.Forms.Padding(5);
		this.Panel43.Size = new System.Drawing.Size(837, 44);
		this.Panel43.TabIndex = 46;
		this.Button39.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button39.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button39.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button39.ForeColor = System.Drawing.Color.White;
		this.Button39.Location = new System.Drawing.Point(5, 5);
		this.Button39.Name = "Button39";
		this.Button39.Size = new System.Drawing.Size(80, 34);
		this.Button39.TabIndex = 28;
		this.Button39.Text = "새로고침";
		this.Button39.UseVisualStyleBackColor = false;
		this.TabPage3.Controls.Add(this.p3);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(837, 636);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "고객센터";
		this.TabPage3.UseVisualStyleBackColor = true;
		this.p3.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p3.Controls.Add(this.p3_text3);
		this.p3.Controls.Add(this.Panel13);
		this.p3.Controls.Add(this.Panel109);
		this.p3.Controls.Add(this.Panel112);
		this.p3.Controls.Add(this.Panel117);
		this.p3.Controls.Add(this.Panel118);
		this.p3.Controls.Add(this.Panel103);
		this.p3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p3.Location = new System.Drawing.Point(0, 0);
		this.p3.Name = "p3";
		this.p3.Size = new System.Drawing.Size(837, 636);
		this.p3.TabIndex = 24;
		this.p3.Visible = false;
		this.p3_text3.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p3_text3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p3_text3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p3_text3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p3_text3.Font = new System.Drawing.Font("굴림", 10f);
		this.p3_text3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p3_text3.Location = new System.Drawing.Point(23, 252);
		this.p3_text3.MaxLength = 0;
		this.p3_text3.Multiline = true;
		this.p3_text3.Name = "p3_text3";
		this.p3_text3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.p3_text3.Size = new System.Drawing.Size(791, 322);
		this.p3_text3.TabIndex = 15;
		this.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel13.Location = new System.Drawing.Point(23, 574);
		this.Panel13.Name = "Panel13";
		this.Panel13.Size = new System.Drawing.Size(791, 18);
		this.Panel13.TabIndex = 44;
		this.Panel109.Controls.Add(this.p3_num);
		this.Panel109.Controls.Add(this.Label9);
		this.Panel109.Controls.Add(this.p3_date);
		this.Panel109.Controls.Add(this.Label8);
		this.Panel109.Controls.Add(this.p3_writer);
		this.Panel109.Controls.Add(this.Label7);
		this.Panel109.Controls.Add(this.p3_kb);
		this.Panel109.Controls.Add(this.p3_filesearch);
		this.Panel109.Controls.Add(this.p3_count);
		this.Panel109.Controls.Add(this.p3_text2);
		this.Panel109.Controls.Add(this.Label6);
		this.Panel109.Controls.Add(this.Label5);
		this.Panel109.Controls.Add(this.p3_combobox2);
		this.Panel109.Controls.Add(this.p3_text1);
		this.Panel109.Controls.Add(this.Label84);
		this.Panel109.Controls.Add(this.Label85);
		this.Panel109.Controls.Add(this.p3_btn1);
		this.Panel109.Controls.Add(this.Label86);
		this.Panel109.Controls.Add(this.p3_combobox1);
		this.Panel109.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel109.Location = new System.Drawing.Point(23, 56);
		this.Panel109.Name = "Panel109";
		this.Panel109.Size = new System.Drawing.Size(791, 196);
		this.Panel109.TabIndex = 17;
		this.p3_num.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.p3_num.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p3_num.Location = new System.Drawing.Point(661, 74);
		this.p3_num.Name = "p3_num";
		this.p3_num.Size = new System.Drawing.Size(60, 25);
		this.p3_num.TabIndex = 61;
		this.p3_num.Text = "0";
		this.p3_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label9.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label9.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label9.Location = new System.Drawing.Point(611, 74);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(55, 25);
		this.Label9.TabIndex = 62;
		this.Label9.Text = "글 번호 :";
		this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.p3_date.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.p3_date.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p3_date.Location = new System.Drawing.Point(393, 136);
		this.p3_date.Name = "p3_date";
		this.p3_date.Size = new System.Drawing.Size(212, 25);
		this.p3_date.TabIndex = 60;
		this.p3_date.Text = "작성일";
		this.p3_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label8.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label8.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label8.Location = new System.Drawing.Point(319, 136);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(68, 25);
		this.Label8.TabIndex = 58;
		this.Label8.Text = "작성일";
		this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.p3_writer.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p3_writer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p3_writer.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p3_writer.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p3_writer.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p3_writer.Location = new System.Drawing.Point(129, 136);
		this.p3_writer.Name = "p3_writer";
		this.p3_writer.Size = new System.Drawing.Size(173, 25);
		this.p3_writer.TabIndex = 57;
		this.Label7.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label7.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label7.Location = new System.Drawing.Point(10, 136);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(113, 25);
		this.Label7.TabIndex = 56;
		this.Label7.Text = "작성자";
		this.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.p3_kb.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p3_kb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p3_kb.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p3_kb.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p3_kb.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p3_kb.Location = new System.Drawing.Point(578, 105);
		this.p3_kb.Name = "p3_kb";
		this.p3_kb.Size = new System.Drawing.Size(108, 25);
		this.p3_kb.TabIndex = 54;
		this.p3_filesearch.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p3_filesearch.BackgroundImage = (System.Drawing.Image)resources.GetObject("p3_filesearch.BackgroundImage");
		this.p3_filesearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.p3_filesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p3_filesearch.ForeColor = System.Drawing.Color.White;
		this.p3_filesearch.Location = new System.Drawing.Point(498, 105);
		this.p3_filesearch.Name = "p3_filesearch";
		this.p3_filesearch.Size = new System.Drawing.Size(74, 25);
		this.p3_filesearch.TabIndex = 52;
		this.p3_filesearch.Text = "파일 찾기";
		this.p3_filesearch.UseVisualStyleBackColor = false;
		this.p3_count.AutoSize = true;
		this.p3_count.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.p3_count.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p3_count.Location = new System.Drawing.Point(611, 13);
		this.p3_count.Name = "p3_count";
		this.p3_count.Size = new System.Drawing.Size(59, 17);
		this.p3_count.TabIndex = 51;
		this.p3_count.Text = "총 0항목";
		this.p3_text2.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p3_text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p3_text2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p3_text2.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p3_text2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p3_text2.Location = new System.Drawing.Point(129, 105);
		this.p3_text2.Name = "p3_text2";
		this.p3_text2.Size = new System.Drawing.Size(363, 25);
		this.p3_text2.TabIndex = 50;
		this.Label6.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label6.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label6.Location = new System.Drawing.Point(10, 105);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(113, 25);
		this.Label6.TabIndex = 49;
		this.Label6.Text = "파일첨부";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label5.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label5.Location = new System.Drawing.Point(60, 43);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(64, 21);
		this.Label5.TabIndex = 47;
		this.Label5.Text = "글 선택";
		this.p3_combobox2.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.p3_combobox2.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.p3_combobox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.p3_combobox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.p3_combobox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p3_combobox2.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p3_combobox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p3_combobox2.FormattingEnabled = true;
		this.p3_combobox2.IntegralHeight = false;
		this.p3_combobox2.Location = new System.Drawing.Point(129, 42);
		this.p3_combobox2.MaxDropDownItems = 20;
		this.p3_combobox2.Name = "p3_combobox2";
		this.p3_combobox2.Size = new System.Drawing.Size(476, 26);
		this.p3_combobox2.TabIndex = 48;
		this.p3_text1.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p3_text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p3_text1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p3_text1.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p3_text1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p3_text1.Location = new System.Drawing.Point(129, 74);
		this.p3_text1.Name = "p3_text1";
		this.p3_text1.Size = new System.Drawing.Size(476, 25);
		this.p3_text1.TabIndex = 46;
		this.Label84.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label84.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label84.Location = new System.Drawing.Point(10, 74);
		this.Label84.Name = "Label84";
		this.Label84.Size = new System.Drawing.Size(113, 25);
		this.Label84.TabIndex = 17;
		this.Label84.Text = "제목";
		this.Label84.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label85.AutoSize = true;
		this.Label85.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label85.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label85.Location = new System.Drawing.Point(11, 172);
		this.Label85.Name = "Label85";
		this.Label85.Size = new System.Drawing.Size(49, 21);
		this.Label85.TabIndex = 16;
		this.Label85.Text = "body";
		this.p3_btn1.BackColor = System.Drawing.Color.Maroon;
		this.p3_btn1.BackgroundImage = (System.Drawing.Image)resources.GetObject("p3_btn1.BackgroundImage");
		this.p3_btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.p3_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p3_btn1.ForeColor = System.Drawing.Color.White;
		this.p3_btn1.Location = new System.Drawing.Point(614, 43);
		this.p3_btn1.Name = "p3_btn1";
		this.p3_btn1.Size = new System.Drawing.Size(107, 25);
		this.p3_btn1.TabIndex = 7;
		this.p3_btn1.Text = "이 게시글 삭제";
		this.p3_btn1.UseVisualStyleBackColor = false;
		this.Label86.AutoSize = true;
		this.Label86.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label86.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label86.Location = new System.Drawing.Point(11, 10);
		this.Label86.Name = "Label86";
		this.Label86.Size = new System.Drawing.Size(112, 21);
		this.Label86.TabIndex = 0;
		this.Label86.Text = "프로젝트 선택";
		this.p3_combobox1.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.p3_combobox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.p3_combobox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.p3_combobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.p3_combobox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p3_combobox1.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p3_combobox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p3_combobox1.FormattingEnabled = true;
		this.p3_combobox1.Location = new System.Drawing.Point(129, 10);
		this.p3_combobox1.Name = "p3_combobox1";
		this.p3_combobox1.Size = new System.Drawing.Size(476, 26);
		this.p3_combobox1.TabIndex = 3;
		this.Panel112.Controls.Add(this.Panel113);
		this.Panel112.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel112.Location = new System.Drawing.Point(23, 0);
		this.Panel112.Name = "Panel112";
		this.Panel112.Size = new System.Drawing.Size(791, 56);
		this.Panel112.TabIndex = 21;
		this.Panel113.Controls.Add(this.Label88);
		this.Panel113.Controls.Add(this.Panel114);
		this.Panel113.Controls.Add(this.Label89);
		this.Panel113.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel113.Location = new System.Drawing.Point(0, 0);
		this.Panel113.Name = "Panel113";
		this.Panel113.Size = new System.Drawing.Size(791, 56);
		this.Panel113.TabIndex = 4;
		this.Label88.AutoSize = true;
		this.Label88.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label88.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label88.Location = new System.Drawing.Point(0, 15);
		this.Label88.Name = "Label88";
		this.Label88.Size = new System.Drawing.Size(153, 30);
		this.Label88.TabIndex = 1;
		this.Label88.Text = "고객센터 관리";
		this.Panel114.BackColor = System.Drawing.Color.Gray;
		this.Panel114.Location = new System.Drawing.Point(157, 41);
		this.Panel114.Name = "Panel114";
		this.Panel114.Size = new System.Drawing.Size(2000, 1);
		this.Panel114.TabIndex = 3;
		this.Label89.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label89.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label89.Location = new System.Drawing.Point(155, 15);
		this.Label89.Name = "Label89";
		this.Label89.Size = new System.Drawing.Size(768, 30);
		this.Label89.TabIndex = 2;
		this.Label89.Text = "프로젝트별 고객센터 운영";
		this.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel117.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel117.Location = new System.Drawing.Point(814, 0);
		this.Panel117.Name = "Panel117";
		this.Panel117.Size = new System.Drawing.Size(23, 592);
		this.Panel117.TabIndex = 20;
		this.Panel118.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel118.Location = new System.Drawing.Point(0, 0);
		this.Panel118.Name = "Panel118";
		this.Panel118.Size = new System.Drawing.Size(23, 592);
		this.Panel118.TabIndex = 19;
		this.Panel103.Controls.Add(this.p3_btn3);
		this.Panel103.Controls.Add(this.p3_btn2);
		this.Panel103.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel103.Location = new System.Drawing.Point(0, 592);
		this.Panel103.Name = "Panel103";
		this.Panel103.Padding = new System.Windows.Forms.Padding(5);
		this.Panel103.Size = new System.Drawing.Size(837, 44);
		this.Panel103.TabIndex = 43;
		this.p3_btn3.BackColor = System.Drawing.Color.DarkGreen;
		this.p3_btn3.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.p3_btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.p3_btn3.Dock = System.Windows.Forms.DockStyle.Left;
		this.p3_btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p3_btn3.ForeColor = System.Drawing.Color.White;
		this.p3_btn3.Location = new System.Drawing.Point(85, 5);
		this.p3_btn3.Name = "p3_btn3";
		this.p3_btn3.Size = new System.Drawing.Size(80, 34);
		this.p3_btn3.TabIndex = 8;
		this.p3_btn3.Text = "새 글 작성";
		this.p3_btn3.UseVisualStyleBackColor = false;
		this.p3_btn2.BackColor = System.Drawing.Color.SaddleBrown;
		this.p3_btn2.BackgroundImage = (System.Drawing.Image)resources.GetObject("p3_btn2.BackgroundImage");
		this.p3_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.p3_btn2.Dock = System.Windows.Forms.DockStyle.Left;
		this.p3_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p3_btn2.ForeColor = System.Drawing.Color.White;
		this.p3_btn2.Location = new System.Drawing.Point(5, 5);
		this.p3_btn2.Name = "p3_btn2";
		this.p3_btn2.Size = new System.Drawing.Size(80, 34);
		this.p3_btn2.TabIndex = 7;
		this.p3_btn2.Text = "저장";
		this.p3_btn2.UseVisualStyleBackColor = false;
		this.TabPage4.Controls.Add(this.p4);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Margin = new System.Windows.Forms.Padding(0);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(837, 636);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "공지사항관리";
		this.TabPage4.UseVisualStyleBackColor = true;
		this.p4.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p4.Controls.Add(this.p4_text2);
		this.p4.Controls.Add(this.Panel16);
		this.p4.Controls.Add(this.Panel53);
		this.p4.Controls.Add(this.Panel15);
		this.p4.Controls.Add(this.Panel17);
		this.p4.Controls.Add(this.Panel20);
		this.p4.Controls.Add(this.Panel21);
		this.p4.Controls.Add(this.Panel22);
		this.p4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p4.Location = new System.Drawing.Point(0, 0);
		this.p4.Name = "p4";
		this.p4.Size = new System.Drawing.Size(837, 636);
		this.p4.TabIndex = 25;
		this.p4.Visible = false;
		this.p4_text2.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p4_text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p4_text2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p4_text2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p4_text2.Font = new System.Drawing.Font("굴림", 10f);
		this.p4_text2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p4_text2.Location = new System.Drawing.Point(23, 332);
		this.p4_text2.MaxLength = 0;
		this.p4_text2.Multiline = true;
		this.p4_text2.Name = "p4_text2";
		this.p4_text2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.p4_text2.Size = new System.Drawing.Size(791, 242);
		this.p4_text2.TabIndex = 15;
		this.Panel16.Controls.Add(this.p4_num);
		this.Panel16.Controls.Add(this.Label12);
		this.Panel16.Controls.Add(this.p4_color4);
		this.Panel16.Controls.Add(this.p4_color3);
		this.Panel16.Controls.Add(this.p4_color2);
		this.Panel16.Controls.Add(this.p4_color1);
		this.Panel16.Controls.Add(this.Label10);
		this.Panel16.Controls.Add(this.Label15);
		this.Panel16.Controls.Add(this.p4_text1);
		this.Panel16.Controls.Add(this.Label18);
		this.Panel16.Controls.Add(this.Label19);
		this.Panel16.Controls.Add(this.Button12);
		this.Panel16.Controls.Add(this.Label20);
		this.Panel16.Controls.Add(this.p4_ComboBox1);
		this.Panel16.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel16.Location = new System.Drawing.Point(23, 186);
		this.Panel16.Name = "Panel16";
		this.Panel16.Size = new System.Drawing.Size(791, 146);
		this.Panel16.TabIndex = 17;
		this.p4_num.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.p4_num.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p4_num.Location = new System.Drawing.Point(661, 77);
		this.p4_num.Name = "p4_num";
		this.p4_num.Size = new System.Drawing.Size(60, 25);
		this.p4_num.TabIndex = 63;
		this.p4_num.Text = "0";
		this.p4_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label12.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label12.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label12.Location = new System.Drawing.Point(611, 77);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(55, 25);
		this.Label12.TabIndex = 64;
		this.Label12.Text = "글 번호 :";
		this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.p4_color4.BackColor = System.Drawing.Color.DarkGreen;
		this.p4_color4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p4_color4.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.p4_color4.ForeColor = System.Drawing.Color.White;
		this.p4_color4.Location = new System.Drawing.Point(222, 77);
		this.p4_color4.Name = "p4_color4";
		this.p4_color4.Size = new System.Drawing.Size(25, 25);
		this.p4_color4.TabIndex = 56;
		this.p4_color4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.p4_color3.BackColor = System.Drawing.Color.Navy;
		this.p4_color3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p4_color3.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.p4_color3.ForeColor = System.Drawing.Color.White;
		this.p4_color3.Location = new System.Drawing.Point(191, 77);
		this.p4_color3.Name = "p4_color3";
		this.p4_color3.Size = new System.Drawing.Size(25, 25);
		this.p4_color3.TabIndex = 55;
		this.p4_color3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.p4_color2.BackColor = System.Drawing.Color.Maroon;
		this.p4_color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p4_color2.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.p4_color2.ForeColor = System.Drawing.Color.White;
		this.p4_color2.Location = new System.Drawing.Point(160, 77);
		this.p4_color2.Name = "p4_color2";
		this.p4_color2.Size = new System.Drawing.Size(25, 25);
		this.p4_color2.TabIndex = 54;
		this.p4_color2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.p4_color1.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
		this.p4_color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p4_color1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.p4_color1.ForeColor = System.Drawing.Color.White;
		this.p4_color1.Location = new System.Drawing.Point(129, 77);
		this.p4_color1.Name = "p4_color1";
		this.p4_color1.Size = new System.Drawing.Size(25, 25);
		this.p4_color1.TabIndex = 53;
		this.p4_color1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label10.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label10.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label10.Location = new System.Drawing.Point(11, 77);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(113, 25);
		this.Label10.TabIndex = 52;
		this.Label10.Text = "색";
		this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label15.AutoSize = true;
		this.Label15.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label15.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label15.Location = new System.Drawing.Point(611, 13);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(59, 17);
		this.Label15.TabIndex = 51;
		this.Label15.Text = "총 0항목";
		this.p4_text1.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p4_text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p4_text1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p4_text1.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p4_text1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p4_text1.Location = new System.Drawing.Point(129, 43);
		this.p4_text1.Name = "p4_text1";
		this.p4_text1.Size = new System.Drawing.Size(476, 25);
		this.p4_text1.TabIndex = 46;
		this.Label18.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label18.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label18.Location = new System.Drawing.Point(10, 43);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(113, 25);
		this.Label18.TabIndex = 17;
		this.Label18.Text = "제목";
		this.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
		this.Label19.AutoSize = true;
		this.Label19.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label19.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label19.Location = new System.Drawing.Point(11, 118);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(80, 21);
		this.Label19.TabIndex = 16;
		this.Label19.Text = "본문 편집";
		this.Button12.BackColor = System.Drawing.Color.Maroon;
		this.Button12.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button12.BackgroundImage");
		this.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button12.ForeColor = System.Drawing.Color.White;
		this.Button12.Location = new System.Drawing.Point(614, 43);
		this.Button12.Name = "Button12";
		this.Button12.Size = new System.Drawing.Size(107, 25);
		this.Button12.TabIndex = 7;
		this.Button12.Text = "이 글 삭제";
		this.Button12.UseVisualStyleBackColor = false;
		this.Label20.AutoSize = true;
		this.Label20.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label20.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label20.Location = new System.Drawing.Point(11, 10);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(112, 21);
		this.Label20.TabIndex = 0;
		this.Label20.Text = "공지사항 선택";
		this.p4_ComboBox1.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.p4_ComboBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.p4_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.p4_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.p4_ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p4_ComboBox1.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p4_ComboBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p4_ComboBox1.FormattingEnabled = true;
		this.p4_ComboBox1.Location = new System.Drawing.Point(129, 10);
		this.p4_ComboBox1.Name = "p4_ComboBox1";
		this.p4_ComboBox1.Size = new System.Drawing.Size(476, 26);
		this.p4_ComboBox1.TabIndex = 3;
		this.Panel53.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.Panel53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel53.Controls.Add(this.txt_noticedetail);
		this.Panel53.Controls.Add(this.txt_notice);
		this.Panel53.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel53.Location = new System.Drawing.Point(23, 56);
		this.Panel53.Name = "Panel53";
		this.Panel53.Size = new System.Drawing.Size(791, 130);
		this.Panel53.TabIndex = 46;
		this.txt_noticedetail.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.txt_noticedetail.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txt_noticedetail.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.txt_noticedetail.Location = new System.Drawing.Point(0, 24);
		this.txt_noticedetail.Name = "txt_noticedetail";
		this.txt_noticedetail.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
		this.txt_noticedetail.Size = new System.Drawing.Size(789, 104);
		this.txt_noticedetail.TabIndex = 1;
		this.txt_notice.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
		this.txt_notice.Cursor = System.Windows.Forms.Cursors.Default;
		this.txt_notice.Dock = System.Windows.Forms.DockStyle.Top;
		this.txt_notice.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.txt_notice.Location = new System.Drawing.Point(0, 0);
		this.txt_notice.Name = "txt_notice";
		this.txt_notice.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
		this.txt_notice.Size = new System.Drawing.Size(789, 24);
		this.txt_notice.TabIndex = 0;
		this.txt_notice.Text = "공지사항 표시구간";
		this.txt_notice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel15.Location = new System.Drawing.Point(23, 574);
		this.Panel15.Name = "Panel15";
		this.Panel15.Size = new System.Drawing.Size(791, 18);
		this.Panel15.TabIndex = 44;
		this.Panel17.Controls.Add(this.Panel18);
		this.Panel17.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel17.Location = new System.Drawing.Point(23, 0);
		this.Panel17.Name = "Panel17";
		this.Panel17.Size = new System.Drawing.Size(791, 56);
		this.Panel17.TabIndex = 21;
		this.Panel18.Controls.Add(this.Label21);
		this.Panel18.Controls.Add(this.Panel19);
		this.Panel18.Controls.Add(this.Label22);
		this.Panel18.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel18.Location = new System.Drawing.Point(0, 0);
		this.Panel18.Name = "Panel18";
		this.Panel18.Size = new System.Drawing.Size(791, 56);
		this.Panel18.TabIndex = 4;
		this.Label21.AutoSize = true;
		this.Label21.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label21.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label21.Location = new System.Drawing.Point(0, 15);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(153, 30);
		this.Label21.TabIndex = 1;
		this.Label21.Text = "공지사항 관리";
		this.Panel19.BackColor = System.Drawing.Color.Gray;
		this.Panel19.Location = new System.Drawing.Point(157, 41);
		this.Panel19.Name = "Panel19";
		this.Panel19.Size = new System.Drawing.Size(2000, 1);
		this.Panel19.TabIndex = 3;
		this.Label22.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label22.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label22.Location = new System.Drawing.Point(155, 15);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(768, 30);
		this.Label22.TabIndex = 2;
		this.Label22.Text = "MLAS 상단에 노출되는 공지사항을 편집";
		this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel20.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel20.Location = new System.Drawing.Point(814, 0);
		this.Panel20.Name = "Panel20";
		this.Panel20.Size = new System.Drawing.Size(23, 592);
		this.Panel20.TabIndex = 20;
		this.Panel21.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel21.Location = new System.Drawing.Point(0, 0);
		this.Panel21.Name = "Panel21";
		this.Panel21.Size = new System.Drawing.Size(23, 592);
		this.Panel21.TabIndex = 19;
		this.Panel22.Controls.Add(this.Button13);
		this.Panel22.Controls.Add(this.Button14);
		this.Panel22.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel22.Location = new System.Drawing.Point(0, 592);
		this.Panel22.Name = "Panel22";
		this.Panel22.Padding = new System.Windows.Forms.Padding(5);
		this.Panel22.Size = new System.Drawing.Size(837, 44);
		this.Panel22.TabIndex = 43;
		this.Button13.BackColor = System.Drawing.Color.DarkGreen;
		this.Button13.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button13.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button13.ForeColor = System.Drawing.Color.White;
		this.Button13.Location = new System.Drawing.Point(85, 5);
		this.Button13.Name = "Button13";
		this.Button13.Size = new System.Drawing.Size(80, 34);
		this.Button13.TabIndex = 8;
		this.Button13.Text = "새 글 작성";
		this.Button13.UseVisualStyleBackColor = false;
		this.Button14.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button14.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button14.BackgroundImage");
		this.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button14.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button14.ForeColor = System.Drawing.Color.White;
		this.Button14.Location = new System.Drawing.Point(5, 5);
		this.Button14.Name = "Button14";
		this.Button14.Size = new System.Drawing.Size(80, 34);
		this.Button14.TabIndex = 7;
		this.Button14.Text = "저장";
		this.Button14.UseVisualStyleBackColor = false;
		this.TabPage5.Controls.Add(this.p5);
		this.TabPage5.Location = new System.Drawing.Point(4, 22);
		this.TabPage5.Name = "TabPage5";
		this.TabPage5.Size = new System.Drawing.Size(837, 636);
		this.TabPage5.TabIndex = 4;
		this.TabPage5.Text = "FTP 편집기";
		this.TabPage5.UseVisualStyleBackColor = true;
		this.p5.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p5.Controls.Add(this.Panel32);
		this.p5.Controls.Add(this.Splitter1);
		this.p5.Controls.Add(this.Panel14);
		this.p5.Controls.Add(this.Panel25);
		this.p5.Controls.Add(this.Panel26);
		this.p5.Controls.Add(this.Panel29);
		this.p5.Controls.Add(this.Panel30);
		this.p5.Controls.Add(this.Panel31);
		this.p5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p5.Location = new System.Drawing.Point(0, 0);
		this.p5.Name = "p5";
		this.p5.Size = new System.Drawing.Size(837, 636);
		this.p5.TabIndex = 26;
		this.p5.Visible = false;
		this.Panel32.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.Panel32.Controls.Add(this.code_tb);
		this.Panel32.Controls.Add(this.FastColoredTextBox1);
		this.Panel32.Controls.Add(this.Panel23);
		this.Panel32.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel32.Location = new System.Drawing.Point(209, 56);
		this.Panel32.Name = "Panel32";
		this.Panel32.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
		this.Panel32.Size = new System.Drawing.Size(605, 518);
		this.Panel32.TabIndex = 50;
		this.code_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.code_tb.Dock = System.Windows.Forms.DockStyle.Fill;
		this.code_tb.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.code_tb.Location = new System.Drawing.Point(3, 20);
		this.code_tb.Multiline = true;
		this.code_tb.Name = "code_tb";
		this.code_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.code_tb.Size = new System.Drawing.Size(602, 498);
		this.code_tb.TabIndex = 49;
		this.code_tb.Visible = false;
		this.FastColoredTextBox1.AutoCompleteBracketsList = new char[10] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
		this.FastColoredTextBox1.AutoIndentCharsPatterns = "\n^\\s*\\$[\\w\\.\\[\\]\\'\\\"]+\\s*(?<range>=)\\s*(?<range>[^;]+);\n";
		this.FastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(154, 14);
		this.FastColoredTextBox1.BackBrush = null;
		this.FastColoredTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.FastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
		this.FastColoredTextBox1.CharHeight = 14;
		this.FastColoredTextBox1.CharWidth = 8;
		this.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
		this.FastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.FastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75f);
		this.FastColoredTextBox1.IsReplaceMode = false;
		this.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP;
		this.FastColoredTextBox1.LeftBracket = '(';
		this.FastColoredTextBox1.LeftBracket2 = '{';
		this.FastColoredTextBox1.Location = new System.Drawing.Point(3, 20);
		this.FastColoredTextBox1.Name = "FastColoredTextBox1";
		this.FastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
		this.FastColoredTextBox1.RightBracket = ')';
		this.FastColoredTextBox1.RightBracket2 = '}';
		this.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(50, 0, 0, 255);
		this.FastColoredTextBox1.ServiceColors = null;
		this.FastColoredTextBox1.Size = new System.Drawing.Size(602, 498);
		this.FastColoredTextBox1.TabIndex = 0;
		this.FastColoredTextBox1.Text = "FastColoredTextBox1";
		this.FastColoredTextBox1.Zoom = 100;
		this.Panel23.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.Panel23.Controls.Add(this.Label26);
		this.Panel23.Controls.Add(this.Label25);
		this.Panel23.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel23.Location = new System.Drawing.Point(3, 0);
		this.Panel23.Name = "Panel23";
		this.Panel23.Size = new System.Drawing.Size(602, 20);
		this.Panel23.TabIndex = 48;
		this.Label26.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label26.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label26.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label26.Location = new System.Drawing.Point(0, 0);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(491, 20);
		this.Label26.TabIndex = 48;
		this.Label26.Text = "File Detail";
		this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label25.BackColor = System.Drawing.Color.DarkGreen;
		this.Label25.Dock = System.Windows.Forms.DockStyle.Right;
		this.Label25.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label25.ForeColor = System.Drawing.Color.White;
		this.Label25.Location = new System.Drawing.Point(491, 0);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(111, 20);
		this.Label25.TabIndex = 49;
		this.Label25.Text = "저장 완료";
		this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label25.Visible = false;
		this.Splitter1.BackColor = System.Drawing.Color.FromArgb(120, 120, 120);
		this.Splitter1.Location = new System.Drawing.Point(203, 56);
		this.Splitter1.Name = "Splitter1";
		this.Splitter1.Size = new System.Drawing.Size(6, 518);
		this.Splitter1.TabIndex = 46;
		this.Splitter1.TabStop = false;
		this.Panel14.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.Panel14.Controls.Add(this.ListBox2);
		this.Panel14.Controls.Add(this.Button21);
		this.Panel14.Controls.Add(this.Label17);
		this.Panel14.Controls.Add(this.ComboBox3);
		this.Panel14.Controls.Add(this.Label27);
		this.Panel14.Controls.Add(this.ComboBox2);
		this.Panel14.Controls.Add(this.Label23);
		this.Panel14.Controls.Add(this.ComboBox1);
		this.Panel14.Controls.Add(this.Label24);
		this.Panel14.Controls.Add(this.Button27);
		this.Panel14.Controls.Add(this.Button22);
		this.Panel14.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel14.Location = new System.Drawing.Point(23, 56);
		this.Panel14.Name = "Panel14";
		this.Panel14.Padding = new System.Windows.Forms.Padding(3);
		this.Panel14.Size = new System.Drawing.Size(180, 518);
		this.Panel14.TabIndex = 45;
		this.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ListBox2.FormattingEnabled = true;
		this.ListBox2.ItemHeight = 12;
		this.ListBox2.Items.AddRange(new object[2] { "admin.php", "dbconfig.php" });
		this.ListBox2.Location = new System.Drawing.Point(3, 137);
		this.ListBox2.Name = "ListBox2";
		this.ListBox2.ScrollAlwaysVisible = true;
		this.ListBox2.Size = new System.Drawing.Size(174, 318);
		this.ListBox2.Sorted = true;
		this.ListBox2.TabIndex = 2;
		this.Button21.BackColor = System.Drawing.Color.ForestGreen;
		this.Button21.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button21.BackgroundImage");
		this.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button21.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button21.ForeColor = System.Drawing.Color.White;
		this.Button21.Location = new System.Drawing.Point(3, 455);
		this.Button21.Name = "Button21";
		this.Button21.Size = new System.Drawing.Size(174, 20);
		this.Button21.TabIndex = 13;
		this.Button21.Text = "새 파일";
		this.Button21.UseVisualStyleBackColor = false;
		this.Label17.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label17.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label17.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label17.Location = new System.Drawing.Point(3, 120);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(174, 17);
		this.Label17.TabIndex = 7;
		this.Label17.Text = "Files";
		this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.ComboBox3.Dock = System.Windows.Forms.DockStyle.Top;
		this.ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox3.FormattingEnabled = true;
		this.ComboBox3.Items.AddRange(new object[2] { "CodingBox", "TextBox" });
		this.ComboBox3.Location = new System.Drawing.Point(3, 98);
		this.ComboBox3.Name = "ComboBox3";
		this.ComboBox3.Size = new System.Drawing.Size(174, 22);
		this.ComboBox3.TabIndex = 10;
		this.Label27.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label27.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label27.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label27.Location = new System.Drawing.Point(3, 81);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(174, 17);
		this.Label27.TabIndex = 11;
		this.Label27.Text = "Text Editor";
		this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.ComboBox2.Dock = System.Windows.Forms.DockStyle.Top;
		this.ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Items.AddRange(new object[3] { "UTF8", "EUCKR", "UNICODE" });
		this.ComboBox2.Location = new System.Drawing.Point(3, 59);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(174, 22);
		this.ComboBox2.TabIndex = 6;
		this.Label23.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label23.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label23.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label23.Location = new System.Drawing.Point(3, 42);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(174, 17);
		this.Label23.TabIndex = 8;
		this.Label23.Text = "Encode";
		this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.ComboBox1.Dock = System.Windows.Forms.DockStyle.Top;
		this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(3, 20);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(174, 22);
		this.ComboBox1.TabIndex = 5;
		this.Label24.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label24.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label24.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label24.Location = new System.Drawing.Point(3, 3);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(174, 17);
		this.Label24.TabIndex = 9;
		this.Label24.Text = "Project";
		this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button27.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button27.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button27.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button27.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button27.Location = new System.Drawing.Point(3, 475);
		this.Button27.Name = "Button27";
		this.Button27.Size = new System.Drawing.Size(174, 20);
		this.Button27.TabIndex = 14;
		this.Button27.Text = "이름 변경";
		this.Button27.UseVisualStyleBackColor = false;
		this.Button22.BackColor = System.Drawing.Color.Maroon;
		this.Button22.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button22.BackgroundImage");
		this.Button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button22.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button22.ForeColor = System.Drawing.Color.White;
		this.Button22.Location = new System.Drawing.Point(3, 495);
		this.Button22.Name = "Button22";
		this.Button22.Size = new System.Drawing.Size(174, 20);
		this.Button22.TabIndex = 12;
		this.Button22.Text = "선택 삭제";
		this.Button22.UseVisualStyleBackColor = false;
		this.Panel25.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel25.Location = new System.Drawing.Point(23, 574);
		this.Panel25.Name = "Panel25";
		this.Panel25.Size = new System.Drawing.Size(791, 18);
		this.Panel25.TabIndex = 44;
		this.Panel26.Controls.Add(this.Panel27);
		this.Panel26.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel26.Location = new System.Drawing.Point(23, 0);
		this.Panel26.Name = "Panel26";
		this.Panel26.Size = new System.Drawing.Size(791, 56);
		this.Panel26.TabIndex = 21;
		this.Panel27.Controls.Add(this.Label31);
		this.Panel27.Controls.Add(this.Panel28);
		this.Panel27.Controls.Add(this.Label32);
		this.Panel27.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel27.Location = new System.Drawing.Point(0, 0);
		this.Panel27.Name = "Panel27";
		this.Panel27.Size = new System.Drawing.Size(791, 56);
		this.Panel27.TabIndex = 4;
		this.Label31.AutoSize = true;
		this.Label31.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label31.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label31.Location = new System.Drawing.Point(0, 15);
		this.Label31.Name = "Label31";
		this.Label31.Size = new System.Drawing.Size(126, 30);
		this.Label31.TabIndex = 1;
		this.Label31.Text = "FTP 편집기";
		this.Panel28.BackColor = System.Drawing.Color.Gray;
		this.Panel28.Location = new System.Drawing.Point(127, 41);
		this.Panel28.Name = "Panel28";
		this.Panel28.Size = new System.Drawing.Size(2000, 1);
		this.Panel28.TabIndex = 3;
		this.Label32.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label32.ForeColor = System.Drawing.Color.Black;
		this.Label32.Location = new System.Drawing.Point(125, 15);
		this.Label32.Name = "Label32";
		this.Label32.Size = new System.Drawing.Size(768, 30);
		this.Label32.TabIndex = 2;
		this.Label32.Text = "접속할 프로젝트 서버를 선택하세요.";
		this.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel29.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel29.Location = new System.Drawing.Point(814, 0);
		this.Panel29.Name = "Panel29";
		this.Panel29.Size = new System.Drawing.Size(23, 592);
		this.Panel29.TabIndex = 20;
		this.Panel30.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel30.Location = new System.Drawing.Point(0, 0);
		this.Panel30.Name = "Panel30";
		this.Panel30.Size = new System.Drawing.Size(23, 592);
		this.Panel30.TabIndex = 19;
		this.Panel31.Controls.Add(this.Button16);
		this.Panel31.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel31.Location = new System.Drawing.Point(0, 592);
		this.Panel31.Name = "Panel31";
		this.Panel31.Padding = new System.Windows.Forms.Padding(5);
		this.Panel31.Size = new System.Drawing.Size(837, 44);
		this.Panel31.TabIndex = 43;
		this.Button16.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button16.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button16.BackgroundImage");
		this.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button16.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button16.ForeColor = System.Drawing.Color.White;
		this.Button16.Location = new System.Drawing.Point(5, 5);
		this.Button16.Name = "Button16";
		this.Button16.Size = new System.Drawing.Size(80, 34);
		this.Button16.TabIndex = 7;
		this.Button16.Text = "저장";
		this.Button16.UseVisualStyleBackColor = false;
		this.TabPage7.Controls.Add(this.p_diag2);
		this.TabPage7.Controls.Add(this.p_diag1);
		this.TabPage7.Location = new System.Drawing.Point(4, 22);
		this.TabPage7.Name = "TabPage7";
		this.TabPage7.Size = new System.Drawing.Size(837, 636);
		this.TabPage7.TabIndex = 6;
		this.TabPage7.Text = "Dialogs";
		this.TabPage7.UseVisualStyleBackColor = true;
		this.p_diag2.BackColor = System.Drawing.Color.White;
		this.p_diag2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag2.Controls.Add(this.p_diag2_t5);
		this.p_diag2.Controls.Add(this.Button32);
		this.p_diag2.Controls.Add(this.p_diag2_num);
		this.p_diag2.Controls.Add(this.p_diag2_rb2);
		this.p_diag2.Controls.Add(this.p_diag2_rb1);
		this.p_diag2.Controls.Add(this.p_diag2_chk1);
		this.p_diag2.Controls.Add(this.p_diag2_c1);
		this.p_diag2.Controls.Add(this.p_diag2_c2);
		this.p_diag2.Controls.Add(this.Label54);
		this.p_diag2.Controls.Add(this.Label52);
		this.p_diag2.Controls.Add(this.Label44);
		this.p_diag2.Controls.Add(this.p_diag2_t4);
		this.p_diag2.Controls.Add(this.Label45);
		this.p_diag2.Controls.Add(this.Label46);
		this.p_diag2.Controls.Add(this.p_diag2_t2);
		this.p_diag2.Controls.Add(this.Label48);
		this.p_diag2.Controls.Add(this.p_diag2_t1);
		this.p_diag2.Controls.Add(this.Label49);
		this.p_diag2.Controls.Add(this.Panel38);
		this.p_diag2.Controls.Add(this.Label50);
		this.p_diag2.Controls.Add(this.p_diag2_t3);
		this.p_diag2.Controls.Add(this.Label47);
		this.p_diag2.Controls.Add(this.Label51);
		this.p_diag2.Controls.Add(this.p_diag2_t6);
		this.p_diag2.Controls.Add(this.Label53);
		this.p_diag2.Location = new System.Drawing.Point(8, 302);
		this.p_diag2.Name = "p_diag2";
		this.p_diag2.Size = new System.Drawing.Size(549, 332);
		this.p_diag2.TabIndex = 2;
		this.p_diag2_t5.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag2_t5.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag2_t5.Location = new System.Drawing.Point(121, 221);
		this.p_diag2_t5.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		this.p_diag2_t5.Name = "p_diag2_t5";
		this.p_diag2_t5.Size = new System.Drawing.Size(153, 25);
		this.p_diag2_t5.TabIndex = 72;
		this.Button32.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button32.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button32.BackgroundImage");
		this.Button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button32.ForeColor = System.Drawing.Color.White;
		this.Button32.Location = new System.Drawing.Point(453, 252);
		this.Button32.Name = "Button32";
		this.Button32.Size = new System.Drawing.Size(43, 26);
		this.Button32.TabIndex = 71;
		this.Button32.Text = "비움";
		this.Button32.UseVisualStyleBackColor = false;
		this.p_diag2_num.AutoSize = true;
		this.p_diag2_num.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.p_diag2_num.Location = new System.Drawing.Point(3, 11);
		this.p_diag2_num.Name = "p_diag2_num";
		this.p_diag2_num.Size = new System.Drawing.Size(33, 12);
		this.p_diag2_num.TabIndex = 70;
		this.p_diag2_num.Text = "NUM";
		this.p_diag2_rb2.AutoSize = true;
		this.p_diag2_rb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p_diag2_rb2.Font = new System.Drawing.Font("맑은 고딕", 9.75f);
		this.p_diag2_rb2.Location = new System.Drawing.Point(186, 193);
		this.p_diag2_rb2.Name = "p_diag2_rb2";
		this.p_diag2_rb2.Size = new System.Drawing.Size(65, 21);
		this.p_diag2_rb2.TabIndex = 6;
		this.p_diag2_rb2.Text = "EUCKR";
		this.p_diag2_rb2.UseVisualStyleBackColor = true;
		this.p_diag2_rb1.AutoSize = true;
		this.p_diag2_rb1.Checked = true;
		this.p_diag2_rb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p_diag2_rb1.Font = new System.Drawing.Font("맑은 고딕", 9.75f);
		this.p_diag2_rb1.Location = new System.Drawing.Point(121, 193);
		this.p_diag2_rb1.Name = "p_diag2_rb1";
		this.p_diag2_rb1.Size = new System.Drawing.Size(54, 21);
		this.p_diag2_rb1.TabIndex = 5;
		this.p_diag2_rb1.TabStop = true;
		this.p_diag2_rb1.Text = "UTF8";
		this.p_diag2_rb1.UseVisualStyleBackColor = true;
		this.p_diag2_chk1.AutoSize = true;
		this.p_diag2_chk1.Checked = true;
		this.p_diag2_chk1.CheckState = System.Windows.Forms.CheckState.Checked;
		this.p_diag2_chk1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p_diag2_chk1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.p_diag2_chk1.Location = new System.Drawing.Point(343, 193);
		this.p_diag2_chk1.Name = "p_diag2_chk1";
		this.p_diag2_chk1.Size = new System.Drawing.Size(81, 21);
		this.p_diag2_chk1.TabIndex = 7;
		this.p_diag2_chk1.Text = "접속 허용";
		this.p_diag2_chk1.UseVisualStyleBackColor = true;
		this.p_diag2_c1.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.p_diag2_c1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.p_diag2_c1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.p_diag2_c1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.p_diag2_c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p_diag2_c1.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag2_c1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag2_c1.FormattingEnabled = true;
		this.p_diag2_c1.Location = new System.Drawing.Point(121, 128);
		this.p_diag2_c1.Name = "p_diag2_c1";
		this.p_diag2_c1.Size = new System.Drawing.Size(375, 26);
		this.p_diag2_c1.TabIndex = 3;
		this.p_diag2_c2.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.p_diag2_c2.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.p_diag2_c2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.p_diag2_c2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.p_diag2_c2.DropDownWidth = 600;
		this.p_diag2_c2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.p_diag2_c2.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag2_c2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag2_c2.FormattingEnabled = true;
		this.p_diag2_c2.Location = new System.Drawing.Point(121, 252);
		this.p_diag2_c2.MaxDropDownItems = 20;
		this.p_diag2_c2.Name = "p_diag2_c2";
		this.p_diag2_c2.Size = new System.Drawing.Size(326, 26);
		this.p_diag2_c2.TabIndex = 20;
		this.Label54.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label54.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label54.Location = new System.Drawing.Point(32, 252);
		this.Label54.Name = "Label54";
		this.Label54.Size = new System.Drawing.Size(83, 25);
		this.Label54.TabIndex = 69;
		this.Label54.Text = "공지";
		this.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label52.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label52.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label52.Location = new System.Drawing.Point(32, 221);
		this.Label52.Name = "Label52";
		this.Label52.Size = new System.Drawing.Size(83, 25);
		this.Label52.TabIndex = 65;
		this.Label52.Text = "버전";
		this.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label44.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label44.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label44.Location = new System.Drawing.Point(32, 190);
		this.Label44.Name = "Label44";
		this.Label44.Size = new System.Drawing.Size(83, 25);
		this.Label44.TabIndex = 61;
		this.Label44.Text = "인코딩";
		this.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_diag2_t4.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag2_t4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag2_t4.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag2_t4.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag2_t4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag2_t4.Location = new System.Drawing.Point(121, 159);
		this.p_diag2_t4.Name = "p_diag2_t4";
		this.p_diag2_t4.Size = new System.Drawing.Size(375, 25);
		this.p_diag2_t4.TabIndex = 4;
		this.Label45.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label45.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label45.Location = new System.Drawing.Point(32, 159);
		this.Label45.Name = "Label45";
		this.Label45.Size = new System.Drawing.Size(83, 25);
		this.Label45.TabIndex = 59;
		this.Label45.Text = "위치(DB)";
		this.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label46.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label46.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label46.Location = new System.Drawing.Point(32, 128);
		this.Label46.Name = "Label46";
		this.Label46.Size = new System.Drawing.Size(83, 25);
		this.Label46.TabIndex = 57;
		this.Label46.Text = "고객명";
		this.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_diag2_t2.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag2_t2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag2_t2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag2_t2.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag2_t2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag2_t2.Location = new System.Drawing.Point(121, 97);
		this.p_diag2_t2.Name = "p_diag2_t2";
		this.p_diag2_t2.Size = new System.Drawing.Size(153, 25);
		this.p_diag2_t2.TabIndex = 1;
		this.Label48.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label48.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label48.Location = new System.Drawing.Point(32, 97);
		this.Label48.Name = "Label48";
		this.Label48.Size = new System.Drawing.Size(83, 25);
		this.Label48.TabIndex = 53;
		this.Label48.Text = "계정";
		this.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_diag2_t1.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag2_t1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag2_t1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag2_t1.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag2_t1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag2_t1.Location = new System.Drawing.Point(121, 66);
		this.p_diag2_t1.Name = "p_diag2_t1";
		this.p_diag2_t1.Size = new System.Drawing.Size(375, 25);
		this.p_diag2_t1.TabIndex = 0;
		this.Label49.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label49.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label49.Location = new System.Drawing.Point(32, 66);
		this.Label49.Name = "Label49";
		this.Label49.Size = new System.Drawing.Size(83, 25);
		this.Label49.TabIndex = 51;
		this.Label49.Text = "프로젝트명";
		this.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel38.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Panel38.Controls.Add(this.Button31);
		this.Panel38.Controls.Add(this.Button15);
		this.Panel38.Controls.Add(this.Button28);
		this.Panel38.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel38.Location = new System.Drawing.Point(0, 294);
		this.Panel38.Name = "Panel38";
		this.Panel38.Padding = new System.Windows.Forms.Padding(5);
		this.Panel38.Size = new System.Drawing.Size(547, 36);
		this.Panel38.TabIndex = 50;
		this.Button31.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button31.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button31.BackgroundImage");
		this.Button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button31.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button31.ForeColor = System.Drawing.Color.White;
		this.Button31.Location = new System.Drawing.Point(302, 5);
		this.Button31.Name = "Button31";
		this.Button31.Size = new System.Drawing.Size(80, 26);
		this.Button31.TabIndex = 41;
		this.Button31.Text = "초기화";
		this.Button31.UseVisualStyleBackColor = false;
		this.Button15.BackColor = System.Drawing.Color.ForestGreen;
		this.Button15.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button15.BackgroundImage");
		this.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button15.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button15.ForeColor = System.Drawing.Color.White;
		this.Button15.Location = new System.Drawing.Point(382, 5);
		this.Button15.Name = "Button15";
		this.Button15.Size = new System.Drawing.Size(80, 26);
		this.Button15.TabIndex = 30;
		this.Button15.Text = "확인";
		this.Button15.UseVisualStyleBackColor = false;
		this.Button28.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button28.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button28.BackgroundImage");
		this.Button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button28.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button28.ForeColor = System.Drawing.Color.White;
		this.Button28.Location = new System.Drawing.Point(462, 5);
		this.Button28.Name = "Button28";
		this.Button28.Size = new System.Drawing.Size(80, 26);
		this.Button28.TabIndex = 40;
		this.Button28.Text = "닫기";
		this.Button28.UseVisualStyleBackColor = false;
		this.Label50.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Label50.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label50.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label50.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label50.Location = new System.Drawing.Point(0, 0);
		this.Label50.Name = "Label50";
		this.Label50.Size = new System.Drawing.Size(547, 54);
		this.Label50.TabIndex = 2;
		this.Label50.Text = "새 프로젝트";
		this.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.p_diag2_t3.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag2_t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag2_t3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag2_t3.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag2_t3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag2_t3.Location = new System.Drawing.Point(343, 97);
		this.p_diag2_t3.Name = "p_diag2_t3";
		this.p_diag2_t3.Size = new System.Drawing.Size(153, 25);
		this.p_diag2_t3.TabIndex = 2;
		this.Label47.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label47.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label47.Location = new System.Drawing.Point(254, 97);
		this.Label47.Name = "Label47";
		this.Label47.Size = new System.Drawing.Size(83, 25);
		this.Label47.TabIndex = 55;
		this.Label47.Text = "암호";
		this.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label51.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label51.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label51.Location = new System.Drawing.Point(254, 190);
		this.Label51.Name = "Label51";
		this.Label51.Size = new System.Drawing.Size(83, 25);
		this.Label51.TabIndex = 63;
		this.Label51.Text = "권한";
		this.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_diag2_t6.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag2_t6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag2_t6.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag2_t6.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag2_t6.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag2_t6.Location = new System.Drawing.Point(343, 221);
		this.p_diag2_t6.Name = "p_diag2_t6";
		this.p_diag2_t6.Size = new System.Drawing.Size(153, 25);
		this.p_diag2_t6.TabIndex = 9;
		this.Label53.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label53.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label53.Location = new System.Drawing.Point(254, 221);
		this.Label53.Name = "Label53";
		this.Label53.Size = new System.Drawing.Size(83, 25);
		this.Label53.TabIndex = 67;
		this.Label53.Text = "접속일";
		this.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_diag1.BackColor = System.Drawing.Color.White;
		this.p_diag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag1.Controls.Add(this.p_diag1_num);
		this.p_diag1.Controls.Add(this.p_diag1_t6);
		this.p_diag1.Controls.Add(this.Label43);
		this.p_diag1.Controls.Add(this.p_diag1_t5);
		this.p_diag1.Controls.Add(this.Label42);
		this.p_diag1.Controls.Add(this.p_diag1_t4);
		this.p_diag1.Controls.Add(this.Label41);
		this.p_diag1.Controls.Add(this.p_diag1_t3);
		this.p_diag1.Controls.Add(this.Label39);
		this.p_diag1.Controls.Add(this.p_diag1_t2);
		this.p_diag1.Controls.Add(this.Label38);
		this.p_diag1.Controls.Add(this.p_diag1_t1);
		this.p_diag1.Controls.Add(this.Label36);
		this.p_diag1.Controls.Add(this.Panel36);
		this.p_diag1.Controls.Add(this.Label40);
		this.p_diag1.Location = new System.Drawing.Point(8, 2);
		this.p_diag1.Name = "p_diag1";
		this.p_diag1.Size = new System.Drawing.Size(549, 299);
		this.p_diag1.TabIndex = 1;
		this.p_diag1_num.AutoSize = true;
		this.p_diag1_num.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.p_diag1_num.Location = new System.Drawing.Point(3, 9);
		this.p_diag1_num.Name = "p_diag1_num";
		this.p_diag1_num.Size = new System.Drawing.Size(33, 12);
		this.p_diag1_num.TabIndex = 71;
		this.p_diag1_num.Text = "NUM";
		this.p_diag1_t6.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag1_t6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag1_t6.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag1_t6.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag1_t6.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag1_t6.Location = new System.Drawing.Point(121, 221);
		this.p_diag1_t6.Name = "p_diag1_t6";
		this.p_diag1_t6.Size = new System.Drawing.Size(375, 25);
		this.p_diag1_t6.TabIndex = 60;
		this.Label43.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label43.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label43.Location = new System.Drawing.Point(32, 221);
		this.Label43.Name = "Label43";
		this.Label43.Size = new System.Drawing.Size(83, 25);
		this.Label43.TabIndex = 61;
		this.Label43.Text = "주소";
		this.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_diag1_t5.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag1_t5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag1_t5.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag1_t5.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag1_t5.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag1_t5.Location = new System.Drawing.Point(121, 190);
		this.p_diag1_t5.Name = "p_diag1_t5";
		this.p_diag1_t5.Size = new System.Drawing.Size(375, 25);
		this.p_diag1_t5.TabIndex = 58;
		this.Label42.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label42.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label42.Location = new System.Drawing.Point(32, 190);
		this.Label42.Name = "Label42";
		this.Label42.Size = new System.Drawing.Size(83, 25);
		this.Label42.TabIndex = 59;
		this.Label42.Text = "이메일";
		this.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_diag1_t4.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag1_t4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag1_t4.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag1_t4.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag1_t4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag1_t4.Location = new System.Drawing.Point(121, 159);
		this.p_diag1_t4.Name = "p_diag1_t4";
		this.p_diag1_t4.Size = new System.Drawing.Size(375, 25);
		this.p_diag1_t4.TabIndex = 56;
		this.Label41.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label41.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label41.Location = new System.Drawing.Point(32, 159);
		this.Label41.Name = "Label41";
		this.Label41.Size = new System.Drawing.Size(83, 25);
		this.Label41.TabIndex = 57;
		this.Label41.Text = "사업자번호";
		this.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_diag1_t3.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag1_t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag1_t3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag1_t3.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag1_t3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag1_t3.Location = new System.Drawing.Point(121, 128);
		this.p_diag1_t3.Name = "p_diag1_t3";
		this.p_diag1_t3.Size = new System.Drawing.Size(375, 25);
		this.p_diag1_t3.TabIndex = 54;
		this.Label39.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label39.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label39.Location = new System.Drawing.Point(32, 128);
		this.Label39.Name = "Label39";
		this.Label39.Size = new System.Drawing.Size(83, 25);
		this.Label39.TabIndex = 55;
		this.Label39.Text = "팩스";
		this.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_diag1_t2.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag1_t2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag1_t2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag1_t2.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag1_t2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag1_t2.Location = new System.Drawing.Point(121, 97);
		this.p_diag1_t2.Name = "p_diag1_t2";
		this.p_diag1_t2.Size = new System.Drawing.Size(375, 25);
		this.p_diag1_t2.TabIndex = 52;
		this.Label38.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label38.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label38.Location = new System.Drawing.Point(32, 97);
		this.Label38.Name = "Label38";
		this.Label38.Size = new System.Drawing.Size(83, 25);
		this.Label38.TabIndex = 53;
		this.Label38.Text = "전화번호";
		this.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_diag1_t1.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.p_diag1_t1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_diag1_t1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.p_diag1_t1.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.p_diag1_t1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.p_diag1_t1.Location = new System.Drawing.Point(121, 66);
		this.p_diag1_t1.Name = "p_diag1_t1";
		this.p_diag1_t1.Size = new System.Drawing.Size(375, 25);
		this.p_diag1_t1.TabIndex = 0;
		this.Label36.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label36.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label36.Location = new System.Drawing.Point(32, 66);
		this.Label36.Name = "Label36";
		this.Label36.Size = new System.Drawing.Size(83, 25);
		this.Label36.TabIndex = 51;
		this.Label36.Text = "이름";
		this.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel36.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Panel36.Controls.Add(this.Button33);
		this.Panel36.Controls.Add(this.Button29);
		this.Panel36.Controls.Add(this.Button30);
		this.Panel36.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel36.Location = new System.Drawing.Point(0, 261);
		this.Panel36.Name = "Panel36";
		this.Panel36.Padding = new System.Windows.Forms.Padding(5);
		this.Panel36.Size = new System.Drawing.Size(547, 36);
		this.Panel36.TabIndex = 50;
		this.Button33.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button33.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button33.BackgroundImage");
		this.Button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button33.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button33.ForeColor = System.Drawing.Color.White;
		this.Button33.Location = new System.Drawing.Point(302, 5);
		this.Button33.Name = "Button33";
		this.Button33.Size = new System.Drawing.Size(80, 26);
		this.Button33.TabIndex = 63;
		this.Button33.Text = "초기화";
		this.Button33.UseVisualStyleBackColor = false;
		this.Button29.BackColor = System.Drawing.Color.ForestGreen;
		this.Button29.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button29.BackgroundImage");
		this.Button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button29.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button29.ForeColor = System.Drawing.Color.White;
		this.Button29.Location = new System.Drawing.Point(382, 5);
		this.Button29.Name = "Button29";
		this.Button29.Size = new System.Drawing.Size(80, 26);
		this.Button29.TabIndex = 61;
		this.Button29.Text = "확인";
		this.Button29.UseVisualStyleBackColor = false;
		this.Button30.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button30.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button30.BackgroundImage");
		this.Button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button30.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button30.ForeColor = System.Drawing.Color.White;
		this.Button30.Location = new System.Drawing.Point(462, 5);
		this.Button30.Name = "Button30";
		this.Button30.Size = new System.Drawing.Size(80, 26);
		this.Button30.TabIndex = 62;
		this.Button30.Text = "닫기";
		this.Button30.UseVisualStyleBackColor = false;
		this.Label40.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Label40.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label40.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label40.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label40.Location = new System.Drawing.Point(0, 0);
		this.Label40.Name = "Label40";
		this.Label40.Size = new System.Drawing.Size(547, 54);
		this.Label40.TabIndex = 2;
		this.Label40.Text = "새 고객";
		this.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.TabPage6.Controls.Add(this.p_ftp_mname);
		this.TabPage6.Controls.Add(this.p_ftp_file);
		this.TabPage6.Controls.Add(this.p_ftp_login);
		this.TabPage6.Location = new System.Drawing.Point(4, 22);
		this.TabPage6.Name = "TabPage6";
		this.TabPage6.Size = new System.Drawing.Size(837, 636);
		this.TabPage6.TabIndex = 5;
		this.TabPage6.Text = "FTPdialogs";
		this.TabPage6.UseVisualStyleBackColor = true;
		this.p_ftp_mname.BackColor = System.Drawing.Color.White;
		this.p_ftp_mname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_ftp_mname.Controls.Add(this.Label37);
		this.p_ftp_mname.Controls.Add(this.TextBox6);
		this.p_ftp_mname.Controls.Add(this.Label35);
		this.p_ftp_mname.Controls.Add(this.TextBox5);
		this.p_ftp_mname.Controls.Add(this.Label30);
		this.p_ftp_mname.Controls.Add(this.Panel34);
		this.p_ftp_mname.Controls.Add(this.Label34);
		this.p_ftp_mname.Location = new System.Drawing.Point(4, 434);
		this.p_ftp_mname.Name = "p_ftp_mname";
		this.p_ftp_mname.Size = new System.Drawing.Size(390, 192);
		this.p_ftp_mname.TabIndex = 2;
		this.Label37.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label37.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label37.Location = new System.Drawing.Point(202, 118);
		this.Label37.Name = "Label37";
		this.Label37.Size = new System.Drawing.Size(160, 25);
		this.Label37.TabIndex = 55;
		this.Label37.Text = "default = .php";
		this.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox6.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox6.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox6.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox6.Location = new System.Drawing.Point(126, 90);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(236, 25);
		this.TextBox6.TabIndex = 52;
		this.Label35.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label35.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label35.Location = new System.Drawing.Point(27, 90);
		this.Label35.Name = "Label35";
		this.Label35.Size = new System.Drawing.Size(93, 25);
		this.Label35.TabIndex = 53;
		this.Label35.Text = "새 이름";
		this.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox5.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox5.Enabled = false;
		this.TextBox5.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox5.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox5.Location = new System.Drawing.Point(126, 59);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(236, 25);
		this.TextBox5.TabIndex = 0;
		this.Label30.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label30.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label30.Location = new System.Drawing.Point(31, 57);
		this.Label30.Name = "Label30";
		this.Label30.Size = new System.Drawing.Size(89, 25);
		this.Label30.TabIndex = 51;
		this.Label30.Text = "현재 이름";
		this.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel34.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Panel34.Controls.Add(this.Button25);
		this.Panel34.Controls.Add(this.Button26);
		this.Panel34.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel34.Location = new System.Drawing.Point(0, 154);
		this.Panel34.Name = "Panel34";
		this.Panel34.Padding = new System.Windows.Forms.Padding(5);
		this.Panel34.Size = new System.Drawing.Size(388, 36);
		this.Panel34.TabIndex = 50;
		this.Button25.BackColor = System.Drawing.Color.ForestGreen;
		this.Button25.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button25.BackgroundImage");
		this.Button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button25.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button25.ForeColor = System.Drawing.Color.White;
		this.Button25.Location = new System.Drawing.Point(223, 5);
		this.Button25.Name = "Button25";
		this.Button25.Size = new System.Drawing.Size(80, 26);
		this.Button25.TabIndex = 3;
		this.Button25.Text = "확인";
		this.Button25.UseVisualStyleBackColor = false;
		this.Button26.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button26.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button26.BackgroundImage");
		this.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button26.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button26.ForeColor = System.Drawing.Color.White;
		this.Button26.Location = new System.Drawing.Point(303, 5);
		this.Button26.Name = "Button26";
		this.Button26.Size = new System.Drawing.Size(80, 26);
		this.Button26.TabIndex = 4;
		this.Button26.Text = "닫기";
		this.Button26.UseVisualStyleBackColor = false;
		this.Label34.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Label34.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label34.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label34.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label34.Location = new System.Drawing.Point(0, 0);
		this.Label34.Name = "Label34";
		this.Label34.Size = new System.Drawing.Size(388, 44);
		this.Label34.TabIndex = 2;
		this.Label34.Text = "이름 변경";
		this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.p_ftp_file.BackColor = System.Drawing.Color.White;
		this.p_ftp_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_ftp_file.Controls.Add(this.TextBox4);
		this.p_ftp_file.Controls.Add(this.Label28);
		this.p_ftp_file.Controls.Add(this.Panel33);
		this.p_ftp_file.Controls.Add(this.Label33);
		this.p_ftp_file.Controls.Add(this.Label29);
		this.p_ftp_file.Location = new System.Drawing.Point(3, 269);
		this.p_ftp_file.Name = "p_ftp_file";
		this.p_ftp_file.Size = new System.Drawing.Size(390, 159);
		this.p_ftp_file.TabIndex = 1;
		this.TextBox4.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox4.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox4.Location = new System.Drawing.Point(102, 59);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(261, 25);
		this.TextBox4.TabIndex = 0;
		this.Label28.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label28.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label28.Location = new System.Drawing.Point(39, 59);
		this.Label28.Name = "Label28";
		this.Label28.Size = new System.Drawing.Size(57, 25);
		this.Label28.TabIndex = 51;
		this.Label28.Text = "이름";
		this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel33.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Panel33.Controls.Add(this.Button23);
		this.Panel33.Controls.Add(this.Button24);
		this.Panel33.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel33.Location = new System.Drawing.Point(0, 121);
		this.Panel33.Name = "Panel33";
		this.Panel33.Padding = new System.Windows.Forms.Padding(5);
		this.Panel33.Size = new System.Drawing.Size(388, 36);
		this.Panel33.TabIndex = 50;
		this.Button23.BackColor = System.Drawing.Color.ForestGreen;
		this.Button23.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button23.BackgroundImage");
		this.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button23.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button23.ForeColor = System.Drawing.Color.White;
		this.Button23.Location = new System.Drawing.Point(223, 5);
		this.Button23.Name = "Button23";
		this.Button23.Size = new System.Drawing.Size(80, 26);
		this.Button23.TabIndex = 3;
		this.Button23.Text = "만들기";
		this.Button23.UseVisualStyleBackColor = false;
		this.Button24.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button24.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button24.BackgroundImage");
		this.Button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button24.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button24.ForeColor = System.Drawing.Color.White;
		this.Button24.Location = new System.Drawing.Point(303, 5);
		this.Button24.Name = "Button24";
		this.Button24.Size = new System.Drawing.Size(80, 26);
		this.Button24.TabIndex = 4;
		this.Button24.Text = "닫기";
		this.Button24.UseVisualStyleBackColor = false;
		this.Label33.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Label33.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label33.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label33.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label33.Location = new System.Drawing.Point(0, 0);
		this.Label33.Name = "Label33";
		this.Label33.Size = new System.Drawing.Size(388, 44);
		this.Label33.TabIndex = 2;
		this.Label33.Text = "새 파일";
		this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label29.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label29.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label29.Location = new System.Drawing.Point(203, 86);
		this.Label29.Name = "Label29";
		this.Label29.Size = new System.Drawing.Size(160, 25);
		this.Label29.TabIndex = 52;
		this.Label29.Text = "default = .php";
		this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.p_ftp_login.BackColor = System.Drawing.Color.White;
		this.p_ftp_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.p_ftp_login.Controls.Add(this.CheckBox1);
		this.p_ftp_login.Controls.Add(this.Button20);
		this.p_ftp_login.Controls.Add(this.Button17);
		this.p_ftp_login.Controls.Add(this.TextBox3);
		this.p_ftp_login.Controls.Add(this.Label16);
		this.p_ftp_login.Controls.Add(this.Panel24);
		this.p_ftp_login.Controls.Add(this.TextBox2);
		this.p_ftp_login.Controls.Add(this.TextBox1);
		this.p_ftp_login.Controls.Add(this.Label14);
		this.p_ftp_login.Controls.Add(this.Label13);
		this.p_ftp_login.Controls.Add(this.Label11);
		this.p_ftp_login.Location = new System.Drawing.Point(3, 3);
		this.p_ftp_login.Name = "p_ftp_login";
		this.p_ftp_login.Size = new System.Drawing.Size(549, 260);
		this.p_ftp_login.TabIndex = 0;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Checked = true;
		this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
		this.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CheckBox1.Location = new System.Drawing.Point(405, 190);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(92, 16);
		this.CheckBox1.TabIndex = 53;
		this.CheckBox1.Text = "Use Passive";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.Button20.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button20.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button20.BackgroundImage");
		this.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button20.ForeColor = System.Drawing.Color.Black;
		this.Button20.Location = new System.Drawing.Point(248, 97);
		this.Button20.Name = "Button20";
		this.Button20.Size = new System.Drawing.Size(123, 25);
		this.Button20.TabIndex = 52;
		this.Button20.Text = "Add 'www'";
		this.Button20.UseVisualStyleBackColor = false;
		this.Button17.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button17.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button17.BackgroundImage");
		this.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button17.ForeColor = System.Drawing.Color.Black;
		this.Button17.Location = new System.Drawing.Point(377, 97);
		this.Button17.Name = "Button17";
		this.Button17.Size = new System.Drawing.Size(123, 25);
		this.Button17.TabIndex = 4;
		this.Button17.Text = "Add 'public_html'";
		this.Button17.UseVisualStyleBackColor = false;
		this.TextBox3.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox3.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox3.Location = new System.Drawing.Point(127, 66);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(373, 25);
		this.TextBox3.TabIndex = 0;
		this.Label16.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label16.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label16.Location = new System.Drawing.Point(28, 66);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(87, 25);
		this.Label16.TabIndex = 51;
		this.Label16.Text = "Host";
		this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel24.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Panel24.Controls.Add(this.Button11);
		this.Panel24.Controls.Add(this.Button19);
		this.Panel24.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel24.Location = new System.Drawing.Point(0, 222);
		this.Panel24.Name = "Panel24";
		this.Panel24.Padding = new System.Windows.Forms.Padding(5);
		this.Panel24.Size = new System.Drawing.Size(547, 36);
		this.Panel24.TabIndex = 50;
		this.Button11.BackColor = System.Drawing.Color.ForestGreen;
		this.Button11.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button11.BackgroundImage");
		this.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button11.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button11.ForeColor = System.Drawing.Color.White;
		this.Button11.Location = new System.Drawing.Point(382, 5);
		this.Button11.Name = "Button11";
		this.Button11.Size = new System.Drawing.Size(80, 26);
		this.Button11.TabIndex = 3;
		this.Button11.Text = "접속";
		this.Button11.UseVisualStyleBackColor = false;
		this.Button19.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button19.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button19.BackgroundImage");
		this.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button19.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button19.ForeColor = System.Drawing.Color.White;
		this.Button19.Location = new System.Drawing.Point(462, 5);
		this.Button19.Name = "Button19";
		this.Button19.Size = new System.Drawing.Size(80, 26);
		this.Button19.TabIndex = 4;
		this.Button19.Text = "닫기";
		this.Button19.UseVisualStyleBackColor = false;
		this.TextBox2.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox2.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox2.Location = new System.Drawing.Point(127, 159);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(373, 25);
		this.TextBox2.TabIndex = 2;
		this.TextBox2.UseSystemPasswordChar = true;
		this.TextBox1.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox1.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox1.Location = new System.Drawing.Point(127, 128);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(373, 25);
		this.TextBox1.TabIndex = 1;
		this.Label14.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label14.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label14.Location = new System.Drawing.Point(24, 159);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(91, 25);
		this.Label14.TabIndex = 4;
		this.Label14.Text = "Password";
		this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label13.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label13.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label13.Location = new System.Drawing.Point(25, 128);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(90, 25);
		this.Label13.TabIndex = 3;
		this.Label13.Text = "Username";
		this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label11.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Label11.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label11.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label11.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label11.Location = new System.Drawing.Point(0, 0);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(547, 54);
		this.Label11.TabIndex = 2;
		this.Label11.Text = "로그인";
		this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Timer1.Interval = 1000;
		this.Button34.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
		this.Button34.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button34.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button34.ForeColor = System.Drawing.Color.White;
		this.Button34.Location = new System.Drawing.Point(333, 5);
		this.Button34.Name = "Button34";
		this.Button34.Size = new System.Drawing.Size(80, 34);
		this.Button34.TabIndex = 35;
		this.Button34.Text = "메신저";
		this.Button34.UseVisualStyleBackColor = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		base.ClientSize = new System.Drawing.Size(845, 662);
		base.Controls.Add(this.TabControl1);
		this.DoubleBuffered = true;
		base.Name = "home_db_microlivire";
		this.Text = "home_db_microlivire";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.p1.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		this.Panel8.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.p2.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.Panel12.ResumeLayout(false);
		this.TabPage8.ResumeLayout(false);
		this.p6.ResumeLayout(false);
		this.Panel37.ResumeLayout(false);
		this.Panel37.PerformLayout();
		this.Panel43.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.p3.ResumeLayout(false);
		this.p3.PerformLayout();
		this.Panel109.ResumeLayout(false);
		this.Panel109.PerformLayout();
		this.Panel112.ResumeLayout(false);
		this.Panel113.ResumeLayout(false);
		this.Panel113.PerformLayout();
		this.Panel103.ResumeLayout(false);
		this.TabPage4.ResumeLayout(false);
		this.p4.ResumeLayout(false);
		this.p4.PerformLayout();
		this.Panel16.ResumeLayout(false);
		this.Panel16.PerformLayout();
		this.Panel53.ResumeLayout(false);
		this.Panel17.ResumeLayout(false);
		this.Panel18.ResumeLayout(false);
		this.Panel18.PerformLayout();
		this.Panel22.ResumeLayout(false);
		this.TabPage5.ResumeLayout(false);
		this.p5.ResumeLayout(false);
		this.Panel32.ResumeLayout(false);
		this.Panel32.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.FastColoredTextBox1).EndInit();
		this.Panel23.ResumeLayout(false);
		this.Panel14.ResumeLayout(false);
		this.Panel26.ResumeLayout(false);
		this.Panel27.ResumeLayout(false);
		this.Panel27.PerformLayout();
		this.Panel31.ResumeLayout(false);
		this.TabPage7.ResumeLayout(false);
		this.p_diag2.ResumeLayout(false);
		this.p_diag2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.p_diag2_t5).EndInit();
		this.Panel38.ResumeLayout(false);
		this.p_diag1.ResumeLayout(false);
		this.p_diag1.PerformLayout();
		this.Panel36.ResumeLayout(false);
		this.TabPage6.ResumeLayout(false);
		this.p_ftp_mname.ResumeLayout(false);
		this.p_ftp_mname.PerformLayout();
		this.Panel34.ResumeLayout(false);
		this.p_ftp_file.ResumeLayout(false);
		this.p_ftp_file.PerformLayout();
		this.Panel33.ResumeLayout(false);
		this.p_ftp_login.ResumeLayout(false);
		this.p_ftp_login.PerformLayout();
		this.Panel24.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void home_db_microlivire_Load(object sender, EventArgs e)
	{
	}

	public void DrawItem(object sender, DrawItemEventArgs e)
	{
		try
		{
			e.DrawBackground();
			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				Brush brush = new SolidBrush(Color.ForestGreen);
				Rectangle bounds = e.Bounds;
				e.Graphics.FillRectangle(brush, bounds);
				Brush brush2 = new SolidBrush(Color.FromArgb(0, 0, 0));
				Graphics graphics = e.Graphics;
				object[] array = new object[1];
				object obj = sender;
				object instance = obj;
				object[] array2 = new object[1];
				object obj2 = (array2[0] = e.Index);
				array[0] = NewLateBinding.LateGet(instance, null, "Items", array2, null, null, null);
				object[] array3 = array;
				bool[] obj3 = new bool[1] { true };
				bool[] array4 = obj3;
				object obj4 = NewLateBinding.LateGet(sender, null, "GetItemText", array, null, null, obj3);
				if (array4[0])
				{
					NewLateBinding.LateSetComplex(obj, null, "Items", new object[2]
					{
						obj2,
						array3[0]
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				graphics.DrawString(Conversions.ToString(obj4), e.Font, brush2, bounds);
			}
			else
			{
				using SolidBrush brush3 = new SolidBrush(e.ForeColor);
				Graphics graphics2 = e.Graphics;
				object[] array5 = new object[1];
				object obj2 = sender;
				object instance2 = obj2;
				object[] array6 = new object[1];
				object obj = (array6[0] = e.Index);
				array5[0] = NewLateBinding.LateGet(instance2, null, "Items", array6, null, null, null);
				object[] array3 = array5;
				bool[] obj5 = new bool[1] { true };
				bool[] array4 = obj5;
				object obj4 = NewLateBinding.LateGet(sender, null, "GetItemText", array5, null, null, obj5);
				if (array4[0])
				{
					NewLateBinding.LateSetComplex(obj2, null, "Items", new object[2]
					{
						obj,
						array3[0]
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				graphics2.DrawString(Conversions.ToString(obj4), e.Font, brush3, e.Bounds);
			}
			e.DrawFocusRectangle();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void Reset(bool thrmode = false)
	{
		Module1.databusy = true;
		Application.DoEvents();
		if (thrmode)
		{
			Module1.thr = new Thread(getASBoard);
			Module1.thr.Start();
			Module1.thr3 = new Thread(getNotice);
			Module1.thr3.Start();
			try
			{
				while (Module1.thr.IsAlive & Module1.thr3.IsAlive)
				{
					Application.DoEvents();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		else
		{
			getASBoard();
			getNotice();
		}
		getLog();
		Module1.databusy = false;
		FastColoredTextBox1.Text = "";
		FastColoredTextBox1.Selection.Start = Place.Empty;
		FastColoredTextBox1.DoCaretVisible();
		FastColoredTextBox1.IsChanged = false;
		FastColoredTextBox1.ClearUndo();
	}

	public void getASBoard()
	{
		ASBoard = new List<string>();
		string[] array = Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + "&type=getAS").Trim().Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string item in array)
		{
			ASBoard.Add(item);
		}
		try
		{
			Module1.thr.Abort();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void getNotice()
	{
		Notice = new List<string>();
		p_diag2_c2.DataSource = null;
		p4_ComboBox1.Items.Clear();
		string[] array = Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + "&type=getNotice").Trim().Trim()
			.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			string[] array2 = text.Trim().Split(new string[1] { "%" }, StringSplitOptions.None);
			Notice.Add(text);
			p4_ComboBox1.Items.Add(array2[2]);
		}
		p_diag2_c2.DataSource = p4_ComboBox1.Items;
		Label15.Text = "총 " + Conversions.ToString(Notice.Count) + "항목";
		if (Notice.Count > 0)
		{
			p4_ComboBox1.SelectedIndex = 0;
		}
		getCustomer();
		getProject();
		try
		{
			Module1.thr3.Abort();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void getCustomer()
	{
		Customer = new List<string>();
		ListView4.Items.Clear();
		p_diag2_c1.Items.Clear();
		string obj = Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + "&type=getCustomer").Trim();
		int num = 0;
		string[] array = obj.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		checked
		{
			foreach (string text in array)
			{
				Customer.Add(text);
				string[] array2 = text.Trim().Split(new string[1] { "%" }, StringSplitOptions.None);
				ListView4.Items.Add(array2[0]);
				p_diag2_c1.Items.Add(Conversion.Val(array2[0]).ToString("000#") + "=" + array2[1]);
				int num2 = array2.Length - 1;
				for (int j = 1; j <= num2; j++)
				{
					ListView4.Items[num].SubItems.Add(array2[j]);
				}
				num++;
			}
		}
	}

	public void getProject()
	{
		p3_combobox1.DataSource = null;
		ComboBox1.DataSource = null;
		Project = new List<string>();
		ProjectNames = new List<string>();
		ListView1.Items.Clear();
		string obj = Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + "&type=getProj").Trim();
		int num = 0;
		string[] array = obj.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		checked
		{
			foreach (string text in array)
			{
				Project.Add(text);
				string[] array2 = text.Trim().Split(new string[1] { "%" }, StringSplitOptions.None);
				ListView1.Items.Add(array2[0]);
				int num2 = array2.Length - 1;
				for (int j = 1; j <= num2; j++)
				{
					if (j == 1)
					{
						ProjectNames.Add(array2[j]);
					}
					if (j == 4)
					{
						bool flag = false;
						foreach (string item in Customer)
						{
							if (Operators.CompareString(item.Substring(0, item.IndexOf("%")), array2[j], TextCompare: false) == 0)
							{
								string[] array3 = item.Split(new string[1] { "%" }, StringSplitOptions.None);
								flag = true;
								ListView1.Items[num].SubItems.Add(array3[1]);
								break;
							}
						}
						if (!flag)
						{
							ListView1.Items[num].SubItems.Add("");
						}
					}
					else
					{
						ListView1.Items[num].SubItems.Add(array2[j]);
					}
				}
				num++;
			}
			p3_combobox1.DataSource = ProjectNames;
			ComboBox1.DataSource = ProjectNames;
			ListBox2.Items.Clear();
			ComboBox2.SelectedIndex = 1;
			ComboBox3.SelectedIndex = 0;
		}
	}

	public void getLog()
	{
		ListView2.Items.Clear();
		string obj = Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + "&type=getLog").Trim();
		int num = 0;
		string[] array = obj.Split(new string[1] { "<split>" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			Project.Add(text);
			string[] array2 = text.Trim().Split(new string[1] { "<enter>" }, StringSplitOptions.None);
			ListView2.Items.Add(array2[0]);
			ListView2.Items[num].SubItems.Add(array2[1]);
			ListView2.Items[num].SubItems.Add(array2[2]);
			ListView2.Items[num].SubItems.Add(array2[3]);
			ListView2.Items[num].SubItems.Add(array2[4]);
			num = checked(num + 1);
		}
	}

	private void Button18_Click(object sender, EventArgs e)
	{
		ListView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		p3_combobox1.Text = ListView1.Items[ListView1.SelectedIndices[0]].SubItems[1].Text;
		checked
		{
			MyProject.Forms.mlas.ListBox1.SelectedIndex++;
		}
	}

	private void p3_btn1_Click(object sender, EventArgs e)
	{
		string text = p3_combobox1.Text;
		if (Operators.CompareString(p3_num.Text, null, TextCompare: false) != 0 && MessageBox.Show("삭제합니까?", "안내", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.No)
		{
			string text2 = "&type=dropAS&num=" + p3_num.Text;
			if (Operators.CompareString(Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + text2).Trim(), "correct", TextCompare: false) != 0)
			{
				MessageBox.Show("오류", "안내", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			Reset();
			p3_combobox1.Text = text;
		}
	}

	private void p3_btn2_Click(object sender, EventArgs e)
	{
		string text = p3_combobox1.Text;
		if (Operators.CompareString(p3_num.Text, null, TextCompare: false) == 0)
		{
			string text2 = "&type=addAS&project=" + p3_combobox1.Text + "&title=" + p3_text1.Text + "&writeby=" + p3_writer.Text + "&body=" + HttpUtility.UrlEncode(p3_text3.Text) + "&filename=" + p3_text2.Text + "&filesize=" + p3_kb.Text;
			Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + text2).Trim();
		}
		else
		{
			string text3 = "&type=editAS&num=" + p3_num.Text + "&project=" + p3_combobox1.Text + "&title=" + p3_text1.Text + "&writeby=" + p3_writer.Text + "&body=" + HttpUtility.UrlEncode(p3_text3.Text) + "&filename=" + p3_text2.Text + "&filesize=" + p3_kb.Text;
			Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + text3).Trim();
		}
		Reset();
		p3_combobox1.Text = text;
	}

	private void p3_btn3_Click(object sender, EventArgs e)
	{
		p3_combobox2.Text = null;
		p3_num.Text = null;
		p3_text1.Text = null;
		p3_text2.Text = null;
		p3_text3.Text = null;
		p3_kb.Text = null;
		p3_writer.Text = null;
		p3_date.Text = null;
	}

	private void p3_combobox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		p3_combobox2.Items.Clear();
		p3_num.Text = null;
		p3_text1.Text = null;
		p3_text2.Text = null;
		p3_text3.Text = null;
		p3_kb.Text = null;
		p3_writer.Text = null;
		p3_date.Text = null;
		checked
		{
			int num = ASBoard.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string instance = ASBoard[i];
				object[] array = new object[1];
				array[0] = NewLateBinding.LateGet(sender, null, "SelectedValue", new object[0], null, null, null);
				object[] array2 = array;
				bool[] array3;
				object left = NewLateBinding.LateGet(instance, null, "IndexOf", array, null, null, array3 = new bool[1] { true });
				if (array3[0])
				{
					NewLateBinding.LateSetComplex(sender, null, "SelectedValue", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
				}
				if (Operators.ConditionalCompareObjectGreater(left, 0, TextCompare: false))
				{
					string[] array4 = ASBoard[i].Split(new string[1] { "%" }, StringSplitOptions.None);
					p3_combobox2.Items.Add(array4[2]);
				}
			}
			p3_count.Text = "총 " + Conversions.ToString(p3_combobox2.Items.Count) + "항목";
			if (p3_combobox2.Items.Count > 0)
			{
				p3_combobox2.SelectedIndex = 0;
			}
		}
	}

	private void p3_combobox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		checked
		{
			int num = ASBoard.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = ASBoard[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(array[1].Trim(), p3_combobox1.SelectedValue, TextCompare: false), Operators.CompareObjectEqual(array[2].Trim(), p3_combobox2.SelectedItem, TextCompare: false))))
				{
					p3_num.Text = array[0];
					p3_text1.Text = array[2];
					p3_text2.Text = array[6];
					p3_text3.Text = array[5];
					p3_kb.Text = array[7];
					p3_writer.Text = array[4];
					p3_date.Text = array[3];
					break;
				}
			}
		}
	}

	private void txt_notice_Click(object sender, EventArgs e)
	{
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		txt_noticedetail.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
	}

	private void TextBox5_TextChanged(object sender, EventArgs e)
	{
		txt_notice.Text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
	}

	private void p4_color1_Click(object sender, EventArgs e)
	{
		p4_color1.Text = "v";
		p4_color2.Text = null;
		p4_color3.Text = null;
		p4_color4.Text = null;
		txt_notice.BackColor = Color.FromArgb(36, 36, 36);
	}

	private void p4_color2_Click(object sender, EventArgs e)
	{
		p4_color1.Text = null;
		p4_color2.Text = "v";
		p4_color3.Text = null;
		p4_color4.Text = null;
		txt_notice.BackColor = Color.Maroon;
	}

	private void p4_color3_Click(object sender, EventArgs e)
	{
		p4_color1.Text = null;
		p4_color2.Text = null;
		p4_color3.Text = "v";
		p4_color4.Text = null;
		txt_notice.BackColor = Color.Navy;
	}

	private void p4_color4_Click(object sender, EventArgs e)
	{
		p4_color1.Text = null;
		p4_color2.Text = null;
		p4_color3.Text = null;
		p4_color4.Text = "v";
		txt_notice.BackColor = Color.DarkGreen;
	}

	private void p4_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		p4_color1.Text = null;
		p4_color2.Text = null;
		p4_color3.Text = null;
		p4_color4.Text = null;
		checked
		{
			int num = Notice.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = Notice[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.ConditionalCompareObjectEqual(array[2].Trim(), p4_ComboBox1.SelectedItem, TextCompare: false))
				{
					p4_num.Text = array[0];
					p4_text1.Text = array[2];
					p4_text2.Text = array[3];
					Module1.notice_color = (int)Math.Round(Conversion.Val(array[1]));
					switch (Module1.notice_color)
					{
					case 0:
						txt_notice.BackColor = Color.FromArgb(36, 36, 36);
						p4_color1.Text = "v";
						break;
					case 1:
						txt_notice.BackColor = Color.Maroon;
						p4_color2.Text = "v";
						break;
					case 2:
						txt_notice.BackColor = Color.Navy;
						p4_color3.Text = "v";
						break;
					case 3:
						txt_notice.BackColor = Color.DarkGreen;
						p4_color4.Text = "v";
						break;
					}
					break;
				}
			}
		}
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		string text = p4_ComboBox1.Text;
		int num = 0;
		if (Operators.CompareString(p4_color2.Text, null, TextCompare: false) != 0)
		{
			num = 1;
		}
		if (Operators.CompareString(p4_color3.Text, null, TextCompare: false) != 0)
		{
			num = 2;
		}
		if (Operators.CompareString(p4_color4.Text, null, TextCompare: false) != 0)
		{
			num = 3;
		}
		if (Operators.CompareString(p4_num.Text, null, TextCompare: false) == 0)
		{
			string text2 = "&type=addNotice&color=" + Conversions.ToString(num) + "&title=" + p4_text1.Text + "&text=" + p4_text2.Text;
			Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + text2).Trim();
		}
		else
		{
			string text3 = "&type=editNotice&num=" + p4_num.Text + "&color=" + Conversions.ToString(num) + "&title=" + p4_text1.Text + "&text=" + p4_text2.Text;
			Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + text3).Trim();
		}
		Reset();
		p4_ComboBox1.Text = text;
	}

	private void Button13_Click(object sender, EventArgs e)
	{
		p4_ComboBox1.Text = null;
		p4_text1.Text = null;
		p4_text2.Text = null;
		p4_color1.Text = "v";
		p4_color2.Text = null;
		p4_color3.Text = null;
		p4_color4.Text = null;
		p4_num.Text = null;
		txt_notice.BackColor = Color.FromArgb(36, 36, 36);
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		string text = p4_ComboBox1.Text;
		if (Operators.CompareString(p4_num.Text, null, TextCompare: false) != 0 && MessageBox.Show("삭제합니까?", "안내", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.No)
		{
			string text2 = "&type=dropNotice&num=" + p4_num.Text;
			if (Operators.CompareString(Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + text2).Trim(), "correct", TextCompare: false) != 0)
			{
				MessageBox.Show("오류", "안내", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			Reset();
			p4_ComboBox1.Text = text;
		}
	}

	private void Splitter1_SplitterMoved(object sender, SplitterEventArgs e)
	{
		ComboBox1.Invalidate();
		ComboBox2.Invalidate();
		ComboBox3.Invalidate();
		ListBox2.Invalidate();
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Module1.databusy)
		{
			ComboBox1.Text = null;
			return;
		}
		p5.Controls.Add(p_ftp_login);
		Point point = Module1.ControlCenter(p5, p_ftp_login);
		p_ftp_login.Top = point.X;
		p_ftp_login.Left = point.Y;
		p5.Controls.SetChildIndex(p_ftp_login, 0);
		p_ftp_login.Show();
		string[] array = Project[ComboBox1.SelectedIndex].Trim().Split(new string[1] { "%" }, StringSplitOptions.None);
		TextBox3.Text = array[5].Replace("http://", "ftp://");
	}

	public void ProgramExit()
	{
		try
		{
			ftp.Abort();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		Uri uri = new Uri(TextBox3.Text);
		ftp = new myftp(uri, TextBox1.Text, TextBox2.Text, CheckBox1.Checked);
		ListBox2.Items.Clear();
		string fileList = ftp.GetFileList();
		if (Operators.CompareString(fileList, "False", TextCompare: false) != 0)
		{
			loginOK = true;
		}
		else
		{
			loginOK = false;
		}
		string[] array = fileList.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			string text2 = text.Remove(0, checked(text.LastIndexOf("/") + 1));
			if (!((Operators.CompareString(text2, ".", TextCompare: false) == 0) | (Operators.CompareString(text2, "..", TextCompare: false) == 0) | (text2.LastIndexOf(".") < 0)))
			{
				ListBox2.Items.Add(text2);
			}
		}
		Label26.Text = "File Detail";
		code_tb.Text = null;
		FastColoredTextBox1.Text = "";
		filename = null;
		if (loginOK)
		{
			Label32.Text = Conversions.ToString(Operators.ConcatenateObject(ComboBox1.SelectedItem, " 서버에 접속 중 입니다."));
			Label32.ForeColor = Color.DarkBlue;
			p_ftp_login.Hide();
		}
		else
		{
			Label32.Text = "접속 실패 : " + ftp.GetError;
			Label32.ForeColor = Color.DarkRed;
		}
	}

	private void Button17_Click(object sender, EventArgs e)
	{
		string[] array = TextBox3.Text.Split(new string[1] { "/" }, StringSplitOptions.None);
		string text = null;
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text += array[i];
				if (i != array.Length - 1)
				{
					text += "/";
				}
				object left = NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null);
				if (Operators.ConditionalCompareObjectEqual(left, "Button17", TextCompare: false))
				{
					if (i == 2)
					{
						text += "public_html/";
					}
				}
				else if (Operators.ConditionalCompareObjectEqual(left, "Button20", TextCompare: false) && i == 2)
				{
					text += "www/";
				}
			}
			TextBox3.Text = text;
		}
	}

	private void Button16_Click(object sender, EventArgs e)
	{
		if (Module1.databusy)
		{
			return;
		}
		Module1.databusy = true;
		if (Operators.CompareString(filename, null, TextCompare: false) != 0)
		{
			if (ComboBox3.SelectedIndex == 0)
			{
				ftp.SaveFile(filename, FastColoredTextBox1.Text);
			}
			else
			{
				ftp.SaveFile(filename, code_tb.Text);
			}
			tcount = 0;
			Timer1.Start();
			Label25.Text = "저장 완료";
			Label25.BackColor = Color.ForestGreen;
			Label25.Show();
			Module1.databusy = false;
		}
	}

	private void Button19_Click(object sender, EventArgs e)
	{
		p_ftp_login.Hide();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectLess(tcount, 1, TextCompare: false))
		{
			ref object reference = ref tcount;
			reference = Operators.AddObject(reference, 1);
		}
		else
		{
			Label25.Hide();
			tcount = 0;
			Timer1.Stop();
		}
	}

	private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!Module1.databusy)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null), 0, TextCompare: false))
			{
				FastColoredTextBox1.Text = code_tb.Text;
				code_tb.Hide();
				FastColoredTextBox1.Show();
			}
			else
			{
				code_tb.Text = FastColoredTextBox1.Text;
				code_tb.Show();
				FastColoredTextBox1.Hide();
			}
		}
	}

	private void ListBox2_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (!Module1.databusy)
		{
			Module1.databusy = true;
			filename = Conversions.ToString(NewLateBinding.LateGet(sender, null, "SelectedItem", new object[0], null, null, null));
			object objectValue = RuntimeHelpers.GetObjectValue(ftp.FileRead(filename, ComboBox2.SelectedIndex));
			if (ComboBox3.SelectedIndex == 0)
			{
				FastColoredTextBox1.Text = Conversions.ToString(objectValue);
			}
			else
			{
				code_tb.Text = Conversions.ToString(objectValue);
			}
			if (Operators.ConditionalCompareObjectNotEqual(objectValue, null, TextCompare: false))
			{
				Label26.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ComboBox1.SelectedItem, "/"), filename));
				tcount = 0;
				Timer1.Start();
				Label25.Text = "파일 열었음";
				Label25.BackColor = Color.DarkRed;
				Label25.Show();
			}
			Module1.databusy = false;
		}
	}

	private void Button23_Click(object sender, EventArgs e)
	{
		if (TextBox4.Text.LastIndexOf(".") < 0)
		{
			TextBox4.Text += ".php";
		}
		ftp.SaveFile(TextBox4.Text, "");
		ListBox2.Items.Clear();
		Uri uri = new Uri(TextBox3.Text);
		ftp = new myftp(uri, TextBox1.Text, TextBox2.Text);
		string[] array = ftp.GetFileList().Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			string text2 = text.Remove(0, checked(text.LastIndexOf("/") + 1));
			if (!((Operators.CompareString(text2, ".", TextCompare: false) == 0) | (Operators.CompareString(text2, "..", TextCompare: false) == 0)))
			{
				ListBox2.Items.Add(text2);
			}
		}
		p_ftp_file.Hide();
	}

	private void Button21_Click(object sender, EventArgs e)
	{
		if (loginOK)
		{
			p5.Controls.Add(p_ftp_file);
			TextBox4.Text = null;
			Point point = Module1.ControlCenter(p5, p_ftp_file);
			p_ftp_file.Top = point.X;
			p_ftp_file.Left = point.Y;
			p5.Controls.SetChildIndex(p_ftp_file, 0);
			p_ftp_file.Show();
			TextBox4.Focus();
		}
	}

	private void Button24_Click(object sender, EventArgs e)
	{
		p_ftp_file.Hide();
	}

	private void Button22_Click(object sender, EventArgs e)
	{
		if (!loginOK || Operators.ConditionalCompareObjectEqual(ListBox2.SelectedItem, null, TextCompare: false) || MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(ListBox2.SelectedItem, " 파일을 정말 삭제 하시겠습니까?")), "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
		{
			return;
		}
		ftp.DeleteFTP(Conversions.ToString(ListBox2.SelectedItem));
		ListBox2.Items.Clear();
		Uri uri = new Uri(TextBox3.Text);
		ftp = new myftp(uri, TextBox1.Text, TextBox2.Text);
		string[] array = ftp.GetFileList().Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			string text2 = text.Remove(0, checked(text.LastIndexOf("/") + 1));
			if (!((Operators.CompareString(text2, ".", TextCompare: false) == 0) | (Operators.CompareString(text2, "..", TextCompare: false) == 0)))
			{
				ListBox2.Items.Add(text2);
			}
		}
	}

	private void code_tb_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Control)
		{
			e.SuppressKeyPress = true;
		}
		if (e.Control & (e.KeyCode == Keys.S))
		{
			Button16_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void Button25_Click(object sender, EventArgs e)
	{
		if (TextBox6.Text.LastIndexOf(".") < 0)
		{
			TextBox6.Text += ".php";
		}
		ftp.Rename(TextBox5.Text, TextBox6.Text);
		ListBox2.Items.Clear();
		Uri uri = new Uri(TextBox3.Text);
		ftp = new myftp(uri, TextBox1.Text, TextBox2.Text);
		string[] array = ftp.GetFileList().Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			string text2 = text.Remove(0, checked(text.LastIndexOf("/") + 1));
			if (!((Operators.CompareString(text2, ".", TextCompare: false) == 0) | (Operators.CompareString(text2, "..", TextCompare: false) == 0)))
			{
				ListBox2.Items.Add(text2);
			}
		}
		p_ftp_mname.Hide();
	}

	private void Button26_Click(object sender, EventArgs e)
	{
		p_ftp_mname.Hide();
	}

	private void Button27_Click(object sender, EventArgs e)
	{
		if (loginOK && !Operators.ConditionalCompareObjectEqual(ListBox2.SelectedItem, null, TextCompare: false))
		{
			p5.Controls.Add(p_ftp_mname);
			TextBox5.Text = Conversions.ToString(ListBox2.SelectedItem);
			TextBox6.Text = null;
			Point point = Module1.ControlCenter(p5, p_ftp_mname);
			p_ftp_mname.Top = point.X;
			p_ftp_mname.Left = point.Y;
			p5.Controls.SetChildIndex(p_ftp_mname, 0);
			p_ftp_mname.Show();
			TextBox6.Focus();
		}
	}

	private void TextBox3_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button11_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void TextBox4_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button23_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void TextBox6_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button25_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void p_ftp_file_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Label11_MouseDown(object sender, MouseEventArgs e)
	{
		ObjectMover.FocusObject(p_ftp_login.Handle);
		ObjectMover.MoveObject(p_ftp_login.Handle);
	}

	private void Label33_MouseDown(object sender, MouseEventArgs e)
	{
		ObjectMover.FocusObject(p_ftp_file.Handle);
		ObjectMover.MoveObject(p_ftp_file.Handle);
	}

	private void Label34_MouseDown(object sender, MouseEventArgs e)
	{
		ObjectMover.FocusObject(p_ftp_mname.Handle);
		ObjectMover.MoveObject(p_ftp_mname.Handle);
	}

	private void Label40_MouseDown(object sender, MouseEventArgs e)
	{
		ObjectMover.FocusObject(p_diag1.Handle);
		ObjectMover.MoveObject(p_diag1.Handle);
	}

	private void Label50_MouseDown(object sender, MouseEventArgs e)
	{
		ObjectMover.FocusObject(p_diag2.Handle);
		ObjectMover.MoveObject(p_diag2.Handle);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		Label40.Text = "새 고객";
		p_diag1_num.Text = null;
		p1.Controls.Add(p_diag1);
		Point point = Module1.ControlCenter(p1, p_diag1);
		p_diag1.Top = point.X;
		p_diag1.Left = point.Y;
		p1.Controls.SetChildIndex(p_diag1, 0);
		p_diag1.Show();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		Label50.Text = "새 프로젝트";
		p_diag2_num.Text = null;
		p2.Controls.Add(p_diag2);
		Point point = Module1.ControlCenter(p2, p_diag2);
		p_diag2.Top = point.X;
		p_diag2.Left = point.Y;
		p2.Controls.SetChildIndex(p_diag2, 0);
		p_diag2.Show();
	}

	private void Button30_Click(object sender, EventArgs e)
	{
		p_diag1.Hide();
	}

	private void Button28_Click(object sender, EventArgs e)
	{
		p_diag2.Hide();
	}

	private void Button15_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(p_diag2_c1.Text, null, TextCompare: false) == 0)
		{
			MessageBox.Show("고객명이 누락입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		string text = "UTF8";
		if (!p_diag2_rb1.Checked)
		{
			text = "EUCKR";
		}
		int num = 1;
		if (!p_diag2_chk1.Checked)
		{
			num = 0;
		}
		object obj = null;
		if (Operators.CompareString(p_diag2_c2.Text, null, TextCompare: false) != 0)
		{
			obj = Notice[p_diag2_c2.SelectedIndex];
			object instance = obj;
			object[] obj2 = new object[2] { 0, null };
			object instance2 = obj;
			object[] array = new object[1];
			object obj3 = (array[0] = "%");
			obj2[1] = NewLateBinding.LateGet(instance2, null, "IndexOf", array, null, null, null);
			object[] array2 = obj2;
			bool[] obj4 = new bool[2] { false, true };
			bool[] array3 = obj4;
			object obj5 = NewLateBinding.LateGet(instance, null, "Substring", obj2, null, null, obj4);
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(instance2, null, "IndexOf", new object[2]
				{
					obj3,
					array2[1]
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			obj = RuntimeHelpers.GetObjectValue(obj5);
		}
		else
		{
			obj = 0;
		}
		if (Operators.CompareString(p_diag2_num.Text, null, TextCompare: false) == 0)
		{
			object right = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("&type=addProj&project=" + p_diag2_t1.Text + "&id=" + p_diag2_t2.Text + "&pw2=" + p_diag2_t3.Text + "&user=" + Conversions.ToString(Conversion.Val(p_diag2_c1.Text.Substring(0, p_diag2_c1.Text.IndexOf("=")))) + "&dburl=" + p_diag2_t4.Text + "&encode=" + text + "&access=" + Conversions.ToString(num) + "&version=" + p_diag2_t5.Text + "&noticev2=", obj), "&last="), p_diag2_t6.Text);
			Module1.HTMLPost(Module1._dburl + "/admin.php", Conversions.ToString(Operators.ConcatenateObject("pw=" + MySettingsProperty.Settings.pw, right))).Trim();
		}
		else
		{
			object right2 = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("&type=editProj&num=" + p_diag2_num.Text + "&project=" + p_diag2_t1.Text + "&id=" + p_diag2_t2.Text + "&pw2=" + p_diag2_t3.Text + "&user=" + Conversions.ToString(Conversion.Val(p_diag2_c1.Text.Substring(0, p_diag2_c1.Text.IndexOf("=")))) + "&dburl=" + p_diag2_t4.Text + "&encode=" + text + "&access=" + Conversions.ToString(num) + "&version=" + p_diag2_t5.Text + "&noticev2=", obj), "&last="), p_diag2_t6.Text);
			Module1.HTMLPost(Module1._dburl + "/admin.php", Conversions.ToString(Operators.ConcatenateObject("pw=" + MySettingsProperty.Settings.pw, right2))).Trim();
		}
		Reset();
		p_diag2.Hide();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(p4_num.Text, null, TextCompare: false) != 0 && MessageBox.Show(ListView1.SelectedItems[0].SubItems[1].Text + " 프로젝트를 정말 삭제합니까?", "안내", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.No)
		{
			string text = "&type=dropProj&num=" + ListView1.SelectedItems[0].SubItems[0].Text;
			if (Operators.CompareString(Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + text).Trim(), "correct", TextCompare: false) != 0)
			{
				MessageBox.Show("오류", "안내", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			Reset();
		}
	}

	private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left)
		{
			return;
		}
		Label50.Text = "프로젝트 속성 편집";
		p_diag2_num.Text = ListView1.SelectedItems[0].SubItems[0].Text;
		p_diag2_t1.Text = ListView1.SelectedItems[0].SubItems[1].Text;
		p_diag2_t2.Text = ListView1.SelectedItems[0].SubItems[2].Text;
		p_diag2_t3.Text = ListView1.SelectedItems[0].SubItems[3].Text;
		p_diag2_t4.Text = ListView1.SelectedItems[0].SubItems[5].Text;
		p_diag2_t5.Text = ListView1.SelectedItems[0].SubItems[8].Text;
		p_diag2_t6.Text = ListView1.SelectedItems[0].SubItems[10].Text;
		string[] array = Project[ListView1.SelectedIndices[0]].Split(new string[1] { "%" }, StringSplitOptions.None);
		int num = 0;
		checked
		{
			foreach (string item in Customer)
			{
				bool flag = false;
				if (Operators.CompareString(item.Substring(0, item.IndexOf("%")), array[4], TextCompare: false) == 0)
				{
					p_diag2_c1.SelectedIndex = num;
					break;
				}
				num++;
				if (!flag)
				{
					p_diag2_c1.Text = null;
				}
			}
			string[] array2 = Project[ListView1.SelectedIndices[0]].Split(new string[1] { "%" }, StringSplitOptions.None);
			int num2 = 0;
			foreach (string item2 in Notice)
			{
				bool flag2 = false;
				if (Operators.CompareString(item2.Substring(0, item2.IndexOf("%")), array2[9], TextCompare: false) == 0)
				{
					p_diag2_c2.SelectedIndex = num2;
					flag2 = true;
					break;
				}
				num2++;
				if (!flag2)
				{
					p_diag2_c2.Text = null;
				}
			}
			if (Operators.CompareString(ListView1.SelectedItems[0].SubItems[6].Text, "UTF8", TextCompare: false) == 0)
			{
				p_diag2_rb1.Checked = true;
			}
			else
			{
				p_diag2_rb2.Checked = true;
			}
			if (Operators.CompareString(ListView1.SelectedItems[0].SubItems[7].Text, "1", TextCompare: false) == 0)
			{
				p_diag2_chk1.Checked = true;
			}
			else
			{
				p_diag2_chk1.Checked = false;
			}
			p2.Controls.Add(p_diag2);
			Point point = Module1.ControlCenter(p2, p_diag2);
			p_diag2.Top = point.X;
			p_diag2.Left = point.Y;
			p2.Controls.SetChildIndex(p_diag2, 0);
			p_diag2.Show();
		}
	}

	private void Button31_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("정말 정보를 초기화 하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.No)
		{
			p_diag2_c1.Text = null;
			p_diag2_c2.SelectedIndex = 0;
			p_diag2_chk1.Checked = true;
			p_diag2_rb1.Checked = true;
			p_diag2_t1.Text = null;
			p_diag2_t2.Text = null;
			p_diag2_t3.Text = null;
			p_diag2_t4.Text = null;
			p_diag2_t5.Text = null;
			p_diag2_t6.Text = null;
		}
	}

	private void Button32_Click(object sender, EventArgs e)
	{
		p_diag2_c2.Text = null;
	}

	private void Button29_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(p_diag1_num.Text, null, TextCompare: false) == 0)
		{
			string text = "&type=addCustomer&name=" + p_diag1_t1.Text + "&tel=" + p_diag1_t2.Text + "&fax=" + p_diag1_t3.Text + "&buildnum=" + p_diag1_t4.Text + "&email=" + p_diag1_t5.Text + "&address=" + p_diag1_t6.Text;
			Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + text).Trim();
		}
		else
		{
			string text2 = "&type=editCustomer&num=" + p_diag1_num.Text + "&name=" + p_diag1_t1.Text + "&tel=" + p_diag1_t2.Text + "&fax=" + p_diag1_t3.Text + "&buildnum=" + p_diag1_t4.Text + "&email=" + p_diag1_t5.Text + "&address=" + p_diag1_t6.Text;
			Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + text2).Trim();
		}
		Reset();
		p_diag1.Hide();
	}

	private void ListView4_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Label40.Text = "고객 정보 편집";
			p_diag1_num.Text = ListView4.SelectedItems[0].SubItems[0].Text;
			p_diag1_t1.Text = ListView4.SelectedItems[0].SubItems[1].Text;
			p_diag1_t2.Text = ListView4.SelectedItems[0].SubItems[2].Text;
			p_diag1_t3.Text = ListView4.SelectedItems[0].SubItems[3].Text;
			p_diag1_t4.Text = ListView4.SelectedItems[0].SubItems[4].Text;
			p_diag1_t5.Text = ListView4.SelectedItems[0].SubItems[5].Text;
			p_diag1_t6.Text = ListView4.SelectedItems[0].SubItems[6].Text;
			p1.Controls.Add(p_diag1);
			Point point = Module1.ControlCenter(p1, p_diag1);
			p_diag1.Top = point.X;
			p_diag1.Left = point.Y;
			p1.Controls.SetChildIndex(p_diag1, 0);
			p_diag1.Show();
		}
	}

	private void Button33_Click(object sender, EventArgs e)
	{
		p_diag1_t1.Text = null;
		p_diag1_t2.Text = null;
		p_diag1_t3.Text = null;
		p_diag1_t4.Text = null;
		p_diag1_t5.Text = null;
		p_diag1_t6.Text = null;
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		getProject();
	}

	private void Button39_Click(object sender, EventArgs e)
	{
		getLog();
	}

	private void Button34_Click(object sender, EventArgs e)
	{
		MyProject.Forms.CHAT_MAIN.Show();
	}
}
