// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using CoreGraphics;

using Xuni.iOS.Core;
using Xuni.iOS.ChartCore;
using Xuni.iOS.FlexChart;

namespace FlexChartSample
{
	public partial class LineMarkerController : UIViewController
	{
		public LineMarkerController (IntPtr handle) : base (handle)
		{
		}

		partial void modeSelected(UISegmentedControl sender)
		{
			chart.LineMarker.Interaction = (XuniChartMarkerInteraction)(int)sender.SelectedSegment;
		}

		partial void positionChanged(UISlider sender)
		{
			double pos = sender.Value;
			if (pos == 0) pos = double.NaN;
			chart.LineMarker.VerticalPosition = pos;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			chart.BindingX = "Name";
			chart.Series.Add(new Series(chart, "Sales, Sales", "Sales"));
			chart.Series.Add(new Series(chart, "Expenses, Expenses", "Expenses"));
			chart.Series.Add(new Series(chart, "Downloads, Downloads", "Downloads"));
			chart.ItemsSource = SalesData.GetSalesDataList();

			chart.ChartType = ChartType.Line;

			MyMarkerView view = new MyMarkerView(chart.LineMarker);
			view.MarkerRender = new MyMarkerRender(view);
			chart.LineMarker.Content = view;
			chart.LineMarker.IsVisible = true;
			chart.LineMarker.Alignment = XuniChartMarkerAlignment.BottomRight;
			chart.LineMarker.Lines = XuniChartMarkerLines.Vertical;
			chart.LineMarker.Interaction = XuniChartMarkerInteraction.Move;
			chart.LineMarker.DragContent = true;
			chart.LineMarker.SeriesIndex = -1;
			chart.LineMarker.VerticalLineColor = UIColor.Gray;
			chart.LineMarker.VerticalPosition = 0;

			chart.AddSubview(view);

		}

		class MyMarkerView : XuniChartMarkerBaseView
		{
			public XuniChartLineMarker Marker;
			public UILabel Content;

			public MyMarkerView(XuniChartLineMarker marker):base(marker)
			{
				Marker = marker;

				BackgroundColor = UIColor.FromWhiteAlpha(0.8f, 0.6f);
				Frame = new CGRect(0, 0, 110, 60);

				Content = new UILabel();
				Content.Frame = new CGRect(5, 5, 100, 50);
				Content.BackgroundColor = UIColor.Clear;
				Content.Font = UIFont.SystemFontOfSize(10);

				AddSubview(Content);
			}
		}

		class MyMarkerRender : IXuniChartMarkerRender
		{
			XuniChartMarkerBaseView _view;

			public MyMarkerRender(XuniChartMarkerBaseView view)
			{
				_view = view;
			}

			public override void RenderMarker()
			{
				if (_view != null)
				{
					MyMarkerView view = (MyMarkerView)_view;
					var dataPoints = view.Marker.DataPoints;

					if (dataPoints != null && dataPoints.Length > 0)
					{
						string str = "";
						str += dataPoints[0].ValueX + " \n";

						for (int i = 0; i < dataPoints.Length-1; i++)
						{
							str += string.Format("{0} {1:C0}",dataPoints[i].SeriesName, dataPoints[i].Value);
						}

						str += string.Format("{0} {1:C0}", dataPoints[dataPoints.Length-1].SeriesName, dataPoints[dataPoints.Length - 1].Value);

						view.Content.Text = str;
						view.Content.Lines = 4;
					}
				}
			}
		}
	}
}