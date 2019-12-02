using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Cage
    {
        public int CageID { get; private set; }

        public Species species { get; private set; }

        public Cage(int cageID,Species species)
        {
            this.CageID = cageID;
            this.species = species;
        }
    }
}
