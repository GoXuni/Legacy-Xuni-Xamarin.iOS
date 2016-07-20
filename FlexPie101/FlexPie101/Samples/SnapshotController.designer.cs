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

namespace FlexPieSample
{
	[Register ("SnapshotController")]
	partial class SnapshotController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexPie.FlexPie flexPie { get; set; }

		[Action ("doTakeSnapshot:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void doTakeSnapshot (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (flexPie != null) {
				flexPie.Dispose ();
				flexPie = null;
			}
		}
	}
}
