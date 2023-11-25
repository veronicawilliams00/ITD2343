using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WilliamsLab_Project
{
    /*****************************************************
     * Name: Veronica Williams
     * Class: ITD-2343 Object Orient Programming Using C#
     * Instructor: Greg Morris
     * Due Date: 10/102/2023
     *****************************************************/
    public partial class FrmWilliams : Form
    {
        public FrmWilliams()
        {
            InitializeComponent();
        }

        //This will clear the text in the Label and revert the background color back to white.
        private void button19_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = " ";
            lblTheDominator.BackColor = Color.White;
            lblTheDominator.ForeColor = Color.Black;
        }



        //This changes the label color to purple and any text to white.
        private void btnPurple_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnPurple.BackColor;
            lblTheDominator.ForeColor = Color.White;
        }

        //This changes the label color to blue and any text to white.
        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnBlue.BackColor;
            lblTheDominator.ForeColor = Color.White;
        }

        //This changes the label color to green.
        private void btnGreen_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnGreen.BackColor;
        }

        //This chagnes the label color to yellow.
        private void btnYellow_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnYellow.BackColor;
        }

        //This changes the label color to orange.
        private void btnOrange_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnOrange.BackColor;
        }

        //This changes the label color to red.
        private void btnRed_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnRed.BackColor;
        }

        //This changes the label color to black and any text to white.
        private void btnBlack_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnBlack.BackColor;
            lblTheDominator.ForeColor = Color.White;
        }

        //This changes the label color to pink.
        private void btnPink_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnPink.BackColor;
        }

        //This changes the label color to brown.
        private void btnBrown_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnBrown.BackColor;
        }

        //This changes the text in the label to 1.
        private void btnDigit1_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "1";
        }

        //This changes the text in the label to 2.
        private void btnDigit2_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "2";
        }

        //This changes the text in the label to 3.
        private void btnDigit3_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "3";
        }

        //This changes the text in the label to 4.
        private void btnDigit4_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "4";
        }

        //This changes the text in the label to 5.
        private void btnDigit5_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "5";
        }

        //This changes the text in the label to 6.
        private void btnDigit6_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "6";
        }


        //This changes the text in the label to 7.
        private void btnDigit7_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "7";
        }

        //This changes the text in the label to 8.
        private void btnDigit8_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "8";
        }

        //This changes the text in the label to 9.
        private void btnDigit9_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "9";
        }


        //This button closes out the form.
        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
