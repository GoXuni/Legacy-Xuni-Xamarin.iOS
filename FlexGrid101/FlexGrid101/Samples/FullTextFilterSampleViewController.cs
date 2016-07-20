using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
	partial class FullTextFilterSampleViewController : UIViewController
	{
		public FullTextFilterSampleViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.IsReadOnly = true;
			this.flexGrid.ItemsSource = Customer.GetCustomerList(100);
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);

			this.flexGrid.FormatItem += (Xuni.iOS.FlexGrid.FlexGrid sender, Xuni.iOS.FlexGrid.GridPanel panel, Xuni.iOS.FlexGrid.GridCellRange range, CoreGraphics.CGContext context) => {
				
				if(panel == sender.Cells)
				{
					if(this.searchText.Text == null || this.searchText.Text.Length == 0 || (sender.EditRange!=null && sender.EditRange.Intersects(range))) return false;

					NSError error = null;
					NSRegularExpression regex = new NSRegularExpression(new NSString(this.searchText.Text), NSRegularExpressionOptions.CaseInsensitive, out error);

					NSString data = new NSString(panel.GetCellData(range.Row, range.Col, true).ToString());


					if(error == null)
					{
						NSMutableAttributedString attributedString = new NSMutableAttributedString(data);

						regex.EnumerateMatches(data, 0, new NSRange(0, data.Length), (NSTextCheckingResult result, NSMatchingFlags flags, ref bool stop) => 
							{
								NSRange thisrange = result.Range;
								UIStringAttributes stringAttributes = new UIStringAttributes();
								stringAttributes.Font = UIFont.BoldSystemFontOfSize(this.flexGrid.Font.PointSize);
								stringAttributes.ForegroundColor = UIColor.Red;
								attributedString.SetAttributes(stringAttributes, thisrange);
							}
						);

						CoreGraphics.CGRect t = panel.GetCellRect(range.Row, range.Col);
						CoreGraphics.CGSize sz = attributedString.Size;
						UITextAlignment align = this.flexGrid.Columns[range.Col].HorizontalAlignment;

						if (align == UITextAlignment.Right) {
							nfloat mod = t.Size.Width - sz.Width - 4;
							if (mod < 4) mod = 4;
							t.Location = new CoreGraphics.CGPoint(t.Location.X + mod, t.Location.Y);
						} else if (align == UITextAlignment.Center) {
							nfloat mod = (t.Size.Width - sz.Width) / 2;
							if (mod < 4) mod = 4;
							t.Location = new CoreGraphics.CGPoint(t.Location.X + mod, t.Location.Y);
						} else {
							t.Location = new CoreGraphics.CGPoint(t.Location.X + 4, t.Location.Y);
						}

						nfloat mrg = (t.Size.Height - sz.Height) / 2;
						if (mrg < 4) mrg = 4;

						t.Location = new CoreGraphics.CGPoint(t.Location.X,t.Location.Y + mrg);

						attributedString.DrawString(t);

						return true;
					}
				}

				return false;
			};
		}

		partial void finishedit (UITextField sender)
		{
			searchText.ResignFirstResponder();
		}

		partial void textChange (UITextField sender)
		{

			if(sender.Text !=null && sender.Text.Length > 0)
			{
				this.flexGrid.CollectionView.Filter = (object item) => 
				{
					Customer d = (Customer)item;


					if (d.Id.ToString().ToLower().Contains(sender.Text.ToLower())) {
						return true;
					}
					else if (d.CountryId.ToString().ToLower().Contains(sender.Text.ToLower())) {
						return true;
					}
					else if (d.Email.ToString().ToLower().Contains(sender.Text.ToLower())) {
						return true;
					}
					else if (d.FirstName.ToString().ToLower().Contains(sender.Text.ToLower())) {
						return true;
					}
					else if (d.LastName.ToString().ToLower().Contains(sender.Text.ToLower()))
					{
						return true;
					}
					else if (d.Country.ToString().ToLower().Contains(sender.Text.ToLower())){
						return true;
					}
					else if (d.City.ToString().ToLower().Contains(sender.Text.ToLower())){
						return true;
					}
					else if (d.Address.ToString().ToLower().Contains(sender.Text.ToLower())){
						return true;
					}
					else if (d.LastOrderDate.ToString().ToLower().Contains(sender.Text.ToLower()))
					{
						return true;
					}

					return false;
				};
			}
			else
			{
				this.flexGrid.CollectionView.Filter = (object item) => 
				{
					return true;
				};
			}
		}
	}
}
