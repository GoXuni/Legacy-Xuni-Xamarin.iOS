using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FlexGridSample
{
	partial class EditFormTable : UITableViewController
	{
		public EditFormTable (IntPtr handle) : base (handle)
		{
		}

		private Customer objectBeingEdited = null;
		public EditingFormSampleViewController Presenter = null;

		public Customer ObjectBeingEdited 
		{
			get { return objectBeingEdited; }
			set { objectBeingEdited = value;
			}
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.firstNameTextField.Text = objectBeingEdited.FirstName;
			this.lastNameTextField.Text = objectBeingEdited.LastName;
			this.eMailTextField.Text = objectBeingEdited.Email;
			this.cityTextField.Text = objectBeingEdited.City;
			this.addressTextField.Text = objectBeingEdited.Address;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			if (indexPath.Row == this.RowsInSection (this.TableView, 0) - 1)
				this.DismissModalViewController (true);
			else if (indexPath.Row == this.RowsInSection (this.TableView, 0) - 2) {
				
				objectBeingEdited.FirstName = this.firstNameTextField.Text;
				objectBeingEdited.LastName = this.lastNameTextField.Text;
				objectBeingEdited.Email = this.eMailTextField.Text;
				objectBeingEdited.City = this.cityTextField.Text;
				objectBeingEdited.Address = this.addressTextField.Text;

				Presenter.EditingFinished ();
				this.DismissModalViewController (true);
			}
		}
	}
}
