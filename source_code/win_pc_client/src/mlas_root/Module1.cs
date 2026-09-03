using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My;

namespace mlas_root;

[StandardModule]
internal sealed class Module1
{
	public sealed class Projects
	{
		public const string home_db_microlivire = "home_db_microlivire";

		public const string android_db_sjka_application_noteapp = "android_db_sjka_application_noteapp";

		public const string android_db_sjka_cyber = "android_db_sjka_cyber";

		public const string android_db_kjh_smart_screen = "android_db_kjh_smart_screen";

		public const string server_url_modify = "server_url_modify";

		public const string windows_db_human_chart = "windows_db_human_chart";

		public const string android_db_ss_order = "android_db_ss_order";

		public const string android_mba_check = "android_mba_check";

		public const string android_mom_hakwon = "android_mom_hakwon";
	}

	public static int version = 276;

	public static int server_version = version;

	public static string click_url = "http://umylife0208.cafe24.com/";

	public static string forceProject = "android_db_ss_order";

	public static string forceTitle = "성신판매접수 관리자";

	public static Panel NOW_DOCK;

	public static bool MLAS_logout = false;

	public static object Menu_textSize = 12;

	public static object Menu_HeightSize = 14;

	public static bool set_animation = false;

	public static bool CMsgboxOption = true;

	public static bool refresh_busy = false;

	public static string[] notice = new string[3];

	public static int notice_color = 0;

	public static string project = null;

	public static string _dburl = null;

	public static string _id = null;

	public static string _pw = null;

	public static string _userName = null;

	public static string _useTime = null;

	public static int permission = 0;

	public static string[] AllData = null;

	public static int datapageNOW = 1;

	public static int datapageMAX = 1;

	public static string[] SearchData;

	public static string encode;

	public static object[] survey_data;

	public static string[] ASfile;

	public static string ASurl = null;

	public static string[] board = null;

	public static bool databusy = false;

	public static bool search_mode = false;

	public static string[] column;

	public static string[] record;

	public static object search1;

	public static object search2;

	public static Thread saveThread;

	public static Thread thr;

	public static Thread thr3;

	public static string searchMode;

	public static string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MLAS\\";

	public static bool filebrowserBetaAlarm = false;

	public static string csvChar34Replace(string arg)
	{
		arg = arg.Replace("\"\"", "&chr34;");
		checked
		{
			if (arg.IndexOf('"') > 0)
			{
				string text = null;
				string text2 = arg.Substring(arg.IndexOf('"') + 1);
				string text3 = text2.Substring(0, text2.IndexOf('"'));
				text = arg.Substring(arg.IndexOf('"'), text3.Length + 2);
				string newValue = text3.Replace(",", "&quot;").Replace("\"", "");
				return csvChar34Replace(arg.Replace(text, newValue));
			}
			return arg;
		}
	}

	public static string UrlEncode(string str)
	{
		return HttpUtility.UrlEncode(str);
	}

	public static object HtmlSourceNoCredent(string URL, string FailURL = null)
	{
		try
		{
			byte[] bytes = new WebClient().DownloadData(URL);
			string result = null;
			string left = encode;
			if (Operators.CompareString(left, null, TextCompare: false) == 0)
			{
				result = Encoding.UTF8.GetString(bytes);
			}
			else if (Operators.CompareString(left, "UTF8", TextCompare: false) == 0)
			{
				result = Encoding.UTF8.GetString(bytes);
			}
			else if (Operators.CompareString(left, "DEFAULT", TextCompare: false) == 0)
			{
				result = Encoding.Default.GetString(bytes);
			}
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			object result2 = "incorrect : " + ex2.Message;
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	public static string HTMLPost(string url, string PostData = "")
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
		httpWebRequest.AllowAutoRedirect = true;
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		byte[] bytes = Encoding.UTF8.GetBytes(PostData);
		httpWebRequest.ContentLength = bytes.Length;
		using (Stream stream = httpWebRequest.GetRequestStream())
		{
			stream.Write(bytes, 0, bytes.Length);
		}
		using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		return new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
	}

	public static bool refreshBusyCheck(bool finish = false)
	{
		if (finish)
		{
			refresh_busy = false;
			return true;
		}
		if (refresh_busy)
		{
			CustomMsgBox.CMsgBox("통신대기로 인한 지연을 방지하기 위하여 새로고침은 시간간격을 두고 하시기 바랍니다.\r\n잠시 후에 다시 시도하십시오.", "통신대기 발생", "닫기", custom_msgbox.CMsgboxColor.Red, custom_msgbox.CmsgBoxIcon.icon_Error, custom_msgbox.ShowLocation.BottomRight, autoClose: true, 3000);
			return false;
		}
		refresh_busy = true;
		return true;
	}

	public static void ASrefresh()
	{
		ASfile = new GetHtmlClass("http://umylife0208.cafe24.com/mlas/admin.php?type=as&data=" + HttpUtility.UrlEncode(project), null, progress: true).getHTML(null).ToString().Split(new string[1] { ">" }, StringSplitOptions.RemoveEmptyEntries);
		MyProject.Forms.mlas.ListView4.Items.Clear();
		checked
		{
			int num = ASfile.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				string[] array = ASfile[i].Split(new string[1] { "|" }, StringSplitOptions.None);
				MyProject.Forms.mlas.ListView4.Items.Add(Conversions.ToString(ASfile.Length - i));
				MyProject.Forms.mlas.ListView4.Items[i].SubItems.Add(array[1]);
				MyProject.Forms.mlas.ListView4.Items[i].SubItems.Add(array[2]);
				MyProject.Forms.mlas.ListView4.Items[i].SubItems.Add(array[3]);
				if (Operators.CompareString(array[5], null, TextCompare: false) == 0)
				{
					MyProject.Forms.mlas.ListView4.Items[i].SubItems.Add("  X");
				}
				else
				{
					MyProject.Forms.mlas.ListView4.Items[i].SubItems.Add("  O");
				}
			}
			MyProject.Forms.mlas.Panel90.Hide();
			MyProject.Forms.mlas.TextBox19.Text = null;
			MyProject.Forms.mlas.ListView4.Dock = DockStyle.Fill;
		}
	}

	public static string GetImageExtension(Image i)
	{
		Guid guid = i.RawFormat.Guid;
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		foreach (ImageCodecInfo imageCodecInfo in imageDecoders)
		{
			if (imageCodecInfo.FormatID == guid)
			{
				return imageCodecInfo.FilenameExtension.Split(new string[1] { ";" }, StringSplitOptions.RemoveEmptyEntries)[0].Remove(0, 2);
			}
		}
		return "*";
	}

	public static string GetImageFilter(Image i)
	{
		Guid guid = i.RawFormat.Guid;
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		foreach (ImageCodecInfo imageCodecInfo in imageDecoders)
		{
			if (imageCodecInfo.FormatID == guid)
			{
				string[] array = imageCodecInfo.FilenameExtension.Split(new string[1] { ";" }, StringSplitOptions.RemoveEmptyEntries);
				string text = null;
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					text = text + text2 + "|" + text2 + "|";
				}
				return text.Remove(checked(text.Length - 1));
			}
		}
		return "*.*";
	}

	public static Point ControlCenter(object BasePanel, object NewLocationPanel)
	{
		Point result = default(Point);
		result.X = Conversions.ToInteger(Operators.SubtractObject(Operators.DivideObject(NewLateBinding.LateGet(NewLateBinding.LateGet(BasePanel, null, "ClientSize", new object[0], null, null, null), null, "Height", new object[0], null, null, null), 2), Operators.DivideObject(NewLateBinding.LateGet(NewLocationPanel, null, "Height", new object[0], null, null, null), 2)));
		result.Y = Conversions.ToInteger(Operators.SubtractObject(Operators.DivideObject(NewLateBinding.LateGet(NewLateBinding.LateGet(BasePanel, null, "ClientSize", new object[0], null, null, null), null, "Width", new object[0], null, null, null), 2), Operators.DivideObject(NewLateBinding.LateGet(NewLocationPanel, null, "Width", new object[0], null, null, null), 2)));
		checked
		{
			result.X -= 50;
			result.Y -= 50;
			return result;
		}
	}

	public static byte[] ImageToByte(Image img)
	{
		return (byte[])new ImageConverter().ConvertTo(img, typeof(byte[]));
	}

	public static void FManagerShow(Panel parent, object target, string search)
	{
		parent.Hide();
		MyProject.Forms.fileManager.parentObject = parent;
		MyProject.Forms.fileManager.target = RuntimeHelpers.GetObjectValue(target);
		MyProject.Forms.fileManager.search = search;
		MyProject.Forms.mlas.Panel2.Controls.Add(MyProject.Forms.fileManager.p_fileManager);
		MyProject.Forms.fileManager.p_fileManager.Show();
		MyProject.Forms.fileManager.imgList();
		MyProject.Forms.fileManager.ListView1.Focus();
	}

	public static void FManagerShowV2(Panel parent, object target, string search)
	{
		parent.Hide();
		MyProject.Forms.fileManager.parentObject = parent;
		MyProject.Forms.fileManager.target = RuntimeHelpers.GetObjectValue(target);
		MyProject.Forms.fileManager.search = search;
		MyProject.Forms.fileManager.searchFinish = false;
		MyProject.Forms.mlas.Panel2.Controls.Add(MyProject.Forms.fileManager.filemanager_v2);
		MyProject.Forms.fileManager.filemanager_v2.Show();
		if (MyProject.Forms.fileManager.folderList.Count <= 0)
		{
			MyProject.Forms.fileManager.FolderRefresh();
		}
		else
		{
			MyProject.Forms.fileManager.searchNum();
		}
	}

	public static string Base64Encode(string str)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(str)).Replace("\\n", "");
	}

	public static string Base64Decode(string str)
	{
		byte[] bytes = Convert.FromBase64String(str);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string ImageToBase64(string filename, ImageFormat format)
	{
		Bitmap bitmap = new Bitmap(filename);
		using MemoryStream memoryStream = new MemoryStream();
		bitmap.Save(memoryStream, format);
		return Convert.ToBase64String(memoryStream.ToArray());
	}
}
