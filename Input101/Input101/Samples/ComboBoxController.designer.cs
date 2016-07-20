// WARNING
//
// This file has been generated automatically by Xamarin Studio Enterprise to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Input101
{
	[Register ("ComboBoxController")]
	partial class ComboBoxController
	{
		[Outlet]
		Xuni.iOS.Input.XuniComboBox ComboBoxEdit { get; set; }

		[Outlet]
		Xuni.iOS.Input.XuniComboBox ComboBoxNonEdit { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ComboBoxEdit != null) {
				ComboBoxEdit.Dispose ();
				ComboBoxEdit = null;
			}

			if (ComboBoxNonEdit != null) {
				ComboBoxNonEdit.Dispose ();
				ComboBoxNonEdit = null;
			}
		}
	}
}
