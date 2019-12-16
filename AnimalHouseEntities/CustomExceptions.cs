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

    public class CantUpdateTreatmentException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantUpdateTreatmentException()
        { }

        public CantUpdateTreatmentException(string message)
            : base(message)
        { }

        public CantUpdateTreatmentException(string message, Exception inner)
            : base(message, inner)
        {
     
        }
    }

    public class CantDeleteTreatmentException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantDeleteTreatmentException()
        { }

        public CantDeleteTreatmentException(string message)
            : base(message)
        { }

        public CantDeleteTreatmentException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }

    public class CantFindTreatmentsException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantFindTreatmentsException()
        { }

        public CantFindTreatmentsException(string message)
            : base(message)
        { }

        public CantFindTreatmentsException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }

    public class CantFindCagesException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantFindCagesException()
        { }

        public CantFindCagesException(string message)
            : base(message)
        { }

        public CantFindCagesException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }

    public class CantFindOperationRoomsException : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantFindOperationRoomsException()
        { }

        public CantFindOperationRoomsException(string message)
            : base(message)
        { }

        public CantFindOperationRoomsException(string message, Exception inner)
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

    public class CantGetAnimalList : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantGetAnimalList()
        { }

        public CantGetAnimalList(string message)
            : base(message)
        { }

        public CantGetAnimalList(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class CantCreateSale : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantCreateSale()
        { }

        public CantCreateSale(string message)
            : base(message)
        { }

        public CantCreateSale(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class CantGetUnPaidPrescription : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantGetUnPaidPrescription()
        { }

        public CantGetUnPaidPrescription(string message)
            : base(message)
        { }

        public CantGetUnPaidPrescription(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class CantGetUnPaidTreatments : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public CantGetUnPaidTreatments()
        { }

        public CantGetUnPaidTreatments(string message)
            : base(message)
        { }

        public CantGetUnPaidTreatments(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class DateNotFound : Exception
    {
        public string ResourceReferenceProperty { get; set; }

        public DateNotFound()
        { }

        public DateNotFound(string message)
            : base(message)
        { }

        public DateNotFound(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}