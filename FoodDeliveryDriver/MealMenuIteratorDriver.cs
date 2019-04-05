using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.RestaurantFoodMenu;
using System.Collections.Generic;

namespace FoodDeliveryApp.FoodDeliveryDriver
{
    /// <summary>
    /// This driver called - Iterator Pattern.
    /// </summary>
    public class MealMenuIteratorDriver
    {
        public List<FoodMenuModel> PrintMealMenu(string restaurantId)
        {
            Waitress waitress = new Waitress(restaurantId);
            var foodMenu = waitress.PrintFoodMenu();
            return foodMenu;
        }
    }
}
