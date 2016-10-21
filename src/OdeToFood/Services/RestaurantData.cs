using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{

    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurantList = new List<Restaurant>
            {
                new Restaurant() { Id = 1, Name = "House of Kobe" },
                new Restaurant() { Id = 2, Name = "AJ & KK" },
                new Restaurant() { Id = 3, Name = "Kings and Friends" },
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurantList;
        }

        List<Restaurant> _restaurantList;
    }
}
