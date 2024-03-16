using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechLibrary.DAL;

namespace Hi_TechLibrary.BLL
{
    public class Employee
    {
        // Properties
        public int EmployeeID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PositionID { get; set; }
        public string Department { get; set; }
        public int StatusID { get; set; }

        // Default constructor
        public Employee()
        {
            EmployeeID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            PositionID = 0;
            Department = string.Empty;
            StatusID = 0;
        }

        // Parameterized constructor for new employee creation. Database will generate EmployeeID.
        public Employee(string firstName, string lastName, string email, string phoneNumber, int positionID, string department, int statusID)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            PositionID = positionID;
            Department = department;
            StatusID = statusID;
        }

        // Overloaded constructor for retrieving an existing employee from the database.
        public Employee(int employeeID, string firstName, string lastName, string email, string phoneNumber, int positionID, string department, int statusID)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            PositionID = positionID;
            StatusID = statusID;
        }

        // Method to save an employee to the database
        public void SaveEmployee(Employee employee)
        {
            EmployeeDB.SaveRecord(employee);
        }
    }
}