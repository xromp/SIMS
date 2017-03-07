using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS.enrollment.student_inquiry
{
    public partial class studentInquiryfrm : Form
    {
        studentEnrollmentCtrl student = new studentEnrollmentCtrl();
        public studentInquiryfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student.removeStudent();
            student.personGet();
        }
    }
}
