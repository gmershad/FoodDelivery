using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryApp.FoodDeliveryDriver
{
    public class MealSelectorDriver
    {
        public List<FoodMenuModel> MealSelectionbyUser(List<FoodMenuModel> foodMenu)
        {
            //Meal Selector.

            Console.WriteLine(string.Empty);
            Console.WriteLine("Please select the food items");
            Console.WriteLine("_________________________");

            List<FoodMenuModel> selectedMealItems = new List<FoodMenuModel>();
            char answer;
            do
            {
                Console.WriteLine("Enter food Id:");
                var foodId = Console.ReadLine();
                var foodItem = foodMenu.FirstOrDefault(e => e.FoodId == foodId);
                if (foodItem != null)
                {
                    Console.WriteLine("You Selected Below food Item:");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Name: {0}", foodItem.FoodName);
                    Console.WriteLine("Rate(Rs.): {0}", foodItem.Rate);
                    Console.WriteLine("Rating: {0}", foodItem.Rating);
                    selectedMealItems.Add(foodItem);
                }
                else
                    Console.WriteLine("Invalid Food Id Selected. No food Item available with this Id.");

                Console.WriteLine(string.Empty);

                Console.WriteLine("Do you want to add more food item(y/n):...?");
                answer = Console.ReadKey().KeyChar;
                Console.WriteLine(string.Empty);

            } while (answer != 'n');

            return selectedMealItems;
        }
    }
}
