using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class sjka_cyber_course
{
	public int index { get; set; }

	public string course { get; set; }

	public sjka_cyber_course(object index, object course)
	{
		this.index = Conversions.ToInteger(index);
		this.course = Conversions.ToString(course);
	}
}
