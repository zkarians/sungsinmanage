using System.Windows.Forms;

namespace mlas_root;

public class DoubleBufferListView : ListView
{
	public DoubleBufferListView()
	{
		DoubleBuffered = true;
	}
}
