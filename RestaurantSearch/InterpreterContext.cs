using System;
using System.Collections.Generic;
using FoodDeliveryApp.RestaurantWebService;
using FoodDeliveryApp.FoodDeliveryAppModel;

namespace FoodDeliveryApp.RestaurantSearch
{
    public class InterpreterContext
    {
        private readonly RestaurantService restaurantService;

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
