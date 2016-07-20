using System;
using UIKit;
using Xuni.iOS.Input;
using Xuni.iOS.Calendar;
using CoreGraphics;
using Foundation;
using Xuni.iOS.Core;

namespace Input101
{
	public partial class DropDownController : UIViewController
	{
		public static XuniMaskedTextField maskedField;
		public XuniCalendar calendar;
		public static XuniDropDown d;

		public DropDownController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			DropDown.DropDownHeight = 300;
			DropDown.DropDownWidth = DropDown.Frame.Size.Width + 30;
			DropDown.DropDownDirection = XuniDropDownDirection.ForceBelow;
			DropDown.IsAnimated = true;
			d = DropDown;

			maskedField = new XuniMaskedTextField();
			maskedField.Mask = "00/00/0000";
			maskedField.BackgroundColor = UIColor.Clear;
			maskedField.BorderStyle = UITextBorderStyle.None;
			DropDown.Header = maskedField;

			calendar = new XuniCalendar ();
			calendar.Delegate = new Mydelegate();
			DropDown.DropDownView = calendar;

		}

		class Mydelegate :XuniCalendarDelegate{
			public override void SelectionChanged (XuniCalendar sender, CalendarRange selectedDates)
			{
				NSDateFormatter dateFormatter = new NSDateFormatter();
				dateFormatter.DateFormat = "dd/MM/yyyy";
				maskedField.Text = dateFormatter.ToString (sender.NativeSelectedDate);
				d.IsDropDownOpen = false;
			}
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


