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
	[Register ("MaskedInputController")]
	partial class MaskedInputController
	{
		[Outlet]
		Xuni.iOS.Input.XuniMaskedTextField MaskedDOB { get; set; }

		[Outlet]
		Xuni.iOS.Input.XuniMaskedTextField MaskedID { get; set; }

		[Outlet]
		Xuni.iOS.Input.XuniMaskedTextField MaskedPhone { get; set; }

		[Outlet]
		Xuni.iOS.Input.XuniMaskedTextField MaskedState { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (MaskedID != null) {
				MaskedID.Dispose ();
				MaskedID = null;
			}

			if (MaskedDOB != null) {
				MaskedDOB.Dispose ();
				MaskedDOB = null;
			}

			if (MaskedPhone != null) {
				MaskedPhone.Dispose ();
				MaskedPhone = null;
			}

			if (MaskedState != null) {
				MaskedState.Dispose ();
				MaskedState = null;
			}
		}
	}
}
