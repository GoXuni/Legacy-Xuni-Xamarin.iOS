using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
	partial class ColumnLayoutEditorTableViewController : UITableViewController
	{
		public ColumnLayoutEditorTableViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.Editing = true;
		}

		public FlexGrid FlexGrid = null;

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return (nint)FlexGrid.Columns.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell ("Cell");
			cell.TextLabel.Text = FlexGrid.Columns[indexPath.Row].Header;
			return cell;
		}

		public override bool CanMoveRow (UITableView tableView, NSIndexPath indexPath)
		{
			return true;
		}

		public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
		{
			if (editingStyle == UITableViewCellEditingStyle.Delete) {
				FlexGrid.Columns.RemoveAt (indexPath.Row);
				this.TableView.DeleteRows (new NSIndexPath[]{ indexPath }, UITableViewRowAnimation.Automatic);
			}
		}

		public override void MoveRow (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
		{
			GridColumn column = FlexGrid.Columns[sourceIndexPath.Row];
			FlexGrid.Columns.RemoveAt (sourceIndexPath.Row);
			FlexGrid.Columns.Insert (destinationIndexPath.Row,column);
		}
	}
}
