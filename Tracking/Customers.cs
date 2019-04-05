using FoodDeliveryApp.FoodDeliveryAppModel;
using System;

namespace FoodDeliveryApp.Tracking
{
    public class Customers : ICustomers
    {

        #region Properties

        private UserModel userModel;
        public Restaurant Restaurant { get; set; }

        #endregion

        public Customers(UserModel userModel)
        {
            this.userModel = userModel;
        }

        #region Methods
        public void Update(FoodDelivery foodDelivery)
        {
            Console.WriteLine("Notified Restaurant ID {0} of Order ID {1}'s Food Delivery Status: {2}", foodDelivery.RestaurantId,
                foodDelivery.OrderId, foodDelivery.DeliveryStatus);
            Console.WriteLine("Date Time: {0}", foodDelivery.DeliveryTime);
        }

        #endregion

    }
}
