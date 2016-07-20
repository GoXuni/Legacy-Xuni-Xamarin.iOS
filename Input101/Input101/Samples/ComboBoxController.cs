using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using Xuni.iOS.Core;

namespace Input101
{
	public partial class ComboBoxController : UIViewController
	{
		public ComboBoxController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			ComboBoxEdit.DisplayMemberPath = "Name";
			ComboBoxEdit.ItemsSource = Countries.GetDemoDataList();
			ComboBoxEdit.DropDownHeight = 200;
			ComboBoxEdit.Placeholder = @"Please Enter...";

			ComboBoxNonEdit.DisplayMemberPath = "Name";
			ComboBoxNonEdit.ItemsSource = Countries.GetDemoDataList();
			ComboBoxNonEdit.IsEditable = false;
			ComboBoxNonEdit.DropDownBehavior = Xuni.iOS.Input.XuniDropDownBehavior.HeaderTap;
			ComboBoxNonEdit.DropDownHeight = 200;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}


}


