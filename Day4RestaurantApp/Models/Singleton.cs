using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day4RestaurantApp.Models
{
    public class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance{ get {
            if(_instance ==null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }}
        public List<Restaurant> Restaurants;
        public static int IdCount;
        private Singleton()
        {
            IdCount = 1;
            Restaurants = new List<Restaurant>();
            Restaurants.Add(new Restaurant("Outback Steakhouse", "BBBQ", 4, "http://mojosavings.com/wp-content/uploads/2012/05/Outback-Steakhouse-Coupons.png"));
            Restaurants.Add(new Restaurant("Burger King", "Fast Food", 2, "http://upload.wikimedia.org/wikipedia/en/thumb/3/3a/Burger_King_Logo.svg/1024px-Burger_King_Logo.svg.png"));
            Restaurants.Add(new Restaurant("Pappadeux's", "Seafood", 5, "http://s3.amazonaws.com/rapgenius/Pappadeaux.jpg"));
        }
    }
}