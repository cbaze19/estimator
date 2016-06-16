using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimator
{
    public partial class MaterialGridView : DataGridView
    {

        public int totalSquares { get; set; }
        public int standingSeamSquares { get; set; }
        public int wallPanelSquares { get; set; }
        public int soffitPanelSquares { get; set; }

        public MaterialGridView()
        {
            InitializeComponent();
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {

            this.RowHeadersVisible = false;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.BorderStyle = BorderStyle.None;
            this.AllowUserToOrderColumns = false;

            this.DataError += new DataGridViewDataErrorEventHandler(DataGrid_Error);
            this.CellFormatting += new DataGridViewCellFormattingEventHandler(DataGrid_CellFormatting);
            this.CurrentCellChanged +=  new EventHandler(DataGrid_CurrentCellChanged);

        }

        private void DataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCell cell = this.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (e.Value != null && (cell.ColumnIndex == 4 || cell.ColumnIndex == 5))
            {

                if (cell.IsInEditMode)
                {
                    e.Value = e.Value.ToString();
                }
                else
                {
                    decimal val = decimal.Parse(e.Value.ToString());
                    string str = val.ToString("C2");
                    e.Value = str;
                }
            }
        }

        private void DataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                this.BeginEdit(true);
            }
            catch (Exception ex)
            {

            }
            //this.BeginEdit(true);
        }

        private void DataGrid_Error(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context.ToString().Contains(DataGridViewDataErrorContexts.Parsing.ToString()))
            {
                MessageBox.Show("Must be currency format.");
            }
        }
    }
}
