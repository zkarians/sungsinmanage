using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace mlas_root;

[ToolboxBitmap(typeof(ComboBox))]
internal class ComboBoxEx : ComboBox
{
	public ComboBoxEx()
	{
		base.DrawMode = DrawMode.OwnerDrawFixed;
		base.DrawItem += ComboBoxEx_DrawItem;
		base.Resize += ComboBoxEx_Resize;
	}

	private void ComboBoxEx_Resize(object sender, EventArgs e)
	{
		NewLateBinding.LateCall(sender, null, "Invalidate", new object[0], null, null, null, IgnoreReturn: true);
	}

	private void ComboBoxEx_DrawItem(object sender, DrawItemEventArgs e)
	{
		if (e.Index < 0)
		{
			return;
		}
		if ((e.State & DrawItemState.Focus) == DrawItemState.Focus || (e.State & DrawItemState.Selected) == DrawItemState.Selected || (e.State & DrawItemState.HotLight) == DrawItemState.HotLight)
		{
			e.DrawBackground();
		}
		else
		{
			object obj = NewLateBinding.LateGet(sender, null, "backcolor", new object[0], null, null, null);
			using Brush brush = new SolidBrush((obj != null) ? ((Color)obj) : default(Color));
			e.Graphics.FillRectangle(brush, e.Bounds);
		}
		e.Graphics.DrawString(NewLateBinding.LateGet(sender, null, "Items", new object[1] { e.Index }, null, null, null).ToString(), (Font)NewLateBinding.LateGet(sender, null, "Font", new object[0], null, null, null), Brushes.Black, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
		if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
		{
			e.DrawFocusRectangle();
		}
		if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
		{
			Brush brush2 = new SolidBrush(Color.FromArgb(255, 246, 0));
			Rectangle bounds = e.Bounds;
			e.Graphics.FillRectangle(brush2, bounds);
			Brush brush3 = new SolidBrush(Color.Blue);
			Font font = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
			Graphics graphics = e.Graphics;
			object[] array = new object[1];
			object obj2 = sender;
			object instance = obj2;
			object[] array2 = new object[1];
			object obj3 = (array2[0] = e.Index);
			array[0] = NewLateBinding.LateGet(instance, null, "Items", array2, null, null, null);
			object[] array3 = array;
			bool[] obj4 = new bool[1] { true };
			bool[] array4 = obj4;
			object obj5 = NewLateBinding.LateGet(sender, null, "GetItemText", array, null, null, obj4);
			if (array4[0])
			{
				NewLateBinding.LateSetComplex(obj2, null, "Items", new object[2]
				{
					obj3,
					array3[0]
				}, null, null, OptimisticSet: true, RValueBase: false);
			}
			graphics.DrawString(Conversions.ToString(obj5), font, brush3, bounds);
			return;
		}
		using SolidBrush brush4 = new SolidBrush(e.ForeColor);
		Graphics graphics2 = e.Graphics;
		object[] array5 = new object[1];
		object obj3 = sender;
		object instance2 = obj3;
		object[] array6 = new object[1];
		object obj2 = (array6[0] = e.Index);
		array5[0] = NewLateBinding.LateGet(instance2, null, "Items", array6, null, null, null);
		object[] array3 = array5;
		bool[] obj6 = new bool[1] { true };
		bool[] array4 = obj6;
		object obj5 = NewLateBinding.LateGet(sender, null, "GetItemText", array5, null, null, obj6);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(obj3, null, "Items", new object[2]
			{
				obj2,
				array3[0]
			}, null, null, OptimisticSet: true, RValueBase: false);
		}
		graphics2.DrawString(Conversions.ToString(obj5), e.Font, brush4, e.Bounds);
	}

	~ComboBoxEx()
	{
		base.Finalize();
	}
}
