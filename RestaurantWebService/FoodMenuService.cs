using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantWebService
{
    public class FoodMenuService
    {
        public FoodMenuService(string endPoint, string restaurantId)
        {
            //Initialize web service with the endpoint string.
            //Data for food Menu items will fetch based on the Restaurant Id.
        }

        public List<FoodMenuModel> getAllFoodMenu(string restaurantId)
        {
            List<FoodMenuModel> foodMenu = new List<FoodMenuModel>();
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "001", Cuisine = "Indian", FoodName = "Chicken Biryani" , Rating = 5, Rate = 250});
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "002", Cuisine = "Indian", FoodName = "Chicken Korma", Rating = 4, Rate = 300 });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "003", Cuisine = "Indian", FoodName = "Shahi Paneer", Rating = 5, Rate = 250 });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "004", Cuisine = "Indian", FoodName = "Tandoori Roti", Rating = 3, Rate = 250 });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "005", Cuisine = "Indian", FoodName = "Choley Bhaturey", Rating = 5, Rate = 100 });

            return foodMenu;
        }
    }
}
