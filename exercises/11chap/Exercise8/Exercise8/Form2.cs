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
    public partial class CarDetails : Form
    {
        Car c;
        public CarDetails(Car c)
        {
            this.c = c;
            InitializeComponent();
        }

        private void CarDetails_Load(object sender, EventArgs e)
        {

        }

        private void lblCarName_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }
    }
}
