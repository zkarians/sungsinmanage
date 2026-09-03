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
public class cti_blacklist : Form
{
	private IContainer components;

	private cti_import form;

	public List<cti_db> ctiDbClass;

	public cti_import parent_form;

	private object busy;

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
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

	[field: AccessedThroughProperty("blacklist_grid")]
	internal virtual DataGridView blacklist_grid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("db_status")]
	internal virtual Label db_status
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

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
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

	public cti_blacklist()
	{
		base.Load += cti_blacklist_Load;
		base.FormClosing += cti_blacklist_FormClosing;
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
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Button1 = new System.Windows.Forms.Button();
		this.db_status = new System.Windows.Forms.Label();
		this.Button9 = new System.Windows.Forms.Button();
		this.Button8 = new System.Windows.Forms.Button();
		this.blacklist_grid = new System.Windows.Forms.DataGridView();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.blacklist_grid).BeginInit();
		base.SuspendLayout();
		this.Panel3.Controls.Add(this.Button1);
		this.Panel3.Controls.Add(this.db_status);
		this.Panel3.Controls.Add(this.Button9);
		this.Panel3.Controls.Add(this.Button8);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel3.Location = new System.Drawing.Point(0, 341);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(376, 25);
		this.Panel3.TabIndex = 77;
		this.Button1.BackColor = System.Drawing.Color.Blue;
		this.Button1.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(53, 2);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(49, 21);
		this.Button1.TabIndex = 79;
		this.Button1.Text = "저장";
		this.Button1.UseVisualStyleBackColor = false;
		this.db_status.Dock = System.Windows.Forms.DockStyle.Right;
		this.db_status.Location = new System.Drawing.Point(198, 0);
		this.db_status.Name = "db_status";
		this.db_status.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
		this.db_status.Size = new System.Drawing.Size(178, 25);
		this.db_status.TabIndex = 78;
		this.db_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button9.BackColor = System.Drawing.Color.Red;
		this.Button9.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button9.ForeColor = System.Drawing.Color.White;
		this.Button9.Location = new System.Drawing.Point(103, 2);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(49, 21);
		this.Button9.TabIndex = 77;
		this.Button9.Text = "삭제";
		this.Button9.UseVisualStyleBackColor = false;
		this.Button8.BackColor = System.Drawing.Color.DarkGreen;
		this.Button8.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button8.ForeColor = System.Drawing.Color.White;
		this.Button8.Location = new System.Drawing.Point(3, 2);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(49, 21);
		this.Button8.TabIndex = 76;
		this.Button8.Text = "추가";
		this.Button8.UseVisualStyleBackColor = false;
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
		this.blacklist_grid.Columns.AddRange(this.Column1, this.DataGridViewTextBoxColumn15, this.DataGridViewTextBoxColumn16);
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
		this.blacklist_grid.Location = new System.Drawing.Point(0, 0);
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
		this.blacklist_grid.Size = new System.Drawing.Size(376, 341);
		this.blacklist_grid.TabIndex = 78;
		this.Column1.HeaderText = "idx";
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.Column1.Visible = false;
		this.DataGridViewTextBoxColumn15.HeaderText = "데이터베이스 이름";
		this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
		this.DataGridViewTextBoxColumn15.Width = 250;
		this.DataGridViewTextBoxColumn16.HeaderText = "총 개수";
		this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
		this.DataGridViewTextBoxColumn16.ReadOnly = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(376, 366);
		base.Controls.Add(this.blacklist_grid);
		base.Controls.Add(this.Panel3);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		this.MinimumSize = new System.Drawing.Size(392, 405);
		base.Name = "cti_blacklist";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "블랙리스트 관리";
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.blacklist_grid).EndInit();
		base.ResumeLayout(false);
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		form = new cti_import();
		form.db_blacklist_upload_mode = true;
		form.Size = new Size(536, 354);
		form.ShowDialog();
	}

	private void cti_blacklist_Load(object sender, EventArgs e)
	{
		ctiDbClass = MyProject.Forms.ssorder_cti.getDB(refresh: false, "blacklist");
		if (ctiDbClass.Count <= 0)
		{
			return;
		}
		foreach (cti_db item in ctiDbClass)
		{
			blacklist_grid.Rows.Add(item.idx, item.name, item.nosplit_count);
		}
		db_status.Text = "총 " + Conversions.ToString(ctiDbClass.Count) + "개 데이터베이스 발견.";
	}

	private void cti_blacklist_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			parent_form.getBlacklist();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		Hide();
		Dispose();
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("선택된 블랙리스트 DB를 삭제 하시겠습니까?", "데이터베이스 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No || Conversions.ToBoolean(busy))
		{
			return;
		}
		busy = true;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = blacklist_grid.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				JObject jObject = new JObject();
				jObject.Add("type", "delDB");
				jObject.Add("id", Module1._id);
				jObject.Add("pw", Module1._pw);
				jObject.Add("idx", dataGridViewRow.Cells[0].Value.ToString());
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
						cti_db item = ctiDbClass.Find((cti_db a) => Operators.ConditionalCompareObjectEqual(a.idx, blacklist_grid.SelectedRows[0].Cells[0].Value, TextCompare: false) ? true : false);
						ctiDbClass.Remove(item);
						blacklist_grid.Rows.Remove(dataGridViewRow);
						db_status.Text = "총 " + Conversions.ToString(ctiDbClass.Count) + "개 데이터베이스 발견.";
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
					CustomMsgBox.CMsgBox("내부 오류 발생.\r\n" + ex2.Message, "내부 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					busy = false;
					ProjectData.ClearProjectError();
					return;
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
		MessageBox.Show("선택된 데이터베이스가 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		try
		{
			blacklist_grid.ClearSelection();
			blacklist_grid.Rows[checked(blacklist_grid.Rows.Count - 1)].Selected = true;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		busy = false;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(busy))
		{
			return;
		}
		busy = true;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)blacklist_grid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				JObject jObject = new JObject();
				jObject.Add("type", "setDB");
				jObject.Add("id", Module1._id);
				jObject.Add("pw", Module1._pw);
				jObject.Add("idx", dataGridViewRow.Cells[0].Value.ToString());
				jObject.Add("name", dataGridViewRow.Cells[1].Value.ToString());
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
						ctiDbClass.Find((cti_db a) => Operators.ConditionalCompareObjectEqual(a.idx, blacklist_grid.SelectedRows[0].Cells[0].Value, TextCompare: false) ? true : false).name = dataGridViewRow.Cells[1].Value.ToString();
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
					busy = false;
					ProjectData.ClearProjectError();
					return;
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
		MessageBox.Show("저장 완료.", "이름 저장", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		busy = false;
	}
}
