using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
	partial class StarSizingSampleViewController : UIViewController
	{
		public StarSizingSampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.AutoGenerateColumns = false;
			this.flexGrid.AllowResizing = false;

			GridColumn[] columns = new[] {new GridColumn {
					Binding = "FirstName",
					Header = "First Name",
					Width = 3,
					WidthType = GridColumnWidth.Star
				},  new GridColumn {
					Binding = "LastName",
					Header = "Last Name",
					Width = 3,
					WidthType = GridColumnWidth.Star
				},  new GridColumn {
					Binding = "LastOrderDate",
					Header = "Last Order",
					Width = 2,
					WidthType = GridColumnWidth.Star
				},  new GridColumn {
					Binding = "OrderTotal",
					Header = "Total",
					Width = 2,
					WidthType = GridColumnWidth.Star
				}
			};

			Array.ForEach (columns, (c) => this.flexGrid.Columns.Add (c));


			this.flexGrid.ItemsSource = Customer.GetCustomerList (100);
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			this.flexGrid.IsReadOnly = true;
		}
	}
}
