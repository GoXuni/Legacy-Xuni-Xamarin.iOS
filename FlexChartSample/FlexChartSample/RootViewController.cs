using System;
using System.Drawing;
using Foundation;
using UIKit;
using Xuni.iOS.Core;
using Xuni.iOS.ChartCore;
using Xuni.iOS.FlexChart;

namespace FlexChartSample
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

            FlexChart chart = new FlexChart();
            chart.Tag = 1;

            // set title/footer
            chart.Header = "FlexChart Sales";
            chart.Footer = "GrapeCity Xuni";
            chart.Legend.BorderWidth = 1;
            chart.Legend.BorderColor = UIColor.Gray;

            // set palette
            chart.Palette = XuniPalettes.Coral();
            // set data source
            chart.ItemsSource = SalesData.GetSalesDataList();
            // bind X axis to display category names
            chart.BindingX = (NSString)"Date";
            chart.Legend.Position = Position.PositionNone;
            // configure default axes
            chart.AxisX.LabelAngle = 45;
            chart.AxisX.Format = "d";
            chart.AxisY.Format = "c0";
            chart.AxisY.Title = "Dollars";

            // add second Y axis
            Axis y2 = new Axis(Position.PositionRight, chart);
            y2.MajorGridVisible = false;
            y2.MinorGridVisible = false;
            y2.LabelsVisible = true;
            y2.Title = "Downloads";
            chart.AxesArray.Add(y2);

            // create series with binding
            Series sales = new Series(chart, (NSString)"Sales", (NSString)"Sales"); 
            Series expenses = new Series(chart, (NSString)"Expenses", (NSString)"Expenses");
            Series downloads = new Series(chart, (NSString)"Downloads", (NSString)"Downloads");
            downloads.AxisY = y2;
            downloads.ChartType = ChartType.ChartTypeLine;
            chart.Series.Add(sales);
            chart.Series.Add(expenses);
            chart.Series.Add(downloads);

            // customize tooltip
            //MyTooltip t = new MyTooltip();
            //t.BackgroundColor = UIColor.Blue;
            //chart.Tooltip.Content = t;
            chart.Tooltip.IsVisible = true;
            // customize plot element
            chart.DataLabel.Content = (NSString)"{y}";
            chart.DataLabel.DataLabelFormat = (NSString)"C0";
            chart.DataLabel.DataLabelBackgroundColor = UIColor.White;
            chart.DataLabel.DataLabelFontColor = UIColor.Red;
            chart.DataLabel.DataLabelBorderColor = UIColor.Gray;
            chart.DataLabel.DataLabelBorderWidth = 0.1;
            chart.DataLabel.Position = ChartDataLabelPosition.ChartDataLabelPositionTop;
            // configure animation
            chart.LoadAnimation.AnimationMode = AnimationMode.AnimationModePoint;
            View.AddSubview(chart);
        }
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            FlexChart g = (FlexChart)View.ViewWithTag(1);
            g.Frame = new CoreGraphics.CGRect(0, 44, View.Bounds.Width, View.Bounds.Height - 44);
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

        #endregion
    }
    public class MyTooltip : XuniBaseChartTooltipView
    {
        //public UILabel label;
        //public override XuniDataPoint ChartData
        //{
        //    get
        //    {
        //        return base.ChartData;
        //    }
        //    set
        //    {
        //        if (label == null)
        //        {
        //            label = new UILabel();
        //            label.Frame = new CoreGraphics.CGRect(0, 0, Bounds.Size.Width, Bounds.Size.Height);
        //            label.Lines = 2;
        //            label.Text = (NSString)("SeriesName " + ChartData.SeriesName + "\nValue" + ChartData.DataY);
        //            AddSubview(label);
        //        }
        //        else
        //        {
        //            label.Text = (NSString)("SeriesName " + ChartData.SeriesName + "\nValue" + ChartData.DataY);
        //        }
        //    }
        //}
        //public void _render()
        //{

        //}
    }
}