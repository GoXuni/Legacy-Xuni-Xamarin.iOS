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
	[Register ("FilterSampleEditorViewController")]
	partial class FilterSampleEditorViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexGrid.FlexGrid flexGrid { get; set; }

		[Action ("editingFinishedOK:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void editingFinishedOK (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (flexGrid != null) {
				flexGrid.Dispose ();
				flexGrid = null;
			}
		}
	}
}
