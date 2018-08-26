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

namespace Module02CarRental
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            const int dailyCharge = 20;
            const double mileCharge = 0.25;
            int days = int.Parse(txtBoxDays.Text);
            double miles = Double.Parse(txtBoxMiles.Text);

            lblTotal.Text = ((days * dailyCharge) + (miles * mileCharge)).ToString();
            
        }
    }
}
