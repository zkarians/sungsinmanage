using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using mlas_root.CRT;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class fileManager : Form
{
	public class folder
	{
		public string name;

		public List<string> items;

		public folder(object name)
		{
			this.name = Conversions.ToString(name);
			items = new List<string>();
		}

		public folder(string name, string item)
		{
			this.name = name;
			items = new List<string>();
			items.Add(item);
		}

		public folder(string name, List<string> items)
		{
			this.name = name;
			this.items = items;
		}
	}

	private IContainer components;

	public object target;

	public Panel parentObject;

	public string search;

	public bool searchFinish;

	private Thread thr;

	private string nm;

	private List<ImageClass> imageClass;

	private List<folder> folderClass;

	private List<string> etc;

	private bool imgLoading;

	private string nowGroup;

	private Panel pn;

	private int lvSelectedLocation;

	private ColumnHeader m_SortingColumn;

	private List<sjka_cyber_imagefolderlist> list;

	public List<sjka_cyber_imagefolder> folderList;

	private string url;

	private sjka_cyber_imagefolder nowFolder;

	private sjka_cyber_imagefolder.sjka_cyber_imageobject nowSelecedFile;

	private List<sjka_cyber_imagefolder.sjka_cyber_imageobject> moveItems;

	private List<sjka_cyber_imagefolder> moveFolder;

	private bool searchInit;

	private Form searchForm;

	private Panel searchPanel;

	private TextBox searchTextBox;

	private Label searchLabel;

	private bool imgViewInit;

	private Form imgViewForm;

	private PictureBox imgViewPictureBox;

	[field: AccessedThroughProperty("p_fileManager")]
	internal virtual Panel p_fileManager
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

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
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

	[field: AccessedThroughProperty("prop1")]
	internal virtual TextBox prop1
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("prop3")]
	internal virtual TextBox prop3
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
			EventHandler value2 = Button7_Click;
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

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual RadioButton RadioButton3
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RadioButton3_CheckedChanged;
			RadioButton radioButton = _RadioButton3;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			_RadioButton3 = value;
			radioButton = _RadioButton3;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RadioButton2_CheckedChanged;
			RadioButton radioButton = _RadioButton2;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			_RadioButton2 = value;
			radioButton = _RadioButton2;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RadioButton1_CheckedChanged;
			RadioButton radioButton = _RadioButton1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			_RadioButton1 = value;
			radioButton = _RadioButton1;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PicturePanel1")]
	internal virtual Panel PicturePanel1
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

	internal virtual Button Button113
	{
		[CompilerGenerated]
		get
		{
			return _Button113;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button113_Click;
			Button button = _Button113;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button113 = value;
			button = _Button113;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel12")]
	internal virtual Panel Panel12
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	internal virtual ComboBoxEx ComboBox1
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
			EventHandler value2 = ComboBox1_SelectedIndexChanged;
			ComboBoxEx comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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
			EventHandler value2 = Button6_Click;
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

	[field: AccessedThroughProperty("newgroup")]
	internal virtual Panel newgroup
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Label39")]
	internal virtual Label Label39
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox12
	{
		[CompilerGenerated]
		get
		{
			return _TextBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox12_TextChanged;
			TextBox textBox = _TextBox12;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox12 = value;
			textBox = _TextBox12;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("prop2")]
	internal virtual TextBox prop2
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

	[field: AccessedThroughProperty("Panel14")]
	internal virtual Panel Panel14
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
			EventHandler value2 = Button16_Click_1;
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

	[field: AccessedThroughProperty("Panel19")]
	internal virtual Panel Panel19
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

	[field: AccessedThroughProperty("Button18")]
	internal virtual Button Button18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button19")]
	internal virtual Button Button19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button20")]
	internal virtual Button Button20
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
			ItemCheckedEventHandler value2 = ListView1_ItemChecked;
			EventHandler value3 = ListView1_SelectedIndexChanged;
			MouseEventHandler value4 = ListView1_MouseDoubleClick;
			KeyEventHandler value5 = ListView1_KeyDown;
			ColumnClickEventHandler value6 = ListView1_ColumnClick;
			ListView listView = _ListView1;
			if (listView != null)
			{
				listView.ItemChecked -= value2;
				listView.SelectedIndexChanged -= value3;
				listView.MouseDoubleClick -= value4;
				listView.KeyDown -= value5;
				listView.ColumnClick -= value6;
			}
			_ListView1 = value;
			listView = _ListView1;
			if (listView != null)
			{
				listView.ItemChecked += value2;
				listView.SelectedIndexChanged += value3;
				listView.MouseDoubleClick += value4;
				listView.KeyDown += value5;
				listView.ColumnClick += value6;
			}
		}
	}

	[field: AccessedThroughProperty("ColumnHeader1")]
	internal virtual ColumnHeader ColumnHeader1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("groups")]
	internal virtual ColumnHeader groups
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

	[field: AccessedThroughProperty("ColumnHeader4")]
	internal virtual ColumnHeader ColumnHeader4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel15")]
	internal virtual Panel Panel15
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

	[field: AccessedThroughProperty("Panel16")]
	internal virtual Panel Panel16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBoxEx ComboBoxEx1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBoxEx1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBoxEx1_SelectedIndexChanged;
			ComboBoxEx comboBoxEx = _ComboBoxEx1;
			if (comboBoxEx != null)
			{
				comboBoxEx.SelectedIndexChanged -= value2;
			}
			_ComboBoxEx1 = value;
			comboBoxEx = _ComboBoxEx1;
			if (comboBoxEx != null)
			{
				comboBoxEx.SelectedIndexChanged += value2;
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

	[field: AccessedThroughProperty("ImageList1")]
	internal virtual ImageList ImageList1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolTip1")]
	internal virtual ToolTip ToolTip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("filemanager_v2")]
	internal virtual Panel filemanager_v2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SplitContainer3")]
	internal virtual SplitContainer SplitContainer3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel17")]
	internal virtual Panel Panel17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListView listView
	{
		[CompilerGenerated]
		get
		{
			return _listView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ItemDragEventHandler value2 = listView_ItemDrag;
			MouseEventHandler value3 = listView_MouseDoubleClick;
			LabelEditEventHandler value4 = listView_AfterLabelEdit;
			KeyEventHandler value5 = listView_KeyDown;
			KeyEventHandler value6 = listView_KeyUp;
			DragEventHandler value7 = listView_DragEnter;
			MouseEventHandler value8 = listView_MouseClick;
			MouseEventHandler value9 = listView_MouseUp;
			DragEventHandler value10 = listView_DragDrop;
			ListView listView = _listView;
			if (listView != null)
			{
				listView.ItemDrag -= value2;
				listView.MouseDoubleClick -= value3;
				listView.AfterLabelEdit -= value4;
				listView.KeyDown -= value5;
				listView.KeyUp -= value6;
				listView.DragEnter -= value7;
				listView.MouseClick -= value8;
				listView.MouseUp -= value9;
				listView.DragDrop -= value10;
			}
			_listView = value;
			listView = _listView;
			if (listView != null)
			{
				listView.ItemDrag += value2;
				listView.MouseDoubleClick += value3;
				listView.AfterLabelEdit += value4;
				listView.KeyDown += value5;
				listView.KeyUp += value6;
				listView.DragEnter += value7;
				listView.MouseClick += value8;
				listView.MouseUp += value9;
				listView.DragDrop += value10;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel1")]
	internal virtual DoubleBufferPanel DoubleBufferPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox nowUrl
	{
		[CompilerGenerated]
		get
		{
			return _nowUrl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = nowUrl_KeyDown;
			TextBox textBox = _nowUrl;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_nowUrl = value;
			textBox = _nowUrl;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("folderTitle")]
	internal virtual Label folderTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox1
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PictureBox1_Click;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel18")]
	internal virtual Panel Panel18
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

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("detailSplitContainer")]
	internal virtual SplitContainer detailSplitContainer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox preview
	{
		[CompilerGenerated]
		get
		{
			return _preview;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = preview_Click;
			PictureBox pictureBox = _preview;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_preview = value;
			pictureBox = _preview;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	internal virtual Button imageSave
	{
		[CompilerGenerated]
		get
		{
			return _imageSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = imageSave_Click;
			Button button = _imageSave;
			if (button != null)
			{
				button.Click -= value2;
			}
			_imageSave = value;
			button = _imageSave;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel21")]
	internal virtual Panel Panel21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button changeImage
	{
		[CompilerGenerated]
		get
		{
			return _changeImage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = changeImage_Click;
			Button button = _changeImage;
			if (button != null)
			{
				button.Click -= value2;
			}
			_changeImage = value;
			button = _changeImage;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("descript")]
	internal virtual Label descript
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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

	[field: AccessedThroughProperty("PictureBox3")]
	internal virtual PictureBox PictureBox3
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

	[field: AccessedThroughProperty("Panel22")]
	internal virtual Panel Panel22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox2
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PictureBox2_Click;
			PictureBox pictureBox = _PictureBox2;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox2 = value;
			pictureBox = _PictureBox2;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	internal virtual PictureBox PictureBox4
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PictureBox4_Click;
			PictureBox pictureBox = _PictureBox4;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox4 = value;
			pictureBox = _PictureBox4;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ContextMenuStrip1")]
	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 이동ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _이동ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 이동ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _이동ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_이동ToolStripMenuItem = value;
			toolStripMenuItem = _이동ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 붙여넣기ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _붙여넣기ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 붙여넣기ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _붙여넣기ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_붙여넣기ToolStripMenuItem = value;
			toolStripMenuItem = _붙여넣기ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 삭제ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _삭제ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 삭제ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _삭제ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_삭제ToolStripMenuItem = value;
			toolStripMenuItem = _삭제ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 새폴더ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _새폴더ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 새폴더ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _새폴더ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_새폴더ToolStripMenuItem = value;
			toolStripMenuItem = _새폴더ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator2")]
	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 이름변경ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _이름변경ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 이름변경ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _이름변경ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_이름변경ToolStripMenuItem = value;
			toolStripMenuItem = _이름변경ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 전체선택ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _전체선택ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 전체선택ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _전체선택ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_전체선택ToolStripMenuItem = value;
			toolStripMenuItem = _전체선택ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
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

	[field: AccessedThroughProperty("PictureBox5")]
	internal virtual PictureBox PictureBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 파일업로드ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _파일업로드ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 파일업로드ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _파일업로드ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_파일업로드ToolStripMenuItem = value;
			toolStripMenuItem = _파일업로드ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual TreeView TreeView1
	{
		[CompilerGenerated]
		get
		{
			return _TreeView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			TreeViewEventHandler value2 = TreeView1_AfterSelect;
			TreeView treeView = _TreeView1;
			if (treeView != null)
			{
				treeView.AfterSelect -= value2;
			}
			_TreeView1 = value;
			treeView = _TreeView1;
			if (treeView != null)
			{
				treeView.AfterSelect += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SplitContainer2")]
	internal virtual SplitContainer SplitContainer2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel23")]
	internal virtual Panel Panel23
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

	public fileManager()
	{
		base.Load += fileManager_Load;
		search = null;
		searchFinish = false;
		nm = null;
		imgLoading = false;
		nowGroup = null;
		folderList = new List<sjka_cyber_imagefolder>();
		url = "";
		moveItems = new List<sjka_cyber_imagefolder.sjka_cyber_imageobject>();
		moveFolder = new List<sjka_cyber_imagefolder>();
		searchInit = false;
		imgViewInit = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.fileManager));
		this.p_fileManager = new System.Windows.Forms.Panel();
		this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
		this.Panel13 = new System.Windows.Forms.Panel();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.groups = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.Panel14 = new System.Windows.Forms.Panel();
		this.Panel15 = new System.Windows.Forms.Panel();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button15 = new System.Windows.Forms.Button();
		this.Button14 = new System.Windows.Forms.Button();
		this.ComboBox2 = new mlas_root.ComboBoxEx();
		this.Button12 = new System.Windows.Forms.Button();
		this.Button11 = new System.Windows.Forms.Button();
		this.Button13 = new System.Windows.Forms.Button();
		this.Label4 = new System.Windows.Forms.Label();
		this.Panel12 = new System.Windows.Forms.Panel();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button9 = new System.Windows.Forms.Button();
		this.Button113 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.Panel16 = new System.Windows.Forms.Panel();
		this.ComboBoxEx1 = new mlas_root.ComboBoxEx();
		this.Button17 = new System.Windows.Forms.Button();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.PicturePanel1 = new System.Windows.Forms.Panel();
		this.Panel10 = new System.Windows.Forms.Panel();
		this.Panel11 = new System.Windows.Forms.Panel();
		this.Button1 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.Label1 = new System.Windows.Forms.Label();
		this.RadioButton3 = new System.Windows.Forms.RadioButton();
		this.RadioButton2 = new System.Windows.Forms.RadioButton();
		this.RadioButton1 = new System.Windows.Forms.RadioButton();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Label2 = new System.Windows.Forms.Label();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Label3 = new System.Windows.Forms.Label();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.prop2 = new System.Windows.Forms.TextBox();
		this.newgroup = new System.Windows.Forms.Panel();
		this.Button34 = new System.Windows.Forms.Button();
		this.Button35 = new System.Windows.Forms.Button();
		this.Label39 = new System.Windows.Forms.Label();
		this.TextBox12 = new System.Windows.Forms.TextBox();
		this.Button8 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.ComboBox1 = new mlas_root.ComboBoxEx();
		this.Label9 = new System.Windows.Forms.Label();
		this.Button6 = new System.Windows.Forms.Button();
		this.Label7 = new System.Windows.Forms.Label();
		this.prop3 = new System.Windows.Forms.TextBox();
		this.Label8 = new System.Windows.Forms.Label();
		this.prop1 = new System.Windows.Forms.TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.Panel8 = new System.Windows.Forms.Panel();
		this.Label10 = new System.Windows.Forms.Label();
		this.Button16 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button10 = new System.Windows.Forms.Button();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.filemanager_v2 = new System.Windows.Forms.Panel();
		this.Panel17 = new System.Windows.Forms.Panel();
		this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
		this.TreeView1 = new System.Windows.Forms.TreeView();
		this.SplitContainer3 = new System.Windows.Forms.SplitContainer();
		this.listView = new System.Windows.Forms.ListView();
		this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.새폴더ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.파일업로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.전체선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.이름변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.detailSplitContainer = new System.Windows.Forms.SplitContainer();
		this.preview = new System.Windows.Forms.PictureBox();
		this.Panel24 = new System.Windows.Forms.Panel();
		this.imageSave = new System.Windows.Forms.Button();
		this.Panel21 = new System.Windows.Forms.Panel();
		this.changeImage = new System.Windows.Forms.Button();
		this.Panel23 = new System.Windows.Forms.Panel();
		this.descript = new System.Windows.Forms.Label();
		this.DoubleBufferPanel1 = new mlas_root.DoubleBufferPanel();
		this.nowUrl = new System.Windows.Forms.TextBox();
		this.folderTitle = new System.Windows.Forms.Label();
		this.Panel18 = new System.Windows.Forms.Panel();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Panel22 = new System.Windows.Forms.Panel();
		this.PictureBox4 = new System.Windows.Forms.PictureBox();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.Panel20 = new System.Windows.Forms.Panel();
		this.Label11 = new System.Windows.Forms.Label();
		this.Button24 = new System.Windows.Forms.Button();
		this.PictureBox5 = new System.Windows.Forms.PictureBox();
		this.Button22 = new System.Windows.Forms.Button();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.Button21 = new System.Windows.Forms.Button();
		this.Button23 = new System.Windows.Forms.Button();
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.Panel19 = new System.Windows.Forms.Panel();
		this.Label5 = new System.Windows.Forms.Label();
		this.Button18 = new System.Windows.Forms.Button();
		this.Button19 = new System.Windows.Forms.Button();
		this.Button20 = new System.Windows.Forms.Button();
		this.p_fileManager.SuspendLayout();
		this.SplitContainer1.Panel1.SuspendLayout();
		this.SplitContainer1.Panel2.SuspendLayout();
		this.SplitContainer1.SuspendLayout();
		this.Panel13.SuspendLayout();
		this.Panel14.SuspendLayout();
		this.Panel15.SuspendLayout();
		this.Panel12.SuspendLayout();
		this.Panel16.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.PicturePanel1.SuspendLayout();
		this.Panel10.SuspendLayout();
		this.Panel11.SuspendLayout();
		this.Panel9.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.newgroup.SuspendLayout();
		this.Panel8.SuspendLayout();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.filemanager_v2.SuspendLayout();
		this.Panel17.SuspendLayout();
		this.SplitContainer2.Panel1.SuspendLayout();
		this.SplitContainer2.Panel2.SuspendLayout();
		this.SplitContainer2.SuspendLayout();
		this.SplitContainer3.Panel1.SuspendLayout();
		this.SplitContainer3.Panel2.SuspendLayout();
		this.SplitContainer3.SuspendLayout();
		this.ContextMenuStrip1.SuspendLayout();
		this.detailSplitContainer.Panel1.SuspendLayout();
		this.detailSplitContainer.Panel2.SuspendLayout();
		this.detailSplitContainer.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.preview).BeginInit();
		this.Panel24.SuspendLayout();
		this.Panel23.SuspendLayout();
		this.DoubleBufferPanel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel22.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		this.Panel20.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		this.Panel19.SuspendLayout();
		base.SuspendLayout();
		this.p_fileManager.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.p_fileManager.Controls.Add(this.SplitContainer1);
		this.p_fileManager.Controls.Add(this.Panel2);
		this.p_fileManager.Controls.Add(this.Panel4);
		this.p_fileManager.Controls.Add(this.Panel5);
		this.p_fileManager.Controls.Add(this.Panel6);
		this.p_fileManager.Controls.Add(this.Panel7);
		this.p_fileManager.Controls.Add(this.Panel8);
		this.p_fileManager.Dock = System.Windows.Forms.DockStyle.Fill;
		this.p_fileManager.Location = new System.Drawing.Point(3, 3);
		this.p_fileManager.Name = "p_fileManager";
		this.p_fileManager.Size = new System.Drawing.Size(840, 625);
		this.p_fileManager.TabIndex = 14;
		this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer1.Location = new System.Drawing.Point(23, 56);
		this.SplitContainer1.Name = "SplitContainer1";
		this.SplitContainer1.Panel1.Controls.Add(this.Panel13);
		this.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.SplitContainer1.Panel2.Controls.Add(this.Panel1);
		this.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.SplitContainer1.Size = new System.Drawing.Size(794, 355);
		this.SplitContainer1.SplitterDistance = 346;
		this.SplitContainer1.SplitterWidth = 5;
		this.SplitContainer1.TabIndex = 4;
		this.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel13.Controls.Add(this.ListView1);
		this.Panel13.Controls.Add(this.Panel14);
		this.Panel13.Controls.Add(this.Label4);
		this.Panel13.Controls.Add(this.Panel12);
		this.Panel13.Controls.Add(this.Panel16);
		this.Panel13.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel13.Location = new System.Drawing.Point(0, 0);
		this.Panel13.Name = "Panel13";
		this.Panel13.Size = new System.Drawing.Size(346, 355);
		this.Panel13.TabIndex = 69;
		this.ListView1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListView1.CheckBoxes = true;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.ColumnHeader1, this.groups, this.ColumnHeader2, this.ColumnHeader4 });
		this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListView1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListView1.FullRowSelect = true;
		this.ListView1.HideSelection = false;
		this.ListView1.Location = new System.Drawing.Point(0, 52);
		this.ListView1.MultiSelect = false;
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(344, 273);
		this.ListView1.TabIndex = 49;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "id";
		this.ColumnHeader1.Width = 70;
		this.groups.Text = "group";
		this.ColumnHeader2.Text = "name";
		this.ColumnHeader2.Width = 200;
		this.ColumnHeader4.Text = "comment";
		this.ColumnHeader4.Width = 400;
		this.Panel14.Controls.Add(this.Panel15);
		this.Panel14.Controls.Add(this.ComboBox2);
		this.Panel14.Controls.Add(this.Button12);
		this.Panel14.Controls.Add(this.Button11);
		this.Panel14.Controls.Add(this.Button13);
		this.Panel14.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel14.Location = new System.Drawing.Point(0, 26);
		this.Panel14.Name = "Panel14";
		this.Panel14.Size = new System.Drawing.Size(344, 26);
		this.Panel14.TabIndex = 72;
		this.Panel15.BackColor = System.Drawing.Color.DarkGoldenrod;
		this.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel15.Controls.Add(this.TextBox1);
		this.Panel15.Controls.Add(this.Button15);
		this.Panel15.Controls.Add(this.Button14);
		this.Panel15.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel15.Location = new System.Drawing.Point(0, 0);
		this.Panel15.Name = "Panel15";
		this.Panel15.Padding = new System.Windows.Forms.Padding(2);
		this.Panel15.Size = new System.Drawing.Size(172, 26);
		this.Panel15.TabIndex = 75;
		this.Panel15.Visible = false;
		this.TextBox1.BackColor = System.Drawing.Color.White;
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox1.Font = new System.Drawing.Font("맑은 고딕", 11f);
		this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox1.Location = new System.Drawing.Point(2, 2);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(92, 20);
		this.TextBox1.TabIndex = 16;
		this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Button15.BackColor = System.Drawing.Color.DarkGreen;
		this.Button15.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button15.BackgroundImage");
		this.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button15.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button15.Font = new System.Drawing.Font("굴림", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button15.ForeColor = System.Drawing.Color.White;
		this.Button15.Location = new System.Drawing.Point(94, 2);
		this.Button15.Name = "Button15";
		this.Button15.Size = new System.Drawing.Size(37, 20);
		this.Button15.TabIndex = 2;
		this.Button15.Text = "확인";
		this.Button15.UseVisualStyleBackColor = false;
		this.Button14.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button14.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button14.BackgroundImage");
		this.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button14.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button14.Font = new System.Drawing.Font("굴림", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button14.ForeColor = System.Drawing.Color.White;
		this.Button14.Location = new System.Drawing.Point(131, 2);
		this.Button14.Name = "Button14";
		this.Button14.Size = new System.Drawing.Size(37, 20);
		this.Button14.TabIndex = 4;
		this.Button14.Text = "취소";
		this.Button14.UseVisualStyleBackColor = false;
		this.ComboBox2.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBox2.DropDownHeight = 600;
		this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox2.FormattingEnabled = true;
		this.ComboBox2.IntegralHeight = false;
		this.ComboBox2.Location = new System.Drawing.Point(0, 0);
		this.ComboBox2.Name = "ComboBox2";
		this.ComboBox2.Size = new System.Drawing.Size(172, 26);
		this.ComboBox2.TabIndex = 70;
		this.Button12.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button12.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button12.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button12.ForeColor = System.Drawing.Color.White;
		this.Button12.Location = new System.Drawing.Point(172, 0);
		this.Button12.Name = "Button12";
		this.Button12.Size = new System.Drawing.Size(65, 26);
		this.Button12.TabIndex = 73;
		this.Button12.Text = "이름변경";
		this.Button12.UseVisualStyleBackColor = false;
		this.Button11.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.Button11.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button11.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button11.ForeColor = System.Drawing.Color.White;
		this.Button11.Location = new System.Drawing.Point(237, 0);
		this.Button11.Name = "Button11";
		this.Button11.Size = new System.Drawing.Size(63, 26);
		this.Button11.TabIndex = 72;
		this.Button11.Text = "그룹삭제";
		this.Button11.UseVisualStyleBackColor = false;
		this.Button13.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
		this.Button13.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button13.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button13.ForeColor = System.Drawing.Color.White;
		this.Button13.Location = new System.Drawing.Point(300, 0);
		this.Button13.Name = "Button13";
		this.Button13.Size = new System.Drawing.Size(44, 26);
		this.Button13.TabIndex = 74;
		this.Button13.Text = "찾기";
		this.Button13.UseVisualStyleBackColor = false;
		this.Label4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Label4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Label4.Location = new System.Drawing.Point(0, 325);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(344, 1);
		this.Label4.TabIndex = 69;
		this.Panel12.Controls.Add(this.Button3);
		this.Panel12.Controls.Add(this.Button9);
		this.Panel12.Controls.Add(this.Button113);
		this.Panel12.Controls.Add(this.Button7);
		this.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel12.Location = new System.Drawing.Point(0, 326);
		this.Panel12.Name = "Panel12";
		this.Panel12.Size = new System.Drawing.Size(344, 27);
		this.Panel12.TabIndex = 68;
		this.Button3.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.Button3.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button3.ForeColor = System.Drawing.Color.White;
		this.Button3.Location = new System.Drawing.Point(92, 0);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(68, 27);
		this.Button3.TabIndex = 28;
		this.Button3.Text = "선택 삭제";
		this.Button3.UseVisualStyleBackColor = false;
		this.Button9.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
		this.Button9.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button9.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button9.ForeColor = System.Drawing.Color.White;
		this.Button9.Location = new System.Drawing.Point(208, 0);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(68, 27);
		this.Button9.TabIndex = 68;
		this.Button9.Text = "찾기";
		this.Button9.UseVisualStyleBackColor = false;
		this.Button113.BackColor = System.Drawing.Color.Purple;
		this.Button113.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button113.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button113.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button113.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button113.ForeColor = System.Drawing.Color.White;
		this.Button113.Location = new System.Drawing.Point(276, 0);
		this.Button113.Name = "Button113";
		this.Button113.Size = new System.Drawing.Size(68, 27);
		this.Button113.TabIndex = 67;
		this.Button113.Text = "통합찾기";
		this.Button113.UseVisualStyleBackColor = false;
		this.Button7.BackColor = System.Drawing.Color.DarkGreen;
		this.Button7.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button7.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button7.ForeColor = System.Drawing.Color.White;
		this.Button7.Location = new System.Drawing.Point(0, 0);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(92, 27);
		this.Button7.TabIndex = 29;
		this.Button7.Text = "이미지 업로드";
		this.Button7.UseVisualStyleBackColor = false;
		this.Panel16.Controls.Add(this.ComboBoxEx1);
		this.Panel16.Controls.Add(this.Button17);
		this.Panel16.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel16.Location = new System.Drawing.Point(0, 0);
		this.Panel16.Name = "Panel16";
		this.Panel16.Size = new System.Drawing.Size(344, 26);
		this.Panel16.TabIndex = 73;
		this.ComboBoxEx1.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBoxEx1.DropDownHeight = 600;
		this.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBoxEx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBoxEx1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBoxEx1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBoxEx1.FormattingEnabled = true;
		this.ComboBoxEx1.IntegralHeight = false;
		this.ComboBoxEx1.Location = new System.Drawing.Point(0, 0);
		this.ComboBoxEx1.Name = "ComboBoxEx1";
		this.ComboBoxEx1.Size = new System.Drawing.Size(317, 26);
		this.ComboBoxEx1.TabIndex = 70;
		this.Button17.BackColor = System.Drawing.Color.DarkTurquoise;
		this.Button17.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button17.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button17.ForeColor = System.Drawing.Color.White;
		this.Button17.Location = new System.Drawing.Point(317, 0);
		this.Button17.Name = "Button17";
		this.Button17.Size = new System.Drawing.Size(27, 26);
		this.Button17.TabIndex = 75;
		this.Button17.Text = "?";
		this.Button17.UseVisualStyleBackColor = false;
		this.Panel1.Controls.Add(this.PicturePanel1);
		this.Panel1.Controls.Add(this.Panel9);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(443, 355);
		this.Panel1.TabIndex = 52;
		this.PicturePanel1.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.PicturePanel1.Controls.Add(this.Panel10);
		this.PicturePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PicturePanel1.Location = new System.Drawing.Point(0, 26);
		this.PicturePanel1.Name = "PicturePanel1";
		this.PicturePanel1.Size = new System.Drawing.Size(443, 329);
		this.PicturePanel1.TabIndex = 53;
		this.Panel10.BackColor = System.Drawing.Color.Transparent;
		this.Panel10.Controls.Add(this.Panel11);
		this.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel10.Location = new System.Drawing.Point(0, 227);
		this.Panel10.Name = "Panel10";
		this.Panel10.Size = new System.Drawing.Size(443, 102);
		this.Panel10.TabIndex = 1;
		this.Panel10.Visible = false;
		this.Panel11.Controls.Add(this.Button1);
		this.Panel11.Controls.Add(this.Button4);
		this.Panel11.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel11.Location = new System.Drawing.Point(347, 0);
		this.Panel11.Name = "Panel11";
		this.Panel11.Size = new System.Drawing.Size(96, 102);
		this.Panel11.TabIndex = 2;
		this.Button1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.YellowGreen;
		this.Button1.Location = new System.Drawing.Point(6, 19);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(84, 29);
		this.Button1.TabIndex = 63;
		this.Button1.Text = "파일 변경";
		this.Button1.UseVisualStyleBackColor = false;
		this.Button4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button4.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.Button4.Location = new System.Drawing.Point(6, 56);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(84, 28);
		this.Button4.TabIndex = 51;
		this.Button4.Text = "파일 저장";
		this.Button4.UseVisualStyleBackColor = false;
		this.Panel9.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Panel9.Controls.Add(this.Label1);
		this.Panel9.Controls.Add(this.RadioButton3);
		this.Panel9.Controls.Add(this.RadioButton2);
		this.Panel9.Controls.Add(this.RadioButton1);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel9.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.Panel9.Location = new System.Drawing.Point(0, 0);
		this.Panel9.Name = "Panel9";
		this.Panel9.Size = new System.Drawing.Size(443, 26);
		this.Panel9.TabIndex = 52;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label1.Location = new System.Drawing.Point(48, 7);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(62, 12);
		this.Label1.TabIndex = 3;
		this.Label1.Text = "보기 모드";
		this.RadioButton3.AutoSize = true;
		this.RadioButton3.Checked = true;
		this.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.RadioButton3.Location = new System.Drawing.Point(265, 5);
		this.RadioButton3.Name = "RadioButton3";
		this.RadioButton3.Size = new System.Drawing.Size(34, 16);
		this.RadioButton3.TabIndex = 2;
		this.RadioButton3.TabStop = true;
		this.RadioButton3.Text = "줌";
		this.RadioButton3.UseVisualStyleBackColor = true;
		this.RadioButton2.AutoSize = true;
		this.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.RadioButton2.Location = new System.Drawing.Point(198, 5);
		this.RadioButton2.Name = "RadioButton2";
		this.RadioButton2.Size = new System.Drawing.Size(58, 16);
		this.RadioButton2.TabIndex = 1;
		this.RadioButton2.Text = "채우기";
		this.RadioButton2.UseVisualStyleBackColor = true;
		this.RadioButton1.AutoSize = true;
		this.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.RadioButton1.Location = new System.Drawing.Point(115, 5);
		this.RadioButton1.Name = "RadioButton1";
		this.RadioButton1.Size = new System.Drawing.Size(74, 16);
		this.RadioButton1.TabIndex = 0;
		this.RadioButton1.Text = "원본 크기";
		this.RadioButton1.UseVisualStyleBackColor = true;
		this.Panel2.Controls.Add(this.Label2);
		this.Panel2.Controls.Add(this.Panel3);
		this.Panel2.Controls.Add(this.Label3);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(23, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(794, 56);
		this.Panel2.TabIndex = 45;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label2.Location = new System.Drawing.Point(0, 15);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(131, 30);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "이미지 찾기";
		this.Panel3.BackColor = System.Drawing.Color.Gray;
		this.Panel3.Location = new System.Drawing.Point(133, 41);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(2000, 1);
		this.Panel3.TabIndex = 3;
		this.Label3.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label3.Location = new System.Drawing.Point(131, 15);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(901, 30);
		this.Label3.TabIndex = 2;
		this.Label3.Text = "사용할 이미지를 선택하거나 업로드 하십시오.";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel4.Controls.Add(this.prop2);
		this.Panel4.Controls.Add(this.newgroup);
		this.Panel4.Controls.Add(this.Button8);
		this.Panel4.Controls.Add(this.Button5);
		this.Panel4.Controls.Add(this.ComboBox1);
		this.Panel4.Controls.Add(this.Label9);
		this.Panel4.Controls.Add(this.Button6);
		this.Panel4.Controls.Add(this.Label7);
		this.Panel4.Controls.Add(this.prop3);
		this.Panel4.Controls.Add(this.Label8);
		this.Panel4.Controls.Add(this.prop1);
		this.Panel4.Controls.Add(this.Label6);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel4.Location = new System.Drawing.Point(23, 411);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(794, 147);
		this.Panel4.TabIndex = 54;
		this.Panel4.Visible = false;
		this.prop2.Location = new System.Drawing.Point(671, 6);
		this.prop2.Name = "prop2";
		this.prop2.Size = new System.Drawing.Size(100, 21);
		this.prop2.TabIndex = 75;
		this.prop2.Visible = false;
		this.newgroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.newgroup.Controls.Add(this.Button34);
		this.newgroup.Controls.Add(this.Button35);
		this.newgroup.Controls.Add(this.Label39);
		this.newgroup.Controls.Add(this.TextBox12);
		this.newgroup.Location = new System.Drawing.Point(223, 39);
		this.newgroup.Name = "newgroup";
		this.newgroup.Size = new System.Drawing.Size(344, 73);
		this.newgroup.TabIndex = 74;
		this.newgroup.Visible = false;
		this.Button34.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button34.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button34.BackgroundImage");
		this.Button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button34.ForeColor = System.Drawing.Color.White;
		this.Button34.Location = new System.Drawing.Point(174, 40);
		this.Button34.Name = "Button34";
		this.Button34.Size = new System.Drawing.Size(86, 24);
		this.Button34.TabIndex = 4;
		this.Button34.Text = "취소";
		this.Button34.UseVisualStyleBackColor = false;
		this.Button35.BackColor = System.Drawing.Color.DarkGreen;
		this.Button35.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button35.BackgroundImage");
		this.Button35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button35.ForeColor = System.Drawing.Color.White;
		this.Button35.Location = new System.Drawing.Point(82, 40);
		this.Button35.Name = "Button35";
		this.Button35.Size = new System.Drawing.Size(86, 24);
		this.Button35.TabIndex = 2;
		this.Button35.Text = "확인";
		this.Button35.UseVisualStyleBackColor = false;
		this.Label39.AutoSize = true;
		this.Label39.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label39.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label39.Location = new System.Drawing.Point(25, 10);
		this.Label39.Name = "Label39";
		this.Label39.Size = new System.Drawing.Size(74, 20);
		this.Label39.TabIndex = 0;
		this.Label39.Text = "새 그룹명";
		this.TextBox12.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox12.Font = new System.Drawing.Font("맑은 고딕", 11f);
		this.TextBox12.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox12.Location = new System.Drawing.Point(105, 7);
		this.TextBox12.Name = "TextBox12";
		this.TextBox12.Size = new System.Drawing.Size(213, 27);
		this.TextBox12.TabIndex = 16;
		this.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Button8.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button8.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button8.ForeColor = System.Drawing.Color.White;
		this.Button8.Location = new System.Drawing.Point(561, 106);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(75, 27);
		this.Button8.TabIndex = 73;
		this.Button8.Text = "수정";
		this.Button8.UseVisualStyleBackColor = false;
		this.Button5.BackColor = System.Drawing.Color.DarkGreen;
		this.Button5.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button5.ForeColor = System.Drawing.Color.White;
		this.Button5.Location = new System.Drawing.Point(639, 72);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(123, 28);
		this.Button5.TabIndex = 72;
		this.Button5.Text = "새 그룹 만들고 보냄";
		this.Button5.UseVisualStyleBackColor = false;
		this.ComboBox1.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ComboBox1.DropDownHeight = 600;
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.IntegralHeight = false;
		this.ComboBox1.Location = new System.Drawing.Point(83, 73);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(468, 28);
		this.ComboBox1.TabIndex = 71;
		this.Label9.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label9.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
		this.Label9.Location = new System.Drawing.Point(17, 72);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(58, 29);
		this.Label9.TabIndex = 67;
		this.Label9.Text = "그룹";
		this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button6.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button6.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button6.ForeColor = System.Drawing.Color.White;
		this.Button6.Location = new System.Drawing.Point(561, 72);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(75, 28);
		this.Button6.TabIndex = 65;
		this.Button6.Text = "이동";
		this.Button6.UseVisualStyleBackColor = false;
		this.Label7.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label7.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
		this.Label7.Location = new System.Drawing.Point(19, 105);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(56, 29);
		this.Label7.TabIndex = 59;
		this.Label7.Text = "설명";
		this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.prop3.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.prop3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.prop3.Font = new System.Drawing.Font("맑은 고딕", 11f);
		this.prop3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.prop3.Location = new System.Drawing.Point(83, 107);
		this.prop3.Name = "prop3";
		this.prop3.Size = new System.Drawing.Size(468, 27);
		this.prop3.TabIndex = 58;
		this.Label8.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label8.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
		this.Label8.Location = new System.Drawing.Point(23, 39);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(52, 29);
		this.Label8.TabIndex = 56;
		this.Label8.Text = "id";
		this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.prop1.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.prop1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.prop1.Font = new System.Drawing.Font("맑은 고딕", 11f);
		this.prop1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.prop1.Location = new System.Drawing.Point(83, 39);
		this.prop1.Name = "prop1";
		this.prop1.ReadOnly = true;
		this.prop1.Size = new System.Drawing.Size(679, 27);
		this.prop1.TabIndex = 26;
		this.Label6.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label6.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold);
		this.Label6.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label6.Location = new System.Drawing.Point(0, 0);
		this.Label6.Name = "Label6";
		this.Label6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 5);
		this.Label6.Size = new System.Drawing.Size(794, 36);
		this.Label6.TabIndex = 48;
		this.Label6.Text = "이미지 등록정보";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel5.Location = new System.Drawing.Point(23, 558);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(794, 23);
		this.Panel5.TabIndex = 53;
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel6.Location = new System.Drawing.Point(0, 0);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(23, 581);
		this.Panel6.TabIndex = 43;
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel7.Location = new System.Drawing.Point(817, 0);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new System.Drawing.Size(23, 581);
		this.Panel7.TabIndex = 44;
		this.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel8.Controls.Add(this.Label10);
		this.Panel8.Controls.Add(this.Button16);
		this.Panel8.Controls.Add(this.Button2);
		this.Panel8.Controls.Add(this.Button10);
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel8.Location = new System.Drawing.Point(0, 581);
		this.Panel8.Name = "Panel8";
		this.Panel8.Padding = new System.Windows.Forms.Padding(5);
		this.Panel8.Size = new System.Drawing.Size(840, 44);
		this.Panel8.TabIndex = 46;
		this.Label10.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label10.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label10.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
		this.Label10.Location = new System.Drawing.Point(85, 5);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(541, 32);
		this.Label10.TabIndex = 32;
		this.Label10.Text = "사용할 파일을 선택 하십시오.";
		this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Button16.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.Button16.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button16.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button16.ForeColor = System.Drawing.Color.White;
		this.Button16.Location = new System.Drawing.Point(5, 5);
		this.Button16.Name = "Button16";
		this.Button16.Size = new System.Drawing.Size(80, 32);
		this.Button16.TabIndex = 33;
		this.Button16.Text = "새로고침";
		this.Button16.UseVisualStyleBackColor = false;
		this.Button2.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button2.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = System.Drawing.Color.White;
		this.Button2.Location = new System.Drawing.Point(626, 5);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(112, 32);
		this.Button2.TabIndex = 30;
		this.Button2.Text = "선택된 파일 사용";
		this.Button2.UseVisualStyleBackColor = false;
		this.Button10.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button10.BackgroundImage = mlas_root.My.Resources.Resources.public_button_close;
		this.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button10.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button10.ForeColor = System.Drawing.Color.White;
		this.Button10.Location = new System.Drawing.Point(738, 5);
		this.Button10.Name = "Button10";
		this.Button10.Size = new System.Drawing.Size(95, 32);
		this.Button10.TabIndex = 31;
		this.Button10.Text = "닫기";
		this.Button10.UseVisualStyleBackColor = false;
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabControl1.Location = new System.Drawing.Point(0, 0);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(854, 657);
		this.TabControl1.TabIndex = 15;
		this.TabPage1.Controls.Add(this.p_fileManager);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(846, 631);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "TabPage1";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.TabPage2.AllowDrop = true;
		this.TabPage2.Controls.Add(this.filemanager_v2);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new System.Drawing.Size(846, 631);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "TabPage2";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.filemanager_v2.AllowDrop = true;
		this.filemanager_v2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.filemanager_v2.Controls.Add(this.Panel17);
		this.filemanager_v2.Controls.Add(this.DoubleBufferPanel1);
		this.filemanager_v2.Controls.Add(this.Panel20);
		this.filemanager_v2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.filemanager_v2.Location = new System.Drawing.Point(0, 0);
		this.filemanager_v2.Name = "filemanager_v2";
		this.filemanager_v2.Size = new System.Drawing.Size(846, 631);
		this.filemanager_v2.TabIndex = 0;
		this.Panel17.AllowDrop = true;
		this.Panel17.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.Panel17.Controls.Add(this.SplitContainer2);
		this.Panel17.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel17.Location = new System.Drawing.Point(0, 55);
		this.Panel17.Name = "Panel17";
		this.Panel17.Size = new System.Drawing.Size(846, 532);
		this.Panel17.TabIndex = 69;
		this.SplitContainer2.BackColor = System.Drawing.Color.Transparent;
		this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
		this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
		this.SplitContainer2.Name = "SplitContainer2";
		this.SplitContainer2.Panel1.Controls.Add(this.TreeView1);
		this.SplitContainer2.Panel1MinSize = 150;
		this.SplitContainer2.Panel2.Controls.Add(this.SplitContainer3);
		this.SplitContainer2.Size = new System.Drawing.Size(846, 532);
		this.SplitContainer2.SplitterDistance = 150;
		this.SplitContainer2.TabIndex = 77;
		this.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TreeView1.HideSelection = false;
		this.TreeView1.Location = new System.Drawing.Point(0, 0);
		this.TreeView1.Name = "TreeView1";
		this.TreeView1.Size = new System.Drawing.Size(150, 532);
		this.TreeView1.TabIndex = 76;
		this.SplitContainer3.AllowDrop = true;
		this.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
		this.SplitContainer3.Location = new System.Drawing.Point(0, 0);
		this.SplitContainer3.Name = "SplitContainer3";
		this.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
		this.SplitContainer3.Panel1.AllowDrop = true;
		this.SplitContainer3.Panel1.Controls.Add(this.listView);
		this.SplitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.SplitContainer3.Panel1MinSize = 150;
		this.SplitContainer3.Panel2.Controls.Add(this.detailSplitContainer);
		this.SplitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.SplitContainer3.Panel2Collapsed = true;
		this.SplitContainer3.Panel2MinSize = 100;
		this.SplitContainer3.Size = new System.Drawing.Size(692, 532);
		this.SplitContainer3.SplitterDistance = 354;
		this.SplitContainer3.TabIndex = 5;
		this.listView.AllowDrop = true;
		this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.listView.ContextMenuStrip = this.ContextMenuStrip1;
		this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
		this.listView.LabelEdit = true;
		this.listView.LargeImageList = this.ImageList1;
		this.listView.Location = new System.Drawing.Point(0, 0);
		this.listView.Name = "listView";
		this.listView.Size = new System.Drawing.Size(692, 532);
		this.listView.TabIndex = 74;
		this.listView.UseCompatibleStateImageBehavior = false;
		this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[9] { this.새폴더ToolStripMenuItem, this.파일업로드ToolStripMenuItem, this.ToolStripSeparator2, this.전체선택ToolStripMenuItem, this.이름변경ToolStripMenuItem, this.이동ToolStripMenuItem, this.붙여넣기ToolStripMenuItem, this.ToolStripSeparator1, this.삭제ToolStripMenuItem });
		this.ContextMenuStrip1.Name = "ContextMenuStrip1";
		this.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
		this.ContextMenuStrip1.ShowImageMargin = false;
		this.ContextMenuStrip1.Size = new System.Drawing.Size(156, 170);
		this.새폴더ToolStripMenuItem.Name = "새폴더ToolStripMenuItem";
		this.새폴더ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.새폴더ToolStripMenuItem.Text = "새 폴더";
		this.파일업로드ToolStripMenuItem.Name = "파일업로드ToolStripMenuItem";
		this.파일업로드ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+U";
		this.파일업로드ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.파일업로드ToolStripMenuItem.Text = "파일 업로드";
		this.ToolStripSeparator2.Name = "ToolStripSeparator2";
		this.ToolStripSeparator2.Size = new System.Drawing.Size(152, 6);
		this.전체선택ToolStripMenuItem.Name = "전체선택ToolStripMenuItem";
		this.전체선택ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
		this.전체선택ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.전체선택ToolStripMenuItem.Text = "전체 선택";
		this.이름변경ToolStripMenuItem.Name = "이름변경ToolStripMenuItem";
		this.이름변경ToolStripMenuItem.ShortcutKeyDisplayString = "F2";
		this.이름변경ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.이름변경ToolStripMenuItem.Text = "이름 바꾸기";
		this.이동ToolStripMenuItem.Name = "이동ToolStripMenuItem";
		this.이동ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
		this.이동ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.이동ToolStripMenuItem.Text = "잘라내기";
		this.붙여넣기ToolStripMenuItem.Enabled = false;
		this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
		this.붙여넣기ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
		this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.붙여넣기ToolStripMenuItem.Text = "붙여넣기";
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new System.Drawing.Size(152, 6);
		this.삭제ToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
		this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
		this.삭제ToolStripMenuItem.ShortcutKeyDisplayString = "DEL";
		this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
		this.삭제ToolStripMenuItem.Text = "삭제";
		this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		this.ImageList1.ImageSize = new System.Drawing.Size(48, 48);
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.detailSplitContainer.BackColor = System.Drawing.Color.Transparent;
		this.detailSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.detailSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
		this.detailSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
		this.detailSplitContainer.Location = new System.Drawing.Point(0, 0);
		this.detailSplitContainer.Name = "detailSplitContainer";
		this.detailSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
		this.detailSplitContainer.Panel1.Controls.Add(this.preview);
		this.detailSplitContainer.Panel1.Controls.Add(this.Panel24);
		this.detailSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(5);
		this.detailSplitContainer.Panel1MinSize = 180;
		this.detailSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.detailSplitContainer.Panel2.Controls.Add(this.Panel23);
		this.detailSplitContainer.Panel2MinSize = 120;
		this.detailSplitContainer.Size = new System.Drawing.Size(150, 25);
		this.detailSplitContainer.SplitterDistance = 180;
		this.detailSplitContainer.TabIndex = 4;
		this.preview.Cursor = System.Windows.Forms.Cursors.Hand;
		this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.preview.Image = mlas_root.My.Resources.Resources.upload;
		this.preview.Location = new System.Drawing.Point(5, 5);
		this.preview.Name = "preview";
		this.preview.Size = new System.Drawing.Size(168, 108);
		this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.preview.TabIndex = 3;
		this.preview.TabStop = false;
		this.preview.Tag = "";
		this.Panel24.BackColor = System.Drawing.Color.White;
		this.Panel24.Controls.Add(this.imageSave);
		this.Panel24.Controls.Add(this.Panel21);
		this.Panel24.Controls.Add(this.changeImage);
		this.Panel24.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel24.Location = new System.Drawing.Point(5, 113);
		this.Panel24.Name = "Panel24";
		this.Panel24.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
		this.Panel24.Size = new System.Drawing.Size(168, 54);
		this.Panel24.TabIndex = 65;
		this.imageSave.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.imageSave.Dock = System.Windows.Forms.DockStyle.Top;
		this.imageSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.imageSave.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.imageSave.Location = new System.Drawing.Point(10, 31);
		this.imageSave.Name = "imageSave";
		this.imageSave.Size = new System.Drawing.Size(148, 22);
		this.imageSave.TabIndex = 51;
		this.imageSave.Text = "다른 이름으로 파일 저장";
		this.imageSave.UseVisualStyleBackColor = false;
		this.Panel21.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel21.Location = new System.Drawing.Point(10, 28);
		this.Panel21.Name = "Panel21";
		this.Panel21.Size = new System.Drawing.Size(148, 3);
		this.Panel21.TabIndex = 64;
		this.changeImage.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.changeImage.Dock = System.Windows.Forms.DockStyle.Top;
		this.changeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.changeImage.ForeColor = System.Drawing.Color.YellowGreen;
		this.changeImage.Location = new System.Drawing.Point(10, 5);
		this.changeImage.Name = "changeImage";
		this.changeImage.Size = new System.Drawing.Size(148, 23);
		this.changeImage.TabIndex = 63;
		this.changeImage.Text = "이미지 교체";
		this.changeImage.UseVisualStyleBackColor = false;
		this.Panel23.Controls.Add(this.descript);
		this.Panel23.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel23.Location = new System.Drawing.Point(0, 0);
		this.Panel23.Name = "Panel23";
		this.Panel23.Size = new System.Drawing.Size(506, 172);
		this.Panel23.TabIndex = 5;
		this.descript.BackColor = System.Drawing.Color.White;
		this.descript.Dock = System.Windows.Forms.DockStyle.Fill;
		this.descript.Location = new System.Drawing.Point(0, 0);
		this.descript.Name = "descript";
		this.descript.Padding = new System.Windows.Forms.Padding(10, 10, 5, 0);
		this.descript.Size = new System.Drawing.Size(506, 172);
		this.descript.TabIndex = 4;
		this.descript.Text = "홈";
		this.DoubleBufferPanel1.Controls.Add(this.nowUrl);
		this.DoubleBufferPanel1.Controls.Add(this.folderTitle);
		this.DoubleBufferPanel1.Controls.Add(this.Panel18);
		this.DoubleBufferPanel1.Controls.Add(this.PictureBox1);
		this.DoubleBufferPanel1.Controls.Add(this.Panel22);
		this.DoubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel1.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel1.Name = "DoubleBufferPanel1";
		this.DoubleBufferPanel1.Padding = new System.Windows.Forms.Padding(10);
		this.DoubleBufferPanel1.Size = new System.Drawing.Size(846, 55);
		this.DoubleBufferPanel1.TabIndex = 75;
		this.nowUrl.BackColor = System.Drawing.Color.WhiteSmoke;
		this.nowUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.nowUrl.Dock = System.Windows.Forms.DockStyle.Fill;
		this.nowUrl.ForeColor = System.Drawing.Color.Blue;
		this.nowUrl.Location = new System.Drawing.Point(44, 28);
		this.nowUrl.Name = "nowUrl";
		this.nowUrl.Size = new System.Drawing.Size(703, 21);
		this.nowUrl.TabIndex = 2;
		this.nowUrl.Text = "\\";
		this.folderTitle.Dock = System.Windows.Forms.DockStyle.Top;
		this.folderTitle.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.folderTitle.Location = new System.Drawing.Point(44, 10);
		this.folderTitle.Name = "folderTitle";
		this.folderTitle.Size = new System.Drawing.Size(703, 18);
		this.folderTitle.TabIndex = 1;
		this.folderTitle.Text = "홈";
		this.folderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel18.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel18.Location = new System.Drawing.Point(39, 10);
		this.Panel18.Name = "Panel18";
		this.Panel18.Size = new System.Drawing.Size(5, 35);
		this.Panel18.TabIndex = 3;
		this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
		this.PictureBox1.Image = mlas_root.My.Resources.Resources.Arrows_Back_icon;
		this.PictureBox1.Location = new System.Drawing.Point(10, 10);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(29, 35);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 0;
		this.PictureBox1.TabStop = false;
		this.Panel22.Controls.Add(this.PictureBox4);
		this.Panel22.Controls.Add(this.PictureBox2);
		this.Panel22.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel22.Location = new System.Drawing.Point(747, 10);
		this.Panel22.Name = "Panel22";
		this.Panel22.Size = new System.Drawing.Size(89, 35);
		this.Panel22.TabIndex = 5;
		this.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
		this.PictureBox4.Image = mlas_root.My.Resources.Resources.add_folder;
		this.PictureBox4.Location = new System.Drawing.Point(7, 0);
		this.PictureBox4.Name = "PictureBox4";
		this.PictureBox4.Size = new System.Drawing.Size(41, 35);
		this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox4.TabIndex = 6;
		this.PictureBox4.TabStop = false;
		this.ToolTip1.SetToolTip(this.PictureBox4, "새 폴더 만들기");
		this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
		this.PictureBox2.Image = mlas_root.My.Resources.Resources.upload;
		this.PictureBox2.Location = new System.Drawing.Point(48, 0);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(41, 35);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox2.TabIndex = 5;
		this.PictureBox2.TabStop = false;
		this.ToolTip1.SetToolTip(this.PictureBox2, "현재 폴더에 파일 업로드");
		this.Panel20.Controls.Add(this.Label11);
		this.Panel20.Controls.Add(this.Button24);
		this.Panel20.Controls.Add(this.PictureBox5);
		this.Panel20.Controls.Add(this.Button22);
		this.Panel20.Controls.Add(this.PictureBox3);
		this.Panel20.Controls.Add(this.Button21);
		this.Panel20.Controls.Add(this.Button23);
		this.Panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel20.Location = new System.Drawing.Point(0, 587);
		this.Panel20.Name = "Panel20";
		this.Panel20.Padding = new System.Windows.Forms.Padding(5);
		this.Panel20.Size = new System.Drawing.Size(846, 44);
		this.Panel20.TabIndex = 47;
		this.Label11.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label11.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label11.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
		this.Label11.Location = new System.Drawing.Point(168, 5);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(463, 34);
		this.Label11.TabIndex = 32;
		this.Label11.Text = "사용할 파일을 선택 하십시오.";
		this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Button24.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button24.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button24.ForeColor = System.Drawing.Color.Gold;
		this.Button24.Location = new System.Drawing.Point(88, 5);
		this.Button24.Name = "Button24";
		this.Button24.Size = new System.Drawing.Size(80, 34);
		this.Button24.TabIndex = 36;
		this.Button24.Text = "찾기";
		this.Button24.UseVisualStyleBackColor = false;
		this.PictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
		this.PictureBox5.Location = new System.Drawing.Point(85, 5);
		this.PictureBox5.Name = "PictureBox5";
		this.PictureBox5.Size = new System.Drawing.Size(3, 34);
		this.PictureBox5.TabIndex = 35;
		this.PictureBox5.TabStop = false;
		this.Button22.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button22.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button22.ForeColor = System.Drawing.Color.YellowGreen;
		this.Button22.Location = new System.Drawing.Point(631, 5);
		this.Button22.Name = "Button22";
		this.Button22.Size = new System.Drawing.Size(112, 34);
		this.Button22.TabIndex = 30;
		this.Button22.Text = "선택된 파일 사용";
		this.Button22.UseVisualStyleBackColor = false;
		this.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
		this.PictureBox3.Location = new System.Drawing.Point(743, 5);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(3, 34);
		this.PictureBox3.TabIndex = 34;
		this.PictureBox3.TabStop = false;
		this.Button21.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button21.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button21.ForeColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.Button21.Location = new System.Drawing.Point(5, 5);
		this.Button21.Name = "Button21";
		this.Button21.Size = new System.Drawing.Size(80, 34);
		this.Button21.TabIndex = 33;
		this.Button21.Text = "새로고침";
		this.Button21.UseVisualStyleBackColor = false;
		this.Button23.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button23.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button23.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.Button23.Location = new System.Drawing.Point(746, 5);
		this.Button23.Name = "Button23";
		this.Button23.Size = new System.Drawing.Size(95, 34);
		this.Button23.TabIndex = 31;
		this.Button23.Text = "닫기";
		this.Button23.UseVisualStyleBackColor = false;
		this.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel19.Controls.Add(this.Label5);
		this.Panel19.Controls.Add(this.Button18);
		this.Panel19.Controls.Add(this.Button19);
		this.Panel19.Controls.Add(this.Button20);
		this.Panel19.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel19.Location = new System.Drawing.Point(0, 699);
		this.Panel19.Name = "Panel19";
		this.Panel19.Padding = new System.Windows.Forms.Padding(5);
		this.Panel19.Size = new System.Drawing.Size(982, 44);
		this.Panel19.TabIndex = 49;
		this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label5.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label5.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
		this.Label5.Location = new System.Drawing.Point(85, 5);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(683, 32);
		this.Label5.TabIndex = 32;
		this.Label5.Text = "사용할 파일을 선택 하십시오.";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Button18.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button18.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button18.ForeColor = System.Drawing.Color.FromArgb(192, 192, 255);
		this.Button18.Location = new System.Drawing.Point(5, 5);
		this.Button18.Name = "Button18";
		this.Button18.Size = new System.Drawing.Size(80, 32);
		this.Button18.TabIndex = 33;
		this.Button18.Text = "새로고침";
		this.Button18.UseVisualStyleBackColor = false;
		this.Button19.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button19.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button19.ForeColor = System.Drawing.Color.YellowGreen;
		this.Button19.Location = new System.Drawing.Point(768, 5);
		this.Button19.Name = "Button19";
		this.Button19.Size = new System.Drawing.Size(112, 32);
		this.Button19.TabIndex = 30;
		this.Button19.Text = "선택된 파일 사용";
		this.Button19.UseVisualStyleBackColor = false;
		this.Button20.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button20.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button20.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.Button20.Location = new System.Drawing.Point(880, 5);
		this.Button20.Name = "Button20";
		this.Button20.Size = new System.Drawing.Size(95, 32);
		this.Button20.TabIndex = 31;
		this.Button20.Text = "닫기";
		this.Button20.UseVisualStyleBackColor = false;
		this.AllowDrop = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(854, 657);
		base.Controls.Add(this.TabControl1);
		this.DoubleBuffered = true;
		base.Name = "fileManager";
		this.Text = "fileManager";
		this.p_fileManager.ResumeLayout(false);
		this.SplitContainer1.Panel1.ResumeLayout(false);
		this.SplitContainer1.Panel2.ResumeLayout(false);
		this.SplitContainer1.ResumeLayout(false);
		this.Panel13.ResumeLayout(false);
		this.Panel14.ResumeLayout(false);
		this.Panel15.ResumeLayout(false);
		this.Panel15.PerformLayout();
		this.Panel12.ResumeLayout(false);
		this.Panel16.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.PicturePanel1.ResumeLayout(false);
		this.Panel10.ResumeLayout(false);
		this.Panel11.ResumeLayout(false);
		this.Panel9.ResumeLayout(false);
		this.Panel9.PerformLayout();
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		this.Panel4.ResumeLayout(false);
		this.Panel4.PerformLayout();
		this.newgroup.ResumeLayout(false);
		this.newgroup.PerformLayout();
		this.Panel8.ResumeLayout(false);
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage2.ResumeLayout(false);
		this.filemanager_v2.ResumeLayout(false);
		this.Panel17.ResumeLayout(false);
		this.SplitContainer2.Panel1.ResumeLayout(false);
		this.SplitContainer2.Panel2.ResumeLayout(false);
		this.SplitContainer2.ResumeLayout(false);
		this.SplitContainer3.Panel1.ResumeLayout(false);
		this.SplitContainer3.Panel2.ResumeLayout(false);
		this.SplitContainer3.ResumeLayout(false);
		this.ContextMenuStrip1.ResumeLayout(false);
		this.detailSplitContainer.Panel1.ResumeLayout(false);
		this.detailSplitContainer.Panel2.ResumeLayout(false);
		this.detailSplitContainer.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.preview).EndInit();
		this.Panel24.ResumeLayout(false);
		this.Panel23.ResumeLayout(false);
		this.DoubleBufferPanel1.ResumeLayout(false);
		this.DoubleBufferPanel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel22.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		this.Panel20.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		this.Panel19.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public List<string> GetImageList()
	{
		List<string> list = new List<string>();
		foreach (ImageClass item in imageClass)
		{
			list.Add(Conversions.ToString(item.getFindString()));
		}
		return list;
	}

	private void ListView1_ItemChecked(object sender, ItemCheckedEventArgs e)
	{
		ListView.CheckedListViewItemCollection checkedItems = ListView1.CheckedItems;
		if (checkedItems.Count > 1)
		{
			string text = null;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = checkedItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem listViewItem = (ListViewItem)enumerator.Current;
					text = text + listViewItem.Text + "\r\n";
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			text = text.Trim().Replace("\r\n", ", ");
			try
			{
				prop1.Text = text;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				ComboBox1.Text = ComboBox2.Text;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			try
			{
				prop3.Text = "복수선택";
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			Button8.Hide();
			return;
		}
		try
		{
			string text2 = null;
			try
			{
				text2 = Module1.HtmlSourceNoCredent(Module1._dburl + "/get.php?t=imgBlobD&n=" + ListView1.SelectedItems[0].SubItems[0].Text).ToString().Trim();
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ProjectData.ClearProjectError();
			}
			if (text2 == null)
			{
				return;
			}
			byte[] buffer = Convert.FromBase64String(text2);
			MemoryStream memoryStream = new MemoryStream(buffer);
			PicturePanel1.BackgroundImage = Image.FromStream(memoryStream);
			ListViewItem focusedItem = ListView1.FocusedItem;
			try
			{
				prop1.Text = focusedItem.Text;
				search = focusedItem.Text;
			}
			catch (Exception ex9)
			{
				ProjectData.SetProjectError(ex9);
				Exception ex10 = ex9;
				ProjectData.ClearProjectError();
			}
			try
			{
				ComboBox1.Text = focusedItem.SubItems[1].Text;
			}
			catch (Exception ex11)
			{
				ProjectData.SetProjectError(ex11);
				Exception ex12 = ex11;
				ProjectData.ClearProjectError();
			}
			try
			{
				prop2.Text = focusedItem.SubItems[2].Text;
			}
			catch (Exception ex13)
			{
				ProjectData.SetProjectError(ex13);
				Exception ex14 = ex13;
				ProjectData.ClearProjectError();
			}
			try
			{
				prop3.Text = focusedItem.SubItems[3].Text;
			}
			catch (Exception ex15)
			{
				ProjectData.SetProjectError(ex15);
				Exception ex16 = ex15;
				ProjectData.ClearProjectError();
			}
			Panel10.Show();
			Panel4.Visible = true;
			newgroup.Hide();
			int arg = 0;
			double num = (double)memoryStream.Length / 1024.0;
			if (num >= 300.0)
			{
				arg = 7;
			}
			else if (num >= 200.0 && num <= 300.0)
			{
				arg = 6;
			}
			else if (num >= 175.0 && num <= 200.0)
			{
				arg = 5;
			}
			else if (num >= 150.0 && num <= 175.0)
			{
				arg = 4;
			}
			else if (num >= 75.0 && num <= 150.0)
			{
				arg = 3;
			}
			else if (num >= 50.0 && num <= 75.0)
			{
				arg = 2;
			}
			else if (num >= 25.0 && num <= 50.0)
			{
				arg = 1;
			}
			else if (num >= 0.0 && num <= 25.0)
			{
				arg = 0;
			}
			Panel10.BackgroundImage = MakeLabel("이름: " + focusedItem.SubItems[2].Text + "\r\n사진 크기: " + Conversions.ToString(PicturePanel1.BackgroundImage.Size.Width) + "x" + Conversions.ToString(PicturePanel1.BackgroundImage.Size.Height) + "\r\n크기: " + GetFileSize(memoryStream.Length), arg);
		}
		catch (Exception ex17)
		{
			ProjectData.SetProjectError(ex17);
			Exception ex18 = ex17;
			PicturePanel1.BackgroundImage = null;
			GC.Collect();
			Panel10.Hide();
			Panel4.Visible = false;
			newgroup.Hide();
			ProjectData.ClearProjectError();
		}
		Button8.Show();
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (ListView1.CheckedItems.Count > 1)
		{
			return;
		}
		try
		{
			string text = null;
			try
			{
				text = new GetHtmlClass(Module1._dburl + "/get.php?t=imgBlobD&n=" + ListView1.SelectedItems[0].SubItems[0].Text).getHTML(this).Trim();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (text == null)
			{
				return;
			}
			byte[] buffer = Convert.FromBase64String(text);
			MemoryStream memoryStream = new MemoryStream(buffer);
			PicturePanel1.BackgroundImage = Image.FromStream(memoryStream);
			ListViewItem focusedItem = ListView1.FocusedItem;
			try
			{
				prop1.Text = focusedItem.Text;
				search = focusedItem.Text;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			try
			{
				ComboBox1.Text = focusedItem.SubItems[1].Text;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			try
			{
				prop2.Text = focusedItem.SubItems[2].Text;
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ProjectData.ClearProjectError();
			}
			try
			{
				prop3.Text = focusedItem.SubItems[3].Text;
			}
			catch (Exception ex9)
			{
				ProjectData.SetProjectError(ex9);
				Exception ex10 = ex9;
				ProjectData.ClearProjectError();
			}
			Panel10.Show();
			Panel4.Visible = true;
			newgroup.Hide();
			int arg = 0;
			double num = (double)memoryStream.Length / 1024.0;
			if (num >= 300.0)
			{
				arg = 7;
			}
			else if (num >= 200.0 && num <= 300.0)
			{
				arg = 6;
			}
			else if (num >= 175.0 && num <= 200.0)
			{
				arg = 5;
			}
			else if (num >= 150.0 && num <= 175.0)
			{
				arg = 4;
			}
			else if (num >= 75.0 && num <= 150.0)
			{
				arg = 3;
			}
			else if (num >= 50.0 && num <= 75.0)
			{
				arg = 2;
			}
			else if (num >= 25.0 && num <= 50.0)
			{
				arg = 1;
			}
			else if (num >= 0.0 && num <= 25.0)
			{
				arg = 0;
			}
			Panel10.BackgroundImage = MakeLabel("이름: " + focusedItem.SubItems[2].Text + "\r\n사진 크기: " + Conversions.ToString(PicturePanel1.BackgroundImage.Size.Width) + "x" + Conversions.ToString(PicturePanel1.BackgroundImage.Size.Height) + "\r\n크기: " + GetFileSize(memoryStream.Length), arg);
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			PicturePanel1.BackgroundImage = null;
			GC.Collect();
			Panel10.Hide();
			Panel4.Visible = false;
			newgroup.Hide();
			ProjectData.ClearProjectError();
		}
		Button8.Show();
	}

	private void ComboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (imgLoading)
		{
			return;
		}
		ComboBox2.Items.Clear();
		foreach (string item in folderClass[ComboBoxEx1.SelectedIndex].items)
		{
			ComboBox2.Items.Add(item);
		}
		try
		{
			ComboBox2.SelectedIndex = 0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void imgList()
	{
		imgLoading = true;
		etc = new List<string>();
		ComboBoxEx1.Items.Clear();
		ComboBox2.Text = null;
		folderClass = new List<folder>();
		folderClass.Add(new folder("전체보기"));
		ComboBox1.Items.Clear();
		ComboBox2.Items.Clear();
		string[] array = new GetHtmlClass(Module1._dburl + "/get.php?t=imgGroup").getHTML(this).Trim().Split(new string[1] { "<split>" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string item in array)
		{
			folderClass[0].items.Add(item);
			ComboBox1.Items.Add(item);
			ComboBox2.Items.Add(item);
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ComboBox2.Items.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string text = Conversions.ToString(enumerator.Current);
				string[] array2 = text.Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
				bool flag = false;
				foreach (folder item2 in folderClass)
				{
					if (item2.name.Contains(array2[0]) | array2[0].Contains(item2.name))
					{
						item2.items.Add(text);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					folderClass.Add(new folder(array2[0], text));
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
		checked
		{
			int num = folderClass.Count - 1;
			for (int j = 0; j <= num && j <= folderClass.Count - 1; j++)
			{
				folder folder = folderClass[j];
				if (folder.items.Count == 1)
				{
					etc.Add(folder.items[0]);
					folderClass.RemoveAt(j);
					j--;
				}
				else
				{
					ComboBoxEx1.Items.Add(folder.name);
					ComboBoxEx1.Text = "전체보기";
				}
			}
			if (etc.Count > 0)
			{
				folderClass.Add(new folder("기타", etc));
				ComboBoxEx1.Items.Add("기타");
			}
			string obj = new GetHtmlClass(Module1._dburl + "/get.php?t=imgList", null, progress: true).getHTML(this).ToString().Trim();
			imageClass = new List<ImageClass>();
			imageClass.Clear();
			int num2 = 0;
			object obj2 = null;
			string[] array3 = obj.Split(new string[1] { "<split>" }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string text2 in array3)
			{
				imageClass.Add(new ImageClass(text2));
				num2++;
				if (Operators.CompareString(search, text2.Substring(0, text2.IndexOf("<br>")), TextCompare: false) == 0)
				{
					obj2 = text2.Substring(text2.LastIndexOf("<br>") + 4);
				}
			}
			Panel10.Hide();
			Panel4.Visible = false;
			if (Operators.ConditionalCompareObjectNotEqual(obj2, null, TextCompare: false))
			{
				ComboBox2.Text = Conversions.ToString(obj2);
			}
			if (Operators.CompareString(search, null, TextCompare: false) == 0)
			{
				try
				{
					ComboBoxEx1.SelectedIndex = 0;
					ComboBox2.SelectedIndex = 0;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			imgLoading = false;
		}
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		Module1.searchMode = null;
		custom_msgbox custom_msgbox2 = CustomMsgBox.CMsgBox(null, "", null, custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Marquee);
		ListView1.Columns[0].Text = "id";
		ListView1.Columns[1].Text = "group";
		ListView1.Columns[2].Text = "name";
		ListView1.Columns[3].Text = "comment";
		ListView1.ListViewItemSorter = new ListViewComparer(0, SortOrder.Ascending);
		ListView1.Sort();
		ListView1.Items.Clear();
		int num = -1;
		nowGroup = ComboBox2.Text;
		int num2 = 0;
		foreach (ImageClass item in imageClass)
		{
			if (!Operators.ConditionalCompareObjectNotEqual(item.group, ComboBox2.SelectedItem, TextCompare: false))
			{
				Application.DoEvents();
				ListView1.Items.Add(Conversions.ToString(item.num));
				if (Operators.CompareString(search, item.num.ToString(), TextCompare: false) == 0)
				{
					num = num2;
				}
				try
				{
					ListView1.Items[num2].SubItems.Add(item.group);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				try
				{
					ListView1.Items[num2].SubItems.Add(item.name);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				try
				{
					ListView1.Items[num2].SubItems.Add(item.text);
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.ClearProjectError();
				}
				num2 = checked(num2 + 1);
			}
		}
		if (num != -1)
		{
			ListView1.FocusedItem = ListView1.Items[num];
			ListView1.Items[num].Selected = true;
			ListView1.Items[num].Focused = true;
			ListView1.EnsureVisible(num);
		}
		newgroup.Hide();
		try
		{
			custom_msgbox2.Close();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			ProjectData.ClearProjectError();
		}
	}

	public string GetFileSize(double TheSize)
	{
		try
		{
			if (TheSize >= 1099511627776.0)
			{
				return Strings.FormatNumber(TheSize / 1099511627776.0, 1) + "TB";
			}
			if (TheSize >= 1073741824.0 && TheSize <= 1099511627775.0)
			{
				return Strings.FormatNumber(TheSize / 1073741824.0, 1) + "GB";
			}
			if (TheSize >= 1048576.0 && TheSize <= 1073741823.0)
			{
				return Strings.FormatNumber(TheSize / 1048576.0, 1) + "MB";
			}
			if (TheSize >= 1024.0 && TheSize <= 1048575.0)
			{
				return Strings.FormatNumber(TheSize / 1024.0, 1) + "KB";
			}
			if (TheSize >= 0.0 && TheSize <= 1023.0)
			{
				return Strings.FormatNumber(TheSize, 1) + "bytes";
			}
			return "";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private Bitmap MakeLabel(string arg1, int arg2)
	{
		Bitmap bitmap = new Bitmap(1024, 500);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.AntiAlias;
		graphics.FillRectangle(new SolidBrush(Color.FromArgb(150, 40, 40, 40)), 0, 0, 1024, 500);
		using (GraphicsPath graphicsPath = new GraphicsPath())
		{
			using Font font = new Font("맑은 고딕", 10.5f, FontStyle.Bold);
			using Pen pen = new Pen(Brushes.Black, 3f);
			graphicsPath.AddString(arg1, font.FontFamily, (int)font.Style, font.Size + 3f, new Point(15, 10), StringFormat.GenericTypographic);
			graphics.DrawPath(pen, graphicsPath);
			graphics.FillPath(Brushes.White, graphicsPath);
		}
		using (GraphicsPath graphicsPath2 = new GraphicsPath())
		{
			using Font font2 = new Font("맑은 고딕", 10.5f, FontStyle.Bold);
			using Pen pen2 = new Pen(Brushes.Black, 3f);
			graphicsPath2.AddString("트래픽 부담: ", font2.FontFamily, (int)font2.Style, font2.Size + 3f, new Point(15, 70), StringFormat.GenericTypographic);
			graphics.DrawPath(pen2, graphicsPath2);
			graphics.FillPath(Brushes.White, graphicsPath2);
		}
		string s = "매우 낮음";
		Brush brush = Brushes.White;
		switch (arg2)
		{
		case 1:
			s = "낮음";
			brush = new SolidBrush(Color.FromArgb(255, 122, 199, 255));
			break;
		case 2:
			s = "조금 낮음";
			brush = new SolidBrush(Color.FromArgb(255, 0, 147, 255));
			break;
		case 3:
			s = "적당함";
			brush = new SolidBrush(Color.FromArgb(255, 0, 255, 61));
			break;
		case 4:
			s = "조금 높음";
			brush = new SolidBrush(Color.FromArgb(255, 255, 96, 96));
			break;
		case 5:
			s = "높음";
			brush = new SolidBrush(Color.FromArgb(255, 255, 52, 52));
			break;
		case 6:
			s = "매우 높음";
			brush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
			break;
		case 7:
			s = "경고! 아주 높음";
			brush = new SolidBrush(Color.FromArgb(255, 200, 0, 218));
			break;
		}
		using (GraphicsPath graphicsPath3 = new GraphicsPath())
		{
			using Font font3 = new Font("맑은 고딕", 10.5f, FontStyle.Bold);
			using Pen pen3 = new Pen(Brushes.Black, 3f);
			graphicsPath3.AddString(s, font3.FontFamily, (int)font3.Style, font3.Size + 3f, new Point(95, 70), StringFormat.GenericTypographic);
			graphics.DrawPath(pen3, graphicsPath3);
			graphics.FillPath(brush, graphicsPath3);
		}
		graphics.Dispose();
		return bitmap;
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		try
		{
			lvSelectedLocation = ListView1.SelectedIndices[0];
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		WebBrowser webBrowser = new WebBrowser();
		WebBrowser webBrowser2 = webBrowser;
		webBrowser2.Dock = DockStyle.Fill;
		webBrowser2.IsWebBrowserContextMenuEnabled = false;
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), Button7.Name, TextCompare: false))
		{
			webBrowser2.Url = new Uri(Module1._dburl + "/fup.php?g=" + HttpUtility.UrlEncode(ComboBox2.Text));
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), Button1.Name, TextCompare: false))
		{
			webBrowser2.Url = new Uri(Module1._dburl + "/fup.php?t=update&num=" + prop1.Text);
		}
		webBrowser2.ScrollBarsEnabled = false;
		webBrowser2 = null;
		Label label = new Label();
		Label label2 = label;
		label2.AutoSize = false;
		label2.Dock = DockStyle.Top;
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), Button7.Name, TextCompare: false))
		{
			label2.Text = "파일 업로드";
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), Button1.Name, TextCompare: false))
		{
			label2.Text = "파일 변경";
		}
		label2.TextAlign = ContentAlignment.MiddleCenter;
		label2.Size = new Size(0, 40);
		label2.Font = new Font("맑은 고딕", 12f, FontStyle.Bold);
		label2.BorderStyle = BorderStyle.FixedSingle;
		label2 = null;
		Button button = new Button();
		Button button2 = button;
		button2.Text = "창 닫기";
		button2.Dock = DockStyle.Bottom;
		button2.FlatStyle = FlatStyle.Flat;
		button2.BackColor = Color.Green;
		button2.ForeColor = Color.White;
		button2.Font = new Font("맑은 고딕", 10f);
		button2.Size = new Size(0, 30);
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), Button7.Name, TextCompare: false))
		{
			button2.Name = "new";
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), Button1.Name, TextCompare: false))
		{
			button2.Name = "mod";
		}
		button2 = null;
		pn = new Panel();
		Panel panel = pn;
		panel.BackColor = Color.DarkRed;
		panel.ForeColor = Color.White;
		panel.BorderStyle = BorderStyle.Fixed3D;
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), Button7.Name, TextCompare: false))
		{
			panel.Size = new Size(300, 380);
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null), Button1.Name, TextCompare: false))
		{
			panel.Size = new Size(300, 225);
		}
		panel.Controls.Add(webBrowser);
		panel.Controls.Add(label);
		panel.Controls.Add(button);
		panel.Location = checked(new Point((int)Math.Round((double)p_fileManager.Size.Width / 2.0 - (double)panel.Size.Width / 2.0), (int)Math.Round((double)p_fileManager.Size.Height / 2.0 - (double)panel.Size.Height / 2.0)));
		panel = null;
		button.MouseDown += closeform;
		p_fileManager.Controls.Add(pn);
		p_fileManager.Controls.SetChildIndex(pn, 0);
	}

	private void closeform(object sender, MouseEventArgs e)
	{
		PicturePanel1.BackgroundImage = null;
		GC.Collect();
		Panel4.Visible = false;
		Panel10.Hide();
		pn.Dispose();
		imgList();
		checked
		{
			try
			{
				if (NewLateBinding.LateGet(sender, null, "name", new object[0], null, null, null) == "mod")
				{
					ListView1.FocusedItem = ListView1.Items[lvSelectedLocation];
					ListView1.Items[lvSelectedLocation].Selected = true;
					ListView1.Items[lvSelectedLocation].Focused = true;
					ListView1.EnsureVisible(lvSelectedLocation);
				}
				else
				{
					ListView1.FocusedItem = ListView1.Items[ListView1.Items.Count - 1];
					ListView1.Items[ListView1.Items.Count - 1].Selected = true;
					ListView1.Items[ListView1.Items.Count - 1].Focused = true;
					ListView1.EnsureVisible(ListView1.Items.Count - 1);
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

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			_ = ListView1.SelectedIndices[0];
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
			return;
		}
		string project = Module1.project;
		checked
		{
			if (Operators.CompareString(project, "android_db_sjka_cyber", TextCompare: false) == 0)
			{
				object left = NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null);
				if (Operators.ConditionalCompareObjectEqual(left, MyProject.Forms.android_db_sjka_cyber.tag_id.Name, TextCompare: false))
				{
					NewLateBinding.LateSet(target, null, "text", new object[1] { ListView1.SelectedItems[0].SubItems[0].Text }, null, null);
					MyProject.Forms.android_db_sjka_cyber.tag_id_KeyUp(RuntimeHelpers.GetObjectValue(sender), new KeyEventArgs(Keys.A));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, MyProject.Forms.android_db_sjka_cyber.RichTextbox1.Name, TextCompare: false))
				{
					int num = ((mlas_root.CRT.CustomRichTextbox)target).SelectionStart;
					string text = "<img id=" + ListView1.SelectedItems[0].SubItems[0].Text + " width=100% height=auto>";
					object instance = target;
					object[] array = new object[1];
					object instance2 = NewLateBinding.LateGet(target, null, "Text", new object[0], null, null, null);
					object[] obj = new object[2] { num, text };
					object[] array2 = obj;
					bool[] obj2 = new bool[2] { true, true };
					bool[] array3 = obj2;
					object obj3 = NewLateBinding.LateGet(instance2, null, "Insert", obj, null, null, obj2);
					if (array3[0])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					if (array3[1])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
					}
					array[0] = obj3;
					NewLateBinding.LateSet(instance, null, "Text", array, null, null);
					NewLateBinding.LateSet(target, null, "SelectionStart", new object[1] { num + text.Length }, null, null);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, MyProject.Forms.android_db_sjka_cyber.TextBox34.Name, TextCompare: false))
				{
					TextBox textBox = (TextBox)target;
					int num2 = textBox.SelectionStart;
					bool flag = true;
					try
					{
						int num3 = textBox.Text.Substring(num2).IndexOf(">");
						int num4 = textBox.Text.Substring(num2).IndexOf("<");
						flag = ((num3 <= num4) ? true : false);
						flag = ((!unchecked(num3 == -1 && num4 == -1)) ? true : false);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
					int num5 = -1;
					if (flag)
					{
						try
						{
							num5 = textBox.Text.Substring(0, num2).LastIndexOf("<");
							if (num5 > -1)
							{
								flag = true;
							}
							else
							{
								flag = false;
							}
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							flag = false;
							ProjectData.ClearProjectError();
						}
						try
						{
							flag = ((Operators.CompareString(textBox.Text.Substring(num5, textBox.Text.Substring(num5).IndexOf("=")).Trim(), "<img id", TextCompare: false) == 0) ? true : false);
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							flag = false;
							ProjectData.ClearProjectError();
						}
					}
					if (flag)
					{
						textBox.Text = textBox.Text.Replace(textBox.Text.Substring(num5 + 8, textBox.Text.Substring(num5 + 8).IndexOf(" ")), ListView1.SelectedItems[0].SubItems[0].Text);
						NewLateBinding.LateSet(target, null, "SelectionStart", new object[1] { num5 + 8 + ListView1.SelectedItems[0].SubItems[0].Text.Length }, null, null);
					}
					else
					{
						string text2 = "<img id=" + ListView1.SelectedItems[0].SubItems[0].Text + " width=100% height=auto>";
						object instance3 = target;
						object[] array4 = new object[1];
						object instance4 = NewLateBinding.LateGet(target, null, "Text", new object[0], null, null, null);
						object[] obj4 = new object[2] { num2, text2 };
						object[] array2 = obj4;
						bool[] obj5 = new bool[2] { true, true };
						bool[] array3 = obj5;
						object obj6 = NewLateBinding.LateGet(instance4, null, "Insert", obj4, null, null, obj5);
						if (array3[0])
						{
							num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
						}
						if (array3[1])
						{
							text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
						}
						array4[0] = obj6;
						NewLateBinding.LateSet(instance3, null, "Text", array4, null, null);
						NewLateBinding.LateSet(target, null, "SelectionStart", new object[1] { num2 + text2.Length }, null, null);
					}
				}
				else if ((NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.e1.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.h1.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.n1.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.n2.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.n3.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.n4.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.n5.Name))
				{
					TextBox textBox2 = (TextBox)target;
					int num6 = textBox2.SelectionStart;
					bool flag2 = true;
					try
					{
						int num7 = textBox2.Text.Substring(num6).IndexOf(">");
						int num8 = textBox2.Text.Substring(num6).IndexOf("<");
						flag2 = ((num7 <= num8) ? true : false);
						flag2 = ((!unchecked(num7 == -1 && num8 == -1)) ? true : false);
					}
					catch (Exception ex9)
					{
						ProjectData.SetProjectError(ex9);
						Exception ex10 = ex9;
						ProjectData.ClearProjectError();
					}
					int num9 = -1;
					if (flag2)
					{
						try
						{
							num9 = textBox2.Text.Substring(0, num6).LastIndexOf("<");
							if (num9 > -1)
							{
								flag2 = true;
							}
							else
							{
								flag2 = false;
							}
						}
						catch (Exception ex11)
						{
							ProjectData.SetProjectError(ex11);
							Exception ex12 = ex11;
							flag2 = false;
							ProjectData.ClearProjectError();
						}
						try
						{
							flag2 = ((Operators.CompareString(textBox2.Text.Substring(num9, textBox2.Text.Substring(num9).IndexOf("=")).Trim(), "<img id", TextCompare: false) == 0) ? true : false);
						}
						catch (Exception ex13)
						{
							ProjectData.SetProjectError(ex13);
							Exception ex14 = ex13;
							flag2 = false;
							ProjectData.ClearProjectError();
						}
					}
					if (flag2)
					{
						textBox2.Text = textBox2.Text.Replace(textBox2.Text.Substring(num9 + 8, textBox2.Text.Substring(num9 + 8).IndexOf(" ")), ListView1.SelectedItems[0].SubItems[0].Text);
						NewLateBinding.LateSet(target, null, "SelectionStart", new object[1] { num9 + 8 + ListView1.SelectedItems[0].SubItems[0].Text.Length }, null, null);
					}
					else
					{
						string text3 = "<img id=" + ListView1.SelectedItems[0].SubItems[0].Text + " width=100% height=auto>";
						object instance5 = target;
						object[] array5 = new object[1];
						object instance6 = NewLateBinding.LateGet(target, null, "Text", new object[0], null, null, null);
						object[] obj7 = new object[2] { num6, text3 };
						object[] array2 = obj7;
						bool[] obj8 = new bool[2] { true, true };
						bool[] array3 = obj8;
						object obj9 = NewLateBinding.LateGet(instance6, null, "Insert", obj7, null, null, obj8);
						if (array3[0])
						{
							num6 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
						}
						if (array3[1])
						{
							text3 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
						}
						array5[0] = obj9;
						NewLateBinding.LateSet(instance5, null, "Text", array5, null, null);
						NewLateBinding.LateSet(target, null, "SelectionStart", new object[1] { num6 + text3.Length }, null, null);
					}
				}
				else
				{
					NewLateBinding.LateSet(target, null, "text", new object[1] { ListView1.SelectedItems[0].SubItems[0].Text }, null, null);
				}
			}
			parentObject.Visible = true;
			base.Visible = false;
			prop1.Text = null;
			prop3.Text = null;
			PicturePanel1.BackgroundImage = null;
			NewLateBinding.LateCall(target, null, "Focus", new object[0], null, null, null, IgnoreReturn: true);
		}
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		parentObject.Visible = true;
		base.Visible = false;
		prop1.Text = null;
		prop3.Text = null;
		PicturePanel1.BackgroundImage = null;
		NewLateBinding.LateCall(target, null, "Focus", new object[0], null, null, null, IgnoreReturn: true);
	}

	private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		Button2_Click(RuntimeHelpers.GetObjectValue(sender), e);
		prop1.Text = null;
		prop3.Text = null;
		PicturePanel1.BackgroundImage = null;
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		ListView.CheckedListViewItemCollection checkedItems = ListView1.CheckedItems;
		if (checkedItems.Count > 1)
		{
			if (MessageBox.Show("여러 항목이 선택되었습니다.\r\n선택된 항목을 모두 삭제하시겠습니까?", "파일삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				return;
			}
			int num = 0;
			string text = null;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = checkedItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem listViewItem = (ListViewItem)enumerator.Current;
					if (Operators.CompareString(Module1.HtmlSourceNoCredent(Module1._dburl + "/set.php?t=imgDel&p=" + MySettingsProperty.Settings.pw + "&n=" + listViewItem.SubItems[0].Text).ToString().Trim()
						.Trim(), "correct", TextCompare: false) != 0)
					{
						num = checked(num + 1);
						text = text + listViewItem.SubItems[0].Text + "\r\n";
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
				text = text.Trim().Replace("\r\n", ", ");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (num == 0)
			{
				MessageBox.Show("선택된 파일이 모두 삭제되었습니다.", "파일삭제", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("일부 파일이 삭제되지 않았습니다. 삭제되지 않은 번호: " + text, "파일삭제", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			imgList();
			ComboBox2.Text = nowGroup;
			return;
		}
		try
		{
			if (MessageBox.Show(ListView1.CheckedItems[0].SubItems[2].Text + " 파일을 정말 삭제하시겠습니까?", "파일삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				if (Operators.CompareString(Module1.HtmlSourceNoCredent(Module1._dburl + "/set.php?t=imgDel&p=" + MySettingsProperty.Settings.pw + "&n=" + ListView1.CheckedItems[0].SubItems[0].Text).ToString().Trim()
					.Trim(), "correct", TextCompare: false) == 0)
				{
					MessageBox.Show(ListView1.CheckedItems[0].SubItems[2].Text + " 파일이 삭제되었습니다.", "파일삭제", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					MessageBox.Show(ListView1.CheckedItems[0].SubItems[2].Text + " 파일 삭제에 실패했습니다.", "파일삭제", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				imgList();
				ComboBox2.Text = nowGroup;
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		if (PicturePanel1.BackgroundImage != null)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			SaveFileDialog saveFileDialog2 = saveFileDialog;
			saveFileDialog2.FileName = prop2.Text;
			saveFileDialog2.Filter = "모든 파일 (*.*)|*.*";
			if (saveFileDialog2.ShowDialog() == DialogResult.OK)
			{
				PicturePanel1.BackgroundImage.Save(saveFileDialog.FileName, PicturePanel1.BackgroundImage.RawFormat);
				MessageBox.Show(saveFileDialog2.FileName + " 에 저장 되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			saveFileDialog2 = null;
		}
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		PicturePanel1.BackgroundImageLayout = ImageLayout.Center;
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		PicturePanel1.BackgroundImageLayout = ImageLayout.Stretch;
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		PicturePanel1.BackgroundImageLayout = ImageLayout.Zoom;
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		ListView.CheckedListViewItemCollection checkedItems = ListView1.CheckedItems;
		if (checkedItems.Count > 1)
		{
			int num = 0;
			string text = null;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = checkedItems.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem listViewItem = (ListViewItem)enumerator.Current;
					if (Operators.CompareString(Module1.HTMLPost(Module1._dburl + "/set.php", "p=" + MySettingsProperty.Settings.pw + "&t=imgModify&n=" + listViewItem.SubItems[0].Text + "&txt=" + listViewItem.SubItems[3].Text + "&g=" + ComboBox1.Text).Trim(), "incorrect", TextCompare: false) == 0)
					{
						num = checked(num + 1);
						text = text + listViewItem.SubItems[0].Text + "\r\n";
					}
					try
					{
						text = text.Trim().Replace("\r\n", ", ");
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					if (num == 0)
					{
						CustomMsgBox.CMsgBox("정상적으로 수정 되었습니다.", "수정 완료", "확인", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 1500);
					}
					else
					{
						CustomMsgBox.CMsgBox("일부 파일이 이동되지 않았습니다. 이동되지 않은 번호: " + text, "수정 완료", "확인", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 1500);
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
			PicturePanel1.BackgroundImage = null;
			GC.Collect();
			Panel4.Visible = false;
			Panel10.Hide();
			search = checkedItems[0].Text.Trim();
			imgList();
		}
		else
		{
			try
			{
				lvSelectedLocation = ListView1.SelectedIndices[0];
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			string obj = Module1.HTMLPost(Module1._dburl + "/set.php", "p=" + MySettingsProperty.Settings.pw + "&t=imgModify&n=" + prop1.Text + "&txt=" + prop3.Text + "&g=" + ComboBox1.Text);
			if (Operators.CompareString(obj, "correct", TextCompare: false) == 0)
			{
				CustomMsgBox.CMsgBox("정상적으로 수정 되었습니다.", "수정 완료", "확인", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 1500);
			}
			if (Operators.CompareString(obj.Trim(), "incorrect", TextCompare: false) == 0)
			{
				CustomMsgBox.CMsgBox("서버에 데이터를 저장하지 못했습니다. 인터넷 또는 서버의 상태를 점검하십시오.", "저장 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				return;
			}
			PicturePanel1.BackgroundImage = null;
			GC.Collect();
			Panel4.Visible = false;
			Panel10.Hide();
			search = prop1.Text.Trim();
			imgList();
			prop3.Focus();
		}
	}

	private void ListView1_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Return:
			Button2_Click(RuntimeHelpers.GetObjectValue(sender), e);
			break;
		case Keys.Escape:
			Button10_Click(RuntimeHelpers.GetObjectValue(sender), e);
			break;
		}
	}

	private void Button113_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Module1.searchMode, "이미지찾기", TextCompare: false) != 0)
		{
			Module1.searchMode = "이미지찾기";
			MyProject.Forms.android_db_sjka_cyber.TextBox13.Text = null;
		}
		try
		{
			MyProject.Forms.android_db_sjka_cyber.ListBox13.DataSource = null;
			MyProject.Forms.android_db_sjka_cyber.ListBox13.DataSource = GetImageList();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		p_fileManager.Controls.Add(MyProject.Forms.android_db_sjka_cyber.diag_search);
		MyProject.Forms.android_db_sjka_cyber.diag_search.Size = new Size(MyProject.Forms.android_db_sjka_cyber.diag_search.Width, 400);
		Point point = Module1.ControlCenter(p_fileManager, MyProject.Forms.android_db_sjka_cyber.diag_search);
		MyProject.Forms.android_db_sjka_cyber.diag_search.Top = point.X;
		MyProject.Forms.android_db_sjka_cyber.diag_search.Left = point.Y;
		p_fileManager.Controls.SetChildIndex(MyProject.Forms.android_db_sjka_cyber.diag_search, 0);
		MyProject.Forms.android_db_sjka_cyber.diag_search.Show();
		MyProject.Forms.android_db_sjka_cyber.TextBox13.Focus();
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

	private void fileManager_Load(object sender, EventArgs e)
	{
		AllowDrop = true;
	}

	private void Button34_Click(object sender, EventArgs e)
	{
		newgroup.Hide();
	}

	private void Button35_Click(object sender, EventArgs e)
	{
		ComboBox1.Items.Add(TextBox12.Text);
		ComboBox1.Text = TextBox12.Text;
		Button6_Click(RuntimeHelpers.GetObjectValue(sender), e);
		newgroup.Hide();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		TextBox12.Text = null;
		newgroup.Show();
		TextBox12.Focus();
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Module1.searchMode, "이미지찾기_부분", TextCompare: false) != 0)
		{
			Module1.searchMode = "이미지찾기_부분";
			MyProject.Forms.android_db_sjka_cyber.TextBox13.Text = null;
		}
		List<string> list = new List<string>();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ListView1.Items.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem listViewItem = (ListViewItem)enumerator.Current;
				list.Add(listViewItem.SubItems[0].Text + "  /  " + listViewItem.SubItems[2].Text + "  /  " + listViewItem.SubItems[3].Text + "  /  " + listViewItem.SubItems[1].Text);
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
			MyProject.Forms.android_db_sjka_cyber.ListBox13.DataSource = null;
			MyProject.Forms.android_db_sjka_cyber.ListBox13.DataSource = list;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		p_fileManager.Controls.Add(MyProject.Forms.android_db_sjka_cyber.diag_search);
		MyProject.Forms.android_db_sjka_cyber.diag_search.Size = new Size(MyProject.Forms.android_db_sjka_cyber.diag_search.Width, 400);
		Point point = Module1.ControlCenter(p_fileManager, MyProject.Forms.android_db_sjka_cyber.diag_search);
		MyProject.Forms.android_db_sjka_cyber.diag_search.Top = point.X;
		MyProject.Forms.android_db_sjka_cyber.diag_search.Left = point.Y;
		p_fileManager.Controls.SetChildIndex(MyProject.Forms.android_db_sjka_cyber.diag_search, 0);
		MyProject.Forms.android_db_sjka_cyber.diag_search.Show();
		MyProject.Forms.android_db_sjka_cyber.TextBox13.Focus();
	}

	private void TextBox12_TextChanged(object sender, EventArgs e)
	{
	}

	private void Button13_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Module1.searchMode, "이미지찾기_그룹", TextCompare: false) != 0)
		{
			Module1.searchMode = "이미지찾기_그룹";
			MyProject.Forms.android_db_sjka_cyber.TextBox13.Text = null;
		}
		try
		{
			MyProject.Forms.android_db_sjka_cyber.ListBox13.DataSource = null;
			MyProject.Forms.android_db_sjka_cyber.ListBox13.DataSource = ComboBox2.Items;
			MyProject.Forms.android_db_sjka_cyber.ListBox13.SelectedIndex = ComboBox2.SelectedIndex;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		p_fileManager.Controls.Add(MyProject.Forms.android_db_sjka_cyber.diag_search);
		MyProject.Forms.android_db_sjka_cyber.diag_search.Size = new Size(MyProject.Forms.android_db_sjka_cyber.diag_search.Width, 400);
		Point point = Module1.ControlCenter(p_fileManager, MyProject.Forms.android_db_sjka_cyber.diag_search);
		MyProject.Forms.android_db_sjka_cyber.diag_search.Top = point.X;
		MyProject.Forms.android_db_sjka_cyber.diag_search.Left = point.Y;
		p_fileManager.Controls.SetChildIndex(MyProject.Forms.android_db_sjka_cyber.diag_search, 0);
		MyProject.Forms.android_db_sjka_cyber.diag_search.Show();
		MyProject.Forms.android_db_sjka_cyber.TextBox13.Focus();
	}

	private void Button12_Click(object sender, EventArgs e)
	{
		Button12.Hide();
		Panel15.Show();
		TextBox1.Text = ComboBox2.Text;
		TextBox1.Focus();
	}

	private void Button11_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("그룹 삭제 : " + ComboBox2.Text + "\r\n\r\n그룹을 삭제하면 안에 포함된 이미지들도 일괄 삭제됩니다. 삭제 하시겠습니까?", "그룹 삭제 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
		{
			if (Operators.CompareString(new GetHtmlClass(Module1._dburl + "/set.php", "p=" + MySettingsProperty.Settings.pw + "&t=iGroupDel&g=" + HttpUtility.UrlEncode(ComboBox2.Text)).getHTML(this), "correct", TextCompare: false) == 0)
			{
				CustomMsgBox.CMsgBox("'" + ComboBox2.Text + "' 그룹이 삭제되었습니다.", "저장 완료", "닫기", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true);
				imgList();
				ComboBox2.Text = null;
				ComboBox2.SelectedIndex = 0;
			}
			else
			{
				CustomMsgBox.CMsgBox("'" + ComboBox2.Text + "' 그룹 삭제 실패.", "알 수 없는 오류입니다.", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			}
		}
	}

	private void Button15_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(new GetHtmlClass(Module1._dburl + "/set.php", "p=" + MySettingsProperty.Settings.pw + "&t=iGroupMod&txt=" + Module1.UrlEncode(TextBox1.Text) + "&g=" + HttpUtility.UrlEncode(ComboBox2.Text)).getHTML(this), "correct", TextCompare: false) == 0)
		{
			Panel15.Hide();
			Button12.Show();
			CustomMsgBox.CMsgBox("'" + ComboBox2.Text + "' 그룹 이름이 '" + TextBox1.Text + "' 으로 변경되었습니다.", "저장 완료", "닫기", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true);
			imgList();
		}
		else
		{
			CustomMsgBox.CMsgBox("'" + ComboBox2.Text + "' 그룹이름 변경실패.", "알 수 없는 오류입니다.", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
		}
	}

	private void Button14_Click(object sender, EventArgs e)
	{
		Button12.Show();
		Panel15.Hide();
	}

	private void Button16_Click(object sender, EventArgs e)
	{
	}

	private void Button16_Click_1(object sender, EventArgs e)
	{
		ComboBox2.Text = null;
		imgList();
	}

	private void Button17_Click(object sender, EventArgs e)
	{
		MessageBox.Show("항목 그룹입니다. 그룹(2차) 이름을 기반으로 하여 항목별 그룹(1차)을 자동으로 생성합니다. \r\n\r\n분류 방법 : 그룹 이름의 맨 앞 단어글자와 일치하는 항목을 자동으로 묶어서 분류합니다.\r\n분류결과 그룹이 1개 이하인 경우 자동으로 '기타'로 분류됩니다.\r\n\r\n예) '마이크로 리비어' 그룹 이름에서 공백(스페이스)을 기준으로 그 앞 단어 '마이크로'라는 글자를 포함하는 그룹들을 한꺼번에 묶음", "도움말", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	public bool searchNum()
	{
		string s = search;
		int result = 0;
		string text = ((!int.TryParse(s, out result)) ? search : new GetHtmlClass(Module1._dburl + "/get.php?t=imgGetGroup&d=" + HttpUtility.UrlEncode(search), null, progress: true).getHTML(this));
		if (text == null)
		{
			search = "";
			searchFinish = true;
			return false;
		}
		if (Operators.CompareString(text.Trim(), null, TextCompare: false) != 0)
		{
			MoveUrl(text);
			search = "";
			searchFinish = true;
			return true;
		}
		return false;
	}

	public void FolderRefresh()
	{
		ImageList1.Images.Add(Resources.folder);
		ImageList1.Images.Add(Resources.jpg);
		ImageList1.Images.Add(Resources.png);
		ImageList1.Images.Add(Resources.gif);
		ImageList1.Images.Add(Resources.bmp);
		list = new List<sjka_cyber_imagefolderlist>();
		folderList = new List<sjka_cyber_imagefolder>();
		string hTML = new GetHtmlClass(Module1._dburl + "/get.php?t=imgFolderList", null, progress: true).getHTML(this);
		list = JsonConvert.DeserializeObject<List<sjka_cyber_imagefolderlist>>(hTML);
		url = "";
		folderTitle.Text = "홈";
		nowUrl.Text = "\\";
		listView.Items.Clear();
		TreeView1.Nodes.Clear();
		TreeView1.Nodes.Add("\\");
		foreach (sjka_cyber_imagefolderlist item in list)
		{
			folderList.Add(new sjka_cyber_imagefolder(item.group));
			if (!item.group.Trim().Equals(""))
			{
				PutTreeNode(TreeView1, item.group);
			}
			item.group.Contains(">");
		}
		if ((Operators.CompareString(search, null, TextCompare: false) != 0) & !searchFinish)
		{
			string s = search;
			int result = 0;
			hTML = ((!int.TryParse(s, out result)) ? search : new GetHtmlClass(Module1._dburl + "/get.php?t=imgGetGroup&d=" + HttpUtility.UrlEncode(search), null, progress: true).getHTML(this));
			if (Operators.CompareString(hTML.Trim(), null, TextCompare: false) != 0)
			{
				MoveUrl(hTML);
			}
			search = "";
			searchFinish = true;
		}
		else
		{
			MoveUrl("\\");
		}
	}

	private void PutTreeNode(TreeView tv, string path)
	{
		if (path.IndexOf(">") >= 0)
		{
			string[] array = path.Split(new string[1] { ">" }, StringSplitOptions.None);
			TreeNode treeNode = null;
			string[] array2 = array;
			foreach (string textToFind in array2)
			{
				if (treeNode == null)
				{
					treeNode = SearchTheTreeView(tv, textToFind);
					continue;
				}
				TreeNode treeNode2 = SearchTheTreeView(treeNode, textToFind);
				if (treeNode2 != null)
				{
					treeNode = treeNode2;
				}
				else
				{
					treeNode.Nodes.Add(new TreeNode(textToFind));
				}
			}
		}
		else if (SearchTheTreeView(tv, path) == null)
		{
			tv.Nodes.Add(path);
		}
	}

	private TreeNode SearchTheTreeView(TreeView tv, string TextToFind)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = tv.Nodes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				TreeNode treeNode = (TreeNode)enumerator.Current;
				if (Operators.CompareString(treeNode.Text, TextToFind, TextCompare: false) == 0)
				{
					return treeNode;
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
		return null;
	}

	private TreeNode SearchTheTreeView(TreeNode treeNode, string TextToFind)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = treeNode.Nodes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				TreeNode treeNode2 = (TreeNode)enumerator.Current;
				if (Operators.CompareString(treeNode2.Text, TextToFind, TextCompare: false) == 0)
				{
					return treeNode2;
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
		return null;
	}

	private void listView_ItemDrag(object sender, ItemDragEventArgs e)
	{
	}

	private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && !MoveUrl())
		{
			Button22_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private bool MoveUrl(string findURL = null, bool prev = false)
	{
		_Closure_0024__531_002D0 arg = default(_Closure_0024__531_002D0);
		_Closure_0024__531_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__531_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL = findURL;
		sjka_cyber_imagefolder sjka_cyber_imagefolder2 = null;
		string key = url;
		if (!prev)
		{
			try
			{
				lvSelectedLocation = listView.SelectedIndices[0];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL, null, TextCompare: false) == 0)
			{
				sjka_cyber_imagefolder2 = folderList.Find((sjka_cyber_imagefolder index) => index.url.Equals(listView.SelectedItems[0].Name) ? true : false);
			}
		}
		else
		{
			if (url.IndexOf(">") <= 0)
			{
				MoveUrl("\\");
				folderTitle.Text = "홈";
				try
				{
					ListViewItem listViewItem = listView.Items[0];
					listViewItem.Selected = false;
					listViewItem.Focused = false;
					listViewItem = listView.Items.Find(key, searchAllSubItems: false)[0];
					listView.FocusedItem = listViewItem;
					listViewItem.Selected = true;
					listViewItem.Focused = true;
					listViewItem.EnsureVisible();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				return true;
			}
			sjka_cyber_imagefolder2 = folderList.Find((sjka_cyber_imagefolder index) => index.url.Equals(url.Substring(0, url.LastIndexOf(">"))) ? true : false);
		}
		if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL, null, TextCompare: false) != 0)
		{
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL.IndexOf("\\") == 0)
			{
				CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL = CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL.Substring(1);
			}
			CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL = CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL.Replace("\\", ">");
			if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL, null, TextCompare: false) == 0)
			{
				folderTitle.Text = "홈";
			}
			sjka_cyber_imagefolder2 = folderList.Find((sjka_cyber_imagefolder index) => index.url.Equals(CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL) ? true : false);
			if (sjka_cyber_imagefolder2 == null)
			{
				CustomMsgBox.CMsgBox(CS_0024_003C_003E8__locals0._0024VB_0024Local_findURL + " 경로를 찾을 수 없습니다.", "이동 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				return false;
			}
		}
		checked
		{
			if (sjka_cyber_imagefolder2 != null)
			{
				url = sjka_cyber_imagefolder2.url;
				sjka_cyber_imagefolder2.Initialization();
				nowFolder = sjka_cyber_imagefolder2;
				if (sjka_cyber_imagefolder2.url.IndexOf(">") > 0)
				{
					folderTitle.Text = sjka_cyber_imagefolder2.url.Substring(sjka_cyber_imagefolder2.url.LastIndexOf(">") + 1);
				}
				else
				{
					folderTitle.Text = sjka_cyber_imagefolder2.url;
				}
				if (Operators.CompareString(url, null, TextCompare: false) == 0)
				{
					folderTitle.Text = "홈";
				}
				listView.Items.Clear();
				foreach (sjka_cyber_imagefolder folder in folderList)
				{
					if (folder.url.Equals(""))
					{
						continue;
					}
					if (folder.url.IndexOf(">") > 0)
					{
						if (folder.url.Substring(0, folder.url.LastIndexOf(">")).Equals(url))
						{
							listView.Items.Add(folder.url, folder.url.Substring(folder.url.LastIndexOf(">") + 1), 0);
						}
					}
					else if ((folder.url.IndexOf(">") < 0) & url.Equals(""))
					{
						listView.Items.Add(folder.url, folder.url.Substring(folder.url.LastIndexOf(">") + 1), 0);
					}
				}
				foreach (sjka_cyber_imagefolder.sjka_cyber_imageobject item in sjka_cyber_imagefolder2.list)
				{
					int imageIndex = 0;
					switch (item.name.Substring(item.name.LastIndexOf(".") + 1).ToLower())
					{
					case "jpg":
						imageIndex = 1;
						break;
					case "png":
						imageIndex = 2;
						break;
					case "gif":
						imageIndex = 3;
						break;
					case "bmp":
						imageIndex = 4;
						break;
					}
					listView.Items.Add(item.num.ToString(), item.name.Substring(0, item.name.LastIndexOf(".")), imageIndex);
				}
				if (prev)
				{
					ListViewItem listViewItem2 = listView.Items.Find(key, searchAllSubItems: false)[0];
					listView.FocusedItem = listViewItem2;
					listViewItem2.Selected = true;
					listViewItem2.Focused = true;
					listViewItem2.EnsureVisible();
				}
				else
				{
					listView.Focus();
					try
					{
						if ((Operators.CompareString(search, null, TextCompare: false) != 0) & !searchFinish)
						{
							ListViewItem[] array = listView.Items.Find(search, searchAllSubItems: false);
							ListViewItem listViewItem3 = listView.Items[0];
							if (array.Length <= 0)
							{
								IEnumerator enumerator3 = default(IEnumerator);
								try
								{
									enumerator3 = listView.Items.GetEnumerator();
									while (enumerator3.MoveNext())
									{
										ListViewItem listViewItem4 = (ListViewItem)enumerator3.Current;
										if (listViewItem4.SubItems[0].Text.Equals(search))
										{
											listViewItem3 = listViewItem4;
											break;
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
							}
							else
							{
								listViewItem3 = array[0];
							}
							listView.FocusedItem = listViewItem3;
							listViewItem3.Selected = true;
							listViewItem3.Focused = true;
							listViewItem3.EnsureVisible();
							search = "";
							searchFinish = true;
						}
						else
						{
							ListViewItem listViewItem5 = listView.Items[0];
							listView.FocusedItem = listViewItem5;
							listViewItem5.Selected = true;
							listViewItem5.Focused = true;
							listViewItem5.EnsureVisible();
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						search = "";
						searchFinish = true;
						ProjectData.ClearProjectError();
					}
				}
				if (!getDetail())
				{
					SplitContainer3.Panel2Collapsed = true;
				}
				else
				{
					SplitContainer3.Panel2Collapsed = false;
				}
				TreeNode treeNode = TreeViewFindURL(url.Replace(">", "\\"));
				if (treeNode != null)
				{
					TreeView1.SelectedNode = treeNode;
					treeNode.Expand();
				}
				nowUrl.Text = "\\" + url.Replace(">", "\\");
				return true;
			}
			return false;
		}
	}

	private void listView_AfterLabelEdit(object sender, LabelEditEventArgs e)
	{
		if (Operators.CompareString(e.Label, null, TextCompare: false) == 0)
		{
			e.CancelEdit = true;
		}
		else if (Operators.CompareString(e.Label.Trim(), null, TextCompare: false) != 0)
		{
			string text = e.Label.Trim();
			if ((text.IndexOf("\\") >= 0) | (text.IndexOf("/") >= 0) | (text.IndexOf(":") >= 0) | (text.IndexOf("*") >= 0) | (text.IndexOf("?") >= 0) | (text.IndexOf('"') >= 0) | (text.IndexOf("<") >= 0) | (text.IndexOf(">") >= 0) | (text.IndexOf("|") >= 0))
			{
				e.CancelEdit = true;
				CustomMsgBox.CMsgBox("파일 이름에는 다음 문자를 사용할 수 없습니다.\r\n\\ / : * ? \" < > |", "이름변경 실패", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				return;
			}
			if (findFolder(Conversions.ToString(Operators.ConcatenateObject(Interaction.IIf(Operators.CompareString(url, "", TextCompare: false) == 0, "", url + ">"), text))) == null)
			{
				try
				{
					sjka_cyber_imagefolder.sjka_cyber_imageobject sjka_cyber_imageobject = nowFolder.list.Find((sjka_cyber_imagefolder.sjka_cyber_imageobject obj) => (((double)obj.num == Conversion.Val(listView.SelectedItems[0].Name)) & (obj.folder == 0)) ? true : false);
					if (sjka_cyber_imageobject == null)
					{
						sjka_cyber_imagefolder sjka_cyber_imagefolder2 = folderList.Find((sjka_cyber_imagefolder obj) => obj.url.Equals(listView.SelectedItems[0].Name) ? true : false);
						if (sjka_cyber_imagefolder2 == null)
						{
							return;
						}
						string text2 = ((sjka_cyber_imagefolder2.url.IndexOf(">") >= 0) ? (sjka_cyber_imagefolder2.url.Substring(0, checked(sjka_cyber_imagefolder2.url.LastIndexOf(">") + 1)) + e.Label.Trim()) : e.Label.Trim());
						new GetHtmlClass(Module1._dburl + "/set.php?t=imageDirMove", "p=" + MySettingsProperty.Settings.pw + "&g=" + HttpUtility.UrlEncode(sjka_cyber_imagefolder2.url) + "&nm=" + HttpUtility.UrlEncode(text2), progress: true).getHTML(this);
						sjka_cyber_imagefolder2.init = false;
						TreeNode treeNode = TreeViewFindURL(sjka_cyber_imagefolder2.url.Replace(">", "\\"));
						if (treeNode != null)
						{
							treeNode.Text = e.Label.Trim();
						}
						if (Operators.CompareString(url, "", TextCompare: false) != 0)
						{
							folderUrlFindReplace(sjka_cyber_imagefolder2.url + ">", text2 + ">");
							sjka_cyber_imagefolder2.url = text2;
							listView.SelectedItems[0].Name = text2;
						}
						if (Operators.CompareString(url, "", TextCompare: false) == 0)
						{
							FolderRefresh();
						}
						try
						{
							ListViewItem listViewItem = listView.Items[0];
							listViewItem.Selected = false;
							listViewItem.Focused = false;
							listViewItem = listView.Items.Find(text2, searchAllSubItems: false)[0];
							listView.FocusedItem = listViewItem;
							listViewItem.Selected = true;
							listViewItem.Focused = true;
							listViewItem.EnsureVisible();
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
					new GetHtmlClass(Module1._dburl + "/set.php?t=imageFileRename", "p=" + MySettingsProperty.Settings.pw + "&n=" + Conversions.ToString(sjka_cyber_imageobject.num) + "&nm=" + HttpUtility.UrlEncode(e.Label.Trim() + sjka_cyber_imageobject.name.Substring(sjka_cyber_imageobject.name.IndexOf("."))), progress: true).getHTML(this);
					sjka_cyber_imageobject.parent.init = false;
					if (Operators.CompareString(url, "", TextCompare: false) == 0)
					{
						FolderRefresh();
					}
					else
					{
						sjka_cyber_imageobject.parent.Initialization();
					}
					try
					{
						ListViewItem listViewItem2 = listView.Items[0];
						listViewItem2.Selected = false;
						listViewItem2.Focused = false;
						listViewItem2 = listView.Items.Find(Conversions.ToString(sjka_cyber_imageobject.num), searchAllSubItems: false)[0];
						listView.FocusedItem = listViewItem2;
						listViewItem2.Selected = true;
						listViewItem2.Focused = true;
						listViewItem2.EnsureVisible();
						return;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
						return;
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.ClearProjectError();
					return;
				}
			}
			e.CancelEdit = true;
			CustomMsgBox.CMsgBox("폴더 이름이 중복됩니다.", "이름변경 실패", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
		}
		else
		{
			e.CancelEdit = true;
		}
	}

	private void Button29_Click(object sender, EventArgs e)
	{
		FolderRefresh();
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		MoveUrl(null, prev: true);
	}

	private void nowUrl_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			try
			{
				MoveUrl(nowUrl.Text.Trim());
				listView.Focus();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void listView_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.U:
			if (e.Control)
			{
				파일업로드ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			break;
		case Keys.A:
			if (e.Control)
			{
				전체선택ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			break;
		case Keys.X:
			if (e.Control)
			{
				이동ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			break;
		case Keys.V:
			if (e.Control)
			{
				붙여넣기ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			break;
		case Keys.F2:
			try
			{
				listView.SelectedItems[0].BeginEdit();
				break;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
				break;
			}
		case Keys.Return:
			try
			{
				MoveUrl();
				break;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
				break;
			}
		case Keys.Delete:
			try
			{
				삭제ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
				break;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				break;
			}
		case Keys.Back:
			MoveUrl(null, prev: true);
			break;
		}
	}

	private void listView_KeyUp(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Right:
			getDetail();
			break;
		case Keys.Left:
			getDetail();
			break;
		case Keys.Up:
			getDetail();
			break;
		case Keys.Down:
			getDetail();
			break;
		}
	}

	private void listView_DragEnter(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			e.Effect = DragDropEffects.Copy;
		}
		else
		{
			e.Effect = DragDropEffects.None;
		}
	}

	private void Button32_Click(object sender, EventArgs e)
	{
	}

	private void Button31_Click(object sender, EventArgs e)
	{
	}

	private void listView_MouseClick(object sender, MouseEventArgs e)
	{
		if (!getDetail())
		{
			SplitContainer3.Panel2Collapsed = true;
		}
	}

	private bool getDetail()
	{
		_ = listView.CheckedItems;
		try
		{
			sjka_cyber_imagefolder.sjka_cyber_imageobject sjka_cyber_imageobject = nowFolder.list.Find((sjka_cyber_imagefolder.sjka_cyber_imageobject obj) => (((double)obj.num == Conversion.Val(listView.SelectedItems[0].Name)) & (obj.folder == 0)) ? true : false);
			if (sjka_cyber_imageobject == null)
			{
				Button22.Visible = false;
				return false;
			}
			Button22.Visible = true;
			nowSelecedFile = sjka_cyber_imageobject;
			if (sjka_cyber_imageobject.blob != null)
			{
				preview.Image = sjka_cyber_imageobject.blob;
				preview.Tag = sjka_cyber_imageobject.name;
				descript.Text = "번호: " + Conversions.ToString(sjka_cyber_imageobject.num) + "\r\n이름: " + sjka_cyber_imageobject.name + "\r\n사진 크기: " + Conversions.ToString(preview.Image.Size.Width) + "x" + Conversions.ToString(preview.Image.Size.Height) + "\r\n크기: " + sjka_cyber_imageobject.imageSize + " (" + sjka_cyber_imageobject.imageAlert + ")";
				SplitContainer3.Panel2Collapsed = false;
				return true;
			}
			string text = null;
			try
			{
				text = new GetHtmlClass(Module1._dburl + "/get.php?t=imgBlobD&n=" + listView.SelectedItems[0].Name).getHTML(this).Trim();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (text == null)
			{
				return false;
			}
			byte[] buffer = Convert.FromBase64String(text);
			MemoryStream memoryStream = new MemoryStream(buffer);
			sjka_cyber_imageobject.blob = (Bitmap)Image.FromStream(memoryStream);
			preview.Image = sjka_cyber_imageobject.blob;
			preview.Tag = sjka_cyber_imageobject.name;
			string imageAlert = "알 수 없음";
			double num = (double)memoryStream.Length / 1024.0;
			if (num >= 300.0)
			{
				imageAlert = "경고! 아주 높음";
			}
			else if (num >= 200.0 && num <= 300.0)
			{
				imageAlert = "매우 높음";
			}
			else if (num >= 175.0 && num <= 200.0)
			{
				imageAlert = "높음";
			}
			else if (num >= 150.0 && num <= 175.0)
			{
				imageAlert = "조금 높음";
			}
			else if (num >= 75.0 && num <= 150.0)
			{
				imageAlert = "적당함";
			}
			else if (num >= 50.0 && num <= 75.0)
			{
				imageAlert = "조금 낮음";
			}
			else if (num >= 25.0 && num <= 50.0)
			{
				imageAlert = "낮음";
			}
			else if (num >= 0.0 && num <= 25.0)
			{
				imageAlert = "매우 낮음";
			}
			sjka_cyber_imageobject.imageSize = GetFileSize(memoryStream.Length);
			sjka_cyber_imageobject.imageAlert = imageAlert;
			descript.Text = "번호: " + Conversions.ToString(sjka_cyber_imageobject.num) + "\r\n이름: " + sjka_cyber_imageobject.name + "\r\n사진 크기: " + Conversions.ToString(preview.Image.Size.Width) + "x" + Conversions.ToString(preview.Image.Size.Height) + "\r\n크기: " + sjka_cyber_imageobject.imageSize + " (" + sjka_cyber_imageobject.imageAlert + ")";
			SplitContainer3.Panel2Collapsed = false;
			return true;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Console.WriteLine(ex4.Message);
			GC.Collect();
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void Button21_Click(object sender, EventArgs e)
	{
		searchFinish = false;
		search = url;
		FolderRefresh();
	}

	private void Button22_Click(object sender, EventArgs e)
	{
		if (nowSelecedFile == null)
		{
			return;
		}
		string project = Module1.project;
		checked
		{
			if (Operators.CompareString(project, "android_db_sjka_cyber", TextCompare: false) == 0)
			{
				object left = NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null);
				if (Operators.ConditionalCompareObjectEqual(left, MyProject.Forms.android_db_sjka_cyber.tag_id.Name, TextCompare: false))
				{
					NewLateBinding.LateSet(target, null, "text", new object[1] { nowSelecedFile.num }, null, null);
					MyProject.Forms.android_db_sjka_cyber.tag_id_KeyUp(RuntimeHelpers.GetObjectValue(sender), new KeyEventArgs(Keys.A));
				}
				else if (Operators.ConditionalCompareObjectEqual(left, MyProject.Forms.android_db_sjka_cyber.RichTextbox1.Name, TextCompare: false))
				{
					int num = ((mlas_root.CRT.CustomRichTextbox)target).SelectionStart;
					string text = "<img id=" + Conversions.ToString(nowSelecedFile.num) + " width=100% height=auto>";
					object instance = target;
					object[] array = new object[1];
					object instance2 = NewLateBinding.LateGet(target, null, "Text", new object[0], null, null, null);
					object[] obj = new object[2] { num, text };
					object[] array2 = obj;
					bool[] obj2 = new bool[2] { true, true };
					bool[] array3 = obj2;
					object obj3 = NewLateBinding.LateGet(instance2, null, "Insert", obj, null, null, obj2);
					if (array3[0])
					{
						num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
					}
					if (array3[1])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
					}
					array[0] = obj3;
					NewLateBinding.LateSet(instance, null, "Text", array, null, null);
					NewLateBinding.LateSet(target, null, "SelectionStart", new object[1] { num + text.Length }, null, null);
				}
				else if (Operators.ConditionalCompareObjectEqual(left, MyProject.Forms.android_db_sjka_cyber.TextBox34.Name, TextCompare: false))
				{
					TextBox textBox = (TextBox)target;
					int num2 = textBox.SelectionStart;
					bool flag = true;
					try
					{
						int num3 = textBox.Text.Substring(num2).IndexOf(">");
						int num4 = textBox.Text.Substring(num2).IndexOf("<");
						flag = ((num3 <= num4) ? true : false);
						flag = ((!unchecked(num3 == -1 && num4 == -1)) ? true : false);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					int num5 = -1;
					if (flag)
					{
						try
						{
							num5 = textBox.Text.Substring(0, num2).LastIndexOf("<");
							if (num5 > -1)
							{
								flag = true;
							}
							else
							{
								flag = false;
							}
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							flag = false;
							ProjectData.ClearProjectError();
						}
						try
						{
							flag = ((Operators.CompareString(textBox.Text.Substring(num5, textBox.Text.Substring(num5).IndexOf("=")).Trim(), "<img id", TextCompare: false) == 0) ? true : false);
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							flag = false;
							ProjectData.ClearProjectError();
						}
					}
					if (flag)
					{
						textBox.Text = textBox.Text.Replace(textBox.Text.Substring(num5 + 8, textBox.Text.Substring(num5 + 8).IndexOf(" ")), Conversions.ToString(nowSelecedFile.num));
						NewLateBinding.LateSet(target, null, "SelectionStart", new object[1] { num5 + 8 + nowSelecedFile.num.ToString().Length }, null, null);
					}
					else
					{
						string text2 = "<img id=" + Conversions.ToString(nowSelecedFile.num) + " width=100% height=auto>";
						object instance3 = target;
						object[] array4 = new object[1];
						object instance4 = NewLateBinding.LateGet(target, null, "Text", new object[0], null, null, null);
						object[] obj4 = new object[2] { num2, text2 };
						object[] array2 = obj4;
						bool[] obj5 = new bool[2] { true, true };
						bool[] array3 = obj5;
						object obj6 = NewLateBinding.LateGet(instance4, null, "Insert", obj4, null, null, obj5);
						if (array3[0])
						{
							num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
						}
						if (array3[1])
						{
							text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
						}
						array4[0] = obj6;
						NewLateBinding.LateSet(instance3, null, "Text", array4, null, null);
						NewLateBinding.LateSet(target, null, "SelectionStart", new object[1] { num2 + text2.Length }, null, null);
					}
				}
				else if ((NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.e1.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.h1.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.n1.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.n2.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.n3.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.n4.Name) | (NewLateBinding.LateGet(target, null, "Name", new object[0], null, null, null) == MyProject.Forms.android_db_sjka_cyber.n5.Name))
				{
					TextBox textBox2 = (TextBox)target;
					int num6 = textBox2.SelectionStart;
					bool flag2 = true;
					try
					{
						int num7 = textBox2.Text.Substring(num6).IndexOf(">");
						int num8 = textBox2.Text.Substring(num6).IndexOf("<");
						flag2 = ((num7 <= num8) ? true : false);
						flag2 = ((!unchecked(num7 == -1 && num8 == -1)) ? true : false);
					}
					catch (Exception ex7)
					{
						ProjectData.SetProjectError(ex7);
						Exception ex8 = ex7;
						ProjectData.ClearProjectError();
					}
					int num9 = -1;
					if (flag2)
					{
						try
						{
							num9 = textBox2.Text.Substring(0, num6).LastIndexOf("<");
							if (num9 > -1)
							{
								flag2 = true;
							}
							else
							{
								flag2 = false;
							}
						}
						catch (Exception ex9)
						{
							ProjectData.SetProjectError(ex9);
							Exception ex10 = ex9;
							flag2 = false;
							ProjectData.ClearProjectError();
						}
						try
						{
							flag2 = ((Operators.CompareString(textBox2.Text.Substring(num9, textBox2.Text.Substring(num9).IndexOf("=")).Trim(), "<img id", TextCompare: false) == 0) ? true : false);
						}
						catch (Exception ex11)
						{
							ProjectData.SetProjectError(ex11);
							Exception ex12 = ex11;
							flag2 = false;
							ProjectData.ClearProjectError();
						}
					}
					if (flag2)
					{
						textBox2.Text = textBox2.Text.Replace(textBox2.Text.Substring(num9 + 8, textBox2.Text.Substring(num9 + 8).IndexOf(" ")), Conversions.ToString(nowSelecedFile.num));
						NewLateBinding.LateSet(target, null, "SelectionStart", new object[1] { num9 + 8 + nowSelecedFile.num.ToString().Length }, null, null);
					}
					else
					{
						string text3 = "<img id=" + Conversions.ToString(nowSelecedFile.num) + " width=100% height=auto>";
						object instance5 = target;
						object[] array5 = new object[1];
						object instance6 = NewLateBinding.LateGet(target, null, "Text", new object[0], null, null, null);
						object[] obj7 = new object[2] { num6, text3 };
						object[] array2 = obj7;
						bool[] obj8 = new bool[2] { true, true };
						bool[] array3 = obj8;
						object obj9 = NewLateBinding.LateGet(instance6, null, "Insert", obj7, null, null, obj8);
						if (array3[0])
						{
							num6 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(int));
						}
						if (array3[1])
						{
							text3 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string));
						}
						array5[0] = obj9;
						NewLateBinding.LateSet(instance5, null, "Text", array5, null, null);
						NewLateBinding.LateSet(target, null, "SelectionStart", new object[1] { num6 + text3.Length }, null, null);
					}
				}
				else
				{
					NewLateBinding.LateSet(target, null, "text", new object[1] { nowSelecedFile.num }, null, null);
				}
			}
			parentObject.Visible = true;
			base.Visible = false;
			NewLateBinding.LateCall(target, null, "Focus", new object[0], null, null, null, IgnoreReturn: true);
		}
	}

	private void Button23_Click(object sender, EventArgs e)
	{
		parentObject.Visible = true;
		base.Visible = false;
		try
		{
			imgViewForm.Hide();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			searchForm.Hide();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		NewLateBinding.LateCall(target, null, "Focus", new object[0], null, null, null, IgnoreReturn: true);
	}

	private string newFolder()
	{
		int num = 1;
		string text = Conversions.ToString(Interaction.IIf(Operators.CompareString(url, "", TextCompare: false) == 0, "새 폴더", url + ">새 폴더"));
		string text2 = text;
		checked
		{
			int num2 = folderList.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (folderList[i].url.Equals(text2))
				{
					num++;
					text2 = text + " (" + num + ")";
					i = 0;
				}
			}
			folderList.Add(new sjka_cyber_imagefolder(text2));
			return text2;
		}
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
		string text = newFolder();
		new GetHtmlClass(Module1._dburl + "/set.php?t=imageNewFolder", "p=" + MySettingsProperty.Settings.pw + "&nm=" + HttpUtility.UrlEncode(text), progress: true).getHTML(this);
		if (Operators.CompareString(url, "", TextCompare: false) == 0)
		{
			FolderRefresh();
		}
		else
		{
			nowFolder.init = false;
			MoveUrl(nowFolder.url);
		}
		TreeViewFindURL(nowFolder.url.Replace(">", "\\"))?.Nodes.Add(new TreeNode(text.Substring(checked(text.LastIndexOf(">") + 1))));
		try
		{
			ListViewItem listViewItem = listView.Items[0];
			listViewItem.Selected = false;
			listViewItem.Focused = false;
			listViewItem = listView.Items.Find(text, searchAllSubItems: false)[0];
			listView.FocusedItem = listViewItem;
			listViewItem.Selected = true;
			listViewItem.Focused = true;
			listViewItem.EnsureVisible();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void 새폴더ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		PictureBox4_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void 이동ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listView.SelectedItems.Count <= 0)
		{
			return;
		}
		moveItems.Clear();
		moveFolder.Clear();
		List<sjka_cyber_imagefolder.sjka_cyber_imageobject> list = nowFolder.list;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = listView.SelectedItems.GetEnumerator();
			_Closure_0024__552_002D0 closure_0024__552_002D = default(_Closure_0024__552_002D0);
			while (enumerator.MoveNext())
			{
				closure_0024__552_002D = new _Closure_0024__552_002D0(closure_0024__552_002D);
				closure_0024__552_002D._0024VB_0024Local_a = (ListViewItem)enumerator.Current;
				closure_0024__552_002D._0024VB_0024Local_a.BackColor = Color.LightGray;
				sjka_cyber_imagefolder.sjka_cyber_imageobject sjka_cyber_imageobject = list.Find(closure_0024__552_002D._Lambda_0024__0);
				if (sjka_cyber_imageobject == null)
				{
					sjka_cyber_imagefolder item = folderList.Find(closure_0024__552_002D._Lambda_0024__1);
					moveFolder.Add(item);
				}
				else
				{
					moveItems.Add(sjka_cyber_imageobject);
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
	}

	private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if ((moveItems.Count <= 0) & (moveFolder.Count <= 0))
		{
			return;
		}
		foreach (sjka_cyber_imagefolder.sjka_cyber_imageobject moveItem in moveItems)
		{
			moveItem.parent.init = false;
			if (Operators.CompareString(new GetHtmlClass(Module1._dburl + "/set.php?t=imageFileMove", "p=" + MySettingsProperty.Settings.pw + "&n=" + Conversions.ToString(moveItem.num) + "&nm=" + HttpUtility.UrlEncode(url), progress: true).getHTML(this), "correct", TextCompare: false) != 0)
			{
				CustomMsgBox.CMsgBox(moveItem.name + " 파일을 이동하는 중에 오류가 발생했습니다.\r\n작업이 중단 됩니다.", "파일 이동 오류!", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				if (Operators.CompareString(url, "", TextCompare: false) == 0)
				{
					FolderRefresh();
					return;
				}
				nowFolder.init = false;
				MoveUrl(nowFolder.url);
				return;
			}
		}
		checked
		{
			foreach (sjka_cyber_imagefolder item in moveFolder)
			{
				item.init = false;
				string text = "";
				if (Operators.CompareString(new GetHtmlClass(PostData: (Operators.CompareString(url, "", TextCompare: false) == 0) ? ("p=" + MySettingsProperty.Settings.pw + "&g=" + HttpUtility.UrlEncode(item.url) + "&nm=" + HttpUtility.UrlEncode(item.url.Substring(item.url.LastIndexOf(">") + 1))) : ("p=" + MySettingsProperty.Settings.pw + "&g=" + HttpUtility.UrlEncode(item.url) + "&nm=" + HttpUtility.UrlEncode(url + ">" + item.url.Substring(item.url.LastIndexOf(">") + 1))), url: Module1._dburl + "/set.php?t=imageDirMove", progress: true).getHTML(this), "correct", TextCompare: false) != 0)
				{
					CustomMsgBox.CMsgBox(item.url.Substring(item.url.LastIndexOf(">") + 1) + " 폴더를 이동하는 중에 오류가 발생했습니다.\r\n작업이 중단 됩니다.", "파일 이동 오류!", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					if (Operators.CompareString(url, "", TextCompare: false) == 0)
					{
						FolderRefresh();
						return;
					}
					nowFolder.init = false;
					MoveUrl(nowFolder.url);
					return;
				}
				if (Operators.CompareString(url, "", TextCompare: false) != 0)
				{
					folderUrlFindReplace(item.url + ">", url + ">" + item.url.Substring(item.url.LastIndexOf(">") + 1) + ">");
					item.url = url + ">" + item.url.Substring(item.url.LastIndexOf(">") + 1);
				}
			}
			TreeView1.Nodes.Clear();
			TreeView1.Nodes.Add("\\");
			foreach (sjka_cyber_imagefolder folder in folderList)
			{
				if (!folder.url.Trim().Equals(""))
				{
					PutTreeNode(TreeView1, folder.url);
				}
			}
			TreeNode treeNode = TreeViewFindURL(url.Replace(">", "\\"));
			if (treeNode != null)
			{
				TreeView1.SelectedNode = treeNode;
			}
			moveItems.Clear();
			moveFolder.Clear();
			if (Operators.CompareString(url, "", TextCompare: false) == 0)
			{
				FolderRefresh();
				return;
			}
			nowFolder.init = false;
			MoveUrl(nowFolder.url);
		}
	}

	private sjka_cyber_imagefolder findFolder(string url)
	{
		foreach (sjka_cyber_imagefolder folder in folderList)
		{
			if (folder.url.Equals(url))
			{
				return folder;
			}
		}
		return null;
	}

	private void folderUrlFindReplace(string find, string replace)
	{
		foreach (sjka_cyber_imagefolder folder in folderList)
		{
			if (folder.url.Contains(find))
			{
				folder.url = folder.url.Replace(find, replace);
			}
		}
	}

	private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (listView.SelectedItems.Count <= 0)
		{
			return;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = listView.SelectedItems.GetEnumerator();
			_Closure_0024__556_002D0 closure_0024__556_002D = default(_Closure_0024__556_002D0);
			while (enumerator.MoveNext())
			{
				closure_0024__556_002D = new _Closure_0024__556_002D0(closure_0024__556_002D);
				closure_0024__556_002D._0024VB_0024Local_lvItem = (ListViewItem)enumerator.Current;
				sjka_cyber_imagefolder.sjka_cyber_imageobject sjka_cyber_imageobject = nowFolder.list.Find(closure_0024__556_002D._Lambda_0024__0);
				if (sjka_cyber_imageobject == null)
				{
					sjka_cyber_imagefolder sjka_cyber_imagefolder2 = folderList.Find(closure_0024__556_002D._Lambda_0024__1);
					if (MessageBox.Show("이 폴더를 완전히 삭제하시겠습니까? 폴더 안에 있는 모든 항목은 영구 삭제됩니다.\r\n\r\n\\" + sjka_cyber_imagefolder2.url.Replace(">", "\\"), "폴더 삭제 주의", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
					{
						continue;
					}
					if (sjka_cyber_imagefolder2 == null)
					{
						return;
					}
					if (Operators.CompareString(new GetHtmlClass(Module1._dburl + "/set.php?t=imageDelFolder", "p=" + MySettingsProperty.Settings.pw + "&g=" + HttpUtility.UrlEncode(sjka_cyber_imagefolder2.url), progress: true).getHTML(this), "correct", TextCompare: false) != 0)
					{
						CustomMsgBox.CMsgBox(sjka_cyber_imagefolder2.getName() + " 폴더 삭제 중에 오류가 발생했습니다.\r\n작업이 중단 됩니다.", "삭제 실패", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
						if (Operators.CompareString(url, "", TextCompare: false) == 0)
						{
							FolderRefresh();
							return;
						}
						nowFolder.init = false;
						MoveUrl(nowFolder.url);
						return;
					}
					folderList.Remove(sjka_cyber_imagefolder2);
					TreeNode treeNode = TreeViewFindURL(sjka_cyber_imagefolder2.url.Replace(">", "\\"));
					if (treeNode != null)
					{
						TreeView1.Nodes.Remove(treeNode);
					}
					List<sjka_cyber_imagefolder> list = new List<sjka_cyber_imagefolder>();
					foreach (sjka_cyber_imagefolder folder in folderList)
					{
						if (folder.url.IndexOf(sjka_cyber_imagefolder2.url + ">") == 0)
						{
							list.Add(folder);
						}
					}
					foreach (sjka_cyber_imagefolder item in list)
					{
						folderList.Remove(item);
					}
				}
				else if (MessageBox.Show("이 파일을 완전히 삭제하시겠습니까?\r\n\r\n번호: " + Conversions.ToString(sjka_cyber_imageobject.num) + "\r\n" + sjka_cyber_imageobject.name, "파일 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.No && Operators.CompareString(new GetHtmlClass(Module1._dburl + "/set.php?t=imgDel", "p=" + MySettingsProperty.Settings.pw + "&n=" + Conversions.ToString(sjka_cyber_imageobject.num), progress: true).getHTML(this), "correct", TextCompare: false) != 0)
				{
					CustomMsgBox.CMsgBox(sjka_cyber_imageobject.name + " 파일 삭제 중에 오류가 발생했습니다.", "삭제 실패", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					if (Operators.CompareString(url, "", TextCompare: false) == 0)
					{
						FolderRefresh();
						continue;
					}
					nowFolder.init = false;
					MoveUrl(nowFolder.url);
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
		SplitContainer3.Panel2Collapsed = true;
		if (Operators.CompareString(url, "", TextCompare: false) == 0)
		{
			FolderRefresh();
			return;
		}
		nowFolder.init = false;
		MoveUrl(nowFolder.url);
	}

	private TreeNode TreeViewFindURL(string url)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = TreeView1.Nodes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				TreeNode treeNode = (TreeNode)enumerator.Current;
				if (treeNode.FullPath.Equals(url))
				{
					return treeNode;
				}
				TreeNode treeNode2 = RecursiveSearch(treeNode, url);
				if (treeNode2 != null)
				{
					return treeNode2;
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
		return null;
	}

	private TreeNode RecursiveSearch(TreeNode treeNode, string url)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = treeNode.Nodes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				TreeNode treeNode2 = (TreeNode)enumerator.Current;
				if (Operators.CompareString(treeNode2.FullPath, url, TextCompare: false) == 0)
				{
					return treeNode2;
				}
				TreeNode treeNode3 = RecursiveSearch(treeNode2, url);
				if (treeNode3 != null)
				{
					return treeNode3;
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
		return null;
	}

	private void listView_MouseUp(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Right)
		{
			return;
		}
		if (listView.SelectedItems.Count > 0)
		{
			새폴더ToolStripMenuItem.Visible = false;
			파일업로드ToolStripMenuItem.Visible = false;
			ToolStripSeparator2.Visible = false;
			이름변경ToolStripMenuItem.Visible = true;
			이동ToolStripMenuItem.Visible = true;
			붙여넣기ToolStripMenuItem.Visible = false;
			ToolStripSeparator1.Visible = true;
			삭제ToolStripMenuItem.Visible = true;
			return;
		}
		새폴더ToolStripMenuItem.Visible = true;
		파일업로드ToolStripMenuItem.Visible = true;
		ToolStripSeparator2.Visible = true;
		이름변경ToolStripMenuItem.Visible = false;
		이동ToolStripMenuItem.Visible = false;
		붙여넣기ToolStripMenuItem.Visible = true;
		ToolStripSeparator1.Visible = false;
		삭제ToolStripMenuItem.Visible = false;
		if ((moveItems.Count > 0) | (moveFolder.Count > 0))
		{
			붙여넣기ToolStripMenuItem.Enabled = true;
		}
		else
		{
			붙여넣기ToolStripMenuItem.Enabled = false;
		}
	}

	private void 이름변경ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		listView.SelectedItems[0].BeginEdit();
	}

	private void listView_DragDrop(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			try
			{
				upload((string[])e.Data.GetData(DataFormats.FileDrop));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				CustomMsgBox.CMsgBox("업로드 할 수 없습니다. " + ex2.Message, "업로드 실패", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		CustomMsgBox.CMsgBox("여러 파일을 한꺼번에 업로드 할 수 있습니다.\r\n또한 파일을 드래그 앤 드롭하면 바로 업로드 할 수 있습니다.", "안내", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight);
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Multiselect = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			try
			{
				upload(openFileDialog.FileNames);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				CustomMsgBox.CMsgBox("업로드 할 수 없습니다. " + ex2.Message, "업로드 실패", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				ProjectData.ClearProjectError();
			}
		}
		openFileDialog = null;
	}

	private void upload(string[] files)
	{
		checked
		{
			foreach (string text in files)
			{
				ImageFormat imageFormat = null;
				switch (text.Substring(text.LastIndexOf(".") + 1).ToLower())
				{
				case "png":
					imageFormat = ImageFormat.Png;
					break;
				case "jpg":
					imageFormat = ImageFormat.Jpeg;
					break;
				case "gif":
					imageFormat = ImageFormat.Gif;
					break;
				case "bmp":
					imageFormat = ImageFormat.Bmp;
					break;
				default:
					CustomMsgBox.CMsgBox(text + " 이미지 파일만 업로드 가능합니다.", "업로드 실패", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					continue;
				}
				string str = Module1.ImageToBase64(text, imageFormat);
				if (Operators.CompareString(new GetHtmlClass(Module1._dburl + "/set.php?t=imageFileUpload", "p=" + MySettingsProperty.Settings.pw + "&g=" + HttpUtility.UrlEncode(nowFolder.url) + "&nm=" + HttpUtility.UrlEncode(text.Substring(text.LastIndexOf("\\") + 1)) + "&d=" + HttpUtility.UrlEncode(str), progress: true).getHTML(this), "correct", TextCompare: false) != 0)
				{
					CustomMsgBox.CMsgBox(text + " 파일 업로드 중에 오류가 발생했습니다.", "업로드 실패", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					if (Operators.CompareString(url, "", TextCompare: false) == 0)
					{
						FolderRefresh();
						continue;
					}
					nowFolder.init = false;
					MoveUrl(nowFolder.url);
				}
			}
			try
			{
				search = files[0].Substring(files[0].LastIndexOf("\\") + 1);
				search = search.Substring(0, search.LastIndexOf("."));
				searchFinish = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(url, "", TextCompare: false) == 0)
			{
				FolderRefresh();
				return;
			}
			nowFolder.init = false;
			MoveUrl(nowFolder.url);
		}
	}

	private void imageSave_Click(object sender, EventArgs e)
	{
		if (preview.Image != null)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			SaveFileDialog saveFileDialog2 = saveFileDialog;
			saveFileDialog2.FileName = Conversions.ToString(preview.Tag);
			saveFileDialog2.Filter = "모든 파일 (*.*)|*.*";
			if (saveFileDialog2.ShowDialog() == DialogResult.OK)
			{
				preview.Image.Save(saveFileDialog.FileName, preview.Image.RawFormat);
				MessageBox.Show(saveFileDialog2.FileName + " 에 저장 되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			saveFileDialog2 = null;
		}
	}

	private void changeImage_Click(object sender, EventArgs e)
	{
		if (nowSelecedFile == null || MessageBox.Show("번호 " + Conversions.ToString(nowSelecedFile.num) + " 이미지 이름 " + nowSelecedFile.name + "\r\n\r\n이미지를 교체 하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
		{
			return;
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Multiselect = false;
		checked
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				ImageFormat imageFormat = null;
				switch (openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf(".") + 1).ToLower())
				{
				case "png":
					imageFormat = ImageFormat.Png;
					break;
				case "jpg":
					imageFormat = ImageFormat.Jpeg;
					break;
				case "gif":
					imageFormat = ImageFormat.Gif;
					break;
				case "bmp":
					imageFormat = ImageFormat.Bmp;
					break;
				default:
					CustomMsgBox.CMsgBox(openFileDialog.FileName + " 이미지 파일만 업로드 가능합니다.", "업로드 실패", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					return;
				}
				string str = Module1.ImageToBase64(openFileDialog.FileName, imageFormat);
				if (Operators.CompareString(new GetHtmlClass(Module1._dburl + "/set.php?t=imageFileChange", "p=" + MySettingsProperty.Settings.pw + "&n=" + Conversions.ToString(nowSelecedFile.num) + "&nm=" + HttpUtility.UrlEncode(openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf("\\") + 1)) + "&d=" + HttpUtility.UrlEncode(str), progress: true).getHTML(this), "correct", TextCompare: false) != 0)
				{
					CustomMsgBox.CMsgBox(openFileDialog.FileName + " 파일 업로드 중에 오류가 발생했습니다.", "업로드 실패", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					if (Operators.CompareString(url, "", TextCompare: false) == 0)
					{
						FolderRefresh();
						return;
					}
					nowFolder.init = false;
					MoveUrl(nowFolder.url);
					return;
				}
				if (Operators.CompareString(url, "", TextCompare: false) == 0)
				{
					FolderRefresh();
				}
				else
				{
					nowFolder.init = false;
					MoveUrl(nowFolder.url);
				}
			}
			openFileDialog = null;
		}
	}

	private void 전체선택ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = listView.Items.GetEnumerator();
			while (enumerator.MoveNext())
			{
				((ListViewItem)enumerator.Current).Selected = true;
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

	private void Button24_Click(object sender, EventArgs e)
	{
		if (searchInit)
		{
			searchForm.Show();
			searchForm.Focus();
			return;
		}
		searchLabel = new Label();
		Label label = searchLabel;
		label.Dock = DockStyle.Fill;
		label.Font = Font;
		label.BorderStyle = BorderStyle.None;
		label.Text = "고유번호(ID)로 파일을 검색합니다.";
		_ = null;
		searchTextBox = new TextBox();
		TextBox textBox = searchTextBox;
		textBox.Dock = DockStyle.Bottom;
		textBox.Font = new Font("굴림", 14f);
		textBox.BorderStyle = BorderStyle.FixedSingle;
		textBox.TextAlign = HorizontalAlignment.Center;
		searchTextBox.KeyDown += searchHandle;
		_ = null;
		searchPanel = new Panel();
		Panel panel = searchPanel;
		panel.Dock = DockStyle.Fill;
		panel.Padding = new Padding(10);
		panel.Controls.Add(searchTextBox);
		panel.Controls.Add(searchLabel);
		_ = null;
		searchForm = new Form();
		Form form = searchForm;
		form.Text = "번호(ID)로 파일 찾기";
		form.Size = new Size(250, 100);
		form.FormBorderStyle = FormBorderStyle.FixedSingle;
		form.MinimizeBox = false;
		form.MaximizeBox = false;
		form.ShowIcon = false;
		form.ShowInTaskbar = false;
		form.TopMost = true;
		form.StartPosition = FormStartPosition.CenterScreen;
		form.Controls.Add(searchPanel);
		searchForm.FormClosing += searchFormClosing;
		_ = null;
		searchForm.Show();
		searchInit = true;
	}

	private void searchFormClosing(object sender, FormClosingEventArgs e)
	{
		if (!Module1.MLAS_logout)
		{
			e.Cancel = true;
		}
		try
		{
			imgViewForm.Hide();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			searchForm.Hide();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	private void searchHandle(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			searchFinish = false;
			search = searchTextBox.Text.Trim();
			if (searchNum())
			{
				searchLabel.Text = "파일을 찾았습니다.";
			}
			else
			{
				searchLabel.Text = "존재하지 않는 고유번호 입니다.";
			}
		}
	}

	private void preview_Click(object sender, EventArgs e)
	{
		try
		{
			sjka_cyber_imagefolder.sjka_cyber_imageobject sjka_cyber_imageobject = nowSelecedFile;
			if (imgViewInit)
			{
				imgViewPictureBox.Image = sjka_cyber_imageobject.blob;
				imgViewForm.Text = sjka_cyber_imageobject.name;
				imgViewForm.Show();
				imgViewForm.Focus();
				return;
			}
			imgViewPictureBox = new PictureBox();
			PictureBox pictureBox = imgViewPictureBox;
			imgViewPictureBox.Image = sjka_cyber_imageobject.blob;
			pictureBox.Dock = DockStyle.Fill;
			pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
			_ = null;
			imgViewForm = new Form();
			Form form = imgViewForm;
			form.Text = sjka_cyber_imageobject.name;
			form.Size = sjka_cyber_imageobject.blob.Size;
			form.FormBorderStyle = FormBorderStyle.Sizable;
			form.MinimizeBox = true;
			form.MaximizeBox = true;
			form.ShowIcon = false;
			form.ShowInTaskbar = true;
			form.StartPosition = FormStartPosition.CenterScreen;
			form.Controls.Add(imgViewPictureBox);
			imgViewForm.FormClosing += searchFormClosing;
			_ = null;
			imgViewForm.Show();
			imgViewForm.Focus();
			imgViewInit = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void 파일업로드ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		PictureBox2_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
	{
		if (e.Action == TreeViewAction.ByMouse)
		{
			MoveUrl(TreeView1.SelectedNode.FullPath);
		}
	}
}
