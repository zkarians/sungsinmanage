using System.Windows.Forms;

namespace mlas_root;

public class TransparentListBox : ListBox
{
	public TransparentListBox()
	{
		SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
	}
}
