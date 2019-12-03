﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalHousePersistence;
using AnimalHouseEntities;

namespace AnimalHouseUnitTest
{
    [TestClass]
    public class TreatmentUnitTest
    {
        static Employee employee = new Employee(1,"jens",false,1,new Title("",1));
        static Item item = new Item(6,"hej",3,50,40,true,true,true);
        static TreatmentType treatmentType = new TreatmentType(1,"hej");

        int treatmentID = 0;

        [TestMethod]
        public void CreateTreatmentTestMethod()
        {
            Treatment treatment = new Treatment(treatmentType, null, null, item, DateTime.Now, DateTime.Now, true, "", true, 3, employee);

            TreatmentManager treatmentManager = new TreatmentManager();
            Treatment treatmentt = treatmentManager.CreateTreatment(treatment);
            Assert.AreNotEqual(0,treatmentt.treatmentID);
            treatmentID = treatment.treatmentID;
        }

        [TestMethod]
        public void UpdateTreatment()
        {
            Treatment treatment = new Treatment(treatmentID,treatmentType, null, null, item, DateTime.Now, DateTime.Now, true, "", true, 3, employee);

            TreatmentManager treatmentManager = new TreatmentManager();
            string treatmentt = treatmentManager.UpdateTreatment(treatment);
            Assert.AreEqual("ok",treatmentt);
        }

        [TestMethod]
        public void DeleteTreatment()
        {
            Treatment treatment = new Treatment(treatmentID, treatmentType, null, null, item, DateTime.Now, DateTime.Now, true, "", true, 3, employee);

            TreatmentManager treatmentManager = new TreatmentManager();
            string treatmentt = treatmentManager.DeleteTreatment(treatmentID);
            Assert.AreNotEqual("OK",treatmentt);
        }

        //[TestMethod]
        //public void GetTreatment()
        //{
        //    Treatment treatment = new Treatment(treatmentID,treatmentType, 1, 1, item, DateTime.Now, DateTime.Now, true, "", true, 3, employee);

        //    TreatmentManager treatmentManager = new TreatmentManager();
        //    List<Treatment> treatmentt = treatmentManager.GetTreatment(treatmentID);
        //    Assert.AreEqual(treatmentt,);

        //}
    }
}