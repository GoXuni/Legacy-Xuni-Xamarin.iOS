using System;
using System.Drawing;
using Foundation;
using UIKit;
using Xuni.iOS.Core;
using Xuni.iOS.ChartCore;
using Xuni.iOS.FlexPie;

namespace FlexPieSample
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
        public class BrowserUsageData : Foundation.NSObject
        {

            [Export("Browser")]
            public string Browser { get; set; }
            [Export("Sessions")]
            public double Sessions { get; set; }
            public BrowserUsageData(String name, double session)
            {
                Browser = name;
                Sessions = session;
            }
        }
        public NSMutableArray GetBrowserDataList()
        {
            NSMutableArray array = new NSMutableArray();
            string[] browser_names = new string[] { "Chrome", "Safari", "IE", "FireFox", "Opera" };
            Random rnd = new Random();
            for (int i = 0; i < browser_names.Length; i++)
            {
                array.Add(new BrowserUsageData(browser_names[i], rnd.Next(100 * (i + 1))));
            }

            return array;
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            // set Xuni license for this sample
            XuniLicenseManager.Key = License.Key;

            // Get our FlexPie from the layout resource
            FlexPie flexPie = new FlexPie();
            flexPie.Tag = 1;
            // bind FlexPie
            flexPie.ItemsSource = GetBrowserDataList();
            flexPie.Binding = "Sessions";
            flexPie.BindingName = "Browser";

            // set palette
            flexPie.Palette = XuniPalettes.Midnight();
            // configure flexpie settings
            flexPie.Header = "Browser Usage Stats";
            flexPie.Footer = "GrapeCity Xuni";
            flexPie.InnerRadius = 0.2f;
            flexPie.StartAngle = 90f;
            flexPie.SelectedItemOffset = 0.2f;
            flexPie.SelectionMode = SelectionMode.SelectionModePoint;

            //// set data label
            flexPie.DataLabel.Content = (NSString)"{value}";
            flexPie.DataLabel.DataLabelBackgroundColor = UIColor.White;
            flexPie.DataLabel.DataLabelFontColor = UIColor.Red;
            flexPie.DataLabel.DataLabelBorderColor = UIColor.Gray;
            flexPie.DataLabel.DataLabelBorderWidth = 0.2;
            flexPie.DataLabel.Position = PieDataLabelPosition.PieDataLabelPositionInside;

            //// customize tooltip

            flexPie.Tooltip.IsVisible = true;

            // configure animation
            flexPie.LoadAnimation.AnimationMode = AnimationMode.AnimationModePoint;

            View.AddSubview(flexPie);
        }
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            FlexPie p = (FlexPie)View.ViewWithTag(1);
            p.Frame = new CoreGraphics.CGRect(0, 44, View.Bounds.Width, View.Bounds.Height - 44);
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