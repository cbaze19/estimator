using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimator
{
    static class Calculator
    {

        static public void PerformCalculations(MainForm form)
        {

            int standingSeamSquares = (int)form.tbStandingSeamSquares.Value;
            int wallPanelSquares = (int)form.tbWallPanelSquares.Value;
            int soffitPanelSquares = (int)form.tbSoffitPanelSquares.Value;

            int totalSquares = standingSeamSquares + wallPanelSquares + soffitPanelSquares;

            form.tbTotalSquares.Text = totalSquares.ToString();

            form.gridViewMats.totalSquares = int.Parse(form.tbTotalSquares.Text);
            form.gridViewMats.standingSeamSquares = int.Parse(form.tbStandingSeamSquares.Text);
            form.gridViewMats.wallPanelSquares = int.Parse(form.tbWallPanelSquares.Text);
            form.gridViewMats.soffitPanelSquares = int.Parse(form.tbSoffitPanelSquares.Text);

            //form.gridViewMats.PerformCalculations();
            DataGridViewCell panelQNTY = form.gridViewMats.Rows[0].Cells[2];
            panelQNTY.Value = totalSquares;

            DataGridViewCell contClip = form.gridViewMats.Rows[1].Cells[2];
            DataGridViewCell zeeRib = form.gridViewMats.Rows[2].Cells[2];

            contClip.Value = (int)panelQNTY.Value * 75;
            zeeRib.Value = (int)panelQNTY.Value * 35;

            int contClipQNTY = int.Parse(form.gridViewMats.Rows[1].Cells[2].Value.ToString());
            int zeeRibQNTY = int.Parse(form.gridViewMats.Rows[2].Cells[2].Value.ToString());
            DataGridViewCell clipZeeScrews = form.gridViewMats.Rows[3].Cells[2];
            clipZeeScrews.Value = (int)((contClipQNTY + zeeRibQNTY) / 1.5);

            DataGridViewCell caulkCell = form.gridViewMats.Rows[4].Cells[2];
            caulkCell.Value = (int)panelQNTY.Value / 1.5;

            DataGridViewCell wallPanelsCell = form.gridViewMats.Rows[11].Cells[2];
            wallPanelsCell.Value = wallPanelSquares;

            DataGridViewCell popRivetCell = form.gridViewMats.Rows[12].Cells[2];
            popRivetCell.Value = (decimal)totalSquares / 100;

            DataGridViewCell prefinOneCell = form.gridViewMats.Rows[13].Cells[2];
            prefinOneCell.Value = (decimal)totalSquares / 50;

            DataGridViewCell prefinTwoCell = form.gridViewMats.Rows[14].Cells[2];
            prefinTwoCell.Value = (decimal)totalSquares / 25;

            DataGridViewCell paintCell = form.gridViewMats.Rows[15].Cells[2];
            paintCell.Value = (decimal)totalSquares / 100;

            foreach (DataGridViewRow r in form.gridViewMats.Rows)
            {
                r.Cells[5].Value = decimal.Parse(r.Cells[2].Value.ToString()) * decimal.Parse(r.Cells[4].Value.ToString());
            }


            form.plMatSubtotal.setText(GetColumnSum(form.gridViewMats, 5).ToString());
            form.plMatTotalCost.setText((form.plMatSubtotal.value * (1 + form.tbWaste.percentageValue) * (1 + form.tbSalesTax.percentageValue)).ToString());

            if (decimal.Parse(form.tbTotalSquares.Text) != 0)
                form.plMatCostPerSquare.setText((form.plMatTotalCost.value / decimal.Parse(form.tbTotalSquares.Text)).ToString());
        }

        static public decimal GetColumnSum(DataGridView dgv, int colIndex)
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
