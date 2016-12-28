using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.FoodMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantFoodMenu
{
    public class Waitress
    {
        private string restaurantId;
        FoodMenu foodMenu;
        public Waitress(string restaurantId)
        {
            this.restaurantId = restaurantId;
        }

        public List<FoodMenuModel> PrintFoodMenu()
        {
            foodMenu = new FoodMenu(restaurantId);
            IIterator restaurantFoodMenu = foodMenu.CreateFoodMenuIterator();
            return PrintFoodMenu(restaurantFoodMenu);
        }

        private List<FoodMenuModel> PrintFoodMenu(IIterator iterator)
        {
            Console.WriteLine("Food Menu");
            Console.WriteLine("**************************************");
            Console.WriteLine();

            List<FoodMenuModel> foodMenu = new List<FoodMenuModel>();

            while (iterator.HasNext())
            {
                FoodMenuModel foodMenuItem = (FoodMenuModel)iterator.Next();
                foodMenu.Add(foodMenuItem);

                Console.WriteLine("Restaurant ID : {0}", foodMenuItem.RestaurantId);
                Console.WriteLine("Food ID : {0}", foodMenuItem.FoodId);
                Console.WriteLine("Food Name : {0}", foodMenuItem.FoodName);
                Console.WriteLine("Couisine : {0}", foodMenuItem.Cuisine);
                Console.WriteLine("Rate(Rs.) : {0}", foodMenuItem.Rate);
                Console.WriteLine("Rating : {0}", foodMenuItem.Rating);
                Console.WriteLine("____________________________");
                Console.WriteLine();
            }

            return foodMenu;
        }
    }
}
