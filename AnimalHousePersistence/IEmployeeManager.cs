using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public interface IEmployeeManager
    {
         List<Employee> GetAllEmployees();
       // List<Employee> GetEmployeeList(SQLQueryResult sQLQueryResult);
    }
}
