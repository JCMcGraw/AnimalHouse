using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class SaleLineItemFactory
    {
        //SingleTon Mønster
        private static SaleLineItemFactory instance;

        private SaleLineItemFactory() { }

        public static SaleLineItemFactory Instance()
        {
            if (instance == null)
            {
                instance = new SaleLineItemFactory();
            }

            return instance;
        }

        //Laver Obj af SaleLineItem
        public SaleLineItem CreateSaleLineItem(Item item, int saleLineItemID, int amount, decimal price, Treatment treatment, Prescription prescription)
        {
            SaleLineItem saleLineItem = new SaleLineItem(item, saleLineItemID, amount, price, treatment, prescription);
            return saleLineItem;
        }

        //Laver Obj af SaleLineItem
        public SaleLineItem CreateSaleLineItem(Item item, int amount, decimal price, Treatment treatment, Prescription prescription)
        {
            SaleLineItem saleLineItem = new SaleLineItem(item, amount, price, treatment, prescription);
            return saleLineItem;
        }
    }
}
