using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechLibrary.DAL;

namespace Hi_TechLibrary.BLL
{
    public class Customer
    {
        // Properties
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public int CreditLimit { get; set; }
        public int StatusID { get; set; }

        // Default constructor
        public Customer()
        {
            Name = string.Empty;
            Street = string.Empty;
            StreetNumber = string.Empty;
            City = string.Empty;
            PostalCode = string.Empty;
            PhoneNumber = string.Empty;
            FaxNumber = string.Empty;
            CreditLimit = 0;
            StatusID = 1; // Default status is Active
        }

        // Parameterized constructor for new customer creation. Database will generate CustomerID.
        public Customer(string name, string street, string streetNumber, string city, string postalCode, string phoneNumber, string faxNumber, int creditLimit)
        {
            Name = name;
            Street = street;
            StreetNumber = streetNumber;
            City = city;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
            CreditLimit = creditLimit;
            StatusID = 1;
        }

        // Overloaded constructor for retrieving an existing customer from the data set.
        public Customer(int customerID, string name, string street, string streetNumber, string city, string postalCode, string phoneNumber, string faxNumber, int creditLimit, int statusID)
        {
            CustomerID = customerID;
            Name = name;
            Street = street;
            StreetNumber = streetNumber;
            City = city;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
            CreditLimit = creditLimit;
            StatusID = statusID;
        }

        // Method to get all customers from the database
        public DataSet GetAllCustomers()
        {
            return CustomerDB.GetAllRecordsWithSchema();
        }
    }
}
