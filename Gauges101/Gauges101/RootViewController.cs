using System;
using System.Drawing;
using Foundation;
using UIKit;
using Xuni.iOS.Gauge;
using Xuni.iOS.Core;

namespace GaugesSample
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
            // Set up linear gauge 
            XuniLinearGauge linearGauge = new XuniLinearGauge();
            linearGauge.Tag = 1;
            linearGauge.Direction = GaugeDirection.Right;
            linearGauge.Min = 0;
            linearGauge.Max = 100;
            linearGauge.Value = 50;
            linearGauge.Format = "C0";
            linearGauge.BackgroundColor = UIColor.White;
            linearGauge.ShowText = ShowText.MinMax;

            // add ranges to the linear gauge
            XuniGaugeRange range1 = new XuniGaugeRange(linearGauge);
            range1.Min = 0;
            range1.Max = 30;
            range1.Color = UIColor.Red;
            linearGauge.Ranges.Add(range1);
            XuniGaugeRange range2 = new XuniGaugeRange(linearGauge);
            range2.Min = 30;
            range2.Max = 70;
            range2.Color = UIColor.Orange;
            linearGauge.Ranges.Add(range2);
            XuniGaugeRange range3 = new XuniGaugeRange(linearGauge);
            range3.Min = 70;
            range3.Max = 100;
            range3.Color = UIColor.Green;
            linearGauge.Ranges.Add(range3);
            linearGauge.ShowRanges = false;

            // bullet graph
            XuniBulletGraph bulletGraph = new XuniBulletGraph();
            bulletGraph.Tag = 2;
            bulletGraph.Pointer.Thickness = 0.5f;
            bulletGraph.Min = 0;
            bulletGraph.Max = 100;
            bulletGraph.Value = 50;
            bulletGraph.Target = 80;
            bulletGraph.Good = 75;
            bulletGraph.Bad = 40;
            bulletGraph.Format = "C0";
            bulletGraph.BackgroundColor = UIColor.White;
            bulletGraph.ShowText = ShowText.Value;

            // radial gauge
            XuniRadialGauge radialGauge = new XuniRadialGauge();
            radialGauge.Tag = 3;
            radialGauge.Min = 0.0;
            radialGauge.Max = 1.0;
            radialGauge.Value = 0.75;
            radialGauge.Format = "P0";
            radialGauge.Pointer.Thickness = 0.5f;
            radialGauge.StartAngle = -15;
            radialGauge.SweepAngle = 210;
            radialGauge.ShowText = ShowText.All;
            radialGauge.Face.Thickness = 0.8f;
            radialGauge.ShowRanges = true;
            radialGauge.BackgroundColor = UIColor.White;

            XuniGaugeRange radialRange1 = new XuniGaugeRange(radialGauge);
            radialRange1.Min = 0.0;
            radialRange1.Max = 0.35;
            radialRange1.Color = UIColor.Orange;
            radialGauge.Ranges.Add(radialRange1);
            View.AddSubview(linearGauge);
            View.AddSubview(bulletGraph);
            View.AddSubview(radialGauge);
        }
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            XuniLinearGauge linearGauge = (XuniLinearGauge)View.ViewWithTag(1);
            XuniBulletGraph bulletGraph = (XuniBulletGraph)View.ViewWithTag(2);
            XuniRadialGauge radialGauge = (XuniRadialGauge)View.ViewWithTag(3);

            linearGauge.Frame = new CoreGraphics.CGRect(0, 64, View.Bounds.Width, View.Bounds.Height / 8);
            bulletGraph.Frame = new CoreGraphics.CGRect(0, View.Bounds.Height / 8 + 64, View.Bounds.Width, View.Bounds.Height / 8);
            radialGauge.Frame = new CoreGraphics.CGRect(0, View.Bounds.Height / 4 + 64, View.Bounds.Width, View.Bounds.Height - (View.Bounds.Height / 4 + 64));
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
}