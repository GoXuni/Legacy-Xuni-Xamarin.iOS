// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

using Xuni.iOS.Core;
using Xuni.iOS.ChartCore;
using Xuni.iOS.FlexChart;

namespace FlexChartSample
{
	public partial class DataLabelController : UIViewController
	{
		partial void modeChanged(UISegmentedControl sender)
		{
			switch (sender.SelectedSegment)
			{
				case 0:
					chart.DataLabel.Position = ChartDataLabelPosition.None;
					break;
				case 1:
					chart.DataLabel.Position = ChartDataLabelPosition.Left;
					break;
				case 2:
					chart.DataLabel.Position = ChartDataLabelPosition.Top;
					break;
				case 3:
					chart.DataLabel.Position = ChartDataLabelPosition.Right;
					break;
				case 4:
					chart.DataLabel.Position = ChartDataLabelPosition.Bottom;
					break;
				case 5:
					chart.DataLabel.Position = ChartDataLabelPosition.Center;
					break;
			}
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			chart.BindingX = "Name";
			chart.Series.Add(new Series(chart, "Expenses", "Total Expenses"));


			chart.ItemsSource = SalesData.GetSalesDataList();
			chart.ChartType = ChartType.Bar;
			chart.IsAnimated = false;
			chart.Tooltip.IsVisible = false;
			chart.AxisX.MajorGridVisible = true;
			chart.AxisY.LabelsVisible = false;
			chart.AxisY.MajorGridVisible = false;
			chart.AxisY.MinorGridVisible = false;
			chart.AxisY.MajorTickWidth = 0;
			chart.Palette = XuniPalettes.Organic;

			chart.DataLabel.Content = "{x} {y}";
			chart.DataLabel.DataLabelFormat = "F2";
			chart.DataLabel.Position = ChartDataLabelPosition.Left;
			chart.DataLabel.DataLabelFontColor = UIColor.Red;
			chart.DataLabel.DataLabelBackgroundColor = UIColor.White;
			chart.DataLabel.DataLabelBorderColor = UIColor.Blue;
			chart.DataLabel.DataLabelBorderWidth = 1;
			chart.DataLabel.DataLabelFont = UIFont.SystemFontOfSize(15);


			modeSelector.SelectedSegment = 1;

		}

		public DataLabelController(IntPtr handle) : base(handle)
		{

		}
	}
}