using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalHouseEntities;
using AnimalHousePersistence;

namespace AnimalHouseUnitTest
{
    [TestClass]
    public class AnimalUnitTest
    {
        CustomerManager customerManager = new CustomerManager();
        AnimalManager animalManager = new AnimalManager();
        //Animal animal;



        [TestMethod]
        public void CreateAnimalTestMethod()
        {

            Customer customer = customerManager.GetCustomer(2628.ToString());
            Animal animal = AnimalFactory.Instance().CreateAnimal(customer, "basse", new DateTime(2014, 2, 12), new Species(1, "hund"), 32, false, null, true);
            Animal newanimal = animalManager.CreateAnimal(animal);
            Assert.AreNotEqual(0, animal.animalID);
            animal.UpdateID(newanimal.animalID);

        }

        [TestMethod]
        public void UpdateAnimalTestMethod()
        {
            Customer customer = customerManager.GetCustomer(2628.ToString());
            Animal animal = AnimalFactory.Instance().CreateAnimal(customer,29, "basse", new DateTime(2014, 2, 12), new Species(1, "hund"), 32, false, null, true);

            string result = animalManager.UpdateAnimal(animal);
            Assert.AreEqual("ok", result);
        }

        [TestMethod]
        public void DeleteAnimalTestMethod()
        {
            Customer customer = customerManager.GetCustomer(2628.ToString());
            Animal animal = AnimalFactory.Instance().CreateAnimal(customer, 29, "basse", new DateTime(2014, 2, 12), new Species(1, "hund"), 32, false, null, true);

            string result = animalManager.DeleteAnimal(animal);
            Assert.AreEqual("ok", result);
        }
    }
}
