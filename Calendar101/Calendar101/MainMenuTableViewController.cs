using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using Xuni.iOS.Calendar;
using Xuni.iOS.Core;

namespace CalendarSample
{
	public class Sample
	{
		public string Title;
		public string Description;
		public string Image;
		public string StoryboardID;
	}

	partial class MainMenuTableViewController : UITableViewController
	{
		List<Sample> list = null;

		public MainMenuTableViewController (IntPtr handle) : base (handle)
		{
		}

		static byte[] GetBytes (string str)
		{
			byte[] bytes = new byte[str.Length * sizeof(char)];
			System.Buffer.BlockCopy (str.ToCharArray (), 0, bytes, 0, bytes.Length);
			return bytes;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			XuniLicenseManager.Key = License.Key;
			XmlSerializer readfile = new XmlSerializer (typeof(System.Collections.Generic.List<Sample>));
			using (StringReader reader = new System.IO.StringReader (File.ReadAllText ("XuniSampleDescriptor.xml"))) {
				list = (List<Sample>)readfile.Deserialize (reader);
			}

		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			Sample s = list [indexPath.Row];
			UIKit.UITableViewCell cell = this.TableView.DequeueReusableCell ("Cell");
			cell.TextLabel.Text = s.Title;
			cell.TextLabel.TextColor = new UIColor ((nfloat)176.0f / 256.0f, (nfloat)15.0f / 256.0f, (nfloat)80.0f / 256.0f, (nfloat)1.0f);
			cell.DetailTextLabel.Text = s.Description;
			cell.ImageView.Image = new UIImage (s.Image);
			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			string next = list [indexPath.Row].StoryboardID;

			UIStoryboard storyboard = UIStoryboard.FromName ("Main", null);
			UIViewController controller = storyboard.InstantiateViewController (next);

			this.NavigationController.PushViewController (controller, true);
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return list.Count;
		}
	}
}
