using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

internal class myftp
{
	private Uri MyUrl;

	private string MyID;

	private string MyPW;

	private FtpWebRequest reqFTP;

	private Thread[] thr;

	private string err;

	private object fail;

	private object fail_count;

	public string[] idlists;

	public string id
	{
		get
		{
			return MyID;
		}
		set
		{
			MyID = value;
		}
	}

	public string pw
	{
		get
		{
			return MyPW;
		}
		set
		{
			MyPW = value;
		}
	}

	public Uri FTPUrl
	{
		get
		{
			return MyUrl;
		}
		set
		{
			MyUrl = value;
		}
	}

	public string GetError => err;

	public myftp(Uri uri, string _id, string _pw, bool Passive = true)
	{
		thr = new Thread[6];
		err = null;
		fail = 2;
		fail_count = 0;
		thr[0] = new Thread((ThreadStart)delegate
		{
			GetFileList();
		});
		MyUrl = uri;
		MyID = _id;
		MyPW = _pw;
		reqFTP = (FtpWebRequest)WebRequest.Create(MyUrl);
		reqFTP.Credentials = new NetworkCredential(_id, _pw);
		reqFTP.UsePassive = Passive;
	}

	public void Upload(string filename)
	{
		FileInfo fileInfo = new FileInfo(filename);
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(MyUrl.ToString() + fileInfo.Name);
		ftpWebRequest.Credentials = new NetworkCredential(id, pw);
		ftpWebRequest.KeepAlive = false;
		ftpWebRequest.Method = "STOR";
		ftpWebRequest.UseBinary = true;
		ftpWebRequest.ContentLength = fileInfo.Length;
		int num = 2048;
		byte[] array = new byte[checked(num + 1)];
		FileStream fileStream = fileInfo.OpenRead();
		try
		{
			Stream requestStream = ftpWebRequest.GetRequestStream();
			for (int num2 = fileStream.Read(array, 0, num); num2 != 0; num2 = fileStream.Read(array, 0, num))
			{
				requestStream.Write(array, 0, num2);
			}
			requestStream.Close();
			fileStream.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public object Abort()
	{
		try
		{
			reqFTP.Abort();
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void SaveFile(string FILENAME, string TEXT)
	{
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(MyUrl.ToString() + "/" + FILENAME);
		ftpWebRequest.Credentials = new NetworkCredential(id, pw);
		ftpWebRequest.KeepAlive = false;
		ftpWebRequest.Method = "STOR";
		ftpWebRequest.UseBinary = true;
		Encoding.Unicode.GetBytes(TEXT);
		try
		{
			Stream requestStream = ftpWebRequest.GetRequestStream();
			using (StreamWriter streamWriter = new StreamWriter(requestStream, Encoding.Default))
			{
				streamWriter.Write(TEXT);
				Application.DoEvents();
			}
			requestStream.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Application.DoEvents();
			if (Operators.ConditionalCompareObjectLess(fail_count, fail, TextCompare: false))
			{
				ref object reference = ref fail_count;
				reference = Operators.AddObject(reference, 1);
				SaveFile(FILENAME, TEXT);
			}
			else
			{
				fail_count = 0;
				Interaction.MsgBox("실패 카운트 초과 : \r\n\r\n" + ex2.Message);
			}
			ProjectData.ClearProjectError();
		}
	}

	public bool DeleteFTP(string filename)
	{
		try
		{
			FtpWebRequest obj = (FtpWebRequest)WebRequest.Create(MyUrl.ToString() + "/" + filename);
			obj.Credentials = new NetworkCredential(id, pw);
			obj.KeepAlive = false;
			obj.Method = "DELE";
			_ = string.Empty;
			FtpWebResponse obj2 = (FtpWebResponse)obj.GetResponse();
			_ = obj2.ContentLength;
			Stream responseStream = obj2.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			obj2.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	public string[] GetFilesDetailList()
	{
		string[] result = new string[0];
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			reqFTP.Method = "LIST";
			WebResponse response = reqFTP.GetResponse();
			StreamReader streamReader = new StreamReader(response.GetResponseStream());
			string value = streamReader.ReadLine();
			while (Conversions.ToDouble(value) != 1.0)
			{
				stringBuilder.Append(value);
				stringBuilder.Append("\r\n");
				value = streamReader.ReadLine();
			}
			stringBuilder.Remove(stringBuilder.ToString().LastIndexOf("\r\n"), 1);
			streamReader.Close();
			response.Close();
			stringBuilder.ToString().Split('\r');
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string GetFileList()
	{
		try
		{
			reqFTP.Timeout = 10000;
			reqFTP.UseBinary = true;
			reqFTP.Method = "NLST";
			FtpWebResponse ftpWebResponse = (FtpWebResponse)reqFTP.GetResponse();
			StreamReader streamReader = new StreamReader(ftpWebResponse.GetResponseStream(), Encoding.Default);
			string text = streamReader.ReadLine();
			while (!streamReader.EndOfStream)
			{
				text = text + "\r\n" + streamReader.ReadLine();
				Application.DoEvents();
			}
			ftpWebResponse.Close();
			streamReader.Close();
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			err = ex2.Message;
			string result = Conversions.ToString(Value: false);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object FileRead(string FILE, int enc)
	{
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri(FTPUrl.ToString() + "/" + FILE));
		try
		{
			ftpWebRequest.Method = "RETR";
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.Credentials = new NetworkCredential(id, pw);
			FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
			Stream responseStream = ftpWebResponse.GetResponseStream();
			string text = null;
			Encoding encoding = null;
			switch (enc)
			{
			case 0:
				encoding = Encoding.UTF8;
				break;
			case 1:
				encoding = Encoding.GetEncoding(51949);
				break;
			case 2:
				encoding = Encoding.Unicode;
				break;
			}
			StreamReader streamReader = new StreamReader(ftpWebResponse.GetResponseStream(), encoding);
			text = streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			ftpWebResponse.Close();
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Module1.databusy = false;
			Application.DoEvents();
			if (Operators.ConditionalCompareObjectLess(fail_count, fail, TextCompare: false))
			{
				ref object reference = ref fail_count;
				reference = Operators.AddObject(reference, 1);
				FileRead(FILE, enc);
			}
			else
			{
				fail_count = 0;
				Interaction.MsgBox("실패 카운트 초과 : \r\n\r\n" + ex2.Message);
			}
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public long GetFileSize(string filename)
	{
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri(FTPUrl.ToString() + filename));
		long result = 0L;
		try
		{
			ftpWebRequest.Method = "SIZE";
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.Credentials = new NetworkCredential(id, pw);
			FtpWebResponse obj = (FtpWebResponse)ftpWebRequest.GetResponse();
			Stream responseStream = obj.GetResponseStream();
			result = obj.ContentLength;
			responseStream.Close();
			obj.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void Rename(string currentFilename, string NewFilename)
	{
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri(FTPUrl.ToString() + "/" + currentFilename));
		try
		{
			ftpWebRequest.Method = "RENAME";
			ftpWebRequest.RenameTo = NewFilename;
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.Credentials = new NetworkCredential(id, pw);
			FtpWebResponse obj = (FtpWebResponse)ftpWebRequest.GetResponse();
			obj.GetResponseStream().Close();
			obj.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public void MakeDir(string dirName)
	{
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri(FTPUrl.ToString() + dirName));
		try
		{
			ftpWebRequest.Method = "MKD";
			ftpWebRequest.UseBinary = true;
			ftpWebRequest.Credentials = new NetworkCredential(id, pw);
			FtpWebResponse obj = (FtpWebResponse)ftpWebRequest.GetResponse();
			obj.GetResponseStream().Close();
			obj.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
