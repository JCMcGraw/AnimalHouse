using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AnimalHouseEntities;

namespace AnimalHousePersistence
{
    public class MedicinePriceAdapter2: IMedicinePriceAdapter
    {
        public List<MedicinePrice>GetMedicinePrice()
        {
            List<MedicinePrice> list = new List<MedicinePrice>();

            string[] MedicinPrices = File.ReadAllLines("D:\\Medicin\\medicin2.txt");
            DateTime date;

            for (int i = 2; i < MedicinPrices.Length; i++)
            {
                string[] MedicinList = MedicinPrices[i].Split('_');
                string Name = MedicinList[0];
                decimal Price = Convert.ToDecimal(MedicinList[1]);
            }
            return list;
        }
    }
}
