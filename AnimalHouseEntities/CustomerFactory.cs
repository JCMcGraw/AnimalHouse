using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using System.Data;

namespace AnimalHouseEntities
{
   public class CustomerFactory
    {
        ICustomerManager customerManager = new CustomerManager();


        //public ICustomerManager GetCustomerManager()
        //{
           

        //    return customerManager;
        //}

        public DataTable GetCustomer(string phone)
        {
          
            return customerManager.GetCustomer(phone);


        }

        public string CreateCustomer(string phone, string name, string address, string email)
        {
          

            return customerManager.CreateCustomer(phone, name, address, email);
        }

        public string UpdateCustomer(string phone, string name, string address, string email)
        {
           return customerManager.UpdateCustomer(phone, name, address, email);

        }

        public string DeleteCustomer(string phone)
        {
            return customerManager.DeleteCustomer(phone);
        }
    }
}
