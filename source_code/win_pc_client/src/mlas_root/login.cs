using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class login : Form
{
	private class accounts
	{
		private object _index;

		private object _project;

		private object _id;

		private object _pw;

		public accounts(int index, string project, string id, string pw)
		{
			_index = index;
			_project = project;
			_id = id;
			_pw = pw;
		}

		public string[] getData()
		{
			return new string[4]
			{
				Conversions.ToString(_index),
				Conversions.ToString(_project),
				Conversions.ToString(_id),
				Conversions.ToString(_pw)
			};
		}

		public string[] getDataBlind()
		{
			return new string[4]
			{
				Conversions.ToString(_index),
				Conversions.ToString(_project),
				Conversions.ToString(_id),
				new string('*', Conversions.ToInteger(NewLateBinding.LateGet(_pw, null, "Length", new object[0], null, null, null)))
			};
		}
	}

	private object init;

	private bool first;

	private object heights;

	private int meY;

	private int meY2;

	private object dataCount;

	private List<accounts> UserAccounts;

	private IContainer components;

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

	internal virtual Label Label2
	{
		[CompilerGenerated]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label2_Click;
			Label label = _Label2;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label2 = value;
			label = _Label2;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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
			KeyEventHandler value2 = TextBox1_KeyDown;
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label5
	{
		[CompilerGenerated]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label5_Click;
			Label label = _Label5;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label5 = value;
			label = _Label5;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			MouseEventHandler value2 = Panel1_MouseDown;
			PictureBox pictureBox = _PictureBox2;
			if (pictureBox != null)
			{
				pictureBox.MouseDown -= value2;
			}
			_PictureBox2 = value;
			pictureBox = _PictureBox2;
			if (pictureBox != null)
			{
				pictureBox.MouseDown += value2;
			}
		}
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

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBox1_SelectedIndexChanged;
			EventHandler value3 = ComboBox1_Leave;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
				comboBox.Leave -= value3;
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
				comboBox.Leave += value3;
			}
		}
	}

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label1_Click;
			Label label = _Label1;
			if (label != null)
			{
				label.Click -= value2;
			}
			_Label1 = value;
			label = _Label1;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Panel Panel1
	{
		[CompilerGenerated]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel1_MouseDown;
			Panel panel = _Panel1;
			if (panel != null)
			{
				panel.MouseDown -= value2;
			}
			_Panel1 = value;
			panel = _Panel1;
			if (panel != null)
			{
				panel.MouseDown += value2;
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

	internal virtual Label Label8
	{
		[CompilerGenerated]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Label8_MouseMove;
			EventHandler value3 = Label8_MouseLeave;
			EventHandler value4 = Label8_Click;
			Label label = _Label8;
			if (label != null)
			{
				label.MouseMove -= value2;
				label.MouseLeave -= value3;
				label.Click -= value4;
			}
			_Label8 = value;
			label = _Label8;
			if (label != null)
			{
				label.MouseMove += value2;
				label.MouseLeave += value3;
				label.Click += value4;
			}
		}
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DoubleBufferPanel3")]
	internal virtual DoubleBufferPanel DoubleBufferPanel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DataGridView1
	{
		[CompilerGenerated]
		get
		{
			return _DataGridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = DataGridView1_CellClick;
			DataGridViewCellEventHandler value3 = DataGridView1_CellDoubleClick;
			DataGridView dataGridView = _DataGridView1;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_DataGridView1 = value;
			dataGridView = _DataGridView1;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel4")]
	internal virtual DoubleBufferPanel DoubleBufferPanel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button4_Click;
			Button button = _Button4;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button3_Click;
			Button button = _Button3;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button5
	{
		[CompilerGenerated]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button5_Click;
			Button button = _Button5;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button5 = value;
			button = _Button5;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Column4")]
	internal virtual DataGridViewTextBoxColumn Column4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewTextBoxColumn Column2
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

	public login()
	{
		base.Load += login_Load;
		base.FormClosing += login_FormClosing;
		init = false;
		first = true;
		heights = 223;
		meY2 = 0;
		dataCount = 1;
		InitializeComponent();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox1.Text, null, TextCompare: false) == 0)
		{
			MessageBox.Show("데이터베이스 계정 칸이 비었습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		if (Operators.CompareString(TextBox2.Text, null, TextCompare: false) == 0)
		{
			MessageBox.Show("암호 칸이 비었습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		if (CheckBox1.Checked)
		{
			MySettingsProperty.Settings.pw = TextBox2.Text;
		}
		else
		{
			MySettingsProperty.Settings.pw = null;
		}
		string hTML = new GetHtmlClass("http://umylife0208.cafe24.com/mlas/admin.php?type=com2&data=" + HttpUtility.UrlEncode(Label5.Text) + "&id=" + HttpUtility.UrlEncode(TextBox1.Text), null, progress: true).getHTML(this);
		string[] array = hTML.ToString().Split(new string[1] { "%" }, StringSplitOptions.None);
		checked
		{
			if ((Operators.CompareString(hTML, null, TextCompare: false) != 0) & (Operators.CompareString(array[0], null, TextCompare: false) != 0))
			{
				try
				{
					Module1._dburl = array[5];
					Module1._id = array[6];
					Module1.encode = array[7];
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show("서버 트래픽이 초과된 것으로 보입니다. 제작사에 문의하여 주시기 바랍니다.\r\n\r\nERROR mlas_traffic_over_exception", "인증 오류", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					ProjectData.ClearProjectError();
					return;
				}
				if (Operators.CompareString(array[2], "0", TextCompare: false) == 0)
				{
					MessageBox.Show("현재 접속한 사용자는 솔루션 사용권한이 정지 되었으므로 이용하실 수 없습니다. 제작사에 문의하여 주시기 바랍니다.\r\n\r\nERROR mlas_access_denied_exception", "액세스 권한 없음", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				Module1.server_version = (int)Math.Round(Conversion.Val(array[3]));
				if (Module1.server_version > Module1.version)
				{
					try
					{
						Process.Start(Application.StartupPath + "\\update.exe", Module1.server_version.ToString());
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						Process.Start("http://umylife0208.cafe24.com/mlas/download/mlas" + Module1.server_version + ".zip");
						ProjectData.ClearProjectError();
					}
					Application.Exit();
					return;
				}
				string text = array[9];
				string hTML2 = new GetHtmlClass("http://umylife0208.cafe24.com/mlas/admin.php?type=notice&num=" + text, null, progress: true).getHTML(this);
				MyProject.Forms.mlas.lb1.Text = "프로젝트 : " + Label5.Text;
				MyProject.Forms.mlas.lb3.Text = "서비스 사용자 분류 : N" + array[0];
				MyProject.Forms.mlas.lb4.Text = "제품 사용 허가 : " + array[1];
				MyProject.Forms.mlas.Label7.Text = "최근 로그인 : " + array[8];
				Module1._userName = array[1];
				Module1._useTime = array[10];
				if (Operators.CompareString(hTML2.ToString(), null, TextCompare: false) == 0)
				{
					MyProject.Forms.mlas.Panel53.Hide();
					MyProject.Forms.mlas.Panel2.Padding = new Padding(0, 0, 0, 0);
				}
				else
				{
					MyProject.Forms.mlas.Panel53.Show();
					string[] array2 = hTML2.Split(new string[1] { "\r\n" }, StringSplitOptions.None);
					Module1.notice[0] = array2[0].Remove(0, 1);
					object obj = null;
					int num = array2.Length - 1;
					for (int i = 1; i <= num; i++)
					{
						obj = Operators.ConcatenateObject(obj, array2[i]);
						if (i < array2.Length - 1)
						{
							obj = Operators.ConcatenateObject(obj, "\r\n");
						}
					}
					Module1.notice[1] = Conversions.ToString(obj);
					MyProject.Forms.mlas.txt_notice.Text = Module1.notice[0] + " (자세히 보기)";
					try
					{
						Module1.notice_color = (int)Math.Round(Conversion.Val(array2[0].Substring(0, 1)));
						switch (Module1.notice_color)
						{
						case 0:
							MyProject.Forms.mlas.txt_notice.BackColor = Color.FromArgb(36, 36, 36);
							break;
						case 1:
							MyProject.Forms.mlas.txt_notice.BackColor = Color.Maroon;
							break;
						case 2:
							MyProject.Forms.mlas.txt_notice.BackColor = Color.Navy;
							break;
						case 3:
							MyProject.Forms.mlas.txt_notice.BackColor = Color.DarkGreen;
							break;
						}
					}
					catch (Exception ex5)
					{
						ProjectData.SetProjectError(ex5);
						Exception ex6 = ex5;
						MyProject.Forms.mlas.txt_notice.BackColor = Color.FromArgb(36, 36, 36);
						ProjectData.ClearProjectError();
					}
				}
			}
			if ((Operators.CompareString(new GetHtmlClass(Module1._dburl + "/admin.php?type=pw&pw=" + TextBox2.Text, null, progress: true).getHTML(this), "correct", TextCompare: false) == 0) & (Operators.CompareString(Module1._id, TextBox1.Text, TextCompare: false) == 0))
			{
				Module1.project = Label5.Text;
				MySettingsProperty.Settings.project = Module1.project;
				MySettingsProperty.Settings.dburl = TextBox1.Text;
				MySettingsProperty.Settings.Save();
				MySettingsProperty.Settings.pw = TextBox2.Text;
				TextBox2.Text = null;
				Module1.ASrefresh();
				CHAT_MAIN_MODULE.CHAT_CLASS = new CHAT("http://umylife0208.cafe24.com/mlas");
				if (CHAT_MAIN_MODULE.CHAT_CLASS.Login(TextBox1.Text, MySettingsProperty.Settings.pw))
				{
					CHAT_MAIN_MODULE.LooperStart();
					foreach (string[] item in CHAT_MAIN_MODULE.CHAT_CLASS.MsgCountDetail())
					{
						_ = item;
					}
				}
				else
				{
					MyProject.Forms.mlas.Panel5.Hide();
				}
				Dispose();
				MyProject.Forms.mlas.Show();
			}
			else
			{
				MessageBox.Show("로그인 실패 / 인터넷 연결이 올바른지, 계정 또는 암호가 올바른지 확인하십시오.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}

	private void login_Load(object sender, EventArgs e)
	{
		TextBox1.Text = MySettingsProperty.Settings.dburl;
		TextBox2.Text = MySettingsProperty.Settings.pw;
		if (Operators.CompareString(MySettingsProperty.Settings.pw, null, TextCompare: false) != 0)
		{
			CheckBox1.Checked = true;
		}
		TextBox2.Focus();
		init = true;
		if (Operators.CompareString(MySettingsProperty.Settings.project, null, TextCompare: false) != 0)
		{
			Label5.Text = MySettingsProperty.Settings.project;
			if (Label5.Text.StartsWith("http"))
			{
				try
				{
					ComboBox1.SelectedIndex = 0;
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return;
				}
			}
			return;
		}
		try
		{
			ComboBox1.SelectedIndex = 0;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	private void Label2_Click(object sender, EventArgs e)
	{
		Process.Start("http://umylife0208.cafe24.com/");
	}

	private void TextBox2_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null), true, TextCompare: false), Operators.CompareObjectEqual(init, true, TextCompare: false))))
		{
			MessageBox.Show("암호 저장은 보안에 취약하며, 관리자 PC가 아닌경우 사용을 금하여 주십시오.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void Label5_Click(object sender, EventArgs e)
	{
		ComboBox1.Text = Label5.Text;
		Label5.Visible = false;
		ComboBox1.Visible = true;
		ComboBox1.Focus();
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Label5.Text = ComboBox1.Text;
		Label5.Visible = true;
		ComboBox1.Visible = false;
	}

	private void Label1_Click(object sender, EventArgs e)
	{
		ComboBox1.Text = Label5.Text;
		Label5.Visible = false;
		ComboBox1.Visible = true;
	}

	private void ComboBox1_Leave(object sender, EventArgs e)
	{
		Label5.Text = ComboBox1.Text;
		Label5.Visible = true;
		ComboBox1.Visible = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Button2_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void Panel1_MouseDown(object sender, MouseEventArgs e)
	{
		if (base.WindowState != FormWindowState.Maximized)
		{
			ObjectMover.MoveObject(base.Handle);
			Application.DoEvents();
			ObjectMover.FocusObject(base.Handle);
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (first)
			{
				if (base.Opacity == 1.0)
				{
					Timer1.Stop();
					first = false;
				}
				else
				{
					base.Opacity += 0.1;
				}
			}
			else if (base.Size.Height < 500)
			{
				ref object reference = ref heights;
				reference = Operators.AddObject(reference, 11);
				base.Size = new Size(469, Conversions.ToInteger(heights));
				meY -= 6;
				meY2 += 6;
				base.Location = new Point(base.Location.X, meY);
			}
			else
			{
				Timer1.Stop();
			}
		}
	}

	private void Label8_MouseMove(object sender, MouseEventArgs e)
	{
		Label8.Image = Resources.login_setting2;
	}

	private void Label8_MouseLeave(object sender, EventArgs e)
	{
		Label8.Image = Resources.login_setting1;
	}

	private void Label8_Click(object sender, EventArgs e)
	{
		checked
		{
			if (base.Size.Height >= 500)
			{
				base.Size = new Size(469, 223);
				base.Location = new Point(base.Location.X, base.Location.Y + meY2);
				return;
			}
			heights = 223;
			meY = base.Location.Y;
			meY2 = 0;
			Timer1.Start();
			Label15.Text = base.Size.ToString();
			UserAccounts = new List<accounts>();
			DataGridView1.Rows.Clear();
			if (MyProject.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Microlivire/mlas/user.dat"))
			{
				using (StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Microlivire/mlas/user.dat", Encoding.Default, detectEncodingFromByteOrderMarks: false))
				{
					string text = streamReader.ReadToEnd();
					if (Operators.CompareString(text.Trim(), null, TextCompare: false) == 0)
					{
						return;
					}
					dataCount = 1;
					string[] array = text.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(new string[1] { "<sp>" }, StringSplitOptions.None);
						UserAccounts.Add(new accounts(Conversions.ToInteger(dataCount), array2[0], array2[1], array2[2]));
						ref object reference = ref dataCount;
						reference = Operators.AddObject(reference, 1);
					}
				}
				{
					foreach (accounts userAccount in UserAccounts)
					{
						DataGridView1.Rows.Add(userAccount.getDataBlind());
					}
					return;
				}
			}
			MyProject.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Microlivire/mlas");
			using (new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Microlivire/mlas/user.dat", append: false, Encoding.Default))
			{
			}
		}
	}

	private void DataGridViewReset()
	{
		DataGridView1.Rows.Clear();
		foreach (accounts userAccount in UserAccounts)
		{
			DataGridView1.Rows.Add(userAccount.getDataBlind());
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		base.Size = new Size(469, 223);
		base.Location = new Point(base.Location.X, checked(base.Location.Y + meY2));
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox1.Text.Trim(), null, TextCompare: false) == 0)
		{
			MessageBox.Show("데이터베이스 계정 칸이 비었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		if (Operators.CompareString(TextBox2.Text.Trim(), null, TextCompare: false) == 0)
		{
			MessageBox.Show("암호 칸이 비었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		try
		{
			UserAccounts.Add(new accounts(Conversions.ToInteger(dataCount), Label5.Text, TextBox1.Text, TextBox2.Text));
			DataGridViewReset();
			ref object reference = ref dataCount;
			reference = Operators.AddObject(reference, 1);
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Microlivire/mlas/user.dat", append: false, Encoding.Default);
			string text = null;
			foreach (accounts userAccount in UserAccounts)
			{
				string[] data = userAccount.getData();
				text = text + data[1] + "<sp>" + data[2] + "<sp>" + data[3] + "\r\n";
			}
			streamWriter.Write(text.Trim());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		try
		{
			accounts item = UserAccounts.Find((accounts c) => (Conversions.ToDouble(c.getData()[0]) == Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.CurrentRow.Cells[0].Value))) ? true : false);
			UserAccounts.Remove(item);
			DataGridViewReset();
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Microlivire/mlas/user.dat", append: false, Encoding.Default);
			string text = null;
			foreach (accounts userAccount in UserAccounts)
			{
				string[] data = userAccount.getData();
				text = text + data[1] + "<sp>" + data[2] + "<sp>" + data[3] + "\r\n";
			}
			streamWriter.Write(text.Trim());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		accounts accounts = UserAccounts.Find((accounts c) => (Conversions.ToDouble(c.getData()[0]) == Conversion.Val(RuntimeHelpers.GetObjectValue(DataGridView1.CurrentRow.Cells[0].Value))) ? true : false);
		Label5.Text = accounts.getData()[1];
		TextBox1.Text = accounts.getData()[2];
		TextBox2.Text = accounts.getData()[3];
	}

	private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void login_FormClosing(object sender, FormClosingEventArgs e)
	{
		e.Cancel = true;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.login));
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Label15 = new System.Windows.Forms.Label();
		this.Button2 = new System.Windows.Forms.Button();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.DoubleBufferPanel3 = new mlas_root.DoubleBufferPanel();
		this.DataGridView1 = new System.Windows.Forms.DataGridView();
		this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DoubleBufferPanel4 = new mlas_root.DoubleBufferPanel();
		this.Button4 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Button5 = new System.Windows.Forms.Button();
		this.DoubleBufferPanel1 = new mlas_root.DoubleBufferPanel();
		this.Label8 = new System.Windows.Forms.Label();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.TextBox2 = new System.Windows.Forms.TextBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.DoubleBufferPanel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
		this.DoubleBufferPanel4.SuspendLayout();
		this.DoubleBufferPanel1.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.BackColor = System.Drawing.Color.DimGray;
		this.Panel1.Controls.Add(this.Label15);
		this.Panel1.Controls.Add(this.Button2);
		this.Panel1.Controls.Add(this.PictureBox2);
		this.Panel1.Controls.Add(this.PictureBox1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(1, 1);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(467, 70);
		this.Panel1.TabIndex = 13;
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(14, 5);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(48, 12);
		this.Label15.TabIndex = 11;
		this.Label15.Text = "Label15";
		this.Label15.Visible = false;
		this.Button2.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
		this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button2.Font = new System.Drawing.Font("굴림", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button2.ForeColor = System.Drawing.Color.White;
		this.Button2.Location = new System.Drawing.Point(447, 1);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(19, 20);
		this.Button2.TabIndex = 10;
		this.Button2.Text = "X";
		this.Button2.UseVisualStyleBackColor = false;
		this.PictureBox2.Image = mlas_root.My.Resources.Resources.logo2;
		this.PictureBox2.Location = new System.Drawing.Point(212, 26);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(213, 26);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox2.TabIndex = 9;
		this.PictureBox2.TabStop = false;
		this.PictureBox1.Image = mlas_root.My.Resources.Resources.logo3;
		this.PictureBox1.Location = new System.Drawing.Point(12, 13);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(219, 48);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox1.TabIndex = 8;
		this.PictureBox1.TabStop = false;
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 5;
		this.DoubleBufferPanel3.BackColor = System.Drawing.Color.Gainsboro;
		this.DoubleBufferPanel3.Controls.Add(this.DataGridView1);
		this.DoubleBufferPanel3.Controls.Add(this.DoubleBufferPanel4);
		this.DoubleBufferPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DoubleBufferPanel3.Location = new System.Drawing.Point(1, 222);
		this.DoubleBufferPanel3.Name = "DoubleBufferPanel3";
		this.DoubleBufferPanel3.Size = new System.Drawing.Size(467, 0);
		this.DoubleBufferPanel3.TabIndex = 15;
		this.DataGridView1.AllowUserToAddRows = false;
		this.DataGridView1.AllowUserToDeleteRows = false;
		this.DataGridView1.AllowUserToResizeColumns = false;
		this.DataGridView1.AllowUserToResizeRows = false;
		this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
		this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
		this.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.DataGridView1.ColumnHeadersHeight = 28;
		this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.DataGridView1.Columns.AddRange(this.Column4, this.Column1, this.Column2, this.Column3);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
		this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
		this.DataGridView1.GridColor = System.Drawing.Color.DarkGray;
		this.DataGridView1.Location = new System.Drawing.Point(0, 0);
		this.DataGridView1.MultiSelect = false;
		this.DataGridView1.Name = "DataGridView1";
		this.DataGridView1.ReadOnly = true;
		this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
		this.DataGridView1.RowHeadersVisible = false;
		this.DataGridView1.RowHeadersWidth = 40;
		this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
		this.DataGridView1.RowTemplate.Height = 23;
		this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DataGridView1.Size = new System.Drawing.Size(467, 0);
		this.DataGridView1.TabIndex = 13;
		this.Column4.Frozen = true;
		this.Column4.HeaderText = "번호";
		this.Column4.Name = "Column4";
		this.Column4.ReadOnly = true;
		this.Column4.Width = 40;
		dataGridViewCellStyle5.Format = "****";
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
		this.Column1.Frozen = true;
		this.Column1.HeaderText = "프로젝트";
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Column1.Width = 220;
		this.Column2.HeaderText = "계정";
		this.Column2.Name = "Column2";
		this.Column2.ReadOnly = true;
		this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		dataGridViewCellStyle6.NullValue = null;
		this.Column3.DefaultCellStyle = dataGridViewCellStyle6;
		this.Column3.HeaderText = "비밀번호";
		this.Column3.Name = "Column3";
		this.Column3.ReadOnly = true;
		this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.DoubleBufferPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.DoubleBufferPanel4.Controls.Add(this.Button4);
		this.DoubleBufferPanel4.Controls.Add(this.Button3);
		this.DoubleBufferPanel4.Controls.Add(this.Button5);
		this.DoubleBufferPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel4.Location = new System.Drawing.Point(0, -34);
		this.DoubleBufferPanel4.Name = "DoubleBufferPanel4";
		this.DoubleBufferPanel4.Padding = new System.Windows.Forms.Padding(3);
		this.DoubleBufferPanel4.Size = new System.Drawing.Size(467, 34);
		this.DoubleBufferPanel4.TabIndex = 14;
		this.Button4.BackColor = System.Drawing.Color.Red;
		this.Button4.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button4.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button4.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button4.ForeColor = System.Drawing.Color.White;
		this.Button4.Location = new System.Drawing.Point(72, 3);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(69, 26);
		this.Button4.TabIndex = 5;
		this.Button4.Text = "삭제";
		this.Button4.UseVisualStyleBackColor = false;
		this.Button3.BackColor = System.Drawing.Color.DarkGreen;
		this.Button3.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button3.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button3.ForeColor = System.Drawing.Color.White;
		this.Button3.Location = new System.Drawing.Point(3, 3);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(69, 26);
		this.Button3.TabIndex = 4;
		this.Button3.Text = "추가";
		this.Button3.UseVisualStyleBackColor = false;
		this.Button5.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button5.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button5.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button5.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button5.ForeColor = System.Drawing.Color.White;
		this.Button5.Location = new System.Drawing.Point(393, 3);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(69, 26);
		this.Button5.TabIndex = 6;
		this.Button5.Text = "닫기";
		this.Button5.UseVisualStyleBackColor = false;
		this.DoubleBufferPanel1.BackColor = System.Drawing.Color.White;
		this.DoubleBufferPanel1.Controls.Add(this.Label8);
		this.DoubleBufferPanel1.Controls.Add(this.ComboBox1);
		this.DoubleBufferPanel1.Controls.Add(this.Label1);
		this.DoubleBufferPanel1.Controls.Add(this.Label6);
		this.DoubleBufferPanel1.Controls.Add(this.Label5);
		this.DoubleBufferPanel1.Controls.Add(this.Button1);
		this.DoubleBufferPanel1.Controls.Add(this.CheckBox1);
		this.DoubleBufferPanel1.Controls.Add(this.Label2);
		this.DoubleBufferPanel1.Controls.Add(this.TextBox1);
		this.DoubleBufferPanel1.Controls.Add(this.Label4);
		this.DoubleBufferPanel1.Controls.Add(this.TextBox2);
		this.DoubleBufferPanel1.Controls.Add(this.Label3);
		this.DoubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.DoubleBufferPanel1.Location = new System.Drawing.Point(1, 71);
		this.DoubleBufferPanel1.Name = "DoubleBufferPanel1";
		this.DoubleBufferPanel1.Size = new System.Drawing.Size(467, 151);
		this.DoubleBufferPanel1.TabIndex = 13;
		this.Label8.Image = mlas_root.My.Resources.Resources.login_setting1;
		this.Label8.Location = new System.Drawing.Point(395, 52);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(39, 47);
		this.Label8.TabIndex = 15;
		this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.ComboBox1.BackColor = System.Drawing.Color.Silver;
		this.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ComboBox1.DropDownHeight = 500;
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.IntegralHeight = false;
		this.ComboBox1.Items.AddRange(new object[24]
		{
			"android_db_home_application_cctv", "android_db_kjh_smart_screen", "android_db_sjka_application_noteapp", "android_db_sjka_cyber", "android_db_ssorder", "android_mba_check", "android_mom_hakwon", "android_utility_cellulator", "home_db_laysee", "home_db_microlivire",
			"home_db_sinkinbs_woobi", "home_db_skylaw_woobi", "server_url_modify", "windows_db_game_atat", "windows_db_hnsync_profile", "windows_db_human_chart", "windows_db_imengineeringstudent", "windows_db_keyboard_typing", "windows_db_mlas_userdb", "windows_db_qr_works",
			"windows_db_safescreen", "windows_db_system_widget", "windows_db_ui_paintwork", "windows_db_xnos"
		});
		this.ComboBox1.Location = new System.Drawing.Point(137, 16);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(297, 20);
		this.ComboBox1.Sorted = true;
		this.ComboBox1.TabIndex = 10;
		this.ComboBox1.Visible = false;
		this.Label1.AutoSize = true;
		this.Label1.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
		this.Label1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.Label1.Location = new System.Drawing.Point(415, 20);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(15, 12);
		this.Label1.TabIndex = 11;
		this.Label1.Text = "▼";
		this.Label6.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label6.Location = new System.Drawing.Point(16, 21);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(115, 12);
		this.Label6.TabIndex = 12;
		this.Label6.Text = "프로젝트 선택";
		this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label5.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
		this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Label5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Label5.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.Label5.Location = new System.Drawing.Point(137, 16);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(297, 20);
		this.Label5.TabIndex = 7;
		this.Label5.Text = "android_db_sjka_application_noteapp";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Button1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.Button1.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.Cursor = System.Windows.Forms.Cursors.Default;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(263, 117);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(184, 25);
		this.Button1.TabIndex = 3;
		this.Button1.Text = "접속";
		this.Button1.UseVisualStyleBackColor = false;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.CheckBox1.Location = new System.Drawing.Point(159, 121);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(97, 16);
		this.CheckBox1.TabIndex = 2;
		this.CheckBox1.Text = "계정정보 저장";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Label2.Font = new System.Drawing.Font("굴림", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label2.Location = new System.Drawing.Point(18, 124);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(77, 11);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "ⓒ Microlivire";
		this.TextBox1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox1.Location = new System.Drawing.Point(137, 52);
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(252, 21);
		this.TextBox1.TabIndex = 0;
		this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label4.Location = new System.Drawing.Point(14, 83);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(117, 12);
		this.Label4.TabIndex = 6;
		this.Label4.Text = "비밀번호";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.TextBox2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox2.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox2.Location = new System.Drawing.Point(137, 78);
		this.TextBox2.Name = "TextBox2";
		this.TextBox2.Size = new System.Drawing.Size(252, 21);
		this.TextBox2.TabIndex = 1;
		this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.TextBox2.UseSystemPasswordChar = true;
		this.Label3.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label3.Location = new System.Drawing.Point(14, 57);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(117, 12);
		this.Label3.TabIndex = 3;
		this.Label3.Text = "데이터베이스 계정";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
		base.ClientSize = new System.Drawing.Size(469, 223);
		base.Controls.Add(this.DoubleBufferPanel3);
		base.Controls.Add(this.DoubleBufferPanel1);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "login";
		base.Opacity = 0.0;
		base.Padding = new System.Windows.Forms.Padding(1);
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Microlivire MLAS";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.DoubleBufferPanel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
		this.DoubleBufferPanel4.ResumeLayout(false);
		this.DoubleBufferPanel1.ResumeLayout(false);
		this.DoubleBufferPanel1.PerformLayout();
		base.ResumeLayout(false);
	}
}
