using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using mlas_root.My;

namespace mlas_root;

public class cti_tm_list
{
	[JsonProperty(PropertyName = "db_idx")]
	public int db_idx { get; set; }

	[JsonProperty(PropertyName = "idx")]
	public int idx { get; set; }

	[JsonProperty(PropertyName = "agent_idx")]
	public int? agent_idx { get; set; }

	[JsonProperty(PropertyName = "name")]
	public string name { get; set; }

	[JsonProperty(PropertyName = "home_number")]
	public string home_number { get; set; }

	[JsonProperty(PropertyName = "phone_number")]
	public string phone_number { get; set; }

	[JsonProperty(PropertyName = "address")]
	public string address { get; set; }

	[JsonProperty(PropertyName = "product_name")]
	public string product_name { get; set; }

	[JsonProperty(PropertyName = "seller")]
	public string seller { get; set; }

	[JsonProperty(PropertyName = "price")]
	public int? price { get; set; }

	[JsonProperty(PropertyName = "result")]
	public int result { get; set; }

	[JsonProperty(PropertyName = "call_time")]
	public string call_time { get; set; }

	[JsonProperty(PropertyName = "call_count")]
	public int? call_count { get; set; }

	[JsonProperty(PropertyName = "call_phone")]
	public string call_phone { get; set; }

	[JsonProperty(PropertyName = "restored")]
	public int restored { get; set; }

	[JsonProperty(PropertyName = "comment")]
	public string comment { get; set; }

	[JsonProperty(PropertyName = "comment2")]
	public string comment2 { get; set; }

	[JsonProperty(PropertyName = "blacklist")]
	public int blacklist { get; set; }

	[JsonProperty(PropertyName = "is_correct")]
	public bool is_correct { get; set; }

	public cti_tm_list()
	{
		call_count = 0;
	}

	public string[] getArray()
	{
		string text = "";
		if (agent_idx.HasValue)
		{
			cti_agents cti_agents2 = MyProject.Forms.ssorder_cti.ctiAgents.Find(delegate(cti_agents a)
			{
				int? account_code = a.account_code;
				int? num = agent_idx;
				return ((account_code.HasValue & num.HasValue) ? new bool?(account_code.GetValueOrDefault() == num.GetValueOrDefault()) : null).GetValueOrDefault() ? true : false;
			});
			if (cti_agents2 != null)
			{
				text = cti_agents2.account_name;
			}
		}
		string text2 = "";
		if (call_count.HasValue)
		{
			text2 = Conversions.ToString(call_count.Value);
		}
		return new string[15]
		{
			Conversions.ToString(idx),
			text,
			name,
			Conversions.ToString(Interaction.IIf(Operators.CompareString(home_number, null, TextCompare: false) == 0, "", home_number)),
			Conversions.ToString(Interaction.IIf(Operators.CompareString(phone_number, null, TextCompare: false) == 0, "", phone_number)),
			Conversions.ToString(Interaction.IIf(Operators.CompareString(address, null, TextCompare: false) == 0, "", address)),
			Conversions.ToString(Interaction.IIf(Operators.CompareString(product_name, null, TextCompare: false) == 0, "", product_name)),
			Conversions.ToString(Interaction.IIf(Operators.CompareString(seller, null, TextCompare: false) == 0, "", seller)),
			Conversions.ToString(Interaction.IIf(!price.HasValue, "", price)),
			text2,
			Conversions.ToString(Interaction.IIf(Operators.CompareString(call_phone, null, TextCompare: false) == 0, "", call_phone)),
			ResultString(),
			Conversions.ToString(Interaction.IIf(Operators.CompareString(comment, null, TextCompare: false) == 0, "", comment)),
			Conversions.ToString(Interaction.IIf(Operators.CompareString(comment2, null, TextCompare: false) == 0, "", comment2)),
			Conversions.ToString(Interaction.IIf(blacklist == 1, "O", ""))
		};
	}

	public string ResultString()
	{
		switch (result)
		{
		case 1:
			return "동의";
		case 2:
			return "무관심";
		case 3:
			return "TM거부";
		case 4:
			return "무응답";
		case 5:
			return "통화중";
		case 6:
			return "통화예약";
		case 7:
			return "결번";
		case 8:
			return "본인아님";
		default:
		{
			int? num = call_count;
			if ((num.HasValue ? new bool?(num.GetValueOrDefault() > 0) : null).GetValueOrDefault())
			{
				return "통화종료";
			}
			return "-";
		}
		}
	}
}
