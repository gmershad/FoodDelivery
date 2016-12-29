using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.Tracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDeliveryApp.FoodDeliveryDriver
{
    public class OrderTrackingDriver
    {
        /// <summary>
        /// This Driver used Observer Design Pattern
        /// </summary>
        /// <param name="restaurantId"></param>
        /// <param name="orderId"></param>
        /// <param name="user"></param>
        /// <param name="cancel"></param>
        public void OrderTrackingByUser(string restaurantId, string orderId, UserModel user, char cancel)
        {
            //Order Tracking.
            if (cancel != 'y')
            {
                Console.WriteLine(string.Empty);
                Console.WriteLine("Food Delivery Status");
                Console.WriteLine("---------------------");

                Restaurant restaurant = new Restaurant(restaurantId, orderId, "Order Received");
                restaurant.Attach(new Customers(user));
                Thread.Sleep(1000);
                restaurant.DeliveryStatus = "Dispatched";
                Thread.Sleep(1000);
                restaurant.DeliveryStatus = "On the way.";
                Thread.Sleep(1000);
                restaurant.DeliveryStatus = "Near to your home";
                restaurant.DeliveryStatus = "Delivered";
            }

            Console.ReadKey();
        }
    }
}
