using FoodDeliveryApp.Ordering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.OrderAndCancellation
{
    public class Customer
    {
        List<IFoodOrderCommands> orderList = new List<IFoodOrderCommands>();

        public void TakeOrder(IFoodOrderCommands order)
        {
            orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var order in orderList)
            {
                order.Execute();
            }

            orderList.Clear();
        }
    }
}
