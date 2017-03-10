using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using SIMS.includes;
using SIMS.Shared.Helper;
namespace SIMS.includes
{
    public class DbProcess : DbConnection
    {
        public SqlDataReader execQueryStr(string _sql)
        {
            SqlCommand cmd = new SqlCommand(_sql, conn, transac);
            cmd.CommandTimeout = 30;
            reader = cmd.ExecuteReader();
            reader.Close();
            return reader;
        }
        public SqlDataReader execStoredProc(string _sp, Dictionary<string,object> _params=null)
        {
            SqlCommand cmd = new SqlCommand(_sp, conn, transac);
            cmd.CommandTimeout = 30;
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (var item in _params.EmptyIfNull())
            {
                cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
