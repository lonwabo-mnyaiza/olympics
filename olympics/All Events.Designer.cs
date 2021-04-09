namespace olympics
{
    partial class All_Events
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
            this.dgvAllEvents = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbDiscipline = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAllEvents = new System.Windows.Forms.TabPage();
            this.tabDisciplineEvents = new System.Windows.Forms.TabPage();
            this.txtDisciplineInfo = new System.Windows.Forms.TextBox();
            this.dgvDisciplinedEvents = new System.Windows.Forms.DataGridView();
            this.tabEventDate = new System.Windows.Forms.TabPage();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtBetween = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvDatedEvents = new System.Windows.Forms.DataGridView();
            this.contextMenuEvents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAllEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEventDiscipline = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEventDates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEvents)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAllEvents.SuspendLayout();
            this.tabDisciplineEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinedEvents)).BeginInit();
            this.tabEventDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatedEvents)).BeginInit();
            this.contextMenuEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllEvents
            // 
            this.dgvAllEvents.AllowUserToAddRows = false;
            this.dgvAllEvents.AllowUserToDeleteRows = false;
            this.dgvAllEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllEvents.Location = new System.Drawing.Point(7, 38);
            this.dgvAllEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllEvents.Name = "dgvAllEvents";
            this.dgvAllEvents.ReadOnly = true;
            this.dgvAllEvents.Size = new System.Drawing.Size(825, 206);
            this.dgvAllEvents.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(657, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 16);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(715, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(116, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Event Desc...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbDiscipline
            // 
            this.cmbDiscipline.FormattingEnabled = true;
            this.cmbDiscipline.Location = new System.Drawing.Point(124, 7);
            this.cmbDiscipline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDiscipline.Name = "cmbDiscipline";
            this.cmbDiscipline.Size = new System.Drawing.Size(87, 24);
            this.cmbDiscipline.TabIndex = 3;
            this.cmbDiscipline.SelectedIndexChanged += new System.EventHandler(this.cmbDiscipline_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAllEvents);
            this.tabControl1.Controls.Add(this.tabDisciplineEvents);
            this.tabControl1.Controls.Add(this.tabEventDate);
            this.tabControl1.Location = new System.Drawing.Point(7, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 283);
            this.tabControl1.TabIndex = 5;
            // 
            // tabAllEvents
            // 
            this.tabAllEvents.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabAllEvents.Controls.Add(this.dgvAllEvents);
            this.tabAllEvents.Controls.Add(this.lblSearch);
            this.tabAllEvents.Controls.Add(this.txtSearch);
            this.tabAllEvents.Location = new System.Drawing.Point(4, 25);
            this.tabAllEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAllEvents.Name = "tabAllEvents";
            this.tabAllEvents.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAllEvents.Size = new System.Drawing.Size(844, 254);
            this.tabAllEvents.TabIndex = 0;
            this.tabAllEvents.Text = "All Events";
            // 
            // tabDisciplineEvents
            // 
            this.tabDisciplineEvents.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabDisciplineEvents.Controls.Add(this.txtDisciplineInfo);
            this.tabDisciplineEvents.Controls.Add(this.dgvDisciplinedEvents);
            this.tabDisciplineEvents.Controls.Add(this.cmbDiscipline);
            this.tabDisciplineEvents.Location = new System.Drawing.Point(4, 25);
            this.tabDisciplineEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDisciplineEvents.Name = "tabDisciplineEvents";
            this.tabDisciplineEvents.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDisciplineEvents.Size = new System.Drawing.Size(844, 254);
            this.tabDisciplineEvents.TabIndex = 1;
            this.tabDisciplineEvents.Text = "Discipline Events";
            // 
            // txtDisciplineInfo
            // 
            this.txtDisciplineInfo.Location = new System.Drawing.Point(7, 7);
            this.txtDisciplineInfo.Name = "txtDisciplineInfo";
            this.txtDisciplineInfo.ReadOnly = true;
            this.txtDisciplineInfo.Size = new System.Drawing.Size(111, 23);
            this.txtDisciplineInfo.TabIndex = 4;
            // 
            // dgvDisciplinedEvents
            // 
            this.dgvDisciplinedEvents.AllowUserToAddRows = false;
            this.dgvDisciplinedEvents.AllowUserToDeleteRows = false;
            this.dgvDisciplinedEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinedEvents.Location = new System.Drawing.Point(6, 48);
            this.dgvDisciplinedEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDisciplinedEvents.Name = "dgvDisciplinedEvents";
            this.dgvDisciplinedEvents.ReadOnly = true;
            this.dgvDisciplinedEvents.Size = new System.Drawing.Size(828, 185);
            this.dgvDisciplinedEvents.TabIndex = 0;
            // 
            // tabEventDate
            // 
            this.tabEventDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabEventDate.Controls.Add(this.btnGo);
            this.tabEventDate.Controls.Add(this.txtBetween);
            this.tabEventDate.Controls.Add(this.lblEndDate);
            this.tabEventDate.Controls.Add(this.lblStartDate);
            this.tabEventDate.Controls.Add(this.dtpEndDate);
            this.tabEventDate.Controls.Add(this.dtpStartDate);
            this.tabEventDate.Controls.Add(this.dgvDatedEvents);
            this.tabEventDate.Location = new System.Drawing.Point(4, 25);
            this.tabEventDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabEventDate.Name = "tabEventDate";
            this.tabEventDate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabEventDate.Size = new System.Drawing.Size(844, 254);
            this.tabEventDate.TabIndex = 2;
            this.tabEventDate.Text = "Event Date";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGo.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(517, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(56, 41);
            this.btnGo.TabIndex = 13;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtBetween
            // 
            this.txtBetween.Location = new System.Drawing.Point(173, 27);
            this.txtBetween.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBetween.Name = "txtBetween";
            this.txtBetween.Size = new System.Drawing.Size(171, 23);
            this.txtBetween.TabIndex = 12;
            this.txtBetween.Text = "Events between these dates";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(350, 9);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(57, 16);
            this.lblEndDate.TabIndex = 11;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(7, 9);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(67, 16);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(350, 27);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(160, 23);
            this.dtpEndDate.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(7, 27);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(160, 23);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dgvDatedEvents
            // 
            this.dgvDatedEvents.AllowUserToAddRows = false;
            this.dgvDatedEvents.AllowUserToDeleteRows = false;
            this.dgvDatedEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatedEvents.Location = new System.Drawing.Point(7, 59);
            this.dgvDatedEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDatedEvents.Name = "dgvDatedEvents";
            this.dgvDatedEvents.ReadOnly = true;
            this.dgvDatedEvents.Size = new System.Drawing.Size(828, 185);
            this.dgvDatedEvents.TabIndex = 9;
            // 
            // contextMenuEvents
            // 
            this.contextMenuEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAllEvents,
            this.mnuEventDiscipline,
            this.mnuEventDates,
            this.mnuClose});
            this.contextMenuEvents.Name = "contextMenuEvents";
            this.contextMenuEvents.Size = new System.Drawing.Size(157, 92);
            // 
            // mnuAllEvents
            // 
            this.mnuAllEvents.Name = "mnuAllEvents";
            this.mnuAllEvents.Size = new System.Drawing.Size(156, 22);
            this.mnuAllEvents.Text = "all events";
            this.mnuAllEvents.Click += new System.EventHandler(this.mnuAllEvents_Click);
            // 
            // mnuEventDiscipline
            // 
            this.mnuEventDiscipline.Name = "mnuEventDiscipline";
            this.mnuEventDiscipline.Size = new System.Drawing.Size(156, 22);
            this.mnuEventDiscipline.Text = "event discipline";
            this.mnuEventDiscipline.Click += new System.EventHandler(this.mnuEventDiscipline_Click);
            // 
            // mnuEventDates
            // 
            this.mnuEventDates.Name = "mnuEventDates";
            this.mnuEventDates.Size = new System.Drawing.Size(156, 22);
            this.mnuEventDates.Text = "event dates";
            this.mnuEventDates.Click += new System.EventHandler(this.mnuEventDates_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(156, 22);
            this.mnuClose.Text = "close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // All_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(854, 313);
            this.ContextMenuStrip = this.contextMenuEvents;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "All_Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.All_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEvents)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAllEvents.ResumeLayout(false);
            this.tabAllEvents.PerformLayout();
            this.tabDisciplineEvents.ResumeLayout(false);
            this.tabDisciplineEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinedEvents)).EndInit();
            this.tabEventDate.ResumeLayout(false);
            this.tabEventDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatedEvents)).EndInit();
            this.contextMenuEvents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllEvents;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbDiscipline;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAllEvents;
        private System.Windows.Forms.TabPage tabDisciplineEvents;
        private System.Windows.Forms.TabPage tabEventDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataGridView dgvDisciplinedEvents;
        private System.Windows.Forms.TextBox txtBetween;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DataGridView dgvDatedEvents;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ContextMenuStrip contextMenuEvents;
        private System.Windows.Forms.ToolStripMenuItem mnuAllEvents;
        private System.Windows.Forms.ToolStripMenuItem mnuEventDates;
        private System.Windows.Forms.ToolStripMenuItem mnuEventDiscipline;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.TextBox txtDisciplineInfo;
    }
}