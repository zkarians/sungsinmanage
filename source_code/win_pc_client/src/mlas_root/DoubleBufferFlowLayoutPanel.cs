using System.Windows.Forms;

namespace mlas_root;

public class DoubleBufferFlowLayoutPanel : FlowLayoutPanel
{
	public DoubleBufferFlowLayoutPanel()
	{
		DoubleBuffered = true;
		SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, value: true);
		UpdateStyles();
	}
}
