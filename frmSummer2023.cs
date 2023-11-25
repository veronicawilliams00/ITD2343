//Veronica Williams
//ITD-2343 Object-Orient Programming Using C#
//09/19/2023

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Williams_Project
{
    public partial class frmSummer2023 : Form
    {
        public frmSummer2023()
        {
            InitializeComponent();
        }


        //Copies information typed in txtEntered to txtCopied
        private void btnSave_Click(object sender, EventArgs e)
        {
            txtCopied.Text = txtEntered.Text;
        }

        //Clears information that was copied from txtEntered from txtCopied
        private void btnWipe_Click(object sentder, EventArgs e)
        {
            txtCopied.Text = " ";
        }

        //Clears information that was typed in txtEntered
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEntered.Text = " ";
        }
    }
}
