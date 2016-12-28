using FoodDeliveryApp.FoodMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantFoodMenu
{
   public interface IFoodMenu
    {
       IIterator CreateFoodMenuIterator();
    }
}
