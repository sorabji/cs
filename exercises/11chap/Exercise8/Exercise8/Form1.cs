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
            new CarDetails(cars[0]).ShowDialog();
            //lblInformation.Text = System.IO.Directory.GetCurrentDirectory();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cars = CarLib.CarHandler.GetCarList();
        }
    }
}
