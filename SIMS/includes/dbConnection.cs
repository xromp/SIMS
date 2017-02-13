using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
namespace SIMS.includes
{
    public class dbConnection
    {
        public SqlConnection conn;
        public SqlTransaction transac;
        public dbConnection() {
            var connStr = ConfigurationManager.ConnectionStrings["SIMSConnStr"].ConnectionString;
            conn = new SqlConnection(connStr);
        }
        protected void openConn() {
            conn.Close();
            conn.Open();
        }
        protected void closeConn() {
            transac.Commit();
            conn.Close();
        }
        protected void errorTransac() {
            transac.Rollback();
            conn.Close();
        }
    }
}
