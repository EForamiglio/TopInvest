﻿using System.Data.SqlClient;

namespace TopInvest.DAO
{
    public class ConBD
    {
        public static SqlConnection GetCon()
        {
            string conStr = "Data Source=LOCALHOST;Initial Catalog=TopInvest;user id=sa; password=123456";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            return con;
        }
    }
}
