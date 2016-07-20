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

namespace FlexChartSample
{
	[Register ("LineMarkerController")]
	partial class LineMarkerController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexChart.FlexChart chart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl modeSelect { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider positionSelect { get; set; }

		[Action ("modeSelected:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void modeSelected (UISegmentedControl sender);

		[Action ("positionChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void positionChanged (UISlider sender);

		void ReleaseDesignerOutlets ()
		{
			if (chart != null) {
				chart.Dispose ();
				chart = null;
			}
			if (modeSelect != null) {
				modeSelect.Dispose ();
				modeSelect = null;
			}
			if (positionSelect != null) {
				positionSelect.Dispose ();
				positionSelect = null;
			}
		}
	}
}
