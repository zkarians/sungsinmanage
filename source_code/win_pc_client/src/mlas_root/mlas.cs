using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using mlas_root.My;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class mlas : Form
{
	private class GraphClass
	{
		private class GraphData
		{
			public DateTime date { get; set; }

			public int count { get; set; }

			public GraphData(object date, object count)
			{
				this.date = Conversions.ToDate(date);
				this.count = Conversions.ToInteger(count);
			}
		}

		public int AllSum;

		public int NowYearSum;

		public int Average;

		private List<GraphData> _origin;

		private List<GraphData> _graphData;

		public GraphClass(string data)
		{
			AllSum = 0;
			NowYearSum = 0;
			Average = 0;
			_origin = new List<GraphData>();
			_graphData = new List<GraphData>();
			JObject jObject = JObject.Parse(data);
			_graphData = JsonConvert.DeserializeObject<List<GraphData>>(jObject.SelectToken("DayCountData7").ToString());
			AllSum = (int)jObject.SelectToken("AllSum");
			NowYearSum = (int)jObject.SelectToken("NowYearSum");
			Average = (int)jObject.SelectToken("Average");
		}

		public int Max()
		{
			int num = 0;
			foreach (GraphData graphDatum in _graphData)
			{
				if (num < graphDatum.count)
				{
					num = graphDatum.count;
				}
			}
			return num;
		}

		public Image drawGraph(Size size)
		{
			Bitmap bitmap = new Bitmap(size.Width, size.Height);
			checked
			{
				using Graphics graphics = Graphics.FromImage(bitmap);
				Point pt = new Point(size.Width - 30, size.Height - 30);
				Point pt2 = new Point(30, 10);
				Point point = new Point(30, size.Height - 30);
				int num = (int)Math.Round((double)(size.Width - 60) / (double)_graphData.Count);
				int num2 = Max();
				StringFormat stringFormat = new StringFormat();
				stringFormat.LineAlignment = StringAlignment.Center;
				stringFormat.Alignment = StringAlignment.Center;
				double num3 = (double)(size.Height - 30) - (double)((size.Height - 30) * num2) / (double)(size.Height - 30) / (double)num2 * (double)(size.Height - 45);
				graphics.DrawLine(Pens.LightGray, new Point(30, (int)Math.Round(num3)), new Point(size.Width - 30, (int)Math.Round(num3)));
				graphics.DrawString(Conversions.ToString(num2), new Font("굴림", 8f), new SolidBrush(Color.Black), new Rectangle(0, (int)Math.Round(num3 - 5.0), 30, 12), stringFormat);
				num3 += 20.0;
				graphics.DrawLine(Pens.LightGray, new Point(30, (int)Math.Round(num3)), new Point(size.Width - 30, (int)Math.Round(num3)));
				num3 += 20.0;
				graphics.DrawLine(Pens.LightGray, new Point(30, (int)Math.Round(num3)), new Point(size.Width - 30, (int)Math.Round(num3)));
				num3 += 20.0;
				graphics.DrawLine(Pens.LightGray, new Point(30, (int)Math.Round(num3)), new Point(size.Width - 30, (int)Math.Round(num3)));
				num3 += 20.0;
				graphics.DrawLine(Pens.LightGray, new Point(30, (int)Math.Round(num3)), new Point(size.Width - 30, (int)Math.Round(num3)));
				int num4 = _graphData.Count - 1;
				for (int i = 0; i <= num4; i++)
				{
					int num5 = num * (i + 1) - 5;
					double num6 = (double)((size.Height - 30) * _graphData[i].count) / (double)(size.Height - 30) / (double)num2 * (double)(size.Height - 45);
					double num7 = (double)(size.Height - 30) - num6;
					Rectangle rect = new Rectangle(num5, (int)Math.Round(num7), 20, (int)Math.Round(num6));
					object obj = Interaction.IIf(i == _graphData.Count - 1, Color.Blue, Color.Gray);
					graphics.FillRectangle(new SolidBrush((obj != null) ? ((Color)obj) : default(Color)), rect);
					graphics.DrawString(Conversions.ToString(_graphData[i].count), new Font("굴림", 8f), new SolidBrush(Color.Black), new Rectangle(num5 - 3, (int)Math.Round(num7 - 12.0), 25, 12), stringFormat);
					graphics.DrawString(_graphData[i].date.ToString("MM/dd", CultureInfo.InvariantCulture), new Font("굴림", 8f), new SolidBrush(Color.Black), new Rectangle(num5 - 7, point.Y + 5, 35, 12), stringFormat);
				}
				graphics.DrawLine(Pens.Black, point, pt);
				graphics.DrawLine(Pens.Black, pt2, point);
				graphics.DrawString(Conversions.ToString(0), new Font("굴림", 8f), new SolidBrush(Color.Black), new Rectangle(0, point.Y - 5, 30, 12), stringFormat);
				return bitmap;
			}
		}
	}

	public struct WINDOWPOS
	{
		public IntPtr hwnd;

		public IntPtr hwndInsertAfter;

		public int x;

		public int y;

		public int cx;

		public int cy;

		public int flags;
	}

	private IContainer components;

	private Size FixedFormSize;

	private int nowListbox1;

	private bool Listbox1EventExit;

	private bool notice_detail;

	private string down;

	private bool form_active;

	private const int mSnapOffset = 20;

	private const int WM_WINDOWPOSCHANGING = 70;

	private object anim_count;

	private object anim_maxcount;

	private Panel anim_obj;

	private const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;

	private const int SET_FEATURE_ON_THREAD = 1;

	private const int SET_FEATURE_ON_PROCESS = 2;

	private const int SET_FEATURE_IN_REGISTRY = 4;

	private const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 8;

	private const int SET_FEATURE_ON_THREAD_INTRANET = 16;

	private const int SET_FEATURE_ON_THREAD_TRUSTED = 32;

	private const int SET_FEATURE_ON_THREAD_INTERNET = 64;

	private const int SET_FEATURE_ON_THREAD_RESTRICTED = 128;

	private bool drag;

	private object type;

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
			EventHandler value2 = PictureBox1_Click;
			PictureBox pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox1 = value;
			pictureBox = _PictureBox1;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	internal virtual TransparentListBox ListBox1
	{
		[CompilerGenerated]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ListBox1_SelectedIndexChanged;
			DrawItemEventHandler value3 = ListBox1_DrawItem_1;
			TransparentListBox listBox = _ListBox1;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value2;
				listBox.DrawItem -= value3;
			}
			_ListBox1 = value;
			listBox = _ListBox1;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value2;
				listBox.DrawItem += value3;
			}
		}
	}

	[field: AccessedThroughProperty("p1")]
	internal virtual Panel p1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lb2")]
	internal virtual Label lb2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lb1")]
	internal virtual Label lb1
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual PictureBox PictureBox4
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = PictureBox4_Click;
			PictureBox pictureBox = _PictureBox4;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_PictureBox4 = value;
			pictureBox = _PictureBox4;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel50")]
	internal virtual Panel Panel50
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel51")]
	internal virtual Panel Panel51
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label39")]
	internal virtual Label Label39
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lb4")]
	internal virtual Label lb4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lb3")]
	internal virtual Label lb3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel53")]
	internal virtual Panel Panel53
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label txt_notice
	{
		[CompilerGenerated]
		get
		{
			return _txt_notice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Label4_Click;
			Label label = _txt_notice;
			if (label != null)
			{
				label.Click -= value2;
			}
			_txt_notice = value;
			label = _txt_notice;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("txt_noticedetail")]
	internal virtual Label txt_noticedetail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p9")]
	internal virtual Panel p9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel62")]
	internal virtual Panel Panel62
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel63")]
	internal virtual Panel Panel63
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label40")]
	internal virtual Label Label40
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label41")]
	internal virtual Label Label41
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel64")]
	internal virtual Panel Panel64
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel65")]
	internal virtual Panel Panel65
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel66")]
	internal virtual Panel Panel66
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button52
	{
		[CompilerGenerated]
		get
		{
			return _Button52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button52_Click;
			Button button = _Button52;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button52 = value;
			button = _Button52;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TextBox12")]
	internal virtual TextBox TextBox12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual WebClient WebClient1
	{
		[CompilerGenerated]
		get
		{
			return _WebClient1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DownloadProgressChangedEventHandler value2 = WebClient1_DownloadProgressChanged;
			AsyncCompletedEventHandler value3 = WebClient1_DownloadFileCompleted;
			WebClient webClient = _WebClient1;
			if (webClient != null)
			{
				webClient.DownloadProgressChanged -= value2;
				webClient.DownloadFileCompleted -= value3;
			}
			_WebClient1 = value;
			webClient = _WebClient1;
			if (webClient != null)
			{
				webClient.DownloadProgressChanged += value2;
				webClient.DownloadFileCompleted += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Panel85")]
	internal virtual Panel Panel85
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ListView ListView4
	{
		[CompilerGenerated]
		get
		{
			return _ListView4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ListView4_SelectedIndexChanged;
			MouseEventHandler value3 = ListView4_MouseDoubleClick;
			ListView listView = _ListView4;
			if (listView != null)
			{
				listView.SelectedIndexChanged -= value2;
				listView.MouseDoubleClick -= value3;
			}
			_ListView4 = value;
			listView = _ListView4;
			if (listView != null)
			{
				listView.SelectedIndexChanged += value2;
				listView.MouseDoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("ColumnHeader30")]
	internal virtual ColumnHeader ColumnHeader30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel86")]
	internal virtual Panel Panel86
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel87")]
	internal virtual Panel Panel87
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label66")]
	internal virtual Label Label66
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label67")]
	internal virtual Label Label67
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel88")]
	internal virtual Panel Panel88
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel89")]
	internal virtual Panel Panel89
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel90")]
	internal virtual Panel Panel90
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button67
	{
		[CompilerGenerated]
		get
		{
			return _Button67;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button67_Click;
			Button button = _Button67;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button67 = value;
			button = _Button67;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual TextBox TextBox19
	{
		[CompilerGenerated]
		get
		{
			return _TextBox19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TextBox19_TextChanged;
			TextBox textBox = _TextBox19;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_TextBox19 = value;
			textBox = _TextBox19;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel92")]
	internal virtual Panel Panel92
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel91")]
	internal virtual Panel Panel91
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar6")]
	internal virtual ProgressBar ProgressBar6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label69")]
	internal virtual Label Label69
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button69
	{
		[CompilerGenerated]
		get
		{
			return _Button69;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button69_Click;
			Button button = _Button69;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button69 = value;
			button = _Button69;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button68
	{
		[CompilerGenerated]
		get
		{
			return _Button68;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button68_Click;
			Button button = _Button68;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button68 = value;
			button = _Button68;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label70")]
	internal virtual Label Label70
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader32")]
	internal virtual ColumnHeader ColumnHeader32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel93")]
	internal virtual Panel Panel93
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label71")]
	internal virtual Label Label71
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader27")]
	internal virtual ColumnHeader ColumnHeader27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader28")]
	internal virtual ColumnHeader ColumnHeader28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel94")]
	internal virtual Panel Panel94
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button70
	{
		[CompilerGenerated]
		get
		{
			return _Button70;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button70_Click;
			Button button = _Button70;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button70 = value;
			button = _Button70;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button71
	{
		[CompilerGenerated]
		get
		{
			return _Button71;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button71_Click;
			Button button = _Button71;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button71 = value;
			button = _Button71;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button72
	{
		[CompilerGenerated]
		get
		{
			return _Button72;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button72_Click;
			Button button = _Button72;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button72 = value;
			button = _Button72;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel95")]
	internal virtual Panel Panel95
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ColumnHeader29")]
	internal virtual ColumnHeader ColumnHeader29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("mod_p1")]
	internal virtual Panel mod_p1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel104")]
	internal virtual Panel Panel104
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel105")]
	internal virtual Panel Panel105
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label78")]
	internal virtual Label Label78
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label79")]
	internal virtual Label Label79
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel106")]
	internal virtual Panel Panel106
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel107")]
	internal virtual Panel Panel107
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel108")]
	internal virtual Panel Panel108
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button75
	{
		[CompilerGenerated]
		get
		{
			return _Button75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button75_Click;
			Button button = _Button75;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button75 = value;
			button = _Button75;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual ComboBox ComboBox17
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DrawItemEventHandler value2 = ListBox1_DrawItem;
			ComboBox comboBox = _ComboBox17;
			if (comboBox != null)
			{
				comboBox.DrawItem -= value2;
			}
			_ComboBox17 = value;
			comboBox = _ComboBox17;
			if (comboBox != null)
			{
				comboBox.DrawItem += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label80")]
	internal virtual Label Label80
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label81")]
	internal virtual Label Label81
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label82")]
	internal virtual Label Label82
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label83")]
	internal virtual Label Label83
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox21")]
	internal virtual TextBox TextBox21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox20")]
	internal virtual TextBox TextBox20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel110")]
	internal virtual Panel Panel110
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox24")]
	internal virtual TextBox TextBox24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label87")]
	internal virtual Label Label87
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button76
	{
		[CompilerGenerated]
		get
		{
			return _Button76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button76_Click;
			Button button = _Button76;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button76 = value;
			button = _Button76;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Panel111")]
	internal virtual Panel Panel111
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("server_url_modify")]
	internal virtual Panel server_url_modify
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label94")]
	internal virtual Label Label94
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

	internal virtual DoubleBufferPanel Panel4
	{
		[CompilerGenerated]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel4_MouseDown;
			MouseEventHandler value3 = Panel4_MouseDoubleClick;
			DoubleBufferPanel panel = _Panel4;
			if (panel != null)
			{
				panel.MouseDown -= value2;
				panel.MouseDoubleClick -= value3;
			}
			_Panel4 = value;
			panel = _Panel4;
			if (panel != null)
			{
				panel.MouseDown += value2;
				panel.MouseDoubleClick += value3;
			}
		}
	}

	internal virtual DoubleBufferFlowLayoutPanel FlowLayoutPanel1
	{
		[CompilerGenerated]
		get
		{
			return _FlowLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel4_MouseDown;
			MouseEventHandler value3 = Panel4_MouseDoubleClick;
			DoubleBufferFlowLayoutPanel flowLayoutPanel = _FlowLayoutPanel1;
			if (flowLayoutPanel != null)
			{
				flowLayoutPanel.MouseDown -= value2;
				flowLayoutPanel.MouseDoubleClick -= value3;
			}
			_FlowLayoutPanel1 = value;
			flowLayoutPanel = _FlowLayoutPanel1;
			if (flowLayoutPanel != null)
			{
				flowLayoutPanel.MouseDown += value2;
				flowLayoutPanel.MouseDoubleClick += value3;
			}
		}
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
			MouseEventHandler value2 = PictureBox3_MouseMove;
			EventHandler value3 = PictureBox3_MouseLeave;
			EventHandler value4 = PictureBox3_Click;
			PictureBox pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.MouseMove -= value2;
				pictureBox.MouseLeave -= value3;
				pictureBox.Click -= value4;
			}
			_PictureBox3 = value;
			pictureBox = _PictureBox3;
			if (pictureBox != null)
			{
				pictureBox.MouseMove += value2;
				pictureBox.MouseLeave += value3;
				pictureBox.Click += value4;
			}
		}
	}

	internal virtual PictureBox PictureBox6
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = PictureBox6_MouseMove;
			EventHandler value3 = PictureBox6_MouseLeave;
			EventHandler value4 = PictureBox6_Click;
			PictureBox pictureBox = _PictureBox6;
			if (pictureBox != null)
			{
				pictureBox.MouseMove -= value2;
				pictureBox.MouseLeave -= value3;
				pictureBox.Click -= value4;
			}
			_PictureBox6 = value;
			pictureBox = _PictureBox6;
			if (pictureBox != null)
			{
				pictureBox.MouseMove += value2;
				pictureBox.MouseLeave += value3;
				pictureBox.Click += value4;
			}
		}
	}

	internal virtual PictureBox PictureBox5
	{
		[CompilerGenerated]
		get
		{
			return _PictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = PictureBox5_MouseMove;
			EventHandler value3 = PictureBox5_MouseLeave;
			EventHandler value4 = PictureBox5_Click;
			PictureBox pictureBox = _PictureBox5;
			if (pictureBox != null)
			{
				pictureBox.MouseMove -= value2;
				pictureBox.MouseLeave -= value3;
				pictureBox.Click -= value4;
			}
			_PictureBox5 = value;
			pictureBox = _PictureBox5;
			if (pictureBox != null)
			{
				pictureBox.MouseMove += value2;
				pictureBox.MouseLeave += value3;
				pictureBox.Click += value4;
			}
		}
	}

	[field: AccessedThroughProperty("ToolTip1")]
	internal virtual ToolTip ToolTip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer2_Tick;
			Timer timer = _Timer2;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer2 = value;
			timer = _Timer2;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual Timer Timer3
	{
		[CompilerGenerated]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer3_Tick;
			Timer timer = _Timer3;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer3 = value;
			timer = _Timer3;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
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

	internal virtual Timer chat_receiver
	{
		[CompilerGenerated]
		get
		{
			return _chat_receiver;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chat_receiver_Tick;
			Timer timer = _chat_receiver;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_chat_receiver = value;
			timer = _chat_receiver;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual DoubleBufferPanel Panel5
	{
		[CompilerGenerated]
		get
		{
			return _Panel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Panel5_Click;
			DoubleBufferPanel panel = _Panel5;
			if (panel != null)
			{
				panel.Click -= value2;
			}
			_Panel5 = value;
			panel = _Panel5;
			if (panel != null)
			{
				panel.Click += value2;
			}
		}
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
			EventHandler value2 = Panel5_Click;
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel6")]
	internal virtual Panel Panel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox8")]
	internal virtual PictureBox PictureBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel7")]
	internal virtual Panel Panel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label13")]
	internal virtual Label Label13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
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

	[field: AccessedThroughProperty("chartPanel")]
	internal virtual Panel chartPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlowLayoutPanel2")]
	internal virtual FlowLayoutPanel FlowLayoutPanel2
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

	[field: AccessedThroughProperty("Panel10")]
	internal virtual Panel Panel10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chartGraph")]
	internal virtual PictureBox chartGraph
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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

	[field: AccessedThroughProperty("PictureBox11")]
	internal virtual PictureBox PictureBox11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox9")]
	internal virtual PictureBox PictureBox9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox7")]
	internal virtual PictureBox PictureBox7
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

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
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

	internal virtual DoubleBufferPanel newmessage
	{
		[CompilerGenerated]
		get
		{
			return _newmessage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Panel5_Click;
			DoubleBufferPanel doubleBufferPanel = _newmessage;
			if (doubleBufferPanel != null)
			{
				doubleBufferPanel.Click -= value2;
			}
			_newmessage = value;
			doubleBufferPanel = _newmessage;
			if (doubleBufferPanel != null)
			{
				doubleBufferPanel.Click += value2;
			}
		}
	}

	internal virtual Panel Panel8
	{
		[CompilerGenerated]
		get
		{
			return _Panel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel4_MouseDown;
			MouseEventHandler value3 = Panel4_MouseDoubleClick;
			Panel panel = _Panel8;
			if (panel != null)
			{
				panel.MouseDown -= value2;
				panel.MouseDoubleClick -= value3;
			}
			_Panel8 = value;
			panel = _Panel8;
			if (panel != null)
			{
				panel.MouseDown += value2;
				panel.MouseDoubleClick += value3;
			}
		}
	}

	internal virtual Timer ssorder_update_checker
	{
		[CompilerGenerated]
		get
		{
			return _ssorder_update_checker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ssorder_update_checker_Tick;
			Timer timer = _ssorder_update_checker;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_ssorder_update_checker = value;
			timer = _ssorder_update_checker;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	internal virtual NoCopyLabel Label4
	{
		[CompilerGenerated]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = Panel4_MouseDown;
			MouseEventHandler value3 = Panel4_MouseDoubleClick;
			NoCopyLabel label = _Label4;
			if (label != null)
			{
				label.MouseDown -= value2;
				label.MouseDoubleClick -= value3;
			}
			_Label4 = value;
			label = _Label4;
			if (label != null)
			{
				label.MouseDown += value2;
				label.MouseDoubleClick += value3;
			}
		}
	}

	public mlas()
	{
		base.Load += sjka_Load;
		base.FormClosing += mlas_FormClosing;
		base.Activated += main_Activated;
		base.Deactivate += main_Deactivate;
		base.MouseMove += mlas_MouseMove;
		base.MouseLeave += mlas_MouseLeave;
		base.MouseDown += mlas_MouseDown;
		base.MouseUp += mlas_MouseUp;
		FixedFormSize = default(Size);
		nowListbox1 = -1;
		Listbox1EventExit = false;
		notice_detail = false;
		down = null;
		form_active = false;
		anim_count = 0;
		type = -1;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.mlas));
		this.p1 = new System.Windows.Forms.Panel();
		this.Button3 = new System.Windows.Forms.Button();
		this.Panel51 = new System.Windows.Forms.Panel();
		this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
		this.Panel9 = new System.Windows.Forms.Panel();
		this.Label3 = new System.Windows.Forms.Label();
		this.lb1 = new System.Windows.Forms.Label();
		this.lb2 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.lb4 = new System.Windows.Forms.Label();
		this.lb3 = new System.Windows.Forms.Label();
		this.Panel10 = new System.Windows.Forms.Panel();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Label39 = new System.Windows.Forms.Label();
		this.Button1 = new System.Windows.Forms.Button();
		this.chartPanel = new System.Windows.Forms.Panel();
		this.Button2 = new System.Windows.Forms.Button();
		this.chartGraph = new System.Windows.Forms.PictureBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label11 = new System.Windows.Forms.Label();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.Panel7 = new System.Windows.Forms.Panel();
		this.PictureBox11 = new System.Windows.Forms.PictureBox();
		this.PictureBox9 = new System.Windows.Forms.PictureBox();
		this.PictureBox7 = new System.Windows.Forms.PictureBox();
		this.PictureBox8 = new System.Windows.Forms.PictureBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.p9 = new System.Windows.Forms.Panel();
		this.TextBox12 = new System.Windows.Forms.TextBox();
		this.Panel95 = new System.Windows.Forms.Panel();
		this.Panel62 = new System.Windows.Forms.Panel();
		this.Panel63 = new System.Windows.Forms.Panel();
		this.Label40 = new System.Windows.Forms.Label();
		this.Label41 = new System.Windows.Forms.Label();
		this.Panel64 = new System.Windows.Forms.Panel();
		this.Panel65 = new System.Windows.Forms.Panel();
		this.Panel66 = new System.Windows.Forms.Panel();
		this.Button72 = new System.Windows.Forms.Button();
		this.Button52 = new System.Windows.Forms.Button();
		this.Panel53 = new System.Windows.Forms.Panel();
		this.txt_noticedetail = new System.Windows.Forms.Label();
		this.txt_notice = new System.Windows.Forms.Label();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Panel85 = new System.Windows.Forms.Panel();
		this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
		this.ListView4 = new System.Windows.Forms.ListView();
		this.ColumnHeader29 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader32 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader28 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader30 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader27 = new System.Windows.Forms.ColumnHeader();
		this.TextBox19 = new System.Windows.Forms.TextBox();
		this.Panel93 = new System.Windows.Forms.Panel();
		this.Panel86 = new System.Windows.Forms.Panel();
		this.Label67 = new System.Windows.Forms.Label();
		this.Button71 = new System.Windows.Forms.Button();
		this.Panel87 = new System.Windows.Forms.Panel();
		this.Label66 = new System.Windows.Forms.Label();
		this.Panel88 = new System.Windows.Forms.Panel();
		this.Panel89 = new System.Windows.Forms.Panel();
		this.Panel92 = new System.Windows.Forms.Panel();
		this.Label70 = new System.Windows.Forms.Label();
		this.Panel94 = new System.Windows.Forms.Panel();
		this.Button70 = new System.Windows.Forms.Button();
		this.Button68 = new System.Windows.Forms.Button();
		this.Button69 = new System.Windows.Forms.Button();
		this.Panel91 = new System.Windows.Forms.Panel();
		this.ProgressBar6 = new System.Windows.Forms.ProgressBar();
		this.Label69 = new System.Windows.Forms.Label();
		this.Panel90 = new System.Windows.Forms.Panel();
		this.Label71 = new System.Windows.Forms.Label();
		this.Button67 = new System.Windows.Forms.Button();
		this.server_url_modify = new System.Windows.Forms.Panel();
		this.Label94 = new System.Windows.Forms.Label();
		this.mod_p1 = new System.Windows.Forms.Panel();
		this.Panel111 = new System.Windows.Forms.Panel();
		this.Label81 = new System.Windows.Forms.Label();
		this.Label80 = new System.Windows.Forms.Label();
		this.Button76 = new System.Windows.Forms.Button();
		this.ComboBox17 = new System.Windows.Forms.ComboBox();
		this.TextBox21 = new System.Windows.Forms.TextBox();
		this.Label82 = new System.Windows.Forms.Label();
		this.TextBox20 = new System.Windows.Forms.TextBox();
		this.Label83 = new System.Windows.Forms.Label();
		this.Panel110 = new System.Windows.Forms.Panel();
		this.TextBox24 = new System.Windows.Forms.TextBox();
		this.Button75 = new System.Windows.Forms.Button();
		this.Label87 = new System.Windows.Forms.Label();
		this.Panel104 = new System.Windows.Forms.Panel();
		this.Panel105 = new System.Windows.Forms.Panel();
		this.Label78 = new System.Windows.Forms.Label();
		this.Label79 = new System.Windows.Forms.Label();
		this.Panel106 = new System.Windows.Forms.Panel();
		this.Panel107 = new System.Windows.Forms.Panel();
		this.Panel108 = new System.Windows.Forms.Panel();
		this.WebClient1 = new System.Net.WebClient();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.ListBox1 = new mlas_root.TransparentListBox();
		this.Panel50 = new System.Windows.Forms.Panel();
		this.PictureBox4 = new System.Windows.Forms.PictureBox();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.PictureBox6 = new System.Windows.Forms.PictureBox();
		this.PictureBox5 = new System.Windows.Forms.PictureBox();
		this.Timer2 = new System.Windows.Forms.Timer(this.components);
		this.Timer3 = new System.Windows.Forms.Timer(this.components);
		this.chat_receiver = new System.Windows.Forms.Timer(this.components);
		this.ssorder_update_checker = new System.Windows.Forms.Timer(this.components);
		this.Panel4 = new mlas_root.DoubleBufferPanel();
		this.Label4 = new mlas_root.NoCopyLabel();
		this.FlowLayoutPanel1 = new mlas_root.DoubleBufferFlowLayoutPanel();
		this.Panel5 = new mlas_root.DoubleBufferPanel();
		this.Label5 = new System.Windows.Forms.Label();
		this.newmessage = new mlas_root.DoubleBufferPanel();
		this.Panel8 = new System.Windows.Forms.Panel();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.p1.SuspendLayout();
		this.Panel51.SuspendLayout();
		this.FlowLayoutPanel2.SuspendLayout();
		this.Panel9.SuspendLayout();
		this.Panel10.SuspendLayout();
		this.chartPanel.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.chartGraph).BeginInit();
		this.Panel6.SuspendLayout();
		this.Panel7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox11).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox7).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox8).BeginInit();
		this.p9.SuspendLayout();
		this.Panel62.SuspendLayout();
		this.Panel66.SuspendLayout();
		this.Panel53.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel85.SuspendLayout();
		this.SplitContainer1.Panel1.SuspendLayout();
		this.SplitContainer1.Panel2.SuspendLayout();
		this.SplitContainer1.SuspendLayout();
		this.Panel86.SuspendLayout();
		this.Panel92.SuspendLayout();
		this.Panel94.SuspendLayout();
		this.Panel91.SuspendLayout();
		this.Panel90.SuspendLayout();
		this.server_url_modify.SuspendLayout();
		this.mod_p1.SuspendLayout();
		this.Panel111.SuspendLayout();
		this.Panel110.SuspendLayout();
		this.Panel104.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.Panel50.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).BeginInit();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox5).BeginInit();
		this.Panel4.SuspendLayout();
		this.FlowLayoutPanel1.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.Panel8.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.p1.Controls.Add(this.Button3);
		this.p1.Controls.Add(this.Panel51);
		this.p1.Controls.Add(this.Label1);
		this.p1.Controls.Add(this.Label2);
		this.p1.Location = new System.Drawing.Point(14, 31);
		this.p1.Name = "p1";
		this.p1.Size = new System.Drawing.Size(816, 473);
		this.p1.TabIndex = 0;
		this.Button3.Location = new System.Drawing.Point(-8, 0);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(75, 23);
		this.Button3.TabIndex = 7;
		this.Button3.Text = "Button3";
		this.Button3.UseVisualStyleBackColor = true;
		this.Button3.Visible = false;
		this.Panel51.Controls.Add(this.FlowLayoutPanel2);
		this.Panel51.Controls.Add(this.Panel6);
		this.Panel51.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel51.Location = new System.Drawing.Point(0, 61);
		this.Panel51.Name = "Panel51";
		this.Panel51.Size = new System.Drawing.Size(816, 368);
		this.Panel51.TabIndex = 12;
		this.FlowLayoutPanel2.Controls.Add(this.Panel9);
		this.FlowLayoutPanel2.Controls.Add(this.Panel10);
		this.FlowLayoutPanel2.Controls.Add(this.chartPanel);
		this.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
		this.FlowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
		this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
		this.FlowLayoutPanel2.Size = new System.Drawing.Size(441, 368);
		this.FlowLayoutPanel2.TabIndex = 29;
		this.Panel9.Controls.Add(this.Label3);
		this.Panel9.Controls.Add(this.lb1);
		this.Panel9.Controls.Add(this.lb2);
		this.Panel9.Controls.Add(this.Label7);
		this.Panel9.Controls.Add(this.lb4);
		this.Panel9.Controls.Add(this.lb3);
		this.Panel9.Location = new System.Drawing.Point(20, 10);
		this.Panel9.Margin = new System.Windows.Forms.Padding(20, 10, 3, 3);
		this.Panel9.Name = "Panel9";
		this.Panel9.Size = new System.Drawing.Size(415, 145);
		this.Panel9.TabIndex = 30;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("맑은 고딕", 14.25f, System.Drawing.FontStyle.Bold);
		this.Label3.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label3.Location = new System.Drawing.Point(-5, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(204, 25);
		this.Label3.TabIndex = 4;
		this.Label3.Text = "제품 이용자 기본 정보";
		this.lb1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.lb1.ForeColor = System.Drawing.Color.Black;
		this.lb1.Location = new System.Drawing.Point(0, 29);
		this.lb1.Name = "lb1";
		this.lb1.Size = new System.Drawing.Size(415, 21);
		this.lb1.TabIndex = 5;
		this.lb1.Text = "프로젝트 : ";
		this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lb2.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.lb2.ForeColor = System.Drawing.Color.Black;
		this.lb2.Location = new System.Drawing.Point(0, 53);
		this.lb2.Name = "lb2";
		this.lb2.Size = new System.Drawing.Size(415, 21);
		this.lb2.TabIndex = 6;
		this.lb2.Text = "위치 : ";
		this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label7.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label7.ForeColor = System.Drawing.Color.Black;
		this.Label7.Location = new System.Drawing.Point(0, 125);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(415, 21);
		this.Label7.TabIndex = 20;
		this.Label7.Text = "최근 로그인 : ";
		this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lb4.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.lb4.ForeColor = System.Drawing.Color.Black;
		this.lb4.Location = new System.Drawing.Point(0, 101);
		this.lb4.Name = "lb4";
		this.lb4.Size = new System.Drawing.Size(415, 21);
		this.lb4.TabIndex = 12;
		this.lb4.Text = "제품 사용 허가 : ";
		this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lb3.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.lb3.ForeColor = System.Drawing.Color.Black;
		this.lb3.Location = new System.Drawing.Point(0, 77);
		this.lb3.Name = "lb3";
		this.lb3.Size = new System.Drawing.Size(415, 21);
		this.lb3.TabIndex = 13;
		this.lb3.Text = "서비스 사용자 분류 : N";
		this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel10.Controls.Add(this.Label6);
		this.Panel10.Controls.Add(this.Label8);
		this.Panel10.Controls.Add(this.Label9);
		this.Panel10.Controls.Add(this.Label39);
		this.Panel10.Controls.Add(this.Button1);
		this.Panel10.Location = new System.Drawing.Point(20, 168);
		this.Panel10.Margin = new System.Windows.Forms.Padding(20, 10, 3, 3);
		this.Panel10.Name = "Panel10";
		this.Panel10.Size = new System.Drawing.Size(405, 133);
		this.Panel10.TabIndex = 30;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("맑은 고딕", 14.25f, System.Drawing.FontStyle.Bold);
		this.Label6.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label6.Location = new System.Drawing.Point(-5, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(366, 25);
		this.Label6.TabIndex = 7;
		this.Label6.Text = "MLAS(Microlivire Admin Solution) 정보";
		this.Label8.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label8.ForeColor = System.Drawing.Color.Black;
		this.Label8.Location = new System.Drawing.Point(0, 75);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(443, 21);
		this.Label8.TabIndex = 9;
		this.Label8.Text = "문의 : microlivire@gmail.com";
		this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label9.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label9.ForeColor = System.Drawing.Color.Black;
		this.Label9.Location = new System.Drawing.Point(0, 29);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(443, 21);
		this.Label9.TabIndex = 10;
		this.Label9.Text = "버전 ";
		this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label39.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label39.ForeColor = System.Drawing.Color.Black;
		this.Label39.Location = new System.Drawing.Point(0, 52);
		this.Label39.Name = "Label39";
		this.Label39.Size = new System.Drawing.Size(443, 21);
		this.Label39.TabIndex = 11;
		this.Label39.Text = "ⓒ 2016 Microlivire 모든 권리 보유";
		this.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button1.BackColor = System.Drawing.Color.Blue;
		this.Button1.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = System.Drawing.Color.White;
		this.Button1.Location = new System.Drawing.Point(0, 100);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(180, 25);
		this.Button1.TabIndex = 19;
		this.Button1.Text = "알림창 표시";
		this.Button1.UseVisualStyleBackColor = false;
		this.Button1.Visible = false;
		this.chartPanel.Controls.Add(this.Button2);
		this.chartPanel.Controls.Add(this.chartGraph);
		this.chartPanel.Controls.Add(this.Label10);
		this.chartPanel.Controls.Add(this.Label14);
		this.chartPanel.Controls.Add(this.Label13);
		this.chartPanel.Controls.Add(this.Label11);
		this.chartPanel.Location = new System.Drawing.Point(20, 304);
		this.chartPanel.Margin = new System.Windows.Forms.Padding(20, 0, 3, 3);
		this.chartPanel.Name = "chartPanel";
		this.chartPanel.Size = new System.Drawing.Size(415, 242);
		this.chartPanel.TabIndex = 28;
		this.chartPanel.Visible = false;
		this.Button2.BackColor = System.Drawing.Color.Transparent;
		this.Button2.BackgroundImage = mlas_root.My.Resources.Resources.redo_32x32_72;
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.Button2.Location = new System.Drawing.Point(147, 81);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(17, 16);
		this.Button2.TabIndex = 27;
		this.Button2.UseVisualStyleBackColor = false;
		this.chartGraph.Location = new System.Drawing.Point(3, 99);
		this.chartGraph.Name = "chartGraph";
		this.chartGraph.Size = new System.Drawing.Size(409, 142);
		this.chartGraph.TabIndex = 25;
		this.chartGraph.TabStop = false;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("맑은 고딕", 14.25f, System.Drawing.FontStyle.Bold);
		this.Label10.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label10.Location = new System.Drawing.Point(-5, 0);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(166, 25);
		this.Label10.TabIndex = 22;
		this.Label10.Text = "앱 사용 유저 통계";
		this.Label14.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label14.ForeColor = System.Drawing.Color.Black;
		this.Label14.Location = new System.Drawing.Point(0, 30);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(415, 21);
		this.Label14.TabIndex = 23;
		this.Label14.Text = "누적 접속 횟수 : ";
		this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label13.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label13.ForeColor = System.Drawing.Color.Black;
		this.Label13.Location = new System.Drawing.Point(0, 54);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(415, 21);
		this.Label13.TabIndex = 24;
		this.Label13.Text = "하루 평균 접속 횟수 : ";
		this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label11.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label11.ForeColor = System.Drawing.Color.Blue;
		this.Label11.Location = new System.Drawing.Point(0, 82);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(165, 17);
		this.Label11.TabIndex = 26;
		this.Label11.Text = "최근 7일 접속자 그래프";
		this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel6.Controls.Add(this.Panel7);
		this.Panel6.Controls.Add(this.PictureBox8);
		this.Panel6.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel6.Location = new System.Drawing.Point(466, 0);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(350, 368);
		this.Panel6.TabIndex = 21;
		this.Panel7.Controls.Add(this.PictureBox11);
		this.Panel7.Controls.Add(this.PictureBox9);
		this.Panel7.Controls.Add(this.PictureBox7);
		this.Panel7.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel7.Location = new System.Drawing.Point(0, 0);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new System.Drawing.Size(350, 476);
		this.Panel7.TabIndex = 21;
		this.PictureBox11.Image = mlas_root.My.Resources.Resources.banner2;
		this.PictureBox11.Location = new System.Drawing.Point(12, 10);
		this.PictureBox11.Name = "PictureBox11";
		this.PictureBox11.Size = new System.Drawing.Size(338, 114);
		this.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox11.TabIndex = 26;
		this.PictureBox11.TabStop = false;
		this.PictureBox9.Image = mlas_root.My.Resources.Resources.banner4;
		this.PictureBox9.Location = new System.Drawing.Point(12, 130);
		this.PictureBox9.Name = "PictureBox9";
		this.PictureBox9.Size = new System.Drawing.Size(338, 114);
		this.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox9.TabIndex = 25;
		this.PictureBox9.TabStop = false;
		this.PictureBox7.Image = mlas_root.My.Resources.Resources.banner3;
		this.PictureBox7.Location = new System.Drawing.Point(107, 256);
		this.PictureBox7.Name = "PictureBox7";
		this.PictureBox7.Size = new System.Drawing.Size(240, 217);
		this.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox7.TabIndex = 24;
		this.PictureBox7.TabStop = false;
		this.PictureBox8.Image = mlas_root.My.Resources.Resources.banner1;
		this.PictureBox8.Location = new System.Drawing.Point(55, -192);
		this.PictureBox8.Name = "PictureBox8";
		this.PictureBox8.Size = new System.Drawing.Size(338, 114);
		this.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox8.TabIndex = 20;
		this.PictureBox8.TabStop = false;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label1.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label1.Location = new System.Drawing.Point(0, 0);
		this.Label1.Name = "Label1";
		this.Label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
		this.Label1.Size = new System.Drawing.Size(816, 61);
		this.Label1.TabIndex = 2;
		this.Label1.Text = "유료제품 이용자에게 제공되는 데이터베이스 통합 관리 시스템(MLAS)입니다.\r\n항상 저희 제품을 이용 해 주셔서 감사합니다!";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Label2.Font = new System.Drawing.Font("굴림", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label2.ForeColor = System.Drawing.Color.DimGray;
		this.Label2.Location = new System.Drawing.Point(0, 429);
		this.Label2.Name = "Label2";
		this.Label2.Padding = new System.Windows.Forms.Padding(25, 10, 50, 0);
		this.Label2.Size = new System.Drawing.Size(816, 44);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "경고: 이 저작물은 저작권법과 국제 협약의 보호를 받습니다. 이 저작물의 전부 또는 일부를 무단으로 복제, 배포하는 행위는 민사 및 형사법에 의해 엄격히 규제되어 있으며, 기소 사유가 됩니다. 허가된 사용자 외에 다른 사용자가 이 저작물을 사용할 수 없습니다.";
		this.p9.Controls.Add(this.TextBox12);
		this.p9.Controls.Add(this.Panel95);
		this.p9.Controls.Add(this.Panel62);
		this.p9.Controls.Add(this.Panel64);
		this.p9.Controls.Add(this.Panel65);
		this.p9.Controls.Add(this.Panel66);
		this.p9.Location = new System.Drawing.Point(836, 31);
		this.p9.Name = "p9";
		this.p9.Size = new System.Drawing.Size(196, 39);
		this.p9.TabIndex = 9;
		this.TextBox12.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox12.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox12.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox12.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox12.Location = new System.Drawing.Point(23, 56);
		this.TextBox12.Multiline = true;
		this.TextBox12.Name = "TextBox12";
		this.TextBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.TextBox12.Size = new System.Drawing.Size(150, 0);
		this.TextBox12.TabIndex = 47;
		this.Panel95.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel95.Location = new System.Drawing.Point(23, -28);
		this.Panel95.Name = "Panel95";
		this.Panel95.Size = new System.Drawing.Size(150, 23);
		this.Panel95.TabIndex = 54;
		this.Panel62.Controls.Add(this.Panel63);
		this.Panel62.Controls.Add(this.Label40);
		this.Panel62.Controls.Add(this.Label41);
		this.Panel62.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel62.Location = new System.Drawing.Point(23, 0);
		this.Panel62.Name = "Panel62";
		this.Panel62.Size = new System.Drawing.Size(150, 56);
		this.Panel62.TabIndex = 45;
		this.Panel63.BackColor = System.Drawing.Color.Gray;
		this.Panel63.Location = new System.Drawing.Point(134, 41);
		this.Panel63.Name = "Panel63";
		this.Panel63.Size = new System.Drawing.Size(2000, 1);
		this.Panel63.TabIndex = 3;
		this.Label40.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label40.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label40.Location = new System.Drawing.Point(132, 15);
		this.Label40.Name = "Label40";
		this.Label40.Size = new System.Drawing.Size(595, 30);
		this.Label40.TabIndex = 2;
		this.Label40.Text = "제품 향상에 도움이 될 수 있도록 개발사에게 요청 사항을 부담없이 보내주십시오.";
		this.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label41.AutoSize = true;
		this.Label41.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label41.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label41.Location = new System.Drawing.Point(0, 15);
		this.Label41.Name = "Label41";
		this.Label41.Size = new System.Drawing.Size(131, 30);
		this.Label41.TabIndex = 1;
		this.Label41.Text = "제품 피드백";
		this.Panel64.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel64.Location = new System.Drawing.Point(0, 0);
		this.Panel64.Name = "Panel64";
		this.Panel64.Size = new System.Drawing.Size(23, 0);
		this.Panel64.TabIndex = 43;
		this.Panel65.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel65.Location = new System.Drawing.Point(173, 0);
		this.Panel65.Name = "Panel65";
		this.Panel65.Size = new System.Drawing.Size(23, 0);
		this.Panel65.TabIndex = 44;
		this.Panel66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel66.Controls.Add(this.Button72);
		this.Panel66.Controls.Add(this.Button52);
		this.Panel66.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel66.Location = new System.Drawing.Point(0, -5);
		this.Panel66.Name = "Panel66";
		this.Panel66.Size = new System.Drawing.Size(196, 44);
		this.Panel66.TabIndex = 46;
		this.Button72.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.Button72.BackgroundImage = mlas_root.My.Resources.Resources.public_button_close;
		this.Button72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button72.ForeColor = System.Drawing.Color.White;
		this.Button72.Location = new System.Drawing.Point(128, 8);
		this.Button72.Name = "Button72";
		this.Button72.Size = new System.Drawing.Size(100, 27);
		this.Button72.TabIndex = 8;
		this.Button72.Text = "닫기";
		this.Button72.UseVisualStyleBackColor = false;
		this.Button52.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button52.BackgroundImage = mlas_root.My.Resources.Resources.public_button;
		this.Button52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button52.ForeColor = System.Drawing.Color.White;
		this.Button52.Location = new System.Drawing.Point(22, 8);
		this.Button52.Name = "Button52";
		this.Button52.Size = new System.Drawing.Size(100, 27);
		this.Button52.TabIndex = 7;
		this.Button52.Text = "보내기";
		this.Button52.UseVisualStyleBackColor = false;
		this.Panel53.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.Panel53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel53.Controls.Add(this.txt_noticedetail);
		this.Panel53.Controls.Add(this.txt_notice);
		this.Panel53.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel53.Location = new System.Drawing.Point(217, 0);
		this.Panel53.Name = "Panel53";
		this.Panel53.Size = new System.Drawing.Size(859, 25);
		this.Panel53.TabIndex = 8;
		this.txt_noticedetail.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.txt_noticedetail.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txt_noticedetail.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.txt_noticedetail.Location = new System.Drawing.Point(0, 24);
		this.txt_noticedetail.Name = "txt_noticedetail";
		this.txt_noticedetail.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
		this.txt_noticedetail.Size = new System.Drawing.Size(857, 0);
		this.txt_noticedetail.TabIndex = 1;
		this.txt_notice.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
		this.txt_notice.Cursor = System.Windows.Forms.Cursors.Hand;
		this.txt_notice.Dock = System.Windows.Forms.DockStyle.Top;
		this.txt_notice.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.txt_notice.Location = new System.Drawing.Point(0, 0);
		this.txt_notice.Name = "txt_notice";
		this.txt_notice.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
		this.txt_notice.Size = new System.Drawing.Size(857, 24);
		this.txt_notice.TabIndex = 0;
		this.txt_notice.Text = "공지사항 표시구간";
		this.txt_notice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.Panel2.Controls.Add(this.Panel85);
		this.Panel2.Controls.Add(this.p1);
		this.Panel2.Controls.Add(this.server_url_modify);
		this.Panel2.Controls.Add(this.p9);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel2.Location = new System.Drawing.Point(217, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
		this.Panel2.Size = new System.Drawing.Size(859, 670);
		this.Panel2.TabIndex = 3;
		this.Panel85.Controls.Add(this.SplitContainer1);
		this.Panel85.Controls.Add(this.Panel93);
		this.Panel85.Controls.Add(this.Panel86);
		this.Panel85.Controls.Add(this.Panel88);
		this.Panel85.Controls.Add(this.Panel89);
		this.Panel85.Controls.Add(this.Panel92);
		this.Panel85.Controls.Add(this.Panel91);
		this.Panel85.Controls.Add(this.Panel90);
		this.Panel85.Location = new System.Drawing.Point(18, 566);
		this.Panel85.Name = "Panel85";
		this.Panel85.Size = new System.Drawing.Size(812, 56);
		this.Panel85.TabIndex = 12;
		this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer1.Location = new System.Drawing.Point(23, 56);
		this.SplitContainer1.Name = "SplitContainer1";
		this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
		this.SplitContainer1.Panel1.Controls.Add(this.ListView4);
		this.SplitContainer1.Panel2.Controls.Add(this.TextBox19);
		this.SplitContainer1.Size = new System.Drawing.Size(766, 0);
		this.SplitContainer1.SplitterDistance = 25;
		this.SplitContainer1.TabIndex = 0;
		this.ListView4.BackColor = System.Drawing.Color.WhiteSmoke;
		this.ListView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.ListView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[5] { this.ColumnHeader29, this.ColumnHeader32, this.ColumnHeader28, this.ColumnHeader30, this.ColumnHeader27 });
		this.ListView4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView4.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListView4.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ListView4.FullRowSelect = true;
		this.ListView4.HideSelection = false;
		this.ListView4.Location = new System.Drawing.Point(0, 0);
		this.ListView4.MultiSelect = false;
		this.ListView4.Name = "ListView4";
		this.ListView4.Size = new System.Drawing.Size(766, 25);
		this.ListView4.TabIndex = 47;
		this.ListView4.UseCompatibleStateImageBehavior = false;
		this.ListView4.View = System.Windows.Forms.View.Details;
		this.ColumnHeader29.Text = "";
		this.ColumnHeader29.Width = 30;
		this.ColumnHeader32.Text = "제목";
		this.ColumnHeader32.Width = 455;
		this.ColumnHeader28.Text = "게시자";
		this.ColumnHeader28.Width = 120;
		this.ColumnHeader30.Text = "게시일";
		this.ColumnHeader30.Width = 140;
		this.ColumnHeader27.Text = "첨부";
		this.ColumnHeader27.Width = 45;
		this.TextBox19.BackColor = System.Drawing.Color.White;
		this.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox19.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TextBox19.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TextBox19.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox19.Location = new System.Drawing.Point(0, 0);
		this.TextBox19.Multiline = true;
		this.TextBox19.Name = "TextBox19";
		this.TextBox19.ReadOnly = true;
		this.TextBox19.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		this.TextBox19.Size = new System.Drawing.Size(766, 25);
		this.TextBox19.TabIndex = 49;
		this.Panel93.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel93.Location = new System.Drawing.Point(23, -87);
		this.Panel93.Name = "Panel93";
		this.Panel93.Size = new System.Drawing.Size(766, 23);
		this.Panel93.TabIndex = 53;
		this.Panel86.Controls.Add(this.Label67);
		this.Panel86.Controls.Add(this.Button71);
		this.Panel86.Controls.Add(this.Panel87);
		this.Panel86.Controls.Add(this.Label66);
		this.Panel86.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel86.Location = new System.Drawing.Point(23, 0);
		this.Panel86.Name = "Panel86";
		this.Panel86.Size = new System.Drawing.Size(766, 56);
		this.Panel86.TabIndex = 45;
		this.Label67.AutoSize = true;
		this.Label67.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label67.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label67.Location = new System.Drawing.Point(0, 15);
		this.Label67.Name = "Label67";
		this.Label67.Size = new System.Drawing.Size(109, 30);
		this.Label67.TabIndex = 1;
		this.Label67.Text = "고객 지원";
		this.Button71.BackColor = System.Drawing.Color.Green;
		this.Button71.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button71.BackgroundImage");
		this.Button71.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button71.Dock = System.Windows.Forms.DockStyle.Right;
		this.Button71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button71.ForeColor = System.Drawing.Color.White;
		this.Button71.Location = new System.Drawing.Point(655, 0);
		this.Button71.Name = "Button71";
		this.Button71.Size = new System.Drawing.Size(111, 56);
		this.Button71.TabIndex = 9;
		this.Button71.Text = "메시지 보내기";
		this.Button71.UseVisualStyleBackColor = false;
		this.Button71.Visible = false;
		this.Panel87.BackColor = System.Drawing.Color.Gray;
		this.Panel87.Location = new System.Drawing.Point(111, 41);
		this.Panel87.Name = "Panel87";
		this.Panel87.Size = new System.Drawing.Size(2000, 1);
		this.Panel87.TabIndex = 3;
		this.Label66.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label66.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label66.Location = new System.Drawing.Point(109, 15);
		this.Label66.Name = "Label66";
		this.Label66.Size = new System.Drawing.Size(901, 30);
		this.Label66.TabIndex = 2;
		this.Label66.Text = "중요사항 및 파일 다운로드 등 여기에서 종합적인 사후 지원을 받을 수 있습니다.";
		this.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel88.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel88.Location = new System.Drawing.Point(0, 0);
		this.Panel88.Name = "Panel88";
		this.Panel88.Size = new System.Drawing.Size(23, 0);
		this.Panel88.TabIndex = 43;
		this.Panel89.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel89.Location = new System.Drawing.Point(789, 0);
		this.Panel89.Name = "Panel89";
		this.Panel89.Size = new System.Drawing.Size(23, 0);
		this.Panel89.TabIndex = 44;
		this.Panel92.BackColor = System.Drawing.Color.DarkSlateGray;
		this.Panel92.Controls.Add(this.Label70);
		this.Panel92.Controls.Add(this.Panel94);
		this.Panel92.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel92.Location = new System.Drawing.Point(0, -64);
		this.Panel92.Name = "Panel92";
		this.Panel92.Size = new System.Drawing.Size(812, 38);
		this.Panel92.TabIndex = 52;
		this.Panel92.Visible = false;
		this.Label70.BackColor = System.Drawing.Color.DarkSlateGray;
		this.Label70.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label70.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label70.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.Label70.Location = new System.Drawing.Point(0, 0);
		this.Label70.Name = "Label70";
		this.Label70.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
		this.Label70.Size = new System.Drawing.Size(546, 38);
		this.Label70.TabIndex = 7;
		this.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel94.Controls.Add(this.Button70);
		this.Panel94.Controls.Add(this.Button68);
		this.Panel94.Controls.Add(this.Button69);
		this.Panel94.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel94.Location = new System.Drawing.Point(546, 0);
		this.Panel94.Name = "Panel94";
		this.Panel94.Size = new System.Drawing.Size(266, 38);
		this.Panel94.TabIndex = 10;
		this.Button70.BackColor = System.Drawing.Color.White;
		this.Button70.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button70.BackgroundImage");
		this.Button70.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button70.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button70.ForeColor = System.Drawing.Color.Black;
		this.Button70.Location = new System.Drawing.Point(101, 5);
		this.Button70.Name = "Button70";
		this.Button70.Size = new System.Drawing.Size(77, 27);
		this.Button70.TabIndex = 10;
		this.Button70.Text = "폴더 열기";
		this.Button70.UseVisualStyleBackColor = false;
		this.Button68.BackColor = System.Drawing.Color.White;
		this.Button68.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button68.BackgroundImage");
		this.Button68.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button68.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button68.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button68.ForeColor = System.Drawing.Color.Black;
		this.Button68.Location = new System.Drawing.Point(18, 5);
		this.Button68.Name = "Button68";
		this.Button68.Size = new System.Drawing.Size(77, 27);
		this.Button68.TabIndex = 8;
		this.Button68.Text = "파일 열기";
		this.Button68.UseVisualStyleBackColor = false;
		this.Button69.BackColor = System.Drawing.Color.White;
		this.Button69.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button69.BackgroundImage");
		this.Button69.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button69.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button69.Font = new System.Drawing.Font("맑은 고딕", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Button69.ForeColor = System.Drawing.Color.Black;
		this.Button69.Location = new System.Drawing.Point(184, 5);
		this.Button69.Name = "Button69";
		this.Button69.Size = new System.Drawing.Size(60, 27);
		this.Button69.TabIndex = 9;
		this.Button69.Text = "닫기";
		this.Button69.UseVisualStyleBackColor = false;
		this.Panel91.BackColor = System.Drawing.Color.DarkSlateGray;
		this.Panel91.Controls.Add(this.ProgressBar6);
		this.Panel91.Controls.Add(this.Label69);
		this.Panel91.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel91.Location = new System.Drawing.Point(0, -26);
		this.Panel91.Name = "Panel91";
		this.Panel91.Size = new System.Drawing.Size(812, 38);
		this.Panel91.TabIndex = 51;
		this.Panel91.Visible = false;
		this.ProgressBar6.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
		this.ProgressBar6.ForeColor = System.Drawing.Color.Red;
		this.ProgressBar6.Location = new System.Drawing.Point(19, 10);
		this.ProgressBar6.Name = "ProgressBar6";
		this.ProgressBar6.Size = new System.Drawing.Size(519, 19);
		this.ProgressBar6.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
		this.ProgressBar6.TabIndex = 6;
		this.ProgressBar6.Value = 50;
		this.Label69.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label69.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.Label69.Location = new System.Drawing.Point(544, 11);
		this.Label69.Name = "Label69";
		this.Label69.Size = new System.Drawing.Size(258, 17);
		this.Label69.TabIndex = 7;
		this.Label69.Text = "\r\n";
		this.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel90.Controls.Add(this.Label71);
		this.Panel90.Controls.Add(this.Button67);
		this.Panel90.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel90.Location = new System.Drawing.Point(0, 12);
		this.Panel90.Name = "Panel90";
		this.Panel90.Size = new System.Drawing.Size(812, 44);
		this.Panel90.TabIndex = 46;
		this.Panel90.Visible = false;
		this.Label71.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label71.ForeColor = System.Drawing.Color.Black;
		this.Label71.Location = new System.Drawing.Point(170, 13);
		this.Label71.Name = "Label71";
		this.Label71.Size = new System.Drawing.Size(663, 17);
		this.Label71.TabIndex = 8;
		this.Label71.Text = "\r\n파일";
		this.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button67.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button67.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.Button67.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button67.ForeColor = System.Drawing.Color.White;
		this.Button67.Location = new System.Drawing.Point(22, 8);
		this.Button67.Name = "Button67";
		this.Button67.Size = new System.Drawing.Size(139, 27);
		this.Button67.TabIndex = 7;
		this.Button67.Text = "첨부파일 다운로드";
		this.Button67.UseVisualStyleBackColor = false;
		this.server_url_modify.Controls.Add(this.Label94);
		this.server_url_modify.Controls.Add(this.mod_p1);
		this.server_url_modify.Location = new System.Drawing.Point(18, 510);
		this.server_url_modify.Name = "server_url_modify";
		this.server_url_modify.Size = new System.Drawing.Size(389, 50);
		this.server_url_modify.TabIndex = 20;
		this.Label94.BackColor = System.Drawing.Color.White;
		this.Label94.Dock = System.Windows.Forms.DockStyle.Top;
		this.Label94.Location = new System.Drawing.Point(0, 0);
		this.Label94.Name = "Label94";
		this.Label94.Size = new System.Drawing.Size(389, 12);
		this.Label94.TabIndex = 0;
		this.Label94.Text = "server_url_modify";
		this.Label94.Visible = false;
		this.mod_p1.Controls.Add(this.Panel111);
		this.mod_p1.Controls.Add(this.Panel110);
		this.mod_p1.Controls.Add(this.Panel104);
		this.mod_p1.Controls.Add(this.Panel106);
		this.mod_p1.Controls.Add(this.Panel107);
		this.mod_p1.Controls.Add(this.Panel108);
		this.mod_p1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mod_p1.Location = new System.Drawing.Point(0, 0);
		this.mod_p1.Name = "mod_p1";
		this.mod_p1.Size = new System.Drawing.Size(389, 50);
		this.mod_p1.TabIndex = 14;
		this.mod_p1.Visible = false;
		this.Panel111.Controls.Add(this.Label81);
		this.Panel111.Controls.Add(this.Label80);
		this.Panel111.Controls.Add(this.Button76);
		this.Panel111.Controls.Add(this.ComboBox17);
		this.Panel111.Controls.Add(this.TextBox21);
		this.Panel111.Controls.Add(this.Label82);
		this.Panel111.Controls.Add(this.TextBox20);
		this.Panel111.Controls.Add(this.Label83);
		this.Panel111.Location = new System.Drawing.Point(50, 84);
		this.Panel111.Name = "Panel111";
		this.Panel111.Size = new System.Drawing.Size(608, 207);
		this.Panel111.TabIndex = 51;
		this.Label81.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label81.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label81.Location = new System.Drawing.Point(2, 8);
		this.Label81.Name = "Label81";
		this.Label81.Size = new System.Drawing.Size(161, 21);
		this.Label81.TabIndex = 1;
		this.Label81.Text = "프로젝트 선택";
		this.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Label80.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label80.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label80.Location = new System.Drawing.Point(-9, 53);
		this.Label80.Name = "Label80";
		this.Label80.Size = new System.Drawing.Size(172, 21);
		this.Label80.TabIndex = 2;
		this.Label80.Text = "데이터베이스 계정";
		this.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button76.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button76.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button76.BackgroundImage");
		this.Button76.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button76.ForeColor = System.Drawing.Color.White;
		this.Button76.Location = new System.Drawing.Point(172, 168);
		this.Button76.Name = "Button76";
		this.Button76.Size = new System.Drawing.Size(133, 27);
		this.Button76.TabIndex = 49;
		this.Button76.Text = "인증";
		this.Button76.UseVisualStyleBackColor = false;
		this.ComboBox17.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
		this.ComboBox17.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ComboBox17.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
		this.ComboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.ComboBox17.Font = new System.Drawing.Font("맑은 고딕", 12f);
		this.ComboBox17.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.ComboBox17.FormattingEnabled = true;
		this.ComboBox17.Location = new System.Drawing.Point(172, 4);
		this.ComboBox17.Name = "ComboBox17";
		this.ComboBox17.Size = new System.Drawing.Size(400, 30);
		this.ComboBox17.TabIndex = 5;
		this.TextBox21.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox21.Cursor = System.Windows.Forms.Cursors.Hand;
		this.TextBox21.Font = new System.Drawing.Font("맑은 고딕", 12f);
		this.TextBox21.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox21.Location = new System.Drawing.Point(172, 95);
		this.TextBox21.Name = "TextBox21";
		this.TextBox21.Size = new System.Drawing.Size(400, 29);
		this.TextBox21.TabIndex = 46;
		this.TextBox21.UseSystemPasswordChar = true;
		this.Label82.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label82.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label82.Location = new System.Drawing.Point(-2, 98);
		this.Label82.Name = "Label82";
		this.Label82.Size = new System.Drawing.Size(165, 21);
		this.Label82.TabIndex = 43;
		this.Label82.Text = "관리자 비밀번호";
		this.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.TextBox20.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox20.Cursor = System.Windows.Forms.Cursors.Hand;
		this.TextBox20.Font = new System.Drawing.Font("맑은 고딕", 12f);
		this.TextBox20.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox20.Location = new System.Drawing.Point(172, 49);
		this.TextBox20.Name = "TextBox20";
		this.TextBox20.Size = new System.Drawing.Size(400, 29);
		this.TextBox20.TabIndex = 45;
		this.Label83.Font = new System.Drawing.Font("맑은 고딕", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label83.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
		this.Label83.Location = new System.Drawing.Point(168, 132);
		this.Label83.Name = "Label83";
		this.Label83.Size = new System.Drawing.Size(404, 22);
		this.Label83.TabIndex = 44;
		this.Label83.Text = "데이터베이스 비밀번호가 아닌 관리자 비밀번호를 입력해야 함.";
		this.Panel110.Controls.Add(this.TextBox24);
		this.Panel110.Controls.Add(this.Button75);
		this.Panel110.Controls.Add(this.Label87);
		this.Panel110.Location = new System.Drawing.Point(67, 278);
		this.Panel110.Name = "Panel110";
		this.Panel110.Size = new System.Drawing.Size(598, 156);
		this.Panel110.TabIndex = 50;
		this.Panel110.Visible = false;
		this.TextBox24.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
		this.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TextBox24.Cursor = System.Windows.Forms.Cursors.Hand;
		this.TextBox24.Font = new System.Drawing.Font("맑은 고딕", 12f);
		this.TextBox24.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.TextBox24.Location = new System.Drawing.Point(154, 23);
		this.TextBox24.Name = "TextBox24";
		this.TextBox24.Size = new System.Drawing.Size(400, 29);
		this.TextBox24.TabIndex = 48;
		this.Button75.BackColor = System.Drawing.Color.SaddleBrown;
		this.Button75.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button75.BackgroundImage");
		this.Button75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Button75.ForeColor = System.Drawing.Color.White;
		this.Button75.Location = new System.Drawing.Point(154, 68);
		this.Button75.Name = "Button75";
		this.Button75.Size = new System.Drawing.Size(133, 27);
		this.Button75.TabIndex = 7;
		this.Button75.Text = "변경";
		this.Button75.UseVisualStyleBackColor = false;
		this.Label87.Font = new System.Drawing.Font("맑은 고딕", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
		this.Label87.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label87.Location = new System.Drawing.Point(-20, 26);
		this.Label87.Name = "Label87";
		this.Label87.Size = new System.Drawing.Size(165, 21);
		this.Label87.TabIndex = 47;
		this.Label87.Text = "서버 주소";
		this.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Panel104.Controls.Add(this.Panel105);
		this.Panel104.Controls.Add(this.Label78);
		this.Panel104.Controls.Add(this.Label79);
		this.Panel104.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel104.Location = new System.Drawing.Point(23, 0);
		this.Panel104.Name = "Panel104";
		this.Panel104.Size = new System.Drawing.Size(343, 56);
		this.Panel104.TabIndex = 41;
		this.Panel105.BackColor = System.Drawing.Color.Gray;
		this.Panel105.Location = new System.Drawing.Point(113, 41);
		this.Panel105.Name = "Panel105";
		this.Panel105.Size = new System.Drawing.Size(2000, 1);
		this.Panel105.TabIndex = 3;
		this.Label78.Font = new System.Drawing.Font("맑은 고딕", 10f, System.Drawing.FontStyle.Bold);
		this.Label78.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Label78.Location = new System.Drawing.Point(111, 15);
		this.Label78.Name = "Label78";
		this.Label78.Size = new System.Drawing.Size(595, 30);
		this.Label78.TabIndex = 2;
		this.Label78.Text = "서버 도메인을 변경 시켜줍니다.";
		this.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label79.AutoSize = true;
		this.Label79.Font = new System.Drawing.Font("맑은 고딕", 16f, System.Drawing.FontStyle.Bold);
		this.Label79.ForeColor = System.Drawing.Color.ForestGreen;
		this.Label79.Location = new System.Drawing.Point(0, 15);
		this.Label79.Name = "Label79";
		this.Label79.Size = new System.Drawing.Size(109, 30);
		this.Label79.TabIndex = 1;
		this.Label79.Text = "주소 변경";
		this.Panel106.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel106.Location = new System.Drawing.Point(0, 0);
		this.Panel106.Name = "Panel106";
		this.Panel106.Size = new System.Drawing.Size(23, 6);
		this.Panel106.TabIndex = 39;
		this.Panel107.Dock = System.Windows.Forms.DockStyle.Right;
		this.Panel107.Location = new System.Drawing.Point(366, 0);
		this.Panel107.Name = "Panel107";
		this.Panel107.Size = new System.Drawing.Size(23, 6);
		this.Panel107.TabIndex = 40;
		this.Panel108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Panel108.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel108.Location = new System.Drawing.Point(0, 6);
		this.Panel108.Name = "Panel108";
		this.Panel108.Size = new System.Drawing.Size(389, 44);
		this.Panel108.TabIndex = 42;
		this.WebClient1.BaseAddress = "";
		this.WebClient1.CachePolicy = null;
		this.WebClient1.Credentials = null;
		this.WebClient1.Encoding = (System.Text.Encoding)resources.GetObject("WebClient1.Encoding");
		this.WebClient1.Headers = (System.Net.WebHeaderCollection)resources.GetObject("WebClient1.Headers");
		this.WebClient1.QueryString = (System.Collections.Specialized.NameValueCollection)resources.GetObject("WebClient1.QueryString");
		this.WebClient1.UseDefaultCredentials = false;
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
		this.Panel1.Controls.Add(this.ListBox1);
		this.Panel1.Controls.Add(this.Panel50);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(217, 670);
		this.Panel1.TabIndex = 0;
		this.ListBox1.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
		this.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListBox1.Cursor = System.Windows.Forms.Cursors.Default;
		this.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ListBox1.Font = new System.Drawing.Font("굴림", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ListBox1.ForeColor = System.Drawing.Color.White;
		this.ListBox1.FormattingEnabled = true;
		this.ListBox1.ItemHeight = 28;
		this.ListBox1.Location = new System.Drawing.Point(12, 25);
		this.ListBox1.Name = "ListBox1";
		this.ListBox1.Size = new System.Drawing.Size(275, 560);
		this.ListBox1.TabIndex = 0;
		this.Panel50.BackColor = System.Drawing.Color.Transparent;
		this.Panel50.Controls.Add(this.PictureBox4);
		this.Panel50.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel50.Location = new System.Drawing.Point(0, 622);
		this.Panel50.Name = "Panel50";
		this.Panel50.Size = new System.Drawing.Size(217, 48);
		this.Panel50.TabIndex = 3;
		this.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
		this.PictureBox4.Image = mlas_root.My.Resources.Resources.logo3;
		this.PictureBox4.Location = new System.Drawing.Point(0, 0);
		this.PictureBox4.Name = "PictureBox4";
		this.PictureBox4.Size = new System.Drawing.Size(217, 48);
		this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.PictureBox4.TabIndex = 2;
		this.PictureBox4.TabStop = false;
		this.ToolTip1.SetToolTip(this.PictureBox4, "사이트 연결");
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.Panel3.Controls.Add(this.Panel53);
		this.Panel3.Controls.Add(this.Panel2);
		this.Panel3.Controls.Add(this.Panel1);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(2, 28);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(1076, 670);
		this.Panel3.TabIndex = 17;
		this.ToolTip1.BackColor = System.Drawing.Color.White;
		this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox3.Image = mlas_root.My.Resources.Resources.close1;
		this.PictureBox3.Location = new System.Drawing.Point(252, 5);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(19, 18);
		this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox3.TabIndex = 0;
		this.PictureBox3.TabStop = false;
		this.ToolTip1.SetToolTip(this.PictureBox3, "종료");
		this.PictureBox6.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox6.Image = mlas_root.My.Resources.Resources.max1;
		this.PictureBox6.Location = new System.Drawing.Point(227, 5);
		this.PictureBox6.Name = "PictureBox6";
		this.PictureBox6.Size = new System.Drawing.Size(19, 18);
		this.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox6.TabIndex = 2;
		this.PictureBox6.TabStop = false;
		this.ToolTip1.SetToolTip(this.PictureBox6, "창모드/전체화면 모드");
		this.PictureBox5.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox5.Image = mlas_root.My.Resources.Resources.mini1;
		this.PictureBox5.Location = new System.Drawing.Point(202, 5);
		this.PictureBox5.Name = "PictureBox5";
		this.PictureBox5.Size = new System.Drawing.Size(19, 18);
		this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox5.TabIndex = 1;
		this.PictureBox5.TabStop = false;
		this.ToolTip1.SetToolTip(this.PictureBox5, "최소화");
		this.Timer2.Interval = 10;
		this.Timer3.Interval = 1;
		this.chat_receiver.Interval = 1000;
		this.ssorder_update_checker.Interval = 60000;
		this.Panel4.BackgroundImage = mlas_root.My.Resources.Resources.topbar;
		this.Panel4.Controls.Add(this.Label4);
		this.Panel4.Controls.Add(this.FlowLayoutPanel1);
		this.Panel4.Controls.Add(this.Panel8);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(2, 0);
		this.Panel4.Name = "Panel4";
		this.Panel4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.Panel4.Size = new System.Drawing.Size(1076, 28);
		this.Panel4.TabIndex = 18;
		this.Label4.BackColor = System.Drawing.Color.Transparent;
		this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Label4.ForeColor = System.Drawing.Color.Yellow;
		this.Label4.Location = new System.Drawing.Point(258, 0);
		this.Label4.Name = "Label4";
		this.Label4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
		this.Label4.Size = new System.Drawing.Size(540, 28);
		this.Label4.TabIndex = 9;
		this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
		this.FlowLayoutPanel1.Controls.Add(this.PictureBox3);
		this.FlowLayoutPanel1.Controls.Add(this.PictureBox6);
		this.FlowLayoutPanel1.Controls.Add(this.PictureBox5);
		this.FlowLayoutPanel1.Controls.Add(this.Panel5);
		this.FlowLayoutPanel1.Controls.Add(this.newmessage);
		this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
		this.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
		this.FlowLayoutPanel1.Location = new System.Drawing.Point(798, 0);
		this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
		this.FlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
		this.FlowLayoutPanel1.Size = new System.Drawing.Size(278, 28);
		this.FlowLayoutPanel1.TabIndex = 5;
		this.Panel5.BackColor = System.Drawing.Color.Transparent;
		this.Panel5.BackgroundImage = mlas_root.My.Resources.Resources.chaticon_small;
		this.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.Panel5.Controls.Add(this.Label5);
		this.Panel5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Panel5.Location = new System.Drawing.Point(169, 2);
		this.Panel5.Margin = new System.Windows.Forms.Padding(0);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(30, 31);
		this.Panel5.TabIndex = 7;
		this.Label5.BackColor = System.Drawing.Color.Transparent;
		this.Label5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Label5.Font = new System.Drawing.Font("굴림", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.Label5.ForeColor = System.Drawing.Color.White;
		this.Label5.Location = new System.Drawing.Point(0, 7);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(30, 11);
		this.Label5.TabIndex = 0;
		this.Label5.Text = "99";
		this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.newmessage.BackColor = System.Drawing.Color.Transparent;
		this.newmessage.BackgroundImage = mlas_root.My.Resources.Resources.newmessage;
		this.newmessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.newmessage.Cursor = System.Windows.Forms.Cursors.Hand;
		this.newmessage.Location = new System.Drawing.Point(3, 2);
		this.newmessage.Margin = new System.Windows.Forms.Padding(0);
		this.newmessage.Name = "newmessage";
		this.newmessage.Size = new System.Drawing.Size(166, 31);
		this.newmessage.TabIndex = 8;
		this.newmessage.Visible = false;
		this.Panel8.BackColor = System.Drawing.Color.Transparent;
		this.Panel8.Controls.Add(this.PictureBox1);
		this.Panel8.Dock = System.Windows.Forms.DockStyle.Left;
		this.Panel8.Location = new System.Drawing.Point(5, 0);
		this.Panel8.Name = "Panel8";
		this.Panel8.Size = new System.Drawing.Size(253, 28);
		this.Panel8.TabIndex = 8;
		this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
		this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox1.Image = mlas_root.My.Resources.Resources.logo2;
		this.PictureBox1.Location = new System.Drawing.Point(27, 5);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(0);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(123, 19);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 1;
		this.PictureBox1.TabStop = false;
		this.AllowDrop = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		base.ClientSize = new System.Drawing.Size(1080, 700);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Panel4);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		this.MinimumSize = new System.Drawing.Size(1080, 700);
		base.Name = "mlas";
		base.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "MLAS";
		this.p1.ResumeLayout(false);
		this.Panel51.ResumeLayout(false);
		this.FlowLayoutPanel2.ResumeLayout(false);
		this.Panel9.ResumeLayout(false);
		this.Panel9.PerformLayout();
		this.Panel10.ResumeLayout(false);
		this.Panel10.PerformLayout();
		this.chartPanel.ResumeLayout(false);
		this.chartPanel.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.chartGraph).EndInit();
		this.Panel6.ResumeLayout(false);
		this.Panel6.PerformLayout();
		this.Panel7.ResumeLayout(false);
		this.Panel7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox11).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox7).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox8).EndInit();
		this.p9.ResumeLayout(false);
		this.p9.PerformLayout();
		this.Panel62.ResumeLayout(false);
		this.Panel62.PerformLayout();
		this.Panel66.ResumeLayout(false);
		this.Panel53.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel85.ResumeLayout(false);
		this.SplitContainer1.Panel1.ResumeLayout(false);
		this.SplitContainer1.Panel2.ResumeLayout(false);
		this.SplitContainer1.Panel2.PerformLayout();
		this.SplitContainer1.ResumeLayout(false);
		this.Panel86.ResumeLayout(false);
		this.Panel86.PerformLayout();
		this.Panel92.ResumeLayout(false);
		this.Panel94.ResumeLayout(false);
		this.Panel91.ResumeLayout(false);
		this.Panel90.ResumeLayout(false);
		this.server_url_modify.ResumeLayout(false);
		this.mod_p1.ResumeLayout(false);
		this.Panel111.ResumeLayout(false);
		this.Panel111.PerformLayout();
		this.Panel110.ResumeLayout(false);
		this.Panel110.PerformLayout();
		this.Panel104.ResumeLayout(false);
		this.Panel104.PerformLayout();
		this.Panel1.ResumeLayout(false);
		this.Panel50.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).EndInit();
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox5).EndInit();
		this.Panel4.ResumeLayout(false);
		this.FlowLayoutPanel1.ResumeLayout(false);
		this.FlowLayoutPanel1.PerformLayout();
		this.Panel5.ResumeLayout(false);
		this.Panel8.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	private void sjka_Load(object sender, EventArgs e)
	{
		try
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\update\\_update.exe"))
			{
				MyProject.Computer.FileSystem.MoveFile(Application.StartupPath + "\\update\\_update.exe", Application.StartupPath + "\\update.exe", overwrite: true);
				MyProject.Computer.FileSystem.DeleteDirectory(Application.StartupPath + "\\update", DeleteDirectoryOption.DeleteAllContents);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		MaximumSize = Screen.FromRectangle(base.Bounds).WorkingArea.Size;
		Text = Text + " " + $"{(double)Module1.version / 100.0:0.00}" + " - " + Module1.project;
		if (Operators.CompareString(Module1.forceProject, null, TextCompare: false) == 0)
		{
			Label4.Text = Module1.project + " (접속일시: " + Module1._useTime + ")";
		}
		FixedFormSize = base.Size;
		DoubleBuffered = true;
		Control.CheckForIllegalCrossThreadCalls = false;
		lb2.Text = "위치 : " + Module1._dburl;
		Label9.Text = "버전 " + $"{(double)Module1.version / 100.0:0.00}";
		object[] array = new object[0];
		checked
		{
			switch (Module1.project)
			{
			case "home_db_microlivire":
				array = new object[14]
				{
					"메인", "", "고객 관리", "프로젝트 관리", "고객센터 관리", "공지사항 관리", "", "FTP 편집기", "접속 로그", "",
					"데이터 새로고침", "", "로그아웃", "종료"
				};
				MyProject.Forms.home_db_microlivire.Reset();
				break;
			case "android_db_sjka_application_noteapp":
				array = new object[16]
				{
					"메인", "", "공지사항 관리", "데이터 관리", "데이터 추가", "", "폴더 관리", "학명집 관리", "", "컬럼 관리",
					"뷰 관리", "검색 관리", "", "고객 지원", "로그아웃", "종료"
				};
				MyProject.Forms.android_db_sjka_application_noteapp.SetList();
				break;
			case "android_db_sjka_cyber":
			{
				int num5 = 30;
				int num6 = 50;
				base.Size = new Size(base.Size.Width + num5, base.Size.Height + num6);
				base.Location = new Point((int)Math.Round((double)base.Location.X - (double)num5 / 2.0), (int)Math.Round((double)base.Location.Y - (double)num6 / 2.0));
				FixedFormSize = base.Size;
				MinimumSize = FixedFormSize;
				ListBox1.Size = new Size(ListBox1.Size.Width, ListBox1.Size.Height + num6);
				ListBox1.Invalidate();
				array = new object[22]
				{
					"메인", "", "회원 관리", "배너 관리", "피드백 관리", "공지사항 관리", "사용설명서 관리", "", "강좌 연결", "강의폴더 관리",
					"기출문제 관리", "", "키워드 폴더 관리", "키워드 관리", "", "핵심요약집 폴더 관리", "핵심요약집 관리", "핵심요약 문서관리", "", "고객 지원",
					"로그아웃", "종료"
				};
				break;
			}
			case "android_db_kjh_smart_screen":
				array = new object[14]
				{
					"메인", "", "데이터 관리", "데이터 추가", "학명집 관리", "폴더 관리", "컬럼 관리", "뷰 관리", "검색 관리", "데이터 새로고침",
					"", "고객 지원", "로그아웃", "종료"
				};
				MyProject.Forms.android_db_sjka_application_noteapp.SetList();
				break;
			case "windows_db_human_chart":
				array = new object[9] { "메인", "", "검사 결과 데이터", "질문 관리", "데이터 새로고침", "", "고객 지원", "로그아웃", "종료" };
				MyProject.Forms.windows_db_human_chart.SurveyList();
				break;
			case "server_url_modify":
				array = new object[6] { "메인", "", "주소 변경", "", "로그아웃", "종료" };
				break;
			case "android_db_ss_order":
			{
				int num3 = 130;
				int num4 = 30;
				base.Size = new Size(base.Size.Width + num3, base.Size.Height + num4);
				FixedFormSize = base.Size;
				MinimumSize = FixedFormSize;
				ListBox1.Size = new Size(ListBox1.Size.Width, ListBox1.Size.Height + num4);
				ListBox1.Invalidate();
				PictureBox4.Image = Resources.logo1;
				Module1.click_url = "http://reception.ivyro.net/";
				Text = "성신 판매접수 관리자 (base to MLAS v" + $"{(double)Module1.version / 100.0:0.00}" + ")";
				switch (ssorder.ssorder_acgb)
				{
				case 1:
					array = new object[6] { "메인", "주문 관리", "고객 관리", "제품 관리", "", "주문 접수" };
					break;
				case 2:
					array = new object[3] { "메인", "주문 접수", "조회" };
					MyProject.Forms.android_db_ss_order.order_lb2.Hide();
					break;
				case 3:
					array = new object[6] { "메인", "주문 관리", "고객 관리", "제품 관리", "", "주문 접수" };
					break;
				case 4:
					array = new object[2] { "메인", "제품 관리" };
					MyProject.Forms.android_db_ss_order.Button22.Hide();
					MyProject.Forms.android_db_ss_order.Button23.Hide();
					MyProject.Forms.android_db_ss_order.Button13.Hide();
					MyProject.Forms.android_db_ss_order.Button14.Hide();
					MyProject.Forms.android_db_ss_order.Button17.Hide();
					break;
				case 5:
					array = new object[9] { "메인", "주문 관리", "고객 관리", "제품 관리", "사용자 관리", "", "상담사 DB 관리자 열기", "", "주문 접수" };
					break;
				}
				if (ssorder.ssorder_acgb < 3)
				{
					array = (object[])Utils.CopyArray(array, new object[array.Length + 4 + 1]);
					array[array.Length - 5] = "";
					array[array.Length - 4] = "상담사 프로그램 열기";
				}
				else
				{
					array = (object[])Utils.CopyArray(array, new object[array.Length + 2 + 1]);
				}
				array[array.Length - 3] = "";
				array[array.Length - 2] = "로그아웃";
				array[array.Length - 1] = "종료";
				break;
			}
			case "android_mba_check":
			{
				int num2 = 30;
				base.Size = new Size(base.Size.Width, base.Size.Height + num2);
				FixedFormSize = base.Size;
				MinimumSize = FixedFormSize;
				ListBox1.Size = new Size(ListBox1.Size.Width, ListBox1.Size.Height + num2);
				ListBox1.Invalidate();
				string id = Module1._id;
				array = ((Operators.CompareString(id, "admin_microlivire", TextCompare: false) != 0) ? new object[9] { "메인", "", "회원 관리", "배너 관리", "공지사항 관리", "", "고객 지원", "로그아웃", "종료" } : new object[11]
				{
					"메인", "", "회원 관리", "배너 관리(MOM출첵)", "배너 관리(학원출첵)", "공지사항 관리", "사용 설명서", "", "고객 지원", "로그아웃",
					"종료"
				});
				break;
			}
			case "android_mom_hakwon":
			{
				int num = 30;
				base.Size = new Size(base.Size.Width, base.Size.Height + num);
				FixedFormSize = base.Size;
				MinimumSize = FixedFormSize;
				ListBox1.Size = new Size(ListBox1.Size.Width, ListBox1.Size.Height + num);
				ListBox1.Invalidate();
				array = new object[9] { "메인", "", "회원 관리", "배너 관리", "공지사항 관리", "", "고객 지원", "로그아웃", "종료" };
				break;
			}
			}
			try
			{
				string text = new GetHtmlClass(Module1._dburl + "/admin.php?type=getCountV2", "pw=" + MySettingsProperty.Settings.pw, progress: true).getHTML(MyProject.Forms.login).Trim();
				if (Operators.CompareString(text, null, TextCompare: false) != 0)
				{
					GraphClass graphClass = new GraphClass(text);
					chartPanel.Show();
					chartGraph.Image = graphClass.drawGraph(chartGraph.Size);
					Label label;
					(label = Label14).Text = label.Text + Conversions.ToString(graphClass.AllSum) + "번 (" + Conversions.ToString(DateAndTime.Now.Year) + "년 " + Conversions.ToString(graphClass.NowYearSum) + "번)";
					(label = Label13).Text = label.Text + Conversions.ToString(graphClass.Average) + "번";
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				chartPanel.Hide();
				ProjectData.ClearProjectError();
			}
			ListBox1.Font = new Font("맑은 고딕", (float)Conversions.ToDouble(Module1.Menu_textSize), FontStyle.Regular, GraphicsUnit.Point, 129);
			ListBox1.ItemHeight = Conversions.ToInteger(Operators.AddObject(Module1.Menu_textSize, Module1.Menu_HeightSize));
			object[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(array2[i]);
				ListBox1.Items.Add(Operators.ConcatenateObject("  ", objectValue));
			}
			try
			{
				ListBox1.SelectedIndex = 0;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		try
		{
			string text = new GetHtmlClass(Module1._dburl + "/admin.php?type=getCountV2", "pw=" + MySettingsProperty.Settings.pw, progress: true).getHTML(this).Trim();
			if (Operators.CompareString(text, null, TextCompare: false) != 0)
			{
				GraphClass graphClass = new GraphClass(text);
				chartPanel.Show();
				chartGraph.Image = graphClass.drawGraph(chartGraph.Size);
				Label14.Text = "누적 접속 횟수 : " + Conversions.ToString(graphClass.AllSum) + "번 (" + Conversions.ToString(DateAndTime.Now.Year) + "년 " + Conversions.ToString(graphClass.NowYearSum) + "번)";
				Label13.Text = "하루 평균 접속 횟수 : " + Conversions.ToString(graphClass.Average) + "번";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Listbox1EventExit)
		{
			Listbox1EventExit = false;
		}
		else
		{
			if (nowListbox1 == ListBox1.SelectedIndex)
			{
				return;
			}
			switch (ListBox1.SelectedItem.ToString().Trim())
			{
			case "메인":
			{
				if (!Module1.CMsgboxOption)
				{
					Button1.Show();
				}
				PanelUnvisible();
				string project = Module1.project;
				if (Operators.CompareString(project, "android_db_ss_order", TextCompare: false) == 0)
				{
					Module1.NOW_DOCK = MyProject.Forms.android_db_ss_order.pHome;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
				}
				else
				{
					Module1.NOW_DOCK = p1;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
				}
				goto case "게시판 관리";
			}
			case "상담사 DB 관리자 열기":
				Listbox1EventExit = true;
				ListBox1.SelectedIndex = nowListbox1;
				MyProject.Forms.ssorder_cti.Show();
				base.Visible = false;
				goto case "게시판 관리";
			case "상담사 프로그램 열기":
				Listbox1EventExit = true;
				ListBox1.SelectedIndex = nowListbox1;
				MyProject.Forms.ssorder_cti.Show();
				base.Visible = false;
				goto case "게시판 관리";
			case "주문 접수":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_ss_order.p5;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				MyProject.Forms.android_db_ss_order.ss_setorder_init();
				goto case "게시판 관리";
			case "주문 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_ss_order.p1;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				MyProject.Forms.android_db_ss_order.ss_order_init();
				if (ssorder.ssorder_acgb == 2)
				{
					MyProject.Forms.android_db_ss_order.searchOrder();
				}
				goto case "게시판 관리";
			case "조회":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_ss_order.p1;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				MyProject.Forms.android_db_ss_order.ss_order_init();
				if (ssorder.ssorder_acgb == 2)
				{
					if (ssorder.order_productClass == null)
					{
						MyProject.Forms.android_db_ss_order.orderProduct();
					}
					MyProject.Forms.android_db_ss_order.searchOrder();
				}
				goto case "게시판 관리";
			case "고객 관리":
			{
				string project2 = Module1.project;
				if (Operators.CompareString(project2, "home_db_microlivire", TextCompare: false) != 0)
				{
					if (Operators.CompareString(project2, "android_db_ss_order", TextCompare: false) == 0)
					{
						PanelUnvisible();
						Module1.NOW_DOCK = MyProject.Forms.android_db_ss_order.p2;
						Module1.NOW_DOCK.SuspendLayout();
						Module1.NOW_DOCK.Dock = DockStyle.Fill;
						Module1.NOW_DOCK.Visible = true;
						Module1.NOW_DOCK.ResumeLayout();
					}
				}
				else
				{
					PanelUnvisible();
					Module1.NOW_DOCK = MyProject.Forms.home_db_microlivire.p1;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
				}
				goto case "게시판 관리";
			}
			case "제품 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_ss_order.p3;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				MyProject.Forms.android_db_ss_order.productDialog(show: false);
				MyProject.Forms.android_db_ss_order.ss_product_init();
				goto case "게시판 관리";
			case "사용자 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_ss_order.p4;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				MyProject.Forms.android_db_ss_order.ss_account_init();
				goto case "게시판 관리";
			case "프로젝트 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.home_db_microlivire.p2;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				goto case "게시판 관리";
			case "고객센터 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.home_db_microlivire.p3;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				goto case "게시판 관리";
			case "접속 로그":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.home_db_microlivire.p6;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				goto case "게시판 관리";
			case "회원 관리":
				PanelUnvisible();
				switch (Module1.project)
				{
				case "android_db_sjka_cyber":
					Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p9;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					if (sjka_cyber.cList2 == null)
					{
						MyProject.Forms.android_db_sjka_cyber.CourseList();
					}
					if (sjka_cyber.ACCOUNT_AD == null)
					{
						MyProject.Forms.android_db_sjka_cyber.getAccount();
					}
					break;
				case "android_mba_check":
					Module1.NOW_DOCK = MyProject.Forms.android_mba_check.p3;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					if (mba_check.mba_check_account.Count <= 0)
					{
						MyProject.Forms.android_mba_check.getAccounts();
					}
					break;
				case "android_mom_hakwon":
					Module1.NOW_DOCK = MyProject.Forms.android_mba_check.p3;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					if (mba_check.mba_check_account.Count <= 0)
					{
						MyProject.Forms.android_mba_check.getAccounts();
					}
					break;
				}
				goto case "게시판 관리";
			case "배너 관리":
				PanelUnvisible();
				switch (Module1.project)
				{
				case "android_db_sjka_cyber":
					Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p10;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					if (sjka_cyber.BANNER == null)
					{
						MyProject.Forms.android_db_sjka_cyber.getBanner();
					}
					break;
				case "android_mba_check":
					Module1.NOW_DOCK = MyProject.Forms.android_mba_check.p1;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					if (mba_check.mba_check_advList.Count <= 0)
					{
						MyProject.Forms.android_mba_check.getBanner(0);
					}
					break;
				case "android_mom_hakwon":
					Module1.NOW_DOCK = MyProject.Forms.android_mba_check.p4;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					if (mba_check.hakwon_check_advList.Count <= 0)
					{
						MyProject.Forms.android_mba_check.getBanner(1);
					}
					break;
				}
				goto case "게시판 관리";
			case "배너 관리(MOM출첵)":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_mba_check.p1;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (mba_check.mba_check_advList.Count <= 0)
				{
					MyProject.Forms.android_mba_check.getBanner(0);
				}
				goto case "게시판 관리";
			case "배너 관리(학원출첵)":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_mba_check.p4;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (mba_check.hakwon_check_advList.Count <= 0)
				{
					MyProject.Forms.android_mba_check.getBanner(1);
				}
				goto case "게시판 관리";
			case "사용 설명서":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_mba_check.p5;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.HOW2USE == null)
				{
					MyProject.Forms.android_mba_check.getHow2Use();
				}
				goto case "게시판 관리";
			case "공지사항 관리":
				PanelUnvisible();
				switch (Module1.project)
				{
				case "android_db_sjka_application_noteapp":
					PanelUnvisible();
					Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_application_noteapp.p10;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					if (Module1.board == null)
					{
						MyProject.Forms.android_db_sjka_application_noteapp.notice_refresh();
					}
					break;
				case "android_db_sjka_cyber":
					Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p8;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					if (sjka_cyber.NOTICE_ND == null)
					{
						MyProject.Forms.android_db_sjka_cyber.getNotice();
					}
					break;
				case "home_db_microlivire":
					Module1.NOW_DOCK = MyProject.Forms.home_db_microlivire.p4;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					break;
				case "android_mba_check":
					Module1.NOW_DOCK = MyProject.Forms.android_mba_check.p2;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					if (sjka_cyber.NOTICE_ND == null)
					{
						MyProject.Forms.android_mba_check.getNotice();
					}
					break;
				case "android_mom_hakwon":
					Module1.NOW_DOCK = MyProject.Forms.android_mba_check.p2;
					Module1.NOW_DOCK.SuspendLayout();
					Module1.NOW_DOCK.Dock = DockStyle.Fill;
					Module1.NOW_DOCK.Visible = true;
					Module1.NOW_DOCK.ResumeLayout();
					if (sjka_cyber.NOTICE_ND == null)
					{
						MyProject.Forms.android_mba_check.getNotice();
					}
					break;
				}
				goto case "게시판 관리";
			case "피드백 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p12;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.docs == null)
				{
					MyProject.Forms.android_db_sjka_cyber.docList(false);
				}
				if (sjka_cyber.KeypointDB == null)
				{
					MyProject.Forms.android_db_sjka_cyber.InitKeypoint();
				}
				if (sjka_cyber.KeypointXML == null)
				{
					MyProject.Forms.android_db_sjka_cyber.getKeypointXML();
				}
				if (sjka_cyber.feedback == null)
				{
					MyProject.Forms.android_db_sjka_cyber.feedbackRefresh();
				}
				goto case "게시판 관리";
			case "사용설명서 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p13;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.HOW2USE == null)
				{
					MyProject.Forms.android_db_sjka_cyber.getHow2Use();
				}
				goto case "게시판 관리";
			case "FTP 편집기":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.home_db_microlivire.p5;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				goto case "게시판 관리";
			case "강좌 연결":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p1;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.cList2 == null)
				{
					MyProject.Forms.android_db_sjka_cyber.CourseList();
				}
				goto case "게시판 관리";
			case "기출문제 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p2;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.docs == null)
				{
					MyProject.Forms.android_db_sjka_cyber.docList(false);
				}
				goto case "게시판 관리";
			case "강의폴더 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p3;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.docs == null)
				{
					MyProject.Forms.android_db_sjka_cyber.docList(false);
				}
				if (sjka_cyber.KwordZip == null)
				{
					MyProject.Forms.android_db_sjka_cyber.getKZip2();
				}
				if (sjka_cyber.keypointZip == null)
				{
					MyProject.Forms.android_db_sjka_cyber.getKeypointZip();
				}
				if ((sjka_cyber.catList == null) | (sjka_cyber.catLib == null))
				{
					MyProject.Forms.android_db_sjka_cyber.CatalogInit();
				}
				goto case "게시판 관리";
			case "키워드 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p4;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.ZipList_dl == null)
				{
					MyProject.Forms.android_db_sjka_cyber.ZipList();
				}
				goto case "게시판 관리";
			case "키워드 폴더 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p7;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.ZipList_dl == null)
				{
					MyProject.Forms.android_db_sjka_cyber.ZipList();
				}
				if (MyProject.Forms.android_db_sjka_cyber.ListBox9.Items.Count < 1)
				{
					MyProject.Forms.android_db_sjka_cyber.getKZip2();
				}
				goto case "게시판 관리";
			case "핵심요약집 폴더 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p6;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.KeypointDB == null)
				{
					MyProject.Forms.android_db_sjka_cyber.InitKeypoint();
				}
				if (sjka_cyber.KeypointXML == null)
				{
					MyProject.Forms.android_db_sjka_cyber.getKeypointXML();
				}
				if (sjka_cyber.keypointZip == null)
				{
					MyProject.Forms.android_db_sjka_cyber.getKeypointZip();
				}
				goto case "게시판 관리";
			case "핵심요약집 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p5;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.KeypointDB == null)
				{
					MyProject.Forms.android_db_sjka_cyber.InitKeypoint();
				}
				if (sjka_cyber.KeypointXML == null)
				{
					MyProject.Forms.android_db_sjka_cyber.getKeypointXML();
				}
				goto case "게시판 관리";
			case "핵심요약 문서관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_cyber.p11;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (sjka_cyber.KeypointDB == null)
				{
					MyProject.Forms.android_db_sjka_cyber.InitKeypoint();
				}
				goto case "게시판 관리";
			case "데이터 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_application_noteapp.p2;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (Module1.AllData == null)
				{
					MyProject.Forms.android_db_sjka_application_noteapp.alldata_load();
				}
				if (MyProject.Forms.android_db_sjka_application_noteapp.ComboBox4.Items.Count <= 0)
				{
					MyProject.Forms.android_db_sjka_application_noteapp.RefreshFolder();
				}
				goto case "게시판 관리";
			case "데이터 추가":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_application_noteapp.p3;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (MyProject.Forms.android_db_sjka_application_noteapp.ComboBox2.Items.Count <= 0)
				{
					MyProject.Forms.android_db_sjka_application_noteapp.RefreshFolder();
				}
				goto case "게시판 관리";
			case "학명집 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_application_noteapp.p4;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (MyProject.Forms.android_db_sjka_application_noteapp.ComboBox3.Items.Count <= 0)
				{
					MyProject.Forms.android_db_sjka_application_noteapp.RefreshNote();
				}
				goto case "게시판 관리";
			case "폴더 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_application_noteapp.p7;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (MyProject.Forms.android_db_sjka_application_noteapp.ComboBox5.Items.Count <= 0)
				{
					MyProject.Forms.android_db_sjka_application_noteapp.RefreshFolder();
				}
				goto case "게시판 관리";
			case "컬럼 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_application_noteapp.p5;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (MyProject.Forms.android_db_sjka_application_noteapp.ListBox4.Items.Count <= 0)
				{
					MyProject.Forms.android_db_sjka_application_noteapp.RefreshColumnName();
				}
				goto case "게시판 관리";
			case "뷰 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_application_noteapp.p6;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (MyProject.Forms.android_db_sjka_application_noteapp.ComboBox6.Items.Count <= 0)
				{
					MyProject.Forms.android_db_sjka_application_noteapp.RefreshView();
				}
				goto case "게시판 관리";
			case "검색 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.android_db_sjka_application_noteapp.p8;
				Module1.NOW_DOCK.SuspendLayout();
				Module1.NOW_DOCK.Visible = true;
				Module1.NOW_DOCK.ResumeLayout();
				if (MyProject.Forms.android_db_sjka_application_noteapp.ComboBox13.Items.Count <= 0)
				{
					MyProject.Forms.android_db_sjka_application_noteapp.RefreshSearch();
				}
				goto case "게시판 관리";
			case "데이터 새로고침":
				Listbox1EventExit = true;
				ListBox1.SelectedIndex = nowListbox1;
				if (MessageBox.Show("저장하지 않은 데이터는 서버에 반영되지 않습니다.\r\n\r\n새로고침 하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.No)
				{
					Module1.search_mode = false;
					switch (Module1.project)
					{
					case "home_db_microlivire":
						MyProject.Forms.home_db_microlivire.Reset(thrmode: true);
						break;
					case "android_db_sjka_application_noteapp":
						MyProject.Forms.android_db_sjka_application_noteapp.SetList();
						break;
					case "android_db_kjh_smart_screen":
						MyProject.Forms.android_db_sjka_application_noteapp.SetList();
						break;
					case "windows_db_human_chart":
						MyProject.Forms.windows_db_human_chart.SurveyList();
						break;
					}
					Module1.ASrefresh();
					goto case "게시판 관리";
				}
				break;
			case "로그아웃":
				Listbox1EventExit = true;
				ListBox1.SelectedIndex = nowListbox1;
				if (MessageBox.Show("현재 계정에서 로그아웃 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						Module1.MLAS_logout = true;
						MySettingsProperty.Settings.autologin = false;
						MySettingsProperty.Settings.Save();
						MyProject.Forms.home_db_microlivire.ProgramExit();
						Application.Restart();
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						try
						{
							Application.Exit();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						ProjectData.ClearProjectError();
					}
				}
				goto case "게시판 관리";
			case "고객 지원":
				PanelUnvisible();
				Panel85.Dock = DockStyle.Fill;
				Panel85.Visible = true;
				Module1.ASrefresh();
				goto case "게시판 관리";
			case "종료":
				Listbox1EventExit = true;
				ListBox1.SelectedIndex = nowListbox1;
				if (MessageBox.Show("MLAS 클라이언트를 종료 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Module1.MLAS_logout = true;
					MyProject.Forms.home_db_microlivire.ProgramExit();
					Application.Exit();
				}
				goto case "게시판 관리";
			case "검사 결과 데이터":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.windows_db_human_chart.p1;
				Module1.NOW_DOCK.Visible = true;
				goto case "게시판 관리";
			case "질문 관리":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.windows_db_human_chart.p2;
				Module1.NOW_DOCK.Visible = true;
				goto case "게시판 관리";
			case "UI 변경":
				PanelUnvisible();
				Module1.NOW_DOCK = MyProject.Forms.windows_db_human_chart.p3;
				Module1.NOW_DOCK.Visible = true;
				goto case "게시판 관리";
			case "주소 변경":
				PanelUnvisible();
				Module1.NOW_DOCK = mod_p1;
				Module1.NOW_DOCK.Dock = DockStyle.Fill;
				Module1.NOW_DOCK.Visible = true;
				ComboBox17.DataSource = MyProject.Forms.login.ComboBox1.Items;
				goto case "게시판 관리";
			default:
				Listbox1EventExit = true;
				ListBox1.SelectedIndex = nowListbox1;
				goto case "게시판 관리";
			case "게시판 관리":
				nowListbox1 = ListBox1.SelectedIndex;
				Animstart();
				break;
			}
		}
	}

	private void PanelUnvisible(bool first = false)
	{
		if (!first)
		{
			nowListbox1 = ListBox1.SelectedIndex;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = Panel2.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					((Panel)enumerator.Current).Visible = false;
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
		switch (Module1.project)
		{
		case "home_db_microlivire":
			Panel2.Controls.Add(MyProject.Forms.home_db_microlivire.p1);
			Panel2.Controls.Add(MyProject.Forms.home_db_microlivire.p2);
			Panel2.Controls.Add(MyProject.Forms.home_db_microlivire.p3);
			Panel2.Controls.Add(MyProject.Forms.home_db_microlivire.p4);
			Panel2.Controls.Add(MyProject.Forms.home_db_microlivire.p5);
			Panel2.Controls.Add(MyProject.Forms.home_db_microlivire.p6);
			if (!first)
			{
				MyProject.Forms.home_db_microlivire.p1.Hide();
				MyProject.Forms.home_db_microlivire.p2.Hide();
				MyProject.Forms.home_db_microlivire.p3.Hide();
				MyProject.Forms.home_db_microlivire.p4.Hide();
				MyProject.Forms.home_db_microlivire.p5.Hide();
				MyProject.Forms.home_db_microlivire.p6.Hide();
			}
			break;
		case "android_db_sjka_application_noteapp":
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_application_noteapp.p2);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_application_noteapp.p3);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_application_noteapp.p4);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_application_noteapp.p5);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_application_noteapp.p6);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_application_noteapp.p7);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_application_noteapp.p8);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_application_noteapp.p10);
			if (!first)
			{
				MyProject.Forms.android_db_sjka_application_noteapp.p2.Hide();
				MyProject.Forms.android_db_sjka_application_noteapp.p3.Hide();
				MyProject.Forms.android_db_sjka_application_noteapp.p4.Hide();
				MyProject.Forms.android_db_sjka_application_noteapp.p5.Hide();
				MyProject.Forms.android_db_sjka_application_noteapp.p6.Hide();
				MyProject.Forms.android_db_sjka_application_noteapp.p7.Hide();
				MyProject.Forms.android_db_sjka_application_noteapp.p8.Hide();
				MyProject.Forms.android_db_sjka_application_noteapp.p10.Hide();
			}
			break;
		case "android_db_sjka_cyber":
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p1);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p2);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p3);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p4);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p5);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p6);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p7);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p8);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p9);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p10);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p11);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p12);
			Panel2.Controls.Add(MyProject.Forms.android_db_sjka_cyber.p13);
			if (!first)
			{
				MyProject.Forms.android_db_sjka_cyber.p1.Hide();
				MyProject.Forms.android_db_sjka_cyber.p2.Hide();
				MyProject.Forms.android_db_sjka_cyber.p3.Hide();
				MyProject.Forms.android_db_sjka_cyber.p4.Hide();
				MyProject.Forms.android_db_sjka_cyber.p5.Hide();
				MyProject.Forms.android_db_sjka_cyber.p6.Hide();
				MyProject.Forms.android_db_sjka_cyber.p7.Hide();
				MyProject.Forms.android_db_sjka_cyber.p8.Hide();
				MyProject.Forms.android_db_sjka_cyber.p9.Hide();
				MyProject.Forms.android_db_sjka_cyber.p10.Hide();
				MyProject.Forms.android_db_sjka_cyber.p11.Hide();
				MyProject.Forms.android_db_sjka_cyber.p12.Hide();
				MyProject.Forms.android_db_sjka_cyber.p13.Hide();
			}
			break;
		case "android_db_kjh_smart_screen":
		{
			MyProject.Forms.android_db_sjka_application_noteapp.Visible = true;
			MyProject.Forms.android_db_sjka_application_noteapp.Dock = DockStyle.Fill;
			if (first)
			{
				break;
			}
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = MyProject.Forms.android_db_sjka_application_noteapp.Controls.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(enumerator2.Current), null, "Visible", new object[1] { false }, null, null);
				}
				break;
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
		}
		case "windows_db_human_chart":
			Panel2.Controls.Add(MyProject.Forms.windows_db_human_chart.p1);
			Panel2.Controls.Add(MyProject.Forms.windows_db_human_chart.p2);
			Panel2.Controls.Add(MyProject.Forms.windows_db_human_chart.p3);
			if (!first)
			{
				MyProject.Forms.windows_db_human_chart.p1.Hide();
				MyProject.Forms.windows_db_human_chart.p2.Hide();
				MyProject.Forms.windows_db_human_chart.p3.Hide();
			}
			break;
		case "server_url_modify":
		{
			server_url_modify.Visible = true;
			server_url_modify.Dock = DockStyle.Fill;
			if (first)
			{
				break;
			}
			IEnumerator enumerator3 = default(IEnumerator);
			try
			{
				enumerator3 = server_url_modify.Controls.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(enumerator3.Current), null, "Visible", new object[1] { false }, null, null);
				}
				break;
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
		}
		case "android_db_ss_order":
			Panel2.Controls.Add(MyProject.Forms.android_db_ss_order.pHome);
			Panel2.Controls.Add(MyProject.Forms.android_db_ss_order.p1);
			Panel2.Controls.Add(MyProject.Forms.android_db_ss_order.p2);
			Panel2.Controls.Add(MyProject.Forms.android_db_ss_order.p3);
			Panel2.Controls.Add(MyProject.Forms.android_db_ss_order.p4);
			Panel2.Controls.Add(MyProject.Forms.android_db_ss_order.p5);
			if (!first)
			{
				MyProject.Forms.android_db_ss_order.pHome.Hide();
				MyProject.Forms.android_db_ss_order.p1.Hide();
				MyProject.Forms.android_db_ss_order.p2.Hide();
				MyProject.Forms.android_db_ss_order.p3.Hide();
				MyProject.Forms.android_db_ss_order.p4.Hide();
				MyProject.Forms.android_db_ss_order.p5.Hide();
			}
			break;
		case "android_mba_check":
			Panel2.Controls.Add(MyProject.Forms.android_mba_check.p1);
			Panel2.Controls.Add(MyProject.Forms.android_mba_check.p2);
			Panel2.Controls.Add(MyProject.Forms.android_mba_check.p3);
			Panel2.Controls.Add(MyProject.Forms.android_mba_check.p4);
			Panel2.Controls.Add(MyProject.Forms.android_mba_check.p5);
			if (!first)
			{
				MyProject.Forms.android_mba_check.p1.Hide();
				MyProject.Forms.android_mba_check.p2.Hide();
				MyProject.Forms.android_mba_check.p3.Hide();
				MyProject.Forms.android_mba_check.p4.Hide();
				MyProject.Forms.android_mba_check.p5.Hide();
			}
			break;
		case "android_mom_hakwon":
			Panel2.Controls.Add(MyProject.Forms.android_mba_check.p1);
			Panel2.Controls.Add(MyProject.Forms.android_mba_check.p2);
			Panel2.Controls.Add(MyProject.Forms.android_mba_check.p3);
			Panel2.Controls.Add(MyProject.Forms.android_mba_check.p4);
			Panel2.Controls.Add(MyProject.Forms.android_mba_check.p5);
			if (!first)
			{
				MyProject.Forms.android_mba_check.p1.Hide();
				MyProject.Forms.android_mba_check.p2.Hide();
				MyProject.Forms.android_mba_check.p3.Hide();
				MyProject.Forms.android_mba_check.p4.Hide();
				MyProject.Forms.android_mba_check.p5.Hide();
			}
			break;
		}
	}

	private void Button77_Click(object sender, EventArgs e)
	{
		try
		{
			Module1.databusy = false;
			Module1.thr3.Abort();
			MyProject.Forms.android_db_sjka_application_noteapp.pnpage();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void releaseObject(object obj)
	{
		try
		{
			Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
			obj = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			obj = null;
			ProjectData.ClearProjectError();
		}
		finally
		{
			GC.Collect();
		}
	}

	public void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
	{
		try
		{
			e.DrawBackground();
			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				Brush brush = new SolidBrush(Color.FromArgb(240, 240, 240));
				Rectangle bounds = e.Bounds;
				e.Graphics.FillRectangle(brush, bounds);
				Brush brush2 = new SolidBrush(Color.FromArgb(0, 0, 0));
				Font font = new Font("맑은 고딕", 12f, FontStyle.Bold, GraphicsUnit.Point, 129);
				Graphics graphics = e.Graphics;
				object[] array = new object[1];
				object obj = sender;
				object instance = obj;
				object[] array2 = new object[1];
				object obj2 = (array2[0] = e.Index);
				array[0] = NewLateBinding.LateGet(instance, null, "Items", array2, null, null, null);
				object[] array3 = array;
				bool[] obj3 = new bool[1] { true };
				bool[] array4 = obj3;
				object obj4 = NewLateBinding.LateGet(sender, null, "GetItemText", array, null, null, obj3);
				if (array4[0])
				{
					NewLateBinding.LateSetComplex(obj, null, "Items", new object[2]
					{
						obj2,
						array3[0]
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				graphics.DrawString(Conversions.ToString(obj4), font, brush2, bounds);
			}
			else
			{
				using SolidBrush brush3 = new SolidBrush(e.ForeColor);
				Graphics graphics2 = e.Graphics;
				object[] array5 = new object[1];
				object obj2 = sender;
				object instance2 = obj2;
				object[] array6 = new object[1];
				object obj = (array6[0] = e.Index);
				array5[0] = NewLateBinding.LateGet(instance2, null, "Items", array6, null, null, null);
				object[] array3 = array5;
				bool[] obj5 = new bool[1] { true };
				bool[] array4 = obj5;
				object obj4 = NewLateBinding.LateGet(sender, null, "GetItemText", array5, null, null, obj5);
				if (array4[0])
				{
					NewLateBinding.LateSetComplex(obj2, null, "Items", new object[2]
					{
						obj,
						array3[0]
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				graphics2.DrawString(Conversions.ToString(obj4), e.Font, brush3, e.Bounds);
			}
			e.DrawFocusRectangle();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
		Process.Start(Module1.click_url);
	}

	private void mlas_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!Module1.MLAS_logout)
		{
			e.Cancel = true;
			if (MessageBox.Show("MLAS 클라이언트를 종료 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Module1.MLAS_logout = true;
				Application.Exit();
			}
		}
	}

	private void Label4_Click(object sender, EventArgs e)
	{
		if (notice_detail)
		{
			Panel53.Size = new Size(0, 25);
			notice_detail = false;
			txt_notice.Text = Module1.notice[0] + " (자세히 보기)";
		}
		else
		{
			Panel53.Size = new Size(0, 130);
			notice_detail = true;
			txt_notice.Text = Module1.notice[0] + " (닫기)";
			txt_noticedetail.Text = Module1.notice[1];
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		MyProject.Forms.android_db_sjka_application_noteapp.p2.Visible = false;
		MyProject.Forms.android_db_sjka_application_noteapp.p3.Visible = false;
		MyProject.Forms.android_db_sjka_application_noteapp.p4.Visible = false;
		MyProject.Forms.android_db_sjka_application_noteapp.p5.Visible = false;
		MyProject.Forms.android_db_sjka_application_noteapp.p6.Visible = false;
		MyProject.Forms.android_db_sjka_application_noteapp.p7.Visible = false;
		MyProject.Forms.android_db_sjka_application_noteapp.p8.Visible = false;
		p1.Dock = DockStyle.Fill;
		p1.Visible = true;
		ListBox1.SelectedIndex = 0;
	}

	private void Button52_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Conversions.ToString(Module1.HtmlSourceNoCredent("http://umylife0208.cafe24.com/mlas/feedback.php?type=msg&project=" + Module1.project + "&msg=" + HttpUtility.UrlEncode(TextBox12.Text))), "incorrect", TextCompare: false) == 0)
		{
			MessageBox.Show("데이터 처리중에 오류가 발생하였습니다.\r\n\r\n인터넷 연결을 확인하거나 데이터 누락이 있는지, 정상적인 접속이 맞는지 확인하십시오.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		MessageBox.Show("제품 피드백을 보냈습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		TextBox12.Text = null;
	}

	private void WebClient1_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		ProgressBar6.Value = e.ProgressPercentage;
		Label69.Text = down + " 파일 다운로드 중입니다. " + Conversions.ToString(e.ProgressPercentage) + "%";
	}

	private void WebClient1_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
	{
		Panel91.Hide();
		Panel92.Show();
	}

	private void ListView4_SelectedIndexChanged(object sender, EventArgs e)
	{
		ListView listView = ListView4;
		if (listView.SelectedItems.Count <= 0)
		{
			Panel90.Hide();
			TextBox19.Text = null;
			ListView4.Dock = DockStyle.Fill;
			return;
		}
		string[] array = Module1.ASfile[listView.SelectedIndices[0]].Split(new string[1] { "|" }, StringSplitOptions.None);
		TextBox19.Text = array[4];
		if (Operators.CompareString(array[5], null, TextCompare: false) == 0)
		{
			Panel90.Hide();
		}
		else
		{
			Panel90.Show();
			Label71.Text = array[5].Substring(checked(array[5].LastIndexOf("/") + 1)) + " (" + array[6] + ") ";
		}
		listView = null;
	}

	private void Button67_Click(object sender, EventArgs e)
	{
		if (ListView4.SelectedItems.Count <= 0)
		{
			return;
		}
		string[] array = Module1.ASfile[ListView4.SelectedIndices[0]].Split(new string[1] { "|" }, StringSplitOptions.None);
		checked
		{
			if (Operators.CompareString(array[5], null, TextCompare: false) != 0)
			{
				SaveFileDialog saveFileDialog;
				SaveFileDialog saveFileDialog2 = (saveFileDialog = new SaveFileDialog());
				if (Operators.CompareString(Module1.ASurl, null, TextCompare: false) != 0)
				{
					saveFileDialog.InitialDirectory = Module1.ASurl.Substring(0, Module1.ASurl.LastIndexOf("\\"));
				}
				saveFileDialog.FileName = array[5].Substring(array[5].LastIndexOf("/") + 1);
				down = array[5].Substring(array[5].LastIndexOf("/") + 1);
				if (saveFileDialog2.ShowDialog() == DialogResult.OK)
				{
					Module1.ASurl = saveFileDialog.FileName;
					Panel92.Hide();
					Panel91.Show();
					Label70.Text = array[5].Substring(array[5].LastIndexOf("/") + 1) + " 파일 다운로드가 완료되었습니다.";
					Uri uri = null;
					uri = ((!array[5].StartsWith("http://")) ? new Uri("http://umylife0208.cafe24.com/mlas/clients/" + array[5]) : new Uri(array[5]));
					WebClient1.DownloadFileAsync(uri, saveFileDialog.FileName);
				}
				saveFileDialog = null;
			}
		}
	}

	private void Button69_Click(object sender, EventArgs e)
	{
		Panel92.Hide();
	}

	private void ListView4_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (ListView4.SelectedItems.Count > 0)
		{
			Button67_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void Button68_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start(Module1.ASurl);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void TextBox19_TextChanged(object sender, EventArgs e)
	{
	}

	private void Button70_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start(Module1.ASurl.Substring(0, Module1.ASurl.LastIndexOf("\\")).Substring(checked(down.LastIndexOf("/") + 1)));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void Button71_Click(object sender, EventArgs e)
	{
		CoInternetSetFeatureEnabled(21, 2, fEnable: true);
		CHAT_MAIN_MODULE.CHAT_FORM = new Form();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(mlas));
		Form cHAT_FORM = CHAT_MAIN_MODULE.CHAT_FORM;
		cHAT_FORM.Text = "Chat v1.0";
		cHAT_FORM.Controls.Add(MyProject.Forms.CHAT_MAIN.Panel2);
		MyProject.Forms.CHAT_MAIN.Panel2.Dock = DockStyle.Fill;
		cHAT_FORM.FormBorderStyle = FormBorderStyle.None;
		cHAT_FORM.Size = new Size(344, 578);
		cHAT_FORM.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		cHAT_FORM.StartPosition = FormStartPosition.CenterScreen;
		CHAT_MAIN_MODULE.CHAT_NOWID = "microlivire";
		MyProject.Forms.CHAT_MAIN.setView();
		cHAT_FORM.Show();
		MyProject.Forms.CHAT_MAIN.TextBox4.Focus();
		CHAT_MAIN_MODULE.CHAT_FORM.FormClosing += delegate
		{
			frmclosing();
		};
		_ = null;
	}

	private void Button72_Click(object sender, EventArgs e)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Panel2.Controls.GetEnumerator();
			while (enumerator.MoveNext())
			{
				((Panel)enumerator.Current).Visible = false;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		Panel85.Dock = DockStyle.Fill;
		Panel85.Visible = true;
	}

	private void Button76_Click(object sender, EventArgs e)
	{
		string[] array = RuntimeHelpers.GetObjectValue(Module1.HtmlSourceNoCredent(Module1._dburl + "/util.php?type=mlas_appurl&project=" + ComboBox17.Text + "&id=" + HttpUtility.UrlEncode(TextBox20.Text) + "&pw=" + HttpUtility.UrlEncode(TextBox21.Text))).ToString().Split(new string[1] { "|" }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length == 2)
		{
			Panel110.Visible = true;
			TextBox24.Text = array[1];
			Panel111.Enabled = false;
			MessageBox.Show("관리자 인증에 성공하였습니다.", "인증 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else
		{
			MessageBox.Show("일치하는 관리자 정보가 없습니다. 다시한번 확인 후 인증하여 주십시오.", "인증 실패", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}
	}

	private void Button75_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("정말 서버주소를 변경하시겠습니까? 만약 올바르지 않은 주소를 입력 했을경우, 솔루션 및 연관되어 있는 모든 앱이 정상적으로 작동하지 않을 수 있습니다.", "주소 변경 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.No)
		{
			if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(Module1.HtmlSourceNoCredent(Module1._dburl + "/util.php?type=mlas_appurlMOD&project=" + ComboBox17.Text + "&id=" + HttpUtility.UrlEncode(TextBox20.Text) + "&pw=" + HttpUtility.UrlEncode(TextBox21.Text) + "&dburl=" + HttpUtility.UrlEncode(TextBox24.Text))), "correct", TextCompare: false))
			{
				MessageBox.Show("변경 완료하였습니다.", "서버주소 변경 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("변경에 실패하였습니다.", "서버주소 변경 실패", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
	}

	private void Panel4_MouseDown(object sender, MouseEventArgs e)
	{
		if (base.WindowState != FormWindowState.Maximized && e.Clicks <= 1)
		{
			ObjectMover.MoveObject(base.Handle);
			Application.DoEvents();
			ObjectMover.FocusObject(base.Handle);
		}
	}

	private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox3.Image = Resources.close2;
	}

	private void PictureBox5_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox5.Image = Resources.mini2;
	}

	private void PictureBox3_MouseLeave(object sender, EventArgs e)
	{
		if (form_active)
		{
			PictureBox3.Image = Resources.close1;
		}
		else
		{
			PictureBox3.Image = Resources.close3;
		}
	}

	private void PictureBox5_MouseLeave(object sender, EventArgs e)
	{
		if (form_active)
		{
			PictureBox5.Image = Resources.mini1;
		}
		else
		{
			PictureBox5.Image = Resources.mini3;
		}
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("MLAS 클라이언트를 종료 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			Module1.MLAS_logout = true;
			MyProject.Forms.home_db_microlivire.ProgramExit();
			Application.Exit();
		}
	}

	private void PictureBox5_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void main_Activated(object sender, EventArgs e)
	{
		form_active = true;
		PictureBox6.Image = Resources.max1;
		PictureBox5.Image = Resources.mini1;
		PictureBox3.Image = Resources.close1;
		Panel4.BackgroundImage = Resources.topbar;
	}

	private void main_Deactivate(object sender, EventArgs e)
	{
		form_active = false;
		PictureBox5.Image = Resources.mini3;
		PictureBox3.Image = Resources.close3;
		PictureBox6.Image = Resources.max3;
		Panel4.BackgroundImage = Resources.topbar_deactive1;
	}

	private void PictureBox6_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox6.Image = Resources.max2;
	}

	private void PictureBox6_MouseLeave(object sender, EventArgs e)
	{
		if (form_active)
		{
			PictureBox6.Image = Resources.max1;
		}
		else
		{
			PictureBox6.Image = Resources.max3;
		}
	}

	private void PictureBox6_Click(object sender, EventArgs e)
	{
		if (base.WindowState == FormWindowState.Normal)
		{
			base.WindowState = FormWindowState.Maximized;
			return;
		}
		base.WindowState = FormWindowState.Normal;
		base.Size = FixedFormSize;
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (base.Opacity == 1.0)
		{
			Timer2.Stop();
			return;
		}
		Application.DoEvents();
		base.Opacity += 0.1;
	}

	private void Panel4_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (base.WindowState == FormWindowState.Normal)
		{
			base.WindowState = FormWindowState.Maximized;
			return;
		}
		base.WindowState = FormWindowState.Normal;
		base.Size = FixedFormSize;
	}

	protected override void WndProc(ref Message m)
	{
		int msg = m.Msg;
		if (msg == 70)
		{
			SnapToDesktopBorder(this, m.LParam, 0);
		}
		base.WndProc(ref m);
	}

	public static void SnapToDesktopBorder(Form clientForm, IntPtr LParam, int widthAdjustment)
	{
		if (clientForm == null)
		{
			throw new ArgumentNullException("clientForm");
		}
		checked
		{
			try
			{
				WINDOWPOS wINDOWPOS = default(WINDOWPOS);
				object obj = Marshal.PtrToStructure(LParam, typeof(WINDOWPOS));
				wINDOWPOS = ((obj != null) ? ((WINDOWPOS)obj) : default(WINDOWPOS));
				if (wINDOWPOS.y == 0 || wINDOWPOS.x == 0)
				{
					return;
				}
				Rectangle rectangle = clientForm.RectangleToScreen(clientForm.ClientRectangle);
				rectangle.Width -= 10;
				rectangle.Height -= 10;
				Rectangle workingArea = Screen.GetWorkingArea(clientForm.ClientRectangle);
				if (wINDOWPOS.x >= workingArea.X - 20 && wINDOWPOS.x <= workingArea.X + 20)
				{
					wINDOWPOS.x = workingArea.X;
				}
				int num = Screen.GetBounds(Screen.PrimaryScreen.Bounds).Height - workingArea.Height;
				if ((wINDOWPOS.y >= -20 && workingArea.Y > 0 && wINDOWPOS.y <= num + 20) || (workingArea.Y <= 0 && wINDOWPOS.y <= 20))
				{
					if (num > 0)
					{
						wINDOWPOS.y = workingArea.Y;
					}
					else
					{
						wINDOWPOS.y = 0;
					}
				}
				if (wINDOWPOS.x + rectangle.Width <= workingArea.Right + 20 && wINDOWPOS.x + rectangle.Width >= workingArea.Right - 20)
				{
					wINDOWPOS.x = workingArea.Right - (rectangle.Width + SystemInformation.FrameBorderSize.Width);
				}
				if (wINDOWPOS.y + rectangle.Height <= workingArea.Bottom + 20 && wINDOWPOS.y + rectangle.Height >= workingArea.Bottom - 20)
				{
					wINDOWPOS.y = workingArea.Bottom - (rectangle.Height + SystemInformation.FrameBorderSize.Height);
				}
				Marshal.StructureToPtr(wINDOWPOS, LParam, fDeleteOld: true);
			}
			catch (ArgumentException ex)
			{
				ProjectData.SetProjectError(ex);
				ArgumentException ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public void AnimInit(object obj)
	{
		anim_maxcount = checked(base.Width - Panel1.Width);
		anim_count = 0;
		anim_obj = (Panel)obj;
		anim_obj.Width = 0;
	}

	public void Animstart()
	{
		if (Module1.set_animation)
		{
			Timer3.Start();
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectGreaterEqual(anim_count, anim_maxcount, TextCompare: false))
		{
			Timer3.Stop();
			anim_obj = (Panel)anim_maxcount;
		}
		else
		{
			ref object reference = ref anim_count;
			reference = Operators.AddObject(reference, 100);
			anim_obj = (Panel)anim_count;
		}
	}

	private void ListBox1_DrawItem_1(object sender, DrawItemEventArgs e)
	{
		try
		{
			e.DrawBackground();
			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				Brush brush = new SolidBrush(Color.FromArgb(240, 240, 240));
				Rectangle bounds = e.Bounds;
				e.Graphics.FillRectangle(brush, bounds);
				Brush brush2 = new SolidBrush(Color.FromArgb(0, 0, 0));
				Font font = new Font("맑은 고딕", (float)Conversions.ToDouble(Module1.Menu_textSize), FontStyle.Bold, GraphicsUnit.Point, 129);
				Graphics graphics = e.Graphics;
				object[] array = new object[1];
				object obj = sender;
				object instance = obj;
				object[] array2 = new object[1];
				object obj2 = (array2[0] = e.Index);
				array[0] = NewLateBinding.LateGet(instance, null, "Items", array2, null, null, null);
				object[] array3 = array;
				bool[] obj3 = new bool[1] { true };
				bool[] array4 = obj3;
				object obj4 = NewLateBinding.LateGet(sender, null, "GetItemText", array, null, null, obj3);
				if (array4[0])
				{
					NewLateBinding.LateSetComplex(obj, null, "Items", new object[2]
					{
						obj2,
						array3[0]
					}, null, null, OptimisticSet: true, RValueBase: false);
				}
				graphics.DrawString(Conversions.ToString(obj4), font, brush2, bounds);
			}
			else
			{
				Font font2 = new Font("맑은 고딕", (float)Conversions.ToDouble(Module1.Menu_textSize), FontStyle.Regular, GraphicsUnit.Point, 129);
				using SolidBrush brush3 = new SolidBrush(e.ForeColor);
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "Items", new object[1] { e.Index }, null, null, null), null, "trim", new object[0], null, null, null), null, TextCompare: false))
				{
					e.Graphics.DrawString("  -----------------------", font2, brush3, e.Bounds);
					e.DrawFocusRectangle();
				}
				else
				{
					Graphics graphics2 = e.Graphics;
					object[] array5 = new object[1];
					object obj2 = sender;
					object instance2 = obj2;
					object[] array6 = new object[1];
					object obj = (array6[0] = e.Index);
					array5[0] = NewLateBinding.LateGet(instance2, null, "Items", array6, null, null, null);
					object[] array3 = array5;
					bool[] obj5 = new bool[1] { true };
					bool[] array4 = obj5;
					object obj4 = NewLateBinding.LateGet(sender, null, "GetItemText", array5, null, null, obj5);
					if (array4[0])
					{
						NewLateBinding.LateSetComplex(obj2, null, "Items", new object[2]
						{
							obj,
							array3[0]
						}, null, null, OptimisticSet: true, RValueBase: false);
					}
					graphics2.DrawString(Conversions.ToString(obj4), font2, brush3, e.Bounds);
				}
			}
			e.DrawFocusRectangle();
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
		Module1.CMsgboxOption = true;
		CustomMsgBox.CMsgBox("알림창이 다시 표시됩니다.", "복구 완료", "확인", custom_msgbox.CMsgboxColor.DarkGreen, custom_msgbox.CmsgBoxIcon.icon_Exclamation);
		Button1.Hide();
	}

	private void chat_receiver_Tick(object sender, EventArgs e)
	{
		if (CHAT_MAIN_MODULE.CHAT_CLASS.refresh())
		{
			Label5.Text = Conversions.ToString(CHAT_MAIN_MODULE.CHAT_CLASS.getCount());
			if (CHAT_MAIN_MODULE.CHAT_CLASS.getCount() > 0)
			{
				newmessage.Show();
			}
			else
			{
				newmessage.Hide();
			}
		}
		if (!Conversions.ToBoolean(CHAT_MAIN_MODULE.CHAT_CLASS.MessageAlert))
		{
			return;
		}
		CHAT_MAIN_MODULE.CHAT_CLASS.AlertDisable();
		foreach (CHAT.ChatList chat in CHAT_MAIN_MODULE.CHAT_CLASS.GetChatList())
		{
			if (Operators.ConditionalCompareObjectEqual(CHAT_MAIN_MODULE.CHAT_NOWID, chat.id, TextCompare: false))
			{
				MyProject.Forms.CHAT_MAIN.setView();
				continue;
			}
			string[] latestId = CHAT_MAIN_MODULE.CHAT_CLASS.LatestId;
			string text = "";
			text = ((latestId[2].Length <= 80) ? latestId[2].Replace("<br>", " ") : (latestId[2].Substring(0, 80).Replace("<br>", " ") + " . . ."));
			CustomMsgBox.CMsgBox(text, "새 메시지 도착 (" + latestId[1] + ")", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Exclamation, custom_msgbox.ShowLocation.TopRight);
		}
	}

	private void Label4_Click_1(object sender, EventArgs e)
	{
	}

	private void frmclosing()
	{
		CHAT_MAIN_MODULE.CHAT_NOWID = null;
		MyProject.Forms.CHAT_MAIN.Controls.Add(MyProject.Forms.CHAT_MAIN.Panel2);
	}

	[DllImport("urlmon.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long CoInternetSetFeatureEnabled(int FeatureEntry, long dwFlags, long fEnable);

	[DllImport("urlmon.dll", ExactSpelling = true)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	public static extern int CoInternetSetFeatureEnabled(int featureEntry, int dwFlags, bool fEnable);

	private void Panel5_Click(object sender, EventArgs e)
	{
		CoInternetSetFeatureEnabled(21, 2, fEnable: true);
		CHAT_MAIN_MODULE.CHAT_FORM = new Form();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(mlas));
		Form cHAT_FORM = CHAT_MAIN_MODULE.CHAT_FORM;
		cHAT_FORM.Text = "Chat v1.0";
		cHAT_FORM.Controls.Add(MyProject.Forms.CHAT_MAIN.Panel2);
		MyProject.Forms.CHAT_MAIN.Panel2.Dock = DockStyle.Fill;
		cHAT_FORM.FormBorderStyle = FormBorderStyle.None;
		cHAT_FORM.Size = new Size(344, 578);
		cHAT_FORM.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		cHAT_FORM.StartPosition = FormStartPosition.CenterScreen;
		CHAT_MAIN_MODULE.CHAT_NOWID = "microlivire";
		MyProject.Forms.CHAT_MAIN.setView();
		cHAT_FORM.Show();
		MyProject.Forms.CHAT_MAIN.TextBox4.Focus();
		CHAT_MAIN_MODULE.CHAT_FORM.FormClosing += delegate
		{
			frmclosing();
		};
		_ = null;
	}

	private void mlas_MouseMove(object sender, MouseEventArgs e)
	{
		checked
		{
			if (base.WindowState == FormWindowState.Maximized)
			{
				Cursor = Cursors.Default;
			}
			else
			{
				if ((e.X < 10) | (e.Y < 10))
				{
					return;
				}
				if (drag)
				{
					object left = type;
					if (Operators.ConditionalCompareObjectEqual(left, 0, TextCompare: false))
					{
						base.Size = new Size(PointToClient(Control.MousePosition).X, PointToClient(Control.MousePosition).Y);
					}
					else if (Operators.ConditionalCompareObjectEqual(left, 1, TextCompare: false))
					{
						base.Size = new Size(base.Size.Width, PointToClient(Control.MousePosition).Y);
					}
					else if (Operators.ConditionalCompareObjectEqual(left, 2, TextCompare: false))
					{
						base.Size = new Size(PointToClient(Control.MousePosition).X, base.Size.Height);
					}
					FixedFormSize = base.Size;
				}
				else if ((e.X > base.Size.Width - 20) & (e.Y > base.Size.Height - 20))
				{
					Cursor = Cursors.SizeNWSE;
				}
				else if (e.X < base.Size.Width - 20)
				{
					Cursor = Cursors.SizeNS;
				}
				else if (e.Y < base.Size.Height - 20)
				{
					Cursor = Cursors.SizeWE;
				}
				else
				{
					Cursor = Cursors.Default;
				}
			}
		}
	}

	private void mlas_MouseLeave(object sender, EventArgs e)
	{
		Cursor = Cursors.Default;
	}

	private void mlas_MouseDown(object sender, MouseEventArgs e)
	{
		if (base.WindowState == FormWindowState.Maximized)
		{
			Cursor = Cursors.Default;
			return;
		}
		drag = true;
		checked
		{
			if ((e.X < 10) | (e.Y < 10))
			{
				type = -1;
			}
			else if ((e.X > base.Size.Width - 20) & (e.Y > base.Size.Height - 20))
			{
				Cursor = Cursors.SizeNWSE;
				type = 0;
			}
			else if (e.X < base.Size.Width - 20)
			{
				Cursor = Cursors.SizeNS;
				type = 1;
			}
			else if (e.Y < base.Size.Height - 20)
			{
				Cursor = Cursors.SizeWE;
				type = 2;
			}
			else
			{
				type = -1;
			}
		}
	}

	private void mlas_MouseUp(object sender, MouseEventArgs e)
	{
		drag = false;
		Cursor = Cursors.Default;
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		MyProject.Forms.fileManager.Show();
		MyProject.Forms.fileManager.AllowDrop = true;
	}

	private void ssorder_update_checker_Tick(object sender, EventArgs e)
	{
		if (!ssorder.ssorder_update_check || !ssorder.findUpdate())
		{
			return;
		}
		ssorder.ssorder_update_check = false;
		if (MessageBox.Show("새 업데이트가 발견되었습니다!\r\n지금 바로 업데이트를 진행하시겠습니까?\r\n\r\n[확인]을 누르면 프로그램이 종료됩니다.", "자동 업데이트 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.OK)
		{
			return;
		}
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
		Module1.MLAS_logout = true;
		Application.Exit();
	}
}
