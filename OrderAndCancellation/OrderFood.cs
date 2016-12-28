using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.OrderAndCancellation
{
    public class OrderFood : IFoodOrderCommands
    {
        private Food food;
        public List<FoodMenuModel> FoodItems;
        public UserModel User;
        public string OrderId;
        public string RestaurantId;

        public OrderFood(Food food)
        {
            this.food = food;
        }

        public void Execute()
        {
            OrderId = food.OrderFood(RestaurantId,User);
        }
    }
}
