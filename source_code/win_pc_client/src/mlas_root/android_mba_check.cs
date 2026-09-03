using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
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
public class android_mba_check : Form
{
	private IContainer components;

	private bool init;

	private WebBrowser bw;

	private Label lb;

	private Button btn;

	private Panel pn;

	private bool editMode;

	private bool busy;

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
	internal virtual DoubleBufferPanel p1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel73")]
	internal virtual DoubleBufferPanel Panel73
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox11")]
	internal virtual PictureBox PictureBox11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label93")]
	internal virtual Label Label93
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel74")]
	internal virtual DoubleBufferPanel Panel74
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label91")]
	internal virtual Label Label91
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox28
	{
		[CompilerGenerated]
		get
		{
			return _TextBox28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox28_TextChanged;
			TextBox textBox = _TextBox28;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox28 = value;
			textBox = _TextBox28;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label79")]
	internal virtual Label Label79
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox26")]
	internal virtual TextBox TextBox26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label96")]
	internal virtual Label Label96
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel64")]
	internal virtual DoubleBufferPanel Panel64
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListBox ListBox11
	{
		[CompilerGenerated]
		get
		{
			return _ListBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ListBox11_SelectedIndexChanged_1;
			DrawItemEventHandler value3 = DrawItem;
			ListBox listBox = _ListBox11;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value2;
				listBox.DrawItem -= value3;
			}
			_ListBox11 = value;
			listBox = _ListBox11;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value2;
				listBox.DrawItem += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Panel80")]
	internal virtual DoubleBufferPanel Panel80
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button83
	{
		[CompilerGenerated]
		get
		{
			return _Button83;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button83_Click;
			Button button = _Button83;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button83 = value;
			button = _Button83;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button80
	{
		[CompilerGenerated]
		get
		{
			return _Button80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button80_Click;
			Button button = _Button80;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button80 = value;
			button = _Button80;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label92")]
	internal virtual Label Label92
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel75")]
	internal virtual DoubleBufferPanel Panel75
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel76")]
	internal virtual DoubleBufferPanel Panel76
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label98")]
	internal virtual Label Label98
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label99")]
	internal virtual Label Label99
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel77")]
	internal virtual DoubleBufferPanel Panel77
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel78")]
	internal virtual DoubleBufferPanel Panel78
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel79")]
	internal virtual DoubleBufferPanel Panel79
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button87
	{
		[CompilerGenerated]
		get
		{
			return _Button87;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button87_Click;
			Button button = _Button87;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button87 = value;
			button = _Button87;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button90
	{
		[CompilerGenerated]
		get
		{
			return _Button90;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button90_Click;
			Button button = _Button90;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button90 = value;
			button = _Button90;
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

	[field: AccessedThroughProperty("TextBox23")]
	internal virtual TextBox TextBox23
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

	[field: AccessedThroughProperty("Panel109")]
	internal virtual DoubleBufferPanel Panel109
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

	[field: AccessedThroughProperty("TextBox25")]
	internal virtual TextBox TextBox25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox24")]
	internal virtual TextBox TextBox24
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

	[field: AccessedThroughProperty("Label88")]
	internal virtual Label Label88
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

	[field: AccessedThroughProperty("Label89")]
	internal virtual Label Label89
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

	internal virtual Button Button74
	{
		[CompilerGenerated]
		get
		{
			return _Button74;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button74_Click;
			Button button = _Button74;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button74 = value;
			button = _Button74;
			if (button != null)
			{
				button.Click += value2;
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
			EventHandler value2 = TextBox1_TextChanged;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("p3")]
	internal virtual DoubleBufferPanel p3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p3_centerpanel")]
	internal virtual DoubleBufferPanel p3_centerpanel
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

	[field: AccessedThroughProperty("DoubleBufferPanel2")]
	internal virtual DoubleBufferPanel DoubleBufferPanel2
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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
			EventHandler value2 = Button1_Click_1;
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
			EventHandler value2 = Button2_Click_1;
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

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
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

	[field: AccessedThroughProperty("DoubleBufferPanel4")]
	internal virtual DoubleBufferPanel DoubleBufferPanel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("DoubleBufferPanel5")]
	internal virtual DoubleBufferPanel DoubleBufferPanel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler value2 = TextBox4_TextChanged;
			TextBox textBox = _TextBox4;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox4 = value;
			textBox = _TextBox4;
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

	internal virtual TextBox TextBox5
	{
		[CompilerGenerated]
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox5_TextChanged;
			TextBox textBox = _TextBox5;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox5 = value;
			textBox = _TextBox5;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("DoubleBufferPanel6")]
	internal virtual DoubleBufferPanel DoubleBufferPanel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListBox ListBox1
	{
		[CompilerGenerated]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = DrawItem;
			EventHandler value3 = ListBox1_SelectedIndexChanged;
			ListBox listBox = _ListBox1;
			if (listBox != null)
			{
				listBox.DrawItem -= value2;
				listBox.SelectedIndexChanged -= value3;
			}
			_ListBox1 = value;
			listBox = _ListBox1;
			if (listBox != null)
			{
				listBox.DrawItem += value2;
				listBox.SelectedIndexChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel7")]
	internal virtual DoubleBufferPanel DoubleBufferPanel7
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel8")]
	internal virtual DoubleBufferPanel DoubleBufferPanel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel13")]
	internal virtual DoubleBufferPanel DoubleBufferPanel13
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn10")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column3")]
	internal virtual DataGridViewTextBoxColumn Column3
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

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewTextBoxColumn Column2
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
	internal virtual DoubleBufferPanel p5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox34")]
	internal virtual TextBox TextBox34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WebBrowser1")]
	internal virtual WebBrowser WebBrowser1
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

	[field: AccessedThroughProperty("Label58")]
	internal virtual Label Label58
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button165")]
	internal virtual Button Button165
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button164
	{
		[CompilerGenerated]
		get
		{
			return _Button164;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button164_Click;
			Button button = _Button164;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button164 = value;
			button = _Button164;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel17")]
	internal virtual DoubleBufferPanel DoubleBufferPanel17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox13")]
	internal virtual CheckBox CheckBox13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button159")]
	internal virtual Button Button159
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox37")]
	internal virtual TextBox TextBox37
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label128")]
	internal virtual Label Label128
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label129")]
	internal virtual Label Label129
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button160
	{
		[CompilerGenerated]
		get
		{
			return _Button160;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button160_Click;
			Button button = _Button160;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button160 = value;
			button = _Button160;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label130")]
	internal virtual Label Label130
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBoxEx ComboBoxEx2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBoxEx2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBoxEx2_SelectedIndexChanged;
			ComboBoxEx comboBoxEx = _ComboBoxEx2;
			if (comboBoxEx != null)
			{
				comboBoxEx.SelectedIndexChanged -= value2;
			}
			_ComboBoxEx2 = value;
			comboBoxEx = _ComboBoxEx2;
			if (comboBoxEx != null)
			{
				comboBoxEx.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel18")]
	internal virtual DoubleBufferPanel DoubleBufferPanel18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel19")]
	internal virtual DoubleBufferPanel DoubleBufferPanel19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label132")]
	internal virtual Label Label132
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

	[field: AccessedThroughProperty("Label134")]
	internal virtual Label Label134
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

	[field: AccessedThroughProperty("DoubleBufferPanel22")]
	internal virtual DoubleBufferPanel DoubleBufferPanel22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel23")]
	internal virtual DoubleBufferPanel DoubleBufferPanel23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel24")]
	internal virtual DoubleBufferPanel DoubleBufferPanel24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button161
	{
		[CompilerGenerated]
		get
		{
			return _Button161;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button161_Click;
			Button button = _Button161;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button161 = value;
			button = _Button161;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button162
	{
		[CompilerGenerated]
		get
		{
			return _Button162;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button162_Click;
			Button button = _Button162;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button162 = value;
			button = _Button162;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button163
	{
		[CompilerGenerated]
		get
		{
			return _Button163;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button163_Click;
			Button button = _Button163;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button163 = value;
			button = _Button163;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual DataGridView mba_accountGrid
	{
		[CompilerGenerated]
		get
		{
			return _mba_accountGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = mba_accountGrid_CellContentClick;
			DataGridView dataGridView = _mba_accountGrid;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick -= value2;
			}
			_mba_accountGrid = value;
			dataGridView = _mba_accountGrid;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick += value2;
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

	public android_mba_check()
	{
		init = false;
		bw = new WebBrowser();
		lb = new Label();
		btn = new Button();
		editMode = false;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.android_mba_check));
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.p3 = new mlas_root.DoubleBufferPanel();
		this.p3_centerpanel = new mlas_root.DoubleBufferPanel();
		this.mba_accountGrid = new System.Windows.Forms.DataGridView();
		this.DataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DoubleBufferPanel1 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel2 = new mlas_root.DoubleBufferPanel();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel9 = new mlas_root.DoubleBufferPanel();
		this.Button7 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button14 = new System.Windows.Forms.Button();
		this.Button15 = new System.Windows.Forms.Button();
		this.DoubleBufferPanel10 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel11 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel12 = new mlas_root.DoubleBufferPanel();
		this.Button1 = new System.Windows.Forms.Button();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.p1 = new mlas_root.DoubleBufferPanel();
		this.Panel73 = new mlas_root.DoubleBufferPanel();
		this.PictureBox11 = new System.Windows.Forms.PictureBox();
		this.Label93 = new System.Windows.Forms.Label();
		this.Panel74 = new mlas_root.DoubleBufferPanel();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label91 = new System.Windows.Forms.Label();
		this.TextBox28 = new System.Windows.Forms.TextBox();
		this.Label79 = new System.Windows.Forms.Label();
		this.TextBox26 = new System.Windows.Forms.TextBox();
		this.Label96 = new System.Windows.Forms.Label();
		this.Panel64 = new mlas_root.DoubleBufferPanel();
		this.ListBox11 = new System.Windows.Forms.ListBox();
		this.Panel80 = new mlas_root.DoubleBufferPanel();
		this.Button83 = new System.Windows.Forms.Button();
		this.Button80 = new System.Windows.Forms.Button();
		this.Label92 = new System.Windows.Forms.Label();
		this.Panel75 = new mlas_root.DoubleBufferPanel();
		this.Panel76 = new mlas_root.DoubleBufferPanel();
		this.Label98 = new System.Windows.Forms.Label();
		this.Label99 = new System.Windows.Forms.Label();
		this.Panel77 = new mlas_root.DoubleBufferPanel();
		this.Panel78 = new mlas_root.DoubleBufferPanel();
		this.Panel79 = new mlas_root.DoubleBufferPanel();
		this.Button87 = new System.Windows.Forms.Button();
		this.Button90 = new System.Windows.Forms.Button();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.p4 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel4 = new mlas_root.DoubleBufferPanel();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel5 = new mlas_root.DoubleBufferPanel();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.TextBox5 = new System.Windows.Forms.TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel6 = new mlas_root.DoubleBufferPanel();
		this.ListBox1 = new System.Windows.Forms.ListBox();
		this.DoubleBufferPanel7 = new mlas_root.DoubleBufferPanel();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Label7 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel8 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel13 = new mlas_root.DoubleBufferPanel();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel14 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel15 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel16 = new mlas_root.DoubleBufferPanel();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button6 = new System.Windows.Forms.Button();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.p2 = new mlas_root.DoubleBufferPanel();
		this.TextBox23 = new System.Windows.Forms.TextBox();
		this.Panel49 = new mlas_root.DoubleBufferPanel();
		this.Panel109 = new mlas_root.DoubleBufferPanel();
		this.Label30 = new System.Windows.Forms.Label();
		this.TextBox25 = new System.Windows.Forms.TextBox();
		this.TextBox24 = new System.Windows.Forms.TextBox();
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
		this.Button85 = new System.Windows.Forms.Button();
		this.Button86 = new System.Windows.Forms.Button();
		this.Button74 = new System.Windows.Forms.Button();
		this.TabPage5 = new System.Windows.Forms.TabPage();
		this.p5 = new mlas_root.DoubleBufferPanel();
		this.TextBox34 = new System.Windows.Forms.TextBox();
		this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
		this.DoubleBufferPanel3 = new mlas_root.DoubleBufferPanel();
		this.Label58 = new System.Windows.Forms.Label();
		this.Button165 = new System.Windows.Forms.Button();
		this.Button164 = new System.Windows.Forms.Button();
		this.DoubleBufferPanel17 = new mlas_root.DoubleBufferPanel();
		this.CheckBox13 = new System.Windows.Forms.CheckBox();
		this.Button159 = new System.Windows.Forms.Button();
		this.TextBox37 = new System.Windows.Forms.TextBox();
		this.Label128 = new System.Windows.Forms.Label();
		this.Label129 = new System.Windows.Forms.Label();
		this.Button160 = new System.Windows.Forms.Button();
		this.Label130 = new System.Windows.Forms.Label();
		this.ComboBoxEx2 = new mlas_root.ComboBoxEx();
		this.DoubleBufferPanel18 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel19 = new mlas_root.DoubleBufferPanel();
		this.Label132 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel20 = new mlas_root.DoubleBufferPanel();
		this.Label134 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel21 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel22 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel23 = new mlas_root.DoubleBufferPanel();
		this.DoubleBufferPanel24 = new mlas_root.DoubleBufferPanel();
		this.Button161 = new System.Windows.Forms.Button();
		this.Button162 = new System.Windows.Forms.Button();
		this.Button163 = new System.Windows.Forms.Button();
		this.TabControl1.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.p3.SuspendLayout();
		this.p3_centerpanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.mba_accountGrid).BeginInit();
		this.DoubleBufferPanel1.SuspendLayout();
		this.DoubleBufferPanel9.SuspendLayout();
		this.DoubleBufferPanel12.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.p1.SuspendLayout();
		this.Panel73.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox11).BeginInit();
		this.Panel74.SuspendLayout();
		this.Panel64.SuspendLayout();
		this.Panel80.SuspendLayout();
		this.Panel75.SuspendLayout();
		this.Panel79.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.p4.SuspendLayout();
		this.DoubleBufferPanel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.DoubleBufferPanel5.SuspendLayout();
		this.DoubleBufferPanel6.SuspendLayout();
		this.DoubleBufferPanel7.SuspendLayout();
		this.DoubleBufferPanel8.SuspendLayout();
		this.DoubleBufferPanel16.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.p2.SuspendLayout();
		this.Panel109.SuspendLayout();
		this.Panel112.SuspendLayout();
		this.Panel113.SuspendLayout();
		this.Panel103.SuspendLayout();
		this.TabPage5.SuspendLayout();
		this.p5.SuspendLayout();
		this.DoubleBufferPanel3.SuspendLayout();
		this.DoubleBufferPanel17.SuspendLayout();
		this.DoubleBufferPanel18.SuspendLayout();
		this.DoubleBufferPanel19.SuspendLayout();
		this.DoubleBufferPanel24.SuspendLayout();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage5);
		this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabControl1.Location = new System.Drawing.Point(0, 0);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(876, 709);
		this.TabControl1.TabIndex = 0;
		this.TabPage3.Controls.Add(this.p3);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(868, 683);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "회원관리";
		this.TabPage3.UseVisualStyleBackColor = true;
		this.p3.BackColor = System.Drawing.Color.Transparent;
		this.p3.Controls.Add(this.p3_centerpanel);
		this.p3.Controls.Add(this.DoubleBufferPanel9);
		this.p3.Controls.Add(this.DoubleBufferPanel10);
		this.p3.Controls.Add(this.DoubleBufferPanel11);
		this.p3.Controls.Add(this.DoubleBufferPanel12);
		this.p3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p3.Location = new System.Drawing.Point(0, 0);
		this.p3.Name = "p3";
		this.p3.Size = new System.Drawing.Size(868, 683);
		this.p3.TabIndex = 17;
		this.p3_centerpanel.Controls.Add(this.mba_accountGrid);
		this.p3_centerpanel.Controls.Add(this.DoubleBufferPanel1);
		this.p3_centerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p3_centerpanel.Location = new System.Drawing.Point(23, 0);
		this.p3_centerpanel.Name = "p3_centerpanel";
		this.p3_centerpanel.Size = new System.Drawing.Size(822, 595);
		this.p3_centerpanel.TabIndex = 57;
		this.mba_accountGrid.AllowUserToAddRows = false;
		this.mba_accountGrid.AllowUserToDeleteRows = false;
		this.mba_accountGrid.AllowUserToOrderColumns = true;
		this.mba_accountGrid.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.mba_accountGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.mba_accountGrid.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.Format = "C2";
		dataGridViewCellStyle2.NullValue = "0";
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.mba_accountGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.mba_accountGrid.ColumnHeadersHeight = 28;
		this.mba_accountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.mba_accountGrid.Columns.AddRange(this.DataGridViewCheckBoxColumn2, this.DataGridViewTextBoxColumn8, this.DataGridViewTextBoxColumn9, this.DataGridViewTextBoxColumn10, this.Column3, this.Column4, this.Column1, this.Column2);
		this.mba_accountGrid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mba_accountGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
		this.mba_accountGrid.EnableHeadersVisualStyles = false;
		this.mba_accountGrid.GridColor = System.Drawing.Color.DarkGray;
		this.mba_accountGrid.Location = new System.Drawing.Point(0, 56);
		this.mba_accountGrid.Name = "mba_accountGrid";
		this.mba_accountGrid.RowHeadersVisible = false;
		this.mba_accountGrid.RowHeadersWidth = 40;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.mba_accountGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
		this.mba_accountGrid.RowTemplate.Height = 30;
		this.mba_accountGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.mba_accountGrid.Size = new System.Drawing.Size(822, 539);
		this.mba_accountGrid.TabIndex = 56;
		this.DataGridViewCheckBoxColumn2.Frozen = true;
		this.DataGridViewCheckBoxColumn2.HeaderText = "";
		this.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2";
		this.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridViewCheckBoxColumn2.Width = 30;
		this.DataGridViewTextBoxColumn8.HeaderText = "번호";
		this.DataGridViewTextBoxColumn8.MaxInputLength = 4;
		this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
		this.DataGridViewTextBoxColumn8.ReadOnly = true;
		this.DataGridViewTextBoxColumn8.Width = 40;
		this.DataGridViewTextBoxColumn9.HeaderText = "이메일";
		this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
		this.DataGridViewTextBoxColumn9.ReadOnly = true;
		this.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn9.Width = 180;
		this.DataGridViewTextBoxColumn10.HeaderText = "학원명";
		this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
		this.DataGridViewTextBoxColumn10.ReadOnly = true;
		this.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridViewTextBoxColumn10.Width = 140;
		this.Column3.HeaderText = "사용자 이름";
		this.Column3.Name = "Column3";
		this.Column3.ReadOnly = true;
		this.Column4.HeaderText = "휴대폰 번호";
		this.Column4.Name = "Column4";
		this.Column4.ReadOnly = true;
		this.Column4.Width = 120;
		this.Column1.HeaderText = "상태";
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.Column1.Width = 90;
		this.Column2.HeaderText = "가입된 앱";
		this.Column2.Name = "Column2";
		this.Column2.ReadOnly = true;
		this.Column2.Width = 90;
		this.DoubleBufferPanel1.Controls.Add(this.DoubleBufferPanel2);
		this.DoubleBufferPanel1.Controls.Add(this.Label1);
		this.DoubleBufferPanel1.Controls.Add(this.Label2);
		this.DoubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel1.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel1.Name = "DoubleBufferPanel1";
		this.DoubleBufferPanel1.Size = new System.Drawing.Size(822, 56);
		this.DoubleBufferPanel1.TabIndex = 57;
		this.DoubleBufferPanel2.BackColor = System.Drawing.Color.Gray;
		this.DoubleBufferPanel2.Location = new System.Drawing.Point(111, 41);
		this.DoubleBufferPanel2.Name = "DoubleBufferPanel2";
		this.DoubleBufferPanel2.Size = new System.Drawing.Size(2000, 1);
		this.DoubleBufferPanel2.TabIndex = 3;
		this.Label1.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label1.Location = new System.Drawing.Point(109, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(595, 30);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "여기에서 회원을 관리합니다.";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label2.Location = new System.Drawing.Point(0, 15);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(109, 30);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "회원 관리";
		this.DoubleBufferPanel9.Controls.Add(this.Button7);
		this.DoubleBufferPanel9.Controls.Add(this.Button2);
		this.DoubleBufferPanel9.Controls.Add(this.Button14);
		this.DoubleBufferPanel9.Controls.Add(this.Button15);
		this.DoubleBufferPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel9.Location = new System.Drawing.Point(23, 595);
		this.DoubleBufferPanel9.Name = "DoubleBufferPanel9";
		this.DoubleBufferPanel9.Padding = new System.Windows.Forms.Padding(5);
		this.DoubleBufferPanel9.Size = new System.Drawing.Size(822, 44);
		this.DoubleBufferPanel9.TabIndex = 53;
		this.Button7.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button7.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button7.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button7.ForeColor = System.Drawing.Color.White;
		this.Button7.Location = new System.Drawing.Point(505, 5);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(106, 34);
		this.Button7.TabIndex = 83;
		this.Button7.Text = "선택 자료\r\n엑셀 내보내기";
		this.Button7.UseVisualStyleBackColor = false;
		this.Button2.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
		this.Button2.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = System.Drawing.Color.White;
		this.Button2.Location = new System.Drawing.Point(611, 5);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(103, 34);
		this.Button2.TabIndex = 80;
		this.Button2.Text = "선택\r\n계정 활성/정지";
		this.Button2.UseVisualStyleBackColor = false;
		this.Button14.BackColor = System.Drawing.Color.Red;
		this.Button14.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button14.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button14.ForeColor = System.Drawing.Color.White;
		this.Button14.Location = new System.Drawing.Point(714, 5);
		this.Button14.Name = "Button14";
		this.Button14.Size = new System.Drawing.Size(103, 34);
		this.Button14.TabIndex = 78;
		this.Button14.Text = "선택 영구 삭제";
		this.Button14.UseVisualStyleBackColor = false;
		this.Button15.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button15.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button15.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button15.ForeColor = System.Drawing.Color.White;
		this.Button15.Location = new System.Drawing.Point(5, 5);
		this.Button15.Name = "Button15";
		this.Button15.Size = new System.Drawing.Size(83, 34);
		this.Button15.TabIndex = 79;
		this.Button15.Text = "전체 선택";
		this.Button15.UseVisualStyleBackColor = false;
		this.DoubleBufferPanel10.Dock = System.Windows.Forms.DockStyle.Left;
		this.DoubleBufferPanel10.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel10.Name = "DoubleBufferPanel10";
		this.DoubleBufferPanel10.Size = new System.Drawing.Size(23, 639);
		this.DoubleBufferPanel10.TabIndex = 43;
		this.DoubleBufferPanel11.Dock = System.Windows.Forms.DockStyle.Right;
		this.DoubleBufferPanel11.Location = new System.Drawing.Point(845, 0);
		this.DoubleBufferPanel11.Name = "DoubleBufferPanel11";
		this.DoubleBufferPanel11.Size = new System.Drawing.Size(23, 639);
		this.DoubleBufferPanel11.TabIndex = 44;
		this.DoubleBufferPanel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel12.Controls.Add(this.Button1);
		this.DoubleBufferPanel12.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel12.Location = new System.Drawing.Point(0, 639);
		this.DoubleBufferPanel12.Name = "DoubleBufferPanel12";
		this.DoubleBufferPanel12.Padding = new System.Windows.Forms.Padding(5);
		this.DoubleBufferPanel12.Size = new System.Drawing.Size(868, 44);
		this.DoubleBufferPanel12.TabIndex = 46;
		this.Button1.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button1.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(5, 5);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(80, 32);
		this.Button1.TabIndex = 78;
		this.Button1.Text = "새로고침";
		this.Button1.UseVisualStyleBackColor = false;
		this.TabPage1.Controls.Add(this.p1);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new System.Drawing.Size(868, 683);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "광고관리(MOM출첵)";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.p1.BackColor = System.Drawing.Color.Transparent;
		this.p1.Controls.Add(this.Panel73);
		this.p1.Controls.Add(this.Panel64);
		this.p1.Controls.Add(this.Panel75);
		this.p1.Controls.Add(this.Panel77);
		this.p1.Controls.Add(this.Panel78);
		this.p1.Controls.Add(this.Panel79);
		this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p1.Location = new System.Drawing.Point(0, 0);
		this.p1.Name = "p1";
		this.p1.Size = new System.Drawing.Size(868, 683);
		this.p1.TabIndex = 17;
		this.p1.Visible = false;
		this.Panel73.Controls.Add(this.PictureBox11);
		this.Panel73.Controls.Add(this.Label93);
		this.Panel73.Controls.Add(this.Panel74);
		this.Panel73.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel73.Location = new System.Drawing.Point(294, 56);
		this.Panel73.Name = "Panel73";
		this.Panel73.Size = new System.Drawing.Size(551, 583);
		this.Panel73.TabIndex = 34;
		this.PictureBox11.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.PictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.PictureBox11.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PictureBox11.Location = new System.Drawing.Point(0, 29);
		this.PictureBox11.Name = "PictureBox11";
		this.PictureBox11.Size = new System.Drawing.Size(551, 352);
		this.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox11.TabIndex = 16;
		this.PictureBox11.TabStop = false;
		this.Label93.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label93.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label93.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label93.Location = new System.Drawing.Point(0, 0);
		this.Label93.Name = "Label93";
		this.Label93.Size = new System.Drawing.Size(551, 29);
		this.Label93.TabIndex = 7;
		this.Label93.Text = "미리보기";
		this.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Panel74.BackColor = System.Drawing.Color.Gainsboro;
		this.Panel74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel74.Controls.Add(this.TextBox2);
		this.Panel74.Controls.Add(this.TextBox1);
		this.Panel74.Controls.Add(this.Label91);
		this.Panel74.Controls.Add(this.TextBox28);
		this.Panel74.Controls.Add(this.Label79);
		this.Panel74.Controls.Add(this.TextBox26);
		this.Panel74.Controls.Add(this.Label96);
		this.Panel74.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel74.Location = new System.Drawing.Point(0, 381);
		this.Panel74.Name = "Panel74";
		this.Panel74.Size = new System.Drawing.Size(551, 202);
		this.Panel74.TabIndex = 32;
		this.Panel74.Visible = false;
		this.TextBox2.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox2.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox2.ImeMode = System.Windows.Forms.ImeMode.Alpha;
		this.TextBox2.Location = new System.Drawing.Point(158, 5);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(324, 25);
		this.TextBox2.TabIndex = 63;
		this.TextBox2.Visible = false;
		this.TextBox1.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
		this.TextBox1.Location = new System.Drawing.Point(44, 43);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(324, 25);
		this.TextBox1.TabIndex = 62;
		this.Label91.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label91.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label91.Location = new System.Drawing.Point(9, 123);
		this.Label91.Name = "Label91";
		this.Label91.Size = new System.Drawing.Size(100, 25);
		this.Label91.TabIndex = 59;
		this.Label91.Text = "연결될 주소";
		this.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox28.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox28.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox28.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox28.Location = new System.Drawing.Point(44, 148);
		this.TextBox28.Name = "TextBox28";
		this.TextBox28.Size = new System.Drawing.Size(468, 25);
		this.TextBox28.TabIndex = 58;
		this.Label79.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label79.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label79.Location = new System.Drawing.Point(9, 71);
		this.Label79.Name = "Label79";
		this.Label79.Size = new System.Drawing.Size(86, 25);
		this.Label79.TabIndex = 57;
		this.Label79.Text = "파일 이름";
		this.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox26.BackColor = System.Drawing.Color.FromArgb(210, 210, 210);
		this.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox26.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox26.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox26.ImeMode = System.Windows.Forms.ImeMode.Alpha;
		this.TextBox26.Location = new System.Drawing.Point(44, 96);
		this.TextBox26.Name = "TextBox26";
		this.TextBox26.ReadOnly = true;
		this.TextBox26.Size = new System.Drawing.Size(324, 25);
		this.TextBox26.TabIndex = 56;
		this.Label96.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label96.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label96.Location = new System.Drawing.Point(13, 18);
		this.Label96.Name = "Label96";
		this.Label96.Size = new System.Drawing.Size(82, 25);
		this.Label96.TabIndex = 53;
		this.Label96.Text = "배너 이름";
		this.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel64.Controls.Add(this.ListBox11);
		this.Panel64.Controls.Add(this.Panel80);
		this.Panel64.Controls.Add(this.Label92);
		this.Panel64.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel64.Location = new System.Drawing.Point(23, 56);
		this.Panel64.Name = "Panel64";
		this.Panel64.Size = new System.Drawing.Size(271, 583);
		this.Panel64.TabIndex = 33;
		this.ListBox11.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.ListBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListBox11.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListBox11.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ListBox11.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox11.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListBox11.FormattingEnabled = true;
		this.ListBox11.ItemHeight = 21;
		this.ListBox11.Location = new System.Drawing.Point(0, 29);
		this.ListBox11.Name = "ListBox11";
		this.ListBox11.Size = new System.Drawing.Size(271, 524);
		this.ListBox11.TabIndex = 7;
		this.Panel80.Controls.Add(this.Button83);
		this.Panel80.Controls.Add(this.Button80);
		this.Panel80.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel80.Location = new System.Drawing.Point(0, 553);
		this.Panel80.Name = "Panel80";
		this.Panel80.Size = new System.Drawing.Size(271, 30);
		this.Panel80.TabIndex = 15;
		this.Button83.BackColor = System.Drawing.Color.Red;
		this.Button83.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button83.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button83.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Button83.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button83.ForeColor = System.Drawing.Color.White;
		this.Button83.Location = new System.Drawing.Point(133, 0);
		this.Button83.Name = "Button83";
		this.Button83.Size = new System.Drawing.Size(138, 30);
		this.Button83.TabIndex = 14;
		this.Button83.Text = "선택 제거";
		this.Button83.UseVisualStyleBackColor = false;
		this.Button80.BackColor = System.Drawing.Color.DarkGreen;
		this.Button80.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button80.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button80.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button80.ForeColor = System.Drawing.Color.White;
		this.Button80.Location = new System.Drawing.Point(0, 0);
		this.Button80.Name = "Button80";
		this.Button80.Size = new System.Drawing.Size(133, 30);
		this.Button80.TabIndex = 15;
		this.Button80.Text = "배너 추가";
		this.Button80.UseVisualStyleBackColor = false;
		this.Label92.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label92.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label92.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label92.Location = new System.Drawing.Point(0, 0);
		this.Label92.Name = "Label92";
		this.Label92.Size = new System.Drawing.Size(271, 29);
		this.Label92.TabIndex = 6;
		this.Label92.Text = "배너 목록";
		this.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Panel75.Controls.Add(this.Panel76);
		this.Panel75.Controls.Add(this.Label98);
		this.Panel75.Controls.Add(this.Label99);
		this.Panel75.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel75.Location = new System.Drawing.Point(23, 0);
		this.Panel75.Name = "Panel75";
		this.Panel75.Size = new System.Drawing.Size(822, 56);
		this.Panel75.TabIndex = 31;
		this.Panel76.BackColor = System.Drawing.Color.Gray;
		this.Panel76.Location = new System.Drawing.Point(106, 41);
		this.Panel76.Name = "Panel76";
		this.Panel76.Size = new System.Drawing.Size(1881, 1);
		this.Panel76.TabIndex = 3;
		this.Label98.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label98.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label98.Location = new System.Drawing.Point(104, 15);
		this.Label98.Name = "Label98";
		this.Label98.Size = new System.Drawing.Size(476, 30);
		this.Label98.TabIndex = 2;
		this.Label98.Text = "여기에서 배너 광고를 관리할 수 있습니다.";
		this.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label99.AutoSize = true;
		this.Label99.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label99.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label99.Location = new System.Drawing.Point(0, 15);
		this.Label99.Name = "Label99";
		this.Label99.Size = new System.Drawing.Size(109, 30);
		this.Label99.TabIndex = 1;
		this.Label99.Text = "배너 관리";
		this.Panel77.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel77.Location = new System.Drawing.Point(845, 0);
		this.Panel77.Name = "Panel77";
		this.Panel77.Size = new System.Drawing.Size(23, 639);
		this.Panel77.TabIndex = 30;
		this.Panel78.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel78.Location = new System.Drawing.Point(0, 0);
		this.Panel78.Name = "Panel78";
		this.Panel78.Size = new System.Drawing.Size(23, 639);
		this.Panel78.TabIndex = 29;
		this.Panel79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel79.Controls.Add(this.Button87);
		this.Panel79.Controls.Add(this.Button90);
		this.Panel79.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel79.Location = new System.Drawing.Point(0, 639);
		this.Panel79.Name = "Panel79";
		this.Panel79.Padding = new System.Windows.Forms.Padding(5);
		this.Panel79.Size = new System.Drawing.Size(868, 44);
		this.Panel79.TabIndex = 0;
		this.Button87.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button87.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button87.BackgroundImage");
		this.Button87.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button87.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button87.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button87.ForeColor = System.Drawing.Color.White;
		this.Button87.Location = new System.Drawing.Point(757, 5);
		this.Button87.Name = "Button87";
		this.Button87.Size = new System.Drawing.Size(104, 32);
		this.Button87.TabIndex = 0;
		this.Button87.Text = "변경사항 저장";
		this.Button87.UseVisualStyleBackColor = false;
		this.Button90.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button90.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button90.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button90.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button90.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button90.ForeColor = System.Drawing.Color.White;
		this.Button90.Location = new System.Drawing.Point(5, 5);
		this.Button90.Name = "Button90";
		this.Button90.Size = new System.Drawing.Size(80, 32);
		this.Button90.TabIndex = 3;
		this.Button90.Text = "새로고침";
		this.Button90.UseVisualStyleBackColor = false;
		this.TabPage4.Controls.Add(this.p4);
		this.TabPage4.Location = new System.Drawing.Point(4, 22);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(868, 683);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "광고관리(학원출첵)";
		this.TabPage4.UseVisualStyleBackColor = true;
		this.p4.BackColor = System.Drawing.Color.Transparent;
		this.p4.Controls.Add(this.DoubleBufferPanel4);
		this.p4.Controls.Add(this.DoubleBufferPanel6);
		this.p4.Controls.Add(this.DoubleBufferPanel8);
		this.p4.Controls.Add(this.DoubleBufferPanel14);
		this.p4.Controls.Add(this.DoubleBufferPanel15);
		this.p4.Controls.Add(this.DoubleBufferPanel16);
		this.p4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p4.Location = new System.Drawing.Point(0, 0);
		this.p4.Name = "p4";
		this.p4.Size = new System.Drawing.Size(868, 683);
		this.p4.TabIndex = 18;
		this.p4.Visible = false;
		this.DoubleBufferPanel4.Controls.Add(this.PictureBox1);
		this.DoubleBufferPanel4.Controls.Add(this.Label3);
		this.DoubleBufferPanel4.Controls.Add(this.DoubleBufferPanel5);
		this.DoubleBufferPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DoubleBufferPanel4.Location = new System.Drawing.Point(294, 56);
		this.DoubleBufferPanel4.Name = "DoubleBufferPanel4";
		this.DoubleBufferPanel4.Size = new System.Drawing.Size(551, 583);
		this.DoubleBufferPanel4.TabIndex = 34;
		this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PictureBox1.Location = new System.Drawing.Point(0, 29);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(551, 352);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 16;
		this.PictureBox1.TabStop = false;
		this.Label3.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label3.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label3.Location = new System.Drawing.Point(0, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(551, 29);
		this.Label3.TabIndex = 7;
		this.Label3.Text = "미리보기";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DoubleBufferPanel5.BackColor = System.Drawing.Color.Gainsboro;
		this.DoubleBufferPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel5.Controls.Add(this.TextBox3);
		this.DoubleBufferPanel5.Controls.Add(this.TextBox4);
		this.DoubleBufferPanel5.Controls.Add(this.Label4);
		this.DoubleBufferPanel5.Controls.Add(this.TextBox5);
		this.DoubleBufferPanel5.Controls.Add(this.Label5);
		this.DoubleBufferPanel5.Controls.Add(this.TextBox6);
		this.DoubleBufferPanel5.Controls.Add(this.Label6);
		this.DoubleBufferPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel5.Location = new System.Drawing.Point(0, 381);
		this.DoubleBufferPanel5.Name = "DoubleBufferPanel5";
		this.DoubleBufferPanel5.Size = new System.Drawing.Size(551, 202);
		this.DoubleBufferPanel5.TabIndex = 32;
		this.DoubleBufferPanel5.Visible = false;
		this.TextBox3.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox3.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox3.ImeMode = System.Windows.Forms.ImeMode.Alpha;
		this.TextBox3.Location = new System.Drawing.Point(158, 5);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(324, 25);
		this.TextBox3.TabIndex = 63;
		this.TextBox3.Visible = false;
		this.TextBox4.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox4.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox4.ImeMode = System.Windows.Forms.ImeMode.Alpha;
		this.TextBox4.Location = new System.Drawing.Point(44, 43);
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(324, 25);
		this.TextBox4.TabIndex = 62;
		this.Label4.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label4.Location = new System.Drawing.Point(9, 123);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(100, 25);
		this.Label4.TabIndex = 59;
		this.Label4.Text = "연결될 주소";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox5.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox5.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox5.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox5.Location = new System.Drawing.Point(44, 148);
		this.TextBox5.Name = "TextBox5";
		this.TextBox5.Size = new System.Drawing.Size(468, 25);
		this.TextBox5.TabIndex = 58;
		this.Label5.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label5.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label5.Location = new System.Drawing.Point(9, 71);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(86, 25);
		this.Label5.TabIndex = 57;
		this.Label5.Text = "파일 이름";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox6.BackColor = System.Drawing.Color.FromArgb(210, 210, 210);
		this.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox6.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox6.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox6.ImeMode = System.Windows.Forms.ImeMode.Alpha;
		this.TextBox6.Location = new System.Drawing.Point(44, 96);
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.ReadOnly = true;
		this.TextBox6.Size = new System.Drawing.Size(324, 25);
		this.TextBox6.TabIndex = 56;
		this.Label6.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label6.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label6.Location = new System.Drawing.Point(13, 18);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(82, 25);
		this.Label6.TabIndex = 53;
		this.Label6.Text = "배너 이름";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.DoubleBufferPanel6.Controls.Add(this.ListBox1);
		this.DoubleBufferPanel6.Controls.Add(this.DoubleBufferPanel7);
		this.DoubleBufferPanel6.Controls.Add(this.Label7);
		this.DoubleBufferPanel6.Dock = System.Windows.Forms.DockStyle.Left;
		this.DoubleBufferPanel6.Location = new System.Drawing.Point(23, 56);
		this.DoubleBufferPanel6.Name = "DoubleBufferPanel6";
		this.DoubleBufferPanel6.Size = new System.Drawing.Size(271, 583);
		this.DoubleBufferPanel6.TabIndex = 33;
		this.ListBox1.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ListBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListBox1.FormattingEnabled = true;
		this.ListBox1.ItemHeight = 21;
		this.ListBox1.Location = new System.Drawing.Point(0, 29);
		this.ListBox1.Name = "ListBox1";
		this.ListBox1.Size = new System.Drawing.Size(271, 524);
		this.ListBox1.TabIndex = 7;
		this.DoubleBufferPanel7.Controls.Add(this.Button3);
		this.DoubleBufferPanel7.Controls.Add(this.Button4);
		this.DoubleBufferPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel7.Location = new System.Drawing.Point(0, 553);
		this.DoubleBufferPanel7.Name = "DoubleBufferPanel7";
		this.DoubleBufferPanel7.Size = new System.Drawing.Size(271, 30);
		this.DoubleBufferPanel7.TabIndex = 15;
		this.Button3.BackColor = System.Drawing.Color.Red;
		this.Button3.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.ForeColor = System.Drawing.Color.White;
		this.Button3.Location = new System.Drawing.Point(133, 0);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(138, 30);
		this.Button3.TabIndex = 14;
		this.Button3.Text = "선택 제거";
		this.Button3.UseVisualStyleBackColor = false;
		this.Button4.BackColor = System.Drawing.Color.DarkGreen;
		this.Button4.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button4.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button4.ForeColor = System.Drawing.Color.White;
		this.Button4.Location = new System.Drawing.Point(0, 0);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(133, 30);
		this.Button4.TabIndex = 15;
		this.Button4.Text = "배너 추가";
		this.Button4.UseVisualStyleBackColor = false;
		this.Label7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label7.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label7.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label7.Location = new System.Drawing.Point(0, 0);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(271, 29);
		this.Label7.TabIndex = 6;
		this.Label7.Text = "배너 목록";
		this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.DoubleBufferPanel8.Controls.Add(this.DoubleBufferPanel13);
		this.DoubleBufferPanel8.Controls.Add(this.Label8);
		this.DoubleBufferPanel8.Controls.Add(this.Label9);
		this.DoubleBufferPanel8.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel8.Location = new System.Drawing.Point(23, 0);
		this.DoubleBufferPanel8.Name = "DoubleBufferPanel8";
		this.DoubleBufferPanel8.Size = new System.Drawing.Size(822, 56);
		this.DoubleBufferPanel8.TabIndex = 31;
		this.DoubleBufferPanel13.BackColor = System.Drawing.Color.Gray;
		this.DoubleBufferPanel13.Location = new System.Drawing.Point(106, 41);
		this.DoubleBufferPanel13.Name = "DoubleBufferPanel13";
		this.DoubleBufferPanel13.Size = new System.Drawing.Size(1892, 1);
		this.DoubleBufferPanel13.TabIndex = 3;
		this.Label8.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label8.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label8.Location = new System.Drawing.Point(104, 15);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(487, 30);
		this.Label8.TabIndex = 2;
		this.Label8.Text = "여기에서 배너 광고를 관리할 수 있습니다.";
		this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label9.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label9.Location = new System.Drawing.Point(0, 15);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(109, 30);
		this.Label9.TabIndex = 1;
		this.Label9.Text = "배너 관리";
		this.DoubleBufferPanel14.Dock = System.Windows.Forms.DockStyle.Right;
		this.DoubleBufferPanel14.Location = new System.Drawing.Point(845, 0);
		this.DoubleBufferPanel14.Name = "DoubleBufferPanel14";
		this.DoubleBufferPanel14.Size = new System.Drawing.Size(23, 639);
		this.DoubleBufferPanel14.TabIndex = 30;
		this.DoubleBufferPanel15.Dock = System.Windows.Forms.DockStyle.Left;
		this.DoubleBufferPanel15.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel15.Name = "DoubleBufferPanel15";
		this.DoubleBufferPanel15.Size = new System.Drawing.Size(23, 639);
		this.DoubleBufferPanel15.TabIndex = 29;
		this.DoubleBufferPanel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel16.Controls.Add(this.Button5);
		this.DoubleBufferPanel16.Controls.Add(this.Button6);
		this.DoubleBufferPanel16.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel16.Location = new System.Drawing.Point(0, 639);
		this.DoubleBufferPanel16.Name = "DoubleBufferPanel16";
		this.DoubleBufferPanel16.Padding = new System.Windows.Forms.Padding(5);
		this.DoubleBufferPanel16.Size = new System.Drawing.Size(868, 44);
		this.DoubleBufferPanel16.TabIndex = 0;
		this.Button5.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button5.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button5.BackgroundImage");
		this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button5.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button5.ForeColor = System.Drawing.Color.White;
		this.Button5.Location = new System.Drawing.Point(757, 5);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(104, 32);
		this.Button5.TabIndex = 0;
		this.Button5.Text = "변경사항 저장";
		this.Button5.UseVisualStyleBackColor = false;
		this.Button6.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button6.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button6.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button6.ForeColor = System.Drawing.Color.White;
		this.Button6.Location = new System.Drawing.Point(5, 5);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(80, 32);
		this.Button6.TabIndex = 3;
		this.Button6.Text = "새로고침";
		this.Button6.UseVisualStyleBackColor = false;
		this.TabPage2.Controls.Add(this.p2);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new System.Drawing.Size(868, 683);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "공지사항관리";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.p2.BackColor = System.Drawing.Color.Transparent;
		this.p2.Controls.Add(this.TextBox23);
		this.p2.Controls.Add(this.Panel49);
		this.p2.Controls.Add(this.Panel109);
		this.p2.Controls.Add(this.Panel112);
		this.p2.Controls.Add(this.Panel117);
		this.p2.Controls.Add(this.Panel118);
		this.p2.Controls.Add(this.Panel103);
		this.p2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p2.Location = new System.Drawing.Point(0, 0);
		this.p2.Name = "p2";
		this.p2.Size = new System.Drawing.Size(868, 683);
		this.p2.TabIndex = 25;
		this.TextBox23.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox23.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox23.Font = new System.Drawing.Font("굴림", 10f);
		this.TextBox23.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox23.Location = new System.Drawing.Point(23, 169);
		this.TextBox23.MaxLength = 0;
		this.TextBox23.Multiline = true;
		this.TextBox23.Name = "TextBox23";
		this.TextBox23.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.TextBox23.Size = new System.Drawing.Size(822, 452);
		this.TextBox23.TabIndex = 15;
		this.TextBox23.WordWrap = false;
		this.Panel49.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel49.Location = new System.Drawing.Point(23, 621);
		this.Panel49.Name = "Panel49";
		this.Panel49.Size = new System.Drawing.Size(822, 18);
		this.Panel49.TabIndex = 44;
		this.Panel109.Controls.Add(this.Label30);
		this.Panel109.Controls.Add(this.TextBox25);
		this.Panel109.Controls.Add(this.TextBox24);
		this.Panel109.Controls.Add(this.Label84);
		this.Panel109.Controls.Add(this.Label85);
		this.Panel109.Controls.Add(this.Button79);
		this.Panel109.Controls.Add(this.Label86);
		this.Panel109.Controls.Add(this.ComboBox16);
		this.Panel109.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel109.Location = new System.Drawing.Point(23, 56);
		this.Panel109.Name = "Panel109";
		this.Panel109.Size = new System.Drawing.Size(822, 113);
		this.Panel109.TabIndex = 17;
		this.Label30.AutoSize = true;
		this.Label30.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label30.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label30.Location = new System.Drawing.Point(637, 52);
		this.Label30.Name = "Label30";
		this.Label30.Size = new System.Drawing.Size(51, 19);
		this.Label30.TabIndex = 48;
		this.Label30.Text = "조회수";
		this.TextBox25.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.TextBox25.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox25.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox25.ForeColor = System.Drawing.Color.Blue;
		this.TextBox25.Location = new System.Drawing.Point(687, 52);
		this.TextBox25.Name = "TextBox25";
		this.TextBox25.ReadOnly = true;
		this.TextBox25.Size = new System.Drawing.Size(112, 20);
		this.TextBox25.TabIndex = 47;
		this.TextBox24.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox24.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox24.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold);
		this.TextBox24.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox24.Location = new System.Drawing.Point(113, 49);
		this.TextBox24.Name = "TextBox24";
		this.TextBox24.Size = new System.Drawing.Size(514, 25);
		this.TextBox24.TabIndex = 46;
		this.Label84.AutoSize = true;
		this.Label84.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label84.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label84.Location = new System.Drawing.Point(70, 51);
		this.Label84.Name = "Label84";
		this.Label84.Size = new System.Drawing.Size(37, 19);
		this.Label84.TabIndex = 17;
		this.Label84.Text = "제목";
		this.Label85.AutoSize = true;
		this.Label85.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label85.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label85.Location = new System.Drawing.Point(11, 90);
		this.Label85.Name = "Label85";
		this.Label85.Size = new System.Drawing.Size(251, 19);
		this.Label85.TabIndex = 16;
		this.Label85.Text = "본문 (HTML 코드로 작성 가능합니다.)";
		this.Button79.BackColor = System.Drawing.Color.Red;
		this.Button79.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button79.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button79.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button79.ForeColor = System.Drawing.Color.White;
		this.Button79.Location = new System.Drawing.Point(641, 17);
		this.Button79.Name = "Button79";
		this.Button79.Size = new System.Drawing.Size(71, 26);
		this.Button79.TabIndex = 7;
		this.Button79.Text = "삭제";
		this.Button79.UseVisualStyleBackColor = false;
		this.Label86.AutoSize = true;
		this.Label86.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label86.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label86.Location = new System.Drawing.Point(23, 20);
		this.Label86.Name = "Label86";
		this.Label86.Size = new System.Drawing.Size(84, 19);
		this.Label86.TabIndex = 0;
		this.Label86.Text = "게시글 선택";
		this.ComboBox16.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox16.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox16.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold);
		this.ComboBox16.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox16.FormattingEnabled = true;
		this.ComboBox16.Location = new System.Drawing.Point(113, 17);
		this.ComboBox16.Name = "ComboBox16";
		this.ComboBox16.Size = new System.Drawing.Size(514, 26);
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
		this.Panel114.Location = new System.Drawing.Point(151, 41);
		this.Panel114.Name = "Panel114";
		this.Panel114.Size = new System.Drawing.Size(2000, 1);
		this.Panel114.TabIndex = 3;
		this.Label89.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label89.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label89.Location = new System.Drawing.Point(149, 15);
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
		this.Panel103.Controls.Add(this.Button85);
		this.Panel103.Controls.Add(this.Button86);
		this.Panel103.Controls.Add(this.Button74);
		this.Panel103.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel103.Location = new System.Drawing.Point(0, 639);
		this.Panel103.Name = "Panel103";
		this.Panel103.Padding = new System.Windows.Forms.Padding(5);
		this.Panel103.Size = new System.Drawing.Size(868, 44);
		this.Panel103.TabIndex = 43;
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
		this.Button86.BackColor = System.Drawing.Color.DarkGreen;
		this.Button86.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button86.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button86.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button86.ForeColor = System.Drawing.Color.White;
		this.Button86.Location = new System.Drawing.Point(85, 5);
		this.Button86.Name = "Button86";
		this.Button86.Size = new System.Drawing.Size(91, 32);
		this.Button86.TabIndex = 8;
		this.Button86.Text = "새로 만들기";
		this.Button86.UseVisualStyleBackColor = false;
		this.Button74.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button74.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button74.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button74.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button74.ForeColor = System.Drawing.Color.White;
		this.Button74.Location = new System.Drawing.Point(5, 5);
		this.Button74.Name = "Button74";
		this.Button74.Size = new System.Drawing.Size(80, 32);
		this.Button74.TabIndex = 9;
		this.Button74.Text = "새로고침";
		this.Button74.UseVisualStyleBackColor = false;
		this.TabPage5.Controls.Add(this.p5);
		this.TabPage5.Location = new System.Drawing.Point(4, 22);
		this.TabPage5.Name = "TabPage5";
		this.TabPage5.Size = new System.Drawing.Size(868, 683);
		this.TabPage5.TabIndex = 4;
		this.TabPage5.Text = "사용설명서";
		this.TabPage5.UseVisualStyleBackColor = true;
		this.p5.BackColor = System.Drawing.Color.Transparent;
		this.p5.Controls.Add(this.TextBox34);
		this.p5.Controls.Add(this.WebBrowser1);
		this.p5.Controls.Add(this.DoubleBufferPanel3);
		this.p5.Controls.Add(this.DoubleBufferPanel17);
		this.p5.Controls.Add(this.DoubleBufferPanel18);
		this.p5.Controls.Add(this.DoubleBufferPanel21);
		this.p5.Controls.Add(this.DoubleBufferPanel22);
		this.p5.Controls.Add(this.DoubleBufferPanel23);
		this.p5.Controls.Add(this.DoubleBufferPanel24);
		this.p5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p5.Location = new System.Drawing.Point(0, 0);
		this.p5.Name = "p5";
		this.p5.Size = new System.Drawing.Size(868, 683);
		this.p5.TabIndex = 26;
		this.TextBox34.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox34.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox34.Font = new System.Drawing.Font("굴림", 10f);
		this.TextBox34.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox34.Location = new System.Drawing.Point(23, 169);
		this.TextBox34.MaxLength = 0;
		this.TextBox34.Multiline = true;
		this.TextBox34.Name = "TextBox34";
		this.TextBox34.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.TextBox34.Size = new System.Drawing.Size(822, 416);
		this.TextBox34.TabIndex = 15;
		this.TextBox34.WordWrap = false;
		this.WebBrowser1.AllowWebBrowserDrop = false;
		this.WebBrowser1.CausesValidation = false;
		this.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.WebBrowser1.IsWebBrowserContextMenuEnabled = false;
		this.WebBrowser1.Location = new System.Drawing.Point(23, 169);
		this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
		this.WebBrowser1.Name = "WebBrowser1";
		this.WebBrowser1.ScriptErrorsSuppressed = true;
		this.WebBrowser1.Size = new System.Drawing.Size(822, 416);
		this.WebBrowser1.TabIndex = 45;
		this.WebBrowser1.WebBrowserShortcutsEnabled = false;
		this.DoubleBufferPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel3.Controls.Add(this.Label58);
		this.DoubleBufferPanel3.Controls.Add(this.Button165);
		this.DoubleBufferPanel3.Controls.Add(this.Button164);
		this.DoubleBufferPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel3.Location = new System.Drawing.Point(23, 585);
		this.DoubleBufferPanel3.Name = "DoubleBufferPanel3";
		this.DoubleBufferPanel3.Padding = new System.Windows.Forms.Padding(5);
		this.DoubleBufferPanel3.Size = new System.Drawing.Size(822, 36);
		this.DoubleBufferPanel3.TabIndex = 44;
		this.Label58.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label58.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
		this.Label58.Location = new System.Drawing.Point(124, 5);
		this.Label58.Name = "Label58";
		this.Label58.Size = new System.Drawing.Size(465, 24);
		this.Label58.TabIndex = 75;
		this.Label58.Text = "※ JPG, PNG, 337 x 600 비율, 200KB 이하 권장";
		this.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button165.BackColor = System.Drawing.Color.Maroon;
		this.Button165.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button165.BackgroundImage");
		this.Button165.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button165.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button165.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button165.ForeColor = System.Drawing.Color.White;
		this.Button165.Location = new System.Drawing.Point(5, 5);
		this.Button165.Name = "Button165";
		this.Button165.Size = new System.Drawing.Size(113, 24);
		this.Button165.TabIndex = 23;
		this.Button165.Text = "이미지 삽입/편집";
		this.Button165.UseVisualStyleBackColor = false;
		this.Button164.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button164.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button164.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button164.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button164.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button164.ForeColor = System.Drawing.Color.White;
		this.Button164.Location = new System.Drawing.Point(732, 5);
		this.Button164.Name = "Button164";
		this.Button164.Size = new System.Drawing.Size(83, 24);
		this.Button164.TabIndex = 74;
		this.Button164.Text = "미리보기";
		this.Button164.UseVisualStyleBackColor = false;
		this.DoubleBufferPanel17.Controls.Add(this.CheckBox13);
		this.DoubleBufferPanel17.Controls.Add(this.Button159);
		this.DoubleBufferPanel17.Controls.Add(this.TextBox37);
		this.DoubleBufferPanel17.Controls.Add(this.Label128);
		this.DoubleBufferPanel17.Controls.Add(this.Label129);
		this.DoubleBufferPanel17.Controls.Add(this.Button160);
		this.DoubleBufferPanel17.Controls.Add(this.Label130);
		this.DoubleBufferPanel17.Controls.Add(this.ComboBoxEx2);
		this.DoubleBufferPanel17.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel17.Location = new System.Drawing.Point(23, 56);
		this.DoubleBufferPanel17.Name = "DoubleBufferPanel17";
		this.DoubleBufferPanel17.Size = new System.Drawing.Size(822, 113);
		this.DoubleBufferPanel17.TabIndex = 17;
		this.CheckBox13.AutoSize = true;
		this.CheckBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CheckBox13.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.CheckBox13.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.CheckBox13.Location = new System.Drawing.Point(641, 50);
		this.CheckBox13.Name = "CheckBox13";
		this.CheckBox13.Size = new System.Drawing.Size(53, 23);
		this.CheckBox13.TabIndex = 68;
		this.CheckBox13.Text = "중요";
		this.CheckBox13.UseVisualStyleBackColor = true;
		this.Button159.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
		this.Button159.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button159.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button159.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button159.ForeColor = System.Drawing.Color.White;
		this.Button159.Location = new System.Drawing.Point(718, 17);
		this.Button159.Name = "Button159";
		this.Button159.Size = new System.Drawing.Size(81, 26);
		this.Button159.TabIndex = 67;
		this.Button159.Text = "찾기";
		this.Button159.UseVisualStyleBackColor = false;
		this.TextBox37.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox37.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox37.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold);
		this.TextBox37.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox37.Location = new System.Drawing.Point(113, 49);
		this.TextBox37.Name = "TextBox37";
		this.TextBox37.Size = new System.Drawing.Size(514, 25);
		this.TextBox37.TabIndex = 46;
		this.Label128.AutoSize = true;
		this.Label128.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label128.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label128.Location = new System.Drawing.Point(70, 51);
		this.Label128.Name = "Label128";
		this.Label128.Size = new System.Drawing.Size(37, 19);
		this.Label128.TabIndex = 17;
		this.Label128.Text = "제목";
		this.Label129.AutoSize = true;
		this.Label129.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label129.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label129.Location = new System.Drawing.Point(11, 90);
		this.Label129.Name = "Label129";
		this.Label129.Size = new System.Drawing.Size(251, 19);
		this.Label129.TabIndex = 16;
		this.Label129.Text = "본문 (HTML 코드로 작성 가능합니다.)";
		this.Button160.BackColor = System.Drawing.Color.Red;
		this.Button160.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button160.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button160.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button160.ForeColor = System.Drawing.Color.White;
		this.Button160.Location = new System.Drawing.Point(641, 17);
		this.Button160.Name = "Button160";
		this.Button160.Size = new System.Drawing.Size(75, 26);
		this.Button160.TabIndex = 7;
		this.Button160.Text = "삭제";
		this.Button160.UseVisualStyleBackColor = false;
		this.Label130.AutoSize = true;
		this.Label130.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label130.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label130.Location = new System.Drawing.Point(23, 20);
		this.Label130.Name = "Label130";
		this.Label130.Size = new System.Drawing.Size(84, 19);
		this.Label130.TabIndex = 0;
		this.Label130.Text = "게시글 선택";
		this.ComboBoxEx2.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBoxEx2.DropDownHeight = 300;
		this.ComboBoxEx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBoxEx2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBoxEx2.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold);
		this.ComboBoxEx2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBoxEx2.FormattingEnabled = true;
		this.ComboBoxEx2.IntegralHeight = false;
		this.ComboBoxEx2.Location = new System.Drawing.Point(113, 17);
		this.ComboBoxEx2.Name = "ComboBoxEx2";
		this.ComboBoxEx2.Size = new System.Drawing.Size(514, 26);
		this.ComboBoxEx2.TabIndex = 3;
		this.DoubleBufferPanel18.Controls.Add(this.DoubleBufferPanel19);
		this.DoubleBufferPanel18.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel18.Location = new System.Drawing.Point(23, 0);
		this.DoubleBufferPanel18.Name = "DoubleBufferPanel18";
		this.DoubleBufferPanel18.Size = new System.Drawing.Size(822, 56);
		this.DoubleBufferPanel18.TabIndex = 21;
		this.DoubleBufferPanel19.Controls.Add(this.Label132);
		this.DoubleBufferPanel19.Controls.Add(this.DoubleBufferPanel20);
		this.DoubleBufferPanel19.Controls.Add(this.Label134);
		this.DoubleBufferPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DoubleBufferPanel19.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel19.Name = "DoubleBufferPanel19";
		this.DoubleBufferPanel19.Size = new System.Drawing.Size(822, 56);
		this.DoubleBufferPanel19.TabIndex = 4;
		this.Label132.AutoSize = true;
		this.Label132.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label132.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label132.Location = new System.Drawing.Point(0, 15);
		this.Label132.Name = "Label132";
		this.Label132.Size = new System.Drawing.Size(175, 30);
		this.Label132.TabIndex = 1;
		this.Label132.Text = "사용설명서 관리";
		this.DoubleBufferPanel20.BackColor = System.Drawing.Color.Gray;
		this.DoubleBufferPanel20.Location = new System.Drawing.Point(151, 41);
		this.DoubleBufferPanel20.Name = "DoubleBufferPanel20";
		this.DoubleBufferPanel20.Size = new System.Drawing.Size(2000, 1);
		this.DoubleBufferPanel20.TabIndex = 3;
		this.Label134.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label134.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label134.Location = new System.Drawing.Point(172, 15);
		this.Label134.Name = "Label134";
		this.Label134.Size = new System.Drawing.Size(768, 30);
		this.Label134.TabIndex = 2;
		this.Label134.Text = "앱에서 표시되는 사용설명서를 추가하거나 편집할 수 있습니다.";
		this.Label134.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.DoubleBufferPanel21.Dock = System.Windows.Forms.DockStyle.Right;
		this.DoubleBufferPanel21.Location = new System.Drawing.Point(845, 0);
		this.DoubleBufferPanel21.Name = "DoubleBufferPanel21";
		this.DoubleBufferPanel21.Size = new System.Drawing.Size(23, 621);
		this.DoubleBufferPanel21.TabIndex = 20;
		this.DoubleBufferPanel22.Dock = System.Windows.Forms.DockStyle.Left;
		this.DoubleBufferPanel22.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel22.Name = "DoubleBufferPanel22";
		this.DoubleBufferPanel22.Size = new System.Drawing.Size(23, 621);
		this.DoubleBufferPanel22.TabIndex = 19;
		this.DoubleBufferPanel23.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel23.Location = new System.Drawing.Point(0, 621);
		this.DoubleBufferPanel23.Name = "DoubleBufferPanel23";
		this.DoubleBufferPanel23.Size = new System.Drawing.Size(868, 18);
		this.DoubleBufferPanel23.TabIndex = 46;
		this.DoubleBufferPanel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel24.Controls.Add(this.Button161);
		this.DoubleBufferPanel24.Controls.Add(this.Button162);
		this.DoubleBufferPanel24.Controls.Add(this.Button163);
		this.DoubleBufferPanel24.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel24.Location = new System.Drawing.Point(0, 639);
		this.DoubleBufferPanel24.Name = "DoubleBufferPanel24";
		this.DoubleBufferPanel24.Padding = new System.Windows.Forms.Padding(5);
		this.DoubleBufferPanel24.Size = new System.Drawing.Size(868, 44);
		this.DoubleBufferPanel24.TabIndex = 43;
		this.Button161.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button161.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button161.BackgroundImage");
		this.Button161.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button161.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button161.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button161.ForeColor = System.Drawing.Color.White;
		this.Button161.Location = new System.Drawing.Point(793, 5);
		this.Button161.Name = "Button161";
		this.Button161.Size = new System.Drawing.Size(68, 32);
		this.Button161.TabIndex = 7;
		this.Button161.Text = "저장";
		this.Button161.UseVisualStyleBackColor = false;
		this.Button162.BackColor = System.Drawing.Color.DarkGreen;
		this.Button162.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button162.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button162.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button162.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button162.ForeColor = System.Drawing.Color.White;
		this.Button162.Location = new System.Drawing.Point(85, 5);
		this.Button162.Name = "Button162";
		this.Button162.Size = new System.Drawing.Size(91, 32);
		this.Button162.TabIndex = 8;
		this.Button162.Text = "새로 만들기";
		this.Button162.UseVisualStyleBackColor = false;
		this.Button163.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button163.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button163.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button163.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button163.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button163.ForeColor = System.Drawing.Color.White;
		this.Button163.Location = new System.Drawing.Point(5, 5);
		this.Button163.Name = "Button163";
		this.Button163.Size = new System.Drawing.Size(80, 32);
		this.Button163.TabIndex = 9;
		this.Button163.Text = "새로고침";
		this.Button163.UseVisualStyleBackColor = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		base.ClientSize = new System.Drawing.Size(876, 709);
		base.Controls.Add(this.TabControl1);
		base.Name = "android_mba_check";
		this.Text = "android_mba_check";
		this.TabControl1.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.p3.ResumeLayout(false);
		this.p3_centerpanel.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.mba_accountGrid).EndInit();
		this.DoubleBufferPanel1.ResumeLayout(false);
		this.DoubleBufferPanel1.PerformLayout();
		this.DoubleBufferPanel9.ResumeLayout(false);
		this.DoubleBufferPanel12.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.p1.ResumeLayout(false);
		this.Panel73.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox11).EndInit();
		this.Panel74.ResumeLayout(false);
		this.Panel74.PerformLayout();
		this.Panel64.ResumeLayout(false);
		this.Panel80.ResumeLayout(false);
		this.Panel75.ResumeLayout(false);
		this.Panel75.PerformLayout();
		this.Panel79.ResumeLayout(false);
		this.TabPage4.ResumeLayout(false);
		this.p4.ResumeLayout(false);
		this.DoubleBufferPanel4.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.DoubleBufferPanel5.ResumeLayout(false);
		this.DoubleBufferPanel5.PerformLayout();
		this.DoubleBufferPanel6.ResumeLayout(false);
		this.DoubleBufferPanel7.ResumeLayout(false);
		this.DoubleBufferPanel8.ResumeLayout(false);
		this.DoubleBufferPanel8.PerformLayout();
		this.DoubleBufferPanel16.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.p2.ResumeLayout(false);
		this.p2.PerformLayout();
		this.Panel109.ResumeLayout(false);
		this.Panel109.PerformLayout();
		this.Panel112.ResumeLayout(false);
		this.Panel113.ResumeLayout(false);
		this.Panel113.PerformLayout();
		this.Panel103.ResumeLayout(false);
		this.TabPage5.ResumeLayout(false);
		this.p5.ResumeLayout(false);
		this.p5.PerformLayout();
		this.DoubleBufferPanel3.ResumeLayout(false);
		this.DoubleBufferPanel17.ResumeLayout(false);
		this.DoubleBufferPanel17.PerformLayout();
		this.DoubleBufferPanel18.ResumeLayout(false);
		this.DoubleBufferPanel19.ResumeLayout(false);
		this.DoubleBufferPanel19.PerformLayout();
		this.DoubleBufferPanel24.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Button90_Click(object sender, EventArgs e)
	{
		getBanner(0);
	}

	public void getBanner(int apptype)
	{
		if (apptype == 0)
		{
			PictureBox11.Image = null;
			Panel74.Hide();
			sjka_cyber.BANNER = new List<BannerData>();
		}
		else
		{
			mba_check.MOM_BANNER = new List<BannerData>();
			PictureBox1.Image = null;
			DoubleBufferPanel5.Hide();
		}
		string hTML = new GetHtmlClass(Module1._dburl + "/admin.php?type=getBanner&pw=" + MySettingsProperty.Settings.pw + "&apptype=" + Conversions.ToString(apptype), "", progress: true).getHTML(this);
		try
		{
			JObject jObject = JObject.Parse(hTML);
			if (jObject.SelectToken("response").ToString().Equals("ok"))
			{
				if (apptype == 0)
				{
					ListBox11.Items.Clear();
					mba_check.mba_check_advList = JsonConvert.DeserializeObject<List<ck_advertise>>(jObject.SelectToken("arrays").ToString());
					foreach (ck_advertise mba_check_adv in mba_check.mba_check_advList)
					{
						ListBox11.Items.Add(mba_check_adv.name);
					}
				}
				else
				{
					ListBox1.Items.Clear();
					mba_check.hakwon_check_advList = JsonConvert.DeserializeObject<List<ck_advertise>>(jObject.SelectToken("arrays").ToString());
					foreach (ck_advertise hakwon_check_adv in mba_check.hakwon_check_advList)
					{
						ListBox1.Items.Add(hakwon_check_adv.name);
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (apptype == 0)
			{
				mba_check.mba_check_advList = new List<ck_advertise>();
			}
			else
			{
				mba_check.hakwon_check_advList = new List<ck_advertise>();
			}
			ProjectData.ClearProjectError();
		}
		if (!init)
		{
			init = true;
			bw = new WebBrowser();
			lb = new Label();
			btn = new Button();
			WebBrowser webBrowser = bw;
			webBrowser.Dock = DockStyle.Fill;
			webBrowser.IsWebBrowserContextMenuEnabled = false;
			if (apptype == 0)
			{
				webBrowser.Url = new Uri(Module1._dburl + "/fup.php?apptype=0");
			}
			else
			{
				webBrowser.Url = new Uri(Module1._dburl + "/fup.php?apptype=1");
			}
			webBrowser.ScrollBarsEnabled = false;
			webBrowser = null;
			Label label = lb;
			label.AutoSize = false;
			label.Dock = DockStyle.Top;
			label.Text = "파일 업로드";
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.Size = new Size(0, 40);
			label.Font = new Font("맑은 고딕", 12f, FontStyle.Bold);
			label.BorderStyle = BorderStyle.FixedSingle;
			_ = null;
			Button button = btn;
			button.Text = "창 닫기";
			button.Dock = DockStyle.Bottom;
			button.FlatStyle = FlatStyle.Flat;
			button.BackColor = Color.Green;
			button.ForeColor = Color.White;
			button.Font = new Font("맑은 고딕", 10f);
			button.Size = new Size(0, 30);
			button.Name = "new";
			_ = null;
			pn = new Panel();
			Panel panel = pn;
			panel.BackColor = Color.DarkRed;
			panel.ForeColor = Color.White;
			panel.BorderStyle = BorderStyle.Fixed3D;
			panel.Size = new Size(300, 225);
			panel.Controls.Add(bw);
			panel.Controls.Add(lb);
			panel.Controls.Add(btn);
			panel.Location = checked(new Point((int)Math.Round((double)p1.Size.Width / 2.0 - (double)panel.Size.Width / 2.0), (int)Math.Round((double)p1.Size.Height / 2.0 - (double)panel.Size.Height / 2.0)));
			panel = null;
			btn.MouseDown += closeform;
		}
	}

	private void closeform(object sender, MouseEventArgs e)
	{
		checked
		{
			if (Operators.ConditionalCompareObjectEqual(bw.Tag, 0, TextCompare: false))
			{
				getBanner(0);
				ListBox11.SelectedIndex = ListBox11.Items.Count - 1;
			}
			else
			{
				getBanner(1);
				ListBox1.SelectedIndex = ListBox1.Items.Count - 1;
			}
			pn.Hide();
		}
	}

	private void ListBox11_SelectedIndexChanged_1(object sender, EventArgs e)
	{
		if (!editMode)
		{
			if (ListBox11.SelectedIndex < 0)
			{
				Panel74.Hide();
			}
			else
			{
				Panel74.Show();
			}
			try
			{
				TextBox2.Text = Conversions.ToString(mba_check.mba_check_advList[ListBox11.SelectedIndex].index);
				TextBox1.Text = mba_check.mba_check_advList[ListBox11.SelectedIndex].name;
				TextBox26.Text = mba_check.mba_check_advList[ListBox11.SelectedIndex].fname;
				TextBox28.Text = mba_check.mba_check_advList[ListBox11.SelectedIndex].url;
				byte[] buffer = Convert.FromBase64String(mba_check.mba_check_advList[ListBox11.SelectedIndex].blob);
				MemoryStream stream = new MemoryStream(buffer);
				PictureBox11.Image = Image.FromStream(stream);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				PictureBox11.Image = null;
				GC.Collect();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DrawItem(object sender, DrawItemEventArgs e)
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

	private void Button80_Click(object sender, EventArgs e)
	{
		if (init)
		{
			bw.Url = new Uri(Module1._dburl + "/fup.php?apptype=0");
			bw.Tag = 0;
		}
		p1.Controls.Add(pn);
		p1.Controls.SetChildIndex(pn, 0);
		pn.Show();
	}

	private void Button78_Click(object sender, EventArgs e)
	{
	}

	private void Button83_Click(object sender, EventArgs e)
	{
		int selectedIndex = ListBox11.SelectedIndex;
		string hTML = new GetHtmlClass(Module1._dburl + "/admin.php?type=delBanner&i=" + TextBox2.Text.Trim() + "&pw=" + MySettingsProperty.Settings.pw, "", progress: true).getHTML(this);
		try
		{
			JObject jObject = JObject.Parse(hTML);
			if (jObject.SelectToken("response").ToString().Equals("ok"))
			{
				getBanner(0);
				if (selectedIndex != 0)
				{
					ListBox11.SelectedIndex = checked(selectedIndex - 1);
				}
			}
			else
			{
				CustomMsgBox.CMsgBox("서버에 오류가 있습니다.\r\n" + jObject.SelectToken("cause").ToString(), "오류 발생", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		editMode = true;
		mba_check.mba_check_advList[ListBox11.SelectedIndex].name = TextBox1.Text;
		ListBox11.Items[ListBox11.SelectedIndex] = TextBox1.Text;
		editMode = false;
	}

	private void ListBox11_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void TextBox28_TextChanged(object sender, EventArgs e)
	{
		editMode = true;
		mba_check.mba_check_advList[ListBox11.SelectedIndex].url = TextBox28.Text;
		editMode = false;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (ListBox11.SelectedIndex <= 0)
		{
			return;
		}
		checked
		{
			ck_advertise value = mba_check.mba_check_advList[ListBox11.SelectedIndex - 1];
			int index = mba_check.mba_check_advList[ListBox11.SelectedIndex].index;
			mba_check.mba_check_advList[ListBox11.SelectedIndex].index = mba_check.mba_check_advList[ListBox11.SelectedIndex - 1].index;
			mba_check.mba_check_advList[ListBox11.SelectedIndex - 1] = mba_check.mba_check_advList[ListBox11.SelectedIndex];
			mba_check.mba_check_advList[ListBox11.SelectedIndex] = value;
			mba_check.mba_check_advList[ListBox11.SelectedIndex].index = index;
			int selectedIndex = ListBox11.SelectedIndex;
			ListBox11.Items.Clear();
			foreach (ck_advertise mba_check_adv in mba_check.mba_check_advList)
			{
				ListBox11.Items.Add(mba_check_adv.name);
			}
			ListBox11.SelectedIndex = selectedIndex - 1;
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		checked
		{
			if (ListBox11.SelectedIndex >= ListBox11.Items.Count - 1)
			{
				return;
			}
			ck_advertise value = mba_check.mba_check_advList[ListBox11.SelectedIndex + 1];
			mba_check.mba_check_advList[ListBox11.SelectedIndex + 1] = mba_check.mba_check_advList[ListBox11.SelectedIndex];
			mba_check.mba_check_advList[ListBox11.SelectedIndex] = value;
			int selectedIndex = ListBox11.SelectedIndex;
			ListBox11.Items.Clear();
			foreach (ck_advertise mba_check_adv in mba_check.mba_check_advList)
			{
				ListBox11.Items.Add(mba_check_adv.name);
			}
			ListBox11.SelectedIndex = selectedIndex + 1;
		}
	}

	private void Button87_Click(object sender, EventArgs e)
	{
		object left = null;
		foreach (ck_advertise mba_check_adv in mba_check.mba_check_advList)
		{
			left = ((!Operators.ConditionalCompareObjectEqual(left, null, TextCompare: false)) ? Operators.ConcatenateObject(left, ",") : "[");
			left = Operators.ConcatenateObject(left, Operators.ConcatenateObject(Operators.ConcatenateObject("{\"index\":\"" + Conversions.ToString(mba_check_adv.index) + "\",\"name\":\"" + mba_check_adv.name + "\",\"url\":\"", Interaction.IIf(mba_check_adv.url.Contains("http://"), mba_check_adv.url, "http://" + mba_check_adv.url)), "\"}"));
		}
		left = Operators.ConcatenateObject(left, "]");
		int selectedIndex = ListBox11.SelectedIndex;
		ListBox11.SelectedIndex = -1;
		string hTML = new GetHtmlClass(Module1._dburl + "/admin.php?type=updateBanner&pw=" + MySettingsProperty.Settings.pw, Conversions.ToString(Operators.ConcatenateObject("json=", left)), progress: true).getHTML(this);
		try
		{
			JObject jObject = JObject.Parse(hTML);
			if (jObject.SelectToken("response").ToString().Equals("ok"))
			{
				getBanner(0);
				ListBox11.SelectedIndex = selectedIndex;
			}
			else
			{
				CustomMsgBox.CMsgBox("서버에 오류가 있습니다.\r\n" + jObject.SelectToken("cause").ToString(), "오류 발생", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button74_Click(object sender, EventArgs e)
	{
		getNotice();
	}

	public void getNotice()
	{
		sjka_cyber.NOTICE_ND = new List<NoticeData>();
		string hTML = new GetHtmlClass(Module1._dburl + "/notice.php?t=getNotice", null, progress: true).getHTML(this);
		if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
		{
			CustomMsgBox.CMsgBox("잠시 후에 다시 시도하십시오.\r\n이런 현상이 계속되면 MLAS를 종료하고 재시작 하십시오.", "통신대기 발생", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 3000);
			return;
		}
		if (Operators.CompareString(hTML, null, TextCompare: false) == 0)
		{
			CustomMsgBox.CMsgBox("데이터 처리중에 오류가 생겼습니다.\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. notice\r\n" + hTML, "통신 오류!", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			return;
		}
		Module1.board = hTML.Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		ComboBox16.Items.Clear();
		TextBox24.Text = null;
		TextBox23.Text = null;
		TextBox25.Text = null;
		string[] board = Module1.board;
		for (int i = 0; i < board.Length; i = checked(i + 1))
		{
			string[] array = board[i].Split(new string[1] { "$" }, StringSplitOptions.None);
			ComboBox16.Items.Add(array[1]);
			sjka_cyber.NOTICE_ND.Add(new NoticeData(array[0], array[1], array[2], array[3]));
		}
	}

	private void Button79_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox16.Text, null, TextCompare: false) == 0 || MessageBox.Show(sjka_cyber.NOTICE_ND[ComboBox16.SelectedIndex].getTitle() + " 이 게시글을 정말 삭제 하시겠습니까?", "게시글 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
		{
			return;
		}
		string hTML = new GetHtmlClass(Module1._dburl + "/set.php?t=noticeDEL", "p=" + MySettingsProperty.Settings.pw + "&n=" + sjka_cyber.NOTICE_ND[ComboBox16.SelectedIndex].getIndex(), progress: true).getHTML(this);
		if (Operators.CompareString(hTML, "correct", TextCompare: false) != 0)
		{
			CustomMsgBox.CMsgBox("데이터 처리중에 오류가 생겼습니다.\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. notice\r\n" + hTML, "통신 오류!", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			return;
		}
		CustomMsgBox.CMsgBox(sjka_cyber.NOTICE_ND[ComboBox16.SelectedIndex].getTitle() + " 삭제 되었습니다.", "삭제 완료", "닫기", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true);
		int selectedIndex = ComboBox16.SelectedIndex;
		getNotice();
		try
		{
			ComboBox16.SelectedIndex = checked(selectedIndex - 1);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button85_Click(object sender, EventArgs e)
	{
		string text = null;
		if (Operators.CompareString(TextBox24.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		if (Operators.CompareString(ComboBox16.Text, null, TextCompare: false) == 0)
		{
			if (MessageBox.Show("이 게시글을 등록 하시겠습니까?", "새 게시물 등록", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				text = new GetHtmlClass(Module1._dburl + "/set.php?t=noticeADD", "p=" + MySettingsProperty.Settings.pw + "&title=" + HttpUtility.UrlEncode(TextBox24.Text) + "&d=" + HttpUtility.UrlEncode(TextBox23.Text.Replace("\r\n", "<br>")), progress: true).getHTML(this);
				if (Operators.CompareString(text, "correct", TextCompare: false) != 0)
				{
					CustomMsgBox.CMsgBox("데이터 처리중에 오류가 생겼습니다.\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. notice\r\n" + text, "통신 오류!", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					return;
				}
				string text2 = TextBox24.Text;
				getNotice();
				ComboBox16.Text = text2;
				CustomMsgBox.CMsgBox("서버에 정상적으로 저장 하였습니다.", "저장 완료", "닫기", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 1500);
			}
		}
		else if (MessageBox.Show("이 게시글의 글을 수정 하시겠습니까?", "글 수정", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
		{
			Module1.board[ComboBox16.SelectedIndex].Split(new string[1] { "%" }, StringSplitOptions.None);
			text = new GetHtmlClass(Module1._dburl + "/set.php?t=noticeMOD", "p=" + MySettingsProperty.Settings.pw + "&title=" + HttpUtility.UrlEncode(TextBox24.Text) + "&d=" + HttpUtility.UrlEncode(TextBox23.Text.Replace("\r\n", "<br>")) + "&n=" + sjka_cyber.NOTICE_ND[ComboBox16.SelectedIndex].getIndex()).getHTML(this);
			if (Operators.CompareString(text, "correct", TextCompare: false) != 0)
			{
				CustomMsgBox.CMsgBox("데이터 처리중에 오류가 생겼습니다.\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. notice\r\n" + text, "통신 오류!", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				return;
			}
			int selectedIndex = ComboBox16.SelectedIndex;
			getNotice();
			ComboBox16.SelectedIndex = selectedIndex;
			CustomMsgBox.CMsgBox("서버에 정상적으로 저장 하였습니다.", "저장 완료", "닫기", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 1500);
		}
	}

	private void ComboBox16_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			TextBox24.Text = sjka_cyber.NOTICE_ND[ComboBox16.SelectedIndex].getTitle();
			TextBox23.Text = sjka_cyber.NOTICE_ND[ComboBox16.SelectedIndex].getContent().Replace("<br>", "\r\n");
			TextBox25.Text = sjka_cyber.NOTICE_ND[ComboBox16.SelectedIndex].getViews();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button86_Click(object sender, EventArgs e)
	{
		ComboBox16.Text = null;
		TextBox24.Text = null;
		TextBox23.Text = null;
		TextBox25.Text = null;
		CustomMsgBox.CMsgBox("새로 만들었습니다.\r\n작성이 끝나면 '저장'버튼을 누르세요.", "새로 만들기", "닫기", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Exclamation, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 1500);
		TextBox24.Focus();
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		getAccounts();
	}

	public void getAccounts()
	{
		PictureBox11.Image = null;
		Panel74.Hide();
		mba_check.mba_check_account = new List<ck_account>();
		string hTML = new GetHtmlClass(Module1._dburl + "/admin.php?type=getAccounts&pw=" + MySettingsProperty.Settings.pw, "", progress: true).getHTML(this);
		try
		{
			JObject jObject = JObject.Parse(hTML);
			if (jObject.SelectToken("response").ToString().Equals("ok"))
			{
				mba_check.mba_check_account = JsonConvert.DeserializeObject<List<ck_account>>(jObject.SelectToken("arrays").ToString());
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			mba_check.mba_check_account = new List<ck_account>();
			ProjectData.ClearProjectError();
		}
		mba_accountGrid.Rows.Clear();
		checked
		{
			foreach (ck_account item in mba_check.mba_check_account)
			{
				mba_accountGrid.Rows.Add(item.getGridData());
				if (item.banned != 0)
				{
					mba_accountGrid.Rows[mba_accountGrid.Rows.Count - 1].Cells[6].Style.BackColor = Color.Red;
					mba_accountGrid.Rows[mba_accountGrid.Rows.Count - 1].Cells[6].Style.ForeColor = Color.White;
				}
				else
				{
					mba_accountGrid.Rows[mba_accountGrid.Rows.Count - 1].Cells[6].Style.BackColor = Color.DarkGreen;
					mba_accountGrid.Rows[mba_accountGrid.Rows.Count - 1].Cells[6].Style.ForeColor = Color.White;
				}
				if (item.apptype == 0)
				{
					mba_accountGrid.Rows[mba_accountGrid.Rows.Count - 1].Cells[7].Style.BackColor = Color.DarkGreen;
					mba_accountGrid.Rows[mba_accountGrid.Rows.Count - 1].Cells[7].Style.ForeColor = Color.White;
				}
				else
				{
					mba_accountGrid.Rows[mba_accountGrid.Rows.Count - 1].Cells[7].Style.BackColor = Color.Purple;
					mba_accountGrid.Rows[mba_accountGrid.Rows.Count - 1].Cells[7].Style.ForeColor = Color.White;
				}
			}
		}
	}

	private void Button15_Click(object sender, EventArgs e)
	{
		bool flag = false;
		int num = 0;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)mba_accountGrid.Rows).GetEnumerator();
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
			foreach (ck_account item in mba_check.mba_check_account)
			{
				item._checked = flag;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void mba_accountGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
		{
			try
			{
				mba_check.mba_check_account[e.RowIndex]._checked = !bool.Parse(Conversions.ToString(dataGridView.Rows[e.RowIndex].Cells[0].Value));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button2_Click_1(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)mba_accountGrid.Rows).GetEnumerator();
				_Closure_0024__574_002D0 closure_0024__574_002D = default(_Closure_0024__574_002D0);
				while (enumerator.MoveNext())
				{
					closure_0024__574_002D = new _Closure_0024__574_002D0(closure_0024__574_002D);
					closure_0024__574_002D._0024VB_0024Local_a = (DataGridViewRow)enumerator.Current;
					if (!Conversions.ToBoolean(closure_0024__574_002D._0024VB_0024Local_a.Cells[0].Value) || MessageBox.Show(Conversions.ToString(Operators.AddObject(Operators.AddObject("번호 '", closure_0024__574_002D._0024VB_0024Local_a.Cells[1].Value), "' 데이터를 정말 이용 정지 처리하시겠습니까?")), "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					{
						continue;
					}
					ck_account ck_account2 = mba_check.mba_check_account.Find(closure_0024__574_002D._Lambda_0024__0);
					JObject jObject = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject(Module1._dburl + "/admin.php?type=banAccounts&i=", closure_0024__574_002D._0024VB_0024Local_a.Cells[1].Value), "&b="), Interaction.IIf(ck_account2.banned == 0, "1", "0"))), "&pw=" + MySettingsProperty.Settings.pw, progress: true).getHTML(this));
					if (!jObject.SelectToken("response").ToString().Equals("fail"))
					{
						string left = jObject.SelectToken("cause").ToString();
						if (Operators.CompareString(left, "pw_no_match", TextCompare: false) == 0)
						{
							MessageBox.Show("오류: 권한이 없음. 잘못된 접근", "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							busy = false;
							return;
						}
						if (Operators.CompareString(left, "mysql_error", TextCompare: false) == 0)
						{
							MessageBox.Show("서버와의 통신은 완료했으나 쿼리에 문제가 있습니다.", "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							busy = false;
							return;
						}
					}
					if (!jObject.SelectToken("response").ToString().Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 고객 번호 '", closure_0024__574_002D._0024VB_0024Local_a.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n")));
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
			getAccounts();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			busy = false;
			text = text + "\r\n서버와의 통신에 실패했습니다.\r\n사유: " + ex2.Message + "\r\n";
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		busy = false;
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = null;
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)mba_accountGrid.Rows).GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
					if (!Conversions.ToBoolean(dataGridViewRow.Cells[0].Value) || MessageBox.Show(Conversions.ToString(Operators.AddObject(Operators.AddObject("번호 '", dataGridViewRow.Cells[1].Value), "' 데이터를 정말 삭제 하시겠습니까?")), "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					{
						continue;
					}
					JObject jObject = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(Module1._dburl + "/admin.php?type=delAccounts&i=", dataGridViewRow.Cells[1].Value)), "&pw=" + MySettingsProperty.Settings.pw, progress: true).getHTML(this));
					if (!jObject.SelectToken("response").ToString().Equals("fail"))
					{
						string left = jObject.SelectToken("cause").ToString();
						if (Operators.CompareString(left, "pw_no_match", TextCompare: false) == 0)
						{
							MessageBox.Show("오류: 권한이 없음. 잘못된 접근", "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							busy = false;
							return;
						}
						if (Operators.CompareString(left, "mysql_error", TextCompare: false) == 0)
						{
							MessageBox.Show("서버와의 통신은 완료했으나 쿼리에 문제가 있습니다.", "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							busy = false;
							return;
						}
					}
					if (!jObject.SelectToken("response").ToString().Equals("ok"))
					{
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.AddObject(Operators.AddObject("\r\n트랜잭션 롤백 발생: 고객 번호 '", dataGridViewRow.Cells[1].Value), "' 아래와 같은 사유로 반영되지 않았습니다."), "\r\n")));
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
			getAccounts();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			busy = false;
			text = text + "\r\n서버와의 통신에 실패했습니다.\r\n사유: " + ex2.Message + "\r\n";
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text, null, TextCompare: false) != 0)
		{
			MessageBox.Show(text.Trim(), "오류 발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		busy = false;
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (init)
		{
			bw.Url = new Uri(Module1._dburl + "/fup.php?apptype=1");
			bw.Tag = 1;
		}
		p4.Controls.Add(pn);
		p4.Controls.SetChildIndex(pn, 0);
		pn.Show();
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		getBanner(1);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		object left = null;
		foreach (ck_advertise hakwon_check_adv in mba_check.hakwon_check_advList)
		{
			left = ((!Operators.ConditionalCompareObjectEqual(left, null, TextCompare: false)) ? Operators.ConcatenateObject(left, ",") : "[");
			left = Operators.ConcatenateObject(left, Operators.ConcatenateObject(Operators.ConcatenateObject("{\"index\":\"" + Conversions.ToString(hakwon_check_adv.index) + "\",\"name\":\"" + hakwon_check_adv.name + "\",\"url\":\"", Interaction.IIf(hakwon_check_adv.url.Contains("http://"), hakwon_check_adv.url, "http://" + hakwon_check_adv.url)), "\"}"));
		}
		left = Operators.ConcatenateObject(left, "]");
		int selectedIndex = ListBox1.SelectedIndex;
		ListBox1.SelectedIndex = -1;
		string hTML = new GetHtmlClass(Module1._dburl + "/admin.php?type=updateBanner&pw=" + MySettingsProperty.Settings.pw, Conversions.ToString(Operators.ConcatenateObject("json=", left)), progress: true).getHTML(this);
		try
		{
			JObject jObject = JObject.Parse(hTML);
			if (jObject.SelectToken("response").ToString().Equals("ok"))
			{
				getBanner(1);
				ListBox1.SelectedIndex = selectedIndex;
			}
			else
			{
				CustomMsgBox.CMsgBox("서버에 오류가 있습니다.\r\n" + jObject.SelectToken("cause").ToString(), "오류 발생", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!editMode)
		{
			if (ListBox1.SelectedIndex < 0)
			{
				DoubleBufferPanel5.Hide();
			}
			else
			{
				DoubleBufferPanel5.Show();
			}
			try
			{
				TextBox3.Text = Conversions.ToString(mba_check.hakwon_check_advList[ListBox1.SelectedIndex].index);
				TextBox4.Text = mba_check.hakwon_check_advList[ListBox1.SelectedIndex].name;
				TextBox6.Text = mba_check.hakwon_check_advList[ListBox1.SelectedIndex].fname;
				TextBox5.Text = mba_check.hakwon_check_advList[ListBox1.SelectedIndex].url;
				byte[] buffer = Convert.FromBase64String(mba_check.hakwon_check_advList[ListBox1.SelectedIndex].blob);
				MemoryStream stream = new MemoryStream(buffer);
				PictureBox1.Image = Image.FromStream(stream);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				PictureBox1.Image = null;
				GC.Collect();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void TextBox4_TextChanged(object sender, EventArgs e)
	{
		editMode = true;
		mba_check.hakwon_check_advList[ListBox1.SelectedIndex].name = TextBox4.Text;
		ListBox1.Items[ListBox1.SelectedIndex] = TextBox4.Text;
		editMode = false;
	}

	private void TextBox5_TextChanged(object sender, EventArgs e)
	{
		editMode = true;
		mba_check.hakwon_check_advList[ListBox1.SelectedIndex].url = TextBox5.Text;
		editMode = false;
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		int selectedIndex = ListBox1.SelectedIndex;
		string hTML = new GetHtmlClass(Module1._dburl + "/admin.php?type=delBanner&i=" + TextBox3.Text.Trim() + "&pw=" + MySettingsProperty.Settings.pw, "", progress: true).getHTML(this);
		try
		{
			JObject jObject = JObject.Parse(hTML);
			if (jObject.SelectToken("response").ToString().Equals("ok"))
			{
				getBanner(1);
				if (selectedIndex != 0)
				{
					ListBox1.SelectedIndex = checked(selectedIndex - 1);
				}
			}
			else
			{
				CustomMsgBox.CMsgBox("서버에 오류가 있습니다.\r\n" + jObject.SelectToken("cause").ToString(), "오류 발생", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void getHow2Use()
	{
		sjka_cyber.HOW2USE = new List<How2UseData>();
		string hTML = new GetHtmlClass(Module1._dburl + "/get.php?t=getHow2Use", Conversions.ToString(Value: true)).getHTML(this);
		if (Operators.CompareString(hTML, "incorrect", TextCompare: false) == 0)
		{
			CustomMsgBox.CMsgBox("잠시 후에 다시 시도하십시오.\r\n이런 현상이 계속되면 MLAS를 종료하고 재시작 하십시오.", "통신대기 발생", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 3000);
			return;
		}
		if (Operators.CompareString(hTML, null, TextCompare: false) == 0)
		{
			CustomMsgBox.CMsgBox("데이터 처리중에 오류가 생겼습니다.\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. notice", "통신 오류!", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			return;
		}
		ComboBoxEx2.Items.Clear();
		TextBox37.Text = null;
		TextBox34.Text = null;
		string[] array = hTML.Split(new string[1] { "<split>" }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			string[] array2 = array[i].Split(new string[1] { "<sp>" }, StringSplitOptions.None);
			ComboBoxEx2.Items.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Val(array2[4]) == 1.0, "[기본] ", ""), Interaction.IIf(Conversion.Val(array2[3]) == 1.0, "[중요] ", "")), array2[1]));
			sjka_cyber.HOW2USE.Add(new How2UseData(array2[0], array2[1], array2[2], Conversions.ToBoolean(array2[3]), Conversions.ToBoolean(array2[4])));
		}
	}

	private void Button163_Click(object sender, EventArgs e)
	{
		getHow2Use();
	}

	private void ComboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			TextBox37.Text = sjka_cyber.HOW2USE[ComboBoxEx2.SelectedIndex].getTitle();
			TextBox34.Text = sjka_cyber.HOW2USE[ComboBoxEx2.SelectedIndex].getContent();
			CheckBox13.Checked = sjka_cyber.HOW2USE[ComboBoxEx2.SelectedIndex].Important;
			if (WebBrowser1.Visible)
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Encoding = Encoding.UTF8;
					WebBrowser1.DocumentText = webClient.DownloadString(Module1._dburl + "/get.php?t=imgHtml&d=" + HttpUtility.UrlEncode("<style>body {margin:0;padding:0;margin-top:0;}</style>" + TextBox34.Text.Replace("<img>", "")));
					return;
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

	private void Button160_Click(object sender, EventArgs e)
	{
		if (ComboBoxEx2.SelectedIndex < 0)
		{
			return;
		}
		if (Conversions.ToBoolean(sjka_cyber.HOW2USE[ComboBoxEx2.SelectedIndex].getLock()))
		{
			MessageBox.Show("기본 설명서는 삭제가 불가능 하고 수정만 가능합니다.", "게시글 삭제 불가", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			if (MessageBox.Show(sjka_cyber.HOW2USE[ComboBoxEx2.SelectedIndex].getTitle() + " 이 게시글을 정말 삭제 하시겠습니까?", "게시글 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}
			if (Operators.CompareString(new GetHtmlClass(Module1._dburl + "/set.php?t=delHow2Use", "p=" + MySettingsProperty.Settings.pw + "&n=" + sjka_cyber.HOW2USE[ComboBoxEx2.SelectedIndex].getIndex(), progress: true).getHTML(this), "correct", TextCompare: false) == 0)
			{
				CustomMsgBox.CMsgBox(sjka_cyber.HOW2USE[ComboBoxEx2.SelectedIndex].getTitle() + " 삭제 되었습니다.", "삭제 완료", "닫기", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true);
				int selectedIndex = ComboBoxEx2.SelectedIndex;
				getHow2Use();
				try
				{
					ComboBoxEx2.SelectedIndex = checked(selectedIndex - 1);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return;
				}
			}
			CustomMsgBox.CMsgBox("데이터 처리중에 오류가 생겼습니다.\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. notice", "통신 오류!", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
		}
	}

	private void Button162_Click(object sender, EventArgs e)
	{
		ComboBoxEx2.Text = null;
		TextBox37.Text = null;
		TextBox34.Text = null;
		CustomMsgBox.CMsgBox("새로 만들었습니다.\r\n작성이 끝나면 '저장'버튼을 누르세요.", "새로 만들기", "닫기", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Exclamation, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 1500);
		TextBox37.Focus();
	}

	private void Button164_Click(object sender, EventArgs e)
	{
		if (TextBox34.Visible)
		{
			Label129.Text = "미리보기 (스마트폰 환경에서 보여지는 화면과 차이가 있을 수 있습니다.)";
			using (WebClient webClient = new WebClient())
			{
				webClient.Encoding = Encoding.UTF8;
				WebBrowser1.DocumentText = webClient.DownloadString(Module1._dburl + "/get.php?t=imgHtml&d=" + HttpUtility.UrlEncode("<style>body {margin:0;padding:0;margin-top:0;}</style>" + TextBox34.Text.Replace("<img>", "")));
			}
			TextBox34.Hide();
			WebBrowser1.Show();
			Button164.Text = "돌아가기";
		}
		else
		{
			Label129.Text = "본문 (HTML 코드로 작성 가능합니다.)";
			TextBox34.Show();
			WebBrowser1.Hide();
			Button164.Text = "미리보기";
		}
	}

	private void Button161_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox37.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		if (Operators.CompareString(ComboBoxEx2.Text, null, TextCompare: false) == 0)
		{
			if (MessageBox.Show("이 게시글을 등록 하시겠습니까?", "새 게시물 등록", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				if (Operators.CompareString(new GetHtmlClass(Module1._dburl + "/set.php?t=addHow2Use", Conversions.ToString(Operators.ConcatenateObject("p=" + MySettingsProperty.Settings.pw + "&title=" + HttpUtility.UrlEncode(TextBox37.Text) + "&d=" + HttpUtility.UrlEncode(TextBox34.Text) + "&v=", Interaction.IIf(CheckBox13.Checked, "1", "0")))).getHTML(this), "correct", TextCompare: false) != 0)
				{
					CustomMsgBox.CMsgBox("데이터 처리중에 오류가 생겼습니다.\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. how2use", "통신 오류!", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					return;
				}
				string text = TextBox37.Text;
				getHow2Use();
				ComboBoxEx2.Text = text;
				CustomMsgBox.CMsgBox("서버에 정상적으로 저장 하였습니다.", "저장 완료", "닫기", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 1500);
			}
		}
		else if (MessageBox.Show("이 게시글을 수정 하시겠습니까?", "글 수정", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
		{
			if (Operators.CompareString(new GetHtmlClass(Module1._dburl + "/set.php?t=updateHow2Use", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("p=" + MySettingsProperty.Settings.pw + "&title=" + HttpUtility.UrlEncode(TextBox37.Text) + "&d=" + HttpUtility.UrlEncode(TextBox34.Text) + "&v=", Interaction.IIf(CheckBox13.Checked, "1", "0")), "&n="), sjka_cyber.HOW2USE[ComboBoxEx2.SelectedIndex].getIndex()))).getHTML(this), "correct", TextCompare: false) != 0)
			{
				CustomMsgBox.CMsgBox("데이터 처리중에 오류가 생겼습니다.\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. how2use", "통신 오류!", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				return;
			}
			int selectedIndex = ComboBoxEx2.SelectedIndex;
			getHow2Use();
			ComboBoxEx2.SelectedIndex = selectedIndex;
			CustomMsgBox.CMsgBox("서버에 정상적으로 저장 하였습니다.", "저장 완료", "닫기", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 1500);
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			SaveFileDialog saveFileDialog2 = saveFileDialog;
			saveFileDialog2.Filter = "*.csv|*.csv";
			saveFileDialog2.FileName = "회원관리_" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd(HH시mm분)") + ".csv";
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
				streamWriter.WriteLine(",번호,이메일,학원명,사용자 이름,휴대폰 번호,상태,가입된 앱");
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = mba_accountGrid.SelectedRows.GetEnumerator();
					IEnumerator enumerator2 = default(IEnumerator);
					while (enumerator.MoveNext())
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
						text = null;
						try
						{
							enumerator2 = dataGridViewRow.Cells.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataGridViewCell dataGridViewCell = (DataGridViewCell)enumerator2.Current;
								text = ((!Operators.ConditionalCompareObjectEqual(dataGridViewCell.Value, null, TextCompare: false)) ? Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject('"', dataGridViewCell.Value), '"'), ","))) : (text + ","));
							}
						}
						finally
						{
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						streamWriter.WriteLine(text);
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
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("테이블 백업에 실패 했습니다.\r\n\r\n" + ex2.Message, "백업 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			ProjectData.ClearProjectError();
		}
	}
}
