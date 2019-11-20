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
        public static CustomerController instance
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

        public Customer GetCustomer(string phone)
        {

            ICustomerManager customerManager = new CustomerManager();

            Customer customer = customerManager.GetCustomer(phone);

            return customer;


        }

        public Customer CreateCustomer(Customer customer)
        {


            ICustomerManager customerManager = new CustomerManager();

            return customerManager.CreateCustomer(customer);

             

            //CustomerFactory customerfactory = new CustomerFactory();

            //Customer customer = new Customer(name, address, phone, email, true);

            //return customerfactory.CreateCustomer(phone, name, address, email);
        }


        public string UpdateCustomer(Customer customer)
        {
            ICustomerManager customerManager = new CustomerManager();

            return customerManager.UpdateCustomer(customer);

            
        }

        public string DeleteCustomer(Customer customer)
        {
            ICustomerManager customerManager = new CustomerManager();

            return customerManager.DeleteCustomer(customer);
        }
    }
}
