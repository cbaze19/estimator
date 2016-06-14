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
            InitializeTextBoxListeners();
            PerformCalculations();
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

            tbTotalMatCost.Text = "100";
            //tbMatSubtotal.ReadOnly = true;
        }

        private void nud_MouseDown(NumericUpDown nud, object sender, MouseEventArgs e)
        {
            nud.Select(0,tbStandingSeamSquares.Value.ToString().Length);
        }

        private void dgError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.Out.WriteLine(e.Context);

            if (e.Exception != null && e.Context.ToString().Contains(DataGridViewDataErrorContexts.Parsing.ToString()))
            {
                MessageBox.Show("Must be currency format.");
            }
        }

        private void TB_Validated(object sender, EventArgs e)
        {
            // Do all calculations...
            PerformCalculations();
        }

        private void endEditCell(object sender, DataGridViewCellEventArgs e)
        {
            PerformCalculations();
        }

        private void PerformCalculations()
        {
            int standingSeamSquares = (int)tbStandingSeamSquares.Value;
            int wallPanelSquares = (int)tbWallPanelSquares.Value;
            int soffitPanelSquares = (int)tbSoffitPanelSquares.Value;

            int totalSquares = standingSeamSquares + wallPanelSquares + soffitPanelSquares;

            tbTotalSquares.Text = totalSquares.ToString();

            gridViewMats.totalSquares = int.Parse(tbTotalSquares.Text);
            gridViewMats.standingSeamSquares = int.Parse(tbStandingSeamSquares.Text);
            gridViewMats.wallPanelSquares = int.Parse(tbWallPanelSquares.Text);
            gridViewMats.soffitPanelSquares = int.Parse(tbSoffitPanelSquares.Text);

            gridViewMats.PerformCalculations();

            tbMatSubtotal.Text = GetColumnSum(gridViewMats, 5).ToString();
        }

        private decimal GetColumnSum(DataGridView dgv, int colIndex)
        {
            decimal sum = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                sum = sum + (decimal)row.Cells[colIndex].Value;
            }

            return sum;
        }

    }
}
