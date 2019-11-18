﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;
using System.Data;

namespace AnimalHouse
{
    public class CustomerController
    {
        private CustomerController()
            {}
        private static CustomerController _instance = null;
        public static CustomerController instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CustomerController();
                }
                return _instance;
            }

        }

        public DataTable GetCustomer(string phone)
        {

            CustomerFactory customerFactory = new CustomerFactory();

           
            DataTable dataTable=customerFactory.GetCustomer(phone);


            return dataTable;

           
        }
       
        public string CreateCostumer(string phone, string name, string address, string email)
        {
            CustomerFactory customerfactory = new CustomerFactory();

           // Customer customer = new Customer(name, address, phone, email, true);

            return customerfactory.CreateCustomer(phone, name, address, email);
        }

        public string UpdateCustomer(string phone, string name, string address, string email)
        {
            CustomerFactory customerfactory = new CustomerFactory();

            return customerfactory.UpdateCustomer(phone, name, address, email);
        }

        public string DeleteCustomer(string phone)
        {
            CustomerFactory customerfactory = new CustomerFactory();
            return customerfactory.DeleteCustomer(phone);
        }
    }
}
