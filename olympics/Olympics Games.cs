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
    public partial class OlympicsGamesAdmin : Form
    {
        public OlympicsGamesAdmin()
        {
            InitializeComponent();
        }

        private void OlympicsGamesAdmin_Load(object sender, EventArgs e)
        {
            grpDisplay.Visible = false;
            cmbAdd.Visible = false;
            cmbChange.Visible = false;
            cmbDelete.Visible = false;
            //radOnOff.Visible = false;

            //cmbAdd.SelectedIndex = 0;
            cmbAdd.Items.Add("Country");
            cmbAdd.Items.Add("Discipline");
            cmbAdd.Items.Add("Event");
            cmbAdd.Items.Add("Participant");
            cmbAdd.Items.Add("Placing");

            //cmbChange.SelectedIndex = 0;
            cmbChange.Items.Add("Country");
            cmbChange.Items.Add("Discipline");
            cmbChange.Items.Add("Event");
            cmbChange.Items.Add("Participant");
            cmbChange.Items.Add("Placing");

            //cmbDelete.SelectedIndex = 0;
            cmbDelete.Items.Add("Country");
            cmbDelete.Items.Add("Discipline");
            cmbDelete.Items.Add("Event");
            cmbDelete.Items.Add("Participant");
            cmbDelete.Items.Add("Placing");

            mnuMod.Visible = false;
        }

        private void newToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            mnuMod.Visible = true; 
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.ShowDialog();
            //games.ShowIcon = false;
        }

        private void mnuAdd_MouseHover(object sender, EventArgs e)
        {
            grpDisplay.Visible = true;
            grpDisplay.Text = "Choose which record to 'add'";
            cmbAdd.Visible = true;
            cmbDelete.Visible = false;
            cmbChange.Visible = false;
            //radOnOff.Visible = true;
            //timer1.Start();
        }

        private void mnuChange_MouseHover(object sender, EventArgs e)
        {
            grpDisplay.Visible = true;
            grpDisplay.Text = "Choose which record to 'change'";
            cmbChange.Visible = true;
            cmbAdd.Visible = false;
            cmbDelete.Visible = false;
            //radOnOff.Visible = true;
            //timer1.Start();
        }

        private void mnuDelete_MouseHover(object sender, EventArgs e)
        {
            grpDisplay.Visible = true;
            grpDisplay.Text = "Choose which record to 'delete'";
            cmbDelete.Visible = true;
            cmbAdd.Visible = false;
            cmbChange.Visible = false;
            //radOnOff.Visible = true;            
            //timer1.Start();
        }

        private void cmbAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add_Records addRecord = new Add_Records(cmbAdd.Text);
            addRecord.ShowDialog();
            // need to retain data from the previous form.
        }

        private void cmbChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_Records changeRecord = new Change_Records(cmbChange.Text);
            changeRecord.ShowDialog();
        }

        private void cmbDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Remove_Records removeRecord = new Remove_Records(cmbDelete.Text);
            removeRecord.ShowDialog();
        }
    }
}
