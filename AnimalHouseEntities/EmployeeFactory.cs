using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class EmployeeFactory
    {
        //SingleTon Mønster
        private EmployeeFactory() { }

        private static EmployeeFactory employeeFactory = null;

        public static EmployeeFactory Instance()
        {
            if (employeeFactory == null)
            {
                employeeFactory = new EmployeeFactory();
            }
            return employeeFactory;
        }

        //Laver Obj af Employee
        public Employee CreateEmployee(int employeeID, string name, bool active, int titleID, Title title)
        {
            return new Employee(employeeID, name, active, titleID, title);
        }

        //Laver Obj af Employee
        public Employee GetEmployee(int employeeID, string name)
        {
            return new Employee(employeeID, name);
        }
    }
}