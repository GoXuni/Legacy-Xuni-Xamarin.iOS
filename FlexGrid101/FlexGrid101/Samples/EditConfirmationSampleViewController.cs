using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
	partial class EditConfirmationSampleViewController : UIViewController
	{
		public EditConfirmationSampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			this.flexGrid.IsReadOnly = false;
			this.flexGrid.AutoGenerateColumns = false;

			GridColumn[] columns = new[] {
				new GridColumn { Binding = "FirstName" },
				new GridColumn { Binding = "LastName" },
				new GridColumn { Binding = "Address" },
				new GridColumn { Binding = "City" },
				new GridColumn { Binding = "PostalCode" },
				new GridColumn {
					Binding = "Active",
					Width = 70,
					WidthType = GridColumnWidth.Pixel
				}
			};

			Array.ForEach (columns, (c) => this.flexGrid.Columns.Add (c));

			object valueBeingEdited = null;

			this.flexGrid.BeginningEdit += (FlexGrid sender, GridPanel panel, GridCellRange range) => {
				valueBeingEdited = panel.GetCellData(range.Row, range.Col, false);
				return false;
			};

			this.flexGrid.CellEditEnded += (object sender, CellEditEndedEventArgs e) => {
				var editResult = e.Panel.GetCellData(e.Range.Row, e.Range.Col, false);

				if(editResult.Equals(valueBeingEdited)) return;
				else
				{
					UIAlertController alert = UIAlertController.Create("Edit Confirmation", "Do you want to commit the edit?", UIAlertControllerStyle.Alert);
					alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (UIAlertAction obj) => {}));
					alert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, (UIAlertAction obj) => {e.Panel[e.Range.Row, e.Range.Col] = valueBeingEdited;}));
					this.PresentViewController(alert, true, null);
				}
			};

			this.flexGrid.ItemsSource = Customer.GetCustomerList(100);
		}
	}
}
