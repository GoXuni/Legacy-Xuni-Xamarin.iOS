using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
	partial class GroupingSampleViewController : UIViewController
	{
		partial void collapseButton_Click(UIBarButtonItem sender)
		{
			if (sender.Title.Equals("Collapse"))
			{
				sender.Title = "Expand";
				this.flexGrid.CollapseGroupsToLevel(0);
			}
			else
			{
				sender.Title = "Collapse";
				foreach (var g in this.flexGrid.Rows)
				{
					if (g is GridGroupRow)
					{
						(g as GridGroupRow).IsCollapsed = false;
					}
				}
			}
		}

		public GroupingSampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			this.flexGrid.AutoGenerateColumns = false;
			this.flexGrid.IsReadOnly = true;

			GridColumn[] columns = new[] { 
				new GridColumn { Binding = "Active", WidthType = GridColumnWidth.Star, Width = 2},
				new GridColumn { Binding = "FirstName", Header = "Name", WidthType = GridColumnWidth.Star, Width = 4},
				new GridColumn { Binding = "OrderTotal", Format = "C", Aggregate = Xuni.iOS.Core.XuniAggregate.Sum, WidthType = GridColumnWidth.Star, Width = 4}
			};

			this.flexGrid.Columns.AddRange (columns);

			this.flexGrid.ItemsSource = Customer.GetCustomerList(100);
			this.flexGrid.CollectionView.GroupDescriptions.Add (new Xuni.iOS.Core.XuniPropertyGroupDescription("Country"));
		}

		partial void SortButton_Activated (UIBarButtonItem sender)
		{
			this.flexGrid.CollectionView.SortDescriptions.RemoveAll();
			if(sender.Title.Equals("Z-A"))
			{
				sender.Title = "A-Z";
				this.flexGrid.CollectionView.SortDescriptions.Add(new Xuni.iOS.Core.XuniSortDescription("Country", false));
			}
			else
			{
				sender.Title = "Z-A";
				this.flexGrid.CollectionView.SortDescriptions.Add(new Xuni.iOS.Core.XuniSortDescription("Country", true));
			}
			this.collapseButton.Title = "Collapse";
		}
	}
}
