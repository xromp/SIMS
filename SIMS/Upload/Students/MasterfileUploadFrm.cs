using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Grid;
namespace SIMS.Upload.Students
{
    public partial class MasterfileUploadFrm : Form
    {
        MasterfileUploadCtrl upload;
        public MasterfileUploadFrm()
        {
            InitializeComponent();
            upload = new MasterfileUploadCtrl(this);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            upload.masterfilleUpload();
        }
    }
}
