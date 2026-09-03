using System;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class ck_advertise
{
	public int index { get; set; }

	public string name { get; set; }

	public string fname { get; set; }

	public string url { get; set; }

	public string blob { get; set; }

	public ck_advertise(object _index, object _name, object _fname, object _url, object _blob)
	{
		index = Conversions.ToInteger(_index);
		name = Conversions.ToString(_name);
		fname = Conversions.ToString(_fname);
		url = Conversions.ToString(_url);
		blob = Conversions.ToString(_blob);
	}

	public Image getImage()
	{
		byte[] buffer = Convert.FromBase64String(blob);
		return Image.FromStream(new MemoryStream(buffer));
	}
}
