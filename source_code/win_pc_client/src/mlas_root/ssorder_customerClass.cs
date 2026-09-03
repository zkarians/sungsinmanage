using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class ssorder_customerClass
{
	public class deepClass
	{
		public bool _check;

		private int _cus_code;

		private string _account_id;

		private string _cus_name;

		private string _cus_call;

		private string _cus_phone;

		private string _cus_address;

		public deepClass(string[] arr)
		{
			_cus_code = Conversions.ToInteger(arr[0]);
			_account_id = arr[1];
			_cus_name = arr[2];
			_cus_call = arr[3];
			_cus_phone = arr[4];
			_cus_address = arr[5];
		}

		public deepClass(string[] arr, bool diagMode)
		{
			_cus_code = Conversions.ToInteger(arr[0]);
			_cus_name = arr[1];
			_cus_call = arr[2];
			_cus_phone = arr[3];
			_cus_address = arr[4];
		}

		public string getCustomerCode()
		{
			return Conversions.ToString(_cus_code);
		}

		public string getCustomerName()
		{
			return _cus_name;
		}

		public string getCustomerCallNumber()
		{
			return _cus_call;
		}

		public string getCustomerPhoneNumber()
		{
			return _cus_phone;
		}

		public string getCustomerAddress()
		{
			return _cus_address;
		}

		public string[] getArray()
		{
			return new string[6]
			{
				Conversions.ToString(_cus_code),
				_account_id,
				_cus_name,
				_cus_call,
				_cus_phone,
				_cus_address.Replace("<split>", " ")
			};
		}

		public string[] getGridData()
		{
			return new string[7]
			{
				Conversions.ToString(Value: false),
				Conversions.ToString(_cus_code),
				_account_id,
				_cus_name,
				_cus_call,
				_cus_phone,
				_cus_address
			};
		}

		public string[] getGridDataDiagMode()
		{
			return new string[5]
			{
				Conversions.ToString(_cus_code),
				_cus_name,
				_cus_call,
				_cus_phone,
				_cus_address
			};
		}
	}

	private List<deepClass> datalist;

	public ssorder_customerClass(string parse)
	{
		datalist = new List<deepClass>();
		string[] array = parse.Split(new string[1] { "<split>" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			datalist.Add(new deepClass(text.Split(new string[1] { "<next>" }, StringSplitOptions.None)));
		}
	}

	public ssorder_customerClass(string parse, bool diagMode)
	{
		datalist = new List<deepClass>();
		string[] array = parse.Split(new string[1] { "<split>" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			datalist.Add(new deepClass(text.Split(new string[1] { "<next>" }, StringSplitOptions.None), diagMode));
		}
	}

	public List<deepClass> getData()
	{
		return datalist;
	}

	public deepClass getData(int index)
	{
		return datalist[index];
	}

	public deepClass getData(string customer_code)
	{
		foreach (deepClass item in datalist)
		{
			if (item.getCustomerCode().Equals(customer_code))
			{
				return item;
			}
		}
		return null;
	}

	public void add(string[] data)
	{
		datalist.Add(new deepClass(data));
	}

	public string ColumnHeaderText()
	{
		return "고객번호,등록자ID,고객명,자택전화,휴대전화,자택주소";
	}
}
