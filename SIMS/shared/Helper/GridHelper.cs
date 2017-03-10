using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
namespace SIMS.Shared.Helper
{
    class GridHelper
    {
        public GridControl gridControl;
        public DataTable dataTable;
        public GridHelper(GridControl _gc,DataTable _dt) {
            gridControl = _gc;
            dataTable = _dt;
        }
        public void setDataSource()
        {
            GridControl _gridControl = gridControl;
            GridView _gridView = (GridView)_gridControl.MainView;

            _gridControl.BeginUpdate();
            try
            {
                _gridView.Columns.Clear();

                _gridControl.DataSource = null;
                _gridControl.DataSource = dataTable;
                _gridControl.Refresh();
            }
            finally
            {
                _gridControl.EndUpdate();
            }

        }
    }
}
