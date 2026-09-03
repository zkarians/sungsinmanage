using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class KeypointXML
{
	private int _index;

	private string _name;

	private string _xml;

	private int _group;

	private List<List<string>> _structure;

	public KeypointXML(string index, string name, string xml, int group)
	{
		checked
		{
			_index = (int)Math.Round(Conversion.Val(index));
			_name = name;
			_structure = new List<List<string>>();
			_group = group;
			try
			{
				string[] array = xml.Trim().Replace("<doc>", "").Replace("</doc>", "")
					.Replace("<", "")
					.Replace("/>", "")
					.Replace(">", "")
					.Replace("\"", "")
					.Split(new string[1] { "/item" }, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i].Trim();
					if (Operators.CompareString(text, null, TextCompare: false) != 0)
					{
						_structure.Add(new List<string>(text.Replace("item name=", "").Split(new string[1] { "child name=" }, StringSplitOptions.RemoveEmptyEntries)));
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public int getIndex()
	{
		return _index;
	}

	public string getName()
	{
		return _name;
	}

	public int getGroup()
	{
		return _group;
	}

	public void Change(int position, int original, int target)
	{
		if (position == -1)
		{
			List<string> value = new List<string>(_structure[target]);
			_structure[target] = _structure[original];
			_structure[original] = value;
		}
		else
		{
			List<string> list = _structure[position];
			string value2 = list[target];
			list[target] = list[original];
			list[original] = value2;
		}
	}

	public void RemoveAt(int position, int position2 = -1)
	{
		if (position2 == -1)
		{
			_structure.RemoveAt(position);
		}
		else
		{
			_structure[position].RemoveAt(position2);
		}
	}

	public void add(int position, string text)
	{
		if (position == -1)
		{
			_structure.Add(new List<string>(new string[1] { text }));
		}
		else
		{
			_structure[position].Add(text);
		}
	}

	public void setString(string text, int array1, int array2)
	{
		try
		{
			_structure[array1][array2] = text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public object getString(int array1 = -1, int array2 = -1)
	{
		if (array1 != -1 && array2 == -1)
		{
			try
			{
				return _structure[array1];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				object result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
		if (array1 != -1 && array2 != -1)
		{
			try
			{
				return _structure[array1][array2];
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				object result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return _structure;
	}

	public int Count(int dimen = 0, int index = 0)
	{
		if (dimen == 0)
		{
			return _structure.Count;
		}
		return _structure[index].Count;
	}
}
