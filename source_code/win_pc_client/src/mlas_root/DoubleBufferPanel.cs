using System.Windows.Forms;

namespace mlas_root;

public class DoubleBufferPanel : Panel
{
	public DoubleBufferPanel()
	{
		DoubleBuffered = true;
		SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		UpdateStyles();
	}
}
