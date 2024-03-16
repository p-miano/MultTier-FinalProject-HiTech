using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechLibrary.BLL;

namespace Hi_TechLibrary.DAL
{
    public class EmployeeDB
    {
        public static void SaveRecord(Employee employee)
        {
            // Open a connection
            SqlConnection conn = UtilityDB.GetDBConnection();
            // Create a command object
            SqlCommand cmd = new SqlCommand();
            // Set the Connection property
            cmd.Connection = conn;
            // Set the command text
            cmd.CommandText = "INSERT INTO Employees (FirstName, LastName, Email, PhoneNumber, PositionID, StatusID) " +
                "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @PositionID, @StatusID)";
            // Add values to the parameters
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
            cmd.Parameters.AddWithValue("@PositionID", employee.PositionID);
            cmd.Parameters.AddWithValue("@StatusID", employee.StatusID);
            // Execute the command
            cmd.ExecuteNonQuery();
            // Close the connection
            conn.Close();
        }
    }
}
