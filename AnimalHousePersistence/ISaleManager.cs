using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public interface ISaleManager
    {
        Sale CreateSale(Sale sale);
        string DeleteSale(Sale sale);
        List<Sale> GetManySalesByCustomerID(Customer customer);
      

    }
}
