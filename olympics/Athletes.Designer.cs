namespace olympics
{
    partial class Athletes
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
            this.components = new System.ComponentModel.Container();
            this.dgvAllAthletes = new System.Windows.Forms.DataGridView();
            this.tabControlAthlete = new System.Windows.Forms.TabControl();
            this.tabAthletes = new System.Windows.Forms.TabPage();
            this.tabByCountry = new System.Windows.Forms.TabPage();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.dgvAthleteCountry = new System.Windows.Forms.DataGridView();
            this.tabByCountryDiscipline = new System.Windows.Forms.TabPage();
            this.btnGo = new System.Windows.Forms.Button();
            this.cmbEventNo = new System.Windows.Forms.ComboBox();
            this.cmbCountryEvent = new System.Windows.Forms.ComboBox();
            this.dgvCountryEvents = new System.Windows.Forms.DataGridView();
            this.tabbyEvent = new System.Windows.Forms.TabPage();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.contextMenuStripAthlete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.athletesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryDisciplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAthletes)).BeginInit();
            this.tabControlAthlete.SuspendLayout();
            this.tabAthletes.SuspendLayout();
            this.tabByCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthleteCountry)).BeginInit();
            this.tabByCountryDiscipline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountryEvents)).BeginInit();
            this.tabbyEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.contextMenuStripAthlete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllAthletes
            // 
            this.dgvAllAthletes.AllowUserToAddRows = false;
            this.dgvAllAthletes.AllowUserToDeleteRows = false;
            this.dgvAllAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAthletes.Location = new System.Drawing.Point(7, 7);
            this.dgvAllAthletes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllAthletes.Name = "dgvAllAthletes";
            this.dgvAllAthletes.ReadOnly = true;
            this.dgvAllAthletes.Size = new System.Drawing.Size(426, 233);
            this.dgvAllAthletes.TabIndex = 0;
            // 
            // tabControlAthlete
            // 
            this.tabControlAthlete.Controls.Add(this.tabAthletes);
            this.tabControlAthlete.Controls.Add(this.tabByCountry);
            this.tabControlAthlete.Controls.Add(this.tabByCountryDiscipline);
            this.tabControlAthlete.Controls.Add(this.tabbyEvent);
            this.tabControlAthlete.Location = new System.Drawing.Point(8, 9);
            this.tabControlAthlete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlAthlete.Name = "tabControlAthlete";
            this.tabControlAthlete.SelectedIndex = 0;
            this.tabControlAthlete.Size = new System.Drawing.Size(447, 279);
            this.tabControlAthlete.TabIndex = 1;
            // 
            // tabAthletes
            // 
            this.tabAthletes.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabAthletes.Controls.Add(this.dgvAllAthletes);
            this.tabAthletes.Location = new System.Drawing.Point(4, 25);
            this.tabAthletes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAthletes.Name = "tabAthletes";
            this.tabAthletes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAthletes.Size = new System.Drawing.Size(439, 250);
            this.tabAthletes.TabIndex = 0;
            this.tabAthletes.Text = "Athletes";
            // 
            // tabByCountry
            // 
            this.tabByCountry.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabByCountry.Controls.Add(this.cmbCountry);
            this.tabByCountry.Controls.Add(this.dgvAthleteCountry);
            this.tabByCountry.Location = new System.Drawing.Point(4, 25);
            this.tabByCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabByCountry.Name = "tabByCountry";
            this.tabByCountry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabByCountry.Size = new System.Drawing.Size(439, 250);
            this.tabByCountry.TabIndex = 1;
            this.tabByCountry.Text = "By Country";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(8, 9);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(124, 24);
            this.cmbCountry.TabIndex = 1;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // dgvAthleteCountry
            // 
            this.dgvAthleteCountry.AllowUserToAddRows = false;
            this.dgvAthleteCountry.AllowUserToDeleteRows = false;
            this.dgvAthleteCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthleteCountry.Location = new System.Drawing.Point(8, 41);
            this.dgvAthleteCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAthleteCountry.Name = "dgvAthleteCountry";
            this.dgvAthleteCountry.ReadOnly = true;
            this.dgvAthleteCountry.Size = new System.Drawing.Size(425, 201);
            this.dgvAthleteCountry.TabIndex = 0;
            // 
            // tabByCountryDiscipline
            // 
            this.tabByCountryDiscipline.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabByCountryDiscipline.Controls.Add(this.btnGo);
            this.tabByCountryDiscipline.Controls.Add(this.cmbEventNo);
            this.tabByCountryDiscipline.Controls.Add(this.cmbCountryEvent);
            this.tabByCountryDiscipline.Controls.Add(this.dgvCountryEvents);
            this.tabByCountryDiscipline.Location = new System.Drawing.Point(4, 25);
            this.tabByCountryDiscipline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabByCountryDiscipline.Name = "tabByCountryDiscipline";
            this.tabByCountryDiscipline.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabByCountryDiscipline.Size = new System.Drawing.Size(439, 250);
            this.tabByCountryDiscipline.TabIndex = 2;
            this.tabByCountryDiscipline.Text = "By Country Discipline";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGo.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(150, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(48, 46);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cmbEventNo
            // 
            this.cmbEventNo.FormattingEnabled = true;
            this.cmbEventNo.Location = new System.Drawing.Point(3, 29);
            this.cmbEventNo.Name = "cmbEventNo";
            this.cmbEventNo.Size = new System.Drawing.Size(109, 24);
            this.cmbEventNo.TabIndex = 2;
            // 
            // cmbCountryEvent
            // 
            this.cmbCountryEvent.FormattingEnabled = true;
            this.cmbCountryEvent.Location = new System.Drawing.Point(3, 4);
            this.cmbCountryEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCountryEvent.Name = "cmbCountryEvent";
            this.cmbCountryEvent.Size = new System.Drawing.Size(140, 24);
            this.cmbCountryEvent.TabIndex = 1;            
            // 
            // dgvCountryEvents
            // 
            this.dgvCountryEvents.AllowUserToAddRows = false;
            this.dgvCountryEvents.AllowUserToDeleteRows = false;
            this.dgvCountryEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountryEvents.Location = new System.Drawing.Point(7, 57);
            this.dgvCountryEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCountryEvents.Name = "dgvCountryEvents";
            this.dgvCountryEvents.ReadOnly = true;
            this.dgvCountryEvents.Size = new System.Drawing.Size(426, 185);
            this.dgvCountryEvents.TabIndex = 0;
            // 
            // tabbyEvent
            // 
            this.tabbyEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabbyEvent.Controls.Add(this.cmbEvent);
            this.tabbyEvent.Controls.Add(this.dgvEvent);
            this.tabbyEvent.Location = new System.Drawing.Point(4, 25);
            this.tabbyEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabbyEvent.Name = "tabbyEvent";
            this.tabbyEvent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabbyEvent.Size = new System.Drawing.Size(439, 250);
            this.tabbyEvent.TabIndex = 3;
            this.tabbyEvent.Text = "By Event";
            // 
            // cmbEvent
            // 
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(7, 7);
            this.cmbEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(140, 24);
            this.cmbEvent.TabIndex = 1;
            this.cmbEvent.SelectedIndexChanged += new System.EventHandler(this.cmbEvent_SelectedIndexChanged);
            // 
            // dgvEvent
            // 
            this.dgvEvent.AllowUserToAddRows = false;
            this.dgvEvent.AllowUserToDeleteRows = false;
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Location = new System.Drawing.Point(7, 39);
            this.dgvEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.ReadOnly = true;
            this.dgvEvent.Size = new System.Drawing.Size(426, 203);
            this.dgvEvent.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo.Location = new System.Drawing.Point(335, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(59, 15);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Filter by...";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            this.lblInfo.MouseLeave += new System.EventHandler(this.lblInfo_MouseLeave);
            this.lblInfo.MouseHover += new System.EventHandler(this.lblInfo_MouseHover);
            // 
            // contextMenuStripAthlete
            // 
            this.contextMenuStripAthlete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.athletesToolStripMenuItem,
            this.countryToolStripMenuItem,
            this.countryDisciplineToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStripAthlete.Name = "contextMenuStripAthlete";
            this.contextMenuStripAthlete.Size = new System.Drawing.Size(172, 114);
            // 
            // athletesToolStripMenuItem
            // 
            this.athletesToolStripMenuItem.Name = "athletesToolStripMenuItem";
            this.athletesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.athletesToolStripMenuItem.Text = "Athletes";
            this.athletesToolStripMenuItem.Click += new System.EventHandler(this.athletesToolStripMenuItem_Click);
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.countryToolStripMenuItem.Text = "Country";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // countryDisciplineToolStripMenuItem
            // 
            this.countryDisciplineToolStripMenuItem.Name = "countryDisciplineToolStripMenuItem";
            this.countryDisciplineToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.countryDisciplineToolStripMenuItem.Text = "Country Discipline";
            this.countryDisciplineToolStripMenuItem.Click += new System.EventHandler(this.countryDisciplineToolStripMenuItem_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.eventToolStripMenuItem.Text = "Event";
            this.eventToolStripMenuItem.Click += new System.EventHandler(this.eventToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Athletes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(467, 297);
            this.ContextMenuStrip = this.contextMenuStripAthlete;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tabControlAthlete);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Athletes";
            this.Text = "Athletes";
            this.Load += new System.EventHandler(this.Athletes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAthletes)).EndInit();
            this.tabControlAthlete.ResumeLayout(false);
            this.tabAthletes.ResumeLayout(false);
            this.tabByCountry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthleteCountry)).EndInit();
            this.tabByCountryDiscipline.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountryEvents)).EndInit();
            this.tabbyEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.contextMenuStripAthlete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllAthletes;
        private System.Windows.Forms.TabControl tabControlAthlete;
        private System.Windows.Forms.TabPage tabAthletes;
        private System.Windows.Forms.TabPage tabByCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.DataGridView dgvAthleteCountry;
        private System.Windows.Forms.TabPage tabByCountryDiscipline;
        private System.Windows.Forms.ComboBox cmbCountryEvent;
        private System.Windows.Forms.DataGridView dgvCountryEvents;
        private System.Windows.Forms.TabPage tabbyEvent;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ComboBox cmbEventNo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAthlete;
        private System.Windows.Forms.ToolStripMenuItem athletesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryDisciplineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}