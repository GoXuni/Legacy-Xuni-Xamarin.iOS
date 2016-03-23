using System;

using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using CoreGraphics;
using Foundation;
using UIKit;
using Xuni.iOS.Core;
using Xuni.iOS.Calendar;

namespace CalendarSample
{
    public partial class ViewController : UIViewController
    {
		private List<UIImage> _weatherIcon = new List<UIImage>();
		private List<UIImage> _dotIcon = new List<UIImage>();
		private XuniCalendar _calendar = new XuniCalendar();

        public ViewController(IntPtr handle) : base(handle)
        {
			_weatherIcon.Add (UIImage.FromBundle ("Images/PartlyCloudy"));
			_weatherIcon.Add (UIImage.FromBundle ("Images/PartlyCloudyRain"));
			_weatherIcon.Add (UIImage.FromBundle ("Images/Rain"));
			_weatherIcon.Add (UIImage.FromBundle ("Images/Storm"));
			_weatherIcon.Add (UIImage.FromBundle ("Images/Sun"));	

			_dotIcon.Add (UIImage.FromBundle ("Images/blue"));
			_dotIcon.Add (UIImage.FromBundle ("Images/green"));
			_dotIcon.Add (UIImage.FromBundle ("Images/red"));
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            XuniLicenseManager.Key = License.Key;

			_calendar.Frame = new CoreGraphics.CGRect(0, 44, View.Bounds.Width, View.Bounds.Height - 44);
			_calendar.MaxSelectionCount = 16;
			_calendar.WeakDelegate = this;
			_calendar.DaySlotLoading += daySlotLoading;
			View.AddSubview(_calendar);
        }

		public void daySlotLoading(object sender, DaySlotLoadingEventArgs e)
		{
			if (!e.EventArgs.IsAdjacentDay) 
			{
				nint day = NSCalendar.CurrentCalendar.Components(NSCalendarUnit.Day, e.EventArgs.Date).Day;
				var rect = e.EventArgs.DaySlot.Frame;
				CGRect rect1, rect2;
				var imageDaySlot = new CalendarImageDaySlot(_calendar, rect);

				if (day >= 14 && day <= 23) {
					rect1 = new CGRect((nfloat)0, (nfloat)0, (nfloat)rect.Height / 4, (nfloat)rect.Height / 4);
					rect2 = new CGRect(rect.Width / 4, rect.Height / 5 * 2, rect.Width / 2, rect.Width / 2);

					imageDaySlot.DayTextRect = rect1;
					imageDaySlot.DayFont = UIFont.SystemFontOfSize (11);
					imageDaySlot.ImageRect = rect2;
					imageDaySlot.ImageSource = _weatherIcon[(int)(day % 5)];
				}
				else {
					rect1 = new CGRect(0, 0, rect.Width, rect.Height / 6 * 4);
					rect2 = new CGRect(rect.Width / 2 - 6 / 2, rect.Height / 6 * 4, 6, 6);

					imageDaySlot.DayTextRect = rect1;
					imageDaySlot.DayFont = UIFont.SystemFontOfSize (14);
					imageDaySlot.ImageRect = rect2;
					imageDaySlot.ImageSource = _dotIcon[(int)(day % 3)];
				}

				e.EventArgs.DaySlot = imageDaySlot;
			}
		}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


    }
}