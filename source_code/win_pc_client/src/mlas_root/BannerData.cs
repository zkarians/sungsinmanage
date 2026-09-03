using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class BannerData
{
	private int _index;

	private string _id;

	private string _url;

	public BannerData(int index, string id, string url)
	{
		_index = checked((int)Math.Round(Conversion.Val(index)));
		_id = id;
		_url = url;
	}

	public string getIndex()
	{
		return Conversions.ToString(_index);
	}

	public string getId()
	{
		return _id;
	}

	public void setId(string Id)
	{
		_id = Id;
	}

	public string getUrl()
	{
		return _url;
	}

	public void setUrl(string URL)
	{
		_url = URL;
	}
}
