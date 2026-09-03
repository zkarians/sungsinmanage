using System;

namespace mlas_root;

public class db_ss_order
{
	public int index { get; set; }

	public int account_code { get; set; }

	public string account_name { get; set; }

	public int cus_code { get; set; }

	public string cus_name { get; set; }

	public string cus_call { get; set; }

	public string cus_phone { get; set; }

	public string product_code { get; set; }

	public string order_address { get; set; }

	public DateTime order_date { get; set; }

	public int order_status { get; set; }

	public string order_delivery { get; set; }

	public string order_etc { get; set; }
}
