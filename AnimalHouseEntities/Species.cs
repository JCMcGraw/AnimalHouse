using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class Species
    {
        
        public int speciesid { get; private set;}
        public string speciesType { get; private set; }
        public Species(int speciesID, string speciesType)
        {
            this.speciesid = speciesID;
            this.speciesType = speciesType;
        }
    }
}
