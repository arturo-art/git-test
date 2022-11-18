using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyCore.Models;

namespace EmptyCore.Services
{
    //public class InMemoryRestaurant : IRestaurantData
    //{
    //    public InMemoryRestaurant()
    //    {
    //        restaurants = new List<Restaurant>
    //        {
    //            new Restaurant{Id=1, Name="rest1"},
    //            new Restaurant{Id=2, Name="rest2"},
    //            new Restaurant{Id=3, Name="rest3"}
    //        };
    //    }
    //    public IEnumerable<Restaurant> GetAll()
    //    {
    //        return restaurants.OrderBy(o => o.Name);
    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return restaurants.FirstOrDefault(f => f.Id == id);
    //    }

    //    public Restaurant Add(Restaurant restaurant)
    //    {
    //        restaurant.Id = restaurants.Max(m => m.Id) + 1;
    //        restaurants.Add(restaurant);
    //        return restaurant;
    //    }

    //    List<Restaurant> restaurants;
    //}
}
