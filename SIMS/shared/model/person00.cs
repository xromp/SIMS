using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using SIMS.includes;
namespace SIMS.shared.model
{
    public class person00:dbprocess
    {
        public person00 ()
        {
            
        }
        public DataTable personGet() {
            DataTable dt = new DataTable();
            openConn();
            dt.Load(execQueryStr("SELECT * FROM person00"));
            return dt;
        }
    }
}
