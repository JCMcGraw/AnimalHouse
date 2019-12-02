using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class CageFactory
    {
        private static CageFactory instance;

        private CageFactory() { }

        public static CageFactory Instance()
        {
            if (instance == null)
            {
                instance = new CageFactory();
            }

            return instance;
        }

        public Cage CreateCage(int cageID)
        {
            return new Cage(cageID);
        }
    }
}
