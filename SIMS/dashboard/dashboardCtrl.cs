using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIMS.shared.model;
namespace SIMS.dashboard
{
    class dashboardCtrl {

        dashboardfrm frm;

        public dashboardCtrl(dashboardfrm _frm) {
            person00 person = new person00();
            person.personGet();// get all person
        }
    }
}
