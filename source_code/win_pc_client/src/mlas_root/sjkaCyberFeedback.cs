using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class sjkaCyberFeedback
{
	private int _num;

	private string _sendId;

	private string _type;

	private string _originalType;

	private string _originaNum;

	private string _insideNum;

	private string _misc;

	private string _date;

	private bool _process;

	private string _rawdata;

	public sjkaCyberFeedback(string arrString)
	{
		string[] array = arrString.Split(new string[1] { "<sp>" }, StringSplitOptions.None);
		_num = checked((int)Math.Round(Conversion.Val(array[0])));
		_sendId = array[1];
		_process = Conversion.Val(array[2].Trim()) != 0.0;
		_originalType = array[3];
		switch (array[3])
		{
		case "doc":
			_type = "기출문제";
			break;
		case "keypoint":
			_type = "핵심요약";
			break;
		case "keyword":
			_type = "키워드";
			break;
		default:
			_type = "기타";
			break;
		}
		_originaNum = array[4];
		_insideNum = array[5];
		_misc = array[6];
		_date = array[7];
		_rawdata = arrString;
	}

	public int getNum()
	{
		return _num;
	}

	public string getSendId()
	{
		return _sendId;
	}

	public string getTypes()
	{
		return _type;
	}

	public string getOriginalNum()
	{
		return _originaNum;
	}

	public string getOriginalType()
	{
		return _originalType;
	}

	public string getInsideNum()
	{
		return _insideNum;
	}

	public string getMisc()
	{
		return _misc;
	}

	public string getDate()
	{
		return _date;
	}

	public string getProcess()
	{
		return Conversions.ToString(_process);
	}

	public void setProcess(bool arg)
	{
		_process = arg;
	}

	public string getRaw()
	{
		return _rawdata;
	}
}
