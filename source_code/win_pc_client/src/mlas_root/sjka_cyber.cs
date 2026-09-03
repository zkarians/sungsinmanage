using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

[StandardModule]
internal sealed class sjka_cyber
{
	public static List<Keypoint> KeypointDB;

	public static List<KeypointXML> KeypointXML;

	public static string[] keypointZip;

	public static List<DataLibrary> ZipList_dl;

	public static string[] KwordZip;

	public static List<string> catList;

	public static List<DataLibrary> catLib;

	public static List<string> cList2;

	public static List<NoticeData> NOTICE_ND;

	public static List<BannerData> BANNER;

	public static List<AccountData> ACCOUNT_AD;

	public static List<DocData> docs;

	public static List<sjkaCyberFeedback> feedback;

	public static List<How2UseData> HOW2USE;

	public static Form emulator;

	public static List<sjka_cyber_keyimage> keyword_imagelist;
}
