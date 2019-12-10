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

    public class NoRemindersFoundException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public NoRemindersFoundException()
        { }

        public NoRemindersFoundException(string message)
            : base(message)
        { }

        public NoRemindersFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }

    public class NoTreatmentTypesFoundException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public NoTreatmentTypesFoundException()
        { }

        public NoTreatmentTypesFoundException(string message)
            : base(message)
        { }

        public NoTreatmentTypesFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }

    public class NoEmployeesFoundException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public NoEmployeesFoundException()
        { }

        public NoEmployeesFoundException(string message)
            : base(message)
        { }

        public NoEmployeesFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }

    public class TreatmentNotCreatedException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public TreatmentNotCreatedException()
        { }

        public TreatmentNotCreatedException(string message)
            : base(message)
        { }

        public TreatmentNotCreatedException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}