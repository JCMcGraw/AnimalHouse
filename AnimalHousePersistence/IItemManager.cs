using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    interface IItemManager
    {
        string UpdateMedicinPrice(Item item);

        string GetLastUpdate(Item item);
    }
}
