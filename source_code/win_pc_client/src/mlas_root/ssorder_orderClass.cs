using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My;

namespace mlas_root;

public class ssorder_orderClass
{
	public class deepClass
	{
		public class product
		{
			public string _name;

			public int _price;

			public string _count;

			public string _etc;

			public string _gb;

			public string _code;

			public product(object parse)
			{
				_name = "";
				_count = "";
				_etc = "";
				_gb = "";
				_code = "";
				string[] array = parse.ToString().Split(new string[1] { "<br>" }, StringSplitOptions.None);
				ssorder_productClass.deepClass deepClass = ssorder.order_productClass.getData().Find((ssorder_productClass.deepClass item) => (Operators.CompareString(item.product_code, array[0], TextCompare: false) == 0) ? true : false);
				if (deepClass != null)
				{
					_name = deepClass.product_name;
				}
				if (Operators.CompareString(array[1], null, TextCompare: false) == 0)
				{
					_price = 0;
				}
				else
				{
					_price = Conversions.ToInteger(array[1]);
				}
				_price = Conversions.ToInteger(array[1]);
				_count = array[2];
				_etc = array[3];
				if (deepClass != null)
				{
					_gb = deepClass.gb_code;
				}
				try
				{
					_code = array[0];
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}

			public product(bool addmode, string parse)
			{
				_name = "";
				_count = "";
				_etc = "";
				_gb = "";
				_code = "";
				string[] array = parse.ToString().Split(new string[1] { "<br>" }, StringSplitOptions.None);
				_name = array[0];
				_price = Conversions.ToInteger(array[1]);
				_count = array[2];
				_etc = array[3];
				_gb = array[4];
				try
				{
					_code = array[5];
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}

			public int getPrice()
			{
				if (Conversion.Val(_gb) == 2.0)
				{
					return 0;
				}
				return _price;
			}

			public string getNameNCount()
			{
				return _name + " x " + _count;
			}
		}

		public List<product> _products;

		public bool _check;

		public bool _visible;

		private int _index;

		private DateTime _order_date;

		private string _account_name;

		private int _cus_code;

		private string _cus_name;

		private string _cus_call;

		private string _cus_phone;

		private string _order_address;

		private string _product_names;

		private int _order_count;

		private double _order_price;

		private int _order_status;

		private string _order_delivery;

		private string _order_etc;

		public deepClass(db_ss_order d)
		{
			_products = new List<product>();
			_visible = true;
			_account_name = "";
			_order_address = "";
			_product_names = "";
			_order_delivery = "";
			_order_etc = "";
			_index = d.index;
			_order_date = d.order_date;
			db_ss_account db_ss_account2 = findAccount(d.account_code);
			if (db_ss_account2 != null)
			{
				_account_name = db_ss_account2.account_name;
			}
			else
			{
				_account_name = "";
			}
			if (d.cus_code == 0)
			{
				_cus_code = 0;
			}
			else
			{
				_cus_code = d.cus_code;
			}
			_cus_name = d.cus_name;
			_cus_call = d.cus_call;
			_cus_phone = d.cus_phone;
			_order_address = d.order_address.Replace("<other>", " ");
			string[] array = d.product_code.Split(new string[1] { "<product>" }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string parse in array)
			{
				_products.Add(new product(parse));
			}
			foreach (product product in _products)
			{
				ref string product_names = ref _product_names;
				product_names = product_names + product.getNameNCount() + "\r\n";
				_order_price += product.getPrice();
			}
			_product_names = _product_names.Trim();
			_order_status = d.order_status;
			_order_delivery = d.order_delivery;
			_order_etc = d.order_etc.Replace("<end>", "");
		}

		public deepClass(string[] arr)
		{
			_products = new List<product>();
			_visible = true;
			_account_name = "";
			_order_address = "";
			_product_names = "";
			_order_delivery = "";
			_order_etc = "";
			_index = Conversions.ToInteger(arr[0]);
			_order_date = Conversions.ToDate(arr[1]);
			_account_name = arr[2];
			if (Operators.CompareString(arr[3], "", TextCompare: false) == 0)
			{
				_cus_code = 0;
			}
			else
			{
				_cus_code = Conversions.ToInteger(arr[3]);
			}
			_cus_name = arr[4];
			_cus_call = arr[5];
			_cus_phone = arr[6];
			_order_address = arr[7].Replace("<other>", " ");
			string[] array = arr[8].Split(new string[1] { "<product>" }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string parse in array)
			{
				_products.Add(new product(parse));
			}
			foreach (product product in _products)
			{
				ref string product_names = ref _product_names;
				product_names = product_names + product.getNameNCount() + "\r\n";
				_order_price += product.getPrice();
			}
			_product_names = _product_names.Trim();
			_order_status = Conversions.ToInteger(arr[9]);
			_order_delivery = arr[10];
			_order_etc = arr[11].Replace("<end>", "");
		}

		private db_ss_account findAccount(int code)
		{
			db_ss_account db_ss_account2 = MyProject.Forms.android_db_ss_order.ss_account.Find((db_ss_account c) => (c.account_code == code) ? true : false);
			if (db_ss_account2 != null)
			{
				return db_ss_account2;
			}
			return null;
		}

		public object getProductNames()
		{
			_product_names = "";
			foreach (product product in _products)
			{
				ref string product_names = ref _product_names;
				product_names = product_names + product.getNameNCount() + "\r\n";
			}
			return _product_names.Trim();
		}

		public object getProductNamesCSV()
		{
			string text = "";
			foreach (product product in _products)
			{
				text = text + "[" + product.getNameNCount() + "] ";
			}
			return text;
		}

		public string getProducts()
		{
			string text = "";
			foreach (product product in _products)
			{
				text = text + "<product>" + product._code + "<br>" + Conversions.ToString(product._price) + "<br>" + product._count + "<br>" + product._etc;
			}
			return text;
		}

		public int getIndex()
		{
			return _index;
		}

		public string getAccountName()
		{
			return _account_name;
		}

		public string getCustomerName()
		{
			return _cus_name;
		}

		public string getCustomerPhoneNumber()
		{
			return _cus_phone;
		}

		public int getOrderStatus()
		{
			return _order_status;
		}

		public int getPrice()
		{
			_order_price = 0.0;
			foreach (product product in _products)
			{
				_order_price += product.getPrice();
			}
			return checked((int)Math.Round(_order_price));
		}

		public string[] getArray()
		{
			string text = null;
			text = _order_status switch
			{
				1 => "접수대기", 
				2 => "발송전", 
				3 => "발송전취소", 
				4 => "발송완료", 
				_ => Conversions.ToString(_order_status), 
			};
			return new string[12]
			{
				_account_name,
				Conversions.ToString(_index),
				Conversions.ToString(_order_date),
				_order_etc,
				_cus_name,
				_cus_call,
				_cus_phone,
				_order_address,
				Conversions.ToString(getProductNamesCSV()),
				"\\" + _order_price.ToString("N0"),
				text,
				_order_delivery
			};
		}

		public string[] getGridData()
		{
			string text = null;
			text = _order_status switch
			{
				1 => "접수대기", 
				2 => "발송전", 
				3 => "발송전취소", 
				4 => "발송완료", 
				_ => Conversions.ToString(_order_status), 
			};
			return new string[13]
			{
				Conversions.ToString(Value: false),
				_account_name,
				Conversions.ToString(_index),
				Conversions.ToString(_order_date),
				_order_etc,
				_cus_name,
				_cus_call,
				_cus_phone,
				_order_address,
				_product_names,
				"\\" + _order_price.ToString("N0"),
				text,
				_order_delivery
			};
		}
	}

	private List<deepClass> datalist;

	public ssorder_orderClass(List<db_ss_order> data)
	{
		datalist = new List<deepClass>();
		foreach (db_ss_order datum in data)
		{
			try
			{
				datalist.Add(new deepClass(datum));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ref string errorIndex = ref MyProject.Forms.android_db_ss_order.errorIndex;
				errorIndex = errorIndex + "\r\n\r\n" + Conversions.ToString(datum.index) + "\r\n";
				ProjectData.ClearProjectError();
			}
		}
	}

	public ssorder_orderClass(string parse)
	{
		datalist = new List<deepClass>();
		string[] array = parse.Split(new string[1] { "<split>" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			datalist.Add(new deepClass(text.Split(new string[1] { "<next>" }, StringSplitOptions.None)));
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

	public void add(string[] data)
	{
		datalist.Add(new deepClass(data));
	}

	public string ColumnHeaderText()
	{
		return "판매자명,번호,접수일자,비고,고객명,자택전화,휴대전화,배송지주소,제품명,총금액,접수상태,송장번호";
	}
}
