using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Ordering
{
    public class Meal
    {
        private List<FoodMenuModel> foodItems = new List<FoodMenuModel>();

        public void AddFoodItem(List<FoodMenuModel> items)
        {
            foodItems.AddRange(items);
        }

        public double GetCost()
        {
            double cost = 0;

            foreach (var item in foodItems)
            {
                cost += item.Rate;
            }

            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in foodItems)
            {
                Console.WriteLine("Food Id: {0}", item.FoodId);
                Console.WriteLine("Food Name: {0}", item.FoodName);
                Console.WriteLine("Food Price: {0}", item.Rate);
                Console.WriteLine("Food Rating: {0}", item.Rating);
                Console.WriteLine("----------------------------");
            }
        }
    }
}
