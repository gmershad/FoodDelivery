using FoodDeliveryApp.FoodDeliveryAppModel;
using FoodDeliveryApp.RestaurantWebService;
using System;
using System.Collections.Generic;

namespace FoodDeliveryApp.RestaurantSearch
{
    public class RestaurantSearchClient
    {
        private readonly InterpreterContext context;

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

            var startIndex = expression.IndexOf("'", StringComparison.Ordinal);
            var lastIndex = expression.LastIndexOf("'", StringComparison.Ordinal);
            String query = expression.Substring(startIndex+1, lastIndex - startIndex-1);

            if (searchType.Equals("restaurant") && searchAttribute.Equals("location"))
                queryExpression = new RestaurantLocationExpression(query);

            if (queryExpression != null)
                return queryExpression.Interpret(this.context);

            return null;
        }
    }
}
