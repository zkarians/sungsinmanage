using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace mlas_root;

public class GetHtmlClass
{
	public delegate void TertiaryThreadDelegate(string Message);

	private class ThreadArguments
	{
		public bool finish;

		public string[] args;

		public TertiaryThreadDelegate ThreadDelegate;

		public ThreadArguments()
		{
			finish = false;
		}

		public void Start()
		{
			try
			{
				byte[] bytes = new WebClient().DownloadData(args[0]);
				string message = null;
				string encode = Module1.encode;
				if (Operators.CompareString(encode, null, TextCompare: false) == 0)
				{
					message = Encoding.UTF8.GetString(bytes);
				}
				else if (Operators.CompareString(encode, "UTF8", TextCompare: false) == 0)
				{
					message = Encoding.UTF8.GetString(bytes);
				}
				else if (Operators.CompareString(encode, "DEFAULT", TextCompare: false) == 0)
				{
					message = Encoding.Default.GetString(bytes);
				}
				ThreadDelegate(message);
				finish = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ThreadDelegate("incorrect");
				finish = true;
				ProjectData.ClearProjectError();
			}
		}

		public void PostStart()
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(args[0]));
				httpWebRequest.AllowAutoRedirect = true;
				httpWebRequest.Method = "POST";
				httpWebRequest.KeepAlive = true;
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				byte[] bytes = Encoding.UTF8.GetBytes(args[1]);
				httpWebRequest.ContentLength = bytes.Length;
				using (Stream stream = httpWebRequest.GetRequestStream())
				{
					stream.Write(bytes, 0, bytes.Length);
				}
				string message;
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					message = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
				}
				ThreadDelegate(message);
				finish = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ThreadDelegate("incorrect");
				finish = true;
				ProjectData.ClearProjectError();
			}
		}
	}

	public bool busy;

	private string returnString;

	public Form context;

	private string _url;

	private string _postdata;

	private bool getSuccess;

	private bool getStart;

	private bool disposed;

	private bool _progress;

	private SafeHandle handle;

	private custom_msgbox progressBar;

	public bool cancelFlag;

	private Thread thread;

	public GetHtmlClass(string url, string PostData = null, bool progress = false)
	{
		busy = false;
		returnString = null;
		context = null;
		getSuccess = false;
		getStart = false;
		disposed = false;
		handle = new SafeFileHandle(IntPtr.Zero, ownsHandle: true);
		progressBar = null;
		cancelFlag = false;
		_url = url;
		_postdata = PostData;
		_progress = progress;
		busy = false;
		returnString = null;
	}

	public void cancel()
	{
		cancelFlag = true;
	}

	public bool isBusy()
	{
		return busy;
	}

	public object getContent()
	{
		if (busy)
		{
			return "incorrect";
		}
		return returnString;
	}

	public string getHTMLProgress()
	{
		ThreadArguments threadArguments = new ThreadArguments();
		threadArguments.ThreadDelegate = TertiaryThread;
		Thread thread;
		if (Operators.CompareString(_postdata, null, TextCompare: false) == 0)
		{
			threadArguments.args = new string[1] { _url };
			thread = new Thread(threadArguments.Start);
		}
		else
		{
			threadArguments.args = new string[2] { _url, _postdata };
			thread = new Thread(threadArguments.PostStart);
		}
		thread.Start();
		while (!threadArguments.finish)
		{
			if (cancelFlag)
			{
				returnString = "incorrect";
				break;
			}
			Application.DoEvents();
		}
		try
		{
			progressBar.Dispose();
			GC.Collect();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return returnString;
	}

	public string getHTML(Form context)
	{
		if (context == null)
		{
			this.context = null;
			ThreadArguments threadArguments = new ThreadArguments();
			threadArguments.ThreadDelegate = TertiaryThread;
			Thread thread;
			if (Operators.CompareString(_postdata, null, TextCompare: false) == 0)
			{
				threadArguments.args = new string[1] { _url };
				thread = new Thread(threadArguments.Start);
			}
			else
			{
				threadArguments.args = new string[2] { _url, _postdata };
				thread = new Thread(threadArguments.PostStart);
			}
			thread.Start();
			while (!threadArguments.finish)
			{
				if (cancelFlag)
				{
					returnString = "incorrect";
					break;
				}
				Application.DoEvents();
				Thread.Sleep(10);
				Application.DoEvents();
			}
			try
			{
				progressBar.Dispose();
				GC.Collect();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			return returnString;
		}
		this.context = context;
		progressBar = CustomMsgBox.CMsgBox(this);
		return progressBar.HtmlResult;
	}

	private void TertiaryThread(string Message)
	{
		if (cancelFlag)
		{
			getSuccess = true;
			return;
		}
		if (Operators.CompareString(Message, "incorrect", TextCompare: false) != 0)
		{
			getSuccess = true;
		}
		returnString = Message;
	}
}
