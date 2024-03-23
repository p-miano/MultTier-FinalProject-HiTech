﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechLibrary.BLL;
using System.Data.SqlClient;

namespace Hi_TechLibrary.DAL
{
    public static class StatusDB
    {
        public static DataSet dsStatus = new DataSet();

        public static void LoadStatus()
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Status ORDER BY StatusID", conn);
                dsStatus.Clear();
                adapter.Fill(dsStatus, "Status");
            }
        }

        public static List<string> GetStatusList()
        {
            List<string> statusList = new List<string>();
            foreach (DataRow row in dsStatus.Tables["Status"].Rows)
            {
                statusList.Add(row["State"].ToString());
            }
            return statusList;
        }
    }
}
