using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class CarRentalForm : Form
    {
        private int numDays = 0;
        private double rentalPrice = 0;

        public int NumDays
        {
            get { return numDays; }
            set { numDays = value; }
        }

        public double RentalPrice
        {
            get { return rentalPrice; }
            set { rentalPrice = value; }
        }

        public CarRentalForm()
        {
            InitializeComponent();
        }

        private void ComputeAndDisplayPrice()
        {
            NumDays = (int)numDaysSelector.Value;
            if (radCompact.Checked)
                RentalPrice = 19.95;
            if (radStandard.Checked)
                RentalPrice = 24.95;
            if (radLuxury.Checked)
                RentalPrice = 39;

            double totalPrice = NumDays*RentalPrice;

            lblTotalCharge.Text = String.Format("Total charge is {0}", totalPrice.ToString("C"));
        }


        private void radCompact_CheckedChanged(object sender, EventArgs e)
        {
            ComputeAndDisplayPrice();
        }

        private void radStandard_CheckedChanged(object sender, EventArgs e)
        {
            ComputeAndDisplayPrice();
        }

        private void radLuxury_CheckedChanged(object sender, EventArgs e)
        {
            ComputeAndDisplayPrice();
        }

        private void numDaysSelector_ValueChanged(object sender, EventArgs e)
        {
            ComputeAndDisplayPrice();
        }
    }
}
