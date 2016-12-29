using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.OrderAndCancellation;
using FoodDeliveryApp.Ordering;
using FoodDeliveryApp.RestaurantFoodMenu;
using FoodDeliveryApp.RestaurantSearch;
using FoodDeliveryApp.Tracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FoodDeliveryApp.FoodDeliveryDriver;

namespace FoodDeliveryApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region User Searches Restaurant

            //User Searches Restaurant.
            RestaurantSearchDriver restaurantSearchDriver = new RestaurantSearchDriver();
            var restaurantId = restaurantSearchDriver.RestaurantSearch();

            #endregion

            #region User Sees Food Menu

            //User sees Food Menu Items based on the selected Restaurant Id.
            MealMenuIteratorDriver mealMenuIteratorDriver = new MealMenuIteratorDriver();
           var foodMenu = mealMenuIteratorDriver.PrintMealMenu(restaurantId);

            #endregion

            #region User Selects Meal

            //Meal Selector.
            MealSelectorDriver mealSelectorDriver = new MealSelectorDriver();
            var selectedMealItems = mealSelectorDriver.MealSelectionbyUser(foodMenu);

            #endregion

            #region Restaurant Builds Meal

            //Calling Meal Builder
            MealBuilderDriver mealBuilderDriver = new MealBuilderDriver();
            var totalCost = mealBuilderDriver.BuildMealForUser(selectedMealItems);

            #endregion

            #region User Orders Food

            //Order Food
            string orderId = string.Empty;
            UserModel user = null;
            MealOrderDriver mealOrderDriver = new MealOrderDriver();
            var cancel = mealOrderDriver.MealOrderByUser(selectedMealItems, totalCost, restaurantId, out orderId, out user);

            #endregion

            #region User Tracks Order

            //Order Tracking.
            OrderTrackingDriver orderTrackingDriver = new OrderTrackingDriver();
            orderTrackingDriver.OrderTrackingByUser(restaurantId, orderId, user, cancel);

            #endregion

            Console.ReadKey();
        }
    }
}
