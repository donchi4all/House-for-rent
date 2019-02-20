using PropertyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace House_for_rent
{
    public partial class Form1 : Form
    {
        Rent rent;
        public Form1()
        {
            InitializeComponent();
            //radTown.Checked = true;
            //radRm2.Checked = true;
            //radBath1_5.Checked = true;

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
          
            rent = new SpecialRent(txtFname.Text.ToString(), txtLname.Text.ToString(),
                radRm1.Checked,
                radRm2.Checked,
                radRm3.Checked,
                radRm4.Checked,
                radBath1.Checked,
                radBath1_5.Checked,
                radBath2.Checked,
                radBath2_5.Checked,
                radDetach.Checked,
                radSemiDetach.Checked,
                radTown.Checked
                );


            
                lblThankYou.Text = rent.ToString();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFname.Text = rent.Clear();
            txtLname.Text = rent.Clear();
            lblThankYou.Text = rent.Clear();
            radTown.Checked = rent.ClearBool();
            radDetach.Checked = rent.ClearBool();
            radSemiDetach.Checked = rent.ClearBool();
            radRm1.Checked = rent.ClearBool();
            radRm2.Checked = rent.ClearBool();
            radRm3.Checked = rent.ClearBool();
            radRm4.Checked = rent.ClearBool();
            radBath1.Checked = rent.ClearBool();
            radBath1_5.Checked = rent.ClearBool();
            radBath2.Checked = rent.ClearBool();
            radBath2_5.Checked = rent.ClearBool();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radTown_CheckedChanged(object sender, EventArgs e)
        {
            radRm4.Enabled = false;
        }

        private void radSemiDetach_CheckedChanged(object sender, EventArgs e)
        {
            radRm4.Enabled = true;
        }

        private void radDetach_CheckedChanged(object sender, EventArgs e)
        {
            radRm4.Enabled = true;
        }
    }
}
