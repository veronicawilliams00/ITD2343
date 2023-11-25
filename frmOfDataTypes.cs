using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module4Project
{
    /**********************************************
     * Veronica Williams
     * ITD-2043 Object Oriented Programming Using C#
     * Instructor - Greg Morris
     * Due Date - 10/03/2023
     * ********************************************/
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPut.Text = " ";
        }

        //Takes the values x and y and displays the results in the label put
        private void btnByte_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 2;
            int result1 = x + y; //Uses the addition property

            lblPut.Text = result1.ToString() + " " + "=" + " " + x.ToString() + " " + "+" + " " + y.ToString();

        }

        //Takes the int x - y and displays the results in the lblPut
        private void btnShort_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 2;
            int result2 = x - y; //Uses the subtraction property

            lblPut.Text = result2.ToString() + " " + "=" + " " + x.ToString() + " " + "-" + " " + y.ToString();
        }

        //Takes the int x / y and displays the results in the lblPut
        private void btnInt_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 2;
            int result3 = x / y; //Uses the division property

            lblPut.Text = result3.ToString() + " " + "=" + " " + x.ToString() + " " + "/" + " " + y.ToString();
        }

        //Takes the int x % y and displays the results in the lblPut
        private void btnLong_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 4;
            int result4 = x % y; //Uses the modulus property

            lblPut.Text = result4.ToString() + " " + "=" + " " + x.ToString() + " " + "%" + " " + y.ToString();
        }

        //Takes the floating x and y numbers to display the float result in the lblPut
        private void btnFloat_Click(object sender, EventArgs e)
        {
            float x = 2.12345567f;
            float y = 4.01f;
            float result5 = x % y; //Uses the modulus property

            lblPut.Text = result5.ToString() + " " + "=" + " " + x.ToString() + " " + "%" + " " + y.ToString();
        }

        //Takes the double x and integer y divides them and displays it in the lblPut
        private void btnDouble_Click(object sender, EventArgs e)
        {
            double x = 2.67891356407642;
            int y = 4;
            double result6 = (x / y); //Uses the division property along with double integer

            lblPut.Text = result6.ToString() + " " + "=" + " " + x.ToString() + " " + "/" + " " + y.ToString();
        }

        //Takes the decimal x and y, displays the results in lblPut
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal x = 2.1699999999999999999999999999999m;
            decimal y = 100.56m;  //m signifies that it is a decimal value
            decimal result7 = (x * y);

            lblPut.Text = result7.ToString() + " " + "=" + " " + x.ToString() + " " + "*" + " " + y.ToString();
        }

        //Takes the double of x and y to display the result in lblPut
        private void btnPow_Click(object sender, EventArgs e)
        {
            double x = 2;
            double y = 4;
            double result8 = Math.Pow(x, y); //Two to the Power of 4

            lblPut.Text = result8.ToString() + " " + "=" + " " + x.ToString() + " " + "Pow" + " " + y.ToString();
        }

        //Takes the double of x and integer y to display the rounded answer in lblPut
        private void btnRound_Click(object sender, EventArgs e)
        {
            double x = 4.523;
            int y = 2;
            double result9 = Math.Round(x, y); //Rounds x to the y decimal place

            lblPut.Text = result9.ToString() + " " + "=" + " " + x.ToString() + " " + "*" + " " + y.ToString();
        }

        //Takes the double x and displays the squareroot in lblPut
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double x = 25;
            double result10 = Math.Sqrt(x);  // Squareroot of x 

            lblPut.Text = result10.ToString() + " " + "=" + " " + "sqrt" + " " + x.ToString();
        }
    }
}
