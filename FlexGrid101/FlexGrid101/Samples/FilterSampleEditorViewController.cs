using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FlexGridSample
{
	partial class FilterSampleEditorViewController : UIViewController
	{
		public FilterSampleEditorViewController (IntPtr handle) : base (handle)
		{
		}

		public Xuni.iOS.FlexGrid.FlexGrid FlexGrid { get { return this.flexGrid; } }
		public Action FilterDataLoadingAction;
		public Action FilterDataApplyAction;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			FilterDataLoadingAction ();

		}

		partial void editingFinishedOK (UIBarButtonItem sender)
		{
			FilterDataApplyAction();
			this.NavigationController.PopViewController(true);
		}
	}
}
