using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2WilliamsProject
{
    public partial class Form1 : Form
    {
      

        /**********************************************
         * Name: Veronica Williams
         * Class: ITD-2343 Obj. Oriented Programming C#
         * Instructor: Greg Morris
         * Due Date: 11/07/2023
         * *********************************************/
        public Form1()
        {
            InitializeComponent();
        }

        //Constants
        const int MODULUS = 0;
        const int FACTORIAL = 1;
        const int FIBONACCI = 2;

        private decimal CalcMethod(decimal dOp1, decimal dOp2, int cOperation)
        {

            if (cOperation == MODULUS)
                    return dOp1 % dOp2;
            
            else if (cOperation == FACTORIAL)
                return dOp1 + dOp1;

            else if (cOperation == FIBONACCI)
                return dOp1 * dOp1;

            else
                return 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblMessage.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModS_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "The Mod DO button will show the modulus of the first operand mod and the second operand. This is done by dividing the first operand by the second operand and providing a remainder of the solution." +
                "\n" + "\n" + "For Example: 5 Mod 2 will result in a value of 1." + "\n" + "\n" + "For Modulus Operations both operands should have a positive value and posititve whole numbers.";

            btnModD.Enabled = true;
            
        }

        private void btnModD_Click(object sender, EventArgs e)
        {
            decimal dOp1 = 0.0m;
            decimal dOp2 = 0.0m;
            decimal dAnswer = 0.0m;
            string sOp1 = "";
            string sOp2 = "";
            string szAnswer = "";
            string szEquation = "";

            sOp1 = txtOp1.Text;
            sOp2 = txtOp2.Text;

            dOp1 = Convert.ToDecimal(sOp1);
            dOp2 = Convert.ToDecimal(sOp2);

            dAnswer = CalcMethod(dOp1, dOp2, MODULUS);


            szAnswer = dAnswer.ToString();

            szEquation = sOp1 + " % " + sOp2 + " = " + szAnswer;

            lblMessage.Text = "";
            lblMessage.Text = szEquation;

        }

        private void btnFactS_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "The Factorial DO button will present the value of the first operand's factorial. This is calculated by multiplying the by each intiger value from the entered value down to one" +
                "\n" + "\n" + "For example: 6! = 6 * 5 * 4 * 3 * 2 * 1, 720" + "\n" + "\n" + "For Factorial Operations operand 1 is required as a positive whole number.";

            btnFactD.Enabled = true;
            txtOp2.Enabled = false;
        }

        private void btnFibS_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "The Fibonacci DO button will present the value of the first operand's fibonacci step value. This is calculated by adding the values of the two numbers, starting at 1 and using the resulting values for the next step of calculation" +
                "\n" + "\n" + "The Fibonacci Sequence looks similar to this - 1, 1, 2, 3, 5, 8, 13, 21, ..." + "\n" + "\n" + "For instance fib(6) is the sixth element of the list or 8." + "\n" + "\n" + "For the Fibonacci sequence operand 1 is required as a positvie whole number.";
            
            btnFibD.Enabled = true;
            txtOp2.Enabled = false;
        }

        private void btnFactD_Click(object sender, EventArgs e)
        {
           
            decimal dOp1 = 0.0m;
            decimal dAnswer = 0.0m;
            string sOp1 = "";
            string szAnswer = "";
            string szEquation = "";

            sOp1 = txtOp1.Text;


            dOp1 = Convert.ToDecimal(sOp1);

            dAnswer = CalcMethod(dOp1, dOp1, FACTORIAL);


            szAnswer = dAnswer.ToString();

            szEquation = sOp1 + " ! " +  " = " + szAnswer;

            lblMessage.Text = "";
            lblMessage.Text = szEquation;
        }

        private void btnFibD_Click(object sender, EventArgs e)
        {
            decimal dOp1 = 0.0m;
            decimal dAnswer = 0.0m;
            string sOp1 = "";
            string szAnswer = "";
            string szEquation = "";

            sOp1 = txtOp1.Text;

            dOp1 = Convert.ToDecimal(sOp1);

            dAnswer = CalcMethod(dOp1, dOp1, FIBONACCI);


            szAnswer = dAnswer.ToString();

            szEquation = sOp1 + " fibonacci " + " = " + szAnswer;

            lblMessage.Text = "";
            lblMessage.Text = szEquation;
        }
    }
}
