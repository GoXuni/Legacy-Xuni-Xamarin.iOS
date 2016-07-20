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
	[Register ("DataLabelController")]
	partial class DataLabelController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexChart.FlexChart chart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl modeSelector { get; set; }

		[Action ("modeChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void modeChanged (UISegmentedControl sender);

		void ReleaseDesignerOutlets ()
		{
			if (chart != null) {
				chart.Dispose ();
				chart = null;
			}
			if (modeSelector != null) {
				modeSelector.Dispose ();
				modeSelector = null;
			}
		}
	}
}
