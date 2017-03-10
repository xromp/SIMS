using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
namespace SIMS.includes
{
    public class DbConnection
    {
        public SqlConnection conn;
        public SqlTransaction transac;
        public SqlDataReader reader;
        public DbConnection() {
            var connStr = ConfigurationManager.ConnectionStrings["SIMSConnStr"].ConnectionString;
            conn = new SqlConnection(connStr);
        }
        public void openConn() {
            conn.Close();
            conn.Open();
        }
        public void closeConn() {
            reader.Close();
            transac.Commit();
            conn.Close();
        }
        public void errorTransac() {
            transac.Rollback();
            reader.Close();
            conn.Close();
        }
    }
}
