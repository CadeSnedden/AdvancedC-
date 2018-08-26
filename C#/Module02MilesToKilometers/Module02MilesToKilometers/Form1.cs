using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Module02MilesToKilometers
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /* btnClose to exit program enviroment */
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConMiles_Click(object sender, EventArgs e)
        {
            const double conversion = 1.6;
            double miles = Double.Parse(txtBoxMiles.Text);
            double kilometers = Double.Parse(txtBoxKilometers.Text);

            txtBoxKilometers.Text = (miles * conversion).ToString();

        }

        private void btnConKilo_Click(object sender, EventArgs e)
        {
            const double conversion = 1.6;
            double miles = Double.Parse(txtBoxMiles.Text);
            double kilometers = Double.Parse(txtBoxKilometers.Text);

            txtBoxMiles.Text = (kilometers / conversion).ToString();
        }
    }
}
