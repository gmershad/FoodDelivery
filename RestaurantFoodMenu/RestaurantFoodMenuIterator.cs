using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.FoodMenu;
using System.Collections.Generic;

namespace FoodDeliveryApp.RestaurantFoodMenu
{
    public class RestaurantFoodMenuIterator : IIterator
    {
        readonly List<FoodMenuModel> foodItems;
        int position;

        public RestaurantFoodMenuIterator(List<FoodMenuModel> foodItems)
        {
            this.foodItems = foodItems;
        }

        public bool HasNext() {
            if (position >= foodItems.Count || foodItems[position] == null)
                return false;
            return true;
        }

        public object Next()
        {
            FoodMenuModel menuItem = foodItems[position];
            position = position + 1;
            return menuItem;
        }
    }
}
