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

namespace FlexGridSample
{
	[Register ("RowDetailsViewController")]
	partial class RowDetailsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexGrid.FlexGrid flexGrid { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl modeSelect { get; set; }

		[Action ("modeSelected:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void modeSelected (UISegmentedControl sender);

		void ReleaseDesignerOutlets ()
		{
			if (flexGrid != null) {
				flexGrid.Dispose ();
				flexGrid = null;
			}
			if (modeSelect != null) {
				modeSelect.Dispose ();
				modeSelect = null;
			}
		}
	}
}
