using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.FoodDeliveryAppModel
{
    public class RestaurantModel
    {
        private string restaurantId;
        public string RestaurantId
        {
            get { return restaurantId; }
            set { restaurantId = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private int rating;
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
