using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class android_db_sjka_application_noteapp : Form
{
	public delegate void SetTextCallback(string text);

	private IContainer components;

	private string error_log;

	private bool busy;

	private bool bakBusy;

	private string[] HAKs;

	private object @int;

	private string[] xlsxstring;

	private string datasheet;

	private string xlsxresult;

	private bool bCancelEdit;

	private ListViewItem.ListViewSubItem CurrentSB;

	private ListViewItem CurrentItem;

	private DataSet result;

	private string[] spl;

	private ColumnHeader m_SortingColumn;

	private object xlsxcancel;

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

	[field: AccessedThroughProperty("TableLayoutPanel2")]
	internal virtual TableLayoutPanel TableLayoutPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListBox ListBox4
	{
		[CompilerGenerated]
		get
		{
			return _ListBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ListBox7_MouseWheel;
			DrawItemEventHandler value3 = ListBox1_DrawItem;
			EventHandler value4 = ListBox4_SelectedIndexChanged;
			ListBox listBox = _ListBox4;
			if (listBox != null)
			{
				listBox.MouseWheel -= value2;
				listBox.DrawItem -= value3;
				listBox.SelectedIndexChanged -= value4;
			}
			_ListBox4 = value;
			listBox = _ListBox4;
			if (listBox != null)
			{
				listBox.MouseWheel += value2;
				listBox.DrawItem += value3;
				listBox.SelectedIndexChanged += value4;
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

	[field: AccessedThroughProperty("Label31")]
	internal virtual Label Label31
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

	internal virtual TextBox TextBox9
	{
		[CompilerGenerated]
		get
		{
			return _TextBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox9_KeyDown;
			TextBox textBox = _TextBox9;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox9 = value;
			textBox = _TextBox9;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label60")]
	internal virtual Label Label60
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label61")]
	internal virtual Label Label61
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox11
	{
		[CompilerGenerated]
		get
		{
			return _TextBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox11_KeyDown;
			TextBox textBox = _TextBox11;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox11 = value;
			textBox = _TextBox11;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	internal virtual Button Button50
	{
		[CompilerGenerated]
		get
		{
			return _Button50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button50_Click;
			Button button = _Button50;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button50 = value;
			button = _Button50;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button51
	{
		[CompilerGenerated]
		get
		{
			return _Button51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button51_Click;
			Button button = _Button51;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button51 = value;
			button = _Button51;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar2")]
	internal virtual ProgressBar ProgressBar2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txt_search")]
	internal virtual Label txt_search
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button49
	{
		[CompilerGenerated]
		get
		{
			return _Button49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button49_Click;
			Button button = _Button49;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button49 = value;
			button = _Button49;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ComboBox4")]
	internal virtual ComboBoxEx ComboBox4
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
			KeyEventHandler value3 = Button15_KeyDown;
			Button button = _Button15;
			if (button != null)
			{
				button.Click -= value2;
				button.KeyDown -= value3;
			}
			_Button15 = value;
			button = _Button15;
			if (button != null)
			{
				button.Click += value2;
				button.KeyDown += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label23")]
	internal virtual Label Label23
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

	[field: AccessedThroughProperty("Label25")]
	internal virtual Label Label25
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

	[field: AccessedThroughProperty("Label20")]
	internal virtual Label Label20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label19")]
	internal virtual Label Label19
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
			KeyEventHandler value2 = LV_KeyDown;
			MouseEventHandler value3 = ListView1_MouseDoubleClick;
			ColumnClickEventHandler value4 = ListView1_ColumnClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.KeyDown -= value2;
				listView.MouseDoubleClick -= value3;
				listView.ColumnClick -= value4;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.KeyDown += value2;
				listView.MouseDoubleClick += value3;
				listView.ColumnClick += value4;
			}
		}
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
			EventHandler value2 = TextBox6_LostFocus;
			KeyPressEventHandler value3 = TextBox6_KeyPress;
			TextBox textBox = _TextBox6;
			if (textBox != null)
			{
				textBox.LostFocus -= value2;
				textBox.KeyPress -= value3;
			}
			_TextBox6 = value;
			textBox = _TextBox6;
			if (textBox != null)
			{
				textBox.LostFocus += value2;
				textBox.KeyPress += value3;
			}
		}
	}

	[field: AccessedThroughProperty("ProgressBar3")]
	internal virtual ProgressBar ProgressBar3
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button46
	{
		[CompilerGenerated]
		get
		{
			return _Button46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button46_Click;
			Button button = _Button46;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button46 = value;
			button = _Button46;
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

	internal virtual Button btn_next
	{
		[CompilerGenerated]
		get
		{
			return _btn_next;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btn_next_Click;
			Button button = _btn_next;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btn_next = value;
			button = _btn_next;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btn_prev
	{
		[CompilerGenerated]
		get
		{
			return _btn_prev;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btn_prev_Click;
			Button button = _btn_prev;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btn_prev = value;
			button = _btn_prev;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual TextBox txt_page
	{
		[CompilerGenerated]
		get
		{
			return _txt_page;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = txt_page_KeyDown;
			TextBox textBox = _txt_page;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_txt_page = value;
			textBox = _txt_page;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label55")]
	internal virtual Label Label55
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

	internal virtual Button Button53
	{
		[CompilerGenerated]
		get
		{
			return _Button53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button53_Click_1;
			Button button = _Button53;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button53 = value;
			button = _Button53;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button48
	{
		[CompilerGenerated]
		get
		{
			return _Button48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button48_Click;
			Button button = _Button48;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button48 = value;
			button = _Button48;
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
			EventHandler value2 = Button38_Click;
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

	[field: AccessedThroughProperty("Label37")]
	internal virtual Label Label37
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

	internal virtual TextBox TextBox10
	{
		[CompilerGenerated]
		get
		{
			return _TextBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox10_KeyDown;
			TextBox textBox = _TextBox10;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox10 = value;
			textBox = _TextBox10;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label38")]
	internal virtual Label Label38
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListBox ListBox7
	{
		[CompilerGenerated]
		get
		{
			return _ListBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ListBox7_MouseWheel;
			DrawItemEventHandler value3 = ListBox1_DrawItem;
			MouseEventHandler value4 = ListBox7_MouseDoubleClick;
			ListBox listBox = _ListBox7;
			if (listBox != null)
			{
				listBox.MouseWheel -= value2;
				listBox.DrawItem -= value3;
				listBox.MouseDoubleClick -= value4;
			}
			_ListBox7 = value;
			listBox = _ListBox7;
			if (listBox != null)
			{
				listBox.MouseWheel += value2;
				listBox.DrawItem += value3;
				listBox.MouseDoubleClick += value4;
			}
		}
	}

	internal virtual ListView ListView2
	{
		[CompilerGenerated]
		get
		{
			return _ListView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ColumnClickEventHandler value2 = ListView2_ColumnClick;
			ListView listView = _ListView2;
			if (listView != null)
			{
				listView.ColumnClick -= value2;
			}
			_ListView2 = value;
			listView = _ListView2;
			if (listView != null)
			{
				listView.ColumnClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
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

	internal virtual ComboBoxEx ComboBox3
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
			EventHandler value2 = ComboBox3_SelectedIndexChanged;
			ComboBoxEx comboBox = _ComboBox3;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox3 = value;
			comboBox = _ComboBox3;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label22")]
	internal virtual Label Label22
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

	[field: AccessedThroughProperty("Label56")]
	internal virtual Label Label56
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label57")]
	internal virtual Label Label57
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button54
	{
		[CompilerGenerated]
		get
		{
			return _Button54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button54_Click;
			Button button = _Button54;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button54 = value;
			button = _Button54;
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

	[field: AccessedThroughProperty("TextBox25")]
	internal virtual TextBox TextBox25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("prog1")]
	internal virtual Label prog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox CheckBox3
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox3_CheckedChanged;
			CheckBox checkBox = _CheckBox3;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox3 = value;
			checkBox = _CheckBox3;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
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

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
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

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBoxEx ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
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

	internal virtual Button Button47
	{
		[CompilerGenerated]
		get
		{
			return _Button47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button47_Click;
			Button button = _Button47;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button47 = value;
			button = _Button47;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadioButton1")]
	internal virtual RadioButton RadioButton1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RadioButton2")]
	internal virtual RadioButton RadioButton2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBoxEx ComboBox2
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
			EventHandler value2 = ComboBox2_SelectedIndexChanged;
			ComboBoxEx comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("RadioButton3")]
	internal virtual RadioButton RadioButton3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = TextBox2_TextChanged;
			TextBox textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox2 = value;
			textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label28")]
	internal virtual Label Label28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label29")]
	internal virtual Label Label29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox7
	{
		[CompilerGenerated]
		get
		{
			return _TextBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox7_KeyDown;
			TextBox textBox = _TextBox7;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox7 = value;
			textBox = _TextBox7;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TableLayoutPanel1")]
	internal virtual TableLayoutPanel TableLayoutPanel1
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
			MouseEventHandler value2 = ListBox7_MouseWheel;
			DrawItemEventHandler value3 = ListBox1_DrawItem;
			MouseEventHandler value4 = ListBox2_MouseDoubleClick;
			ListBox listBox = _ListBox2;
			if (listBox != null)
			{
				listBox.MouseWheel -= value2;
				listBox.DrawItem -= value3;
				listBox.MouseDoubleClick -= value4;
			}
			_ListBox2 = value;
			listBox = _ListBox2;
			if (listBox != null)
			{
				listBox.MouseWheel += value2;
				listBox.DrawItem += value3;
				listBox.MouseDoubleClick += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Label26")]
	internal virtual Label Label26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual ListBox ListBox3
	{
		[CompilerGenerated]
		get
		{
			return _ListBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ListBox7_MouseWheel;
			DrawItemEventHandler value3 = ListBox1_DrawItem;
			MouseEventHandler value4 = ListBox3_MouseDoubleClick;
			ListBox listBox = _ListBox3;
			if (listBox != null)
			{
				listBox.MouseWheel -= value2;
				listBox.DrawItem -= value3;
				listBox.MouseDoubleClick -= value4;
			}
			_ListBox3 = value;
			listBox = _ListBox3;
			if (listBox != null)
			{
				listBox.MouseWheel += value2;
				listBox.DrawItem += value3;
				listBox.MouseDoubleClick += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Label27")]
	internal virtual Label Label27
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

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBoxEx ComboBox5
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox5_SelectedIndexChanged;
			ComboBoxEx comboBox = _ComboBox5;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox5 = value;
			comboBox = _ComboBox5;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox8")]
	internal virtual TextBox TextBox8
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

	[field: AccessedThroughProperty("Label58")]
	internal virtual Label Label58
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label59")]
	internal virtual Label Label59
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label62")]
	internal virtual Label Label62
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label63")]
	internal virtual Label Label63
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button36")]
	internal virtual Button Button36
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

	[field: AccessedThroughProperty("TableLayoutPanel3")]
	internal virtual TableLayoutPanel TableLayoutPanel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label33")]
	internal virtual Label Label33
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

	internal virtual ListBox ListBox5
	{
		[CompilerGenerated]
		get
		{
			return _ListBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ListBox7_MouseWheel;
			DrawItemEventHandler value3 = ListBox1_DrawItem;
			ListBox listBox = _ListBox5;
			if (listBox != null)
			{
				listBox.MouseWheel -= value2;
				listBox.DrawItem -= value3;
			}
			_ListBox5 = value;
			listBox = _ListBox5;
			if (listBox != null)
			{
				listBox.MouseWheel += value2;
				listBox.DrawItem += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label36")]
	internal virtual Label Label36
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListBox ListBox6
	{
		[CompilerGenerated]
		get
		{
			return _ListBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ListBox7_MouseWheel;
			DrawItemEventHandler value3 = ListBox1_DrawItem;
			ListBox listBox = _ListBox6;
			if (listBox != null)
			{
				listBox.MouseWheel -= value2;
				listBox.DrawItem -= value3;
			}
			_ListBox6 = value;
			listBox = _ListBox6;
			if (listBox != null)
			{
				listBox.MouseWheel += value2;
				listBox.DrawItem += value3;
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

	[field: AccessedThroughProperty("Label45")]
	internal virtual Label Label45
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox6")]
	internal virtual ComboBoxEx ComboBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox7")]
	internal virtual ComboBoxEx ComboBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox8")]
	internal virtual ComboBoxEx ComboBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox9")]
	internal virtual ComboBoxEx ComboBox9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox10")]
	internal virtual ComboBoxEx ComboBox10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox11")]
	internal virtual ComboBoxEx ComboBox11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox12")]
	internal virtual ComboBoxEx ComboBox12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox22")]
	internal virtual TextBox TextBox22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox23")]
	internal virtual TextBox TextBox23
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

	internal virtual Button Button79
	{
		[CompilerGenerated]
		get
		{
			return _Button79;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button79_Click;
			Button button = _Button79;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button79 = value;
			button = _Button79;
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

	internal virtual ComboBoxEx ComboBox16
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox16_SelectedIndexChanged;
			ComboBoxEx comboBox = _ComboBox16;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox16 = value;
			comboBox = _ComboBox16;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label88")]
	internal virtual Label Label88
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

	internal virtual Button Button86
	{
		[CompilerGenerated]
		get
		{
			return _Button86;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button86_Click;
			Button button = _Button86;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button86 = value;
			button = _Button86;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button85
	{
		[CompilerGenerated]
		get
		{
			return _Button85;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button85_Click;
			Button button = _Button85;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button85 = value;
			button = _Button85;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label34")]
	internal virtual Label Label34
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

	[field: AccessedThroughProperty("ComboBox14")]
	internal virtual ComboBoxEx ComboBox14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox13")]
	internal virtual ComboBoxEx ComboBox13
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

	[field: AccessedThroughProperty("Label53")]
	internal virtual Label Label53
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

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
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

	[field: AccessedThroughProperty("TabPage6")]
	internal virtual TabPage TabPage6
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

	[field: AccessedThroughProperty("TabPage8")]
	internal virtual TabPage TabPage8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ContextMenuStrip1")]
	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 전체백업ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _전체백업ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button53_Click;
			ToolStripMenuItem toolStripMenuItem = _전체백업ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_전체백업ToolStripMenuItem = value;
			toolStripMenuItem = _전체백업ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 현재페이지백업ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _현재페이지백업ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _현재페이지백업ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_현재페이지백업ToolStripMenuItem = value;
			toolStripMenuItem = _현재페이지백업ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual Button Button125
	{
		[CompilerGenerated]
		get
		{
			return _Button125;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button125_Click;
			Button button = _Button125;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button125 = value;
			button = _Button125;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p5")]
	internal virtual DoubleBufferPanel p5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel39")]
	internal virtual DoubleBufferPanel Panel39
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel38")]
	internal virtual DoubleBufferPanel Panel38
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel14")]
	internal virtual DoubleBufferPanel Panel14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel15")]
	internal virtual DoubleBufferPanel Panel15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel16")]
	internal virtual DoubleBufferPanel Panel16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel37")]
	internal virtual DoubleBufferPanel Panel37
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel36")]
	internal virtual DoubleBufferPanel Panel36
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p2")]
	internal virtual DoubleBufferPanel p2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel57")]
	internal virtual DoubleBufferPanel Panel57
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel60")]
	internal virtual DoubleBufferPanel Panel60
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel58")]
	internal virtual DoubleBufferPanel Panel58
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel59")]
	internal virtual DoubleBufferPanel Panel59
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel10")]
	internal virtual DoubleBufferPanel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual DoubleBufferPanel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel115")]
	internal virtual DoubleBufferPanel Panel115
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel61")]
	internal virtual DoubleBufferPanel Panel61
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel25")]
	internal virtual DoubleBufferPanel Panel25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel56")]
	internal virtual DoubleBufferPanel Panel56
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel30")]
	internal virtual DoubleBufferPanel Panel30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel24")]
	internal virtual DoubleBufferPanel Panel24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel23")]
	internal virtual DoubleBufferPanel Panel23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual DoubleBufferPanel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p4")]
	internal virtual DoubleBufferPanel p4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel52")]
	internal virtual DoubleBufferPanel Panel52
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel9")]
	internal virtual DoubleBufferPanel Panel9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel31")]
	internal virtual DoubleBufferPanel Panel31
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel32")]
	internal virtual DoubleBufferPanel Panel32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel33")]
	internal virtual DoubleBufferPanel Panel33
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel34")]
	internal virtual DoubleBufferPanel Panel34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel8")]
	internal virtual DoubleBufferPanel Panel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p3")]
	internal virtual DoubleBufferPanel p3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual DoubleBufferPanel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel54")]
	internal virtual DoubleBufferPanel Panel54
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel26")]
	internal virtual DoubleBufferPanel Panel26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel55")]
	internal virtual DoubleBufferPanel Panel55
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel29")]
	internal virtual DoubleBufferPanel Panel29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel11")]
	internal virtual DoubleBufferPanel Panel11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel27")]
	internal virtual DoubleBufferPanel Panel27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel28")]
	internal virtual DoubleBufferPanel Panel28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p7")]
	internal virtual DoubleBufferPanel p7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel13")]
	internal virtual DoubleBufferPanel Panel13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel22")]
	internal virtual DoubleBufferPanel Panel22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel19")]
	internal virtual DoubleBufferPanel Panel19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel20")]
	internal virtual DoubleBufferPanel Panel20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel21")]
	internal virtual DoubleBufferPanel Panel21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel35")]
	internal virtual DoubleBufferPanel Panel35
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel12")]
	internal virtual DoubleBufferPanel Panel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p6")]
	internal virtual DoubleBufferPanel p6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel40")]
	internal virtual DoubleBufferPanel Panel40
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel41")]
	internal virtual DoubleBufferPanel Panel41
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel42")]
	internal virtual DoubleBufferPanel Panel42
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel43")]
	internal virtual DoubleBufferPanel Panel43
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel44")]
	internal virtual DoubleBufferPanel Panel44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel18")]
	internal virtual DoubleBufferPanel Panel18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel17")]
	internal virtual DoubleBufferPanel Panel17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p10")]
	internal virtual DoubleBufferPanel p10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel109")]
	internal virtual DoubleBufferPanel Panel109
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel112")]
	internal virtual DoubleBufferPanel Panel112
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel113")]
	internal virtual DoubleBufferPanel Panel113
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel114")]
	internal virtual DoubleBufferPanel Panel114
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel117")]
	internal virtual DoubleBufferPanel Panel117
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel118")]
	internal virtual DoubleBufferPanel Panel118
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel103")]
	internal virtual DoubleBufferPanel Panel103
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p8")]
	internal virtual DoubleBufferPanel p8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel45")]
	internal virtual DoubleBufferPanel Panel45
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel46")]
	internal virtual DoubleBufferPanel Panel46
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel47")]
	internal virtual DoubleBufferPanel Panel47
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel48")]
	internal virtual DoubleBufferPanel Panel48
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel49")]
	internal virtual DoubleBufferPanel Panel49
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual DoubleBufferPanel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual DoubleBufferPanel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel50")]
	internal virtual DoubleBufferPanel Panel50
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel51")]
	internal virtual DoubleBufferPanel Panel51
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

	[field: AccessedThroughProperty("DoubleBufferPanel1")]
	internal virtual DoubleBufferPanel DoubleBufferPanel1
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

	internal virtual Button Button52
	{
		[CompilerGenerated]
		get
		{
			return _Button52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button52_Click;
			Button button = _Button52;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button52 = value;
			button = _Button52;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button55
	{
		[CompilerGenerated]
		get
		{
			return _Button55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button55_Click;
			Button button = _Button55;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button55 = value;
			button = _Button55;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button56
	{
		[CompilerGenerated]
		get
		{
			return _Button56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button56_Click;
			Button button = _Button56;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button56 = value;
			button = _Button56;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button57
	{
		[CompilerGenerated]
		get
		{
			return _Button57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button57_Click;
			Button button = _Button57;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button57 = value;
			button = _Button57;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel2")]
	internal virtual DoubleBufferPanel DoubleBufferPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button60
	{
		[CompilerGenerated]
		get
		{
			return _Button60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button60_Click;
			Button button = _Button60;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button60 = value;
			button = _Button60;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button58
	{
		[CompilerGenerated]
		get
		{
			return _Button58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button58_Click;
			Button button = _Button58;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button58 = value;
			button = _Button58;
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

	[field: AccessedThroughProperty("DoubleBufferPanel3")]
	internal virtual DoubleBufferPanel DoubleBufferPanel3
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

	public android_db_sjka_application_noteapp()
	{
		base.Load += android_db_sjka_application_noteapp_Load;
		busy = false;
		bakBusy = false;
		datasheet = null;
		xlsxresult = "";
		result = new DataSet();
		xlsxcancel = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.android_db_sjka_application_noteapp));
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.TabPage5 = new System.Windows.Forms.TabPage();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.TabPage6 = new System.Windows.Forms.TabPage();
		this.TabPage7 = new System.Windows.Forms.TabPage();
		this.TabPage8 = new System.Windows.Forms.TabPage();
		this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.전체백업ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.현재페이지백업ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.p2 = new mlas_root.DoubleBufferPanel();
		this.Panel10 = new mlas_root.DoubleBufferPanel();
		this.ComboBox4 = new mlas_root.ComboBoxEx();
		this.Button15 = new System.Windows.Forms.Button();
		this.Label23 = new System.Windows.Forms.Label();
		this.Button16 = new System.Windows.Forms.Button();
		this.Label25 = new System.Windows.Forms.Label();
		this.Panel57 = new mlas_root.DoubleBufferPanel();
		this.Panel60 = new mlas_root.DoubleBufferPanel();
		this.TextBox11 = new System.Windows.Forms.TextBox();
		this.Button50 = new System.Windows.Forms.Button();
		this.Panel58 = new mlas_root.DoubleBufferPanel();
		this.Button51 = new System.Windows.Forms.Button();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Panel59 = new mlas_root.DoubleBufferPanel();
		this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
		this.txt_search = new System.Windows.Forms.Label();
		this.Button49 = new System.Windows.Forms.Button();
		this.Panel7 = new mlas_root.DoubleBufferPanel();
		this.Button9 = new System.Windows.Forms.Button();
		this.Label20 = new System.Windows.Forms.Label();
		this.Button8 = new System.Windows.Forms.Button();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.Label19 = new System.Windows.Forms.Label();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Panel115 = new mlas_root.DoubleBufferPanel();
		this.Panel61 = new mlas_root.DoubleBufferPanel();
		this.ProgressBar3 = new System.Windows.Forms.ProgressBar();
		this.Label42 = new System.Windows.Forms.Label();
		this.Panel25 = new mlas_root.DoubleBufferPanel();
		this.Label11 = new System.Windows.Forms.Label();
		this.Panel56 = new mlas_root.DoubleBufferPanel();
		this.Button46 = new System.Windows.Forms.Button();
		this.Button45 = new System.Windows.Forms.Button();
		this.btn_next = new System.Windows.Forms.Button();
		this.btn_prev = new System.Windows.Forms.Button();
		this.txt_page = new System.Windows.Forms.TextBox();
		this.Panel30 = new mlas_root.DoubleBufferPanel();
		this.Label55 = new System.Windows.Forms.Label();
		this.Panel24 = new mlas_root.DoubleBufferPanel();
		this.Panel23 = new mlas_root.DoubleBufferPanel();
		this.Panel6 = new mlas_root.DoubleBufferPanel();
		this.Button6 = new System.Windows.Forms.Button();
		this.Button53 = new System.Windows.Forms.Button();
		this.Button48 = new System.Windows.Forms.Button();
		this.Button18 = new System.Windows.Forms.Button();
		this.Button11 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.Button42 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button17 = new System.Windows.Forms.Button();
		this.Button77 = new System.Windows.Forms.Button();
		this.p3 = new mlas_root.DoubleBufferPanel();
		this.TextBox25 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.Panel5 = new mlas_root.DoubleBufferPanel();
		this.Panel54 = new mlas_root.DoubleBufferPanel();
		this.Label1 = new System.Windows.Forms.Label();
		this.Button43 = new System.Windows.Forms.Button();
		this.prog1 = new System.Windows.Forms.Label();
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.Panel53 = new System.Windows.Forms.Panel();
		this.Label14 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label15 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.ComboBox1 = new mlas_root.ComboBoxEx();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.CheckBox3 = new System.Windows.Forms.CheckBox();
		this.Button41 = new System.Windows.Forms.Button();
		this.Button37 = new System.Windows.Forms.Button();
		this.Label17 = new System.Windows.Forms.Label();
		this.Panel26 = new mlas_root.DoubleBufferPanel();
		this.Panel55 = new mlas_root.DoubleBufferPanel();
		this.Label12 = new System.Windows.Forms.Label();
		this.Panel29 = new mlas_root.DoubleBufferPanel();
		this.Label13 = new System.Windows.Forms.Label();
		this.Panel11 = new mlas_root.DoubleBufferPanel();
		this.ComboBox2 = new mlas_root.ComboBoxEx();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Button58 = new System.Windows.Forms.Button();
		this.Label16 = new System.Windows.Forms.Label();
		this.RadioButton1 = new System.Windows.Forms.RadioButton();
		this.RadioButton2 = new System.Windows.Forms.RadioButton();
		this.RadioButton3 = new System.Windows.Forms.RadioButton();
		this.Panel27 = new mlas_root.DoubleBufferPanel();
		this.Panel28 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel3 = new mlas_root.DoubleBufferPanel();
		this.Button44 = new System.Windows.Forms.Button();
		this.Button47 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Label4 = new System.Windows.Forms.Label();
		this.p4 = new mlas_root.DoubleBufferPanel();
		this.Panel52 = new mlas_root.DoubleBufferPanel();
		this.Button38 = new System.Windows.Forms.Button();
		this.Label37 = new System.Windows.Forms.Label();
		this.Button39 = new System.Windows.Forms.Button();
		this.TextBox10 = new System.Windows.Forms.TextBox();
		this.Label38 = new System.Windows.Forms.Label();
		this.ListBox7 = new System.Windows.Forms.ListBox();
		this.Label24 = new System.Windows.Forms.Label();
		this.Panel50 = new mlas_root.DoubleBufferPanel();
		this.ListView2 = new System.Windows.Forms.ListView();
		this.Panel9 = new mlas_root.DoubleBufferPanel();
		this.Button10 = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.Label21 = new System.Windows.Forms.Label();
		this.ComboBox3 = new mlas_root.ComboBoxEx();
		this.Label22 = new System.Windows.Forms.Label();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.Panel31 = new mlas_root.DoubleBufferPanel();
		this.Panel32 = new mlas_root.DoubleBufferPanel();
		this.Label56 = new System.Windows.Forms.Label();
		this.Label57 = new System.Windows.Forms.Label();
		this.Panel33 = new mlas_root.DoubleBufferPanel();
		this.Panel34 = new mlas_root.DoubleBufferPanel();
		this.Panel8 = new mlas_root.DoubleBufferPanel();
		this.Button54 = new System.Windows.Forms.Button();
		this.Button13 = new System.Windows.Forms.Button();
		this.Button40 = new System.Windows.Forms.Button();
		this.Button12 = new System.Windows.Forms.Button();
		this.Button14 = new System.Windows.Forms.Button();
		this.Button19 = new System.Windows.Forms.Button();
		this.p7 = new mlas_root.DoubleBufferPanel();
		this.Panel13 = new mlas_root.DoubleBufferPanel();
		this.Button25 = new System.Windows.Forms.Button();
		this.Label28 = new System.Windows.Forms.Label();
		this.Button26 = new System.Windows.Forms.Button();
		this.Label29 = new System.Windows.Forms.Label();
		this.TextBox7 = new System.Windows.Forms.TextBox();
		this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
		this.Panel2 = new mlas_root.DoubleBufferPanel();
		this.Button125 = new System.Windows.Forms.Button();
		this.Button28 = new System.Windows.Forms.Button();
		this.Button27 = new System.Windows.Forms.Button();
		this.Button23 = new System.Windows.Forms.Button();
		this.ListBox2 = new System.Windows.Forms.ListBox();
		this.Label26 = new System.Windows.Forms.Label();
		this.Button22 = new System.Windows.Forms.Button();
		this.ListBox3 = new System.Windows.Forms.ListBox();
		this.Label27 = new System.Windows.Forms.Label();
		this.Panel51 = new mlas_root.DoubleBufferPanel();
		this.Panel22 = new mlas_root.DoubleBufferPanel();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		this.Button24 = new System.Windows.Forms.Button();
		this.Label18 = new System.Windows.Forms.Label();
		this.ComboBox5 = new mlas_root.ComboBoxEx();
		this.TextBox8 = new System.Windows.Forms.TextBox();
		this.Label30 = new System.Windows.Forms.Label();
		this.Panel19 = new mlas_root.DoubleBufferPanel();
		this.Panel20 = new mlas_root.DoubleBufferPanel();
		this.Label58 = new System.Windows.Forms.Label();
		this.Label59 = new System.Windows.Forms.Label();
		this.Panel21 = new mlas_root.DoubleBufferPanel();
		this.Panel35 = new mlas_root.DoubleBufferPanel();
		this.Panel12 = new mlas_root.DoubleBufferPanel();
		this.Button20 = new System.Windows.Forms.Button();
		this.Button21 = new System.Windows.Forms.Button();
		this.Button52 = new System.Windows.Forms.Button();
		this.p5 = new mlas_root.DoubleBufferPanel();
		this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
		this.Panel39 = new mlas_root.DoubleBufferPanel();
		this.ListBox4 = new System.Windows.Forms.ListBox();
		this.Button29 = new System.Windows.Forms.Button();
		this.Panel38 = new mlas_root.DoubleBufferPanel();
		this.Label31 = new System.Windows.Forms.Label();
		this.Label32 = new System.Windows.Forms.Label();
		this.TextBox9 = new System.Windows.Forms.TextBox();
		this.Panel14 = new mlas_root.DoubleBufferPanel();
		this.Panel15 = new mlas_root.DoubleBufferPanel();
		this.Label60 = new System.Windows.Forms.Label();
		this.Label61 = new System.Windows.Forms.Label();
		this.Panel16 = new mlas_root.DoubleBufferPanel();
		this.Panel37 = new mlas_root.DoubleBufferPanel();
		this.Panel36 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel2 = new mlas_root.DoubleBufferPanel();
		this.Button60 = new System.Windows.Forms.Button();
		this.p6 = new mlas_root.DoubleBufferPanel();
		this.Panel40 = new mlas_root.DoubleBufferPanel();
		this.Panel41 = new mlas_root.DoubleBufferPanel();
		this.Label62 = new System.Windows.Forms.Label();
		this.Label63 = new System.Windows.Forms.Label();
		this.Panel42 = new mlas_root.DoubleBufferPanel();
		this.Panel43 = new mlas_root.DoubleBufferPanel();
		this.Panel44 = new mlas_root.DoubleBufferPanel();
		this.Button55 = new System.Windows.Forms.Button();
		this.Button36 = new System.Windows.Forms.Button();
		this.Button33 = new System.Windows.Forms.Button();
		this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
		this.Panel18 = new mlas_root.DoubleBufferPanel();
		this.Label33 = new System.Windows.Forms.Label();
		this.Button30 = new System.Windows.Forms.Button();
		this.Button34 = new System.Windows.Forms.Button();
		this.ListBox5 = new System.Windows.Forms.ListBox();
		this.Label36 = new System.Windows.Forms.Label();
		this.ListBox6 = new System.Windows.Forms.ListBox();
		this.Button32 = new System.Windows.Forms.Button();
		this.Button31 = new System.Windows.Forms.Button();
		this.Panel17 = new mlas_root.DoubleBufferPanel();
		this.Label45 = new System.Windows.Forms.Label();
		this.ComboBox6 = new mlas_root.ComboBoxEx();
		this.ComboBox7 = new mlas_root.ComboBoxEx();
		this.ComboBox8 = new mlas_root.ComboBoxEx();
		this.ComboBox9 = new mlas_root.ComboBoxEx();
		this.ComboBox10 = new mlas_root.ComboBoxEx();
		this.ComboBox11 = new mlas_root.ComboBoxEx();
		this.ComboBox12 = new mlas_root.ComboBoxEx();
		this.p8 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel1 = new mlas_root.DoubleBufferPanel();
		this.ComboBox13 = new mlas_root.ComboBoxEx();
		this.Label53 = new System.Windows.Forms.Label();
		this.Label54 = new System.Windows.Forms.Label();
		this.ComboBox14 = new mlas_root.ComboBoxEx();
		this.Panel45 = new mlas_root.DoubleBufferPanel();
		this.Panel46 = new mlas_root.DoubleBufferPanel();
		this.Label34 = new System.Windows.Forms.Label();
		this.Label35 = new System.Windows.Forms.Label();
		this.Panel47 = new mlas_root.DoubleBufferPanel();
		this.Panel48 = new mlas_root.DoubleBufferPanel();
		this.Panel49 = new mlas_root.DoubleBufferPanel();
		this.Button56 = new System.Windows.Forms.Button();
		this.Button35 = new System.Windows.Forms.Button();
		this.p10 = new mlas_root.DoubleBufferPanel();
		this.TextBox22 = new System.Windows.Forms.TextBox();
		this.Panel1 = new mlas_root.DoubleBufferPanel();
		this.Panel109 = new mlas_root.DoubleBufferPanel();
		this.TextBox23 = new System.Windows.Forms.TextBox();
		this.Label84 = new System.Windows.Forms.Label();
		this.Label85 = new System.Windows.Forms.Label();
		this.Button79 = new System.Windows.Forms.Button();
		this.Label86 = new System.Windows.Forms.Label();
		this.ComboBox16 = new mlas_root.ComboBoxEx();
		this.Panel112 = new mlas_root.DoubleBufferPanel();
		this.Panel113 = new mlas_root.DoubleBufferPanel();
		this.Label88 = new System.Windows.Forms.Label();
		this.Panel114 = new mlas_root.DoubleBufferPanel();
		this.Label89 = new System.Windows.Forms.Label();
		this.Panel117 = new mlas_root.DoubleBufferPanel();
		this.Panel118 = new mlas_root.DoubleBufferPanel();
		this.Panel103 = new mlas_root.DoubleBufferPanel();
		this.Button86 = new System.Windows.Forms.Button();
		this.Button85 = new System.Windows.Forms.Button();
		this.Button57 = new System.Windows.Forms.Button();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage5.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.TabPage6.SuspendLayout();
		this.TabPage7.SuspendLayout();
		this.TabPage8.SuspendLayout();
		this.ContextMenuStrip1.SuspendLayout();
		this.p2.SuspendLayout();
		this.Panel10.SuspendLayout();
		this.Panel57.SuspendLayout();
		this.Panel60.SuspendLayout();
		this.Panel58.SuspendLayout();
		this.Panel59.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.Panel61.SuspendLayout();
		this.Panel25.SuspendLayout();
		this.Panel56.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.p3.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.Panel54.SuspendLayout();
		this.Panel53.SuspendLayout();
		this.Panel26.SuspendLayout();
		this.Panel55.SuspendLayout();
		this.Panel11.SuspendLayout();
		this.DoubleBufferPanel3.SuspendLayout();
		this.p4.SuspendLayout();
		this.Panel52.SuspendLayout();
		this.Panel9.SuspendLayout();
		this.Panel31.SuspendLayout();
		this.Panel8.SuspendLayout();
		this.p7.SuspendLayout();
		this.Panel13.SuspendLayout();
		this.TableLayoutPanel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel22.SuspendLayout();
		this.Panel19.SuspendLayout();
		this.Panel12.SuspendLayout();
		this.p5.SuspendLayout();
		this.TableLayoutPanel2.SuspendLayout();
		this.Panel39.SuspendLayout();
		this.Panel38.SuspendLayout();
		this.Panel14.SuspendLayout();
		this.DoubleBufferPanel2.SuspendLayout();
		this.p6.SuspendLayout();
		this.Panel40.SuspendLayout();
		this.Panel44.SuspendLayout();
		this.TableLayoutPanel3.SuspendLayout();
		this.Panel18.SuspendLayout();
		this.Panel17.SuspendLayout();
		this.p8.SuspendLayout();
		this.DoubleBufferPanel1.SuspendLayout();
		this.Panel45.SuspendLayout();
		this.Panel49.SuspendLayout();
		this.p10.SuspendLayout();
		this.Panel109.SuspendLayout();
		this.Panel112.SuspendLayout();
		this.Panel113.SuspendLayout();
		this.Panel103.SuspendLayout();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage5);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Controls.Add(this.TabPage6);
		this.TabControl1.Controls.Add(this.TabPage7);
		this.TabControl1.Controls.Add(this.TabPage8);
		this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabControl1.Location = new System.Drawing.Point(0, 0);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(876, 709);
		this.TabControl1.TabIndex = 0;
		this.TabPage1.BackColor = System.Drawing.Color.Transparent;
		this.TabPage1.Controls.Add(this.p2);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new System.Drawing.Size(868, 683);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "데이터관리";
		this.TabPage5.BackColor = System.Drawing.Color.Transparent;
		this.TabPage5.Controls.Add(this.p3);
		this.TabPage5.Location = new System.Drawing.Point(4, 22);
		this.TabPage5.Name = "TabPage5";
		this.TabPage5.Size = new System.Drawing.Size(868, 683);
		this.TabPage5.TabIndex = 4;
		this.TabPage5.Text = "데이터추가";
		this.TabPage2.BackColor = System.Drawing.Color.Transparent;
		this.TabPage2.Controls.Add(this.p4);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new System.Drawing.Size(868, 683);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "학명집관리";
		this.TabPage3.BackColor = System.Drawing.Color.Transparent;
		this.TabPage3.Controls.Add(this.p7);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(868, 683);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "폴더관리";
		this.TabPage4.BackColor = System.Drawing.Color.Transparent;
		this.TabPage4.Controls.Add(this.p5);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(868, 683);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "컬럼관리";
		this.TabPage6.BackColor = System.Drawing.Color.Transparent;
		this.TabPage6.Controls.Add(this.p6);
		this.TabPage6.Location = new System.Drawing.Point(4, 22);
		this.TabPage6.Name = "TabPage6";
		this.TabPage6.Size = new System.Drawing.Size(868, 683);
		this.TabPage6.TabIndex = 5;
		this.TabPage6.Text = "뷰관리";
		this.TabPage7.BackColor = System.Drawing.Color.Transparent;
		this.TabPage7.Controls.Add(this.p8);
		this.TabPage7.Location = new System.Drawing.Point(4, 22);
		this.TabPage7.Name = "TabPage7";
		this.TabPage7.Size = new System.Drawing.Size(868, 683);
		this.TabPage7.TabIndex = 6;
		this.TabPage7.Text = "검색관리";
		this.TabPage8.BackColor = System.Drawing.Color.Transparent;
		this.TabPage8.Controls.Add(this.p10);
		this.TabPage8.Location = new System.Drawing.Point(4, 22);
		this.TabPage8.Name = "TabPage8";
		this.TabPage8.Size = new System.Drawing.Size(868, 683);
		this.TabPage8.TabIndex = 7;
		this.TabPage8.Text = "게시판관리";
		this.ContextMenuStrip1.AutoSize = false;
		this.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.ContextMenuStrip1.DropShadowEnabled = false;
		this.ContextMenuStrip1.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
		this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.전체백업ToolStripMenuItem, this.현재페이지백업ToolStripMenuItem });
		this.ContextMenuStrip1.Name = "ContextMenuStrip1";
		this.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		this.ContextMenuStrip1.ShowImageMargin = false;
		this.ContextMenuStrip1.ShowItemToolTips = false;
		this.ContextMenuStrip1.Size = new System.Drawing.Size(150, 57);
		this.전체백업ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
		this.전체백업ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.전체백업ToolStripMenuItem.Name = "전체백업ToolStripMenuItem";
		this.전체백업ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
		this.전체백업ToolStripMenuItem.Text = "전체 백업";
		this.현재페이지백업ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.현재페이지백업ToolStripMenuItem.Name = "현재페이지백업ToolStripMenuItem";
		this.현재페이지백업ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
		this.현재페이지백업ToolStripMenuItem.Text = "현재 페이지 백업";
		this.p2.Controls.Add(this.Panel10);
		this.p2.Controls.Add(this.Panel57);
		this.p2.Controls.Add(this.Panel7);
		this.p2.Controls.Add(this.TextBox6);
		this.p2.Controls.Add(this.ListView1);
		this.p2.Controls.Add(this.Panel115);
		this.p2.Controls.Add(this.Panel61);
		this.p2.Controls.Add(this.Panel25);
		this.p2.Controls.Add(this.Panel24);
		this.p2.Controls.Add(this.Panel23);
		this.p2.Controls.Add(this.Panel6);
		this.p2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p2.Location = new System.Drawing.Point(0, 0);
		this.p2.Margin = new System.Windows.Forms.Padding(0);
		this.p2.Name = "p2";
		this.p2.Size = new System.Drawing.Size(868, 683);
		this.p2.TabIndex = 16;
		this.p2.Visible = false;
		this.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel10.Controls.Add(this.ComboBox4);
		this.Panel10.Controls.Add(this.Button15);
		this.Panel10.Controls.Add(this.Label23);
		this.Panel10.Controls.Add(this.Button16);
		this.Panel10.Controls.Add(this.Label25);
		this.Panel10.Location = new System.Drawing.Point(57, 266);
		this.Panel10.Name = "Panel10";
		this.Panel10.Size = new System.Drawing.Size(376, 165);
		this.Panel10.TabIndex = 5;
		this.Panel10.Visible = false;
		this.ComboBox4.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox4.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox4.FormattingEnabled = true;
		this.ComboBox4.Location = new System.Drawing.Point(55, 79);
		this.ComboBox4.Name = "ComboBox4";
		this.ComboBox4.Size = new System.Drawing.Size(264, 28);
		this.ComboBox4.TabIndex = 15;
		this.Button15.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button15.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button15.BackgroundImage");
		this.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button15.ForeColor = System.Drawing.Color.White;
		this.Button15.Location = new System.Drawing.Point(191, 123);
		this.Button15.Name = "Button15";
		this.Button15.Size = new System.Drawing.Size(86, 24);
		this.Button15.TabIndex = 4;
		this.Button15.Text = "취소";
		this.Button15.UseVisualStyleBackColor = false;
		this.Label23.AutoSize = true;
		this.Label23.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label23.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.Label23.Location = new System.Drawing.Point(117, 54);
		this.Label23.Name = "Label23";
		this.Label23.Size = new System.Drawing.Size(133, 17);
		this.Label23.TabIndex = 3;
		this.Label23.Text = "학명집을 선택하세요.";
		this.Button16.BackColor = System.Drawing.Color.DarkGreen;
		this.Button16.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button16.BackgroundImage");
		this.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button16.ForeColor = System.Drawing.Color.White;
		this.Button16.Location = new System.Drawing.Point(99, 123);
		this.Button16.Name = "Button16";
		this.Button16.Size = new System.Drawing.Size(86, 24);
		this.Button16.TabIndex = 2;
		this.Button16.Text = "추가";
		this.Button16.UseVisualStyleBackColor = false;
		this.Label25.AutoSize = true;
		this.Label25.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label25.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label25.Location = new System.Drawing.Point(49, 20);
		this.Label25.Name = "Label25";
		this.Label25.Size = new System.Drawing.Size(279, 30);
		this.Label25.TabIndex = 0;
		this.Label25.Text = "기존 학명집에 데이터 추가";
		this.Panel57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel57.Controls.Add(this.Panel60);
		this.Panel57.Controls.Add(this.Panel58);
		this.Panel57.Controls.Add(this.Panel59);
		this.Panel57.Location = new System.Drawing.Point(392, 287);
		this.Panel57.Name = "Panel57";
		this.Panel57.Size = new System.Drawing.Size(516, 182);
		this.Panel57.TabIndex = 16;
		this.Panel57.Visible = false;
		this.Panel60.Controls.Add(this.TextBox11);
		this.Panel60.Controls.Add(this.Button50);
		this.Panel60.Location = new System.Drawing.Point(0, 48);
		this.Panel60.Name = "Panel60";
		this.Panel60.Size = new System.Drawing.Size(514, 53);
		this.Panel60.TabIndex = 10;
		this.TextBox11.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox11.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox11.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox11.Location = new System.Drawing.Point(44, 10);
		this.TextBox11.Name = "TextBox11";
		this.TextBox11.Size = new System.Drawing.Size(334, 27);
		this.TextBox11.TabIndex = 7;
		this.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Button50.BackColor = System.Drawing.Color.DarkGreen;
		this.Button50.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button50.BackgroundImage");
		this.Button50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button50.ForeColor = System.Drawing.Color.White;
		this.Button50.Location = new System.Drawing.Point(384, 10);
		this.Button50.Name = "Button50";
		this.Button50.Size = new System.Drawing.Size(88, 27);
		this.Button50.TabIndex = 6;
		this.Button50.Text = "검색";
		this.Button50.UseVisualStyleBackColor = false;
		this.Panel58.Controls.Add(this.Button51);
		this.Panel58.Controls.Add(this.Label10);
		this.Panel58.Controls.Add(this.Label5);
		this.Panel58.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel58.Location = new System.Drawing.Point(0, 0);
		this.Panel58.Name = "Panel58";
		this.Panel58.Size = new System.Drawing.Size(514, 48);
		this.Panel58.TabIndex = 8;
		this.Button51.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button51.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button51.BackgroundImage");
		this.Button51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button51.ForeColor = System.Drawing.Color.White;
		this.Button51.Location = new System.Drawing.Point(384, 23);
		this.Button51.Name = "Button51";
		this.Button51.Size = new System.Drawing.Size(88, 25);
		this.Button51.TabIndex = 8;
		this.Button51.Text = "닫기";
		this.Button51.UseVisualStyleBackColor = false;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label10.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label10.Location = new System.Drawing.Point(39, 19);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(57, 30);
		this.Label10.TabIndex = 0;
		this.Label10.Text = "검색";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("맑은 고딕", 9f);
		this.Label5.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.Label5.Location = new System.Drawing.Point(100, 28);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(265, 15);
		this.Label5.TabIndex = 3;
		this.Label5.Text = "다중 키워드 세미콜론(;) 구분, 범위 지정 물결(~)";
		this.Panel59.Controls.Add(this.ProgressBar2);
		this.Panel59.Controls.Add(this.txt_search);
		this.Panel59.Controls.Add(this.Button49);
		this.Panel59.Location = new System.Drawing.Point(-1, 103);
		this.Panel59.Name = "Panel59";
		this.Panel59.Size = new System.Drawing.Size(517, 83);
		this.Panel59.TabIndex = 9;
		this.Panel59.Visible = false;
		this.ProgressBar2.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
		this.ProgressBar2.ForeColor = System.Drawing.Color.FromArgb(184, 255, 48);
		this.ProgressBar2.Location = new System.Drawing.Point(47, 7);
		this.ProgressBar2.Name = "ProgressBar2";
		this.ProgressBar2.Size = new System.Drawing.Size(426, 19);
		this.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
		this.ProgressBar2.TabIndex = 6;
		this.ProgressBar2.Value = 50;
		this.txt_search.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.txt_search.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.txt_search.Location = new System.Drawing.Point(47, 34);
		this.txt_search.Name = "txt_search";
		this.txt_search.Size = new System.Drawing.Size(332, 24);
		this.txt_search.TabIndex = 7;
		this.txt_search.Text = "검색 중 입니다. 잠시만 기다려 주세요... (1/14452)";
		this.txt_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button49.BackColor = System.Drawing.Color.Red;
		this.Button49.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button49.BackgroundImage");
		this.Button49.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button49.ForeColor = System.Drawing.Color.White;
		this.Button49.Location = new System.Drawing.Point(387, 34);
		this.Button49.Name = "Button49";
		this.Button49.Size = new System.Drawing.Size(86, 24);
		this.Button49.TabIndex = 4;
		this.Button49.Text = "검색 취소";
		this.Button49.UseVisualStyleBackColor = false;
		this.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel7.Controls.Add(this.Button9);
		this.Panel7.Controls.Add(this.Label20);
		this.Panel7.Controls.Add(this.Button8);
		this.Panel7.Controls.Add(this.TextBox4);
		this.Panel7.Controls.Add(this.Label19);
		this.Panel7.Location = new System.Drawing.Point(499, 109);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new System.Drawing.Size(376, 165);
		this.Panel7.TabIndex = 3;
		this.Panel7.Visible = false;
		this.Button9.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button9.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button9.BackgroundImage");
		this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button9.ForeColor = System.Drawing.Color.White;
		this.Button9.Location = new System.Drawing.Point(191, 123);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(86, 24);
		this.Button9.TabIndex = 4;
		this.Button9.Text = "취소";
		this.Button9.UseVisualStyleBackColor = false;
		this.Label20.AutoSize = true;
		this.Label20.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label20.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.Label20.Location = new System.Drawing.Point(124, 54);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(120, 17);
		this.Label20.TabIndex = 3;
		this.Label20.Text = "이름을 입력하세요.";
		this.Button8.BackColor = System.Drawing.Color.DarkGreen;
		this.Button8.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button8.BackgroundImage");
		this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button8.ForeColor = System.Drawing.Color.White;
		this.Button8.Location = new System.Drawing.Point(99, 123);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(86, 24);
		this.Button8.TabIndex = 2;
		this.Button8.Text = "만들기";
		this.Button8.UseVisualStyleBackColor = false;
		this.TextBox4.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox4.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox4.Location = new System.Drawing.Point(55, 78);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(264, 27);
		this.TextBox4.TabIndex = 1;
		this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label19.AutoSize = true;
		this.Label19.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label19.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label19.Location = new System.Drawing.Point(112, 20);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(153, 30);
		this.Label19.TabIndex = 0;
		this.Label19.Text = "학명집 만들기";
		this.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox6.Font = new System.Drawing.Font("맑은 고딕", 12f);
		this.TextBox6.Location = new System.Drawing.Point(30, 63);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(116, 29);
		this.TextBox6.TabIndex = 6;
		this.TextBox6.Visible = false;
		this.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
		this.ListView1.AllowColumnReorder = true;
		this.ListView1.BackColor = System.Drawing.Color.White;
		this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListView1.CheckBoxes = true;
		this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListView1.ForeColor = System.Drawing.Color.Black;
		this.ListView1.FullRowSelect = true;
		this.ListView1.GridLines = true;
		this.ListView1.HideSelection = false;
		this.ListView1.Location = new System.Drawing.Point(23, 56);
		this.ListView1.Name = "ListView1";
		this.ListView1.ShowGroups = false;
		this.ListView1.Size = new System.Drawing.Size(822, 522);
		this.ListView1.TabIndex = 23;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ListView1.VirtualListSize = 500;
		this.Panel115.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel115.Location = new System.Drawing.Point(23, 578);
		this.Panel115.Name = "Panel115";
		this.Panel115.Size = new System.Drawing.Size(822, 23);
		this.Panel115.TabIndex = 25;
		this.Panel61.BackColor = System.Drawing.Color.Transparent;
		this.Panel61.Controls.Add(this.ProgressBar3);
		this.Panel61.Controls.Add(this.Label42);
		this.Panel61.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel61.Location = new System.Drawing.Point(23, 601);
		this.Panel61.Name = "Panel61";
		this.Panel61.Size = new System.Drawing.Size(822, 38);
		this.Panel61.TabIndex = 24;
		this.Panel61.Visible = false;
		this.ProgressBar3.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
		this.ProgressBar3.ForeColor = System.Drawing.Color.FromArgb(184, 255, 48);
		this.ProgressBar3.Location = new System.Drawing.Point(19, 10);
		this.ProgressBar3.Name = "ProgressBar3";
		this.ProgressBar3.Size = new System.Drawing.Size(519, 19);
		this.ProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
		this.ProgressBar3.TabIndex = 6;
		this.ProgressBar3.Value = 50;
		this.Label42.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label42.ForeColor = System.Drawing.Color.Red;
		this.Label42.Location = new System.Drawing.Point(544, 11);
		this.Label42.Name = "Label42";
		this.Label42.Size = new System.Drawing.Size(258, 17);
		this.Label42.TabIndex = 7;
		this.Label42.Text = "데이터베이스 백업 중...";
		this.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel25.Controls.Add(this.Label11);
		this.Panel25.Controls.Add(this.Panel56);
		this.Panel25.Controls.Add(this.Panel30);
		this.Panel25.Controls.Add(this.Label55);
		this.Panel25.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel25.Location = new System.Drawing.Point(23, 0);
		this.Panel25.Name = "Panel25";
		this.Panel25.Size = new System.Drawing.Size(822, 56);
		this.Panel25.TabIndex = 10;
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label11.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label11.Location = new System.Drawing.Point(0, 15);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(131, 30);
		this.Label11.TabIndex = 1;
		this.Label11.Text = "데이터 관리";
		this.Panel56.Controls.Add(this.Button46);
		this.Panel56.Controls.Add(this.Button45);
		this.Panel56.Controls.Add(this.btn_next);
		this.Panel56.Controls.Add(this.btn_prev);
		this.Panel56.Controls.Add(this.txt_page);
		this.Panel56.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel56.Location = new System.Drawing.Point(638, 0);
		this.Panel56.Name = "Panel56";
		this.Panel56.Size = new System.Drawing.Size(184, 56);
		this.Panel56.TabIndex = 6;
		this.Button46.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button46.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button46.BackgroundImage");
		this.Button46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button46.ForeColor = System.Drawing.Color.White;
		this.Button46.Location = new System.Drawing.Point(63, 15);
		this.Button46.Name = "Button46";
		this.Button46.Size = new System.Drawing.Size(31, 27);
		this.Button46.TabIndex = 6;
		this.Button46.Text = "<<";
		this.Button46.UseVisualStyleBackColor = false;
		this.Button45.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button45.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button45.BackgroundImage");
		this.Button45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button45.ForeColor = System.Drawing.Color.White;
		this.Button45.Location = new System.Drawing.Point(153, 15);
		this.Button45.Name = "Button45";
		this.Button45.Size = new System.Drawing.Size(31, 27);
		this.Button45.TabIndex = 5;
		this.Button45.Text = ">>";
		this.Button45.UseVisualStyleBackColor = false;
		this.btn_next.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.btn_next.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_next.BackgroundImage");
		this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_next.ForeColor = System.Drawing.Color.White;
		this.btn_next.Location = new System.Drawing.Point(125, 15);
		this.btn_next.Name = "btn_next";
		this.btn_next.Size = new System.Drawing.Size(25, 27);
		this.btn_next.TabIndex = 4;
		this.btn_next.Text = ">";
		this.btn_next.UseVisualStyleBackColor = false;
		this.btn_prev.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.btn_prev.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_prev.BackgroundImage");
		this.btn_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_prev.ForeColor = System.Drawing.Color.White;
		this.btn_prev.Location = new System.Drawing.Point(97, 15);
		this.btn_prev.Name = "btn_prev";
		this.btn_prev.Size = new System.Drawing.Size(25, 27);
		this.btn_prev.TabIndex = 3;
		this.btn_prev.Text = "<";
		this.btn_prev.UseVisualStyleBackColor = false;
		this.txt_page.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.txt_page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txt_page.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.txt_page.ForeColor = System.Drawing.Color.Black;
		this.txt_page.Location = new System.Drawing.Point(8, 14);
		this.txt_page.Name = "txt_page";
		this.txt_page.Size = new System.Drawing.Size(53, 29);
		this.txt_page.TabIndex = 2;
		this.txt_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Panel30.BackColor = System.Drawing.Color.Gray;
		this.Panel30.Location = new System.Drawing.Point(134, 41);
		this.Panel30.Name = "Panel30";
		this.Panel30.Size = new System.Drawing.Size(2000, 1);
		this.Panel30.TabIndex = 5;
		this.Label55.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label55.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label55.Location = new System.Drawing.Point(132, 15);
		this.Label55.Name = "Label55";
		this.Label55.Size = new System.Drawing.Size(595, 30);
		this.Label55.TabIndex = 4;
		this.Label55.Text = "서버에 등록된 모든 자료를 탐색 및 편집 할 수 있습니다.";
		this.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel24.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel24.Location = new System.Drawing.Point(845, 0);
		this.Panel24.Name = "Panel24";
		this.Panel24.Size = new System.Drawing.Size(23, 639);
		this.Panel24.TabIndex = 9;
		this.Panel23.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel23.Location = new System.Drawing.Point(0, 0);
		this.Panel23.Name = "Panel23";
		this.Panel23.Size = new System.Drawing.Size(23, 639);
		this.Panel23.TabIndex = 8;
		this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel6.Controls.Add(this.Button6);
		this.Panel6.Controls.Add(this.Button53);
		this.Panel6.Controls.Add(this.Button48);
		this.Panel6.Controls.Add(this.Button18);
		this.Panel6.Controls.Add(this.Button11);
		this.Panel6.Controls.Add(this.Button7);
		this.Panel6.Controls.Add(this.Button42);
		this.Panel6.Controls.Add(this.Button5);
		this.Panel6.Controls.Add(this.Button17);
		this.Panel6.Controls.Add(this.Button77);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel6.Location = new System.Drawing.Point(0, 639);
		this.Panel6.Name = "Panel6";
		this.Panel6.Padding = new System.Windows.Forms.Padding(4);
		this.Panel6.Size = new System.Drawing.Size(868, 44);
		this.Panel6.TabIndex = 2;
		this.Button6.BackColor = System.Drawing.Color.Red;
		this.Button6.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button6.BackgroundImage");
		this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button6.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button6.ForeColor = System.Drawing.Color.White;
		this.Button6.Location = new System.Drawing.Point(444, 4);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(80, 34);
		this.Button6.TabIndex = 1;
		this.Button6.Text = "선택 삭제";
		this.Button6.UseVisualStyleBackColor = false;
		this.Button53.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button53.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button53.BackgroundImage");
		this.Button53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button53.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button53.ForeColor = System.Drawing.Color.White;
		this.Button53.Location = new System.Drawing.Point(590, 4);
		this.Button53.Name = "Button53";
		this.Button53.Size = new System.Drawing.Size(68, 34);
		this.Button53.TabIndex = 7;
		this.Button53.Text = "백업";
		this.Button53.UseVisualStyleBackColor = false;
		this.Button48.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
		this.Button48.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button48.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button48.ForeColor = System.Drawing.Color.White;
		this.Button48.Location = new System.Drawing.Point(658, 4);
		this.Button48.Name = "Button48";
		this.Button48.Size = new System.Drawing.Size(68, 34);
		this.Button48.TabIndex = 6;
		this.Button48.Text = "검색";
		this.Button48.UseVisualStyleBackColor = false;
		this.Button18.BackColor = System.Drawing.Color.OliveDrab;
		this.Button18.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button18.BackgroundImage");
		this.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button18.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button18.ForeColor = System.Drawing.Color.White;
		this.Button18.Location = new System.Drawing.Point(726, 4);
		this.Button18.Name = "Button18";
		this.Button18.Size = new System.Drawing.Size(68, 34);
		this.Button18.TabIndex = 5;
		this.Button18.Text = "열 맞춤";
		this.Button18.UseVisualStyleBackColor = false;
		this.Button11.BackColor = System.Drawing.Color.DarkGreen;
		this.Button11.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button11.BackgroundImage");
		this.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button11.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button11.ForeColor = System.Drawing.Color.White;
		this.Button11.Location = new System.Drawing.Point(344, 4);
		this.Button11.Name = "Button11";
		this.Button11.Size = new System.Drawing.Size(100, 34);
		this.Button11.TabIndex = 3;
		this.Button11.Text = "선택 기존\r\n학명집에 추가";
		this.Button11.UseVisualStyleBackColor = false;
		this.Button7.BackColor = System.Drawing.Color.DarkGreen;
		this.Button7.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button7.BackgroundImage");
		this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button7.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button7.ForeColor = System.Drawing.Color.White;
		this.Button7.Location = new System.Drawing.Point(244, 4);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(100, 34);
		this.Button7.TabIndex = 2;
		this.Button7.Text = "선택 학명집\r\n만들기";
		this.Button7.UseVisualStyleBackColor = false;
		this.Button42.BackColor = System.Drawing.Color.DarkGreen;
		this.Button42.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button42.BackgroundImage");
		this.Button42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button42.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button42.ForeColor = System.Drawing.Color.White;
		this.Button42.Location = new System.Drawing.Point(164, 4);
		this.Button42.Name = "Button42";
		this.Button42.Size = new System.Drawing.Size(80, 34);
		this.Button42.TabIndex = 5;
		this.Button42.Text = "빈 데이터\r\n추가";
		this.Button42.UseVisualStyleBackColor = false;
		this.Button42.Visible = false;
		this.Button5.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button5.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button5.BackgroundImage");
		this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button5.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button5.ForeColor = System.Drawing.Color.White;
		this.Button5.Location = new System.Drawing.Point(84, 4);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(80, 34);
		this.Button5.TabIndex = 0;
		this.Button5.Text = "전체 선택";
		this.Button5.UseVisualStyleBackColor = false;
		this.Button17.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button17.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button17.BackgroundImage");
		this.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button17.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button17.ForeColor = System.Drawing.Color.White;
		this.Button17.Location = new System.Drawing.Point(794, 4);
		this.Button17.Name = "Button17";
		this.Button17.Size = new System.Drawing.Size(68, 34);
		this.Button17.TabIndex = 4;
		this.Button17.Text = "저장";
		this.Button17.UseVisualStyleBackColor = false;
		this.Button77.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button77.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button77.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button77.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button77.ForeColor = System.Drawing.Color.White;
		this.Button77.Location = new System.Drawing.Point(4, 4);
		this.Button77.Name = "Button77";
		this.Button77.Size = new System.Drawing.Size(80, 34);
		this.Button77.TabIndex = 8;
		this.Button77.Text = "새로고침";
		this.Button77.UseVisualStyleBackColor = false;
		this.p3.BackColor = System.Drawing.Color.Transparent;
		this.p3.Controls.Add(this.TextBox25);
		this.p3.Controls.Add(this.TextBox3);
		this.p3.Controls.Add(this.Panel5);
		this.p3.Controls.Add(this.Panel26);
		this.p3.Controls.Add(this.Panel11);
		this.p3.Controls.Add(this.Panel27);
		this.p3.Controls.Add(this.Panel28);
		this.p3.Controls.Add(this.DoubleBufferPanel3);
		this.p3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p3.Location = new System.Drawing.Point(0, 0);
		this.p3.Name = "p3";
		this.p3.Size = new System.Drawing.Size(868, 683);
		this.p3.TabIndex = 17;
		this.p3.Visible = false;
		this.TextBox25.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
		this.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox25.Font = new System.Drawing.Font("맑은 고딕", 12f);
		this.TextBox25.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.TextBox25.Location = new System.Drawing.Point(33, 226);
		this.TextBox25.Multiline = true;
		this.TextBox25.Name = "TextBox25";
		this.TextBox25.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.TextBox25.Size = new System.Drawing.Size(103, 36);
		this.TextBox25.TabIndex = 21;
		this.TextBox25.Visible = false;
		this.TextBox3.BackColor = System.Drawing.Color.White;
		this.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox3.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox3.Location = new System.Drawing.Point(23, 213);
		this.TextBox3.MaxLength = 0;
		this.TextBox3.Multiline = true;
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.TextBox3.Size = new System.Drawing.Size(822, 291);
		this.TextBox3.TabIndex = 15;
		this.TextBox3.WordWrap = false;
		this.Panel5.Controls.Add(this.Panel54);
		this.Panel5.Controls.Add(this.Panel53);
		this.Panel5.Controls.Add(this.CheckBox3);
		this.Panel5.Controls.Add(this.Button41);
		this.Panel5.Controls.Add(this.Button37);
		this.Panel5.Controls.Add(this.Label17);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(23, 56);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(822, 157);
		this.Panel5.TabIndex = 17;
		this.Panel54.Controls.Add(this.Label1);
		this.Panel54.Controls.Add(this.Button43);
		this.Panel54.Controls.Add(this.prog1);
		this.Panel54.Controls.Add(this.ProgressBar1);
		this.Panel54.Location = new System.Drawing.Point(8, 11);
		this.Panel54.Name = "Panel54";
		this.Panel54.Size = new System.Drawing.Size(10, 100);
		this.Panel54.TabIndex = 20;
		this.Panel54.Visible = false;
		this.Label1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(8, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(363, 20);
		this.Label1.TabIndex = 9;
		this.Label1.Text = "작업이 완료 될 때 까지 잠시만 기다려 주세요...";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button43.BackColor = System.Drawing.Color.Red;
		this.Button43.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button43.ForeColor = System.Drawing.Color.White;
		this.Button43.Location = new System.Drawing.Point(387, 33);
		this.Button43.Name = "Button43";
		this.Button43.Size = new System.Drawing.Size(86, 34);
		this.Button43.TabIndex = 8;
		this.Button43.Text = "취소";
		this.Button43.UseVisualStyleBackColor = false;
		this.prog1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.prog1.ForeColor = System.Drawing.Color.Black;
		this.prog1.Location = new System.Drawing.Point(8, 63);
		this.prog1.Name = "prog1";
		this.prog1.Size = new System.Drawing.Size(363, 20);
		this.prog1.TabIndex = 2;
		this.prog1.Text = "0/0";
		this.prog1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(184, 255, 48);
		this.ProgressBar1.Location = new System.Drawing.Point(8, 41);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(363, 16);
		this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
		this.ProgressBar1.TabIndex = 0;
		this.Panel53.Controls.Add(this.Label14);
		this.Panel53.Controls.Add(this.Button1);
		this.Panel53.Controls.Add(this.Label15);
		this.Panel53.Controls.Add(this.TextBox1);
		this.Panel53.Controls.Add(this.ComboBox1);
		this.Panel53.Controls.Add(this.Button2);
		this.Panel53.Controls.Add(this.Button3);
		this.Panel53.Location = new System.Drawing.Point(8, 11);
		this.Panel53.Name = "Panel53";
		this.Panel53.Size = new System.Drawing.Size(586, 100);
		this.Panel53.TabIndex = 21;
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label14.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label14.Location = new System.Drawing.Point(3, 8);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(207, 20);
		this.Label14.TabIndex = 0;
		this.Label14.Text = "1. 파일 열기 (XLSX, CSV, TXT)";
		this.Button1.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button1.BackgroundImage");
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(357, 35);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(77, 26);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "찾기";
		this.Button1.UseVisualStyleBackColor = false;
		this.Label15.AutoSize = true;
		this.Label15.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label15.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label15.Location = new System.Drawing.Point(13, 72);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(99, 17);
		this.Label15.TabIndex = 4;
		this.Label15.Text = "XLSX 시트 선택";
		this.TextBox1.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox1.Location = new System.Drawing.Point(7, 36);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.Size = new System.Drawing.Size(342, 23);
		this.TextBox1.TabIndex = 1;
		this.ComboBox1.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox1.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(124, 68);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(225, 24);
		this.ComboBox1.TabIndex = 3;
		this.Button2.BackColor = System.Drawing.Color.Green;
		this.Button2.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = System.Drawing.Color.White;
		this.Button2.Location = new System.Drawing.Point(357, 68);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(149, 26);
		this.Button2.TabIndex = 5;
		this.Button2.Text = "변환 시작";
		this.Button2.UseVisualStyleBackColor = false;
		this.Button3.BackColor = System.Drawing.Color.Maroon;
		this.Button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button3.BackgroundImage");
		this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.ForeColor = System.Drawing.Color.White;
		this.Button3.Location = new System.Drawing.Point(437, 35);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(69, 26);
		this.Button3.TabIndex = 7;
		this.Button3.Text = "초기화";
		this.Button3.UseVisualStyleBackColor = false;
		this.CheckBox3.AutoSize = true;
		this.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CheckBox3.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.CheckBox3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.CheckBox3.Location = new System.Drawing.Point(443, 130);
		this.CheckBox3.Name = "CheckBox3";
		this.CheckBox3.Size = new System.Drawing.Size(99, 21);
		this.CheckBox3.TabIndex = 19;
		this.CheckBox3.Text = "자동 줄 바꿈";
		this.CheckBox3.UseVisualStyleBackColor = true;
		this.Button41.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button41.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button41.BackgroundImage");
		this.Button41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button41.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button41.ForeColor = System.Drawing.Color.White;
		this.Button41.Location = new System.Drawing.Point(306, 128);
		this.Button41.Name = "Button41";
		this.Button41.Size = new System.Drawing.Size(129, 24);
		this.Button41.TabIndex = 18;
		this.Button41.Text = "구분 문자 삽입 (뒤)";
		this.Button41.UseVisualStyleBackColor = false;
		this.Button37.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button37.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button37.BackgroundImage");
		this.Button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button37.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button37.ForeColor = System.Drawing.Color.White;
		this.Button37.Location = new System.Drawing.Point(172, 128);
		this.Button37.Name = "Button37";
		this.Button37.Size = new System.Drawing.Size(129, 24);
		this.Button37.TabIndex = 17;
		this.Button37.Text = "구분 문자 삽입 (앞)";
		this.Button37.UseVisualStyleBackColor = false;
		this.Label17.AutoSize = true;
		this.Label17.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label17.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label17.Location = new System.Drawing.Point(14, 129);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(145, 20);
		this.Label17.TabIndex = 16;
		this.Label17.Text = "2. 직접 입력 및 편집";
		this.Panel26.Controls.Add(this.Panel55);
		this.Panel26.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel26.Location = new System.Drawing.Point(23, 0);
		this.Panel26.Name = "Panel26";
		this.Panel26.Size = new System.Drawing.Size(822, 56);
		this.Panel26.TabIndex = 21;
		this.Panel55.Controls.Add(this.Label12);
		this.Panel55.Controls.Add(this.Panel29);
		this.Panel55.Controls.Add(this.Label13);
		this.Panel55.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel55.Location = new System.Drawing.Point(0, 0);
		this.Panel55.Name = "Panel55";
		this.Panel55.Size = new System.Drawing.Size(822, 56);
		this.Panel55.TabIndex = 4;
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label12.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label12.Location = new System.Drawing.Point(0, 15);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(131, 30);
		this.Label12.TabIndex = 1;
		this.Label12.Text = "데이터 추가";
		this.Panel29.BackColor = System.Drawing.Color.Gray;
		this.Panel29.Location = new System.Drawing.Point(135, 41);
		this.Panel29.Name = "Panel29";
		this.Panel29.Size = new System.Drawing.Size(2000, 1);
		this.Panel29.TabIndex = 3;
		this.Label13.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label13.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label13.Location = new System.Drawing.Point(133, 15);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(768, 30);
		this.Label13.TabIndex = 2;
		this.Label13.Text = "문서 파일을 이용하여 데이터를 입력하거나, 직접 작성하여 추가 할 수 있습니다.";
		this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel11.Controls.Add(this.ComboBox2);
		this.Panel11.Controls.Add(this.TextBox2);
		this.Panel11.Controls.Add(this.Button58);
		this.Panel11.Controls.Add(this.Label16);
		this.Panel11.Controls.Add(this.RadioButton1);
		this.Panel11.Controls.Add(this.RadioButton2);
		this.Panel11.Controls.Add(this.RadioButton3);
		this.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel11.Location = new System.Drawing.Point(23, 504);
		this.Panel11.Name = "Panel11";
		this.Panel11.Size = new System.Drawing.Size(822, 135);
		this.Panel11.TabIndex = 18;
		this.ComboBox2.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox2.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.Location = new System.Drawing.Point(328, 62);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(297, 28);
		this.ComboBox2.TabIndex = 13;
		this.TextBox2.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
		this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox2.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox2.Location = new System.Drawing.Point(16, 62);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(297, 27);
		this.TextBox2.TabIndex = 12;
		this.Button58.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button58.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button58.ForeColor = System.Drawing.Color.White;
		this.Button58.Location = new System.Drawing.Point(631, 62);
		this.Button58.Name = "Button58";
		this.Button58.Size = new System.Drawing.Size(86, 27);
		this.Button58.TabIndex = 18;
		this.Button58.Text = "새로고침";
		this.Button58.UseVisualStyleBackColor = false;
		this.Label16.AutoSize = true;
		this.Label16.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label16.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label16.Location = new System.Drawing.Point(12, 12);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(175, 20);
		this.Label16.TabIndex = 8;
		this.Label16.Text = "3. 데이터 처리 방식 선택";
		this.RadioButton1.AutoSize = true;
		this.RadioButton1.Cursor = System.Windows.Forms.Cursors.Default;
		this.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.RadioButton1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.RadioButton1.Location = new System.Drawing.Point(16, 41);
		this.RadioButton1.Name = "RadioButton1";
		this.RadioButton1.Size = new System.Drawing.Size(175, 21);
		this.RadioButton1.TabIndex = 9;
		this.RadioButton1.TabStop = true;
		this.RadioButton1.Text = "저장 후 새 학명집에 넣기";
		this.RadioButton1.UseVisualStyleBackColor = true;
		this.RadioButton2.AutoSize = true;
		this.RadioButton2.Cursor = System.Windows.Forms.Cursors.Default;
		this.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.RadioButton2.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.RadioButton2.Location = new System.Drawing.Point(328, 41);
		this.RadioButton2.Name = "RadioButton2";
		this.RadioButton2.Size = new System.Drawing.Size(188, 21);
		this.RadioButton2.TabIndex = 10;
		this.RadioButton2.TabStop = true;
		this.RadioButton2.Text = "저장 후 기존 학명집에 추가";
		this.RadioButton2.UseVisualStyleBackColor = true;
		this.RadioButton3.AutoSize = true;
		this.RadioButton3.Checked = true;
		this.RadioButton3.Cursor = System.Windows.Forms.Cursors.Default;
		this.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.RadioButton3.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.RadioButton3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.RadioButton3.Location = new System.Drawing.Point(16, 98);
		this.RadioButton3.Name = "RadioButton3";
		this.RadioButton3.Size = new System.Drawing.Size(152, 21);
		this.RadioButton3.TabIndex = 11;
		this.RadioButton3.TabStop = true;
		this.RadioButton3.Text = "데이터를 저장만 하기";
		this.RadioButton3.UseVisualStyleBackColor = true;
		this.Panel27.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel27.Location = new System.Drawing.Point(845, 0);
		this.Panel27.Name = "Panel27";
		this.Panel27.Size = new System.Drawing.Size(23, 639);
		this.Panel27.TabIndex = 20;
		this.Panel28.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel28.Location = new System.Drawing.Point(0, 0);
		this.Panel28.Name = "Panel28";
		this.Panel28.Size = new System.Drawing.Size(23, 639);
		this.Panel28.TabIndex = 19;
		this.DoubleBufferPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel3.Controls.Add(this.Button44);
		this.DoubleBufferPanel3.Controls.Add(this.Button47);
		this.DoubleBufferPanel3.Controls.Add(this.Button4);
		this.DoubleBufferPanel3.Controls.Add(this.Label4);
		this.DoubleBufferPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel3.Location = new System.Drawing.Point(0, 639);
		this.DoubleBufferPanel3.Name = "DoubleBufferPanel3";
		this.DoubleBufferPanel3.Padding = new System.Windows.Forms.Padding(5);
		this.DoubleBufferPanel3.Size = new System.Drawing.Size(868, 44);
		this.DoubleBufferPanel3.TabIndex = 38;
		this.Button44.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button44.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button44.ForeColor = System.Drawing.Color.White;
		this.Button44.Location = new System.Drawing.Point(599, 8);
		this.Button44.Name = "Button44";
		this.Button44.Size = new System.Drawing.Size(101, 22);
		this.Button44.TabIndex = 16;
		this.Button44.Text = "log";
		this.Button44.UseVisualStyleBackColor = false;
		this.Button44.Visible = false;
		this.Button47.BackColor = System.Drawing.Color.Red;
		this.Button47.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button47.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button47.ForeColor = System.Drawing.Color.White;
		this.Button47.Location = new System.Drawing.Point(447, 5);
		this.Button47.Name = "Button47";
		this.Button47.Size = new System.Drawing.Size(146, 32);
		this.Button47.TabIndex = 17;
		this.Button47.Text = "업로드 취소";
		this.Button47.UseVisualStyleBackColor = false;
		this.Button47.Visible = false;
		this.Button4.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button4.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button4.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button4.ForeColor = System.Drawing.Color.White;
		this.Button4.Location = new System.Drawing.Point(301, 5);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(146, 32);
		this.Button4.TabIndex = 14;
		this.Button4.Text = "데이터 업로드 시작";
		this.Button4.UseVisualStyleBackColor = false;
		this.Label4.BackColor = System.Drawing.Color.White;
		this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.Label4.Dock = System.Windows.Forms.DockStyle.Left;
		this.Label4.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label4.ForeColor = System.Drawing.Color.Black;
		this.Label4.Location = new System.Drawing.Point(5, 5);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(296, 32);
		this.Label4.TabIndex = 15;
		this.Label4.Text = "0/0";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label4.Visible = false;
		this.p4.BackColor = System.Drawing.Color.Transparent;
		this.p4.Controls.Add(this.Panel52);
		this.p4.Controls.Add(this.ListBox7);
		this.p4.Controls.Add(this.Label24);
		this.p4.Controls.Add(this.Panel50);
		this.p4.Controls.Add(this.ListView2);
		this.p4.Controls.Add(this.Panel9);
		this.p4.Controls.Add(this.Panel31);
		this.p4.Controls.Add(this.Panel33);
		this.p4.Controls.Add(this.Panel34);
		this.p4.Controls.Add(this.Panel8);
		this.p4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p4.Location = new System.Drawing.Point(0, 0);
		this.p4.Name = "p4";
		this.p4.Size = new System.Drawing.Size(868, 683);
		this.p4.TabIndex = 18;
		this.p4.Visible = false;
		this.Panel52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel52.Controls.Add(this.Button38);
		this.Panel52.Controls.Add(this.Label37);
		this.Panel52.Controls.Add(this.Button39);
		this.Panel52.Controls.Add(this.TextBox10);
		this.Panel52.Controls.Add(this.Label38);
		this.Panel52.Location = new System.Drawing.Point(188, 207);
		this.Panel52.Name = "Panel52";
		this.Panel52.Size = new System.Drawing.Size(376, 165);
		this.Panel52.TabIndex = 16;
		this.Panel52.Visible = false;
		this.Button38.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button38.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button38.BackgroundImage");
		this.Button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button38.ForeColor = System.Drawing.Color.White;
		this.Button38.Location = new System.Drawing.Point(191, 123);
		this.Button38.Name = "Button38";
		this.Button38.Size = new System.Drawing.Size(86, 24);
		this.Button38.TabIndex = 4;
		this.Button38.Text = "취소";
		this.Button38.UseVisualStyleBackColor = false;
		this.Label37.AutoSize = true;
		this.Label37.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label37.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.Label37.Location = new System.Drawing.Point(124, 54);
		this.Label37.Name = "Label37";
		this.Label37.Size = new System.Drawing.Size(120, 17);
		this.Label37.TabIndex = 3;
		this.Label37.Text = "이름을 입력하세요.";
		this.Button39.BackColor = System.Drawing.Color.DarkGreen;
		this.Button39.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button39.BackgroundImage");
		this.Button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button39.ForeColor = System.Drawing.Color.White;
		this.Button39.Location = new System.Drawing.Point(99, 123);
		this.Button39.Name = "Button39";
		this.Button39.Size = new System.Drawing.Size(86, 24);
		this.Button39.TabIndex = 2;
		this.Button39.Text = "만들기";
		this.Button39.UseVisualStyleBackColor = false;
		this.TextBox10.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox10.Font = new System.Drawing.Font("맑은 고딕", 14f);
		this.TextBox10.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox10.Location = new System.Drawing.Point(55, 78);
		this.TextBox10.Name = "TextBox10";
		this.TextBox10.Size = new System.Drawing.Size(264, 32);
		this.TextBox10.TabIndex = 1;
		this.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label38.AutoSize = true;
		this.Label38.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label38.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label38.Location = new System.Drawing.Point(112, 20);
		this.Label38.Name = "Label38";
		this.Label38.Size = new System.Drawing.Size(153, 30);
		this.Label38.TabIndex = 0;
		this.Label38.Text = "학명집 만들기";
		this.ListBox7.BackColor = System.Drawing.Color.White;
		this.ListBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListBox7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListBox7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ListBox7.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox7.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListBox7.FormattingEnabled = true;
		this.ListBox7.ItemHeight = 20;
		this.ListBox7.Location = new System.Drawing.Point(23, 172);
		this.ListBox7.Name = "ListBox7";
		this.ListBox7.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
		this.ListBox7.Size = new System.Drawing.Size(822, 449);
		this.ListBox7.TabIndex = 28;
		this.Label24.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label24.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label24.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label24.Location = new System.Drawing.Point(23, 143);
		this.Label24.Name = "Label24";
		this.Label24.Size = new System.Drawing.Size(822, 29);
		this.Label24.TabIndex = 46;
		this.Label24.Text = "포함된 데이터";
		this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel50.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel50.Location = new System.Drawing.Point(23, 621);
		this.Panel50.Name = "Panel50";
		this.Panel50.Size = new System.Drawing.Size(822, 18);
		this.Panel50.TabIndex = 45;
		this.ListView2.Activation = System.Windows.Forms.ItemActivation.OneClick;
		this.ListView2.AllowColumnReorder = true;
		this.ListView2.BackColor = System.Drawing.Color.White;
		this.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListView2.CheckBoxes = true;
		this.ListView2.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListView2.ForeColor = System.Drawing.Color.Black;
		this.ListView2.FullRowSelect = true;
		this.ListView2.GridLines = true;
		this.ListView2.Location = new System.Drawing.Point(24, 188);
		this.ListView2.Name = "ListView2";
		this.ListView2.ShowGroups = false;
		this.ListView2.Size = new System.Drawing.Size(131, 106);
		this.ListView2.TabIndex = 23;
		this.ListView2.UseCompatibleStateImageBehavior = false;
		this.ListView2.View = System.Windows.Forms.View.Details;
		this.ListView2.Visible = false;
		this.Panel9.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel9.Controls.Add(this.Button10);
		this.Panel9.Controls.Add(this.CheckBox1);
		this.Panel9.Controls.Add(this.Label21);
		this.Panel9.Controls.Add(this.ComboBox3);
		this.Panel9.Controls.Add(this.Label22);
		this.Panel9.Controls.Add(this.TextBox5);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel9.Location = new System.Drawing.Point(23, 56);
		this.Panel9.Name = "Panel9";
		this.Panel9.Size = new System.Drawing.Size(822, 87);
		this.Panel9.TabIndex = 22;
		this.Button10.BackColor = System.Drawing.Color.Red;
		this.Button10.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button10.BackgroundImage");
		this.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button10.Font = new System.Drawing.Font("굴림", 9f);
		this.Button10.ForeColor = System.Drawing.Color.White;
		this.Button10.Location = new System.Drawing.Point(666, 15);
		this.Button10.Name = "Button10";
		this.Button10.Size = new System.Drawing.Size(115, 26);
		this.Button10.TabIndex = 15;
		this.Button10.Text = "삭제";
		this.Button10.UseVisualStyleBackColor = false;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Checked = true;
		this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
		this.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CheckBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.CheckBox1.Location = new System.Drawing.Point(666, 49);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(112, 21);
		this.CheckBox1.TabIndex = 22;
		this.CheckBox1.Text = "이 학명집 표시";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.Label21.AutoSize = true;
		this.Label21.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label21.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label21.Location = new System.Drawing.Point(48, 18);
		this.Label21.Name = "Label21";
		this.Label21.Size = new System.Drawing.Size(84, 19);
		this.Label21.TabIndex = 1;
		this.Label21.Text = "학명집 선택";
		this.ComboBox3.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox3.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox3.FormattingEnabled = true;
		this.ComboBox3.Location = new System.Drawing.Point(142, 15);
		this.ComboBox3.Name = "ComboBox3";
		this.ComboBox3.Size = new System.Drawing.Size(518, 26);
		this.ComboBox3.TabIndex = 14;
		this.Label22.AutoSize = true;
		this.Label22.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label22.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label22.Location = new System.Drawing.Point(62, 49);
		this.Label22.Name = "Label22";
		this.Label22.Size = new System.Drawing.Size(70, 19);
		this.Label22.TabIndex = 16;
		this.Label22.Text = "이름 변경";
		this.TextBox5.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox5.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox5.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox5.Location = new System.Drawing.Point(142, 47);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(518, 25);
		this.TextBox5.TabIndex = 17;
		this.Panel31.Controls.Add(this.Panel32);
		this.Panel31.Controls.Add(this.Label56);
		this.Panel31.Controls.Add(this.Label57);
		this.Panel31.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel31.Location = new System.Drawing.Point(23, 0);
		this.Panel31.Name = "Panel31";
		this.Panel31.Size = new System.Drawing.Size(822, 56);
		this.Panel31.TabIndex = 27;
		this.Panel32.BackColor = System.Drawing.Color.Gray;
		this.Panel32.Location = new System.Drawing.Point(134, 41);
		this.Panel32.Name = "Panel32";
		this.Panel32.Size = new System.Drawing.Size(2000, 1);
		this.Panel32.TabIndex = 3;
		this.Label56.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label56.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label56.Location = new System.Drawing.Point(132, 15);
		this.Label56.Name = "Label56";
		this.Label56.Size = new System.Drawing.Size(595, 30);
		this.Label56.TabIndex = 2;
		this.Label56.Text = "데이터베이스를 참조하는 학명집을 관리할 수 있습니다.";
		this.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label57.AutoSize = true;
		this.Label57.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label57.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label57.Location = new System.Drawing.Point(0, 15);
		this.Label57.Name = "Label57";
		this.Label57.Size = new System.Drawing.Size(131, 30);
		this.Label57.TabIndex = 1;
		this.Label57.Text = "학명집 관리";
		this.Panel33.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel33.Location = new System.Drawing.Point(845, 0);
		this.Panel33.Name = "Panel33";
		this.Panel33.Size = new System.Drawing.Size(23, 639);
		this.Panel33.TabIndex = 26;
		this.Panel34.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel34.Location = new System.Drawing.Point(0, 0);
		this.Panel34.Name = "Panel34";
		this.Panel34.Size = new System.Drawing.Size(23, 639);
		this.Panel34.TabIndex = 25;
		this.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel8.Controls.Add(this.Button54);
		this.Panel8.Controls.Add(this.Button13);
		this.Panel8.Controls.Add(this.Button40);
		this.Panel8.Controls.Add(this.Button12);
		this.Panel8.Controls.Add(this.Button14);
		this.Panel8.Controls.Add(this.Button19);
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel8.Location = new System.Drawing.Point(0, 639);
		this.Panel8.Name = "Panel8";
		this.Panel8.Padding = new System.Windows.Forms.Padding(5);
		this.Panel8.Size = new System.Drawing.Size(868, 44);
		this.Panel8.TabIndex = 24;
		this.Button54.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button54.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button54.BackgroundImage");
		this.Button54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button54.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button54.ForeColor = System.Drawing.Color.White;
		this.Button54.Location = new System.Drawing.Point(337, 5);
		this.Button54.Name = "Button54";
		this.Button54.Size = new System.Drawing.Size(61, 32);
		this.Button54.TabIndex = 17;
		this.Button54.Text = "정리";
		this.Button54.UseVisualStyleBackColor = false;
		this.Button13.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button13.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button13.BackgroundImage");
		this.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button13.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button13.Font = new System.Drawing.Font("굴림", 9f);
		this.Button13.ForeColor = System.Drawing.Color.White;
		this.Button13.Location = new System.Drawing.Point(793, 5);
		this.Button13.Name = "Button13";
		this.Button13.Size = new System.Drawing.Size(68, 32);
		this.Button13.TabIndex = 0;
		this.Button13.Text = "저장";
		this.Button13.UseVisualStyleBackColor = false;
		this.Button40.BackColor = System.Drawing.Color.DarkGreen;
		this.Button40.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button40.BackgroundImage");
		this.Button40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button40.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button40.ForeColor = System.Drawing.Color.White;
		this.Button40.Location = new System.Drawing.Point(255, 5);
		this.Button40.Name = "Button40";
		this.Button40.Size = new System.Drawing.Size(82, 32);
		this.Button40.TabIndex = 16;
		this.Button40.Text = "새 학명집";
		this.Button40.UseVisualStyleBackColor = false;
		this.Button12.BackColor = System.Drawing.Color.Red;
		this.Button12.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button12.BackgroundImage");
		this.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button12.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button12.Font = new System.Drawing.Font("굴림", 9f);
		this.Button12.ForeColor = System.Drawing.Color.White;
		this.Button12.Location = new System.Drawing.Point(170, 5);
		this.Button12.Name = "Button12";
		this.Button12.Size = new System.Drawing.Size(85, 32);
		this.Button12.TabIndex = 1;
		this.Button12.Text = "선택 삭제";
		this.Button12.UseVisualStyleBackColor = false;
		this.Button14.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button14.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button14.BackgroundImage");
		this.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button14.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button14.Font = new System.Drawing.Font("굴림", 9f);
		this.Button14.ForeColor = System.Drawing.Color.White;
		this.Button14.Location = new System.Drawing.Point(85, 5);
		this.Button14.Name = "Button14";
		this.Button14.Size = new System.Drawing.Size(85, 32);
		this.Button14.TabIndex = 0;
		this.Button14.Text = "전체 선택";
		this.Button14.UseVisualStyleBackColor = false;
		this.Button19.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button19.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button19.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button19.ForeColor = System.Drawing.Color.White;
		this.Button19.Location = new System.Drawing.Point(5, 5);
		this.Button19.Name = "Button19";
		this.Button19.Size = new System.Drawing.Size(80, 32);
		this.Button19.TabIndex = 18;
		this.Button19.Text = "새로고침";
		this.Button19.UseVisualStyleBackColor = false;
		this.p7.BackColor = System.Drawing.Color.Transparent;
		this.p7.Controls.Add(this.Panel13);
		this.p7.Controls.Add(this.TableLayoutPanel1);
		this.p7.Controls.Add(this.Panel51);
		this.p7.Controls.Add(this.Panel22);
		this.p7.Controls.Add(this.Panel19);
		this.p7.Controls.Add(this.Panel21);
		this.p7.Controls.Add(this.Panel35);
		this.p7.Controls.Add(this.Panel12);
		this.p7.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p7.Location = new System.Drawing.Point(0, 0);
		this.p7.Name = "p7";
		this.p7.Size = new System.Drawing.Size(868, 683);
		this.p7.TabIndex = 19;
		this.p7.Visible = false;
		this.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel13.Controls.Add(this.Button25);
		this.Panel13.Controls.Add(this.Label28);
		this.Panel13.Controls.Add(this.Button26);
		this.Panel13.Controls.Add(this.Label29);
		this.Panel13.Controls.Add(this.TextBox7);
		this.Panel13.Location = new System.Drawing.Point(10, 405);
		this.Panel13.Name = "Panel13";
		this.Panel13.Size = new System.Drawing.Size(338, 169);
		this.Panel13.TabIndex = 10;
		this.Panel13.Visible = false;
		this.Button25.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button25.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button25.BackgroundImage");
		this.Button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button25.ForeColor = System.Drawing.Color.White;
		this.Button25.Location = new System.Drawing.Point(171, 122);
		this.Button25.Name = "Button25";
		this.Button25.Size = new System.Drawing.Size(86, 24);
		this.Button25.TabIndex = 4;
		this.Button25.Text = "취소";
		this.Button25.UseVisualStyleBackColor = false;
		this.Label28.AutoSize = true;
		this.Label28.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.Label28.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.Label28.Location = new System.Drawing.Point(87, 51);
		this.Label28.Name = "Label28";
		this.Label28.Size = new System.Drawing.Size(162, 19);
		this.Label28.TabIndex = 3;
		this.Label28.Text = "폴더 이름을 입력하세요.";
		this.Button26.BackColor = System.Drawing.Color.DarkGreen;
		this.Button26.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button26.BackgroundImage");
		this.Button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button26.ForeColor = System.Drawing.Color.White;
		this.Button26.Location = new System.Drawing.Point(79, 122);
		this.Button26.Name = "Button26";
		this.Button26.Size = new System.Drawing.Size(86, 24);
		this.Button26.TabIndex = 2;
		this.Button26.Text = "만들기";
		this.Button26.UseVisualStyleBackColor = false;
		this.Label29.AutoSize = true;
		this.Label29.Font = new System.Drawing.Font("맑은 고딕", 14f, System.Drawing.FontStyle.Bold);
		this.Label29.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label29.Location = new System.Drawing.Point(98, 21);
		this.Label29.Name = "Label29";
		this.Label29.Size = new System.Drawing.Size(140, 25);
		this.Label29.TabIndex = 0;
		this.Label29.Text = "새 폴더 만들기";
		this.TextBox7.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox7.Font = new System.Drawing.Font("맑은 고딕", 12f);
		this.TextBox7.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox7.Location = new System.Drawing.Point(36, 81);
		this.TextBox7.Name = "TextBox7";
		this.TextBox7.Size = new System.Drawing.Size(264, 29);
		this.TextBox7.TabIndex = 16;
		this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TableLayoutPanel1.ColumnCount = 3;
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80f));
		this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001f));
		this.TableLayoutPanel1.Controls.Add(this.Panel2, 2, 2);
		this.TableLayoutPanel1.Controls.Add(this.ListBox2, 0, 1);
		this.TableLayoutPanel1.Controls.Add(this.Label26, 0, 0);
		this.TableLayoutPanel1.Controls.Add(this.Button22, 1, 1);
		this.TableLayoutPanel1.Controls.Add(this.ListBox3, 2, 1);
		this.TableLayoutPanel1.Controls.Add(this.Label27, 2, 0);
		this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TableLayoutPanel1.Location = new System.Drawing.Point(23, 145);
		this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
		this.TableLayoutPanel1.Name = "TableLayoutPanel1";
		this.TableLayoutPanel1.RowCount = 3;
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882351f));
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.11765f));
		this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25f));
		this.TableLayoutPanel1.Size = new System.Drawing.Size(822, 476);
		this.TableLayoutPanel1.TabIndex = 13;
		this.Panel2.Controls.Add(this.Button125);
		this.Panel2.Controls.Add(this.Button28);
		this.Panel2.Controls.Add(this.Button27);
		this.Panel2.Controls.Add(this.Button23);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel2.Location = new System.Drawing.Point(450, 450);
		this.Panel2.Margin = new System.Windows.Forms.Padding(0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(372, 26);
		this.Panel2.TabIndex = 3;
		this.Button125.BackColor = System.Drawing.Color.Black;
		this.Button125.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button125.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button125.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button125.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button125.ForeColor = System.Drawing.Color.White;
		this.Button125.Location = new System.Drawing.Point(128, 0);
		this.Button125.Name = "Button125";
		this.Button125.Size = new System.Drawing.Size(71, 26);
		this.Button125.TabIndex = 67;
		this.Button125.Text = "바로가기";
		this.Button125.UseVisualStyleBackColor = false;
		this.Button28.BackColor = System.Drawing.Color.FromArgb(192, 192, 0);
		this.Button28.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button28.BackgroundImage");
		this.Button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button28.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button28.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button28.ForeColor = System.Drawing.Color.White;
		this.Button28.Location = new System.Drawing.Point(64, 0);
		this.Button28.Name = "Button28";
		this.Button28.Size = new System.Drawing.Size(64, 26);
		this.Button28.TabIndex = 13;
		this.Button28.Text = "아래로";
		this.Button28.UseVisualStyleBackColor = false;
		this.Button27.BackColor = System.Drawing.Color.FromArgb(192, 192, 0);
		this.Button27.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button27.BackgroundImage");
		this.Button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button27.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button27.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button27.ForeColor = System.Drawing.Color.White;
		this.Button27.Location = new System.Drawing.Point(0, 0);
		this.Button27.Name = "Button27";
		this.Button27.Size = new System.Drawing.Size(64, 26);
		this.Button27.TabIndex = 11;
		this.Button27.Text = "위로";
		this.Button27.UseVisualStyleBackColor = false;
		this.Button23.BackColor = System.Drawing.Color.Maroon;
		this.Button23.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button23.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button23.ForeColor = System.Drawing.Color.White;
		this.Button23.Location = new System.Drawing.Point(291, 0);
		this.Button23.Name = "Button23";
		this.Button23.Size = new System.Drawing.Size(81, 26);
		this.Button23.TabIndex = 9;
		this.Button23.Text = "선택 제거";
		this.Button23.UseVisualStyleBackColor = false;
		this.ListBox2.BackColor = System.Drawing.Color.White;
		this.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ListBox2.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.ListBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListBox2.FormattingEnabled = true;
		this.ListBox2.ItemHeight = 21;
		this.ListBox2.Location = new System.Drawing.Point(3, 29);
		this.ListBox2.Name = "ListBox2";
		this.ListBox2.Size = new System.Drawing.Size(364, 418);
		this.ListBox2.TabIndex = 4;
		this.Label26.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label26.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label26.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label26.Location = new System.Drawing.Point(3, 0);
		this.Label26.Name = "Label26";
		this.Label26.Size = new System.Drawing.Size(364, 26);
		this.Label26.TabIndex = 5;
		this.Label26.Text = "전체 학명집";
		this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Button22.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button22.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button22.Font = new System.Drawing.Font("굴림", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Button22.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button22.Image = mlas_root.My.Resources.Resources.arrow_forward_icon;
		this.Button22.Location = new System.Drawing.Point(373, 29);
		this.Button22.Name = "Button22";
		this.Button22.Size = new System.Drawing.Size(74, 418);
		this.Button22.TabIndex = 8;
		this.Button22.UseVisualStyleBackColor = false;
		this.ListBox3.BackColor = System.Drawing.Color.White;
		this.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListBox3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ListBox3.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.ListBox3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListBox3.FormattingEnabled = true;
		this.ListBox3.ItemHeight = 21;
		this.ListBox3.Location = new System.Drawing.Point(453, 29);
		this.ListBox3.Name = "ListBox3";
		this.ListBox3.Size = new System.Drawing.Size(366, 418);
		this.ListBox3.TabIndex = 7;
		this.Label27.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label27.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label27.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label27.Location = new System.Drawing.Point(453, 0);
		this.Label27.Name = "Label27";
		this.Label27.Size = new System.Drawing.Size(366, 26);
		this.Label27.TabIndex = 6;
		this.Label27.Text = "폴더에 포함된 학명집";
		this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Panel51.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel51.Location = new System.Drawing.Point(23, 621);
		this.Panel51.Name = "Panel51";
		this.Panel51.Size = new System.Drawing.Size(822, 18);
		this.Panel51.TabIndex = 45;
		this.Panel22.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel22.Controls.Add(this.CheckBox2);
		this.Panel22.Controls.Add(this.Button24);
		this.Panel22.Controls.Add(this.Label18);
		this.Panel22.Controls.Add(this.ComboBox5);
		this.Panel22.Controls.Add(this.TextBox8);
		this.Panel22.Controls.Add(this.Label30);
		this.Panel22.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel22.Location = new System.Drawing.Point(23, 56);
		this.Panel22.Name = "Panel22";
		this.Panel22.Size = new System.Drawing.Size(822, 89);
		this.Panel22.TabIndex = 32;
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.Checked = true;
		this.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
		this.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CheckBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.CheckBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.CheckBox2.Location = new System.Drawing.Point(684, 50);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(99, 21);
		this.CheckBox2.TabIndex = 23;
		this.CheckBox2.Text = "이 폴더 표시";
		this.CheckBox2.UseVisualStyleBackColor = true;
		this.Button24.BackColor = System.Drawing.Color.Red;
		this.Button24.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button24.ForeColor = System.Drawing.Color.White;
		this.Button24.Location = new System.Drawing.Point(683, 15);
		this.Button24.Name = "Button24";
		this.Button24.Size = new System.Drawing.Size(103, 26);
		this.Button24.TabIndex = 2;
		this.Button24.Text = "삭제";
		this.Button24.UseVisualStyleBackColor = false;
		this.Label18.AutoSize = true;
		this.Label18.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label18.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label18.Location = new System.Drawing.Point(39, 17);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(70, 19);
		this.Label18.TabIndex = 2;
		this.Label18.Text = "폴더 선택";
		this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.ComboBox5.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox5.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox5.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox5.FormattingEnabled = true;
		this.ComboBox5.Location = new System.Drawing.Point(115, 15);
		this.ComboBox5.Name = "ComboBox5";
		this.ComboBox5.Size = new System.Drawing.Size(563, 26);
		this.ComboBox5.TabIndex = 3;
		this.TextBox8.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox8.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox8.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox8.Location = new System.Drawing.Point(115, 47);
		this.TextBox8.Name = "TextBox8";
		this.TextBox8.Size = new System.Drawing.Size(563, 25);
		this.TextBox8.TabIndex = 17;
		this.Label30.AutoSize = true;
		this.Label30.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label30.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label30.Location = new System.Drawing.Point(39, 49);
		this.Label30.Name = "Label30";
		this.Label30.Size = new System.Drawing.Size(70, 19);
		this.Label30.TabIndex = 15;
		this.Label30.Text = "이름 변경";
		this.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel19.Controls.Add(this.Panel20);
		this.Panel19.Controls.Add(this.Label58);
		this.Panel19.Controls.Add(this.Label59);
		this.Panel19.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel19.Location = new System.Drawing.Point(23, 0);
		this.Panel19.Name = "Panel19";
		this.Panel19.Size = new System.Drawing.Size(822, 56);
		this.Panel19.TabIndex = 31;
		this.Panel20.BackColor = System.Drawing.Color.Gray;
		this.Panel20.Location = new System.Drawing.Point(113, 41);
		this.Panel20.Name = "Panel20";
		this.Panel20.Size = new System.Drawing.Size(2000, 1);
		this.Panel20.TabIndex = 3;
		this.Label58.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label58.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label58.Location = new System.Drawing.Point(111, 15);
		this.Label58.Name = "Label58";
		this.Label58.Size = new System.Drawing.Size(595, 30);
		this.Label58.TabIndex = 2;
		this.Label58.Text = "학명집을 참조하는 폴더를 관리 할 수 있습니다.";
		this.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label59.AutoSize = true;
		this.Label59.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label59.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label59.Location = new System.Drawing.Point(0, 15);
		this.Label59.Name = "Label59";
		this.Label59.Size = new System.Drawing.Size(109, 30);
		this.Label59.TabIndex = 1;
		this.Label59.Text = "폴더 관리";
		this.Panel21.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel21.Location = new System.Drawing.Point(845, 0);
		this.Panel21.Name = "Panel21";
		this.Panel21.Size = new System.Drawing.Size(23, 639);
		this.Panel21.TabIndex = 30;
		this.Panel35.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel35.Location = new System.Drawing.Point(0, 0);
		this.Panel35.Name = "Panel35";
		this.Panel35.Size = new System.Drawing.Size(23, 639);
		this.Panel35.TabIndex = 29;
		this.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel12.Controls.Add(this.Button20);
		this.Panel12.Controls.Add(this.Button21);
		this.Panel12.Controls.Add(this.Button52);
		this.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel12.Location = new System.Drawing.Point(0, 639);
		this.Panel12.Name = "Panel12";
		this.Panel12.Padding = new System.Windows.Forms.Padding(5);
		this.Panel12.Size = new System.Drawing.Size(868, 44);
		this.Panel12.TabIndex = 0;
		this.Button20.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button20.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button20.BackgroundImage");
		this.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button20.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button20.ForeColor = System.Drawing.Color.White;
		this.Button20.Location = new System.Drawing.Point(793, 5);
		this.Button20.Name = "Button20";
		this.Button20.Size = new System.Drawing.Size(68, 32);
		this.Button20.TabIndex = 0;
		this.Button20.Text = "저장";
		this.Button20.UseVisualStyleBackColor = false;
		this.Button21.BackColor = System.Drawing.Color.DarkGreen;
		this.Button21.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button21.BackgroundImage");
		this.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button21.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button21.ForeColor = System.Drawing.Color.White;
		this.Button21.Location = new System.Drawing.Point(85, 5);
		this.Button21.Name = "Button21";
		this.Button21.Size = new System.Drawing.Size(80, 32);
		this.Button21.TabIndex = 1;
		this.Button21.Text = "새 폴더";
		this.Button21.UseVisualStyleBackColor = false;
		this.Button52.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button52.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button52.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button52.ForeColor = System.Drawing.Color.White;
		this.Button52.Location = new System.Drawing.Point(5, 5);
		this.Button52.Name = "Button52";
		this.Button52.Size = new System.Drawing.Size(80, 32);
		this.Button52.TabIndex = 9;
		this.Button52.Text = "새로고침";
		this.Button52.UseVisualStyleBackColor = false;
		this.p5.BackColor = System.Drawing.Color.Transparent;
		this.p5.Controls.Add(this.TableLayoutPanel2);
		this.p5.Controls.Add(this.Panel14);
		this.p5.Controls.Add(this.Panel16);
		this.p5.Controls.Add(this.Panel37);
		this.p5.Controls.Add(this.Panel36);
		this.p5.Controls.Add(this.DoubleBufferPanel2);
		this.p5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p5.Location = new System.Drawing.Point(0, 0);
		this.p5.Name = "p5";
		this.p5.Size = new System.Drawing.Size(868, 683);
		this.p5.TabIndex = 20;
		this.p5.Visible = false;
		this.TableLayoutPanel2.ColumnCount = 3;
		this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10f));
		this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400f));
		this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90f));
		this.TableLayoutPanel2.Controls.Add(this.Panel39, 1, 0);
		this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TableLayoutPanel2.Location = new System.Drawing.Point(23, 56);
		this.TableLayoutPanel2.Name = "TableLayoutPanel2";
		this.TableLayoutPanel2.RowCount = 1;
		this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
		this.TableLayoutPanel2.Size = new System.Drawing.Size(822, 556);
		this.TableLayoutPanel2.TabIndex = 36;
		this.Panel39.Controls.Add(this.ListBox4);
		this.Panel39.Controls.Add(this.Button29);
		this.Panel39.Controls.Add(this.Panel38);
		this.Panel39.Controls.Add(this.TextBox9);
		this.Panel39.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel39.Location = new System.Drawing.Point(45, 3);
		this.Panel39.Name = "Panel39";
		this.Panel39.Size = new System.Drawing.Size(394, 550);
		this.Panel39.TabIndex = 0;
		this.ListBox4.BackColor = System.Drawing.Color.White;
		this.ListBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListBox4.Dock = System.Windows.Forms.DockStyle.Left;
		this.ListBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ListBox4.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListBox4.FormattingEnabled = true;
		this.ListBox4.ItemHeight = 21;
		this.ListBox4.Location = new System.Drawing.Point(0, 37);
		this.ListBox4.Name = "ListBox4";
		this.ListBox4.Size = new System.Drawing.Size(193, 513);
		this.ListBox4.TabIndex = 5;
		this.Button29.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button29.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button29.ForeColor = System.Drawing.Color.White;
		this.Button29.Location = new System.Drawing.Point(201, 81);
		this.Button29.Name = "Button29";
		this.Button29.Size = new System.Drawing.Size(185, 24);
		this.Button29.TabIndex = 11;
		this.Button29.Text = "변경";
		this.Button29.UseVisualStyleBackColor = false;
		this.Panel38.Controls.Add(this.Label31);
		this.Panel38.Controls.Add(this.Label32);
		this.Panel38.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel38.Location = new System.Drawing.Point(0, 0);
		this.Panel38.Name = "Panel38";
		this.Panel38.Size = new System.Drawing.Size(394, 37);
		this.Panel38.TabIndex = 35;
		this.Label31.AutoSize = true;
		this.Label31.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label31.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label31.Location = new System.Drawing.Point(37, 11);
		this.Label31.Name = "Label31";
		this.Label31.Size = new System.Drawing.Size(129, 21);
		this.Label31.TabIndex = 0;
		this.Label31.Text = "DATA COLUMN";
		this.Label32.AutoSize = true;
		this.Label32.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label32.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label32.Location = new System.Drawing.Point(245, 11);
		this.Label32.Name = "Label32";
		this.Label32.Size = new System.Drawing.Size(96, 21);
		this.Label32.TabIndex = 9;
		this.Label32.Text = "컬럼명 변경";
		this.TextBox9.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox9.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox9.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox9.Location = new System.Drawing.Point(201, 49);
		this.TextBox9.Name = "TextBox9";
		this.TextBox9.Size = new System.Drawing.Size(185, 27);
		this.TextBox9.TabIndex = 10;
		this.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Panel14.Controls.Add(this.Panel15);
		this.Panel14.Controls.Add(this.Label60);
		this.Panel14.Controls.Add(this.Label61);
		this.Panel14.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel14.Location = new System.Drawing.Point(23, 0);
		this.Panel14.Name = "Panel14";
		this.Panel14.Size = new System.Drawing.Size(822, 56);
		this.Panel14.TabIndex = 34;
		this.Panel15.BackColor = System.Drawing.Color.Gray;
		this.Panel15.Location = new System.Drawing.Point(113, 41);
		this.Panel15.Name = "Panel15";
		this.Panel15.Size = new System.Drawing.Size(2000, 1);
		this.Panel15.TabIndex = 3;
		this.Label60.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label60.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label60.Location = new System.Drawing.Point(111, 15);
		this.Label60.Name = "Label60";
		this.Label60.Size = new System.Drawing.Size(595, 30);
		this.Label60.TabIndex = 2;
		this.Label60.Text = "데이터베이스 컬럼의 이름을 변경 할 수 있습니다.";
		this.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label61.AutoSize = true;
		this.Label61.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label61.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label61.Location = new System.Drawing.Point(0, 15);
		this.Label61.Name = "Label61";
		this.Label61.Size = new System.Drawing.Size(109, 30);
		this.Label61.TabIndex = 1;
		this.Label61.Text = "컬럼 관리";
		this.Panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel16.Location = new System.Drawing.Point(23, 612);
		this.Panel16.Name = "Panel16";
		this.Panel16.Size = new System.Drawing.Size(822, 27);
		this.Panel16.TabIndex = 8;
		this.Panel37.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel37.Location = new System.Drawing.Point(0, 0);
		this.Panel37.Name = "Panel37";
		this.Panel37.Size = new System.Drawing.Size(23, 639);
		this.Panel37.TabIndex = 32;
		this.Panel36.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel36.Location = new System.Drawing.Point(845, 0);
		this.Panel36.Name = "Panel36";
		this.Panel36.Size = new System.Drawing.Size(23, 639);
		this.Panel36.TabIndex = 33;
		this.DoubleBufferPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel2.Controls.Add(this.Button60);
		this.DoubleBufferPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel2.Location = new System.Drawing.Point(0, 639);
		this.DoubleBufferPanel2.Name = "DoubleBufferPanel2";
		this.DoubleBufferPanel2.Padding = new System.Windows.Forms.Padding(5);
		this.DoubleBufferPanel2.Size = new System.Drawing.Size(868, 44);
		this.DoubleBufferPanel2.TabIndex = 37;
		this.Button60.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button60.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button60.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button60.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button60.ForeColor = System.Drawing.Color.White;
		this.Button60.Location = new System.Drawing.Point(5, 5);
		this.Button60.Name = "Button60";
		this.Button60.Size = new System.Drawing.Size(80, 32);
		this.Button60.TabIndex = 9;
		this.Button60.Text = "새로고침";
		this.Button60.UseVisualStyleBackColor = false;
		this.p6.BackColor = System.Drawing.Color.Transparent;
		this.p6.Controls.Add(this.Panel40);
		this.p6.Controls.Add(this.Panel42);
		this.p6.Controls.Add(this.Panel43);
		this.p6.Controls.Add(this.Panel44);
		this.p6.Controls.Add(this.TableLayoutPanel3);
		this.p6.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p6.Location = new System.Drawing.Point(0, 0);
		this.p6.Name = "p6";
		this.p6.Size = new System.Drawing.Size(868, 683);
		this.p6.TabIndex = 21;
		this.p6.Visible = false;
		this.Panel40.Controls.Add(this.Panel41);
		this.Panel40.Controls.Add(this.Label62);
		this.Panel40.Controls.Add(this.Label63);
		this.Panel40.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel40.Location = new System.Drawing.Point(23, 0);
		this.Panel40.Name = "Panel40";
		this.Panel40.Size = new System.Drawing.Size(822, 56);
		this.Panel40.TabIndex = 37;
		this.Panel41.BackColor = System.Drawing.Color.Gray;
		this.Panel41.Location = new System.Drawing.Point(90, 41);
		this.Panel41.Name = "Panel41";
		this.Panel41.Size = new System.Drawing.Size(2000, 1);
		this.Panel41.TabIndex = 3;
		this.Label62.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label62.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label62.Location = new System.Drawing.Point(88, 15);
		this.Label62.Name = "Label62";
		this.Label62.Size = new System.Drawing.Size(595, 30);
		this.Label62.TabIndex = 2;
		this.Label62.Text = "안드로이드 앱 화면에 표시될 데이터 형식을 변경 할 수 있습니다.";
		this.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label63.AutoSize = true;
		this.Label63.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label63.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label63.Location = new System.Drawing.Point(0, 15);
		this.Label63.Name = "Label63";
		this.Label63.Size = new System.Drawing.Size(87, 30);
		this.Label63.TabIndex = 1;
		this.Label63.Text = "뷰 관리";
		this.Panel42.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel42.Location = new System.Drawing.Point(0, 0);
		this.Panel42.Name = "Panel42";
		this.Panel42.Size = new System.Drawing.Size(23, 639);
		this.Panel42.TabIndex = 35;
		this.Panel43.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel43.Location = new System.Drawing.Point(845, 0);
		this.Panel43.Name = "Panel43";
		this.Panel43.Size = new System.Drawing.Size(23, 639);
		this.Panel43.TabIndex = 36;
		this.Panel44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel44.Controls.Add(this.Button55);
		this.Panel44.Controls.Add(this.Button36);
		this.Panel44.Controls.Add(this.Button33);
		this.Panel44.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel44.Location = new System.Drawing.Point(0, 639);
		this.Panel44.Name = "Panel44";
		this.Panel44.Padding = new System.Windows.Forms.Padding(5);
		this.Panel44.Size = new System.Drawing.Size(868, 44);
		this.Panel44.TabIndex = 38;
		this.Button55.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button55.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button55.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button55.ForeColor = System.Drawing.Color.White;
		this.Button55.Location = new System.Drawing.Point(98, 5);
		this.Button55.Name = "Button55";
		this.Button55.Size = new System.Drawing.Size(80, 32);
		this.Button55.TabIndex = 15;
		this.Button55.Text = "새로고침";
		this.Button55.UseVisualStyleBackColor = false;
		this.Button36.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button36.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button36.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button36.Location = new System.Drawing.Point(5, 5);
		this.Button36.Name = "Button36";
		this.Button36.Size = new System.Drawing.Size(93, 32);
		this.Button36.TabIndex = 14;
		this.Button36.Text = "미리보기";
		this.Button36.UseVisualStyleBackColor = false;
		this.Button36.Visible = false;
		this.Button33.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button33.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button33.BackgroundImage");
		this.Button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button33.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button33.ForeColor = System.Drawing.Color.White;
		this.Button33.Location = new System.Drawing.Point(793, 5);
		this.Button33.Name = "Button33";
		this.Button33.Size = new System.Drawing.Size(68, 32);
		this.Button33.TabIndex = 13;
		this.Button33.Text = "저장";
		this.Button33.UseVisualStyleBackColor = false;
		this.TableLayoutPanel3.ColumnCount = 3;
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 537f));
		this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel3.Controls.Add(this.Panel18, 1, 1);
		this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
		this.TableLayoutPanel3.Name = "TableLayoutPanel3";
		this.TableLayoutPanel3.RowCount = 3;
		this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 560f));
		this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel3.Size = new System.Drawing.Size(868, 683);
		this.TableLayoutPanel3.TabIndex = 40;
		this.Panel18.Controls.Add(this.Label33);
		this.Panel18.Controls.Add(this.Button30);
		this.Panel18.Controls.Add(this.Button34);
		this.Panel18.Controls.Add(this.ListBox5);
		this.Panel18.Controls.Add(this.Label36);
		this.Panel18.Controls.Add(this.ListBox6);
		this.Panel18.Controls.Add(this.Button32);
		this.Panel18.Controls.Add(this.Button31);
		this.Panel18.Controls.Add(this.Panel17);
		this.Panel18.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel18.Location = new System.Drawing.Point(168, 64);
		this.Panel18.Name = "Panel18";
		this.Panel18.Size = new System.Drawing.Size(531, 554);
		this.Panel18.TabIndex = 0;
		this.Label33.BackColor = System.Drawing.Color.DarkGreen;
		this.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label33.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label33.ForeColor = System.Drawing.Color.White;
		this.Label33.Location = new System.Drawing.Point(262, 375);
		this.Label33.Name = "Label33";
		this.Label33.Size = new System.Drawing.Size(180, 24);
		this.Label33.TabIndex = 39;
		this.Label33.Text = "다수 컬럼";
		this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Button30.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button30.Font = new System.Drawing.Font("굴림", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Button30.ForeColor = System.Drawing.Color.White;
		this.Button30.Image = mlas_root.My.Resources.Resources.arrow_forward_icon;
		this.Button30.Location = new System.Drawing.Point(215, 399);
		this.Button30.Name = "Button30";
		this.Button30.Size = new System.Drawing.Size(45, 128);
		this.Button30.TabIndex = 8;
		this.Button30.UseVisualStyleBackColor = false;
		this.Button34.BackColor = System.Drawing.Color.Red;
		this.Button34.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button34.BackgroundImage");
		this.Button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button34.ForeColor = System.Drawing.Color.White;
		this.Button34.Location = new System.Drawing.Point(444, 443);
		this.Button34.Name = "Button34";
		this.Button34.Size = new System.Drawing.Size(64, 24);
		this.Button34.TabIndex = 21;
		this.Button34.Text = "제거";
		this.Button34.UseVisualStyleBackColor = false;
		this.ListBox5.BackColor = System.Drawing.Color.White;
		this.ListBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ListBox5.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox5.ForeColor = System.Drawing.Color.Black;
		this.ListBox5.FormattingEnabled = true;
		this.ListBox5.ItemHeight = 21;
		this.ListBox5.Location = new System.Drawing.Point(33, 399);
		this.ListBox5.Name = "ListBox5";
		this.ListBox5.Size = new System.Drawing.Size(180, 128);
		this.ListBox5.TabIndex = 6;
		this.Label36.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.Label36.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label36.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label36.Location = new System.Drawing.Point(43, 378);
		this.Label36.Name = "Label36";
		this.Label36.Size = new System.Drawing.Size(161, 21);
		this.Label36.TabIndex = 11;
		this.Label36.Text = "컬럼 참조 추가";
		this.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ListBox6.BackColor = System.Drawing.Color.White;
		this.ListBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ListBox6.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox6.ForeColor = System.Drawing.Color.Black;
		this.ListBox6.FormattingEnabled = true;
		this.ListBox6.ItemHeight = 21;
		this.ListBox6.Location = new System.Drawing.Point(262, 399);
		this.ListBox6.Name = "ListBox6";
		this.ListBox6.Size = new System.Drawing.Size(180, 128);
		this.ListBox6.TabIndex = 7;
		this.Button32.BackColor = System.Drawing.Color.FromArgb(192, 192, 0);
		this.Button32.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button32.BackgroundImage");
		this.Button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button32.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button32.ForeColor = System.Drawing.Color.White;
		this.Button32.Location = new System.Drawing.Point(444, 421);
		this.Button32.Name = "Button32";
		this.Button32.Size = new System.Drawing.Size(64, 24);
		this.Button32.TabIndex = 10;
		this.Button32.Text = "아래로";
		this.Button32.UseVisualStyleBackColor = false;
		this.Button31.BackColor = System.Drawing.Color.FromArgb(192, 192, 0);
		this.Button31.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button31.BackgroundImage");
		this.Button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button31.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button31.ForeColor = System.Drawing.Color.White;
		this.Button31.Location = new System.Drawing.Point(444, 399);
		this.Button31.Name = "Button31";
		this.Button31.Size = new System.Drawing.Size(64, 24);
		this.Button31.TabIndex = 9;
		this.Button31.Text = "위로";
		this.Button31.UseVisualStyleBackColor = false;
		this.Panel17.BackColor = System.Drawing.Color.White;
		this.Panel17.BackgroundImage = mlas_root.My.Resources.Resources.main;
		this.Panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel17.Controls.Add(this.Label45);
		this.Panel17.Controls.Add(this.ComboBox6);
		this.Panel17.Controls.Add(this.ComboBox7);
		this.Panel17.Controls.Add(this.ComboBox8);
		this.Panel17.Controls.Add(this.ComboBox9);
		this.Panel17.Controls.Add(this.ComboBox10);
		this.Panel17.Controls.Add(this.ComboBox11);
		this.Panel17.Controls.Add(this.ComboBox12);
		this.Panel17.Location = new System.Drawing.Point(29, 7);
		this.Panel17.Name = "Panel17";
		this.Panel17.Size = new System.Drawing.Size(479, 352);
		this.Panel17.TabIndex = 0;
		this.Label45.BackColor = System.Drawing.Color.DarkGreen;
		this.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label45.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label45.ForeColor = System.Drawing.Color.White;
		this.Label45.Location = new System.Drawing.Point(17, 169);
		this.Label45.Name = "Label45";
		this.Label45.Size = new System.Drawing.Size(369, 34);
		this.Label45.TabIndex = 5;
		this.Label45.Text = "다수 컬럼";
		this.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ComboBox6.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox6.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox6.ForeColor = System.Drawing.Color.Black;
		this.ComboBox6.FormattingEnabled = true;
		this.ComboBox6.Location = new System.Drawing.Point(44, 101);
		this.ComboBox6.Name = "ComboBox6";
		this.ComboBox6.Size = new System.Drawing.Size(342, 28);
		this.ComboBox6.TabIndex = 4;
		this.ComboBox7.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox7.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox7.ForeColor = System.Drawing.Color.Black;
		this.ComboBox7.FormattingEnabled = true;
		this.ComboBox7.Location = new System.Drawing.Point(17, 135);
		this.ComboBox7.Name = "ComboBox7";
		this.ComboBox7.Size = new System.Drawing.Size(180, 28);
		this.ComboBox7.TabIndex = 15;
		this.ComboBox8.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox8.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox8.ForeColor = System.Drawing.Color.Black;
		this.ComboBox8.FormattingEnabled = true;
		this.ComboBox8.Location = new System.Drawing.Point(206, 135);
		this.ComboBox8.Name = "ComboBox8";
		this.ComboBox8.Size = new System.Drawing.Size(180, 28);
		this.ComboBox8.TabIndex = 17;
		this.ComboBox9.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox9.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox9.ForeColor = System.Drawing.Color.Black;
		this.ComboBox9.FormattingEnabled = true;
		this.ComboBox9.Location = new System.Drawing.Point(17, 208);
		this.ComboBox9.Name = "ComboBox9";
		this.ComboBox9.Size = new System.Drawing.Size(369, 28);
		this.ComboBox9.TabIndex = 24;
		this.ComboBox10.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox10.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox10.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox10.ForeColor = System.Drawing.Color.Black;
		this.ComboBox10.FormattingEnabled = true;
		this.ComboBox10.Location = new System.Drawing.Point(17, 242);
		this.ComboBox10.Name = "ComboBox10";
		this.ComboBox10.Size = new System.Drawing.Size(369, 28);
		this.ComboBox10.TabIndex = 22;
		this.ComboBox11.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox11.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox11.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox11.ForeColor = System.Drawing.Color.Black;
		this.ComboBox11.FormattingEnabled = true;
		this.ComboBox11.Location = new System.Drawing.Point(17, 276);
		this.ComboBox11.Name = "ComboBox11";
		this.ComboBox11.Size = new System.Drawing.Size(369, 28);
		this.ComboBox11.TabIndex = 28;
		this.ComboBox12.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox12.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox12.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox12.ForeColor = System.Drawing.Color.Black;
		this.ComboBox12.FormattingEnabled = true;
		this.ComboBox12.Location = new System.Drawing.Point(17, 310);
		this.ComboBox12.Name = "ComboBox12";
		this.ComboBox12.Size = new System.Drawing.Size(369, 28);
		this.ComboBox12.TabIndex = 26;
		this.p8.BackColor = System.Drawing.Color.Transparent;
		this.p8.Controls.Add(this.DoubleBufferPanel1);
		this.p8.Controls.Add(this.Panel45);
		this.p8.Controls.Add(this.Panel47);
		this.p8.Controls.Add(this.Panel48);
		this.p8.Controls.Add(this.Panel49);
		this.p8.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p8.Location = new System.Drawing.Point(0, 0);
		this.p8.Name = "p8";
		this.p8.Size = new System.Drawing.Size(868, 683);
		this.p8.TabIndex = 22;
		this.p8.Visible = false;
		this.DoubleBufferPanel1.BackColor = System.Drawing.Color.Transparent;
		this.DoubleBufferPanel1.Controls.Add(this.ComboBox13);
		this.DoubleBufferPanel1.Controls.Add(this.Label53);
		this.DoubleBufferPanel1.Controls.Add(this.Label54);
		this.DoubleBufferPanel1.Controls.Add(this.ComboBox14);
		this.DoubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel1.Location = new System.Drawing.Point(23, 56);
		this.DoubleBufferPanel1.Name = "DoubleBufferPanel1";
		this.DoubleBufferPanel1.Size = new System.Drawing.Size(822, 100);
		this.DoubleBufferPanel1.TabIndex = 43;
		this.ComboBox13.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox13.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox13.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox13.ForeColor = System.Drawing.Color.Black;
		this.ComboBox13.FormattingEnabled = true;
		this.ComboBox13.Location = new System.Drawing.Point(138, 19);
		this.ComboBox13.Name = "ComboBox13";
		this.ComboBox13.Size = new System.Drawing.Size(636, 26);
		this.ComboBox13.TabIndex = 5;
		this.Label53.AutoSize = true;
		this.Label53.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label53.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label53.Location = new System.Drawing.Point(36, 22);
		this.Label53.Name = "Label53";
		this.Label53.Size = new System.Drawing.Size(98, 19);
		this.Label53.TabIndex = 1;
		this.Label53.Text = "국가표준 검색";
		this.Label54.AutoSize = true;
		this.Label54.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label54.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label54.Location = new System.Drawing.Point(52, 54);
		this.Label54.Name = "Label54";
		this.Label54.Size = new System.Drawing.Size(84, 19);
		this.Label54.TabIndex = 2;
		this.Label54.Text = "수험용 검색";
		this.ComboBox14.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox14.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox14.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox14.ForeColor = System.Drawing.Color.Black;
		this.ComboBox14.FormattingEnabled = true;
		this.ComboBox14.Location = new System.Drawing.Point(138, 51);
		this.ComboBox14.Name = "ComboBox14";
		this.ComboBox14.Size = new System.Drawing.Size(636, 26);
		this.ComboBox14.TabIndex = 6;
		this.Panel45.Controls.Add(this.Panel46);
		this.Panel45.Controls.Add(this.Label34);
		this.Panel45.Controls.Add(this.Label35);
		this.Panel45.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel45.Location = new System.Drawing.Point(23, 0);
		this.Panel45.Name = "Panel45";
		this.Panel45.Size = new System.Drawing.Size(822, 56);
		this.Panel45.TabIndex = 41;
		this.Panel46.BackColor = System.Drawing.Color.Gray;
		this.Panel46.Location = new System.Drawing.Point(113, 41);
		this.Panel46.Name = "Panel46";
		this.Panel46.Size = new System.Drawing.Size(2000, 1);
		this.Panel46.TabIndex = 3;
		this.Label34.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label34.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label34.Location = new System.Drawing.Point(111, 15);
		this.Label34.Name = "Label34";
		this.Label34.Size = new System.Drawing.Size(595, 30);
		this.Label34.TabIndex = 2;
		this.Label34.Text = "검색에 활용할 학명집을 선택 할 수 있습니다.";
		this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label35.AutoSize = true;
		this.Label35.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label35.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label35.Location = new System.Drawing.Point(0, 15);
		this.Label35.Name = "Label35";
		this.Label35.Size = new System.Drawing.Size(109, 30);
		this.Label35.TabIndex = 1;
		this.Label35.Text = "검색 관리";
		this.Panel47.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel47.Location = new System.Drawing.Point(0, 0);
		this.Panel47.Name = "Panel47";
		this.Panel47.Size = new System.Drawing.Size(23, 639);
		this.Panel47.TabIndex = 39;
		this.Panel48.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel48.Location = new System.Drawing.Point(845, 0);
		this.Panel48.Name = "Panel48";
		this.Panel48.Size = new System.Drawing.Size(23, 639);
		this.Panel48.TabIndex = 40;
		this.Panel49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel49.Controls.Add(this.Button56);
		this.Panel49.Controls.Add(this.Button35);
		this.Panel49.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel49.Location = new System.Drawing.Point(0, 639);
		this.Panel49.Name = "Panel49";
		this.Panel49.Padding = new System.Windows.Forms.Padding(5);
		this.Panel49.Size = new System.Drawing.Size(868, 44);
		this.Panel49.TabIndex = 42;
		this.Button56.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button56.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button56.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button56.ForeColor = System.Drawing.Color.White;
		this.Button56.Location = new System.Drawing.Point(5, 5);
		this.Button56.Name = "Button56";
		this.Button56.Size = new System.Drawing.Size(80, 32);
		this.Button56.TabIndex = 9;
		this.Button56.Text = "새로고침";
		this.Button56.UseVisualStyleBackColor = false;
		this.Button35.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button35.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button35.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button35.ForeColor = System.Drawing.Color.White;
		this.Button35.Location = new System.Drawing.Point(793, 5);
		this.Button35.Name = "Button35";
		this.Button35.Size = new System.Drawing.Size(68, 32);
		this.Button35.TabIndex = 7;
		this.Button35.Text = "저장";
		this.Button35.UseVisualStyleBackColor = false;
		this.p10.BackColor = System.Drawing.Color.Transparent;
		this.p10.Controls.Add(this.TextBox22);
		this.p10.Controls.Add(this.Panel1);
		this.p10.Controls.Add(this.Panel109);
		this.p10.Controls.Add(this.Panel112);
		this.p10.Controls.Add(this.Panel117);
		this.p10.Controls.Add(this.Panel118);
		this.p10.Controls.Add(this.Panel103);
		this.p10.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p10.Location = new System.Drawing.Point(0, 0);
		this.p10.Name = "p10";
		this.p10.Size = new System.Drawing.Size(868, 683);
		this.p10.TabIndex = 23;
		this.TextBox22.BackColor = System.Drawing.Color.White;
		this.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox22.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox22.Font = new System.Drawing.Font("굴림", 10f);
		this.TextBox22.ForeColor = System.Drawing.Color.Black;
		this.TextBox22.Location = new System.Drawing.Point(23, 173);
		this.TextBox22.MaxLength = 0;
		this.TextBox22.Multiline = true;
		this.TextBox22.Name = "TextBox22";
		this.TextBox22.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.TextBox22.Size = new System.Drawing.Size(822, 448);
		this.TextBox22.TabIndex = 15;
		this.TextBox22.WordWrap = false;
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(23, 621);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(822, 18);
		this.Panel1.TabIndex = 44;
		this.Panel109.Controls.Add(this.TextBox23);
		this.Panel109.Controls.Add(this.Label84);
		this.Panel109.Controls.Add(this.Label85);
		this.Panel109.Controls.Add(this.Button79);
		this.Panel109.Controls.Add(this.Label86);
		this.Panel109.Controls.Add(this.ComboBox16);
		this.Panel109.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel109.Location = new System.Drawing.Point(23, 56);
		this.Panel109.Name = "Panel109";
		this.Panel109.Size = new System.Drawing.Size(822, 117);
		this.Panel109.TabIndex = 17;
		this.TextBox23.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox23.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox23.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox23.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox23.Location = new System.Drawing.Point(114, 50);
		this.TextBox23.Name = "TextBox23";
		this.TextBox23.Size = new System.Drawing.Size(563, 25);
		this.TextBox23.TabIndex = 46;
		this.Label84.AutoSize = true;
		this.Label84.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label84.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label84.Location = new System.Drawing.Point(70, 52);
		this.Label84.Name = "Label84";
		this.Label84.Size = new System.Drawing.Size(37, 19);
		this.Label84.TabIndex = 17;
		this.Label84.Text = "제목";
		this.Label85.AutoSize = true;
		this.Label85.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label85.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label85.Location = new System.Drawing.Point(6, 93);
		this.Label85.Name = "Label85";
		this.Label85.Size = new System.Drawing.Size(251, 19);
		this.Label85.TabIndex = 16;
		this.Label85.Text = "본문 (HTML 코드로 작성 가능합니다.)";
		this.Button79.BackColor = System.Drawing.Color.Red;
		this.Button79.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button79.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button79.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button79.ForeColor = System.Drawing.Color.White;
		this.Button79.Location = new System.Drawing.Point(683, 18);
		this.Button79.Name = "Button79";
		this.Button79.Size = new System.Drawing.Size(82, 26);
		this.Button79.TabIndex = 7;
		this.Button79.Text = "삭제";
		this.Button79.UseVisualStyleBackColor = false;
		this.Label86.AutoSize = true;
		this.Label86.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label86.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label86.Location = new System.Drawing.Point(23, 21);
		this.Label86.Name = "Label86";
		this.Label86.Size = new System.Drawing.Size(84, 19);
		this.Label86.TabIndex = 0;
		this.Label86.Text = "게시글 선택";
		this.ComboBox16.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox16.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox16.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox16.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox16.FormattingEnabled = true;
		this.ComboBox16.Location = new System.Drawing.Point(113, 18);
		this.ComboBox16.Name = "ComboBox16";
		this.ComboBox16.Size = new System.Drawing.Size(564, 26);
		this.ComboBox16.TabIndex = 3;
		this.Panel112.Controls.Add(this.Panel113);
		this.Panel112.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel112.Location = new System.Drawing.Point(23, 0);
		this.Panel112.Name = "Panel112";
		this.Panel112.Size = new System.Drawing.Size(822, 56);
		this.Panel112.TabIndex = 21;
		this.Panel113.Controls.Add(this.Label88);
		this.Panel113.Controls.Add(this.Panel114);
		this.Panel113.Controls.Add(this.Label89);
		this.Panel113.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel113.Location = new System.Drawing.Point(0, 0);
		this.Panel113.Name = "Panel113";
		this.Panel113.Size = new System.Drawing.Size(822, 56);
		this.Panel113.TabIndex = 4;
		this.Label88.AutoSize = true;
		this.Label88.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label88.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label88.Location = new System.Drawing.Point(0, 15);
		this.Label88.Name = "Label88";
		this.Label88.Size = new System.Drawing.Size(153, 30);
		this.Label88.TabIndex = 1;
		this.Label88.Text = "공지사항 관리";
		this.Panel114.BackColor = System.Drawing.Color.Gray;
		this.Panel114.Location = new System.Drawing.Point(155, 41);
		this.Panel114.Name = "Panel114";
		this.Panel114.Size = new System.Drawing.Size(2000, 1);
		this.Panel114.TabIndex = 3;
		this.Label89.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label89.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label89.Location = new System.Drawing.Point(153, 15);
		this.Label89.Name = "Label89";
		this.Label89.Size = new System.Drawing.Size(768, 30);
		this.Label89.TabIndex = 2;
		this.Label89.Text = "공지사항 게시판을 여기에서 관리 하십시오.";
		this.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel117.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel117.Location = new System.Drawing.Point(845, 0);
		this.Panel117.Name = "Panel117";
		this.Panel117.Size = new System.Drawing.Size(23, 639);
		this.Panel117.TabIndex = 20;
		this.Panel118.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel118.Location = new System.Drawing.Point(0, 0);
		this.Panel118.Name = "Panel118";
		this.Panel118.Size = new System.Drawing.Size(23, 639);
		this.Panel118.TabIndex = 19;
		this.Panel103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel103.Controls.Add(this.Button86);
		this.Panel103.Controls.Add(this.Button85);
		this.Panel103.Controls.Add(this.Button57);
		this.Panel103.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel103.Location = new System.Drawing.Point(0, 639);
		this.Panel103.Name = "Panel103";
		this.Panel103.Padding = new System.Windows.Forms.Padding(5);
		this.Panel103.Size = new System.Drawing.Size(868, 44);
		this.Panel103.TabIndex = 43;
		this.Button86.BackColor = System.Drawing.Color.DarkGreen;
		this.Button86.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button86.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button86.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button86.ForeColor = System.Drawing.Color.White;
		this.Button86.Location = new System.Drawing.Point(85, 5);
		this.Button86.Name = "Button86";
		this.Button86.Size = new System.Drawing.Size(88, 32);
		this.Button86.TabIndex = 8;
		this.Button86.Text = "새로 만들기";
		this.Button86.UseVisualStyleBackColor = false;
		this.Button85.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button85.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button85.BackgroundImage");
		this.Button85.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button85.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button85.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button85.ForeColor = System.Drawing.Color.White;
		this.Button85.Location = new System.Drawing.Point(793, 5);
		this.Button85.Name = "Button85";
		this.Button85.Size = new System.Drawing.Size(68, 32);
		this.Button85.TabIndex = 7;
		this.Button85.Text = "저장";
		this.Button85.UseVisualStyleBackColor = false;
		this.Button57.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button57.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button57.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button57.ForeColor = System.Drawing.Color.White;
		this.Button57.Location = new System.Drawing.Point(5, 5);
		this.Button57.Name = "Button57";
		this.Button57.Size = new System.Drawing.Size(80, 32);
		this.Button57.TabIndex = 9;
		this.Button57.Text = "새로고침";
		this.Button57.UseVisualStyleBackColor = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(876, 709);
		base.Controls.Add(this.TabControl1);
		this.DoubleBuffered = true;
		base.Name = "android_db_sjka_application_noteapp";
		this.Text = "android_db_sjka_application_noteapp";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage5.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.TabPage4.ResumeLayout(false);
		this.TabPage6.ResumeLayout(false);
		this.TabPage7.ResumeLayout(false);
		this.TabPage8.ResumeLayout(false);
		this.ContextMenuStrip1.ResumeLayout(false);
		this.p2.ResumeLayout(false);
		this.p2.PerformLayout();
		this.Panel10.ResumeLayout(false);
		this.Panel10.PerformLayout();
		this.Panel57.ResumeLayout(false);
		this.Panel60.ResumeLayout(false);
		this.Panel60.PerformLayout();
		this.Panel58.ResumeLayout(false);
		this.Panel58.PerformLayout();
		this.Panel59.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.Panel7.PerformLayout();
		this.Panel61.ResumeLayout(false);
		this.Panel25.ResumeLayout(false);
		this.Panel25.PerformLayout();
		this.Panel56.ResumeLayout(false);
		this.Panel56.PerformLayout();
		this.Panel6.ResumeLayout(false);
		this.p3.ResumeLayout(false);
		this.p3.PerformLayout();
		this.Panel5.ResumeLayout(false);
		this.Panel5.PerformLayout();
		this.Panel54.ResumeLayout(false);
		this.Panel53.ResumeLayout(false);
		this.Panel53.PerformLayout();
		this.Panel26.ResumeLayout(false);
		this.Panel55.ResumeLayout(false);
		this.Panel55.PerformLayout();
		this.Panel11.ResumeLayout(false);
		this.Panel11.PerformLayout();
		this.DoubleBufferPanel3.ResumeLayout(false);
		this.p4.ResumeLayout(false);
		this.Panel52.ResumeLayout(false);
		this.Panel52.PerformLayout();
		this.Panel9.ResumeLayout(false);
		this.Panel9.PerformLayout();
		this.Panel31.ResumeLayout(false);
		this.Panel31.PerformLayout();
		this.Panel8.ResumeLayout(false);
		this.p7.ResumeLayout(false);
		this.Panel13.ResumeLayout(false);
		this.Panel13.PerformLayout();
		this.TableLayoutPanel1.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel22.ResumeLayout(false);
		this.Panel22.PerformLayout();
		this.Panel19.ResumeLayout(false);
		this.Panel19.PerformLayout();
		this.Panel12.ResumeLayout(false);
		this.p5.ResumeLayout(false);
		this.TableLayoutPanel2.ResumeLayout(false);
		this.Panel39.ResumeLayout(false);
		this.Panel39.PerformLayout();
		this.Panel38.ResumeLayout(false);
		this.Panel38.PerformLayout();
		this.Panel14.ResumeLayout(false);
		this.Panel14.PerformLayout();
		this.DoubleBufferPanel2.ResumeLayout(false);
		this.p6.ResumeLayout(false);
		this.Panel40.ResumeLayout(false);
		this.Panel40.PerformLayout();
		this.Panel44.ResumeLayout(false);
		this.TableLayoutPanel3.ResumeLayout(false);
		this.Panel18.ResumeLayout(false);
		this.Panel17.ResumeLayout(false);
		this.p8.ResumeLayout(false);
		this.DoubleBufferPanel1.ResumeLayout(false);
		this.DoubleBufferPanel1.PerformLayout();
		this.Panel45.ResumeLayout(false);
		this.Panel45.PerformLayout();
		this.Panel49.ResumeLayout(false);
		this.p10.ResumeLayout(false);
		this.p10.PerformLayout();
		this.Panel109.ResumeLayout(false);
		this.Panel109.PerformLayout();
		this.Panel112.ResumeLayout(false);
		this.Panel113.ResumeLayout(false);
		this.Panel113.PerformLayout();
		this.Panel103.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void android_db_sjka_application_noteapp_Load(object sender, EventArgs e)
	{
	}

	private void BeginEditListItem(ListViewItem iTm, int SubItemIndex)
	{
		Point location = iTm.SubItems[SubItemIndex].Bounds.Location;
		MouseEventArgs e = new MouseEventArgs(MouseButtons.Left, 2, location.X, location.Y, 0);
		ListView1_MouseDoubleClick(ListView1, e);
	}

	private void converToCSV()
	{
		DataTableCollection tables = result.Tables;
		object[] array = new object[1];
		ref object reference = ref @int;
		ref object reference2 = ref reference;
		array[0] = reference;
		object[] array2 = array;
		bool[] obj = new bool[1] { true };
		bool[] array3 = obj;
		object instance = NewLateBinding.LateGet(tables, null, "Item", array, null, null, obj);
		if (array3[0])
		{
			reference2 = RuntimeHelpers.GetObjectValue(array2[0]);
		}
		object obj2 = Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "Rows", new object[0], null, null, null), null, "Count", new object[0], null, null, null), 1);
		ProgressBar1.Maximum = Conversions.ToInteger(Operators.AddObject(obj2, 1));
		StringBuilder stringBuilder = new StringBuilder();
		object CounterResult = default(object);
		object LoopForResult = default(object);
		if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(CounterResult, 0, obj2, 1, ref LoopForResult, ref CounterResult))
		{
			object CounterResult2 = default(object);
			object LoopForResult2 = default(object);
			do
			{
				prog1.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("데이터 분석중... (", Operators.AddObject(CounterResult, 1)), "/"), Operators.AddObject(obj2, 1)), ")"));
				ProgressBar1.Value = Conversions.ToInteger(Operators.AddObject(CounterResult, 1));
				string text = "";
				object counter = CounterResult2;
				object obj3 = 0;
				DataTableCollection tables2 = result.Tables;
				object[] array4 = new object[1];
				ref object reference3 = ref @int;
				reference2 = ref reference3;
				array4[0] = reference3;
				array2 = array4;
				bool[] obj4 = new bool[1] { true };
				array3 = obj4;
				object instance2 = NewLateBinding.LateGet(tables2, null, "Item", array4, null, null, obj4);
				if (array3[0])
				{
					reference2 = RuntimeHelpers.GetObjectValue(array2[0]);
				}
				if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(counter, obj3, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(instance2, null, "Columns", new object[0], null, null, null), null, "Count", new object[0], null, null, null), 1), 1, ref LoopForResult2, ref CounterResult2))
				{
					do
					{
						string obj5 = text;
						DataTableCollection tables3 = result.Tables;
						object[] array5 = new object[1];
						ref object reference4 = ref @int;
						reference2 = ref reference4;
						array5[0] = reference4;
						object[] array6 = array5;
						bool[] obj6 = new bool[1] { true };
						bool[] array7 = obj6;
						object instance3 = NewLateBinding.LateGet(tables3, null, "Item", array5, null, null, obj6);
						if (array7[0])
						{
							reference2 = RuntimeHelpers.GetObjectValue(array6[0]);
						}
						object instance4 = NewLateBinding.LateGet(instance3, null, "Rows", array2 = new object[1] { CounterResult }, null, null, array3 = new bool[1] { true });
						if (array3[0])
						{
							CounterResult = RuntimeHelpers.GetObjectValue(array2[0]);
						}
						text = obj5 + NewLateBinding.LateIndexGet(instance4, new object[1] { CounterResult2 }, null).ToString() + "|";
					}
					while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult2, LoopForResult2, ref CounterResult2));
				}
				stringBuilder.AppendLine(text);
				Application.DoEvents();
			}
			while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
		}
		xlsxresult = stringBuilder.ToString();
	}

	public void getExcelData(string file)
	{
		IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(File.Open(file, FileMode.Open, FileAccess.Read));
		result = excelDataReader.AsDataSet();
		excelDataReader.Close();
		ArrayList arrayList = new ArrayList();
		checked
		{
			int num = result.Tables.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				arrayList.Add(result.Tables[i].TableName.ToString());
				ComboBox1.DataSource = arrayList;
			}
		}
	}

	public object ChrToColumn(string Chr)
	{
		_ = Module1.record;
		int num = 0;
		int num2 = 65;
		checked
		{
			do
			{
				if (Operators.CompareString(Module1.record[num], null, TextCompare: false) == 0)
				{
					if (Operators.CompareString(Conversions.ToString(Strings.ChrW(num2)), Chr, TextCompare: false) == 0)
					{
						return "NULL";
					}
				}
				else if (Operators.CompareString(Conversions.ToString(Strings.ChrW(num2)), Chr, TextCompare: false) == 0)
				{
					return Module1.record[num];
				}
				num++;
				num2++;
			}
			while (num2 <= 90);
			int num3 = 1;
			do
			{
				if (Operators.CompareString(Module1.record[num], null, TextCompare: false) == 0)
				{
					if ((double)num3 == Conversions.ToDouble(Chr))
					{
						return "NULL";
					}
				}
				else if ((double)num3 == Conversions.ToDouble(Chr))
				{
					return Module1.record[num];
				}
				num++;
				num3++;
			}
			while (num3 <= 74);
			return "NULL";
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "모든 파일|*.*|Excel 통합 문서|*.xlsx|CSV 파일|*.csv|텍스트 파일|*.txt";
		checked
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (openFileDialog.FileName.EndsWith("csv"))
				{
					try
					{
						using (StreamReader streamReader = new StreamReader(openFileDialog.FileName, Encoding.Default, detectEncodingFromByteOrderMarks: false))
						{
							TextBox3.Text = streamReader.ReadToEnd();
							Application.DoEvents();
						}
						ComboBox1.DataSource = null;
						ComboBox1.Items.Clear();
						TextBox1.Text = openFileDialog.FileName;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						MessageBox.Show("파일을 열 수 없습니다! : 파일이 손상되었거나 경로가 잘못 되었습니다.\r\n\r\n다른 파일로 다시 시도하십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
					}
				}
				else if (openFileDialog.FileName.EndsWith("txt"))
				{
					int num = 0;
					int num2 = 0;
					using (StreamReader streamReader2 = new StreamReader(openFileDialog.FileName, Encoding.Default, detectEncodingFromByteOrderMarks: false))
					{
						while (!streamReader2.EndOfStream)
						{
							streamReader2.ReadLine();
							num2++;
						}
					}
					Panel54.Visible = true;
					ProgressBar1.Maximum = num2;
					try
					{
						using (StreamReader streamReader3 = new StreamReader(openFileDialog.FileName, Encoding.Default, detectEncodingFromByteOrderMarks: false))
						{
							ProgressBar1.Value = 0;
							prog1.Text = Conversions.ToString(0);
							while (!streamReader3.EndOfStream)
							{
								if (!busy)
								{
									return;
								}
								prog1.Text = "데이터 변환 중... (" + Conversions.ToString(num + 1) + "/" + Conversions.ToString(num2 + 1) + ")";
								ProgressBar1.Value = num;
								ref string reference = ref xlsxresult;
								reference = reference + streamReader3.ReadLine().Replace("\t", "|") + "\r\n";
								num++;
								Application.DoEvents();
							}
						}
						TextBox3.Text = xlsxresult;
						ComboBox1.DataSource = null;
						ComboBox1.Items.Clear();
						TextBox1.Text = openFileDialog.FileName;
						Panel54.Visible = false;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						MessageBox.Show("파일을 열 수 없습니다! : 파일이 손상되었거나 경로가 잘못 되었습니다. " + ex4.Message + "\r\n\r\n다른 파일로 다시 시도하십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
					}
				}
				else if (openFileDialog.FileName.EndsWith("xlsx"))
				{
					try
					{
						getExcelData(openFileDialog.FileName);
						TextBox1.Text = openFileDialog.FileName;
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						MessageBox.Show("파일을 열 수 없습니다! : 파일이 손상되었거나 경로가 잘못 되었습니다.\r\n\r\n다른 파일로 다시 시도하십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					MessageBox.Show("파일을 열 수 없습니다! : 지원하지 않는 파일 확장자입니다.\r\n\r\n다른 파일로 다시 시도하십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					TextBox1.Text = null;
				}
			}
			openFileDialog = null;
			busy = false;
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (busy || Operators.CompareString(TextBox1.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		if (TextBox1.Text.EndsWith("csv") | TextBox1.Text.EndsWith("txt"))
		{
			MessageBox.Show("Excel 통합문서 파일(*.XLSX)이 아니면 변환할 필요가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		@int = ComboBox1.SelectedIndex;
		Panel54.Size = new Size(546, 100);
		Panel53.Visible = false;
		Panel54.Visible = true;
		xlsxresult = "";
		Module1.thr = new Thread(converToCSV);
		Module1.thr.Start();
		while (Module1.thr.IsAlive)
		{
			Application.DoEvents();
		}
		if (Operators.ConditionalCompareObjectEqual(xlsxcancel, false, TextCompare: false))
		{
			Panel53.Visible = true;
			Panel54.Visible = false;
			TextBox3.Text = xlsxresult;
		}
		else
		{
			xlsxcancel = false;
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (!busy)
		{
			ComboBox1.DataSource = null;
			datasheet = null;
			TextBox1.Text = null;
			ComboBox1.Items.Clear();
			TextBox3.Text = null;
			result = null;
			Label14.Text = "1. 파일로 삽입 (XLSX, CSV, TXT)";
			TextBox2.Text = null;
			ComboBox2.Text = null;
			RadioButton3.Checked = true;
		}
	}

	private void ProcessSetText(string text)
	{
		if (Label4.InvokeRequired)
		{
			SetTextCallback method = ProcessSetText;
			Panel11.Invoke(method, text);
		}
		else
		{
			Label4.Text = text;
		}
	}

	private void SaveDB()
	{
		string text = null;
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = spl.Length - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (!busy)
					{
						break;
					}
					ProcessSetText("전송 중... (" + Conversions.ToString(num2 + 1) + "/" + Conversions.ToString(spl.Length) + ")");
					string hTML = new GetHtmlClass(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=AddData&data=" + HttpUtility.UrlEncode(spl[num2]), "").getHTML(MyProject.Forms.mlas);
					if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
					{
						ProcessSetText("전송 중... (" + Conversions.ToString(num2 + 1) + "/" + Conversions.ToString(spl.Length) + ")(2)");
						hTML = new GetHtmlClass(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=AddData&data=" + HttpUtility.UrlEncode(spl[num2]), "").getHTML(MyProject.Forms.mlas);
						if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
						{
							ref string reference = ref error_log;
							reference = reference + spl[num2] + "\r\n";
							goto IL_01bf;
						}
					}
					stringBuilder.Append("," + hTML);
					Application.DoEvents();
					goto IL_01bf;
				}
				text = stringBuilder.ToString();
				try
				{
					text = text.Remove(0, 1);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				if (RadioButton1.Checked && Operators.CompareString(new GetHtmlClass(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + "&type=AddHAK&ftype=1&name=" + HttpUtility.UrlEncode(TextBox2.Text) + "&data=" + HttpUtility.UrlEncode(text)).getHTML(MyProject.Forms.mlas), "incorrect", TextCompare: false) == 0)
				{
					MessageBox.Show("학명집 생성중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Button47.Visible = false;
					break;
				}
				if (RadioButton2.Checked)
				{
					int num3 = 0;
					int num4 = HAKs.Length - 1;
					for (int i = 0; i <= num4; i++)
					{
						string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox2.SelectedItem, null, "Trim", new object[0], null, null, null), array[1].Trim(), TextCompare: false))
						{
							num3 = Conversions.ToInteger(array[0]);
							break;
						}
					}
					if (Operators.CompareString(new GetHtmlClass(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + "&type=dataAdd&num=" + Conversions.ToString(num3) + "&data=" + HttpUtility.UrlEncode("," + text)).getHTML(MyProject.Forms.mlas), "incorrect", TextCompare: false) == 0)
					{
						MessageBox.Show("학명집에 데이터를 추가하는 중에 오류가 발생했습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						Button47.Visible = false;
						break;
					}
				}
				_ = RadioButton3.Checked;
				if (Operators.CompareString(error_log, null, TextCompare: false) != 0)
				{
					if (MessageBox.Show("일부 데이터가 DB에 입력되었지만, 일부 추가되지 않은 데이터가 있습니다.\r\n이 데이터들을 검토하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						TextBox3.Text = error_log;
					}
				}
				else
				{
					MessageBox.Show("성공적으로 작업을 완료했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				break;
				IL_01bf:
				num2++;
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox3.Text, null, TextCompare: false) == 0 || busy)
		{
			return;
		}
		checked
		{
			int num = HAKs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.CompareString(TextBox2.Text.Trim(), array[1].Trim(), TextCompare: false) == 0)
				{
					MessageBox.Show("무결성 정책에 따라 중복되는 이름은 사용 할 수 없습니다.\r\n\r\n다른 이름을 사용하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			if (RadioButton1.Checked && Operators.CompareString(TextBox2.Text, null, TextCompare: false) == 0)
			{
				MessageBox.Show("새 학명집 이름을 지정하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			error_log = null;
			busy = true;
			Button4.Visible = false;
			Label4.Visible = true;
			Button47.Visible = true;
			spl = TextBox3.Text.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
			Module1.saveThread = new Thread(SaveDB);
			Module1.saveThread.Start();
			while (Module1.saveThread.IsAlive)
			{
				TextBox25.Text = error_log;
				Application.DoEvents();
			}
			busy = false;
			Button4.Visible = true;
			Label4.Visible = false;
			SetList();
			Button47.Visible = false;
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (ListView1.Items[0].Checked)
				{
					int num = ListView1.Items.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						ListView1.Items[i].Checked = false;
					}
				}
				else
				{
					int num2 = ListView1.Items.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						ListView1.Items[j].Checked = true;
					}
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

	private void Button6_Click(object sender, EventArgs e)
	{
		string text = null;
		checked
		{
			int num = ListView1.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ListView1.Items[i].Checked)
				{
					text = text + "," + ListView1.Items[i].SubItems[0].Text;
				}
			}
			if (Operators.CompareString(text, null, TextCompare: false) == 0 || MessageBox.Show("정말 선택된 항목을 모두 삭제 하시겠습니까?\r\n\r\n영구적으로 삭제되며 복구할 수 없습니다.", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
			{
				return;
			}
			int num2 = ListView1.Items.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				if (ListView1.Items[j].Checked && Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=DelData&num=" + ListView1.Items[j].SubItems[0].Text)), "incorrect", TextCompare: false) == 0)
				{
					MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			SetList();
		}
	}

	private void ListBox7_MouseWheel(object sender, MouseEventArgs e)
	{
		NewLateBinding.LateCall(sender, null, "invalidate", new object[0], null, null, null, IgnoreReturn: true);
	}

	public void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
	{
		if (e.Index < 0)
		{
			return;
		}
		if ((e.State & DrawItemState.Focus) == DrawItemState.Focus || (e.State & DrawItemState.Selected) == DrawItemState.Selected || (e.State & DrawItemState.HotLight) == DrawItemState.HotLight)
		{
			e.DrawBackground();
		}
		else
		{
			object obj = NewLateBinding.LateGet(sender, null, "backcolor", new object[0], null, null, null);
			using Brush brush = new SolidBrush((obj != null) ? ((Color)obj) : default(Color));
			e.Graphics.FillRectangle(brush, e.Bounds);
		}
		e.Graphics.DrawString(NewLateBinding.LateGet(sender, null, "Items", new object[1] { e.Index }, null, null, null).ToString(), (Font)NewLateBinding.LateGet(sender, null, "Font", new object[0], null, null, null), Brushes.Black, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
		if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
		{
			e.DrawFocusRectangle();
		}
		if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
		{
			Brush brush2 = new SolidBrush(Color.FromArgb(255, 246, 0));
			Rectangle bounds = e.Bounds;
			e.Graphics.FillRectangle(brush2, bounds);
			Brush brush3 = new SolidBrush(Color.Blue);
			Font font = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
			Graphics graphics = e.Graphics;
			object[] array = new object[1];
			object obj2 = sender;
			object instance = obj2;
			object[] array2 = new object[1];
			object obj3 = (array2[0] = e.Index);
			array[0] = NewLateBinding.LateGet(instance, null, "Items", array2, null, null, null);
			object[] array3 = array;
			bool[] obj4 = new bool[1] { true };
			bool[] array4 = obj4;
			object obj5 = NewLateBinding.LateGet(sender, null, "GetItemText", array, null, null, obj4);
			if (array4[0])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Items", new object[2]
				{
					obj3,
					array3[0]
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			graphics.DrawString(Conversions.ToString(obj5), font, brush3, bounds);
			return;
		}
		using SolidBrush brush4 = new SolidBrush(e.ForeColor);
		Graphics graphics2 = e.Graphics;
		object[] array5 = new object[1];
		object obj3 = sender;
		object instance2 = obj3;
		object[] array6 = new object[1];
		object obj2 = (array6[0] = e.Index);
		array5[0] = NewLateBinding.LateGet(instance2, null, "Items", array6, null, null, null);
		object[] array3 = array5;
		bool[] obj6 = new bool[1] { true };
		bool[] array4 = obj6;
		object obj5 = NewLateBinding.LateGet(sender, null, "GetItemText", array5, null, null, obj6);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj3, null, "Items", new object[2]
			{
				obj2,
				array3[0]
			}, null, null, OptimisticSet: true, RValueBase: false);
		}
		graphics2.DrawString(Conversions.ToString(obj5), e.Font, brush4, e.Bounds);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		string text = null;
		checked
		{
			int num = ListView1.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ListView1.Items[i].Checked)
				{
					text = text + "," + ListView1.Items[i].SubItems[0].Text;
				}
			}
			if (Operators.CompareString(text, null, TextCompare: false) != 0)
			{
				Panel10.Visible = false;
				Panel57.Visible = false;
				TextBox4.Text = null;
				Point point = Module1.ControlCenter(p2, Panel7);
				Panel7.Top = point.X;
				Panel7.Left = point.Y;
				Panel7.Visible = true;
				TextBox4.Focus();
			}
		}
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox4.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		checked
		{
			int num = HAKs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.CompareString(TextBox4.Text.Trim(), array[1].Trim(), TextCompare: false) == 0)
				{
					MessageBox.Show("무결성 정책에 따라 중복되는 이름은 사용 할 수 없습니다.\r\n\r\n다른 이름을 사용하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			string text = null;
			int num2 = ListView1.Items.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				if (ListView1.Items[j].Checked)
				{
					text = text + "," + ListView1.Items[j].SubItems[0].Text;
				}
			}
			if (Operators.CompareString(text, null, TextCompare: false) != 0)
			{
				text = text.Remove(0, 1);
				if (text.Length > 5478)
				{
					MessageBox.Show("학명집 만들기: 한번에 최대 1000항목만 넣을 수 있습니다. 일단 1000개 이하를 넣어서 학명집을 만든 뒤, 나머지 데이터는 기존 학명집에 추가를 사용하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (Operators.ConditionalCompareObjectEqual(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=AddHAK&ftype=1&name=" + HttpUtility.UrlEncode(TextBox4.Text) + "&data=" + HttpUtility.UrlEncode(text)), "incorrect", TextCompare: false))
				{
					MessageBox.Show("학명집 생성중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				Panel7.Visible = false;
				MessageBox.Show(TextBox4.Text + " 학명집을 만들었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				SetList(refresh: false);
			}
		}
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		string text = null;
		checked
		{
			int num = ListView1.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ListView1.Items[i].Checked)
				{
					text = text + "," + ListView1.Items[i].SubItems[0].Text;
				}
			}
			if (Operators.CompareString(text, null, TextCompare: false) != 0)
			{
				Panel7.Visible = false;
				Panel57.Visible = false;
				Point point = Module1.ControlCenter(p2, Panel10);
				Panel10.Top = point.X;
				Panel10.Left = point.Y;
				Panel10.Visible = true;
				Button15.Focus();
			}
		}
	}

	private void Button16_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox4.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		int num = 0;
		checked
		{
			int num2 = HAKs.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox4.SelectedItem, null, "Trim", new object[0], null, null, null), array[1].Trim(), TextCompare: false))
				{
					num = Conversions.ToInteger(array[0]);
					break;
				}
			}
			string text = null;
			int num3 = ListView1.Items.Count - 1;
			for (int j = 0; j <= num3; j++)
			{
				if (ListView1.Items[j].Checked)
				{
					text = text + "," + ListView1.Items[j].SubItems[0].Text;
				}
			}
			if (text.Length > 5478)
			{
				MessageBox.Show("학명집 만들기: 한번에 최대 1000항목만 넣을 수 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=dataAdd&num=" + Conversions.ToString(num) + "&data=" + HttpUtility.UrlEncode(text)), "incorrect", TextCompare: false))
			{
				MessageBox.Show("학명집 생성중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Panel10.Visible = false;
			MessageBox.Show(TextBox4.Text + " 학명집에 선택항목을 추가 하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			SetList(refresh: false);
		}
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		Panel7.Visible = false;
	}

	private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		ListBox7.DataSource = null;
		ListBox7.Items.Clear();
		int num = 0;
		ArrayList arrayList = new ArrayList();
		checked
		{
			int num2 = HAKs.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox3.SelectedItem, null, "Trim", new object[0], null, null, null), array[1].Trim(), TextCompare: false))
				{
					continue;
				}
				string[] array2 = array[2].Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
				num = array2.Length;
				TextBox5.Text = array[1];
				if (Operators.CompareString(array[4], "1", TextCompare: false) == 0)
				{
					CheckBox1.Checked = true;
				}
				else
				{
					CheckBox1.Checked = false;
				}
				int num3 = array2.Length - 1;
				for (int j = 0; j <= num3; j++)
				{
					try
					{
						Label24.Text = "데이터 입력 중... (" + Conversions.ToString(Math.Round((double)j / (double)num * 100.0, 0)) + "%)";
						arrayList.Add(array2[j]);
						Application.DoEvents();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				break;
			}
			Label24.Text = "포함된 데이터 (총 " + Conversions.ToString(num) + "항목)";
			ListBox7.DataSource = arrayList;
			busy = false;
		}
	}

	private void Button54_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("학명집의 데이터들은 모두 원본 데이터를 참조하는 것들로 이루어져 있으며, 원본 데이터가 삭제되더라도 학명집의 참조 번호는 삭제되지 않는 구조로 되어있습니다. 그러므로 원본 데이터를 삭제했을 경우 학명집의 데이터 유효성을 검사하여 원본 데이터의 자료존재 유무를 판단하여 정리하여야 합니다. 기능은 이를 대신 수행해줍니다.\r\n\r\n데이터 총 개수를 정확하게 할 때 사용하십시오. 정리 후 저장버튼을 누르지 않으면 정리내용이 반영되지 않습니다.\r\n\r\n학명집 정리를 시작하시겠습니까? (데이터 양에 비례하여 시간은 길어질 수 있습니다.)", "안내", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No || busy)
		{
			return;
		}
		busy = true;
		ListBox7.DataSource = null;
		ListBox7.Items.Clear();
		int num = 0;
		ArrayList arrayList = new ArrayList();
		checked
		{
			int num2 = HAKs.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox3.SelectedItem, null, "Trim", new object[0], null, null, null), array[1].Trim(), TextCompare: false))
				{
					continue;
				}
				string[] array2 = array[2].Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
				num = array2.Length;
				TextBox5.Text = array[1];
				if (Operators.CompareString(array[4], "1", TextCompare: false) == 0)
				{
					CheckBox1.Checked = true;
				}
				else
				{
					CheckBox1.Checked = false;
				}
				int num3 = array2.Length - 1;
				for (int j = 0; j <= num3; j++)
				{
					try
					{
						int num4 = Module1.AllData.Length - 1;
						for (int k = 0; k <= num4; k++)
						{
							string[] array3 = Module1.AllData[k].Split(new string[1] { "%" }, StringSplitOptions.None);
							if (Operators.CompareString(array2[j], array3[0], TextCompare: false) == 0)
							{
								Label24.Text = "데이터 정리 (" + Conversions.ToString(j) + "/" + Conversions.ToString(num) + ")";
								arrayList.Add(array3[0]);
								Application.DoEvents();
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
				}
				break;
			}
			ListBox7.DataSource = arrayList;
			Label24.Text = "포함된 데이터 (총 " + Conversions.ToString(ListBox7.Items.Count) + "항목)";
			busy = false;
		}
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox3.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		checked
		{
			int num = HAKs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(TextBox5.Text.Trim(), array[1].Trim(), TextCompare: false) == 0, Operators.CompareObjectNotEqual(TextBox5.Text, ComboBox3.SelectedItem, TextCompare: false))))
				{
					MessageBox.Show("무결성 정책에 따라 중복되는 이름은 사용 할 수 없습니다.\r\n\r\n다른 이름을 사용하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			if (MessageBox.Show("정말 선택된 항목을 모두 삭제 하시겠습니까?\r\n\r\n데이터는 삭제되지 않으며, 학명집에서 해당 항목만 사라집니다.", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
			{
				return;
			}
			int num2 = 0;
			int num3 = HAKs.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				string[] array2 = HAKs[j].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox3.SelectedItem, null, "Trim", new object[0], null, null, null), array2[1].Trim(), TextCompare: false))
				{
					num2 = Conversions.ToInteger(array2[0]);
					break;
				}
			}
			string text = null;
			int num4 = ListBox7.Items.Count - 1;
			for (int k = 0; k <= num4; k++)
			{
				try
				{
					bool flag = false;
					int num5 = ListBox7.SelectedItems.Count - 1;
					for (int l = 0; l <= num5; l++)
					{
						if (Operators.ConditionalCompareObjectEqual(ListBox7.SelectedItems[l], ListBox7.Items[k], TextCompare: false))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(",", ListBox7.Items[k])));
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show("선택된 항목이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					ProjectData.ClearProjectError();
					return;
				}
			}
			if (Operators.CompareString(text, null, TextCompare: false) != 0)
			{
				int num6 = 0;
				num6 = (CheckBox1.Checked ? 1 : 0);
				if (Operators.ConditionalCompareObjectEqual(Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + "&num=" + Conversions.ToString(num2) + "&type=modifyfolder&name=" + TextBox5.Text + "&data=" + text + "&visible=" + Conversions.ToString(num6)), "incorrect", TextCompare: false))
				{
					MessageBox.Show("삭제 중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				MessageBox.Show("삭제가 완료 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				string text2 = ComboBox3.Text;
				SetList();
				RefreshNote();
				ComboBox3.Text = text2;
			}
		}
	}

	private void Button13_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox3.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		checked
		{
			int num = HAKs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(TextBox5.Text.Trim(), array[1].Trim(), TextCompare: false) == 0, Operators.CompareObjectNotEqual(TextBox5.Text, ComboBox3.SelectedItem, TextCompare: false))))
				{
					MessageBox.Show("무결성 정책에 따라 중복되는 이름은 사용 할 수 없습니다.\r\n\r\n다른 이름을 사용하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			int num2 = 0;
			int num3 = HAKs.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				string[] array2 = HAKs[j].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox3.SelectedItem, null, "Trim", new object[0], null, null, null), array2[1].Trim(), TextCompare: false))
				{
					try
					{
						num2 = Conversions.ToInteger(array2[0]);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						MessageBox.Show("데이터 처리중에 오류가 발생하였습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						ProjectData.ClearProjectError();
						return;
					}
					break;
				}
			}
			string text = null;
			int num4 = ListBox7.Items.Count - 1;
			for (int k = 0; k <= num4; k++)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(",", ListBox7.Items[k])));
			}
			try
			{
				text = text.Remove(0, 1);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			int num5 = 0;
			num5 = (CheckBox1.Checked ? 1 : 0);
			if (Operators.CompareString(Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + "&num=" + Conversions.ToString(num2) + "&type=modifyfolder&name=" + HttpUtility.UrlEncode(TextBox5.Text) + "&data=" + HttpUtility.UrlEncode(text) + "&visible=" + Conversions.ToString(num5)), "incorrect", TextCompare: false) == 0)
			{
				MessageBox.Show("데이터 처리중에 오류가발생하였습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			string text2 = ComboBox3.Text;
			MessageBox.Show("성공적으로 저장했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			SetList();
			RefreshNote();
			ComboBox3.Text = text2;
		}
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox3.Text, null, TextCompare: false) == 0 || MessageBox.Show("정말 '" + ComboBox3.Text + "' 학명집을 삭제 하시겠습니까?\r\n\r\n데이터는 삭제되지 않으며, 학명집의 데이터 참조만 끊어집니다.", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
		{
			return;
		}
		int num = 0;
		checked
		{
			int num2 = HAKs.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox3.SelectedItem, null, "Trim", new object[0], null, null, null), array[1].Trim(), TextCompare: false))
				{
					num = Conversions.ToInteger(array[0]);
					break;
				}
			}
			if (Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&num=" + Conversions.ToString(num) + "&type=DelHAK")), "incorrect", TextCompare: false) == 0)
			{
				MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			SetList();
			RefreshNote();
			try
			{
				ComboBox3.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button15_Click(object sender, EventArgs e)
	{
		Panel10.Visible = false;
	}

	private void LV_KeyDown(object sender, KeyEventArgs e)
	{
		if (ListView1.SelectedItems.Count != 0)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.F2)
			{
				e.Handled = true;
				BeginEditListItem(ListView1.SelectedItems[0], 2);
			}
		}
	}

	private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		CurrentItem = ListView1.GetItemAt(e.X, e.Y);
		if (CurrentItem == null)
		{
			return;
		}
		CurrentSB = CurrentItem.GetSubItemAt(e.X, e.Y);
		int num = CurrentItem.SubItems.IndexOf(CurrentSB);
		try
		{
			ListView1.SelectedItems[0].Checked = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		checked
		{
			try
			{
				if (num == 0)
				{
					CurrentItem.BeginEdit();
					return;
				}
				int num2 = CurrentSB.Bounds.Left + 4;
				int num3 = CurrentSB.Bounds.Width - 5;
				TextBox textBox = TextBox6;
				textBox.SetBounds(num2 + ListView1.Left, CurrentSB.Bounds.Top - 2 + ListView1.Top, num3, CurrentSB.Bounds.Height);
				textBox.Text = CurrentSB.Text;
				textBox.Show();
				textBox.Focus();
				_ = null;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void TextBox6_LostFocus(object sender, EventArgs e)
	{
		TextBox6.Hide();
		if (!bCancelEdit)
		{
			int index = CurrentItem.SubItems.IndexOf(CurrentSB);
			ListView1.SelectedItems[0].SubItems[index].Text = TextBox6.Text;
		}
		else
		{
			bCancelEdit = false;
		}
		ListView1.Focus();
	}

	private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
	{
		switch (e.KeyChar)
		{
		case '\r':
			bCancelEdit = false;
			e.Handled = true;
			TextBox6.Hide();
			break;
		case '\u001b':
			bCancelEdit = true;
			e.Handled = true;
			TextBox6.Hide();
			break;
		}
	}

	private void Button17_Click(object sender, EventArgs e)
	{
		string text = null;
		checked
		{
			int num = ListView1.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ListView1.Items[i].Checked)
				{
					text = text + "," + ListView1.Items[i].SubItems[0].Text;
				}
			}
			if (Operators.CompareString(text, null, TextCompare: false) == 0)
			{
				MessageBox.Show("체크된 항목이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			int num2 = ListView1.Items.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				if (!ListView1.Items[j].Checked)
				{
					continue;
				}
				int num3 = 0;
				int num4 = Module1.AllData.Length - 1;
				for (int k = 0; k <= num4; k++)
				{
					string[] array = Module1.AllData[k].Split(new string[1] { "%" }, StringSplitOptions.None);
					if (Operators.CompareString(array[0], ListView1.Items[j].Text, TextCompare: false) == 0)
					{
						try
						{
							num3 = Conversions.ToInteger(array[0]);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							MessageBox.Show("항목을 수정하는 도중에 문제가 발생 하였습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							ProjectData.ClearProjectError();
							return;
						}
						break;
					}
				}
				string text2 = null;
				int num5 = ListView1.Items[j].SubItems.Count - 1;
				for (int l = 0; l <= num5; l++)
				{
					text2 = text2 + ListView1.Items[j].SubItems[l].Text + "|";
				}
				if (Operators.ConditionalCompareObjectEqual(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=modifydata&data=" + HttpUtility.UrlEncode(text2) + "&num=" + Conversions.ToString(num3)), "incorrect", TextCompare: false))
				{
					MessageBox.Show("항목을 수정하는 도중에 문제가 발생 하였습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			MessageBox.Show("수정된 항목이 서버에 정상적으로 반영되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox3.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		checked
		{
			try
			{
				int num = ListBox7.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					ListBox7.SetSelected(i, value: true);
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

	private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		ColumnHeader columnHeader = ListView1.Columns[e.Column];
		SortOrder sortOrder;
		if (m_SortingColumn == null)
		{
			sortOrder = SortOrder.Ascending;
		}
		else
		{
			sortOrder = ((!columnHeader.Equals(m_SortingColumn)) ? SortOrder.Ascending : ((!m_SortingColumn.Text.EndsWith(" ▼")) ? SortOrder.Ascending : SortOrder.Descending));
			try
			{
				m_SortingColumn.Text = m_SortingColumn.Text.Replace("▼", "").Replace("▲", "").Trim();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		m_SortingColumn = columnHeader;
		if (sortOrder == SortOrder.Ascending)
		{
			m_SortingColumn.Text += " ▼";
		}
		else
		{
			m_SortingColumn.Text += " ▲";
		}
		ListView1.ListViewItemSorter = new ListViewComparer(e.Column, sortOrder);
		ListView1.Sort();
	}

	private void Button18_Click(object sender, EventArgs e)
	{
		ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
	}

	private void ListView2_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		ColumnHeader columnHeader = (ColumnHeader)NewLateBinding.LateGet(sender, null, "Columns", new object[1] { e.Column }, null, null, null);
		SortOrder sortOrder;
		if (m_SortingColumn == null)
		{
			sortOrder = SortOrder.Ascending;
		}
		else
		{
			sortOrder = ((!columnHeader.Equals(m_SortingColumn)) ? SortOrder.Ascending : ((!m_SortingColumn.Text.EndsWith(" ▼")) ? SortOrder.Ascending : SortOrder.Descending));
			try
			{
				m_SortingColumn.Text = m_SortingColumn.Text.Replace("▼", "").Replace("▲", "").Trim();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		m_SortingColumn = columnHeader;
		if (sortOrder == SortOrder.Ascending)
		{
			m_SortingColumn.Text += " ▼";
		}
		else
		{
			m_SortingColumn.Text += " ▲";
		}
		NewLateBinding.LateSet(sender, null, "ListViewItemSorter", new object[1]
		{
			new ListViewComparer(e.Column, sortOrder)
		}, null, null);
		NewLateBinding.LateCall(sender, null, "Sort", new object[0], null, null, null, IgnoreReturn: true);
	}

	private void Button24_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox5.Text, null, TextCompare: false) == 0 || MessageBox.Show("정말 '" + ComboBox5.Text + "' 폴더를 삭제 하시겠습니까?\r\n\r\n데이터 및 학명집은 삭제되지 않으며, 폴더의 학명집 참조만 끊어집니다.", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
		{
			return;
		}
		int num = 0;
		checked
		{
			int num2 = HAKs.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ComboBox5.SelectedItem, null, "Trim", new object[0], null, null, null), array[1].Trim(), TextCompare: false))
				{
					num = Conversions.ToInteger(array[0]);
					break;
				}
			}
			if (Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&num=" + Conversions.ToString(num) + "&type=DelHAK")), "incorrect", TextCompare: false) == 0)
			{
				MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			SetList();
			RefreshFolder();
			try
			{
				ComboBox5.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button21_Click(object sender, EventArgs e)
	{
		Point point = Module1.ControlCenter(p7, Panel13);
		Panel13.Top = point.X;
		Panel13.Left = point.Y;
		Panel13.Visible = true;
		TextBox7.Text = null;
		TextBox7.Focus();
	}

	private void Button25_Click(object sender, EventArgs e)
	{
		Panel13.Visible = false;
	}

	private void Button26_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox7.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		checked
		{
			int num = HAKs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(TextBox7.Text.Trim(), array[1].Trim(), TextCompare: false) == 0, Operators.CompareObjectNotEqual(TextBox7.Text, ComboBox5.SelectedItem, TextCompare: false))))
				{
					MessageBox.Show("무결성 정책에 따라 중복되는 이름은 사용 할 수 없습니다.\r\n\r\n다른 이름을 사용하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			if (Operators.ConditionalCompareObjectEqual(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=AddHAK&ftype=0&name=" + HttpUtility.UrlEncode(TextBox7.Text)), "incorrect", TextCompare: false))
			{
				MessageBox.Show("폴더 생성중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			MessageBox.Show("성공적으로 작업을 완료했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			SetList();
			RefreshFolder();
			ComboBox5.SelectedIndex = ComboBox5.Items.Count - 1;
			Panel13.Visible = false;
		}
	}

	private void Button22_Click(object sender, EventArgs e)
	{
		try
		{
			ListBox3.Items.Add(RuntimeHelpers.GetObjectValue(ListBox2.SelectedItem));
			ListBox3.SelectedIndex = checked(ListBox3.Items.Count - 1);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
	{
		ListBox3.Items.Clear();
		checked
		{
			int num = HAKs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.CompareString(array[1], ComboBox5.Text, TextCompare: false) != 0)
				{
					continue;
				}
				TextBox8.Text = array[1];
				if (Conversions.ToDouble(array[4]) == 1.0)
				{
					CheckBox2.Checked = true;
				}
				else
				{
					CheckBox2.Checked = false;
				}
				string[] array2 = array[2].Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
				int num2 = array2.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					int num3 = HAKs.Length - 1;
					for (int k = 0; k <= num3; k++)
					{
						string[] array3 = HAKs[k].Split(new string[1] { "%" }, StringSplitOptions.RemoveEmptyEntries);
						if (Operators.CompareString(array3[0], array2[j], TextCompare: false) == 0)
						{
							ListBox3.Items.Add(array3[1]);
							break;
						}
					}
				}
			}
		}
	}

	private void Button27_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ListBox3.Items[ListBox3.SelectedIndex - 1]);
				RuntimeHelpers.GetObjectValue(ListBox3.SelectedItem);
				ListBox3.Items[ListBox3.SelectedIndex - 1] = RuntimeHelpers.GetObjectValue(ListBox3.SelectedItem);
				ListBox3.Items[ListBox3.SelectedIndex] = RuntimeHelpers.GetObjectValue(objectValue);
				ListBox3.SelectedIndex -= 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button28_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ListBox3.Items[ListBox3.SelectedIndex + 1]);
				RuntimeHelpers.GetObjectValue(ListBox3.SelectedItem);
				ListBox3.Items[ListBox3.SelectedIndex + 1] = RuntimeHelpers.GetObjectValue(ListBox3.SelectedItem);
				ListBox3.Items[ListBox3.SelectedIndex] = RuntimeHelpers.GetObjectValue(objectValue);
				ListBox3.SelectedIndex += 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button23_Click(object sender, EventArgs e)
	{
		try
		{
			ListBox3.Items.RemoveAt(ListBox3.SelectedIndex);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button20_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox5.Text, null, TextCompare: false) == 0 || Operators.CompareString(TextBox8.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		checked
		{
			int num = HAKs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(TextBox8.Text.Trim(), array[1].Trim(), TextCompare: false) == 0, Operators.CompareObjectNotEqual(TextBox8.Text, ComboBox5.SelectedItem, TextCompare: false))))
				{
					MessageBox.Show("무결성 정책에 따라 중복되는 이름은 사용 할 수 없습니다.\r\n\r\n다른 이름을 사용하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			string text = null;
			int num2 = 0;
			int num3 = HAKs.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				string[] array2 = HAKs[j].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.CompareString(array2[1], ComboBox5.Text, TextCompare: false) == 0)
				{
					num2 = Conversions.ToInteger(array2[0]);
				}
			}
			int num4 = ListBox3.Items.Count - 1;
			for (int k = 0; k <= num4; k++)
			{
				int num5 = HAKs.Length - 1;
				for (int l = 0; l <= num5; l++)
				{
					string[] array3 = HAKs[l].Split(new string[1] { "%" }, StringSplitOptions.None);
					if (Operators.ConditionalCompareObjectEqual(array3[1], ListBox3.Items[k], TextCompare: false))
					{
						text = text + "," + array3[0];
					}
				}
			}
			int num6 = ListView2.Items.Count - 1;
			for (int m = 0; m <= num6; m++)
			{
				if (!ListView2.Items[m].Checked)
				{
					text = text + "," + ListView2.Items[m].SubItems[0].Text;
				}
			}
			try
			{
				text = text.Remove(0, 1);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			int num7 = 0;
			num7 = (CheckBox2.Checked ? 1 : 0);
			if (Operators.CompareString(Module1.HTMLPost(Module1._dburl + "/admin.php", "pw=" + MySettingsProperty.Settings.pw + "&num=" + Conversions.ToString(num2) + "&type=modifyfolder&name=" + TextBox8.Text + "&data=" + text + "&visible=" + Conversions.ToString(num7)), "incorrect", TextCompare: false) == 0)
			{
				MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			string text2 = ComboBox5.Text;
			MessageBox.Show("성공적으로 저장했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			SetList();
			RefreshFolder();
			ComboBox5.Text = text2;
		}
	}

	private void TextBox7_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button26_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		if (e.KeyCode == Keys.Escape)
		{
			Panel13.Visible = false;
		}
	}

	private void Button29_Click(object sender, EventArgs e)
	{
		int selectedIndex = ListBox4.SelectedIndex;
		Module1.record[selectedIndex] = TextBox9.Text;
		ListBox4.Items.Clear();
		_ = Module1.record;
		int num = 0;
		int num2 = 65;
		checked
		{
			do
			{
				try
				{
					if (Operators.CompareString(Module1.record[num], null, TextCompare: false) == 0)
					{
						ListBox4.Items.Add(Conversions.ToString(Strings.ChrW(num2)) + " = NULL");
					}
					else
					{
						ListBox4.Items.Add(Conversions.ToString(Strings.ChrW(num2)) + " = " + Module1.record[num]);
					}
					num++;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ListBox4.Items.Add(Conversions.ToString(num2) + " = NULL");
					num++;
					ProjectData.ClearProjectError();
				}
				num2++;
			}
			while (num2 <= 90);
			int num3 = 1;
			do
			{
				try
				{
					if (Operators.CompareString(Module1.record[num], null, TextCompare: false) == 0)
					{
						ListBox4.Items.Add(Conversions.ToString(num3) + " = NULL");
					}
					else
					{
						ListBox4.Items.Add(Conversions.ToString(num3) + " = " + Module1.record[num]);
					}
					num++;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ListBox4.Items.Add(Conversions.ToString(num3) + " = NULL");
					num++;
					ProjectData.ClearProjectError();
				}
				num3++;
			}
			while (num3 <= 74);
			ListBox4.SelectedIndex = selectedIndex;
			string text = null;
			int num4 = Module1.record.Length - 1;
			for (int i = 0; i <= num4; i++)
			{
				text += Module1.record[i];
				if (i < Module1.record.Length - 2)
				{
					text += ",";
				}
			}
			if (Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=Settings&id=recordname&data=" + HttpUtility.UrlEncode(text))), "incorrect", TextCompare: false) == 0)
			{
				MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			MessageBox.Show("성공적으로 저장했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			SetList();
			RefreshColumnName();
			ListBox4.SelectedIndex = selectedIndex;
		}
	}

	private void ListBox4_SelectedIndexChanged(object sender, EventArgs e)
	{
		ListBox listBox = (ListBox)sender;
		TextBox9.Text = Module1.record[listBox.SelectedIndex];
	}

	private void TextBox9_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button29_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void Button31_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ListBox6.Items[ListBox6.SelectedIndex - 1]);
				RuntimeHelpers.GetObjectValue(ListBox6.SelectedItem);
				ListBox6.Items[ListBox6.SelectedIndex - 1] = RuntimeHelpers.GetObjectValue(ListBox6.SelectedItem);
				ListBox6.Items[ListBox6.SelectedIndex] = RuntimeHelpers.GetObjectValue(objectValue);
				ListBox6.SelectedIndex -= 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button32_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ListBox6.Items[ListBox6.SelectedIndex + 1]);
				RuntimeHelpers.GetObjectValue(ListBox6.SelectedItem);
				ListBox6.Items[ListBox6.SelectedIndex + 1] = RuntimeHelpers.GetObjectValue(ListBox6.SelectedItem);
				ListBox6.Items[ListBox6.SelectedIndex] = RuntimeHelpers.GetObjectValue(objectValue);
				ListBox6.SelectedIndex += 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button30_Click(object sender, EventArgs e)
	{
		ListBox6.Items.Add(RuntimeHelpers.GetObjectValue(ListBox5.SelectedItem));
		ListBox6.SelectedIndex = checked(ListBox6.Items.Count - 1);
	}

	private void Button34_Click(object sender, EventArgs e)
	{
		try
		{
			ListBox6.Items.RemoveAt(ListBox6.SelectedIndex);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button33_Click(object sender, EventArgs e)
	{
		string text = null;
		int num = 3;
		int num2 = 0;
		checked
		{
			do
			{
				switch (num2)
				{
				case 0:
					text = ComboBox6.Text.Substring(0, ComboBox6.Text.IndexOf(" "));
					break;
				case 1:
					text += ComboBox7.Text.Substring(0, ComboBox7.Text.IndexOf(" "));
					break;
				case 2:
					try
					{
						text += ListBox6.Items[0].ToString().Substring(0, ListBox6.Items[0].ToString().IndexOf(" "));
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						ProjectData.ClearProjectError();
					}
					break;
				case 3:
					try
					{
						text += ListBox6.Items[1].ToString().Substring(0, ListBox6.Items[1].ToString().IndexOf(" "));
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						ProjectData.ClearProjectError();
					}
					break;
				case 4:
					try
					{
						text += ListBox6.Items[2].ToString().Substring(0, ListBox6.Items[2].ToString().IndexOf(" "));
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
					break;
				case 5:
					text += ComboBox8.Text.Substring(0, ComboBox8.Text.IndexOf(" "));
					break;
				case 6:
					text += ComboBox9.Text.Substring(0, ComboBox9.Text.IndexOf(" "));
					break;
				case 7:
					text += ComboBox10.Text.Substring(0, ComboBox10.Text.IndexOf(" "));
					break;
				case 8:
					text += ComboBox11.Text.Substring(0, ComboBox11.Text.IndexOf(" "));
					break;
				case 9:
					text += ComboBox12.Text.Substring(0, ComboBox12.Text.IndexOf(" "));
					break;
				default:
					try
					{
						text += ListBox6.Items[num].ToString().Substring(0, ListBox6.Items[num].ToString().IndexOf(" "));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
						goto IL_0308;
					}
					num++;
					break;
				}
				if (num2 < 99)
				{
					text += ",";
				}
				goto IL_0308;
				IL_0308:
				num2++;
			}
			while (num2 <= 99);
			if (Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=Settings&id=column&data=" + HttpUtility.UrlEncode(text))), "incorrect", TextCompare: false) == 0)
			{
				MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			MessageBox.Show("성공적으로 저장했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			SetList();
			RefreshView();
		}
	}

	private void Button35_Click(object sender, EventArgs e)
	{
		string str = ComboBox13.Text;
		if (Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=Settings&id=search1&data=" + HttpUtility.UrlEncode(str))), "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("search1 데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		str = ComboBox14.Text;
		if (Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=Settings&id=search2&data=" + HttpUtility.UrlEncode(str))), "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("search2 데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		MessageBox.Show("성공적으로 저장했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		SetList();
		RefreshSearch();
	}

	private void TextBox4_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button8_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		if (e.KeyCode == Keys.Escape)
		{
			Panel7.Visible = false;
		}
	}

	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Button37_Click(object sender, EventArgs e)
	{
		TextBox3.Hide();
		checked
		{
			if (Operators.CompareString(TextBox3.Text, null, TextCompare: false) == 0)
			{
				TextBox3.Text = "|";
			}
			else
			{
				string[] array = TextBox3.Text.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
				string text = "";
				TextBox3.Text = null;
				Panel54.Show();
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text = text + "|" + array[i] + "\r\n";
					prog1.Text = Conversions.ToString(i) + "/" + Conversions.ToString(array.Length - 1);
					Application.DoEvents();
				}
				TextBox3.Text = text.Trim();
				Panel54.Hide();
			}
			TextBox3.Show();
		}
	}

	private void Button41_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox3.Text, null, TextCompare: false) == 0)
		{
			TextBox3.Text = "|";
			return;
		}
		string[] array = TextBox3.Text.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		TextBox3.Text = null;
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				TextBox textBox;
				(textBox = TextBox3).Text = textBox.Text + array[i] + "|";
				if (i < array.Length - 1)
				{
					TextBox3.Text += "\r\n";
				}
			}
		}
	}

	private void Button40_Click(object sender, EventArgs e)
	{
		Panel52.Visible = false;
		TextBox10.Text = null;
		Point point = Module1.ControlCenter(p4, Panel52);
		Panel52.Top = point.X;
		Panel52.Left = point.Y;
		Panel52.Visible = true;
		TextBox10.Focus();
	}

	private void Button39_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox10.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		checked
		{
			int num = HAKs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.CompareString(TextBox10.Text.Trim(), array[1].Trim(), TextCompare: false) == 0)
				{
					MessageBox.Show("무결성 정책에 따라 중복되는 이름은 사용 할 수 없습니다.\r\n\r\n다른 이름을 사용하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			if (Operators.ConditionalCompareObjectEqual(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=AddHAK&ftype=1&name=" + HttpUtility.UrlEncode(TextBox10.Text)), "incorrect", TextCompare: false))
			{
				MessageBox.Show("학명집 생성중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Panel52.Visible = false;
			MessageBox.Show(TextBox4.Text + " 학명집을 만들었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			SetList();
			RefreshNote();
			try
			{
				ComboBox3.SelectedIndex = ComboBox3.Items.Count - 1;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button38_Click(object sender, EventArgs e)
	{
		Panel52.Visible = false;
	}

	private void TextBox10_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button39_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		if (e.KeyCode == Keys.Escape)
		{
			Panel52.Visible = false;
		}
	}

	private void Button15_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Panel10.Visible = false;
		}
	}

	private void TextBox3_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Control)
		{
			e.SuppressKeyPress = true;
		}
		if (e.Control & (e.KeyCode == Keys.A))
		{
			TextBox3.SelectAll();
		}
		if (e.Control & (e.KeyCode == Keys.C))
		{
			TextBox3.Copy();
		}
		if (e.Control & (e.KeyCode == Keys.V))
		{
			TextBox3.Paste();
		}
		if (e.Control & (e.KeyCode == Keys.Z))
		{
			TextBox3.Undo();
		}
		if (e.Control & (e.KeyCode == Keys.X))
		{
			TextBox3.Cut();
		}
	}

	private void CheckBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (((CheckBox)sender).Checked)
		{
			TextBox3.WordWrap = true;
		}
		else
		{
			TextBox3.WordWrap = false;
		}
	}

	private void Button42_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=AddData")), "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			SetList();
		}
	}

	private void Button43_Click(object sender, EventArgs e)
	{
		busy = false;
		xlsxcancel = true;
		Panel53.Visible = true;
		Panel54.Visible = false;
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

	private void Button44_Click(object sender, EventArgs e)
	{
		TextBox3.Text = error_log;
	}

	private void btn_next_Click(object sender, EventArgs e)
	{
		checked
		{
			if (Module1.datapageNOW < Module1.datapageMAX)
			{
				Module1.datapageNOW++;
				txt_page.Text = Conversions.ToString(Module1.datapageNOW);
				pnpage(Module1.datapageNOW);
			}
		}
	}

	private void btn_prev_Click(object sender, EventArgs e)
	{
		checked
		{
			if (Module1.datapageNOW > 1)
			{
				Module1.datapageNOW--;
				txt_page.Text = Conversions.ToString(Module1.datapageNOW);
				pnpage(Module1.datapageNOW);
			}
		}
	}

	private void Button45_Click(object sender, EventArgs e)
	{
		if (Module1.datapageNOW < Module1.datapageMAX)
		{
			Module1.datapageNOW = Module1.datapageMAX;
			txt_page.Text = Conversions.ToString(Module1.datapageMAX);
			pnpage(Module1.datapageMAX);
		}
	}

	private void txt_page_KeyDown(object sender, KeyEventArgs e)
	{
		checked
		{
			if (e.KeyCode == Keys.Return)
			{
				double a = Conversion.Val(txt_page.Text);
				try
				{
					Module1.datapageNOW = (int)Math.Round(a);
					pnpage((int)Math.Round(a));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					txt_page.Text = Conversions.ToString(Module1.datapageNOW);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private void Button46_Click(object sender, EventArgs e)
	{
		if (Module1.datapageNOW > 1)
		{
			Module1.datapageNOW = 1;
			txt_page.Text = Conversions.ToString(Module1.datapageNOW);
			pnpage(Module1.datapageNOW);
		}
	}

	private void Button47_Click(object sender, EventArgs e)
	{
		Button4.Visible = true;
		Label4.Visible = false;
		Button47.Visible = false;
		busy = false;
		MessageBox.Show("사용자 요청에 따라 전송작업이 모두 취소되었습니다.", "전송 취소", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void Button48_Click(object sender, EventArgs e)
	{
		if (!busy)
		{
			if (!Module1.search_mode)
			{
				Label5.Text = "다중 키워드 세미콜론(;) 구분, 범위 지정 물결(~)";
				Panel7.Visible = false;
				Panel10.Visible = false;
				Panel59.Visible = false;
				Panel60.Enabled = true;
				TextBox11.Text = null;
				Point point = Module1.ControlCenter(p2, Panel57);
				Panel57.Top = point.X;
				Panel57.Left = point.Y;
				Panel57.Size = new Size(516, 118);
				Panel57.Visible = true;
				TextBox11.Focus();
			}
			else
			{
				Module1.search_mode = false;
				pnpage();
			}
		}
	}

	private void Button51_Click(object sender, EventArgs e)
	{
		busy = false;
		Panel57.Visible = false;
	}

	private void Button50_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = TextBox11.Text.Replace("%", "").Trim();
		if ((Operators.CompareString(text, null, TextCompare: false) == 0) | (Operators.CompareString(text, "", TextCompare: false) == 0))
		{
			return;
		}
		checked
		{
			if (TextBox11.Text.IndexOf("~") < 0)
			{
				string[] array = text.Split(new string[1] { ";" }, StringSplitOptions.RemoveEmptyEntries);
				int num = array.Length - 1;
				Panel59.Visible = true;
				Panel57.Size = new Size(516, 182);
				Panel60.Enabled = false;
				ArrayList arrayList = new ArrayList();
				ProgressBar2.Maximum = Module1.AllData.Length;
				ProgressBar2.Value = 0;
				try
				{
					int num2 = Module1.AllData.Length - 1;
					for (int i = 0; i <= num2; i++)
					{
						Application.DoEvents();
						txt_search.Text = "검색 중 입니다. 잠시만 기다려 주세요... (" + Conversions.ToString(i) + "/" + Conversions.ToString(ProgressBar2.Maximum) + ")";
						string[] array2 = Module1.AllData[i].Split(new string[1] { "%" }, StringSplitOptions.RemoveEmptyEntries);
						int num3 = 0;
						int num4 = array2.Length - 1;
						for (int j = 0; j <= num4; j++)
						{
							if (!busy)
							{
								return;
							}
							if (array2[j].IndexOf(array[num3]) >= 0)
							{
								if (num3 == num)
								{
									arrayList.Add(i);
									break;
								}
								num3++;
							}
							Application.DoEvents();
						}
						ProgressBar2.Value++;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				if (arrayList.Count <= 0)
				{
					busy = false;
					Module1.search_mode = false;
					Label5.Text = "검색결과가 없습니다.";
					Panel60.Enabled = true;
					Panel59.Visible = false;
					Panel57.Size = new Size(516, 118);
					return;
				}
				busy = false;
				Module1.search_mode = true;
				Panel57.Visible = false;
				Module1.SearchData = new string[arrayList.Count + 1];
				int num5 = arrayList.Count - 1;
				for (int k = 0; k <= num5; k++)
				{
					Module1.SearchData[k] = Module1.AllData[(int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(arrayList[k])))];
				}
				pnpage();
				txt_page.Text = "1";
				Label11.Text = "검색 모드";
				Label55.Text = "검색어 '" + text + "'에 대한 검색결과 입니다. 총 " + Conversions.ToString(arrayList.Count) + "항목 검색 됨.";
				return;
			}
			int[] array4;
			try
			{
				string[] array3 = text.Split(new string[1] { "~" }, StringSplitOptions.RemoveEmptyEntries);
				array4 = new int[2]
				{
					(int)Math.Round(Conversion.Val(array3[0])),
					(int)Math.Round(Conversion.Val(array3[1]))
				};
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Label5.Text = "범위를 바르게 입력하세요. (예) 100~500";
				ProjectData.ClearProjectError();
				return;
			}
			Panel59.Visible = true;
			Panel57.Size = new Size(516, 182);
			Panel60.Enabled = false;
			ArrayList arrayList2 = new ArrayList();
			ProgressBar2.Maximum = Module1.AllData.Length;
			ProgressBar2.Value = 0;
			int num6 = Module1.AllData.Length - 1;
			int num7 = 0;
			while (true)
			{
				if (num7 <= num6)
				{
					Application.DoEvents();
					txt_search.Text = "검색 중 입니다. 잠시만 기다려 주세요... (" + Conversions.ToString(num7) + "/" + Conversions.ToString(ProgressBar2.Maximum) + ")";
					string[] array5 = Module1.AllData[num7].Split(new string[1] { "%" }, StringSplitOptions.RemoveEmptyEntries);
					if (busy)
					{
						if ((Conversion.Val(array5[0]) >= (double)array4[0]) & (Conversion.Val(array5[0]) <= (double)array4[1]))
						{
							arrayList2.Add(num7);
						}
						Application.DoEvents();
						ProgressBar2.Value++;
						num7++;
						continue;
					}
					break;
				}
				if (arrayList2.Count <= 0)
				{
					busy = false;
					Module1.search_mode = false;
					Label5.Text = "검색결과가 없습니다.";
					Panel60.Enabled = true;
					Panel59.Visible = false;
					Panel57.Size = new Size(516, 118);
					break;
				}
				busy = false;
				Module1.search_mode = true;
				Panel57.Visible = false;
				Module1.SearchData = new string[arrayList2.Count + 1];
				int num8 = arrayList2.Count - 1;
				for (int l = 0; l <= num8; l++)
				{
					Module1.SearchData[l] = Module1.AllData[(int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(arrayList2[l])))];
				}
				pnpage();
				txt_page.Text = "1";
				Label11.Text = "검색 모드";
				Label55.Text = "검색어 '" + text + "'에 대한 검색결과 입니다. 총 " + Conversions.ToString(arrayList2.Count) + "항목 검색 됨.";
				break;
			}
		}
	}

	private void TextBox11_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button50_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		if (e.KeyCode == Keys.Escape)
		{
			Panel57.Visible = false;
			busy = false;
		}
	}

	private void Button49_Click(object sender, EventArgs e)
	{
		busy = false;
		Panel60.Enabled = true;
		Panel59.Visible = false;
		Panel57.Size = new Size(516, 118);
	}

	private void Button53_Click_1(object sender, EventArgs e)
	{
		ContextMenuStrip1.Show(Button1, Button1.PointToClient(Cursor.Position));
		ContextMenuStrip1.Show();
	}

	private void ListBox7_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left)
		{
			return;
		}
		checked
		{
			try
			{
				string text = null;
				int num = Module1.AllData.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string[] array = Module1.AllData[i].Split(new string[1] { "%" }, StringSplitOptions.RemoveEmptyEntries);
					if (Operators.ConditionalCompareObjectEqual(ListBox7.SelectedValue, array[0], TextCompare: false))
					{
						int num2 = array.Length - 1;
						for (int j = 0; j <= num2; j++)
						{
							text = text + array[j] + "\r\n";
						}
						break;
					}
				}
				Interaction.MsgBox(text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show("데이터를 불러오는 중입니다. 잠시 후 다시 시도하여 주십시오.", "데이터 불러오는 중", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ComboBox16_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox16.Text, null, TextCompare: false) != 0)
		{
			string[] array = Module1.board[ComboBox16.SelectedIndex].Split(new string[1] { "%" }, StringSplitOptions.None);
			TextBox23.Text = array[1];
			TextBox22.Text = array[2];
		}
	}

	private void Button79_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox16.Text, null, TextCompare: false) != 0)
		{
			string[] array = Module1.board[ComboBox16.SelectedIndex].Split(new string[1] { "%" }, StringSplitOptions.None);
			if (MessageBox.Show(array[1] + " 이 게시글을 정말 삭제 하시겠습니까?", "게시글 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=noticeDEL&num=" + array[0]));
				notice_refresh();
			}
		}
	}

	private void Button86_Click(object sender, EventArgs e)
	{
		ComboBox16.Text = null;
		TextBox22.Text = null;
		TextBox23.Text = null;
	}

	private void Button85_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox16.Text, null, TextCompare: false) == 0)
		{
			if (MessageBox.Show("이 게시글을 등록 하시겠습니까?", "새 게시물 등록", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				RuntimeHelpers.GetObjectValue(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=noticeADD&title=" + HttpUtility.UrlEncode(TextBox23.Text) + "&text=" + HttpUtility.UrlEncode(TextBox22.Text)));
				notice_refresh();
			}
		}
		else if (MessageBox.Show("이 게시글의 글을 수정 하시겠습니까?", "글 수정", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
		{
			string[] array = Module1.board[ComboBox16.SelectedIndex].Split(new string[1] { "%" }, StringSplitOptions.None);
			RuntimeHelpers.GetObjectValue(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=noticeMOD&title=" + HttpUtility.UrlEncode(TextBox23.Text) + "&text=" + HttpUtility.UrlEncode(TextBox22.Text) + "&num=" + array[0]));
			notice_refresh();
		}
	}

	private void Button53_Click(object sender, EventArgs e)
	{
		if (bakBusy)
		{
			return;
		}
		bakBusy = true;
		checked
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				SaveFileDialog saveFileDialog2 = saveFileDialog;
				saveFileDialog2.Filter = "*.csv|*.csv";
				saveFileDialog2.FileName = Module1.project + "_" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd(HH-mm-ss)") + ".csv";
				saveFileDialog2.InitialDirectory = Environment.CurrentDirectory;
				saveFileDialog2.Title = "백업 경로를 지정하세요.";
				if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
				{
					bakBusy = false;
					return;
				}
				if (saveFileDialog2.FileName.ToLower().LastIndexOf("csv") < 0)
				{
					MessageBox.Show("CSV 확장자가 아니면 백업할 수 없습니다!", "확장자 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					bakBusy = false;
					return;
				}
				saveFileDialog2 = null;
				Panel61.Visible = true;
				ProgressBar3.Value = 0;
				ProgressBar3.Maximum = Module1.AllData.Length;
				string text = null;
				int num = 0;
				do
				{
					try
					{
						text = text + Module1.record[num] + ",";
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						text += ",";
						ProjectData.ClearProjectError();
					}
					num++;
				}
				while (num <= 99);
				using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, append: false, Encoding.Default))
				{
					streamWriter.WriteLine(text);
					int num2 = Module1.AllData.Length - 1;
					for (int i = 0; i <= num2; i++)
					{
						text = null;
						Label42.Text = "데이터베이스 백업 중... (" + Conversions.ToString(i + 1) + "/" + Conversions.ToString(Module1.AllData.Length) + ")";
						ProgressBar3.Value++;
						string[] array = Module1.AllData[i].Split(new string[1] { "%" }, StringSplitOptions.None);
						int num3 = array.Length - 1;
						for (int j = 0; j <= num3; j++)
						{
							text = ((Operators.CompareString(array[j], null, TextCompare: false) != 0) ? ((array[j].IndexOf(",") < 0) ? (text + array[j] + ",") : (text + "\"" + array[j] + "\",")) : (text + ","));
						}
						streamWriter.WriteLine(text);
						Application.DoEvents();
					}
				}
				Panel61.Visible = false;
				MessageBox.Show("데이터베이스 백업이 완료되었습니다.", "백업 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				bakBusy = false;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show("데이터베이스 백업에 실패 했습니다.\r\n\r\n" + ex4.Message, "백업 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				bakBusy = false;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (bakBusy)
		{
			return;
		}
		bakBusy = true;
		checked
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				SaveFileDialog saveFileDialog2 = saveFileDialog;
				saveFileDialog2.Filter = "*.csv|*.csv";
				saveFileDialog2.FileName = Module1.project + "_" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd(HH-mm-ss)") + ".csv";
				saveFileDialog2.InitialDirectory = Environment.CurrentDirectory;
				saveFileDialog2.Title = "백업 경로를 지정하세요.";
				if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
				{
					bakBusy = false;
					return;
				}
				if (saveFileDialog2.FileName.ToLower().LastIndexOf("csv") < 0)
				{
					MessageBox.Show("CSV 확장자가 아니면 백업할 수 없습니다!", "확장자 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					bakBusy = false;
					return;
				}
				saveFileDialog2 = null;
				Panel61.Visible = true;
				ProgressBar3.Value = 0;
				ProgressBar3.Maximum = ListView1.Items.Count;
				string text = null;
				int num = 0;
				do
				{
					try
					{
						text = text + Module1.record[num] + ",";
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						text += ",";
						ProjectData.ClearProjectError();
					}
					num++;
				}
				while (num <= 99);
				using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, append: false, Encoding.Default))
				{
					streamWriter.WriteLine(text);
					int num2 = ListView1.Items.Count - 1;
					for (int i = 0; i <= num2; i++)
					{
						text = null;
						Label42.Text = "데이터베이스 백업 중... (" + Conversions.ToString(i + 1) + "/" + Conversions.ToString(ListView1.Items.Count) + ")";
						ProgressBar3.Value++;
						int num3 = ListView1.Items[i].SubItems.Count - 1;
						for (int j = 0; j <= num3; j++)
						{
							text = ((Operators.CompareString(ListView1.Items[i].SubItems[j].Text, null, TextCompare: false) != 0) ? ((ListView1.Items[i].SubItems[j].Text.IndexOf(",") < 0) ? (text + ListView1.Items[i].SubItems[j].Text + ",") : (text + "\"" + ListView1.Items[i].SubItems[j].Text + "\",")) : (text + ","));
						}
						streamWriter.WriteLine(text);
						Application.DoEvents();
					}
				}
				Panel61.Visible = false;
				MessageBox.Show("데이터베이스 백업이 완료되었습니다.", "백업 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				bakBusy = false;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show("데이터베이스 백업에 실패 했습니다.\r\n\r\n" + ex4.Message, "백업 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				bakBusy = false;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ListBox2_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		Button22_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ListBox3_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		Button125_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void Button125_Click(object sender, EventArgs e)
	{
		if (ListBox3.SelectedIndex < 0)
		{
			return;
		}
		checked
		{
			int num = MyProject.Forms.mlas.ListBox1.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(MyProject.Forms.mlas.ListBox1.Items[i].ToString().Trim(), "학명집 관리", TextCompare: false) == 0)
				{
					MyProject.Forms.mlas.ListBox1.SelectedIndex = i;
					ComboBox3.Text = Conversions.ToString(ListBox3.SelectedItem);
					break;
				}
			}
		}
	}

	public void notice_refresh()
	{
		TextBox22.Text = null;
		TextBox23.Text = null;
		string hTML = new GetHtmlClass(Module1._dburl + "/search.php?type=notice", null, progress: true).getHTML(MyProject.Forms.mlas);
		if (Operators.CompareString(hTML, null, TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. notice", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Module1.board = hTML.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		ComboBox16.Items.Clear();
		TextBox22.Text = null;
		TextBox23.Text = null;
		string[] board = Module1.board;
		for (int i = 0; i < board.Length; i = checked(i + 1))
		{
			string[] array = board[i].Split(new string[1] { "%" }, StringSplitOptions.None);
			ComboBox16.Items.Add(array[1]);
		}
	}

	public void SetList(bool refresh = true)
	{
		Module1.datapageNOW = 1;
		txt_page.Text = "1";
		string hTML = new GetHtmlClass(Module1._dburl + "/util.php?type=getSettingsAdmin").getHTML(MyProject.Forms.mlas);
		if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. getSettings", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		checked
		{
			try
			{
				string[] array = hTML.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string[] array2 = array[i].Split(new string[1] { "%" }, StringSplitOptions.None);
					switch (array2[1])
					{
					case "column":
						Module1.column = array2[2].ToString().Split(new string[1] { "," }, StringSplitOptions.None);
						break;
					case "recordname":
						Module1.record = array2[2].ToString().Split(new string[1] { "," }, StringSplitOptions.None);
						Module1.record = (string[])Utils.CopyArray(Module1.record, new string[101]);
						break;
					case "search1":
						Module1.search1 = array2[2];
						break;
					case "search2":
						Module1.search2 = array2[2];
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show("DB 환경설정이 잘못되었습니다. 제작사에 문의하여 주시기 바랍니다.\r\n\r\nERROR mlas_get_settings_exception", "환경설정 오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
				return;
			}
			if (refresh)
			{
				ListView1.Items.Clear();
				ListView1.Columns.Clear();
			}
			ListBox7.DataSource = null;
			ListBox7.Items.Clear();
			ListBox2.Items.Clear();
			TextBox5.Text = null;
			ComboBox2.Items.Clear();
			ComboBox3.Items.Clear();
			ComboBox4.Items.Clear();
			ComboBox5.Items.Clear();
			TextBox7.Text = null;
			TextBox8.Text = null;
			ListBox3.Items.Clear();
			Panel7.Visible = false;
			Panel10.Visible = false;
			Panel13.Visible = false;
			ListBox4.Items.Clear();
			TextBox9.Text = null;
			ListBox5.Items.Clear();
			ListBox6.Items.Clear();
			ComboBox6.Items.Clear();
			ComboBox7.Items.Clear();
			ComboBox8.Items.Clear();
			ComboBox9.Items.Clear();
			ComboBox10.Items.Clear();
			ComboBox11.Items.Clear();
			ComboBox12.Items.Clear();
			ComboBox13.Items.Clear();
			ComboBox14.Items.Clear();
			int num2 = 0;
			do
			{
				try
				{
					if (Operators.CompareString(Module1.record[num2], null, TextCompare: false) == 0)
					{
						if (refresh)
						{
							ListView1.Columns.Add("-");
						}
					}
					else if (refresh)
					{
						ListView1.Columns.Add(Module1.record[num2]);
					}
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					if (refresh)
					{
						ListView1.Columns.Add("-");
					}
					ProjectData.ClearProjectError();
				}
				num2++;
			}
			while (num2 <= 99);
		}
	}

	public void alldata_load()
	{
		if (!Module1.databusy)
		{
			Module1.databusy = true;
			string hTML = new GetHtmlClass(Module1._dburl + "/admin.php?type=all", null, progress: true).getHTML(MyProject.Forms.mlas);
			if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
			{
				MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. all", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Module1.AllData = hTML.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
			pnpage();
			ListView1.ListViewItemSorter = new ListViewComparer(0, SortOrder.Ascending);
			ListView1.Sort();
			Module1.databusy = false;
		}
	}

	public void pnpage(int page = 1)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		if (!Module1.search_mode)
		{
			Panel56.Visible = true;
			Label11.Text = "대기 중...";
			Button48.Text = "검색";
		}
		else
		{
			Panel56.Visible = false;
			Label11.Text = "대기 중...";
			Button48.Text = "검색 종료";
		}
		checked
		{
			try
			{
				ListView1.Hide();
				ListView1.Items.Clear();
				if (!Module1.search_mode)
				{
					Module1.datapageMAX = (int)Math.Ceiling((double)(Module1.AllData.Length - 1) / 499.0);
					int num = Module1.AllData.Length - 1;
					int num2 = 0;
					if (Module1.datapageMAX > 1)
					{
						num = 499;
					}
					if (page != 1)
					{
						num2 = (page - 1) * 500;
					}
					int num3 = num;
					for (int i = 0; i <= num3; i++)
					{
						Label55.Text = "자료를 정리 중 입니다... 잠시만 기다려 주세요. (" + Conversions.ToString(Math.Round((double)i / (double)num * 100.0)) + "%)";
						string[] array = Module1.AllData[num2 + i].Split(new string[1] { "%" }, StringSplitOptions.None);
						ListView1.Items.Add(array[0]);
						if (busy)
						{
							int num4 = array.Length - 1;
							for (int j = 1; j <= num4; j++)
							{
								ListView1.Items[i].SubItems.Add(array[j]);
							}
							Application.DoEvents();
							continue;
						}
						break;
					}
				}
				else
				{
					_ = Module1.SearchData.Length - 1;
					int num5 = Module1.SearchData.Length - 1;
					for (int k = 0; k <= num5; k++)
					{
						Label55.Text = "검색된 자료를 정리 중 입니다... 잠시만 기다려 주세요. (" + Conversions.ToString(Math.Round((double)k / (double)(Module1.SearchData.Length - 1) * 100.0)) + "%)";
						string[] array2 = Module1.SearchData[k].Split(new string[1] { "%" }, StringSplitOptions.None);
						ListView1.Items.Add(array2[0]);
						if (busy)
						{
							int num6 = array2.Length - 1;
							for (int l = 1; l <= num6; l++)
							{
								ListView1.Items[k].SubItems.Add(array2[l]);
							}
							Application.DoEvents();
							continue;
						}
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
			if (!Module1.search_mode)
			{
				Panel56.Visible = true;
				Label11.Text = "데이터 관리";
				Label55.Text = "모든 자료를 탐색 및 편집 할 수 있습니다. 합계: " + Conversions.ToString(Module1.AllData.Length) + " 레코드. 페이지 수: " + Conversions.ToString(Module1.datapageMAX);
				Button48.Text = "검색";
			}
			else
			{
				Panel56.Visible = false;
				Button48.Text = "검색 종료";
			}
			ListView1.Show();
			busy = false;
		}
	}

	public void RefreshSearch()
	{
		string hTML = new GetHtmlClass(Module1._dburl + "/util.php?type=getSettingsAdmin", null, progress: true).getHTML(MyProject.Forms.mlas);
		if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. getSettings", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		checked
		{
			try
			{
				string[] array = hTML.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string[] array2 = array[i].Split(new string[1] { "%" }, StringSplitOptions.None);
					string left = array2[1];
					if (Operators.CompareString(left, "search1", TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, "search2", TextCompare: false) == 0)
						{
							Module1.search2 = array2[2];
						}
					}
					else
					{
						Module1.search1 = array2[2];
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show("DB 환경설정이 잘못되었습니다. 제작사에 문의하여 주시기 바랍니다.\r\n\r\nERROR mlas_get_settings_exception", "환경설정 오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
				return;
			}
			ComboBox13.Items.Clear();
			ComboBox14.Items.Clear();
			hTML = new GetHtmlClass(Module1._dburl + "/search.php?type=folderlist&ftype=3", null, progress: true).getHTML(MyProject.Forms.mlas);
			if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
			{
				MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. folderlist", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			HAKs = hTML.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
			int num2 = HAKs.Length - 1;
			for (int j = 0; j <= num2; j++)
			{
				string[] array3 = HAKs[j].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.CompareString(array3[3], "0", TextCompare: false) != 0)
				{
					ComboBox13.Items.Add(array3[1]);
					ComboBox14.Items.Add(array3[1]);
				}
			}
			ComboBox13.Text = Conversions.ToString(Module1.search1);
			ComboBox14.Text = Conversions.ToString(Module1.search2);
		}
	}

	public void RefreshColumnName()
	{
		TextBox9.Text = null;
		string hTML = new GetHtmlClass(Module1._dburl + "/util.php?type=getSettingsAdmin", null, progress: true).getHTML(MyProject.Forms.mlas);
		if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. getSettings", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		checked
		{
			try
			{
				string[] array = hTML.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string[] array2 = array[i].Split(new string[1] { "%" }, StringSplitOptions.None);
					string left = array2[1];
					if (Operators.CompareString(left, "recordname", TextCompare: false) == 0)
					{
						Module1.record = array2[2].ToString().Split(new string[1] { "," }, StringSplitOptions.None);
						Module1.record = (string[])Utils.CopyArray(Module1.record, new string[101]);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show("DB 환경설정이 잘못되었습니다. 제작사에 문의하여 주시기 바랍니다.\r\n\r\nERROR mlas_get_settings_exception", "환경설정 오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
				return;
			}
			ListBox4.Items.Clear();
			_ = Module1.record;
			int num2 = 0;
			int num3 = 65;
			do
			{
				try
				{
					if (Operators.CompareString(Module1.record[num2], null, TextCompare: false) == 0)
					{
						ListBox4.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = NULL");
					}
					else
					{
						ListBox4.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = " + Module1.record[num2]);
					}
					num2++;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ListBox4.Items.Add(Conversions.ToString(num3) + " = NULL");
					num2++;
					ProjectData.ClearProjectError();
				}
				num3++;
			}
			while (num3 <= 90);
			int num4 = 1;
			do
			{
				try
				{
					if (Operators.CompareString(Module1.record[num2], null, TextCompare: false) == 0)
					{
						ListBox4.Items.Add(Conversions.ToString(num4) + " = NULL");
					}
					else
					{
						ListBox4.Items.Add(Conversions.ToString(num4) + " = " + Module1.record[num2]);
					}
					num2++;
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ListBox4.Items.Add(Conversions.ToString(num4) + " = NULL");
					num2++;
					ProjectData.ClearProjectError();
				}
				num4++;
			}
			while (num4 <= 29);
		}
	}

	public void RefreshView()
	{
		string hTML = new GetHtmlClass(Module1._dburl + "/util.php?type=getSettingsAdmin", null, progress: true).getHTML(MyProject.Forms.mlas);
		if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. getSettings", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		checked
		{
			try
			{
				string[] array = hTML.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string[] array2 = array[i].Split(new string[1] { "%" }, StringSplitOptions.None);
					string left = array2[1];
					if (Operators.CompareString(left, "column", TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, "recordname", TextCompare: false) == 0)
						{
							Module1.record = array2[2].ToString().Split(new string[1] { "," }, StringSplitOptions.None);
							Module1.record = (string[])Utils.CopyArray(Module1.record, new string[101]);
						}
					}
					else
					{
						Module1.column = array2[2].ToString().Split(new string[1] { "," }, StringSplitOptions.None);
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show("DB 환경설정이 잘못되었습니다. 제작사에 문의하여 주시기 바랍니다.\r\n\r\nERROR mlas_get_settings_exception", "환경설정 오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
				return;
			}
			ListBox5.Items.Clear();
			ListBox6.Items.Clear();
			ComboBox6.Items.Clear();
			ComboBox7.Items.Clear();
			ComboBox8.Items.Clear();
			ComboBox9.Items.Clear();
			ComboBox10.Items.Clear();
			ComboBox11.Items.Clear();
			ComboBox12.Items.Clear();
			_ = Module1.record;
			int num2 = 0;
			int num3 = 65;
			do
			{
				try
				{
					if (Operators.CompareString(Module1.record[num2], null, TextCompare: false) == 0)
					{
						ComboBox6.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = NULL");
						ComboBox7.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = NULL");
						ComboBox8.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = NULL");
						ComboBox9.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = NULL");
						ComboBox10.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = NULL");
						ComboBox11.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = NULL");
						ComboBox12.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = NULL");
					}
					else
					{
						ComboBox6.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = " + Module1.record[num2]);
						ComboBox7.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = " + Module1.record[num2]);
						ComboBox8.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = " + Module1.record[num2]);
						ComboBox9.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = " + Module1.record[num2]);
						ComboBox10.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = " + Module1.record[num2]);
						ComboBox11.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = " + Module1.record[num2]);
						ComboBox12.Items.Add(Conversions.ToString(Strings.ChrW(num3)) + " = " + Module1.record[num2]);
					}
					num2++;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ListBox4.Items.Add(Conversions.ToString(num3) + " = NULL");
					num2++;
					ProjectData.ClearProjectError();
				}
				num3++;
			}
			while (num3 <= 90);
			int num4 = 1;
			do
			{
				try
				{
					if (Operators.CompareString(Module1.record[num2], null, TextCompare: false) == 0)
					{
						ComboBox6.Items.Add(Conversions.ToString(num4) + " = NULL");
						ComboBox7.Items.Add(Conversions.ToString(num4) + " = NULL");
						ComboBox8.Items.Add(Conversions.ToString(num4) + " = NULL");
						ComboBox9.Items.Add(Conversions.ToString(num4) + " = NULL");
						ComboBox10.Items.Add(Conversions.ToString(num4) + " = NULL");
						ComboBox11.Items.Add(Conversions.ToString(num4) + " = NULL");
						ComboBox12.Items.Add(Conversions.ToString(num4) + " = NULL");
					}
					else
					{
						ComboBox6.Items.Add(Conversions.ToString(num4) + " = " + Module1.record[num2]);
						ComboBox7.Items.Add(Conversions.ToString(num4) + " = " + Module1.record[num2]);
						ComboBox8.Items.Add(Conversions.ToString(num4) + " = " + Module1.record[num2]);
						ComboBox9.Items.Add(Conversions.ToString(num4) + " = " + Module1.record[num2]);
						ComboBox10.Items.Add(Conversions.ToString(num4) + " = " + Module1.record[num2]);
						ComboBox11.Items.Add(Conversions.ToString(num4) + " = " + Module1.record[num2]);
						ComboBox12.Items.Add(Conversions.ToString(num4) + " = " + Module1.record[num2]);
					}
					num2++;
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					num2++;
					ProjectData.ClearProjectError();
				}
				num4++;
			}
			while (num4 <= 29);
			int num5 = Module1.column.Length - 1;
			for (int j = 0; j <= num5; j++)
			{
				switch (j)
				{
				case 0:
					ComboBox6.Text = Conversions.ToString(Operators.ConcatenateObject(Module1.column[j] + " = ", ChrToColumn(Module1.column[j])));
					continue;
				case 1:
					ComboBox7.Text = Conversions.ToString(Operators.ConcatenateObject(Module1.column[j] + " = ", ChrToColumn(Module1.column[j])));
					continue;
				case 5:
					ComboBox8.Text = Conversions.ToString(Operators.ConcatenateObject(Module1.column[j] + " = ", ChrToColumn(Module1.column[j])));
					continue;
				case 6:
					ComboBox9.Text = Conversions.ToString(Operators.ConcatenateObject(Module1.column[j] + " = ", ChrToColumn(Module1.column[j])));
					continue;
				case 7:
					ComboBox10.Text = Conversions.ToString(Operators.ConcatenateObject(Module1.column[j] + " = ", ChrToColumn(Module1.column[j])));
					continue;
				case 8:
					ComboBox11.Text = Conversions.ToString(Operators.ConcatenateObject(Module1.column[j] + " = ", ChrToColumn(Module1.column[j])));
					continue;
				case 9:
					ComboBox12.Text = Conversions.ToString(Operators.ConcatenateObject(Module1.column[j] + " = ", ChrToColumn(Module1.column[j])));
					continue;
				}
				if (Operators.CompareString(Module1.column[j], null, TextCompare: false) != 0)
				{
					ListBox6.Items.Add(Operators.ConcatenateObject(Module1.column[j] + " = ", ChrToColumn(Module1.column[j])));
				}
			}
			num2 = 0;
			int num6 = 65;
			do
			{
				try
				{
					if (Operators.CompareString(Module1.record[num2], null, TextCompare: false) == 0)
					{
						ListBox5.Items.Add(Conversions.ToString(Strings.ChrW(num6)) + " = NULL");
					}
					else
					{
						ListBox5.Items.Add(Conversions.ToString(Strings.ChrW(num6)) + " = " + Module1.record[num2]);
					}
					num2++;
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					num2++;
					ProjectData.ClearProjectError();
				}
				num6++;
			}
			while (num6 <= 90);
			int num7 = 1;
			do
			{
				try
				{
					if (Operators.CompareString(Module1.record[num2], null, TextCompare: false) == 0)
					{
						ListBox5.Items.Add(Conversions.ToString(num7) + " = NULL");
					}
					else
					{
						ListBox5.Items.Add(Conversions.ToString(num7) + " = " + Module1.record[num2]);
					}
					num2++;
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception ex10 = ex9;
					ListBox5.Items.Add(Conversions.ToString(num7) + " = NULL");
					num2++;
					ProjectData.ClearProjectError();
				}
				num7++;
			}
			while (num7 <= 29);
		}
	}

	public void RefreshFolder()
	{
		TextBox8.Text = null;
		ListBox3.Items.Clear();
		ComboBox2.Items.Clear();
		ComboBox4.Items.Clear();
		ComboBox5.Items.Clear();
		ListBox2.Items.Clear();
		Panel13.Hide();
		string hTML = new GetHtmlClass(Module1._dburl + "/search.php?type=folderlist&ftype=3", null, progress: true).getHTML(MyProject.Forms.mlas);
		if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. folderlist", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		HAKs = hTML.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		checked
		{
			int num = HAKs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.CompareString(array[3], "0", TextCompare: false) == 0)
				{
					ComboBox5.Items.Add(array[1]);
					continue;
				}
				ComboBox2.Items.Add(array[1]);
				ComboBox4.Items.Add(array[1]);
				ListBox2.Items.Add(array[1]);
			}
		}
	}

	public void RefreshNote()
	{
		TextBox5.Text = null;
		ListBox7.DataSource = null;
		Panel52.Visible = false;
		ComboBox3.Items.Clear();
		string hTML = new GetHtmlClass(Module1._dburl + "/search.php?type=folderlist&ftype=3", null, progress: true).getHTML(MyProject.Forms.mlas);
		if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. folderlist", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		HAKs = hTML.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		checked
		{
			int num = HAKs.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = HAKs[i].Split(new string[1] { "%" }, StringSplitOptions.None);
				if (Operators.CompareString(array[3], "0", TextCompare: false) != 0)
				{
					ComboBox3.Items.Add(array[1]);
				}
			}
		}
	}

	private void Button52_Click(object sender, EventArgs e)
	{
		RefreshFolder();
	}

	private void Button19_Click(object sender, EventArgs e)
	{
		RefreshNote();
	}

	private void Button77_Click(object sender, EventArgs e)
	{
		RefreshFolder();
		alldata_load();
	}

	private void Button56_Click(object sender, EventArgs e)
	{
		RefreshSearch();
	}

	private void Button60_Click(object sender, EventArgs e)
	{
		RefreshColumnName();
	}

	private void Button55_Click(object sender, EventArgs e)
	{
		RefreshView();
	}

	private void Button57_Click(object sender, EventArgs e)
	{
		notice_refresh();
	}

	private void Button58_Click(object sender, EventArgs e)
	{
		RefreshFolder();
	}
}
