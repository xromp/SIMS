using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using SIMS.directives;
namespace SIMS.enrollment.student_inquiry
{
    public partial class studentInquiryFrm : Form
    {
        studentEnrollmentCtrl student = new studentEnrollmentCtrl();
        public studentInquiryFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student.removeStudent();
            student.personGet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImportExcel import = new ImportExcel();
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            file.Title= "Select file to be upload";
            file.Filter = "(*.xls)|*.xlsx";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user  
            {
                filePath = file.FileName; //get the path of the file  
                fileExt = Path.GetExtension(filePath); //get the file extension  
                try
                {
                    DataTable dtExcel = new DataTable();
                    dtExcel = import.ReadExcel(filePath, fileExt); //read excel file  
                    //dataGridView1.Visible = true;
                    //dataGridView1.DataSource = dtExcel;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
