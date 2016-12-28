using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.RestaurantSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantWebService
{
    public abstract class AbstractExpression
    {
        public abstract List<RestaurantModel> Interpret(InterpreterContext context);
    }
}
