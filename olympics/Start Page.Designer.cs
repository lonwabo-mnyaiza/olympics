namespace olympics
{
    partial class Start_Page
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
            this.contextMenuStripDisclaimer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.disclaimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new System.Windows.Forms.Button();
            this.prbLoad = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.lblInit = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxOlympic = new System.Windows.Forms.PictureBox();
            this.contextMenuStripDisclaimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOlympic)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripDisclaimer
            // 
            this.contextMenuStripDisclaimer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disclaimerToolStripMenuItem});
            this.contextMenuStripDisclaimer.Name = "contextMenuStripDisclaimer";
            this.contextMenuStripDisclaimer.Size = new System.Drawing.Size(130, 26);
            // 
            // disclaimerToolStripMenuItem
            // 
            this.disclaimerToolStripMenuItem.Name = "disclaimerToolStripMenuItem";
            this.disclaimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.disclaimerToolStripMenuItem.Text = "Disclaimer";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNext.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(21, 152);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 28);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // prbLoad
            // 
            this.prbLoad.Location = new System.Drawing.Point(12, 196);
            this.prbLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prbLoad.Name = "prbLoad";
            this.prbLoad.Size = new System.Drawing.Size(215, 28);
            this.prbLoad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to the Olympics ";
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(12, 126);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(96, 24);
            this.cmbUsers.TabIndex = 5;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // txtAdminName
            // 
            this.txtAdminName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminName.ForeColor = System.Drawing.Color.Silver;
            this.txtAdminName.Location = new System.Drawing.Point(115, 127);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(116, 23);
            this.txtAdminName.TabIndex = 6;
            this.txtAdminName.Text = "Lonwabo";
            this.txtAdminName.Click += new System.EventHandler(this.txtAdminName_Click_1);
            this.txtAdminName.Enter += new System.EventHandler(this.txtAdminName_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(115, 152);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(97, 23);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "211164682";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Enabled = true;
            this.timerProgressBar.Interval = 1000;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Location = new System.Drawing.Point(7, 178);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(0, 16);
            this.lblInit.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Silver;
            this.txtUserName.Location = new System.Drawing.Point(115, 128);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(113, 23);
            this.txtUserName.TabIndex = 10;
            this.txtUserName.Text = "First Name";
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 42);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pbxOlympic
            // 
            this.pbxOlympic.Location = new System.Drawing.Point(12, 30);
            this.pbxOlympic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxOlympic.Name = "pbxOlympic";
            this.pbxOlympic.Size = new System.Drawing.Size(215, 89);
            this.pbxOlympic.TabIndex = 4;
            this.pbxOlympic.TabStop = false;
            // 
            // Start_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(236, 226);
            this.Controls.Add(this.prbLoad);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxOlympic);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPassword);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Start_Page";
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.Start_Page_Load);
            this.contextMenuStripDisclaimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOlympic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripDisclaimer;
        private System.Windows.Forms.ToolStripMenuItem disclaimerToolStripMenuItem;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ProgressBar prbLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxOlympic;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Timer timerProgressBar;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserName;
    }
}