﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public class AnimalManager: IAnimalManager
    {
        public Animal CreateAnimal(Animal animal)
        {
            string query = Utility.ReadSQLQueryFromFile("CreateAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@customerid", animal.customer.customerID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@species", animal.Species.speciesID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@birthday", animal.birthYear.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);
            sQLQuery.AddParameter("@name", animal.name.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@weight", animal.weight.ToString(), SqlDbType.Float);
            sQLQuery.AddParameter("@gender", animal.gender.ToString(), SqlDbType.Bit);
            sQLQuery.AddParameter("@active", "True", SqlDbType.Bit);

            if(animal.Employee == null)
            {
                sQLQuery.AddParameter("@employeeid", null, SqlDbType.Int);
            }
            else
            {
                sQLQuery.AddParameter("@employeeid", animal.Employee.employeeID.ToString(), SqlDbType.Int);
            }

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            int animalID = (int)sQLQueryResult.dataTable.Rows[0]["AnimalID"];
            animal.UpdateID(animalID);
            
            if (sQLQueryResult.code == 0)
            {
                return animal;
            }
            else
            {
                throw new AnimalNotCreatedException("", sQLQueryResult.exception);
            }
        }

        public string UpdateAnimal(Animal animal)
        {
            string query = Utility.ReadSQLQueryFromFile("UpdateAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalID", animal.animalID.ToString(), SqlDbType.Int);
            if (animal.Employee == null)
            {
                sQLQuery.AddParameter("@employeeid", null, SqlDbType.Int);
            }
            else
            {
                sQLQuery.AddParameter("@employeeid", animal.Employee.employeeID.ToString(), SqlDbType.Int);
            }
           
            sQLQuery.AddParameter("@weight", animal.weight.ToString(), SqlDbType.Decimal);
          
            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {
                return "ok";
            }
            else
            {
                throw new AnimalNotEditedException("",sQLQueryResult.exception);
            }
        }
        public string DeleteAnimal(Animal animal)
        {
            string query = Utility.ReadSQLQueryFromFile("DeleteAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalid", animal.animalID.ToString(), SqlDbType.Int);


            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {
                return "ok";
            }
            else
            {
                throw new AnimalNotDeletedException("", sQLQueryResult.exception);
            }
        }
        public Animal GetAnimal(int animalID)
        {
            string query = Utility.ReadSQLQueryFromFile("GetAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalid", animalID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            DataRow dataRow = sQLQueryResult.dataTable.Rows[0];

            int CustomerID = (int)sQLQueryResult.dataTable.Rows[0]["CustomerID"];
            string customerName = (string)sQLQueryResult.dataTable.Rows[0]["customername"];
            string customeradress = (string)sQLQueryResult.dataTable.Rows[0]["Adress"];
            string customerphone = (string)sQLQueryResult.dataTable.Rows[0]["Phone"];
            string customeremail = (string)sQLQueryResult.dataTable.Rows[0]["Email"];
            bool customeractive = (bool)sQLQueryResult.dataTable.Rows[0]["Active"];
            Customer customer = CustomerFactory.Instance().CreateCustomer(CustomerID, customerName, customeradress, customerphone, customeremail, customeractive, 0);

            string speciesName = sQLQueryResult.dataTable.Rows[0]["SpeciesName"].ToString();

            int speciesID = (int)sQLQueryResult.dataTable.Rows[0]["SpeciesID"];

            Species species = SpeciesFactory.Instance().CreateSpecies(speciesID, speciesName);

            string name = sQLQueryResult.dataTable.Rows[0]["SpeciesName"].ToString();

            int employeeID = (int)sQLQueryResult.dataTable.Rows[0]["EmployeeID"];

            Employee employee = EmployeeFactory.Instance().GetEmployee(employeeID, name);

            Animal animal = new Animal(customer,(int)dataRow["AnimalID"], (string)dataRow["Name"], (DateTime)dataRow["BirthYear"], species, (double)dataRow["Weight"], (bool)dataRow["Gender"], employee, (bool)dataRow["Active"]);

            return animal;
        }
        private List<Animal> GetAnimalList(SQLQueryResult sQLQueryResult)
        {
            List<Animal> animals = new List<Animal>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                Employee employee = null;
                if (sQLQueryResult.dataTable.Rows[i].IsNull("EmployeeID"))
                {
                }
                else
                {
                    string titleName = (string)sQLQueryResult.dataTable.Rows[i]["TitleName"];
                    int titleID = (int)sQLQueryResult.dataTable.Rows[i]["TitleID"];
                    Title title = TitleFactory.Instance().CreateTitle(titleName, titleID);

                    string employeeName = (string)sQLQueryResult.dataTable.Rows[i]["EmployeeName"];
                    int employeeID = (int)sQLQueryResult.dataTable.Rows[i]["EmployeeID"];
                    bool employeeActive = (bool)sQLQueryResult.dataTable.Rows[i]["EmployeeActive"];

                    employee = EmployeeFactory.Instance().CreateEmployee(employeeID, employeeName, employeeActive, title);
                }
                int CustomerID = (int)sQLQueryResult.dataTable.Rows[i]["CustomerID"];
                string customerName = (string)sQLQueryResult.dataTable.Rows[i]["customername"];
                string customeradress = (string)sQLQueryResult.dataTable.Rows[i]["Adress"];
                string customerphone = (string)sQLQueryResult.dataTable.Rows[i]["Phone"];
                string customeremail = (string)sQLQueryResult.dataTable.Rows[i]["Email"];
                bool customeractive = (bool)sQLQueryResult.dataTable.Rows[i]["Active"];
                Customer customer = CustomerFactory.Instance().CreateCustomer(CustomerID, customerName, customeradress, customerphone, customeremail, customeractive, 0);
                int animalID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalID"];
                string name = (string)sQLQueryResult.dataTable.Rows[i]["Name"];
                DateTime birthday = (DateTime)sQLQueryResult.dataTable.Rows[i]["BirthYear"];
                int speciesID = (int)sQLQueryResult.dataTable.Rows[i]["Speciesid"];
                string speciesName = (string)sQLQueryResult.dataTable.Rows[i]["SpeciesName"];
                Species species = SpeciesFactory.Instance().CreateSpecies(speciesID, speciesName);
                double weight = Convert.ToDouble((decimal)sQLQueryResult.dataTable.Rows[i]["Weight"]);
                bool gender = (bool)sQLQueryResult.dataTable.Rows[i]["Gender"];
                bool active = (bool)sQLQueryResult.dataTable.Rows[i]["Active"];

                animals.Add(AnimalFactory.Instance().CreateAnimal(customer, animalID, name, birthday, species, weight, gender, employee, true));
            }
            return animals;
        }

        public List<Animal> GetManyAnimalByCustomerID(Customer customer)
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyAnimalsByCustomerID.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@CustomerID", customer.customerID.ToString(), SqlDbType.VarChar);
           
            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {
                List<Animal> animals = new List<Animal>();
                animals = GetAnimalList(sQLQueryResult);
                return animals;
            }
            else
            {
                throw new CantGetAnimalList("", sQLQueryResult.exception);
            }
        }
        private List<Species> GetSpecies(SQLQueryResult sQLQueryResult)
        {
            List<Species> species = new List<Species>();
            {
                for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
                {
                    int speciesID = (int)sQLQueryResult.dataTable.Rows[i]["SpeciesID"];
                    string speciesName = (String)sQLQueryResult.dataTable.Rows[i]["SpeciesName"];

                    species.Add(SpeciesFactory.Instance().CreateSpecies(speciesID, speciesName));
                }
                return species;
            }
        }
        public List<Species> GetAllSpecies()
        {
            string query = Utility.ReadSQLQueryFromFile("GetSpecies.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Species> allspecies = new List<Species>();

            allspecies = GetSpecies(sQLQueryResult);

            return allspecies;
        }
        public List<MedicalRecord> GetAllMedicalRecordEntriesByAnimalID(Animal animal)
        {
            string query = Utility.ReadSQLQueryFromFile("GetAllMedicalRecordByAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalid", animal.animalID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<MedicalRecord> entries = new List<MedicalRecord>();

            entries = GetMedicalRecordEntryList(animal, sQLQueryResult);

            if (sQLQueryResult.code == 0)
            {
                return entries;
            }
            else
            {
                throw new MedicalRecordEntryNotFoundException("", sQLQueryResult.exception);
            } 
        }
        private List<MedicalRecord> GetMedicalRecordEntryList(Animal animal,SQLQueryResult sQLQueryResult)
        {
            List<MedicalRecord> entries = new List<MedicalRecord>();
          
            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                string entry = (string)sQLQueryResult.dataTable.Rows[i]["Entry"];
                int MedicalRecordID = (int)sQLQueryResult.dataTable.Rows[i]["MedicalRecordID"];
                int TreatmentID = (int)sQLQueryResult.dataTable.Rows[i]["TreatmentID"];
                DateTime StartTime = (DateTime)sQLQueryResult.dataTable.Rows[i]["StartTime"];
                DateTime EndTime = (DateTime)sQLQueryResult.dataTable.Rows[i]["EndTime"];
                bool Payed = (bool)sQLQueryResult.dataTable.Rows[i]["Payed"];
                string Headline = (string)sQLQueryResult.dataTable.Rows[i]["Headline"];
                bool Active = (bool)sQLQueryResult.dataTable.Rows[i]["Active"];
                int Status = (int)sQLQueryResult.dataTable.Rows[i]["Status"];

                Treatment treatment = TreatmentFactory.Instance().CreateTreatment(TreatmentID,null, null, null, null, StartTime, EndTime, Payed, Headline, Active, animal, null, Status);

                MedicalRecord medicalRecord = MedicalRecordFactory.Instance().CreateMedicalRecord(MedicalRecordID, entry, animal, treatment);
                entries.Add(medicalRecord);
              
            }
            return entries;
        }

        public MedicalRecord CreateMedicalRecordEntry(MedicalRecord medicalRecord)
        {
            Animal animal = medicalRecord.animal;
            Treatment treatment = medicalRecord.treatment;

            string query = Utility.ReadSQLQueryFromFile("CreateMedicalRecordEntry.txt");
            SQLQuery sQLQuery = new SQLQuery(query);
           
            sQLQuery.AddParameter("@entry", medicalRecord.entry.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@animalID", animal.animalID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@treatmentID", treatment.treatmentID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);
            int medicalrecordID = (int)sQLQueryResult.dataTable.Rows[0]["MedicalRecordID"];

            if (sQLQueryResult.code!=0)
            {
                throw new CantUpdateTreatmentException("", sQLQueryResult.exception);
            }
            medicalRecord.UpdateMedicalRecordID(medicalrecordID);
            return medicalRecord;
        }

        public List<Prescription> GetAllPrescriptionByAnimal(int animalID)
        {
            string query = Utility.ReadSQLQueryFromFile("GetAllPrescriptionByAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalID", animalID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Prescription> prescription = new List<Prescription>();
            prescription = GetAllPrescriptionList(sQLQueryResult);

            if (sQLQueryResult.code == 0)
            {
                return prescription;
            }
            else
            {
                throw new PrescriptionNotFoundException("", sQLQueryResult.exception);
            }
        }
        
        private List<Prescription> GetAllPrescriptionList(SQLQueryResult sQLQueryResult)
        {
            List<Prescription> prescriptions = new List<Prescription>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                int prescriptionID;
                Employee employee;
                Animal animal;
                Item item;
                Title title;

                if (sQLQueryResult.dataTable.Rows[i].IsNull("EmployeeID"))
                {
                    employee = null;
                }
                else
                {
                    int employeeID = (int)sQLQueryResult.dataTable.Rows[i]["EmployeeID"];
                    string name = (string)sQLQueryResult.dataTable.Rows[i]["Employeename"];
                    int titleID = (int)sQLQueryResult.dataTable.Rows[i]["TitleID"];
                    string titleName = (string)sQLQueryResult.dataTable.Rows[i]["TitleName"];

                    title = TitleFactory.Instance().CreateTitle(titleName, titleID);
                    employee = EmployeeFactory.Instance().CreateEmployee(employeeID, name, true, title);
                }

                if (sQLQueryResult.dataTable.Rows[i].IsNull("AnimalID"))
                {
                    animal = null;
                }
                else
                {
                    int customerID = (int)sQLQueryResult.dataTable.Rows[i]["CustomerID"];
                    string nameCustomer = (string)sQLQueryResult.dataTable.Rows[i]["CustomerName"];
                    string address = (string)sQLQueryResult.dataTable.Rows[i]["Adress"];
                    string phone = (string)sQLQueryResult.dataTable.Rows[i]["Phone"];
                    string email = (string)sQLQueryResult.dataTable.Rows[i]["Email"];
                    bool activeCustomer = (bool)sQLQueryResult.dataTable.Rows[i]["CustomerActive"];
                    int cvr = 0; 
                    string name = (string)sQLQueryResult.dataTable.Rows[i]["AnimalName"];
                    DateTime birthYear = (DateTime)sQLQueryResult.dataTable.Rows[i]["BirthYear"];
                    int speciesID = (int)sQLQueryResult.dataTable.Rows[i]["SpeciesID"];
                    string nameSpecies = (string)sQLQueryResult.dataTable.Rows[i]["SpeciesName"];
                    double weight = Convert.ToDouble((decimal)sQLQueryResult.dataTable.Rows[i]["Weight"]);
                    bool gender = (bool)sQLQueryResult.dataTable.Rows[i]["Gender"];
                    bool activeAnimal = (bool)sQLQueryResult.dataTable.Rows[i]["AnimalActive"];

                    Species species = SpeciesFactory.Instance().CreateSpecies(speciesID, nameSpecies);
                    Customer customer = CustomerFactory.Instance().CreateCustomer(customerID,nameCustomer,address,phone,email,activeCustomer,cvr);

                    animal = AnimalFactory.Instance().CreateAnimal(customer, name, birthYear, species, weight, gender, employee, activeAnimal);
                }

                if (sQLQueryResult.dataTable.Rows[i].IsNull("ItemID"))
                {
                    item = null;
                }
                else
                {
                    int itemID = (int)sQLQueryResult.dataTable.Rows[i]["ItemID"];
                    string name = (string)sQLQueryResult.dataTable.Rows[i]["ItemName"];
                    decimal price = (decimal)sQLQueryResult.dataTable.Rows[i]["ItemPrice"];
                    decimal costPrice = (decimal)sQLQueryResult.dataTable.Rows[i]["CostPrice"];
                    int amountItem = (int)sQLQueryResult.dataTable.Rows[i]["ItemAmount"];
                    bool prescription = (bool)sQLQueryResult.dataTable.Rows[i]["Prescription"];
                    bool treatment = (bool)sQLQueryResult.dataTable.Rows[i]["ItemTreatment"];
                    bool itemActive = (bool)sQLQueryResult.dataTable.Rows[i]["ItemActive"];

                    item = ItemFactory.Instance().CreateItem(itemID, name, amountItem, price, costPrice, prescription, treatment, itemActive);
                }

                int amount = (int)sQLQueryResult.dataTable.Rows[i]["Amount"];
                DateTime prescriptionDay = (DateTime)sQLQueryResult.dataTable.Rows[i]["PrescriptionDay"];
                bool payed = (bool)sQLQueryResult.dataTable.Rows[i]["Payed"];
                prescriptionID = (int)sQLQueryResult.dataTable.Rows[i]["PrescriptionID"];

                prescriptions.Add(PrescriptionFactory.Instance().CreatePrescription(prescriptionID, amount, prescriptionDay,payed,employee, animal, item));
            }
            return prescriptions;
        }

        public Prescription CreatePrescription(Prescription prescription)
        {
            string query = Utility.ReadSQLQueryFromFile("CreatePrescription.txt");

            SQLQuery sQLQuery = new SQLQuery(query);
            
            sQLQuery.AddParameter("@amount", prescription.amount.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@employeeID", prescription.employee.employeeID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@animalID", prescription.animal.animalID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@itemID", prescription.item.itemID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@prescriptionDay", prescription.prescriptionDay.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if(sQLQueryResult.code!=0)
            {
                throw new CantCreatePrescription("", sQLQueryResult.exception);
            }

            int prescriptionID = (int)sQLQueryResult.dataTable.Rows[0]["PrescriptionID"];
            prescription.UpdateID(prescriptionID);

            return prescription;
        }

        public List<Prescription> GetUnpaidPrescriptionByCustomer(Customer customer)
        {
            string query = Utility.ReadSQLQueryFromFile("GetUnpaidPrescriptionsByCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@customerid", customer.customerID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {
                List<Prescription> prescription = new List<Prescription>();
                prescription = GetAllPrescriptionList(sQLQueryResult);
                return prescription;
            }
            else
            {
                throw new CantGetUnPaidPrescription("", sQLQueryResult.exception);
            }
        }
    }
}

