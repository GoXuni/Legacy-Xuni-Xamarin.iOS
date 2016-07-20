using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;
using Xuni.iOS.Core;

namespace FlexGridSample
{
	partial class GettingStartedSampleViewController : UIViewController
	{
		public GettingStartedSampleViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.ItemsSource = Customer.GetCustomerList(100);
			this.flexGrid.IsReadOnly = false;
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
		}
	}
}
