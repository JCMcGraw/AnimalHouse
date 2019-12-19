using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Species
    {
        public int speciesID { get; private set;}

        public string speciesName { get; private set; }

        public Species(int speciesID, string speciesName)
        {
            this.speciesID = speciesID;
            this.speciesName = speciesName;
        }
    }
}
