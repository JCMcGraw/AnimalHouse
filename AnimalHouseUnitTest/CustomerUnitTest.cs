using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalHouseEntities;
using AnimalHousePersistence;


namespace AnimalHouseUnitTest
{
    [TestClass]
    public class CustomerUnitTest
    {

        static Random random = new Random();

        [TestMethod]
        public void CreateCustomerTestMethod()
        {
            Customer customer = CustomerFactory.Instance().CreateCustomer("hans", "Vejvej", random.Next(1000000, 10000000).ToString(), "Hejsa@gmail.com", true, 0);

            CustomerManager customerManager = new CustomerManager();
            customerManager.CreateCustomer(customer);
            Assert.AreNotEqual(0, customer.customerID);
        }

        [TestMethod]
        public void DeleteCustomerTestMethod()
        {

            Customer customer = CustomerFactory.Instance().CreateCustomer("hans", "Vejvej", "654", "Hejsa@gmail.com", true, 0);

            CustomerManager customerManager = new CustomerManager();
            
            string deleteCustomer= customerManager.DeleteCustomer(customer);
            Assert.AreEqual("Kunde gjort inaktiv", deleteCustomer);
        }

        [TestMethod]
        public void UpdateCustomerTestMethod()
        {
            Customer customer = CustomerFactory.Instance().CreateCustomer("hans", "Vejvej", "654", "Hejsa2@gmail.com", true, 0);
            CustomerManager customerManager = new CustomerManager();
           string updateCustomer= customerManager.UpdateCustomer(customer);
            Assert.AreEqual("Kunde rettet", updateCustomer);
        }
    }
}
