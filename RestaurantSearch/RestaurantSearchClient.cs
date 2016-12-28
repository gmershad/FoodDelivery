using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.RestaurantWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.RestaurantSearch
{
    public class RestaurantSearchClient
    {
        private InterpreterContext context;

        public RestaurantSearchClient(InterpreterContext context)
        {
            this.context = context;
        }

        public List<RestaurantModel> Intercept(string expression)
        {
            AbstractExpression queryExpression = null;
            String[] stringParts = expression.Split(' ');
            String searchType = stringParts[0];
            String searchAttribute = stringParts[2];

            var startIndex = expression.IndexOf("'");
            var lastIndex = expression.LastIndexOf("'");
            var length = expression.Length;
            String query = expression.Substring(startIndex+1, lastIndex - startIndex-1);

            if (searchType.Equals("restaurant") && searchAttribute.Equals("location"))
                queryExpression = new RestaurantLocationExpression(query);

            if (queryExpression != null)
                return queryExpression.Interpret(this.context);

            return null;
        }
    }
}
