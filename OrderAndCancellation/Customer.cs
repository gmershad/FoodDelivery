using System.Collections.Generic;

namespace FoodDeliveryApp.OrderAndCancellation
{
    public class Customer
    {
        readonly List<IFoodOrderCommands> orderList = new List<IFoodOrderCommands>();

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
