using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyCore.Models;
using EmptyCore.Services;
using Microsoft.AspNetCore.Mvc;
using EmptyCore.ViewModels;

namespace EmptyCore.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData
            , IGreeter greeter)
        {
            _greeter = greeter;
            _restaurantData = restaurantData;
        }
        public IActionResult index()
        {
            //var Model = new Restaurant { Id = 1, Name = "rest 1" };
            var model = new RestaurantViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfDay();
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return Redirect(nameof(index));
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Restaurant restaurant)
        {
            throw new Exception("test");
            return Content(restaurant.Name);
            //return new ObjectResult("get data");
            if(ModelState.IsValid)
            {
                Restaurant res = new Restaurant();
                res.Name = restaurant.Name;
                res.Cuisine = restaurant.Cuisine;
                var model = _restaurantData.Add(res);
                //return RedirectToAction(nameof(Details), "Home", new { id = res.Id });
                return View(nameof(Details), res);
            }
            return View();
        }
    }
}
