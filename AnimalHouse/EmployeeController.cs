using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using AnimalHouseEntities;

namespace AnimalHouse
{
    public class EmployeeController
    {
        private EmployeeController() { }

        private static EmployeeController employeeController = null;

        public static EmployeeController Instance()
        {
            if (employeeController == null)
            {
                employeeController = new EmployeeController();
            }
            return employeeController;
        }

        IEmployeeManager employeeManager = new EmployeeManager();

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = employeeManager.GetAllEmployees();
            return employees;
        }
    }
}
