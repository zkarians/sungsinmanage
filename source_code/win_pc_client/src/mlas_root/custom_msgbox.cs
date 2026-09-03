using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class custom_msgbox : Form
{
	public enum CMsgboxColor
	{
		None,
		Red,
		DarkGreen,
		Yellow,
		Blue
	}

	public enum CmsgBoxIcon
	{
		icon_Information = 64,
		icon_Error = 16,
		icon_Exclamation = 48,
		icon_None = 0,
		icon_Marquee = 99
	}

	public enum ShowLocation
	{
		TopLeft,
		TopCenter,
		TopRight,
		MiddleLeft,
		MiddleCenter,
		MiddleRight,
		BottomLeft,
		BottomCenter,
		BottomRight
	}

	private IContainer components;

	public string title;

	public string message;

	public CmsgBoxIcon iconType;

	public string buttonText;

	public int buttonColor;

	public bool autoClose;

	public int closetime;

	public string HtmlResult;

	public GetHtmlClass HtmlClass;

	private int mq;

	private bool @switch;

	[field: AccessedThroughProperty("Panel4")]
	internal virtual Panel Panel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlowLayoutPanel1")]
	internal virtual FlowLayoutPanel FlowLayoutPanel1
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
			MouseEventHandler value3 = PictureBox3_MouseMove;
			EventHandler value4 = PictureBox3_MouseLeave;
			PictureBox pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
				pictureBox.MouseMove -= value3;
				pictureBox.MouseLeave -= value4;
			}
			_PictureBox3 = value;
			pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
				pictureBox.MouseMove += value3;
				pictureBox.MouseLeave += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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
			MouseEventHandler value2 = PictureBox1_MouseDown;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
			}
		}
	}

	internal virtual Timer fadein
	{
		[CompilerGenerated]
		get
		{
			return _fadein;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = fadein_Tick;
			Timer timer = _fadein;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_fadein = value;
			timer = _fadein;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
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
			KeyEventHandler value3 = Button10_KeyDown;
			Button button = _Button10;
			if (button != null)
			{
				button.Click -= value2;
				button.KeyDown -= value3;
			}
			_Button10 = value;
			button = _Button10;
			if (button != null)
			{
				button.Click += value2;
				button.KeyDown += value3;
			}
		}
	}

	internal virtual Timer fadeout
	{
		[CompilerGenerated]
		get
		{
			return _fadeout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = fadeout_Tick;
			Timer timer = _fadeout;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_fadeout = value;
			timer = _fadeout;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer aClose
	{
		[CompilerGenerated]
		get
		{
			return _aClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = aClose_Tick;
			Timer timer = _aClose;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_aClose = value;
			timer = _aClose;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("FlowLayoutPanel2")]
	internal virtual FlowLayoutPanel FlowLayoutPanel2
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer marquee
	{
		[CompilerGenerated]
		get
		{
			return _marquee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = marquee_Tick;
			Timer timer = _marquee;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_marquee = value;
			timer = _marquee;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	public custom_msgbox()
	{
		base.Load += custom_msgbox_Load;
		base.FormClosing += custom_msgbox_FormClosing;
		title = null;
		message = null;
		buttonText = "닫기";
		buttonColor = 0;
		autoClose = false;
		closetime = 1000;
		HtmlResult = null;
		HtmlClass = null;
		@switch = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.custom_msgbox));
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Label2 = new System.Windows.Forms.Label();
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
		this.Button10 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.fadein = new System.Windows.Forms.Timer(this.components);
		this.fadeout = new System.Windows.Forms.Timer(this.components);
		this.aClose = new System.Windows.Forms.Timer(this.components);
		this.marquee = new System.Windows.Forms.Timer(this.components);
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Label1 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Panel1.SuspendLayout();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		this.FlowLayoutPanel2.SuspendLayout();
		this.Panel4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.FlowLayoutPanel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		base.SuspendLayout();
		this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel1.Controls.Add(this.Panel3);
		this.Panel1.Controls.Add(this.TextBox1);
		this.Panel1.Controls.Add(this.PictureBox2);
		this.Panel1.Controls.Add(this.Panel2);
		this.Panel1.Controls.Add(this.FlowLayoutPanel2);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(0, 28);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(414, 101);
		this.Panel1.TabIndex = 20;
		this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel3.Controls.Add(this.Label2);
		this.Panel3.Controls.Add(this.ProgressBar1);
		this.Panel3.Cursor = System.Windows.Forms.Cursors.AppStarting;
		this.Panel3.Location = new System.Drawing.Point(68, 9);
		this.Panel3.Name = "Panel3";
		this.Panel3.Padding = new System.Windows.Forms.Padding(5);
		this.Panel3.Size = new System.Drawing.Size(220, 60);
		this.Panel3.TabIndex = 39;
		this.Panel3.Visible = false;
		this.Label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
		this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label2.ForeColor = System.Drawing.Color.SteelBlue;
		this.Label2.Location = new System.Drawing.Point(5, 36);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(208, 17);
		this.Label2.TabIndex = 39;
		this.Label2.Text = "잠시만 기다려 주십시오...";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
		this.ProgressBar1.Cursor = System.Windows.Forms.Cursors.AppStarting;
		this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top;
		this.ProgressBar1.Location = new System.Drawing.Point(5, 5);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(208, 31);
		this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
		this.ProgressBar1.TabIndex = 38;
		this.TextBox1.BackColor = System.Drawing.Color.White;
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.TextBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.TextBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75f);
		this.TextBox1.Location = new System.Drawing.Point(99, 9);
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.Size = new System.Drawing.Size(296, 51);
		this.TextBox1.TabIndex = 37;
		this.TextBox1.TabStop = false;
		this.PictureBox2.Location = new System.Drawing.Point(0, 3);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(99, 72);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.PictureBox2.TabIndex = 0;
		this.PictureBox2.TabStop = false;
		this.Panel2.BackColor = System.Drawing.Color.DarkGray;
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 67);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(412, 1);
		this.Panel2.TabIndex = 36;
		this.FlowLayoutPanel2.Controls.Add(this.Button10);
		this.FlowLayoutPanel2.Controls.Add(this.Button1);
		this.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.FlowLayoutPanel2.Location = new System.Drawing.Point(0, 68);
		this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
		this.FlowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.FlowLayoutPanel2.Size = new System.Drawing.Size(412, 31);
		this.FlowLayoutPanel2.TabIndex = 36;
		this.Button10.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button10.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button10.BackgroundImage");
		this.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button10.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button10.ForeColor = System.Drawing.Color.White;
		this.Button10.Location = new System.Drawing.Point(324, 3);
		this.Button10.Margin = new System.Windows.Forms.Padding(6, 3, 0, 0);
		this.Button10.Name = "Button10";
		this.Button10.Size = new System.Drawing.Size(82, 24);
		this.Button10.TabIndex = 34;
		this.Button10.Text = "백업";
		this.Button10.UseVisualStyleBackColor = false;
		this.Button1.BackColor = System.Drawing.Color.Blue;
		this.Button1.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(159, 3);
		this.Button1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(162, 24);
		this.Button1.TabIndex = 35;
		this.Button1.Text = "표시안함";
		this.Button1.UseVisualStyleBackColor = false;
		this.fadein.Interval = 5;
		this.fadeout.Interval = 5;
		this.marquee.Interval = 20;
		this.Panel4.BackgroundImage = mlas_root.My.Resources.Resources.topbar;
		this.Panel4.Controls.Add(this.Label1);
		this.Panel4.Controls.Add(this.PictureBox1);
		this.Panel4.Controls.Add(this.FlowLayoutPanel1);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(0, 0);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(414, 28);
		this.Panel4.TabIndex = 19;
		this.Label1.AutoSize = true;
		this.Label1.BackColor = System.Drawing.Color.Transparent;
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(311, 9);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(67, 12);
		this.Label1.TabIndex = 36;
		this.Label1.Text = "3초 후 닫힘";
		this.Label1.Visible = false;
		this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PictureBox1.Location = new System.Drawing.Point(0, 0);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(0);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(384, 28);
		this.PictureBox1.TabIndex = 6;
		this.PictureBox1.TabStop = false;
		this.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
		this.FlowLayoutPanel1.Controls.Add(this.PictureBox3);
		this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
		this.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
		this.FlowLayoutPanel1.Location = new System.Drawing.Point(384, 0);
		this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
		this.FlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
		this.FlowLayoutPanel1.Size = new System.Drawing.Size(30, 28);
		this.FlowLayoutPanel1.TabIndex = 5;
		this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox3.Image = mlas_root.My.Resources.Resources.close1;
		this.PictureBox3.Location = new System.Drawing.Point(4, 5);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(19, 18);
		this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox3.TabIndex = 0;
		this.PictureBox3.TabStop = false;
		this.Timer1.Enabled = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(414, 129);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Panel4);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "custom_msgbox";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "custom_msgbox";
		base.TopMost = true;
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		this.FlowLayoutPanel2.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.FlowLayoutPanel1.ResumeLayout(false);
		this.FlowLayoutPanel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		base.ResumeLayout(false);
	}

	private void custom_msgbox_Load(object sender, EventArgs e)
	{
		Timer1.Start();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Timer1.Stop();
		if (HtmlClass == null)
		{
			Text = title;
			TextBox1.Text = message;
			PictureBox1.Image = titleImage();
			switch (iconType)
			{
			case CmsgBoxIcon.icon_Exclamation:
				PictureBox2.Image = Resources.msgbox_information;
				Button1.Hide();
				break;
			case CmsgBoxIcon.icon_Error:
				PictureBox2.Image = Resources.msgbox_error;
				Button1.Hide();
				break;
			case CmsgBoxIcon.icon_Information:
				PictureBox2.Image = Resources.msgbox_information;
				break;
			case CmsgBoxIcon.icon_None:
				PictureBox2.Hide();
				TextBox1.Dock = DockStyle.Fill;
				break;
			case CmsgBoxIcon.icon_Marquee:
				base.ShowInTaskbar = false;
				marquee.Start();
				Panel2.Hide();
				Panel4.Hide();
				base.TransparencyKey = Color.White;
				base.Location = checked(new Point((int)Math.Round((double)base.Location.X + (double)(base.Size.Width - 30) / 2.0), (int)Math.Round((double)base.Location.Y + (double)(base.Size.Height - 30) / 2.0)));
				Panel1.BorderStyle = BorderStyle.None;
				base.Size = new Size(30, 30);
				PictureBox2.Dock = DockStyle.Fill;
				TextBox1.Hide();
				FlowLayoutPanel2.Hide();
				break;
			default:
				PictureBox2.Image = Resources.msgbox_information;
				break;
			}
			switch (buttonColor)
			{
			case 0:
				Button10.BackColor = Color.FromArgb(230, 230, 230);
				Button10.BackgroundImage = Resources.public_button_close;
				break;
			case 1:
				Button10.BackColor = Color.Red;
				Button10.BackgroundImage = Resources.public_button;
				break;
			case 2:
				Button10.BackColor = Color.DarkGreen;
				Button10.BackgroundImage = Resources.public_button;
				break;
			case 3:
				Button10.BackColor = Color.FromArgb(192, 192, 0);
				Button10.BackgroundImage = Resources.public_button;
				break;
			case 4:
				Button10.BackColor = Color.Blue;
				Button10.BackgroundImage = Resources.public_button;
				break;
			}
			Button10.Text = buttonText;
			Button10.Focus();
			fadein.Start();
			if (autoClose)
			{
				Label1.Visible = true;
				Label1.Text = Conversions.ToString(Math.Ceiling((double)closetime / 1000.0)) + "초 후 닫음";
			}
		}
		else
		{
			func();
		}
	}

	public void func()
	{
		base.TopMost = false;
		base.ShowInTaskbar = false;
		Panel2.Hide();
		Panel4.Hide();
		base.Location = checked(new Point((int)Math.Round((double)base.Location.X + (double)(base.Size.Width - 220) / 2.0), (int)Math.Round((double)base.Location.Y + (double)(base.Size.Height - 80) / 2.0)));
		Panel1.BorderStyle = BorderStyle.None;
		base.Size = new Size(220, 60);
		Panel3.Dock = DockStyle.Fill;
		Panel3.Visible = true;
		Application.DoEvents();
		TextBox1.Hide();
		FlowLayoutPanel2.Hide();
		base.Opacity = 0.8999999761581421;
		HtmlResult = HtmlClass.getHTMLProgress();
		base.DialogResult = DialogResult.OK;
	}

	private Bitmap titleImage()
	{
		Bitmap bitmap = new Bitmap(500, 50);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.AntiAlias;
		Pen pen = new Pen(new SolidBrush(Color.FromArgb(80, 80, 80)), 4f);
		Pen pen2 = new Pen(new SolidBrush(Color.FromArgb(146, 144, 0)), 1f);
		using (GraphicsPath graphicsPath = new GraphicsPath())
		{
			using Font font = new Font("맑은 고딕", 14f, FontStyle.Bold);
			graphicsPath.AddString(title, font.FontFamily, (int)font.Style, font.Size, new Point(20, 4), StringFormat.GenericTypographic);
			graphics.DrawPath(pen, graphicsPath);
			graphics.DrawPath(pen2, graphicsPath);
			graphics.FillPath(Brushes.Yellow, graphicsPath);
		}
		graphics.Dispose();
		return bitmap;
	}

	private void marquee_Tick(object sender, EventArgs e)
	{
	}

	private Bitmap DrawProgress(Rectangle rect, float percentage, bool reverse = false)
	{
		Bitmap bitmap = new Bitmap(base.Size.Width, base.Size.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		float num = (float)(3.6 * (double)percentage);
		float sweepAngle = 360f - num;
		Color color = Color.Blue;
		Color color2 = Color.White;
		if (reverse)
		{
			color = Color.White;
			color2 = Color.Red;
		}
		graphics.SmoothingMode = SmoothingMode.HighSpeed;
		using (Pen pen2 = new Pen(color, 20f))
		{
			using Pen pen = new Pen(color2, 20f);
			graphics.DrawArc(pen, rect, num - 90f, sweepAngle);
			graphics.DrawArc(pen2, rect, -90f, num);
			graphics.FillEllipse(Brushes.White, 2, 2, 8, 8);
		}
		graphics.Dispose();
		return bitmap;
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		fadeout.Start();
	}

	private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox3.Image = Resources.close2;
	}

	private void PictureBox3_MouseLeave(object sender, EventArgs e)
	{
		PictureBox3.Image = Resources.close1;
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		if (autoClose)
		{
			aClose.Stop();
			Label1.Hide();
		}
		try
		{
			ObjectMover.MoveObject(base.Handle);
			Application.DoEvents();
			ObjectMover.FocusObject(base.Handle);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void fadein_Tick(object sender, EventArgs e)
	{
		if (base.Opacity >= 1.0)
		{
			fadein.Stop();
			base.Opacity = 1.0;
			if (autoClose)
			{
				aClose.Interval = closetime;
				aClose.Start();
			}
		}
		else
		{
			base.Opacity += 0.2;
		}
	}

	private void fadeout_Tick(object sender, EventArgs e)
	{
		if (base.Opacity <= 0.0)
		{
			fadeout.Stop();
			Close();
		}
		else
		{
			base.Opacity -= 0.2;
		}
	}

	private void aClose_Tick(object sender, EventArgs e)
	{
		aClose.Stop();
		fadeout.Start();
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		fadein.Stop();
		fadeout.Start();
	}

	private void Button10_KeyDown(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode == Keys.Escape)
		{
			fadein.Stop();
			fadeout.Start();
		}
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		Module1.CMsgboxOption = false;
		aClose.Stop();
		fadein.Stop();
		Label1.Hide();
		Button1.Hide();
		PictureBox1.Image = titleImage();
		fadeout.Start();
	}

	private void custom_msgbox_FormClosing(object sender, FormClosingEventArgs e)
	{
		CustomMsgBox.CMsgBox_icon = CmsgBoxIcon.icon_None;
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
	}
}
