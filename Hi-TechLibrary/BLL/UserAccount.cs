﻿using Hi_TechLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_TechLibrary.BLL
{
    public class UserAccount
    {
        // Properties
        public int UserID { get; } // UserID is auto-generated by the database
        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole UserRole { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int StatusID { get; set; }
        public bool MustChangePassword { get; set; }

        // Default constructor
        public UserAccount()
        {
            Username = string.Empty;
            Password = string.Empty;
            UserRole = UserRole.Default;
            DateCreated = DateTime.Now; // Default to the current time
            StatusID = 1; // Default status is Active
            MustChangePassword = true; // New users must change their password
        }

        // Parameterized constructor for new user creation
        public UserAccount(int employeeID, string username, string password, UserRole userRole, int statusID)
        {
            EmployeeID = employeeID;
            Username = username;
            Password = password; 
            UserRole = userRole;
            DateCreated = DateTime.Now; 
            StatusID = statusID;
            MustChangePassword = true;
        }

        // Method to save a user to the database
        public void SaveUserAccount(UserAccount userAccount)
        {
            UserAccountDB.SaveRecord(userAccount);
        }

        // Method to get all users from the database
        public static List<UserAccount> GetAllUsers()
        {
            return UserAccountDB.GetAllRecords();
        }

        // Method to search for a user by UserID or EmployeeID
        public static UserAccount SearchUser(int id)
        {
            return UserAccountDB.Search(id);
        }

        // Method to update a user in the database
        public static void UpdateUser(UserAccount user)
        {
            UserAccountDB.UpdateRecord(user);
        }

        // Method to delete a user from the database
        public static void DeleteUser(int userID)
        {
            UserAccountDB.DeleteRecord(userID);
        }
    }
}