using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalHousePersistence;
using AnimalHouseEntities;

namespace AnimalHouseUnitTest
{
    [TestClass]
    public class SaleUnitTest
    {
        static Customer customer = new Customer(1,"","","","",false);
        Sale sale = new Sale(customer,DateTime.Now);

        [TestMethod]
        public void PriceTestMethod()
        {
            decimal total = sale.Price(5, 5);
            Assert.AreEqual(25, total);
        }

        [TestMethod]
        public void MomsTestMethod()
        {
            decimal momsPrice = sale.Moms(25);
            Assert.AreEqual(6.25m, momsPrice);
        }

        [TestMethod]
        public void TotalPriceInkMomsTestMethod()
        {
            decimal totalPriceInkMoms = sale.TotalPriceInkMoms(25,6.25m);
            Assert.AreEqual(31.25m, totalPriceInkMoms);
        }
    }
}
