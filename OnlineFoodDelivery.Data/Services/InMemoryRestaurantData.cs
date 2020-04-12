using OnlineFoodDelivery.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineFoodDelivery.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantService
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1,Name="Scott's Pizza", Cousin=CousinTypes.Italian},
                new Restaurant{Id=2,Name="China Buffet", Cousin=CousinTypes.Chineese},
                new Restaurant{Id=3,Name="Godavari Kitchen", Cousin=CousinTypes.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return restaurants.OrderBy(k => k.Name);
        }
    }
}
