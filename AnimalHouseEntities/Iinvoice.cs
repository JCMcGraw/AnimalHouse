using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
   public interface Iinvoice
   {
        void CreatePDF(Sale sale);
   }
}
