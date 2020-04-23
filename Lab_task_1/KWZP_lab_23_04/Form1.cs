using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            btnClose.Enabled = chkButtonEnabled.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Random losowa = new Random();
        private void rbtRadio1_CheckedChanged(object sender, EventArgs e)
        {
            rbtRadio1.Text = "";
            int los = losowa.Next(1, 10);
            if (los>5) {
                rbtRadio2.Text = "Wybierz mnie";
                rbtRadio3.Text = "";
            }
            else
            {
                rbtRadio2.Text = "";
                rbtRadio3.Text = "Wybierz mnie";
            };
                               
            
        }

        private void rbtRadio2_CheckedChanged(object sender, EventArgs e)
        {
            rbtRadio2.Text = "";
            int los = losowa.Next(1, 10);
            if (los > 5)
            {
                rbtRadio1.Text = "Wybierz mnie";
                rbtRadio3.Text = "";
            }
            else
            {
                rbtRadio1.Text = "";
                rbtRadio3.Text = "Wybierz mnie";
            };
        }

        private void rbtRadio3_CheckedChanged(object sender, EventArgs e)
        {
            rbtRadio3.Text = "";
            int los = losowa.Next(1, 10);
            if (los > 5)
            {
                rbtRadio2.Text = "Wybierz mnie";
                rbtRadio1.Text = "";
            }
            else
            {
                rbtRadio2.Text = "";
                rbtRadio1.Text = "Wybierz mnie";
            };
        }
    }
}
