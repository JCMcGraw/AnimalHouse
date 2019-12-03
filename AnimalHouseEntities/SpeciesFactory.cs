using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class SpeciesFactory
    {
        private static SpeciesFactory instance;

        private SpeciesFactory() { }

        public static SpeciesFactory Instance()
        {
            if (instance == null)
            {
                instance = new SpeciesFactory();
            }
            return instance;
        }
        public Species CreateSpecies(int speciesID, string speciesName)
        {
            return new Species(speciesID, speciesName);
        }
        public Species GetSpecies(int speciesID, string name)
        {
            return new Species(speciesID, name);
        }
    }
}
