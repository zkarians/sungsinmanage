using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

internal class ListViewComparer : IComparer
{
	private int m_ColumnNumber;

	private SortOrder m_SortOrder;

	public ListViewComparer(int column_number, SortOrder sort_order)
	{
		m_ColumnNumber = column_number;
		m_SortOrder = sort_order;
	}

	public int Compare(object x, object y)
	{
		ListViewItem listViewItem = (ListViewItem)x;
		ListViewItem listViewItem2 = (ListViewItem)y;
		string text = ((listViewItem.SubItems.Count > m_ColumnNumber) ? listViewItem.SubItems[m_ColumnNumber].Text : "");
		string text2 = ((listViewItem2.SubItems.Count > m_ColumnNumber) ? listViewItem2.SubItems[m_ColumnNumber].Text : "");
		if (m_SortOrder == SortOrder.Ascending)
		{
			if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
			{
				return Conversion.Val(text).CompareTo(Conversion.Val(text2));
			}
			if (Information.IsDate(text) & Information.IsDate(text2))
			{
				return DateTime.Parse(text).CompareTo(DateTime.Parse(text2));
			}
			return string.Compare(text, text2);
		}
		if (Versioned.IsNumeric(text) & Versioned.IsNumeric(text2))
		{
			return Conversion.Val(text2).CompareTo(Conversion.Val(text));
		}
		if (Information.IsDate(text) & Information.IsDate(text2))
		{
			return DateTime.Parse(text2).CompareTo(DateTime.Parse(text));
		}
		return string.Compare(text2, text);
	}

	int IComparer.Compare(object x, object y)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Compare
		return this.Compare(x, y);
	}
}
