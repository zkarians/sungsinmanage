using System;
using System.Runtime.InteropServices;

namespace mlas_root;

internal class ObjectMover
{
	[DllImport("User32.dll")]
	private static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	private static extern int ReleaseCapture();

	[DllImport("user32.dll")]
	private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

	public static void FocusObject(IntPtr Handle)
	{
		SetForegroundWindow(Handle);
	}

	public static void MoveObject(IntPtr Handle)
	{
		ReleaseCapture();
		SendMessage(Handle, 161, 2, 0);
	}
}
