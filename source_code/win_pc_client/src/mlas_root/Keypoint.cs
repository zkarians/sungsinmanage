using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class Keypoint
{
	private int _index;

	private string _name;

	private string _xml;

	private int _type;

	public Keypoint(string index, string name, string xml, string type)
	{
		_index = checked((int)Math.Round(Conversion.Val(index)));
		_name = name;
		_xml = xml;
		_type = Conversions.ToInteger(type);
	}

	public string getXML()
	{
		if (Operators.CompareString(_xml, null, TextCompare: false) == 0)
		{
			_xml = Conversions.ToString(Module1.HtmlSourceNoCredent(Module1._dburl + "/get.php?t=getXML&n=" + Conversions.ToString(_index)));
			if (Operators.CompareString(_xml, null, TextCompare: false) == 0)
			{
				return null;
			}
			return _xml;
		}
		return _xml;
	}

	public int getIndex()
	{
		return _index;
	}

	public string getName()
	{
		return _name;
	}

	public string getGroup()
	{
		return Conversions.ToString(_type);
	}

	public void setXML(string xml)
	{
		_xml = xml;
	}
}
