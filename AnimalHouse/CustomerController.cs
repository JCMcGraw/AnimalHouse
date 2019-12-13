using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;
using System.Data;
using AnimalHousePersistence;

namespace AnimalHouse
{
    public class CustomerController
    {
        private CustomerController()
            {}
        private static CustomerController customerController = null;
        public static CustomerController Instance
        {
            get
            {
                if (customerController == null)
                {
                    customerController = new CustomerController();
                }
                return customerController;
            }

        }
        ICustomerManager customerManager = new CustomerManager();

        public Customer GetCustomer(string phone)
        {

            Customer customer = customerManager.GetCustomer(phone);

            return customer;
            
        }

        public Customer CreateCustomer(Customer customer)
        {

            return customerManager.CreateCustomer(customer);

        }


        public string UpdateCustomer(Customer customer)
        {
         
            return customerManager.UpdateCustomer(customer);
        }

        public string DeleteCustomer(Customer customer)
        {
           
            return customerManager.DeleteCustomer(customer);
        }

        public string UndeleteCustomer(Customer customer)
        {
        
            return customerManager.UndeleteCustomer(customer);
        }

        
    }
}
