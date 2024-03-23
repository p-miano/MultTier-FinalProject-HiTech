using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechLibrary.BLL;

namespace Hi_TechLibrary.DAL
{
    public static class CustomerDB
    {
        public static DataSet GetAllRecords()
        {
            using(SqlConnection conn = UtilityDB.GetDBConnection())
            {
                string query = "SELECT * FROM Customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dsCustomers = new DataSet();
                try
                {
                    adapter.Fill(dsCustomers, "Customers");
                }
                catch (SqlException ex)
                {
                    throw new Exception("SQL Error: " + ex.Message);
                }
                return dsCustomers;
            }
        }

        public static DataSet GetAllRecordsWithSchema()
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                string query = "SELECT * FROM Customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet dsCustomers = new DataSet();
                try
                {
                    // Fill the DataSet and include schema information
                    adapter.FillSchema(dsCustomers, SchemaType.Source, "Customers");
                    adapter.Fill(dsCustomers, "Customers");
                }
                catch (SqlException ex)
                {
                    throw new Exception("SQL Error: " + ex.Message);
                }
                return dsCustomers;
            }
        }

    }
}
