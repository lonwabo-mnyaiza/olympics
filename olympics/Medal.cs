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
    public partial class Medal : Form
    {
        Placing medals = new Placing();

        public Medal()
        {
            InitializeComponent();
        }

        private void Medal_Load(object sender, EventArgs e)
        {
            dgvAllMedals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllMedals.DataSource = medals.AllPlacing();
            
            // can be removed at a later stage
            tabControlMedals.TabPages.Remove(tabCountryMedals);
            tabControlMedals.TabPages.Remove(tabTop10);
            tabControlMedals.TabPages.Remove(tabCompare);
        }
    }
}
