using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.OrderAndCancellation
{
    public class Food
    {
        public string OrderFood( string restaurantId, UserModel user)
        {
            var orderId = (restaurantId + Guid.NewGuid().ToString().Substring(0, 15)).ToUpper();
            Console.WriteLine("Order ID: {0}", orderId);
            Console.WriteLine("Customer Name : {0}", user.UserName);
            Console.WriteLine("Mobile : {0}", user.PhoneNumber);
            Console.WriteLine("User ID : {0}", user.UserId);
            Console.WriteLine("Address : {0}", user.Address);
            Console.WriteLine("Amount(Rs.): {0}", user.Amount);
            Console.WriteLine("Food Ordered");
            return orderId.ToString();
        }

        public void CancelFood(string orderId)
        {
            Console.WriteLine("Food Order with Order ID {0} has been cancelled.", orderId);
        }
    }
}
