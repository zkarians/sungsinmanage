using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using mlas_root.My;

namespace mlas_root;

[StandardModule]
internal sealed class CustomMsgBox
{
	public static custom_msgbox.CmsgBoxIcon CMsgBox_icon;

	public static custom_msgbox CMsgBox(string title, string caption, string buttontext, custom_msgbox.CMsgboxColor buttonColor, custom_msgbox.CmsgBoxIcon icon, custom_msgbox.ShowLocation Location = custom_msgbox.ShowLocation.MiddleCenter, bool autoClose = false, int autoInterval = 2000)
	{
		return CMsgBox(MyProject.Forms.mlas, title, caption, buttontext, buttonColor, icon, Location, autoClose, autoInterval);
	}

	public static custom_msgbox CMsgBox(GetHtmlClass HtmlClass)
	{
		custom_msgbox obj = new custom_msgbox();
		Form context = HtmlClass.context;
		custom_msgbox custom_msgbox2 = obj;
		custom_msgbox2.HtmlClass = HtmlClass;
		if (context != null)
		{
			custom_msgbox2.Location = checked(new Point((int)Math.Round((double)context.PointToScreen(Point.Empty).X + ((double)context.Width / 2.0 - (double)custom_msgbox2.Width / 2.0)), (int)Math.Round((double)context.PointToScreen(Point.Empty).Y + ((double)context.Height / 2.0 - (double)custom_msgbox2.Height / 2.0))));
			custom_msgbox2.ShowDialog();
		}
		custom_msgbox2 = null;
		return obj;
	}

	public static custom_msgbox CMsgBox(Form context, string title, string caption, string buttontext, custom_msgbox.CMsgboxColor buttonColor, custom_msgbox.CmsgBoxIcon icon, custom_msgbox.ShowLocation Location = custom_msgbox.ShowLocation.MiddleCenter, bool autoClose = false, int autoInterval = 2000)
	{
		if (!Module1.CMsgboxOption && icon != custom_msgbox.CmsgBoxIcon.icon_Error && icon != custom_msgbox.CmsgBoxIcon.icon_Exclamation && icon != custom_msgbox.CmsgBoxIcon.icon_Marquee)
		{
			return null;
		}
		if (((CMsgBox_icon != custom_msgbox.CmsgBoxIcon.icon_None) & (CMsgBox_icon != custom_msgbox.CmsgBoxIcon.icon_Marquee)) && icon == custom_msgbox.CmsgBoxIcon.icon_Marquee)
		{
			return null;
		}
		custom_msgbox custom_msgbox2 = new custom_msgbox();
		custom_msgbox custom_msgbox3 = custom_msgbox2;
		custom_msgbox3.title = caption;
		custom_msgbox3.message = title;
		custom_msgbox3.autoClose = autoClose;
		custom_msgbox3.closetime = autoInterval;
		custom_msgbox3.buttonText = buttontext;
		custom_msgbox3.buttonColor = (int)buttonColor;
		custom_msgbox3.iconType = icon;
		CMsgBox_icon = icon;
		checked
		{
			switch (Location)
			{
			case custom_msgbox.ShowLocation.TopLeft:
				custom_msgbox3.Location = new Point(context.PointToScreen(Point.Empty).X, context.PointToScreen(Point.Empty).Y + 30);
				break;
			case custom_msgbox.ShowLocation.TopCenter:
				custom_msgbox3.Location = new Point((int)Math.Round((double)context.PointToScreen(Point.Empty).X + ((double)context.Width / 2.0 - (double)custom_msgbox3.Width / 2.0)), context.PointToScreen(Point.Empty).Y + 30);
				break;
			case custom_msgbox.ShowLocation.TopRight:
				custom_msgbox3.Location = new Point(context.PointToScreen(Point.Empty).X + (context.Width - custom_msgbox3.Width), context.PointToScreen(Point.Empty).Y + 30);
				break;
			case custom_msgbox.ShowLocation.MiddleLeft:
				custom_msgbox3.Location = new Point(context.PointToScreen(Point.Empty).X, (int)Math.Round((double)context.PointToScreen(Point.Empty).Y + ((double)context.Height / 2.0 - (double)custom_msgbox3.Height / 2.0)));
				break;
			case custom_msgbox.ShowLocation.MiddleCenter:
				custom_msgbox3.Location = new Point((int)Math.Round((double)context.PointToScreen(Point.Empty).X + ((double)context.Width / 2.0 - (double)custom_msgbox3.Width / 2.0)), (int)Math.Round((double)context.PointToScreen(Point.Empty).Y + ((double)context.Height / 2.0 - (double)custom_msgbox3.Height / 2.0)));
				break;
			case custom_msgbox.ShowLocation.MiddleRight:
				custom_msgbox3.Location = new Point(context.PointToScreen(Point.Empty).X + (context.Width - custom_msgbox3.Width), (int)Math.Round((double)context.PointToScreen(Point.Empty).Y + ((double)context.Height / 2.0 - (double)custom_msgbox3.Height / 2.0)));
				break;
			case custom_msgbox.ShowLocation.BottomLeft:
				custom_msgbox3.Location = new Point(context.PointToScreen(Point.Empty).X, context.PointToScreen(Point.Empty).Y + (context.Height - custom_msgbox3.Height));
				break;
			case custom_msgbox.ShowLocation.BottomCenter:
				custom_msgbox3.Location = new Point((int)Math.Round((double)context.PointToScreen(Point.Empty).X + ((double)context.Width / 2.0 - (double)custom_msgbox3.Width / 2.0)), context.PointToScreen(Point.Empty).Y + (context.Height - custom_msgbox3.Height));
				break;
			case custom_msgbox.ShowLocation.BottomRight:
				custom_msgbox3.Location = new Point(context.PointToScreen(Point.Empty).X + (context.Width - custom_msgbox3.Width) - 15, context.PointToScreen(Point.Empty).Y + (context.Height - custom_msgbox3.Height) - 38);
				break;
			}
			switch (icon)
			{
			case custom_msgbox.CmsgBoxIcon.icon_Error:
				custom_msgbox3.ShowDialog();
				break;
			case custom_msgbox.CmsgBoxIcon.icon_Exclamation:
				custom_msgbox3.Show();
				break;
			case custom_msgbox.CmsgBoxIcon.icon_Information:
				custom_msgbox3.Show();
				break;
			case custom_msgbox.CmsgBoxIcon.icon_Marquee:
				custom_msgbox3.Show();
				break;
			case custom_msgbox.CmsgBoxIcon.icon_None:
				custom_msgbox3.Show();
				break;
			}
			custom_msgbox3 = null;
			return custom_msgbox2;
		}
	}
}
