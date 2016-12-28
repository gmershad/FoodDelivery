using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantWebService
{
    public class RestaurantService
    {
        public RestaurantService(string endPoint) {
        
            //Initialize web service with the endpoint string.
        }

        /// <summary>
        /// This method should expose Webservice to fetch all Restaurants.
        /// </summary>
        public List<RestaurantModel> GetAllRestaurants()
        {
            List<RestaurantModel>  restaurants = new List<RestaurantModel>();
            restaurants.Add(new RestaurantModel { RestaurantId="001", Name="Barbequnation", Address="JP Nagar, Bangalore 56006", Rating = 5 });
            restaurants.Add(new RestaurantModel {RestaurantId="002", Name = "Paradize", Address = "Kormangala",  Rating = 3});
            restaurants.Add(new RestaurantModel {RestaurantId="003", Name = "Thirteenth floor", Address = "Brigate Road", Rating = 4 });
            restaurants.Add(new RestaurantModel {RestaurantId="004", Name = "Mango Tree", Address = "JP Nagar, Bangalore 560009", Rating =2 });
            restaurants.Add(new RestaurantModel {RestaurantId="005", Name = "Brewsky", Address = "JP Nagar, Bangalore 564555", Rating = 4});
            return restaurants;
        }
    }
}
