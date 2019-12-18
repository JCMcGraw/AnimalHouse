using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public class EmployeeManager : IEmployeeManager
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            string query = Utility.ReadSQLQueryFromFile("GetAllEmployees.txt");

            SQLQuery sQLQuery = new SQLQuery(query);

            SQLQueryResult sQLQueryResult = SQLDatabaseConnector.QueryDatabase(sQLQuery);

            if (sQLQueryResult.code != 0 || sQLQueryResult.dataTable.Rows.Count == 0)
            {
                throw new NoEmployeesFoundException("", sQLQueryResult.exception);
            }
            else
            {
                employees = GetEmployeeList(sQLQueryResult);

                return employees;
            }
        }

        private List<Employee> GetEmployeeList(SQLQueryResult sQLQueryResult)
        {
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < sQLQueryResult.dataTable.Rows.Count; i++)
            {
                int employeeID;
                string name;
                bool active = true;
                int titleID;
                Title title;
                string titleName;

                employeeID=(int)sQLQueryResult.dataTable.Rows[i]["EmployeeID"];
                name = (string)sQLQueryResult.dataTable.Rows[i]["Employeename"];
                titleID = (int)sQLQueryResult.dataTable.Rows[i]["TitleID"];
                titleName = (string)sQLQueryResult.dataTable.Rows[i]["TitleName"];

                Title newtitle = TitleFactory.Instance().CreateTitle(titleName, titleID);
                title = newtitle;

                employees.Add(EmployeeFactory.Instance().CreateEmployee(employeeID, name, active, title));
            }
            return employees;
        }
    }
}