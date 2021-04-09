using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace olympics
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //chkCurrent.Checked = false;
            //txtOlympics.Clear();
            //txtOlympics.ReadOnly = false;
        }

        private void chkCurrent_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkCurrent.Checked == true)
            //{
            //    txtOlympics.Text = "London Olympics";
            //    cmbOlympicType.Text = "Summer";
            //    cmbYear.Text = "2012";
            //    txtOlympics.ReadOnly = true;
            //}
            //else
            //{
            //    txtOlympics.Clear();
            //    cmbOlympicType.SelectedIndex = 0;
            //    cmbYear.SelectedIndex = 0;
            //    txtOlympics.ReadOnly = false;
            //}
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // make the olympic form get its name from the value in the text box.
        }

        private void Games_Load(object sender, EventArgs e)
        {
            btnChange.Focus();
            //cmbOlympicType.Items.Add("Summer");
            //cmbOlympicType.Items.Add("Winter");

            //cmbOlympicType.Text = "Summer";
            //cmbYear.Text = "2012";
        }

        private void cmbOlympicType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbOlympicType.Text == "Summer")
            //{
            //    // summer olympics
            //    cmbYear.Items.Add("2000");
            //    cmbYear.Items.Add("2004");
            //    cmbYear.Items.Add("2008");
            //    cmbYear.Items.Add("2012");
            //}
            //else
            //{
            //    // winter olympics
            //    cmbYear.Items.Add(2002);
            //    cmbYear.Items.Add(2006);
            //    cmbYear.Items.Add(2010);
            //}
        }
    }
}
