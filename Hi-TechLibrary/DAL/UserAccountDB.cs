using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechLibrary.BLL;

namespace Hi_TechLibrary.DAL
{
    public static class UserAccountDB
    {
        public static void SaveRecord(UserAccount userAccount)
        {
            // Open a connection
            SqlConnection conn = UtilityDB.GetDBConnection();
            // Create a command object
            SqlCommand cmd = new SqlCommand();
            // Set the Connection property
            cmd.Connection = conn;
            // Set the command text
            cmd.CommandText = "INSERT INTO UserAccount (EmployeeID, Username, Password, Role, StatusID, MustChangePassword) " +
                "VALUES (@EmployeeID, @Username, @Password, @UserRole, @StatusID, @MustChangePassword)";
            // Add values to the parameters
            cmd.Parameters.AddWithValue("@EmployeeID", userAccount.EmployeeID);
            cmd.Parameters.AddWithValue("@Username", userAccount.Username);
            cmd.Parameters.AddWithValue("@Password", userAccount.Password);
            cmd.Parameters.AddWithValue("@UserRole", userAccount.UserRole);
            cmd.Parameters.AddWithValue("@StatusID", userAccount.StatusID);
            cmd.Parameters.AddWithValue("@MustChangePassword", userAccount.MustChangePassword);
            // Execute the command
            cmd.ExecuteNonQuery();
            // Close the connection
            conn.Close();

        }

        public static List<UserAccount> GetAllRecords()
        {
            List<UserAccount> listUsers = new List<UserAccount>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserAccount", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            UserAccount user;
            while (reader.Read())
            {
                user = new UserAccount();
                user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                // Convert the UserRole from string to UserRole enum
                string roleString = reader["UserRole"].ToString();
                if (Enum.TryParse<UserRole>(roleString, out UserRole role))
                {
                    user.UserRole = role;
                }
                else
                {
                    user.UserRole = UserRole.Default;
                }
                user.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                user.DateModified = reader["DateModified"] as DateTime?;
                user.StatusID = Convert.ToInt32(reader["StatusID"]);
                user.MustChangePassword = Convert.ToBoolean(reader["MustChangePassword"]);
                listUsers.Add(user);
            }
            conn.Close();
            return listUsers;
        }

        // Method to search for a user by UserID or EmployeeID
        public static UserAccount Search(int id)
        {
            UserAccount user = new UserAccount();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserAccount WHERE UserID = @ID OR EmployeeID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                // Convert the UserRole from string to UserRole enum
                string roleString = reader["UserRole"].ToString();
                if (Enum.TryParse<UserRole>(roleString, out UserRole role))
                {
                    user.UserRole = role;
                }
                else
                {
                    user.UserRole = UserRole.Default;
                }
                user.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                user.DateModified = reader["DateModified"] as DateTime?;
                user.StatusID = Convert.ToInt32(reader["StatusID"]);
                user.MustChangePassword = Convert.ToBoolean(reader["MustChangePassword"]);
            }
            conn.Close();
            return user;
        }

        // Overloaded method to search for a user by one string parameter (username or role)
        public static List<UserAccount> Search(string searchStr)
        {
            List<UserAccount> listUsers = new List<UserAccount>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserAccount WHERE Username LIKE @SearchStr OR UserRole LIKE @SearchStr", conn);
            cmd.Parameters.AddWithValue("@SearchStr", "%" + searchStr + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            UserAccount user;
            while (reader.Read())
            {
                user = new UserAccount();
                user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                // Convert the UserRole from string to UserRole enum
                string roleString = reader["UserRole"].ToString();
                if (Enum.TryParse<UserRole>(roleString, out UserRole role))
                {
                    user.UserRole = role;
                }
                else
                {
                    user.UserRole = UserRole.Default;
                }
                user.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                user.DateModified = reader["DateModified"] as DateTime?;
                user.StatusID = Convert.ToInt32(reader["StatusID"]);
                user.MustChangePassword = Convert.ToBoolean(reader["MustChangePassword"]);
                listUsers.Add(user);
            }
            conn.Close();
            return listUsers;
        }

        public static void UpdateRecord(UserAccount user)
        {
            // Open a connection
            SqlConnection conn = UtilityDB.GetDBConnection();
            // Create a command object
            SqlCommand cmd = new SqlCommand();
            // Set the Connection property
            cmd.Connection = conn;
            // Set the command text
            cmd.CommandText = "UPDATE UserAccount SET Username = @Username, Password = @Password, UserRole = @UserRole, DateModified = @DateModified, StatusID = @StatusID, MustChangePassword = @MustChangePassword " +
                "WHERE UserID = @UserID";
            // Add values to the parameters
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@UserRole", user.UserRole);
            cmd.Parameters.AddWithValue("@DateModified", user.DateModified);
            cmd.Parameters.AddWithValue("@StatusID", user.StatusID);
            cmd.Parameters.AddWithValue("@MustChangePassword", user.MustChangePassword);
            cmd.Parameters.AddWithValue("@UserID", user.UserID);
            // Execute the command
            cmd.ExecuteNonQuery();
            // Close the connection
            conn.Close();
        }

        public static void DeleteRecord(int userID)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM UserAccount WHERE UserID = @UserID", conn);
            cmd.Parameters.AddWithValue("@UserID", userID);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
