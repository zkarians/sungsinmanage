using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

public class sjka_cyber_imagefolderlist
{
	public string group { get; set; }

	public sjka_cyber_imagefolderlist(object group)
	{
		this.group = Conversions.ToString(group);
	}
}
