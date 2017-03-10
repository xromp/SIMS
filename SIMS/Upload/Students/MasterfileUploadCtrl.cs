using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using DevExpress.XtraGrid;

using System.IO;
using System.Data;
using SIMS.directives;
using SIMS.Shared.Helper;
namespace SIMS.Upload.Students
{
    public class MasterfileUploadCtrl
    {
        MasterfileUploadFrm masterfileFrm;
        public MasterfileUploadCtrl(MasterfileUploadFrm _frm) {
            masterfileFrm = _frm;
        }
        public void masterfilleUpload() {
            ImportExcel import = new ImportExcel();
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            file.Title = "Select file to be upload";
            file.Filter = "(*.xls)|*.xlsx";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user  
            {
                filePath = file.FileName; //get the path of the file  
                fileExt = Path.GetExtension(filePath); //get the file extension  
                try
                {
                    DataTable dtExcel = new DataTable();
                    dtExcel = import.ReadExcel(filePath, fileExt); //read excel file  
                    GridHelper gridHelper = new GridHelper(masterfileFrm.gcMasterfileUpload, dtExcel);
                    gridHelper.setDataSource();
                    masterfileFrm.lblUploadCount.Text = string.Format("{0} record(s)", dtExcel.AsDataView().Count);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
