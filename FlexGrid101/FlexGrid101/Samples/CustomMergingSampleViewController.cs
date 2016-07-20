using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
	partial class CustomMergingSampleViewController : UIViewController
	{
		public CustomMergingSampleViewController (IntPtr handle) : base (handle)
		{
		} 

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.SelectionMode = GridSelectionMode.Cell;
			this.flexGrid.IsReadOnly = true;
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
			this.flexGrid.AutoSizeMode = GridAutoSizeMode.Both;
			this.flexGrid.AllowMerging = GridAllowMerging.All;

			string[] weekdays = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday","Sunday"};

			foreach (string s in weekdays)
				this.flexGrid.Columns.Add (new GridColumn {
					Header = s,
					WidthType = GridColumnWidth.Star,
					Width = 1,
					DataType = Xuni.iOS.Core.XuniDataType.String,
					MinWidth = 120,
					HorizontalAlignment = UITextAlignment.Center,
					HeaderHorizontalAlignment = UITextAlignment.Center,
					AllowMerging = true
				});

			string[] timespans = new string[]{ "12", "13", "14", "15", "16", "17", "18"};

			foreach (string s in timespans) {
				GridRow newRow = new GridRow ();
				this.flexGrid.Rows.Add (newRow);
				this.flexGrid.RowHeaders[this.flexGrid.Rows.IndexOf(newRow), 0] = new NSString(s+":00");
			}

			this.flexGrid.ColumnHeaders.Rows.Insert(0, new GridRow() { AllowMerging = true });
			this.flexGrid.ColumnHeaders[0, 0] = "Weekday";
			this.flexGrid.ColumnHeaders[0, 1] = "Weekday";
			this.flexGrid.ColumnHeaders[0, 2] = "Weekday";
			this.flexGrid.ColumnHeaders[0, 3] = "Weekday";
			this.flexGrid.ColumnHeaders[0, 4] = "Weekday";
			this.flexGrid.ColumnHeaders[0, 5] = "Weekend";
			this.flexGrid.ColumnHeaders[0, 6] = "Weekend";

			this.flexGrid[0, 0] = "Walker";
			this.flexGrid[0, 1] = "Morning Show";
			this.flexGrid[0, 2] = "Morning Show";
			this.flexGrid[0, 3] = "Sports";
			this.flexGrid[0, 4] = "Weather";
			this.flexGrid[0, 5] = "N/A";
			this.flexGrid[0, 6] = "N/A";
			this.flexGrid[1, 5] = "N/A";
			this.flexGrid[1, 6] = "N/A";
			this.flexGrid[2, 5] = "N/A";
			this.flexGrid[2, 6] = "N/A";
			this.flexGrid[3, 5] = "N/A";
			this.flexGrid[3, 6] = "N/A";
			this.flexGrid[4, 5] = "N/A";
			this.flexGrid[4, 6] = "N/A";
			this.flexGrid[1, 0] = "Today Show";
			this.flexGrid[1, 1] = "Today Show";
			this.flexGrid[2, 0] = "Today Show";
			this.flexGrid[2, 1] = "Today Show";
			this.flexGrid[1, 2] = "Sesame Street";
			this.flexGrid[1, 3] = "Football";
			this.flexGrid[2, 3] = "Football";
			this.flexGrid[1, 4] = "Market Watch";
			this.flexGrid[2, 2] = "Kids Zone";
			this.flexGrid[2, 4] = "Soap Opera";
			this.flexGrid[3, 0] = "News";
			this.flexGrid[3, 1] = "News";
			this.flexGrid[3, 2] = "News";
			this.flexGrid[3, 3] = "News";
			this.flexGrid[3, 4] = "News";
			this.flexGrid[4, 0] = "News";
			this.flexGrid[4, 1] = "News";
			this.flexGrid[4, 2] = "News";
			this.flexGrid[4, 3] = "News";
			this.flexGrid[4, 4] = "News";
			this.flexGrid[5, 0] = "Wheel of Fortune";
			this.flexGrid[5, 1] = "Wheel of Fortune";
			this.flexGrid[5, 2] = "Wheel of Fortune";
			this.flexGrid[5, 3] = "Jeopardy";
			this.flexGrid[5, 4] = "Jeopardy";
			this.flexGrid[5, 5] = "Movie";
			this.flexGrid[6, 5] = "Movie";
			this.flexGrid[5, 6] = "Golf";
			this.flexGrid[6, 6] = "Golf";
			this.flexGrid[6, 0] = "Night Show";
			this.flexGrid[6, 1] = "Night Show";
			this.flexGrid[6, 2] = "Sports";
			this.flexGrid[6, 3] = "Big Brother";
			this.flexGrid[6, 4] = "Big Brother";

			this.flexGrid.AutoSizeColumn (0, true);

			this.flexGrid.SelectionChanged += (object sender, SelectionChangedEventArgs e) => {
				string thisShow = this.flexGrid[(int)e.Range.Row, (int)e.Range.Col].ToString();
				this.tvShowName.Text = thisShow;

				string timeTable = "";

				for (int cc = 0; cc<weekdays.Length; cc++)
				{
					string day = weekdays[cc];
					string spanStart = null, spanEnd = null;

					for (int cr = 0; cr < timespans.Length; cr++)
					{
						string candidate = this.flexGrid[cr, cc].ToString();
						if(candidate.Equals(thisShow))
						{
							if(spanStart == null) spanStart = timespans[cr];
						}
						else
						{
							if(spanStart!=null) {
								spanEnd = timespans[cr];
								break;
							}
						}
					}

					if(spanStart!=null && spanEnd == null) spanEnd="19";

					if(spanStart!=null && spanEnd!= null) timeTable = timeTable+day+": "+spanStart+":00-"+spanEnd+":00\r";
				}



				this.tvShowTimeTable.Text = timeTable;
			};
		}
	}
}
