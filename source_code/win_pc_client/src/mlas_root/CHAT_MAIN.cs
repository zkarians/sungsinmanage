using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class CHAT_MAIN : Form
{
	private IContainer components;

	private int hScrollOffset;

	private int vScrollOffset;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	internal virtual Timer looper
	{
		[CompilerGenerated]
		get
		{
			return _looper;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = looper_Tick;
			Timer timer = _looper;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_looper = value;
			timer = _looper;
			if (timer != null)
			{
				timer.Tick += value2;
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	internal virtual WebBrowser WebBrowser1
	{
		[CompilerGenerated]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			WebBrowserDocumentCompletedEventHandler value2 = WebBrowser1_DocumentCompleted;
			WebBrowser webBrowser = _WebBrowser1;
			if (webBrowser != null)
			{
				webBrowser.DocumentCompleted -= value2;
			}
			_WebBrowser1 = value;
			webBrowser = _WebBrowser1;
			if (webBrowser != null)
			{
				webBrowser.DocumentCompleted += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
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

	internal virtual Panel Panel4
	{
		[CompilerGenerated]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel4_MouseDown;
			Panel panel = _Panel4;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel4 = value;
			panel = _Panel4;
			if (panel != null)
			{
				panel.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label3
	{
		[CompilerGenerated]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel4_MouseDown;
			Label label = _Label3;
			if (label != null)
			{
				label.MouseDown -= value2;
			}
			_Label3 = value;
			label = _Label3;
			if (label != null)
			{
				label.MouseDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox3
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PictureBox3_Click;
			PictureBox pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox3 = value;
			pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public CHAT_MAIN()
	{
		base.Load += CHAT_MAIN_Load;
		hScrollOffset = 100;
		vScrollOffset = 300;
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
		this.Panel1 = new System.Windows.Forms.Panel();
		this.TextBox6 = new System.Windows.Forms.TextBox();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.ListBox2 = new System.Windows.Forms.ListBox();
		this.ListBox1 = new System.Windows.Forms.ListBox();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
		this.Button2 = new System.Windows.Forms.Button();
		this.TextBox4 = new System.Windows.Forms.TextBox();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.looper = new System.Windows.Forms.Timer(this.components);
		this.Panel5 = new System.Windows.Forms.Panel();
		this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		this.Panel3.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.SplitContainer1.Panel1.SuspendLayout();
		this.SplitContainer1.Panel2.SuspendLayout();
		this.SplitContainer1.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel1.Controls.Add(this.TextBox6);
		this.Panel1.Controls.Add(this.PictureBox1);
		this.Panel1.Controls.Add(this.TextBox3);
		this.Panel1.Controls.Add(this.ListBox2);
		this.Panel1.Controls.Add(this.ListBox1);
		this.Panel1.Controls.Add(this.TextBox2);
		this.Panel1.Controls.Add(this.TextBox1);
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Controls.Add(this.Button1);
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(476, 562);
		this.Panel1.TabIndex = 0;
		this.TextBox6.Location = new System.Drawing.Point(26, 404);
		this.TextBox6.Multiline = true;
		this.TextBox6.Name = "TextBox6";
		this.TextBox6.Size = new System.Drawing.Size(235, 91);
		this.TextBox6.TabIndex = 13;
		this.PictureBox1.Location = new System.Drawing.Point(23, 317);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(157, 70);
		this.PictureBox1.TabIndex = 12;
		this.PictureBox1.TabStop = false;
		this.TextBox3.Location = new System.Drawing.Point(23, 52);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(83, 21);
		this.TextBox3.TabIndex = 6;
		this.ListBox2.FormattingEnabled = true;
		this.ListBox2.ItemHeight = 12;
		this.ListBox2.Location = new System.Drawing.Point(272, 263);
		this.ListBox2.Name = "ListBox2";
		this.ListBox2.Size = new System.Drawing.Size(185, 232);
		this.ListBox2.TabIndex = 5;
		this.ListBox1.FormattingEnabled = true;
		this.ListBox1.ItemHeight = 12;
		this.ListBox1.Location = new System.Drawing.Point(272, 25);
		this.ListBox1.Name = "ListBox1";
		this.ListBox1.Size = new System.Drawing.Size(185, 232);
		this.ListBox1.TabIndex = 4;
		this.TextBox2.Location = new System.Drawing.Point(23, 25);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(83, 21);
		this.TextBox2.TabIndex = 1;
		this.TextBox1.Location = new System.Drawing.Point(94, 122);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(157, 21);
		this.TextBox1.TabIndex = 3;
		this.TextBox1.Text = "microlivire";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(37, 182);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(42, 12);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "Label2";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(37, 129);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(42, 12);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "Label1";
		this.Button1.Location = new System.Drawing.Point(105, 177);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 23);
		this.Button1.TabIndex = 0;
		this.Button1.Text = "login";
		this.Button1.UseVisualStyleBackColor = true;
		this.WebBrowser1.AllowWebBrowserDrop = false;
		this.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.WebBrowser1.IsWebBrowserContextMenuEnabled = false;
		this.WebBrowser1.Location = new System.Drawing.Point(0, 0);
		this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
		this.WebBrowser1.Name = "WebBrowser1";
		this.WebBrowser1.Size = new System.Drawing.Size(342, 477);
		this.WebBrowser1.TabIndex = 10;
		this.WebBrowser1.WebBrowserShortcutsEnabled = false;
		this.Button2.BackgroundImage = mlas_root.My.Resources.Resources.chat_background;
		this.Button2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = System.Drawing.Color.White;
		this.Button2.Location = new System.Drawing.Point(284, 0);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(58, 63);
		this.Button2.TabIndex = 8;
		this.Button2.Text = "보내기";
		this.Button2.UseVisualStyleBackColor = true;
		this.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox4.Location = new System.Drawing.Point(3, 3);
		this.TextBox4.Multiline = true;
		this.TextBox4.Name = "TextBox4";
		this.TextBox4.Size = new System.Drawing.Size(278, 57);
		this.TextBox4.TabIndex = 7;
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabControl1.Location = new System.Drawing.Point(0, 0);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(1346, 690);
		this.TabControl1.TabIndex = 1;
		this.TabPage1.Controls.Add(this.Panel2);
		this.TabPage1.Controls.Add(this.Panel1);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(1338, 664);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "TabPage1";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel2.Controls.Add(this.SplitContainer1);
		this.Panel2.Controls.Add(this.Panel6);
		this.Panel2.Controls.Add(this.Panel4);
		this.Panel2.Location = new System.Drawing.Point(500, 10);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(344, 578);
		this.Panel2.TabIndex = 11;
		this.Panel6.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel6.Location = new System.Drawing.Point(0, 575);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(342, 1);
		this.Panel6.TabIndex = 14;
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
		this.Panel4.BackgroundImage = mlas_root.My.Resources.Resources.chat_background;
		this.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Panel4.Controls.Add(this.PictureBox3);
		this.Panel4.Controls.Add(this.Label3);
		this.Panel4.Controls.Add(this.PictureBox2);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(0, 0);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(342, 32);
		this.Panel4.TabIndex = 13;
		this.PictureBox3.Image = mlas_root.My.Resources.Resources.chat_topbar_close;
		this.PictureBox3.Location = new System.Drawing.Point(316, 5);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(21, 21);
		this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox3.TabIndex = 3;
		this.PictureBox3.TabStop = false;
		this.Label3.AutoSize = true;
		this.Label3.ForeColor = System.Drawing.Color.White;
		this.Label3.Location = new System.Drawing.Point(38, 11);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(75, 12);
		this.Label3.TabIndex = 2;
		this.Label3.Text = "@Microlivire";
		this.PictureBox2.Image = mlas_root.My.Resources.Resources.chaticon;
		this.PictureBox2.Location = new System.Drawing.Point(4, 4);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(31, 25);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox2.TabIndex = 1;
		this.PictureBox2.TabStop = false;
		this.Panel3.BackColor = System.Drawing.Color.White;
		this.Panel3.Controls.Add(this.Panel5);
		this.Panel3.Controls.Add(this.Button2);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(0, 0);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(342, 63);
		this.Panel3.TabIndex = 12;
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(1338, 664);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "TabPage2";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.looper.Interval = 500;
		this.Panel5.BackColor = System.Drawing.Color.White;
		this.Panel5.Controls.Add(this.TextBox4);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Name = "Panel5";
		this.Panel5.Padding = new System.Windows.Forms.Padding(3);
		this.Panel5.Size = new System.Drawing.Size(284, 63);
		this.Panel5.TabIndex = 9;
		this.SplitContainer1.BackColor = System.Drawing.Color.DimGray;
		this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer1.Location = new System.Drawing.Point(0, 32);
		this.SplitContainer1.Name = "SplitContainer1";
		this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
		this.SplitContainer1.Panel1.Controls.Add(this.WebBrowser1);
		this.SplitContainer1.Panel1MinSize = 250;
		this.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White;
		this.SplitContainer1.Panel2.Controls.Add(this.Panel3);
		this.SplitContainer1.Panel2MinSize = 63;
		this.SplitContainer1.Size = new System.Drawing.Size(342, 543);
		this.SplitContainer1.SplitterDistance = 477;
		this.SplitContainer1.SplitterWidth = 3;
		this.SplitContainer1.TabIndex = 15;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1346, 690);
		base.Controls.Add(this.TabControl1);
		base.Name = "CHAT_MAIN";
		this.Text = "Form1";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		this.Panel3.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		this.Panel5.PerformLayout();
		this.SplitContainer1.Panel1.ResumeLayout(false);
		this.SplitContainer1.Panel2.ResumeLayout(false);
		this.SplitContainer1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		CHAT_MAIN_MODULE.CHAT_CLASS = new CHAT("http://umylife0208.cafe24.com/mlas");
		ListBox1.Items.Clear();
		if (!CHAT_MAIN_MODULE.CHAT_CLASS.Login(TextBox1.Text, "1111"))
		{
			return;
		}
		CHAT_MAIN_MODULE.LooperStart();
		foreach (string[] item in CHAT_MAIN_MODULE.CHAT_CLASS.MsgCountDetail())
		{
			ListBox1.Items.Add(item[0] + "(" + item[1] + ")");
		}
	}

	private void looper_Tick(object sender, EventArgs e)
	{
		if (CHAT_MAIN_MODULE.CHAT_CLASS.refresh())
		{
			TextBox2.Text = Conversions.ToString(CHAT_MAIN_MODULE.CHAT_CLASS.LoopCount);
			TextBox3.Text = Conversions.ToString(CHAT_MAIN_MODULE.CHAT_CLASS.getCount());
		}
		if (!Conversions.ToBoolean(CHAT_MAIN_MODULE.CHAT_CLASS.MessageAlert))
		{
			return;
		}
		ListBox1.Items.Clear();
		foreach (string[] item in CHAT_MAIN_MODULE.CHAT_CLASS.MsgCountDetail())
		{
			_ = item;
		}
	}

	private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		setView();
		ListBox1.Items.Clear();
		foreach (string[] item in CHAT_MAIN_MODULE.CHAT_CLASS.MsgCountDetail())
		{
			ListBox1.Items.Add(item[0] + "(" + item[1] + ")");
		}
	}

	public void setView()
	{
		try
		{
			string text = "<html><style>div {width:100%;border-radius: 25px;}body {font-family: 맑은 고딕, 굴림; font-style:normal;padding:0px; cursor:none; -webkit-user-select: none; -ms-user-select: none; user-select: none;background: ;}#mymsg {min-width:10px; max-width:100%; text-align:right; right: 0px; padding:10px, 5px, 10px, 5px;  background:#ffd34c;  }#tarmsg {min-width:10px; max-width:100%; right: 0px; padding:10px, 5px, 10px, 5px;  background:#cecece;}#mytime {padding:5px, 0px, 20px, 0px; text-align:right; right: 0px; }#tartime {padding:5px, 0px, 20px, 0px; text-align:left; right: 0px; }.msg { font-size:12px;  }.time { font-size:10px;  }</style><body ondragstart='return false' onselectstart='return false'>";
			foreach (string message in CHAT_MAIN_MODULE.CHAT_CLASS.getMessages(CHAT_MAIN_MODULE.CHAT_NOWID))
			{
				string[] array = message.Split(new string[1] { "<split>" }, StringSplitOptions.None);
				text = ((Conversion.Val(array[0]) != 0.0) ? (text + "<div><div id=tarmsg class=msg>" + array[1] + "</div><div id=tartime class=time>" + array[2] + "</div></div>") : (text + "<div><div id=mymsg class=msg>" + array[1] + "</div><div id=mytime class=time>" + array[2] + "</div></div>"));
			}
			text += "</body></html>";
			WebBrowser1.DocumentText = text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		WebBrowser1.Document.Body.ScrollTop = WebBrowser1.Document.Body.ScrollRectangle.Height;
	}

	private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		CHAT_MAIN_MODULE.CHAT_CLASS.Send(CHAT_MAIN_MODULE.CHAT_NOWID, TextBox4.Text.Replace("\r\n", "<br>"));
		TextBox4.Text = null;
		setView();
		TextBox4.Focus();
	}

	private void TextBox4_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Control & (e.KeyCode == Keys.Return))
		{
			Button2_Click(RuntimeHelpers.GetObjectValue(sender), e);
			TextBox4.Text = null;
		}
		else if (e.KeyCode == Keys.Return)
		{
			e.Handled = false;
		}
	}

	private void Panel5_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Panel4_MouseDown(object sender, MouseEventArgs e)
	{
		ObjectMover.MoveObject(CHAT_MAIN_MODULE.CHAT_FORM.Handle);
		Application.DoEvents();
		ObjectMover.FocusObject(CHAT_MAIN_MODULE.CHAT_FORM.Handle);
	}

	private void CHAT_MAIN_Load(object sender, EventArgs e)
	{
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		CHAT_MAIN_MODULE.CHAT_NOWID = null;
		CHAT_MAIN_MODULE.CHAT_FORM.Close();
	}
}
