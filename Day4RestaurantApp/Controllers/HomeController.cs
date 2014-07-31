using Day4RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4RestaurantApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Restaurant> Restaurants = Singleton.Instance.Restaurants;
            return View(Restaurants);
          }
        [HttpPost]
        public ActionResult Index(string name, string cuisine, int rating, string image)
        {
            Singleton.Instance.Restaurants.Add(new Restaurant(name, cuisine, rating, image));
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            List<Restaurant> Restaurants = Singleton.Instance.Restaurants;
            Restaurant Restaurant = Restaurants.Where(r => r.Id == id).FirstOrDefault();
            return View(Restaurant);
        }
        [HttpPost]
        public ActionResult Details(int id, string comment)
        {
            List<Restaurant> Restaurants = Singleton.Instance.Restaurants;
            Restaurant Restaurant = Restaurants.Where(r => r.Id == id).FirstOrDefault();
            Restaurant.Comments.Add(new RestaurantComment(){Comment = comment});
            //Redirects to first get ActionrResult - must pass in any parameters in the ActionResult above
            return RedirectToAction("Details", new {id = id});
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}