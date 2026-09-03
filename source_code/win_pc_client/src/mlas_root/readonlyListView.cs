using System;
using System.Windows.Forms;

namespace mlas_root;

public class readonlyListView : ListView
{
	private bool mCreating;

	private bool mReadOnly;

	public bool ReadOnly
	{
		get
		{
			return mReadOnly;
		}
		set
		{
			mReadOnly = value;
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		mCreating = true;
		base.OnHandleCreated(e);
		mCreating = false;
	}

	protected override void OnItemCheck(ItemCheckEventArgs e)
	{
		e.NewValue = e.CurrentValue;
		base.OnItemCheck(e);
	}
}
