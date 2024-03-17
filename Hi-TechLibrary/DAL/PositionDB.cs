using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechLibrary.BLL;

namespace Hi_TechLibrary.DAL
{
    public static class PositionDB
    {
        // Returns a list of all positions in the database
        public static List<Position> GetAllRecords()
        {
            List<Position> listPositions = new List<Position>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Positions", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Position position;
            while (reader.Read())
            {
                position = new Position(Convert.ToInt32(reader["PositionID"]), reader["PositionTitle"].ToString(), reader["PositionDescription"].ToString());
                listPositions.Add(position);
            }
            conn.Close();
            return listPositions;
        }
    }
}
