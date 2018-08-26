//Cade Snedden
//Advanced C#

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module02FahrenheitToCelsius
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /* Button to exit program enviroment */
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /* Converts Fahrenheit to Celsius */
        private void btnConFah_Click(object sender, EventArgs e)
        {
            string fah = txtBoxFah.Text;
            int f;
            bool conF = Int32.TryParse(fah, out f);

            float conversion = ((f - 32) * 5/9);

            lblCel.Text = conversion.ToString();

        }

        /* Button to reset the Fahrenheit value */
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxFah.Text = "0";
        }
    }
}
