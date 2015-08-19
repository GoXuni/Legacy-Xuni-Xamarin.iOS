using System;
using System.Drawing;
using Foundation;
using UIKit;
using Xuni.iOS.FlexGrid;
using Xuni.iOS.Core;

namespace FlexGridSample
{
    public partial class RootViewController : UIViewController
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

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            XuniLicenseManager.Key = License.Key;
            FlexGrid grid = new FlexGrid();
            grid.Tag = 1;
            grid.ItemsSource = Customer.GetCustomerList(50);
            Column c1 = grid.Columns.GetItem<Column>(0);
            c1.Format = "c";
            Column c2 = grid.Columns.GetItem<Column>(1);
            c2.Format = "MM/dd/yyyy";
            grid.HeadersVisibility = FlexHeadersVisibility.FlexHeadersVisibilityColumn;

            if (UserInterfaceIdiomIsPhone == false)
            {
                starSizingForEditing(grid);
            }

            grid.WeakDelegate = this;
            //grid.FormatItem  += grid_FormatItem;
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
        [Export("prepareCellForEdit:")]
        public void PrepareCellForEdit(FlexCellRangeEventArgs args)
        {
            FlexGrid g = (FlexGrid)View.ViewWithTag(1);
            nuint i = (nuint)args.Col;
            Column col = g.Columns.GetItem<Column>(i);
            if (col.Binding == "Hired")
            {
                UITextField editor = (UITextField)g.ActiveEditor;
                UIDatePicker picker = new UIDatePicker();
                NSDate d = (NSDate)g.GetCellData(args.Row, args.Col, false);
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
        [Export("formatItem:")]
        public void FormatItem(FlexFormatItemEventArgs args)
        {
            FlexGrid g = (FlexGrid)View.ViewWithTag(1);
            nuint i = (nuint)args.Col;
            Column col = g.Columns.GetItem<Column>(i);
            if (col.Binding == "Money")
            {
                NSNumberFormatter f = new NSNumberFormatter();
                f.NumberStyle = NSNumberFormatterStyle.Currency;
                NSNumber n;
                try
                {
                    n = (NSNumber)g.GetCellData(args.Row, args.Col, false);
                }
                catch
                {
                    n = f.NumberFromString((NSString)g.GetCellData(args.Row, args.Col, false));
                }
                CoreGraphics.CGRect r = args.Panel.GetCellRect(args.Row, args.Col);
                if (n.Int32Value > 90)
                {
                    args.Context.SetFillColor(UIColor.Green.CGColor);
                }
                else if (n.Int32Value < 60)
                {
                    args.Context.SetFillColor(UIColor.Red.CGColor);
                }
                args.Context.FillRect(r);
            }
        }
        #endregion
    }
}