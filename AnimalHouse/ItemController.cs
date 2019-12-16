using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;
using AnimalHousePersistence;

namespace AnimalHouse
{
    public class ItemController
    {
        private static ItemController instance;

        public static ItemController Instance()
        {
            if (instance == null)
            {
                instance = new ItemController();
            }

            return instance;
        }

        IItemManager itemManager = new ItemManager();

        public List<Item> GetAllActiveItems()
        {
            List<Item> items = itemManager.GetAllActiveItems();
            return items;
        }
        public DateTime GetLastUpdate()
        {
            return itemManager.GetLastUpdate();

        }
        public void UpdateMedicinePrice(int adapterSelector)
        {
            itemManager.UpdateMedicinePrice(adapterSelector);
        }
        //public List<MedicinPrice> GetMedicinPrices()
        //{
        //    List<MedicinPrice> medicinPrices = IItemManager.GetMedicinPrices();
        //    return medicinPrices;
        //}
    }
}
