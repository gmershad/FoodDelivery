using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Tracking
{
    /// <summary>
    /// Subject
    /// </summary>
    public abstract class FoodDelivery
    {
        #region Properties

        private List<ICustomers> _customers = new List<ICustomers>();

        private string orderId;
        public string OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        private string restaurantId;
        public string RestaurantId
        {
            get { return restaurantId; }
            set { restaurantId = value; }
        }

        private string deliveryStatus;
        public string DeliveryStatus
        {
            get { return deliveryStatus; }
            set
            {
                if (deliveryStatus != value)
                {
                    deliveryStatus = value;
                    Notify();
                }
            }
        }

        public DateTime DeliveryTime
        {
            get { return DateTime.Now; }
        }

        #endregion

        #region Constructor

        public FoodDelivery(string restaurantId, string orderId, string deliveryStatus)
        {
            this.restaurantId = restaurantId;
            this.orderId = orderId;
            this.deliveryStatus = deliveryStatus;
        }

        #endregion

        #region Methods

        public void Attach(ICustomers customer)
        {
            _customers.Add(customer);
        }

        public void Notify()
        {
            foreach (ICustomers customer in _customers)
            {
                customer.Update(this);
            }

            Console.WriteLine(string.Empty);
        }

        #endregion
    }
}
