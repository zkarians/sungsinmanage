using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
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
public class ssorder_cti : Form
{
	private IContainer components;

	public cti_db selectDb;

	private List<TabPage> tabPages;

	private bool agentLogin;

	private object busy;

	public List<cti_agents> ctiAgents;

	public List<cti_db> ctiDbClass;

	private object default_directory;

	public Form AgentSelectDiag;

	private DataGridView nowDatagridView;

	private object isProductPageInit;

	public object page_busy;

	private object logging_in;

	private int tmpIdx;

	private int current_page;

	private int[] logging_time;

	private GetHtmlClass pushHtmlClass;

	private string pushPostData;

	private Form cbox;

	private bool agent_breakTime;

	private DataGridView nowtable;

	private object callLogType;

	private object idletime;

	private cti_agents selectAgent;

	internal virtual TabControl TabControl1
	{
		[CompilerGenerated]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TabControl1_SelectedIndexChanged;
			TabControl tabControl = _TabControl1;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged -= value2;
			}
			_TabControl1 = value;
			tabControl = _TabControl1;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage4")]
	internal virtual TabPage TabPage4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ImageList1")]
	internal virtual ImageList ImageList1
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

	internal virtual Button agent_delete
	{
		[CompilerGenerated]
		get
		{
			return _agent_delete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = agent_delete_Click;
			Button button = _agent_delete;
			if (button != null)
			{
				button.Click -= value2;
			}
			_agent_delete = value;
			button = _agent_delete;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button agent_reset
	{
		[CompilerGenerated]
		get
		{
			return _agent_reset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = agent_reset_Click;
			Button button = _agent_reset;
			if (button != null)
			{
				button.Click -= value2;
			}
			_agent_reset = value;
			button = _agent_reset;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button agent_add
	{
		[CompilerGenerated]
		get
		{
			return _agent_add;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = agent_add_Click;
			Button button = _agent_add;
			if (button != null)
			{
				button.Click -= value2;
			}
			_agent_add = value;
			button = _agent_add;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	internal virtual DataGridView db_grid
	{
		[CompilerGenerated]
		get
		{
			return _db_grid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = db_grid_CellClick;
			DataGridViewCellEventHandler value3 = db_grid_CellDoubleClick;
			DataGridView dataGridView = _db_grid;
			if (dataGridView != null)
			{
				dataGridView.CellClick -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_db_grid = value;
			dataGridView = _db_grid;
			if (dataGridView != null)
			{
				dataGridView.CellClick += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("table_grid")]
	internal virtual DataGridView table_grid
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton db_add
	{
		[CompilerGenerated]
		get
		{
			return _db_add;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_add_Click;
			ToolStripButton toolStripButton = _db_add;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_add = value;
			toolStripButton = _db_add;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton db_get_data
	{
		[CompilerGenerated]
		get
		{
			return _db_get_data;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_get_data_Click;
			ToolStripButton toolStripButton = _db_get_data;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_get_data = value;
			toolStripButton = _db_get_data;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton db_delete
	{
		[CompilerGenerated]
		get
		{
			return _db_delete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_delete_Click;
			ToolStripButton toolStripButton = _db_delete;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_delete = value;
			toolStripButton = _db_delete;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator2")]
	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton db_start_stop
	{
		[CompilerGenerated]
		get
		{
			return _db_start_stop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_start_stop_Click;
			ToolStripButton toolStripButton = _db_start_stop;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_start_stop = value;
			toolStripButton = _db_start_stop;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator5")]
	internal virtual ToolStripSeparator ToolStripSeparator5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton db_auto_split
	{
		[CompilerGenerated]
		get
		{
			return _db_auto_split;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_auto_split_Click;
			ToolStripButton toolStripButton = _db_auto_split;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_auto_split = value;
			toolStripButton = _db_auto_split;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton db_split
	{
		[CompilerGenerated]
		get
		{
			return _db_split;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_split_Click;
			ToolStripButton toolStripButton = _db_split;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_split = value;
			toolStripButton = _db_split;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton db_restore
	{
		[CompilerGenerated]
		get
		{
			return _db_restore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_restore_Click;
			ToolStripButton toolStripButton = _db_restore;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_restore = value;
			toolStripButton = _db_restore;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator6")]
	internal virtual ToolStripSeparator ToolStripSeparator6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton db_output
	{
		[CompilerGenerated]
		get
		{
			return _db_output;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_output_Click;
			ToolStripButton toolStripButton = _db_output;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_output = value;
			toolStripButton = _db_output;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton db_agree_output
	{
		[CompilerGenerated]
		get
		{
			return _db_agree_output;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_agree_output_Click;
			ToolStripButton toolStripButton = _db_agree_output;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_agree_output = value;
			toolStripButton = _db_agree_output;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ContextMenuStrip1")]
	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem cmenu_new
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_new;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cmenu_new_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_new;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_new = value;
			toolStripMenuItem = _cmenu_new;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem cmenu_import
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_import;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cmenu_import_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_import;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_import = value;
			toolStripMenuItem = _cmenu_import;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem cmenu_delete
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_delete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cmenu_delete_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_delete;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_delete = value;
			toolStripMenuItem = _cmenu_delete;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator7")]
	internal virtual ToolStripSeparator ToolStripSeparator7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem cmenu_start
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_start;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cmenu_start_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_start;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_start = value;
			toolStripMenuItem = _cmenu_start;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem cmenu_stop
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_stop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cmenu_stop_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_stop;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_stop = value;
			toolStripMenuItem = _cmenu_stop;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator8")]
	internal virtual ToolStripSeparator ToolStripSeparator8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cmenu_auto")]
	internal virtual ToolStripMenuItem cmenu_auto
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem cmenu_split
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_split;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripMenuItem8_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_split;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_split = value;
			toolStripMenuItem = _cmenu_split;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem cmenu_restore
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_restore;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cmenu_restore_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_restore;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_restore = value;
			toolStripMenuItem = _cmenu_restore;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator9")]
	internal virtual ToolStripSeparator ToolStripSeparator9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem cmenu_output
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_output;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cmenu_output_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_output;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_output = value;
			toolStripMenuItem = _cmenu_output;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem cmenu_agree_output
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_agree_output;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cmenu_agree_output_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_agree_output;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_agree_output = value;
			toolStripMenuItem = _cmenu_agree_output;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem cmenu_save
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_save;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cmenu_save_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_save;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_save = value;
			toolStripMenuItem = _cmenu_save;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton db_save
	{
		[CompilerGenerated]
		get
		{
			return _db_save;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_save_Click;
			ToolStripButton toolStripButton = _db_save;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_save = value;
			toolStripButton = _db_save;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton db_back
	{
		[CompilerGenerated]
		get
		{
			return _db_back;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_back_Click;
			ToolStripButton toolStripButton = _db_back;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_back = value;
			toolStripButton = _db_back;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewImageColumn1")]
	internal virtual DataGridViewImageColumn DataGridViewImageColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView agents_grid
	{
		[CompilerGenerated]
		get
		{
			return _agents_grid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewRowsAddedEventHandler value2 = agents_grid_RowsAdded;
			DataGridViewCellEventHandler value3 = agents_grid_CellClick;
			EventHandler value4 = agents_grid_SelectionChanged;
			DataGridView dataGridView = _agents_grid;
			if (dataGridView != null)
			{
				dataGridView.RowsAdded -= value2;
				dataGridView.CellClick -= value3;
				dataGridView.SelectionChanged -= value4;
			}
			_agents_grid = value;
			dataGridView = _agents_grid;
			if (dataGridView != null)
			{
				dataGridView.RowsAdded += value2;
				dataGridView.CellClick += value3;
				dataGridView.SelectionChanged += value4;
			}
		}
	}

	[field: AccessedThroughProperty("bottomBar")]
	internal virtual StatusStrip bottomBar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dbName")]
	internal virtual ToolStripStatusLabel dbName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel5")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("db_status")]
	internal virtual ToolStripStatusLabel db_status
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator3")]
	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator4")]
	internal virtual ToolStripSeparator ToolStripSeparator4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ContextMenuStrip ContextMenuStrip2
	{
		[CompilerGenerated]
		get
		{
			return _ContextMenuStrip2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ToolStripItemClickedEventHandler value2 = ContextMenuStrip2_ItemClicked;
			ContextMenuStrip contextMenuStrip = _ContextMenuStrip2;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.ItemClicked -= value2;
			}
			_ContextMenuStrip2 = value;
			contextMenuStrip = _ContextMenuStrip2;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.ItemClicked += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel1")]
	internal virtual DoubleBufferPanel DoubleBufferPanel1
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

	internal virtual ComboBoxEx ComboBoxEx1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBoxEx1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBoxEx1_SelectedIndexChanged;
			ComboBoxEx comboBoxEx = _ComboBoxEx1;
			if (comboBoxEx != null)
			{
				comboBoxEx.SelectedIndexChanged -= value2;
			}
			_ComboBoxEx1 = value;
			comboBoxEx = _ComboBoxEx1;
			if (comboBoxEx != null)
			{
				comboBoxEx.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ContextMenuStrip3")]
	internal virtual ContextMenuStrip ContextMenuStrip3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 모든상담사배정ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _모든상담사배정ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 모든상담사배정ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _모든상담사배정ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_모든상담사배정ToolStripMenuItem = value;
			toolStripMenuItem = _모든상담사배정ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 로그인상담사배정ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _로그인상담사배정ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 로그인상담사배정ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _로그인상담사배정ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_로그인상담사배정ToolStripMenuItem = value;
			toolStripMenuItem = _로그인상담사배정ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 모든상담원에게배분ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _모든상담원에게배분ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 모든상담원에게배분ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _모든상담원에게배분ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_모든상담원에게배분ToolStripMenuItem = value;
			toolStripMenuItem = _모든상담원에게배분ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 접속중인상담원에게만배분ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _접속중인상담원에게만배분ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 접속중인상담원에게만배분ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _접속중인상담원에게만배분ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_접속중인상담원에게만배분ToolStripMenuItem = value;
			toolStripMenuItem = _접속중인상담원에게만배분ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator10")]
	internal virtual ToolStripSeparator ToolStripSeparator10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 접속중인상담원에게만강제배분ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _접속중인상담원에게만강제배분ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 접속중인상담원에게만강제배분ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _접속중인상담원에게만강제배분ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_접속중인상담원에게만강제배분ToolStripMenuItem = value;
			toolStripMenuItem = _접속중인상담원에게만강제배분ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator11")]
	internal virtual ToolStripSeparator ToolStripSeparator11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 강제배분ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _강제배분ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 강제배분ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _강제배분ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_강제배분ToolStripMenuItem = value;
			toolStripMenuItem = _강제배분ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ImageList2")]
	internal virtual ImageList ImageList2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("agentpanel")]
	internal virtual Panel agentpanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel5")]
	internal virtual Panel Panel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TabControl TabControl2
	{
		[CompilerGenerated]
		get
		{
			return _TabControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TabControl2_SelectedIndexChanged;
			MouseEventHandler value3 = ssorder_cti_MouseMove;
			TabControl tabControl = _TabControl2;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged -= value2;
				tabControl.MouseMove -= value3;
			}
			_TabControl2 = value;
			tabControl = _TabControl2;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged += value2;
				tabControl.MouseMove += value3;
			}
		}
	}

	[field: AccessedThroughProperty("tm1")]
	internal virtual TabPage tm1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tm2")]
	internal virtual TabPage tm2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tm3")]
	internal virtual TabPage tm3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tm5")]
	internal virtual TabPage tm5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tm6")]
	internal virtual TabPage tm6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Panel Panel4
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
			MouseEventHandler value2 = ssorder_cti_MouseMove;
			Panel panel = _Panel4;
			if (panel != null)
			{
				panel.MouseMove -= value2;
			}
			_Panel4 = value;
			panel = _Panel4;
			if (panel != null)
			{
				panel.MouseMove += value2;
			}
		}
	}

	internal virtual DoubleBufferPanel DoubleBufferPanel3
	{
		[CompilerGenerated]
		get
		{
			return _DoubleBufferPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ssorder_cti_MouseMove;
			DoubleBufferPanel doubleBufferPanel = _DoubleBufferPanel3;
			if (doubleBufferPanel != null)
			{
				doubleBufferPanel.MouseMove -= value2;
			}
			_DoubleBufferPanel3 = value;
			doubleBufferPanel = _DoubleBufferPanel3;
			if (doubleBufferPanel != null)
			{
				doubleBufferPanel.MouseMove += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged -= value2;
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("statusLabel")]
	internal virtual ToolStripStatusLabel statusLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripStatusLabel2")]
	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("selectDBLabel")]
	internal virtual ToolStripStatusLabel selectDBLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("timeLabel")]
	internal virtual ToolStripStatusLabel timeLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("miniToolStrip")]
	internal virtual StatusStrip miniToolStrip
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

	internal virtual Timer time
	{
		[CompilerGenerated]
		get
		{
			return _time;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = time_Tick;
			Timer timer = _time;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_time = value;
			timer = _time;
			if (timer != null)
			{
				timer.Tick += value2;
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

	internal virtual DataGridView tm_grid_all
	{
		[CompilerGenerated]
		get
		{
			return _tm_grid_all;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ssorder_cti_MouseMove;
			DataGridViewCellEventHandler value3 = tm_grid_all_CellDoubleClick;
			DataGridView dataGridView = _tm_grid_all;
			if (dataGridView != null)
			{
				dataGridView.MouseMove -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_tm_grid_all = value;
			dataGridView = _tm_grid_all;
			if (dataGridView != null)
			{
				dataGridView.MouseMove += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DoubleBufferPanel2")]
	internal virtual DoubleBufferPanel DoubleBufferPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button6
	{
		[CompilerGenerated]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button6_Click;
			Button button = _Button6;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button6 = value;
			button = _Button6;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button Button7
	{
		[CompilerGenerated]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Button7_Click;
			Button button = _Button7;
			if (button != null)
			{
				button.Click -= value2;
			}
			_Button7 = value;
			button = _Button7;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBoxEx ComboBoxEx2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBoxEx2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ComboBoxEx2_SelectedIndexChanged;
			ComboBoxEx comboBoxEx = _ComboBoxEx2;
			if (comboBoxEx != null)
			{
				comboBoxEx.SelectedIndexChanged -= value2;
			}
			_ComboBoxEx2 = value;
			comboBoxEx = _ComboBoxEx2;
			if (comboBoxEx != null)
			{
				comboBoxEx.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual DataGridView tm_grid_call_log
	{
		[CompilerGenerated]
		get
		{
			return _tm_grid_call_log;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ssorder_cti_MouseMove;
			DataGridViewCellEventHandler value3 = tm_grid_all_CellDoubleClick;
			DataGridView dataGridView = _tm_grid_call_log;
			if (dataGridView != null)
			{
				dataGridView.MouseMove -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_tm_grid_call_log = value;
			dataGridView = _tm_grid_call_log;
			if (dataGridView != null)
			{
				dataGridView.MouseMove += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn44")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn44
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn43")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn43
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn42")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn42
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn41")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn41
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn40")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn40
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn39")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn39
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn38")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn38
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn37")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn37
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView tm_grid_calling
	{
		[CompilerGenerated]
		get
		{
			return _tm_grid_calling;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ssorder_cti_MouseMove;
			DataGridViewCellEventHandler value3 = tm_grid_all_CellDoubleClick;
			DataGridView dataGridView = _tm_grid_calling;
			if (dataGridView != null)
			{
				dataGridView.MouseMove -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_tm_grid_calling = value;
			dataGridView = _tm_grid_calling;
			if (dataGridView != null)
			{
				dataGridView.MouseMove += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn61")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn61
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn62")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn62
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn63")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn63
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn64")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn64
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn65")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn65
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn66")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn66
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn67")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn67
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn68")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn68
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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

	[field: AccessedThroughProperty("ToolTip1")]
	internal virtual ToolTip ToolTip1
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

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn14")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14
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

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn17")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column5")]
	internal virtual DataGridViewTextBoxColumn Column5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column6")]
	internal virtual DataGridViewTextBoxColumn Column6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 새로고침ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _새로고침ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 새로고침ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _새로고침ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_새로고침ToolStripMenuItem = value;
			toolStripMenuItem = _새로고침ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton db_refresh
	{
		[CompilerGenerated]
		get
		{
			return _db_refresh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_refresh_Click;
			ToolStripButton toolStripButton = _db_refresh;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_refresh = value;
			toolStripButton = _db_refresh;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 배분량선택ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _배분량선택ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 배분량선택ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _배분량선택ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_배분량선택ToolStripMenuItem = value;
			toolStripMenuItem = _배분량선택ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator12")]
	internal virtual ToolStripSeparator ToolStripSeparator12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 사용자정의ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _사용자정의ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 사용자정의ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _사용자정의ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_사용자정의ToolStripMenuItem = value;
			toolStripMenuItem = _사용자정의ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator13")]
	internal virtual ToolStripSeparator ToolStripSeparator13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator14")]
	internal virtual ToolStripSeparator ToolStripSeparator14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton db_settings
	{
		[CompilerGenerated]
		get
		{
			return _db_settings;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripButton1_Click;
			ToolStripButton toolStripButton = _db_settings;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_settings = value;
			toolStripButton = _db_settings;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ContextMenuStrip4")]
	internal virtual ContextMenuStrip ContextMenuStrip4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem 미처리회수ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _미처리회수ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 미처리회수ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _미처리회수ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_미처리회수ToolStripMenuItem = value;
			toolStripMenuItem = _미처리회수ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 일괄회수ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _일괄회수ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 일괄회수ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _일괄회수ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_일괄회수ToolStripMenuItem = value;
			toolStripMenuItem = _일괄회수ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 일괄회수ToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _일괄회수ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 일괄회수ToolStripMenuItem1_Click;
			ToolStripMenuItem toolStripMenuItem = _일괄회수ToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_일괄회수ToolStripMenuItem1 = value;
			toolStripMenuItem = _일괄회수ToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem 미처리항목일괄회수ToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _미처리항목일괄회수ToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 미처리항목일괄회수ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _미처리항목일괄회수ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_미처리항목일괄회수ToolStripMenuItem = value;
			toolStripMenuItem = _미처리항목일괄회수ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton db_blacklist
	{
		[CompilerGenerated]
		get
		{
			return _db_blacklist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripButton2_Click;
			ToolStripButton toolStripButton = _db_blacklist;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_blacklist = value;
			toolStripButton = _db_blacklist;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage5")]
	internal virtual TabPage TabPage5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView tm_grid_miss
	{
		[CompilerGenerated]
		get
		{
			return _tm_grid_miss;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ssorder_cti_MouseMove;
			DataGridViewCellEventHandler value3 = tm_grid_all_CellDoubleClick;
			DataGridView dataGridView = _tm_grid_miss;
			if (dataGridView != null)
			{
				dataGridView.MouseMove -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_tm_grid_miss = value;
			dataGridView = _tm_grid_miss;
			if (dataGridView != null)
			{
				dataGridView.MouseMove += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	internal virtual DataGridView tm_grid_call_out
	{
		[CompilerGenerated]
		get
		{
			return _tm_grid_call_out;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ssorder_cti_MouseMove;
			DataGridViewCellEventHandler value3 = tm_grid_all_CellDoubleClick;
			DataGridView dataGridView = _tm_grid_call_out;
			if (dataGridView != null)
			{
				dataGridView.MouseMove -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_tm_grid_call_out = value;
			dataGridView = _tm_grid_call_out;
			if (dataGridView != null)
			{
				dataGridView.MouseMove += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	internal virtual DataGridView tm_grid_agree
	{
		[CompilerGenerated]
		get
		{
			return _tm_grid_agree;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ssorder_cti_MouseMove;
			DataGridViewCellEventHandler value3 = tm_grid_all_CellDoubleClick;
			DataGridView dataGridView = _tm_grid_agree;
			if (dataGridView != null)
			{
				dataGridView.MouseMove -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_tm_grid_agree = value;
			dataGridView = _tm_grid_agree;
			if (dataGridView != null)
			{
				dataGridView.MouseMove += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	internal virtual DataGridView tm_grid_reserve
	{
		[CompilerGenerated]
		get
		{
			return _tm_grid_reserve;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ssorder_cti_MouseMove;
			DataGridViewCellEventHandler value3 = tm_grid_all_CellDoubleClick;
			DataGridView dataGridView = _tm_grid_reserve;
			if (dataGridView != null)
			{
				dataGridView.MouseMove -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_tm_grid_reserve = value;
			dataGridView = _tm_grid_reserve;
			if (dataGridView != null)
			{
				dataGridView.MouseMove += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Column4")]
	internal virtual DataGridViewTextBoxColumn Column4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("c1")]
	internal virtual DataGridViewTextBoxColumn c1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("c2")]
	internal virtual DataGridViewTextBoxColumn c2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("c7")]
	internal virtual DataGridViewTextBoxColumn c7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("c6")]
	internal virtual DataGridViewTextBoxColumn c6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("c8")]
	internal virtual DataGridViewTextBoxColumn c8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("c3")]
	internal virtual DataGridViewTextBoxColumn c3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("c4")]
	internal virtual DataGridViewTextBoxColumn c4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("c5")]
	internal virtual DataGridViewTextBoxColumn c5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column10")]
	internal virtual DataGridViewTextBoxColumn Column10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column11")]
	internal virtual DataGridViewTextBoxColumn Column11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton db_filter
	{
		[CompilerGenerated]
		get
		{
			return _db_filter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = ToolStripButton3_Click;
			ToolStripButton toolStripButton = _db_filter;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_filter = value;
			toolStripButton = _db_filter;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem cmenu_filter
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_filter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 블랙리스트필터ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_filter;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_filter = value;
			toolStripMenuItem = _cmenu_filter;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator15")]
	internal virtual ToolStripSeparator ToolStripSeparator15
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

	[field: AccessedThroughProperty("TabPage6")]
	internal virtual TabPage TabPage6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView tm_grid_blacklist
	{
		[CompilerGenerated]
		get
		{
			return _tm_grid_blacklist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			MouseEventHandler value2 = ssorder_cti_MouseMove;
			DataGridViewCellEventHandler value3 = tm_grid_all_CellDoubleClick;
			DataGridView dataGridView = _tm_grid_blacklist;
			if (dataGridView != null)
			{
				dataGridView.MouseMove -= value2;
				dataGridView.CellDoubleClick -= value3;
			}
			_tm_grid_blacklist = value;
			dataGridView = _tm_grid_blacklist;
			if (dataGridView != null)
			{
				dataGridView.MouseMove += value2;
				dataGridView.CellDoubleClick += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewImageColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn1")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn2")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column7")]
	internal virtual DataGridViewTextBoxColumn Column7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn5")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn8")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn9")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn10")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn11")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn12")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column8")]
	internal virtual DataGridViewTextBoxColumn Column8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column9")]
	internal virtual DataGridViewTextBoxColumn Column9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column14")]
	internal virtual DataGridViewTextBoxColumn Column14
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

	internal virtual CheckBox CheckBox3
	{
		[CompilerGenerated]
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = CheckBox3_CheckedChanged;
			CheckBox checkBox = _CheckBox3;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_CheckBox3 = value;
			checkBox = _CheckBox3;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem cmenu_blacklist_reset
	{
		[CompilerGenerated]
		get
		{
			return _cmenu_blacklist_reset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = 블랙리스트복구ToolStripMenuItem_Click;
			ToolStripMenuItem toolStripMenuItem = _cmenu_blacklist_reset;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_cmenu_blacklist_reset = value;
			toolStripMenuItem = _cmenu_blacklist_reset;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton db_blacklist_reset
	{
		[CompilerGenerated]
		get
		{
			return _db_blacklist_reset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = db_blacklist_reset_Click;
			ToolStripButton toolStripButton = _db_blacklist_reset;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_db_blacklist_reset = value;
			toolStripButton = _db_blacklist_reset;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn3")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn6")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn20")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn19")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn21")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn7")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn13")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn18")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column12")]
	internal virtual DataGridViewTextBoxColumn Column12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column13")]
	internal virtual DataGridViewTextBoxColumn Column13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn29")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn29
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn30")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn30
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn31")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn31
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn32")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn32
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn33")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn33
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn34")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn34
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn35")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn35
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn36")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn36
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn45")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn45
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn46")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn46
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn47")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn47
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn48")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn48
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn49")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn49
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn50")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn50
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn51")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn51
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn52")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn52
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn53")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn53
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn54")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn54
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn55")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn55
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn56")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn56
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn57")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn57
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn58")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn58
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn59")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn59
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn60")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn60
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn69")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn69
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn70")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn70
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn71")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn71
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn72")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn72
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn73")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn73
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn74")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn74
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn85")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn85
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn86")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn86
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn87")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn87
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn88")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn88
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn89")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn89
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn90")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn90
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn91")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn91
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn92")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn92
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn93")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn93
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn94")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn94
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn4")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn23")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn23
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn22")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn22
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn25")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn25
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn24")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn24
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn26")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn26
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn27")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn28")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn83")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn83
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn75")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn75
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn76")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn76
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn77")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn77
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn79")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn79
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn78")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn78
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn80")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn80
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn81")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn81
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn82")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn82
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DataGridViewTextBoxColumn84")]
	internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn84
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
			KeyPressEventHandler value3 = TextBox1_KeyPress;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyDown -= value2;
				textBox.KeyPress -= value3;
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				textBox.KeyDown += value2;
				textBox.KeyPress += value3;
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	public ssorder_cti()
	{
		base.Load += ssorder_cti_Load;
		base.FormClosed += ssorder_cti_FormClosed;
		base.MouseMove += ssorder_cti_MouseMove;
		tabPages = new List<TabPage>();
		agentLogin = false;
		busy = false;
		ctiDbClass = new List<cti_db>();
		AgentSelectDiag = new Form();
		isProductPageInit = false;
		page_busy = false;
		logging_in = false;
		current_page = -1;
		logging_time = new int[3];
		cbox = null;
		agent_breakTime = false;
		callLogType = false;
		idletime = 0;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlas_root.ssorder_cti));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.agents_grid = new System.Windows.Forms.DataGridView();
		this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.cmenu_start = new System.Windows.Forms.ToolStripMenuItem();
		this.cmenu_stop = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
		this.cmenu_new = new System.Windows.Forms.ToolStripMenuItem();
		this.cmenu_import = new System.Windows.Forms.ToolStripMenuItem();
		this.새로고침ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.cmenu_save = new System.Windows.Forms.ToolStripMenuItem();
		this.cmenu_delete = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
		this.cmenu_auto = new System.Windows.Forms.ToolStripMenuItem();
		this.배분량선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
		this.모든상담원에게배분ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.접속중인상담원에게만배분ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
		this.강제배분ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.cmenu_split = new System.Windows.Forms.ToolStripMenuItem();
		this.cmenu_restore = new System.Windows.Forms.ToolStripMenuItem();
		this.일괄회수ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.미처리항목일괄회수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
		this.cmenu_output = new System.Windows.Forms.ToolStripMenuItem();
		this.cmenu_agree_output = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
		this.cmenu_filter = new System.Windows.Forms.ToolStripMenuItem();
		this.cmenu_blacklist_reset = new System.Windows.Forms.ToolStripMenuItem();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Label2 = new System.Windows.Forms.Label();
		this.agent_delete = new System.Windows.Forms.Button();
		this.agent_reset = new System.Windows.Forms.Button();
		this.agent_add = new System.Windows.Forms.Button();
		this.CheckBox1 = new System.Windows.Forms.CheckBox();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.db_grid = new System.Windows.Forms.DataGridView();
		this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
		this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.table_grid = new System.Windows.Forms.DataGridView();
		this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.c8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ContextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.DoubleBufferPanel1 = new mlas_root.DoubleBufferPanel();
		this.CheckBox2 = new System.Windows.Forms.CheckBox();
		this.Button2 = new System.Windows.Forms.Button();
		this.Button1 = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.ComboBoxEx1 = new mlas_root.ComboBoxEx();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.db_back = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.db_start_stop = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
		this.db_add = new System.Windows.Forms.ToolStripButton();
		this.db_get_data = new System.Windows.Forms.ToolStripButton();
		this.db_refresh = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
		this.db_save = new System.Windows.Forms.ToolStripButton();
		this.db_delete = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.db_auto_split = new System.Windows.Forms.ToolStripButton();
		this.db_split = new System.Windows.Forms.ToolStripButton();
		this.db_restore = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
		this.db_output = new System.Windows.Forms.ToolStripButton();
		this.db_agree_output = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
		this.db_filter = new System.Windows.Forms.ToolStripButton();
		this.db_blacklist_reset = new System.Windows.Forms.ToolStripButton();
		this.db_blacklist = new System.Windows.Forms.ToolStripButton();
		this.db_settings = new System.Windows.Forms.ToolStripButton();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.agentpanel = new System.Windows.Forms.Panel();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.TabControl2 = new System.Windows.Forms.TabControl();
		this.tm1 = new System.Windows.Forms.TabPage();
		this.tm_grid_all = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tm2 = new System.Windows.Forms.TabPage();
		this.tm_grid_call_log = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn83 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tm3 = new System.Windows.Forms.TabPage();
		this.tm_grid_miss = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.TabPage5 = new System.Windows.Forms.TabPage();
		this.tm_grid_call_out = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn82 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn84 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tm5 = new System.Windows.Forms.TabPage();
		this.tm_grid_agree = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.tm6 = new System.Windows.Forms.TabPage();
		this.tm_grid_reserve = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.TabPage6 = new System.Windows.Forms.TabPage();
		this.tm_grid_blacklist = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn85 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn86 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn87 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn88 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn89 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn91 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn92 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn93 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn94 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
		this.DoubleBufferPanel2 = new mlas_root.DoubleBufferPanel();
		this.Button9 = new System.Windows.Forms.Button();
		this.TextBox1 = new System.Windows.Forms.TextBox();
		this.Button8 = new System.Windows.Forms.Button();
		this.Label5 = new System.Windows.Forms.Label();
		this.Panel6 = new System.Windows.Forms.Panel();
		this.CheckBox3 = new System.Windows.Forms.CheckBox();
		this.Button6 = new System.Windows.Forms.Button();
		this.Button7 = new System.Windows.Forms.Button();
		this.Label4 = new System.Windows.Forms.Label();
		this.ComboBoxEx2 = new mlas_root.ComboBoxEx();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.DoubleBufferPanel3 = new mlas_root.DoubleBufferPanel();
		this.tm_grid_calling = new System.Windows.Forms.DataGridView();
		this.DataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Button5 = new System.Windows.Forms.Button();
		this.Button4 = new System.Windows.Forms.Button();
		this.Label3 = new System.Windows.Forms.Label();
		this.Button3 = new System.Windows.Forms.Button();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.ComboBox1 = new System.Windows.Forms.ComboBox();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.selectDBLabel = new System.Windows.Forms.ToolStripStatusLabel();
		this.timeLabel = new System.Windows.Forms.ToolStripStatusLabel();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.bottomBar = new System.Windows.Forms.StatusStrip();
		this.dbName = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
		this.db_status = new System.Windows.Forms.ToolStripStatusLabel();
		this.ContextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.사용자정의ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
		this.모든상담사배정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.로그인상담사배정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
		this.접속중인상담원에게만강제배분ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.miniToolStrip = new System.Windows.Forms.StatusStrip();
		this.time = new System.Windows.Forms.Timer(this.components);
		this.DataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
		this.ContextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.일괄회수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.미처리회수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.agents_grid).BeginInit();
		this.ContextMenuStrip1.SuspendLayout();
		this.Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.TabPage2.SuspendLayout();
		this.SplitContainer1.Panel1.SuspendLayout();
		this.SplitContainer1.Panel2.SuspendLayout();
		this.SplitContainer1.SuspendLayout();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.db_grid).BeginInit();
		this.Panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.table_grid).BeginInit();
		this.DoubleBufferPanel1.SuspendLayout();
		this.ToolStrip1.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.agentpanel.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.TabControl2.SuspendLayout();
		this.tm1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tm_grid_all).BeginInit();
		this.tm2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tm_grid_call_log).BeginInit();
		this.tm3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tm_grid_miss).BeginInit();
		this.TabPage5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tm_grid_call_out).BeginInit();
		this.tm5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tm_grid_agree).BeginInit();
		this.tm6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tm_grid_reserve).BeginInit();
		this.TabPage6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tm_grid_blacklist).BeginInit();
		this.DoubleBufferPanel2.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.DoubleBufferPanel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.tm_grid_calling).BeginInit();
		this.GroupBox1.SuspendLayout();
		this.StatusStrip1.SuspendLayout();
		this.bottomBar.SuspendLayout();
		this.ContextMenuStrip3.SuspendLayout();
		this.ContextMenuStrip4.SuspendLayout();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Controls.Add(this.TabPage4);
		this.TabControl1.Controls.Add(this.TabPage3);
		this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabControl1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TabControl1.ImageList = this.ImageList1;
		this.TabControl1.ItemSize = new System.Drawing.Size(98, 30);
		this.TabControl1.Location = new System.Drawing.Point(0, 0);
		this.TabControl1.Margin = new System.Windows.Forms.Padding(0);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(1084, 661);
		this.TabControl1.TabIndex = 0;
		this.TabPage1.Controls.Add(this.agents_grid);
		this.TabPage1.Controls.Add(this.Panel2);
		this.TabPage1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TabPage1.ImageIndex = 9;
		this.TabPage1.Location = new System.Drawing.Point(4, 34);
		this.TabPage1.Margin = new System.Windows.Forms.Padding(0);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new System.Drawing.Size(1076, 623);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "상담원 관리";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.agents_grid.AllowUserToAddRows = false;
		this.agents_grid.AllowUserToDeleteRows = false;
		this.agents_grid.AllowUserToOrderColumns = true;
		this.agents_grid.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.agents_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.agents_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.agents_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.agents_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.agents_grid.ColumnHeadersHeight = 24;
		this.agents_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.agents_grid.Columns.AddRange(this.Column3, this.DataGridViewTextBoxColumn14, this.DataGridViewTextBoxColumn15, this.DataGridViewTextBoxColumn16, this.DataGridViewTextBoxColumn17, this.Column5, this.Column6);
		this.agents_grid.ContextMenuStrip = this.ContextMenuStrip1;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.agents_grid.DefaultCellStyle = dataGridViewCellStyle3;
		this.agents_grid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.agents_grid.EnableHeadersVisualStyles = false;
		this.agents_grid.Location = new System.Drawing.Point(0, 0);
		this.agents_grid.Name = "agents_grid";
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.agents_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.agents_grid.RowHeadersVisible = false;
		this.agents_grid.RowTemplate.Height = 23;
		this.agents_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.agents_grid.Size = new System.Drawing.Size(1076, 585);
		this.agents_grid.TabIndex = 66;
		this.Column3.HeaderText = "NO";
		this.Column3.Name = "Column3";
		this.Column3.ReadOnly = true;
		this.Column3.Visible = false;
		this.Column3.Width = 70;
		this.DataGridViewTextBoxColumn14.HeaderText = "계정";
		this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
		this.DataGridViewTextBoxColumn14.ReadOnly = true;
		this.DataGridViewTextBoxColumn15.HeaderText = "상담원명";
		this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
		this.DataGridViewTextBoxColumn15.ReadOnly = true;
		this.DataGridViewTextBoxColumn16.HeaderText = "등록일";
		this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
		this.DataGridViewTextBoxColumn16.ReadOnly = true;
		this.DataGridViewTextBoxColumn16.Width = 150;
		this.DataGridViewTextBoxColumn17.HeaderText = "해촉일";
		this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
		this.DataGridViewTextBoxColumn17.ReadOnly = true;
		this.DataGridViewTextBoxColumn17.Width = 150;
		this.Column5.HeaderText = "상태";
		this.Column5.Name = "Column5";
		this.Column5.ReadOnly = true;
		this.Column5.Width = 80;
		this.Column6.HeaderText = "최근 접속일시";
		this.Column6.Name = "Column6";
		this.Column6.ReadOnly = true;
		this.Column6.Width = 150;
		this.ContextMenuStrip1.AllowMerge = false;
		this.ContextMenuStrip1.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[19]
		{
			this.cmenu_start, this.cmenu_stop, this.ToolStripSeparator8, this.cmenu_new, this.cmenu_import, this.새로고침ToolStripMenuItem, this.ToolStripSeparator3, this.cmenu_save, this.cmenu_delete, this.ToolStripSeparator7,
			this.cmenu_auto, this.cmenu_split, this.cmenu_restore, this.ToolStripSeparator9, this.cmenu_output, this.cmenu_agree_output, this.ToolStripSeparator15, this.cmenu_filter, this.cmenu_blacklist_reset
		});
		this.ContextMenuStrip1.Name = "ContextMenuStrip1";
		this.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		this.ContextMenuStrip1.Size = new System.Drawing.Size(195, 342);
		this.cmenu_start.Image = mlas_root.My.Resources.Resources.play_new;
		this.cmenu_start.Name = "cmenu_start";
		this.cmenu_start.Size = new System.Drawing.Size(194, 22);
		this.cmenu_start.Text = "배포 시작";
		this.cmenu_start.ToolTipText = "데이터베이스를 담당자에게 배포합니다.";
		this.cmenu_stop.Image = mlas_root.My.Resources.Resources.Stop_sign;
		this.cmenu_stop.Name = "cmenu_stop";
		this.cmenu_stop.Size = new System.Drawing.Size(194, 22);
		this.cmenu_stop.Text = "배포 중단";
		this.cmenu_stop.ToolTipText = "담당자에게 배포된 데이터베이스를 중단합니다.";
		this.ToolStripSeparator8.Name = "ToolStripSeparator8";
		this.ToolStripSeparator8.Size = new System.Drawing.Size(191, 6);
		this.cmenu_new.Image = mlas_root.My.Resources.Resources.add_new;
		this.cmenu_new.Name = "cmenu_new";
		this.cmenu_new.Size = new System.Drawing.Size(194, 22);
		this.cmenu_new.Text = "새 DB 만들기";
		this.cmenu_new.ToolTipText = "새 데이터베이스를 생성합니다.";
		this.cmenu_new.Visible = false;
		this.cmenu_import.Image = mlas_root.My.Resources.Resources.upload_new;
		this.cmenu_import.Name = "cmenu_import";
		this.cmenu_import.Size = new System.Drawing.Size(194, 22);
		this.cmenu_import.Text = "데이터베이스 가져오기";
		this.cmenu_import.ToolTipText = "엑셀 파일을 데이터베이스로 변환합니다.";
		this.새로고침ToolStripMenuItem.Image = mlas_root.My.Resources.Resources.sync_new;
		this.새로고침ToolStripMenuItem.Name = "새로고침ToolStripMenuItem";
		this.새로고침ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
		this.새로고침ToolStripMenuItem.Text = "새로고침";
		this.새로고침ToolStripMenuItem.ToolTipText = "모든 데이터베이스의 TM 결과를 새로고침 합니다.";
		this.ToolStripSeparator3.Name = "ToolStripSeparator3";
		this.ToolStripSeparator3.Size = new System.Drawing.Size(191, 6);
		this.cmenu_save.Image = mlas_root.My.Resources.Resources.Save_new;
		this.cmenu_save.Name = "cmenu_save";
		this.cmenu_save.Size = new System.Drawing.Size(194, 22);
		this.cmenu_save.Text = "저장";
		this.cmenu_save.ToolTipText = "선택된 데이터베이스의 이름 변경사항을 저장합니다.";
		this.cmenu_delete.Image = mlas_root.My.Resources.Resources.delete_new;
		this.cmenu_delete.Name = "cmenu_delete";
		this.cmenu_delete.Size = new System.Drawing.Size(194, 22);
		this.cmenu_delete.Text = "삭제";
		this.cmenu_delete.ToolTipText = "선택된 데이터베이스를 포함된 데이터와 함께 영구 삭제합니다.";
		this.ToolStripSeparator7.Name = "ToolStripSeparator7";
		this.ToolStripSeparator7.Size = new System.Drawing.Size(191, 6);
		this.cmenu_auto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.배분량선택ToolStripMenuItem, this.ToolStripSeparator12, this.모든상담원에게배분ToolStripMenuItem, this.접속중인상담원에게만배분ToolStripMenuItem, this.ToolStripSeparator11, this.강제배분ToolStripMenuItem });
		this.cmenu_auto.Image = mlas_root.My.Resources.Resources.lightning_new;
		this.cmenu_auto.Name = "cmenu_auto";
		this.cmenu_auto.Size = new System.Drawing.Size(194, 22);
		this.cmenu_auto.Text = "자동 배분";
		this.배분량선택ToolStripMenuItem.Name = "배분량선택ToolStripMenuItem";
		this.배분량선택ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
		this.배분량선택ToolStripMenuItem.Text = "사용자 정의";
		this.배분량선택ToolStripMenuItem.ToolTipText = "자동 배분할 갯수를 사용자가 직접 정의합니다.";
		this.ToolStripSeparator12.Name = "ToolStripSeparator12";
		this.ToolStripSeparator12.Size = new System.Drawing.Size(155, 6);
		this.모든상담원에게배분ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.모든상담원에게배분ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.모든상담원에게배분ToolStripMenuItem.Name = "모든상담원에게배분ToolStripMenuItem";
		this.모든상담원에게배분ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
		this.모든상담원에게배분ToolStripMenuItem.Text = "모든 상담원";
		this.모든상담원에게배분ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
		this.모든상담원에게배분ToolStripMenuItem.ToolTipText = "등록된 상담원들에게 각각 일정 비율의 고객데이터를 배정합니다.\r\n이미 상담원이 할당되어있는 고객데이터의 경우 배정되지 않습니다.\r\n관리자에게는 배분되지 않습니다.";
		this.접속중인상담원에게만배분ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.접속중인상담원에게만배분ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		this.접속중인상담원에게만배분ToolStripMenuItem.Name = "접속중인상담원에게만배분ToolStripMenuItem";
		this.접속중인상담원에게만배분ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
		this.접속중인상담원에게만배분ToolStripMenuItem.Text = "접속중인 상담원";
		this.접속중인상담원에게만배분ToolStripMenuItem.ToolTipText = "접속중인 상담원들에게 각각 일정 비율의 고객데이터를 배정합니다.\r\n이미 상담원이 할당되어있는 고객데이터의 경우 배정되지 않습니다.";
		this.ToolStripSeparator11.Name = "ToolStripSeparator11";
		this.ToolStripSeparator11.Size = new System.Drawing.Size(155, 6);
		this.강제배분ToolStripMenuItem.Name = "강제배분ToolStripMenuItem";
		this.강제배분ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
		this.강제배분ToolStripMenuItem.Text = "강제 배분";
		this.강제배분ToolStripMenuItem.ToolTipText = "기존 배분을 모두 강제 회수하고 새로 배분합니다.\r\n배포 중이면 통화 중인 상담원은 회수되지 않습니다.";
		this.cmenu_split.Image = mlas_root.My.Resources.Resources.forward_new;
		this.cmenu_split.Name = "cmenu_split";
		this.cmenu_split.Size = new System.Drawing.Size(194, 22);
		this.cmenu_split.Text = "수동 배분";
		this.cmenu_split.ToolTipText = "고객정보를 담당자별로 수동으로 배분합니다.";
		this.cmenu_restore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.일괄회수ToolStripMenuItem1, this.미처리항목일괄회수ToolStripMenuItem });
		this.cmenu_restore.Image = mlas_root.My.Resources.Resources.restore_new;
		this.cmenu_restore.Name = "cmenu_restore";
		this.cmenu_restore.Size = new System.Drawing.Size(194, 22);
		this.cmenu_restore.Text = "회수";
		this.일괄회수ToolStripMenuItem1.Name = "일괄회수ToolStripMenuItem1";
		this.일괄회수ToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.일괄회수ToolStripMenuItem1.Text = "일괄 회수";
		this.일괄회수ToolStripMenuItem1.ToolTipText = "모든 항목을 일괄 회수합니다.";
		this.미처리항목일괄회수ToolStripMenuItem.Name = "미처리항목일괄회수ToolStripMenuItem";
		this.미처리항목일괄회수ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.미처리항목일괄회수ToolStripMenuItem.Text = "미처리 항목 일괄 회수";
		this.미처리항목일괄회수ToolStripMenuItem.ToolTipText = "미처리된 항목을 일괄 회수 합니다.";
		this.ToolStripSeparator9.Name = "ToolStripSeparator9";
		this.ToolStripSeparator9.Size = new System.Drawing.Size(191, 6);
		this.cmenu_output.Image = mlas_root.My.Resources.Resources.download_new;
		this.cmenu_output.Name = "cmenu_output";
		this.cmenu_output.Size = new System.Drawing.Size(194, 22);
		this.cmenu_output.Text = "결과 내보내기";
		this.cmenu_output.ToolTipText = "TM 결과를 엑셀 파일로 저장합니다.";
		this.cmenu_agree_output.Image = mlas_root.My.Resources.Resources.Good_mark;
		this.cmenu_agree_output.Name = "cmenu_agree_output";
		this.cmenu_agree_output.Size = new System.Drawing.Size(194, 22);
		this.cmenu_agree_output.Text = "동의리스트 내보내기";
		this.cmenu_agree_output.ToolTipText = "TM 결과중에 동의한 고객만 추출하여 엑셀 파일로 저장합니다.\r\n";
		this.ToolStripSeparator15.Name = "ToolStripSeparator15";
		this.ToolStripSeparator15.Size = new System.Drawing.Size(191, 6);
		this.cmenu_filter.Image = mlas_root.My.Resources.Resources.Filter_new;
		this.cmenu_filter.Name = "cmenu_filter";
		this.cmenu_filter.Size = new System.Drawing.Size(194, 22);
		this.cmenu_filter.Text = "블랙리스트 필터";
		this.cmenu_filter.ToolTipText = "블랙리스트 데이터베이스와 선택된 데이터베이스를 대조하여 필터링 합니다.";
		this.cmenu_blacklist_reset.Image = mlas_root.My.Resources.Resources.Redo_new;
		this.cmenu_blacklist_reset.Name = "cmenu_blacklist_reset";
		this.cmenu_blacklist_reset.Size = new System.Drawing.Size(194, 22);
		this.cmenu_blacklist_reset.Text = "블랙리스트 복구";
		this.cmenu_blacklist_reset.ToolTipText = "블랙리스트 처리된 레코드들을 일괄 복구합니다.";
		this.Panel2.Controls.Add(this.Label2);
		this.Panel2.Controls.Add(this.agent_delete);
		this.Panel2.Controls.Add(this.agent_reset);
		this.Panel2.Controls.Add(this.agent_add);
		this.Panel2.Controls.Add(this.CheckBox1);
		this.Panel2.Controls.Add(this.PictureBox1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new System.Drawing.Point(0, 585);
		this.Panel2.Name = "Panel2";
		this.Panel2.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
		this.Panel2.Size = new System.Drawing.Size(1076, 38);
		this.Panel2.TabIndex = 59;
		this.Label2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Label2.Location = new System.Drawing.Point(862, 5);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(166, 28);
		this.Label2.TabIndex = 12;
		this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.agent_delete.BackColor = System.Drawing.Color.Red;
		this.agent_delete.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.agent_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.agent_delete.Dock = System.Windows.Forms.DockStyle.Left;
		this.agent_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.agent_delete.ForeColor = System.Drawing.Color.White;
		this.agent_delete.Location = new System.Drawing.Point(382, 5);
		this.agent_delete.Name = "agent_delete";
		this.agent_delete.Size = new System.Drawing.Size(142, 28);
		this.agent_delete.TabIndex = 10;
		this.agent_delete.Text = "선택 해촉";
		this.agent_delete.UseVisualStyleBackColor = false;
		this.agent_reset.BackColor = System.Drawing.Color.DarkGreen;
		this.agent_reset.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.agent_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.agent_reset.Dock = System.Windows.Forms.DockStyle.Left;
		this.agent_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.agent_reset.ForeColor = System.Drawing.Color.White;
		this.agent_reset.Location = new System.Drawing.Point(240, 5);
		this.agent_reset.Name = "agent_reset";
		this.agent_reset.Size = new System.Drawing.Size(142, 28);
		this.agent_reset.TabIndex = 11;
		this.agent_reset.Text = "선택 재등록";
		this.agent_reset.UseVisualStyleBackColor = false;
		this.agent_add.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.agent_add.BackgroundImage = mlas_root.My.Resources.Resources.public_button_long;
		this.agent_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.agent_add.Dock = System.Windows.Forms.DockStyle.Left;
		this.agent_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.agent_add.ForeColor = System.Drawing.Color.White;
		this.agent_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.agent_add.Location = new System.Drawing.Point(98, 5);
		this.agent_add.Name = "agent_add";
		this.agent_add.Size = new System.Drawing.Size(142, 28);
		this.agent_add.TabIndex = 9;
		this.agent_add.Text = "상담원 추가";
		this.agent_add.UseVisualStyleBackColor = false;
		this.CheckBox1.AutoSize = true;
		this.CheckBox1.Checked = true;
		this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
		this.CheckBox1.Dock = System.Windows.Forms.DockStyle.Left;
		this.CheckBox1.Location = new System.Drawing.Point(10, 5);
		this.CheckBox1.Name = "CheckBox1";
		this.CheckBox1.Size = new System.Drawing.Size(88, 28);
		this.CheckBox1.TabIndex = 0;
		this.CheckBox1.Text = "해촉자 숨김";
		this.CheckBox1.UseVisualStyleBackColor = true;
		this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
		this.PictureBox1.Image = mlas_root.My.Resources.Resources.sync_new;
		this.PictureBox1.Location = new System.Drawing.Point(1028, 5);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
		this.PictureBox1.Size = new System.Drawing.Size(43, 28);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.PictureBox1.TabIndex = 13;
		this.PictureBox1.TabStop = false;
		this.ToolTip1.SetToolTip(this.PictureBox1, "새로고침");
		this.TabPage2.Controls.Add(this.SplitContainer1);
		this.TabPage2.Controls.Add(this.ToolStrip1);
		this.TabPage2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TabPage2.ImageIndex = 8;
		this.TabPage2.Location = new System.Drawing.Point(4, 34);
		this.TabPage2.Margin = new System.Windows.Forms.Padding(0);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new System.Drawing.Size(1076, 623);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "데이터베이스 관리";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.SplitContainer1.BackColor = System.Drawing.Color.Transparent;
		this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer1.IsSplitterFixed = true;
		this.SplitContainer1.Location = new System.Drawing.Point(0, 35);
		this.SplitContainer1.Margin = new System.Windows.Forms.Padding(0);
		this.SplitContainer1.Name = "SplitContainer1";
		this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
		this.SplitContainer1.Panel1.Controls.Add(this.Panel1);
		this.SplitContainer1.Panel2.Controls.Add(this.Panel3);
		this.SplitContainer1.Size = new System.Drawing.Size(1076, 588);
		this.SplitContainer1.SplitterDistance = 234;
		this.SplitContainer1.SplitterWidth = 1;
		this.SplitContainer1.TabIndex = 64;
		this.Panel1.Controls.Add(this.db_grid);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(1076, 234);
		this.Panel1.TabIndex = 60;
		this.db_grid.AllowUserToAddRows = false;
		this.db_grid.AllowUserToDeleteRows = false;
		this.db_grid.AllowUserToOrderColumns = true;
		this.db_grid.AllowUserToResizeRows = false;
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.db_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
		this.db_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.db_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.db_grid.ColumnHeadersHeight = 24;
		this.db_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.db_grid.Columns.AddRange(this.Column1, this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.Column7, this.DataGridViewTextBoxColumn5, this.DataGridViewTextBoxColumn8, this.DataGridViewTextBoxColumn9, this.DataGridViewTextBoxColumn10, this.DataGridViewTextBoxColumn11, this.DataGridViewTextBoxColumn12, this.Column8, this.Column9, this.Column14, this.Column2);
		this.db_grid.ContextMenuStrip = this.ContextMenuStrip1;
		this.db_grid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.db_grid.EnableHeadersVisualStyles = false;
		this.db_grid.Location = new System.Drawing.Point(0, 0);
		this.db_grid.MultiSelect = false;
		this.db_grid.Name = "db_grid";
		this.db_grid.RowHeadersVisible = false;
		this.db_grid.RowTemplate.Height = 23;
		this.db_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.db_grid.Size = new System.Drawing.Size(1076, 234);
		this.db_grid.TabIndex = 65;
		this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.Column1.FillWeight = 50f;
		this.Column1.HeaderText = "";
		this.Column1.Image = mlas_root.My.Resources.Resources.Stop_sign;
		this.Column1.Name = "Column1";
		this.Column1.ReadOnly = true;
		this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.Column1.Width = 30;
		this.DataGridViewTextBoxColumn1.HeaderText = "NO";
		this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
		this.DataGridViewTextBoxColumn1.ReadOnly = true;
		this.DataGridViewTextBoxColumn1.Width = 70;
		this.DataGridViewTextBoxColumn2.HeaderText = "데이터베이스 이름";
		this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
		this.DataGridViewTextBoxColumn2.Width = 200;
		this.Column7.HeaderText = "미배분";
		this.Column7.Name = "Column7";
		this.Column7.ReadOnly = true;
		this.Column7.Width = 80;
		this.DataGridViewTextBoxColumn5.HeaderText = "총건수";
		this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
		this.DataGridViewTextBoxColumn5.ReadOnly = true;
		this.DataGridViewTextBoxColumn5.Width = 80;
		this.DataGridViewTextBoxColumn8.HeaderText = "미처리";
		this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
		this.DataGridViewTextBoxColumn8.ReadOnly = true;
		this.DataGridViewTextBoxColumn8.Width = 80;
		this.DataGridViewTextBoxColumn9.HeaderText = "동의";
		this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
		this.DataGridViewTextBoxColumn9.ReadOnly = true;
		this.DataGridViewTextBoxColumn9.Width = 80;
		this.DataGridViewTextBoxColumn10.HeaderText = "무관심";
		this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
		this.DataGridViewTextBoxColumn10.ReadOnly = true;
		this.DataGridViewTextBoxColumn10.Width = 80;
		this.DataGridViewTextBoxColumn11.HeaderText = "TM거부";
		this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
		this.DataGridViewTextBoxColumn11.ReadOnly = true;
		this.DataGridViewTextBoxColumn11.Width = 80;
		this.DataGridViewTextBoxColumn12.HeaderText = "무응답";
		this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
		this.DataGridViewTextBoxColumn12.ReadOnly = true;
		this.DataGridViewTextBoxColumn12.Width = 80;
		this.Column8.HeaderText = "결번";
		this.Column8.Name = "Column8";
		this.Column8.ReadOnly = true;
		this.Column8.Width = 80;
		this.Column9.HeaderText = "본인아님";
		this.Column9.Name = "Column9";
		this.Column9.ReadOnly = true;
		this.Column9.Width = 80;
		this.Column14.HeaderText = "블랙리스트";
		this.Column14.Name = "Column14";
		this.Column14.ReadOnly = true;
		this.Column14.Width = 80;
		this.Column2.HeaderText = "최근 배포일자";
		this.Column2.Name = "Column2";
		this.Column2.ReadOnly = true;
		this.Column2.Width = 150;
		this.Panel3.Controls.Add(this.table_grid);
		this.Panel3.Controls.Add(this.DoubleBufferPanel1);
		this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel3.Location = new System.Drawing.Point(0, 0);
		this.Panel3.Margin = new System.Windows.Forms.Padding(0);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(1076, 353);
		this.Panel3.TabIndex = 68;
		this.table_grid.AllowUserToAddRows = false;
		this.table_grid.AllowUserToDeleteRows = false;
		this.table_grid.AllowUserToOrderColumns = true;
		this.table_grid.AllowUserToResizeRows = false;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.table_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
		this.table_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.table_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.table_grid.ColumnHeadersHeight = 24;
		this.table_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.table_grid.Columns.AddRange(this.Column4, this.c1, this.c2, this.c7, this.c6, this.c8, this.c3, this.c4, this.c5, this.Column10, this.Column11);
		this.table_grid.ContextMenuStrip = this.ContextMenuStrip2;
		this.table_grid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.table_grid.EnableHeadersVisualStyles = false;
		this.table_grid.Location = new System.Drawing.Point(0, 0);
		this.table_grid.Name = "table_grid";
		this.table_grid.RowHeadersVisible = false;
		this.table_grid.RowTemplate.Height = 23;
		this.table_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.table_grid.Size = new System.Drawing.Size(1076, 318);
		this.table_grid.TabIndex = 68;
		this.Column4.HeaderText = "NO";
		this.Column4.Name = "Column4";
		this.Column4.ReadOnly = true;
		this.Column4.Visible = false;
		this.Column4.Width = 70;
		this.c1.HeaderText = "상담원명";
		this.c1.Name = "c1";
		this.c1.ReadOnly = true;
		this.c2.HeaderText = "고객명";
		this.c2.Name = "c2";
		this.c2.ReadOnly = true;
		this.c2.Width = 80;
		this.c7.HeaderText = "집전화";
		this.c7.Name = "c7";
		this.c7.ReadOnly = true;
		this.c7.Width = 120;
		this.c6.HeaderText = "휴대전화";
		this.c6.Name = "c6";
		this.c6.ReadOnly = true;
		this.c6.Width = 120;
		this.c8.HeaderText = "주소";
		this.c8.Name = "c8";
		this.c8.ReadOnly = true;
		this.c8.Width = 560;
		this.c3.HeaderText = "상품명";
		this.c3.Name = "c3";
		this.c3.ReadOnly = true;
		this.c4.HeaderText = "구매처";
		this.c4.Name = "c4";
		this.c4.ReadOnly = true;
		this.c5.HeaderText = "금액";
		this.c5.Name = "c5";
		this.c5.ReadOnly = true;
		this.Column10.HeaderText = "비고1";
		this.Column10.Name = "Column10";
		this.Column10.ReadOnly = true;
		this.Column10.Width = 150;
		this.Column11.HeaderText = "비고2";
		this.Column11.Name = "Column11";
		this.Column11.ReadOnly = true;
		this.Column11.Width = 150;
		this.ContextMenuStrip2.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(0, 0);
		this.ContextMenuStrip2.Name = "ContextMenuStrip2";
		this.ContextMenuStrip2.ShowImageMargin = false;
		this.ContextMenuStrip2.ShowItemToolTips = false;
		this.ContextMenuStrip2.Size = new System.Drawing.Size(36, 4);
		this.DoubleBufferPanel1.BackColor = System.Drawing.SystemColors.Control;
		this.DoubleBufferPanel1.Controls.Add(this.CheckBox2);
		this.DoubleBufferPanel1.Controls.Add(this.Button2);
		this.DoubleBufferPanel1.Controls.Add(this.Button1);
		this.DoubleBufferPanel1.Controls.Add(this.Label1);
		this.DoubleBufferPanel1.Controls.Add(this.ComboBoxEx1);
		this.DoubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel1.Location = new System.Drawing.Point(0, 318);
		this.DoubleBufferPanel1.Name = "DoubleBufferPanel1";
		this.DoubleBufferPanel1.Size = new System.Drawing.Size(1076, 35);
		this.DoubleBufferPanel1.TabIndex = 69;
		this.CheckBox2.AutoSize = true;
		this.CheckBox2.Location = new System.Drawing.Point(353, 10);
		this.CheckBox2.Name = "CheckBox2";
		this.CheckBox2.Size = new System.Drawing.Size(140, 16);
		this.CheckBox2.TabIndex = 4;
		this.CheckBox2.Text = "블랙리스트 항목 보기";
		this.CheckBox2.UseVisualStyleBackColor = true;
		this.Button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button2.BackgroundImage");
		this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button2.Location = new System.Drawing.Point(185, 6);
		this.Button2.Name = "Button2";
		this.Button2.Size = new System.Drawing.Size(78, 23);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "< 이전";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button1.BackgroundImage");
		this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button1.Location = new System.Drawing.Point(266, 6);
		this.Button1.Name = "Button1";
		this.Button1.Size = new System.Drawing.Size(78, 23);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "다음 >";
		this.Button1.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(11, 12);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(69, 12);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "페이지 선택";
		this.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBoxEx1.FormattingEnabled = true;
		this.ComboBoxEx1.Location = new System.Drawing.Point(86, 6);
		this.ComboBoxEx1.Name = "ComboBoxEx1";
		this.ComboBoxEx1.Size = new System.Drawing.Size(89, 22);
		this.ComboBoxEx1.TabIndex = 0;
		this.ToolStrip1.AllowMerge = false;
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[22]
		{
			this.db_back, this.ToolStripSeparator1, this.db_start_stop, this.ToolStripSeparator5, this.db_add, this.db_get_data, this.db_refresh, this.ToolStripSeparator4, this.db_save, this.db_delete,
			this.ToolStripSeparator2, this.db_auto_split, this.db_split, this.db_restore, this.ToolStripSeparator6, this.db_output, this.db_agree_output, this.ToolStripSeparator14, this.db_filter, this.db_blacklist_reset,
			this.db_blacklist, this.db_settings
		});
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
		this.ToolStrip1.Size = new System.Drawing.Size(1076, 35);
		this.ToolStrip1.TabIndex = 68;
		this.ToolStrip1.Text = "ToolStrip1";
		this.db_back.AutoSize = false;
		this.db_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_back.Image = mlas_root.My.Resources.Resources.Apply_new;
		this.db_back.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_back.Name = "db_back";
		this.db_back.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
		this.db_back.Size = new System.Drawing.Size(42, 30);
		this.db_back.Text = "완료";
		this.db_back.Visible = false;
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 35);
		this.ToolStripSeparator1.Visible = false;
		this.db_start_stop.AutoSize = false;
		this.db_start_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_start_stop.Image = mlas_root.My.Resources.Resources.play_new;
		this.db_start_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_start_stop.Name = "db_start_stop";
		this.db_start_stop.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.db_start_stop.Size = new System.Drawing.Size(31, 32);
		this.db_start_stop.Text = "데이터베이스 실행";
		this.db_start_stop.ToolTipText = "배포 시작";
		this.ToolStripSeparator5.Name = "ToolStripSeparator5";
		this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 35);
		this.db_add.AutoSize = false;
		this.db_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_add.Image = mlas_root.My.Resources.Resources.add_new;
		this.db_add.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_add.Name = "db_add";
		this.db_add.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_add.Size = new System.Drawing.Size(31, 32);
		this.db_add.Text = "새 DB 만들기";
		this.db_add.ToolTipText = "[새 DB 만들기]\r\n새 데이터베이스를 생성합니다.";
		this.db_add.Visible = false;
		this.db_get_data.AutoSize = false;
		this.db_get_data.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_get_data.Image = mlas_root.My.Resources.Resources.upload_new;
		this.db_get_data.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_get_data.Name = "db_get_data";
		this.db_get_data.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_get_data.Size = new System.Drawing.Size(31, 32);
		this.db_get_data.Text = "데이터베이스 가져오기";
		this.db_get_data.ToolTipText = "[데이터베이스 가져오기]\r\n엑셀 파일을 데이터베이스로 변환합니다.";
		this.db_refresh.AutoSize = false;
		this.db_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_refresh.Image = mlas_root.My.Resources.Resources.sync_new;
		this.db_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_refresh.Name = "db_refresh";
		this.db_refresh.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_refresh.Size = new System.Drawing.Size(31, 32);
		this.db_refresh.Text = "새로고침";
		this.db_refresh.ToolTipText = "[새로고침]\r\n모든 데이터베이스의 TM 결과를 새로고침 합니다.";
		this.ToolStripSeparator4.Name = "ToolStripSeparator4";
		this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 35);
		this.db_save.AutoSize = false;
		this.db_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_save.Image = mlas_root.My.Resources.Resources.Save_new;
		this.db_save.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_save.Name = "db_save";
		this.db_save.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_save.Size = new System.Drawing.Size(31, 32);
		this.db_save.Text = "선택 저장";
		this.db_save.ToolTipText = "[선택 저장]\r\n선택된 데이터베이스의 이름 변경사항을 저장합니다.";
		this.db_delete.AutoSize = false;
		this.db_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_delete.Image = mlas_root.My.Resources.Resources.delete_new;
		this.db_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_delete.Name = "db_delete";
		this.db_delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_delete.Size = new System.Drawing.Size(31, 32);
		this.db_delete.Text = "선택 삭제";
		this.db_delete.ToolTipText = "[선택 삭제]\r\n선택된 데이터베이스를 포함된 데이터와 함께 영구 삭제합니다.";
		this.ToolStripSeparator2.Name = "ToolStripSeparator2";
		this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 35);
		this.db_auto_split.AutoSize = false;
		this.db_auto_split.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_auto_split.Image = mlas_root.My.Resources.Resources.lightning_new;
		this.db_auto_split.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_auto_split.Name = "db_auto_split";
		this.db_auto_split.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_auto_split.Size = new System.Drawing.Size(31, 32);
		this.db_auto_split.Text = "자동 배분";
		this.db_auto_split.ToolTipText = "[자동 배분]\r\n고객정보를 담당자들에게 자동으로 배분합니다.";
		this.db_split.AutoSize = false;
		this.db_split.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_split.Image = mlas_root.My.Resources.Resources.forward_new;
		this.db_split.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_split.Name = "db_split";
		this.db_split.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.db_split.Size = new System.Drawing.Size(31, 32);
		this.db_split.Text = "수동 배분";
		this.db_split.ToolTipText = "[수동 배분]\r\n고객정보를 담당자별로 수동으로 배분합니다.";
		this.db_restore.AutoSize = false;
		this.db_restore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_restore.Image = mlas_root.My.Resources.Resources.restore_new;
		this.db_restore.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_restore.Name = "db_restore";
		this.db_restore.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_restore.Size = new System.Drawing.Size(31, 32);
		this.db_restore.Text = "회수";
		this.db_restore.ToolTipText = "[회수]\r\n배정된 담당자를 회수하여 재배치가 가능한 상태로 변경합니다.\r\n배포 중이면 통화 중인 상담원은 회수되지 않습니다.";
		this.ToolStripSeparator6.Name = "ToolStripSeparator6";
		this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 35);
		this.db_output.AutoSize = false;
		this.db_output.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_output.Image = mlas_root.My.Resources.Resources.download_new;
		this.db_output.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_output.Name = "db_output";
		this.db_output.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_output.Size = new System.Drawing.Size(31, 32);
		this.db_output.Text = "결과 내보내기";
		this.db_output.ToolTipText = "[결과 내보내기]\r\nTM 결과를 엑셀 파일로 저장합니다.";
		this.db_agree_output.AutoSize = false;
		this.db_agree_output.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_agree_output.Image = mlas_root.My.Resources.Resources.Good_mark;
		this.db_agree_output.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_agree_output.Name = "db_agree_output";
		this.db_agree_output.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_agree_output.Size = new System.Drawing.Size(31, 32);
		this.db_agree_output.Text = "동의리스트 내보내기";
		this.db_agree_output.ToolTipText = "[동의리스트 내보내기]\r\nTM 결과중에 동의한 고객만 추출하여 엑셀 파일로 저장합니다.";
		this.ToolStripSeparator14.Name = "ToolStripSeparator14";
		this.ToolStripSeparator14.Size = new System.Drawing.Size(6, 35);
		this.db_filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_filter.Image = mlas_root.My.Resources.Resources.Filter_new;
		this.db_filter.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_filter.Name = "db_filter";
		this.db_filter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_filter.Size = new System.Drawing.Size(31, 32);
		this.db_filter.Text = "블랙리스트 필터";
		this.db_filter.ToolTipText = "[블랙리스트 필터]\r\n블랙리스트 데이터베이스와 선택된 데이터베이스를 대조하여 필터링 합니다.";
		this.db_blacklist_reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_blacklist_reset.Image = mlas_root.My.Resources.Resources.Redo_new;
		this.db_blacklist_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_blacklist_reset.Name = "db_blacklist_reset";
		this.db_blacklist_reset.Size = new System.Drawing.Size(26, 32);
		this.db_blacklist_reset.Text = "블랙리스트 복구";
		this.db_blacklist_reset.ToolTipText = "[블랙리스트 복구]\r\n블랙리스트 처리된 레코드들을 일괄 복구합니다.";
		this.db_blacklist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_blacklist.Image = mlas_root.My.Resources.Resources.blacklist_new;
		this.db_blacklist.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_blacklist.Name = "db_blacklist";
		this.db_blacklist.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
		this.db_blacklist.Size = new System.Drawing.Size(31, 32);
		this.db_blacklist.Text = "블랙리스트 관리";
		this.db_settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.db_settings.Image = mlas_root.My.Resources.Resources.Pinion;
		this.db_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.db_settings.Name = "db_settings";
		this.db_settings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.db_settings.Size = new System.Drawing.Size(31, 32);
		this.db_settings.Text = "환경설정";
		this.TabPage4.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.TabPage4.Location = new System.Drawing.Point(4, 34);
		this.TabPage4.Margin = new System.Windows.Forms.Padding(0);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new System.Drawing.Size(1076, 623);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "TM 결과";
		this.TabPage4.UseVisualStyleBackColor = true;
		this.TabPage3.Controls.Add(this.agentpanel);
		this.TabPage3.Location = new System.Drawing.Point(4, 34);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new System.Drawing.Size(1076, 623);
		this.TabPage3.TabIndex = 4;
		this.TabPage3.Text = "상담원";
		this.TabPage3.UseVisualStyleBackColor = true;
		this.agentpanel.Controls.Add(this.Panel5);
		this.agentpanel.Controls.Add(this.StatusStrip1);
		this.agentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
		this.agentpanel.Location = new System.Drawing.Point(0, 0);
		this.agentpanel.Name = "agentpanel";
		this.agentpanel.Size = new System.Drawing.Size(1076, 623);
		this.agentpanel.TabIndex = 4;
		this.Panel5.Controls.Add(this.TabControl2);
		this.Panel5.Controls.Add(this.DoubleBufferPanel2);
		this.Panel5.Controls.Add(this.Panel4);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Name = "Panel5";
		this.Panel5.Padding = new System.Windows.Forms.Padding(10);
		this.Panel5.Size = new System.Drawing.Size(1076, 601);
		this.Panel5.TabIndex = 5;
		this.TabControl2.Controls.Add(this.tm1);
		this.TabControl2.Controls.Add(this.tm2);
		this.TabControl2.Controls.Add(this.tm3);
		this.TabControl2.Controls.Add(this.TabPage5);
		this.TabControl2.Controls.Add(this.tm5);
		this.TabControl2.Controls.Add(this.tm6);
		this.TabControl2.Controls.Add(this.TabPage6);
		this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabControl2.Enabled = false;
		this.TabControl2.ImageList = this.ImageList2;
		this.TabControl2.ItemSize = new System.Drawing.Size(98, 30);
		this.TabControl2.Location = new System.Drawing.Point(10, 72);
		this.TabControl2.Multiline = true;
		this.TabControl2.Name = "TabControl2";
		this.TabControl2.SelectedIndex = 0;
		this.TabControl2.Size = new System.Drawing.Size(1056, 484);
		this.TabControl2.TabIndex = 1;
		this.tm1.Controls.Add(this.tm_grid_all);
		this.tm1.ImageIndex = 4;
		this.tm1.Location = new System.Drawing.Point(4, 34);
		this.tm1.Name = "tm1";
		this.tm1.Padding = new System.Windows.Forms.Padding(3);
		this.tm1.Size = new System.Drawing.Size(1048, 446);
		this.tm1.TabIndex = 3;
		this.tm1.Text = "전체";
		this.tm1.UseVisualStyleBackColor = true;
		this.tm_grid_all.AllowUserToAddRows = false;
		this.tm_grid_all.AllowUserToDeleteRows = false;
		this.tm_grid_all.AllowUserToOrderColumns = true;
		this.tm_grid_all.AllowUserToResizeRows = false;
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.tm_grid_all.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
		this.tm_grid_all.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.tm_grid_all.BackgroundColor = System.Drawing.Color.White;
		this.tm_grid_all.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_all.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
		this.tm_grid_all.ColumnHeadersHeight = 24;
		this.tm_grid_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.tm_grid_all.Columns.AddRange(this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn6, this.DataGridViewTextBoxColumn20, this.DataGridViewTextBoxColumn19, this.DataGridViewTextBoxColumn21, this.DataGridViewTextBoxColumn7, this.DataGridViewTextBoxColumn13, this.DataGridViewTextBoxColumn18, this.Column12, this.Column13);
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.tm_grid_all.DefaultCellStyle = dataGridViewCellStyle9;
		this.tm_grid_all.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tm_grid_all.EnableHeadersVisualStyles = false;
		this.tm_grid_all.Location = new System.Drawing.Point(3, 3);
		this.tm_grid_all.MultiSelect = false;
		this.tm_grid_all.Name = "tm_grid_all";
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle10.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_all.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
		this.tm_grid_all.RowHeadersVisible = false;
		this.tm_grid_all.RowTemplate.Height = 23;
		this.tm_grid_all.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.tm_grid_all.Size = new System.Drawing.Size(1042, 440);
		this.tm_grid_all.TabIndex = 70;
		this.DataGridViewTextBoxColumn3.HeaderText = "NO";
		this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
		this.DataGridViewTextBoxColumn3.ReadOnly = true;
		this.DataGridViewTextBoxColumn3.Width = 70;
		this.DataGridViewTextBoxColumn6.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
		this.DataGridViewTextBoxColumn6.ReadOnly = true;
		this.DataGridViewTextBoxColumn6.Width = 80;
		this.DataGridViewTextBoxColumn20.HeaderText = "집전화";
		this.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
		this.DataGridViewTextBoxColumn20.ReadOnly = true;
		this.DataGridViewTextBoxColumn20.Visible = false;
		this.DataGridViewTextBoxColumn20.Width = 120;
		this.DataGridViewTextBoxColumn19.HeaderText = "휴대전화";
		this.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
		this.DataGridViewTextBoxColumn19.ReadOnly = true;
		this.DataGridViewTextBoxColumn19.Visible = false;
		this.DataGridViewTextBoxColumn19.Width = 120;
		this.DataGridViewTextBoxColumn21.HeaderText = "주소";
		this.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
		this.DataGridViewTextBoxColumn21.ReadOnly = true;
		this.DataGridViewTextBoxColumn21.Width = 600;
		this.DataGridViewTextBoxColumn7.HeaderText = "제품명";
		this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
		this.DataGridViewTextBoxColumn7.ReadOnly = true;
		this.DataGridViewTextBoxColumn13.HeaderText = "구매처";
		this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
		this.DataGridViewTextBoxColumn13.ReadOnly = true;
		this.DataGridViewTextBoxColumn18.HeaderText = "금액";
		this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
		this.DataGridViewTextBoxColumn18.ReadOnly = true;
		this.Column12.HeaderText = "비고1";
		this.Column12.Name = "Column12";
		this.Column12.ReadOnly = true;
		this.Column12.Width = 150;
		this.Column13.HeaderText = "비고2";
		this.Column13.Name = "Column13";
		this.Column13.ReadOnly = true;
		this.Column13.Width = 150;
		this.tm2.Controls.Add(this.tm_grid_call_log);
		this.tm2.ImageIndex = 12;
		this.tm2.Location = new System.Drawing.Point(4, 34);
		this.tm2.Name = "tm2";
		this.tm2.Padding = new System.Windows.Forms.Padding(3);
		this.tm2.Size = new System.Drawing.Size(1048, 446);
		this.tm2.TabIndex = 0;
		this.tm2.Text = "통화이력";
		this.tm2.UseVisualStyleBackColor = true;
		this.tm_grid_call_log.AllowUserToAddRows = false;
		this.tm_grid_call_log.AllowUserToDeleteRows = false;
		this.tm_grid_call_log.AllowUserToOrderColumns = true;
		this.tm_grid_call_log.AllowUserToResizeRows = false;
		dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.tm_grid_call_log.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
		this.tm_grid_call_log.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.tm_grid_call_log.BackgroundColor = System.Drawing.Color.White;
		this.tm_grid_call_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle12.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_call_log.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
		this.tm_grid_call_log.ColumnHeadersHeight = 24;
		this.tm_grid_call_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.tm_grid_call_log.Columns.AddRange(this.DataGridViewTextBoxColumn4, this.DataGridViewTextBoxColumn23, this.DataGridViewTextBoxColumn22, this.DataGridViewTextBoxColumn25, this.DataGridViewTextBoxColumn24, this.DataGridViewTextBoxColumn26, this.DataGridViewTextBoxColumn27, this.DataGridViewTextBoxColumn28, this.DataGridViewTextBoxColumn83);
		dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle13.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.tm_grid_call_log.DefaultCellStyle = dataGridViewCellStyle13;
		this.tm_grid_call_log.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tm_grid_call_log.EnableHeadersVisualStyles = false;
		this.tm_grid_call_log.Location = new System.Drawing.Point(3, 3);
		this.tm_grid_call_log.MultiSelect = false;
		this.tm_grid_call_log.Name = "tm_grid_call_log";
		dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle14.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_call_log.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
		this.tm_grid_call_log.RowHeadersVisible = false;
		this.tm_grid_call_log.RowTemplate.Height = 23;
		this.tm_grid_call_log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.tm_grid_call_log.Size = new System.Drawing.Size(1042, 440);
		this.tm_grid_call_log.TabIndex = 71;
		this.DataGridViewTextBoxColumn4.HeaderText = "NO";
		this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
		this.DataGridViewTextBoxColumn4.ReadOnly = true;
		this.DataGridViewTextBoxColumn4.Width = 70;
		this.DataGridViewTextBoxColumn23.HeaderText = "통화시각";
		this.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23";
		this.DataGridViewTextBoxColumn23.ReadOnly = true;
		this.DataGridViewTextBoxColumn23.Width = 150;
		this.DataGridViewTextBoxColumn22.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22";
		this.DataGridViewTextBoxColumn22.ReadOnly = true;
		this.DataGridViewTextBoxColumn22.Width = 80;
		this.DataGridViewTextBoxColumn25.HeaderText = "제품명";
		this.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25";
		this.DataGridViewTextBoxColumn25.ReadOnly = true;
		this.DataGridViewTextBoxColumn24.HeaderText = "구매처";
		this.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24";
		this.DataGridViewTextBoxColumn24.ReadOnly = true;
		this.DataGridViewTextBoxColumn26.HeaderText = "금액";
		this.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26";
		this.DataGridViewTextBoxColumn26.ReadOnly = true;
		this.DataGridViewTextBoxColumn27.HeaderText = "시도수";
		this.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27";
		this.DataGridViewTextBoxColumn27.ReadOnly = true;
		this.DataGridViewTextBoxColumn27.Width = 120;
		this.DataGridViewTextBoxColumn28.HeaderText = "통화번호";
		this.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28";
		this.DataGridViewTextBoxColumn28.ReadOnly = true;
		this.DataGridViewTextBoxColumn28.Visible = false;
		this.DataGridViewTextBoxColumn28.Width = 120;
		this.DataGridViewTextBoxColumn83.HeaderText = "통화결과";
		this.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83";
		this.DataGridViewTextBoxColumn83.ReadOnly = true;
		this.DataGridViewTextBoxColumn83.Width = 120;
		this.tm3.Controls.Add(this.tm_grid_miss);
		this.tm3.ImageIndex = 1;
		this.tm3.Location = new System.Drawing.Point(4, 34);
		this.tm3.Name = "tm3";
		this.tm3.Padding = new System.Windows.Forms.Padding(3);
		this.tm3.Size = new System.Drawing.Size(1048, 446);
		this.tm3.TabIndex = 1;
		this.tm3.Text = "미시도";
		this.tm3.UseVisualStyleBackColor = true;
		this.tm_grid_miss.AllowUserToAddRows = false;
		this.tm_grid_miss.AllowUserToDeleteRows = false;
		this.tm_grid_miss.AllowUserToOrderColumns = true;
		this.tm_grid_miss.AllowUserToResizeRows = false;
		dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.tm_grid_miss.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
		this.tm_grid_miss.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.tm_grid_miss.BackgroundColor = System.Drawing.Color.White;
		this.tm_grid_miss.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle16.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_miss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
		this.tm_grid_miss.ColumnHeadersHeight = 24;
		this.tm_grid_miss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.tm_grid_miss.Columns.AddRange(this.DataGridViewTextBoxColumn29, this.DataGridViewTextBoxColumn30, this.DataGridViewTextBoxColumn31, this.DataGridViewTextBoxColumn32, this.DataGridViewTextBoxColumn33, this.DataGridViewTextBoxColumn34, this.DataGridViewTextBoxColumn35, this.DataGridViewTextBoxColumn36, this.DataGridViewTextBoxColumn45, this.DataGridViewTextBoxColumn46);
		dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle17.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.tm_grid_miss.DefaultCellStyle = dataGridViewCellStyle17;
		this.tm_grid_miss.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tm_grid_miss.EnableHeadersVisualStyles = false;
		this.tm_grid_miss.Location = new System.Drawing.Point(3, 3);
		this.tm_grid_miss.MultiSelect = false;
		this.tm_grid_miss.Name = "tm_grid_miss";
		dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle18.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_miss.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
		this.tm_grid_miss.RowHeadersVisible = false;
		this.tm_grid_miss.RowTemplate.Height = 23;
		this.tm_grid_miss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.tm_grid_miss.Size = new System.Drawing.Size(1042, 440);
		this.tm_grid_miss.TabIndex = 71;
		this.DataGridViewTextBoxColumn29.HeaderText = "NO";
		this.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29";
		this.DataGridViewTextBoxColumn29.ReadOnly = true;
		this.DataGridViewTextBoxColumn29.Width = 70;
		this.DataGridViewTextBoxColumn30.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30";
		this.DataGridViewTextBoxColumn30.ReadOnly = true;
		this.DataGridViewTextBoxColumn30.Width = 80;
		this.DataGridViewTextBoxColumn31.HeaderText = "집전화";
		this.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31";
		this.DataGridViewTextBoxColumn31.ReadOnly = true;
		this.DataGridViewTextBoxColumn31.Visible = false;
		this.DataGridViewTextBoxColumn31.Width = 120;
		this.DataGridViewTextBoxColumn32.HeaderText = "휴대전화";
		this.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32";
		this.DataGridViewTextBoxColumn32.ReadOnly = true;
		this.DataGridViewTextBoxColumn32.Visible = false;
		this.DataGridViewTextBoxColumn32.Width = 120;
		this.DataGridViewTextBoxColumn33.HeaderText = "주소";
		this.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33";
		this.DataGridViewTextBoxColumn33.ReadOnly = true;
		this.DataGridViewTextBoxColumn33.Width = 600;
		this.DataGridViewTextBoxColumn34.HeaderText = "제품명";
		this.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34";
		this.DataGridViewTextBoxColumn34.ReadOnly = true;
		this.DataGridViewTextBoxColumn35.HeaderText = "구매처";
		this.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35";
		this.DataGridViewTextBoxColumn35.ReadOnly = true;
		this.DataGridViewTextBoxColumn36.HeaderText = "금액";
		this.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36";
		this.DataGridViewTextBoxColumn36.ReadOnly = true;
		this.DataGridViewTextBoxColumn45.HeaderText = "비고1";
		this.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45";
		this.DataGridViewTextBoxColumn45.ReadOnly = true;
		this.DataGridViewTextBoxColumn45.Width = 150;
		this.DataGridViewTextBoxColumn46.HeaderText = "비고2";
		this.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46";
		this.DataGridViewTextBoxColumn46.ReadOnly = true;
		this.DataGridViewTextBoxColumn46.Width = 150;
		this.TabPage5.Controls.Add(this.tm_grid_call_out);
		this.TabPage5.ImageIndex = 6;
		this.TabPage5.Location = new System.Drawing.Point(4, 34);
		this.TabPage5.Name = "TabPage5";
		this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage5.Size = new System.Drawing.Size(1048, 446);
		this.TabPage5.TabIndex = 7;
		this.TabPage5.Text = "통화종료";
		this.TabPage5.UseVisualStyleBackColor = true;
		this.tm_grid_call_out.AllowUserToAddRows = false;
		this.tm_grid_call_out.AllowUserToDeleteRows = false;
		this.tm_grid_call_out.AllowUserToOrderColumns = true;
		this.tm_grid_call_out.AllowUserToResizeRows = false;
		dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.tm_grid_call_out.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
		this.tm_grid_call_out.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.tm_grid_call_out.BackgroundColor = System.Drawing.Color.White;
		this.tm_grid_call_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle20.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_call_out.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
		this.tm_grid_call_out.ColumnHeadersHeight = 24;
		this.tm_grid_call_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.tm_grid_call_out.Columns.AddRange(this.DataGridViewTextBoxColumn75, this.DataGridViewTextBoxColumn76, this.DataGridViewTextBoxColumn77, this.DataGridViewTextBoxColumn79, this.DataGridViewTextBoxColumn78, this.DataGridViewTextBoxColumn80, this.DataGridViewTextBoxColumn81, this.DataGridViewTextBoxColumn82, this.DataGridViewTextBoxColumn84);
		dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle21.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.tm_grid_call_out.DefaultCellStyle = dataGridViewCellStyle21;
		this.tm_grid_call_out.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tm_grid_call_out.EnableHeadersVisualStyles = false;
		this.tm_grid_call_out.Location = new System.Drawing.Point(3, 3);
		this.tm_grid_call_out.MultiSelect = false;
		this.tm_grid_call_out.Name = "tm_grid_call_out";
		dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle22.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_call_out.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
		this.tm_grid_call_out.RowHeadersVisible = false;
		this.tm_grid_call_out.RowTemplate.Height = 23;
		this.tm_grid_call_out.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.tm_grid_call_out.Size = new System.Drawing.Size(1042, 440);
		this.tm_grid_call_out.TabIndex = 72;
		this.DataGridViewTextBoxColumn75.HeaderText = "NO";
		this.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75";
		this.DataGridViewTextBoxColumn75.ReadOnly = true;
		this.DataGridViewTextBoxColumn75.Width = 70;
		this.DataGridViewTextBoxColumn76.HeaderText = "통화시각";
		this.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76";
		this.DataGridViewTextBoxColumn76.ReadOnly = true;
		this.DataGridViewTextBoxColumn76.Width = 150;
		this.DataGridViewTextBoxColumn77.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77";
		this.DataGridViewTextBoxColumn77.ReadOnly = true;
		this.DataGridViewTextBoxColumn77.Width = 80;
		this.DataGridViewTextBoxColumn79.HeaderText = "제품명";
		this.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79";
		this.DataGridViewTextBoxColumn79.ReadOnly = true;
		this.DataGridViewTextBoxColumn78.HeaderText = "구매처";
		this.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78";
		this.DataGridViewTextBoxColumn78.ReadOnly = true;
		this.DataGridViewTextBoxColumn80.HeaderText = "금액";
		this.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80";
		this.DataGridViewTextBoxColumn80.ReadOnly = true;
		this.DataGridViewTextBoxColumn81.HeaderText = "시도수";
		this.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81";
		this.DataGridViewTextBoxColumn81.ReadOnly = true;
		this.DataGridViewTextBoxColumn81.Width = 120;
		this.DataGridViewTextBoxColumn82.HeaderText = "통화번호";
		this.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82";
		this.DataGridViewTextBoxColumn82.ReadOnly = true;
		this.DataGridViewTextBoxColumn82.Visible = false;
		this.DataGridViewTextBoxColumn82.Width = 120;
		this.DataGridViewTextBoxColumn84.HeaderText = "통화결과";
		this.DataGridViewTextBoxColumn84.Name = "DataGridViewTextBoxColumn84";
		this.DataGridViewTextBoxColumn84.ReadOnly = true;
		this.DataGridViewTextBoxColumn84.Width = 120;
		this.tm5.Controls.Add(this.tm_grid_agree);
		this.tm5.ImageIndex = 13;
		this.tm5.Location = new System.Drawing.Point(4, 34);
		this.tm5.Name = "tm5";
		this.tm5.Padding = new System.Windows.Forms.Padding(3);
		this.tm5.Size = new System.Drawing.Size(1048, 446);
		this.tm5.TabIndex = 5;
		this.tm5.Text = "판매접수";
		this.tm5.UseVisualStyleBackColor = true;
		this.tm_grid_agree.AllowUserToAddRows = false;
		this.tm_grid_agree.AllowUserToDeleteRows = false;
		this.tm_grid_agree.AllowUserToOrderColumns = true;
		this.tm_grid_agree.AllowUserToResizeRows = false;
		dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.tm_grid_agree.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
		this.tm_grid_agree.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.tm_grid_agree.BackgroundColor = System.Drawing.Color.White;
		this.tm_grid_agree.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle24.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_agree.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
		this.tm_grid_agree.ColumnHeadersHeight = 24;
		this.tm_grid_agree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.tm_grid_agree.Columns.AddRange(this.DataGridViewTextBoxColumn47, this.DataGridViewTextBoxColumn48, this.DataGridViewTextBoxColumn49, this.DataGridViewTextBoxColumn50, this.DataGridViewTextBoxColumn51, this.DataGridViewTextBoxColumn52, this.DataGridViewTextBoxColumn53, this.DataGridViewTextBoxColumn54, this.DataGridViewTextBoxColumn55, this.DataGridViewTextBoxColumn56);
		dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle25.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.tm_grid_agree.DefaultCellStyle = dataGridViewCellStyle25;
		this.tm_grid_agree.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tm_grid_agree.EnableHeadersVisualStyles = false;
		this.tm_grid_agree.Location = new System.Drawing.Point(3, 3);
		this.tm_grid_agree.MultiSelect = false;
		this.tm_grid_agree.Name = "tm_grid_agree";
		dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle26.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_agree.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
		this.tm_grid_agree.RowHeadersVisible = false;
		this.tm_grid_agree.RowTemplate.Height = 23;
		this.tm_grid_agree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.tm_grid_agree.Size = new System.Drawing.Size(1042, 440);
		this.tm_grid_agree.TabIndex = 71;
		this.DataGridViewTextBoxColumn47.HeaderText = "NO";
		this.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47";
		this.DataGridViewTextBoxColumn47.ReadOnly = true;
		this.DataGridViewTextBoxColumn47.Width = 70;
		this.DataGridViewTextBoxColumn48.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48";
		this.DataGridViewTextBoxColumn48.ReadOnly = true;
		this.DataGridViewTextBoxColumn48.Width = 80;
		this.DataGridViewTextBoxColumn49.HeaderText = "집전화";
		this.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49";
		this.DataGridViewTextBoxColumn49.ReadOnly = true;
		this.DataGridViewTextBoxColumn49.Visible = false;
		this.DataGridViewTextBoxColumn49.Width = 120;
		this.DataGridViewTextBoxColumn50.HeaderText = "휴대전화";
		this.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50";
		this.DataGridViewTextBoxColumn50.ReadOnly = true;
		this.DataGridViewTextBoxColumn50.Visible = false;
		this.DataGridViewTextBoxColumn50.Width = 120;
		this.DataGridViewTextBoxColumn51.HeaderText = "주소";
		this.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51";
		this.DataGridViewTextBoxColumn51.ReadOnly = true;
		this.DataGridViewTextBoxColumn51.Width = 600;
		this.DataGridViewTextBoxColumn52.HeaderText = "제품명";
		this.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52";
		this.DataGridViewTextBoxColumn52.ReadOnly = true;
		this.DataGridViewTextBoxColumn53.HeaderText = "구매처";
		this.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53";
		this.DataGridViewTextBoxColumn53.ReadOnly = true;
		this.DataGridViewTextBoxColumn54.HeaderText = "금액";
		this.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54";
		this.DataGridViewTextBoxColumn54.ReadOnly = true;
		this.DataGridViewTextBoxColumn55.HeaderText = "비고1";
		this.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55";
		this.DataGridViewTextBoxColumn55.ReadOnly = true;
		this.DataGridViewTextBoxColumn55.Width = 150;
		this.DataGridViewTextBoxColumn56.HeaderText = "비고2";
		this.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56";
		this.DataGridViewTextBoxColumn56.ReadOnly = true;
		this.DataGridViewTextBoxColumn56.Width = 150;
		this.tm6.Controls.Add(this.tm_grid_reserve);
		this.tm6.ImageIndex = 0;
		this.tm6.Location = new System.Drawing.Point(4, 34);
		this.tm6.Name = "tm6";
		this.tm6.Padding = new System.Windows.Forms.Padding(3);
		this.tm6.Size = new System.Drawing.Size(1048, 446);
		this.tm6.TabIndex = 6;
		this.tm6.Text = "통화예약";
		this.tm6.UseVisualStyleBackColor = true;
		this.tm_grid_reserve.AllowUserToAddRows = false;
		this.tm_grid_reserve.AllowUserToDeleteRows = false;
		this.tm_grid_reserve.AllowUserToOrderColumns = true;
		this.tm_grid_reserve.AllowUserToResizeRows = false;
		dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.tm_grid_reserve.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle27;
		this.tm_grid_reserve.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.tm_grid_reserve.BackgroundColor = System.Drawing.Color.White;
		this.tm_grid_reserve.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle28.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_reserve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
		this.tm_grid_reserve.ColumnHeadersHeight = 24;
		this.tm_grid_reserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.tm_grid_reserve.Columns.AddRange(this.DataGridViewTextBoxColumn57, this.DataGridViewTextBoxColumn58, this.DataGridViewTextBoxColumn59, this.DataGridViewTextBoxColumn60, this.DataGridViewTextBoxColumn69, this.DataGridViewTextBoxColumn70, this.DataGridViewTextBoxColumn71, this.DataGridViewTextBoxColumn72, this.DataGridViewTextBoxColumn73, this.DataGridViewTextBoxColumn74);
		dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle29.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.tm_grid_reserve.DefaultCellStyle = dataGridViewCellStyle29;
		this.tm_grid_reserve.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tm_grid_reserve.EnableHeadersVisualStyles = false;
		this.tm_grid_reserve.Location = new System.Drawing.Point(3, 3);
		this.tm_grid_reserve.MultiSelect = false;
		this.tm_grid_reserve.Name = "tm_grid_reserve";
		dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle30.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_reserve.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
		this.tm_grid_reserve.RowHeadersVisible = false;
		this.tm_grid_reserve.RowTemplate.Height = 23;
		this.tm_grid_reserve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.tm_grid_reserve.Size = new System.Drawing.Size(1042, 440);
		this.tm_grid_reserve.TabIndex = 71;
		this.DataGridViewTextBoxColumn57.HeaderText = "NO";
		this.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57";
		this.DataGridViewTextBoxColumn57.ReadOnly = true;
		this.DataGridViewTextBoxColumn57.Width = 70;
		this.DataGridViewTextBoxColumn58.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58";
		this.DataGridViewTextBoxColumn58.ReadOnly = true;
		this.DataGridViewTextBoxColumn58.Width = 80;
		this.DataGridViewTextBoxColumn59.HeaderText = "집전화";
		this.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59";
		this.DataGridViewTextBoxColumn59.ReadOnly = true;
		this.DataGridViewTextBoxColumn59.Visible = false;
		this.DataGridViewTextBoxColumn59.Width = 120;
		this.DataGridViewTextBoxColumn60.HeaderText = "휴대전화";
		this.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60";
		this.DataGridViewTextBoxColumn60.ReadOnly = true;
		this.DataGridViewTextBoxColumn60.Visible = false;
		this.DataGridViewTextBoxColumn60.Width = 120;
		this.DataGridViewTextBoxColumn69.HeaderText = "주소";
		this.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69";
		this.DataGridViewTextBoxColumn69.ReadOnly = true;
		this.DataGridViewTextBoxColumn69.Width = 600;
		this.DataGridViewTextBoxColumn70.HeaderText = "제품명";
		this.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70";
		this.DataGridViewTextBoxColumn70.ReadOnly = true;
		this.DataGridViewTextBoxColumn71.HeaderText = "구매처";
		this.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71";
		this.DataGridViewTextBoxColumn71.ReadOnly = true;
		this.DataGridViewTextBoxColumn72.HeaderText = "금액";
		this.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72";
		this.DataGridViewTextBoxColumn72.ReadOnly = true;
		this.DataGridViewTextBoxColumn73.HeaderText = "비고1";
		this.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73";
		this.DataGridViewTextBoxColumn73.ReadOnly = true;
		this.DataGridViewTextBoxColumn73.Width = 150;
		this.DataGridViewTextBoxColumn74.HeaderText = "비고2";
		this.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74";
		this.DataGridViewTextBoxColumn74.ReadOnly = true;
		this.DataGridViewTextBoxColumn74.Width = 150;
		this.TabPage6.Controls.Add(this.tm_grid_blacklist);
		this.TabPage6.ImageIndex = 14;
		this.TabPage6.Location = new System.Drawing.Point(4, 34);
		this.TabPage6.Name = "TabPage6";
		this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage6.Size = new System.Drawing.Size(1048, 446);
		this.TabPage6.TabIndex = 8;
		this.TabPage6.Text = "블랙리스트";
		this.TabPage6.UseVisualStyleBackColor = true;
		this.tm_grid_blacklist.AllowUserToAddRows = false;
		this.tm_grid_blacklist.AllowUserToDeleteRows = false;
		this.tm_grid_blacklist.AllowUserToOrderColumns = true;
		this.tm_grid_blacklist.AllowUserToResizeRows = false;
		dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.tm_grid_blacklist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
		this.tm_grid_blacklist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.tm_grid_blacklist.BackgroundColor = System.Drawing.Color.White;
		this.tm_grid_blacklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle32.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_blacklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
		this.tm_grid_blacklist.ColumnHeadersHeight = 24;
		this.tm_grid_blacklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.tm_grid_blacklist.Columns.AddRange(this.DataGridViewTextBoxColumn85, this.DataGridViewTextBoxColumn86, this.DataGridViewTextBoxColumn87, this.DataGridViewTextBoxColumn88, this.DataGridViewTextBoxColumn89, this.DataGridViewTextBoxColumn90, this.DataGridViewTextBoxColumn91, this.DataGridViewTextBoxColumn92, this.DataGridViewTextBoxColumn93, this.DataGridViewTextBoxColumn94);
		dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle33.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.tm_grid_blacklist.DefaultCellStyle = dataGridViewCellStyle33;
		this.tm_grid_blacklist.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tm_grid_blacklist.EnableHeadersVisualStyles = false;
		this.tm_grid_blacklist.Location = new System.Drawing.Point(3, 3);
		this.tm_grid_blacklist.MultiSelect = false;
		this.tm_grid_blacklist.Name = "tm_grid_blacklist";
		dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle34.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_blacklist.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
		this.tm_grid_blacklist.RowHeadersVisible = false;
		this.tm_grid_blacklist.RowTemplate.Height = 23;
		this.tm_grid_blacklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.tm_grid_blacklist.Size = new System.Drawing.Size(1042, 440);
		this.tm_grid_blacklist.TabIndex = 72;
		this.DataGridViewTextBoxColumn85.HeaderText = "NO";
		this.DataGridViewTextBoxColumn85.Name = "DataGridViewTextBoxColumn85";
		this.DataGridViewTextBoxColumn85.ReadOnly = true;
		this.DataGridViewTextBoxColumn85.Width = 70;
		this.DataGridViewTextBoxColumn86.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn86.Name = "DataGridViewTextBoxColumn86";
		this.DataGridViewTextBoxColumn86.ReadOnly = true;
		this.DataGridViewTextBoxColumn86.Width = 80;
		this.DataGridViewTextBoxColumn87.HeaderText = "집전화";
		this.DataGridViewTextBoxColumn87.Name = "DataGridViewTextBoxColumn87";
		this.DataGridViewTextBoxColumn87.ReadOnly = true;
		this.DataGridViewTextBoxColumn87.Visible = false;
		this.DataGridViewTextBoxColumn87.Width = 120;
		this.DataGridViewTextBoxColumn88.HeaderText = "휴대전화";
		this.DataGridViewTextBoxColumn88.Name = "DataGridViewTextBoxColumn88";
		this.DataGridViewTextBoxColumn88.ReadOnly = true;
		this.DataGridViewTextBoxColumn88.Visible = false;
		this.DataGridViewTextBoxColumn88.Width = 120;
		this.DataGridViewTextBoxColumn89.HeaderText = "주소";
		this.DataGridViewTextBoxColumn89.Name = "DataGridViewTextBoxColumn89";
		this.DataGridViewTextBoxColumn89.ReadOnly = true;
		this.DataGridViewTextBoxColumn89.Width = 600;
		this.DataGridViewTextBoxColumn90.HeaderText = "제품명";
		this.DataGridViewTextBoxColumn90.Name = "DataGridViewTextBoxColumn90";
		this.DataGridViewTextBoxColumn90.ReadOnly = true;
		this.DataGridViewTextBoxColumn91.HeaderText = "구매처";
		this.DataGridViewTextBoxColumn91.Name = "DataGridViewTextBoxColumn91";
		this.DataGridViewTextBoxColumn91.ReadOnly = true;
		this.DataGridViewTextBoxColumn92.HeaderText = "금액";
		this.DataGridViewTextBoxColumn92.Name = "DataGridViewTextBoxColumn92";
		this.DataGridViewTextBoxColumn92.ReadOnly = true;
		this.DataGridViewTextBoxColumn93.HeaderText = "비고1";
		this.DataGridViewTextBoxColumn93.Name = "DataGridViewTextBoxColumn93";
		this.DataGridViewTextBoxColumn93.ReadOnly = true;
		this.DataGridViewTextBoxColumn93.Width = 150;
		this.DataGridViewTextBoxColumn94.HeaderText = "비고2";
		this.DataGridViewTextBoxColumn94.Name = "DataGridViewTextBoxColumn94";
		this.DataGridViewTextBoxColumn94.ReadOnly = true;
		this.DataGridViewTextBoxColumn94.Width = 150;
		this.ImageList2.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList2.ImageStream");
		this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
		this.ImageList2.Images.SetKeyName(0, "Blue pin.png");
		this.ImageList2.Images.SetKeyName(1, "Bubble.png");
		this.ImageList2.Images.SetKeyName(2, "Comment.png");
		this.ImageList2.Images.SetKeyName(3, "Dial.png");
		this.ImageList2.Images.SetKeyName(4, "Display.png");
		this.ImageList2.Images.SetKeyName(5, "Exit_new.png");
		this.ImageList2.Images.SetKeyName(6, "Hungup.png");
		this.ImageList2.Images.SetKeyName(7, "Notes.png");
		this.ImageList2.Images.SetKeyName(8, "Thumbs up.png");
		this.ImageList2.Images.SetKeyName(9, "Key.png");
		this.ImageList2.Images.SetKeyName(10, "Clock.png");
		this.ImageList2.Images.SetKeyName(11, "Next.png");
		this.ImageList2.Images.SetKeyName(12, "History.png");
		this.ImageList2.Images.SetKeyName(13, "Shopping cart.png");
		this.ImageList2.Images.SetKeyName(14, "blacklist_new.png");
		this.DoubleBufferPanel2.BackColor = System.Drawing.SystemColors.Control;
		this.DoubleBufferPanel2.Controls.Add(this.Button9);
		this.DoubleBufferPanel2.Controls.Add(this.TextBox1);
		this.DoubleBufferPanel2.Controls.Add(this.Button8);
		this.DoubleBufferPanel2.Controls.Add(this.Label5);
		this.DoubleBufferPanel2.Controls.Add(this.Panel6);
		this.DoubleBufferPanel2.Controls.Add(this.CheckBox3);
		this.DoubleBufferPanel2.Controls.Add(this.Button6);
		this.DoubleBufferPanel2.Controls.Add(this.Button7);
		this.DoubleBufferPanel2.Controls.Add(this.Label4);
		this.DoubleBufferPanel2.Controls.Add(this.ComboBoxEx2);
		this.DoubleBufferPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.DoubleBufferPanel2.Enabled = false;
		this.DoubleBufferPanel2.Location = new System.Drawing.Point(10, 556);
		this.DoubleBufferPanel2.Name = "DoubleBufferPanel2";
		this.DoubleBufferPanel2.Size = new System.Drawing.Size(1056, 35);
		this.DoubleBufferPanel2.TabIndex = 70;
		this.Button9.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button9.BackgroundImage");
		this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button9.Location = new System.Drawing.Point(835, 6);
		this.Button9.Name = "Button9";
		this.Button9.Size = new System.Drawing.Size(60, 23);
		this.Button9.TabIndex = 9;
		this.Button9.Text = "지우기";
		this.Button9.UseVisualStyleBackColor = true;
		this.TextBox1.Location = new System.Drawing.Point(598, 7);
		this.TextBox1.MaxLength = 16;
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.Size = new System.Drawing.Size(161, 21);
		this.TextBox1.TabIndex = 8;
		this.Button8.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button8.BackgroundImage");
		this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button8.Location = new System.Drawing.Point(769, 6);
		this.Button8.Name = "Button8";
		this.Button8.Size = new System.Drawing.Size(60, 23);
		this.Button8.TabIndex = 7;
		this.Button8.Text = "검색";
		this.Button8.UseVisualStyleBackColor = true;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(487, 11);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(105, 12);
		this.Label5.TabIndex = 6;
		this.Label5.Text = "연락처로 고객찾기";
		this.Panel6.BackColor = System.Drawing.Color.Silver;
		this.Panel6.Location = new System.Drawing.Point(474, 7);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new System.Drawing.Size(1, 20);
		this.Panel6.TabIndex = 5;
		this.CheckBox3.AutoSize = true;
		this.CheckBox3.Checked = true;
		this.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
		this.CheckBox3.Location = new System.Drawing.Point(354, 10);
		this.CheckBox3.Name = "CheckBox3";
		this.CheckBox3.Size = new System.Drawing.Size(112, 16);
		this.CheckBox3.TabIndex = 4;
		this.CheckBox3.Text = "블랙리스트 제외";
		this.CheckBox3.UseVisualStyleBackColor = true;
		this.Button6.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button6.BackgroundImage");
		this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button6.Location = new System.Drawing.Point(185, 6);
		this.Button6.Name = "Button6";
		this.Button6.Size = new System.Drawing.Size(78, 23);
		this.Button6.TabIndex = 3;
		this.Button6.Text = "< 이전";
		this.Button6.UseVisualStyleBackColor = true;
		this.Button7.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button7.BackgroundImage");
		this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		this.Button7.Location = new System.Drawing.Point(266, 6);
		this.Button7.Name = "Button7";
		this.Button7.Size = new System.Drawing.Size(78, 23);
		this.Button7.TabIndex = 2;
		this.Button7.Text = "다음 >";
		this.Button7.UseVisualStyleBackColor = true;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(11, 12);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(69, 12);
		this.Label4.TabIndex = 1;
		this.Label4.Text = "페이지 선택";
		this.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.ComboBoxEx2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBoxEx2.FormattingEnabled = true;
		this.ComboBoxEx2.Location = new System.Drawing.Point(86, 6);
		this.ComboBoxEx2.Name = "ComboBoxEx2";
		this.ComboBoxEx2.Size = new System.Drawing.Size(89, 22);
		this.ComboBoxEx2.TabIndex = 0;
		this.Panel4.Controls.Add(this.DoubleBufferPanel3);
		this.Panel4.Controls.Add(this.GroupBox1);
		this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new System.Drawing.Point(10, 10);
		this.Panel4.Name = "Panel4";
		this.Panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
		this.Panel4.Size = new System.Drawing.Size(1056, 62);
		this.Panel4.TabIndex = 2;
		this.DoubleBufferPanel3.Controls.Add(this.tm_grid_calling);
		this.DoubleBufferPanel3.Controls.Add(this.Button5);
		this.DoubleBufferPanel3.Controls.Add(this.Button4);
		this.DoubleBufferPanel3.Controls.Add(this.Label3);
		this.DoubleBufferPanel3.Controls.Add(this.Button3);
		this.DoubleBufferPanel3.Dock = System.Windows.Forms.DockStyle.Right;
		this.DoubleBufferPanel3.Location = new System.Drawing.Point(440, 0);
		this.DoubleBufferPanel3.Name = "DoubleBufferPanel3";
		this.DoubleBufferPanel3.Size = new System.Drawing.Size(616, 52);
		this.DoubleBufferPanel3.TabIndex = 3;
		this.tm_grid_calling.AllowUserToAddRows = false;
		this.tm_grid_calling.AllowUserToDeleteRows = false;
		this.tm_grid_calling.AllowUserToOrderColumns = true;
		this.tm_grid_calling.AllowUserToResizeRows = false;
		dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.tm_grid_calling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle35;
		this.tm_grid_calling.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.tm_grid_calling.BackgroundColor = System.Drawing.Color.White;
		this.tm_grid_calling.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle36.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_calling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
		this.tm_grid_calling.ColumnHeadersHeight = 24;
		this.tm_grid_calling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.tm_grid_calling.Columns.AddRange(this.DataGridViewTextBoxColumn61, this.DataGridViewTextBoxColumn62, this.DataGridViewTextBoxColumn63, this.DataGridViewTextBoxColumn64, this.DataGridViewTextBoxColumn65, this.DataGridViewTextBoxColumn66, this.DataGridViewTextBoxColumn67, this.DataGridViewTextBoxColumn68);
		dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle37.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.tm_grid_calling.DefaultCellStyle = dataGridViewCellStyle37;
		this.tm_grid_calling.EnableHeadersVisualStyles = false;
		this.tm_grid_calling.Location = new System.Drawing.Point(47, -2);
		this.tm_grid_calling.MultiSelect = false;
		this.tm_grid_calling.Name = "tm_grid_calling";
		dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle38.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.tm_grid_calling.RowHeadersDefaultCellStyle = dataGridViewCellStyle38;
		this.tm_grid_calling.RowHeadersVisible = false;
		this.tm_grid_calling.RowTemplate.Height = 23;
		this.tm_grid_calling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.tm_grid_calling.Size = new System.Drawing.Size(62, 58);
		this.tm_grid_calling.TabIndex = 75;
		this.tm_grid_calling.Visible = false;
		this.DataGridViewTextBoxColumn61.HeaderText = "NO";
		this.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61";
		this.DataGridViewTextBoxColumn61.ReadOnly = true;
		this.DataGridViewTextBoxColumn61.Width = 70;
		this.DataGridViewTextBoxColumn62.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62";
		this.DataGridViewTextBoxColumn62.ReadOnly = true;
		this.DataGridViewTextBoxColumn62.Width = 80;
		this.DataGridViewTextBoxColumn63.HeaderText = "주민번호";
		this.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63";
		this.DataGridViewTextBoxColumn63.ReadOnly = true;
		this.DataGridViewTextBoxColumn63.Width = 120;
		this.DataGridViewTextBoxColumn64.HeaderText = "성별";
		this.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64";
		this.DataGridViewTextBoxColumn64.ReadOnly = true;
		this.DataGridViewTextBoxColumn64.Width = 50;
		this.DataGridViewTextBoxColumn65.HeaderText = "연령";
		this.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65";
		this.DataGridViewTextBoxColumn65.ReadOnly = true;
		this.DataGridViewTextBoxColumn65.Width = 50;
		this.DataGridViewTextBoxColumn66.HeaderText = "휴대전화";
		this.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66";
		this.DataGridViewTextBoxColumn66.ReadOnly = true;
		this.DataGridViewTextBoxColumn66.Width = 120;
		this.DataGridViewTextBoxColumn67.HeaderText = "집전화";
		this.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67";
		this.DataGridViewTextBoxColumn67.ReadOnly = true;
		this.DataGridViewTextBoxColumn67.Width = 120;
		this.DataGridViewTextBoxColumn68.HeaderText = "주소";
		this.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68";
		this.DataGridViewTextBoxColumn68.ReadOnly = true;
		this.DataGridViewTextBoxColumn68.Width = 600;
		this.Button5.Enabled = false;
		this.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button5.ImageIndex = 10;
		this.Button5.ImageList = this.ImageList2;
		this.Button5.Location = new System.Drawing.Point(220, 7);
		this.Button5.Name = "Button5";
		this.Button5.Size = new System.Drawing.Size(82, 37);
		this.Button5.TabIndex = 4;
		this.Button5.Text = "자리비움";
		this.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button5.UseVisualStyleBackColor = true;
		this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button4.ImageIndex = 9;
		this.Button4.ImageList = this.ImageList2;
		this.Button4.Location = new System.Drawing.Point(308, 7);
		this.Button4.Name = "Button4";
		this.Button4.Size = new System.Drawing.Size(82, 37);
		this.Button4.TabIndex = 3;
		this.Button4.Text = "로그인";
		this.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button4.UseVisualStyleBackColor = true;
		this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.Label3.ForeColor = System.Drawing.Color.RoyalBlue;
		this.Label3.Location = new System.Drawing.Point(484, 7);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(128, 37);
		this.Label3.TabIndex = 2;
		this.Label3.Text = "00:00:00";
		this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Button3.Enabled = false;
		this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Button3.ImageIndex = 5;
		this.Button3.ImageList = this.ImageList2;
		this.Button3.Location = new System.Drawing.Point(396, 7);
		this.Button3.Name = "Button3";
		this.Button3.Size = new System.Drawing.Size(82, 37);
		this.Button3.TabIndex = 1;
		this.Button3.Text = "로그아웃";
		this.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.Button3.UseVisualStyleBackColor = true;
		this.GroupBox1.Controls.Add(this.ComboBox1);
		this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
		this.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
		this.GroupBox1.Location = new System.Drawing.Point(0, 0);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(263, 52);
		this.GroupBox1.TabIndex = 0;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "데이터베이스 선택";
		this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboBox1.Enabled = false;
		this.ComboBox1.FormattingEnabled = true;
		this.ComboBox1.Location = new System.Drawing.Point(6, 20);
		this.ComboBox1.Name = "ComboBox1";
		this.ComboBox1.Size = new System.Drawing.Size(251, 20);
		this.ComboBox1.TabIndex = 0;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.statusLabel, this.ToolStripStatusLabel2, this.selectDBLabel, this.timeLabel });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 601);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(1076, 22);
		this.StatusStrip1.TabIndex = 4;
		this.StatusStrip1.Text = "StatusStrip1";
		this.statusLabel.Name = "statusLabel";
		this.statusLabel.Size = new System.Drawing.Size(90, 17);
		this.statusLabel.Text = "상태 : 오프라인";
		this.ToolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
		this.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
		this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
		this.ToolStripStatusLabel2.Size = new System.Drawing.Size(4, 17);
		this.selectDBLabel.Name = "selectDBLabel";
		this.selectDBLabel.Size = new System.Drawing.Size(66, 17);
		this.selectDBLabel.Text = "선택 : 없음";
		this.timeLabel.Name = "timeLabel";
		this.timeLabel.Size = new System.Drawing.Size(901, 17);
		this.timeLabel.Spring = true;
		this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.ImageList1.Images.SetKeyName(0, "034-users.png");
		this.ImageList1.Images.SetKeyName(1, "edit.png");
		this.ImageList1.Images.SetKeyName(2, "eye.png");
		this.ImageList1.Images.SetKeyName(3, "server.png");
		this.ImageList1.Images.SetKeyName(4, "shuffle.png");
		this.ImageList1.Images.SetKeyName(5, "telephone.png");
		this.ImageList1.Images.SetKeyName(6, "trash.png");
		this.ImageList1.Images.SetKeyName(7, "003-bar-chart.png");
		this.ImageList1.Images.SetKeyName(8, "database_new.png");
		this.ImageList1.Images.SetKeyName(9, "People.png");
		this.bottomBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.dbName, this.ToolStripStatusLabel5, this.db_status });
		this.bottomBar.Location = new System.Drawing.Point(0, 641);
		this.bottomBar.Name = "bottomBar";
		this.bottomBar.Size = new System.Drawing.Size(1011, 24);
		this.bottomBar.TabIndex = 70;
		this.bottomBar.Text = "StatusStrip2";
		this.bottomBar.Visible = false;
		this.dbName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.All;
		this.dbName.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
		this.dbName.Name = "dbName";
		this.dbName.Size = new System.Drawing.Size(159, 19);
		this.dbName.Text = "데이터베이스를 선택하세요";
		this.ToolStripStatusLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
		this.ToolStripStatusLabel5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
		this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
		this.ToolStripStatusLabel5.Size = new System.Drawing.Size(10, 19);
		this.ToolStripStatusLabel5.Text = "|";
		this.db_status.Name = "db_status";
		this.db_status.Size = new System.Drawing.Size(0, 19);
		this.ContextMenuStrip3.AllowMerge = false;
		this.ContextMenuStrip3.Font = new System.Drawing.Font("굴림", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
		this.ContextMenuStrip3.ImageScalingSize = new System.Drawing.Size(0, 0);
		this.ContextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.사용자정의ToolStripMenuItem, this.ToolStripSeparator13, this.모든상담사배정ToolStripMenuItem, this.로그인상담사배정ToolStripMenuItem, this.ToolStripSeparator10, this.접속중인상담원에게만강제배분ToolStripMenuItem });
		this.ContextMenuStrip3.Name = "ContextMenuStrip2";
		this.ContextMenuStrip3.ShowImageMargin = false;
		this.ContextMenuStrip3.Size = new System.Drawing.Size(134, 104);
		this.사용자정의ToolStripMenuItem.Name = "사용자정의ToolStripMenuItem";
		this.사용자정의ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
		this.사용자정의ToolStripMenuItem.Text = "사용자 정의";
		this.사용자정의ToolStripMenuItem.ToolTipText = "자동 배분할 갯수를 사용자가 직접 정의합니다.";
		this.ToolStripSeparator13.Name = "ToolStripSeparator13";
		this.ToolStripSeparator13.Size = new System.Drawing.Size(130, 6);
		this.모든상담사배정ToolStripMenuItem.Name = "모든상담사배정ToolStripMenuItem";
		this.모든상담사배정ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
		this.모든상담사배정ToolStripMenuItem.Text = "모든 상담원";
		this.모든상담사배정ToolStripMenuItem.ToolTipText = "등록된 상담원들에게 각각 일정 비율의 고객데이터를 배정합니다.\r\n이미 상담원이 할당되어있는 고객데이터의 경우 배정되지 않습니다.\r\n관리자에게는 배분되지 않습니다.";
		this.로그인상담사배정ToolStripMenuItem.Name = "로그인상담사배정ToolStripMenuItem";
		this.로그인상담사배정ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
		this.로그인상담사배정ToolStripMenuItem.Text = "접속중인 상담원";
		this.로그인상담사배정ToolStripMenuItem.ToolTipText = "접속중인 상담원들에게 각각 일정 비율의 고객데이터를 배정합니다.\r\n이미 상담원이 할당되어있는 고객데이터의 경우 배정되지 않습니다.";
		this.ToolStripSeparator10.Name = "ToolStripSeparator10";
		this.ToolStripSeparator10.Size = new System.Drawing.Size(130, 6);
		this.접속중인상담원에게만강제배분ToolStripMenuItem.Name = "접속중인상담원에게만강제배분ToolStripMenuItem";
		this.접속중인상담원에게만강제배분ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
		this.접속중인상담원에게만강제배분ToolStripMenuItem.Text = "강제 배분";
		this.접속중인상담원에게만강제배분ToolStripMenuItem.ToolTipText = "기존 배분을 모두 강제 회수하고 새로 배분합니다.\r\n배포 중이면 통화 중인 상담원은 회수되지 않습니다.";
		this.miniToolStrip.AccessibleName = "새 항목 선택";
		this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
		this.miniToolStrip.AutoSize = false;
		this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
		this.miniToolStrip.Location = new System.Drawing.Point(202, 24);
		this.miniToolStrip.Name = "miniToolStrip";
		this.miniToolStrip.Size = new System.Drawing.Size(515, 22);
		this.miniToolStrip.TabIndex = 4;
		this.time.Enabled = true;
		this.time.Interval = 1000;
		this.DataGridViewTextBoxColumn44.HeaderText = "주소";
		this.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44";
		this.DataGridViewTextBoxColumn44.ReadOnly = true;
		this.DataGridViewTextBoxColumn44.Width = 600;
		this.DataGridViewTextBoxColumn43.HeaderText = "집전화";
		this.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43";
		this.DataGridViewTextBoxColumn43.ReadOnly = true;
		this.DataGridViewTextBoxColumn43.Width = 120;
		this.DataGridViewTextBoxColumn42.HeaderText = "휴대전화";
		this.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42";
		this.DataGridViewTextBoxColumn42.ReadOnly = true;
		this.DataGridViewTextBoxColumn42.Width = 120;
		this.DataGridViewTextBoxColumn41.HeaderText = "연령";
		this.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41";
		this.DataGridViewTextBoxColumn41.ReadOnly = true;
		this.DataGridViewTextBoxColumn41.Width = 50;
		this.DataGridViewTextBoxColumn40.HeaderText = "성별";
		this.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40";
		this.DataGridViewTextBoxColumn40.ReadOnly = true;
		this.DataGridViewTextBoxColumn40.Width = 50;
		this.DataGridViewTextBoxColumn39.HeaderText = "주민번호";
		this.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39";
		this.DataGridViewTextBoxColumn39.ReadOnly = true;
		this.DataGridViewTextBoxColumn39.Width = 120;
		this.DataGridViewTextBoxColumn38.HeaderText = "고객명";
		this.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38";
		this.DataGridViewTextBoxColumn38.ReadOnly = true;
		this.DataGridViewTextBoxColumn38.Width = 80;
		this.DataGridViewTextBoxColumn37.HeaderText = "NO";
		this.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37";
		this.DataGridViewTextBoxColumn37.ReadOnly = true;
		this.DataGridViewTextBoxColumn37.Width = 70;
		this.ContextMenuStrip4.AllowMerge = false;
		this.ContextMenuStrip4.ImageScalingSize = new System.Drawing.Size(0, 0);
		this.ContextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.일괄회수ToolStripMenuItem, this.미처리회수ToolStripMenuItem });
		this.ContextMenuStrip4.Name = "ContextMenuStrip4";
		this.ContextMenuStrip4.ShowImageMargin = false;
		this.ContextMenuStrip4.Size = new System.Drawing.Size(170, 48);
		this.일괄회수ToolStripMenuItem.Name = "일괄회수ToolStripMenuItem";
		this.일괄회수ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
		this.일괄회수ToolStripMenuItem.Text = "일괄 회수";
		this.일괄회수ToolStripMenuItem.ToolTipText = "모든 항목을 일괄 회수합니다.";
		this.미처리회수ToolStripMenuItem.Name = "미처리회수ToolStripMenuItem";
		this.미처리회수ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
		this.미처리회수ToolStripMenuItem.Text = "미처리 항목 일괄 회수";
		this.미처리회수ToolStripMenuItem.ToolTipText = "미처리된 항목을 일괄 회수 합니다.";
		this.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.DataGridViewImageColumn1.FillWeight = 50f;
		this.DataGridViewImageColumn1.HeaderText = "";
		this.DataGridViewImageColumn1.Image = mlas_root.My.Resources.Resources.Stop_sign;
		this.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1";
		this.DataGridViewImageColumn1.ReadOnly = true;
		this.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridViewImageColumn1.Width = 30;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1084, 661);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.bottomBar);
		this.DoubleBuffered = true;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.KeyPreview = true;
		this.MinimumSize = new System.Drawing.Size(800, 400);
		base.Name = "ssorder_cti";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.agents_grid).EndInit();
		this.ContextMenuStrip1.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.TabPage2.ResumeLayout(false);
		this.SplitContainer1.Panel1.ResumeLayout(false);
		this.SplitContainer1.Panel2.ResumeLayout(false);
		this.SplitContainer1.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.db_grid).EndInit();
		this.Panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.table_grid).EndInit();
		this.DoubleBufferPanel1.ResumeLayout(false);
		this.DoubleBufferPanel1.PerformLayout();
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		this.TabPage3.ResumeLayout(false);
		this.agentpanel.ResumeLayout(false);
		this.agentpanel.PerformLayout();
		this.Panel5.ResumeLayout(false);
		this.TabControl2.ResumeLayout(false);
		this.tm1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tm_grid_all).EndInit();
		this.tm2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tm_grid_call_log).EndInit();
		this.tm3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tm_grid_miss).EndInit();
		this.TabPage5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tm_grid_call_out).EndInit();
		this.tm5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tm_grid_agree).EndInit();
		this.tm6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tm_grid_reserve).EndInit();
		this.TabPage6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tm_grid_blacklist).EndInit();
		this.DoubleBufferPanel2.ResumeLayout(false);
		this.DoubleBufferPanel2.PerformLayout();
		this.Panel4.ResumeLayout(false);
		this.DoubleBufferPanel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.tm_grid_calling).EndInit();
		this.GroupBox1.ResumeLayout(false);
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.bottomBar.ResumeLayout(false);
		this.bottomBar.PerformLayout();
		this.ContextMenuStrip3.ResumeLayout(false);
		this.ContextMenuStrip4.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public void MakeGridViewDoubleBuffered(DataGridView dgv)
	{
		dgv.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgv, true, null);
	}

	private void table_close_Click(object sender, EventArgs e)
	{
		getDB(refresh: true);
		SplitContainer1.Panel1Collapsed = false;
		SplitContainer1.Panel2Collapsed = true;
		db_back.Visible = false;
		ToolStripSeparator1.Visible = false;
		db_refresh.Visible = true;
		db_save.Visible = true;
		ToolStripSeparator4.Visible = true;
		db_start_stop.Visible = true;
		ToolStripSeparator5.Visible = true;
		db_restore.Visible = true;
		ToolStripSeparator6.Visible = true;
		db_output.Visible = true;
		db_agree_output.Visible = true;
		db_auto_split.Visible = true;
		selectDbInit();
		db_restore.ToolTipText = "[회수]\r\n배정된 담당자를 회수하여 재배치가 가능한 상태로 변경합니다.\r\n배포 중이면 통화 중인 상담원은 회수되지 않습니다.";
	}

	private void ssorder_cti_Load(object sender, EventArgs e)
	{
		MakeGridViewDoubleBuffered(db_grid);
		MakeGridViewDoubleBuffered(agents_grid);
		MakeGridViewDoubleBuffered(table_grid);
		tabPages.Add(TabControl1.TabPages[0]);
		tabPages.Add(TabControl1.TabPages[1]);
		tabPages.Add(TabControl1.TabPages[2]);
		tabPages.Add(TabControl1.TabPages[3]);
		string text = $"{(double)ssorder.ssorder_version / 100.0:0.00}";
		if (ssorder.ssorder_acgb == 5)
		{
			agentLogin = false;
			TabControl1.TabPages.Remove(tabPages[2]);
			TabControl1.TabPages.Remove(tabPages[3]);
			SplitContainer1.Panel2Collapsed = true;
			getAgents();
			getDB();
			Text = "상담사 데이터베이스 관리자 v" + text;
		}
		else
		{
			agentLogin = true;
			nowtable = tm_grid_all;
			TabControl1.TabPages.Remove(tabPages[0]);
			TabControl1.TabPages.Remove(tabPages[1]);
			TabControl1.TabPages.Remove(tabPages[2]);
			TabControl1.TabPages.Remove(tabPages[3]);
			base.Controls.Remove(TabControl1);
			base.Controls.Add(agentpanel);
			timeLabel.Text = DateTime.Now.ToString();
			string text2 = ssorder.ssorder_acgb switch
			{
				1 => "관리자", 
				2 => "일반", 
				3 => "최고관리자", 
				4 => "재고관리자", 
				5 => "루트계정", 
				_ => "일반", 
			};
			Text = " [상담원 : " + Module1._id + " / " + ssorder.ssorder_gb2 + "] [권한-" + text2 + "] 상담사 프로그램 v" + text;
		}
		default_directory = Environment.CurrentDirectory;
	}

	private void ssorder_cti_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (Conversions.ToBoolean(Operators.AndObject(agentLogin, logging_in)))
		{
			logout();
			logging_in = false;
		}
		MyProject.Forms.mlas.Show();
	}

	public void getAgents()
	{
		JObject jObject = new JObject();
		jObject.Add("type", "getAgents");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		string postData = "args=" + jObject.ToString(Formatting.None);
		string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_get.php")), postData, progress: true).getHTML(this);
		checked
		{
			try
			{
				JObject jObject2 = JObject.Parse(hTML);
				if (jObject2.SelectToken("response").Equals("fail"))
				{
					Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
					busy = false;
					return;
				}
				agents_grid.Rows.Clear();
				ctiAgents = JsonConvert.DeserializeObject<List<cti_agents>>((string)jObject2.SelectToken("output"));
				int num = 0;
				ContextMenuStrip2.Items.Clear();
				foreach (cti_agents ctiAgent in ctiAgents)
				{
					if (ctiAgent.expire == 0)
					{
						agents_grid.Rows.Add(ctiAgent.idx, ctiAgent.account_id, ctiAgent.account_name, ctiAgent.regist_date, ctiAgent.expire_date, ctiAgent.LoggingStateString(), ctiAgent.last_date);
						Color black = Color.Black;
						int? logging = ctiAgent.logging;
						int? num2 = logging;
						if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							black = Color.Blue;
						}
						else
						{
							num2 = logging;
							black = ((!(num2.HasValue ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault()) ? Color.DarkGray : Color.DarkRed);
						}
						agents_grid.Rows[agents_grid.Rows.Count - 1].Cells[5].Style.ForeColor = black;
						ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(ctiAgent.account_name, null);
						toolStripMenuItem.Tag = ctiAgent;
						ContextMenuStrip2.Items.Add(toolStripMenuItem);
						num++;
					}
				}
				if (num != 0)
				{
					agents_grid.Rows[0].Selected = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				busy = false;
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex2.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				ProjectData.ClearProjectError();
			}
			Label2.Text = "총 " + Conversions.ToString(agents_grid.Rows.Count) + "개 레코드 검색됨.";
			busy = false;
		}
	}

	public List<cti_db> getDB(bool refresh = false, string flag = null)
	{
		JObject jObject = new JObject();
		jObject.Add("type", "getDB");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("flag", flag);
		string postData = "args=" + jObject.ToString(Formatting.None);
		string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_get.php")), postData, progress: true).getHTML(this);
		try
		{
			JObject jObject2 = JObject.Parse(hTML);
			if (jObject2.SelectToken("response").Equals("fail"))
			{
				Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
				busy = false;
				return null;
			}
			if (flag != null)
			{
				busy = false;
				return JsonConvert.DeserializeObject<List<cti_db>>((string)jObject2.SelectToken("output"));
			}
			db_grid.Rows.Clear();
			ctiDbClass = JsonConvert.DeserializeObject<List<cti_db>>((string)jObject2.SelectToken("output"));
			Image image = Resources.Stop_sign;
			bool flag2 = false;
			foreach (cti_db item in ctiDbClass)
			{
				if (!flag2 && !refresh)
				{
					selectDb = item;
					flag2 = true;
				}
				switch (item.status)
				{
				case 0:
					image = Resources.Stop_sign;
					break;
				case 1:
					image = Resources.play_new;
					break;
				}
				JArray jArray = JArray.Parse(item.call_counts);
				int[] array = new int[9]
				{
					Conversions.ToInteger(jArray[0].ToString()),
					Conversions.ToInteger(jArray[1].ToString()),
					Conversions.ToInteger(jArray[2].ToString()),
					Conversions.ToInteger(jArray[3].ToString()),
					Conversions.ToInteger(jArray[4].ToString()),
					Conversions.ToInteger(jArray[5].ToString()),
					Conversions.ToInteger(jArray[6].ToString()),
					Conversions.ToInteger(jArray[7].ToString()),
					Conversions.ToInteger(jArray[8].ToString())
				};
				checked
				{
					int num = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6];
					db_grid.Rows.Add(image, item.idx, item.name, item.nosplit_count, num, array[0], array[1], array[2], array[3], array[4], array[7], array[8], item.blacklist_count, item.last_date);
					if ((refresh & (selectDb != null)) && item.idx == selectDb.idx)
					{
						selectDb = item;
					}
					if (item.status == 1)
					{
						db_grid.Rows[db_grid.Rows.Count - 1].Cells[2].ReadOnly = true;
					}
				}
			}
			db_status.Text = "서버에 " + Conversions.ToString(ctiDbClass.Count) + "개의 데이터베이스가 있습니다.";
			if (ctiDbClass.Count != 0 && !refresh)
			{
				db_grid.Rows[0].Selected = true;
			}
			if (refresh & (selectDb != null))
			{
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = ((IEnumerable)db_grid.Rows).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator2.Current;
						if (Conversions.ToDouble(dataGridViewRow.Cells[1].Value.ToString()) == (double)selectDb.idx)
						{
							dataGridViewRow.Selected = true;
							break;
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
			selectDbInit();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			busy = false;
			CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex2.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			ProjectData.ClearProjectError();
		}
		busy = false;
		return null;
	}

	private void db_grid_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		selectDbInit();
	}

	private void db_back_Click(object sender, EventArgs e)
	{
		foreach (cti_db item in ctiDbClass)
		{
			item.blacklistViewMode = false;
		}
		table_close_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void selectDbInit()
	{
		selectDb = ctiDbClass.Find((cti_db a) => Operators.ConditionalCompareObjectEqual(a.idx, db_grid.SelectedRows[0].Cells[1].Value, TextCompare: false) ? true : false);
		if (selectDb == null)
		{
			db_start_stop.Visible = false;
			ToolStripSeparator5.Visible = false;
			ToolStripSeparator4.Visible = false;
			db_save.Visible = false;
			db_delete.Visible = false;
			ToolStripSeparator2.Visible = false;
			db_auto_split.Visible = false;
			db_split.Visible = false;
			db_restore.Visible = false;
			ToolStripSeparator6.Visible = false;
			db_output.Visible = false;
			db_agree_output.Visible = false;
			db_filter.Visible = false;
			db_blacklist_reset.Visible = false;
			cmenu_start.Visible = false;
			cmenu_stop.Visible = false;
			ToolStripSeparator8.Visible = false;
			ToolStripSeparator3.Visible = false;
			cmenu_save.Visible = false;
			cmenu_delete.Visible = false;
			ToolStripSeparator7.Visible = false;
			cmenu_auto.Visible = false;
			cmenu_split.Visible = false;
			cmenu_restore.Visible = false;
			ToolStripSeparator9.Visible = false;
			cmenu_output.Visible = false;
			cmenu_agree_output.Visible = false;
			ToolStripSeparator15.Visible = false;
			cmenu_filter.Visible = false;
			cmenu_blacklist_reset.Visible = false;
			return;
		}
		dbName.Text = selectDb.name;
		switch (selectDb.status)
		{
		case 0:
			db_start_stop.Visible = true;
			ToolStripSeparator5.Visible = true;
			ToolStripSeparator4.Visible = true;
			db_start_stop.Image = Resources.play_new;
			db_start_stop.ToolTipText = "배포 시작";
			cmenu_start.Visible = true;
			cmenu_stop.Visible = false;
			db_save.Visible = true;
			db_delete.Visible = true;
			ToolStripSeparator2.Visible = true;
			ToolStripSeparator5.Visible = true;
			ToolStripSeparator4.Visible = true;
			db_auto_split.Visible = true;
			db_split.Visible = true;
			db_restore.Visible = true;
			ToolStripSeparator6.Visible = true;
			db_output.Visible = true;
			db_agree_output.Visible = true;
			db_filter.Visible = true;
			db_blacklist_reset.Visible = true;
			ToolStripSeparator8.Visible = true;
			ToolStripSeparator3.Visible = true;
			cmenu_save.Visible = true;
			cmenu_delete.Visible = true;
			ToolStripSeparator7.Visible = true;
			cmenu_auto.Visible = true;
			cmenu_split.Visible = true;
			cmenu_restore.Visible = true;
			ToolStripSeparator9.Visible = true;
			cmenu_output.Visible = true;
			cmenu_agree_output.Visible = true;
			ToolStripSeparator15.Visible = true;
			cmenu_filter.Visible = true;
			cmenu_blacklist_reset.Visible = true;
			break;
		case 1:
			db_start_stop.Visible = true;
			ToolStripSeparator5.Visible = true;
			ToolStripSeparator4.Visible = true;
			db_start_stop.Image = Resources.Stop_sign;
			db_start_stop.ToolTipText = "배포 중단";
			cmenu_start.Visible = false;
			cmenu_stop.Visible = true;
			db_save.Visible = false;
			db_delete.Visible = false;
			ToolStripSeparator2.Visible = false;
			db_auto_split.Visible = true;
			ToolStripSeparator6.Visible = false;
			db_output.Visible = false;
			db_agree_output.Visible = false;
			db_filter.Visible = false;
			db_blacklist_reset.Visible = false;
			ToolStripSeparator8.Visible = true;
			ToolStripSeparator3.Visible = false;
			cmenu_save.Visible = false;
			cmenu_delete.Visible = false;
			ToolStripSeparator7.Visible = true;
			cmenu_auto.Visible = true;
			cmenu_split.Visible = true;
			cmenu_restore.Visible = true;
			ToolStripSeparator9.Visible = false;
			cmenu_output.Visible = false;
			cmenu_agree_output.Visible = false;
			ToolStripSeparator15.Visible = false;
			cmenu_filter.Visible = false;
			cmenu_blacklist_reset.Visible = false;
			break;
		}
		if (SplitContainer1.Panel1Collapsed)
		{
			db_add.Visible = false;
			db_refresh.Visible = false;
			db_get_data.Visible = true;
			db_save.Visible = false;
			db_delete.Visible = true;
			db_filter.Visible = false;
			db_blacklist_reset.Visible = false;
			ToolStripSeparator4.Visible = false;
			db_delete.ToolTipText = "선택 삭제";
			ToolStripSeparator2.Visible = true;
			db_start_stop.Visible = false;
			ToolStripSeparator5.Visible = false;
			db_restore.ToolTipText = "[선택 회수]\r\n배정된 담당자를 회수하여 재배치가 가능한 상태로 변경합니다.\r\n배포 중이면 통화 중인 상담원은 회수되지 않습니다.";
			ToolStripSeparator6.Visible = false;
			db_output.Visible = false;
			db_agree_output.Visible = false;
			db_auto_split.Visible = false;
		}
	}

	private void db_split_Click(object sender, EventArgs e)
	{
		if (!SplitContainer1.Panel1Collapsed)
		{
			table_grid.Visible = false;
			selectDb.blacklistViewMode = false;
			CheckBox2.Checked = false;
			int cusData = selectDb.getCusData(table_grid);
			try
			{
				ComboBoxEx1.SelectedIndex = selectDb.now_page;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			table_grid.Visible = true;
			SplitContainer1.Panel1Collapsed = true;
			SplitContainer1.Panel2Collapsed = false;
			dbName.Text = selectDb.name;
			db_status.Text = "총 " + Conversions.ToString(selectDb.max_page) + " 페이지, 총 " + Conversions.ToString(cusData) + "개 레코드 검색됨.";
			db_back.Visible = true;
			ToolStripSeparator1.Visible = true;
			selectDbInit();
		}
		else
		{
			Rectangle bounds = db_split.Bounds;
			new Point(bounds.Left, bounds.Bottom);
			ContextMenuStrip2.Show(ToolStrip1, ToolStrip1.PointToClient(Cursor.Position));
		}
	}

	private void db_restore_Click(object sender, EventArgs e)
	{
		if (SplitContainer1.Panel2Collapsed)
		{
			Rectangle bounds = db_split.Bounds;
			new Point(bounds.Left, bounds.Bottom);
			ContextMenuStrip4.Show(ToolStrip1, ToolStrip1.PointToClient(Cursor.Position));
			return;
		}
		List<string> list = new List<string>();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = table_grid.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				list.Add(dataGridViewRow.Cells[0].Value.ToString());
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
			return;
		}
		string text = JsonConvert.SerializeObject(list);
		JObject jObject = new JObject();
		jObject.Add("type", "dbRestore");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("idx", selectDb.idx);
		jObject.Add("idxs", Module1.Base64Encode(text.ToString()));
		string postData = "args=" + jObject.ToString(Formatting.None);
		checked
		{
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
					bool flag = false;
					IEnumerator enumerator2 = default(IEnumerator);
					try
					{
						enumerator2 = table_grid.SelectedRows.GetEnumerator();
						_Closure_0024__1036_002D0 closure_0024__1036_002D = default(_Closure_0024__1036_002D0);
						while (enumerator2.MoveNext())
						{
							closure_0024__1036_002D = new _Closure_0024__1036_002D0(closure_0024__1036_002D);
							closure_0024__1036_002D._0024VB_0024Local_row = (DataGridViewRow)enumerator2.Current;
							bool flag2 = false;
							foreach (JToken item in (IEnumerable<JToken>)jObject2.SelectToken("nolist"))
							{
								if ((double)(int)item == Conversions.ToDouble(closure_0024__1036_002D._0024VB_0024Local_row.Cells[0].Value.ToString()))
								{
									flag2 = true;
									flag = true;
								}
							}
							if (!flag2)
							{
								selectDb.ctiTMList.Find(closure_0024__1036_002D._Lambda_0024__0).agent_idx = null;
								selectDb.nosplit_count--;
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
					db_grid.SelectedRows[0].Cells[3].Value = selectDb.nosplit_count;
					if (flag)
					{
						CustomMsgBox.CMsgBox("일부 상담사가 통화중이므로 회수할 수 없습니다. 통화중이 아니라면 데이터베이스를 중단후 회수를 시도하십시오. 통화중 레코드NO:" + jObject2.SelectToken("nolist").ToString(Formatting.None), "상담사 통화중", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Exclamation);
					}
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
	}

	private void 일괄회수ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		JObject jObject = new JObject();
		jObject.Add("type", "dbRestore");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("idx", selectDb.idx);
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
				if (selectDb.ctiTMList != null)
				{
					foreach (cti_tm_list ctiTM in selectDb.ctiTMList)
					{
						ctiTM.agent_idx = null;
					}
				}
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
			return;
		}
		getDB(refresh: true);
	}

	private void 미처리회수ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		JObject jObject = new JObject();
		jObject.Add("type", "dbRestore");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("idx", selectDb.idx);
		jObject.Add("option", 0);
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
				if (selectDb.ctiTMList != null)
				{
					foreach (cti_tm_list ctiTM in selectDb.ctiTMList)
					{
						ctiTM.agent_idx = null;
					}
				}
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
			return;
		}
		getDB(refresh: true);
	}

	private void db_output_Click(object sender, EventArgs e)
	{
		backupSub(selectDb.name);
	}

	private void db_agree_output_Click(object sender, EventArgs e)
	{
		backupSub(selectDb.name + "_동의리스트", 1);
	}

	private void backupSub(string fileName, int? resultNumber = null)
	{
		if (Conversions.ToBoolean(busy))
		{
			return;
		}
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			SaveFileDialog saveFileDialog2 = saveFileDialog;
			saveFileDialog2.Filter = "*.csv|*.csv";
			saveFileDialog2.FileName = fileName + "_" + Strings.Format(DateAndTime.Now, "[yyyy-MM-dd]_[HH-mm-ss]") + ".csv";
			saveFileDialog2.InitialDirectory = Conversions.ToString(default_directory);
			saveFileDialog2.Title = "저장할 경로를 지정하세요.";
			if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			if (saveFileDialog2.FileName.ToLower().LastIndexOf("csv") < 0)
			{
				MessageBox.Show("CSV 확장자가 아니면 내보낼 수 없습니다!", "확장자 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			default_directory = saveFileDialog2.FileName;
			saveFileDialog2 = null;
			base.Enabled = false;
			busy = true;
			List<cti_tm_list> list = selectDb.ExportReport(null, resultNumber, blacklistOutput: true);
			if (list == null)
			{
				return;
			}
			string text = null;
			string value = "NO,상담원명,고객명,집전화,휴대전화,주소,제품명,구매처,금액,시도수,통화번호,TM결과,비고1,비고2,블랙리스트여부";
			using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, append: false, Encoding.Default))
			{
				streamWriter.WriteLine(value);
				foreach (cti_tm_list item in list)
				{
					text = null;
					string[] array = item.getArray();
					foreach (string text2 in array)
					{
						text = ((Operators.CompareString(text2, null, TextCompare: false) != 0) ? ((!text2.Contains(",")) ? (text + text2.Trim() + ",") : (text + "\"" + text2.Trim() + "\",")) : (text + ","));
					}
					streamWriter.WriteLine(text.Replace("\r\n", ""));
					Application.DoEvents();
				}
			}
			MessageBox.Show("리스트 내보내기가 완료되었습니다.", "내보내기 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("리스트 내보내기에 실패 했습니다.\r\n\r\n" + ex2.Message, "내보내기 오류", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			ProjectData.ClearProjectError();
		}
		busy = false;
		base.Enabled = true;
	}

	private void db_start_stop_Click(object sender, EventArgs e)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = db_grid.SelectedRows.GetEnumerator();
			_Closure_0024__1043_002D0 closure_0024__1043_002D = default(_Closure_0024__1043_002D0);
			while (enumerator.MoveNext())
			{
				closure_0024__1043_002D = new _Closure_0024__1043_002D0(closure_0024__1043_002D);
				closure_0024__1043_002D._0024VB_0024Local_row = (DataGridViewRow)enumerator.Current;
				cti_db cti_db2 = ctiDbClass.Find(closure_0024__1043_002D._Lambda_0024__0);
				int idx = cti_db2.idx;
				int num = 0;
				switch (cti_db2.status)
				{
				case 0:
					closure_0024__1043_002D._0024VB_0024Local_row.Cells[2].ReadOnly = true;
					num = 1;
					break;
				case 1:
					closure_0024__1043_002D._0024VB_0024Local_row.Cells[2].ReadOnly = false;
					num = 0;
					break;
				}
				JObject jObject = new JObject();
				jObject.Add("type", "setDB");
				jObject.Add("id", Module1._id);
				jObject.Add("pw", Module1._pw);
				jObject.Add("idx", idx);
				jObject.Add("status", num);
				string postData = "args=" + jObject.ToString(Formatting.None);
				string hTML = new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_set.php")), postData, progress: true).getHTML(this);
				try
				{
					JObject jObject2 = JObject.Parse(hTML);
					if (jObject2.SelectToken("response").Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
					cti_db2.status = num;
					switch (cti_db2.status)
					{
					case 0:
						closure_0024__1043_002D._0024VB_0024Local_row.Cells[0].Value = Resources.Stop_sign;
						break;
					case 1:
						closure_0024__1043_002D._0024VB_0024Local_row.Cells[0].Value = Resources.play_new;
						cti_db2.last_date = (string)jObject2.SelectToken("output");
						closure_0024__1043_002D._0024VB_0024Local_row.Cells[13].Value = cti_db2.last_date;
						break;
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
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		selectDbInit();
	}

	private void db_get_data_Click(object sender, EventArgs e)
	{
		if (!SplitContainer1.Panel1Collapsed)
		{
			MyProject.Forms.cti_import.db_input_mode = false;
		}
		else
		{
			MyProject.Forms.cti_import.db_input_mode = true;
		}
		MyProject.Forms.cti_import.Size = new Size(536, 354);
		MyProject.Forms.cti_import.ShowDialog();
	}

	private void db_refresh_Click(object sender, EventArgs e)
	{
		getDB(refresh: true);
	}

	private void db_add_Click(object sender, EventArgs e)
	{
		_ = SplitContainer1.Panel1Collapsed;
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		agents_grid.Rows.Clear();
		if (ctiAgents == null)
		{
			return;
		}
		foreach (cti_agents ctiAgent in ctiAgents)
		{
			if (!(CheckBox1.Checked & ctiAgent.expire.Equals(1)))
			{
				agents_grid.Rows.Add(ctiAgent.idx, ctiAgent.account_id, ctiAgent.account_name, ctiAgent.regist_date, ctiAgent.expire_date, ctiAgent.LoggingStateString(), ctiAgent.last_date);
				Color black = Color.Black;
				int? logging = ctiAgent.logging;
				int? num = logging;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					black = Color.Blue;
				}
				else
				{
					num = logging;
					black = ((!(num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault()) ? Color.DarkGray : Color.DarkRed);
				}
				agents_grid.Rows[checked(agents_grid.Rows.Count - 1)].Cells[5].Style.ForeColor = black;
			}
		}
		Label2.Text = "총 " + Conversions.ToString(agents_grid.Rows.Count) + "개 레코드 검색됨.";
	}

	private void cmenu_start_Click(object sender, EventArgs e)
	{
		db_start_stop_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cmenu_stop_Click(object sender, EventArgs e)
	{
		db_start_stop_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cmenu_new_Click(object sender, EventArgs e)
	{
	}

	private void cmenu_import_Click(object sender, EventArgs e)
	{
		db_get_data_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void 새로고침ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		db_refresh_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cmenu_save_Click(object sender, EventArgs e)
	{
		db_save_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cmenu_delete_Click(object sender, EventArgs e)
	{
		db_delete_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ToolStripMenuItem8_Click(object sender, EventArgs e)
	{
		db_split_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cmenu_restore_Click(object sender, EventArgs e)
	{
		db_restore_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cmenu_output_Click(object sender, EventArgs e)
	{
		db_output_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void cmenu_agree_output_Click(object sender, EventArgs e)
	{
		db_agree_output_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void db_save_Click(object sender, EventArgs e)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = db_grid.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				JObject jObject = new JObject();
				jObject.Add("type", "setDB");
				jObject.Add("id", Module1._id);
				jObject.Add("pw", Module1._pw);
				jObject.Add("idx", dataGridViewRow.Cells[1].Value.ToString());
				jObject.Add("name", dataGridViewRow.Cells[2].Value.ToString());
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
						MessageBox.Show("데이터베이스 이름 [" + selectDb.name + " -> " + dataGridViewRow.Cells[2].Value.ToString() + "] 변경되었습니다.", "이름 변경 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						ctiDbClass.Find((cti_db a) => Operators.ConditionalCompareObjectEqual(a.idx, db_grid.SelectedRows[0].Cells[1].Value, TextCompare: false) ? true : false).name = dataGridViewRow.Cells[2].Value.ToString();
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
		selectDbInit();
	}

	private void db_delete_Click(object sender, EventArgs e)
	{
		if (!SplitContainer1.Panel1Collapsed)
		{
			if (MessageBox.Show(selectDb.name + " 데이터베이스를 삭제하시겠습니까?", "데이터베이스 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				return;
			}
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = db_grid.SelectedRows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
					JObject jObject = new JObject();
					jObject.Add("type", "delDB");
					jObject.Add("id", Module1._id);
					jObject.Add("pw", Module1._pw);
					jObject.Add("idx", dataGridViewRow.Cells[1].Value.ToString());
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
							cti_db item = ctiDbClass.Find((cti_db a) => Operators.ConditionalCompareObjectEqual(a.idx, db_grid.SelectedRows[0].Cells[1].Value, TextCompare: false) ? true : false);
							ctiDbClass.Remove(item);
							db_grid.Rows.Remove(dataGridViewRow);
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
			try
			{
				db_grid.ClearSelection();
				db_grid.Rows[checked(db_grid.Rows.Count - 1)].Selected = true;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				selectDb = null;
				ProjectData.ClearProjectError();
			}
			MessageBox.Show("데이터베이스가 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			selectDbInit();
		}
		else
		{
			if (MessageBox.Show("선택한 고객 데이터를 삭제하시겠습니까?", "고객 데이터 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				return;
			}
			List<string> list = new List<string>();
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = table_grid.SelectedRows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)enumerator2.Current;
					list.Add(dataGridViewRow2.Cells[0].Value.ToString());
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			if (list.Count <= 0)
			{
				return;
			}
			string text = JsonConvert.SerializeObject(list);
			JObject jObject3 = new JObject();
			jObject3.Add("type", "delCustomer");
			jObject3.Add("id", Module1._id);
			jObject3.Add("pw", Module1._pw);
			jObject3.Add("db_idx", selectDb.idx);
			jObject3.Add("idxs", Module1.Base64Encode(text.ToString()));
			string postData2 = "args=" + jObject3.ToString(Formatting.None);
			try
			{
				JObject jObject4 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_set.php")), postData2, progress: true).getHTML(this));
				if (jObject4.SelectToken("response").Equals("fail"))
				{
					Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
					busy = false;
					return;
				}
				JToken jToken2 = jObject4.SelectToken("response");
				if ((string)jToken2 == "ok")
				{
					bool flag = false;
					List<cti_tm_list> list2 = new List<cti_tm_list>();
					List<DataGridViewRow> list3 = new List<DataGridViewRow>();
					IEnumerator enumerator3 = default(IEnumerator);
					try
					{
						enumerator3 = table_grid.SelectedRows.GetEnumerator();
						_Closure_0024__1060_002D0 closure_0024__1060_002D = default(_Closure_0024__1060_002D0);
						while (enumerator3.MoveNext())
						{
							closure_0024__1060_002D = new _Closure_0024__1060_002D0(closure_0024__1060_002D);
							closure_0024__1060_002D._0024VB_0024Local_row = (DataGridViewRow)enumerator3.Current;
							bool flag2 = false;
							foreach (JToken item3 in (IEnumerable<JToken>)jObject4.SelectToken("nolist"))
							{
								if ((double)(int)item3 == Conversions.ToDouble(closure_0024__1060_002D._0024VB_0024Local_row.Cells[0].Value.ToString()))
								{
									flag2 = true;
									flag = true;
								}
							}
							if (!flag2)
							{
								cti_tm_list item2 = selectDb.ctiTMList.Find(closure_0024__1060_002D._Lambda_0024__1);
								list2.Add(item2);
								list3.Add(closure_0024__1060_002D._0024VB_0024Local_row);
							}
						}
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					foreach (cti_tm_list item4 in list2)
					{
						selectDb.ctiTMList.Remove(item4);
					}
					foreach (DataGridViewRow item5 in list3)
					{
						table_grid.Rows.Remove(item5);
					}
					if (flag)
					{
						CustomMsgBox.CMsgBox("일부 상담사가 통화중이므로 삭제할 수 없습니다. 통화중이 아니라면 데이터베이스를 중단후 삭제를 시도하십시오. 통화중 레코드NO:" + jObject4.SelectToken("nolist").ToString(Formatting.None), "상담사 통화중", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Exclamation);
					}
					else
					{
						MessageBox.Show("삭제가 완료되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else if ((string)jToken2 == "fail")
				{
					CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject4.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex6.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void db_auto_split_Click(object sender, EventArgs e)
	{
		Rectangle bounds = db_split.Bounds;
		new Point(bounds.Left, bounds.Bottom);
		ContextMenuStrip3.Show(ToolStrip1, ToolStrip1.PointToClient(Cursor.Position));
	}

	private void agent_add_Click(object sender, EventArgs e)
	{
		if (AgentSelectDiag.IsHandleCreated)
		{
			AgentSelectDiag.Close();
		}
		AgentSelectDiag = new Form();
		Form agentSelectDiag = AgentSelectDiag;
		agentSelectDiag.Size = new Size(800, 600);
		agentSelectDiag.StartPosition = FormStartPosition.CenterScreen;
		agentSelectDiag.FormBorderStyle = FormBorderStyle.SizableToolWindow;
		agentSelectDiag.Text = "상담원 추가 (열을 더블클릭 하면 추가됩니다.)";
		agentSelectDiag.ShowIcon = false;
		agentSelectDiag.Controls.Add(MyProject.Forms.android_db_ss_order.p4_centerpanel);
		_ = null;
		AgentSelectDiag.FormClosing += delegate(object a0, FormClosingEventArgs a1)
		{
			productDiagClosing((Form)a0, a1);
		};
		nowDatagridView = agents_grid;
		agentDialog(show: true);
		MyProject.Forms.android_db_ss_order.ss_product_init();
		isProductPageInit = false;
		MyProject.Forms.android_db_ss_order.p4.Dock = DockStyle.Fill;
		AgentSelectDiag.ShowDialog();
	}

	private void productDiagClosing(Form sender, FormClosingEventArgs e)
	{
		MyProject.Forms.android_db_ss_order.p4.Controls.Add(MyProject.Forms.android_db_ss_order.p4_centerpanel);
		MyProject.Forms.android_db_ss_order.p4.Controls.SetChildIndex(MyProject.Forms.android_db_ss_order.p4_centerpanel, 0);
		agentDialog(show: false);
		isProductPageInit = false;
	}

	public void agentDialog(bool show)
	{
		if (show)
		{
			MyProject.Forms.android_db_ss_order.accountGrid.Columns[0].Visible = false;
			MyProject.Forms.android_db_ss_order.accountGrid.Columns[5].Visible = false;
			MyProject.Forms.android_db_ss_order.accountGrid.Columns[7].Visible = false;
			MyProject.Forms.android_db_ss_order.accountGrid.AllowUserToAddRows = false;
			MyProject.Forms.android_db_ss_order.accountGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			MyProject.Forms.android_db_ss_order.accountGrid.MultiSelect = false;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = MyProject.Forms.android_db_ss_order.accountGrid.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					((DataGridViewColumn)enumerator.Current).ReadOnly = true;
				}
				return;
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		MyProject.Forms.android_db_ss_order.accountGrid.Columns[0].Visible = true;
		MyProject.Forms.android_db_ss_order.accountGrid.Columns[5].Visible = true;
		MyProject.Forms.android_db_ss_order.accountGrid.Columns[7].Visible = true;
		MyProject.Forms.android_db_ss_order.accountGrid.AllowUserToAddRows = true;
		MyProject.Forms.android_db_ss_order.accountGrid.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
		MyProject.Forms.android_db_ss_order.accountGrid.MultiSelect = true;
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = MyProject.Forms.android_db_ss_order.accountGrid.Columns.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				((DataGridViewColumn)enumerator2.Current).ReadOnly = false;
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

	public bool addAgent(DataGridViewRow data)
	{
		JObject jObject = new JObject();
		jObject.Add("type", "addAgent");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("account_idx", data.Cells[1].Value.ToString());
		string postData = "args=" + jObject.ToString(Formatting.None);
		JObject jObject2;
		try
		{
			jObject2 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_set.php")), postData, progress: true).getHTML(this));
			JToken jToken = jObject2.SelectToken("response");
			if (!((string)jToken == "ok") && (string)jToken == "fail")
			{
				if ((string)jObject2.SelectToken("cause") == "already_exist")
				{
					CustomMsgBox.CMsgBox("해당 사용자는 이미 등록되어 있습니다. 해촉자인 경우 재등록 하십시오.", "이미 존재하는 사용자", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				}
				else
				{
					Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
				}
				busy = false;
				return false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex2.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		cti_agents cti_agents2 = new cti_agents();
		cti_agents2.idx = (int)jObject2.SelectToken("idx");
		cti_agents2.account_code = (int?)data.Cells[1].Value;
		cti_agents2.account_id = Conversions.ToString(data.Cells[4].Value);
		cti_agents2.account_name = Conversions.ToString(data.Cells[6].Value);
		cti_agents2.regist_date = (string)jObject2.SelectToken("date");
		cti_agents2.logging = 0;
		ctiAgents.Add(cti_agents2);
		agents_grid.Rows.Add(cti_agents2.idx, cti_agents2.account_id, cti_agents2.account_name, cti_agents2.regist_date);
		agents_grid.Rows[checked(agents_grid.Rows.Count - 1)].Cells[5].Style.ForeColor = Color.DarkGray;
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(cti_agents2.account_name, null);
		toolStripMenuItem.Tag = cti_agents2;
		ContextMenuStrip2.Items.Add(toolStripMenuItem);
		return true;
	}

	private void agent_reset_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("선택한 사용자를 재등록 하시겠습니까?", "선택 재등록", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
		{
			return;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = agents_grid.SelectedRows.GetEnumerator();
			_Closure_0024__1069_002D0 closure_0024__1069_002D = default(_Closure_0024__1069_002D0);
			while (enumerator.MoveNext())
			{
				closure_0024__1069_002D = new _Closure_0024__1069_002D0(closure_0024__1069_002D);
				closure_0024__1069_002D._0024VB_0024Local_row = (DataGridViewRow)enumerator.Current;
				cti_agents cti_agents2 = ctiAgents.Find(closure_0024__1069_002D._Lambda_0024__0);
				if (cti_agents2.expire == 0)
				{
					continue;
				}
				JObject jObject = new JObject();
				jObject.Add("type", "agentReset");
				jObject.Add("id", Module1._id);
				jObject.Add("pw", Module1._pw);
				jObject.Add("idx", cti_agents2.idx);
				string postData = "args=" + jObject.ToString(Formatting.None);
				JObject jObject2;
				try
				{
					jObject2 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_set.php")), postData, progress: true).getHTML(this));
					if (jObject2.SelectToken("response").Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex2.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					ProjectData.ClearProjectError();
					return;
				}
				cti_agents2.expire = 0;
				cti_agents2.regist_date = (string)jObject2.SelectToken("output");
				cti_agents2.expire_date = "";
				closure_0024__1069_002D._0024VB_0024Local_row.Cells[3].Value = cti_agents2.regist_date;
				closure_0024__1069_002D._0024VB_0024Local_row.Cells[4].Value = "";
				closure_0024__1069_002D._0024VB_0024Local_row.Cells[5].Value = "-";
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		MessageBox.Show("재등록이 완료되었습니다.", "재등록 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		if (agents_grid.SelectedRows.Count < 2)
		{
			if (agent_delete.Visible)
			{
				agent_reset.Show();
				agent_delete.Hide();
			}
			else
			{
				agent_reset.Hide();
				agent_delete.Show();
			}
		}
	}

	private void agent_delete_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("선택한 사용자를 해촉 하시겠습니까?", "선택 해촉", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
		{
			return;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = agents_grid.SelectedRows.GetEnumerator();
			_Closure_0024__1070_002D0 closure_0024__1070_002D = default(_Closure_0024__1070_002D0);
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				closure_0024__1070_002D = new _Closure_0024__1070_002D0(closure_0024__1070_002D);
				closure_0024__1070_002D._0024VB_0024Local_row = (DataGridViewRow)enumerator.Current;
				cti_agents cti_agents2 = ctiAgents.Find(closure_0024__1070_002D._Lambda_0024__0);
				if (cti_agents2.expire == 1)
				{
					continue;
				}
				ToolStripMenuItem toolStripMenuItem = null;
				try
				{
					enumerator2 = ContextMenuStrip2.Items.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ToolStripMenuItem toolStripMenuItem2 = (ToolStripMenuItem)enumerator2.Current;
						if (((cti_agents)toolStripMenuItem2.Tag).idx == cti_agents2.idx)
						{
							toolStripMenuItem = toolStripMenuItem2;
							break;
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
				if (toolStripMenuItem != null)
				{
					ContextMenuStrip2.Items.Remove(toolStripMenuItem);
				}
				JObject jObject = new JObject();
				jObject.Add("type", "agentDelete");
				jObject.Add("id", Module1._id);
				jObject.Add("pw", Module1._pw);
				jObject.Add("idx", cti_agents2.idx);
				string postData = "args=" + jObject.ToString(Formatting.None);
				JObject jObject2;
				try
				{
					jObject2 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_set.php")), postData, progress: true).getHTML(this));
					if (jObject2.SelectToken("response").Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						return;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex2.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					ProjectData.ClearProjectError();
					return;
				}
				cti_agents2.expire = 1;
				cti_agents2.expire_date = (string)jObject2.SelectToken("output");
				cti_agents2.logging = 0;
				if (CheckBox1.Checked)
				{
					agents_grid.Rows.Remove(closure_0024__1070_002D._0024VB_0024Local_row);
					continue;
				}
				closure_0024__1070_002D._0024VB_0024Local_row.Cells[4].Value = cti_agents2.expire_date;
				Color black = Color.Black;
				int? logging = cti_agents2.logging;
				int? num = logging;
				if ((num.HasValue ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
				{
					black = Color.Blue;
				}
				else
				{
					num = logging;
					black = ((!(num.HasValue ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault()) ? Color.DarkGray : Color.DarkRed);
				}
				closure_0024__1070_002D._0024VB_0024Local_row.Cells[5].Value = cti_agents2.LoggingStateString();
				closure_0024__1070_002D._0024VB_0024Local_row.Cells[5].Style.ForeColor = black;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		MessageBox.Show("해촉이 완료되었습니다.", "해촉 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		if (agents_grid.SelectedRows.Count < 2)
		{
			if (agent_delete.Visible)
			{
				agent_reset.Show();
				agent_delete.Hide();
			}
			else
			{
				agent_reset.Hide();
				agent_delete.Show();
			}
		}
		Label2.Text = "총 " + Conversions.ToString(agents_grid.Rows.Count) + "개 레코드 검색됨.";
	}

	private void ComboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(page_busy))
		{
			ComboBoxEx1.SelectedIndex = selectDb.now_page;
			return;
		}
		page_busy = true;
		selectDb.now_page = ComboBoxEx1.SelectedIndex;
		Conversions.ToInteger(selectDb.getCusData(table_grid, Conversions.ToString(selectDb.now_page), returnFlag: true));
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		checked
		{
			if (selectDb.now_page > 0 && !Conversions.ToBoolean(page_busy))
			{
				page_busy = true;
				selectDb.now_page--;
				Conversions.ToInteger(selectDb.getCusData(table_grid, Conversions.ToString(selectDb.now_page), returnFlag: true));
			}
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		checked
		{
			if (selectDb.now_page < selectDb.max_page - 1)
			{
				if (Conversions.ToBoolean(page_busy))
				{
					ComboBoxEx1.SelectedIndex = selectDb.now_page;
					return;
				}
				page_busy = true;
				selectDb.now_page++;
				Conversions.ToInteger(selectDb.getCusData(table_grid, Conversions.ToString(selectDb.now_page), returnFlag: true));
			}
		}
	}

	private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
		_Closure_0024__1075_002D0 arg = new _Closure_0024__1075_002D0(arg);
		arg._0024VB_0024Me = this;
		arg._0024VB_0024Local_e = e;
		List<string> list = new List<string>();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = table_grid.SelectedRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
				list.Add(dataGridViewRow.Cells[0].Value.ToString());
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
			return;
		}
		string text = JsonConvert.SerializeObject(list);
		JObject jObject = new JObject();
		jObject.Add("type", "putAgent");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("db_idx", selectDb.idx);
		jObject.Add("idxs", Module1.Base64Encode(text.ToString()));
		jObject.Add("agent_idx", NewLateBinding.LateGet(arg._0024VB_0024Local_e.ClickedItem.Tag, null, "account_code", new object[0], null, null, null).ToString());
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
				_Closure_0024__1075_002D2 arg2 = new _Closure_0024__1075_002D2(arg2);
				arg2._0024VB_0024NonLocal__0024VB_0024Closure_2 = arg;
				cti_agents cti_agents2 = ctiAgents.Find((cti_agents a) => Operators.ConditionalCompareObjectEqual(a.account_code, NewLateBinding.LateGet(arg2._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_e.ClickedItem.Tag, null, "account_code", new object[0], null, null, null), TextCompare: false) ? true : false);
				if (cti_agents2 != null)
				{
					arg2._0024VB_0024Local_agentName = cti_agents2.account_name;
				}
				else
				{
					arg2._0024VB_0024Local_agentName = null;
				}
				bool flag = false;
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = table_grid.SelectedRows.GetEnumerator();
					_Closure_0024__1075_002D1 closure_0024__1075_002D = default(_Closure_0024__1075_002D1);
					while (enumerator2.MoveNext())
					{
						closure_0024__1075_002D = new _Closure_0024__1075_002D1(closure_0024__1075_002D);
						closure_0024__1075_002D._0024VB_0024NonLocal__0024VB_0024Closure_3 = arg2;
						closure_0024__1075_002D._0024VB_0024Local_row = (DataGridViewRow)enumerator2.Current;
						bool flag2 = false;
						foreach (JToken item in (IEnumerable<JToken>)jObject2.SelectToken("nolist"))
						{
							if ((double)(int)item == Conversions.ToDouble(closure_0024__1075_002D._0024VB_0024Local_row.Cells[0].Value.ToString()))
							{
								flag2 = true;
								flag = true;
							}
						}
						if (!flag2)
						{
							if (selectDb.ctiTMList == null)
							{
								selectDb.getCusData(table_grid);
							}
							selectDb.ctiTMList.Find(closure_0024__1075_002D._Lambda_0024__1).agent_idx = (int?)NewLateBinding.LateGet(closure_0024__1075_002D._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_e.ClickedItem.Tag, null, "account_code", new object[0], null, null, null);
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
				if (flag)
				{
					CustomMsgBox.CMsgBox("일부 상담사가 통화중이므로 회수할 수 없습니다. 통화중이 아니라면 데이터베이스를 중단후 회수를 시도하십시오. 통화중 레코드NO:" + jObject2.SelectToken("nolist").ToString(Formatting.None), "상담사 통화중", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Exclamation);
				}
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

	private void 모든상담원에게배분ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		모든상담사배정ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void 접속중인상담원에게만배분ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		로그인상담사배정ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void 강제배분ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		접속중인상담원에게만강제배분ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void 사용자정의ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		MyProject.Forms.cti_split_custom.selectDb = selectDb;
		MyProject.Forms.cti_split_custom.ShowDialog();
	}

	private void 모든상담사배정ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		JObject jObject = new JObject();
		jObject.Add("type", "autoSplit");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("idx", selectDb.idx);
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
				selectDb.ctiTMList = null;
				if (!SplitContainer1.Panel2Collapsed)
				{
					selectDb.getCusData(table_grid);
				}
				getDB(refresh: true);
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

	private void 로그인상담사배정ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		JObject jObject = new JObject();
		jObject.Add("type", "autoSplit");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("idx", selectDb.idx);
		jObject.Add("LoginAgent", 1);
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
				selectDb.ctiTMList = null;
				if (!SplitContainer1.Panel2Collapsed)
				{
					selectDb.getCusData(table_grid);
				}
				getDB(refresh: true);
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

	private void 접속중인상담원에게만강제배분ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		JObject jObject = new JObject();
		jObject.Add("type", "autoSplit");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("idx", selectDb.idx);
		jObject.Add("forceSplit", 1);
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
				selectDb.ctiTMList = null;
				if (!SplitContainer1.Panel2Collapsed)
				{
					selectDb.getCusData(table_grid);
				}
				getDB(refresh: true);
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

	private void db_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		DataGridViewRow dataGridViewRow = db_grid.SelectedRows[0];
		db_split_Click(RuntimeHelpers.GetObjectValue(sender), e);
		db_grid.ClearSelection();
		dataGridViewRow.Selected = true;
	}

	private void agents_grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		Label2.Text = "총 " + Conversions.ToString(agents_grid.Rows.Count) + "개 레코드 검색됨.";
	}

	private void time_Tick(object sender, EventArgs e)
	{
		timeLabel.Text = DateTime.Now.ToString();
		if (!Conversions.ToBoolean(logging_in))
		{
			return;
		}
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
			Label3.Text = string.Format("{2:00}:{1:00}:{0:00}", logging_time[2], logging_time[1], logging_time[0]);
			if (MyProject.Forms.cti_call.Visible)
			{
				return;
			}
			try
			{
				if (pushHtmlClass == null)
				{
					JObject jObject = new JObject();
					jObject.Add("type", "getAgentPush");
					jObject.Add("id", Module1._id);
					jObject.Add("pw", Module1._pw);
					jObject.Add("idx", ssorder.cti_account_idx);
					pushPostData = "args=" + jObject.ToString(Formatting.None);
					pushHtmlClass = new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_get.php")), pushPostData);
				}
				if (pushHtmlClass.busy)
				{
					return;
				}
				string hTML = pushHtmlClass.getHTML(null);
				if (Operators.CompareString(hTML, null, TextCompare: false) != 0 && (string)JObject.Parse(hTML).SelectToken("response") == "ok")
				{
					if (selectDb != null)
					{
						int index = 0;
						try
						{
							index = nowtable.SelectedRows[0].Index;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						tmpIdx = selectDb.idx;
						current_page = selectDb.now_page;
						selectDb = null;
						login(1);
						if (ctiDbClass.Find(delegate(cti_db a)
						{
							if (a.idx == tmpIdx)
							{
								selectDb = a;
								try
								{
									ComboBox1.Text = a.name;
								}
								catch (Exception ex7)
								{
									ProjectData.SetProjectError(ex7);
									Exception ex8 = ex7;
									ProjectData.ClearProjectError();
								}
								return true;
							}
							TabControl2_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
							ComboBox1.Text = null;
							return false;
						}) == null)
						{
							selectDb = null;
							agentTablesClear();
							selectDBLabel.Text = "선택 : 없음";
						}
						else
						{
							DataGridView dataGridView = tm_grid_all;
							switch (TabControl2.SelectedIndex)
							{
							case 0:
								dataGridView = tm_grid_all;
								break;
							case 1:
								dataGridView = tm_grid_call_log;
								break;
							case 2:
								dataGridView = tm_grid_miss;
								break;
							case 3:
								dataGridView = tm_grid_call_out;
								break;
							case 4:
								dataGridView = tm_grid_agree;
								break;
							case 5:
								dataGridView = tm_grid_reserve;
								break;
							case 6:
								dataGridView = tm_grid_blacklist;
								break;
							}
							TabControl2_SelectedIndexChanged(TabControl2, new EventArgs());
							try
							{
								dataGridView.Rows[index].Selected = true;
							}
							catch (Exception ex3)
							{
								ProjectData.SetProjectError(ex3);
								Exception ex4 = ex3;
								ProjectData.ClearProjectError();
							}
						}
					}
					else
					{
						login(1);
					}
					if (cbox == null)
					{
						cbox = CustomMsgBox.CMsgBox(this, "서버에서 데이터가 변경되어 자동으로 새로고침 되었습니다.", "최신 데이터로 업데이트됨", "닫기", custom_msgbox.CMsgboxColor.None, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 5000);
					}
					else if (cbox.IsHandleCreated)
					{
						cbox.Close();
						cbox = CustomMsgBox.CMsgBox(this, "서버에서 데이터가 변경되어 자동으로 새로고침 되었습니다.", "최신 데이터로 업데이트됨", "닫기", custom_msgbox.CMsgboxColor.None, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 5000);
					}
					else
					{
						cbox = CustomMsgBox.CMsgBox(this, "서버에서 데이터가 변경되어 자동으로 새로고침 되었습니다.", "최신 데이터로 업데이트됨", "닫기", custom_msgbox.CMsgboxColor.None, custom_msgbox.CmsgBoxIcon.icon_Information, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 5000);
					}
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
				return;
			}
			ref object reference = ref idletime;
			reference = Operators.AddObject(reference, 1);
			if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectGreaterEqual(idletime, 300, TextCompare: false), !agent_breakTime), logging_in)))
			{
				Button5_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}
	}

	private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(busy))
		{
			return;
		}
		busy = true;
		agentpanel.Enabled = false;
		selectDb = ctiDbClass[ComboBox1.SelectedIndex];
		selectDBLabel.Text = "선택 : " + selectDb.name;
		if (selectDb.ctiTMList == null)
		{
			JObject jObject = new JObject();
			jObject.Add("type", "agentGetTMList");
			jObject.Add("id", Module1._id);
			jObject.Add("pw", Module1._pw);
			jObject.Add("idx", ssorder.cti_account_idx);
			jObject.Add("db_idx", selectDb.idx);
			string postData = "args=" + jObject.ToString(Formatting.None);
			try
			{
				JObject jObject2 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_get.php")), postData, progress: true).getHTML(this));
				if (jObject2.SelectToken("response").Equals("fail"))
				{
					Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
					busy = false;
					return;
				}
				JToken jToken = jObject2.SelectToken("response");
				if ((string)jToken == "ok")
				{
					busy = false;
					agentpanel.Enabled = true;
					selectDb.setAgentData(JsonConvert.DeserializeObject<List<cti_tm_list>>((string)jObject2.SelectToken("output")));
					TabControl2.SelectedIndex = 2;
				}
				else if ((string)jToken == "fail")
				{
					jObject2.SelectToken("cause");
					CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					busy = false;
					agentpanel.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				CustomMsgBox.CMsgBox("내부 오류 발생2. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex2.Message, "내부 오류 발생", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				busy = false;
				agentpanel.Enabled = true;
				ProjectData.ClearProjectError();
				return;
			}
		}
		else
		{
			busy = false;
			agentpanel.Enabled = true;
			TabControl2_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}
		busy = false;
		agentpanel.Enabled = true;
	}

	private void login(int refresh = 0)
	{
		if (Conversions.ToBoolean(busy))
		{
			return;
		}
		busy = true;
		JObject jObject = new JObject();
		jObject.Add("type", "agentLogin");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("refresh", refresh);
		jObject.Add("idx", ssorder.cti_account_idx);
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
				if (refresh == 0)
				{
					busy = false;
					statusLabel.Text = "상태 : 접속 중";
					logging_in = true;
					Button3.Enabled = true;
					Button4.Enabled = false;
					Button5.Enabled = true;
					ComboBox1.Enabled = true;
					TabControl2.Enabled = true;
					DoubleBufferPanel2.Enabled = true;
					TabControl2.SelectTab(0);
					TabControl2.Enabled = true;
					Label3.Text = "00:00:00";
					logging_time = new int[3];
				}
				ComboBox1.Items.Clear();
				ctiDbClass = JsonConvert.DeserializeObject<List<cti_db>>((string)jObject2.SelectToken("output"));
				foreach (cti_db item in ctiDbClass)
				{
					ComboBox1.Items.Add(item.name);
				}
			}
			else if ((string)jToken == "fail" && refresh == 0)
			{
				if ((string)jObject2.SelectToken("cause") == "permission_error")
				{
					MessageBox.Show("로그인 실패 / 권한이 없습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					busy = false;
				}
				else
				{
					CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					busy = false;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (refresh == 0)
			{
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + ex2.Message, "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				busy = false;
				ProjectData.ClearProjectError();
				return;
			}
			ProjectData.ClearProjectError();
		}
		busy = false;
	}

	private void logout()
	{
		if (Conversions.ToBoolean(busy))
		{
			return;
		}
		busy = true;
		logging_in = false;
		Button3.Enabled = false;
		Button5.Enabled = false;
		JObject jObject = new JObject();
		jObject.Add("type", "agentLogout");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("idx", ssorder.cti_account_idx);
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
				busy = false;
				statusLabel.Text = "상태 : 오프라인";
				selectDBLabel.Text = "선택 : 없음";
				selectDb = null;
				logging_in = false;
				Button3.Enabled = false;
				Button4.Enabled = true;
				Button5.Enabled = false;
				ComboBox1.Enabled = false;
				DoubleBufferPanel2.Enabled = false;
				ctiDbClass.Clear();
				ComboBox1.Items.Clear();
				TabControl2.SelectTab(0);
				TabControl2.Enabled = false;
				Button5.ImageIndex = 10;
				Button5.Text = "자리비움";
				agent_breakTime = false;
				Label3.Text = "00:00:00";
				agentTablesAllClear();
			}
			else if ((string)jToken == "fail")
			{
				jObject2.SelectToken("cause");
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				busy = false;
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

	private void Button4_Click(object sender, EventArgs e)
	{
		login();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
		{
			logout();
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		string text = "agentBreak";
		if (agent_breakTime)
		{
			text = "agentUnbreak";
			agent_breakTime = false;
		}
		else
		{
			agent_breakTime = true;
		}
		JObject jObject = new JObject();
		jObject.Add("type", text);
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("idx", ssorder.cti_account_idx);
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
				if (agent_breakTime)
				{
					Button5.ImageIndex = 11;
					Button5.Text = "대기";
					statusLabel.Text = "상태 : 자리비움";
				}
				else
				{
					Button5.ImageIndex = 10;
					Button5.Text = "자리비움";
					statusLabel.Text = "상태 : 접속 중";
				}
			}
			else if ((string)jToken == "fail")
			{
				jObject2.SelectToken("cause");
				CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
				agent_breakTime = !agent_breakTime;
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

	public void TabControl2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (selectDb != null && !Conversions.ToBoolean(Operators.NotObject(logging_in)) && !Conversions.ToBoolean(busy) && !Conversions.ToBoolean(page_busy) && ComboBox1.SelectedIndex >= 0)
		{
			selectDb.now_page = 0;
			callLogType = false;
			CheckBox3.Show();
			switch (TabControl2.SelectedIndex)
			{
			case 0:
				nowtable = tm_grid_all;
				break;
			case 1:
				nowtable = tm_grid_call_log;
				callLogType = true;
				break;
			case 2:
				nowtable = tm_grid_miss;
				break;
			case 3:
				nowtable = tm_grid_call_out;
				callLogType = true;
				break;
			case 4:
				nowtable = tm_grid_agree;
				break;
			case 5:
				nowtable = tm_grid_reserve;
				break;
			case 6:
				nowtable = tm_grid_blacklist;
				CheckBox3.Hide();
				break;
			}
			if (selectDb.ctiTMList.Count <= 0)
			{
				nowtable.Rows.Clear();
			}
			else if (current_page != -1)
			{
				selectDb.setAgentDataGridView(Conversions.ToBoolean(callLogType), nowtable, Conversions.ToString(current_page), TabControl2.SelectedIndex, !CheckBox3.Checked);
				current_page = -1;
			}
			else
			{
				selectDb.setAgentDataGridView(Conversions.ToBoolean(callLogType), nowtable, TabControl2.SelectedIndex, !CheckBox3.Checked);
			}
		}
	}

	private void agentTablesClear()
	{
		switch (TabControl2.SelectedIndex)
		{
		case 0:
			nowtable = tm_grid_all;
			break;
		case 1:
			nowtable = tm_grid_call_log;
			break;
		case 2:
			nowtable = tm_grid_miss;
			break;
		case 3:
			nowtable = tm_grid_call_out;
			break;
		case 4:
			nowtable = tm_grid_agree;
			break;
		case 5:
			nowtable = tm_grid_reserve;
			break;
		case 6:
			nowtable = tm_grid_blacklist;
			break;
		}
		nowtable.Rows.Clear();
	}

	private void agentTablesAllClear()
	{
		tm_grid_all.Rows.Clear();
		tm_grid_call_log.Rows.Clear();
		tm_grid_miss.Rows.Clear();
		tm_grid_call_out.Rows.Clear();
		tm_grid_agree.Rows.Clear();
		tm_grid_reserve.Rows.Clear();
		tm_grid_blacklist.Rows.Clear();
		nowtable.Rows.Clear();
	}

	private void ComboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (selectDb != null)
			{
				if (Conversions.ToBoolean(page_busy))
				{
					ComboBoxEx2.SelectedIndex = selectDb.now_page;
					return;
				}
				page_busy = true;
				selectDb.now_page = ComboBoxEx2.SelectedIndex;
				selectDb.setAgentDataGridView(Conversions.ToBoolean(callLogType), nowtable, Conversions.ToString(selectDb.now_page), TabControl2.SelectedIndex, !CheckBox3.Checked);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			CustomMsgBox.CMsgBox("내부 오류 발생.\r\n" + ex2.Message, "내부 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
			page_busy = false;
			ProjectData.ClearProjectError();
		}
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		checked
		{
			if (selectDb != null && selectDb.now_page > 0)
			{
				if (Conversions.ToBoolean(page_busy))
				{
					ComboBoxEx2.SelectedIndex = selectDb.now_page;
					return;
				}
				page_busy = true;
				selectDb.now_page--;
				selectDb.setAgentDataGridView(Conversions.ToBoolean(callLogType), nowtable, Conversions.ToString(selectDb.now_page), TabControl2.SelectedIndex, !CheckBox3.Checked);
			}
		}
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		checked
		{
			if (selectDb != null && selectDb.now_page < selectDb.max_page - 1)
			{
				if (Conversions.ToBoolean(page_busy))
				{
					ComboBoxEx2.SelectedIndex = selectDb.now_page;
					return;
				}
				page_busy = true;
				selectDb.now_page++;
				selectDb.setAgentDataGridView(Conversions.ToBoolean(callLogType), nowtable, Conversions.ToString(selectDb.now_page), TabControl2.SelectedIndex, !CheckBox3.Checked);
			}
		}
	}

	private void ssorder_cti_MouseMove(object sender, MouseEventArgs e)
	{
		idletime = 0;
	}

	private void tm_grid_all_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (selectDb != null)
		{
			if (agent_breakTime)
			{
				Button5_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			DataGridView dataGridView = (DataGridView)sender;
			MyProject.Forms.cti_call.selectCustomer = selectDb.ctiTMList.Find((cti_tm_list b) => ((double)b.idx == Conversions.ToDouble(dataGridView.SelectedRows[0].Cells[0].Value.ToString())) ? true : false);
			MyProject.Forms.cti_call.selectRow = dataGridView.SelectedRows[0];
			if (MyProject.Forms.cti_call.selectCustomer != null)
			{
				MyProject.Forms.cti_call.ShowDialog();
			}
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		CheckBox1.Checked = true;
		getAgents();
	}

	private void 배분량선택ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		사용자정의ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		MyProject.Forms.cti_settings.ShowDialog();
	}

	private void 일괄회수ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		일괄회수ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void 미처리항목일괄회수ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		미처리회수ToolStripMenuItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void ToolStripButton2_Click(object sender, EventArgs e)
	{
		MyProject.Forms.cti_blacklist.ShowDialog();
	}

	private void agents_grid_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void agents_grid_SelectionChanged(object sender, EventArgs e)
	{
		try
		{
			if (agents_grid.SelectedRows.Count >= 2)
			{
				agent_reset.Show();
				agent_delete.Show();
				return;
			}
			selectAgent = ctiAgents.Find((cti_agents a) => Operators.ConditionalCompareObjectEqual(a.idx, agents_grid.SelectedRows[0].Cells[0].Value, TextCompare: false) ? true : false);
			if (selectAgent != null)
			{
				if (selectAgent.expire != 0)
				{
					agent_reset.Show();
					agent_delete.Hide();
				}
				else
				{
					agent_reset.Hide();
					agent_delete.Show();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void ToolStripButton3_Click(object sender, EventArgs e)
	{
		MyProject.Forms.cti_blacklist_filter.ShowDialog();
	}

	private void 블랙리스트필터ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		ToolStripButton3_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (SplitContainer1.Panel1Collapsed)
		{
			selectDb.blacklistViewMode = CheckBox2.Checked;
			int cusData = selectDb.getCusData(table_grid);
			db_status.Text = "총 " + Conversions.ToString(selectDb.max_page) + " 페이지, 총 " + Conversions.ToString(cusData) + "개 레코드 검색됨.";
		}
	}

	private void CheckBox3_CheckedChanged(object sender, EventArgs e)
	{
		TabControl2_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (TabControl1.SelectedIndex)
		{
		case 0:
			bottomBar.Visible = false;
			break;
		case 1:
			bottomBar.Visible = true;
			break;
		}
	}

	private void db_blacklist_reset_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show(selectDb.name + " 데이터베이스에 존재하는 블랙리스트를 일괄 복구하시겠습니까?", "블랙리스트 복구", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
		{
			return;
		}
		JObject jObject = new JObject();
		jObject.Add("type", "restoreBlacklist");
		jObject.Add("id", Module1._id);
		jObject.Add("pw", Module1._pw);
		jObject.Add("db_idx", selectDb.idx);
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
				MessageBox.Show("블랙리스트가 복구되었습니다.", "복구 완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				getDB(refresh: true);
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
			ProjectData.ClearProjectError();
			return;
		}
		try
		{
			db_grid.ClearSelection();
			db_grid.Rows[checked(db_grid.Rows.Count - 1)].Selected = true;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			selectDb = null;
			ProjectData.ClearProjectError();
		}
	}

	private void 블랙리스트복구ToolStripMenuItem_Click(object sender, EventArgs e)
	{
		db_blacklist_reset_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Button8_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		checked
		{
			if (Operators.CompareString(TextBox1.Text.Trim(), null, TextCompare: false) == 0)
			{
				CustomMsgBox.CMsgBox("빈칸은 입력할 수 없습니다.", "", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Exclamation);
				busy = false;
				agentpanel.Enabled = true;
			}
			else
			{
				if (Conversions.ToBoolean(busy))
				{
					return;
				}
				busy = true;
				agentpanel.Enabled = false;
				JObject jObject = new JObject();
				jObject.Add("type", "getFindCustomer");
				jObject.Add("id", Module1._id);
				jObject.Add("pw", Module1._pw);
				jObject.Add("idx", ssorder.cti_account_idx);
				jObject.Add("call_number", TextBox1.Text.Trim().Replace("-", "").Replace(" ", ""));
				string postData = "args=" + jObject.ToString(Formatting.None);
				try
				{
					JObject jObject2 = JObject.Parse(new GetHtmlClass(Conversions.ToString(Operators.AddObject(ssorder.ssorder_server, "cti/cti_get.php")), postData, progress: true).getHTML(this));
					if (jObject2.SelectToken("response").Equals("fail"))
					{
						Interaction.MsgBox("오류: 권한이 없음. 잘못된 접근");
						busy = false;
						agentpanel.Enabled = true;
						return;
					}
					if (Operators.CompareString(jObject2.SelectToken("output").ToString(), null, TextCompare: false) == 0)
					{
						CustomMsgBox.CMsgBox(TextBox1.Text.Trim() + " 검색결과가 없습니다.", "결과 없음", "닫기", custom_msgbox.CMsgboxColor.Blue, custom_msgbox.CmsgBoxIcon.icon_Exclamation);
						busy = false;
						agentpanel.Enabled = true;
						return;
					}
					List<cti_tm_list> list = JsonConvert.DeserializeObject<List<cti_tm_list>>((string)jObject2.SelectToken("output"));
					int num = 0;
					int count = list.Count;
					for (int i = 0; i <= count; i++)
					{
						if (list[i].is_correct)
						{
							num = (int)Math.Floor((double)i / 500.0);
							break;
						}
					}
					foreach (cti_db item in ctiDbClass)
					{
						if ((double)item.idx == Conversion.Val(list[0].db_idx))
						{
							selectDb = item;
							ComboBox1.Text = item.name;
							selectDBLabel.Text = "선택 : " + selectDb.name;
							break;
						}
					}
					JToken jToken = jObject2.SelectToken("response");
					if ((string)jToken == "ok")
					{
						selectDb.setAgentData(JsonConvert.DeserializeObject<List<cti_tm_list>>((string)jObject2.SelectToken("output")));
						cti_tm_list cti_tm_list2 = selectDb.ctiTMList.Find((cti_tm_list b) => b.is_correct ? true : false);
						TabControl2.SelectedIndex = 0;
						selectDb.setAgentDataGridView(callLogType: false, tm_grid_all, Conversions.ToString(num), TabControl2.SelectedIndex, !CheckBox3.Checked);
						IEnumerator enumerator2 = default(IEnumerator);
						try
						{
							enumerator2 = ((IEnumerable)tm_grid_all.Rows).GetEnumerator();
							while (enumerator2.MoveNext())
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator2.Current;
								if (Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value)) == (double)cti_tm_list2.idx)
								{
									tm_grid_all.CurrentCell = dataGridViewRow.Cells[0];
									break;
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
						busy = false;
						agentpanel.Enabled = true;
					}
					else if ((string)jToken == "fail")
					{
						CustomMsgBox.CMsgBox("서버와의 통신 오류 입니다. 자세한 오류정보는 아래에 표시됩니다.\r\n" + jObject2.SelectToken("cause").ToString(), "통신 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
						busy = false;
						agentpanel.Enabled = true;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					CustomMsgBox.CMsgBox("내부 오류 발생.\r\n" + ex2.Message, "내부 오류", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error);
					busy = false;
					agentpanel.Enabled = true;
					ProjectData.ClearProjectError();
					return;
				}
				busy = false;
				agentpanel.Enabled = true;
			}
		}
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		TextBox1.Text = null;
		TextBox1.Focus();
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", TextCompare: false) != 0))
		{
			e.Handled = true;
		}
	}
}
