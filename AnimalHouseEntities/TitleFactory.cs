using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class TitleFactory
    {
        private TitleFactory() { }

        private static TitleFactory titleFactory = null;

        public static TitleFactory Instance()
        {
            if (titleFactory == null)
            {
                titleFactory = new TitleFactory();
            }
            return titleFactory;
        }

       public Title CreateTitle(string name, int titleID)
       {
            return new Title(name, titleID);
       }
    }
}
