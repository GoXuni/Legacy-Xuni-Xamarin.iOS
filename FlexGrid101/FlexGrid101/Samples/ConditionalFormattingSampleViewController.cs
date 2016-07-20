using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;
using System.Collections.Generic;

namespace FlexGridSample
{
	partial class ConditionalFormattingSampleViewController : UIViewController
	{
		public ConditionalFormattingSampleViewController (IntPtr handle) : base (handle)
		{
		}

		private static UIColor DarkGreen = new UIColor(0.15f, 0.31f, 0.07f,1.0f);

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			this.flexGrid.AutoGenerateColumns = false;
			this.flexGrid.IsReadOnly = true;

			GridColumn[] columns = new[] { 
				new GridColumn { Binding = "FirstName" }, 
				new GridColumn { Binding = "LastName" },
				new GridColumn { Binding = "OrderTotal", Format = "C" },
				new GridColumn { Binding = "OrderCount", Format = "N1" },
				new GridColumn { 
					Binding = "CountryId",
					Header = "Country",
					HeaderHorizontalAlignment = UITextAlignment.Left,
					HorizontalAlignment = UITextAlignment.Left,
					DataMap = new GridDataMap (
						Array.ConvertAll (Customer._countries, (pair) => new CountryPair {
							CountryId = Array.IndexOf (Customer._countries, pair),
							CountryTitle = pair.Key
						}), new NSString ("CountryId"), new NSString ("CountryTitle"))
				}, 
				new GridColumn { Binding = "LastOrderDate" }, 
				new GridColumn { 
					Binding = "LastOrderDate",
					Header = "Last Order Time",
					Formatter = new NSDateFormatter { DateFormat = "hh:mm a" }
				}
			};

			this.flexGrid.Columns.AddRange (columns);

			List<Customer> dataList = Customer.GetCustomerList(100);


			this.flexGrid.FormatItem += (Xuni.iOS.FlexGrid.FlexGrid sender, Xuni.iOS.FlexGrid.GridPanel panel, Xuni.iOS.FlexGrid.GridCellRange range, CoreGraphics.CGContext context) => {
				if (panel.CellType == Xuni.iOS.FlexGrid.GridCellType.Cell)
				{
					GridColumn col = sender.Columns[range.Col];
					if(col.Binding.Equals("OrderTotal"))
					{
						double money = dataList[range.Row].OrderTotal;
						if(money > 5000)
						{
							panel.TextAttributes.SetValueForKey(DarkGreen, UIStringAttributeKey.ForegroundColor);
						}
						else
						{
							panel.TextAttributes.SetValueForKey(UIColor.Red, UIStringAttributeKey.ForegroundColor);
						}

					}
					else if (col.Binding.Equals("OrderCount"))
					{
						int orders = dataList[range.Row].OrderCount;
						if(orders > 50)
						{
							context.SetFillColor(DarkGreen.CGColor);
						}
						else
						{
							context.SetFillColor(UIColor.Red.CGColor);
						}
						context.FillRect(panel.GetCellRect(range.Row, range.Col));
						panel.TextAttributes.SetValueForKey(UIColor.White, UIStringAttributeKey.ForegroundColor);
					}
				}
				return false;
			};

			this.flexGrid.ItemsSource = dataList;
		}
	}
}
