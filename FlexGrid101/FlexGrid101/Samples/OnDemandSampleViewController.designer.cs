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
	[Register ("OnDemandSampleViewController")]
	partial class OnDemandSampleViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexGrid.FlexGrid flexGrid { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField searchText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl sortModeSelector { get; set; }

		[Action ("doSearch:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void doSearch (UITextField sender);

		[Action ("sortModeChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void sortModeChanged (UISegmentedControl sender);

		void ReleaseDesignerOutlets ()
		{
			if (flexGrid != null) {
				flexGrid.Dispose ();
				flexGrid = null;
			}
			if (searchText != null) {
				searchText.Dispose ();
				searchText = null;
			}
			if (sortModeSelector != null) {
				sortModeSelector.Dispose ();
				sortModeSelector = null;
			}
		}
	}
}
