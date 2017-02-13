using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using SIMS.includes;
namespace SIMS.includes
{
    public class dbprocess : dbConnection
    {
        protected SqlDataReader execQueryStr(string _sql)
        {
            SqlCommand cmd = new SqlCommand(_sql, conn, transac);
            cmd.CommandTimeout = 30;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
