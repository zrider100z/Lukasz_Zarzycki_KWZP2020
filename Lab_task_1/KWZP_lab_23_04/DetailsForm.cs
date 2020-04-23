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
    public partial class DetailsForm : Form
    {
        public DetailsForm(String labeltext)
        {
            InitializeComponent();
            lblLabel1.Text = labeltext;
        }

        private void lblLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
