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
        private double toppings = 0, place = 0;

        public double Place
        {
            get { return place; }
            set { place = value; }
        }

        public double Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
