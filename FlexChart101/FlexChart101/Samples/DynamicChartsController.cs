// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

using Xuni.iOS.Core;
using Xuni.iOS.ChartCore;
using Xuni.iOS.FlexChart;
using System.Linq;
using System.Collections.Generic;

namespace FlexChartSample
{
	public partial class DynamicChartsController : UIViewController
	{
		List<DummyObject> list = new List<DummyObject>();

		public DynamicChartsController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			for (int i = 0; i < 8; i++)
			{
				list.Add(getItem());
			}
			chart.ItemsSource = list;
			chart.Palette = XuniPalettes.Coral;
			chart.Tooltip.IsVisible = false;
			chart.ChartType = ChartType.Line; 
			chart.LoadAnimation.AnimationMode = AnimationMode.Point;

			chart.BindingX = "time";
			chart.Series.Add(new Series(chart, "Trucks, Trucks", "Trucks"));
			chart.Series.Add(new Series(chart, "Ships, Ships", "Ships"));
			chart.Series.Add(new Series(chart, "Planes, Planes", "Planes"));

			chart.IsAnimated = true;

			InvokeInBackground(()=>{
				bool flag = true;
				while (flag)
				{
					NSThread.SleepFor(1);
					InvokeOnMainThread(() =>
					{
						chart.CollectionView.RemoveAt(0);
						chart.CollectionView.Add(getItem());
						if (!IsViewLoaded)
							flag = false;
					});
				}
			});
		}

		Random random = new Random();

		public DummyObject getItem()
		{
			double nextDouble = random.Next(0, 1000);

			while (nextDouble < 900)
			{
				nextDouble = random.Next(0, 1000);
			}

			double trucks = nextDouble + 20;
			double ships = nextDouble + 10;
			double planes = nextDouble;

			DateTime now = DateTime.Now;

			return new DummyObject(now, now.ToString("mm:ss"), trucks, ships, planes);
		}

		public class DummyObject
		{
			public String Name { get; set; }

			public DateTime Time { get; set; }

			public double Trucks { get; set; }

			public double Ships { get; set; }

			public double Planes { get; set; }

			public DummyObject(DateTime time, String name, double trucks, double ships, double planes)
			{
				this.Time = time;
				this.Name = name;
				this.Trucks = trucks;
				this.Ships = ships;
				this.Planes = planes;
			}

		} 
	}
}