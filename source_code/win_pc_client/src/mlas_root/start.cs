using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class start : Form
{
	private IContainer components;

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

	[field: AccessedThroughProperty("DoubleBufferPanel1")]
	internal virtual DoubleBufferPanel DoubleBufferPanel1
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

	[field: AccessedThroughProperty("NoCopyLabel1")]
	internal virtual NoCopyLabel NoCopyLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public start()
	{
		base.Load += start_Load;
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
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.DoubleBufferPanel1 = new mlas_root.DoubleBufferPanel();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.NoCopyLabel1 = new mlas_root.NoCopyLabel();
		this.DoubleBufferPanel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1500;
		this.DoubleBufferPanel1.BackColor = System.Drawing.Color.White;
		this.DoubleBufferPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel1.Controls.Add(this.PictureBox1);
		this.DoubleBufferPanel1.Controls.Add(this.NoCopyLabel1);
		this.DoubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DoubleBufferPanel1.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel1.Name = "DoubleBufferPanel1";
		this.DoubleBufferPanel1.Padding = new System.Windows.Forms.Padding(10);
		this.DoubleBufferPanel1.Size = new System.Drawing.Size(132, 110);
		this.DoubleBufferPanel1.TabIndex = 2;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PictureBox1.Image = mlas_root.My.Resources.Resources.loading_animation3;
		this.PictureBox1.Location = new System.Drawing.Point(10, 10);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(110, 60);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.PictureBox1.TabIndex = 2;
		this.PictureBox1.TabStop = false;
		this.NoCopyLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.NoCopyLabel1.Location = new System.Drawing.Point(10, 70);
		this.NoCopyLabel1.Name = "NoCopyLabel1";
		this.NoCopyLabel1.Size = new System.Drawing.Size(110, 28);
		this.NoCopyLabel1.TabIndex = 3;
		this.NoCopyLabel1.Text = "여는 중...";
		this.NoCopyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(132, 110);
		base.Controls.Add(this.DoubleBufferPanel1);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "start";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MLAS";
		this.DoubleBufferPanel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	private void start_Load(object sender, EventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		string forceProject = Module1.forceProject;
		if (Operators.CompareString(forceProject, "android_db_ss_order", TextCompare: false) == 0)
		{
			Dispose();
			MyProject.Forms.ssorder_login.Show();
		}
		else
		{
			Dispose();
			MyProject.Forms.login.Show();
		}
	}
}
