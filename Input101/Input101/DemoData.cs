using Foundation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Input101
{
	public class Countries : NSObject
	{
		[Export("Name")]
		public string Name { get; set; }

		public Countries()
		{
			this.Name = string.Empty;
		}

		public Countries(string name, double sales, double salesgoal, double download, double downloadgoal, double expense, double expensegoal, string fruits)
		{
			this.Name = name;
		}

		public static NSMutableArray GetDemoDataList()
		{
			NSMutableArray array = new NSMutableArray();
			var quarterNames = "Australia,Bangladesh,Brazil,Canada,China,France,Germany,India,Japan,Nepal,Pakistan,Srilanka".Split(',');

			for (int i = 0; i < quarterNames.Length; i++)
			{
				array.Add(new Countries
					{
						Name = quarterNames[i]
					});
			}
			return array;
		}
	}
}
