using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FlexGridSample
{
	partial class ColumnLayoutSampleViewController : UIViewController
	{
		public ColumnLayoutSampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.IsReadOnly = true;
			this.flexGrid.ItemsSource = Customer.GetCustomerList(100);
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			this.flexGrid.AutoSizeColumns ();
		}

		partial void doEditColumns (UIBarButtonItem sender)
		{
			UIStoryboard storyboard = UIStoryboard.FromName ("MainStoryboard", null);
			ColumnLayoutEditorTableViewController controller = (ColumnLayoutEditorTableViewController)storyboard.InstantiateViewController ("ColumnLayoutEditor");
			controller.FlexGrid = this.flexGrid;

			this.NavigationController.PushViewController (controller, true);
		}
	}
}
