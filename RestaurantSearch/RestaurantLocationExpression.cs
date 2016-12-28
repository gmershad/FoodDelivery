using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.RestaurantWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantSearch
{
    public class RestaurantLocationExpression : AbstractExpression
    {
        private String searchString;

        public RestaurantLocationExpression(String searchString)
        {
            this.searchString = searchString;
        }
        public override List<RestaurantModel> Interpret(InterpreterContext context)
        {
            List<RestaurantModel> restaurants = context.GetAllRestaurants();

            List<RestaurantModel> restaurantResult = new List<RestaurantModel>();
            var result = restaurants.Where(e => e.Address.Contains(this.searchString));

            if (result != null) restaurantResult = result.ToList();

            return restaurantResult;
        }
    }
}
