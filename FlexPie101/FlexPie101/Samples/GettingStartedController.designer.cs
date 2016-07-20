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
	[Register ("GettingStartedController")]
	partial class GettingStartedController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexPie.FlexPie donutChart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexPie.FlexPie pieChart { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (donutChart != null) {
				donutChart.Dispose ();
				donutChart = null;
			}
			if (pieChart != null) {
				pieChart.Dispose ();
				pieChart = null;
			}
		}
	}
}
