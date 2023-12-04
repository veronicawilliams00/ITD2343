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
 * Due Date: 10/17/2023
 * *********************************************/

namespace Module6MethodsProjectDL
{
    public partial class frmMethodActing : Form
    {
        // Public Contsants to use
        const int ADD = 0;
        const int SUBTRACT = 1;
        const int MULTIPLY = 2;
        const int DIVIDE = 3;
        const int MODULUS = 4;

        public frmMethodActing()
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

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = CalcMethod(dLeft, dRight, MODULUS);


            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " % " + szRight + " = " + szAnswer;

            lblAnswer.Text = "";
            lblAnswer.Text = szEquation;

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

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = CalcMethod(dLeft, dRight, DIVIDE);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " / " + szRight + " = " + szAnswer;

            lblAnswer.Text = "";
            lblAnswer.Text = szEquation;


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

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = CalcMethod(dLeft, dRight, MULTIPLY);
            
            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " * " + szRight + " = " + szAnswer;

            lblAnswer.Text = "";
            lblAnswer.Text = szEquation;


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

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = CalcMethod(dLeft, dRight, SUBTRACT);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " - " + szRight + " = " + szAnswer;

            lblAnswer.Text = "";
            lblAnswer.Text = szEquation;


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

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = CalcMethod(dLeft, dRight, ADD);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " + " + szRight + " = " + szAnswer;

            lblAnswer.Text = "";
            lblAnswer.Text = szEquation;

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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
