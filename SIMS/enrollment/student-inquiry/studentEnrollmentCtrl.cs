using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS.enrollment.student_inquiry
{
    class studentEnrollmentCtrl
    {
        public void removeStudent() {
            StudentEnrollment student = new StudentEnrollment();
            student.delete();
        }
    }
}
