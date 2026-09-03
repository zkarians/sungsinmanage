using System;
using System.Collections;
using System.Collections.Generic;
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
public class cti_split_custom : Form
{
	private IContainer components;

	public cti_db selectDb;

	private List<cti_agents> ctiAgents;

	private List<cti_result_count> ctiAgentsResultCount;

	private object busy;

	[field: AccessedThroughProperty("split_grid")]
	internal virtual DataGridView split_grid
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

	internal virtual Button rand_start
	{
		[CompilerGenerated]
		get
		{
			return _rand_start;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = rand_start_Click;
			Button button = _rand_start;
			if (button != null)
			{
				button.Click -= value2;
			}
			_rand_start = value;
			button = _rand_start;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button popsplit_start
	{
		[CompilerGenerated]
		get
		{
			return _popsplit_start;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = popsplit_start_Click;
			Button button = _popsplit_start;
			if (button != null)
			{
				button.Click -= value2;
			}
			_popsplit_start = value;
			button = _popsplit_start;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button closeform
	{
		[CompilerGenerated]
		get
		{
			return _closeform;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = close_Click;
			Button button = _closeform;
			if (button != null)
			{
				button.Click -= value2;
			}
			_closeform = value;
			button = _closeform;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nosplit_count")]
	internal virtual Label nosplit_count
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dbname")]
	internal virtual Label dbname
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("Column3")]
	internal virtual DataGridViewTextBoxColumn Column3
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

	[field: AccessedThroughProperty("Column4")]
	internal virtual DataGridViewTextBoxColumn Column4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn17")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public cti_split_custom()
	{
		base.Load += cti_split_custom_Load;
		base.FormClosed += cti_split_custom_FormClosed;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.cti_split_custom));
		this.split_grid = new System.Windows.Forms.DataGridView();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.closeform = new System.Windows.Forms.Button();
		this.popsplit_start = new System.Windows.Forms.Button();
		this.rand_start = new System.Windows.Forms.Button();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.nosplit_count = new System.Windows.Forms.Label();
		this.dbname = new System.Windows.Forms.Label();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		((System.ComponentModel.ISupportInitialize)this.split_grid).BeginInit();
		this.Panel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		base.SuspendLayout();
		this.split_grid.AllowUserToAddRows = false;
		this.split_grid.AllowUserToDeleteRows = false;
		this.split_grid.AllowUserToOrderColumns = true;
		this.split_grid.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.split_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.split_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.split_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.split_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.split_grid.ColumnHeadersHeight = 24;
		this.split_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.split_grid.Columns.AddRange(this.Column1, this.Column2, this.DataGridViewTextBoxColumn15, this.Column3, this.DataGridViewTextBoxColumn16, this.Column4, this.DataGridViewTextBoxColumn17);
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.split_grid.DefaultCellStyle = dataGridViewCellStyle3;
		this.split_grid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.split_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.split_grid.EnableHeadersVisualStyles = false;
		this.split_grid.Location = new System.Drawing.Point(0, 70);
		this.split_grid.MultiSelect = false;
		this.split_grid.Name = "split_grid";
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.split_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.split_grid.RowHeadersVisible = false;
		this.split_grid.RowTemplate.Height = 23;
		this.split_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
		this.split_grid.Size = new System.Drawing.Size(523, 379);
		this.split_grid.TabIndex = 67;
		this.Panel1.Controls.Add(this.closeform);
		this.Panel1.Controls.Add(this.popsplit_start);
		this.Panel1.Controls.Add(this.rand_start);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 533);
		this.Panel1.Name = "Panel1";
		this.Panel1.Padding = new System.Windows.Forms.Padding(5);
		this.Panel1.Size = new System.Drawing.Size(523, 39);
		this.Panel1.TabIndex = 68;
		this.closeform.BackColor = System.Drawing.Color.Red;
		this.closeform.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.closeform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.closeform.Dock = System.Windows.Forms.DockStyle.Left;
		this.closeform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.closeform.ForeColor = System.Drawing.Color.White;
		this.closeform.Location = new System.Drawing.Point(5, 5);
		this.closeform.Name = "closeform";
		this.closeform.Size = new System.Drawing.Size(79, 29);
		this.closeform.TabIndex = 14;
		this.closeform.Text = "닫기";
		this.closeform.UseVisualStyleBackColor = false;
		this.popsplit_start.BackColor = System.Drawing.Color.Blue;
		this.popsplit_start.BackgroundImage = (System.Drawing.Image)resources.GetObject("popsplit_start.BackgroundImage");
		this.popsplit_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.popsplit_start.Dock = System.Windows.Forms.DockStyle.Right;
		this.popsplit_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.popsplit_start.ForeColor = System.Drawing.Color.White;
		this.popsplit_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.popsplit_start.Location = new System.Drawing.Point(298, 5);
		this.popsplit_start.Name = "popsplit_start";
		this.popsplit_start.Size = new System.Drawing.Size(110, 29);
		this.popsplit_start.TabIndex = 12;
		this.popsplit_start.Text = "순차 배분 시작";
		this.popsplit_start.UseVisualStyleBackColor = false;
		this.rand_start.BackColor = System.Drawing.Color.FromArgb(192, 0, 192);
		this.rand_start.BackgroundImage = (System.Drawing.Image)resources.GetObject("rand_start.BackgroundImage");
		this.rand_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.rand_start.Dock = System.Windows.Forms.DockStyle.Right;
		this.rand_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.rand_start.ForeColor = System.Drawing.Color.White;
		this.rand_start.Location = new System.Drawing.Point(408, 5);
		this.rand_start.Name = "rand_start";
		this.rand_start.Size = new System.Drawing.Size(110, 29);
		this.rand_start.TabIndex = 13;
		this.rand_start.Text = "랜덤 배분 시작";
		this.rand_start.UseVisualStyleBackColor = false;
		this.Panel2.Controls.Add(this.nosplit_count);
		this.Panel2.Controls.Add(this.dbname);
		this.Panel2.Controls.Add(this.Label10);
		this.Panel2.Controls.Add(this.Label9);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(523, 70);
		this.Panel2.TabIndex = 69;
		this.nosplit_count.BackColor = System.Drawing.SystemColors.Control;
		this.nosplit_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.nosplit_count.ForeColor = System.Drawing.Color.Black;
		this.nosplit_count.Location = new System.Drawing.Point(163, 37);
		this.nosplit_count.Name = "nosplit_count";
		this.nosplit_count.Size = new System.Drawing.Size(296, 20);
		this.nosplit_count.TabIndex = 29;
		this.nosplit_count.Text = "0";
		this.nosplit_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.dbname.BackColor = System.Drawing.SystemColors.Control;
		this.dbname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.dbname.ForeColor = System.Drawing.Color.RoyalBlue;
		this.dbname.Location = new System.Drawing.Point(163, 14);
		this.dbname.Name = "dbname";
		this.dbname.Size = new System.Drawing.Size(296, 20);
		this.dbname.TabIndex = 28;
		this.dbname.Text = "없음";
		this.dbname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label10.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label10.ForeColor = System.Drawing.Color.Black;
		this.Label10.Location = new System.Drawing.Point(41, 37);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(114, 20);
		this.Label10.TabIndex = 27;
		this.Label10.Text = "총 미배분 건수";
		this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label9.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label9.ForeColor = System.Drawing.Color.Black;
		this.Label9.Location = new System.Drawing.Point(41, 14);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(114, 20);
		this.Label9.TabIndex = 26;
		this.Label9.Text = "데이터베이스 이름";
		this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel3.Controls.Add(this.CheckBox2);
		this.Panel3.Controls.Add(this.GroupBox1);
		this.Panel3.Controls.Add(this.CheckBox1);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel3.Location = new System.Drawing.Point(0, 449);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(523, 84);
		this.Panel3.TabIndex = 70;
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.Location = new System.Drawing.Point(13, 10);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(76, 16);
		this.CheckBox2.TabIndex = 37;
		this.CheckBox2.Text = "전체 선택";
		this.CheckBox2.UseVisualStyleBackColor = true;
		this.GroupBox1.Controls.Add(this.TextBox1);
		this.GroupBox1.Controls.Add(this.Button2);
		this.GroupBox1.Controls.Add(this.Button1);
		this.GroupBox1.Location = new System.Drawing.Point(12, 34);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(368, 46);
		this.GroupBox1.TabIndex = 36;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "선택한 항목 배분량 설정";
		this.TextBox1.Location = new System.Drawing.Point(9, 17);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(127, 21);
		this.TextBox1.TabIndex = 32;
		this.Button2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button2.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button2.ForeColor = System.Drawing.Color.White;
		this.Button2.Location = new System.Drawing.Point(224, 17);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(126, 21);
		this.Button2.TabIndex = 35;
		this.Button2.Text = "배분량 자동 나누기";
		this.Button2.UseVisualStyleBackColor = false;
		this.Button1.BackColor = System.Drawing.Color.DarkGreen;
		this.Button1.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(139, 17);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(75, 21);
		this.Button1.TabIndex = 34;
		this.Button1.Text = "설정";
		this.Button1.UseVisualStyleBackColor = false;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Location = new System.Drawing.Point(95, 10);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(152, 16);
		this.CheckBox1.TabIndex = 31;
		this.CheckBox1.Text = "접속중인 상담원만 보기";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.Column1.HeaderText = "agent_idx";
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.Column1.Visible = false;
		this.Column2.HeaderText = "";
		this.Column2.Name = "Column2";
		this.Column2.Width = 30;
		this.DataGridViewTextBoxColumn15.HeaderText = "상담원명";
		this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
		this.DataGridViewTextBoxColumn15.ReadOnly = true;
		this.DataGridViewTextBoxColumn15.Width = 130;
		this.Column3.HeaderText = "배분된 건수";
		this.Column3.Name = "Column3";
		this.Column3.ReadOnly = true;
		this.Column3.Width = 80;
		this.DataGridViewTextBoxColumn16.HeaderText = "미처리 건수";
		this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
		this.DataGridViewTextBoxColumn16.ReadOnly = true;
		this.DataGridViewTextBoxColumn16.Width = 80;
		this.Column4.HeaderText = "동의 건수";
		this.Column4.Name = "Column4";
		this.Column4.ReadOnly = true;
		this.Column4.Width = 80;
		this.DataGridViewTextBoxColumn17.HeaderText = "배분량 설정";
		this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(523, 572);
		base.Controls.Add(this.split_grid);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		this.MinimumSize = new System.Drawing.Size(539, 611);
		base.Name = "cti_split_custom";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "사용자 정의 배분";
		((System.ComponentModel.ISupportInitialize)this.split_grid).EndInit();
		this.Panel1.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel3.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void cti_split_custom_Load(object sender, EventArgs e)
	{
		MyProject.Forms.ssorder_cti.getAgents();
		ctiAgents = MyProject.Forms.ssorder_cti.ctiAgents;
		getAgentsResult();
		viewChange(online: false);
		dbname.Text = selectDb.name;
		nosplit_count.Text = Conversions.ToString(checked(selectDb.nosplit_count - selectDb.blacklist_count));
	}

	private void viewChange(bool online)
	{
		split_grid.Rows.Clear();
		using (List<cti_agents>.Enumerator enumerator = ctiAgents.GetEnumerator())
		{
			_Closure_0024__104_002D0 closure_0024__104_002D = default(_Closure_0024__104_002D0);
			while (enumerator.MoveNext())
			{
				closure_0024__104_002D = new _Closure_0024__104_002D0(closure_0024__104_002D);
				closure_0024__104_002D._0024VB_0024Local_db = enumerator.Current;
				if (!(online & !closure_0024__104_002D._0024VB_0024Local_db.logging.HasValue) && closure_0024__104_002D._0024VB_0024Local_db.expire == 0)
				{
					cti_result_count cti_result_count2 = ctiAgentsResultCount.Find(closure_0024__104_002D._Lambda_0024__0);
					if (cti_result_count2 == null)
					{
						split_grid.Rows.Add(closure_0024__104_002D._0024VB_0024Local_db.account_code, CheckBox2.Checked, closure_0024__104_002D._0024VB_0024Local_db.account_name, 0, 0, 0);
					}
					else
					{
						split_grid.Rows.Add(closure_0024__104_002D._0024VB_0024Local_db.account_code, CheckBox2.Checked, closure_0024__104_002D._0024VB_0024Local_db.account_name, cti_result_count2.resultAll, cti_result_count2.result0, cti_result_count2.result1);
					}
				}
			}
		}
		split_grid.Sort(split_grid.Columns[2], ListSortDirection.Ascending);
		split_grid.ClearSelection();
	}

	private void getAgentsResult()
	{
		JObject jObject = new JObject();
		jObject.Add("type", "getAgentsResult");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("db_idx", selectDb.idx);
		string postData = "args=" + jObject.ToString(Formatting.None);
		try
		{
			JObject jObject2 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_get.php")), postData, progress: true).getHTML(this));
			if (jObject2.SelectToken("response").Equals("fail"))
			{
				Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
				return;
			}
			JToken jToken = jObject2.SelectToken("response");
			if ((string)jToken == "ok")
			{
				ctiAgentsResultCount = JsonConvert.DeserializeObject<List<cti_result_count>>((string)jObject2.SelectToken("output"));
			}
			else if ((string)jToken == "fail")
			{
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex2.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			ProjectData.ClearProjectError();
		}
	}

	private void close_Click(object sender, EventArgs e)
	{
		Dispose();
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		viewChange(CheckBox1.Checked);
	}

	private void popsplit_start_Click(object sender, EventArgs e)
	{
		startSplit(random: false);
	}

	private void rand_start_Click(object sender, EventArgs e)
	{
		startSplit(random: true);
	}

	private void startSplit(bool random)
	{
		if (Conversions.ToBoolean(busy))
		{
			return;
		}
		busy = true;
		List<JObject> list = new List<JObject>();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)split_grid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (!Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[6].Value, null, TextCompare: false) && !Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, false, TextCompare: false))
				{
					JObject jObject = new JObject();
					jObject.Add("idx", dataGridViewRow.Cells[0].Value.ToString());
					jObject.Add("count", dataGridViewRow.Cells[6].Value.ToString());
					list.Add(jObject);
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
		if (list.Count <= 0)
		{
			busy = false;
			return;
		}
		string str = JsonConvert.SerializeObject(list);
		int num = Conversions.ToInteger(Interaction.IIf(random, 1, 0));
		JObject jObject2 = new JObject();
		jObject2.Add("type", "customPutAgent");
		jObject2.Add("id", Module1._id);
		jObject2.Add("pw", Module1._pw);
		jObject2.Add("db_idx", selectDb.idx);
		jObject2.Add("idxs", Module1.Base64Encode(str).ToString());
		jObject2.Add("random", num);
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
				MyProject.Forms.ssorder_cti.getDB(refresh: true);
				Dispose();
			}
			else if ((string)jToken == "fail")
			{
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject3.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
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

	private void Button1_Click(object sender, EventArgs e)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)split_grid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (Operators.ConditionalCompareObjectEqual(((DataGridViewCheckBoxCell)dataGridViewRow.Cells[1]).Value, true, TextCompare: false))
				{
					try
					{
						dataGridViewRow.Cells[6].Value = Conversion.Val(TextBox1.Text.Trim());
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						Interaction.MsgBox("숫자만 입력 가능합니다.");
						ProjectData.ClearProjectError();
						break;
					}
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

	private void Button2_Click(object sender, EventArgs e)
	{
		int num = 0;
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)split_grid.Rows).GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.ConditionalCompareObjectEqual(((DataGridViewRow)enumerator.Current).Cells[1].Value, true, TextCompare: false))
					{
						num++;
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
			double num2 = Math.Ceiling((double)(selectDb.nosplit_count - selectDb.blacklist_count) / (double)num);
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = ((IEnumerable)split_grid.Rows).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator2.Current;
					if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[1].Value, true, TextCompare: false))
					{
						dataGridViewRow.Cells[6].Value = num2;
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
		}
	}

	private void CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		bool @checked = CheckBox2.Checked;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)split_grid.Rows).GetEnumerator();
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

	private void cti_split_custom_FormClosed(object sender, FormClosedEventArgs e)
	{
		Dispose();
	}
}
