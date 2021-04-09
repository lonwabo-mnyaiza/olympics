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
    public partial class Add_Records : Form
    {
        string addComboBox;
        string infoText = "enter ";
        string message = "Continue with operation..."; // All infomation is correct
        string caption = "Confirmation";

        Country country = new Country();
        Discipline discipline = new Discipline();
        Event events = new Event();
        Participant athlete = new Participant();
        Placing medals = new Placing();

        BindingSource addBinding;
         

        public Add_Records(string comboBoxText)
        {
            InitializeComponent();
            addComboBox = comboBoxText;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);            
            
            if (dr == DialogResult.Yes)
            {
                if (addComboBox == "Country")
                {
                    country.AddCountry(txtColumn2.Text, txtColumn3.Text);
                }
                if (addComboBox == "Discipline")
                {
                    discipline.AddDiscipline(txtColumn2.Text, txtColumn3.Text);
                }
                if (addComboBox == "Event")
                {                    
                    events.AddEvent(txtColumn1.Text, txtColumn2.Text, txtColumn3.Text, txtColumn4.Text, txtColumn5.Text, txtColumn6.Text);
                    //if (TextBox.Text.Trim().Length == 0)
                }
                if (addComboBox == "Participant")
                {
                    athlete.AddParticipant(txtColumn2.Text, txtColumn3.Text, txtColumn4.Text, txtColumn5.Text);
                }
                if (addComboBox == "Placing")
                {
 
                }
                this.Close();
            }
        }

        private void Add_Data_Load(object sender, EventArgs e)
        {
            // set the minimum to 1 and the maximum at a default is set to 100.
            numPlacing.Minimum = 1;

            // tabControl manipulations.
            tabControl1.TabPages["tabInfo"].Text = addComboBox;
            // hiding of tabpages.
            tabControl1.TabPages.Remove(tabTeamEvent);
            tabControl1.TabPages.Remove(tabIndividualEvent);
            tabControl1.TabPages.Remove(tabPlacing);

            mnuRecord.Text = infoText + "record";
            mnuTeamEvent.Visible = false;
            mnuIndividualEvent.Visible = false;
            mnuEvent.Visible = false;

            // context menu strip option set to not visible
            

            
            
            // label visibility set to off.
            lblColumn1.Visible = false;
            lblColumn2.Visible = false;
            lblColumn3.Visible = false;
            lblColumn4.Visible = false;
            lblColumn5.Visible = false;
            lblColumn6.Visible = false;

            if (addComboBox == "Country")
            {
                txtColumn1.Visible = false;
                txtColumn2.Visible = true;
                txtColumn3.Visible = true;
                txtColumn4.Visible = false;
                txtColumn5.Visible = false;
                txtColumn6.Visible = false;

                lblColumn1.Visible = false;
                lblColumn2.Visible = true;
                lblColumn3.Visible = true;
                lblColumn4.Visible = false;
                lblColumn5.Visible = false;
                lblColumn6.Visible = false;

                // try and make the context word bold and diff font...
                lblInfo.Text = infoText + "Country data here...";
                lblColumn2.Text = "CountryID:";
                lblColumn3.Text = "CountryName:";
            }

            if (addComboBox == "Discipline")
            {
                txtColumn1.Visible = false;
                txtColumn2.Visible = true;
                txtColumn3.Visible = true;
                txtColumn4.Visible = false;
                txtColumn5.Visible = false;
                txtColumn6.Visible = false;

                lblColumn1.Visible = false;
                lblColumn2.Visible = true;
                lblColumn3.Visible = true;
                lblColumn4.Visible = false;
                lblColumn5.Visible = false;
                lblColumn6.Visible = false;

                // try and make the context word bold and diff font...
                lblInfo.Text = infoText + "Discipline data here...";
                lblColumn2.Text = "Discipline Code:";
                lblColumn3.Text = "Discipline Desc:"; 
            }
            if (addComboBox == "Event")
            {
                txtColumn1.Visible = true;
                txtColumn2.Visible = true;
                txtColumn3.Visible = true;
                txtColumn4.Visible = true;
                txtColumn5.Visible = true;
                txtColumn6.Visible = true;

                lblColumn1.Visible = true;
                lblColumn2.Visible = true;
                lblColumn3.Visible = true;
                lblColumn4.Visible = true;
                lblColumn5.Visible = true;
                lblColumn6.Visible = true;

                // try and make the context word bold and diff font...
                lblInfo.Text = infoText + "Event data here...";
                lblColumn1.Text = "Event Desc:";
                lblColumn2.Text = "Discipline Code:";
                lblColumn3.Text = "Gender:";
                lblColumn4.Text = "EventType:";
                lblColumn5.Text = "EventDate:";
                lblColumn6.Text = "Venue:";

                tabControl1.TabPages.Add(tabTeamEvent);
                tabControl1.TabPages.Add(tabIndividualEvent);

                mnuTeamEvent.Visible = true;
                mnuIndividualEvent.Visible = true;
                mnuEvent.Visible = true;
            }
            if (addComboBox == "Participant")
            {
                txtColumn1.Visible = false;
                txtColumn2.Visible = true;
                txtColumn3.Visible = true;
                txtColumn4.Visible = true;
                txtColumn5.Visible = true;
                txtColumn6.Visible = false;

                lblColumn1.Visible = false;
                lblColumn2.Visible = true;
                lblColumn3.Visible = true;
                lblColumn4.Visible = true;
                lblColumn5.Visible = true;
                lblColumn6.Visible = false;

                // try and make the context word(Participant) bold and diff font...
                lblInfo.Text = infoText + "Participant data here...";
                lblColumn2.Text = "ID:";
                lblColumn3.Text = "Name:";
                lblColumn4.Text = "Gender:";
                lblColumn5.Text = "Country ID:";
            }
            if (addComboBox == "Placing")
            {
                tabControl1.TabPages.Remove(tabInfo);
                tabControl1.TabPages.Add(tabPlacing);
                lblInfo.Text = infoText + "Placing data here";


                // place holders need a improved select statement.
                addBinding = new BindingSource();
                addBinding.DataSource = medals.AllPlacing();

                cmbEventNo.DataSource = events.AllEvents();
                cmbEventNo.DisplayMember = "EventNo";
                cmbEventNo.ValueMember = "EventNo";

                //txtEventDesc.DataBindings.Add(new Binding("Text", addBinding,"EventDescription")); 

                cmbParticipantID.DataSource = athlete.AllParticipant();
                cmbParticipantID.DisplayMember = "ParticipantID";
                cmbParticipantID.ValueMember = "ParticipantID";

                //txtAthleteName.DataBindings.Add(new Binding("Text", addBinding, "ParticipantName"));

                cmbCountryID.DataSource = country.AllCountries();
                cmbCountryID.DisplayMember = "CountryID";
                cmbCountryID.ValueMember = "CountryID";

                //txtCountry.DataBindings.Add(new Binding("Text", addBinding, "CountryName"));                

                cmbDisciplineCode.DataSource = discipline.AllDiscipline();
                cmbDisciplineCode.DisplayMember = "DisciplineCode";
                cmbDisciplineCode.ValueMember = "DisciplineCode";

                //txtDisciplineDesc.DataBindings.Add(new Binding("Text", addBinding, "DisciplineDescription"));                
            }
        }

        private void mnuRecord_Click(object sender, EventArgs e)
        {
            btnAdd.Focus();
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

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabInfo);
        }

        private void cmbEventNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEventDesc.Text = events.PlacingEventDesc(cmbEventNo.Text).ToString();
        }

        private void cmbParticipantID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAthleteName.Text = athlete.PlacingParticipantName(cmbParticipantID.Text).ToString();
        }

        private void cmbCountryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCountry.Text = country.PlacingCountry(cmbCountryID.Text).ToString();
        }

        private void cmbDisciplineCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDisciplineDesc.Text = discipline.PlacingDisciplineDesc(cmbDisciplineCode.Text).ToString();
        }

        private void txtEventNo1_TextChanged(object sender, EventArgs e)
        {
            txtEventNo2.Text = txtEventNo1.Text;
        }

        private void txtCountryID1_TextChanged(object sender, EventArgs e)
        {
            txtCountryID2.Text = txtCountryID1.Text;
        }

        private void txtEventNo2_TextChanged(object sender, EventArgs e)
        {
            txtEventNo1.Text = txtEventNo2.Text;
        }

        private void txtCountryID2_TextChanged(object sender, EventArgs e)
        {
            txtCountryID1.Text = txtCountryID2.Text;
        }      
    }
}
