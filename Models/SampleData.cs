using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T880809.Models {
    static class SampleData {
        public static List<Country> Countries = new List<Country>
        {
            new Country
            {
                ID = 1,
                Name = "USA"
            },
            new Country
            {
                ID = 3,
                Name = "Russia"
            },
            new Country
            {
                ID = 2,
                Name = "United Kingdom"
            }
        };

        public static List<City> CitiesUS = new List<City>
        {
            new City
            {
                ID = 1,
                Name = "New York"
            },
            new City
            {
                ID = 2,
                Name = "Oklahoma"
            },
            new City
            {
                ID = 3,
                Name = "Los Angeles"
            }
        };

        public static List<City> CitiesUnitedKingdom = new List<City>
        {
            new City
            {
                ID = 1,
                Name = "London"
            },
            new City
            {
                ID = 2,
                Name = "Manchester"
            },
            new City
            {
                ID = 3,
                Name = "Liverpool"
            }
        };

        public static List<City> CitiesRussia = new List<City>
        {
            new City
            {
                ID = 1,
                Name = "Tula"
            },
            new City
            {
                ID = 2,
                Name = "Kaluga"
            }
        };



        public static List<SampleOrder> Orders = new List<SampleOrder>() {
            new SampleOrder {
                OrderID = 10248,
                OrderDate = new DateTime(1996, 7, 4),
                ShipCountry = 1,
                ShipCity = 1,
                CustomerName = "Paul Henriot"
            },
            new SampleOrder {
                OrderID = 10249,
                OrderDate = new DateTime(1996, 7, 5),
                ShipCountry = 2,
                ShipCity = 1,
                CustomerName = "Karin Josephs"
            },
            
        };
    }
}
