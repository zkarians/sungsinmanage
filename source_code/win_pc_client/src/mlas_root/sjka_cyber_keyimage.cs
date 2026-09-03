using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class sjka_cyber_keyimage
{
	public int index { get; set; }

	public string text { get; set; }

	public sjka_cyber_keyimage(object i, object t)
	{
		index = Conversions.ToInteger(i);
		text = Conversions.ToString(t);
	}
}
