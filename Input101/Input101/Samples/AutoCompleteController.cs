using System;
using UIKit;
using Foundation;
using CoreGraphics;
using Xuni.iOS.Core;
using Xuni.iOS.Input;

namespace Input101
{

	public class TableDelegate : UITableViewDelegate
	{

		Xuni.iOS.Input.XuniAutoComplete custom;

		public TableDelegate (Xuni.iOS.Input.XuniAutoComplete customAutocomplete)
		{
			custom = customAutocomplete;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			custom.SelectedIndex = indexPath.Row;
			custom.IsDropDownOpen = false;
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 50;
		}

		public override void WillDisplay(UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
			cell.SeparatorInset = UIEdgeInsets.Zero;
			cell.PreservesSuperviewLayoutMargins = false;
			cell.LayoutMargins = UIEdgeInsets.Zero;
		}
	}

	public class TableSource : UITableViewSource
	{
	
		Xuni.iOS.Input.XuniAutoComplete custom;
		string CellIdentifier = "TableCell";

		public TableSource (Xuni.iOS.Input.XuniAutoComplete customAutocomplete)
		{
			custom = customAutocomplete;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return (nint)(custom.TemporaryItemSource.Count);
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
	
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier);
			}
	
			CGRect rect = cell.ContentView.Frame;
			UIView selectedBackgroundView = new UIView(cell.Bounds);
			selectedBackgroundView.BackgroundColor = new UIColor((nfloat)(0 / 255.0),(nfloat)(122.0 / 255.0),(nfloat)(255.0 / 255.0),(nfloat)1.0);
			cell.SelectedBackgroundView = selectedBackgroundView;

			foreach (UIView view in cell.ContentView.Subviews)
			{
				view.RemoveFromSuperview ();
			}

			Countries item = custom.TemporaryItemSource.GetItem<Countries>((nuint)indexPath.Row);
			UIImageView imageView = new UIImageView(new CGRect(8,0,48,48));
			NSString imagePath = new NSString ("Images/" + (NSString)item.Name);
			imageView.Image = new UIImage(imagePath);
			cell.ContentView.Add (imageView);

			UILabel label = new UILabel (new CGRect(65,10,rect.Size.Width - 40, rect.Size.Height / 2));
			label.Text = item.Name;
			cell.ContentView.Add (label);

			custom.NormalizeCellText (label,label.Text);
			if(custom.FilterString != null)
			{
				custom.HighlightedSubstring (custom.FilterString,label);
			}

			return cell;
		}
	}

	public partial class AutoCompleteController : UIViewController
	{
		public AutoCompleteController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			HighlightDropdown.DropDownHeight = 200;
			HighlightDropdown.DisplayMemberPath = "Name";
			HighlightDropdown.IsAnimated = true;
			HighlightDropdown.ItemsSource = Countries.GetDemoDataList ();
			HighlightDropdown.ShowButton = false;

			DelayDropdown.DropDownHeight = 200;
			DelayDropdown.DisplayMemberPath = @"Name";
			DelayDropdown.IsAnimated = true;
			DelayDropdown.ItemsSource = Countries.GetDemoDataList ();
			DelayDropdown.Delay = 1000;
			DelayDropdown.ShowButton = false;

			CustomDropdown.DropDownHeight = 200;
			CustomDropdown.DisplayMemberPath = @"Name";
			CustomDropdown.IsAnimated = true;
			CustomDropdown.HighlightedColor = UIColor.Red;
			CustomDropdown.ItemsSource = Countries.GetDemoDataList ();
			CustomDropdown.TableView.Source = new TableSource(CustomDropdown);
			CustomDropdown.TableView.Delegate = new TableDelegate (CustomDropdown);

			FilterDropdown.ItemsSource = Countries.GetDemoDataList();
			FilterDropdown.DisplayMemberPath = "Name";
			FilterDropdown.Delegate = new Mydelegate(FilterDropdown);
			FilterDropdown.IsAnimated = true;
			FilterDropdown.FilteringArgs.Cancel = true;
		}

		class Mydelegate : XuniAutoCompleteDelegate
		{
			XuniAutoComplete filterAuto;

			public Mydelegate(XuniAutoComplete filterDropdown)
			{
				filterAuto = filterDropdown;
			}

			public override void Filtering(XuniAutoComplete sender, XuniAutoCompleteFilteringEventArgs eventArgs)
			{
				sender.CollectionView.Filter = (item) =>
				{
					Countries d = (Countries)item;
					string s = d.Name.Substring(0, 1).ToLower();
					if (s == "b")
					{
						return true;
					}
					return false;
				};

				NSMutableArray data = null;

				if (sender.CollectionView.Items != null)
				{
					data = new NSMutableArray();

					foreach (var item in sender.CollectionView.Items)
					{
						
						data.Add(NSObject.FromObject(item));
					}
				}
				sender.ItemsSource = data ;
				//filterAuto.FilteringArgs.Cancel = false;
			}
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
		
}


