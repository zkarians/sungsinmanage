using System;
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
public class cti_call : Form
{
	private IContainer components;

	public bool logCall;

	public cti_tm_list selectCustomer;

	public DataGridViewRow selectRow;

	private int[] logging_time;

	public Form orderDialog;

	public Point formlocation;

	private bool busy;

	private bool call_start;

	private int call_result;

	[field: AccessedThroughProperty("ImageList1")]
	internal virtual ImageList ImageList1
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

	internal virtual Button order
	{
		[CompilerGenerated]
		get
		{
			return _order;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _order;
			if (button != null)
			{
				button.Click -= value2;
			}
			_order = value;
			button = _order;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button callOff
	{
		[CompilerGenerated]
		get
		{
			return _callOff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button1_Click;
			Button button = _callOff;
			if (button != null)
			{
				button.Click -= value2;
			}
			_callOff = value;
			button = _callOff;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button save
	{
		[CompilerGenerated]
		get
		{
			return _save;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button2_Click;
			Button button = _save;
			if (button != null)
			{
				button.Click -= value2;
			}
			_save = value;
			button = _save;
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

	[field: AccessedThroughProperty("cus_name")]
	internal virtual TextBox cus_name
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
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

	[field: AccessedThroughProperty("cus_product_name")]
	internal virtual TextBox cus_product_name
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cus_seller")]
	internal virtual TextBox cus_seller
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cus_price")]
	internal virtual TextBox cus_price
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cus_phone")]
	internal virtual TextBox cus_phone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cus_home")]
	internal virtual TextBox cus_home
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cus_address")]
	internal virtual TextBox cus_address
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
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
			Timer timer = _Timer1;
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
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

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button callPhone
	{
		[CompilerGenerated]
		get
		{
			return _callPhone;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button4_Click;
			Button button = _callPhone;
			if (button != null)
			{
				button.Click -= value2;
			}
			_callPhone = value;
			button = _callPhone;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button callHome
	{
		[CompilerGenerated]
		get
		{
			return _callHome;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button5_Click;
			Button button = _callHome;
			if (button != null)
			{
				button.Click -= value2;
			}
			_callHome = value;
			button = _callHome;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ImageList2")]
	internal virtual ImageList ImageList2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	internal virtual ToolStripMenuItem 무관심ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _무관심ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 무관심ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _무관심ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_무관심ToolStripMenuItem = value;
			toolStripMenuItem = _무관심ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem TM거부ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _TM거부ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TM거부ToolStripMenuItem_Click;
			ToolStripMenuItem tM거부ToolStripMenuItem = _TM거부ToolStripMenuItem;
			if (tM거부ToolStripMenuItem != null)
			{
				tM거부ToolStripMenuItem.Click -= value2;
			}
			_TM거부ToolStripMenuItem = value;
			tM거부ToolStripMenuItem = _TM거부ToolStripMenuItem;
			if (tM거부ToolStripMenuItem != null)
			{
				tM거부ToolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 무응답ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _무응답ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 무응답ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _무응답ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_무응답ToolStripMenuItem = value;
			toolStripMenuItem = _무응답ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 통화예약ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _통화예약ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 통화예약ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _통화예약ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_통화예약ToolStripMenuItem = value;
			toolStripMenuItem = _통화예약ToolStripMenuItem;
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

	internal virtual ToolStripMenuItem 결번ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _결번ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 결번ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _결번ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_결번ToolStripMenuItem = value;
			toolStripMenuItem = _결번ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 본인아님ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _본인아님ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 본인아님ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _본인아님ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_본인아님ToolStripMenuItem = value;
			toolStripMenuItem = _본인아님ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator3")]
	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cus_comment2")]
	internal virtual TextBox cus_comment2
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

	[field: AccessedThroughProperty("cus_comment")]
	internal virtual TextBox cus_comment
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

	public cti_call()
	{
		base.Load += cti_call_Load;
		base.FormClosing += cti_call_FormClosing;
		logCall = false;
		logging_time = new int[3];
		orderDialog = new Form();
		busy = false;
		call_start = false;
		call_result = 0;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.cti_call));
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.Label3 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.cus_name = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.cus_product_name = new System.Windows.Forms.TextBox();
		this.cus_seller = new System.Windows.Forms.TextBox();
		this.cus_price = new System.Windows.Forms.TextBox();
		this.cus_phone = new System.Windows.Forms.TextBox();
		this.cus_home = new System.Windows.Forms.TextBox();
		this.cus_address = new System.Windows.Forms.TextBox();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Label9 = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label15 = new System.Windows.Forms.Label();
		this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label17 = new System.Windows.Forms.Label();
		this.cus_comment2 = new System.Windows.Forms.TextBox();
		this.Label16 = new System.Windows.Forms.Label();
		this.cus_comment = new System.Windows.Forms.TextBox();
		this.callHome = new System.Windows.Forms.Button();
		this.save = new System.Windows.Forms.Button();
		this.callPhone = new System.Windows.Forms.Button();
		this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.무관심ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TM거부ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.무응답ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.결번ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.본인아님ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.통화예약ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.callOff = new System.Windows.Forms.Button();
		this.order = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label18 = new System.Windows.Forms.Label();
		this.Label19 = new System.Windows.Forms.Label();
		this.GroupBox1.SuspendLayout();
		this.ContextMenuStrip1.SuspendLayout();
		base.SuspendLayout();
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.ImageList1.Images.SetKeyName(0, "Buy.png");
		this.ImageList1.Images.SetKeyName(1, "Hungup.png");
		this.ImageList1.Images.SetKeyName(2, "Save.png");
		this.ImageList1.Images.SetKeyName(3, "Shopping cart.png");
		this.ImageList1.Images.SetKeyName(4, "delete_new.png");
		this.ImageList1.Images.SetKeyName(5, "Dial.png");
		this.ImageList1.Images.SetKeyName(6, "Report.png");
		this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.Label3.ForeColor = System.Drawing.Color.Black;
		this.Label3.Location = new System.Drawing.Point(97, 86);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(180, 20);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "00:00:00";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label1.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label1.ForeColor = System.Drawing.Color.RoyalBlue;
		this.Label1.Location = new System.Drawing.Point(6, 22);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(68, 21);
		this.Label1.TabIndex = 7;
		this.Label1.Text = "고객명";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.cus_name.Location = new System.Drawing.Point(80, 22);
		this.cus_name.Name = "cus_name";
		this.cus_name.Size = new System.Drawing.Size(180, 21);
		this.cus_name.TabIndex = 8;
		this.Label2.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label2.ForeColor = System.Drawing.Color.RoyalBlue;
		this.Label2.Location = new System.Drawing.Point(6, 152);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(68, 21);
		this.Label2.TabIndex = 9;
		this.Label2.Text = "제품명";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label4.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label4.ForeColor = System.Drawing.Color.RoyalBlue;
		this.Label4.Location = new System.Drawing.Point(6, 179);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(68, 21);
		this.Label4.TabIndex = 10;
		this.Label4.Text = "구매처";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label5.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label5.ForeColor = System.Drawing.Color.RoyalBlue;
		this.Label5.Location = new System.Drawing.Point(6, 206);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(68, 21);
		this.Label5.TabIndex = 11;
		this.Label5.Text = "금액";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label6.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label6.ForeColor = System.Drawing.Color.RoyalBlue;
		this.Label6.Location = new System.Drawing.Point(6, 76);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(68, 21);
		this.Label6.TabIndex = 12;
		this.Label6.Text = "휴대전화";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label7.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label7.ForeColor = System.Drawing.Color.RoyalBlue;
		this.Label7.Location = new System.Drawing.Point(6, 49);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(68, 21);
		this.Label7.TabIndex = 13;
		this.Label7.Text = "집전화";
		this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label8.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label8.ForeColor = System.Drawing.Color.RoyalBlue;
		this.Label8.Location = new System.Drawing.Point(6, 103);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(68, 21);
		this.Label8.TabIndex = 14;
		this.Label8.Text = "주소";
		this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.cus_product_name.Location = new System.Drawing.Point(80, 152);
		this.cus_product_name.Name = "cus_product_name";
		this.cus_product_name.Size = new System.Drawing.Size(268, 21);
		this.cus_product_name.TabIndex = 15;
		this.cus_seller.Location = new System.Drawing.Point(80, 179);
		this.cus_seller.Name = "cus_seller";
		this.cus_seller.Size = new System.Drawing.Size(268, 21);
		this.cus_seller.TabIndex = 16;
		this.cus_price.Location = new System.Drawing.Point(80, 206);
		this.cus_price.Name = "cus_price";
		this.cus_price.Size = new System.Drawing.Size(268, 21);
		this.cus_price.TabIndex = 17;
		this.cus_phone.Location = new System.Drawing.Point(80, 76);
		this.cus_phone.Name = "cus_phone";
		this.cus_phone.Size = new System.Drawing.Size(180, 21);
		this.cus_phone.TabIndex = 18;
		this.cus_home.Location = new System.Drawing.Point(80, 49);
		this.cus_home.Name = "cus_home";
		this.cus_home.Size = new System.Drawing.Size(180, 21);
		this.cus_home.TabIndex = 19;
		this.cus_address.Location = new System.Drawing.Point(80, 103);
		this.cus_address.Multiline = true;
		this.cus_address.Name = "cus_address";
		this.cus_address.Size = new System.Drawing.Size(268, 43);
		this.cus_address.TabIndex = 20;
		this.Timer1.Interval = 1000;
		this.Label9.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label9.ForeColor = System.Drawing.Color.Black;
		this.Label9.Location = new System.Drawing.Point(20, 17);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(69, 20);
		this.Label9.TabIndex = 21;
		this.Label9.Text = "통화번호";
		this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label10.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label10.ForeColor = System.Drawing.Color.Black;
		this.Label10.Location = new System.Drawing.Point(20, 40);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(69, 20);
		this.Label10.TabIndex = 22;
		this.Label10.Text = "시도수";
		this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label11.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label11.ForeColor = System.Drawing.Color.Black;
		this.Label11.Location = new System.Drawing.Point(21, 64);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(69, 19);
		this.Label11.TabIndex = 23;
		this.Label11.Text = "상태";
		this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label12.BackColor = System.Drawing.SystemColors.Control;
		this.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.Label12.ForeColor = System.Drawing.Color.Red;
		this.Label12.Location = new System.Drawing.Point(97, 17);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(180, 20);
		this.Label12.TabIndex = 24;
		this.Label12.Text = "없음";
		this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label13.BackColor = System.Drawing.SystemColors.Control;
		this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.Label13.ForeColor = System.Drawing.Color.Black;
		this.Label13.Location = new System.Drawing.Point(97, 40);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(180, 20);
		this.Label13.TabIndex = 25;
		this.Label13.Text = "0";
		this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label14.BackColor = System.Drawing.SystemColors.Control;
		this.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.Label14.ForeColor = System.Drawing.Color.Red;
		this.Label14.Location = new System.Drawing.Point(97, 63);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(180, 20);
		this.Label14.TabIndex = 26;
		this.Label14.Text = "대기중";
		this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label15.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label15.ForeColor = System.Drawing.Color.Black;
		this.Label15.Location = new System.Drawing.Point(20, 86);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(69, 20);
		this.Label15.TabIndex = 27;
		this.Label15.Text = "통화시간";
		this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.ImageList2.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList2.ImageStream");
		this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
		this.ImageList2.Images.SetKeyName(0, "Dial.png");
		this.GroupBox1.Controls.Add(this.Label17);
		this.GroupBox1.Controls.Add(this.cus_comment2);
		this.GroupBox1.Controls.Add(this.Label16);
		this.GroupBox1.Controls.Add(this.cus_comment);
		this.GroupBox1.Controls.Add(this.Label1);
		this.GroupBox1.Controls.Add(this.callHome);
		this.GroupBox1.Controls.Add(this.save);
		this.GroupBox1.Controls.Add(this.callPhone);
		this.GroupBox1.Controls.Add(this.cus_name);
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.Label4);
		this.GroupBox1.Controls.Add(this.Label5);
		this.GroupBox1.Controls.Add(this.Label6);
		this.GroupBox1.Controls.Add(this.Label7);
		this.GroupBox1.Controls.Add(this.Label8);
		this.GroupBox1.Controls.Add(this.cus_product_name);
		this.GroupBox1.Controls.Add(this.cus_address);
		this.GroupBox1.Controls.Add(this.cus_seller);
		this.GroupBox1.Controls.Add(this.cus_home);
		this.GroupBox1.Controls.Add(this.cus_price);
		this.GroupBox1.Controls.Add(this.cus_phone);
		this.GroupBox1.Location = new System.Drawing.Point(15, 146);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(369, 378);
		this.GroupBox1.TabIndex = 30;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "고객정보";
		this.Label17.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label17.ForeColor = System.Drawing.Color.Black;
		this.Label17.Location = new System.Drawing.Point(6, 282);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(68, 21);
		this.Label17.TabIndex = 32;
		this.Label17.Text = "비고2";
		this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.cus_comment2.Location = new System.Drawing.Point(80, 282);
		this.cus_comment2.Multiline = true;
		this.cus_comment2.Name = "cus_comment2";
		this.cus_comment2.Size = new System.Drawing.Size(268, 43);
		this.cus_comment2.TabIndex = 33;
		this.Label16.Font = new System.Drawing.Font("굴림", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label16.ForeColor = System.Drawing.Color.Black;
		this.Label16.Location = new System.Drawing.Point(6, 233);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(68, 21);
		this.Label16.TabIndex = 30;
		this.Label16.Text = "비고1";
		this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.cus_comment.Location = new System.Drawing.Point(80, 233);
		this.cus_comment.Multiline = true;
		this.cus_comment.Name = "cus_comment";
		this.cus_comment.Size = new System.Drawing.Size(268, 43);
		this.cus_comment.TabIndex = 31;
		this.callHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.callHome.ImageIndex = 0;
		this.callHome.ImageList = this.ImageList2;
		this.callHome.Location = new System.Drawing.Point(266, 50);
		this.callHome.Name = "callHome";
		this.callHome.Size = new System.Drawing.Size(82, 21);
		this.callHome.TabIndex = 29;
		this.callHome.Text = "전화걸기";
		this.callHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.callHome.UseVisualStyleBackColor = true;
		this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.save.ImageIndex = 2;
		this.save.ImageList = this.ImageList1;
		this.save.Location = new System.Drawing.Point(236, 331);
		this.save.Name = "save";
		this.save.Size = new System.Drawing.Size(112, 27);
		this.save.TabIndex = 6;
		this.save.Text = "변경사항 저장";
		this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.save.UseVisualStyleBackColor = true;
		this.callPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.callPhone.ImageIndex = 0;
		this.callPhone.ImageList = this.ImageList2;
		this.callPhone.Location = new System.Drawing.Point(266, 76);
		this.callPhone.Name = "callPhone";
		this.callPhone.Size = new System.Drawing.Size(82, 21);
		this.callPhone.TabIndex = 28;
		this.callPhone.Text = "전화걸기";
		this.callPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.callPhone.UseVisualStyleBackColor = true;
		this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.무관심ToolStripMenuItem, this.TM거부ToolStripMenuItem, this.무응답ToolStripMenuItem, this.ToolStripSeparator3, this.결번ToolStripMenuItem, this.본인아님ToolStripMenuItem, this.ToolStripSeparator1, this.통화예약ToolStripMenuItem });
		this.ContextMenuStrip1.Name = "ContextMenuStrip1";
		this.ContextMenuStrip1.Size = new System.Drawing.Size(123, 148);
		this.무관심ToolStripMenuItem.Image = mlas_root.My.Resources.Resources.Sad_new;
		this.무관심ToolStripMenuItem.Name = "무관심ToolStripMenuItem";
		this.무관심ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
		this.무관심ToolStripMenuItem.Text = "무관심";
		this.TM거부ToolStripMenuItem.Image = mlas_root.My.Resources.Resources.No_new;
		this.TM거부ToolStripMenuItem.Name = "TM거부ToolStripMenuItem";
		this.TM거부ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
		this.TM거부ToolStripMenuItem.Text = "TM거부";
		this.무응답ToolStripMenuItem.Image = mlas_root.My.Resources.Resources.delete_new;
		this.무응답ToolStripMenuItem.Name = "무응답ToolStripMenuItem";
		this.무응답ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
		this.무응답ToolStripMenuItem.Text = "무응답";
		this.ToolStripSeparator3.Name = "ToolStripSeparator3";
		this.ToolStripSeparator3.Size = new System.Drawing.Size(119, 6);
		this.결번ToolStripMenuItem.Image = mlas_root.My.Resources.Resources.Forbidden;
		this.결번ToolStripMenuItem.Name = "결번ToolStripMenuItem";
		this.결번ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
		this.결번ToolStripMenuItem.Text = "결번";
		this.본인아님ToolStripMenuItem.Image = mlas_root.My.Resources.Resources.Forbidden;
		this.본인아님ToolStripMenuItem.Name = "본인아님ToolStripMenuItem";
		this.본인아님ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
		this.본인아님ToolStripMenuItem.Text = "본인아님";
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new System.Drawing.Size(119, 6);
		this.통화예약ToolStripMenuItem.Image = mlas_root.My.Resources.Resources.Blue_pin;
		this.통화예약ToolStripMenuItem.Name = "통화예약ToolStripMenuItem";
		this.통화예약ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
		this.통화예약ToolStripMenuItem.Text = "통화예약";
		this.callOff.Enabled = false;
		this.callOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.callOff.ImageIndex = 1;
		this.callOff.ImageList = this.ImageList1;
		this.callOff.Location = new System.Drawing.Point(286, 17);
		this.callOff.Name = "callOff";
		this.callOff.Size = new System.Drawing.Size(87, 66);
		this.callOff.TabIndex = 5;
		this.callOff.Text = "통화종료";
		this.callOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.callOff.UseVisualStyleBackColor = true;
		this.order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.order.ImageIndex = 3;
		this.order.ImageList = this.ImageList1;
		this.order.Location = new System.Drawing.Point(286, 86);
		this.order.Name = "order";
		this.order.Size = new System.Drawing.Size(87, 44);
		this.order.TabIndex = 3;
		this.order.Text = "판매접수";
		this.order.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.order.UseVisualStyleBackColor = true;
		this.Button1.Enabled = false;
		this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button1.ImageIndex = 6;
		this.Button1.ImageList = this.ImageList1;
		this.Button1.Location = new System.Drawing.Point(381, 110);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(88, 33);
		this.Button1.TabIndex = 31;
		this.Button1.Text = "TM결과";
		this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button1.UseVisualStyleBackColor = true;
		this.Button1.Visible = false;
		this.Label18.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label18.ForeColor = System.Drawing.Color.Black;
		this.Label18.Location = new System.Drawing.Point(20, 110);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(69, 20);
		this.Label18.TabIndex = 32;
		this.Label18.Text = "TM 결과";
		this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.Label19.ForeColor = System.Drawing.Color.Black;
		this.Label19.Location = new System.Drawing.Point(97, 110);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(180, 20);
		this.Label19.TabIndex = 31;
		this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(397, 538);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.Label19);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.Label15);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.callOff);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.order);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "cti_call";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "전화걸기";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.ContextMenuStrip1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void cti_call_Load(object sender, EventArgs e)
	{
		cus_name.Text = selectCustomer.name;
		if (selectCustomer.product_name != null)
		{
			cus_product_name.Text = selectCustomer.product_name;
		}
		else
		{
			cus_product_name.Text = "-";
		}
		if (selectCustomer.seller != null)
		{
			cus_seller.Text = selectCustomer.seller;
		}
		else
		{
			cus_seller.Text = "-";
		}
		if (selectCustomer.price.HasValue)
		{
			cus_price.Text = Conversions.ToString(selectCustomer.price.Value);
		}
		else
		{
			cus_price.Text = "-";
		}
		if (selectCustomer.phone_number != null)
		{
			cus_phone.Text = selectCustomer.phone_number;
			Button4_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
		else
		{
			cus_phone.Text = "-";
			callPhone.Enabled = false;
			if (selectCustomer.home_number != null)
			{
				Button5_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}
		if (selectCustomer.home_number != null)
		{
			cus_home.Text = selectCustomer.home_number;
		}
		else
		{
			cus_home.Text = "-";
			callHome.Enabled = false;
		}
		cus_address.Text = selectCustomer.address;
		if (selectCustomer.call_phone != null)
		{
			Label12.Text = selectCustomer.call_phone;
			Label12.ForeColor = Color.RoyalBlue;
		}
		Label13.Text = Conversions.ToString(selectCustomer.call_count.Value);
		cus_comment.Text = selectCustomer.comment;
		cus_comment2.Text = selectCustomer.comment2;
		if (selectCustomer.result == 0)
		{
			Label19.Text = "-";
			return;
		}
		call_result = selectCustomer.result;
		Label19.Text = selectCustomer.ResultString();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		call_result = 1;
		endCall(call_result, closeForm: false);
		selectCustomer.result = call_result;
		Label19.Text = selectCustomer.ResultString();
		if (orderDialog.IsHandleCreated)
		{
			orderDialog.Close();
			return;
		}
		formlocation = base.Location;
		checked
		{
			base.Location = new Point((int)Math.Round((double)formlocation.X / 2.0), formlocation.Y);
			orderDialog = new Form();
			Form form = orderDialog;
			form.Size = new Size(1000, 700);
			form.StartPosition = FormStartPosition.Manual;
			form.FormBorderStyle = FormBorderStyle.Sizable;
			form.Text = "상담사 판매접수";
			form.ShowIcon = false;
			form.Controls.Add(MyProject.Forms.android_db_ss_order.DoubleBufferPanel24);
			form.Location = new Point((int)Math.Round((double)formlocation.X / 2.0 + (double)base.Size.Width), (int)Math.Round((double)formlocation.Y / 2.0));
			_ = null;
			orderDialog.FormClosing += delegate(object a0, FormClosingEventArgs a1)
			{
				productDiagClosing((Form)a0, a1);
			};
			MyProject.Forms.android_db_ss_order.DoubleBufferPanel24.Dock = DockStyle.Fill;
			MyProject.Forms.android_db_ss_order.Panel1.Visible = true;
			orderDialog.Show();
			MyProject.Forms.android_db_ss_order.Button41_Click(RuntimeHelpers.GetObjectValue(sender), e);
			MyProject.Forms.android_db_ss_order.order_name.Text = selectCustomer.name;
			if (selectCustomer.home_number != null)
			{
				string[] array = selectCustomer.home_number.Split(new string[1] { "-" }, StringSplitOptions.None);
				if (array.Length == 3)
				{
					MyProject.Forms.android_db_ss_order.order_call1.Text = array[0];
					MyProject.Forms.android_db_ss_order.order_call2.Text = array[1];
					MyProject.Forms.android_db_ss_order.order_call3.Text = array[2];
				}
			}
			else
			{
				MyProject.Forms.android_db_ss_order.CheckBox2.Checked = true;
			}
			if (selectCustomer.phone_number != null)
			{
				string[] array2 = selectCustomer.phone_number.Split(new string[1] { "-" }, StringSplitOptions.None);
				if (array2.Length == 3)
				{
					MyProject.Forms.android_db_ss_order.order_phone1.Text = array2[0];
					MyProject.Forms.android_db_ss_order.order_phone2.Text = array2[1];
					MyProject.Forms.android_db_ss_order.order_phone3.Text = array2[2];
				}
			}
			else
			{
				MyProject.Forms.android_db_ss_order.CheckBox3.Checked = true;
			}
			MyProject.Forms.android_db_ss_order.CheckBox4.Checked = true;
			MyProject.Forms.android_db_ss_order.order_delivery.Text = selectCustomer.address;
			MyProject.Forms.android_db_ss_order.order_address.Text = selectCustomer.address;
		}
	}

	private void productDiagClosing(Form sender, FormClosingEventArgs e)
	{
		MyProject.Forms.android_db_ss_order.p5.Controls.Add(MyProject.Forms.android_db_ss_order.DoubleBufferPanel24);
		MyProject.Forms.android_db_ss_order.p5.Controls.SetChildIndex(MyProject.Forms.android_db_ss_order.DoubleBufferPanel24, 0);
		MyProject.Forms.android_db_ss_order.Panel1.Visible = false;
		base.Location = formlocation;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		ContextMenuStrip1.Show(callOff, callOff.PointToClient(Cursor.Position));
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(cus_name.Text.Replace("-", "").Trim(), null, TextCompare: false) == 0)
		{
			CustomMsgBox.CMsgBox("이름 칸이 비었습니다.", "저장할 수 없습니다", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
		}
		else if (Operators.CompareString(cus_address.Text.Replace("-", "").Trim(), null, TextCompare: false) == 0)
		{
			CustomMsgBox.CMsgBox("주소 칸이 비었습니다.", "저장할 수 없습니다", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
		}
		else if ((Operators.CompareString(cus_home.Text.Replace("-", "").Trim(), null, TextCompare: false) == 0) & (Operators.CompareString(cus_phone.Text.Replace("-", "").Trim(), null, TextCompare: false) == 0))
		{
			CustomMsgBox.CMsgBox("집전화 또는 휴대전화 번호 중 하나는 필수로 입력되어야 합니다.", "저장할 수 없습니다", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
		}
		else
		{
			if (busy)
			{
				return;
			}
			busy = true;
			JObject jObject = new JObject();
			jObject.Add("name", cus_name.Text.Trim());
			jObject.Add("product_name", cus_product_name.Text.Replace("-", "").Trim());
			jObject.Add("seller", cus_seller.Text.Replace("-", "").Trim());
			jObject.Add("price", cus_price.Text.Replace("-", "").Trim());
			jObject.Add("phone_number", cus_phone.Text.Replace("-", "").Trim());
			jObject.Add("home_number", cus_home.Text.Replace("-", "").Trim());
			jObject.Add("address", cus_address.Text.Trim());
			jObject.Add("comment", cus_comment.Text.Trim());
			jObject.Add("comment2", cus_comment2.Text.Trim());
			JObject jObject2 = new JObject();
			jObject2.Add("type", "modifyCustomer");
			jObject2.Add("id", Module1._id);
			jObject2.Add("pw", Module1._pw);
			jObject2.Add("agent_idx", ssorder.cti_account_idx);
			jObject2.Add("cus_idx", selectCustomer.idx);
			jObject2.Add("data", Module1.Base64Encode(jObject.ToString(Formatting.None)));
			string postData = "args=" + jObject2.ToString(Formatting.None);
			try
			{
				JObject jObject3 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_set.php")), postData, progress: true).getHTML(this));
				if (jObject3.SelectToken("response").Equals("fail"))
				{
					Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
					busy = false;
					return;
				}
				JToken jToken = jObject3.SelectToken("response");
				if ((string)jToken == "ok")
				{
					cti_tm_list cti_tm_list2 = selectCustomer;
					cti_tm_list2.name = cus_name.Text.Trim();
					cti_tm_list2.product_name = cus_product_name.Text.Replace("-", "").Trim();
					if (Operators.CompareString(cus_seller.Text.Replace("-", "").Trim(), null, TextCompare: false) == 0)
					{
						cti_tm_list2.seller = null;
					}
					else
					{
						cti_tm_list2.seller = cus_seller.Text.Replace("-", "").Trim();
					}
					if (Operators.CompareString(cus_price.Text.Replace("-", "").Trim(), null, TextCompare: false) == 0)
					{
						cti_tm_list2.price = null;
					}
					else
					{
						cti_tm_list2.price = Conversions.ToInteger(cus_price.Text.Trim());
					}
					if (Operators.CompareString(cus_phone.Text.Replace("-", "").Trim(), null, TextCompare: false) == 0)
					{
						cti_tm_list2.phone_number = null;
						callPhone.Enabled = false;
					}
					else
					{
						cti_tm_list2.phone_number = cus_phone.Text.Trim();
						if (!callOff.Enabled)
						{
							callPhone.Enabled = true;
						}
					}
					if (Operators.CompareString(cus_home.Text.Replace("-", "").Trim(), null, TextCompare: false) == 0)
					{
						cti_tm_list2.home_number = null;
						callHome.Enabled = false;
					}
					else
					{
						cti_tm_list2.home_number = cus_home.Text.Trim();
						if (!callOff.Enabled)
						{
							callHome.Enabled = true;
						}
					}
					cti_tm_list2.address = cus_address.Text.Trim();
					cti_tm_list2.comment = cus_comment.Text.Trim();
					cti_tm_list2.comment2 = cus_comment2.Text.Trim();
					cti_tm_list2 = null;
					DataGridView dataGridView = MyProject.Forms.ssorder_cti.tm_grid_all;
					switch (MyProject.Forms.ssorder_cti.TabControl2.SelectedIndex)
					{
					case 0:
						dataGridView = MyProject.Forms.ssorder_cti.tm_grid_all;
						break;
					case 1:
						dataGridView = MyProject.Forms.ssorder_cti.tm_grid_call_log;
						break;
					case 2:
						dataGridView = MyProject.Forms.ssorder_cti.tm_grid_miss;
						break;
					case 3:
						dataGridView = MyProject.Forms.ssorder_cti.tm_grid_call_out;
						break;
					case 4:
						dataGridView = MyProject.Forms.ssorder_cti.tm_grid_agree;
						break;
					case 5:
						dataGridView = MyProject.Forms.ssorder_cti.tm_grid_reserve;
						break;
					case 6:
						dataGridView = MyProject.Forms.ssorder_cti.tm_grid_blacklist;
						break;
					}
					int index = dataGridView.SelectedRows[0].Index;
					MyProject.Forms.ssorder_cti.TabControl2_SelectedIndexChanged(MyProject.Forms.ssorder_cti.TabControl2, new EventArgs());
					try
					{
						dataGridView.Rows[index].Selected = true;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				else if ((string)jToken == "fail")
				{
					JToken jToken2 = jObject3.SelectToken("cause");
					if ((string)jToken2 == "permission_error")
					{
						MessageBox.Show("로그인 실패 / 권한이 없습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Dispose();
						busy = false;
					}
					else if ((string)jToken2 == "is_not_my_customer")
					{
						MessageBox.Show("해당 고객의 담당자가 변경되었습니다.", "반영 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Dispose();
						busy = false;
					}
					else
					{
						CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject3.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
						busy = false;
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex4.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				busy = false;
				ProjectData.ClearProjectError();
				return;
			}
			busy = false;
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		startCall(selectCustomer.phone_number);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		startCall(selectCustomer.home_number);
	}

	private void startCall(string number)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		logging_time = new int[3];
		JObject jObject = new JObject();
		jObject.Add("type", "startCall");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("agent_idx", ssorder.cti_account_idx);
		jObject.Add("cus_idx", selectCustomer.idx);
		jObject.Add("call_phone", number);
		string postData = "args=" + jObject.ToString(Formatting.None);
		checked
		{
			try
			{
				JObject jObject2 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_set.php")), postData).getHTML(this));
				if (jObject2.SelectToken("response").Equals("fail"))
				{
					Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
					busy = false;
					return;
				}
				JToken jToken = jObject2.SelectToken("response");
				if ((string)jToken == "ok")
				{
					selectCustomer.call_count++;
					selectCustomer.call_phone = number;
					selectCustomer.call_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
					Timer1.Start();
					callOff.Enabled = true;
					Button1.Enabled = true;
					callPhone.Enabled = false;
					callHome.Enabled = false;
					Label12.ForeColor = Color.RoyalBlue;
					Label14.ForeColor = Color.RoyalBlue;
					Label12.Text = number;
					Label13.Text = Conversions.ToString(selectCustomer.call_count.Value);
					Label14.Text = "통화중";
					Label14.ForeColor = Color.DarkGreen;
					call_start = true;
				}
				else if ((string)jToken == "fail")
				{
					JToken jToken2 = jObject2.SelectToken("cause");
					if ((string)jToken2 == "permission_error")
					{
						MessageBox.Show("로그인 실패 / 권한이 없습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Dispose();
						busy = false;
					}
					else if ((string)jToken2 == "is_not_my_customer")
					{
						MessageBox.Show("해당 고객의 담당자가 변경되었습니다.", "반영 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Dispose();
						busy = false;
					}
					else
					{
						CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
						busy = false;
					}
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

	private void endCall(int status, bool closeForm = true)
	{
		if (busy)
		{
			return;
		}
		busy = true;
		JObject jObject = new JObject();
		jObject.Add("type", "endCall");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("agent_idx", ssorder.cti_account_idx);
		jObject.Add("cus_idx", selectCustomer.idx);
		jObject.Add("status", status);
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
				selectCustomer.result = status;
				DataGridView dataGridView = MyProject.Forms.ssorder_cti.tm_grid_all;
				switch (MyProject.Forms.ssorder_cti.TabControl2.SelectedIndex)
				{
				case 0:
					dataGridView = MyProject.Forms.ssorder_cti.tm_grid_all;
					break;
				case 1:
					dataGridView = MyProject.Forms.ssorder_cti.tm_grid_call_log;
					break;
				case 2:
					dataGridView = MyProject.Forms.ssorder_cti.tm_grid_miss;
					break;
				case 3:
					dataGridView = MyProject.Forms.ssorder_cti.tm_grid_call_out;
					break;
				case 4:
					dataGridView = MyProject.Forms.ssorder_cti.tm_grid_agree;
					break;
				case 5:
					dataGridView = MyProject.Forms.ssorder_cti.tm_grid_reserve;
					break;
				case 6:
					dataGridView = MyProject.Forms.ssorder_cti.tm_grid_blacklist;
					break;
				}
				int index = dataGridView.SelectedRows[0].Index;
				MyProject.Forms.ssorder_cti.TabControl2_SelectedIndexChanged(MyProject.Forms.ssorder_cti.TabControl2, new EventArgs());
				try
				{
					dataGridView.Rows[index].Selected = true;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				if (closeForm)
				{
					call_start = false;
					Dispose();
				}
				else
				{
					Timer1.Stop();
					callOff.Enabled = false;
					if (selectCustomer.phone_number != null)
					{
						callPhone.Enabled = true;
					}
					if (selectCustomer.home_number != null)
					{
						callHome.Enabled = true;
					}
					Button1.Enabled = false;
					Label14.ForeColor = Color.Red;
					Label14.Text = "통화종료";
					Label19.Text = selectCustomer.ResultString();
					call_start = false;
				}
			}
			else if ((string)jToken == "fail")
			{
				JToken jToken2 = jObject2.SelectToken("cause");
				if ((string)jToken2 == "permission_error")
				{
					MessageBox.Show("로그인 실패 / 권한이 없습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					busy = false;
				}
				else if ((string)jToken2 == "is_not_my_customer")
				{
					MessageBox.Show("해당 고객의 담당자가 변경되었습니다.", "반영 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Dispose();
					busy = false;
				}
				else
				{
					CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					busy = false;
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex4.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			busy = false;
			ProjectData.ClearProjectError();
			return;
		}
		busy = false;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			logging_time[2]++;
			if (logging_time[2] == 60)
			{
				logging_time[2] = 0;
				logging_time[1]++;
			}
			if (logging_time[1] == 60)
			{
				logging_time[1] = 0;
				logging_time[0]++;
			}
			Label3.Text = string.Format("{2:00}:{1:00}:{0:00}", logging_time[2], logging_time[1], logging_time[0]);
		}
	}

	private void close_Click(object sender, EventArgs e)
	{
		Dispose();
		if (orderDialog.IsHandleCreated)
		{
			orderDialog.Close();
		}
	}

	private void 없음ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		call_result = 0;
		selectCustomer.result = call_result;
		Label19.Text = "-";
	}

	private void 동의ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		call_result = 1;
		selectCustomer.result = call_result;
		Label19.Text = selectCustomer.ResultString();
	}

	private void 무관심ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		call_result = 2;
		selectCustomer.result = call_result;
		Label19.Text = selectCustomer.ResultString();
		endCall(call_result);
	}

	private void TM거부ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		call_result = 3;
		selectCustomer.result = call_result;
		Label19.Text = selectCustomer.ResultString();
		endCall(call_result);
	}

	private void 무응답ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		call_result = 4;
		selectCustomer.result = call_result;
		Label19.Text = selectCustomer.ResultString();
		endCall(call_result);
	}

	private void 통화예약ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		call_result = 6;
		selectCustomer.result = call_result;
		Label19.Text = selectCustomer.ResultString();
		endCall(call_result);
	}

	private void close_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			close_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void cti_call_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (call_start)
		{
			e.Cancel = true;
			MessageBox.Show("통화를 종료한 후 창을 닫을 수 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		Dispose();
		if (orderDialog.IsHandleCreated)
		{
			orderDialog.Close();
		}
	}

	private void 결번ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		call_result = 7;
		selectCustomer.result = call_result;
		Label19.Text = selectCustomer.ResultString();
		endCall(call_result);
	}

	private void 본인아님ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		call_result = 8;
		selectCustomer.result = call_result;
		Label19.Text = selectCustomer.ResultString();
		endCall(call_result);
	}

	private void 통화종료ToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
	}
}
