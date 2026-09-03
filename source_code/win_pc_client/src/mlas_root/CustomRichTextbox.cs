using System.ComponentModel;
using System.Diagnostics;

namespace mlas_root;

internal class CustomRichTextbox : Component
{
	private IContainer components;

	[DebuggerNonUserCode]
	public CustomRichTextbox(IContainer container)
		: this()
	{
		container?.Add(this);
	}

	[DebuggerNonUserCode]
	public CustomRichTextbox()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = new Container();
	}
}
