using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalHousePersistence;
using AnimalHouseEntities;

namespace AnimalHouseUnitTest
{
    [TestClass]
    public class TreatmentUnitTest
    {
        static TreatmentType treatmentType = TreatmentTypeFactory.Instance().CreateTreatmentType(1, "hej");
        static OperationRoom operationRoom = OperationRoomFactory.Instance().CreateOperationRoom(1);
        static Species species = SpeciesFactory.Instance().CreateSpecies(1,"Hund");
        static Cage cage = CageFactory.Instance().CreateCage(1,species);
        static Item item = ItemFactory.Instance().CreateItem(6, "hej", 3, 50, 40, true, true, true);
        static Customer customer = CustomerFactory.Instance().CreateCustomer("hans","Vejvej","+4553595754","Hejsa@gmail.com",false, 0);
        static Animal animal = AnimalFactory.Instance().CreateAnimal(customer,3,"hej",DateTime.Now,species,100,true,employee,false);
        static Employee employee = EmployeeFactory.Instance().CreateEmployee(1,"jens",false,new Title("",1));
        
        static int treatmentID = 0;

        [TestMethod]
        public void CreateTreatmentTestMethod()
        {
            Treatment treatment = TreatmentFactory.Instance().CreateTreatment(treatmentType, operationRoom, cage, item, DateTime.Now, DateTime.Now, true, "", true, animal, employee,0);

            TreatmentManager treatmentManager = new TreatmentManager();
            Treatment treatmentt = treatmentManager.CreateTreatment(treatment);
            Assert.AreNotEqual(0,treatmentt.treatmentID);
            treatmentID = treatment.treatmentID;
        }

        [TestMethod]
        public void UpdateTreatment()
        {
            Treatment treatment = TreatmentFactory.Instance().CreateTreatment(treatmentType, operationRoom, cage, item, DateTime.Now, DateTime.Now, true, "", true, animal, employee, 0);

            TreatmentManager treatmentManager = new TreatmentManager();
            string treatmentt = treatmentManager.UpdateTreatment(treatment);
            Assert.AreEqual("ok",treatmentt);
        }

        [TestMethod]
        public void DeleteTreatment()
        {
            Treatment treatment = TreatmentFactory.Instance().CreateTreatment(treatmentType, operationRoom, cage, item, DateTime.Now, DateTime.Now, true, "", true, animal, employee, 0);

            TreatmentManager treatmentManager = new TreatmentManager();
            string treatmentt = treatmentManager.DeleteTreatment(treatmentID);
            Assert.AreNotEqual("OK",treatmentt);
        }
    }
}
