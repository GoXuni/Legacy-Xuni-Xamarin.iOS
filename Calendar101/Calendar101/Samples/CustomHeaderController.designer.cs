// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CalendarSample
{
	[Register ("CustomHeaderController")]
	partial class CustomHeaderController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.Calendar.XuniCalendar calendar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel dateLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl modeSelector { get; set; }

		[Action ("selectMode:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void selectMode (UISegmentedControl sender);

		[Action ("selectToday:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void selectToday (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (calendar != null) {
				calendar.Dispose ();
				calendar = null;
			}
			if (dateLabel != null) {
				dateLabel.Dispose ();
				dateLabel = null;
			}
			if (modeSelector != null) {
				modeSelector.Dispose ();
				modeSelector = null;
			}
		}
	}
}
