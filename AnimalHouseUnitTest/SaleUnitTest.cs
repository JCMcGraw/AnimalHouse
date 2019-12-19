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
        Sale sale = SaleFactory.Instance().CreateSale(customer, DateTime.Now);
        



        [TestMethod]
        public void PriceTestMethod()
        {
            SaleLineItem saleLineItem= SaleLineItemFactory.Instance().CreateSaleLineItem(null, 1, 5, 50, null, null);
            sale.AddSaleLineItem(saleLineItem);

            decimal total = sale.Price();
            Assert.AreEqual(250, total);
        }

        [TestMethod]
        public void MomsTestMethod()
        {
            SaleLineItem saleLineItem = SaleLineItemFactory.Instance().CreateSaleLineItem(null, 1, 5, 50, null, null);
            sale.AddSaleLineItem(saleLineItem);

            decimal momsPrice = sale.Moms();
            Assert.AreEqual(62.50m, momsPrice);
        }

        [TestMethod]
        public void TotalPriceInkMomsTestMethod()
        {
            SaleLineItem saleLineItem = SaleLineItemFactory.Instance().CreateSaleLineItem(null, 1, 5, 50, null, null);
            sale.AddSaleLineItem(saleLineItem);

            decimal totalPriceInkMoms = sale.TotalPriceInkMoms();
            Assert.AreEqual(312.50m, totalPriceInkMoms);
        }
    }
}
