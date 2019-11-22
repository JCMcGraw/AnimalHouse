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


            //Sale sale = SaleFactory.Instance().CreateSale(null);

            //ISaleManager saleManager = new SaleManager();
            ////saleManager.GetManySalesByCustomerID(customer);

            ////Item item = saleManager.GetAllActiveItems()[0];

            //SaleLineItem saleLineItem = SaleLineItemFactory.Instance().CreateSaleLineItem(item, 2, item.price);
            //sale.AddSaleLineItem(saleLineItem);

            //saleManager.CreateSale(sale);


            Console.ReadKey();
        }
    }
}
