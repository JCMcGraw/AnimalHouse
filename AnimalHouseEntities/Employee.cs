﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
   public class Employee
    {
        public int employeeID { get; private set; }

        public string name { get; private set; }

        public bool active { get; private set; }

        
        public Title title { get; private set; }

        public Employee(int employeeID, string name, bool active, Title title)
        {
            this.employeeID = employeeID;
            this.name = name;
            this.active = active; 
            this.title = title;
        }
        public Employee(int employeeID, string name)
        {
            this.employeeID = employeeID;
            this.name = name;
        }
    }
}
