using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public class AnimalManager : IAnimalManager
    {
        
        

        //Species species;
        public Animal CreateAnimal(Animal animal)

        {
            string query = Utility.ReadSQLQueryFromFile("CreateAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@customerid", animal.customer.customerID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@species", animal.Species.speciesid.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@birthday", animal.birthday.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);
            sQLQuery.AddParameter("@name", animal.name.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@weight", animal.weight.ToString(), SqlDbType.Float);
            sQLQuery.AddParameter("@gender", animal.gender.ToString(), SqlDbType.Bit);
            sQLQuery.AddParameter("@active", "True", SqlDbType.Bit);
            sQLQuery.AddParameter("@employeeid", animal.Employee.employeeID.ToString(), SqlDbType.Int);


            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            int animalID = (int)sQLQueryResult.dataTable.Rows[0]["AnimalID"];

            animal.UpdateID(animalID);

            return animal;
           
           



        }
        



        public string UpdateAnimal(Animal animal)
        {
            string query = Utility.ReadSQLQueryFromFile("UpdateAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalID", animal.animalID.ToString(), SqlDbType.Int);
            //sQLQuery.AddParameter("@birthday", animal.birthday.ToString(), SqlDbType.VarChar);
            //sQLQuery.AddParameter("@species", animal.Species.speciesid.ToString(), SqlDbType.Int);
            //sQLQuery.AddParameter("@gender", animal.gender.ToString(), SqlDbType.Char);
            sQLQuery.AddParameter("@employeeid", animal.Employee.employeeID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@weight", animal.weight.ToString(), SqlDbType.VarChar);
          


            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);



            if (sQLQueryResult.code == 0)
            {
                return "Dyr rettet";
            }
            else
            {
                return sQLQueryResult.exception.Message.ToString();

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
                return "dyret er slettet fra kunden";
            }
            else
            {

            }
            return sQLQueryResult.exception.Message.ToString();


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

            int employeeID = (int)sQLQueryResult.dataTable.Rows[0]["SpeciesID"];

            Employee employee = EmployeeFactory.Instance().GetEmployee(employeeID, name);

            Animal animal = new Animal(customer,(int)dataRow["AnimalID"], (string)dataRow["Name"], (DateTime)dataRow["BirthYear"], species, (double)dataRow["Weight"], (bool)dataRow["Gender"], employee, (bool)dataRow["Active"]);

            return animal;

        }
        public List<Animal> GetAnimalList(SQLQueryResult sQLQueryResult)
        {
            List<Animal> animals = new List<Animal>();

            {
               // string query = Utility.ReadSQLQueryFromFile("GetManyAnimalsByCustomerID.txt");

                //SQLQuery sQLQuery = new SQLQuery(query);

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


                        employee = EmployeeFactory.Instance().CreateEmployee(employeeID, employeeName, employeeActive, titleID, title);
                    }


                    int CustomerID = (int)sQLQueryResult.dataTable.Rows[i]["CustomerID"];
                    string customerName = (string)sQLQueryResult.dataTable.Rows[i]["customername"];
                    string customeradress = (string)sQLQueryResult.dataTable.Rows[i]["Adress"];
                    string customerphone = (string)sQLQueryResult.dataTable.Rows[i]["Phone"];
                    string customeremail = (string)sQLQueryResult.dataTable.Rows[i]["Email"];
                    bool customeractive = (bool)sQLQueryResult.dataTable.Rows[i]["Active"];
                    Customer customer = CustomerFactory.Instance().CreateCustomer(CustomerID,customerName,customeradress,customerphone,customeremail,customeractive,0);
                    int animalID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalID"];
                    string name = (string)sQLQueryResult.dataTable.Rows[i]["Name"];
                    DateTime birthday = (DateTime)sQLQueryResult.dataTable.Rows[i]["BirthYear"];
                    int speciesID = (int)sQLQueryResult.dataTable.Rows[i]["Speciesid"];
                    string speciesName =(string)sQLQueryResult.dataTable.Rows[i]["SpeciesName"];
                    Species species = SpeciesFactory.Instance().CreateSpecies(speciesID, speciesName);

                    double weight =Convert.ToDouble( (decimal)sQLQueryResult.dataTable.Rows[i]["Weight"]);
                    bool gender = (bool)sQLQueryResult.dataTable.Rows[i]["Gender"];

                    //int employeeID = (int)sQLQueryResult.dataTable.Rows[i]["employeeID"];
                    
                    bool active = (bool)sQLQueryResult.dataTable.Rows[i]["Active"];

                    animals.Add(AnimalFactory.Instance().CreateAnimal(customer,animalID, name, birthday, species, weight, gender,employee, true));



                }
                return animals;
            }
        }

        public List<Animal> GetManyAnimalByCustomerID(Customer customer)
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyAnimalsByCustomerID.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@CustomerID", customer.customerID.ToString(), SqlDbType.VarChar);
           
            

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Animal> animals = new List<Animal>();

            animals = GetAnimalList(sQLQueryResult);

            return animals;
        }

        public List<Species> GetSpecies(SQLQueryResult sQLQueryResult)
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

        public List<string> GetAllJounalEntriesByAnimalID(Animal animal)
        {
            

            string query = Utility.ReadSQLQueryFromFile("GetAllJounalEntriesByAnimalID");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalid", animal.animalID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<string> entries = new List<string>();

            entries = GetJournalList(sQLQueryResult);

            return entries;
        }

        public List<string>GetJournalList(SQLQueryResult sQLQueryResult)
        {
            List<string> entries = new List<string>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                entries.Add((string)sQLQueryResult.dataTable.Rows[i]["Entry"]);
            }
            return entries;
        }

        public void CreateMedicalRecordEntry(MedicalRecord medicalRecord)
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

            medicalRecord.UpdateMedicalRecordID(medicalrecordID);
        }

        public List<Prescription> GetAllPrescriptionByAnimal(int animalID)
        {
            string query = Utility.ReadSQLQueryFromFile("GetAllPrescriptionByAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalID", animalID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Prescription> prescription = new List<Prescription>();
            prescription = GetAllPrescriptionList(sQLQueryResult);

            return prescription;
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
                    employee = EmployeeFactory.Instance().CreateEmployee(employeeID, name, true, titleID, title);
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
                    int cvr = 0; //(int)sQLQueryResult.dataTable.Rows[i]["CVR"];
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
                prescriptionID = (int)sQLQueryResult.dataTable.Rows[i]["PrescriptionID"];

                prescriptions.Add(PrescriptionFactory.Instance().CreatePrescription(prescriptionID, amount, prescriptionDay,employee, animal, item));
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

            int prescriptionID = (int)sQLQueryResult.dataTable.Rows[0]["PrescriptionID"];

            prescription.UpdateID(prescriptionID);

            return prescription;
        }
    }
}

