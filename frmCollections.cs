using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCollections
{
    public partial class frmCollections : Form
    {
        public frmCollections()
        {
            InitializeComponent();
        }

        //Initialize variable for the array.
        int arrayTotal = 0;
        short[] collectionArray = new short[17];

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txtNum.Text == " ")
                {
                    lblCalc.Text = "Number Value is a required field.";
                }

                else
                {
                    short numValue = short.Parse(txtNum.Text);
                    if (numValue > -1216 && numValue < 1218)
                    {
                        collectionArray[arrayTotal] = numValue;
                        arrayTotal++;
                        txtNum.Text = " ";

                    }

                    else
                    {
                        lblCalc.Text = "The number value needs to be between -1,217 and 1,217.";
                        txtNum.Text = " ";
                    }
                }
            
            }
            catch(FormatException)
            {
                lblCalc.Text = "Please enter a valid number format.";
            }
            catch(IndexOutOfRangeException)
            {
                lblCalc.Text = "The collection amount can be no more than 17.";
            }

            txtNum.Focus();

        }

        private void frmCollections_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Array.Sort(collectionArray);
            //string collectionString = " ";
            decimal sum = 0.0m;
            decimal average = 0.0m;
           foreach (decimal a in collectionArray)
               if (a != 0)
               {
                   sum += a;
                   average += sum / collectionArray.Length;
                   //collectionString += a + "\n" + sum + "\n" + average + "\n";
                   lblResult.Text ="Array Collection" + "\n" + a + "\n" +"Array Average:" + "\n" + average + "\n" + "Array Largest Number:" + sum + "\n";
                   

               }
        }

        private void lblCalc_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNum.Text = " ";
            lblCalc.Text = "The collection has been emptied.";
            lblResult.Text = " ";
            collectionArray[arrayTotal] = 0;
        }
    }
}
