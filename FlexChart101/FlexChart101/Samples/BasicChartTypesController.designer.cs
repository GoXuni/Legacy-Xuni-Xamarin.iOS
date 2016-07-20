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
	[Register ("BasicChartTypesController")]
	partial class BasicChartTypesController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexChart.FlexChart chart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIPickerView picker { get; set; }

		[Action ("reverseSwitched:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void reverseSwitched (UISwitch sender);

		void ReleaseDesignerOutlets ()
		{
			if (chart != null) {
				chart.Dispose ();
				chart = null;
			}
			if (picker != null) {
				picker.Dispose ();
				picker = null;
			}
		}
	}
}
