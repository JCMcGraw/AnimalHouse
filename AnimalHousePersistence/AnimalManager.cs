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

            sQLQuery.AddParameter("@customerid", animal.customerID.ToString(), SqlDbType.Int);
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

            sQLQuery.AddParameter("@name", animal.name.ToString(), SqlDbType.VarChar);
            //sQLQuery.AddParameter("@birthday", animal.birthday.ToString(), SqlDbType.VarChar);
            //sQLQuery.AddParameter("@species", animal.Species.speciesid.ToString(), SqlDbType.Int);
            //sQLQuery.AddParameter("@gender", animal.gender.ToString(), SqlDbType.Char);
            sQLQuery.AddParameter("@employeeid", animal.Employee.employeeID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@weight", animal.weight.ToString(), SqlDbType.VarChar);
          


            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);



            if (sQLQueryResult.code == 0)
            {
                return "dyret er rettet";
            }
            else
            {

            }
            return "Fejl";
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
            return "FEJL";


        }
        public Animal GetAnimal(int animalID)
        {

            string query = Utility.ReadSQLQueryFromFile("GetAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalid", animalID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            DataRow dataRow = sQLQueryResult.dataTable.Rows[0];

            string speciesName = sQLQueryResult.dataTable.Rows[0]["SpeciesName"].ToString();

            int speciesID = (int)sQLQueryResult.dataTable.Rows[0]["SpeciesID"];

            Species species = SpeciesFactory.Instance().CreateSpecies(speciesID, speciesName);

            string name = sQLQueryResult.dataTable.Rows[0]["SpeciesName"].ToString();

            int employeeID = (int)sQLQueryResult.dataTable.Rows[0]["SpeciesID"];

            Employee employee = EmployeeFactory.Instance().GetEmployee(employeeID, name);

            Animal animal = new Animal((int)dataRow["CustomerID"],(int)dataRow["AnimalID"], (string)dataRow["Name"], (DateTime)dataRow["BirthYear"], species, (double)dataRow["Weight"], (bool)dataRow["Gender"], employee, (bool)dataRow["Active"]);

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
                   

                    int employeeID;
                    if (sQLQueryResult.dataTable.Rows[i].IsNull("EmployeeID"))
                    {
                        employeeID = -1;
                    }
                    else
                    {
                        employeeID = (int)sQLQueryResult.dataTable.Rows[i]["EmployeeID"];
                    }



                    int customerID = (int)sQLQueryResult.dataTable.Rows[i]["CustomerID"];
                    int animalID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalID"];
                    string name = (string)sQLQueryResult.dataTable.Rows[i]["Name"];
                    DateTime birthday = (DateTime)sQLQueryResult.dataTable.Rows[i]["BirthYear"];
                    int speciesID = (int)sQLQueryResult.dataTable.Rows[i]["Speciesid"];
                    string speciesName =(string)sQLQueryResult.dataTable.Rows[i]["SpeciesName"];
                    Species species = SpeciesFactory.Instance().CreateSpecies(speciesID, speciesName);

                    double weight =Convert.ToDouble( (decimal)sQLQueryResult.dataTable.Rows[i]["Weight"]);
                    bool gender = (bool)sQLQueryResult.dataTable.Rows[i]["Gender"];

                    //int employeeID = (int)sQLQueryResult.dataTable.Rows[i]["employeeID"];
                    
                    Employee employee = EmployeeFactory.Instance().GetEmployee(employeeID, name);
                    bool active = (bool)sQLQueryResult.dataTable.Rows[i]["Active"];

                    animals.Add(AnimalFactory.Instance().CreateAnimal(customerID,animalID, name, birthday, species, weight, gender,employee, true));



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

            //Test---! Skal udkommenteres og nedestående skal slettes!
           
            //sQLQuery.AddParameter("@entry", medicalRecord.entry.ToString(), SqlDbType.VarChar);
            //sQLQuery.AddParameter("@animalID", animal.animalID.ToString(), SqlDbType.Int);
            //sQLQuery.AddParameter("@treatmentID", treatment.treatmentID.ToString(), SqlDbType.Int);

            //Test---! Skal slettes igen og overstående skal udkommenteres!

            sQLQuery.AddParameter("@entry", (string)medicalRecord.entry, SqlDbType.VarChar);
            sQLQuery.AddParameter("@animalID", 3.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@treatmentID", 1015.ToString(), SqlDbType.Int);


            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);
        }

        //MedicalRecord
        //public List<MedicalRecord> GetAllMedicalRecordByAnimal(int animalID)
        //{
        //    string query = Utility.ReadSQLQueryFromFile("GetAllMedicalRecordByAnimal.txt");

        //    SQLQuery sQLQuery = new SQLQuery(query);

        //    sQLQuery.AddParameter("@animalID", animalID.ToString(), SqlDbType.Int);

        //    SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

        //    List<MedicalRecord> medicalRecords = new List<MedicalRecord>();
        //    medicalRecords = GetAllMedicalRecordByAnimalList(sQLQueryResult);

        //    return medicalRecords;
        //}

        //private List<MedicalRecord> GetAllMedicalRecordByAnimalList(SQLQueryResult sQLQueryResult)
        //{
        //    List<MedicalRecord> medicalRecords = new List<MedicalRecord>();

        //    for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
        //    {
        //        int MedicalRecordID;

        //        if (sQLQueryResult.dataTable.Rows[i].IsNull("AnimalID"))
        //        {
        //            MedicalRecordID = -1;
        //        }
        //        else
        //        {
        //            MedicalRecordID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalID"];
        //        }

        //        string entry = (string)sQLQueryResult.dataTable.Rows[i]["Entry"];

        //        medicalRecords.Add(MedicalRecordFactory.Instance().CreateMedicalRecord(MedicalRecordID,entry));
        //    }
        //    return medicalRecords;
        //}
    }
}

