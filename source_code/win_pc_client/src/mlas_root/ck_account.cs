using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class ck_account
{
	public bool _checked;

	public int index { get; set; }

	public int banned { get; set; }

	public string account_id { get; set; }

	public string account_name { get; set; }

	public int apptype { get; set; }

	public string user_name { get; set; }

	public string user_phone { get; set; }

	public ck_account()
	{
		_checked = false;
	}

	public string[] getGridData()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.IIf(banned.Equals(0), "이용가능", "정지됨"));
		object objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.IIf(apptype.Equals(0), "MOM출첵", "학원출첵"));
		return new string[8]
		{
			Conversions.ToString(Value: false),
			Conversions.ToString(index),
			account_id,
			account_name,
			user_name,
			user_phone,
			Conversions.ToString(objectValue),
			Conversions.ToString(objectValue2)
		};
	}
}
