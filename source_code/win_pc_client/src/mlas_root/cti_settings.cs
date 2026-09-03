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
public class cti_settings : Form
{
	private IContainer components;

	private object busy;

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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public cti_settings()
	{
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
		this.Label1 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label1.ForeColor = System.Drawing.Color.DimGray;
		this.Label1.Location = new System.Drawing.Point(11, 187);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(371, 24);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "서버의 상담원 또는 DB(고객정보) 데이터를 영구적으로 삭제합니다.\r\n인덱스(NO)가 포화되었을때 초기화 하는 용도로 사용합니다.";
		this.Button1.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.Button1.Image = mlas_root.My.Resources.Resources.Danger;
		this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button1.Location = new System.Drawing.Point(23, 107);
		this.Button1.Name = "Button1";
		this.Button1.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
		this.Button1.Size = new System.Drawing.Size(127, 43);
		this.Button1.TabIndex = 3;
		this.Button1.Text = "서버 초기화";
		this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button1.UseVisualStyleBackColor = true;
		this.TextBox1.BackColor = System.Drawing.Color.White;
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox1.Location = new System.Drawing.Point(84, 44);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(194, 21);
		this.TextBox1.TabIndex = 1;
		this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label4.Location = new System.Drawing.Point(21, 77);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(57, 12);
		this.Label4.TabIndex = 10;
		this.Label4.Text = "비밀번호";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox2.BackColor = System.Drawing.Color.White;
		this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox2.Location = new System.Drawing.Point(84, 72);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(194, 21);
		this.TextBox2.TabIndex = 2;
		this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TextBox2.UseSystemPasswordChar = true;
		this.Label3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label3.Location = new System.Drawing.Point(21, 49);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(57, 12);
		this.Label3.TabIndex = 9;
		this.Label3.Text = "아이디";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label2.Location = new System.Drawing.Point(19, 17);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(267, 12);
		this.Label2.TabIndex = 11;
		this.Label2.Text = "초기화 하려면 Root 계정 인증이 필요합니다.";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label5.AutoSize = true;
		this.Label5.ForeColor = System.Drawing.Color.Red;
		this.Label5.Location = new System.Drawing.Point(11, 167);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(45, 12);
		this.Label5.TabIndex = 12;
		this.Label5.Text = "※경고!";
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.CheckBox1.Location = new System.Drawing.Point(165, 110);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(100, 16);
		this.CheckBox1.TabIndex = 13;
		this.CheckBox1.Text = "상담원 데이터";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.CheckBox2.Location = new System.Drawing.Point(165, 132);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(198, 16);
		this.CheckBox2.TabIndex = 14;
		this.CheckBox2.Text = "DB 데이터(블랙리스트 DB 포함)";
		this.CheckBox2.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(402, 228);
		base.Controls.Add(this.CheckBox2);
		base.Controls.Add(this.CheckBox1);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.TextBox1);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.TextBox2);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.Button1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "cti_settings";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "환경설정";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(busy))
		{
			return;
		}
		if (Operators.CompareString(TextBox1.Text.Trim(), null, TextCompare: false) == 0)
		{
			Interaction.MsgBox("아이디 칸이 비었습니다.");
		}
		else if (Operators.CompareString(TextBox2.Text.Trim(), null, TextCompare: false) == 0)
		{
			Interaction.MsgBox("비밀번호 칸이 비었습니다.");
		}
		else if (!CheckBox1.Checked & !CheckBox2.Checked)
		{
			Interaction.MsgBox("옵션을 최소 1개는 선택하십시오.");
		}
		else
		{
			if (MessageBox.Show("정말 서버를 초기상태로 복원 하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
			{
				return;
			}
			busy = true;
			string text = Conversions.ToString(Interaction.IIf(CheckBox1.Checked, 1, 0));
			string text2 = Conversions.ToString(Interaction.IIf(CheckBox2.Checked, 1, 0));
			JObject jObject = new JObject();
			jObject.Add("type", "dbFactoryReset");
			jObject.Add("id", TextBox1.Text.Trim());
			jObject.Add("pw", TextBox2.Text.Trim());
			jObject.Add("remove_agent", text);
			jObject.Add("remove_db", text2);
			string postData = "args=" + jObject.ToString(Formatting.None);
			try
			{
				JObject jObject2 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_set.php")), postData, progress: true).getHTML(this));
				JToken jToken = jObject2.SelectToken("response");
				if ((string)jToken == "ok")
				{
					MessageBox.Show("초기화가 완료되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					if (CheckBox1.Checked)
					{
						MyProject.Forms.ssorder_cti.getAgents();
					}
					if (CheckBox2.Checked)
					{
						MyProject.Forms.ssorder_cti.getDB();
					}
					Dispose();
				}
				else if ((string)jToken == "fail")
				{
					if ((string)jObject2.SelectToken("cause") == "permission_error")
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
					}
					else
					{
						CustomMsgBox.CMsgBox("서버에서 오류가 발생되었습니다. 자세한 정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					}
					busy = false;
					return;
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
}
