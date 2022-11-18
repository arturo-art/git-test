using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCore.api
{
    [Route("api/[controller]/{category}")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private IRestaurantData _restaurants;

        public FoodController(IRestaurantData restaurantData)
        {
            _restaurants = restaurantData;
        }
        [HttpGet]
        public IActionResult Find()
        {
            return Ok(_restaurants.GetAll());
        }
        [HttpGet("{id}", Name = "Get")]
        //[HttpGet(Name = "Get")]
        public IActionResult GetAll(int id)
        {
            return new ObjectResult("get All");
        }
    }
}