namespace olympics
{
    partial class Change_Records
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
            this.btnChange = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.dgvChange1 = new System.Windows.Forms.DataGridView();
            this.tabTeamEvent = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChangeTwo = new System.Windows.Forms.DataGridView();
            this.dgvChange2 = new System.Windows.Forms.DataGridView();
            this.tabIndividualEvent = new System.Windows.Forms.TabPage();
            this.dgvChange3 = new System.Windows.Forms.DataGridView();
            this.tabPlacing = new System.Windows.Forms.TabPage();
            this.dgvPlacing = new System.Windows.Forms.DataGridView();
            this.lblColumn6 = new System.Windows.Forms.Label();
            this.txtColumn1 = new System.Windows.Forms.TextBox();
            this.lblColumn5 = new System.Windows.Forms.Label();
            this.txtColumn2 = new System.Windows.Forms.TextBox();
            this.lblColumn4 = new System.Windows.Forms.Label();
            this.txtColumn3 = new System.Windows.Forms.TextBox();
            this.lblColumn3 = new System.Windows.Forms.Label();
            this.txtColumn4 = new System.Windows.Forms.TextBox();
            this.lblColumn2 = new System.Windows.Forms.Label();
            this.txtColumn5 = new System.Windows.Forms.TextBox();
            this.lblColumn1 = new System.Windows.Forms.Label();
            this.txtColumn6 = new System.Windows.Forms.TextBox();
            this.contextMenuManipulations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeamEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIndividualEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAesthetics = new System.Windows.Forms.MenuStrip();
            this.lblColumn7 = new System.Windows.Forms.Label();
            this.txtColumn7 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChange1)).BeginInit();
            this.tabTeamEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChange2)).BeginInit();
            this.tabIndividualEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChange3)).BeginInit();
            this.tabPlacing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacing)).BeginInit();
            this.contextMenuManipulations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.OrangeRed;
            this.btnChange.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(697, 309);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(59, 91);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change Record";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblInfo.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(294, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(172, 28);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "change data here...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Controls.Add(this.tabTeamEvent);
            this.tabControl1.Controls.Add(this.tabIndividualEvent);
            this.tabControl1.Controls.Add(this.tabPlacing);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 269);
            this.tabControl1.TabIndex = 15;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabInfo.Controls.Add(this.dgvChange1);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(736, 240);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "tabPage1";
            // 
            // dgvChange1
            // 
            this.dgvChange1.AllowUserToAddRows = false;
            this.dgvChange1.AllowUserToDeleteRows = false;
            this.dgvChange1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChange1.Location = new System.Drawing.Point(3, 6);
            this.dgvChange1.Name = "dgvChange1";
            this.dgvChange1.ReadOnly = true;
            this.dgvChange1.Size = new System.Drawing.Size(724, 224);
            this.dgvChange1.TabIndex = 27;
            this.dgvChange1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChange1_CellClick);
            // 
            // tabTeamEvent
            // 
            this.tabTeamEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabTeamEvent.Controls.Add(this.label2);
            this.tabTeamEvent.Controls.Add(this.label1);
            this.tabTeamEvent.Controls.Add(this.dgvChangeTwo);
            this.tabTeamEvent.Controls.Add(this.dgvChange2);
            this.tabTeamEvent.Location = new System.Drawing.Point(4, 25);
            this.tabTeamEvent.Name = "tabTeamEvent";
            this.tabTeamEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeamEvent.Size = new System.Drawing.Size(736, 240);
            this.tabTeamEvent.TabIndex = 1;
            this.tabTeamEvent.Text = "Team Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Team Participant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Team Event";
            // 
            // dgvChangeTwo
            // 
            this.dgvChangeTwo.AllowUserToAddRows = false;
            this.dgvChangeTwo.AllowUserToDeleteRows = false;
            this.dgvChangeTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangeTwo.Location = new System.Drawing.Point(7, 133);
            this.dgvChangeTwo.Name = "dgvChangeTwo";
            this.dgvChangeTwo.ReadOnly = true;
            this.dgvChangeTwo.Size = new System.Drawing.Size(723, 105);
            this.dgvChangeTwo.TabIndex = 1;
            this.dgvChangeTwo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChangeTwo_CellClick);
            // 
            // dgvChange2
            // 
            this.dgvChange2.AllowUserToAddRows = false;
            this.dgvChange2.AllowUserToDeleteRows = false;
            this.dgvChange2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChange2.Location = new System.Drawing.Point(7, 16);
            this.dgvChange2.Name = "dgvChange2";
            this.dgvChange2.ReadOnly = true;
            this.dgvChange2.Size = new System.Drawing.Size(723, 99);
            this.dgvChange2.TabIndex = 0;
            this.dgvChange2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChange2_CellClick);
            // 
            // tabIndividualEvent
            // 
            this.tabIndividualEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabIndividualEvent.Controls.Add(this.dgvChange3);
            this.tabIndividualEvent.Location = new System.Drawing.Point(4, 25);
            this.tabIndividualEvent.Name = "tabIndividualEvent";
            this.tabIndividualEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndividualEvent.Size = new System.Drawing.Size(736, 240);
            this.tabIndividualEvent.TabIndex = 2;
            this.tabIndividualEvent.Text = "Individual Event";
            // 
            // dgvChange3
            // 
            this.dgvChange3.AllowUserToAddRows = false;
            this.dgvChange3.AllowUserToDeleteRows = false;
            this.dgvChange3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChange3.Location = new System.Drawing.Point(3, 6);
            this.dgvChange3.Name = "dgvChange3";
            this.dgvChange3.ReadOnly = true;
            this.dgvChange3.Size = new System.Drawing.Size(727, 228);
            this.dgvChange3.TabIndex = 0;
            this.dgvChange3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChange3_CellClick);
            // 
            // tabPlacing
            // 
            this.tabPlacing.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPlacing.Controls.Add(this.dgvPlacing);
            this.tabPlacing.Location = new System.Drawing.Point(4, 25);
            this.tabPlacing.Name = "tabPlacing";
            this.tabPlacing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlacing.Size = new System.Drawing.Size(736, 240);
            this.tabPlacing.TabIndex = 3;
            this.tabPlacing.Text = "Placing";
            // 
            // dgvPlacing
            // 
            this.dgvPlacing.AllowUserToAddRows = false;
            this.dgvPlacing.AllowUserToDeleteRows = false;
            this.dgvPlacing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacing.Location = new System.Drawing.Point(6, 6);
            this.dgvPlacing.Name = "dgvPlacing";
            this.dgvPlacing.ReadOnly = true;
            this.dgvPlacing.Size = new System.Drawing.Size(724, 228);
            this.dgvPlacing.TabIndex = 0;
            this.dgvPlacing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlacing_CellClick);
            // 
            // lblColumn6
            // 
            this.lblColumn6.AutoSize = true;
            this.lblColumn6.Location = new System.Drawing.Point(171, 339);
            this.lblColumn6.Name = "lblColumn6";
            this.lblColumn6.Size = new System.Drawing.Size(52, 16);
            this.lblColumn6.TabIndex = 26;
            this.lblColumn6.Text = "Column6";
            // 
            // txtColumn1
            // 
            this.txtColumn1.Location = new System.Drawing.Point(12, 315);
            this.txtColumn1.Name = "txtColumn1";
            this.txtColumn1.Size = new System.Drawing.Size(72, 23);
            this.txtColumn1.TabIndex = 17;
            this.txtColumn1.Visible = false;
            // 
            // lblColumn5
            // 
            this.lblColumn5.AutoSize = true;
            this.lblColumn5.Location = new System.Drawing.Point(100, 339);
            this.lblColumn5.Name = "lblColumn5";
            this.lblColumn5.Size = new System.Drawing.Size(52, 16);
            this.lblColumn5.TabIndex = 25;
            this.lblColumn5.Text = "Column5";
            // 
            // txtColumn2
            // 
            this.txtColumn2.Location = new System.Drawing.Point(90, 315);
            this.txtColumn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColumn2.Name = "txtColumn2";
            this.txtColumn2.Size = new System.Drawing.Size(72, 23);
            this.txtColumn2.TabIndex = 15;
            this.txtColumn2.Visible = false;
            // 
            // lblColumn4
            // 
            this.lblColumn4.AutoSize = true;
            this.lblColumn4.Location = new System.Drawing.Point(15, 339);
            this.lblColumn4.Name = "lblColumn4";
            this.lblColumn4.Size = new System.Drawing.Size(52, 16);
            this.lblColumn4.TabIndex = 24;
            this.lblColumn4.Text = "Column4";
            // 
            // txtColumn3
            // 
            this.txtColumn3.Location = new System.Drawing.Point(168, 315);
            this.txtColumn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColumn3.Name = "txtColumn3";
            this.txtColumn3.Size = new System.Drawing.Size(72, 23);
            this.txtColumn3.TabIndex = 16;
            this.txtColumn3.Visible = false;
            // 
            // lblColumn3
            // 
            this.lblColumn3.AutoSize = true;
            this.lblColumn3.Location = new System.Drawing.Point(187, 302);
            this.lblColumn3.Name = "lblColumn3";
            this.lblColumn3.Size = new System.Drawing.Size(52, 16);
            this.lblColumn3.TabIndex = 23;
            this.lblColumn3.Text = "Column3";
            // 
            // txtColumn4
            // 
            this.txtColumn4.Location = new System.Drawing.Point(12, 354);
            this.txtColumn4.Name = "txtColumn4";
            this.txtColumn4.Size = new System.Drawing.Size(72, 23);
            this.txtColumn4.TabIndex = 18;
            this.txtColumn4.Visible = false;
            // 
            // lblColumn2
            // 
            this.lblColumn2.AutoSize = true;
            this.lblColumn2.Location = new System.Drawing.Point(100, 302);
            this.lblColumn2.Name = "lblColumn2";
            this.lblColumn2.Size = new System.Drawing.Size(52, 16);
            this.lblColumn2.TabIndex = 22;
            this.lblColumn2.Text = "Column2";
            // 
            // txtColumn5
            // 
            this.txtColumn5.Location = new System.Drawing.Point(90, 354);
            this.txtColumn5.Name = "txtColumn5";
            this.txtColumn5.Size = new System.Drawing.Size(72, 23);
            this.txtColumn5.TabIndex = 19;
            this.txtColumn5.Visible = false;
            // 
            // lblColumn1
            // 
            this.lblColumn1.AutoSize = true;
            this.lblColumn1.Location = new System.Drawing.Point(12, 302);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(52, 16);
            this.lblColumn1.TabIndex = 21;
            this.lblColumn1.Text = "Column1";
            // 
            // txtColumn6
            // 
            this.txtColumn6.Location = new System.Drawing.Point(168, 354);
            this.txtColumn6.Name = "txtColumn6";
            this.txtColumn6.Size = new System.Drawing.Size(72, 23);
            this.txtColumn6.TabIndex = 20;
            this.txtColumn6.Visible = false;
            // 
            // contextMenuManipulations
            // 
            this.contextMenuManipulations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEvent,
            this.mnuTeamEvent,
            this.mnuIndividualEvent,
            this.mnuRecord,
            this.mnuClose});
            this.contextMenuManipulations.Name = "contextMenuManipulations";
            this.contextMenuManipulations.Size = new System.Drawing.Size(159, 114);
            // 
            // mnuEvent
            // 
            this.mnuEvent.Name = "mnuEvent";
            this.mnuEvent.Size = new System.Drawing.Size(158, 22);
            this.mnuEvent.Text = "event";
            // 
            // mnuTeamEvent
            // 
            this.mnuTeamEvent.Name = "mnuTeamEvent";
            this.mnuTeamEvent.Size = new System.Drawing.Size(158, 22);
            this.mnuTeamEvent.Text = "team event";
            this.mnuTeamEvent.Click += new System.EventHandler(this.mnuTeamEvent_Click);
            // 
            // mnuIndividualEvent
            // 
            this.mnuIndividualEvent.Name = "mnuIndividualEvent";
            this.mnuIndividualEvent.Size = new System.Drawing.Size(158, 22);
            this.mnuIndividualEvent.Text = "individual event";
            this.mnuIndividualEvent.Click += new System.EventHandler(this.mnuIndividualEvent_Click);
            // 
            // mnuRecord
            // 
            this.mnuRecord.Name = "mnuRecord";
            this.mnuRecord.Size = new System.Drawing.Size(158, 22);
            this.mnuRecord.Text = "record";
            this.mnuRecord.Click += new System.EventHandler(this.mnuRecord_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(158, 22);
            this.mnuClose.Text = "close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // menuStripAesthetics
            // 
            this.menuStripAesthetics.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStripAesthetics.Location = new System.Drawing.Point(0, 0);
            this.menuStripAesthetics.Name = "menuStripAesthetics";
            this.menuStripAesthetics.Size = new System.Drawing.Size(768, 24);
            this.menuStripAesthetics.TabIndex = 27;
            this.menuStripAesthetics.Text = "menuStrip1";
            // 
            // lblColumn7
            // 
            this.lblColumn7.AutoSize = true;
            this.lblColumn7.Location = new System.Drawing.Point(247, 324);
            this.lblColumn7.Name = "lblColumn7";
            this.lblColumn7.Size = new System.Drawing.Size(52, 16);
            this.lblColumn7.TabIndex = 28;
            this.lblColumn7.Text = "Column7";
            // 
            // txtColumn7
            // 
            this.txtColumn7.Location = new System.Drawing.Point(246, 339);
            this.txtColumn7.Name = "txtColumn7";
            this.txtColumn7.Size = new System.Drawing.Size(102, 23);
            this.txtColumn7.TabIndex = 29;
            this.txtColumn7.Visible = false;
            // 
            // Change_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(768, 407);
            this.ContextMenuStrip = this.contextMenuManipulations;
            this.Controls.Add(this.txtColumn7);
            this.Controls.Add(this.lblColumn7);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.menuStripAesthetics);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblColumn6);
            this.Controls.Add(this.txtColumn1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblColumn5);
            this.Controls.Add(this.txtColumn2);
            this.Controls.Add(this.txtColumn6);
            this.Controls.Add(this.lblColumn4);
            this.Controls.Add(this.lblColumn1);
            this.Controls.Add(this.txtColumn3);
            this.Controls.Add(this.txtColumn5);
            this.Controls.Add(this.lblColumn3);
            this.Controls.Add(this.lblColumn2);
            this.Controls.Add(this.txtColumn4);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripAesthetics;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Change_Records";
            this.Text = "Change Records";
            this.Load += new System.EventHandler(this.Change_Data_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChange1)).EndInit();
            this.tabTeamEvent.ResumeLayout(false);
            this.tabTeamEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChange2)).EndInit();
            this.tabIndividualEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChange3)).EndInit();
            this.tabPlacing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacing)).EndInit();
            this.contextMenuManipulations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.DataGridView dgvChange1;
        private System.Windows.Forms.Label lblColumn6;
        private System.Windows.Forms.TextBox txtColumn1;
        private System.Windows.Forms.Label lblColumn5;
        private System.Windows.Forms.TextBox txtColumn2;
        private System.Windows.Forms.Label lblColumn4;
        private System.Windows.Forms.TextBox txtColumn3;
        private System.Windows.Forms.Label lblColumn3;
        private System.Windows.Forms.TextBox txtColumn4;
        private System.Windows.Forms.Label lblColumn2;
        private System.Windows.Forms.TextBox txtColumn5;
        private System.Windows.Forms.Label lblColumn1;
        private System.Windows.Forms.TextBox txtColumn6;
        private System.Windows.Forms.TabPage tabTeamEvent;
        private System.Windows.Forms.TabPage tabIndividualEvent;
        private System.Windows.Forms.DataGridView dgvChange2;
        private System.Windows.Forms.DataGridView dgvChange3;
        private System.Windows.Forms.TabPage tabPlacing;
        private System.Windows.Forms.DataGridView dgvPlacing;
        public System.Windows.Forms.ContextMenuStrip contextMenuManipulations;
        private System.Windows.Forms.ToolStripMenuItem mnuRecord;
        private System.Windows.Forms.ToolStripMenuItem mnuTeamEvent;
        private System.Windows.Forms.ToolStripMenuItem mnuIndividualEvent;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.MenuStrip menuStripAesthetics;
        private System.Windows.Forms.ToolStripMenuItem mnuEvent;
        private System.Windows.Forms.DataGridView dgvChangeTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColumn7;
        private System.Windows.Forms.TextBox txtColumn7;
    }
}