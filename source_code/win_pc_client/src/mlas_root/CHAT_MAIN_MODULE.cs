using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My;

namespace mlas_root;

[StandardModule]
public sealed class CHAT_MAIN_MODULE
{
	public static CHAT CHAT_CLASS;

	public static Form CHAT_FORM = new Form();

	public static string CHAT_NOWID;

	public static void LooperStart()
	{
		MyProject.Forms.mlas.chat_receiver.Start();
		MyProject.Forms.CHAT_MAIN.looper.Start();
	}

	public static void LooperStop()
	{
		MyProject.Forms.mlas.chat_receiver.Stop();
		MyProject.Forms.CHAT_MAIN.looper.Stop();
	}

	public static void LooperInterval(int value)
	{
		MyProject.Forms.mlas.chat_receiver.Interval = value;
		MyProject.Forms.CHAT_MAIN.looper.Interval = value;
	}
}
