using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalHouseEntities;
using AnimalHousePersistence;

namespace AnimalHouseUnitTest
{
    [TestClass]
    public class SaleUnitTest
    {
        static Customer customer = CustomerFactory.Instance().CreateCustomer(1, "", "", "", "", false, 0);
        Sale sale = new Sale(customer, DateTime.Now);

        [TestMethod]
        public void PriceTestMethod()
        {
            decimal total = sale.Price();
            Assert.AreEqual(25, total);
        }

        [TestMethod]
        public void MomsTestMethod()
        {
            decimal momsPrice = sale.Moms();
            Assert.AreEqual(6.25m, momsPrice);
        }

        [TestMethod]
        public void TotalPriceInkMomsTestMethod()
        {
            decimal totalPriceInkMoms = sale.TotalPriceInkMoms();
            Assert.AreEqual(31.25m, totalPriceInkMoms);
        }
    }
}
