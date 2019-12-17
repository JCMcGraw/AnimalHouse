using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnimalHouseEntities
{
    public class CustomerFactory
    {
        //SingleTon Mønster
        private CustomerFactory() { }

        private static CustomerFactory customerFactory = null;

        public static CustomerFactory Instance()
        {
            if (customerFactory == null)
            {
                customerFactory = new CustomerFactory();
            }
            return customerFactory;
        }

        //Laver Obj af Customer
        public Customer CreateCustomer(string name, string address, string phone, string email, bool active, int cvr)
        {
            if (cvr != 0)
            {
                return new BusinessCustomer(cvr, name, address, phone, email, active);
            }
            else
            {
                return new PrivateCustomer(name, address, phone, email, active);
            }
        }

        //Laver Obj af Customer
        public Customer CreateCustomer(int customerID, string name, string address, string phone, string email, bool active, int cvr)
        {
            if (cvr != 0)
            {
                return new BusinessCustomer(customerID, cvr, name, address, phone, email, active);
            }
            else
            {
                return new PrivateCustomer(customerID, name, address, phone, email, active);
            }
        }
    }
}