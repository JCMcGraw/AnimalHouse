using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalHousePersistence;
using AnimalHouseEntities;

namespace AnimalHouseUnitTest
{
    [TestClass]
    public class CustomerUnitTest
    {
      

        // public int customerID { get; private set; }
        static string name = "Testman";
        public string address = "Testvej";
        public string phone = "98745895";
        public string email = "test@mail.dk";
        public bool active = true;
        int customerID = 0;
        //public List<Animal> animals { get; private set; }

        [TestMethod]
        public void CreateCustomer()
        {
            Customer customer = new Customer(name, address, phone, email, active);

            CustomerManager customerManager = new CustomerManager();
            Customer customertmp = customerManager.CreateCustomer(customer);

            //customerID=customer.UpdateID()
            //Assert.AreNotEqual(0, treatmentt.treatmentID);
            //treatmentID = treatment.treatmentID;
        }
    }
}
