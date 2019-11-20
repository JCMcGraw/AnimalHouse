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

        public List<Item> GetAllActiveItems()
        {
            ISaleManager saleManager = new SaleManager();

            List<Item> items = saleManager.GetAllActiveItems();

            return items;
        }
    }
}
