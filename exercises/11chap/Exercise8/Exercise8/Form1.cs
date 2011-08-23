using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise8
{
    public partial class MainForm : Form
    {
        List<Car> cars;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                lblError.Text = "Please Select a Car!";
            }
            else
            {
                lblError.Text = ""; 
                new CarDetails(cars[listBox.SelectedIndex]).ShowDialog();
                listBox.SelectedIndex = -1;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cars = CarLib.CarHandler.GetCarList();
            listBox.Items.AddRange(cars.ToArray());
            lblError.Text = ""; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
