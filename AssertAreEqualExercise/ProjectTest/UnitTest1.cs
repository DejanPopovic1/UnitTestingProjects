using NUnit.Framework;
using SoftwareRegressionPrinciple;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<decimal> initialisedData = new List<decimal>() {
                0.5m,
                0.72m,
                0.32m,
                0.78m,
                9.10m
            };
            List<decimal> expectedDiscountedList = new List<decimal>() {
                0.45m,
                0.648m,
                0.288m,
                0.702m,
                8.19m
            };
            MyCheckoutList checkoutList = new MyCheckoutList();
            checkoutList.SetValues(initialisedData);
            //TODO: Insert your code below
            Assert.AreEqual(checkoutList.CheckoutPrices, initialisedData);
            Assert.AreEqual(checkoutList.DiscountedCheckoutPrices, expectedDiscountedList);
        }
    }
}