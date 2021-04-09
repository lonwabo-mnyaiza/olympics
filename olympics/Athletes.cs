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
    public partial class Athletes : Form
    {
        public Athletes()
        {
            InitializeComponent();
        }

        Participant athlete = new Participant();
        Country country = new Country();
        Event events = new Event();
        Discipline discipline = new Discipline();

        private void Athletes_Load(object sender, EventArgs e)
        {
            lblInfo.Visible = false;

            dgvAllAthletes.DataSource = athlete.AllParticipant();
            //dgvAthleteCountry.DataSource = athlete.AllParticipant();
            dgvCountryEvents.DataSource = athlete.AllParticipant();
            //dgvEvent.DataSource = athlete.AllParticipant();

            dgvAllAthletes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAthleteCountry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCountryEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cmbCountry.DataSource = country.AllCountries();
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";

            cmbCountryEvent.DataSource = country.AllCountries();
            cmbCountryEvent.DisplayMember = "CountryName";
            cmbCountryEvent.ValueMember = "CountryID";

            cmbEventNo.DataSource = events.AllEvents();
            cmbEventNo.DisplayMember = "EventDescription";
            cmbEventNo.ValueMember = "EventNo";

            cmbEvent.DataSource = events.AllEvents();
            cmbEvent.DisplayMember = "EventDescription";
            cmbEvent.ValueMember = "EventNo";

            // pro version feature and the lblInfo_Click event
            //tabControlAthlete.TabPages.Remove(tabByCountry);
            //tabControlAthlete.TabPages.Remove(tabByCountryDiscipline);
            //tabControlAthlete.TabPages.Remove(tabbyEvent);

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            tabControlAthlete.TabPages.Add(tabByCountry);
            tabControlAthlete.TabPages.Add(tabByCountryDiscipline);
            tabControlAthlete.TabPages.Add(tabbyEvent);

            lblInfo.Visible = false;
        }

        private void athletesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlAthlete.SelectTab(tabAthletes);
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlAthlete.SelectTab(tabByCountry);
        }

        private void countryDisciplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlAthlete.SelectTab(tabByCountryDiscipline);
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlAthlete.SelectTab(tabbyEvent);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAthleteCountry.DataSource = athlete.CountryParticipants(cmbCountry.SelectedValue.ToString());
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            dgvCountryEvents.DataSource = athlete.CountryEventParticipants(cmbCountryEvent.SelectedValue.ToString() , cmbEventNo.Text);
        }

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEvent.DataSource = athlete.EventParticipants(cmbEvent.Text);
        }

        private void lblInfo_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Font = new Font(lblInfo.Font, FontStyle.Underline);            
            lblInfo.ForeColor = Color.DarkGreen;
        }

        private void lblInfo_MouseLeave(object sender, EventArgs e)
        {            
            lblInfo.ForeColor = Color.Navy;
        }        
    }
}
