using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace olympics
{
    public partial class OlympicsGamesUser : Form
    {
        Country country = new Country();
        string textFile = "Disclaimer.txt";
        string olympicHistory = "http://en.wikipedia.org/wiki/Olympic_Games";
        string olympicWebSite = "http://www.london2012.com/schedule-and-results/full-schedule.html";
        string olympicFacebook = "http://www.facebook.com/olympics?ref=ts&fref=ts";
        string olympicTwitter = "https://twitter.com/Olympics";
        string creditsFile = "C:/Users/lonwabo/Documents/#School My Modules/#IT 2nd year/Second Semester/Software Development ONT2000/Olympics/olympics/bin/Debug/Credits/bin/Debug/Credits.txt";
        string userManual = "UserManual.docx";
        string name;
        string imagePath = "C:/Users/lonwabo/Documents/#School My Modules/#IT 2nd year/Second Semester/Software Development ONT2000/Olympics/olympics/bin/Debug/Images/";
        int imageCounter = 0;
        
        public OlympicsGamesUser(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void Olympics_Load(object sender, EventArgs e)
        {
            lblDaybyDayEvents.Visible = false;
            timerOlympicApp.Start();
            notifyIconInfo.ShowBalloonTip(600000);
            if (name != "First Name")
                lblWelcome.Text += name;
          
        }       

        private void mnuContextExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuEvents_Click(object sender, EventArgs e)
        {
            All_Events allEvents = new All_Events();
            allEvents.ShowDialog();
        }

        private void mnuDisclaimer_Click(object sender, EventArgs e)
        {
            Process.Start(textFile);
        }

        private void mnuContextDisclaimer_Click(object sender, EventArgs e)
        {
            Process.Start(textFile);
        }

        private void mnuHistory_Click(object sender, EventArgs e)
        {
            Process.Start(olympicHistory);
        }

        private void mnuCredits_Click(object sender, EventArgs e)
        {
            Process.Start(creditsFile);         
        }

        private void medalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medal medal = new Medal();
            medal.ShowDialog();
        }

        private void mnuAthlete_Click(object sender, EventArgs e)
        {
            Athletes athletes = new Athletes();
            athletes.ShowDialog();
        }

        private void mnuCountry_Click(object sender, EventArgs e)
        {
            Countries countries = new Countries();
            countries.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIconInfo.ShowBalloonTip(5000);

            

            //if (imageCounter <= 7)
            //{
            //    this.SuspendLayout();
            //    pictureBoxPrimary.Image = new Bitmap("C:/Users/lonwabo/Documents/#School My Modules/#IT 2nd year/Second Semester/Software Development ONT2000/Olympics/olympics/bin/Debug/Images/" + imageCounter + ".jpg");
            //    this.ResumeLayout();
            //}
            //else
            //{
            //    imageCounter = 0;
            //}
        }

        private void notifyIconInfo_BalloonTipClicked(object sender, EventArgs e)
        {
            Process.Start(olympicWebSite);
        }

        private void mnuContents_Click(object sender, EventArgs e)
        {
            OpenMicrosoftWord(userManual);
        }

        static void OpenMicrosoftWord(string file)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "WINwORD.EXE";
            startInfo.Arguments = file;
            Process.Start(startInfo);
        }

        private void webSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(olympicWebSite);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(olympicFacebook);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start(olympicTwitter);
        }

        private void lblDaybyDayEvents_Click(object sender, EventArgs e)
        {
            Day_by_Day_Events dayEvents = new Day_by_Day_Events();
            dayEvents.ShowDialog();
        }

        //protected override bool ProcessCmdKey(Keys keyData)
        //{
        //    if (keyData == Keys.F1)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
      
        // athlete menu click causes the athlete form to pop up with the required information.

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (grpDisplay.Visible = true && cmbAdd.Focused == false && cmbChange.Focused == false && cmbDelete.Focused == false && radOnOff.Checked == false)
        //    {
        //        //grpDisplay.Visible = false;
        //        //cmbDelete.Visible = false;
        //        //cmbAdd.Visible = false;
        //        //cmbChange.Visible = false;
        //        //radOnOff.Visible = false;
        //        panContainer.Visible = false;
        //        timer1.Stop();
        //    }
        //}        
        // use the timer and the mouse leave to make the mnuMod disappear again.       
    }
}
