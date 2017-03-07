using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS.models
{
    class person00
    {
        public string lname { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public bool active { get; set; }
        
        public person00(string lname, string fname, string mname, bool active)
        {
            this.lname = lname;
            this.fname = fname;
            this.mname = mname;
            this.active = active;
        }

        public string getRemarks() {
            string remarks = "";
            if (this.active)
            {
                remarks = "IF,This is test remarks for constructor and class methods";
            }
            else {
                remarks = "ELSE, This is test remarks.";
            }
            return remarks;
        }
    }
}
