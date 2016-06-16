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
            
            DataGridViewCell panelQNTY = form.gridViewMats.Rows[0].Cells[2];
            panelQNTY.Value = standingSeamSquares;

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


            decimal[] sos = { 0.5m, 0.75m, 0.75m, 1.75m, 1.25m, 1.25m, 1.25m, 1.75m, 1.5m, 1.4m, 4m };

            decimal soinftsum = 0m;
            foreach (DataGridViewRow row in form.trimGridView.Rows)
            {
                row.Cells[4].Value = sos[row.Index] * decimal.Parse(form.tbTrimPrice.baseText);
                row.Cells[5].Value = decimal.Parse(row.Cells[4].Value.ToString()) * decimal.Parse(row.Cells[2].Value.ToString());
                soinftsum = soinftsum + sos[row.Index] * decimal.Parse(row.Cells[2].Value.ToString());
            }

            form.lTotalFlatSheetsValue.Text = ((int)Math.Ceiling(soinftsum / 35)).ToString();

            foreach (DataGridViewRow r in form.gridViewMats.Rows)
            {
                r.Cells[5].Value = decimal.Parse(r.Cells[2].Value.ToString()) * decimal.Parse(r.Cells[4].Value.ToString());
            }


            form.plMatSubtotal.setText((GetColumnSum(form.gridViewMats, 5) + GetColumnSum(form.trimGridView, 5)).ToString());
            form.plMatTotalCost.setText((form.plMatSubtotal.value * (1 + form.tbWaste.percentageValue) * (1 + form.tbSalesTax.percentageValue)).ToString());




            form.laborGridView.Rows[4].Cells[2].Value = decimal.Parse(form.tbStandingSeamSquares.Value.ToString());
            form.laborGridView.Rows[5].Cells[2].Value = decimal.Parse(form.tbSoffitPanelSquares.Value.ToString());
            form.laborGridView.Rows[6].Cells[2].Value = decimal.Parse(form.tbWallPanelSquares.Value.ToString());

            form.laborGridView.Rows[7].Cells[2].Value = decimal.Parse(form.trimGridView.Rows[8].Cells[2].Value.ToString()) + decimal.Parse(form.trimGridView.Rows[9].Cells[2].Value.ToString());
            form.laborGridView.Rows[8].Cells[2].Value = decimal.Parse(form.trimGridView.Rows[2].Cells[2].Value.ToString());
            form.laborGridView.Rows[9].Cells[2].Value = decimal.Parse(form.trimGridView.Rows[3].Cells[2].Value.ToString()) + decimal.Parse(form.trimGridView.Rows[5].Cells[2].Value.ToString());

            form.laborGridView.Rows[10].Cells[2].Value = decimal.Parse(form.trimGridView.Rows[10].Cells[2].Value.ToString());

            foreach (DataGridViewRow r in form.laborGridView.Rows)
            {
                r.Cells[5].Value = decimal.Parse(r.Cells[2].Value.ToString()) * decimal.Parse(r.Cells[4].Value.ToString());
            }

            //form.tbLaborSubtotal.text = GetColumnSum(form.laborGridView, 5).ToString();
            form.plLaborSubtotal.setText(GetColumnSum(form.laborGridView, 5).ToString());
            form.plLaborTotal.setText((form.plLaborSubtotal.value * (1 + form.tbLaborBurden.percentageValue)).ToString());

            foreach (DataGridViewRow r in form.otherGridView.Rows)
            {
                if (!r.IsNewRow)
                    r.Cells[5].Value = decimal.Parse(r.Cells[2].Value.ToString()) * decimal.Parse(r.Cells[4].Value.ToString());
            }

            form.plOtherTotalCost.setText(GetColumnSum(form.otherGridView, 5).ToString());

            if (decimal.Parse(form.tbTotalSquares.Text) != 0)
            {
                form.plMatCostPerSquare.setText((form.plMatTotalCost.value / decimal.Parse(form.tbTotalSquares.Text)).ToString());
                form.plLaborCostPerSquare.setText((form.plLaborTotal.value / decimal.Parse(form.tbTotalSquares.Text)).ToString());
            }
        }

        static public decimal GetColumnSum(DataGridView dgv, int colIndex)
        {
            decimal sum = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                sum = sum + decimal.Parse(row.Cells[colIndex].Value.ToString());
            }

            return sum;
        }

    }
}
