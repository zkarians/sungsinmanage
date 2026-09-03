using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace mlas_root.CRT;

public class CustomRichTextbox : RichTextBox
{
	private const int SB_HORZ = 0;

	private const int SB_VERT = 1;

	public int HorizontalPosition
	{
		get
		{
			return GetScrollPos(base.Handle, 0);
		}
		set
		{
			SetScrollPos(base.Handle, 0, value, bRedraw: true);
		}
	}

	public int VerticalPosition
	{
		get
		{
			return GetScrollPos(base.Handle, 1);
		}
		set
		{
			SetScrollPos(base.Handle, 1, value, bRedraw: true);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int GetScrollPos(IntPtr hWnd, int nBar);

	[DllImport("user32.dll")]
	private static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);

	public CustomRichTextbox()
	{
		SetStyle(ControlStyles.DoubleBuffer, value: true);
	}
}
