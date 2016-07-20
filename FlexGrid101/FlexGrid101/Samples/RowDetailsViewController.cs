using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
	partial class RowDetailsViewController : UIViewController
	{
		public RowDetailsViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.flexGrid.AutoGenerateColumns = false;
			this.flexGrid.IsReadOnly = true;

			GridColumn id = new GridColumn {
				Binding = "Id",
				Header = "ID",
				Width = 1,
				WidthType = GridColumnWidth.Star
			}, first = new GridColumn {
				Binding = "FirstName",
				Header = "First Name",
				Width = 2,
				WidthType = GridColumnWidth.Star
			}, second = new GridColumn {
				Binding = "LastName",
				Header = "Last Name",
				Width = 2,
				WidthType = GridColumnWidth.Star
			};

			this.flexGrid.Columns.Add (id);
			this.flexGrid.Columns.Add (first);
			this.flexGrid.Columns.Add (second);

			this.flexGrid.ItemsSource = Customer.GetCustomerList(100);

			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			this.flexGrid.DetailProvider.DetailVisibilityMode = Xuni.iOS.FlexGrid.GridDetailVisibilityMode.ExpandSingle;


			this.flexGrid.DetailProvider.DetailCellCreating += (Xuni.iOS.FlexGrid.FlexGridDetailProvider sender, Xuni.iOS.FlexGrid.GridRow row) => {
				MapKit.MKMapView mapView = new MapKit.MKMapView();
				mapView.UserInteractionEnabled = false;

				CoreLocation.CLGeocoder geocoder = new CoreLocation.CLGeocoder();


				geocoder.GeocodeAddress(((Customer)row.DataItem).City, (CoreLocation.CLPlacemark[] placemarks, NSError error) => {
					CoreLocation.CLPlacemark placemark = placemarks[placemarks.Length-1];
					float spanX = 0.0725f;
					float spanY = 0.0725f;
					MapKit.MKCoordinateRegion region = new MapKit.MKCoordinateRegion();
					region.Center.Latitude = placemark.Location.Coordinate.Latitude;
					region.Center.Longitude = placemark.Location.Coordinate.Longitude;
					region.Span = new MapKit.MKCoordinateSpan(spanX, spanY);
					mapView.SetRegion(region, false);
				});

				return mapView;
			};


			this.flexGrid.DetailProvider.GridRowHeaderLoading += (Xuni.iOS.FlexGrid.FlexGridDetailProvider sender, Xuni.iOS.FlexGrid.GridRow row, UIButton DefaultButton) => {
				DefaultButton = new UIButton(UIButtonType.Custom);
				DefaultButton.SetImage(new UIImage("Images/show"), UIControlState.Normal);
				DefaultButton.SetImage(new UIImage("Images/hide"), UIControlState.Selected);
				return DefaultButton;
			};
		}

		partial void modeSelected (UISegmentedControl sender)
		{
			switch(sender.SelectedSegment)
			{
			case 0: flexGrid.DetailProvider.DetailVisibilityMode = GridDetailVisibilityMode.ExpandSingle; break;
			case 1: flexGrid.DetailProvider.DetailVisibilityMode = GridDetailVisibilityMode.ExpandMultiple; break;
			case 2: flexGrid.DetailProvider.DetailVisibilityMode = GridDetailVisibilityMode.Selection; break;	
			}
		}
	}
}
