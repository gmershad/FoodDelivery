using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.FoodMenu;
using FoodDeliveryApp.RestaurantWebService;
using System.Collections.Generic;

namespace FoodDeliveryApp.RestaurantFoodMenu
{
    public class FoodMenu : IFoodMenu
    {
        private readonly string restaurantId;

        public FoodMenu(string restaurantId)
        {
            this.restaurantId = restaurantId;
        }

        public List<FoodMenuModel> GetFoodMenuItems()
        {
            FoodMenuService foodMenuService = new FoodMenuService(string.Empty, restaurantId);
           var foodMenuItems = foodMenuService.getAllFoodMenu(restaurantId);

            return foodMenuItems;
        }

        public IIterator CreateFoodMenuIterator()
        {
            var foodMenuItems = GetFoodMenuItems();
            return new RestaurantFoodMenuIterator(foodMenuItems);
        }
    }
}
