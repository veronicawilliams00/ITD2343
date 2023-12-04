using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCheckDigitProject
{
    public partial class frmCheckDigit : Form
    {
        public frmCheckDigit()
        {
            InitializeComponent();
        }
        /**********************************************
        * Name: Veronica Williams
        * Class: ITD-2343 Obj. Oriented Programming C#
        * Instructor: Greg Morris
        * Due Date: 11/07/2023
        * *********************************************/

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAcc.Text = " ";
            txtCon.Text = " ";
            txtPay.Text = " ";
            lblStatus.Text = " ";

            txtAcc.Focus();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            try
            {
                decimal txtPay = 0m;

                if (txtAcc.Text != txtCon.Text)
                {
                    lblStatus.Text = "Please reconfirm you account numbers.";
                }
                else if (txtAcc.MaxLength > 10)
                {
                    lblStatus.Text = "Number is too long.";
                }
                else if (txtPay == 0)
                {
                    lblStatus.Text = "Please enter a value greater than 0.";
                }
                else
                {
                    DateTime currentDate = DateTime.Today;

                    lblStatus.Text = "Date: " + currentDate.ToLongDateString() + "\n" + "\n" + "Your Account: " + txtAcc + "\n" + "Your payment of: " + txtPay + "\n" + "Will be processed. Thank you!";

                }
            }

            catch(Exception)
            {
                lblStatus.Text = "Please enter the required information.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblStatus.Text = " ";
        }
    }
}
