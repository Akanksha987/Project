using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                new Restaurant { RestaurantId = 1, Name = "Tasty Bites", Location = "Delhi" },
                new Restaurant { RestaurantId = 2, Name = "Food Express", Location = "Mumbai" }
            };

            return View(restaurants);
        }

        public IActionResult Menu(int id)
        {
            List<MenuItem> items = new List<MenuItem>()
            {
                new MenuItem { MenuId = 1, RestaurantId = 1, ItemName = "Veg Burger", Price = 120 },
                new MenuItem { MenuId = 2, RestaurantId = 1, ItemName = "Cheese Pizza", Price = 250 },
                new MenuItem { MenuId = 3, RestaurantId = 2, ItemName = "Paneer Roll", Price = 150 },
                new MenuItem { MenuId = 4, RestaurantId = 2, ItemName = "Cold Coffee", Price = 80 }
            };

            var restaurantMenu = items.FindAll(x => x.RestaurantId == id);
            return View(restaurantMenu);
        }
    }
}
