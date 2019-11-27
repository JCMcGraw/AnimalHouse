﻿using System;
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
            sQLQuery.AddParameter("@headline", treatment.headline.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@active", treatment.active.ToString(), SqlDbType.Bit);
            sQLQuery.AddParameter("@treatmenttypeid", treatment.treatmentType.treatmentTypeID.ToString(), SqlDbType.Int);

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
            sQLQuery.AddParameter("@headline", treatment.headline.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@active", treatment.active.ToString(), SqlDbType.Bit);
            sQLQuery.AddParameter("@treatmentID", treatment.treatmentID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            return "ok";
        }

        public string DeleteTreatment(int treatmentID)
        {
            string query = Utility.ReadSQLQueryFromFile("DeleteTreatment.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@treatmentID", treatmentID.ToString(), SqlDbType.Int);
            
            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            return "ok";
        }

        public List<Treatment> GetTreatment(int treatmentID)
        {
            string query = Utility.ReadSQLQueryFromFile("GetTreatment.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@treatmentID", treatmentID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Treatment> treatments = new List<Treatment>();

            treatments = GetTreatmentList(sQLQueryResult);

            return treatments;
        }

        public List<Treatment> GetManyTreatmentsByEmployee(int employeeID, DateTime startTime, DateTime endTime)
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyTreatmentsByEmployee.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@employeeID", employeeID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@startTime", startTime.ToString("yyyy-MM-ddThh:mm:ss"), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", endTime.ToString("yyyy-MM-ddThh:mm:ss"), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Treatment> treatments = new List<Treatment>();

            treatments = GetTreatmentList(sQLQueryResult);

            return treatments;
        }

        public List<Treatment> GetManyTreatmentsByAnimal(int animalID, DateTime startTime, DateTime endTime)
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyTreatmentsByAnimal.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@animalID", animalID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@startTime", startTime.ToString("yyyy-MM-ddThh:mm:ss"), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", endTime.ToString("yyyy-MM-ddThh:mm:ss"), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Treatment> treatments = new List<Treatment>();

            treatments = GetTreatmentList(sQLQueryResult);

            return treatments;
        }

        public List<Treatment> GetManyTreatmentsByDateTime(DateTime startTime, DateTime endTime)
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyTreatmentsByDateTime.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@startTime", startTime.ToString("yyyy-MM-ddThh:mm:ss"), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", endTime.ToString("yyyy-MM-ddThh:mm:ss"), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Treatment> treatments = new List<Treatment>();

            treatments = GetTreatmentList(sQLQueryResult);

            return treatments;
        }

        public List<TreatmentType> GetManyTreatmentTypes()
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyTreatmentTypes.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<TreatmentType> treatments = new List<TreatmentType>();

            treatments = GetTreatmentTypeList(sQLQueryResult);

            return treatments;
        }

        public List<Treatment> GetTreatmentList(SQLQueryResult sQLQueryResult)
        {
            List<Treatment> treatments = new List<Treatment>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                int treatmentID;
                TreatmentType treatmentType;
                Employee employee;
                int operationRoomID;
                int cageID;
                int itemID;
                int employeeID;
                int animalID;
                Title title;

                if (sQLQueryResult.dataTable.Rows[i].IsNull("TreatmentID"))
                {
                    treatmentID = -1;
                }
                else
                {
                    treatmentID = (int)sQLQueryResult.dataTable.Rows[i]["TreatmentID"];
                }
                if (sQLQueryResult.dataTable.Rows[i].IsNull("TreatmentTypeID"))
                {
                    treatmentType = null;
                }
                else
                {
                    int treatmentTypeID = (int)sQLQueryResult.dataTable.Rows[i]["TreatmentTypeID"];
                    string treatmentTypeName = (string)sQLQueryResult.dataTable.Rows[i]["Name"];

                    TreatmentType newTreatmentType = TreatmentTypeFactory.Instance().CreateTreatmentType(treatmentTypeID, treatmentTypeName);

                    treatmentType = newTreatmentType;
                }
                if (sQLQueryResult.dataTable.Rows[i].IsNull("OperationRoomID"))
                {
                    operationRoomID = -1;
                }
                else
                {
                    operationRoomID = (int)sQLQueryResult.dataTable.Rows[i]["OperationRoomID"];
                }
                if (sQLQueryResult.dataTable.Rows[i].IsNull("CageID"))
                {
                    cageID = -1;
                }
                else
                {
                    cageID = (int)sQLQueryResult.dataTable.Rows[i]["CageID"];
                }
                if (sQLQueryResult.dataTable.Rows[i].IsNull("ItemID"))
                {
                    itemID = -1;
                }
                else
                {
                    itemID = (int)sQLQueryResult.dataTable.Rows[i]["ItemID"];
                }

                if (sQLQueryResult.dataTable.Rows[i].IsNull("EmployeeID"))
                {
                    employeeID = -1;
                }
                else
                {
                    employeeID = (int)sQLQueryResult.dataTable.Rows[i]["EmployeeID"];
                }

                if (sQLQueryResult.dataTable.Rows[i].IsNull("AnimalID"))
                {
                    animalID = -1;
                }
                else
                {
                    animalID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalID"];
                }
                DateTime startTime = (DateTime)sQLQueryResult.dataTable.Rows[i]["StartTime"];
                DateTime endTime = (DateTime)sQLQueryResult.dataTable.Rows[i]["EndTime"];
                bool payed = (bool)sQLQueryResult.dataTable.Rows[i]["Payed"];
                string headline = (string)sQLQueryResult.dataTable.Rows[i]["Headline"];
                bool active = (bool)sQLQueryResult.dataTable.Rows[i]["Active"];
                employeeID = (int)sQLQueryResult.dataTable.Rows[i]["EmployeeID"];
                string name = (string)sQLQueryResult.dataTable.Rows[i]["Employeename"];
                int titleID = (int)sQLQueryResult.dataTable.Rows[i]["TitleID"];
                string titleName = (string)sQLQueryResult.dataTable.Rows[i]["TitleName"];

                title = TitleFactory.Instance().CreateTitle(titleName, titleID);
                employee = EmployeeFactory.Instance().CreateEmployee(employeeID,name,true,titleID,title);
                 

                treatments.Add(TreatmentFactory.Instance().CreateTreatment(treatmentID, treatmentType, operationRoomID, cageID, itemID, startTime, endTime, payed, headline, active, animalID, employeeID));
            }
            return treatments;
        }

        public List<TreatmentType> GetTreatmentTypeList(SQLQueryResult sQLQueryResult)
        {
            List<TreatmentType> treatmentTypes = new List<TreatmentType>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                int treatmentTypeID;

                if (sQLQueryResult.dataTable.Rows[i].IsNull("TreatmentTypeID"))
                {
                    treatmentTypeID = -1;
                }
                else
                {
                    treatmentTypeID = (int)sQLQueryResult.dataTable.Rows[i]["TreatmentTypeID"];
                }

                string name = (string)sQLQueryResult.dataTable.Rows[i]["Name"];

                treatmentTypes.Add(TreatmentTypeFactory.Instance().CreateTreatmentType(treatmentTypeID, name));
            }
            return treatmentTypes;
        }
    }
}
