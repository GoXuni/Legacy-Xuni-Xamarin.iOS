using Foundation;
using System;
using UIKit;
using Xuni.iOS.Core;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
    public partial class UnboundSampleViewController : UIViewController
    {
        public UnboundSampleViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			flexGrid.AllowMerging = GridAllowMerging.All;              // add rows/columns to the unbound grid             for (int i = 0; i < 12; i++) // three years, four quarters per year             {                 flexGrid.Columns.Add(new GridColumn());             }             for (int i = 0; i < 500; i++)             {                 flexGrid.Rows.Add(new GridRow());             }              // populate the unbound grid with some stuff             for (int r = 0; r < flexGrid.Rows.Count; r++)             {                 for (int c = 0; c < flexGrid.Columns.Count; c++)                 {                     flexGrid[r, c] = string.Format("cell [{0},{1}]", r, c);                 }             }              // set unbound column headers             var ch = flexGrid.ColumnHeaders;             ch.Rows.Add(new GridRow()); // one header row for years, one for quarters             for (int c = 0; c < ch.Columns.Count; c++)             {                 ch[0, c] = 2016 + c / 4; // year                 ch[1, c] = string.Format("Q {0}", c % 4 + 1); // quarter             }              // allow merging the first fixed row             ch.Rows[0].AllowMerging = true;              // set unbound row headers             var rh = flexGrid.RowHeaders;             rh.Columns.Add(new GridColumn());             for (int c = 0; c < rh.Columns.Count; c++)             { 				rh.Columns[c].Width = 60;                 for (int r = 0; r < rh.Rows.Count; r++)                 {                     rh[r, c] = string.Format("hdr {0},{1}", c == 0 ? r / 2 : r, c);                 }             }              // allow merging the first fixed column             rh.Columns[0].AllowMerging = true; 
		}
    }
}