using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIMS.shared.model;
namespace SIMS.dashboard
{
    class dashboardCtrl {

        dashboardFrm frm;

        public dashboardCtrl(dashboardFrm _frm) {
            person00 person = new person00();
            person00.get();
        }
    }
}
