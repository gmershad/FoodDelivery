using FoodDeliveryApp.FoodMenu;

namespace FoodDeliveryApp.RestaurantFoodMenu
{
   public interface IFoodMenu
    {
       IIterator CreateFoodMenuIterator();
    }
}
