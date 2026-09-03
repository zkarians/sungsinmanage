using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class printpage : Form
{
	private IContainer components;

	public string txt_number;

	public string txt_name;

	public string txt_email;

	public string txt_date;

	public int[] part1_result;

	public int[] part1_mirror_result;

	public int[] symbol_result;

	public int[] others_result;

	private const int SRCCOPY = 13369376;

	private Bitmap m_PrintBitmap;

	[field: AccessedThroughProperty("picChart1")]
	internal virtual PictureBox picChart1
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

	[field: AccessedThroughProperty("PrintPreviewDialog1")]
	internal virtual PrintPreviewDialog PrintPreviewDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintDocument1")]
	internal virtual PrintDocument PrintDocument1
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

	[field: AccessedThroughProperty("picChart2")]
	internal virtual PictureBox picChart2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("picChart3")]
	internal virtual PictureBox picChart3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("picChart4")]
	internal virtual PictureBox picChart4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("picChart10")]
	internal virtual PictureBox picChart10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("picChart9")]
	internal virtual PictureBox picChart9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("picChart8")]
	internal virtual PictureBox picChart8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("picChart7")]
	internal virtual PictureBox picChart7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("picChart6")]
	internal virtual PictureBox picChart6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("picChart5")]
	internal virtual PictureBox picChart5
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PrintDocument m_PrintDocument
	{
		[CompilerGenerated]
		get
		{
			return _m_PrintDocument;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintPageEventHandler value2 = m_PrintDocument_PrintPage;
			PrintDocument printDocument = _m_PrintDocument;
			if (printDocument != null)
			{
				printDocument.PrintPage -= value2;
			}
			_m_PrintDocument = value;
			printDocument = _m_PrintDocument;
			if (printDocument != null)
			{
				printDocument.PrintPage += value2;
			}
		}
	}

	public printpage()
	{
		base.Load += Form1_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.printpage));
		this.Button1 = new System.Windows.Forms.Button();
		this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
		this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.picChart6 = new System.Windows.Forms.PictureBox();
		this.picChart1 = new System.Windows.Forms.PictureBox();
		this.picChart2 = new System.Windows.Forms.PictureBox();
		this.picChart8 = new System.Windows.Forms.PictureBox();
		this.picChart10 = new System.Windows.Forms.PictureBox();
		this.picChart9 = new System.Windows.Forms.PictureBox();
		this.picChart7 = new System.Windows.Forms.PictureBox();
		this.picChart5 = new System.Windows.Forms.PictureBox();
		this.picChart4 = new System.Windows.Forms.PictureBox();
		this.picChart3 = new System.Windows.Forms.PictureBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button3 = new System.Windows.Forms.Button();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.picChart6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.picChart1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.picChart2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.picChart8).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.picChart10).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.picChart9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.picChart7).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.picChart5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.picChart4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.picChart3).BeginInit();
		base.SuspendLayout();
		this.Button1.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(817, 47);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(108, 33);
		this.Button1.TabIndex = 1;
		this.Button1.Text = "프린트";
		this.Button1.UseVisualStyleBackColor = false;
		this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
		this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
		this.PrintPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
		this.PrintPreviewDialog1.Document = this.PrintDocument1;
		this.PrintPreviewDialog1.Enabled = true;
		this.PrintPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("PrintPreviewDialog1.Icon");
		this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
		this.PrintPreviewDialog1.ShowIcon = false;
		this.PrintPreviewDialog1.UseAntiAlias = true;
		this.PrintPreviewDialog1.Visible = false;
		this.Panel1.AutoScroll = true;
		this.Panel1.BackColor = System.Drawing.Color.White;
		this.Panel1.Controls.Add(this.PictureBox1);
		this.Panel1.Controls.Add(this.Label4);
		this.Panel1.Controls.Add(this.Label3);
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.picChart6);
		this.Panel1.Controls.Add(this.picChart1);
		this.Panel1.Controls.Add(this.picChart2);
		this.Panel1.Controls.Add(this.picChart8);
		this.Panel1.Controls.Add(this.picChart10);
		this.Panel1.Controls.Add(this.picChart9);
		this.Panel1.Controls.Add(this.picChart7);
		this.Panel1.Controls.Add(this.picChart5);
		this.Panel1.Controls.Add(this.picChart4);
		this.Panel1.Controls.Add(this.picChart3);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.MaximumSize = new System.Drawing.Size(810, 995);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(810, 739);
		this.Panel1.TabIndex = 2;
		this.PictureBox1.Image = mlas_root.My.Resources.Resources.logo21;
		this.PictureBox1.Location = new System.Drawing.Point(48, 47);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(400, 56);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox1.TabIndex = 15;
		this.PictureBox1.TabStop = false;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label4.Location = new System.Drawing.Point(28, 604);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(86, 68);
		this.Label4.TabIndex = 13;
		this.Label4.Text = "커뮤니케이션\r\n태도\r\n스타일\r\n표현력\r\n";
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label3.Location = new System.Drawing.Point(28, 840);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(86, 34);
		this.Label3.TabIndex = 12;
		this.Label3.Text = "커뮤니케이션\r\n습관적 행동";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label2.Location = new System.Drawing.Point(72, 131);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(109, 84);
		this.Label2.TabIndex = 11;
		this.Label2.Text = "• 이름 : \r\n• 이메일 : \r\n• 검사 날짜 :\r\n• 분류 번호 : ";
		this.picChart6.Location = new System.Drawing.Point(302, 538);
		this.picChart6.Name = "picChart6";
		this.picChart6.Size = new System.Drawing.Size(250, 214);
		this.picChart6.TabIndex = 5;
		this.picChart6.TabStop = false;
		this.picChart1.Location = new System.Drawing.Point(528, 15);
		this.picChart1.Name = "picChart1";
		this.picChart1.Size = new System.Drawing.Size(243, 254);
		this.picChart1.TabIndex = 0;
		this.picChart1.TabStop = false;
		this.picChart2.Location = new System.Drawing.Point(76, 275);
		this.picChart2.Name = "picChart2";
		this.picChart2.Size = new System.Drawing.Size(240, 257);
		this.picChart2.TabIndex = 1;
		this.picChart2.TabStop = false;
		this.picChart8.Location = new System.Drawing.Point(76, 758);
		this.picChart8.Name = "picChart8";
		this.picChart8.Size = new System.Drawing.Size(250, 214);
		this.picChart8.TabIndex = 7;
		this.picChart8.TabStop = false;
		this.picChart10.Location = new System.Drawing.Point(528, 758);
		this.picChart10.Name = "picChart10";
		this.picChart10.Size = new System.Drawing.Size(220, 214);
		this.picChart10.TabIndex = 9;
		this.picChart10.TabStop = false;
		this.picChart9.Location = new System.Drawing.Point(302, 758);
		this.picChart9.Name = "picChart9";
		this.picChart9.Size = new System.Drawing.Size(220, 214);
		this.picChart9.TabIndex = 8;
		this.picChart9.TabStop = false;
		this.picChart7.Location = new System.Drawing.Point(528, 538);
		this.picChart7.Name = "picChart7";
		this.picChart7.Size = new System.Drawing.Size(220, 214);
		this.picChart7.TabIndex = 6;
		this.picChart7.TabStop = false;
		this.picChart5.Location = new System.Drawing.Point(76, 538);
		this.picChart5.Name = "picChart5";
		this.picChart5.Size = new System.Drawing.Size(220, 214);
		this.picChart5.TabIndex = 4;
		this.picChart5.TabStop = false;
		this.picChart4.Location = new System.Drawing.Point(528, 275);
		this.picChart4.Name = "picChart4";
		this.picChart4.Size = new System.Drawing.Size(220, 235);
		this.picChart4.TabIndex = 3;
		this.picChart4.TabStop = false;
		this.picChart3.Location = new System.Drawing.Point(302, 275);
		this.picChart3.Name = "picChart3";
		this.picChart3.Size = new System.Drawing.Size(220, 235);
		this.picChart3.TabIndex = 2;
		this.picChart3.TabStop = false;
		this.Button2.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = System.Drawing.Color.White;
		this.Button2.Location = new System.Drawing.Point(817, 86);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(108, 33);
		this.Button2.TabIndex = 2;
		this.Button2.Text = "닫기";
		this.Button2.UseVisualStyleBackColor = false;
		this.Button3.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
		this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button3.ForeColor = System.Drawing.Color.White;
		this.Button3.Location = new System.Drawing.Point(817, 8);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(108, 33);
		this.Button3.TabIndex = 0;
		this.Button3.Text = "파일로 저장";
		this.Button3.UseVisualStyleBackColor = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		base.ClientSize = new System.Drawing.Size(932, 739);
		base.Controls.Add(this.Button3);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Button1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "printpage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "결과보기";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.picChart6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.picChart1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.picChart2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.picChart8).EndInit();
		((System.ComponentModel.ISupportInitialize)this.picChart10).EndInit();
		((System.ComponentModel.ISupportInitialize)this.picChart9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.picChart7).EndInit();
		((System.ComponentModel.ISupportInitialize)this.picChart5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.picChart4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.picChart3).EndInit();
		base.ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Text = MySettingsProperty.Settings.project;
		Label2.Font = new Font("나눔고딕", 12f, FontStyle.Regular, GraphicsUnit.Point, 129);
		Label3.Font = new Font("나눔고딕", 9.76f, FontStyle.Regular, GraphicsUnit.Point, 129);
		Label4.Font = new Font("나눔고딕", 9.76f, FontStyle.Regular, GraphicsUnit.Point, 129);
		Label2.Text = "• 이름 : " + txt_name + "\r\n• 이메일 : " + txt_email + "\r\n• 검사 일자 : " + txt_date + "\r\n• 분류 번호 : " + txt_number;
		Color[] colors = new Color[15]
		{
			Color.FromArgb(0, 112, 66),
			Color.FromArgb(152, 2, 13),
			Color.FromArgb(239, 166, 1),
			Color.FromArgb(255, 255, 255),
			Color.FromArgb(56, 56, 56),
			Color.Yellow,
			Color.White,
			Color.Gray,
			Color.LightBlue,
			Color.LightGreen,
			Color.LightCyan,
			Color.Pink,
			Color.Maroon,
			Color.LightYellow,
			Color.SkyBlue
		};
		Color[] colors2 = new Color[2]
		{
			Color.FromArgb(152, 2, 13),
			Color.FromArgb(100, 100, 100)
		};
		Color[] colors3 = new Color[3]
		{
			Color.FromArgb(0, 112, 66),
			Color.FromArgb(152, 2, 13),
			Color.FromArgb(56, 56, 56)
		};
		new Random();
		string[] marks = new string[6] { "<다섯 타입>", "셀프 타입", "에너지 타입", "해브 타입", "그룹 타입", "휴머니즘 타입" };
		checked
		{
			picChart1.Image = MakePieChart(part1_result, colors, (int)Math.Round((double)picChart1.ClientSize.Width * 0.01), 60, marks);
			string[] marks2 = new string[6] { "<미러 타입>", "셀프 타입", "에너지 타입", "해브 타입", "그룹 타입", "휴머니즘 타입" };
			picChart2.Image = MakePieChart(part1_mirror_result, colors, (int)Math.Round((double)picChart2.ClientSize.Width * 0.01), 60, marks2);
			string[] marks3 = new string[4] { "<선호 체계>", "시각", "청각", "촉각" };
			picChart3.Image = MakePieChart(symbol_result, colors3, (int)Math.Round((double)picChart3.ClientSize.Width * 0.01), 60, marks3);
			string[] marks4 = new string[3] { "<외향 / 내향>", "외향", "내향" };
			int[] values = new int[2]
			{
				others_result[0],
				others_result[1]
			};
			picChart4.Image = MakePieChart(values, colors2, (int)Math.Round((double)picChart4.ClientSize.Width * 0.01), 60, marks4);
			string[] marks5 = new string[3] { "<이성적 / 감성적>", "이성적", "감성적" };
			values = new int[2]
			{
				others_result[2],
				others_result[3]
			};
			picChart5.Image = MakePieChart(values, colors2, (int)Math.Round((double)picChart5.ClientSize.Width * 0.01), 60, marks5);
			string[] marks6 = new string[3] { "<다양한 관계 / 밀접한 관계>", "다양한 관계", "밀접한 관계" };
			values = new int[2]
			{
				others_result[4],
				others_result[5]
			};
			picChart6.Image = MakePieChart(values, colors2, (int)Math.Round((double)picChart6.ClientSize.Width * 0.01), 60, marks6);
			string[] marks7 = new string[3] { "<구체적 / 추상적>", "구체적", "추상적" };
			values = new int[2]
			{
				others_result[6],
				others_result[7]
			};
			picChart7.Image = MakePieChart(values, colors2, (int)Math.Round((double)picChart7.ClientSize.Width * 0.01), 60, marks7);
			string[] marks8 = new string[3] { "<조기착수 / 임박착수>", "조기착수", "임박착수" };
			values = new int[2]
			{
				others_result[8],
				others_result[9]
			};
			picChart8.Image = MakePieChart(values, colors2, (int)Math.Round((double)picChart8.ClientSize.Width * 0.01), 60, marks8);
			string[] marks9 = new string[3] { "<관습적 / 개성적>", "관습적", "개성적" };
			values = new int[2]
			{
				others_result[10],
				others_result[11]
			};
			picChart9.Image = MakePieChart(values, colors2, (int)Math.Round((double)picChart9.ClientSize.Width * 0.01), 60, marks9);
			string[] marks10 = new string[3] { "<체계성 / 유연성>", "체계성", "유연성" };
			values = new int[2]
			{
				others_result[12],
				others_result[13]
			};
			picChart10.Image = MakePieChart(values, colors2, (int)Math.Round((double)picChart10.ClientSize.Width * 0.01), 60, marks10);
		}
	}

	private Bitmap MakePieChart(int[] values, Color[] colors, int margin, int radius, string[] marks)
	{
		checked
		{
			float[] array = new float[values.Length + 1];
			double num = 0.0;
			int num2 = values.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				num += (double)values[i];
			}
			int num3 = values.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				array[j + 1] = (float)((double)(360 * values[j]) / num);
			}
			array[0] = 1E-07f;
			int num4 = values.Length;
			for (int k = 1; k <= num4; k++)
			{
				array[k] += array[k - 1];
				if (array[k] > 360f)
				{
					array[k] = 360f;
				}
			}
			Bitmap bitmap = new Bitmap(2 * (margin + radius + 100), 2 * (margin + radius + 100));
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			int num5 = 0;
			SolidBrush brush = new SolidBrush(Color.FromArgb(84, 84, 84));
			Pen pen = new Pen(brush);
			graphics.DrawEllipse(pen, margin + 56, margin + 30, 2 * radius, 2 * radius);
			graphics.DrawEllipse(pen, margin + 57, margin + 31, 2 * radius, 2 * radius);
			graphics.DrawEllipse(pen, margin + 58, margin + 32, 2 * radius, 2 * radius);
			int num6 = array.Length - 2;
			for (int l = 0; l <= num6; l++)
			{
				graphics.FillPie(new SolidBrush(colors[num5]), margin + 55, margin + 30, 2 * radius, 2 * radius, array[l], array[l + 1] - array[l]);
				graphics.DrawPie(pen, margin + 55, margin + 30, 2 * radius, 2 * radius, array[l], array[l + 1] - array[l]);
				unchecked
				{
					num5 = checked(num5 + 1) % colors.Length;
				}
			}
			num5 = 0;
			int num7 = 0;
			foreach (int num8 in values)
			{
				num7 += num8;
			}
			Font font = new Font("나눔고딕", 9f);
			Font font2 = new Font("나눔고딕", 10f);
			SolidBrush brush2 = new SolidBrush(Color.Black);
			graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
			StringFormat stringFormat = new StringFormat();
			stringFormat.LineAlignment = StringAlignment.Center;
			stringFormat.Alignment = StringAlignment.Center;
			graphics.DrawString(marks[0], font2, brush2, new RectangleF(15f, 0f, 210f, 20f), stringFormat);
			int num9 = 18;
			int num10 = array.Length - 2;
			for (int n = 0; n <= num10; n++)
			{
				graphics.DrawString(marks[n + 1] + " (" + Conversions.ToString(Math.Round((double)values[n] / (double)num7 * 100.0, 1)) + "%)", font, brush2, new RectangleF(70f, n * num9 + radius + 95, 300f, 200f));
				graphics.FillRectangle(new SolidBrush(colors[num5]), new Rectangle(54, n * num9 + radius + 99, 12, 12));
				graphics.DrawRectangle(pen, new Rectangle(54, n * num9 + radius + 99, 12, 12));
				unchecked
				{
					num5 = checked(num5 + 1) % colors.Length;
				}
			}
			graphics.Dispose();
			return bitmap;
		}
	}

	[DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

	private Bitmap GetFormImage()
	{
		Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Minimum;
		Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Minimum;
		checked
		{
			Bitmap image;
			using (Graphics graphics = CreateGraphics())
			{
				image = new Bitmap(base.ClientSize.Width - 140, 1024, graphics);
				Graphics graphics2 = Graphics.FromImage(image);
				IntPtr hdc = graphics2.GetHdc();
				IntPtr hdc2 = graphics.GetHdc();
				int num = 1;
				do
				{
					Thread.Sleep(10);
					Application.DoEvents();
					num++;
				}
				while (num <= 5);
				BitBlt(hdc, 0, 0, base.ClientSize.Width, base.ClientSize.Height, hdc2, 0, 0, 13369376);
				graphics.ReleaseHdc(hdc2);
				graphics2.ReleaseHdc(hdc);
			}
			Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Maximum;
			Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Maximum;
			Bitmap image2;
			using (Graphics graphics3 = CreateGraphics())
			{
				image2 = new Bitmap(base.ClientSize.Width - 140, 1024, graphics3);
				Graphics graphics4 = Graphics.FromImage(image2);
				IntPtr hdc3 = graphics4.GetHdc();
				IntPtr hdc4 = graphics3.GetHdc();
				int num2 = 1;
				do
				{
					Thread.Sleep(10);
					Application.DoEvents();
					num2++;
				}
				while (num2 <= 5);
				BitBlt(hdc3, 0, 0, base.ClientSize.Width, base.ClientSize.Height, hdc4, 0, 0, 13369376);
				graphics3.ReleaseHdc(hdc4);
				graphics4.ReleaseHdc(hdc3);
			}
			Bitmap bitmap = new Bitmap(810, 1024);
			using (Graphics graphics5 = Graphics.FromImage(bitmap))
			{
				graphics5.FillRectangle(Brushes.White, 0, 0, 810, 1024);
				graphics5.DrawImage(image2, 0, 232);
				graphics5.DrawImage(image, 0, 0);
			}
			Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Minimum;
			Panel1.VerticalScroll.Value = Panel1.VerticalScroll.Minimum;
			return bitmap;
		}
	}

	private void m_PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
	{
		checked
		{
			int num = e.MarginBounds.Y + unchecked(checked(e.MarginBounds.Height - m_PrintBitmap.Height) / 2) - 50;
			e.Graphics.DrawImage(m_PrintBitmap, 0, num);
			e.HasMorePages = false;
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		m_PrintBitmap = GetFormImage();
		m_PrintDocument = new PrintDocument();
		PrintPreviewDialog1.Document = m_PrintDocument;
		PrintPreviewDialog1.ShowDialog();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		m_PrintBitmap = GetFormImage();
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		SaveFileDialog saveFileDialog2 = saveFileDialog;
		saveFileDialog2.FileName = (txt_date + " " + txt_name).Replace(" ", "_");
		saveFileDialog2.Filter = "비트맵 (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tiff)|*.tiff";
		saveFileDialog2.Title = "차트 저장";
		saveFileDialog2.FilterIndex = 2;
		if (saveFileDialog2.ShowDialog() == DialogResult.OK)
		{
			switch (saveFileDialog2.FileName.Substring(checked(saveFileDialog2.FileName.LastIndexOf(".") + 1), 3).ToLower())
			{
			case "gif":
				m_PrintBitmap.Save(saveFileDialog2.FileName, ImageFormat.Gif);
				break;
			case "png":
				m_PrintBitmap.Save(saveFileDialog2.FileName, ImageFormat.Png);
				break;
			case "jpg":
				m_PrintBitmap.Save(saveFileDialog2.FileName, ImageFormat.Jpeg);
				break;
			case "bmp":
				m_PrintBitmap.Save(saveFileDialog2.FileName, ImageFormat.Bmp);
				break;
			case "tiff":
				m_PrintBitmap.Save(saveFileDialog2.FileName, ImageFormat.Tiff);
				break;
			default:
				m_PrintBitmap.Save(saveFileDialog2.FileName, ImageFormat.Bmp);
				break;
			}
			MessageBox.Show(saveFileDialog.FileName + " 경로에 파일로 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		saveFileDialog2 = null;
	}
}
