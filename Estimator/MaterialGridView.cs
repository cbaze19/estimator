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

            this.Columns.Add("mColMaterial", "Material");
            this.Columns.Add("mColDescription", "Description");
            this.Columns.Add("mColQNTY", "QNTY");
            this.Columns.Add("mColUnit", "Unit");
            this.Columns.Add("mColUnitPrice", "Unit Price");
            this.Columns.Add("mColTotalPrice", "Total");

            this.Columns[4].ValueType = typeof(decimal);
            this.Columns[5].ValueType = typeof(decimal);

            this.Columns[0].Width = 165;
            this.Columns[1].Width = 165;
            this.Columns[2].Width = 50;

            this.Rows.Add("Panels", "", "", "Squares", 0.00, 0.00);
            this.Rows.Add("Cont. Clip", "", 0, "Feet", 0.15, 0.00);
            this.Rows.Add("Ins. Zee Rib", "", 0, "Feet", 0.10, 0.00);
            this.Rows.Add("Clip/Zee Screws", "", 0, "???", 0.09, 0.00);
            this.Rows.Add("Caulk", "", 0, "Tubes", 3.89, 0.00);
            this.Rows.Add("Insulation", "", 0, "???", 113.00, 0.00);
            this.Rows.Add("Decking", "", 0, "???", 25.00, 0.00);
            this.Rows.Add("Insulation/Decking Screws", "", 0, "???", 200.00, 0.00);
            this.Rows.Add("Underlayment", "", 0, "???", 40.00, 0.00);
            this.Rows.Add("Soffit Panels", "", 0, "???", 165.00, 0.00);
            this.Rows.Add("Ridge Vent", "", 0, "???", 10.00, 0.00);
            this.Rows.Add("Wall Panels", "", 0, "Squares", 165.00, 0.00);
            this.Rows.Add("Pop Rivets", "Prefinished", 0, "???", 58.00, 0.00);
            this.Rows.Add("Prefin Screws", "Self Drillers", 0, "???", 65.00, 0.00);
            this.Rows.Add("Prefin Screws", "Wood Grips", 0, "???", 125.00, 0.00);
            this.Rows.Add("Paint", "", 0, "???", 25.00, 0.00);
            this.Rows.Add("Misc", "", 0, "???", 0.00, 0.00);

            this.DataError += new DataGridViewDataErrorEventHandler(DataGrid_Error);
            this.CellFormatting += new DataGridViewCellFormattingEventHandler(DataGrid_CellFormatting);
            this.CellEndEdit += new DataGridViewCellEventHandler(DataGrid_EndEditCell);
            this.CurrentCellChanged += new EventHandler(DataGrid_CurrentCellChanged);

        }

        public void PerformCalculations()
        {
            DataGridViewCell panelQNTY = this.Rows[0].Cells[2];
            panelQNTY.Value = totalSquares;

            DataGridViewCell contClip = this.Rows[1].Cells[2];
            DataGridViewCell zeeRib = this.Rows[2].Cells[2];

            contClip.Value = (int)panelQNTY.Value * 75;
            zeeRib.Value = (int)panelQNTY.Value * 35;
            
            int contClipQNTY = int.Parse(this.Rows[1].Cells[2].Value.ToString());
            int zeeRibQNTY = int.Parse(this.Rows[2].Cells[2].Value.ToString());
            DataGridViewCell clipZeeScrews = this.Rows[3].Cells[2];
            clipZeeScrews.Value = (int)((contClipQNTY + zeeRibQNTY) / 1.5);

            DataGridViewCell caulkCell = this.Rows[4].Cells[2];
            caulkCell.Value = (int)panelQNTY.Value / 1.5;

            DataGridViewCell wallPanelsCell = this.Rows[11].Cells[2];
            wallPanelsCell.Value = wallPanelSquares;

            DataGridViewCell popRivetCell = this.Rows[12].Cells[2];
            popRivetCell.Value = (decimal)totalSquares / 100;

            DataGridViewCell prefinOneCell = this.Rows[13].Cells[2];
            prefinOneCell.Value = (decimal)totalSquares / 50;

            DataGridViewCell prefinTwoCell = this.Rows[14].Cells[2];
            prefinTwoCell.Value = (decimal)totalSquares / 25;

            DataGridViewCell paintCell = this.Rows[15].Cells[2];
            paintCell.Value = (decimal)totalSquares / 100;

            foreach (DataGridViewRow r in this.Rows)
            {
                r.Cells[5].Value = decimal.Parse(r.Cells[2].Value.ToString()) * decimal.Parse(r.Cells[4].Value.ToString());
            }
            
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
            this.BeginEdit(true);
        }

        private void DataGrid_EndEditCell(object sender, DataGridViewCellEventArgs e)
        {
            PerformCalculations();
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
