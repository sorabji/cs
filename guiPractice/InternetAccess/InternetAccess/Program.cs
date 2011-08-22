using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InternetAccess
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            double totalPrice = 0;
            switch (MessageBox.Show("Do you want internet access?", "Internet Access", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    switch (MessageBox.Show("Do you want unlimited access?", "Type of Access", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                    {
                        case DialogResult.Yes:
                            totalPrice = 19.95;
                            break;
                        case DialogResult.No:
                            totalPrice = 10.95;
                            break;
                    }
                    break;
                case DialogResult.No:
                    break;
            }
            String result = String.Format("total price: {0}",totalPrice.ToString("C"));
            MessageBox.Show(result, "Total Price", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
