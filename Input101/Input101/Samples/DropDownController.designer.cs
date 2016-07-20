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
	[Register ("DropDownController")]
	partial class DropDownController
	{
		[Outlet]
		Xuni.iOS.Input.XuniDropDown DropDown { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DropDown != null) {
				DropDown.Dispose ();
				DropDown = null;
			}
		}
	}
}
