using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIMS.shared.model;
namespace SIMS.enrollment.student_inquiry
{
    class studentEnrollmentCtrl
    {
        public void removeStudent() {
            StudentEnrollment student = new StudentEnrollment();
            student.delete();
        }
        public void loadStudentInfo() {
        }
        public void personGet() {
            var data = person00.get().FirstOrDefault().genderDesc;
        }
    }
}
