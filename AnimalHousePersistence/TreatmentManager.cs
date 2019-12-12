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
            sQLQuery.AddParameter("@headline", treatment.headline.ToString(), SqlDbType.VarChar);
            sQLQuery.AddParameter("@active", treatment.active.ToString(), SqlDbType.Bit);
            sQLQuery.AddParameter("@treatmenttypeid", treatment.treatmentType.treatmentTypeID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@itemid", treatment.item.itemID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@animalid", treatment.animal.animalID.ToString(), SqlDbType.Int);
            sQLQuery.AddParameter("@status", treatment.status.ToString(), SqlDbType.Int);

            if (treatment.employee == null)
            {
                sQLQuery.AddParameter("@employeeid", null, SqlDbType.Int);
            }
            else
            {
                sQLQuery.AddParameter("@employeeid", treatment.employee.employeeID.ToString(), SqlDbType.Int);
            }

            if (treatment.operationRoom == null)
            {
                sQLQuery.AddParameter("@operationroomid", null, SqlDbType.Int);
            }
            else
            {
                sQLQuery.AddParameter("@operationroomid", treatment.operationRoom.operationRoomID.ToString(), SqlDbType.Int);
            }

            if (treatment.cage == null)
            {
                sQLQuery.AddParameter("@cageid", null, SqlDbType.Int);
            }
            else
            {
                sQLQuery.AddParameter("@cageid", treatment.cage.CageID.ToString(), SqlDbType.Int);
            }

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if(sQLQueryResult.code != 0)
            {
                throw new TreatmentNotCreatedException("", sQLQueryResult.exception);
            }
            else
            {
                int treatmentID = (int)sQLQueryResult.dataTable.Rows[0]["TreatmentID"];

                treatment.UpdateID(treatmentID);

                return treatment;
            }
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
            sQLQuery.AddParameter("@status", treatment.status.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code!=0)
            {
                throw new CantUpdateTreatmentException("", sQLQueryResult.exception);
            }

            return "ok";
        }

        public string DeleteTreatment(int treatmentID)
        {
            string query = Utility.ReadSQLQueryFromFile("DeleteTreatment.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@treatmentID", treatmentID.ToString(), SqlDbType.Int);
            
            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if(sQLQueryResult.code != 0)
            {
                throw new CantDeleteTreatmentException("", sQLQueryResult.exception);
            }

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
            sQLQuery.AddParameter("@startTime", startTime.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", endTime.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);

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
            sQLQuery.AddParameter("@startTime", startTime.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", endTime.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            List<Treatment> treatments = new List<Treatment>();

            treatments = GetTreatmentList(sQLQueryResult);

            return treatments;
        }

        public List<Treatment> GetManyTreatmentsByDateTime(DateTime startTime, DateTime endTime)
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyTreatmentsByDateTime.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@startTime", startTime.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", endTime.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if(sQLQueryResult.code != 0)
            {
                throw new CantFindTreatmentsException("", sQLQueryResult.exception);
            }
            List<Treatment> treatments = new List<Treatment>();

            treatments = GetTreatmentList(sQLQueryResult);

            return treatments;
        }

        public List<Treatment> GetUnpaidTreatmentsByCustomer(Customer customer)
        {
            string query = Utility.ReadSQLQueryFromFile("GetUnpaidTreatmentsByCustomer.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@customerid", customer.customerID.ToString(), SqlDbType.Int);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code==0)
            {
                List<Treatment> treatments = new List<Treatment>();

                treatments = GetTreatmentList(sQLQueryResult);

                return treatments;
            }
            else
            {
                throw new CantGetUnPaidTreatments("", sQLQueryResult.exception);
            }
        }

        public List<TreatmentType> GetAllTreatmentTypes()
        {
            string query = Utility.ReadSQLQueryFromFile("GetManyTreatmentTypes.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code != 0 || sQLQueryResult.dataTable.Rows.Count == 0)
            {
                throw new NoTreatmentTypesFoundException("", sQLQueryResult.exception);
            }
            else
            {
                List<TreatmentType> treatments = new List<TreatmentType>();

                treatments = GetTreatmentTypeList(sQLQueryResult);

                return treatments;
            }
        }

        public List<Cage> GetAllCages()
        {
            string query = Utility.ReadSQLQueryFromFile("GetAllCages.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code != 0)
            {
                throw new CantFindCagesException("", sQLQueryResult.exception);
            }

            List<Cage> cages = new List<Cage>();
            cages = GetCageList(sQLQueryResult); 

            return cages;
        }

        public List<OperationRoom> GetAllOperationRooms()
        {
            string query = Utility.ReadSQLQueryFromFile("GetAllOperationRooms.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code != 0)
            {
                throw new CantFindOperationRoomsException("", sQLQueryResult.exception);
            }

            List<OperationRoom> operationRooms = new List<OperationRoom>();
            operationRooms = GetAllOperationRooms(sQLQueryResult);

            return operationRooms;

        }

        private List<Treatment> GetTreatmentList(SQLQueryResult sQLQueryResult)
        {
            List<Treatment> treatments = new List<Treatment>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                int treatmentID;
                TreatmentType treatmentType;
                Employee employee;
                Employee animalEmployee = null;
                OperationRoom operationRoom;
                Cage cage;
                Item item;
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
                    operationRoom = null;
                }
                else
                {
                    int operationRoomID = (int)sQLQueryResult.dataTable.Rows[i]["OperationRoomID"];

                    operationRoom = OperationRoomFactory.Instance().CreateOperationRoom(operationRoomID);
                }

                if (sQLQueryResult.dataTable.Rows[i].IsNull("CageID"))
                {
                    cage = null;
                }
                else
                {
                    int cageID = (int)sQLQueryResult.dataTable.Rows[i]["CageID"];
                    int speciesID = (int)sQLQueryResult.dataTable.Rows[i]["SpeciesID"];
                    string speciesName = (string)sQLQueryResult.dataTable.Rows[i]["SpeciesName"];

                    Species species = SpeciesFactory.Instance().CreateSpecies(speciesID, speciesName);

                    cage = CageFactory.Instance().CreateCage(cageID,species);
                }


                if (sQLQueryResult.dataTable.Rows[i].IsNull("ItemID"))
                {
                    item = null;
                }
                else
                {
                    int itemID = (int)sQLQueryResult.dataTable.Rows[i]["ItemID"];
                    string name = (string)sQLQueryResult.dataTable.Rows[i]["ItemName"];
                    decimal price = (decimal)sQLQueryResult.dataTable.Rows[i]["Price"];
                    decimal costPrice = (decimal)sQLQueryResult.dataTable.Rows[i]["CostPrice"];
                    int amount = (int)sQLQueryResult.dataTable.Rows[i]["Amount"];
                    bool prescription = (bool)sQLQueryResult.dataTable.Rows[i]["Prescription"];
                    bool treatment = (bool)sQLQueryResult.dataTable.Rows[i]["ItemTreatment"];
                    bool itemActive = (bool)sQLQueryResult.dataTable.Rows[i]["ItemActive"];

                    item = ItemFactory.Instance().CreateItem(itemID,name,amount,price,costPrice,prescription,treatment,itemActive);
                }

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

                animalID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalID"];
                if (!sQLQueryResult.dataTable.Rows[i].IsNull("AnimalEmployeeID"))
                {
                    int animalTitleID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalEmployeeTitleID"];
                    string animalTitleName = (string)sQLQueryResult.dataTable.Rows[i]["AnimalEmployeeTitle"];

                    Title animalEmployeeTitle = TitleFactory.Instance().CreateTitle(animalTitleName, animalTitleID);

                    int animalEmployeeID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalEmployeeID"];
                    string animalEmployeeName = (string)sQLQueryResult.dataTable.Rows[i]["AnimalEmployeeName"];
                    bool animalEmployeeActive = (bool)sQLQueryResult.dataTable.Rows[i]["AnimalEmployeeActive"];


                    animalEmployee = EmployeeFactory.Instance().CreateEmployee(animalEmployeeID, animalEmployeeName, animalEmployeeActive, animalEmployeeTitle.titleID, animalEmployeeTitle);
                }

                int animalSpeciesID = (int)sQLQueryResult.dataTable.Rows[i]["AnimalSpeciesID"];
                string animalSpeciesName = (string)sQLQueryResult.dataTable.Rows[i]["AnimalSpeciesName"];

                Species animalSpecies = SpeciesFactory.Instance().CreateSpecies(animalSpeciesID, animalSpeciesName);

                int customerID = (int)sQLQueryResult.dataTable.Rows[i]["CustomerID"];
                string customerName = (string)sQLQueryResult.dataTable.Rows[i]["CustomerName"];
                string customerAddress = (string)sQLQueryResult.dataTable.Rows[i]["Adress"];
                string customerPhone = (string)sQLQueryResult.dataTable.Rows[i]["Phone"];
                string customerEmail = (string)sQLQueryResult.dataTable.Rows[i]["Email"];
                bool customerActive = (bool)sQLQueryResult.dataTable.Rows[i]["CustomerActive"];

                Customer customer = CustomerFactory.Instance().CreateCustomer(customerID, customerName, customerAddress, customerPhone, customerEmail, customerActive, 0);


                string animalName = (string)sQLQueryResult.dataTable.Rows[i]["AnimalName"];
                DateTime animalBirthday = (DateTime)sQLQueryResult.dataTable.Rows[i]["BirthYear"];
                bool animalGender = (bool)sQLQueryResult.dataTable.Rows[i]["Gender"];
                double animalWeight = Convert.ToDouble((decimal)sQLQueryResult.dataTable.Rows[i]["Weight"]);
                bool animalActive = (bool)sQLQueryResult.dataTable.Rows[i]["AnimalActive"];

                Animal animal = AnimalFactory.Instance().CreateAnimal(customer, animalID, animalName, animalBirthday, animalSpecies, animalWeight, animalGender, animalEmployee, animalActive);

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
                int status = (int)sQLQueryResult.dataTable.Rows[i]["Status"];
                
                treatments.Add(TreatmentFactory.Instance().CreateTreatment(treatmentID, treatmentType, operationRoom, cage, item, startTime, endTime, payed, headline, active, animal, employee,status));
            }
            return treatments;
        }

        private List<TreatmentType> GetTreatmentTypeList(SQLQueryResult sQLQueryResult)
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

        private List<Cage> GetCageList(SQLQueryResult sQLQueryResult)
        {
            List<Cage> cages = new List<Cage>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                int cageID = (int)sQLQueryResult.dataTable.Rows[i]["CageID"];
                int speciesID = (int)sQLQueryResult.dataTable.Rows[i]["SpeciesID"];
                string speciesName = (string)sQLQueryResult.dataTable.Rows[i]["SpeciesName"];

                Species species = SpeciesFactory.Instance().CreateSpecies(speciesID, speciesName);

                cages.Add(CageFactory.Instance().CreateCage(cageID,species));
            }
            return cages;
        }

        private List<OperationRoom> GetAllOperationRooms(SQLQueryResult sQLQueryResult)
        {
            List<OperationRoom> operationRooms = new List<OperationRoom>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                int operationRoomID;

                if (sQLQueryResult.dataTable.Rows[i].IsNull("OperationRoomID"))
                {
                    operationRoomID = -1;
                }
                else
                {
                    operationRoomID = (int)sQLQueryResult.dataTable.Rows[i]["OperationRoomID"];
                }
                operationRooms.Add(OperationRoomFactory.Instance().CreateOperationRoom(operationRoomID));
            }
            return operationRooms;
        }

        public List<Treatment> GetManyTreatmentsForSendingRminders(DateTime startTime, DateTime endTime)
        {
            string query = Utility.ReadSQLQueryFromFile("SendReminder.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            sQLQuery.AddParameter("@startTime", startTime.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);
            sQLQuery.AddParameter("@endTime", endTime.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);
            if(sQLQueryResult.code != 0)
            {
                throw new NoRemindersFoundException("1", sQLQueryResult.exception);
            }
            List<Treatment> treatments = new List<Treatment>();

            treatments = GetTreatmentList(sQLQueryResult);

            if (treatments.Count == 0)
            {
                throw new NoRemindersFoundException("2", sQLQueryResult.exception);
            }

            return treatments;
        }
    }
}
