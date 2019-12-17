using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class ItemFactory
    {
        //SingleTon Mønster
        private static ItemFactory instance;

        private ItemFactory() { }

        public static ItemFactory Instance()
        {
            if (instance == null)
            {
                instance = new ItemFactory();
            }

            return instance;
        }

        //Laver obj af Item
        public Item CreateItem(int itemID, string name, int amount, decimal price, decimal costPrice, bool prescription, bool treatment, bool active)
        {
            Item item = new Item(itemID, name, amount, price, costPrice, prescription, treatment, active);
            return item;
        }
    }
}
