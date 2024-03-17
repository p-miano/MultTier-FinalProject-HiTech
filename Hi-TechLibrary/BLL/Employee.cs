﻿using System;
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
        public int EmployeeID { get; } // Database will generate EmployeeID
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PositionID { get; set; }
        public int StatusID { get; set; }

        // Default constructor
        public Employee()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            PositionID = 0;
            StatusID = 1; // Default status is Active
        }

        // Parameterized constructor for new employee creation. Database will generate EmployeeID.
        public Employee(string firstName, string lastName, string email, string phoneNumber, int positionID, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            PositionID = positionID;
            StatusID = 1;
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

        // Method to get all employees from the database
        public List<Employee> GetAllEmployees()
        {
            return EmployeeDB.GetAllRecords();
        }

        // Method to search for an employee by EmployeeID
        public Employee SearchEmployeeById(int employeeID)
        {
            return EmployeeDB.SearchById(employeeID);
        }

        // Method to search for an employee by email
        public Employee SearchEmployeeByEmail(string email)
        {
            return EmployeeDB.SearchByEmail(email);
        }

        // Method to search for an employee by first name, last name or phone number
        public List<Employee> SearchEmployees(string searchStr)
        {
            return EmployeeDB.SearchByNameOrPhone(searchStr);
        }

        // Overloaded method to search for an employee by first name and last name together
        public List<Employee> SearchEmployees(string firstName, string lastName)
        {
            return EmployeeDB.SearchByFirstAndLastName(firstName, lastName);
        }
    }
}