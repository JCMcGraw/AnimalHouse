using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalHouse
{
    public class BossController
    {

        public CustomerController GetCustomerController()
        {
            CustomerController customercontroller = CustomerController.instance;
            return customercontroller;

        }

    }
}
