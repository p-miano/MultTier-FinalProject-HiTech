using System.Configuration;
using System.Data.SqlClient;
namespace Hi_TechLibrary.DAL
{
    public static class UtilityDB
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; // Pass the name of the connection string to the ConnectionString property. The connection string is stored in the App.config file.
            conn.Open();
            return conn;
        }
    }
}
