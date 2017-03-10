using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using SIMS.includes;
namespace SIMS.shared.model
{
    public class person00
    {
        public int person00id { get; set; }
        public string lname { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string gender { get; set; }
        public string genderDesc { get; set; }

        public person00 ()
        {
        }
        #region Properties
        #endregion
        #region Queries
        public static List<person00> get()
        {
            DbProcess proc = new DbProcess();
            List<person00> person = new List<person00>();

            proc.openConn();
            proc.transac = proc.conn.BeginTransaction("person00Get");
            var reader = proc.execStoredProc("sp_person00Get");
            while (reader.Read())
            {
                person00 data = new person00();
                data.person00id= (int)reader["person00id"];
                data.lname = Convert.ToString(reader["lname"]);
                data.fname = Convert.ToString(reader["fname"]);
                data.mname = Convert.ToString(reader["mname"]);
                data.gender = Convert.ToString(reader["gender"]);
                data.genderDesc = data.gender == "M" ? "Male" : data.gender == "F" ? "Female" :"";
                person.Add(data);
            }
            proc.closeConn();
            return person;
        }
        #endregion

    }
}
