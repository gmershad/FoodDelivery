using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliveryApp.RestaurantWebService;
using FoodDeliveryApp.FoodDeliveryAppModel;

namespace FoodDeliveryApp.RestaurantSearch
{
    public class InterpreterContext
    {
        private RestaurantService restaurantService;

        public InterpreterContext(String endpoint)
        {
            restaurantService = new RestaurantService(endpoint);
        }

        public List<RestaurantModel> GetAllRestaurants()
        {
            return restaurantService.GetAllRestaurants();
        }
    }
}
