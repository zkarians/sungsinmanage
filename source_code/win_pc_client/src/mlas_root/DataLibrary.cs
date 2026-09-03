using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class DataLibrary
{
	private string _name;

	private int _index;

	private string _xml;

	private int _type;

	private string _s;

	private string _s1;

	private int _keyword;

	private int _keypoint;

	private bool _visible;

	private string _docs;

	private string _arr;

	private string _content;

	private int _views;

	private bool _silgi;

	public string pid;

	public DataLibrary(string index, string name, string arr)
	{
		_index = checked((int)Math.Round(Conversion.Val(index)));
		_name = name;
		_arr = arr;
	}

	public DataLibrary(string index, string name, string xml, string type)
	{
		checked
		{
			_index = (int)Math.Round(Conversion.Val(index));
			_name = name;
			_xml = xml;
			_type = (int)Math.Round(Conversion.Val(type));
		}
	}

	public DataLibrary(string index, string name, string docs, int keyword, string keypoint, bool visible, bool silgi, string coin)
	{
		_index = checked((int)Math.Round(Conversion.Val(index)));
		_name = name;
		_docs = docs;
		_keyword = keyword;
		_keypoint = Conversions.ToInteger(keypoint);
		_visible = visible;
		_silgi = silgi;
		pid = coin;
	}

	public string getArr()
	{
		return _arr;
	}

	public string getKeyword()
	{
		return Conversions.ToString(_keyword);
	}

	public int getKeypoint()
	{
		return _keypoint;
	}

	public int getVisible()
	{
		return 0 - (_visible ? 1 : 0);
	}

	public int getDocs()
	{
		return Conversions.ToInteger(_docs);
	}

	public string getName()
	{
		return _name;
	}

	public void setName(string name)
	{
		_name = name;
	}

	public bool getSilgi()
	{
		return _silgi;
	}

	public void setsilgi(bool @bool)
	{
		_silgi = @bool;
	}

	public int getIndex()
	{
		return _index;
	}

	public string getXML()
	{
		return _xml;
	}

	public void setXML(string xml)
	{
		_xml = xml;
	}

	public int getDocType()
	{
		return _type;
	}
}
