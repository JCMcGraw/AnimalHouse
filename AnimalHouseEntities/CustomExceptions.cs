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

    public class NoCustomerFoundException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public NoCustomerFoundException()
        { }

        public NoCustomerFoundException(string message)
            : base(message)
        { }

        public NoCustomerFoundException(string message, Exception inner)
            : base(message, inner)
        { }

    }

    public class CustomerNotUpdated : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CustomerNotUpdated()
        { }

        public CustomerNotUpdated(string message)
            : base(message)
        { }

        public CustomerNotUpdated(string message, Exception inner)
            : base(message, inner)
        { }


    }
    public class CantDeleteException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantDeleteException()
        { }

        public CantDeleteException(string message)
            : base(message)
        { }

        public CantDeleteException(string message, Exception inner)
            : base(message, inner)
        {

        }

    }

    public class CantCreateCustomer : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantCreateCustomer()
        { }

        public CantCreateCustomer(string message)
            : base(message)
        { }

        public CantCreateCustomer(string message, Exception inner)
            : base(message, inner)
        {

        }
    }

    public class CantCreatePrescription : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantCreatePrescription()
        { }

        public CantCreatePrescription(string message)
            : base(message)
        { }

        public CantCreatePrescription(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }

    public class CantUpdateTreatment : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantUpdateTreatment()
        { }

        public CantUpdateTreatment(string message)
            : base(message)
        { }

        public CantUpdateTreatment(string message, Exception inner)
            : base(message, inner)
        {
     
        }
    }
}