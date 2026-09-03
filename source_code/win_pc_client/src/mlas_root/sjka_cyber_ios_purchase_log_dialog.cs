using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using mlas_root.My;

namespace mlas_root;

[DesignerGenerated]
public class sjka_cyber_ios_purchase_log_dialog : Form
{
	private IContainer components;

	public string id;

	private List<sjka_cyber_ios_purchase_log> list;

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

	[field: AccessedThroughProperty("datagrid")]
	internal virtual DataGridView datagrid
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

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public sjka_cyber_ios_purchase_log_dialog()
	{
		base.Load += sjka_cyber_ios_purchase_log_dialog_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.sjka_cyber_ios_purchase_log_dialog));
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.datagrid = new System.Windows.Forms.DataGridView();
		this.Button1 = new System.Windows.Forms.Button();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		((System.ComponentModel.ISupportInitialize)this.datagrid).BeginInit();
		this.Panel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.Font = new System.Drawing.Font("맑은 고딕", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label1.Location = new System.Drawing.Point(0, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(834, 36);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "txt";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label2.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label2.Location = new System.Drawing.Point(0, 36);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(538, 34);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "최근 1년 까지의 결제 성공한 기록만 조회 가능합니다.";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.datagrid.AllowUserToAddRows = false;
		this.datagrid.AllowUserToDeleteRows = false;
		this.datagrid.AllowUserToOrderColumns = true;
		this.datagrid.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.Gainsboro;
		this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.datagrid.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.Format = "C2";
		dataGridViewCellStyle2.NullValue = "0";
		dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.datagrid.DefaultCellStyle = dataGridViewCellStyle3;
		this.datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
		this.datagrid.EnableHeadersVisualStyles = false;
		this.datagrid.GridColor = System.Drawing.Color.DarkGray;
		this.datagrid.Location = new System.Drawing.Point(0, 70);
		this.datagrid.MultiSelect = false;
		this.datagrid.Name = "datagrid";
		this.datagrid.RowHeadersWidth = 30;
		this.datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.datagrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
		this.datagrid.RowTemplate.Height = 50;
		this.datagrid.RowTemplate.ReadOnly = true;
		this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.datagrid.Size = new System.Drawing.Size(834, 572);
		this.datagrid.TabIndex = 58;
		this.Button1.Location = new System.Drawing.Point(194, 4);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(87, 27);
		this.Button1.TabIndex = 59;
		this.Button1.Text = "검색";
		this.Button1.UseVisualStyleBackColor = true;
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.Panel2);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(834, 70);
		this.Panel1.TabIndex = 60;
		this.Panel2.Controls.Add(this.TextBox3);
		this.Panel2.Controls.Add(this.Button1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel2.Location = new System.Drawing.Point(538, 36);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(296, 34);
		this.Panel2.TabIndex = 61;
		this.TextBox3.BackColor = System.Drawing.Color.White;
		this.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox3.Font = new System.Drawing.Font("맑은 고딕", 10f);
		this.TextBox3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox3.Location = new System.Drawing.Point(3, 5);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.Size = new System.Drawing.Size(186, 25);
		this.TextBox3.TabIndex = 60;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(834, 642);
		base.Controls.Add(this.datagrid);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		this.MinimumSize = new System.Drawing.Size(850, 681);
		base.Name = "sjka_cyber_ios_purchase_log_dialog";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "회원 결제 기록";
		((System.ComponentModel.ISupportInitialize)this.datagrid).EndInit();
		this.Panel1.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		base.ResumeLayout(false);
	}

	private void sjka_cyber_ios_purchase_log_dialog_Load(object sender, EventArgs e)
	{
		TextBox3.Text = id;
		listRefresh();
	}

	private void listRefresh()
	{
		Label1.Text = "[" + (id + " 검색결과]").Trim() + " " + DateTime.Now.AddYears(-1).ToString("yyyy년 MM월 dd일") + " ~ " + DateTime.Now.ToString("yyyy년 MM월 dd일") + " 조회 결과";
		list = new List<sjka_cyber_ios_purchase_log>();
		datagrid.DataSource = null;
		string hTML = new GetHtmlClass(Module1._dburl + "/set.php?t=getPurchaseLog", "p=" + MySettingsProperty.Settings.pw + "&i=" + id, progress: true).getHTML(this);
		list = JsonConvert.DeserializeObject<List<sjka_cyber_ios_purchase_log>>(hTML);
		datagrid.DataSource = list;
		datagrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		datagrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		datagrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		datagrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		datagrid.Columns[0].HeaderText = "고유번호";
		datagrid.Columns[1].HeaderText = "결제일시";
		datagrid.Columns[2].HeaderText = "회원ID 또는 UUID(앱 고유번호)";
		datagrid.Columns[3].HeaderText = "구매항목";
		checked
		{
			int num = datagrid.Columns.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = datagrid.Columns[i].Width;
				datagrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				datagrid.Columns[i].Width = num2;
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		id = TextBox3.Text.Trim();
		listRefresh();
	}

	private void TextBox3_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
