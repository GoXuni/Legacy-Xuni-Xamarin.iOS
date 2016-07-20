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
	[Register ("FilterSampleViewController")]
	partial class FilterSampleViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem filterOrEditAction { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexGrid.FlexGrid flexGrid { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem removeFilterAction { get; set; }

		[Action ("doFilterOrEdit:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void doFilterOrEdit (UIBarButtonItem sender);

		[Action ("doRemoveFilter:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void doRemoveFilter (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (filterOrEditAction != null) {
				filterOrEditAction.Dispose ();
				filterOrEditAction = null;
			}
			if (flexGrid != null) {
				flexGrid.Dispose ();
				flexGrid = null;
			}
			if (removeFilterAction != null) {
				removeFilterAction.Dispose ();
				removeFilterAction = null;
			}
		}
	}
}
