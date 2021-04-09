namespace olympics
{
    partial class Medal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMedals = new System.Windows.Forms.TabControl();
            this.tabAllMedals = new System.Windows.Forms.TabPage();
            this.dgvAllMedals = new System.Windows.Forms.DataGridView();
            this.tabCountryMedals = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabTop10 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabCompare = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabControlMedals.SuspendLayout();
            this.tabAllMedals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMedals)).BeginInit();
            this.tabCountryMedals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabTop10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMedals
            // 
            this.tabControlMedals.Controls.Add(this.tabAllMedals);
            this.tabControlMedals.Controls.Add(this.tabCountryMedals);
            this.tabControlMedals.Controls.Add(this.tabTop10);
            this.tabControlMedals.Controls.Add(this.tabCompare);
            this.tabControlMedals.Location = new System.Drawing.Point(12, 13);
            this.tabControlMedals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlMedals.Name = "tabControlMedals";
            this.tabControlMedals.SelectedIndex = 0;
            this.tabControlMedals.Size = new System.Drawing.Size(684, 282);
            this.tabControlMedals.TabIndex = 0;
            // 
            // tabAllMedals
            // 
            this.tabAllMedals.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabAllMedals.Controls.Add(this.dgvAllMedals);
            this.tabAllMedals.Location = new System.Drawing.Point(4, 25);
            this.tabAllMedals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAllMedals.Name = "tabAllMedals";
            this.tabAllMedals.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAllMedals.Size = new System.Drawing.Size(676, 253);
            this.tabAllMedals.TabIndex = 0;
            this.tabAllMedals.Text = "AllMedals";
            // 
            // dgvAllMedals
            // 
            this.dgvAllMedals.AllowUserToAddRows = false;
            this.dgvAllMedals.AllowUserToDeleteRows = false;
            this.dgvAllMedals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllMedals.Location = new System.Drawing.Point(8, 9);
            this.dgvAllMedals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllMedals.Name = "dgvAllMedals";
            this.dgvAllMedals.ReadOnly = true;
            this.dgvAllMedals.Size = new System.Drawing.Size(662, 234);
            this.dgvAllMedals.TabIndex = 0;
            // 
            // tabCountryMedals
            // 
            this.tabCountryMedals.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabCountryMedals.Controls.Add(this.dataGridView2);
            this.tabCountryMedals.Location = new System.Drawing.Point(4, 25);
            this.tabCountryMedals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCountryMedals.Name = "tabCountryMedals";
            this.tabCountryMedals.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCountryMedals.Size = new System.Drawing.Size(676, 253);
            this.tabCountryMedals.TabIndex = 1;
            this.tabCountryMedals.Text = "tabPage2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 9);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(579, 234);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabTop10
            // 
            this.tabTop10.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabTop10.Controls.Add(this.dataGridView3);
            this.tabTop10.Location = new System.Drawing.Point(4, 25);
            this.tabTop10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTop10.Name = "tabTop10";
            this.tabTop10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTop10.Size = new System.Drawing.Size(676, 253);
            this.tabTop10.TabIndex = 2;
            this.tabTop10.Text = "tabPage3";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 9);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(575, 234);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabCompare
            // 
            this.tabCompare.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabCompare.Controls.Add(this.dataGridView4);
            this.tabCompare.Location = new System.Drawing.Point(4, 25);
            this.tabCompare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCompare.Name = "tabCompare";
            this.tabCompare.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCompare.Size = new System.Drawing.Size(676, 253);
            this.tabCompare.TabIndex = 3;
            this.tabCompare.Text = "tabPage4";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(8, 9);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(575, 234);
            this.dataGridView4.TabIndex = 0;
            // 
            // Medal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(713, 313);
            this.Controls.Add(this.tabControlMedals);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Medal";
            this.Text = "Medal";
            this.Load += new System.EventHandler(this.Medal_Load);
            this.tabControlMedals.ResumeLayout(false);
            this.tabAllMedals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMedals)).EndInit();
            this.tabCountryMedals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabTop10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabCompare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMedals;
        private System.Windows.Forms.TabPage tabAllMedals;
        private System.Windows.Forms.DataGridView dgvAllMedals;
        private System.Windows.Forms.TabPage tabCountryMedals;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabTop10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabCompare;
        private System.Windows.Forms.DataGridView dataGridView4;


    }
}