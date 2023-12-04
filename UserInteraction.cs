using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLabExam
{
    /***********************************************
     * Veronica Williams
     * Class ITD-2343 Obj-OrientProgramming Using C#
     * Fall 2023
     * 10/10/2023
     * *********************************************/
    public partial class UserInteraction : Form
    {
        public UserInteraction()
        {
            InitializeComponent();
        }

        //Clears the textbox
        private void bnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = " ";
        }

        //Inputs the letter A into the textbox
        private void btnA_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "A";
        }

        //Inputs the letter E into the textbox
        private void btnE_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "E";
        }

        //Inputs the letter I into the textbox
        private void btnI_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "I";
        }

        //Inputs the letter O into the textbox
        private void btnO_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "O";
        }

        //Inputs the letter U into the textbox
        private void btnU_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "U";
        }

        //Inputs the letter Y into the textbox
        private void btnY_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "Y";
        }

        //Inputs the letter B into the textbox
        private void btnB_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "B";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Inputs the letter C into the textbox
        private void btnC_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "C";
        }

        //Inputs the letter D into the textbox
        private void btnD_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "D";
        }

        //Inputs the letter F into the textbox
        private void btnF_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "F";
        }

        //Inputs the letter G into the textbox
        private void btnG_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "G";
        }

        //Inputs the letter H into the textbox
        private void btnH_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "H";
        }

        //Inputs the letter J into the textbox
        private void btnJ_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "J";
        }

        //Inputs the letter K into the textbox
        private void btnK_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "K";
        }

        //Inputs the letter L into the textbox
        private void btnL_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "L";
        }

        //Inputs the letter M into the textbox
        private void btnM_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "M";
        }

        //Inputs the letter N into the textbox
        private void btnN_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "N";
        }

        //Inputs the letter P into the textbox
        private void btnP_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "P";
        }

        //Inputs the letter Q into the textbox
        private void btnQ_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "Q";
        }

        //Inputs the letter R into the textbox
        private void btnR_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "R";
        }

        //Inputs the letter S into the textbox
        private void btnS_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "S";
        }

        //Inputs the letter T into the textbox
        private void btnT_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "T";
        }

        //Inputs the letter V into the textbox
        private void btnV_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "V";
        }

        //Inputs the letter W into the textbox
        private void btnW_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "W";
        }

        //Inputs the letter X into the textbox
        private void btnX_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "X";
        }

        //Inputs the letter Z into the textbox
        private void btnZ_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "Z";
        }

        //Inputs the letter 0 into the textbox
        private void btn0_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "0";
        }

        //Inputs the letter 1 into the textbox
        private void btn1_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "1";
        }

        //Inputs the letter 2 into the textbox
        private void btn2_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "2";
        }

        //Inputs the letter 3 into the textbox
        private void btn3_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "3";
        }

        //Inputs the letter 4 into the textbox
        private void btn4_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "4";
        }

        //Inputs the letter 5 into the textbox
        private void btn5_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "5";
        }

        //Inputs the letter 6 into the textbox
        private void btn6_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "6";
        }

        //Inputs the letter 7 into the textbox
        private void btn7_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "7";
        }

        //Inputs the letter 8 into the textbox
        private void btn8_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "8";
        }

        //Inputs the letter 9 into the textbox
        private void btn9_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "9";
        }

        //Inputs the letter . into the textbox
        private void btnPeriod_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + ".";
        }

        //Copies information from the text box into the label
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = txtInput.Text;
        }

        private void btnBlank_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + " ";
        }

        //Closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
