using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using mlas_root.My;

namespace mlas_root;

[StandardModule]
internal sealed class ssorder
{
	public static object ssorder_server = "http://localhost:5000/tmserver";

	public static int ssorder_version = 318;

	public static int ssorder_acgb;

	public static int ssorder_team_code;

	public static string ssorder_name;

	public static int ssorder_account_code;

	public static string cti_account_idx;

	public static ssorder_productClass order_productClass;

	public static ssorder_orderClass orderClass;

	public static ssorder_customerClass customerClass;

	public static ssorder_productClass productClass;

	public static ssorder_accountClass accountClass;

	public static ssorder_productClass orderProductClass;

	public static ssorder_customerClass setOrderCustomerClass;

	public static string ssorder_gb;

	public static string ssorder_gb2;

	public static bool ssorder_update_check = false;

	public static int latest_version;

	public static bool forceUpdate;

	public static bool findUpdate()
	{
		try
		{
			JObject jObject = JObject.Parse(new GetHtmlClass(Module1._dburl + "/update/get.php").getHTML(null));
			latest_version = checked((int)Math.Round(Conversion.Val(jObject.SelectToken("latest_version").ToString())));
			forceUpdate = (bool)jObject.SelectToken("force");
			try
			{
				if (!MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\update.exe"))
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (latest_version > ssorder_version)
			{
				return true;
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ssorder_update_check = false;
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return false;
	}

	public static DataSet openExcel(string file)
	{
		DataSet dataSet = new DataSet();
		IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(File.Open(file, FileMode.Open, FileAccess.Read));
		dataSet = excelDataReader.AsDataSet();
		excelDataReader.Close();
		return dataSet;
	}
}
