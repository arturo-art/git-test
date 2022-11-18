using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyCore.Models;
using EmptyCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmptyCore.Pages.Restaurants
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        private IRestaurantData _restaurantData;

        public UpdateModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public  IActionResult OnGet(int id)
        {
            Restaurant = _restaurantData.Get(id);
            if (Restaurant == null)
                RedirectToAction("Index","Home");
            return Page();
        }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _restaurantData.Update(Restaurant);
                return RedirectToAction("Details", "Home", new { Id = Restaurant.Id });
            }
            return Page();
        }
    }
}