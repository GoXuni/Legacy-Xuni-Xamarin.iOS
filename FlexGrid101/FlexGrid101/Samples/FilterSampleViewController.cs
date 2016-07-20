using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xuni.iOS.FlexGrid;
using System.Collections.Generic;

namespace FlexGridSample
{
	partial class FilterSampleViewController : UIViewController
	{

		public class FilterData: ICloneable
		{
			public string FilterColumn { get; set; }

			public int FilterOperation { get; set; }

			public string FilterString { get; set; }

			public object Clone()
			{
				return new FilterData {FilterColumn = FilterColumn==null?null:(string)FilterColumn.Clone(), FilterOperation = FilterOperation, FilterString = FilterString==null?null:(string)FilterString.Clone() };
			}

		}

		public class FilterOperation
		{
			public string Title { get; set; }

			public int Identifier { get; set; }

			public static List<FilterOperation> StandardOperations ()
			{
				string[] titles = "Contains|StartsWith|EndsWith|EqualsText".Split('|');
				List<FilterOperation> result = new List<FilterOperation> ();
				foreach (string s in titles)
					result.Add (new FilterOperation { Title=s, Identifier = Array.IndexOf(titles, s) });
				return result;
			}
		}

		private List<FilterData> filterData;

		public FilterSampleViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.flexGrid.ItemsSource = Customer.GetCustomerList (100);
			this.flexGrid.IsReadOnly = false;
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);
		}

		partial void doRemoveFilter (UIBarButtonItem sender)
		{
			filterOrEditAction.Title = "Filter";
			sender.Enabled = false;
			this.flexGrid.CollectionView.Filter=(object item) => 
			{
				return true;
			};
		}

		partial void doFilterOrEdit (UIBarButtonItem sender)
		{
			if(sender.Title.Equals("Filter"))
			{
				filterData = new List<FilterData>();
				foreach(GridColumn gc in flexGrid.Columns)
				{
					filterData.Add(new FilterData {FilterColumn=gc.Binding, FilterOperation = 0, FilterString = null });
				}
			}

			UIStoryboard storyboard = UIStoryboard.FromName ("MainStoryboard", null);
			FilterSampleEditorViewController controller = (FilterSampleEditorViewController)storyboard.InstantiateViewController ("FilterSampleEditor");

			controller.FilterDataLoadingAction+=()=>
			{
				List<FilterData> newFilterData = new List<FilterData>();
				for(int i = 0; i < filterData.Count; i++)
					newFilterData.Add((FilterData)filterData[i].Clone());

				controller.FlexGrid.ItemsSource = newFilterData;
				controller.FlexGrid.IsReadOnly = false;
				controller.FlexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);

				GridColumn col = controller.FlexGrid.Columns[1];
				col.DataMap = new GridDataMap(FilterOperation.StandardOperations(), new NSString("Identifier"), new NSString("Title"));
			};

			controller.FilterDataApplyAction+=()=>
			{
				sender.Title = "Edit";
				removeFilterAction.Enabled = true;

				this.filterData = (List<FilterData>)controller.FlexGrid.ItemsSource;

				this.flexGrid.CollectionView.Filter = (object item)=>
				{
					bool result = true;
					for(int i = 0; i < filterData.Count; i++)
					{
						FilterData thisItem = filterData[i];
						GridColumn col = this.flexGrid.Columns[i];
						string objStr = col.GetBoundValue(item)!=null?col.GetBoundValue(item).ToString().ToLower():null;
						string filterStr = thisItem.FilterString!=null?thisItem.FilterString.ToLower():null;

						if(filterStr != null && filterStr.Length != 0) 
						{
							switch(thisItem.FilterOperation)
							{
							case 0:
								if(objStr==null || !objStr.Contains(filterStr)) result = false;
								break;
							case 1: 
								if(objStr==null || !objStr.StartsWith(filterStr)) result = false;
								break;
							case 2:
								if(objStr==null || !objStr.EndsWith(filterStr)) result = false;
								break;
							case 3: 
								if(objStr==null || !objStr.Equals(filterStr)) result = false;
								break;
							}
						}
					}
					return result;
				};
			};


			this.NavigationController.PushViewController(controller, true);


		}
	}
}
