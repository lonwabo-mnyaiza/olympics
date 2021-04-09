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
    public partial class Day_by_Day_Events : Form
    {
        public Day_by_Day_Events()
        {
            InitializeComponent();
        }

        Event events = new Event();

        private void Day_by_Day_Events_Load(object sender, EventArgs e)
        {
            //mncEvents.MaxSelectionCount = 1;
            mncEvents.MaxDate = new DateTime(2012, 08, 12);
            mncEvents.MinDate = new DateTime(2012, 07, 27);           
        }

        private void mncEvents_DateChanged(object sender, DateRangeEventArgs e)
        {
            string day = mncEvents.ToString();
            dgvEvents.DataSource = events.DayEvent(day);
        }
    }
}
