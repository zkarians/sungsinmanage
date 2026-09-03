using System.Windows.Forms;

namespace mlas_root;

public class NoCopyLabel : Label
{
	private int WM_GETTEXT;

	private int WM_LBUTTONDBLCLK;

	private bool doubleclickflag;

	public NoCopyLabel()
	{
		WM_GETTEXT = 13;
		WM_LBUTTONDBLCLK = 515;
		doubleclickflag = false;
	}

	protected override void WndProc(ref Message m)
	{
		if (m.Msg == WM_LBUTTONDBLCLK)
		{
			doubleclickflag = true;
		}
		if (m.Msg == WM_GETTEXT && doubleclickflag)
		{
			doubleclickflag = false;
		}
		else
		{
			base.WndProc(ref m);
		}
	}
}
