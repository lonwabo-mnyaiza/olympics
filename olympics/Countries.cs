using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace olympics
{
    public partial class Countries : Form
    {
        Country country = new Country();
        int clickCount = 0;
        public Countries()
        {
            InitializeComponent();
        }

        private void Countries_Load(object sender, EventArgs e)
        {
            dgvCountries.DataSource = country.AllCountries();
            dgvCountries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount <= 1)
            {
                txtSearch.Clear();
            }
            txtSearch.Font = new Font(txtSearch.Font, FontStyle.Regular);
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // to make search-search for anything that contains the letters use prefix "%" + 
            string searchKey = txtSearch.Text + "%";
            dgvCountries.DataSource = country.SearchCountry(searchKey);
        }      
    }
}
