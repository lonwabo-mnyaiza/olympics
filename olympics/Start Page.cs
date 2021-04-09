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
    public partial class Start_Page : Form
    {
        int adminClick = 0;
        int passwordClick = 0;
        int userClick = 0;

        string message = "This Administrator is not recognised by the application\nAccess Denied";
        string caption = "Unauthorised Access";

        public Start_Page()
        {
            InitializeComponent();
        }

        BusinessLayer businessLayer = new BusinessLayer();
        private void Start_Page_Load(object sender, EventArgs e)
        {
            cmbUsers.Items.Add("Admin");
            cmbUsers.Items.Add("End User");
            //cmbUsers.SelectedIndex = 0;

            txtAdminName.Visible = false;
            txtPassword.Visible = false;
            txtUserName.Visible = false;

            cmbUsers.Enabled = false;
            txtAdminName.Enabled = false;
            txtPassword.Enabled = false;
            btnNext.Enabled = false;
            //lblInit.Visible = false;

            //DataTable dt = new DataTable();
            //dt = businessLayer.SelectCountryFlag();

            //foreach (DataRow dr in dt)
            //{

            //}           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
            if (cmbUsers.Text == "Admin")
            {
                if (businessLayer.VerifyPassword(txtAdminName.Text, txtPassword.Text) == 1)
                {
                    OlympicsGamesAdmin adminPage = new OlympicsGamesAdmin();
                    this.Hide();
                    adminPage.ShowDialog();
                }
                else
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbUsers.Text == "End User")
            {
                OlympicsGamesUser userPage = new OlympicsGamesUser(txtUserName.Text);
                this.Hide();
                userPage.ShowDialog();                
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.Text == "Admin")
            {
                txtAdminName.Visible = true;
                txtPassword.Visible = true;
                txtPassword.Enabled = true;
                txtAdminName.Enabled = true;
                txtUserName.Visible = false;
            }
            else
            {
                txtAdminName.Visible = false;
                txtPassword.Visible = false;
                txtUserName.Visible = true;
            }
        }       

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            int randNum = randomNumber.Next(1, 11);

            prbLoad.Increment(randNum);

            if (prbLoad.Value < 5)
                lblInit.Text = "/Initializing";
            else if (prbLoad.Value < 10)
                lblInit.Text = "/Loading data";
            else if (prbLoad.Value < 15)
                lblInit.Text = "/Loading database";
            else if (prbLoad.Value < 20)
                lblInit.Text = "/Populating dataBase";
            else if (prbLoad.Value < 25)
                lblInit.Text = "/Populating tables";
            else if (prbLoad.Value < 30)
                lblInit.Text = "/Population stored procedures";
            else if (prbLoad.Value < 35)
                lblInit.Text = "/DB population complete";
            else if (prbLoad.Value < 40)
                lblInit.Text = "/Registering";
            else if (prbLoad.Value < 45)
                lblInit.Text = "/Registering complete";
            else if (prbLoad.Value < 50)
                lblInit.Text = "/Assembling components";
            else if (prbLoad.Value < 55)
                lblInit.Text = "/Finalizing components";
            else if (prbLoad.Value < 60)
                lblInit.Text = "/Component assembly complete";
            else if (prbLoad.Value < 65)
                lblInit.Text = "/Data testing";
            else if (prbLoad.Value < 70)
                lblInit.Text = "/Testing";
            else if (prbLoad.Value < 75)
                lblInit.Text = "/Testing complete";
            else if (prbLoad.Value < 80)
                lblInit.Text = "/Stabilizing";
            else if (prbLoad.Value < 90)
                lblInit.Text = "/Finalizing";
            else if (prbLoad.Value > 95)
                lblInit.Text = "/Complete";

            if (prbLoad.Value == prbLoad.Maximum)
            {
                prbLoad.Visible = false;
                lblInit.Visible = false;
                cmbUsers.Enabled = true;
                btnNext.Enabled = true;

                timerProgressBar.Stop();
            }
        }

        private void txtAdminName_Click_1(object sender, EventArgs e)
        {
            adminClick++;
            if (adminClick <= 1)
            {
                txtAdminName.Clear();
            }
            txtAdminName.Font = new Font(txtAdminName.Font, FontStyle.Regular);
            txtAdminName.ForeColor = Color.Black;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            passwordClick++;
            if (passwordClick <= 1)
            {
                txtPassword.Clear();
            }
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Regular);
            txtPassword.ForeColor = Color.Black;
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            userClick++;
            if (userClick <= 1)
            {
                txtUserName.Clear();
            }
            txtUserName.Font = new Font(txtPassword.Font, FontStyle.Regular);
            txtUserName.ForeColor = Color.Black;
        }          

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            userClick++;
            if (userClick <= 1)
            {
                txtUserName.Clear();
            }
            txtUserName.Font = new Font(txtPassword.Font, FontStyle.Regular);
            txtUserName.ForeColor = Color.Black;
        }

        private void txtAdminName_Enter(object sender, EventArgs e)
        {
            adminClick++;
            if (adminClick <= 1)
            {
                txtAdminName.Clear();
            }
            txtAdminName.Font = new Font(txtAdminName.Font, FontStyle.Regular);
            txtAdminName.ForeColor = Color.Black;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            passwordClick++;
            if (passwordClick <= 1)
            {
                txtPassword.Clear();
            }
            txtPassword.Font = new Font(txtPassword.Font, FontStyle.Regular);
            txtPassword.ForeColor = Color.Black;
        }             
    }
}
