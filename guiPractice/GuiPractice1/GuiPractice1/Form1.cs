using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiPractice1
{
    public partial class Form1 : Form
    {
        private double toppings = 0, 
                       dineInOrOut = 0,
                       totalPrice = 0;

        public double DineInOrOut
        {
            get { return dineInOrOut; }
            set { 
                dineInOrOut = value; 
                totalPrice = dineInOrOut + toppings; 
            }
        }

        public double Toppings
        {
            get { return toppings; }
            set { 
                toppings = value; 
                totalPrice = dineInOrOut + toppings; 
            }
        }

        public double TotalPrice
        {
            get { return totalPrice; }
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateToppingsPrice()
        {
            Toppings = 0;
            if (chkPepperoni.Checked)
                Toppings += 1;
            if (chkSausage.Checked)
                Toppings += 1;
            if (chkOnion.Checked)
                Toppings += 1;
            //TotalPrice = 0;
        }

        private void UpdateDineInOrOutPrice()
        {
            DineInOrOut = 0;
            if (radDelivery.Checked)
                DineInOrOut+=5;
            if (radTakeOut.Checked)
                DineInOrOut+=2;
            //TotalPrice = 0;
        }

        private void SetLabelText()
        {
            lblPrice.Text = String.Format("The cost is {0}", TotalPrice.ToString("C"));
        }

        private void UpdateLabel()
        {
            UpdateToppingsPrice();
            UpdateDineInOrOutPrice();
            SetLabelText();       
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void chkSausage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void radTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void radDelivery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("The cost is {0}", TotalPrice.ToString("C")), "Total Price", MessageBoxButtons.OK);
        }
    }
}
