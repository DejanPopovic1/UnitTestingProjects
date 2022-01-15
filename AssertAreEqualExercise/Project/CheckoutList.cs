using System.Collections.Generic;

namespace SoftwareRegressionPrinciple
{
    public class MyCheckoutList
    {
        public List<decimal> CheckoutPrices = new List<decimal>();
        public List<decimal> DiscountedCheckoutPrices = new List<decimal>();

        public void DiscountList(List<decimal> l)
        {
            DiscountedCheckoutPrices = l;
            for (int i = 0; i < DiscountedCheckoutPrices.Count; i++)
            {
                DiscountedCheckoutPrices[i] *= 0.9m;
            }
        }

        public void SetValues(List<decimal> l)
        {
            CheckoutPrices = l;
            DiscountList(CheckoutPrices);
        }
    }
}
