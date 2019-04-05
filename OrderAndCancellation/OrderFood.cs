using FoodDeliveryApp.FoodDeliveryAppModel;
using System.Collections.Generic;

namespace FoodDeliveryApp.OrderAndCancellation
{
    public class OrderFood : IFoodOrderCommands
    {
        private readonly Food food;
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
