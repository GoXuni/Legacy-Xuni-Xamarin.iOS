using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
	partial class FreezingSampleViewController : UIViewController
	{
		public FreezingSampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.flexGrid.IsReadOnly = true;
			this.flexGrid.FrozenRows = 1;
			this.flexGrid.FrozenColumns = 1;
			this.flexGrid.AllowMerging = Xuni.iOS.FlexGrid.GridAllowMerging.Cells;
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);

			this.flexGrid.AutoGeneratingColumn += (FlexGrid sender, Xuni.iOS.Core.XuniPropertyInfo propertyInfo, GridColumn column) => {
				if(propertyInfo.Name.Equals("Country"))
					column.AllowMerging = true;
				return false;
			};

			this.flexGrid.ItemsSource = Customer.GetCustomerList(100);

			this.flexGrid.AutoSizeColumns ();
		}
	}
}
