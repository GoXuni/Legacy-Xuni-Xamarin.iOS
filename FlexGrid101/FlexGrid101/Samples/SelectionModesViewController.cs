using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FlexGridSample
{
	partial class SelectionModesViewController : UIViewController
	{
		public SelectionModesViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.ItemsSource = Customer.GetCustomerList(100);

			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			this.flexGrid.SelectionChanged += (object sender, Xuni.iOS.FlexGrid.SelectionChangedEventArgs e) => 
			{
				this.selectionCount.Title = "Selected: "+(this.flexGrid.Selection.ColumnSpan * this.flexGrid.Selection.RowSpan);
			};
		}

		partial void modeSelected (UISegmentedControl sender)
		{
			this.flexGrid.SelectionMode = (Xuni.iOS.FlexGrid.GridSelectionMode)((int)sender.SelectedSegment);
		}
	}
}
