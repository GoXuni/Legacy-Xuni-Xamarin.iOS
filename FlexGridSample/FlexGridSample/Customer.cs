using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using Foundation;

namespace FlexGridSample
{
    public class Customer : Foundation.NSObject
    {
        #region ** fields

        static Random _rnd = new Random();
        static string[] _firstNames = "Andy|Ben|Charlie|Dan|Ed|Fred|Gil|Herb|Jack|Karl|Larry|Mark|Noah|Oprah|Paul|Quince|Rich|Steve|Ted|Ulrich|Vic|Xavier|Zeb".Split('|');
        static string[] _lastNames = "Ambers|Bishop|Cole|Danson|Evers|Frommer|Griswold|Heath|Jammers|Krause|Lehman|Myers|Neiman|Orsted|Paulson|Quaid|Richards|Stevens|Trask|Ulam".Split('|');
        static string[] _countries = "China|India|United States|Indonesia|Brazil|Pakistan|Bangladesh|Nigeria|Russia|Japan|Mexico|Philippines|Vietnam|Germany|Ethiopia|Egypt|Iran|Turkey|Congo|France|Thailand|United Kingdom|Italy|Myanmar".Split('|');

        #endregion

        #region ** initialization

        public Customer()
            : this(_rnd.Next(10000))
        {
        }
        public Customer(int id)
        {
            ID = id;
            First = GetString(_firstNames);
            Last = GetString(_lastNames);
            CountryID = _rnd.Next() % _countries.Length;
            Active = _rnd.NextDouble() >= .5;
            iOSHired = NSDate.Now.AddSeconds(-24 * 60 * 60 * _rnd.Next(1, 1000));
            Money = 50 + _rnd.NextDouble() * 50;
        }

        #endregion

        #region ** object model

        public int ID
        {
            get;
            set;
        }


        [Export("CountryID")]
        public int CountryID { get; set; }

        [Export("Active")]
        public bool Active { get; set; }

        [Export("First")]
        public string First { get; set; }

        [Export("Last")]
        public string Last { get; set; }

        [Export("Hired")]
        public NSDate iOSHired { get; set; }

        [Export("Money")]
        public NSNumber Money { get; set; }

        #endregion
        #region ** implementation

        // ** utilities
        static string GetString(string[] arr)
        {
            return arr[_rnd.Next(arr.Length)];
        }
        static string GetName()
        {
            return string.Format("{0} {1}", GetString(_firstNames), GetString(_lastNames));
        }

        // ** static list provider
        public static NSMutableArray GetCustomerList(int count)
        {
            var array = new NSMutableArray();
            for (int i = 0; i < count; i++)
            {
                array.Add(new Customer(i));
            }
            return array;
        }

        // ** static value providers
        public static string[] GetCountries() { return _countries; }
        public static string[] GetFirstNames() { return _firstNames; }
        public static string[] GetLastNames() { return _lastNames; }

        #endregion
    }
}
