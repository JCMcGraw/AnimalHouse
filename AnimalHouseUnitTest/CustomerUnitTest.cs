using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalHouseEntities;
using AnimalHousePersistence;


namespace AnimalHouseUnitTest
{
    [TestClass]
    public class CustomerUnitTest
    {
        
        static Customer customer = CustomerFactory.Instance().CreateCustomer("hans", "Vejvej", "+4553595754", "Hejsa@gmail.com", true,0);

        [TestMethod]
        public void CreateCustomerTestMethod()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.CreateCustomer(customer);
        }

        [TestMethod]
        public void DeleteCustomerTestMethod()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.DeleteCustomer(customer);
        }

        [TestMethod]
        public void UpdateCustomerTestMethod()
        {
            Customer tmpcustomer= CustomerFactory.Instance().CreateCustomer("hans", "Vejvej", "+4553595754", "Hejsa2@gmail.com", true, 0);
            CustomerManager customerManager = new CustomerManager();
            customerManager.UpdateCustomer(customer);
        }
    }
}
