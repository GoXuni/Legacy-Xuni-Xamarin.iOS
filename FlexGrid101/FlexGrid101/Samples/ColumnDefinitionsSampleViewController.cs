using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
	partial class ColumnDefinitionsSampleViewController : UIViewController
	{
		public ColumnDefinitionsSampleViewController (IntPtr handle) : base (handle)
		{
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.AutoGenerateColumns = false;
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);

			GridColumn[] columns = new[] { 
				new GridColumn {
					Binding = "Active",
					Width = 70,
					WidthType = GridColumnWidth.Pixel
				},  new GridColumn {
					Binding = "Id",
					Header = "ID",
					Width = 100,
					WidthType = GridColumnWidth.Pixel
				}, 
				new GridColumn { Binding = "FirstName" }, 
				new GridColumn { Binding = "LastName" },
				new GridColumn { Binding = "OrderTotal", Format = "C2" },
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
			this.flexGrid.IsReadOnly = false;
			this.flexGrid.ItemsSource = Customer.GetCustomerList (100);
		}
	}
}
