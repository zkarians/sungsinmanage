using System;
using System.ComponentModel;
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
public class ssorder_login : Form
{
	private IContainer components;

	private object busy;

	private object loginOK;

	[field: AccessedThroughProperty("DoubleBufferPanel1")]
	internal virtual DoubleBufferPanel DoubleBufferPanel1
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

	[field: AccessedThroughProperty("CheckBox1")]
	internal virtual CheckBox CheckBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox2_KeyDown;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox2
	{
		[CompilerGenerated]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = TextBox2_KeyDown;
			TextBox textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
			}
			_TextBox2 = value;
			textBox = _TextBox2;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual TextBox Label1
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	public ssorder_login()
	{
		base.Load += ssorder_login_Load;
		base.FormClosing += ssorder_login_FormClosing;
		busy = false;
		loginOK = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.ssorder_login));
		this.DoubleBufferPanel1 = new mlas_root.DoubleBufferPanel();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Label1 = new System.Windows.Forms.TextBox();
		this.TextBox3 = new System.Windows.Forms.TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Button1 = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.DoubleBufferPanel1.SuspendLayout();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.DoubleBufferPanel1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.DoubleBufferPanel1.Controls.Add(this.CheckBox2);
		this.DoubleBufferPanel1.Controls.Add(this.Label5);
		this.DoubleBufferPanel1.Controls.Add(this.Panel1);
		this.DoubleBufferPanel1.Controls.Add(this.PictureBox1);
		this.DoubleBufferPanel1.Controls.Add(this.Button1);
		this.DoubleBufferPanel1.Controls.Add(this.CheckBox1);
		this.DoubleBufferPanel1.Controls.Add(this.TextBox1);
		this.DoubleBufferPanel1.Controls.Add(this.Label4);
		this.DoubleBufferPanel1.Controls.Add(this.TextBox2);
		this.DoubleBufferPanel1.Controls.Add(this.Label3);
		this.DoubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DoubleBufferPanel1.Location = new System.Drawing.Point(0, 0);
		this.DoubleBufferPanel1.Name = "DoubleBufferPanel1";
		this.DoubleBufferPanel1.Size = new System.Drawing.Size(437, 185);
		this.DoubleBufferPanel1.TabIndex = 14;
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CheckBox2.ForeColor = System.Drawing.Color.Blue;
		this.CheckBox2.Location = new System.Drawing.Point(334, 121);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(85, 16);
		this.CheckBox2.TabIndex = 4;
		this.CheckBox2.Text = "자동 로그인";
		this.CheckBox2.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("굴림", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label5.ForeColor = System.Drawing.Color.Gray;
		this.Label5.Location = new System.Drawing.Point(11, 156);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(179, 11);
		this.Label5.TabIndex = 13;
		this.Label5.Text = "기술지원: microlivire@gmail.com";
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Controls.Add(this.TextBox3);
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(437, 25);
		this.Panel1.TabIndex = 12;
		this.Label1.BackColor = System.Drawing.Color.DarkCyan;
		this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.Label1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(131, 6);
		this.Label1.MaximumSize = new System.Drawing.Size(0, 20);
		this.Label1.MinimumSize = new System.Drawing.Size(0, 20);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(306, 20);
		this.Label1.TabIndex = 0;
		this.Label1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TextBox3.BackColor = System.Drawing.Color.DarkCyan;
		this.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox3.Dock = System.Windows.Forms.DockStyle.Top;
		this.TextBox3.Enabled = false;
		this.TextBox3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox3.ForeColor = System.Drawing.Color.White;
		this.TextBox3.Location = new System.Drawing.Point(131, 0);
		this.TextBox3.MaximumSize = new System.Drawing.Size(0, 6);
		this.TextBox3.Name = "TextBox3";
		this.TextBox3.ReadOnly = true;
		this.TextBox3.Size = new System.Drawing.Size(306, 6);
		this.TextBox3.TabIndex = 11;
		this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label2.BackColor = System.Drawing.Color.Teal;
		this.Label2.Dock = System.Windows.Forms.DockStyle.Left;
		this.Label2.ForeColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(0, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(131, 25);
		this.Label2.TabIndex = 9;
		this.Label2.Text = "서버주소 변경";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.PictureBox1.Image = mlas_root.My.Resources.Resources.laptop;
		this.PictureBox1.Location = new System.Drawing.Point(17, 36);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(100, 100);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 8;
		this.PictureBox1.TabStop = false;
		this.Button1.BackColor = System.Drawing.Color.Blue;
		this.Button1.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(236, 150);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(184, 25);
		this.Button1.TabIndex = 5;
		this.Button1.Text = "접속";
		this.Button1.UseVisualStyleBackColor = false;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.CheckBox1.Location = new System.Drawing.Point(334, 100);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(85, 16);
		this.CheckBox1.TabIndex = 3;
		this.CheckBox1.Text = "아이디 저장";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.TextBox1.BackColor = System.Drawing.Color.White;
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox1.Location = new System.Drawing.Point(195, 42);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(224, 21);
		this.TextBox1.TabIndex = 1;
		this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label4.Location = new System.Drawing.Point(132, 75);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(57, 12);
		this.Label4.TabIndex = 6;
		this.Label4.Text = "비밀번호";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox2.BackColor = System.Drawing.Color.White;
		this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox2.Location = new System.Drawing.Point(195, 70);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(224, 21);
		this.TextBox2.TabIndex = 2;
		this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TextBox2.UseSystemPasswordChar = true;
		this.Label3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label3.Location = new System.Drawing.Point(132, 47);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(57, 12);
		this.Label3.TabIndex = 3;
		this.Label3.Text = "아이디";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(437, 185);
		base.Controls.Add(this.DoubleBufferPanel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "ssorder_login";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "성신판매접수 관리자";
		this.DoubleBufferPanel1.ResumeLayout(false);
		this.DoubleBufferPanel1.PerformLayout();
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	private void ssorder_login_Load(object sender, EventArgs e)
	{
		Text = Text + " v" + $"{(double)ssorder.ssorder_version / 100.0:0.00}";
		Label1.Text = Conversions.ToString(ssorder.ssorder_server);
		TextBox1.Text = MySettingsProperty.Settings.dburl;
		if (Operators.CompareString(MySettingsProperty.Settings.project, null, TextCompare: false) != 0)
		{
			Label1.Text = MySettingsProperty.Settings.project;
			if (!Label1.Text.StartsWith("http"))
			{
				Label1.Text = Conversions.ToString(ssorder.ssorder_server);
			}
		}
		if (Operators.CompareString(MySettingsProperty.Settings.dburl, null, TextCompare: false) != 0)
		{
			CheckBox1.Checked = true;
			TextBox2.Focus();
		}
		if (MySettingsProperty.Settings.autologin)
		{
			CheckBox2.Checked = true;
			TextBox2.Text = MySettingsProperty.Settings.pw;
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Button1_Click(object sender, EventArgs e)
	{
		ssorder.ssorder_server = Label1.Text.Trim();
		if (Operators.CompareString(TextBox1.Text, null, TextCompare: false) == 0)
		{
			MessageBox.Show("아이디 칸이 비었습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else if (Operators.CompareString(TextBox2.Text, null, TextCompare: false) == 0)
		{
			MessageBox.Show("비밀번호 칸이 비었습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else
		{
			if (Conversions.ToBoolean(busy))
			{
				return;
			}
			busy = true;
			Module1._id = TextBox1.Text;
			Module1._pw = TextBox2.Text;
			if (CheckBox2.Checked)
			{
				MySettingsProperty.Settings.pw = TextBox2.Text;
				MySettingsProperty.Settings.autologin = true;
			}
			else
			{
				MySettingsProperty.Settings.pw = null;
				MySettingsProperty.Settings.autologin = false;
			}
			if (!ssorder.ssorder_server.ToString().EndsWith("/"))
			{
				ssorder.ssorder_server = Operators.ConcatenateObject(ssorder.ssorder_server, "/");
			}
			JObject jObject = new JObject();
			jObject.Add("id", Module1._id);
			jObject.Add("pw", Module1._pw);
			jObject.Add("version", ssorder.ssorder_version);
			string postData = "args=" + jObject.ToString(Formatting.None);
			try
			{
				JObject jObject2 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "login_v2.php")), postData, progress: true).getHTML(this));
				if (jObject2.SelectToken("response").Equals("fail"))
				{
					Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
					busy = false;
					return;
				}
				JToken jToken = jObject2.SelectToken("response");
				if ((string)jToken == "ok")
				{
					ssorder.ssorder_account_code = (int)jObject2.SelectToken("output").SelectToken("account_code");
					ssorder.ssorder_acgb = (int)jObject2.SelectToken("output").SelectToken("acgb_code");
					ssorder.ssorder_team_code = (int)jObject2.SelectToken("output").SelectToken("team_code");
					ssorder.ssorder_name = (string)jObject2.SelectToken("output").SelectToken("name");
					ssorder.cti_account_idx = (string)jObject2.SelectToken("output").SelectToken("cti_idx");
					string text = ssorder.ssorder_acgb switch
					{
						1 => "관리자", 
						2 => "일반", 
						3 => "최고관리자", 
						4 => "재고관리자", 
						5 => "루트계정", 
						_ => "일반", 
					};
					MyProject.Forms.android_db_ss_order.order_lb1.Text += ssorder.ssorder_name;
					Label order_lb;
					(order_lb = MyProject.Forms.android_db_ss_order.order_lb2).Text = Conversions.ToString(Operators.ConcatenateObject(order_lb.Text, ssorder.ssorder_server));
					MyProject.Forms.android_db_ss_order.order_lb3.Text += Conversions.ToString(ssorder.ssorder_account_code);
					MyProject.Forms.android_db_ss_order.order_lb4.Text += text;
					(order_lb = MyProject.Forms.android_db_ss_order.order_lb5).Text = Conversions.ToString(Operators.ConcatenateObject(order_lb.Text, Interaction.IIf(ssorder.ssorder_team_code == 1, "직판", "TM")));
					Module1._dburl = Conversions.ToString(ssorder.ssorder_server);
					Module1._id = TextBox1.Text;
					Module1._useTime = (string)jObject2.SelectToken("output").SelectToken("date");
					Module1.project = Module1.forceProject;
					if (CheckBox1.Checked)
					{
						MySettingsProperty.Settings.project = Conversions.ToString(ssorder.ssorder_server);
						MySettingsProperty.Settings.dburl = TextBox1.Text;
						MySettingsProperty.Settings.Save();
					}
					else
					{
						string dburl = MySettingsProperty.Settings.dburl;
						MySettingsProperty.Settings.dburl = null;
						MySettingsProperty.Settings.Save();
						MySettingsProperty.Settings.dburl = dburl;
					}
					MySettingsProperty.Settings.pw = TextBox2.Text;
					TextBox2.Text = null;
					if (ssorder.findUpdate())
					{
						if (ssorder.forceUpdate)
						{
							if (MessageBox.Show("필수 업데이트가 발견되었습니다. 지금 업데이트를 진행 하시겠습니까?", "새 업데이트 있음", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
							{
								try
								{
									using (StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\update.ini", append: false, Encoding.Default))
									{
										streamWriter.WriteLine("android_db_ss_order");
										streamWriter.WriteLine(ssorder.ssorder_version);
										streamWriter.Write(Application.StartupPath);
									}
									Process.Start(Application.StartupPath + "\\update.exe", Module1._dburl);
								}
								catch (Exception ex)
								{
									ProjectData.SetProjectError(ex);
									Exception ex2 = ex;
									ProjectData.ClearProjectError();
								}
								ProjectData.EndApp();
								Application.Exit();
							}
							else
							{
								Application.Exit();
							}
							return;
						}
						if (MessageBox.Show("서버에 새 업데이트가 출시 되었습니다.\r\n\r\n[확인]을 누르면 자동 업데이트가 실행되며,\r\n[취소]를 누르면 업데이트를 보류합니다.\r\n\r\n업데이트를 진행 하시겠습니까?", "새 업데이트 있음", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
						{
							try
							{
								using (StreamWriter streamWriter2 = new StreamWriter(Application.StartupPath + "\\update.ini", append: false, Encoding.Default))
								{
									streamWriter2.WriteLine("android_db_ss_order");
									streamWriter2.WriteLine(ssorder.ssorder_version);
									streamWriter2.Write(Application.StartupPath);
								}
								Process.Start(Application.StartupPath + "\\update.exe", Module1._dburl);
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ProjectData.ClearProjectError();
							}
							ProjectData.EndApp();
							Application.Exit();
							return;
						}
						MySettingsProperty.Settings.update_jump = ssorder.latest_version;
						MySettingsProperty.Settings.Save();
					}
					else if (ssorder.forceUpdate & (ssorder.latest_version > ssorder.ssorder_version))
					{
						MessageBox.Show("필수 업데이트가 발견되었지만 업데이트 프로그램이 존재하지 않아 프로그램을 실행할 수 없습니다. 관리자에게 문의하십시오.", "업데이트 실패", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						ProjectData.EndApp();
						Application.Exit();
						return;
					}
					MyProject.Forms.mlas.Panel5.Hide();
					MyProject.Forms.mlas.Show();
					ssorder.ssorder_gb = (string)jObject2.SelectToken("output").SelectToken("team");
					ssorder.ssorder_gb2 = (string)jObject2.SelectToken("output").SelectToken("name");
					MyProject.Forms.mlas.Label4.Text = Module1.forceTitle + " v" + $"{(double)ssorder.ssorder_version / 100.0:0.00}" + " [사원이름-" + ssorder.ssorder_gb2 + "] [소속구분-" + ssorder.ssorder_gb + "]";
					MyProject.Forms.mlas.PictureBox1.Hide();
					MyProject.Forms.mlas.Panel53.Hide();
					MyProject.Forms.mlas.Panel2.Padding = new Padding(0, 0, 0, 0);
					loginOK = true;
					Close();
				}
				else if ((string)jToken == "fail")
				{
					JToken jToken2 = jObject2.SelectToken("cause");
					if ((string)jToken2 == "no_match")
					{
						MessageBox.Show("로그인 실패 / 인터넷 연결이 올바른지, 계정 또는 암호가 올바른지 확인하십시오.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else if ((string)jToken2 == "permission_error")
					{
						MessageBox.Show("해당 IP는 접속 권한이 없습니다. 관리자에게 문의하십시오.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else if ((string)jToken2 == "update_require")
					{
						MessageBox.Show("업데이트가 필요합니다. \"확인\"을 누르면 업데이트가 시작됩니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					}
					busy = false;
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex6.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				busy = false;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void TextBox2_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void ssorder_login_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Conversions.ToBoolean(Operators.NotObject(loginOK)))
		{
			ProjectData.EndApp();
		}
	}
}
