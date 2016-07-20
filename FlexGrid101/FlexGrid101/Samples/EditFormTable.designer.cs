// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FlexGridSample
{
	[Register ("EditFormTable")]
	partial class EditFormTable
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField addressTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField cityTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField eMailTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField firstNameTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField lastNameTextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (addressTextField != null) {
				addressTextField.Dispose ();
				addressTextField = null;
			}
			if (cityTextField != null) {
				cityTextField.Dispose ();
				cityTextField = null;
			}
			if (eMailTextField != null) {
				eMailTextField.Dispose ();
				eMailTextField = null;
			}
			if (firstNameTextField != null) {
				firstNameTextField.Dispose ();
				firstNameTextField = null;
			}
			if (lastNameTextField != null) {
				lastNameTextField.Dispose ();
				lastNameTextField = null;
			}
		}
	}
}
