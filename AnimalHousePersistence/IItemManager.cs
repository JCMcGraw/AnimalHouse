using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public interface IItemManager
    {
        void UpdateMedicinPrice(int adapterSelector);

        string GetLastUpdate(Item item);
        List<Item> GetAllActiveItems();

        //List<MedicinePrice>GetMedicinPrices(MedicinePrice medicinPrice);
    }
}
