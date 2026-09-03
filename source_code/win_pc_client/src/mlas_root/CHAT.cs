using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class CHAT
{
	public class ChatList
	{
		public class ChatDetail
		{
			private int _index;

			private string _text;

			private string _time;

			private bool _read;

			public string Index => Conversions.ToString(_index);

			public string Text => _text;

			public string Time => _time;

			public bool Read
			{
				get
				{
					return _read;
				}
				set
				{
					_read = value;
				}
			}

			public ChatDetail(int index, string text, string time, bool read)
			{
				_text = null;
				_read = false;
				_index = index;
				_text = text;
				_time = time;
				_read = read;
			}
		}

		private string _id;

		public List<ChatDetail> msg;

		public object id => _id;

		public ChatList(string id)
		{
			_id = id;
			msg = new List<ChatDetail>();
		}

		public void push(int index, string text, string time, bool read)
		{
			msg.Add(new ChatDetail(index, text, time, read));
		}

		public void read()
		{
			foreach (ChatDetail item in msg)
			{
				item.Read = true;
			}
		}

		public int getCount()
		{
			int num = 0;
			foreach (ChatDetail item in msg)
			{
				if (!item.Read)
				{
					num = checked(num + 1);
				}
			}
			return num;
		}

		public List<string> getTextList()
		{
			List<string> list = new List<string>();
			foreach (ChatDetail item in msg)
			{
				list.Add(item.Index + "<split>" + item.Text + "<split>" + item.Time);
				item.Read = true;
			}
			return list;
		}

		public List<ChatDetail> getChatDetail()
		{
			return msg;
		}
	}

	private class GetHtmlClass
	{
		public delegate void TertiaryThreadDelegate(string Message);

		private class ThreadArguments
		{
			public string[] args;

			public TertiaryThreadDelegate ThreadDelegate;

			public void Start()
			{
				try
				{
					byte[] bytes = new WebClient().DownloadData(args[0]);
					string text = null;
					text = Encoding.UTF8.GetString(bytes);
					ThreadDelegate(text);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ThreadDelegate("incorrect");
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
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ThreadDelegate("incorrect");
					ProjectData.ClearProjectError();
				}
			}
		}

		private bool busy;

		private string returnString;

		private string _url;

		private string _postdata;

		private bool getSuccess;

		private bool getStart;

		private bool _progress;

		public GetHtmlClass(string url, string PostData = null, bool progress = false)
		{
			busy = false;
			returnString = null;
			getSuccess = false;
			getStart = false;
			_url = url;
			_postdata = PostData;
			_progress = progress;
			busy = false;
			returnString = null;
		}

		public bool isBusy()
		{
			return busy;
		}

		public string getContent()
		{
			if (busy)
			{
				return "incorrect";
			}
			return returnString;
		}

		public string getHTML()
		{
			getStart = true;
			busy = true;
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
			int num = 0;
			while (!getSuccess)
			{
				Application.DoEvents();
				Thread.Sleep(1);
				Application.DoEvents();
				num = checked(num + 1);
				if (num > 5000)
				{
					returnString = "incorrect";
					break;
				}
			}
			busy = false;
			return returnString;
		}

		public void getHTML_NotReturn()
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
		}

		private void TertiaryThread(string Message)
		{
			if (Operators.CompareString(Message, "incorrect", TextCompare: false) != 0)
			{
				getSuccess = true;
			}
			returnString = Message;
		}
	}

	private bool _init;

	private string _server;

	private string _id;

	private GetHtmlClass _htmlclass;

	private Form _form;

	private int _loopcount;

	private List<ChatList> _chatList;

	private bool _login;

	private bool _newMember;

	private bool _msgalert;

	private string[] _latest;

	private ChatList _latestItem;

	public object MemberAlert
	{
		get
		{
			bool newMember = _newMember;
			_newMember = false;
			return newMember;
		}
	}

	public object MessageAlert => _msgalert;

	public int LoopCount => _loopcount;

	public string[] LatestId => _latest;

	public ChatList LatestMessage => _latestItem;

	public object id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = Conversions.ToString(value);
		}
	}

	public CHAT(string server)
	{
		_init = false;
		_loopcount = 0;
		_login = false;
		_newMember = false;
		_msgalert = false;
		_server = server;
	}

	public CHAT(string server, string id, string pw)
	{
		_init = false;
		_loopcount = 0;
		_login = false;
		_newMember = false;
		_msgalert = false;
		_server = server;
		Login(id, pw);
	}

	public bool Login(string id, string pw)
	{
		_htmlclass = new GetHtmlClass(_server + "/CHAT_COMPONENTS/get.php?t=login&i=" + id + "&p=" + HttpUtility.UrlEncode(pw), null, progress: true);
		string[] array = _htmlclass.getHTML().Split(new string[1] { "<split>" }, StringSplitOptions.None);
		if (Operators.CompareString(array[0], "correct", TextCompare: false) == 0)
		{
			_chatList = new List<ChatList>();
			_login = true;
			_id = id;
			if (Operators.CompareString(array[1].Trim(), null, TextCompare: false) != 0)
			{
				string[] array2 = array[1].Trim().Split(new string[1] { "<friend>" }, StringSplitOptions.RemoveEmptyEntries);
				foreach (string text in array2)
				{
					_chatList.Add(new ChatList(text));
				}
			}
			FILE_READ();
			return true;
		}
		return false;
	}

	public void addFriend(string value)
	{
		_chatList.Add(new ChatList(value));
	}

	public List<string> getFriend()
	{
		List<string> list = new List<string>();
		foreach (ChatList chat in _chatList)
		{
			list.Add(Conversions.ToString(chat.id));
		}
		return list;
	}

	public List<string> getMessages(string id)
	{
		List<string> result = new List<string>();
		_htmlclass = new GetHtmlClass(_server + "/CHAT_COMPONENTS/get.php?t=read&i=" + _id, null, progress: true);
		_htmlclass.getHTML();
		foreach (ChatList chat in _chatList)
		{
			if (Operators.ConditionalCompareObjectEqual(chat.id, id, TextCompare: false))
			{
				result = chat.getTextList();
			}
		}
		FILE_SAVE(id, "", reset: true);
		return result;
	}

	public void AlertDisable()
	{
		_msgalert = false;
	}

	public int getCount()
	{
		int num = 0;
		foreach (ChatList chat in _chatList)
		{
			num = checked(num + chat.getCount());
		}
		return num;
	}

	public List<string[]> MsgCountDetail()
	{
		List<string[]> list = new List<string[]>();
		foreach (ChatList chat in _chatList)
		{
			list.Add(new string[2]
			{
				Conversions.ToString(chat.id),
				Conversions.ToString(chat.getCount())
			});
		}
		return list;
	}

	public List<ChatList> GetChatList()
	{
		return _chatList;
	}

	public bool refresh()
	{
		if (_htmlclass.isBusy())
		{
			return false;
		}
		string content = _htmlclass.getContent();
		_htmlclass = new GetHtmlClass(_server + "/CHAT_COMPONENTS/get.php?t=MsgList&i=" + _id, null, progress: true);
		_htmlclass.getHTML();
		checked
		{
			if (Operators.CompareString(content, null, TextCompare: false) != 0)
			{
				string[] array = content.Split(new string[1] { "<message>" }, StringSplitOptions.None);
				if (Operators.CompareString(array[0], _id, TextCompare: false) == 0)
				{
					string[] array2 = array;
					_Closure_0024__35_002D0 closure_0024__35_002D = default(_Closure_0024__35_002D0);
					foreach (string text in array2)
					{
						closure_0024__35_002D = new _Closure_0024__35_002D0(closure_0024__35_002D);
						if (Operators.CompareString(text, _id, TextCompare: false) != 0)
						{
							closure_0024__35_002D._0024VB_0024Local_s2 = text.Split(new string[1] { "<split>" }, StringSplitOptions.None);
							ChatList chatList = null;
							try
							{
								chatList = _chatList[_chatList.FindIndex(closure_0024__35_002D._Lambda_0024__0)];
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								_chatList.Add(new ChatList(closure_0024__35_002D._0024VB_0024Local_s2[1]));
								chatList = _chatList[_chatList.Count - 1];
								_newMember = true;
								ProjectData.ClearProjectError();
							}
							chatList.push((int)Math.Round(Conversion.Val(closure_0024__35_002D._0024VB_0024Local_s2[0])), closure_0024__35_002D._0024VB_0024Local_s2[2], closure_0024__35_002D._0024VB_0024Local_s2[3], read: false);
							FILE_SAVE(closure_0024__35_002D._0024VB_0024Local_s2[1], "<message>" + text + "<split>0");
							_latest = closure_0024__35_002D._0024VB_0024Local_s2;
							_latestItem = chatList;
							_msgalert = true;
						}
					}
				}
			}
			_loopcount++;
			return true;
		}
	}

	public bool Send(string target, string text)
	{
		_htmlclass = new GetHtmlClass(_server + "/CHAT_COMPONENTS/get.php?t=send&i=" + _id + "&target=" + target + "&txt=" + text);
		_htmlclass.getHTML_NotReturn();
		if (Operators.CompareString(_htmlclass.getContent(), "incorrect", TextCompare: false) != 0)
		{
			ChatList chatList = null;
			try
			{
				chatList = _chatList[_chatList.FindIndex((ChatList b) => Operators.ConditionalCompareObjectEqual(b.id, target, TextCompare: false) ? true : false)];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				_chatList.Add(new ChatList(target));
				chatList = _chatList[checked(_chatList.Count - 1)];
				_newMember = true;
				ProjectData.ClearProjectError();
			}
			chatList.push(0, text, Conversions.ToString(DateTime.Today) + Strings.Format(DateTime.Now, " HH:mm:ss"), read: true);
			return true;
		}
		return false;
	}

	private void putMessage(string str)
	{
		string[] array = str.Split(new string[1] { "<message>" }, StringSplitOptions.RemoveEmptyEntries);
		checked
		{
			_Closure_0024__37_002D0 closure_0024__37_002D = default(_Closure_0024__37_002D0);
			foreach (string text in array)
			{
				closure_0024__37_002D = new _Closure_0024__37_002D0(closure_0024__37_002D);
				closure_0024__37_002D._0024VB_0024Local_s2 = text.Split(new string[1] { "<split>" }, StringSplitOptions.None);
				ChatList chatList = null;
				try
				{
					chatList = _chatList[_chatList.FindIndex(closure_0024__37_002D._Lambda_0024__0)];
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_chatList.Add(new ChatList(closure_0024__37_002D._0024VB_0024Local_s2[1]));
					chatList = _chatList[_chatList.Count - 1];
					_newMember = true;
					ProjectData.ClearProjectError();
				}
				chatList.push((int)Math.Round(Conversion.Val(closure_0024__37_002D._0024VB_0024Local_s2[0])), closure_0024__37_002D._0024VB_0024Local_s2[2], closure_0024__37_002D._0024VB_0024Local_s2[3], Conversion.Val(closure_0024__37_002D._0024VB_0024Local_s2[4]) != 0.0);
				if (Conversions.ToDouble(closure_0024__37_002D._0024VB_0024Local_s2[4]) == 0.0)
				{
					_msgalert = true;
				}
				if (Conversion.Val(closure_0024__37_002D._0024VB_0024Local_s2[4]) == 0.0)
				{
					_latest = closure_0024__37_002D._0024VB_0024Local_s2;
				}
			}
		}
	}

	private void FILE_READ()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(CHAT_MODULE.CHAT_LOG_STORAGE + _id);
		if (!directoryInfo.Exists)
		{
			return;
		}
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			using StreamReader streamReader = new StreamReader(CHAT_MODULE.CHAT_LOG_STORAGE + _id + "\\" + fileInfo.Name, Encoding.UTF8);
			putMessage(streamReader.ReadToEnd());
		}
	}

	private void FILE_SAVE(string id, string str, bool reset = false)
	{
		_Closure_0024__39_002D0 arg = default(_Closure_0024__39_002D0);
		_Closure_0024__39_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__39_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_id = id;
		if (reset)
		{
			if (!Directory.Exists(CHAT_MODULE.CHAT_LOG_STORAGE + _id))
			{
				Directory.CreateDirectory(CHAT_MODULE.CHAT_LOG_STORAGE + _id);
			}
			using StreamWriter streamWriter = new StreamWriter(CHAT_MODULE.CHAT_LOG_STORAGE + _id + "\\" + CS_0024_003C_003E8__locals0._0024VB_0024Local_id, append: false, Encoding.UTF8);
			ChatList chatList = _chatList[_chatList.FindIndex((ChatList b) => Operators.ConditionalCompareObjectEqual(b.id, CS_0024_003C_003E8__locals0._0024VB_0024Local_id, TextCompare: false) ? true : false)];
			foreach (ChatList.ChatDetail item in chatList.getChatDetail())
			{
				streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<message>" + item.Index + "<split>", chatList.id), "<split>"), item.Text), "<split>"), item.Time), "<split>1"));
			}
			return;
		}
		if (File.Exists(CHAT_MODULE.CHAT_LOG_STORAGE + _id + "\\" + CS_0024_003C_003E8__locals0._0024VB_0024Local_id))
		{
			using (StreamWriter streamWriter2 = File.AppendText(CHAT_MODULE.CHAT_LOG_STORAGE + _id + "\\" + CS_0024_003C_003E8__locals0._0024VB_0024Local_id))
			{
				streamWriter2.WriteLine(str);
				return;
			}
		}
		if (!Directory.Exists(CHAT_MODULE.CHAT_LOG_STORAGE + _id))
		{
			Directory.CreateDirectory(CHAT_MODULE.CHAT_LOG_STORAGE + _id);
		}
		using StreamWriter streamWriter3 = new StreamWriter(CHAT_MODULE.CHAT_LOG_STORAGE + _id + "\\" + CS_0024_003C_003E8__locals0._0024VB_0024Local_id, append: false, Encoding.UTF8);
		streamWriter3.Write(str);
	}
}
