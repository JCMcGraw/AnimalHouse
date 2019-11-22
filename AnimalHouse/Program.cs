using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using AnimalHouseEntities;

namespace AnimalHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treatment treatment = TreatmentFaktory.Instance().CreateTreatment(0,0,0,0,0, Convert.ToDateTime("1905 - 05 - 27"), Convert.ToDateTime("1905 - 08 - 22"), false);

            //TreatmentController.Instance().CreateTreatment(treatment);

            //TreatmentController.Instance().UpdateTreatment(treatment);



            //Customer customer = CustomerController.instance.GetCustomer("123");


            //Sale sale = SaleFactory.Instance().CreateSale(customer);
            

            //ISaleManager saleManager = new SaleManager();

            //List<Sale> sales = saleManager.GetManySalesByCustomerID(customer);

            ////Sale sale = sales[sales.Count - 1];
            ////sale.saleLineItems.Clear();

            //////List<Sale> sales = saleManager.GetManySalesByCustomerID(customer);
            //////saleManager.DeleteSale(sales[0]);
            //Item item = saleManager.GetAllActiveItems()[0];
            ////Item item2 = saleManager.GetAllActiveItems()[1];

            //SaleLineItem saleLineItem = SaleLineItemFactory.Instance().CreateSaleLineItem(item, 2, item.price);
            //sale.AddSaleLineItem(saleLineItem);
            ////SaleLineItem saleLineItem2 = SaleLineItemFactory.Instance().CreateSaleLineItem(item2, 2, item2.price);
            ////sale.AddSaleLineItem(saleLineItem2);

            ////saleManager.UpdateSale(sale);
            //saleManager.CreateSale(sale);


            Console.ReadKey();
        }
    }
}
