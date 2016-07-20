// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using Xuni.iOS.FlexChart;
using Xuni.iOS.ChartCore;

namespace FlexChartSample
{
	public partial class BubbleChartController : UIViewController
	{
		public BubbleChartController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			chart.BindingX = "Name";

			chart.Series.Add(new Series(chart, "Sales, Downloads", "Sales"));
			chart.Series.Add(new Series(chart, "Expenses, Downloads", "Expenses"));

			chart.ChartType = ChartType.Bubble;
			chart.LoadAnimation.AnimationMode = AnimationMode.Series;

			chart.ItemsSource = SalesData.GetSalesDataList();
		}
	}
}