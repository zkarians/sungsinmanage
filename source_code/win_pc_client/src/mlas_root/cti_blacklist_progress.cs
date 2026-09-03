using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My.Resources;

namespace mlas_root;

[DesignerGenerated]
public class cti_blacklist_progress : Form
{
	private IContainer components;

	public cti_import parent_form;

	private List<cti_db> ctiDbClass;

	private List<cti_tm_list> fileData;

	private List<cti_tm_list> correctData;

	private int nowDBidx;

	private Thread[] thread;

	private int stackPercent;

	private int z;

	private List<int> indices;

	private object index;

	private List<cti_tm_list> tmlist;

	private int dbCount;

	private object filedataCount;

	private object filedataPercent;

	private int[] logging_time;

	private bool process_finish;

	private int tmpPosition;

	private int processPerSecond;

	private int overtime;

	internal virtual System.Windows.Forms.Timer Timer1
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
			System.Windows.Forms.Timer timer = _Timer1;
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

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar2")]
	internal virtual ProgressBar ProgressBar2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("label_progress1")]
	internal virtual Label label_progress1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("label_progress2")]
	internal virtual Label label_progress2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("label_percent1")]
	internal virtual Label label_percent1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("label_percent2")]
	internal virtual Label label_percent2
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

	internal virtual Button closebtn
	{
		[CompilerGenerated]
		get
		{
			return _closebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = closebtn_Click;
			Button button = _closebtn;
			if (button != null)
			{
				button.Click -= value2;
			}
			_closebtn = value;
			button = _closebtn;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ImageList1")]
	internal virtual ImageList ImageList1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("label_found")]
	internal virtual Label label_found
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("label_filename")]
	internal virtual Label label_filename
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolTip1")]
	internal virtual ToolTip ToolTip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("label_status")]
	internal virtual Label label_status
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

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
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

	public cti_blacklist_progress()
	{
		base.Load += cti_blacklist_progress_Load;
		base.FormClosed += cti_blacklist_progress_FormClosed;
		base.FormClosing += cti_blacklist_progress_FormClosing;
		nowDBidx = 0;
		thread = new Thread[6];
		stackPercent = 0;
		z = 0;
		indices = new List<int>();
		logging_time = new int[3];
		process_finish = false;
		tmpPosition = 0;
		processPerSecond = 0;
		overtime = 0;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.cti_blacklist_progress));
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
		this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
		this.label_progress1 = new System.Windows.Forms.Label();
		this.label_progress2 = new System.Windows.Forms.Label();
		this.label_percent1 = new System.Windows.Forms.Label();
		this.label_percent2 = new System.Windows.Forms.Label();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.label_found = new System.Windows.Forms.Label();
		this.label_filename = new System.Windows.Forms.Label();
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.closebtn = new System.Windows.Forms.Button();
		this.label_status = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.ProgressBar1.Location = new System.Drawing.Point(156, 81);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new System.Drawing.Size(366, 15);
		this.ProgressBar1.Step = 1;
		this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
		this.ProgressBar1.TabIndex = 2;
		this.ProgressBar2.Location = new System.Drawing.Point(156, 147);
		this.ProgressBar2.Name = "ProgressBar2";
		this.ProgressBar2.Size = new System.Drawing.Size(366, 15);
		this.ProgressBar2.Step = 1;
		this.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
		this.ProgressBar2.TabIndex = 3;
		this.label_progress1.Location = new System.Drawing.Point(154, 66);
		this.label_progress1.Name = "label_progress1";
		this.label_progress1.Size = new System.Drawing.Size(333, 12);
		this.label_progress1.TabIndex = 4;
		this.label_progress1.Text = "전체 진행도";
		this.label_progress2.Location = new System.Drawing.Point(154, 132);
		this.label_progress2.Name = "label_progress2";
		this.label_progress2.Size = new System.Drawing.Size(333, 12);
		this.label_progress2.TabIndex = 5;
		this.label_progress2.Text = "현재 레코드 위치 (0/0)";
		this.label_percent1.Location = new System.Drawing.Point(480, 66);
		this.label_percent1.Name = "label_percent1";
		this.label_percent1.Size = new System.Drawing.Size(42, 12);
		this.label_percent1.TabIndex = 6;
		this.label_percent1.Text = "0%";
		this.label_percent1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label_percent2.Location = new System.Drawing.Point(480, 132);
		this.label_percent2.Name = "label_percent2";
		this.label_percent2.Size = new System.Drawing.Size(42, 12);
		this.label_percent2.TabIndex = 7;
		this.label_percent2.Text = "0%";
		this.label_percent2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.ImageList1.Images.SetKeyName(0, "Buy.png");
		this.ImageList1.Images.SetKeyName(1, "Hungup.png");
		this.ImageList1.Images.SetKeyName(2, "Save.png");
		this.ImageList1.Images.SetKeyName(3, "Shopping cart.png");
		this.ImageList1.Images.SetKeyName(4, "delete_new.png");
		this.ImageList1.Images.SetKeyName(5, "Dial.png");
		this.ImageList1.Images.SetKeyName(6, "Report.png");
		this.label_found.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.label_found.Location = new System.Drawing.Point(187, 34);
		this.label_found.Name = "label_found";
		this.label_found.Size = new System.Drawing.Size(233, 12);
		this.label_found.TabIndex = 33;
		this.label_found.Text = "일치하는 레코드 0개 발견.";
		this.label_filename.Location = new System.Drawing.Point(187, 18);
		this.label_filename.Name = "label_filename";
		this.label_filename.Size = new System.Drawing.Size(233, 12);
		this.label_filename.TabIndex = 34;
		this.label_filename.Text = "대상: ";
		this.closebtn.Image = mlas_root.My.Resources.Resources.Stop_sign;
		this.closebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.closebtn.Location = new System.Drawing.Point(431, 16);
		this.closebtn.Name = "closebtn";
		this.closebtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
		this.closebtn.Size = new System.Drawing.Size(91, 34);
		this.closebtn.TabIndex = 9999;
		this.closebtn.Text = "중단";
		this.closebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.ToolTip1.SetToolTip(this.closebtn, "작업을 중단합니다.");
		this.closebtn.UseVisualStyleBackColor = true;
		this.label_status.Dock = System.Windows.Forms.DockStyle.Left;
		this.label_status.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.label_status.Location = new System.Drawing.Point(0, 0);
		this.label_status.Name = "label_status";
		this.label_status.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
		this.label_status.Size = new System.Drawing.Size(407, 28);
		this.label_status.TabIndex = 36;
		this.label_status.Text = "레코드 정리하는 중...";
		this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Label1.Dock = System.Windows.Forms.DockStyle.Right;
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(413, 0);
		this.Label1.Name = "Label1";
		this.Label1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
		this.Label1.Size = new System.Drawing.Size(123, 28);
		this.Label1.TabIndex = 37;
		this.Label1.Text = "진행시간 00:00:00";
		this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.PictureBox2.Image = mlas_root.My.Resources.Resources.blacklist_new;
		this.PictureBox2.Location = new System.Drawing.Point(156, 15);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(29, 34);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.PictureBox2.TabIndex = 35;
		this.PictureBox2.TabStop = false;
		this.PictureBox1.Image = mlas_root.My.Resources.Resources.loading_animation2;
		this.PictureBox1.Location = new System.Drawing.Point(1, 10);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(147, 165);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.PictureBox1.TabIndex = 8;
		this.PictureBox1.TabStop = false;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(154, 101);
		this.Label2.Name = "Label2";
		this.Label2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
		this.Label2.Size = new System.Drawing.Size(123, 12);
		this.Label2.TabIndex = 38;
		this.Label2.Text = "남은 시간 계산 중...";
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Controls.Add(this.label_status);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 185);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(536, 28);
		this.Panel1.TabIndex = 39;
		this.Panel2.BackColor = System.Drawing.Color.Gainsboro;
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 184);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(536, 1);
		this.Panel2.TabIndex = 40;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(536, 213);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.PictureBox2);
		base.Controls.Add(this.label_filename);
		base.Controls.Add(this.label_found);
		base.Controls.Add(this.closebtn);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.label_percent2);
		base.Controls.Add(this.label_percent1);
		base.Controls.Add(this.label_progress2);
		base.Controls.Add(this.label_progress1);
		base.Controls.Add(this.ProgressBar2);
		base.Controls.Add(this.ProgressBar1);
		this.Cursor = System.Windows.Forms.Cursors.Arrow;
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		this.MinimumSize = new System.Drawing.Size(548, 206);
		base.Name = "cti_blacklist_progress";
		base.ShowIcon = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "데이터 필터링 진행 중...";
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void cti_blacklist_progress_Load(object sender, EventArgs e)
	{
		fileData = parent_form.ctiTMList;
		ctiDbClass = new List<cti_db>();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)parent_form.blacklist_grid.Rows).GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				if (Conversions.ToBoolean(((DataGridViewCheckBoxCell)dataGridViewRow.Cells[1]).Value))
				{
					ctiDbClass.Add(new cti_db(Conversions.ToInteger(dataGridViewRow.Cells[0].Value.ToString()), dataGridViewRow.Cells[2].Value.ToString(), Conversions.ToInteger(dataGridViewRow.Cells[3].Value.ToString())));
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
		stackPercent = 0;
		nowDBidx = 0;
		correctData = new List<cti_tm_list>();
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = parent_form.indices.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
				indices.Add(Conversions.ToInteger(objectValue));
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
		index = parent_form.selectIndex;
		label_filename.Text = "대상: " + parent_form.dbName;
		thread[0] = new Thread(thr);
		thread[0].Start();
		Label1.Focus();
	}

	private void thr()
	{
		dbCount = ctiDbClass.Count;
		checked
		{
			foreach (cti_db item in ctiDbClass)
			{
				nowDBidx++;
				label_progress1.Text = "전체 진행도 (" + Conversions.ToString(nowDBidx) + "/" + Conversions.ToString(ctiDbClass.Count) + ") [비교: " + item.name + "]";
				label_progress2.Text = "현재 레코드 위치 (" + Conversions.ToString(0) + "/" + Conversions.ToString(fileData.Count) + ")";
				label_status.Text = "블랙리스트 데이터베이스를 불러오는 중...";
				tmlist = item.ExportReport(this);
				label_status.Text = "데이터 필터링 프로세스 실행 중...";
				filedataCount = fileData.Count;
				filedataPercent = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Ceiling", new object[1] { Operators.MultiplyObject(Operators.DivideObject(z, filedataCount), 100) }, null, null, null));
				thread[1] = new Thread(mainthr);
				thread[1].Start();
				thread[1].Join();
				stackPercent += z;
				z = 0;
				tmpPosition = 0;
			}
			process_finish = true;
			parent_form.correctData = correctData;
			base.DialogResult = DialogResult.OK;
		}
	}

	private void mainthr()
	{
		checked
		{
			_Closure_0024__98_002D0 closure_0024__98_002D = default(_Closure_0024__98_002D0);
			while (z < fileData.Count)
			{
				closure_0024__98_002D = new _Closure_0024__98_002D0(closure_0024__98_002D);
				closure_0024__98_002D._0024VB_0024Local_b = fileData[z];
				foreach (cti_tm_list item in tmlist)
				{
					int num = 0;
					bool flag = false;
					using (List<int>.Enumerator enumerator2 = indices.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							switch (enumerator2.Current)
							{
							case 0:
								if (closure_0024__98_002D._0024VB_0024Local_b.name == null)
								{
									continue;
								}
								if (closure_0024__98_002D._0024VB_0024Local_b.name.Equals(item.name))
								{
									num++;
								}
								break;
							case 1:
								if (closure_0024__98_002D._0024VB_0024Local_b.phone_number == null)
								{
									continue;
								}
								if (closure_0024__98_002D._0024VB_0024Local_b.phone_number.Equals(item.phone_number))
								{
									num++;
								}
								break;
							case 2:
								if (closure_0024__98_002D._0024VB_0024Local_b.home_number == null)
								{
									continue;
								}
								if (closure_0024__98_002D._0024VB_0024Local_b.home_number.Equals(item.home_number))
								{
									num++;
								}
								break;
							case 3:
								if (closure_0024__98_002D._0024VB_0024Local_b.address == null)
								{
									continue;
								}
								if (closure_0024__98_002D._0024VB_0024Local_b.address.Equals(item.address))
								{
									num++;
								}
								break;
							case 4:
								if (closure_0024__98_002D._0024VB_0024Local_b.product_name == null)
								{
									continue;
								}
								if (closure_0024__98_002D._0024VB_0024Local_b.product_name.Equals(item.product_name))
								{
									num++;
								}
								break;
							case 5:
								if (closure_0024__98_002D._0024VB_0024Local_b.seller == null)
								{
									continue;
								}
								if (closure_0024__98_002D._0024VB_0024Local_b.seller.Equals(item.seller))
								{
									num++;
								}
								break;
							case 6:
								if (!closure_0024__98_002D._0024VB_0024Local_b.price.HasValue)
								{
									continue;
								}
								if (closure_0024__98_002D._0024VB_0024Local_b.price.Equals(item.price))
								{
									num++;
								}
								break;
							case 7:
								if (closure_0024__98_002D._0024VB_0024Local_b.comment == null)
								{
									continue;
								}
								if (closure_0024__98_002D._0024VB_0024Local_b.comment.Equals(item.comment))
								{
									num++;
								}
								break;
							case 8:
								if (closure_0024__98_002D._0024VB_0024Local_b.comment2 == null)
								{
									continue;
								}
								if (closure_0024__98_002D._0024VB_0024Local_b.comment2.Equals(item.comment2))
								{
									num++;
								}
								break;
							}
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(num, Operators.AddObject(index, 1), TextCompare: false), Operators.NotObject(Operators.CompareObjectEqual(index, 6, TextCompare: false)))))
							{
								flag = true;
								break;
							}
							if (Operators.ConditionalCompareObjectEqual(index, 6, TextCompare: false) && num >= indices.Count)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						continue;
					}
					if (correctData.Find((closure_0024__98_002D._0024I0 == null) ? (closure_0024__98_002D._0024I0 = closure_0024__98_002D._Lambda_0024__0) : closure_0024__98_002D._0024I0) == null)
					{
						correctData.Add(closure_0024__98_002D._0024VB_0024Local_b);
						try
						{
							label_found.Text = "일치하는 레코드 " + Conversions.ToString(correctData.Count) + "개 발견.";
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
					break;
				}
				try
				{
					ProgressBar1.Value = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Math), "Ceiling", new object[1] { Operators.MultiplyObject(Operators.DivideObject(stackPercent + z, Operators.MultiplyObject(filedataCount, dbCount)), 100) }, null, null, null));
					label_percent1.Text = Conversions.ToString(ProgressBar1.Value) + "%";
					filedataPercent = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Ceiling", new object[1] { Operators.MultiplyObject(Operators.DivideObject(z, filedataCount), 100) }, null, null, null));
					ProgressBar2.Value = Conversions.ToInteger(filedataPercent);
					label_progress2.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("현재 레코드 위치 (" + Conversions.ToString(z) + "/", filedataCount), ") ["), processPerSecond), "/초당] "));
					label_percent2.Text = Conversions.ToString(Operators.ConcatenateObject(filedataPercent, "%"));
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				z++;
			}
		}
	}

	private void closebtn_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("작업 내용을 잃게됩니다. 정말 중단하시겠습니까?", "작업 중단", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.OK)
		{
			try
			{
				thread[0].Abort();
				thread[1].Abort();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			base.DialogResult = DialogResult.Cancel;
			Dispose();
		}
	}

	private void cti_blacklist_progress_FormClosed(object sender, FormClosedEventArgs e)
	{
		Dispose();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			logging_time[2]++;
			if (logging_time[2] == 60)
			{
				logging_time[2] = 0;
				logging_time[1]++;
			}
			if (logging_time[1] == 60)
			{
				logging_time[1] = 0;
				logging_time[0]++;
			}
			processPerSecond = z - tmpPosition;
			tmpPosition = z;
			Label1.Text = string.Format("진행시간 {2:00}:{1:00}:{0:00}", logging_time[2], logging_time[1], logging_time[0]);
			try
			{
				TimeSpan timeSpan = TimeSpan.FromSeconds(Conversions.ToDouble(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Ceiling", new object[1] { Operators.DivideObject(Operators.SubtractObject(Operators.MultiplyObject(filedataCount, ctiDbClass.Count), stackPercent + z), processPerSecond) }, null, null, null))));
				object right = ((timeSpan.Hours == 0) ? "" : (timeSpan.Hours.ToString().PadLeft(2, '0') + "시간 "));
				object right2 = ((timeSpan.Minutes == 0) ? "" : (timeSpan.Minutes.ToString().PadLeft(2, '0') + "분 "));
				object right3 = timeSpan.Seconds.ToString().PadLeft(2, '0');
				object obj = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("약 ", right), right2), right3), "초 남음");
				Label2.Text = Conversions.ToString(obj);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void cti_blacklist_progress_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!process_finish)
		{
			e.Cancel = true;
		}
	}
}
