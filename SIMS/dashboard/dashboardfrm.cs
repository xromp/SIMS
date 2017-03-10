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
    public partial class dashboardFrm : Form
    {
        dashboardCtrl dashboardCtrl;
        public dashboardFrm()
        {
            InitializeComponent();
            dashboardCtrl = new dashboardCtrl(this);
        }
    }
}
