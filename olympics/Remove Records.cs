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
    public partial class Remove_Records : Form
    {
        // if you change team event you'll also need to change team participant.
        string removeComboBox;
        string infoText = "remove ";
        string message = "Continue with operation..."; // All infomation is correct
        string caption = "Confirmation";

        Country country = new Country();
        Discipline discipline = new Discipline();
        Event events = new Event();
        Participant athlete = new Participant();
        Placing medal = new Placing();

        public Remove_Records(string comboBoxText)
        {
            InitializeComponent();
            removeComboBox = comboBoxText;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            
            if (dr == DialogResult.Yes)
            {
                if (removeComboBox == "Country")
                {
                    country.RemoveCountry(txtColumn2.Text);
                }
                if (removeComboBox == "Discipline")
                {
                    discipline.RemoveDiscipline(txtColumn2.Text);
                }
                if (removeComboBox == "Event")
                {
                    events.RemoveEvent(txtColumn3.Text);
                }
                if (removeComboBox == "Participant")
                {
                    athlete.RemoveParticipant(txtColumn2.Text);
                }
                this.Close();
            }
        }

        private void Remove_Records_Load(object sender, EventArgs e)
        {
            // set label visibility to false.
            lblColumn1.Visible = false;
            lblColumn2.Visible = false;
            lblColumn3.Visible = false;
            lblColumn4.Visible = false;
            lblColumn5.Visible = false;
            lblColumn6.Visible = false;

            // view mode will only be available in plug-in (updated version)...
            mnuView.Visible = false;

            // make dataGridView full row selection.
            dgvDelete1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDelete2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDelete3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRemovePlacing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // tabControl manipulations.
            tabControl1.TabPages["tabInfo"].Text = removeComboBox;
            // hiding of tabpages.
            tabControl1.TabPages.Remove(tabTeamEvent);
            tabControl1.TabPages.Remove(tabIndividualEvent);
            tabControl1.TabPages.Remove(tabPlacing);

            mnuRecord.Text = infoText + "record";
            mnuTeamEvent.Visible = false;
            mnuIndividualEvent.Visible = false;
            mnuEvent.Visible = false;

            if (removeComboBox == "Country")
            {
                dgvDelete1.DataSource = country.AllCountries();
                // try and make the context word bold and diff font.
                lblInfo.Text = infoText + "Country data here...";
            }
            if (removeComboBox == "Discipline")
            {
                dgvDelete1.DataSource = discipline.AllDiscipline();
                // try and make the context word bold and diff font.
                lblInfo.Text = infoText + "Discipline data here...";
            }
            if (removeComboBox == "Event")
            {
                dgvDelete1.DataSource = events.AllEvents();
                dgvDelete2.DataSource = events.TeamEvent();
                dgvDelete3.DataSource = events.IndividualEvent();
                // try and make the context word bold and diff font.
                lblInfo.Text = infoText + "Event data here...";
                tabControl1.TabPages.Add(tabTeamEvent);
                tabControl1.TabPages.Add(tabIndividualEvent);

                mnuTeamEvent.Visible = true;
                mnuIndividualEvent.Visible = true;
                mnuEvent.Visible = true;
                
            }
            if (removeComboBox == "Participant")
            {
                dgvDelete1.DataSource = athlete.AllParticipant();
                // try and make the context word(Participant) bold and diff font.
                lblInfo.Text = infoText + "Participant data here...";
            }
            if (removeComboBox == "Placing")
            {
                tabControl1.TabPages.Remove(tabInfo);
                tabControl1.TabPages.Add(tabPlacing);
                lblInfo.Text = infoText + "Placing data here";
                dgvRemovePlacing.DataSource = medal.EveryPlacing();
            }

            //textBox1.Visible = true;
            //textBox2.Visible = true;
            //textBox3.Visible = true;
            //textBox4.Visible = true;
            //textBox5.Visible = true;
            //textBox6.Visible = true;
        }

        private void mnuRecord_Click(object sender, EventArgs e)
        {
            btnRemove.Focus();
        }

        private void mnuTeamEvent_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabTeamEvent");
        }

        private void mnuIndividualEvent_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabIndividualEvent");  
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void mnuText_Click(object sender, EventArgs e)
        //{
        //    dgvDelete1.Visible = false;

        //    textBox1.Visible = false;
        //    textBox2.Visible = false;
        //    textBox3.Visible = false;
        //    textBox4.Visible = false;
        //    textBox5.Visible = false;
        //    textBox6.Visible = false;

        //    if (removeComboBox == "Country")
        //    {
        //        txtColumn1.Visible = false;
        //        txtColumn2.Visible = true;
        //        txtColumn3.Visible = true;
        //        txtColumn4.Visible = false;
        //        txtColumn5.Visible = false;
        //        txtColumn6.Visible = false;

        //        lblColumn1.Visible = false;
        //        lblColumn2.Visible = true;
        //        lblColumn3.Visible = true;
        //        lblColumn4.Visible = false;
        //        lblColumn5.Visible = false;
        //        lblColumn6.Visible = false;
                
        //        lblColumn2.Text = "CountryID:";
        //        lblColumn3.Text = "CountryName:";               
        //    }

        //    if (removeComboBox == "Discipline")
        //    {
        //        txtColumn1.Visible = false;
        //        txtColumn2.Visible = true;
        //        txtColumn3.Visible = true;
        //        txtColumn4.Visible = false;
        //        txtColumn5.Visible = false;
        //        txtColumn6.Visible = false;

        //        lblColumn1.Visible = false;
        //        lblColumn2.Visible = true;
        //        lblColumn3.Visible = true;
        //        lblColumn4.Visible = false;
        //        lblColumn5.Visible = false;
        //        lblColumn6.Visible = false;
                
        //        lblColumn2.Text = "Discipline Code:";
        //        lblColumn3.Text = "Discipline Desc:";                
        //    }
        //    if (removeComboBox == "Event")
        //    {
        //        txtColumn1.Visible = true;
        //        txtColumn2.Visible = true;
        //        txtColumn3.Visible = true;
        //        txtColumn4.Visible = true;
        //        txtColumn5.Visible = true;
        //        txtColumn6.Visible = true;

        //        lblColumn1.Visible = true;
        //        lblColumn2.Visible = true;
        //        lblColumn3.Visible = true;
        //        lblColumn4.Visible = true;
        //        lblColumn5.Visible = true;
        //        lblColumn6.Visible = true;
                
        //        lblColumn1.Text = "Event Desc:";
        //        lblColumn2.Text = "Discipline Code:";
        //        lblColumn3.Text = "Gender:";
        //        lblColumn4.Text = "EventType:";
        //        lblColumn5.Text = "EventDate:";
        //        lblColumn6.Text = "Venue:";                
        //    }
        //    if (removeComboBox == "Participant")
        //    {
        //        txtColumn1.Visible = false;
        //        txtColumn2.Visible = true;
        //        txtColumn3.Visible = true;
        //        txtColumn4.Visible = true;
        //        txtColumn5.Visible = true;
        //        txtColumn6.Visible = false;

        //        lblColumn1.Visible = false;
        //        lblColumn2.Visible = true;
        //        lblColumn3.Visible = true;
        //        lblColumn4.Visible = true;
        //        lblColumn5.Visible = true;
        //        lblColumn6.Visible = false;
                
        //        lblColumn2.Text = "ID:";
        //        lblColumn3.Text = "Name:";
        //        lblColumn4.Text = "Gender:";
        //        lblColumn5.Text = "Country ID:";                
        //    }
        //}

        //private void mnuData_Click(object sender, EventArgs e)
        //{
        //    dgvDelete1.Visible = true;
        //    textBox1.Visible = true;
        //    textBox2.Visible = true;
        //    textBox3.Visible = true;
        //    textBox4.Visible = true;
        //    textBox5.Visible = true;
        //    textBox6.Visible = true;

        //}       
    }
}
