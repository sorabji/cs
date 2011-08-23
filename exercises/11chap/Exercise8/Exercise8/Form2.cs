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
        Car car;
        public CarDetails(Car car)
        {
            this.car = car;
            InitializeComponent();
        }

        private void CarDetails_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = car.Image;
            pictureBox1.Height = car.Image.Height;
            pictureBox1.Width = car.Image.Width;

            lblYear.Text = car.Year;
            lblMake.Text = car.Make;
            lblModel.Text = car.Model;
            lblColor.Text = car.Color;

            llblLink.Links.Add(0,0,"http://www.google.com/search?q=" + car.Query);
        }

        private void lblCarName_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //this.DestroyHandle();
            this.Dispose();
        }

        private void llblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }


    }
}
