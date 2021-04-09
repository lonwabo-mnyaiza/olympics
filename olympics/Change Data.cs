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
    public partial class Change_Records : Form
    {
        // if you change team event you'll also need to change team participant.
        // displayed in the message box
        string message = "Continue with operation..."; // All infomation is correct
        string caption = "Confirmation";

        string messageTextbox = "Please Fill in the corresponding tabs to advance";
        string captionTextbox = "Incomplete Arguments";
        string changeComboBox;
        string infoText = "change ";
        bool isIncomplete = false;

        Country country = new Country();
        Discipline discipline = new Discipline();
        Event events = new Event();
        Participant athlete = new Participant();
        Medal medals = new Medal();
        Placing medal = new Placing();

        public Change_Records(string comboBoxText)
        {
            InitializeComponent();
            changeComboBox = comboBoxText;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes)
            {
                if (changeComboBox == "Country")
                {
                    country.EditCountry(txtColumn2.Text, txtColumn3.Text);
                }
                if (changeComboBox == "Discipline")
                {
                    discipline.EditDiscipline(txtColumn2.Text, txtColumn3.Text);
                }
                if (changeComboBox == "Event")
                {
                    //foreach (Control control in this.Controls)
                    //{
                    //    if (control is TextBox)
                    //    {
                    //        TextBox tb = control as TextBox;
                    //        if (string.IsNullOrEmpty(tb.Text))
                    //        {
                    //            isIncomplete = true;
                    //            break;
                    //        }
                    //    }
                    //}

                    //if (isIncomplete)
                    //{
                    //    MessageBox.Show(messageTextbox, captionTextbox, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else
                    events.EditEvent(txtColumn1.Text, txtColumn2.Text, txtColumn3.Text, txtColumn4.Text, txtColumn5.Text, txtColumn6.Text);
                }
                if (changeComboBox == "Participant")
                {
                    athlete.EditParticipant(txtColumn2.Text, txtColumn3.Text, txtColumn4.Text, txtColumn5.Text);
                }
                this.Close();
            }
        }

        private void Change_Data_Load(object sender, EventArgs e)
        {
            // set label visibility to false.
            lblColumn1.Visible = false;
            lblColumn2.Visible = false;
            lblColumn3.Visible = false;
            lblColumn4.Visible = false;
            lblColumn5.Visible = false;
            lblColumn6.Visible = false;
            lblColumn7.Visible = false;
            // make dataGridView full row selection.
            dgvChange1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChange2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChangeTwo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChange3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlacing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // tabControl manipulations.
            tabControl1.TabPages["tabInfo"].Text = changeComboBox;
            // hide the remainder of the pages.
            tabControl1.TabPages.Remove(tabTeamEvent);
            tabControl1.TabPages.Remove(tabIndividualEvent);
            tabControl1.TabPages.Remove(tabPlacing);

            mnuRecord.Text = infoText + "record";
            mnuTeamEvent.Visible = false;
            mnuIndividualEvent.Visible = false;
            mnuEvent.Visible = false;

            if (changeComboBox == "Country")
            {
                txtColumn1.Visible = true;
                txtColumn2.Visible = true;
                txtColumn3.Visible = false;
                txtColumn4.Visible = false;
                txtColumn5.Visible = false;
                txtColumn6.Visible = false;
                txtColumn7.Visible = false;

                lblColumn1.Visible = true;
                lblColumn2.Visible = true;
                lblColumn3.Visible = false;
                lblColumn4.Visible = false;
                lblColumn5.Visible = false;
                lblColumn6.Visible = false;
                lblColumn7.Visible = false;

                // try and make the context word bold and diff font.
                lblInfo.Text = infoText + "Country data here...";
                lblColumn1.Text = "CountryID:";
                lblColumn2.Text = "CountryName:";

                dgvChange1.DataSource = country.AllCountries();
            }

            if (changeComboBox == "Discipline")
            {
                txtColumn1.Visible = true;
                txtColumn2.Visible = true;
                txtColumn3.Visible = false;
                txtColumn4.Visible = false;
                txtColumn5.Visible = false;
                txtColumn6.Visible = false;
                txtColumn7.Visible = false;

                lblColumn1.Visible = true;
                lblColumn2.Visible = true;
                lblColumn3.Visible = false;
                lblColumn4.Visible = false;
                lblColumn5.Visible = false;
                lblColumn6.Visible = false;
                lblColumn7.Visible = false;

                // try and make the context word bold and diff font.
                lblInfo.Text = infoText + "Discipline data here...";
                lblColumn1.Text = "Discipline Code:";
                lblColumn2.Text = "Discipline Desc:";

                dgvChange1.DataSource = discipline.AllDiscipline();
            }
            if (changeComboBox == "Event")
            {
                txtColumn1.Visible = true;
                txtColumn2.Visible = true;
                txtColumn3.Visible = true;
                txtColumn4.Visible = true;
                txtColumn5.Visible = true;
                txtColumn6.Visible = true;
                txtColumn7.Visible = true;

                lblColumn1.Visible = true;
                lblColumn2.Visible = true;
                lblColumn3.Visible = true;
                lblColumn4.Visible = true;
                lblColumn5.Visible = true;
                lblColumn6.Visible = true;
                lblColumn7.Visible = true;

                // try and make the context word bold and diff font.
                lblInfo.Text = infoText + "Event data here...";
                lblColumn1.Text = "Event No";
                lblColumn2.Text = "Event Desc:";
                lblColumn3.Text = "Discipline Code:";
                lblColumn4.Text = "Gender:";
                lblColumn5.Text = "EventType:";
                lblColumn6.Text = "EventDate:";
                lblColumn7.Text = "Venue:";

                tabControl1.TabPages.Add(tabTeamEvent);
                tabControl1.TabPages.Add(tabIndividualEvent);

                dgvChange1.DataSource = events.AllEvents();
                dgvChange2.DataSource = events.TeamEvent();
                dgvChangeTwo.DataSource = events.TeamParticipants();
                dgvChange3.DataSource = events.IndividualEvent();

                mnuTeamEvent.Visible = true;
                mnuIndividualEvent.Visible = true;
                mnuEvent.Visible = true;


            }
            if (changeComboBox == "Participant")
            {
                txtColumn1.Visible = true;
                txtColumn2.Visible = true;
                txtColumn3.Visible = false;
                txtColumn4.Visible = true;
                txtColumn5.Visible = true;
                txtColumn6.Visible = false;
                txtColumn7.Visible = false;

                lblColumn1.Visible = true;
                lblColumn2.Visible = true;
                lblColumn3.Visible = false;
                lblColumn4.Visible = true;
                lblColumn5.Visible = true;
                lblColumn6.Visible = false;
                lblColumn7.Visible = false;

                // try and make the context word(Participant) bold and diff font.
                // can have two dif text boxes.
                lblInfo.Text = infoText + "Participant data here...";
                lblColumn1.Text = "ID:";
                lblColumn2.Text = "Name:";
                lblColumn4.Text = "Gender:";
                lblColumn5.Text = "Country ID:";

                dgvChange1.DataSource = athlete.AllParticipant();
            }
            if (changeComboBox == "Placing")
            {
                tabControl1.TabPages.Remove(tabInfo);
                tabControl1.TabPages.Add(tabPlacing);
                lblInfo.Text = infoText + "Placing data here";
                dgvPlacing.DataSource = medal.AllPlacing();

                txtColumn1.Visible = true;
                txtColumn2.Visible = true;
                txtColumn3.Visible = true;
                txtColumn4.Visible = true;
                txtColumn5.Visible = true;
                txtColumn6.Visible = false;
                txtColumn7.Visible = false;

                lblColumn1.Visible = true;
                lblColumn2.Visible = true;
                lblColumn3.Visible = true;
                lblColumn4.Visible = true;
                lblColumn5.Visible = true;
                lblColumn6.Visible = false;
                lblColumn7.Visible = false;

                lblColumn1.Text = "EventNo";
                lblColumn2.Text = "ParticipantID";
                lblColumn3.Text = "CountryID";
                lblColumn4.Text = "DisciplineCode";
                lblColumn5.Text = "Placing";

            }
        }

        private void mnuRecord_Click(object sender, EventArgs e)
        {
            btnChange.Focus();
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

        private void dgvChange1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (changeComboBox == "Country")
            {
                if (dgvChange1.SelectedRows.Count > 0)
                {
                    txtColumn1.Text = dgvChange1.SelectedRows[0].Cells[0].Value.ToString();
                    txtColumn2.Text = dgvChange1.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
            if (changeComboBox == "Discipline")
            {
                if (dgvChange1.SelectedRows.Count > 0)
                {
                    txtColumn1.Text = dgvChange1.SelectedRows[0].Cells[0].Value.ToString();
                    txtColumn2.Text = dgvChange1.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
            if (changeComboBox == "Event")
            {
                txtColumn1.Visible = true;
                txtColumn2.Visible = true;
                txtColumn3.Visible = true;
                txtColumn4.Visible = true;
                txtColumn5.Visible = true;
                txtColumn6.Visible = true;
                txtColumn7.Visible = true;

                lblColumn1.Visible = true;
                lblColumn2.Visible = true;
                lblColumn3.Visible = true;
                lblColumn4.Visible = true;
                lblColumn5.Visible = true;
                lblColumn6.Visible = true;
                lblColumn7.Visible = true;

                // try and make the context word bold and diff font.
                lblInfo.Text = infoText + "Event data here...";
                lblColumn1.Text = "Event No";
                lblColumn2.Text = "Event Desc:";
                lblColumn3.Text = "Discipline Code:";
                lblColumn4.Text = "Gender:";
                lblColumn5.Text = "EventType:";
                lblColumn6.Text = "EventDate:";
                lblColumn7.Text = "Venue:";

                if (dgvChange1.SelectedRows.Count > 0)
                {
                    txtColumn1.Text = dgvChange1.SelectedRows[0].Cells[0].Value.ToString();
                    txtColumn2.Text = dgvChange1.SelectedRows[0].Cells[1].Value.ToString();
                    txtColumn3.Text = dgvChange1.SelectedRows[0].Cells[2].Value.ToString();
                    txtColumn4.Text = dgvChange1.SelectedRows[0].Cells[3].Value.ToString();
                    txtColumn5.Text = dgvChange1.SelectedRows[0].Cells[4].Value.ToString();
                    txtColumn6.Text = dgvChange1.SelectedRows[0].Cells[5].Value.ToString();
                    txtColumn7.Text = dgvChange1.SelectedRows[0].Cells[6].Value.ToString();
                }
            }
            if (changeComboBox == "Participant")
            {
                if (dgvChange1.SelectedRows.Count > 0)
                {
                    txtColumn1.Text = dgvChange1.SelectedRows[0].Cells[0].Value.ToString();
                    txtColumn2.Text = dgvChange1.SelectedRows[0].Cells[1].Value.ToString();

                    txtColumn4.Text = dgvChange1.SelectedRows[0].Cells[2].Value.ToString();
                    txtColumn5.Text = dgvChange1.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
        }        

        private void dgvChange2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtColumn1.Visible = true;
            txtColumn2.Visible = true;
            txtColumn3.Visible = false;
            txtColumn4.Visible = false;
            txtColumn5.Visible = false;
            txtColumn6.Visible = false;
            txtColumn7.Visible = false;

            lblColumn1.Visible = true;
            lblColumn2.Visible = true;
            lblColumn3.Visible = false;
            lblColumn4.Visible = false;
            lblColumn5.Visible = false;
            lblColumn6.Visible = false;
            lblColumn7.Visible = false;

            // try and make the context word bold and diff font.
            lblInfo.Text = infoText + "Event data here...";
            lblColumn1.Text = "Event No:";
            lblColumn2.Text = "Country ID:";

            if (dgvChange2.SelectedRows.Count > 0)
            {
                txtColumn1.Text = dgvChange2.SelectedRows[0].Cells[0].Value.ToString();
                txtColumn2.Text = dgvChange2.SelectedRows[0].Cells[1].Value.ToString();                
            }
        }

        private void dgvChangeTwo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtColumn1.Visible = true;
            txtColumn2.Visible = true;
            txtColumn3.Visible = true;
            txtColumn4.Visible = true;
            txtColumn5.Visible = false;
            txtColumn6.Visible = false;
            txtColumn7.Visible = false;

            lblColumn1.Visible = true;
            lblColumn2.Visible = true;
            lblColumn3.Visible = true;
            lblColumn4.Visible = true;
            lblColumn5.Visible = false;
            lblColumn6.Visible = false;
            lblColumn7.Visible = false;

            // try and make the context word bold and diff font.
            lblInfo.Text = infoText + "Event data here...";
            lblColumn1.Text = "Event No:";
            lblColumn2.Text = "Country ID:";
            lblColumn3.Text = "Participant ID:";
            lblColumn4.Text = "Participant Role:";

            if (dgvChangeTwo.SelectedRows.Count > 0)
            {
                txtColumn1.Text = dgvChangeTwo.SelectedRows[0].Cells[0].Value.ToString();
                txtColumn2.Text = dgvChangeTwo.SelectedRows[0].Cells[1].Value.ToString();
                txtColumn3.Text = dgvChangeTwo.SelectedRows[0].Cells[2].Value.ToString();
                txtColumn4.Text = dgvChangeTwo.SelectedRows[0].Cells[3].Value.ToString();                
            }
        }

        private void dgvChange3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtColumn1.Visible = true;
            txtColumn2.Visible = true;
            txtColumn3.Visible = true;
            txtColumn4.Visible = false;
            txtColumn5.Visible = false;
            txtColumn6.Visible = false;
            txtColumn7.Visible = false;

            lblColumn1.Visible = true;
            lblColumn2.Visible = true;
            lblColumn3.Visible = true;
            lblColumn4.Visible = false;
            lblColumn5.Visible = false;
            lblColumn6.Visible = false;
            lblColumn7.Visible = false;

            // try and make the context word bold and diff font.
            lblInfo.Text = infoText + "Event data here...";
            lblColumn1.Text = "Event No:";
            lblColumn2.Text = "Participant ID:";
            lblColumn3.Text = "Country ID:";

            if (dgvChange3.SelectedRows.Count > 0)
            {
                txtColumn1.Text = dgvChange3.SelectedRows[0].Cells[0].Value.ToString();
                txtColumn2.Text = dgvChange3.SelectedRows[0].Cells[1].Value.ToString();
                txtColumn3.Text = dgvChange3.SelectedRows[0].Cells[2].Value.ToString();                
            }
        }

        private void dgvPlacing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (changeComboBox == "Placing")
            {
                if (dgvPlacing.SelectedRows.Count > 0)
                {
                    txtColumn1.Text = dgvPlacing.SelectedRows[0].Cells[0].Value.ToString();
                    txtColumn2.Text = dgvPlacing.SelectedRows[0].Cells[1].Value.ToString();
                    txtColumn3.Text = dgvPlacing.SelectedRows[0].Cells[2].Value.ToString();
                    txtColumn4.Text = dgvPlacing.SelectedRows[0].Cells[3].Value.ToString();
                    txtColumn5.Text = dgvPlacing.SelectedRows[0].Cells[4].Value.ToString();                    
                }
            }
        }
    }
}