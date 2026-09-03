using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public android_db_sjka_application_noteapp m_android_db_sjka_application_noteapp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public android_db_sjka_cyber m_android_db_sjka_cyber;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public android_db_ss_order m_android_db_ss_order;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public android_mba_check m_android_mba_check;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public CHAT_MAIN m_CHAT_MAIN;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cti_blacklist m_cti_blacklist;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cti_blacklist_filter m_cti_blacklist_filter;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cti_blacklist_progress m_cti_blacklist_progress;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cti_call m_cti_call;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cti_import m_cti_import;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cti_settings m_cti_settings;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public cti_split_custom m_cti_split_custom;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public custom_msgbox m_custom_msgbox;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public fileManager m_fileManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public home_db_microlivire m_home_db_microlivire;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public login m_login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public mlas m_mlas;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public playground m_playground;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public printpage m_printpage;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public sjka_cyber_ios_purchase_log_dialog m_sjka_cyber_ios_purchase_log_dialog;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ssorder_cti m_ssorder_cti;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ssorder_login m_ssorder_login;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public start m_start;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public windows_db_human_chart m_windows_db_human_chart;

		public android_db_sjka_application_noteapp android_db_sjka_application_noteapp
		{
			get
			{
				m_android_db_sjka_application_noteapp = Create__Instance__(m_android_db_sjka_application_noteapp);
				return m_android_db_sjka_application_noteapp;
			}
			set
			{
				if (value != m_android_db_sjka_application_noteapp)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_android_db_sjka_application_noteapp);
				}
			}
		}

		public android_db_sjka_cyber android_db_sjka_cyber
		{
			get
			{
				m_android_db_sjka_cyber = Create__Instance__(m_android_db_sjka_cyber);
				return m_android_db_sjka_cyber;
			}
			set
			{
				if (value != m_android_db_sjka_cyber)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_android_db_sjka_cyber);
				}
			}
		}

		public android_db_ss_order android_db_ss_order
		{
			get
			{
				m_android_db_ss_order = Create__Instance__(m_android_db_ss_order);
				return m_android_db_ss_order;
			}
			set
			{
				if (value != m_android_db_ss_order)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_android_db_ss_order);
				}
			}
		}

		public android_mba_check android_mba_check
		{
			get
			{
				m_android_mba_check = Create__Instance__(m_android_mba_check);
				return m_android_mba_check;
			}
			set
			{
				if (value != m_android_mba_check)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_android_mba_check);
				}
			}
		}

		public CHAT_MAIN CHAT_MAIN
		{
			get
			{
				m_CHAT_MAIN = Create__Instance__(m_CHAT_MAIN);
				return m_CHAT_MAIN;
			}
			set
			{
				if (value != m_CHAT_MAIN)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_CHAT_MAIN);
				}
			}
		}

		public cti_blacklist cti_blacklist
		{
			get
			{
				m_cti_blacklist = Create__Instance__(m_cti_blacklist);
				return m_cti_blacklist;
			}
			set
			{
				if (value != m_cti_blacklist)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_cti_blacklist);
				}
			}
		}

		public cti_blacklist_filter cti_blacklist_filter
		{
			get
			{
				m_cti_blacklist_filter = Create__Instance__(m_cti_blacklist_filter);
				return m_cti_blacklist_filter;
			}
			set
			{
				if (value != m_cti_blacklist_filter)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_cti_blacklist_filter);
				}
			}
		}

		public cti_blacklist_progress cti_blacklist_progress
		{
			get
			{
				m_cti_blacklist_progress = Create__Instance__(m_cti_blacklist_progress);
				return m_cti_blacklist_progress;
			}
			set
			{
				if (value != m_cti_blacklist_progress)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_cti_blacklist_progress);
				}
			}
		}

		public cti_call cti_call
		{
			get
			{
				m_cti_call = Create__Instance__(m_cti_call);
				return m_cti_call;
			}
			set
			{
				if (value != m_cti_call)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_cti_call);
				}
			}
		}

		public cti_import cti_import
		{
			get
			{
				m_cti_import = Create__Instance__(m_cti_import);
				return m_cti_import;
			}
			set
			{
				if (value != m_cti_import)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_cti_import);
				}
			}
		}

		public cti_settings cti_settings
		{
			get
			{
				m_cti_settings = Create__Instance__(m_cti_settings);
				return m_cti_settings;
			}
			set
			{
				if (value != m_cti_settings)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_cti_settings);
				}
			}
		}

		public cti_split_custom cti_split_custom
		{
			get
			{
				m_cti_split_custom = Create__Instance__(m_cti_split_custom);
				return m_cti_split_custom;
			}
			set
			{
				if (value != m_cti_split_custom)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_cti_split_custom);
				}
			}
		}

		public custom_msgbox custom_msgbox
		{
			get
			{
				m_custom_msgbox = Create__Instance__(m_custom_msgbox);
				return m_custom_msgbox;
			}
			set
			{
				if (value != m_custom_msgbox)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_custom_msgbox);
				}
			}
		}

		public fileManager fileManager
		{
			get
			{
				m_fileManager = Create__Instance__(m_fileManager);
				return m_fileManager;
			}
			set
			{
				if (value != m_fileManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_fileManager);
				}
			}
		}

		public home_db_microlivire home_db_microlivire
		{
			get
			{
				m_home_db_microlivire = Create__Instance__(m_home_db_microlivire);
				return m_home_db_microlivire;
			}
			set
			{
				if (value != m_home_db_microlivire)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_home_db_microlivire);
				}
			}
		}

		public login login
		{
			get
			{
				m_login = Create__Instance__(m_login);
				return m_login;
			}
			set
			{
				if (value != m_login)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_login);
				}
			}
		}

		public mlas mlas
		{
			get
			{
				m_mlas = Create__Instance__(m_mlas);
				return m_mlas;
			}
			set
			{
				if (value != m_mlas)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_mlas);
				}
			}
		}

		public playground playground
		{
			get
			{
				m_playground = Create__Instance__(m_playground);
				return m_playground;
			}
			set
			{
				if (value != m_playground)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_playground);
				}
			}
		}

		public printpage printpage
		{
			get
			{
				m_printpage = Create__Instance__(m_printpage);
				return m_printpage;
			}
			set
			{
				if (value != m_printpage)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_printpage);
				}
			}
		}

		public sjka_cyber_ios_purchase_log_dialog sjka_cyber_ios_purchase_log_dialog
		{
			get
			{
				m_sjka_cyber_ios_purchase_log_dialog = Create__Instance__(m_sjka_cyber_ios_purchase_log_dialog);
				return m_sjka_cyber_ios_purchase_log_dialog;
			}
			set
			{
				if (value != m_sjka_cyber_ios_purchase_log_dialog)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_sjka_cyber_ios_purchase_log_dialog);
				}
			}
		}

		public ssorder_cti ssorder_cti
		{
			get
			{
				m_ssorder_cti = Create__Instance__(m_ssorder_cti);
				return m_ssorder_cti;
			}
			set
			{
				if (value != m_ssorder_cti)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ssorder_cti);
				}
			}
		}

		public ssorder_login ssorder_login
		{
			get
			{
				m_ssorder_login = Create__Instance__(m_ssorder_login);
				return m_ssorder_login;
			}
			set
			{
				if (value != m_ssorder_login)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ssorder_login);
				}
			}
		}

		public start start
		{
			get
			{
				m_start = Create__Instance__(m_start);
				return m_start;
			}
			set
			{
				if (value != m_start)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_start);
				}
			}
		}

		public windows_db_human_chart windows_db_human_chart
		{
			get
			{
				m_windows_db_human_chart = Create__Instance__(m_windows_db_human_chart);
				return m_windows_db_human_chart;
			}
			set
			{
				if (value != m_windows_db_human_chart)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_windows_db_human_chart);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || Instance.IsDisposed)
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
