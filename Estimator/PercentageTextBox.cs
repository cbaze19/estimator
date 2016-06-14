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
    public partial class PercentageTextBox : TextBox
    {

        public string baseText { get; set; }
        public decimal percentageValue { get; set; }
        public string resultText { get; set; }

        public PercentageTextBox()
        {
            InitializeComponent();
            Setup();
            Validate();
        }

        private void Setup()
        {
            this.Text = "0";
            this.MouseDown += PercentageTextBox_MouseDown;
            this.Validating += PercentageTextBox_Validating;
            this.GotFocus += PercentageTextBox_GotFocus;
        }

        private void PercentageTextBox_GotFocus(object sender, EventArgs e)
        {
            deFormat();
            this.SelectAll();
        }

        private void PercentageTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            deFormat();
            this.SelectAll();
        }

        private void PercentageTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validate();
        }

        private void Validate()
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                this.Text = "0";
            }

            baseText = this.Text;

            try
            {
                percentageValue = decimal.Parse(baseText)/100;
                Format();
            }
            catch (Exception e)
            {
                MessageBox.Show("Not a valid percentage format!");
                this.Text = "";
                this.baseText = "";
                this.Focus();
            }
        }

        private void Format()
        {
            resultText = percentageValue.ToString("P");
            this.Text = resultText;
        }

        private void deFormat()
        {
            this.Text = baseText;
        }

    }
}
