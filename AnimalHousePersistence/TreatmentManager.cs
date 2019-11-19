using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public class TreatmentManager : ITreatmentManager
    {
        public Treatment CreateTreatment(Treatment treatment)
        {
            string query = Utility.ReadSQLQueryFromFile("CreateTreatment.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@startTime", treatment.startTime.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", treatment.endTime.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@payed", treatment.payed.ToString(), SqlDbType.Bit);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            int treatmentID = (int)sQLQueryResult.dataTable.Rows[0]["TreatmentID"];

            treatment.UpdateID(treatmentID);

            return treatment;
        }

        public string UpdateTreatment(Treatment treatment)
        {
            string query = Utility.ReadSQLQueryFromFile("UpdateTreatment.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@startTime", treatment.startTime.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", treatment.endTime.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@payed", treatment.payed.ToString(), SqlDbType.Bit);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            return "ok";
        }

        public string DeleteTreatment(Treatment treatment)
        {
            string query = Utility.ReadSQLQueryFromFile("DeleteTreatment.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@startTime", treatment.startTime.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", treatment.endTime.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@payed", treatment.payed.ToString(), SqlDbType.Bit);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            return "ok";
        }

        public Treatment GetTreatment(int treatmentID)
        {
            string query = Utility.ReadSQLQueryFromFile("GetTreatment.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@treatmentID", treatmentID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            int tratmentID = (int)sQLQueryResult.dataTable.Rows[0]["TreatmentID"];
            int treatmentTypeID = (int)sQLQueryResult.dataTable.Rows[0]["TreatmentTypeID"];
            int operationRoomID = (int)sQLQueryResult.dataTable.Rows[0]["OperationRoomID"];
            int cageID = (int)sQLQueryResult.dataTable.Rows[0]["CageID"];
            int itemID = (int)sQLQueryResult.dataTable.Rows[0]["ItemID"];
            DateTime startTime = (DateTime)sQLQueryResult.dataTable.Rows[0]["StartTime"];
            DateTime endTime = (DateTime)sQLQueryResult.dataTable.Rows[0]["EndTime"];
            bool payed = (bool)sQLQueryResult.dataTable.Rows[0]["Payed"];
            int employeeID = (int)sQLQueryResult.dataTable.Rows[0]["EmployeeID"];
            int animalID = (int)sQLQueryResult.dataTable.Rows[0]["AnimalID"];
            
            Treatment treatment = TreatmentFaktory.Instance().CreateTreatment(tratmentID, treatmentTypeID, operationRoomID,cageID,itemID,startTime,endTime,payed);

            return treatment;
        }

        public List<Treatment> GetManyTreatmentsByEmployee(int employeeID, DateTime startTime, DateTime endTime)
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyTreatmentsByEmployee.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@employeeID", employeeID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@startTime", startTime.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", endTime.ToString(), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Treatment> treatments = new List<Treatment>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                int tratmentID = (int)sQLQueryResult.dataTable.Rows[i]["TreatmentID"];
                int treatmentTypeID = (int)sQLQueryResult.dataTable.Rows[i]["TreatmentTypeID"];
                int operationRoomID = (int)sQLQueryResult.dataTable.Rows[i]["OperationRoomID"];
                int cageID = (int)sQLQueryResult.dataTable.Rows[i]["CageID"];
                int itemID = (int)sQLQueryResult.dataTable.Rows[i]["ItemID"];
                DateTime startTimee = (DateTime)sQLQueryResult.dataTable.Rows[i]["StartTime"];
                DateTime endTimee = (DateTime)sQLQueryResult.dataTable.Rows[i]["EndTime"];
                bool payed = (bool)sQLQueryResult.dataTable.Rows[i]["Payed"];
                int employeeIDD = (int)sQLQueryResult.dataTable.Rows[i]["EmployeeID"];
                int animalID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalID"];

                treatments.Add(TreatmentFaktory.Instance().CreateTreatment(tratmentID, treatmentTypeID, operationRoomID, cageID, itemID, startTimee, endTimee, payed));
            }
            return new List<Treatment>();
        }

        public List<Treatment> GetManyTreatmentsByAnimal(int animalID, DateTime startTime, DateTime endTime)
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyTreatmentsByAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@employeeID", animalID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@startTime", startTime.ToString(), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", endTime.ToString(), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Treatment> treatments = new List<Treatment>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                int tratmentID = (int)sQLQueryResult.dataTable.Rows[i]["TreatmentID"];
                int treatmentTypeID = (int)sQLQueryResult.dataTable.Rows[i]["TreatmentTypeID"];
                int operationRoomID = (int)sQLQueryResult.dataTable.Rows[i]["OperationRoomID"];
                int cageID = (int)sQLQueryResult.dataTable.Rows[i]["CageID"];
                int itemID = (int)sQLQueryResult.dataTable.Rows[i]["ItemID"];
                DateTime startTimee = (DateTime)sQLQueryResult.dataTable.Rows[i]["StartTime"];
                DateTime endTimee = (DateTime)sQLQueryResult.dataTable.Rows[i]["EndTime"];
                bool payed = (bool)sQLQueryResult.dataTable.Rows[i]["Payed"];
                int employeeID = (int)sQLQueryResult.dataTable.Rows[i]["EmployeeID"];
                int animalIDD = (int)sQLQueryResult.dataTable.Rows[i]["AnimalID"];

                treatments.Add(TreatmentFaktory.Instance().CreateTreatment(tratmentID, treatmentTypeID, operationRoomID, cageID, itemID, startTimee, endTimee, payed));
            }
            return new List<Treatment>();
        }

        public List<Treatment> GetManyTreatmentsByDateTime(DateTime startTime, DateTime endTime)
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyTreatmentsByDateTime.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@startTime", startTime.ToString("yyyy-MM-ddThh:mm:ss"), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", endTime.ToString("yyyy-MM-ddThh:mm:ss"), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Treatment> treatments = new List<Treatment>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                DataRow dataRow = sQLQueryResult.dataTable.Rows[i];

                int tratmentID = (int)sQLQueryResult.dataTable.Rows[i]["TreatmentID"];
                if (sQLQueryResult.dataTable.Rows[i].IsNull("TreatmentTypeID"))
                {

                }
                else
                {
                    int treatmentTypeID = (int)sQLQueryResult.dataTable.Rows[i]["TreatmentTypeID"];
                }
                int operationRoomID = (int)sQLQueryResult.dataTable.Rows[i]["OperationRoomID"];
                int cageID = (int)sQLQueryResult.dataTable.Rows[i]["CageID"];
                int itemID = (int)sQLQueryResult.dataTable.Rows[i]["ItemID"];
                DateTime startTimee = (DateTime)sQLQueryResult.dataTable.Rows[i]["StartTime"];
                DateTime endTimee = (DateTime)sQLQueryResult.dataTable.Rows[i]["EndTime"];
                bool payed = (bool)sQLQueryResult.dataTable.Rows[i]["Payed"];
                int employeeID = (int)sQLQueryResult.dataTable.Rows[i]["EmployeeID"];
                int animalID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalID"];

                //treatments.Add(TreatmentFaktory.Instance().CreateTreatment(tratmentID, treatmentTypeID, operationRoomID, cageID, itemID, startTimee, endTimee, payed));
            }
            return new List<Treatment>();
        }


    }
}
