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
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class cti_import : Form
{
	private IContainer components;

	public bool db_input_mode;

	public bool db_blacklist_upload_mode;

	public List<cti_tm_list> ctiTMList;

	public ListBox.SelectedIndexCollection indices;

	public int selectIndex;

	public string dbName;

	public List<cti_tm_list> correctData;

	private object busy;

	private List<string[]> ctiImport;

	private bool selectedNothing;

	private List<cti_db> ctiDbClass;

	public Point formlocation;

	private bool checkbuttonEvent;

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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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
			EventHandler value2 = ListBox1_SelectedIndexChanged;
			ListBox listBox = _ListBox1;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value2;
			}
			_ListBox1 = value;
			listBox = _ListBox1;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value2;
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
			EventHandler value2 = ListBox2_SelectedIndexChanged;
			ListBox listBox = _ListBox2;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value2;
			}
			_ListBox2 = value;
			listBox = _ListBox2;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value2;
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

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("status")]
	internal virtual ToolStripStatusLabel status
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("blacklist_grid")]
	internal virtual DataGridView blacklist_grid
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

	internal virtual CheckBox CheckBox2
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox2_CheckedChanged;
			CheckBox checkBox = _CheckBox2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox2 = value;
			checkBox = _CheckBox2;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("db_status")]
	internal virtual Label db_status
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListBox3")]
	internal virtual ListBox ListBox3
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
	internal virtual DataGridViewCheckBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn15")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn16")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn16
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("ListBox4")]
	internal virtual ListBox ListBox4
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual RadioButton RadioButton4
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RadioButton4_CheckedChanged;
			RadioButton radioButton = _RadioButton4;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			_RadioButton4 = value;
			radioButton = _RadioButton4;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	internal virtual RadioButton RadioButton5
	{
		[CompilerGenerated]
		get
		{
			return _RadioButton5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RadioButton5_CheckedChanged;
			RadioButton radioButton = _RadioButton5;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			_RadioButton5 = value;
			radioButton = _RadioButton5;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public cti_import()
	{
		base.Load += cti_import_Load;
		base.FormClosing += cti_import_FormClosing;
		base.LocationChanged += cti_import_LocationChanged;
		db_input_mode = false;
		db_blacklist_upload_mode = false;
		ctiTMList = new List<cti_tm_list>();
		dbName = "";
		busy = false;
		ctiImport = new List<string[]>();
		selectedNothing = false;
		formlocation = default(Point);
		checkbuttonEvent = false;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.cti_import));
		this.Label2 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.ListBox1 = new System.Windows.Forms.ListBox();
		this.ListBox2 = new System.Windows.Forms.ListBox();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.status = new System.Windows.Forms.ToolStripStatusLabel();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.ListBox4 = new System.Windows.Forms.ListBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.ListBox3 = new System.Windows.Forms.ListBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.RadioButton3 = new System.Windows.Forms.RadioButton();
		this.RadioButton2 = new System.Windows.Forms.RadioButton();
		this.RadioButton1 = new System.Windows.Forms.RadioButton();
		this.Label7 = new System.Windows.Forms.Label();
		this.blacklist_grid = new System.Windows.Forms.DataGridView();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Button8 = new System.Windows.Forms.Button();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		this.db_status = new System.Windows.Forms.Label();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Button6 = new System.Windows.Forms.Button();
		this.Label4 = new System.Windows.Forms.Label();
		this.Button7 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button2 = new System.Windows.Forms.Button();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.RadioButton5 = new System.Windows.Forms.RadioButton();
		this.RadioButton4 = new System.Windows.Forms.RadioButton();
		this.Label8 = new System.Windows.Forms.Label();
		this.StatusStrip1.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.Panel7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.blacklist_grid).BeginInit();
		this.Panel3.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		base.SuspendLayout();
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 79);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(161, 12);
		this.Label2.TabIndex = 15;
		this.Label2.Text = "※ 컬럼을 일치시켜 주십시오";
		this.TextBox1.BackColor = System.Drawing.Color.White;
		this.TextBox1.Location = new System.Drawing.Point(76, 39);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.Size = new System.Drawing.Size(326, 21);
		this.TextBox1.TabIndex = 16;
		this.ListBox1.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox1.FormattingEnabled = true;
		this.ListBox1.Items.AddRange(new object[9] { "고객명", "집전화", "휴대전화", "주소", "제품명", "구매처", "금액", "비고1", "비고2" });
		this.ListBox1.Location = new System.Drawing.Point(14, 96);
		this.ListBox1.Name = "ListBox1";
		this.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.ListBox1.Size = new System.Drawing.Size(86, 147);
		this.ListBox1.TabIndex = 17;
		this.ListBox2.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox2.FormattingEnabled = true;
		this.ListBox2.Location = new System.Drawing.Point(106, 96);
		this.ListBox2.Name = "ListBox2";
		this.ListBox2.Size = new System.Drawing.Size(296, 147);
		this.ListBox2.TabIndex = 18;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.status });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 604);
		this.StatusStrip1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		this.StatusStrip1.Size = new System.Drawing.Size(520, 22);
		this.StatusStrip1.SizingGrip = false;
		this.StatusStrip1.TabIndex = 67;
		this.StatusStrip1.Text = "StatusStrip1";
		this.status.Name = "status";
		this.status.Size = new System.Drawing.Size(122, 17);
		this.status.Text = "파일을 불러오십시오.";
		this.TextBox2.BackColor = System.Drawing.Color.White;
		this.TextBox2.Location = new System.Drawing.Point(76, 12);
		this.TextBox2.MaxLength = 36;
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(326, 21);
		this.TextBox2.TabIndex = 69;
		this.Label1.ForeColor = System.Drawing.Color.Blue;
		this.Label1.Location = new System.Drawing.Point(13, 17);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(57, 12);
		this.Label1.TabIndex = 70;
		this.Label1.Text = "DB 이름";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label3.Location = new System.Drawing.Point(13, 44);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(57, 12);
		this.Label3.TabIndex = 71;
		this.Label3.Text = "경로";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(168, 10);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(140, 16);
		this.CheckBox1.TabIndex = 74;
		this.CheckBox1.Text = "블랙리스트 필터 사용";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.GroupBox1.Controls.Add(this.Panel6);
		this.GroupBox1.Controls.Add(this.blacklist_grid);
		this.GroupBox1.Controls.Add(this.Panel3);
		this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
		this.GroupBox1.Location = new System.Drawing.Point(0, 0);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(491, 246);
		this.GroupBox1.TabIndex = 75;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "블랙리스트 데이터베이스 선택";
		this.Panel6.Controls.Add(this.Panel5);
		this.Panel6.Controls.Add(this.Panel4);
		this.Panel6.Controls.Add(this.Panel7);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel6.Location = new System.Drawing.Point(288, 17);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(200, 201);
		this.Panel6.TabIndex = 73;
		this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.Panel5.Controls.Add(this.ListBox4);
		this.Panel5.Controls.Add(this.Label6);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel5.Location = new System.Drawing.Point(102, 0);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(102, 156);
		this.Panel5.TabIndex = 72;
		this.ListBox4.BackColor = System.Drawing.SystemColors.Control;
		this.ListBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListBox4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListBox4.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox4.FormattingEnabled = true;
		this.ListBox4.ItemHeight = 12;
		this.ListBox4.Items.AddRange(new object[7] { "1개 컬럼 일치", "2개 컬럼 일치", "3개 컬럼 일치", "4개 컬럼 일치", "5개 컬럼 일치", "6개 컬럼 일치", "모든 선택 일치" });
		this.ListBox4.Location = new System.Drawing.Point(0, 30);
		this.ListBox4.Name = "ListBox4";
		this.ListBox4.Size = new System.Drawing.Size(98, 122);
		this.ListBox4.TabIndex = 73;
		this.Label6.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label6.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label6.Location = new System.Drawing.Point(0, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(98, 30);
		this.Label6.TabIndex = 72;
		this.Label6.Text = "필터링 조건";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.Panel4.Controls.Add(this.ListBox3);
		this.Panel4.Controls.Add(this.Label5);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel4.Location = new System.Drawing.Point(0, 0);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(102, 156);
		this.Panel4.TabIndex = 71;
		this.ListBox3.BackColor = System.Drawing.SystemColors.Control;
		this.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListBox3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListBox3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox3.FormattingEnabled = true;
		this.ListBox3.ItemHeight = 12;
		this.ListBox3.Items.AddRange(new object[9] { "고객명", "집전화", "휴대전화", "주소", "제품명", "구매처", "금액", "비고1", "비고2" });
		this.ListBox3.Location = new System.Drawing.Point(0, 30);
		this.ListBox3.Name = "ListBox3";
		this.ListBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
		this.ListBox3.Size = new System.Drawing.Size(98, 122);
		this.ListBox3.TabIndex = 70;
		this.Label5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label5.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label5.Location = new System.Drawing.Point(0, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(98, 30);
		this.Label5.TabIndex = 71;
		this.Label5.Text = "비교할 컬럼";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.Panel7.Controls.Add(this.RadioButton3);
		this.Panel7.Controls.Add(this.RadioButton2);
		this.Panel7.Controls.Add(this.RadioButton1);
		this.Panel7.Controls.Add(this.Label7);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel7.Location = new System.Drawing.Point(0, 156);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new System.Drawing.Size(200, 45);
		this.Panel7.TabIndex = 73;
		this.RadioButton3.AutoSize = true;
		this.RadioButton3.Location = new System.Drawing.Point(107, 22);
		this.RadioButton3.Name = "RadioButton3";
		this.RadioButton3.Size = new System.Drawing.Size(47, 16);
		this.RadioButton3.TabIndex = 76;
		this.RadioButton3.Text = "모두";
		this.RadioButton3.UseVisualStyleBackColor = true;
		this.RadioButton2.AutoSize = true;
		this.RadioButton2.Checked = true;
		this.RadioButton2.Location = new System.Drawing.Point(59, 22);
		this.RadioButton2.Name = "RadioButton2";
		this.RadioButton2.Size = new System.Drawing.Size(47, 16);
		this.RadioButton2.TabIndex = 75;
		this.RadioButton2.TabStop = true;
		this.RadioButton2.Text = "기본";
		this.RadioButton2.UseVisualStyleBackColor = true;
		this.RadioButton1.AutoSize = true;
		this.RadioButton1.Location = new System.Drawing.Point(10, 22);
		this.RadioButton1.Name = "RadioButton1";
		this.RadioButton1.Size = new System.Drawing.Size(47, 16);
		this.RadioButton1.TabIndex = 74;
		this.RadioButton1.Text = "최소";
		this.RadioButton1.UseVisualStyleBackColor = true;
		this.Label7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label7.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label7.Location = new System.Drawing.Point(0, 0);
		this.Label7.Name = "Label7";
		this.Label7.Padding = new System.Windows.Forms.Padding(8, 5, 0, 0);
		this.Label7.Size = new System.Drawing.Size(196, 17);
		this.Label7.TabIndex = 73;
		this.Label7.Text = "프리셋";
		this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.blacklist_grid.AllowUserToAddRows = false;
		this.blacklist_grid.AllowUserToDeleteRows = false;
		this.blacklist_grid.AllowUserToOrderColumns = true;
		this.blacklist_grid.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.blacklist_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.blacklist_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.blacklist_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.blacklist_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.blacklist_grid.ColumnHeadersHeight = 24;
		this.blacklist_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.blacklist_grid.Columns.AddRange(this.Column1, this.Column2, this.DataGridViewTextBoxColumn15, this.DataGridViewTextBoxColumn16);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.blacklist_grid.DefaultCellStyle = dataGridViewCellStyle3;
		this.blacklist_grid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.blacklist_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.blacklist_grid.EnableHeadersVisualStyles = false;
		this.blacklist_grid.Location = new System.Drawing.Point(3, 17);
		this.blacklist_grid.MultiSelect = false;
		this.blacklist_grid.Name = "blacklist_grid";
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.blacklist_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.blacklist_grid.RowHeadersVisible = false;
		this.blacklist_grid.RowTemplate.Height = 23;
		this.blacklist_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.blacklist_grid.Size = new System.Drawing.Size(485, 201);
		this.blacklist_grid.TabIndex = 68;
		this.Column1.HeaderText = "idx";
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.Column1.Visible = false;
		this.Column2.HeaderText = "";
		this.Column2.Name = "Column2";
		this.Column2.Width = 30;
		this.DataGridViewTextBoxColumn15.HeaderText = "데이터베이스 이름";
		this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
		this.DataGridViewTextBoxColumn15.ReadOnly = true;
		this.DataGridViewTextBoxColumn15.Width = 150;
		this.DataGridViewTextBoxColumn16.HeaderText = "총 개수";
		this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
		this.DataGridViewTextBoxColumn16.ReadOnly = true;
		this.DataGridViewTextBoxColumn16.Width = 70;
		this.Panel3.Controls.Add(this.Button8);
		this.Panel3.Controls.Add(this.CheckBox2);
		this.Panel3.Controls.Add(this.db_status);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel3.Location = new System.Drawing.Point(3, 218);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(485, 25);
		this.Panel3.TabIndex = 69;
		this.Button8.BackColor = System.Drawing.Color.DarkGreen;
		this.Button8.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button8.ForeColor = System.Drawing.Color.White;
		this.Button8.Location = new System.Drawing.Point(86, 2);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(136, 21);
		this.Button8.TabIndex = 76;
		this.Button8.Text = "블랙리스트 관리 열기";
		this.Button8.UseVisualStyleBackColor = false;
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.Location = new System.Drawing.Point(5, 6);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(76, 16);
		this.CheckBox2.TabIndex = 75;
		this.CheckBox2.Text = "전체 선택";
		this.CheckBox2.UseVisualStyleBackColor = true;
		this.db_status.Dock = System.Windows.Forms.DockStyle.Right;
		this.db_status.Location = new System.Drawing.Point(251, 0);
		this.db_status.Name = "db_status";
		this.db_status.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
		this.db_status.Size = new System.Drawing.Size(234, 25);
		this.db_status.TabIndex = 79;
		this.db_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel2.Controls.Add(this.Button6);
		this.Panel2.Controls.Add(this.CheckBox1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 561);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(520, 43);
		this.Panel2.TabIndex = 77;
		this.Button6.BackColor = System.Drawing.Color.Blue;
		this.Button6.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button6.ForeColor = System.Drawing.Color.White;
		this.Button6.Location = new System.Drawing.Point(314, 3);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(191, 28);
		this.Button6.TabIndex = 22;
		this.Button6.Text = "가져오기";
		this.Button6.UseVisualStyleBackColor = false;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(508, 15);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(49, 24);
		this.Label4.TabIndex = 78;
		this.Label4.Text = "536, 354\r\n665";
		this.Label4.Visible = false;
		this.Button7.BackColor = System.Drawing.Color.DodgerBlue;
		this.Button7.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button7.BackgroundImage");
		this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button7.Font = new System.Drawing.Font("굴림", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button7.ForeColor = System.Drawing.Color.White;
		this.Button7.Location = new System.Drawing.Point(412, 107);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(91, 28);
		this.Button7.TabIndex = 68;
		this.Button7.Text = "빈 컬럼 추가";
		this.Button7.UseVisualStyleBackColor = false;
		this.Button5.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.Button5.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button5.BackgroundImage");
		this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button5.Font = new System.Drawing.Font("굴림", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button5.ForeColor = System.Drawing.Color.White;
		this.Button5.Location = new System.Drawing.Point(412, 134);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(91, 28);
		this.Button5.TabIndex = 21;
		this.Button5.Text = "지우기";
		this.Button5.UseVisualStyleBackColor = false;
		this.Button4.BackColor = System.Drawing.Color.DimGray;
		this.Button4.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button4.BackgroundImage");
		this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button4.ForeColor = System.Drawing.Color.White;
		this.Button4.Location = new System.Drawing.Point(412, 204);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(91, 28);
		this.Button4.TabIndex = 20;
		this.Button4.Text = "↓";
		this.Button4.UseVisualStyleBackColor = false;
		this.Button3.BackColor = System.Drawing.Color.DimGray;
		this.Button3.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button3.BackgroundImage");
		this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.ForeColor = System.Drawing.Color.White;
		this.Button3.Location = new System.Drawing.Point(412, 177);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(91, 28);
		this.Button3.TabIndex = 19;
		this.Button3.Text = "↑";
		this.Button3.UseVisualStyleBackColor = false;
		this.Button2.BackColor = System.Drawing.Color.DarkGreen;
		this.Button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button2.BackgroundImage");
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = System.Drawing.Color.White;
		this.Button2.Location = new System.Drawing.Point(412, 38);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(90, 24);
		this.Button2.TabIndex = 12;
		this.Button2.Text = "찾아보기...";
		this.Button2.UseVisualStyleBackColor = false;
		this.Panel1.Controls.Add(this.GroupBox1);
		this.Panel1.Controls.Add(this.GroupBox2);
		this.Panel1.Location = new System.Drawing.Point(14, 259);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(491, 298);
		this.Panel1.TabIndex = 79;
		this.Panel1.Visible = false;
		this.GroupBox2.Controls.Add(this.RadioButton5);
		this.GroupBox2.Controls.Add(this.RadioButton4);
		this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.GroupBox2.Location = new System.Drawing.Point(0, 254);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(491, 44);
		this.GroupBox2.TabIndex = 76;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "일치하는 레코드 처리 방식";
		this.RadioButton5.AutoSize = true;
		this.RadioButton5.Checked = true;
		this.RadioButton5.Location = new System.Drawing.Point(159, 19);
		this.RadioButton5.Name = "RadioButton5";
		this.RadioButton5.Size = new System.Drawing.Size(75, 16);
		this.RadioButton5.TabIndex = 27;
		this.RadioButton5.TabStop = true;
		this.RadioButton5.Text = "숨김 처리";
		this.RadioButton5.UseVisualStyleBackColor = true;
		this.RadioButton4.AutoSize = true;
		this.RadioButton4.Location = new System.Drawing.Point(9, 19);
		this.RadioButton4.Name = "RadioButton4";
		this.RadioButton4.Size = new System.Drawing.Size(147, 16);
		this.RadioButton4.TabIndex = 26;
		this.RadioButton4.Text = "데이터베이스에서 삭제";
		this.RadioButton4.UseVisualStyleBackColor = true;
		this.Label8.Location = new System.Drawing.Point(406, 13);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(103, 21);
		this.Label8.TabIndex = 80;
		this.Label8.Text = "총 0 레코드";
		this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(520, 626);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.TextBox2);
		base.Controls.Add(this.Button7);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.Button5);
		base.Controls.Add(this.Button4);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.ListBox2);
		base.Controls.Add(this.ListBox1);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "cti_import";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "데이터베이스 가져오기";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.Panel7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.blacklist_grid).EndInit();
		this.Panel3.ResumeLayout(false);
		this.Panel3.PerformLayout();
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		this.Panel1.ResumeLayout(false);
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(busy))
		{
			return;
		}
		busy = true;
		checked
		{
			try
			{
				ctiTMList.Clear();
				bool flag = true;
				int num = 0;
				IEnumerator enumerator2 = default(IEnumerator);
				foreach (string[] item in ctiImport)
				{
					if (flag)
					{
						flag = false;
						continue;
					}
					num = 0;
					cti_tm_list cti_tm_list2 = new cti_tm_list();
					try
					{
						enumerator2 = ListBox2.Items.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							string text = Conversions.ToString(enumerator2.Current);
							if (text.Equals("빈 컬럼"))
							{
								num++;
								continue;
							}
							int num2 = ctiImport[0].Length - 1;
							for (int i = 0; i <= num2; i++)
							{
								if (!ctiImport[0][i].Equals(text))
								{
									continue;
								}
								if (item[i].Trim().Length <= 0)
								{
									num++;
									continue;
								}
								switch (num)
								{
								case 0:
									cti_tm_list2.name = item[i];
									break;
								case 1:
									cti_tm_list2.home_number = item[i];
									break;
								case 2:
									cti_tm_list2.phone_number = item[i];
									break;
								case 3:
									cti_tm_list2.address = item[i];
									break;
								case 4:
									cti_tm_list2.product_name = item[i];
									break;
								case 5:
									cti_tm_list2.seller = item[i];
									break;
								case 6:
									cti_tm_list2.price = Conversions.ToInteger(item[i]);
									break;
								case 7:
									cti_tm_list2.comment = item[i];
									break;
								case 8:
									cti_tm_list2.comment2 = item[i];
									break;
								}
								num++;
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
					ctiTMList.Add(cti_tm_list2);
				}
				if (CheckBox1.Checked)
				{
					int num3 = 0;
					IEnumerator enumerator3 = default(IEnumerator);
					try
					{
						enumerator3 = ((IEnumerable)blacklist_grid.Rows).GetEnumerator();
						while (enumerator3.MoveNext())
						{
							if (Operators.ConditionalCompareObjectEqual(((DataGridViewCheckBoxCell)((DataGridViewRow)enumerator3.Current).Cells[1]).Value, true, TextCompare: false))
							{
								num3++;
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
					if (num3 <= 0)
					{
						MessageBox.Show("블랙리스트 데이터베이스를 한 개 이상 선택하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						busy = false;
						return;
					}
					if (ListBox3.SelectedIndices.Count <= 0)
					{
						MessageBox.Show("블랙리스트 비교군을 한 개 이상 선택하여 주십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						busy = false;
						return;
					}
					if ((ListBox3.SelectedIndices.Count < ListBox4.SelectedIndex + 1) & (ListBox4.SelectedIndex != 6))
					{
						MessageBox.Show("필터링 조건 갯수보다 비교군 갯수가 작을 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						busy = false;
						return;
					}
					indices = ListBox3.SelectedIndices;
					selectIndex = ListBox4.SelectedIndex;
					MyProject.Forms.cti_blacklist_progress.parent_form = this;
					dbName = TextBox2.Text.Trim();
					if (MyProject.Forms.cti_blacklist_progress.ShowDialog() != DialogResult.OK)
					{
						busy = false;
						return;
					}
					if (!RadioButton4.Checked)
					{
						foreach (cti_tm_list correctDatum in correctData)
						{
							correctDatum.blacklist = 1;
						}
					}
					else
					{
						foreach (cti_tm_list correctDatum2 in correctData)
						{
							ctiTMList.Remove(correctDatum2);
						}
					}
				}
				if (ctiTMList.Count <= 0)
				{
					busy = false;
					MessageBox.Show("추가할 데이터가 없습니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				string text2 = JsonConvert.SerializeObject(ctiTMList);
				JObject jObject = new JObject();
				if (!db_input_mode)
				{
					jObject.Add("type", "addDB");
					jObject.Add("name", TextBox2.Text.Trim());
				}
				else
				{
					jObject.Add("type", "putDB");
					jObject.Add("idx", MyProject.Forms.ssorder_cti.selectDb.idx);
				}
				jObject.Add("id", Module1._id);
				jObject.Add("pw", Module1._pw);
				if (db_blacklist_upload_mode)
				{
					jObject.Add("upload_mode", "blacklist");
				}
				jObject.Add("data", Module1.Base64Encode(text2.ToString()));
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
						if (!db_input_mode)
						{
							if (!db_blacklist_upload_mode)
							{
								MyProject.Forms.ssorder_cti.ctiDbClass.Add(new cti_db((int)jObject2.SelectToken("output"), TextBox2.Text.Trim(), ctiTMList.Count));
								MyProject.Forms.ssorder_cti.db_grid.Rows.Add(Resources.Stop_sign, jObject2.SelectToken("output").ToString(), TextBox2.Text.Trim(), ctiTMList.Count, ctiTMList.Count, 0, 0, 0, 0, 0, 0, 0);
								MyProject.Forms.ssorder_cti.db_status.Text = "서버에 " + Conversions.ToString(MyProject.Forms.ssorder_cti.ctiDbClass.Count) + "개의 데이터베이스가 있습니다.";
								MyProject.Forms.ssorder_cti.db_grid.ClearSelection();
								MyProject.Forms.ssorder_cti.db_grid.Rows[MyProject.Forms.ssorder_cti.db_grid.Rows.Count - 1].Selected = true;
								MyProject.Forms.ssorder_cti.selectDbInit();
							}
							else
							{
								MyProject.Forms.cti_blacklist.ctiDbClass.Add(new cti_db((int)jObject2.SelectToken("output"), TextBox2.Text.Trim(), ctiTMList.Count));
								MyProject.Forms.cti_blacklist.blacklist_grid.Rows.Add(jObject2.SelectToken("output").ToString(), TextBox2.Text.Trim(), ctiTMList.Count);
								MyProject.Forms.cti_blacklist.db_status.Text = "총 " + Conversions.ToString(MyProject.Forms.cti_blacklist.ctiDbClass.Count) + "개 데이터베이스 발견.";
							}
						}
						else
						{
							MyProject.Forms.ssorder_cti.selectDb.getCusData(MyProject.Forms.ssorder_cti.table_grid, Conversions.ToString(MyProject.Forms.ssorder_cti.selectDb.max_page - 1), returnFlag: false);
							MyProject.Forms.ssorder_cti.getDB(refresh: true);
						}
						MessageBox.Show("데이터 가져오기를 완료했습니다.", "가져오기 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						MyProject.Forms.ssorder_cti.getDB(refresh: true);
						Dispose();
					}
					else if ((string)jToken == "fail")
					{
						CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
						busy = false;
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
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show("컬럼이 일치하지 않거나 사용할 수 없는 문자가 포함되어 있습니다.\r\n\r\n다시 확인 후 시도하십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				busy = false;
				ProjectData.ClearProjectError();
			}
			busy = false;
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(busy, true, TextCompare: false))
		{
			return;
		}
		busy = true;
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "호환되는 파일|*.xlsx;*.csv|Excel 통합 문서|*.xlsx|CSV 파일|*.csv|모든 파일|*.*";
		checked
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				ctiImport.Clear();
				ListBox2.Items.Clear();
				TextBox1.Text = openFileDialog.FileName;
				TextBox1.SelectionStart = TextBox1.Text.Length - 1;
				status.Text = "컬럼이 일치하는지 확인하십시오.";
				TextBox2.Text = openFileDialog.SafeFileName.Replace(".csv", "").Replace(".xlsx", "");
				if (openFileDialog.FileName.EndsWith("csv"))
				{
					try
					{
						using StreamReader streamReader = new StreamReader(openFileDialog.FileName, Encoding.Default, detectEncodingFromByteOrderMarks: false);
						while (!streamReader.EndOfStream)
						{
							string[] array = Module1.csvChar34Replace(streamReader.ReadLine()).Split(new string[1] { "," }, StringSplitOptions.None);
							string[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								array2[i].Replace("&quot;", ",").Replace("&chr34;", "\"");
							}
							ctiImport.Add(array);
						}
						int num = ctiImport[0].Length - 1;
						for (int j = 0; j <= num; j++)
						{
							ListBox2.Items.Add(ctiImport[0][j]);
						}
						ListBox1.SelectedIndex = 0;
						ListBox2.SelectedIndex = 0;
					}
					catch (IOException ex)
					{
						ProjectData.SetProjectError(ex);
						IOException ex2 = ex;
						MessageBox.Show("파일을 열 수 없습니다! : 다른 프로그램에서 해당 파일을 사용 중 입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Dispose();
						ProjectData.ClearProjectError();
						return;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						MessageBox.Show("파일을 열 수 없습니다! : 파일이 손상되었거나 경로가 잘못 되었습니다.\r\n\r\n다른 파일로 다시 시도하십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Dispose();
						ProjectData.ClearProjectError();
						return;
					}
				}
				else if (openFileDialog.FileName.EndsWith("xlsx"))
				{
					try
					{
						DataSet dataSet = ssorder.openExcel(openFileDialog.FileName);
						IEnumerator enumerator = default(IEnumerator);
						try
						{
							enumerator = dataSet.Tables[0].Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow obj = (DataRow)enumerator.Current;
								List<string> list = new List<string>();
								object[] itemArray = obj.ItemArray;
								for (int k = 0; k < itemArray.Length; k++)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(itemArray[k]);
									if (Operators.CompareString(objectValue.ToString(), null, TextCompare: false) == 0)
									{
										list.Add("");
									}
									else
									{
										list.Add(Conversions.ToString(objectValue));
									}
								}
								ctiImport.Add(list.ToArray());
							}
						}
						finally
						{
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						int num2 = ctiImport[0].Length - 1;
						for (int l = 0; l <= num2; l++)
						{
							ListBox2.Items.Add(ctiImport[0][l]);
						}
						ListBox1.SelectedIndex = 0;
						ListBox2.SelectedIndex = 0;
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						MessageBox.Show("파일을 열 수 없습니다! : " + ex6.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Dispose();
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					MessageBox.Show("파일을 열 수 없습니다! : 지원하지 않는 파일 확장자입니다.\r\n\r\n다른 파일로 다시 시도하십시오.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Dispose();
				}
			}
			else
			{
				Dispose();
			}
			openFileDialog = null;
			Label8.Text = "총 " + Conversions.ToString(ctiImport.Count - 1) + " 레코드";
			busy = false;
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		if (!Conversions.ToBoolean(busy))
		{
			ListBox2.Items.Add("빈 컬럼");
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		if (!Conversions.ToBoolean(busy))
		{
			try
			{
				int selectedIndex = ListBox2.SelectedIndex;
				ListBox2.Items.RemoveAt(ListBox2.SelectedIndex);
				ListBox2.SelectedIndex = selectedIndex;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		checked
		{
			if (!Conversions.ToBoolean(busy) && ListBox2.SelectedIndex > 0)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ListBox2.SelectedItem);
				int selectedIndex = ListBox2.SelectedIndex;
				ListBox2.Items.RemoveAt(selectedIndex);
				ListBox2.Items.Insert(selectedIndex - 1, RuntimeHelpers.GetObjectValue(objectValue));
				ListBox2.SelectedIndex = selectedIndex - 1;
			}
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		checked
		{
			if (!Conversions.ToBoolean(busy) && ListBox2.SelectedIndex >= 0 && ListBox2.SelectedIndex < ListBox2.Items.Count - 1)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(ListBox2.SelectedItem);
				int selectedIndex = ListBox2.SelectedIndex;
				ListBox2.Items.RemoveAt(selectedIndex);
				ListBox2.Items.Insert(selectedIndex + 1, RuntimeHelpers.GetObjectValue(objectValue));
				ListBox2.SelectedIndex = selectedIndex + 1;
			}
		}
	}

	private void cti_import_Load(object sender, EventArgs e)
	{
		ctiImport.Clear();
		ListBox2.Items.Clear();
		Button2_Click(RuntimeHelpers.GetObjectValue(sender), e);
		if (db_blacklist_upload_mode)
		{
			CheckBox1.Hide();
		}
	}

	private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (selectedNothing)
		{
			selectedNothing = false;
			return;
		}
		if (checked(ListBox2.Items.Count - 1) < ListBox1.SelectedIndex)
		{
			selectedNothing = true;
			ListBox2.ClearSelected();
			return;
		}
		try
		{
			ListBox2.SelectedIndex = ListBox1.SelectedIndex;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			selectedNothing = true;
			ListBox2.ClearSelected();
			ProjectData.ClearProjectError();
		}
	}

	private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (selectedNothing)
		{
			selectedNothing = false;
			return;
		}
		if (checked(ListBox1.Items.Count - 1) < ListBox2.SelectedIndex)
		{
			selectedNothing = true;
			ListBox1.ClearSelected();
			return;
		}
		try
		{
			ListBox1.SelectedIndex = ListBox2.SelectedIndex;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			selectedNothing = true;
			ListBox1.ClearSelected();
			ProjectData.ClearProjectError();
		}
	}

	public void getBlacklist()
	{
		ctiDbClass = MyProject.Forms.ssorder_cti.getDB(refresh: false, "blacklist");
		if (ctiDbClass.Count <= 0)
		{
			return;
		}
		blacklist_grid.Rows.Clear();
		foreach (cti_db item in ctiDbClass)
		{
			blacklist_grid.Rows.Add(item.idx, false, item.name, item.nosplit_count);
		}
		db_status.Text = "총 " + Conversions.ToString(ctiDbClass.Count) + "개 데이터베이스 발견.";
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckBox1.Checked)
		{
			checkbuttonEvent = true;
			base.Size = new Size(536, 665);
			Panel1.Show();
			formlocation = base.Location;
			base.Location = new Point(formlocation.X, checked((int)Math.Round((double)formlocation.Y - 140.0)));
			getBlacklist();
			checkbuttonEvent = false;
			return;
		}
		checkbuttonEvent = true;
		base.Size = new Size(536, 354);
		Panel1.Hide();
		CheckBox2.Checked = false;
		RadioButton2.Checked = true;
		if (formlocation != default(Point))
		{
			base.Location = formlocation;
		}
		checkbuttonEvent = false;
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		MyProject.Forms.cti_blacklist.parent_form = this;
		MyProject.Forms.cti_blacklist.ShowDialog();
	}

	private void cti_import_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Conversions.ToBoolean(busy))
		{
			e.Cancel = true;
		}
		else
		{
			Dispose();
		}
	}

	private void CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		bool @checked = CheckBox2.Checked;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)blacklist_grid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				((DataGridViewCheckBoxCell)((DataGridViewRow)enumerator.Current).Cells[1]).Value = @checked;
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

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		ListBox3.ClearSelected();
		ListBox4.ClearSelected();
		ListBox3.SelectedIndex = 1;
		ListBox3.SelectedIndex = 2;
		ListBox4.SelectedIndex = 0;
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		ListBox3.ClearSelected();
		ListBox4.ClearSelected();
		ListBox3.SelectedIndex = 0;
		ListBox3.SelectedIndex = 1;
		ListBox3.SelectedIndex = 2;
		ListBox4.SelectedIndex = 1;
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		ListBox3.ClearSelected();
		ListBox4.ClearSelected();
		checked
		{
			int num = ListBox3.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				ListBox3.SelectedIndex = i;
			}
			ListBox4.SelectedIndex = 6;
			if (RadioButton3.Checked)
			{
				MessageBox.Show("모든 컬럼을 탐색하면 필터링 속도가 느려질 수 있습니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
	}

	private void cti_import_LocationChanged(object sender, EventArgs e)
	{
		if (!checkbuttonEvent)
		{
			formlocation = default(Point);
		}
	}

	private void RadioButton5_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void RadioButton4_CheckedChanged(object sender, EventArgs e)
	{
	}
}
