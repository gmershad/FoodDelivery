using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantSearch
{
    public class RestaurantSearchDriver
    {
        public string RestaurantSearch()
        {
            InterpreterContext context = new InterpreterContext("Some API");
            RestaurantSearchClient client = new RestaurantSearchClient(context);

            var result = client.Intercept("restaurant by location 'JP Nagar'");
            if (!result.Any()) Console.WriteLine("Sorry, No Restaurants available in this location.");

            Console.WriteLine("List of Restaurants");
            Console.WriteLine("*******************");

            foreach (var item in result)
            {
                Console.WriteLine(" ");
                Console.WriteLine("{0} {1}", item.RestaurantId, item.Name);
                Console.WriteLine("{0}", item.Address);
                int rating = item.Rating;
                Console.Write("Rating: ");
                while (rating > 0)
                {
                    Console.Write("*");
                    rating--;
                }

                Console.WriteLine("");
                Console.WriteLine("_________________________________");
            }

            Console.WriteLine();
            Console.WriteLine("Please Select Restaurant by Id: ");
            var restaurantId = Console.ReadLine();
            return restaurantId;
        }
    }
}
