namespace FoodDeliveryApp.OrderAndCancellation
{
    public class CancelFood : IFoodOrderCommands
    {
        private readonly Food food;
        public string OrderId;

        public CancelFood(Food food)
        {
            this.food = food;
        }

        public void Execute()
        {
            food.CancelFood(OrderId);
        }
    }
}
