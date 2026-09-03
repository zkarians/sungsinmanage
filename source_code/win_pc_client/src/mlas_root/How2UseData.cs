using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class How2UseData
{
	private int _index;

	private string _title;

	private string _content;

	private bool _important;

	private bool _lock;

	public bool _ios;

	public bool Important
	{
		get
		{
			return _important;
		}
		set
		{
			_important = value;
		}
	}

	public How2UseData(string index, string title, string content, bool important, bool @lock)
	{
		_important = false;
		_lock = false;
		_ios = false;
		_index = checked((int)Math.Round(Conversion.Val(index)));
		_title = title;
		_content = content;
		_important = important;
		_lock = @lock;
	}

	public How2UseData(string index, string title, string content, bool important, bool @lock, bool ios)
	{
		_important = false;
		_lock = false;
		_ios = false;
		_index = checked((int)Math.Round(Conversion.Val(index)));
		_title = title;
		_content = content;
		_important = important;
		_lock = @lock;
		_ios = ios;
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

	public string getLock()
	{
		return Conversions.ToString(_lock);
	}
}
