using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class sjka_cyber_paidlist
{
	public int course { get; set; }

	public string courseString { get; set; }

	public string validate { get; set; }

	public sjka_cyber_paidlist(object course, object validate)
	{
		this.course = Conversions.ToInteger(course);
		this.validate = Conversions.ToString(validate);
	}
}
