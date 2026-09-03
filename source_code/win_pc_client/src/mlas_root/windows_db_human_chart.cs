using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My;

namespace mlas_root;

[DesignerGenerated]
public class windows_db_human_chart : Form
{
	private IContainer components;

	private bool search_mode;

	private string[] record;

	public string[] fontoption;

	private ColumnHeader m_SortingColumn;

	private bool busy;

	private bool bCancelEdit;

	private ListViewItem.ListViewSubItem CurrentSB;

	private ListViewItem CurrentItem;

	private bool bakBusy;

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

	[field: AccessedThroughProperty("Panel77")]
	internal virtual Panel Panel77
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox17")]
	internal virtual TextBox TextBox17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox16")]
	internal virtual TextBox TextBox16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox15")]
	internal virtual TextBox TextBox15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox14")]
	internal virtual TextBox TextBox14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label51")]
	internal virtual Label Label51
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

	[field: AccessedThroughProperty("Label64")]
	internal virtual Label Label64
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel68")]
	internal virtual Panel Panel68
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel75")]
	internal virtual Panel Panel75
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar4")]
	internal virtual ProgressBar ProgressBar4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("txt_search2")]
	internal virtual Label txt_search2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel73")]
	internal virtual Panel Panel73
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
			EventHandler value2 = Button19_Click_1;
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

	[field: AccessedThroughProperty("Panel74")]
	internal virtual Panel Panel74
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label46")]
	internal virtual Label Label46
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

	internal virtual ListView ListView3
	{
		[CompilerGenerated]
		get
		{
			return _ListView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ListView3_MouseDoubleClick;
			ListView listView = _ListView3;
			if (listView != null)
			{
				listView.MouseDoubleClick -= value2;
			}
			_ListView3 = value;
			listView = _ListView3;
			if (listView != null)
			{
				listView.MouseDoubleClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("nums")]
	internal virtual ColumnHeader nums
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("names")]
	internal virtual ColumnHeader names
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("email")]
	internal virtual ColumnHeader email
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dates")]
	internal virtual ColumnHeader dates
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("survey")]
	internal virtual ColumnHeader survey
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

	[field: AccessedThroughProperty("ColumnHeader2")]
	internal virtual ColumnHeader ColumnHeader2
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

	[field: AccessedThroughProperty("ColumnHeader22")]
	internal virtual ColumnHeader ColumnHeader22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader23")]
	internal virtual ColumnHeader ColumnHeader23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader24")]
	internal virtual ColumnHeader ColumnHeader24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader25")]
	internal virtual ColumnHeader ColumnHeader25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader26")]
	internal virtual ColumnHeader ColumnHeader26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel67")]
	internal virtual Panel Panel67
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel69")]
	internal virtual Panel Panel69
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

	[field: AccessedThroughProperty("Label44")]
	internal virtual Label Label44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel76")]
	internal virtual Panel Panel76
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar5")]
	internal virtual ProgressBar ProgressBar5
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

	[field: AccessedThroughProperty("Panel70")]
	internal virtual Panel Panel70
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel71")]
	internal virtual Panel Panel71
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel72")]
	internal virtual Panel Panel72
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button62
	{
		[CompilerGenerated]
		get
		{
			return _Button62;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button62_Click;
			Button button = _Button62;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button62 = value;
			button = _Button62;
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

	internal virtual Button Button59
	{
		[CompilerGenerated]
		get
		{
			return _Button59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Button59_Click;
			Button button = _Button59;
			if (button != null)
			{
				button.MouseDown -= value2;
			}
			_Button59 = value;
			button = _Button59;
			if (button != null)
			{
				button.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Button61")]
	internal virtual Button Button61
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button65
	{
		[CompilerGenerated]
		get
		{
			return _Button65;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button65_Click;
			Button button = _Button65;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button65 = value;
			button = _Button65;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button66
	{
		[CompilerGenerated]
		get
		{
			return _Button66;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button66_Click;
			Button button = _Button66;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button66 = value;
			button = _Button66;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p2")]
	internal virtual Panel p2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel83")]
	internal virtual Panel Panel83
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button64
	{
		[CompilerGenerated]
		get
		{
			return _Button64;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button64_Click;
			Button button = _Button64;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button64 = value;
			button = _Button64;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox18")]
	internal virtual TextBox TextBox18
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

	[field: AccessedThroughProperty("Panel84")]
	internal virtual Panel Panel84
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox15
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox15_SelectedIndexChanged;
			EventHandler value3 = ComboBox15_Resize;
			DrawItemEventHandler value4 = DrawItemEvent;
			ComboBox comboBox = _ComboBox15;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
				comboBox.Resize -= value3;
				comboBox.DrawItem -= value4;
			}
			_ComboBox15 = value;
			comboBox = _ComboBox15;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
				comboBox.Resize += value3;
				comboBox.DrawItem += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Label65")]
	internal virtual Label Label65
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel78")]
	internal virtual Panel Panel78
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel79")]
	internal virtual Panel Panel79
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

	[field: AccessedThroughProperty("Label50")]
	internal virtual Label Label50
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel80")]
	internal virtual Panel Panel80
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel81")]
	internal virtual Panel Panel81
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel82")]
	internal virtual Panel Panel82
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button63
	{
		[CompilerGenerated]
		get
		{
			return _Button63;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button63_Click;
			Button button = _Button63;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button63 = value;
			button = _Button63;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p3")]
	internal virtual Panel p3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual NumericUpDown NumericUpDown1
	{
		[CompilerGenerated]
		get
		{
			return _NumericUpDown1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NumericUpDown1_ValueChanged;
			NumericUpDown numericUpDown = _NumericUpDown1;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged -= value2;
			}
			_NumericUpDown1 = value;
			numericUpDown = _NumericUpDown1;
			if (numericUpDown != null)
			{
				numericUpDown.ValueChanged += value2;
			}
		}
	}

	internal virtual Label font4
	{
		[CompilerGenerated]
		get
		{
			return _font4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label78_Click;
			Label label = _font4;
			if (label != null)
			{
				label.Click -= value2;
			}
			_font4 = value;
			label = _font4;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label font3
	{
		[CompilerGenerated]
		get
		{
			return _font3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label79_Click;
			Label label = _font3;
			if (label != null)
			{
				label.Click -= value2;
			}
			_font3 = value;
			label = _font3;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("font2")]
	internal virtual Label font2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label font1
	{
		[CompilerGenerated]
		get
		{
			return _font1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label81_Click;
			Label label = _font1;
			if (label != null)
			{
				label.Click -= value2;
			}
			_font1 = value;
			label = _font1;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label77")]
	internal virtual Label Label77
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label76")]
	internal virtual Label Label76
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel98")]
	internal virtual Panel Panel98
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel99")]
	internal virtual Panel Panel99
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label72")]
	internal virtual Label Label72
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label73")]
	internal virtual Label Label73
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel100")]
	internal virtual Panel Panel100
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel101")]
	internal virtual Panel Panel101
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel102")]
	internal virtual Panel Panel102
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Button Button73
	{
		[CompilerGenerated]
		get
		{
			return _Button73;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button73_Click;
			Button button = _Button73;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button73 = value;
			button = _Button73;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label74")]
	internal virtual Label Label74
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label75")]
	internal virtual Label Label75
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

	[field: AccessedThroughProperty("ColumnHeader27")]
	internal virtual ColumnHeader ColumnHeader27
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

	public windows_db_human_chart()
	{
		base.Load += windows_db_human_chart_Load;
		search_mode = false;
		busy = false;
		bakBusy = false;
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
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.p1 = new System.Windows.Forms.Panel();
		this.Panel77 = new System.Windows.Forms.Panel();
		this.TextBox17 = new System.Windows.Forms.TextBox();
		this.TextBox16 = new System.Windows.Forms.TextBox();
		this.TextBox15 = new System.Windows.Forms.TextBox();
		this.TextBox14 = new System.Windows.Forms.TextBox();
		this.Button57 = new System.Windows.Forms.Button();
		this.Label51 = new System.Windows.Forms.Label();
		this.Button60 = new System.Windows.Forms.Button();
		this.Label64 = new System.Windows.Forms.Label();
		this.Panel68 = new System.Windows.Forms.Panel();
		this.Panel75 = new System.Windows.Forms.Panel();
		this.ProgressBar4 = new System.Windows.Forms.ProgressBar();
		this.Button56 = new System.Windows.Forms.Button();
		this.txt_search2 = new System.Windows.Forms.Label();
		this.Panel73 = new System.Windows.Forms.Panel();
		this.TextBox13 = new System.Windows.Forms.TextBox();
		this.Button19 = new System.Windows.Forms.Button();
		this.Panel74 = new System.Windows.Forms.Panel();
		this.Button55 = new System.Windows.Forms.Button();
		this.Label46 = new System.Windows.Forms.Label();
		this.Label47 = new System.Windows.Forms.Label();
		this.ListView3 = new System.Windows.Forms.ListView();
		this.nums = new System.Windows.Forms.ColumnHeader();
		this.names = new System.Windows.Forms.ColumnHeader();
		this.email = new System.Windows.Forms.ColumnHeader();
		this.dates = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader27 = new System.Windows.Forms.ColumnHeader();
		this.survey = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
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
		this.ColumnHeader15 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader16 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader17 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader18 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader19 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader20 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader21 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader22 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader23 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader24 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader25 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader26 = new System.Windows.Forms.ColumnHeader();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Panel67 = new System.Windows.Forms.Panel();
		this.Panel69 = new System.Windows.Forms.Panel();
		this.Label43 = new System.Windows.Forms.Label();
		this.Label44 = new System.Windows.Forms.Label();
		this.Panel76 = new System.Windows.Forms.Panel();
		this.ProgressBar5 = new System.Windows.Forms.ProgressBar();
		this.Label49 = new System.Windows.Forms.Label();
		this.Panel70 = new System.Windows.Forms.Panel();
		this.Panel71 = new System.Windows.Forms.Panel();
		this.Panel72 = new System.Windows.Forms.Panel();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button62 = new System.Windows.Forms.Button();
		this.Button58 = new System.Windows.Forms.Button();
		this.Button59 = new System.Windows.Forms.Button();
		this.Button61 = new System.Windows.Forms.Button();
		this.Button65 = new System.Windows.Forms.Button();
		this.Button66 = new System.Windows.Forms.Button();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.p2 = new System.Windows.Forms.Panel();
		this.Panel83 = new System.Windows.Forms.Panel();
		this.Button64 = new System.Windows.Forms.Button();
		this.TextBox18 = new System.Windows.Forms.TextBox();
		this.Label52 = new System.Windows.Forms.Label();
		this.Panel84 = new System.Windows.Forms.Panel();
		this.ComboBox15 = new System.Windows.Forms.ComboBox();
		this.Label65 = new System.Windows.Forms.Label();
		this.Panel78 = new System.Windows.Forms.Panel();
		this.Panel79 = new System.Windows.Forms.Panel();
		this.Label48 = new System.Windows.Forms.Label();
		this.Label50 = new System.Windows.Forms.Label();
		this.Panel80 = new System.Windows.Forms.Panel();
		this.Panel81 = new System.Windows.Forms.Panel();
		this.Panel82 = new System.Windows.Forms.Panel();
		this.Button63 = new System.Windows.Forms.Button();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.p3 = new System.Windows.Forms.Panel();
		this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
		this.font4 = new System.Windows.Forms.Label();
		this.font3 = new System.Windows.Forms.Label();
		this.font2 = new System.Windows.Forms.Label();
		this.font1 = new System.Windows.Forms.Label();
		this.Label77 = new System.Windows.Forms.Label();
		this.Label76 = new System.Windows.Forms.Label();
		this.Panel98 = new System.Windows.Forms.Panel();
		this.Panel99 = new System.Windows.Forms.Panel();
		this.Label72 = new System.Windows.Forms.Label();
		this.Label73 = new System.Windows.Forms.Label();
		this.Panel100 = new System.Windows.Forms.Panel();
		this.Panel101 = new System.Windows.Forms.Panel();
		this.Panel102 = new System.Windows.Forms.Panel();
		this.Button74 = new System.Windows.Forms.Button();
		this.Button73 = new System.Windows.Forms.Button();
		this.Label74 = new System.Windows.Forms.Label();
		this.Label75 = new System.Windows.Forms.Label();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.p1.SuspendLayout();
		this.Panel77.SuspendLayout();
		this.Panel68.SuspendLayout();
		this.Panel75.SuspendLayout();
		this.Panel73.SuspendLayout();
		this.Panel74.SuspendLayout();
		this.Panel67.SuspendLayout();
		this.Panel76.SuspendLayout();
		this.Panel72.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.p2.SuspendLayout();
		this.Panel83.SuspendLayout();
		this.Panel84.SuspendLayout();
		this.Panel78.SuspendLayout();
		this.Panel82.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.p3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
		this.Panel98.SuspendLayout();
		this.Panel102.SuspendLayout();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabControl1.Location = new System.Drawing.Point(0, 0);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(845, 633);
		this.TabControl1.TabIndex = 0;
		this.TabPage1.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
		this.TabPage1.Controls.Add(this.p1);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(837, 607);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "검사결과데이터";
		this.p1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p1.Controls.Add(this.Panel77);
		this.p1.Controls.Add(this.Panel68);
		this.p1.Controls.Add(this.ListView3);
		this.p1.Controls.Add(this.Panel1);
		this.p1.Controls.Add(this.Panel67);
		this.p1.Controls.Add(this.Panel76);
		this.p1.Controls.Add(this.Panel70);
		this.p1.Controls.Add(this.Panel71);
		this.p1.Controls.Add(this.Panel72);
		this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p1.Location = new System.Drawing.Point(3, 3);
		this.p1.Name = "p1";
		this.p1.Size = new System.Drawing.Size(831, 601);
		this.p1.TabIndex = 10;
		this.Panel77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel77.Controls.Add(this.TextBox17);
		this.Panel77.Controls.Add(this.TextBox16);
		this.Panel77.Controls.Add(this.TextBox15);
		this.Panel77.Controls.Add(this.TextBox14);
		this.Panel77.Controls.Add(this.Button57);
		this.Panel77.Controls.Add(this.Label51);
		this.Panel77.Controls.Add(this.Button60);
		this.Panel77.Controls.Add(this.Label64);
		this.Panel77.Location = new System.Drawing.Point(36, 254);
		this.Panel77.Name = "Panel77";
		this.Panel77.Size = new System.Drawing.Size(420, 262);
		this.Panel77.TabIndex = 27;
		this.Panel77.Visible = false;
		this.TextBox17.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox17.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox17.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox17.Location = new System.Drawing.Point(120, 177);
		this.TextBox17.Name = "TextBox17";
		this.TextBox17.Size = new System.Drawing.Size(264, 27);
		this.TextBox17.TabIndex = 19;
		this.TextBox16.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox16.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox16.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox16.Location = new System.Drawing.Point(120, 137);
		this.TextBox16.Name = "TextBox16";
		this.TextBox16.Size = new System.Drawing.Size(264, 27);
		this.TextBox16.TabIndex = 18;
		this.TextBox15.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox15.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox15.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox15.Location = new System.Drawing.Point(120, 97);
		this.TextBox15.Name = "TextBox15";
		this.TextBox15.Size = new System.Drawing.Size(264, 27);
		this.TextBox15.TabIndex = 17;
		this.TextBox14.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox14.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox14.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox14.Location = new System.Drawing.Point(120, 58);
		this.TextBox14.Name = "TextBox14";
		this.TextBox14.Size = new System.Drawing.Size(264, 27);
		this.TextBox14.TabIndex = 16;
		this.Button57.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button57.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button57.Location = new System.Drawing.Point(212, 222);
		this.Button57.Name = "Button57";
		this.Button57.Size = new System.Drawing.Size(86, 24);
		this.Button57.TabIndex = 21;
		this.Button57.Text = "취소";
		this.Button57.UseVisualStyleBackColor = false;
		this.Label51.AutoSize = true;
		this.Label51.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label51.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.Label51.Location = new System.Drawing.Point(16, 61);
		this.Label51.Name = "Label51";
		this.Label51.Size = new System.Drawing.Size(89, 140);
		this.Label51.TabIndex = 3;
		this.Label51.Text = "이름\r\n\r\n이메일\r\n\r\n날짜\r\n\r\n검사 데이터";
		this.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button60.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button60.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button60.Location = new System.Drawing.Point(120, 222);
		this.Button60.Name = "Button60";
		this.Button60.Size = new System.Drawing.Size(86, 24);
		this.Button60.TabIndex = 20;
		this.Button60.Text = "추가";
		this.Button60.UseVisualStyleBackColor = false;
		this.Label64.AutoSize = true;
		this.Label64.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label64.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label64.Location = new System.Drawing.Point(144, 14);
		this.Label64.Name = "Label64";
		this.Label64.Size = new System.Drawing.Size(131, 30);
		this.Label64.TabIndex = 0;
		this.Label64.Text = "데이터 추가";
		this.Panel68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel68.Controls.Add(this.Panel75);
		this.Panel68.Controls.Add(this.Panel73);
		this.Panel68.Controls.Add(this.Panel74);
		this.Panel68.Location = new System.Drawing.Point(35, 68);
		this.Panel68.Name = "Panel68";
		this.Panel68.Size = new System.Drawing.Size(516, 182);
		this.Panel68.TabIndex = 25;
		this.Panel68.Visible = false;
		this.Panel75.Controls.Add(this.ProgressBar4);
		this.Panel75.Controls.Add(this.Button56);
		this.Panel75.Controls.Add(this.txt_search2);
		this.Panel75.Location = new System.Drawing.Point(-1, 103);
		this.Panel75.Name = "Panel75";
		this.Panel75.Size = new System.Drawing.Size(517, 83);
		this.Panel75.TabIndex = 9;
		this.Panel75.Visible = false;
		this.ProgressBar4.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
		this.ProgressBar4.ForeColor = System.Drawing.Color.FromArgb(184, 255, 48);
		this.ProgressBar4.Location = new System.Drawing.Point(47, 7);
		this.ProgressBar4.Name = "ProgressBar4";
		this.ProgressBar4.Size = new System.Drawing.Size(426, 19);
		this.ProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
		this.ProgressBar4.TabIndex = 6;
		this.ProgressBar4.Value = 50;
		this.Button56.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button56.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button56.Location = new System.Drawing.Point(387, 34);
		this.Button56.Name = "Button56";
		this.Button56.Size = new System.Drawing.Size(86, 24);
		this.Button56.TabIndex = 4;
		this.Button56.Text = "검색 취소";
		this.Button56.UseVisualStyleBackColor = false;
		this.txt_search2.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.txt_search2.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.txt_search2.Location = new System.Drawing.Point(45, 35);
		this.txt_search2.Name = "txt_search2";
		this.txt_search2.Size = new System.Drawing.Size(334, 23);
		this.txt_search2.TabIndex = 7;
		this.txt_search2.Text = "검색 중 입니다. 잠시만 기다려 주세요... (1/14452)";
		this.txt_search2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel73.Controls.Add(this.TextBox13);
		this.Panel73.Controls.Add(this.Button19);
		this.Panel73.Location = new System.Drawing.Point(0, 48);
		this.Panel73.Name = "Panel73";
		this.Panel73.Size = new System.Drawing.Size(514, 53);
		this.Panel73.TabIndex = 10;
		this.TextBox13.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox13.Font = new System.Drawing.Font("맑은 고딕", 14f);
		this.TextBox13.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox13.Location = new System.Drawing.Point(44, 7);
		this.TextBox13.Name = "TextBox13";
		this.TextBox13.Size = new System.Drawing.Size(334, 32);
		this.TextBox13.TabIndex = 7;
		this.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Button19.BackColor = System.Drawing.Color.YellowGreen;
		this.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button19.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button19.Location = new System.Drawing.Point(384, 7);
		this.Button19.Name = "Button19";
		this.Button19.Size = new System.Drawing.Size(88, 32);
		this.Button19.TabIndex = 6;
		this.Button19.Text = "검색";
		this.Button19.UseVisualStyleBackColor = false;
		this.Panel74.Controls.Add(this.Button55);
		this.Panel74.Controls.Add(this.Label46);
		this.Panel74.Controls.Add(this.Label47);
		this.Panel74.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel74.Location = new System.Drawing.Point(0, 0);
		this.Panel74.Name = "Panel74";
		this.Panel74.Size = new System.Drawing.Size(514, 48);
		this.Panel74.TabIndex = 8;
		this.Button55.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button55.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button55.Location = new System.Drawing.Point(384, 23);
		this.Button55.Name = "Button55";
		this.Button55.Size = new System.Drawing.Size(88, 25);
		this.Button55.TabIndex = 8;
		this.Button55.Text = "닫기";
		this.Button55.UseVisualStyleBackColor = false;
		this.Label46.AutoSize = true;
		this.Label46.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label46.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label46.Location = new System.Drawing.Point(39, 19);
		this.Label46.Name = "Label46";
		this.Label46.Size = new System.Drawing.Size(57, 30);
		this.Label46.TabIndex = 0;
		this.Label46.Text = "검색";
		this.Label47.AutoSize = true;
		this.Label47.Font = new System.Drawing.Font("맑은 고딕", 9f);
		this.Label47.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.Label47.Location = new System.Drawing.Point(100, 28);
		this.Label47.Name = "Label47";
		this.Label47.Size = new System.Drawing.Size(162, 15);
		this.Label47.TabIndex = 3;
		this.Label47.Text = "다중 키워드 세미콜론(;) 구분";
		this.ListView3.Activation = System.Windows.Forms.ItemActivation.OneClick;
		this.ListView3.AllowColumnReorder = true;
		this.ListView3.BackColor = System.Drawing.Color.White;
		this.ListView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListView3.CheckBoxes = true;
		this.ListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[32]
		{
			this.nums, this.names, this.email, this.dates, this.ColumnHeader27, this.survey, this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4,
			this.ColumnHeader5, this.ColumnHeader6, this.ColumnHeader7, this.ColumnHeader8, this.ColumnHeader9, this.ColumnHeader10, this.ColumnHeader11, this.ColumnHeader12, this.ColumnHeader13, this.ColumnHeader14,
			this.ColumnHeader15, this.ColumnHeader16, this.ColumnHeader17, this.ColumnHeader18, this.ColumnHeader19, this.ColumnHeader20, this.ColumnHeader21, this.ColumnHeader22, this.ColumnHeader23, this.ColumnHeader24,
			this.ColumnHeader25, this.ColumnHeader26
		});
		this.ListView3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView3.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListView3.ForeColor = System.Drawing.Color.Black;
		this.ListView3.FullRowSelect = true;
		this.ListView3.GridLines = true;
		this.ListView3.HideSelection = false;
		this.ListView3.Location = new System.Drawing.Point(23, 56);
		this.ListView3.Name = "ListView3";
		this.ListView3.ShowGroups = false;
		this.ListView3.Size = new System.Drawing.Size(785, 444);
		this.ListView3.TabIndex = 24;
		this.ListView3.UseCompatibleStateImageBehavior = false;
		this.ListView3.View = System.Windows.Forms.View.Details;
		this.ListView3.VirtualListSize = 500;
		this.nums.Text = "번호";
		this.nums.Width = 80;
		this.names.Text = "이름";
		this.names.Width = 100;
		this.email.Text = "이메일";
		this.email.Width = 206;
		this.dates.Text = "검사 날짜";
		this.dates.Width = 230;
		this.ColumnHeader27.Text = "IP";
		this.ColumnHeader27.Width = 150;
		this.survey.Text = "셀프";
		this.survey.Width = 100;
		this.ColumnHeader1.Text = "에너지";
		this.ColumnHeader1.Width = 100;
		this.ColumnHeader2.Text = "해브";
		this.ColumnHeader2.Width = 100;
		this.ColumnHeader3.Text = "그룹";
		this.ColumnHeader3.Width = 100;
		this.ColumnHeader4.Text = "휴머니즘";
		this.ColumnHeader4.Width = 100;
		this.ColumnHeader5.Text = "미러 셀프";
		this.ColumnHeader5.Width = 100;
		this.ColumnHeader6.Text = "미러 에너지";
		this.ColumnHeader6.Width = 100;
		this.ColumnHeader7.Text = "미러 해브";
		this.ColumnHeader7.Width = 100;
		this.ColumnHeader8.Text = "미러 그룹";
		this.ColumnHeader8.Width = 100;
		this.ColumnHeader9.Text = "미러 휴머니즘";
		this.ColumnHeader9.Width = 100;
		this.ColumnHeader10.Text = "시각";
		this.ColumnHeader10.Width = 100;
		this.ColumnHeader11.Text = "청각";
		this.ColumnHeader11.Width = 100;
		this.ColumnHeader12.Text = "촉각";
		this.ColumnHeader12.Width = 100;
		this.ColumnHeader13.Text = "외향";
		this.ColumnHeader13.Width = 100;
		this.ColumnHeader14.Text = "내향";
		this.ColumnHeader14.Width = 100;
		this.ColumnHeader15.Text = "이성적";
		this.ColumnHeader15.Width = 100;
		this.ColumnHeader16.Text = "감성적";
		this.ColumnHeader16.Width = 100;
		this.ColumnHeader17.Text = "다양한 관계";
		this.ColumnHeader17.Width = 100;
		this.ColumnHeader18.Text = "밀접한 관계";
		this.ColumnHeader18.Width = 100;
		this.ColumnHeader19.Text = "구체적";
		this.ColumnHeader19.Width = 100;
		this.ColumnHeader20.Text = "추상적";
		this.ColumnHeader20.Width = 100;
		this.ColumnHeader21.Text = "조기착수";
		this.ColumnHeader21.Width = 100;
		this.ColumnHeader22.Text = "임박착수";
		this.ColumnHeader22.Width = 100;
		this.ColumnHeader23.Text = "관습적";
		this.ColumnHeader23.Width = 100;
		this.ColumnHeader24.Text = "개성적";
		this.ColumnHeader24.Width = 100;
		this.ColumnHeader25.Text = "체계성";
		this.ColumnHeader25.Width = 100;
		this.ColumnHeader26.Text = "유연성";
		this.ColumnHeader26.Width = 100;
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(23, 500);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(785, 19);
		this.Panel1.TabIndex = 46;
		this.Panel67.Controls.Add(this.Panel69);
		this.Panel67.Controls.Add(this.Label43);
		this.Panel67.Controls.Add(this.Label44);
		this.Panel67.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel67.Location = new System.Drawing.Point(23, 0);
		this.Panel67.Name = "Panel67";
		this.Panel67.Size = new System.Drawing.Size(785, 56);
		this.Panel67.TabIndex = 14;
		this.Panel69.BackColor = System.Drawing.Color.Gray;
		this.Panel69.Location = new System.Drawing.Point(185, 41);
		this.Panel69.Name = "Panel69";
		this.Panel69.Size = new System.Drawing.Size(2000, 1);
		this.Panel69.TabIndex = 5;
		this.Label43.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label43.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label43.Location = new System.Drawing.Point(183, 15);
		this.Label43.Name = "Label43";
		this.Label43.Size = new System.Drawing.Size(675, 30);
		this.Label43.TabIndex = 4;
		this.Label43.Text = "항목을 더블클릭하면 차트를 볼 수 있으며, 저장 및 프린트가 가능합니다.";
		this.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label44.AutoSize = true;
		this.Label44.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label44.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label44.Location = new System.Drawing.Point(0, 15);
		this.Label44.Name = "Label44";
		this.Label44.Size = new System.Drawing.Size(183, 30);
		this.Label44.TabIndex = 1;
		this.Label44.Text = "검사 결과 데이터";
		this.Panel76.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
		this.Panel76.Controls.Add(this.ProgressBar5);
		this.Panel76.Controls.Add(this.Label49);
		this.Panel76.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel76.Location = new System.Drawing.Point(23, 519);
		this.Panel76.Name = "Panel76";
		this.Panel76.Size = new System.Drawing.Size(785, 38);
		this.Panel76.TabIndex = 26;
		this.Panel76.Visible = false;
		this.ProgressBar5.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
		this.ProgressBar5.ForeColor = System.Drawing.Color.FromArgb(184, 255, 48);
		this.ProgressBar5.Location = new System.Drawing.Point(19, 10);
		this.ProgressBar5.Name = "ProgressBar5";
		this.ProgressBar5.Size = new System.Drawing.Size(519, 19);
		this.ProgressBar5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
		this.ProgressBar5.TabIndex = 6;
		this.ProgressBar5.Value = 50;
		this.Label49.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label49.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.Label49.Location = new System.Drawing.Point(544, 11);
		this.Label49.Name = "Label49";
		this.Label49.Size = new System.Drawing.Size(258, 17);
		this.Label49.TabIndex = 7;
		this.Label49.Text = "데이터베이스 백업 중...";
		this.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel70.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel70.Location = new System.Drawing.Point(808, 0);
		this.Panel70.Name = "Panel70";
		this.Panel70.Size = new System.Drawing.Size(23, 557);
		this.Panel70.TabIndex = 13;
		this.Panel71.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel71.Location = new System.Drawing.Point(0, 0);
		this.Panel71.Name = "Panel71";
		this.Panel71.Size = new System.Drawing.Size(23, 557);
		this.Panel71.TabIndex = 12;
		this.Panel72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel72.Controls.Add(this.Button1);
		this.Panel72.Controls.Add(this.Button62);
		this.Panel72.Controls.Add(this.Button58);
		this.Panel72.Controls.Add(this.Button59);
		this.Panel72.Controls.Add(this.Button61);
		this.Panel72.Controls.Add(this.Button65);
		this.Panel72.Controls.Add(this.Button66);
		this.Panel72.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel72.Location = new System.Drawing.Point(0, 557);
		this.Panel72.Name = "Panel72";
		this.Panel72.Size = new System.Drawing.Size(831, 44);
		this.Panel72.TabIndex = 11;
		this.Button1.BackColor = System.Drawing.Color.DarkGreen;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(202, 8);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(91, 27);
		this.Button1.TabIndex = 9;
		this.Button1.Text = "IP기록 삭제";
		this.Button1.UseVisualStyleBackColor = false;
		this.Button62.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button62.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button62.Location = new System.Drawing.Point(299, 8);
		this.Button62.Name = "Button62";
		this.Button62.Size = new System.Drawing.Size(85, 27);
		this.Button62.TabIndex = 8;
		this.Button62.Text = "데이터 추가";
		this.Button62.UseVisualStyleBackColor = false;
		this.Button58.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button58.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button58.Location = new System.Drawing.Point(477, 8);
		this.Button58.Name = "Button58";
		this.Button58.Size = new System.Drawing.Size(85, 27);
		this.Button58.TabIndex = 7;
		this.Button58.Text = "백업";
		this.Button58.UseVisualStyleBackColor = false;
		this.Button59.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button59.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button59.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button59.Location = new System.Drawing.Point(388, 8);
		this.Button59.Name = "Button59";
		this.Button59.Size = new System.Drawing.Size(85, 27);
		this.Button59.TabIndex = 6;
		this.Button59.Text = "검색";
		this.Button59.UseVisualStyleBackColor = false;
		this.Button61.BackColor = System.Drawing.Color.DarkGreen;
		this.Button61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button61.ForeColor = System.Drawing.Color.White;
		this.Button61.Location = new System.Drawing.Point(795, 8);
		this.Button61.Name = "Button61";
		this.Button61.Size = new System.Drawing.Size(85, 27);
		this.Button61.TabIndex = 5;
		this.Button61.Text = "열 맞춤";
		this.Button61.UseVisualStyleBackColor = false;
		this.Button61.Visible = false;
		this.Button65.BackColor = System.Drawing.Color.Firebrick;
		this.Button65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button65.ForeColor = System.Drawing.Color.White;
		this.Button65.Location = new System.Drawing.Point(111, 8);
		this.Button65.Name = "Button65";
		this.Button65.Size = new System.Drawing.Size(85, 27);
		this.Button65.TabIndex = 1;
		this.Button65.Text = "선택 삭제";
		this.Button65.UseVisualStyleBackColor = false;
		this.Button66.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button66.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button66.Location = new System.Drawing.Point(22, 8);
		this.Button66.Name = "Button66";
		this.Button66.Size = new System.Drawing.Size(85, 27);
		this.Button66.TabIndex = 0;
		this.Button66.Text = "전체 선택";
		this.Button66.UseVisualStyleBackColor = false;
		this.TabPage2.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
		this.TabPage2.Controls.Add(this.p2);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(982, 607);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "질문관리";
		this.p2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p2.Controls.Add(this.Panel83);
		this.p2.Controls.Add(this.Panel84);
		this.p2.Controls.Add(this.Panel78);
		this.p2.Controls.Add(this.Panel80);
		this.p2.Controls.Add(this.Panel81);
		this.p2.Controls.Add(this.Panel82);
		this.p2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p2.Location = new System.Drawing.Point(3, 3);
		this.p2.Name = "p2";
		this.p2.Size = new System.Drawing.Size(976, 601);
		this.p2.TabIndex = 11;
		this.p2.Visible = false;
		this.Panel83.Controls.Add(this.Button64);
		this.Panel83.Controls.Add(this.TextBox18);
		this.Panel83.Controls.Add(this.Label52);
		this.Panel83.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel83.Location = new System.Drawing.Point(23, 140);
		this.Panel83.Name = "Panel83";
		this.Panel83.Padding = new System.Windows.Forms.Padding(20, 5, 20, 20);
		this.Panel83.Size = new System.Drawing.Size(930, 417);
		this.Panel83.TabIndex = 43;
		this.Button64.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button64.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button64.Location = new System.Drawing.Point(153, 11);
		this.Button64.Name = "Button64";
		this.Button64.Size = new System.Drawing.Size(98, 27);
		this.Button64.TabIndex = 3;
		this.Button64.Text = "작성 요령";
		this.Button64.UseVisualStyleBackColor = false;
		this.TextBox18.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox18.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox18.Font = new System.Drawing.Font("굴림", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox18.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox18.Location = new System.Drawing.Point(20, 45);
		this.TextBox18.Multiline = true;
		this.TextBox18.Name = "TextBox18";
		this.TextBox18.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.TextBox18.Size = new System.Drawing.Size(890, 352);
		this.TextBox18.TabIndex = 2;
		this.Label52.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label52.Font = new System.Drawing.Font("맑은 고딕", 14f, System.Drawing.FontStyle.Bold);
		this.Label52.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label52.Location = new System.Drawing.Point(20, 5);
		this.Label52.Name = "Label52";
		this.Label52.Size = new System.Drawing.Size(890, 40);
		this.Label52.TabIndex = 1;
		this.Label52.Text = "질문 스크립트";
		this.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel84.Controls.Add(this.ComboBox15);
		this.Panel84.Controls.Add(this.Label65);
		this.Panel84.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel84.Location = new System.Drawing.Point(23, 56);
		this.Panel84.Name = "Panel84";
		this.Panel84.Padding = new System.Windows.Forms.Padding(20, 5, 20, 20);
		this.Panel84.Size = new System.Drawing.Size(930, 84);
		this.Panel84.TabIndex = 44;
		this.ComboBox15.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox15.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ComboBox15.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ComboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox15.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox15.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox15.FormattingEnabled = true;
		this.ComboBox15.Location = new System.Drawing.Point(20, 50);
		this.ComboBox15.Name = "ComboBox15";
		this.ComboBox15.Size = new System.Drawing.Size(890, 30);
		this.ComboBox15.TabIndex = 4;
		this.Label65.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label65.Font = new System.Drawing.Font("맑은 고딕", 14f, System.Drawing.FontStyle.Bold);
		this.Label65.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label65.Location = new System.Drawing.Point(20, 5);
		this.Label65.Name = "Label65";
		this.Label65.Size = new System.Drawing.Size(890, 45);
		this.Label65.TabIndex = 1;
		this.Label65.Text = "질문 카테고리 선택";
		this.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel78.Controls.Add(this.Panel79);
		this.Panel78.Controls.Add(this.Label48);
		this.Panel78.Controls.Add(this.Label50);
		this.Panel78.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel78.Location = new System.Drawing.Point(23, 0);
		this.Panel78.Name = "Panel78";
		this.Panel78.Size = new System.Drawing.Size(930, 56);
		this.Panel78.TabIndex = 41;
		this.Panel79.BackColor = System.Drawing.Color.Gray;
		this.Panel79.Location = new System.Drawing.Point(113, 41);
		this.Panel79.Name = "Panel79";
		this.Panel79.Size = new System.Drawing.Size(2000, 1);
		this.Panel79.TabIndex = 3;
		this.Label48.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label48.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label48.Location = new System.Drawing.Point(111, 15);
		this.Label48.Name = "Label48";
		this.Label48.Size = new System.Drawing.Size(595, 30);
		this.Label48.TabIndex = 2;
		this.Label48.Text = "검사에 사용될 질문 내용을 변경하거나 추가하십시오.";
		this.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label50.AutoSize = true;
		this.Label50.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label50.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label50.Location = new System.Drawing.Point(0, 15);
		this.Label50.Name = "Label50";
		this.Label50.Size = new System.Drawing.Size(109, 30);
		this.Label50.TabIndex = 1;
		this.Label50.Text = "질문 관리";
		this.Panel80.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel80.Location = new System.Drawing.Point(0, 0);
		this.Panel80.Name = "Panel80";
		this.Panel80.Size = new System.Drawing.Size(23, 557);
		this.Panel80.TabIndex = 39;
		this.Panel81.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel81.Location = new System.Drawing.Point(953, 0);
		this.Panel81.Name = "Panel81";
		this.Panel81.Size = new System.Drawing.Size(23, 557);
		this.Panel81.TabIndex = 40;
		this.Panel82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel82.Controls.Add(this.Button63);
		this.Panel82.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel82.Location = new System.Drawing.Point(0, 557);
		this.Panel82.Name = "Panel82";
		this.Panel82.Size = new System.Drawing.Size(976, 44);
		this.Panel82.TabIndex = 42;
		this.Button63.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button63.ForeColor = System.Drawing.Color.White;
		this.Button63.Location = new System.Drawing.Point(22, 8);
		this.Button63.Name = "Button63";
		this.Button63.Size = new System.Drawing.Size(93, 27);
		this.Button63.TabIndex = 5;
		this.Button63.Text = "저장";
		this.Button63.UseVisualStyleBackColor = false;
		this.TabPage3.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
		this.TabPage3.Controls.Add(this.p3);
		this.TabPage3.Location = new System.Drawing.Point(4, 22);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage3.Size = new System.Drawing.Size(982, 607);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "UI변경";
		this.p3.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p3.Controls.Add(this.NumericUpDown1);
		this.p3.Controls.Add(this.font4);
		this.p3.Controls.Add(this.font3);
		this.p3.Controls.Add(this.font2);
		this.p3.Controls.Add(this.font1);
		this.p3.Controls.Add(this.Label77);
		this.p3.Controls.Add(this.Label76);
		this.p3.Controls.Add(this.Panel98);
		this.p3.Controls.Add(this.Panel100);
		this.p3.Controls.Add(this.Panel101);
		this.p3.Controls.Add(this.Panel102);
		this.p3.Controls.Add(this.Label74);
		this.p3.Controls.Add(this.Label75);
		this.p3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p3.Location = new System.Drawing.Point(3, 3);
		this.p3.Name = "p3";
		this.p3.Size = new System.Drawing.Size(976, 601);
		this.p3.TabIndex = 13;
		this.p3.Visible = false;
		this.NumericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.NumericUpDown1.Font = new System.Drawing.Font("굴림", 14f);
		this.NumericUpDown1.ForeColor = System.Drawing.Color.White;
		this.NumericUpDown1.Location = new System.Drawing.Point(393, 135);
		this.NumericUpDown1.Maximum = new decimal(new int[4] { 18, 0, 0, 0 });
		this.NumericUpDown1.Minimum = new decimal(new int[4] { 8, 0, 0, 0 });
		this.NumericUpDown1.Name = "NumericUpDown1";
		this.NumericUpDown1.Size = new System.Drawing.Size(17, 29);
		this.NumericUpDown1.TabIndex = 49;
		this.NumericUpDown1.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.font4.BackColor = System.Drawing.Color.Green;
		this.font4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.font4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.font4.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.font4.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.font4.Location = new System.Drawing.Point(196, 241);
		this.font4.Name = "font4";
		this.font4.Size = new System.Drawing.Size(213, 29);
		this.font4.TabIndex = 48;
		this.font4.Text = "0,128,0";
		this.font4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.font3.BackColor = System.Drawing.Color.FromArgb(6, 106, 156);
		this.font3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.font3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.font3.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.font3.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.font3.Location = new System.Drawing.Point(197, 188);
		this.font3.Name = "font3";
		this.font3.Size = new System.Drawing.Size(213, 29);
		this.font3.TabIndex = 47;
		this.font3.Text = "6,106,156";
		this.font3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.font2.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.font2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.font2.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.font2.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.font2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.font2.Location = new System.Drawing.Point(197, 135);
		this.font2.Name = "font2";
		this.font2.Size = new System.Drawing.Size(213, 29);
		this.font2.TabIndex = 46;
		this.font2.Text = "12pt";
		this.font2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.font1.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.font1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.font1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.font1.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.font1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.font1.Location = new System.Drawing.Point(197, 82);
		this.font1.Name = "font1";
		this.font1.Size = new System.Drawing.Size(213, 29);
		this.font1.TabIndex = 45;
		this.font1.Text = "맑은 고딕";
		this.font1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label77.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label77.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label77.Location = new System.Drawing.Point(51, 241);
		this.Label77.Name = "Label77";
		this.Label77.Size = new System.Drawing.Size(118, 29);
		this.Label77.TabIndex = 44;
		this.Label77.Text = "색2 변경";
		this.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label76.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label76.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label76.Location = new System.Drawing.Point(52, 188);
		this.Label76.Name = "Label76";
		this.Label76.Size = new System.Drawing.Size(118, 29);
		this.Label76.TabIndex = 43;
		this.Label76.Text = "색1 변경";
		this.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel98.Controls.Add(this.Panel99);
		this.Panel98.Controls.Add(this.Label72);
		this.Panel98.Controls.Add(this.Label73);
		this.Panel98.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel98.Location = new System.Drawing.Point(23, 0);
		this.Panel98.Name = "Panel98";
		this.Panel98.Size = new System.Drawing.Size(930, 56);
		this.Panel98.TabIndex = 41;
		this.Panel99.BackColor = System.Drawing.Color.Gray;
		this.Panel99.Location = new System.Drawing.Point(90, 41);
		this.Panel99.Name = "Panel99";
		this.Panel99.Size = new System.Drawing.Size(2000, 1);
		this.Panel99.TabIndex = 3;
		this.Label72.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label72.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label72.Location = new System.Drawing.Point(88, 15);
		this.Label72.Name = "Label72";
		this.Label72.Size = new System.Drawing.Size(595, 30);
		this.Label72.TabIndex = 2;
		this.Label72.Text = "휴먼 차트에 표시되는 폰트 형식을 수정하거나 색을 변경 할 수 있습니다.";
		this.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label73.AutoSize = true;
		this.Label73.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label73.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label73.Location = new System.Drawing.Point(0, 15);
		this.Label73.Name = "Label73";
		this.Label73.Size = new System.Drawing.Size(88, 30);
		this.Label73.TabIndex = 1;
		this.Label73.Text = "UI 변경";
		this.Panel100.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel100.Location = new System.Drawing.Point(0, 0);
		this.Panel100.Name = "Panel100";
		this.Panel100.Size = new System.Drawing.Size(23, 557);
		this.Panel100.TabIndex = 39;
		this.Panel101.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel101.Location = new System.Drawing.Point(953, 0);
		this.Panel101.Name = "Panel101";
		this.Panel101.Size = new System.Drawing.Size(23, 557);
		this.Panel101.TabIndex = 40;
		this.Panel102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel102.Controls.Add(this.Button74);
		this.Panel102.Controls.Add(this.Button73);
		this.Panel102.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel102.Location = new System.Drawing.Point(0, 557);
		this.Panel102.Name = "Panel102";
		this.Panel102.Size = new System.Drawing.Size(976, 44);
		this.Panel102.TabIndex = 42;
		this.Button74.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button74.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Button74.Location = new System.Drawing.Point(128, 8);
		this.Button74.Name = "Button74";
		this.Button74.Size = new System.Drawing.Size(100, 27);
		this.Button74.TabIndex = 8;
		this.Button74.Text = "초기화";
		this.Button74.UseVisualStyleBackColor = false;
		this.Button73.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button73.ForeColor = System.Drawing.Color.White;
		this.Button73.Location = new System.Drawing.Point(22, 8);
		this.Button73.Name = "Button73";
		this.Button73.Size = new System.Drawing.Size(100, 27);
		this.Button73.TabIndex = 7;
		this.Button73.Text = "저장";
		this.Button73.UseVisualStyleBackColor = false;
		this.Label74.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label74.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label74.Location = new System.Drawing.Point(52, 135);
		this.Label74.Name = "Label74";
		this.Label74.Size = new System.Drawing.Size(118, 29);
		this.Label74.TabIndex = 2;
		this.Label74.Text = "폰트 크기 변경";
		this.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label75.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label75.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label75.Location = new System.Drawing.Point(52, 82);
		this.Label75.Name = "Label75";
		this.Label75.Size = new System.Drawing.Size(118, 29);
		this.Label75.TabIndex = 1;
		this.Label75.Text = "폰트 변경";
		this.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
		base.ClientSize = new System.Drawing.Size(845, 633);
		base.Controls.Add(this.TabControl1);
		base.Name = "windows_db_human_chart";
		this.Text = "windows_db_human_chart";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.p1.ResumeLayout(false);
		this.Panel77.ResumeLayout(false);
		this.Panel77.PerformLayout();
		this.Panel68.ResumeLayout(false);
		this.Panel75.ResumeLayout(false);
		this.Panel73.ResumeLayout(false);
		this.Panel73.PerformLayout();
		this.Panel74.ResumeLayout(false);
		this.Panel74.PerformLayout();
		this.Panel67.ResumeLayout(false);
		this.Panel67.PerformLayout();
		this.Panel76.ResumeLayout(false);
		this.Panel72.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.p2.ResumeLayout(false);
		this.Panel83.ResumeLayout(false);
		this.Panel83.PerformLayout();
		this.Panel84.ResumeLayout(false);
		this.Panel78.ResumeLayout(false);
		this.Panel78.PerformLayout();
		this.Panel82.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.p3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
		this.Panel98.ResumeLayout(false);
		this.Panel98.PerformLayout();
		this.Panel102.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public void SurveyList(bool refresh = true)
	{
		string text = "all";
		string text2 = Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?type=" + text));
		if (Operators.CompareString(text2, "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오. " + text, "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Module1.survey_data = Module1.HtmlSourceNoCredent("http://umylife0208.cafe24.com/survey/util.php?type=getSurvey").ToString().Split(new string[1] { "$" }, StringSplitOptions.RemoveEmptyEntries);
		ComboBox15.Items.Clear();
		TextBox18.Text = null;
		checked
		{
			int num = Module1.survey_data.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Module1.survey_data[i], null, "Split", new object[2]
				{
					new string[1] { "%" },
					StringSplitOptions.RemoveEmptyEntries
				}, null, null, null));
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, null), "fontoption", TextCompare: false))
				{
					fontoption = NewLateBinding.LateIndexGet(objectValue, new object[1] { 1 }, null).ToString().Split(new string[1] { "|" }, StringSplitOptions.None);
					font1.Text = fontoption[0];
					NumericUpDown1.Value = new decimal(Conversion.Val(fontoption[1]));
					font2.Text = fontoption[1] + "pt";
					font3.Text = fontoption[2];
					string[] array = fontoption[2].Split(',');
					font3.BackColor = Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
					font4.Text = fontoption[3];
					string[] array2 = fontoption[3].Split(',');
					font4.BackColor = Color.FromArgb(Conversions.ToInteger(array2[0]), Conversions.ToInteger(array2[1]), Conversions.ToInteger(array2[2]));
				}
				else
				{
					ComboBox15.Items.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { 0 }, null)));
				}
			}
			ListView3.Items.Clear();
			if (refresh)
			{
				ListView3.ListViewItemSorter = new ListViewComparer(0, SortOrder.Ascending);
				ListView3.Sort();
			}
			Module1.AllData = text2.Split(new string[1] { "$" }, StringSplitOptions.RemoveEmptyEntries);
			int num2 = Module1.AllData.Length - 1;
			for (int j = 0; j <= num2; j++)
			{
				string[] array3 = Module1.AllData[j].Split(new string[1] { "%" }, StringSplitOptions.None);
				ListView3.Items.Add(array3[0]);
				int num3 = array3.Length - 2;
				for (int k = 1; k <= num3; k++)
				{
					ListView3.Items[j].SubItems.Add(array3[k]);
				}
				string[] array4 = array3[array3.Length - 1].Split(new string[1] { "|" }, StringSplitOptions.None);
				int num4 = array4.Length - 1;
				for (int l = 0; l <= num4; l++)
				{
					ListView3.Items[j].SubItems.Add(array4[l]);
				}
			}
		}
	}

	private void ListView3_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		CurrentItem = ListView3.GetItemAt(e.X, e.Y);
		checked
		{
			if (CurrentItem != null)
			{
				MyProject.Forms.printpage.txt_number = CurrentItem.SubItems[0].Text;
				MyProject.Forms.printpage.txt_name = CurrentItem.SubItems[1].Text;
				MyProject.Forms.printpage.txt_email = CurrentItem.SubItems[2].Text;
				MyProject.Forms.printpage.txt_date = CurrentItem.SubItems[3].Text;
				ListViewItem.ListViewSubItemCollection subItems = CurrentItem.SubItems;
				int num = 5;
				try
				{
					MyProject.Forms.printpage.part1_result = new int[5]
					{
						Conversions.ToInteger(subItems[num].Text),
						Conversions.ToInteger(subItems[num + 1].Text),
						Conversions.ToInteger(subItems[num + 2].Text),
						Conversions.ToInteger(subItems[num + 3].Text),
						Conversions.ToInteger(subItems[num + 4].Text)
					};
					num += 5;
					MyProject.Forms.printpage.part1_mirror_result = new int[5]
					{
						Conversions.ToInteger(subItems[num].Text),
						Conversions.ToInteger(subItems[num + 1].Text),
						Conversions.ToInteger(subItems[num + 2].Text),
						Conversions.ToInteger(subItems[num + 3].Text),
						Conversions.ToInteger(subItems[num + 4].Text)
					};
					num += 5;
					MyProject.Forms.printpage.symbol_result = new int[3]
					{
						Conversions.ToInteger(subItems[num].Text),
						Conversions.ToInteger(subItems[num + 1].Text),
						Conversions.ToInteger(subItems[num + 2].Text)
					};
					num += 3;
					MyProject.Forms.printpage.others_result = new int[14]
					{
						Conversions.ToInteger(subItems[num].Text),
						Conversions.ToInteger(subItems[num + 1].Text),
						Conversions.ToInteger(subItems[num + 2].Text),
						Conversions.ToInteger(subItems[num + 3].Text),
						Conversions.ToInteger(subItems[num + 4].Text),
						Conversions.ToInteger(subItems[num + 5].Text),
						Conversions.ToInteger(subItems[num + 6].Text),
						Conversions.ToInteger(subItems[num + 7].Text),
						Conversions.ToInteger(subItems[num + 8].Text),
						Conversions.ToInteger(subItems[num + 9].Text),
						Conversions.ToInteger(subItems[num + 10].Text),
						Conversions.ToInteger(subItems[num + 11].Text),
						Conversions.ToInteger(subItems[num + 12].Text),
						Conversions.ToInteger(subItems[num + 13].Text)
					};
					MyProject.Forms.printpage.Show();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show("설문이 완료되지 않은 항목은 차트를 열 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private void Button59_Click(object sender, EventArgs e)
	{
		if (!busy)
		{
			if (!search_mode)
			{
				Label47.Text = "다중 키워드 세미콜론(;) 구분";
				Panel75.Visible = false;
				Panel73.Enabled = true;
				TextBox13.Text = null;
				Point point = Module1.ControlCenter(p1, Panel68);
				Panel68.Top = point.X;
				Panel68.Left = point.Y;
				Panel68.Size = new Size(516, 118);
				Panel68.Visible = true;
				TextBox13.Focus();
			}
			else
			{
				search_mode = false;
				SurveyList();
				Label44.Text = "설문 관리";
				Label43.Text = "검사 결과 차트를 여기에서 보거나 인쇄할 수 있습니다.";
				Button59.Text = "검색";
				Button59.BackColor = Color.Black;
			}
		}
	}

	private void ListView3_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		ColumnHeader columnHeader = ListView3.Columns[e.Column];
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
		ListView3.ListViewItemSorter = new ListViewComparer(e.Column, sortOrder);
		ListView3.Sort();
	}

	private void Button19_Click_1(object sender, EventArgs e)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		string text = TextBox13.Text;
		string[] array = text.Split(new string[1] { ";" }, StringSplitOptions.RemoveEmptyEntries);
		checked
		{
			int num = array.Length - 1;
			Panel75.Visible = true;
			Panel68.Size = new Size(516, 182);
			Panel73.Enabled = false;
			ArrayList arrayList = new ArrayList();
			ProgressBar4.Maximum = Module1.AllData.Length;
			ProgressBar4.Value = 0;
			try
			{
				int num2 = Module1.AllData.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					Application.DoEvents();
					txt_search2.Text = "검색 중 입니다. 잠시만 기다려 주세요... (" + Conversions.ToString(i) + "/" + Conversions.ToString(ProgressBar4.Maximum) + ")";
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
					ProgressBar4.Value++;
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
				search_mode = false;
				Label47.Text = "검색결과가 없습니다.";
				Panel73.Enabled = true;
				Panel75.Visible = false;
				Panel68.Size = new Size(516, 118);
				TextBox13.Focus();
			}
			else
			{
				busy = false;
				search_mode = true;
				Panel68.Visible = false;
				ListView3.Items.Clear();
				Module1.SearchData = new string[arrayList.Count + 1];
				int num5 = arrayList.Count - 1;
				for (int k = 0; k <= num5; k++)
				{
					string[] array3 = Module1.AllData[(int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(arrayList[k])))].Split(new string[1] { "%" }, StringSplitOptions.None);
					ListView3.Items.Add(array3[0]);
					int num6 = array3.Length - 2;
					for (int l = 1; l <= num6; l++)
					{
						ListView3.Items[k].SubItems.Add(array3[l]);
					}
					string[] array4 = array3[array3.Length - 1].Split(new string[1] { "|" }, StringSplitOptions.None);
					int num7 = array4.Length - 1;
					for (int m = 0; m <= num7; m++)
					{
						ListView3.Items[k].SubItems.Add(array4[m]);
					}
				}
				Label44.Text = "검색 모드";
				Label43.Text = "검색어 '" + text + "'에 대한 검색결과 입니다. 총 " + Conversions.ToString(arrayList.Count) + "항목 검색 됨.";
			}
			if (!search_mode)
			{
				Button59.Text = "검색";
				Button59.BackColor = Color.Black;
			}
			else
			{
				Button59.Text = "검색 종료";
				Button59.BackColor = Color.RoyalBlue;
			}
		}
	}

	private void Button55_Click(object sender, EventArgs e)
	{
		Panel68.Visible = false;
	}

	private void Button56_Click(object sender, EventArgs e)
	{
		busy = false;
	}

	private void TextBox13_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button19_Click_1(RuntimeHelpers.GetObjectValue(sender), e);
		}
		if (e.KeyCode == Keys.Escape)
		{
			Panel68.Visible = false;
			busy = false;
		}
	}

	private void Button58_Click(object sender, EventArgs e)
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
				Panel76.Visible = true;
				ProgressBar5.Value = 0;
				ProgressBar5.Maximum = Module1.AllData.Length;
				string text = null;
				int num = 0;
				do
				{
					try
					{
						text = text + record[num] + ",";
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
						Label49.Text = "데이터베이스 백업 중... (" + Conversions.ToString(i + 1) + "/" + Conversions.ToString(Module1.AllData.Length) + ")";
						ProgressBar5.Value++;
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
				Panel76.Visible = false;
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

	private void Button66_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (ListView3.Items[0].Checked)
				{
					int num = ListView3.Items.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						ListView3.Items[i].Checked = false;
					}
				}
				else
				{
					int num2 = ListView3.Items.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						ListView3.Items[j].Checked = true;
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

	private void Button65_Click(object sender, EventArgs e)
	{
		string text = null;
		checked
		{
			int num = ListView3.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ListView3.Items[i].Checked)
				{
					text = text + "," + ListView3.Items[i].SubItems[0].Text;
				}
			}
			if (Operators.CompareString(text, null, TextCompare: false) == 0 || MessageBox.Show("정말 선택된 항목을 모두 삭제 하시겠습니까?\r\n\r\n영구적으로 삭제되며 복구할 수 없습니다.", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
			{
				return;
			}
			int num2 = ListView3.Items.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				if (ListView3.Items[j].Checked && Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=DelData&num=" + ListView3.Items[j].SubItems[0].Text)), "incorrect", TextCompare: false) == 0)
				{
					MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			SurveyList();
		}
	}

	private void Button62_Click(object sender, EventArgs e)
	{
		Point point = Module1.ControlCenter(p1, Panel77);
		Panel77.Top = point.X;
		Panel77.Left = point.Y;
		Panel77.Visible = true;
		TextBox14.Focus();
	}

	private void Button60_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=AddData&name=" + TextBox14.Text + "&email=" + TextBox15.Text + "&date=" + TextBox16.Text + "&survey=" + TextBox17.Text)), "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		SurveyList();
		Panel77.Visible = false;
		TextBox14.Text = null;
		TextBox15.Text = null;
		TextBox16.Text = null;
		TextBox17.Text = null;
	}

	private void Button57_Click(object sender, EventArgs e)
	{
		Panel77.Visible = false;
		TextBox14.Text = null;
		TextBox15.Text = null;
		TextBox16.Text = null;
		TextBox17.Text = null;
	}

	private void ComboBox15_SelectedIndexChanged(object sender, EventArgs e)
	{
		string[] array = Module1.survey_data[ComboBox15.SelectedIndex].ToString().Split(new string[1] { "%" }, StringSplitOptions.RemoveEmptyEntries);
		TextBox18.Text = array[1];
	}

	private void Button63_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox15.Text, null, TextCompare: false) == 0)
		{
			return;
		}
		string text = null;
		checked
		{
			if (TextBox18.Lines.Length < 15)
			{
				text = Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=update&rname=" + ComboBox15.Text + "&data=" + HttpUtility.UrlEncode(TextBox18.Text)));
			}
			else
			{
				text = Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=update&rname=" + ComboBox15.Text + "&data=" + HttpUtility.UrlEncode(TextBox18.Lines[0] + "\r\n")));
				int num = TextBox18.Lines.Length - 1;
				for (int i = 1; i <= num; i++)
				{
					text = Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=update2&rname=" + ComboBox15.Text + "&data=" + HttpUtility.UrlEncode(TextBox18.Lines[i] + "\r\n")));
				}
			}
			if ((Operators.CompareString(text, "incorrect", TextCompare: false) == 0) | (Operators.CompareString(text, null, TextCompare: false) == 0))
			{
				MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Module1.survey_data[ComboBox15.SelectedIndex] = ComboBox15.Text + "%" + TextBox18.Text;
			MessageBox.Show("성공적으로 저장 하였습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void ComboBox15_Resize(object sender, EventArgs e)
	{
		ComboBox15.Refresh();
	}

	private void Label81_Click(object sender, EventArgs e)
	{
		FontDialog fontDialog = new FontDialog();
		fontDialog.ShowColor = false;
		fontDialog.ShowEffects = false;
		fontDialog.ShowHelp = false;
		fontDialog.ShowApply = false;
		Font font2 = (fontDialog.Font = new Font(font1.Text, Convert.ToSingle(NumericUpDown1.Value)));
		fontDialog.MaxSize = 18;
		fontDialog.MinSize = 8;
		fontDialog.AllowSimulations = false;
		fontDialog.AllowVerticalFonts = false;
		_ = null;
		if (fontDialog.ShowDialog() == DialogResult.OK)
		{
			font1.Text = fontDialog.Font.Name;
			NumericUpDown1.Value = new decimal(fontDialog.Font.Size);
		}
	}

	private void Label80_Click(object sender, EventArgs e)
	{
	}

	private void Label79_Click(object sender, EventArgs e)
	{
		ColorDialog colorDialog = new ColorDialog();
		string[] array = font3.Text.Split(new string[1] { "," }, StringSplitOptions.None);
		colorDialog.Color = checked(Color.FromArgb((int)Math.Round(Conversion.Val(array[0].Trim())), (int)Math.Round(Conversion.Val(array[1].Trim())), (int)Math.Round(Conversion.Val(array[2].Trim()))));
		colorDialog.AnyColor = true;
		colorDialog.ShowHelp = false;
		_ = null;
		if (colorDialog.ShowDialog() == DialogResult.OK)
		{
			if (colorDialog.Color.G >= 128)
			{
				font3.ForeColor = Color.Black;
			}
			else
			{
				font3.ForeColor = Color.FromArgb(224, 224, 224);
			}
			font3.Text = Conversions.ToString(colorDialog.Color.R) + "," + Conversions.ToString(colorDialog.Color.G) + "," + Conversions.ToString(colorDialog.Color.B);
			font3.BackColor = colorDialog.Color;
		}
	}

	private void Label78_Click(object sender, EventArgs e)
	{
		ColorDialog colorDialog = new ColorDialog();
		string[] array = font4.Text.Split(new string[1] { "," }, StringSplitOptions.None);
		colorDialog.Color = checked(Color.FromArgb((int)Math.Round(Conversion.Val(array[0].Trim())), (int)Math.Round(Conversion.Val(array[1].Trim())), (int)Math.Round(Conversion.Val(array[2].Trim()))));
		colorDialog.AnyColor = true;
		colorDialog.ShowHelp = false;
		_ = null;
		if (colorDialog.ShowDialog() == DialogResult.OK)
		{
			if (colorDialog.Color.G >= 128)
			{
				font4.ForeColor = Color.Black;
			}
			else
			{
				font4.ForeColor = Color.FromArgb(224, 224, 224);
			}
			font4.Text = Conversions.ToString(colorDialog.Color.R) + "," + Conversions.ToString(colorDialog.Color.G) + "," + Conversions.ToString(colorDialog.Color.B);
			font4.BackColor = colorDialog.Color;
		}
	}

	private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
	{
		font2.Text = Conversions.ToString(NumericUpDown1.Value) + "pt";
	}

	private void Button64_Click(object sender, EventArgs e)
	{
		MessageBox.Show("■ self ~ mirror (셀프타입부터 미러타입까지)\r\n□ 엔터( Enter )를 기준으로 문항을 구분합니다.\r\n\r\n■ symbol (표상체계)\r\n□ 엔터( Enter )를 기준으로 문항을 구분합니다.\r\n□ 바( | )문자를 기준으로 지문이 나눠집니다. (예: 질문내용|시각지문|청각지문|촉각지문)\r\n\r\n■ others (외/내향 특성 외 7가지)\r\n□ 엔터( Enter )를 기준으로 문항을 구분합니다.\r\n□ 홑화살괄호( > )문자가 아래 질문들의 특성을 구분합니다. 특성은 총 7가지 이므로 7번 사용됩니다.\r\n□ 바( | )문자를 기준으로 지문이 나눠집니다. (예: 질문|외향적지문|내향적지문)\r\n□ 질문을 입력하지 않으면 지문만 출력됩니다. (예:>외향적지문|내향적지문)", "작성 요령", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void Button74_Click(object sender, EventArgs e)
	{
		font1.Text = "맑은 고딕";
		NumericUpDown1.Value = new decimal(10L);
		font3.Text = "6,106,156";
		font3.BackColor = Color.FromArgb(6, 106, 156);
		font4.Text = "0,128,0";
		font4.BackColor = Color.FromArgb(0, 128, 0);
		string str = font1.Text + "|" + Conversions.ToString(NumericUpDown1.Value) + "|" + font3.Text + "|" + font4.Text;
		string text = null;
		text = Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=update&rname=fontoption&data=" + HttpUtility.UrlEncode(str)));
		if ((Operators.CompareString(text, "incorrect", TextCompare: false) == 0) | (Operators.CompareString(text, null, TextCompare: false) == 0))
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			MessageBox.Show("성공적으로 저장 하였습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	private void Button73_Click(object sender, EventArgs e)
	{
		string str = font1.Text + "|" + Conversions.ToString(NumericUpDown1.Value) + "|" + font3.Text + "|" + font4.Text;
		string text = null;
		text = Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=update&rname=fontoption&data=" + HttpUtility.UrlEncode(str)));
		if ((Operators.CompareString(text, "incorrect", TextCompare: false) == 0) | (Operators.CompareString(text, null, TextCompare: false) == 0))
		{
			MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			MessageBox.Show("성공적으로 저장 하였습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}

	public void DrawItemEvent(object sender, DrawItemEventArgs e)
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

	private void windows_db_human_chart_Load(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = null;
		checked
		{
			int num = ListView3.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (ListView3.Items[i].Checked)
				{
					text = text + "," + ListView3.Items[i].SubItems[0].Text;
				}
			}
			if (Operators.CompareString(text, null, TextCompare: false) == 0 || MessageBox.Show("선택된 항목에 해당하는 검사의 IP기록을 제거하어 재검사를 허용 하시겠습니까?\r\n\r\n삭제된 IP정보는 복구할 수 없습니다.", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
			{
				return;
			}
			int num2 = ListView3.Items.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				if (ListView3.Items[j].Checked && Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/admin.php?pw=" + MySettingsProperty.Settings.pw + "&type=AllowIP&num=" + ListView3.Items[j].SubItems[0].Text)), "incorrect", TextCompare: false) == 0)
				{
					MessageBox.Show("데이터 처리중에 오류가 생겼습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			MessageBox.Show("해당 컴퓨터가 재검사 허용되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			SurveyList();
		}
	}
}
