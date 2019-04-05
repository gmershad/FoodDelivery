namespace FoodDeliveryApp.Tracking
{
    public class Restaurant : FoodDelivery
    {
        public Restaurant(string restaurantId, string orderId, string deliveryStatus) 
            : base(restaurantId, orderId, deliveryStatus) { }
    }
}
