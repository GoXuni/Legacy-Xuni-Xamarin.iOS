using System;
using Foundation;
using System.Collections.Generic;

namespace FlexPieSample
{
	public class PieChartData
	{
		public string Name {get; set;}

		public double Value {get; set;}

		public static IEnumerable<PieChartData> DemoData()
		{
			List<PieChartData> result = new List<PieChartData> ();
			string[] fruit = new string[]{"Oranges","Apples","Pears","Bananas","Pineapples" };

			Random r = new Random ();

			foreach (var f in fruit)
				result.Add (new PieChartData { Name = f, Value = r.NextDouble()*101.0});

			return result;
		}
	}
}

