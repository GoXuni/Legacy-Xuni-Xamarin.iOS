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
	[Register ("HitTestController")]
	partial class HitTestController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexChart.FlexChart chart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel chartElementLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel pointIndexLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel seriesLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel xyValuesLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (chart != null) {
				chart.Dispose ();
				chart = null;
			}
			if (chartElementLabel != null) {
				chartElementLabel.Dispose ();
				chartElementLabel = null;
			}
			if (pointIndexLabel != null) {
				pointIndexLabel.Dispose ();
				pointIndexLabel = null;
			}
			if (seriesLabel != null) {
				seriesLabel.Dispose ();
				seriesLabel = null;
			}
			if (xyValuesLabel != null) {
				xyValuesLabel.Dispose ();
				xyValuesLabel = null;
			}
		}
	}
}
