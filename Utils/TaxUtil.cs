namespace FoodDeliveryApp.Utils
{
    public class TaxUtil
    {
        private const double ROUND_OFF = 0.05;

        /// <summary>
        /// Rounds off a double value to the nearest 0.05
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double RoundOff(double value)
        {
            return (int)(value / ROUND_OFF + 0.5) * 0.05;
        }
    }
}
