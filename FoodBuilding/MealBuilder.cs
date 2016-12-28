using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Ordering
{
    public class MealBuilder
    {
        public Meal meal;
        public void PrepareMeal(List<FoodMenuModel> foodMenu)
        {
            meal = new Meal();
            meal.AddFoodItem(foodMenu);
        }
    }
}
