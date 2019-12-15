using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
   public class Title
   {
        public string name { get; private set; }

        public int titleID { get; private set; }

        public Title(string name, int titleID)
        {
            this.name = name;
            this.titleID = titleID;
        }
   }
}
