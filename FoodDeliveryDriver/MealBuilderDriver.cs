using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.Ordering;
using System;
using System.Collections.Generic;
using FoodDeliveryApp.FoodCostTaxCalculation;

namespace FoodDeliveryApp.FoodDeliveryDriver
{
    public class MealBuilderDriver
    {
        /// <summary>
        /// This driver called that module which followed Builder Design Pattern
        /// </summary>
        /// <param name="selectedMealItems"></param>
        /// <returns></returns>
        public double BuildMealForUser(List<FoodMenuModel> selectedMealItems)
        {
            Console.WriteLine();
            Console.WriteLine("You Selected Below Meal Items");
            Console.WriteLine("_______________________________");
            MealBuilder mealBuilder = new MealBuilder();
            mealBuilder.PrepareMeal(selectedMealItems);
            mealBuilder.meal.ShowItems();
            var foodCost = mealBuilder.meal.GetCost();
            
            //Calculation of Tax
            var taxCalculationContext = new TaxCalculationContext(new OneStarTaxCalculator());
            var taxAmount = taxCalculationContext.GetCalculatedTax(foodCost, 0.05, false);
            var totalCostofFood = foodCost + taxAmount;
            Console.WriteLine("Total Cost(Rs.): {0}", totalCostofFood);
            Console.WriteLine("Total Tax(Rs.): {0}", taxAmount);
            return totalCostofFood;
        }
    }
}
