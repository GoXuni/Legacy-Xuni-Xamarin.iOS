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
    [Register ("GroupingSampleViewController")]
    partial class GroupingSampleViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem collapseButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Xuni.iOS.FlexGrid.FlexGrid flexGrid { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem SortButton { get; set; }


        [Action ("SortButton_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SortButton_Activated (UIBarButtonItem sender);

        [Action ("collapseButton_Click:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void collapseButton_Click (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (collapseButton != null) {
                collapseButton.Dispose ();
                collapseButton = null;
            }

            if (flexGrid != null) {
                flexGrid.Dispose ();
                flexGrid = null;
            }

            if (SortButton != null) {
                SortButton.Dispose ();
                SortButton = null;
            }
        }
    }
}