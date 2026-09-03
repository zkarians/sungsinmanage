using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class AccountData
{
	private int _index;

	private string _id;

	private string _course;

	private bool _allow;

	private string _allowdate;

	private bool _phone;

	public int coin;

	public string PaidList;

	public AccountData(string index, string id, string course, string allow, string allowdate, string phone, string PaidList)
	{
		_index = checked((int)Math.Round(Conversion.Val(index)));
		_id = id;
		_course = course;
		if (Operators.CompareString(allow, "1", TextCompare: false) == 0)
		{
			_allow = true;
		}
		else
		{
			_allow = false;
		}
		_allowdate = allowdate;
		if (Operators.CompareString(phone, "1", TextCompare: false) == 0)
		{
			_phone = true;
		}
		else
		{
			_phone = false;
		}
		this.PaidList = PaidList;
	}

	public AccountData(string index, string id, string course, string allow, string allowdate, string phone, int coin, string PaidList)
	{
		_index = checked((int)Math.Round(Conversion.Val(index)));
		_id = id;
		_course = course;
		if (Operators.CompareString(allow, "1", TextCompare: false) == 0)
		{
			_allow = true;
		}
		else
		{
			_allow = false;
		}
		_allowdate = allowdate;
		if (Operators.CompareString(phone, "1", TextCompare: false) == 0)
		{
			_phone = true;
		}
		else
		{
			_phone = false;
		}
		this.coin = coin;
		this.PaidList = PaidList;
	}

	public string getIndex()
	{
		return Conversions.ToString(_index);
	}

	public string getId()
	{
		return _id;
	}

	public string getCourse()
	{
		return _course;
	}

	public bool getAllow()
	{
		return _allow;
	}

	public string getAllowDate()
	{
		return _allowdate;
	}

	public bool getPhone()
	{
		return _phone;
	}
}
