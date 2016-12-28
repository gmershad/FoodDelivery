using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Tracking
{
    public class Restaurant : FoodDelivery
    {
        public Restaurant(string restaurantId, string orderId, string deliveryStatus) : base(restaurantId, orderId, deliveryStatus) { }
    }
}
