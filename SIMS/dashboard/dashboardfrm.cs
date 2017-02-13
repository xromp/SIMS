using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS.dashboard
{
    public partial class dashboardfrm : Form
    {
        dashboardCtrl dashboardCtrl;
        public dashboardfrm()
        {
            InitializeComponent();
            dashboardCtrl = new dashboardCtrl(this);
        }
    }
}
