using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************************
 * Name: Veronica Williams
 * Class: ITD-2343 Obj. Oriented Programming C#
 * Instructor: Greg Morris
 * Due Date: 10/24/2023
 * *********************************************/

namespace Module6MethodsProjectDL
{
    public partial class frmValidID : Form
    {
        // Public Contsants to use
        const int ADD = 0;
        const int SUBTRACT = 1;
        const int MULTIPLY = 2;
        const int DIVIDE = 3;
        const int MODULUS = 4;

        public frmValidID()
        {
            InitializeComponent();
        }
        
       
        //Put Your method here
        private decimal CalcMethod(decimal dLeft, decimal dRight, int cOperation)
        {

            if (cOperation == ADD)
                return dLeft + dRight;
        
            else if (cOperation == SUBTRACT)
                return dLeft - dRight;

            else if (cOperation == MULTIPLY)
                return dLeft * dRight;

            else if (cOperation == DIVIDE)
                return dLeft / dRight;

            else if (cOperation == MODULUS)
                return dLeft % dRight;

            else
                return 0;
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
             
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
        try
            {     
                dAnswer = CalcMethod(dLeft, dRight, MODULUS);

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " % " + szRight + " = " + szAnswer;

                lblAnswer.Text = "";
                lblAnswer.Text = szEquation;
               
                if (!Decimal.TryParse(txtLeft.Text, out decimal number))
                {
                    lblAnswer.Text = "Please enter a numeric value.";
                }
                else if (!Decimal.TryParse(txtRight.Text, out decimal number2))
                {
                    lblAnswer.Text = "Please enter a numeric value.";
                }
                else if (number < 0)
                {
                    lblAnswer.Text = "Pleas eneter a positive value.";
                }
                
            }

            catch(DivideByZeroException)
            {
                lblAnswer.Text = "Cantno Modulus 0.";
            }

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;

            try
            {

                dAnswer = CalcMethod(dLeft, dRight, DIVIDE);

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " % " + szRight + " = " + szAnswer;

                lblAnswer.Text = "";
                lblAnswer.Text = szEquation;



               if (!Decimal.TryParse(txtLeft.Text, out decimal number))
                {
                    lblAnswer.Text = "Please enter a numeric value.";
                }
                else if (!Decimal.TryParse(txtRight.Text, out decimal number2))
                { 
                    lblAnswer.Text = "Please enter a numeric value.";
                }
            }

            catch (DivideByZeroException)
            {
                lblAnswer.Text = "Cannot divide by zero.";
            }

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;

            try
            { 
       
                dAnswer = CalcMethod(dLeft, dRight, MULTIPLY);

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " * " + szRight + " = " + szAnswer;

                lblAnswer.Text = "";
                lblAnswer.Text = szEquation;

                if (!Decimal.TryParse(txtLeft.Text, out decimal number))
                {
                    lblAnswer.Text = "Please enter a numeric value.";
                }
                else if (!Decimal.TryParse(txtRight.Text, out decimal number2))
                {
                    lblAnswer.Text = "Please enter a numeric value.";
                }
            }

            catch (Exception)
            {
                lblAnswer.Text = "Operand left and right are required values.";
            }


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;

                dAnswer = CalcMethod(dLeft, dRight, SUBTRACT);

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " - " + szRight + " = " + szAnswer;

                lblAnswer.Text = "";
                lblAnswer.Text = szEquation;

            if (!Decimal.TryParse(txtLeft.Text, out decimal number))
            {
                lblAnswer.Text = "Please enter a numeric value.";
            }
            else if (!Decimal.TryParse(txtRight.Text, out decimal number2))
            {
                lblAnswer.Text = "Please enter a numeric value.";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;

                dAnswer = CalcMethod(dLeft, dRight, ADD);

                szAnswer = dAnswer.ToString();

                szEquation = szLeft + " + " + szRight + " = " + szAnswer;

                lblAnswer.Text = "";
                lblAnswer.Text = szEquation;

            if (!Decimal.TryParse(txtLeft.Text, out decimal number))
            {
                lblAnswer.Text = "Please enter a numeric value.";
            }
            else if (!Decimal.TryParse(txtRight.Text, out decimal number2))
            {
                lblAnswer.Text = "Please enter a numeric value.";
            }
           
        }

     

        private void lftTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMethodActing_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeft.Text = " ";
            txtRight.Text = " ";
            lblAnswer.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
