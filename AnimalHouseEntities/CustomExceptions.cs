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
    public class AnimalNotEditedException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public AnimalNotEditedException()
        { }

        public AnimalNotEditedException(string message)
            : base(message)
        { }

        public AnimalNotEditedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class AnimalNotDeletedException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public AnimalNotDeletedException()
        { }

        public AnimalNotDeletedException(string message)
            : base(message)
        { }

        public AnimalNotDeletedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class AnimalNotCreatedException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public AnimalNotCreatedException()
        { }

        public AnimalNotCreatedException(string message)
            : base(message)
        { }

        public AnimalNotCreatedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class MedicalRecordEntryNotFoundException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public MedicalRecordEntryNotFoundException()
        { }

        public MedicalRecordEntryNotFoundException(string message)
            : base(message)
        { }

        public MedicalRecordEntryNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class PrescriptionNotFoundException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public PrescriptionNotFoundException()
        { }

        public PrescriptionNotFoundException(string message)
            : base(message)
        { }

        public PrescriptionNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}