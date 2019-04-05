using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.RestaurantSearch;
using System.Collections.Generic;

namespace FoodDeliveryApp.RestaurantWebService
{
    public abstract class AbstractExpression
    {
        public abstract List<RestaurantModel> Interpret(InterpreterContext context);
    }
}
