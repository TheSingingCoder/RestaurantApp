using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day4RestaurantApp.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public int Rating { get; set; }
        public string Image { get; set; }
        //Constructor Function - use so that the id is created every time you instantiate a new object
        public Restaurant(string name, string cuisine, int rating, string image)
        {
            Name = name;
            Cuisine = cuisine;
            Rating = rating;
            Image = image;
            Id = Singleton.IdCount;
            Singleton.IdCount++;
        }
        public List<RestaurantComment> Comments = new List<RestaurantComment>();
        
    }
}