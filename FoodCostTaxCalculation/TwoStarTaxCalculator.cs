using FoodDeliveryApp.Utils;

namespace FoodDeliveryApp.FoodCostTaxCalculation
{
    public class TwoStarTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double price, double localTax, bool imported)
        {
            double tax = price * localTax;

            if (imported)
                tax += (price * 1.5);

            //rounds off to nearest 0.05;
            tax = TaxUtil.RoundOff(tax);

            return tax;
        }
    }
}
