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
    public partial class CurrencyTextBox : TextBox
    {
        public string baseText { get; set; }
        public decimal currencyValue { get; set; }
        public string resultText { get; set; }

        public CurrencyTextBox()
        {
            InitializeComponent();
            Setup();
            Validate();
        }

        private void Setup()
        {
            this.Text = "0";

            this.MouseDown += CurrencyTextBox_MouseDown;
            this.Validating += CurrencyTextBox_Validating;
            this.GotFocus += CurrencyTextBox_GotFocus;
        }

        private void CurrencyTextBox_GotFocus(object sender, EventArgs e)
        {
            deFormat();
            this.SelectAll();
        }

        private void CurrencyTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            deFormat();
            this.SelectAll();
        }

        private void CurrencyTextBox_Validating(object sender, CancelEventArgs e)
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
                currencyValue = decimal.Parse(baseText);
                Format();
            }
            catch (Exception e)
            {
                MessageBox.Show("Not a valid currency format!");
                this.Text = "";
                this.baseText = "";
                this.Focus();
            }
        }

        private void Format()
        {
            resultText = currencyValue.ToString("C2");
            
            this.Text = resultText;
        }

        private void deFormat()
        {
            this.Text = baseText;
        }
    }
}
