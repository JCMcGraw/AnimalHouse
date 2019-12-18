using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class SaleFactory
    {
        //SingleTon Mønster
        private static SaleFactory instance;

        private SaleFactory() { }

        public static SaleFactory Instance()
        {
            if (instance == null)
            {
                instance = new SaleFactory();
            }

            return instance;
        }
        
        //Laver Obj af Sale
        public Sale CreateSale(int saleID, Customer customer, DateTime salesDay)
        {
            Sale sale = new Sale(saleID, customer, salesDay);
            return sale;
        }

        //Laver Obj af Sale
        public Sale CreateSale(Customer customer, DateTime salesDay)
        {
            Sale sale = new Sale(customer, salesDay);
            return sale;
        }
    }
}
