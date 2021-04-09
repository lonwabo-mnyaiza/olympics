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
    public partial class All_Events : Form
    {
        Discipline discipline = new Discipline();
        Event events = new Event();

        int clickCount = 0;

        string message = "Continue with operation..."; // All infomation is correct
        string caption = "Confirmation";
        DateTime startDate;
        DateTime endDate;

        public All_Events()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // to make search-search for anything that contains the letters use prefix "%" + 
            string searchKey = txtSearch.Text + "%";
            dgvAllEvents.DataSource = events.SearchEvent(searchKey);
        }

        private void All_Events_Load(object sender, EventArgs e)
        {            
            // for multiple olympics it is important that you leave this field wide
            dtpStartDate.MinDate = new DateTime(2012,07,27);
            dtpStartDate.MaxDate = new DateTime(2012, 08, 12);
            dtpEndDate.MinDate = new DateTime(2012, 07, 27);
            dtpEndDate.MaxDate = new DateTime(2012, 08, 12);

            startDate = dtpStartDate.MinDate = new DateTime(2012, 07, 27);
            endDate = dtpEndDate.MaxDate = new DateTime(2012, 08, 12);

            dtpStartDate.Value = startDate;
            dtpEndDate.Value = endDate;

            dgvAllEvents.DataSource = events.AllEvents();
            dgvDatedEvents.DataSource = events.AllEvents();
            dgvDisciplinedEvents.DataSource = events.AllEvents();

            dgvAllEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatedEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDisciplinedEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cmbDiscipline.DataSource = discipline.AllDiscipline();
            cmbDiscipline.DisplayMember = "DisciplineCode";
            cmbDiscipline.ValueMember = "DisciplineCode";

            txtDisciplineInfo.Visible = false;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount <= 1)
                txtSearch.Clear();

            txtSearch.Font = new Font(txtSearch.Font, FontStyle.Regular);
            txtSearch.ForeColor = Color.Black;
            // change the font.
        }

        private void cmbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDisciplineInfo.Visible = true;
            txtDisciplineInfo.Text = discipline.EventDisciplineDesc(cmbDiscipline.Text);
            dgvDisciplinedEvents.DataSource = events.DisciplinedEvents(cmbDiscipline.Text);            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // not sure if this will work or not
            string startDate = dtpStartDate.Text;
            string endDate = dtpEndDate.Text;
            DialogResult dr;
            dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
                dgvDatedEvents.DataSource = events.DateEvents(startDate, endDate);
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuEventDiscipline_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabDisciplineEvents);
        }

        private void mnuEventDates_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabEventDate);
        }

        private void mnuAllEvents_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabAllEvents);
        }            
    }
}
