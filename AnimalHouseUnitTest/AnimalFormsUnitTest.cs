using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalHouseEntities;
using AnimalHousePersistence;

namespace AnimalHouseUnitTest
{
    [TestClass]
    class AnimalFormsUnitTest
    {
        CustomerManager customerManager = new CustomerManager();
        AnimalManager animalManager = new AnimalManager();
        Animal animal;

        

        [TestMethod]
        public void CreateAnimalTestMethod()
        {
             
            Customer customer = customerManager.GetCustomer(2628.ToString());
            animal = AnimalFactory.Instance().CreateAnimal(customer, "basse",new DateTime(2014,2,12),new Species(1,"hund"),32,false,null,true);
            animal = animalManager.CreateAnimal(animal);
            Assert.AreNotEqual(0, animal.animalID);
            
        }

        [TestMethod]
        public void UpdateCustomerTestMethod()
        {
            string result = animalManager.UpdateAnimal(animal);
            Assert.AreEqual("ok", result);
        }

        [TestMethod]
        public void DeleteCustomerTestMethod()
        {
            string result = animalManager.DeleteAnimal(animal);
            Assert.AreEqual("ok", result);
        }

       
    }
}
