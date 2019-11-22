using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class SaleLineItemFactory
    {
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

        public SaleLineItem CreateSaleLineItem(Item item, int saleLineItemID, int amount, decimal price)
        {
            SaleLineItem saleLineItem = new SaleLineItem(item, saleLineItemID, amount, price);
            return saleLineItem;
        }

        public SaleLineItem CreateSaleLineItem(Item item, int amount, decimal price)
        {
            SaleLineItem saleLineItem = new SaleLineItem(item, amount, price);
            return saleLineItem;
        }
    }
}
