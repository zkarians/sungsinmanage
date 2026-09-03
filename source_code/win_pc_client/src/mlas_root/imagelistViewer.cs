using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class imagelistViewer : Form
{
	private class ivClass
	{
		public object num
		{
			[CompilerGenerated]
			get
			{
				return _num;
			}
			[CompilerGenerated]
			set
			{
				_num = RuntimeHelpers.GetObjectValue(value);
			}
		}
	}

	private IContainer components;

	private string selectUrl;

	private string loadUrl;

	private string uploadUrl;

	private string delUrl;

	private List<ivClass> ivList;

	[field: AccessedThroughProperty("DoubleBufferPanel1")]
	internal virtual DoubleBufferPanel DoubleBufferPanel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("img")]
	internal virtual PictureBox img
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView imglistGrid
	{
		[CompilerGenerated]
		get
		{
			return _imglistGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = imglistGrid_CellClick;
			KeyEventHandler value3 = imglistGrid_KeyUp;
			DataGridView dataGridView = _imglistGrid;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
				dataGridView.KeyUp -= value3;
			}
			_imglistGrid = value;
			dataGridView = _imglistGrid;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
				dataGridView.KeyUp += value3;
			}
		}
	}

	[field: AccessedThroughProperty("title")]
	internal virtual Label title
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel30")]
	internal virtual DoubleBufferPanel Panel30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button refresh
	{
		[CompilerGenerated]
		get
		{
			return _refresh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = refresh_Click;
			Button button = _refresh;
			if (button != null)
			{
				button.Click -= value2;
			}
			_refresh = value;
			button = _refresh;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button delete
	{
		[CompilerGenerated]
		get
		{
			return _delete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = delete_Click;
			Button button = _delete;
			if (button != null)
			{
				button.Click -= value2;
			}
			_delete = value;
			button = _delete;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button upload
	{
		[CompilerGenerated]
		get
		{
			return _upload;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = upload_Click;
			Button button = _upload;
			if (button != null)
			{
				button.Click -= value2;
			}
			_upload = value;
			button = _upload;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button selectall
	{
		[CompilerGenerated]
		get
		{
			return _selectall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = selectall_Click;
			Button button = _selectall;
			if (button != null)
			{
				button.Click -= value2;
			}
			_selectall = value;
			button = _selectall;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ReadonlyListView1")]
	internal virtual readonlyListView ReadonlyListView1
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.imagelistViewer));
		this.DoubleBufferPanel1 = new mlas_root.DoubleBufferPanel();
		this.img = new System.Windows.Forms.PictureBox();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.Label1 = new System.Windows.Forms.Label();
		this.RadioButton3 = new System.Windows.Forms.RadioButton();
		this.RadioButton2 = new System.Windows.Forms.RadioButton();
		this.RadioButton1 = new System.Windows.Forms.RadioButton();
		this.title = new System.Windows.Forms.Label();
		this.imglistGrid = new System.Windows.Forms.DataGridView();
		this.Panel30 = new mlas_root.DoubleBufferPanel();
		this.refresh = new System.Windows.Forms.Button();
		this.delete = new System.Windows.Forms.Button();
		this.upload = new System.Windows.Forms.Button();
		this.selectall = new System.Windows.Forms.Button();
		this.ReadonlyListView1 = new mlas_root.readonlyListView();
		this.DoubleBufferPanel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.img).BeginInit();
		this.Panel9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.imglistGrid).BeginInit();
		this.Panel30.SuspendLayout();
		base.SuspendLayout();
		this.DoubleBufferPanel1.Controls.Add(this.img);
		this.DoubleBufferPanel1.Controls.Add(this.Panel9);
		this.DoubleBufferPanel1.Controls.Add(this.title);
		this.DoubleBufferPanel1.Controls.Add(this.imglistGrid);
		this.DoubleBufferPanel1.Controls.Add(this.Panel30);
		this.DoubleBufferPanel1.Controls.Add(this.ReadonlyListView1);
		this.DoubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DoubleBufferPanel1.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel1.Name = "DoubleBufferPanel1";
		this.DoubleBufferPanel1.Size = new System.Drawing.Size(784, 561);
		this.DoubleBufferPanel1.TabIndex = 1;
		this.img.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.img.Dock = System.Windows.Forms.DockStyle.Fill;
		this.img.Location = new System.Drawing.Point(158, 58);
		this.img.Name = "img";
		this.img.Size = new System.Drawing.Size(626, 459);
		this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.img.TabIndex = 59;
		this.img.TabStop = false;
		this.Panel9.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Panel9.Controls.Add(this.Label1);
		this.Panel9.Controls.Add(this.RadioButton3);
		this.Panel9.Controls.Add(this.RadioButton2);
		this.Panel9.Controls.Add(this.RadioButton1);
		this.Panel9.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel9.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.Panel9.Location = new System.Drawing.Point(158, 32);
		this.Panel9.Name = "Panel9";
		this.Panel9.Size = new System.Drawing.Size(626, 26);
		this.Panel9.TabIndex = 63;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label1.Location = new System.Drawing.Point(11, 7);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(62, 12);
		this.Label1.TabIndex = 3;
		this.Label1.Text = "보기 모드";
		this.RadioButton3.AutoSize = true;
		this.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.RadioButton3.Location = new System.Drawing.Point(228, 5);
		this.RadioButton3.Name = "RadioButton3";
		this.RadioButton3.Size = new System.Drawing.Size(34, 16);
		this.RadioButton3.TabIndex = 2;
		this.RadioButton3.Text = "줌";
		this.RadioButton3.UseVisualStyleBackColor = true;
		this.RadioButton2.AutoSize = true;
		this.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.RadioButton2.Location = new System.Drawing.Point(161, 5);
		this.RadioButton2.Name = "RadioButton2";
		this.RadioButton2.Size = new System.Drawing.Size(58, 16);
		this.RadioButton2.TabIndex = 1;
		this.RadioButton2.Text = "채우기";
		this.RadioButton2.UseVisualStyleBackColor = true;
		this.RadioButton1.AutoSize = true;
		this.RadioButton1.Checked = true;
		this.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.RadioButton1.Location = new System.Drawing.Point(78, 5);
		this.RadioButton1.Name = "RadioButton1";
		this.RadioButton1.Size = new System.Drawing.Size(74, 16);
		this.RadioButton1.TabIndex = 0;
		this.RadioButton1.TabStop = true;
		this.RadioButton1.Text = "원본 크기";
		this.RadioButton1.UseVisualStyleBackColor = true;
		this.title.AutoSize = true;
		this.title.ForeColor = System.Drawing.Color.Blue;
		this.title.Location = new System.Drawing.Point(10, 11);
		this.title.Name = "title";
		this.title.Size = new System.Drawing.Size(42, 12);
		this.title.TabIndex = 62;
		this.title.Text = "Label1";
		this.imglistGrid.AllowUserToAddRows = false;
		this.imglistGrid.AllowUserToDeleteRows = false;
		this.imglistGrid.AllowUserToOrderColumns = true;
		this.imglistGrid.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.imglistGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.imglistGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.imglistGrid.BackgroundColor = System.Drawing.Color.White;
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
		this.imglistGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.imglistGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.imglistGrid.DefaultCellStyle = dataGridViewCellStyle3;
		this.imglistGrid.Dock = System.Windows.Forms.DockStyle.Left;
		this.imglistGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
		this.imglistGrid.EnableHeadersVisualStyles = false;
		this.imglistGrid.GridColor = System.Drawing.Color.DarkGray;
		this.imglistGrid.Location = new System.Drawing.Point(0, 32);
		this.imglistGrid.Name = "imglistGrid";
		this.imglistGrid.RowHeadersWidth = 30;
		this.imglistGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.imglistGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
		this.imglistGrid.RowTemplate.Height = 35;
		this.imglistGrid.RowTemplate.ReadOnly = true;
		this.imglistGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.imglistGrid.Size = new System.Drawing.Size(158, 485);
		this.imglistGrid.StandardTab = true;
		this.imglistGrid.TabIndex = 57;
		this.Panel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel30.Controls.Add(this.refresh);
		this.Panel30.Controls.Add(this.delete);
		this.Panel30.Controls.Add(this.upload);
		this.Panel30.Controls.Add(this.selectall);
		this.Panel30.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel30.Location = new System.Drawing.Point(0, 517);
		this.Panel30.Name = "Panel30";
		this.Panel30.Padding = new System.Windows.Forms.Padding(5);
		this.Panel30.Size = new System.Drawing.Size(784, 44);
		this.Panel30.TabIndex = 60;
		this.refresh.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.refresh.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.refresh.Dock = System.Windows.Forms.DockStyle.Right;
		this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.refresh.ForeColor = System.Drawing.Color.White;
		this.refresh.Location = new System.Drawing.Point(697, 5);
		this.refresh.Name = "refresh";
		this.refresh.Size = new System.Drawing.Size(80, 32);
		this.refresh.TabIndex = 105;
		this.refresh.Text = "새로고침";
		this.refresh.UseVisualStyleBackColor = false;
		this.delete.BackColor = System.Drawing.Color.Red;
		this.delete.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.delete.Dock = System.Windows.Forms.DockStyle.Left;
		this.delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
		this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.delete.ForeColor = System.Drawing.Color.White;
		this.delete.Location = new System.Drawing.Point(165, 5);
		this.delete.Name = "delete";
		this.delete.Size = new System.Drawing.Size(80, 32);
		this.delete.TabIndex = 104;
		this.delete.Text = "선택 삭제";
		this.delete.UseVisualStyleBackColor = false;
		this.upload.BackColor = System.Drawing.Color.DarkGreen;
		this.upload.BackgroundImage = (System.Drawing.Image)resources.GetObject("upload.BackgroundImage");
		this.upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.upload.Dock = System.Windows.Forms.DockStyle.Left;
		this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.upload.ForeColor = System.Drawing.Color.White;
		this.upload.Location = new System.Drawing.Point(85, 5);
		this.upload.Name = "upload";
		this.upload.Size = new System.Drawing.Size(80, 32);
		this.upload.TabIndex = 1;
		this.upload.Text = "업로드";
		this.upload.UseVisualStyleBackColor = false;
		this.selectall.BackColor = System.Drawing.Color.Black;
		this.selectall.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.selectall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.selectall.Dock = System.Windows.Forms.DockStyle.Left;
		this.selectall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.selectall.ForeColor = System.Drawing.Color.White;
		this.selectall.Location = new System.Drawing.Point(5, 5);
		this.selectall.Name = "selectall";
		this.selectall.Size = new System.Drawing.Size(80, 32);
		this.selectall.TabIndex = 3;
		this.selectall.Text = "전체 선택";
		this.selectall.UseVisualStyleBackColor = false;
		this.ReadonlyListView1.BackColor = System.Drawing.SystemColors.Control;
		this.ReadonlyListView1.Dock = System.Windows.Forms.DockStyle.Top;
		this.ReadonlyListView1.Location = new System.Drawing.Point(0, 0);
		this.ReadonlyListView1.Name = "ReadonlyListView1";
		this.ReadonlyListView1.ReadOnly = false;
		this.ReadonlyListView1.Size = new System.Drawing.Size(784, 32);
		this.ReadonlyListView1.TabIndex = 61;
		this.ReadonlyListView1.UseCompatibleStateImageBehavior = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(784, 561);
		base.Controls.Add(this.DoubleBufferPanel1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		this.MinimumSize = new System.Drawing.Size(800, 600);
		base.Name = "imagelistViewer";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MLAS Database 관리자";
		this.DoubleBufferPanel1.ResumeLayout(false);
		this.DoubleBufferPanel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.img).EndInit();
		this.Panel9.ResumeLayout(false);
		this.Panel9.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.imglistGrid).EndInit();
		this.Panel30.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public imagelistViewer(string dburl, string lourl, string upurl, string deurl)
	{
		base.Load += imagelistViewer_Load;
		InitializeComponent();
		selectUrl = dburl;
		loadUrl = lourl;
		uploadUrl = upurl;
		delUrl = deurl;
	}

	private void imagelistViewer_Load(object sender, EventArgs e)
	{
		title.Text = selectUrl;
		listRefresh();
	}

	private void listRefresh()
	{
		ivList = new List<ivClass>();
		imglistGrid.DataSource = null;
		string hTML = new GetHtmlClass(selectUrl, "p=" + MySettingsProperty.Settings.pw, progress: true).getHTML(this);
		ivList = JsonConvert.DeserializeObject<List<ivClass>>(hTML);
		imglistGrid.DataSource = ivList;
	}

	private void refresh_Click(object sender, EventArgs e)
	{
		listRefresh();
	}

	private void selectall_Click(object sender, EventArgs e)
	{
		imglistGrid.SelectAll();
	}

	private void upload_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(uploadUrl, null, TextCompare: false) == 0)
		{
			Interaction.MsgBox("업로드가 불가능한 DB 입니다.");
		}
	}

	private void delete_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(delUrl, null, TextCompare: false) == 0)
		{
			Interaction.MsgBox("레코드 삭제가 불가능한 DB 입니다.");
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = imglistGrid.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (MessageBox.Show("번호 " + ivList[dataGridViewRow.Index].num.ToString() + " 이미지를 삭제 하시겠습니까? 삭제된 후 이 번호가 참조된 모든 키워드에서 이미지를 표시 할 수 없습니다. 삭제된 이미지는 다시 복구할 수 없습니다.", "이미지 삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.No)
				{
					new GetHtmlClass(delUrl + ivList[dataGridViewRow.Index].num.ToString(), "", progress: true).getHTML(this);
					img.Image = null;
					GC.Collect();
					_ = dataGridViewRow.Index;
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
		listRefresh();
	}

	private void imglistGrid_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		_ = (DataGridView)sender;
		if (e.RowIndex < 0)
		{
			return;
		}
		img.Image = null;
		GC.Collect();
		try
		{
			string hTML = new GetHtmlClass(loadUrl + ivList[imglistGrid.CurrentRow.Index].num.ToString()).getHTML(this);
			if (hTML != null)
			{
				byte[] buffer = Convert.FromBase64String(hTML);
				MemoryStream stream = new MemoryStream(buffer);
				img.Image = Image.FromStream(stream);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			img.Image = null;
			GC.Collect();
			ProjectData.ClearProjectError();
		}
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		img.SizeMode = PictureBoxSizeMode.CenterImage;
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		img.SizeMode = PictureBoxSizeMode.StretchImage;
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		img.SizeMode = PictureBoxSizeMode.Zoom;
	}

	private void imglistGrid_KeyUp(object sender, KeyEventArgs e)
	{
		_ = (DataGridView)sender;
		try
		{
			string hTML = new GetHtmlClass(loadUrl + ivList[imglistGrid.CurrentRow.Index].num.ToString()).getHTML(this);
			if (hTML != null)
			{
				byte[] buffer = Convert.FromBase64String(hTML);
				MemoryStream stream = new MemoryStream(buffer);
				img.Image = Image.FromStream(stream);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			img.Image = null;
			GC.Collect();
			ProjectData.ClearProjectError();
		}
	}
}
