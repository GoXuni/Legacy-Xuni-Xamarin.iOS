// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Input101
{
	[Register ("AutoCompleteController")]
	partial class AutoCompleteController
	{
		[Outlet]
		Xuni.iOS.Input.XuniAutoComplete CustomDropdown { get; set; }

		[Outlet]
		Xuni.iOS.Input.XuniAutoComplete DelayDropdown { get; set; }

		[Outlet]
		Xuni.iOS.Input.XuniAutoComplete FilterDropdown { get; set; }

		[Outlet]
		Xuni.iOS.Input.XuniAutoComplete HighlightDropdown { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CustomDropdown != null) {
				CustomDropdown.Dispose ();
				CustomDropdown = null;
			}

			if (DelayDropdown != null) {
				DelayDropdown.Dispose ();
				DelayDropdown = null;
			}

			if (HighlightDropdown != null) {
				HighlightDropdown.Dispose ();
				HighlightDropdown = null;
			}

			if (FilterDropdown != null) {
				FilterDropdown.Dispose ();
				FilterDropdown = null;
			}
		}
	}
}
