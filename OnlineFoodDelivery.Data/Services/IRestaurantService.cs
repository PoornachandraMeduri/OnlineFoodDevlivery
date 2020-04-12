using OnlineFoodDelivery.Data.Models;
using System.Collections.Generic;

namespace OnlineFoodDelivery.Data.Services
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetAllRestaurants();
    }
}
