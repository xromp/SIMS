﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using SIMS.includes;
namespace SIMS.enrollment.student_inquiry
{
    class StudentEnrollment
    {
        public void delete() {
            dbprocess proc = new dbprocess();
            proc.openConn();
            try
            {
                proc.transac = proc.conn.BeginTransaction("StudentInsert");
                proc.execQueryStr("DELETE FROM person00 WHERE person00id = 1");
                proc.execQueryStr("DELETE FROM person00 WHERE person00id = 2");
                proc.execQueryStr("DELETE FROM person00 WHERE person00id = 3");
                proc.execQueryStr("DELETE FROM person00 WHERE person00id = 3'");
                proc.closeConn();
            }
            catch (Exception)
            {
                proc.errorTransac();
            }
            
        }
    }
}