using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;

namespace FlexGridSample
{
	partial class EditingFormSampleViewController : UIViewController
	{
		public EditingFormSampleViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			this.flexGrid.IsReadOnly = true;
			this.flexGrid.ItemsSource = Customer.GetCustomerList (100);

			this.flexGrid.SelectionChanged += (sender, e) => this.EditButton.Enabled = true;
			this.flexGrid.CellDoubleTapped += (sender, panel, range) => {
				InvokeInBackground (() => {
					System.Threading.Thread.Sleep (500);

					InvokeOnMainThread (() => {
						if (sender.Selection.Row != -1)
							this.doEdit (null); 
					});

				});
				return false;
			};
		}

		public void EditingFinished()
		{
			this.flexGrid.CollectionView.RaiseCollectionChanged ();
		}

		partial void doEdit (UIBarButtonItem sender)
		{
			UIStoryboard storyboard = UIStoryboard.FromName ("MainStoryboard", null);
			UIViewController controller = storyboard.InstantiateViewController ("EditFormTable");
			((EditFormTable)controller).ObjectBeingEdited = ((List<Customer>)flexGrid.ItemsSource)[this.flexGrid.Selection.Row];
			((EditFormTable)controller).Presenter = this;
			this.PresentModalViewController (controller, true);
		}
	}
}
