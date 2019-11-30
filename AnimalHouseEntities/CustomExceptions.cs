using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHouseEntities
{
    public class NoItemsFoundException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public NoItemsFoundException()
        { }

        public NoItemsFoundException(string message)
            : base(message)
        { }

        public NoItemsFoundException(string message, Exception inner)
            : base(message, inner)
        { }

    }
}
