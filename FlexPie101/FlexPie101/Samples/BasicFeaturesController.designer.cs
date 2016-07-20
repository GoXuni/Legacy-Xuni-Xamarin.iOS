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
using Xuni.iOS.FlexPie;

namespace FlexPieSample
{
	[Register ("BasicFeaturesController")]
	partial class BasicFeaturesController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel innerRadiusLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider offsetSlider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexPie.FlexPie pieChart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch reversedSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider startAngleSlider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIStepper stepper { get; set; }

		[Action ("offsetChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void offsetChanged (UISlider sender);

		[Action ("startAngleChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void startAngleChanged (UISlider sender);

		[Action ("switchValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void switchValueChanged (UISwitch sender);

		[Action ("valueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void valueChanged (UIStepper sender);

		void ReleaseDesignerOutlets ()
		{
			if (innerRadiusLabel != null) {
				innerRadiusLabel.Dispose ();
				innerRadiusLabel = null;
			}
			if (offsetSlider != null) {
				offsetSlider.Dispose ();
				offsetSlider = null;
			}
			if (pieChart != null) {
				pieChart.Dispose ();
				pieChart = null;
			}
			if (reversedSwitch != null) {
				reversedSwitch.Dispose ();
				reversedSwitch = null;
			}
			if (startAngleSlider != null) {
				startAngleSlider.Dispose ();
				startAngleSlider = null;
			}
			if (stepper != null) {
				stepper.Dispose ();
				stepper = null;
			}
		}
	}
}
