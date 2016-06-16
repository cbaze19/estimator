using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            addGridRows();
            InitializeTextBoxListeners();
            Calculator.PerformCalculations(this);
            SetupGrids();
        }

        private void InitializeTextBoxListeners()
        {
            tbStandingSeamSquares.Validated += new EventHandler(TB_Validated);
            tbWallPanelSquares.Validated += new EventHandler(TB_Validated);
            tbSoffitPanelSquares.Validated += new EventHandler(TB_Validated);

            tbStandingSeamSquares.GotFocus += (sender, e) => nud_MouseDown(tbStandingSeamSquares, sender, null);
            tbWallPanelSquares.GotFocus += (sender, e) => nud_MouseDown(tbWallPanelSquares, sender, null);
            tbSoffitPanelSquares.GotFocus += (sender, e) => nud_MouseDown(tbSoffitPanelSquares, sender, null);

            tbStandingSeamSquares.MouseDown += (sender, e) => nud_MouseDown(tbStandingSeamSquares, sender, e);
            tbWallPanelSquares.MouseDown += (sender, e) => nud_MouseDown(tbWallPanelSquares, sender, e);
            tbSoffitPanelSquares.MouseDown += (sender, e) => nud_MouseDown(tbSoffitPanelSquares, sender, e);

            tbWaste.Validated += new EventHandler(TB_Validated);
            tbSalesTax.Validated += new EventHandler(TB_Validated);
            tbLaborBurden.Validated += new EventHandler(TB_Validated);

            gridViewMats.CellEndEdit += new DataGridViewCellEventHandler(TB_Validated);
            trimGridView.CellEndEdit += new DataGridViewCellEventHandler(TB_Validated);
            laborGridView.CellEndEdit += new DataGridViewCellEventHandler(TB_Validated);
            otherGridView.CellEndEdit += new DataGridViewCellEventHandler(TB_Validated);
        }

        private void SetupGrids()
        {
            foreach (DataGridViewColumn column in gridViewMats.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in trimGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in laborGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in otherGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            tbTrimPrice.Text = "$0.96";
            tbTrimPrice.baseText = "0.96";
        }

        private void nud_MouseDown(NumericUpDown nud, object sender, MouseEventArgs e)
        {
            nud.Select(0, tbStandingSeamSquares.Value.ToString().Length);
        }

        private void dgError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.Out.WriteLine(e.Context);

            if (e.Exception != null && e.Context.ToString().Contains(DataGridViewDataErrorContexts.Parsing.ToString()))
            {
                MessageBox.Show("Must be in currency format.");
            }
        }

        private void TB_Validated(object sender, EventArgs e)
        {
            // Do all calculations...
            Calculator.PerformCalculations(this);
        }

        private void endEditCell(object sender, DataGridViewCellEventArgs e)
        {
            Calculator.PerformCalculations(this);
        }

        private void addGridRows()
        {
            gridViewMats.Rows.Add("Panels", "", "", "Squares", 0.00, 0.00);
            gridViewMats.Rows.Add("Cont. Clip", "", 0, "Feet", 0.15, 0.00);
            gridViewMats.Rows.Add("Ins. Zee Rib", "", 0, "Feet", 0.10, 0.00);
            gridViewMats.Rows.Add("Clip/Zee Screws", "", 0, "???", 0.09, 0.00);
            gridViewMats.Rows.Add("Caulk", "", 0, "Tubes", 3.89, 0.00);
            gridViewMats.Rows.Add("Insulation", "", 0, "???", 113.00, 0.00);
            gridViewMats.Rows.Add("Decking", "", 0, "???", 25.00, 0.00);
            gridViewMats.Rows.Add("Insulation/Decking Screws", "", 0, "???", 200.00, 0.00);
            gridViewMats.Rows.Add("Underlayment", "", 0, "???", 40.00, 0.00);
            gridViewMats.Rows.Add("Soffit Panels", "", 0, "???", 165.00, 0.00);
            gridViewMats.Rows.Add("Ridge Vent", "", 0, "???", 10.00, 0.00);
            gridViewMats.Rows.Add("Wall Panels", "", 0, "Squares", 165.00, 0.00);
            gridViewMats.Rows.Add("Pop Rivets", "Prefinished", 0, "???", 58.00, 0.00);
            gridViewMats.Rows.Add("Prefin Screws", "Self Drillers", 0, "???", 65.00, 0.00);
            gridViewMats.Rows.Add("Prefin Screws", "Wood Grips", 0, "???", 125.00, 0.00);
            gridViewMats.Rows.Add("Paint", "", 0, "???", 25.00, 0.00);
            gridViewMats.Rows.Add("Misc", "", 0, "???", 0.00, 0.00);

            trimGridView.Rows.Add("Z-Closure", "", 0, "LF", 0.00, 0.00);
            trimGridView.Rows.Add("Panel Starter", "", 0, "LF", 0.00, 0.00);
            trimGridView.Rows.Add("Rec'r Cnt'r", "", 0, "LF", 0.00, 0.00);
            trimGridView.Rows.Add("Coping", "", 0, "LF", 0.00, 0.00);
            trimGridView.Rows.Add("Wall Flashing", "", 0, "LF", 0.00, 0.00);
            trimGridView.Rows.Add("Fascia", "", 0, "LF", 0.00, 0.00);
            trimGridView.Rows.Add("Hip/Ridge", "", 0, "LF", 0.00, 0.00);
            trimGridView.Rows.Add("Valley", "", 0, "LF", 0.00, 0.00);
            trimGridView.Rows.Add("Gutter", "", 0, "LF", 0.00, 0.00);
            trimGridView.Rows.Add("Downspout", "", 0, "LF", 0.00, 0.00);
            trimGridView.Rows.Add("Misc", "", 0, "LF", 0.00, 0.00);

            laborGridView.Rows.Add("Stocking & Setup", "", 0, "", 0.00, 0.00);
            laborGridView.Rows.Add("Shop Fabrication", "", 0, "", 0.00, 0.00);
            laborGridView.Rows.Add("Underlayment", "", 0, "", 0.00, 0.00);
            laborGridView.Rows.Add("Insulation/Decking", "", 0, "", 0.00, 0.00);
            laborGridView.Rows.Add("Roof Panels", "", 0, "", 0.00, 0.00);
            laborGridView.Rows.Add("Soffit Panels", "", 0, "", 0.00, 0.00);
            laborGridView.Rows.Add("Misc Panels", "", 0, "", 0.00, 0.00);
            laborGridView.Rows.Add("Gutter/Downspout Inft", "", 0, "", 0.00, 0.00);
            laborGridView.Rows.Add("Rec'r/Cnt'r Inft", "", 0, "", 0.00, 0.00);
            laborGridView.Rows.Add("Fascia/Coping Inft", "", 0, "", 0.00, 0.00);
            laborGridView.Rows.Add("Misc Trim", "", 0, "", 0.00, 0.00);

            for (int i = 0; i<15; i++)
            {
                otherGridView.Rows.Add("", "", 0, "", 0.00, 0.00);
            }
            
        }

    }
}