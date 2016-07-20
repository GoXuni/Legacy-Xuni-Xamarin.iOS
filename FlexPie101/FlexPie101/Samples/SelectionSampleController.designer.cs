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
	[Register ("SelectionSampleController")]
	partial class SelectionSampleController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexPie.FlexPie flexPie { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch isAnimatedSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel offsetLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl positionSelector { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIStepper stepper { get; set; }

		[Action ("positionChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void positionChanged (UISegmentedControl sender);

		[Action ("stepperClicked:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void stepperClicked (UIStepper sender);

		[Action ("switchAnimation:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void switchAnimation (UISwitch sender);

		void ReleaseDesignerOutlets ()
		{
			if (flexPie != null) {
				flexPie.Dispose ();
				flexPie = null;
			}
			if (isAnimatedSwitch != null) {
				isAnimatedSwitch.Dispose ();
				isAnimatedSwitch = null;
			}
			if (offsetLabel != null) {
				offsetLabel.Dispose ();
				offsetLabel = null;
			}
			if (positionSelector != null) {
				positionSelector.Dispose ();
				positionSelector = null;
			}
			if (stepper != null) {
				stepper.Dispose ();
				stepper = null;
			}
		}
	}
}
