using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class CageFactory
    {
        //SingleTon Mønster
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

        //Laver Obj af Cage
        public Cage CreateCage(int cageID,Species species)
        {
            return new Cage(cageID,species);
        }
    }
}
