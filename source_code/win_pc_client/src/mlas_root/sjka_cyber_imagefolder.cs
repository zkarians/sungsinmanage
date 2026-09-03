using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using mlas_root.My;

namespace mlas_root;

public class sjka_cyber_imagefolder
{
	public class sjka_cyber_imageobject
	{
		public sjka_cyber_imagefolder parent;

		public int num { get; set; }

		public string name { get; set; }

		public Bitmap blob { get; set; }

		public string text { get; set; }

		public int folder { get; set; }

		public string imageSize { get; set; }

		public string imageAlert { get; set; }

		public sjka_cyber_imageobject()
		{
			imageSize = "알 수 없음";
		}
	}

	public bool init { get; set; }

	public string url { get; set; }

	public List<sjka_cyber_imageobject> list { get; set; }

	public sjka_cyber_imagefolder(string url)
	{
		init = false;
		this.url = url;
	}

	public string getName()
	{
		if (url.IndexOf(">") > 0)
		{
			return url.Substring(checked(url.LastIndexOf(">") + 1));
		}
		return url;
	}

	public List<sjka_cyber_imageobject> Initialization()
	{
		if (init)
		{
			return list;
		}
		list = new List<sjka_cyber_imageobject>();
		string hTML = new GetHtmlClass(Module1._dburl + "/get.php?t=imgGetFolder&d=" + HttpUtility.UrlEncode(url), null, progress: true).getHTML(MyProject.Forms.mlas);
		try
		{
			list = JsonConvert.DeserializeObject<List<sjka_cyber_imageobject>>(hTML);
			foreach (sjka_cyber_imageobject item in list)
			{
				item.parent = this;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			List<sjka_cyber_imageobject> result = null;
			ProjectData.ClearProjectError();
			return result;
		}
		init = true;
		return list;
	}
}
