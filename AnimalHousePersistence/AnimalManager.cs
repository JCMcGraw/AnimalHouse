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
        public Animal CreateAnimal(Animal animal)

        {
            string query = Utility.ReadSQLQueryFromFile("CreateAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@name", animal.name.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@weight", animal.weight.ToString(), SqlDbType.Bit);
            sQLQuery.AddParameter("@gender", animal.gender.ToString(), SqlDbType.Bit);
            sQLQuery.AddParameter("@active", animal.active.ToString(), SqlDbType.Bit);


            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            int animalID = (int)sQLQueryResult.dataTable.Rows[0]["AnimalID"];

            animal.UpdateID(animalID);

            return animal;
        }
            //if (sQLQueryResult.code == 0)
            //{
            //    //read datatable
            //}
            //else
            //{

            //}

            //return "OK";
        
        public Animal GetAnimal(int animalID)
        {
            string query = Utility.ReadSQLQueryFromFile("GetAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalid", animalID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            int customerID = (int)sQLQueryResult.dataTable.Rows[0]["customerID"];
            //int animalID = (int)sQLQueryResult.dataTable.Rows[0]["AnimalID"];
            string name = (string)sQLQueryResult.dataTable.Rows[0]["name"];
            string birthday = (string)sQLQueryResult.dataTable.Rows[0]["species"];
            int species = (int)sQLQueryResult.dataTable.Rows[0]["species"];
            double weight = (int)sQLQueryResult.dataTable.Rows[0]["weight"];
            char gender = (char)sQLQueryResult.dataTable.Rows[0]["gender"];
            bool active = (bool)sQLQueryResult.dataTable.Rows[0]["active"];

            Animal animal = AnimalFactory.Instance().CreateAnimal(customerID, animalID, name, birthday, species, weight, gender, active);

            return animal;
        }

            //if (sQLQueryResult.code == 0)
            //{

            //    //read datatable


            //}
            //else
            //{

            //}
            //return "OK";
        
        public string UpdateAnimal(Animal animal)
        {
            string query = Utility.ReadSQLQueryFromFile("UpdateAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@name", animal.name.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@gender", animal.gender.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@weight", animal.weight.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@active", animal.active.ToString(), SqlDbType.Bit);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            

        if (sQLQueryResult.code == 0)
            {
                //read datatable
            }
            else
            {

            }
            return "OK";
        }

        public string DeleteAnimal(Animal animal)
        {
            string query = Utility.ReadSQLQueryFromFile("DeleteAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalid", animal.animalid.ToString(), SqlDbType.Int);
           

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code == 0)
            {
                //read datatable
            }
            else
            {

            }
            return "OK";
        }

    }
}
