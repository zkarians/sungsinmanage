namespace mlas_root;

public class cti_agents
{
	public int idx { get; set; }

	public int? account_code { get; set; }

	public string account_id { get; set; }

	public string account_name { get; set; }

	public string regist_date { get; set; }

	public string expire_date { get; set; }

	public int expire { get; set; }

	public int? logging { get; set; }

	public string last_date { get; set; }

	public string LoggingStateString()
	{
		int? num = logging;
		int? num2 = num;
		if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 1) : null).GetValueOrDefault())
		{
			return "접속중";
		}
		num2 = num;
		if ((num2.HasValue ? new bool?(num2.GetValueOrDefault() == 2) : null).GetValueOrDefault())
		{
			return "자리비움";
		}
		int num3 = expire;
		if (num3 == 1)
		{
			return "해촉자";
		}
		return "-";
	}
}
