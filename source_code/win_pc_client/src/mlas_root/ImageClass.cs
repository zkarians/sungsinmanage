using System;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class ImageClass
{
	public int num;

	public string name;

	public string text;

	public string group;

	public ImageClass(string var)
	{
		string[] array = var.Split(new string[1] { "<br>" }, StringSplitOptions.None);
		num = Conversions.ToInteger(array[0]);
		name = array[1];
		text = array[2];
		group = array[3];
	}

	public ImageClass(object num, object name, object text, object group)
	{
		this.num = Conversions.ToInteger(num);
		this.name = Conversions.ToString(name);
		this.text = Conversions.ToString(text);
		this.group = Conversions.ToString(group);
	}

	public object getFindString()
	{
		return num + "  /  " + name + "  /  " + text + "  /  " + group + "  /  ";
	}
}
