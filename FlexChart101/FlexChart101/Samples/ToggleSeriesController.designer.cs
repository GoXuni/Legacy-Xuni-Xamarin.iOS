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
	[Register ("ToggleSeriesController")]
	partial class ToggleSeriesController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexChart.FlexChart chart { get; set; }

		[Action ("switchChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void switchChanged (UISwitch sender);

		void ReleaseDesignerOutlets ()
		{
			if (chart != null) {
				chart.Dispose ();
				chart = null;
			}
		}
	}
}
