using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;
using AnimalHousePersistence;

namespace AnimalHouse
{
    public class SaleController
    {
        private static SaleController instance;

        private SaleController() { }

        public static SaleController Instance()
        {
            if (instance == null)
            {
                instance = new SaleController();
            }

            return instance;
        }

        ISaleManager saleManager = new SaleManager();

        //public List<Item> GetAllActiveItems()
        //{
        //    List<Item> items = ItemController.GetAllActiveItems();
        //    return items;
        //}

        public Sale CreateSale(Sale sale)
        {
            Sale saleWithID = saleManager.CreateSale(sale);
            return saleWithID;
        }

        public string UpdateSale(Sale sale)
        {
            string returncode = saleManager.UpdateSale(sale);
            return returncode;
        }

        public string DeleteSale(Sale sale)
        {
            string returncode = saleManager.DeleteSale(sale);
            return returncode;
        }

        public List<Sale> GetManySalesByCustomerID(Customer customer)
        {
            List<Sale> sales = saleManager.GetManySalesByCustomerID(customer);
            return sales;
        }

        public void CreateInvoice(Sale sale)
        {
            Iinvoice invoice = new Invoice();

            invoice.CreatePDF(sale);
        }
    }
}
