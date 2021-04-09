namespace olympics
{
    partial class Remove_Records
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.dgvDelete1 = new System.Windows.Forms.DataGridView();
            this.txtColumn1 = new System.Windows.Forms.TextBox();
            this.lblColumn6 = new System.Windows.Forms.Label();
            this.txtColumn2 = new System.Windows.Forms.TextBox();
            this.lblColumn5 = new System.Windows.Forms.Label();
            this.txtColumn3 = new System.Windows.Forms.TextBox();
            this.lblColumn4 = new System.Windows.Forms.Label();
            this.txtColumn4 = new System.Windows.Forms.TextBox();
            this.lblColumn3 = new System.Windows.Forms.Label();
            this.txtColumn5 = new System.Windows.Forms.TextBox();
            this.lblColumn2 = new System.Windows.Forms.Label();
            this.txtColumn6 = new System.Windows.Forms.TextBox();
            this.lblColumn1 = new System.Windows.Forms.Label();
            this.tabTeamEvent = new System.Windows.Forms.TabPage();
            this.dgvDelete2 = new System.Windows.Forms.DataGridView();
            this.tabIndividualEvent = new System.Windows.Forms.TabPage();
            this.dgvDelete3 = new System.Windows.Forms.DataGridView();
            this.tabPlacing = new System.Windows.Forms.TabPage();
            this.menuStripView = new System.Windows.Forms.MenuStrip();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuText = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuManipulations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeamEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIndividualEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRemovePlacing = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete1)).BeginInit();
            this.tabTeamEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete2)).BeginInit();
            this.tabIndividualEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete3)).BeginInit();
            this.tabPlacing.SuspendLayout();
            this.menuStripView.SuspendLayout();
            this.contextMenuManipulations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemovePlacing)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemove.Location = new System.Drawing.Point(610, 229);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(62, 82);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Record";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblInfo.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(294, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(176, 28);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "remove data here...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Controls.Add(this.tabTeamEvent);
            this.tabControl1.Controls.Add(this.tabIndividualEvent);
            this.tabControl1.Controls.Add(this.tabPlacing);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 195);
            this.tabControl1.TabIndex = 14;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabInfo.Controls.Add(this.dgvDelete1);
            this.tabInfo.Controls.Add(this.txtColumn1);
            this.tabInfo.Controls.Add(this.lblColumn6);
            this.tabInfo.Controls.Add(this.txtColumn2);
            this.tabInfo.Controls.Add(this.lblColumn5);
            this.tabInfo.Controls.Add(this.txtColumn3);
            this.tabInfo.Controls.Add(this.lblColumn4);
            this.tabInfo.Controls.Add(this.txtColumn4);
            this.tabInfo.Controls.Add(this.lblColumn3);
            this.tabInfo.Controls.Add(this.txtColumn5);
            this.tabInfo.Controls.Add(this.lblColumn2);
            this.tabInfo.Controls.Add(this.txtColumn6);
            this.tabInfo.Controls.Add(this.lblColumn1);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(652, 166);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "tabPage1";
            // 
            // dgvDelete1
            // 
            this.dgvDelete1.AllowUserToAddRows = false;
            this.dgvDelete1.AllowUserToDeleteRows = false;
            this.dgvDelete1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete1.Location = new System.Drawing.Point(6, 6);
            this.dgvDelete1.Name = "dgvDelete1";
            this.dgvDelete1.ReadOnly = true;
            this.dgvDelete1.Size = new System.Drawing.Size(640, 150);
            this.dgvDelete1.TabIndex = 26;
            // 
            // txtColumn1
            // 
            this.txtColumn1.Location = new System.Drawing.Point(11, 20);
            this.txtColumn1.Name = "txtColumn1";
            this.txtColumn1.Size = new System.Drawing.Size(72, 23);
            this.txtColumn1.TabIndex = 16;
            this.txtColumn1.Visible = false;
            // 
            // lblColumn6
            // 
            this.lblColumn6.AutoSize = true;
            this.lblColumn6.Location = new System.Drawing.Point(170, 38);
            this.lblColumn6.Name = "lblColumn6";
            this.lblColumn6.Size = new System.Drawing.Size(0, 16);
            this.lblColumn6.TabIndex = 25;
            // 
            // txtColumn2
            // 
            this.txtColumn2.Location = new System.Drawing.Point(89, 20);
            this.txtColumn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColumn2.Name = "txtColumn2";
            this.txtColumn2.Size = new System.Drawing.Size(72, 23);
            this.txtColumn2.TabIndex = 14;
            this.txtColumn2.Visible = false;
            // 
            // lblColumn5
            // 
            this.lblColumn5.AutoSize = true;
            this.lblColumn5.Location = new System.Drawing.Point(93, 39);
            this.lblColumn5.Name = "lblColumn5";
            this.lblColumn5.Size = new System.Drawing.Size(0, 16);
            this.lblColumn5.TabIndex = 24;
            // 
            // txtColumn3
            // 
            this.txtColumn3.Location = new System.Drawing.Point(167, 20);
            this.txtColumn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColumn3.Name = "txtColumn3";
            this.txtColumn3.Size = new System.Drawing.Size(72, 23);
            this.txtColumn3.TabIndex = 15;
            this.txtColumn3.Visible = false;
            // 
            // lblColumn4
            // 
            this.lblColumn4.AutoSize = true;
            this.lblColumn4.Location = new System.Drawing.Point(14, 38);
            this.lblColumn4.Name = "lblColumn4";
            this.lblColumn4.Size = new System.Drawing.Size(0, 16);
            this.lblColumn4.TabIndex = 23;
            // 
            // txtColumn4
            // 
            this.txtColumn4.Location = new System.Drawing.Point(11, 49);
            this.txtColumn4.Name = "txtColumn4";
            this.txtColumn4.Size = new System.Drawing.Size(72, 23);
            this.txtColumn4.TabIndex = 17;
            this.txtColumn4.Visible = false;
            // 
            // lblColumn3
            // 
            this.lblColumn3.AutoSize = true;
            this.lblColumn3.Location = new System.Drawing.Point(169, 6);
            this.lblColumn3.Name = "lblColumn3";
            this.lblColumn3.Size = new System.Drawing.Size(0, 16);
            this.lblColumn3.TabIndex = 22;
            // 
            // txtColumn5
            // 
            this.txtColumn5.Location = new System.Drawing.Point(89, 50);
            this.txtColumn5.Name = "txtColumn5";
            this.txtColumn5.Size = new System.Drawing.Size(72, 23);
            this.txtColumn5.TabIndex = 18;
            this.txtColumn5.Visible = false;
            // 
            // lblColumn2
            // 
            this.lblColumn2.AutoSize = true;
            this.lblColumn2.Location = new System.Drawing.Point(92, 7);
            this.lblColumn2.Name = "lblColumn2";
            this.lblColumn2.Size = new System.Drawing.Size(0, 16);
            this.lblColumn2.TabIndex = 21;
            // 
            // txtColumn6
            // 
            this.txtColumn6.Location = new System.Drawing.Point(167, 49);
            this.txtColumn6.Name = "txtColumn6";
            this.txtColumn6.Size = new System.Drawing.Size(72, 23);
            this.txtColumn6.TabIndex = 19;
            this.txtColumn6.Visible = false;
            // 
            // lblColumn1
            // 
            this.lblColumn1.AutoSize = true;
            this.lblColumn1.Location = new System.Drawing.Point(11, 8);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(0, 16);
            this.lblColumn1.TabIndex = 20;
            // 
            // tabTeamEvent
            // 
            this.tabTeamEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabTeamEvent.Controls.Add(this.dgvDelete2);
            this.tabTeamEvent.Location = new System.Drawing.Point(4, 25);
            this.tabTeamEvent.Name = "tabTeamEvent";
            this.tabTeamEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeamEvent.Size = new System.Drawing.Size(652, 166);
            this.tabTeamEvent.TabIndex = 1;
            this.tabTeamEvent.Text = "Team Event";
            // 
            // dgvDelete2
            // 
            this.dgvDelete2.AllowUserToAddRows = false;
            this.dgvDelete2.AllowUserToDeleteRows = false;
            this.dgvDelete2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete2.Location = new System.Drawing.Point(6, 6);
            this.dgvDelete2.Name = "dgvDelete2";
            this.dgvDelete2.ReadOnly = true;
            this.dgvDelete2.Size = new System.Drawing.Size(640, 153);
            this.dgvDelete2.TabIndex = 0;
            // 
            // tabIndividualEvent
            // 
            this.tabIndividualEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabIndividualEvent.Controls.Add(this.dgvDelete3);
            this.tabIndividualEvent.Location = new System.Drawing.Point(4, 25);
            this.tabIndividualEvent.Name = "tabIndividualEvent";
            this.tabIndividualEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndividualEvent.Size = new System.Drawing.Size(652, 166);
            this.tabIndividualEvent.TabIndex = 2;
            this.tabIndividualEvent.Text = "Individual Event";
            // 
            // dgvDelete3
            // 
            this.dgvDelete3.AllowUserToAddRows = false;
            this.dgvDelete3.AllowUserToDeleteRows = false;
            this.dgvDelete3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete3.Location = new System.Drawing.Point(6, 9);
            this.dgvDelete3.Name = "dgvDelete3";
            this.dgvDelete3.ReadOnly = true;
            this.dgvDelete3.Size = new System.Drawing.Size(640, 150);
            this.dgvDelete3.TabIndex = 0;
            // 
            // tabPlacing
            // 
            this.tabPlacing.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPlacing.Controls.Add(this.dgvRemovePlacing);
            this.tabPlacing.Location = new System.Drawing.Point(4, 25);
            this.tabPlacing.Name = "tabPlacing";
            this.tabPlacing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlacing.Size = new System.Drawing.Size(652, 166);
            this.tabPlacing.TabIndex = 3;
            this.tabPlacing.Text = "Placing";
            // 
            // menuStripView
            // 
            this.menuStripView.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStripView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuView});
            this.menuStripView.Location = new System.Drawing.Point(0, 0);
            this.menuStripView.Name = "menuStripView";
            this.menuStripView.Size = new System.Drawing.Size(684, 25);
            this.menuStripView.TabIndex = 15;
            this.menuStripView.Text = "menuStrip1";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuData,
            this.mnuText});
            this.mnuView.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(55, 21);
            this.mnuView.Text = "View";
            // 
            // mnuData
            // 
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(169, 22);
            this.mnuData.Text = "DataGridView";
            // 
            // mnuText
            // 
            this.mnuText.Name = "mnuText";
            this.mnuText.Size = new System.Drawing.Size(169, 22);
            this.mnuText.Text = "TextBox View";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 23);
            this.textBox1.TabIndex = 28;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 232);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 23);
            this.textBox2.TabIndex = 26;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 36;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(168, 232);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 23);
            this.textBox3.TabIndex = 27;
            this.textBox3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 261);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(72, 23);
            this.textBox4.TabIndex = 29;
            this.textBox4.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 34;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(90, 262);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(72, 23);
            this.textBox5.TabIndex = 30;
            this.textBox5.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 33;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(168, 261);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(72, 23);
            this.textBox6.TabIndex = 31;
            this.textBox6.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 32;
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
            // dgvRemovePlacing
            // 
            this.dgvRemovePlacing.AllowUserToAddRows = false;
            this.dgvRemovePlacing.AllowUserToDeleteRows = false;
            this.dgvRemovePlacing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemovePlacing.Location = new System.Drawing.Point(7, 7);
            this.dgvRemovePlacing.Name = "dgvRemovePlacing";
            this.dgvRemovePlacing.ReadOnly = true;
            this.dgvRemovePlacing.Size = new System.Drawing.Size(639, 150);
            this.dgvRemovePlacing.TabIndex = 0;
            // 
            // Remove_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(684, 317);
            this.ContextMenuStrip = this.contextMenuManipulations;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.menuStripView);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripView;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Remove_Records";
            this.Text = "Remove Records";
            this.Load += new System.EventHandler(this.Remove_Records_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete1)).EndInit();
            this.tabTeamEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete2)).EndInit();
            this.tabIndividualEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete3)).EndInit();
            this.tabPlacing.ResumeLayout(false);
            this.menuStripView.ResumeLayout(false);
            this.menuStripView.PerformLayout();
            this.contextMenuManipulations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemovePlacing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabTeamEvent;
        private System.Windows.Forms.TabPage tabIndividualEvent;
        private System.Windows.Forms.TextBox txtColumn1;
        private System.Windows.Forms.Label lblColumn6;
        private System.Windows.Forms.TextBox txtColumn2;
        private System.Windows.Forms.Label lblColumn5;
        private System.Windows.Forms.TextBox txtColumn3;
        private System.Windows.Forms.Label lblColumn4;
        private System.Windows.Forms.TextBox txtColumn4;
        private System.Windows.Forms.Label lblColumn3;
        private System.Windows.Forms.TextBox txtColumn5;
        private System.Windows.Forms.Label lblColumn2;
        private System.Windows.Forms.TextBox txtColumn6;
        private System.Windows.Forms.Label lblColumn1;
        private System.Windows.Forms.MenuStrip menuStripView;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuText;
        private System.Windows.Forms.DataGridView dgvDelete1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDelete2;
        private System.Windows.Forms.DataGridView dgvDelete3;
        private System.Windows.Forms.TabPage tabPlacing;
        private System.Windows.Forms.ToolStripMenuItem mnuRecord;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuTeamEvent;
        private System.Windows.Forms.ToolStripMenuItem mnuIndividualEvent;
        public System.Windows.Forms.ContextMenuStrip contextMenuManipulations;
        private System.Windows.Forms.ToolStripMenuItem mnuEvent;
        private System.Windows.Forms.DataGridView dgvRemovePlacing;
    }
}