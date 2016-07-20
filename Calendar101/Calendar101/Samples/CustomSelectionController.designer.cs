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
	[Register ("CustomSelectionController")]
	partial class CustomSelectionController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.Calendar.XuniCalendar calendar { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (calendar != null) {
				calendar.Dispose ();
				calendar = null;
			}
		}
	}
}
