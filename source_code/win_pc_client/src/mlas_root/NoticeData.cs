using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class NoticeData
{
	private int _index;

	private string _title;

	private string _content;

	private string _views;

	public NoticeData(string index, string title, string content, string views)
	{
		_index = checked((int)Math.Round(Conversion.Val(index)));
		_title = title;
		_content = content;
		_views = Conversions.ToString(Conversion.Val(views));
	}

	public string getIndex()
	{
		return Conversions.ToString(_index);
	}

	public string getTitle()
	{
		return _title;
	}

	public string getContent()
	{
		return _content;
	}

	public string getViews()
	{
		return _views;
	}
}
