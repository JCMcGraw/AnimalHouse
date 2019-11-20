using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class SaleFactory
    {
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

        public Sale CreateSale(int saleID, Customer customer)
        {
            Sale sale = new Sale(saleID, customer);
            return sale;
        }
    }
}
