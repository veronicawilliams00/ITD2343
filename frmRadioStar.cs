using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioStarProjectWilliams
{

    /**********************************************
    * Name: Veronica Williams
    * Class: ITD-2343 Obj. Oriented Programming C#
    * Instructor: Greg Morris
    * Due Date: 11/14/2023
    * *********************************************/

    public partial class frmRadioStar : Form
    {
        //Constants to Use
        const int ADD = 0;
        const int SUBTRACT = 1;
        const int MULTIPLY = 2;
        const int DIVIDE = 3;
        const int MODULUS = 4;

        public frmRadioStar()
        {
            InitializeComponent();

        }


        private decimal CalcMethod(decimal oLeft, decimal oRight, int cOperation)
        {

            if (cOperation == ADD)
                return oLeft + oRight;

            else if (cOperation == SUBTRACT)
                return oLeft - oRight;

            else if (cOperation == MULTIPLY)
                return oLeft * oRight;

            else if (cOperation == DIVIDE)
                return oLeft / oRight;

            else if (cOperation == MODULUS)
                return oLeft % oRight;

            else
                return 0;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "";
            txtLeft.Text = "";
            txtRight.Text = "";

            rbtnAdd.Checked = true;
            chckVer.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chckVer_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnMod_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
                if (chckVer.Checked)
                    EnableVer();
                else
                    DisableVer();
        }

        private void EnableVer()
        {
            if (rbtnAdd.Checked && btnCalc.Enabled)
            {

                decimal oLeft = 0.0m;
                decimal oRight = 0.0m;
                decimal oAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
            try
                { 
                oLeft = Convert.ToDecimal(szLeft);
                oRight = Convert.ToDecimal(szRight);

                oAnswer = CalcMethod(oLeft, oRight, ADD);


                szAnswer = oAnswer.ToString();

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
                catch (Exception)
                {
                    lblAnswer.Text = "Please enter a valid number.";
                }
            }

            else if (rbtnSubtract.Checked && btnCalc.Enabled)
            {
                decimal oLeft = 0.0m;
                decimal oRight = 0.0m;
                decimal oAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
                try
                {
                    oLeft = Convert.ToDecimal(szLeft);
                    oRight = Convert.ToDecimal(szRight);

                    oAnswer = CalcMethod(oLeft, oRight, SUBTRACT);


                    szAnswer = oAnswer.ToString();

                    szEquation = szLeft + " - " + szRight + " = " + szAnswer;

                    lblAnswer.Text = "";
                    lblAnswer.Text = szEquation;
                }
                catch (Exception)
                {
                    lblAnswer.Text = "Please enter a valid number.";
                }
            }

            else if (rbtnMulti.Checked && btnCalc.Enabled)
            {
                decimal oLeft = 0.0m;
                decimal oRight = 0.0m;
                decimal oAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
                try
                {
                    oLeft = Convert.ToDecimal(szLeft);
                    oRight = Convert.ToDecimal(szRight);

                    oAnswer = CalcMethod(oLeft, oRight, MULTIPLY);


                    szAnswer = oAnswer.ToString();

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
                    lblAnswer.Text = "Please enter a valid number.";
                }
            }

            else if (rbtnDivide.Checked && btnCalc.Enabled)
            {
                decimal oLeft = 0.0m;
                decimal oRight = 0.0m;
                decimal oAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
                try
                {
                    oLeft = Convert.ToDecimal(szLeft);
                    oRight = Convert.ToDecimal(szRight);

                    oAnswer = CalcMethod(oLeft, oRight, DIVIDE);


                    szAnswer = oAnswer.ToString();

                    szEquation = szLeft + " / " + szRight + " = " + szAnswer;

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

                catch (DivideByZeroException)
                {
                    lblAnswer.Text = "Cantno Modulus 0.";
                }
                catch(Exception)
                {
                    lblAnswer.Text = "Please enter a numeric value.";
                }
        }

            else if (rbtnMod.Checked && btnCalc.Enabled)
            {
                decimal oLeft = 0.0m;
                decimal oRight = 0.0m;
                decimal oAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
                try
                {
                    oLeft = Convert.ToDecimal(szLeft);
                    oRight = Convert.ToDecimal(szRight);

                    oAnswer = CalcMethod(oLeft, oRight, MODULUS);


                    szAnswer = oAnswer.ToString();

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

                catch (DivideByZeroException)
                {
                    lblAnswer.Text = "Cantno Modulus 0.";
                }
                catch(Exception)
                {
                    lblAnswer.Text = "Please enter a numeric value.";
                }
            }
        }

        private void DisableVer()
        {
            if (rbtnAdd.Checked && btnCalc.Enabled)
            {
                decimal oLeft = 0.0m;
                decimal oRight = 0.0m;
                decimal oAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
                try
                {
                    oLeft = Convert.ToDecimal(szLeft);
                    oRight = Convert.ToDecimal(szRight);

                    oAnswer = CalcMethod(oLeft, oRight, ADD);


                    szAnswer = oAnswer.ToString();

                    szEquation = "The answer is " + szAnswer;

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
                    lblAnswer.Text = "Please enter a valid number.";
                }
            }

            else if (rbtnSubtract.Checked && btnCalc.Enabled)
            {
                decimal oLeft = 0.0m;
                decimal oRight = 0.0m;
                decimal oAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
                try
                {
                    oLeft = Convert.ToDecimal(szLeft);
                    oRight = Convert.ToDecimal(szRight);

                    oAnswer = CalcMethod(oLeft, oRight, SUBTRACT);


                    szAnswer = oAnswer.ToString();

                    szEquation = "The answer is " + szAnswer;

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
                    lblAnswer.Text = "Please enter a valid number.";
                }
            }

            else if (rbtnMulti.Checked && btnCalc.Enabled)
            {
                decimal oLeft = 0.0m;
                decimal oRight = 0.0m;
                decimal oAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
                try
                {
                    oLeft = Convert.ToDecimal(szLeft);
                    oRight = Convert.ToDecimal(szRight);

                    oAnswer = CalcMethod(oLeft, oRight, MULTIPLY);


                    szAnswer = oAnswer.ToString();

                    szEquation = "The answer is " + szAnswer;

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
                    lblAnswer.Text = "Please enter a valid number.";
                }
            }

            else if (rbtnDivide.Checked && btnCalc.Enabled)
            {
                decimal oLeft = 0.0m;
                decimal oRight = 0.0m;
                decimal oAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
                try
                {
                    oLeft = Convert.ToDecimal(szLeft);
                    oRight = Convert.ToDecimal(szRight);

                    oAnswer = CalcMethod(oLeft, oRight, DIVIDE);


                    szAnswer = oAnswer.ToString();

                    szEquation = "The answer is " + szAnswer;

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

                catch (DivideByZeroException)
                {
                    lblAnswer.Text = "Cannot Divide 0.";
                }
                catch(Exception)
                {
                    lblAnswer.Text = "Please enter a numeric value.";
                }
            }

            else if (rbtnMod.Checked && btnCalc.Enabled)
            {

                decimal oLeft = 0.0m;
                decimal oRight = 0.0m;
                decimal oAnswer = 0.0m;
                string szLeft = "";
                string szRight = "";
                string szAnswer = "";
                string szEquation = "";

                szLeft = txtLeft.Text;
                szRight = txtRight.Text;
                try
                {
                    oLeft = Convert.ToDecimal(szLeft);
                    oRight = Convert.ToDecimal(szRight);

                    oAnswer = CalcMethod(oLeft, oRight, MODULUS);


                    szAnswer = oAnswer.ToString();

                    szEquation = "The answer is  " + szAnswer;

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

                catch (DivideByZeroException)
                {
                    lblAnswer.Text = "Cannot Modulus 0.";
                }
                catch(Exception)
                {
                    lblAnswer.Text = "Please enter a numeric value.";
                }
            }
        }

        }
}
