using System;
using System.Drawing;
using Foundation;
using UIKit;
using Xuni.iOS.FlexGrid;
using CoreGraphics;
using Xuni.iOS.Core;

namespace FlexGridSample
{
	public partial class RootViewController : UIViewController, IFlexGridDelegate
    {
        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public RootViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

		public Column ColumnByBinding(FlexGrid grid, string binding)
		{
			for (nuint i = 0; i < grid.Columns.Count; i++) {

				Column col = grid.Columns.GetItem<Column> (i);

				if (col.Binding == binding) {
					return col;
				}
			}

			return null;
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            XuniLicenseManager.Key = License.Key;
            FlexGrid grid = new FlexGrid();
            grid.Tag = 1;
            grid.ItemsSource = Customer.GetCustomerList(50);

			grid.WeakDelegate = this;

			Column c1 = ColumnByBinding(grid, "Money");
            c1.Format = "c";
			Column c2 = ColumnByBinding(grid, "Hired");
            c2.Format = "MM/dd/yyyy";
            grid.HeadersVisibility = FlexHeadersVisibility.FlexHeadersVisibilityColumn;

            if (UserInterfaceIdiomIsPhone == false)
            {
                starSizingForEditing(grid);
            }

            View.AddSubview(grid);
        }
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            FlexGrid g = (FlexGrid)View.ViewWithTag(1);
            g.Frame = new CoreGraphics.CGRect(0, 44, View.Bounds.Width, View.Bounds.Height - 44);
        }
        private void starSizingForEditing(FlexGrid g)
        {
			for (nuint i = 0; i < g.Columns.Count; i++)
            {
                Column col = g.Columns.GetItem<Column>(i);
                col.WidthType = FlexColumnWidth.FlexColumnWidthStar;
                col.Width = (i == 1) ? 4 : (i == 0) ? 2 : 3;
            }
        }

        private void grid_FormatItem(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

		public bool PrepareCellForEdit(FlexGrid sender, GridPanel panel, CellRange range)
        {

            FlexGrid g = (FlexGrid)View.ViewWithTag(1);
            nuint i = (nuint)range.Col;
            Column col = g.Columns.GetItem<Column>(i);
            if (col.Binding == "Hired")
            {
                UITextField editor = (UITextField)g.ActiveEditor;
                UIDatePicker picker = new UIDatePicker();
				NSDate d = (NSDate)g.GetCellData(range.Row, range.Col, false);
                picker.Opaque = true;
                picker.Mode = UIDatePickerMode.Date;
                picker.Date = d;
                picker.ValueChanged += picker_ValueChanged;
                editor.InputView = picker;
                UIToolbar toolbar = new UIToolbar(new CoreGraphics.CGRect(0, 0, View.Bounds.Width, 44));
                toolbar.BarStyle = UIBarStyle.Default;
                picker.EditingDidEnd += picker_EditingDidEnd;

                UIBarButtonItem done = new UIBarButtonItem(UIBarButtonSystemItem.Done, picker_EditingDidEnd);
                UIBarButtonItem space = new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace, null, null);
                toolbar.SetItems(new UIBarButtonItem[2]{space, done} , false);
                editor.InputAccessoryView = toolbar;
                editor.ClearButtonMode = UITextFieldViewMode.Never;
            }

			return false;
        }

        void picker_EditingDidEnd(object sender, EventArgs e)
        {
            FlexGrid g = (FlexGrid)View.ViewWithTag(1);
            UITextField editor = (UITextField)g.ActiveEditor;
            UIDatePicker picker = (UIDatePicker)editor.InputView;
            g.Cells.SetCellData(picker.Date, g.EditRange.Row, g.EditRange.Col);
            g.FinishEditing(true);
        }

        private void picker_ValueChanged(object sender, EventArgs e)
        {
            FlexGrid g = (FlexGrid)View.ViewWithTag(1);
            UITextField editor = (UITextField)g.ActiveEditor;
            Column col = g.Columns.GetItem<Column>((nuint)g.EditRange.Col);
            NSDateFormatter df = new NSDateFormatter();
            df.DateFormat = "M/dd/yy";
            editor.Text = df.ToString(((UIDatePicker)(sender)).Date);
        }

		public bool FormatItem(FlexGrid sender,GridPanel panel, CellRange range, CGContext context)
        {
            FlexGrid g = (FlexGrid)View.ViewWithTag(1);
            nuint i = (nuint)range.Col;
            Column col = g.Columns.GetItem<Column>(i);
            if (col.Binding == "Money")
            {
                NSNumberFormatter f = new NSNumberFormatter();
                f.NumberStyle = NSNumberFormatterStyle.Currency;

				Console.WriteLine (g.GetCellData(range.Row, range.Col, true));

                NSNumber n;
                try
                {
					n = (NSNumber)g.GetCellData(range.Row, range.Col, false);
                }
                catch
                {
					n = f.NumberFromString(g.GetCellData(range.Row, range.Col, true).ToString());
                }
				CoreGraphics.CGRect r = panel.GetCellRect(range.Row, range.Col);
                if (n.Int32Value > 90)
                {
                    context.SetFillColor(UIColor.Green.CGColor);
                }
                else if (n.Int32Value < 60)
                {
                    context.SetFillColor(UIColor.Red.CGColor);
                }
                context.FillRect(r);
            }

			return false;
        }
        #endregion
    }
}