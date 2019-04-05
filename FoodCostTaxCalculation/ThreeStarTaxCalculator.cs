using FoodDeliveryApp.Utils;

namespace FoodDeliveryApp.FoodCostTaxCalculation
{
    public class ThreeStarTaxCalculator
    {
        public double CalculateTax(double price, double localTax, bool imported)
        {
            double tax = price * localTax;

            if (imported)
                tax += (price * 2.5);

            //rounds off to nearest 0.05;
            tax = TaxUtil.RoundOff(tax);

            return tax;
        }
    }
}
