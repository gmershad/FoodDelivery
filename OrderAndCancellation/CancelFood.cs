using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.OrderAndCancellation
{
    public class CancelFood : IFoodOrderCommands
    {
        private Food food;
        public string OrderId;

        public CancelFood(Food food)
        {
            this.food = food;
        }

        public void Execute()
        {
            food.CancelFood(OrderId);
        }
    }
}
