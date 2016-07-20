using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;
using Xuni.iOS.Gauge;

namespace FlexGridSample
{
	partial class CustomCellsSampleViewController : UIViewController
	{
		public CustomCellsSampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.AutoGenerateColumns = false;
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			this.flexGrid.IsReadOnly = true;
			this.flexGrid.HeadersVisibility = GridHeadersVisibility.Column;

			GridColumn[] columns = new[] {new GridColumn {
					Binding = "FirstName",
					Header = "First Name",
					Width = 1,
					WidthType = GridColumnWidth.Star
				},  new GridColumn {
					Binding = "LastName",
					Header = "Last Name",
					Width = 1,
					WidthType = GridColumnWidth.Star
				},  new GridColumn {
					Binding = "OrderTotal",
					Header = "Total",
					Width = 1,
					WidthType = GridColumnWidth.Star,
					HeaderHorizontalAlignment = UITextAlignment.Center
				}
			};

			Array.ForEach (columns, (c) => this.flexGrid.Columns.Add (c));

			this.flexGrid.FormatItem += (FlexGrid sender, GridPanel panel, GridCellRange range, CoreGraphics.CGContext context) => {
				GridColumn c = sender.Columns[range.Col];
				if(c.Binding.Equals("OrderTotal") && panel.CellType == GridCellType.Cell)
				{
					XuniRadialGauge rgauge = new XuniRadialGauge()
					{
						BackgroundColor = UIColor.Clear,
						ShowText = ShowText.None,
						Thickness = 0.6,
						Min = 0,
						Max = 100,
						LoadAnimation = null,
						Value = double.Parse(panel.GetCellData(range.Row, range.Col, false).ToString())*(100.0/10000.0),
						ShowRanges = false
					};

					XuniGaugeRange[] ranges = new []
					{
						new XuniGaugeRange()
						{
							Min = 0,
							Max = 40,
							Color = new UIColor(0.133f, 0.694f, 0.298f, 1.0f)
						},
						new XuniGaugeRange()
						{
							Min = 40,
							Max = 80,
							Color = new UIColor(1.0f, 0.502f, 0.502f, 1.0f)
						},
						new XuniGaugeRange()
						{
							Min = 80,
							Max = 100,
							Color = new UIColor(0.0f, 0.635f, 0.91f, 1.0f)
						}
					};

					rgauge.Ranges.AddRange(ranges);

					CoreGraphics.CGRect rect = panel.GetCellRect(range.Row, range.Col);
					rgauge.Frame = rect;

					UIImage img = new UIImage(rgauge.GetImage());
					img.Draw(rect);

					return true;
				}
				return false;
			};


			this.flexGrid.ItemsSource = Customer.GetCustomerList (100);

		}
	}
}
