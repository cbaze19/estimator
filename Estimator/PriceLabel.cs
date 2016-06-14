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
    public partial class PriceLabel : Label
    {

        public string baseText { get; set; }
        public string resultText { get; set; }

        public decimal value { get; set; }

        public PriceLabel()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.TextAlign = ContentAlignment.MiddleLeft;
        }

        public void setText(string t)
        {
            baseText = t;
            formatText();
            this.Text = resultText;
        }

        private void formatText()
        {
            value = decimal.Parse(baseText);
            resultText = value.ToString("C2");
        }
    }
}
