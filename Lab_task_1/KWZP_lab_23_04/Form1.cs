using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP_lab_23_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnClose.Enabled = false;
            rbtRadio1.Text = "Wybierz mnie";
            rbtRadio2.Text = "";
            rbtRadio3.Text = "";
        }

        private void txtButtonLabel_TextChanged(object sender, EventArgs e)
        {
            if (txtButtonLabel.TextLength > 0)
            {
                btnClose.Text = txtButtonLabel.Text;
            }
        }

        private void chkButtonEnabled_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.White;
            btnClose.Enabled = chkButtonEnabled.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DetailsForm detailsform = new DetailsForm(txtButtonLabel.Text);
            detailsform.Show();

        }
        //absolutnie nieprzemyslana deklaracja zmiennych
        Random losowa = new Random();
        int which_box = 1;
        private void rbtRadio1_CheckedChanged(object sender, EventArgs e)
        {
            if (which_box == 1)
            {
                BackColor = Color.Red;
            }
            rbtRadio1.Text = "";
            int los = losowa.Next(1, 10);
            if (los>5) {
                rbtRadio2.Text = "Wybierz mnie";
                rbtRadio3.Text = "";
                which_box = 2;
            }
            else
            {
                rbtRadio2.Text = "";
                rbtRadio3.Text = "Wybierz mnie";
                which_box = 3;
            };
                               
            
        }

        private void rbtRadio2_CheckedChanged(object sender, EventArgs e)
        {
            if (which_box ==2)
            {
                BackColor = Color.Green;
            }
            rbtRadio2.Text = "";
            int los = losowa.Next(1, 10);
            if (los > 5)
            {
                rbtRadio1.Text = "Wybierz mnie";
                rbtRadio3.Text = "";
                which_box = 1;
            }
            else
            {
                rbtRadio1.Text = "";
                rbtRadio3.Text = "Wybierz mnie";
                which_box = 3;
            };
        }

        private void rbtRadio3_CheckedChanged(object sender, EventArgs e)
        {
            if (which_box == 3)
            {
                BackColor = Color.Blue;
            }
            rbtRadio3.Text = "";
            int los = losowa.Next(1, 10);
            if (los > 5)
            {
                rbtRadio2.Text = "Wybierz mnie";
                rbtRadio1.Text = "";
                which_box = 2;
            }
            else
            {
                rbtRadio2.Text = "";
                rbtRadio1.Text = "Wybierz mnie";
                which_box = 1;
            };
        }
    }
}
