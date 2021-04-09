namespace olympics
{
    partial class OlympicsGamesAdmin
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
            this.cmbAdd = new System.Windows.Forms.ComboBox();
            this.cmbChange = new System.Windows.Forms.ComboBox();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.mnuMod = new System.Windows.Forms.MenuStrip();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainAdmin = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDisplay.SuspendLayout();
            this.mnuMod.SuspendLayout();
            this.menuStripMainAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAdd
            // 
            this.cmbAdd.FormattingEnabled = true;
            this.cmbAdd.Location = new System.Drawing.Point(7, 63);
            this.cmbAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAdd.Name = "cmbAdd";
            this.cmbAdd.Size = new System.Drawing.Size(107, 24);
            this.cmbAdd.TabIndex = 2;
            this.cmbAdd.SelectedIndexChanged += new System.EventHandler(this.cmbAdd_SelectedIndexChanged);
            // 
            // cmbChange
            // 
            this.cmbChange.FormattingEnabled = true;
            this.cmbChange.Location = new System.Drawing.Point(6, 63);
            this.cmbChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbChange.Name = "cmbChange";
            this.cmbChange.Size = new System.Drawing.Size(107, 24);
            this.cmbChange.TabIndex = 1;
            this.cmbChange.SelectedIndexChanged += new System.EventHandler(this.cmbChange_SelectedIndexChanged);
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(7, 63);
            this.cmbDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(107, 24);
            this.cmbDelete.TabIndex = 0;
            this.cmbDelete.SelectedIndexChanged += new System.EventHandler(this.cmbDelete_SelectedIndexChanged);
            // 
            // grpDisplay
            // 
            this.grpDisplay.Controls.Add(this.cmbAdd);
            this.grpDisplay.Controls.Add(this.cmbChange);
            this.grpDisplay.Controls.Add(this.cmbDelete);
            this.grpDisplay.Location = new System.Drawing.Point(71, 31);
            this.grpDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDisplay.Size = new System.Drawing.Size(125, 99);
            this.grpDisplay.TabIndex = 3;
            this.grpDisplay.TabStop = false;
            // 
            // mnuMod
            // 
            this.mnuMod.BackColor = System.Drawing.Color.RoyalBlue;
            this.mnuMod.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuMod.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuChange,
            this.mnuDelete});
            this.mnuMod.Location = new System.Drawing.Point(0, 27);
            this.mnuMod.Name = "mnuMod";
            this.mnuMod.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuMod.Size = new System.Drawing.Size(68, 109);
            this.mnuMod.TabIndex = 4;
            this.mnuMod.Text = "menuStrip1";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(53, 21);
            this.mnuAdd.Text = "Add";
            this.mnuAdd.MouseHover += new System.EventHandler(this.mnuAdd_MouseHover);
            // 
            // mnuChange
            // 
            this.mnuChange.Name = "mnuChange";
            this.mnuChange.Size = new System.Drawing.Size(53, 21);
            this.mnuChange.Text = "Change";
            this.mnuChange.MouseHover += new System.EventHandler(this.mnuChange_MouseHover);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(53, 21);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.MouseHover += new System.EventHandler(this.mnuDelete_MouseHover);
            // 
            // menuStripMainAdmin
            // 
            this.menuStripMainAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStripMainAdmin.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMainAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.gamesToolStripMenuItem});
            this.menuStripMainAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainAdmin.Name = "menuStripMainAdmin";
            this.menuStripMainAdmin.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStripMainAdmin.Size = new System.Drawing.Size(205, 27);
            this.menuStripMainAdmin.TabIndex = 5;
            this.menuStripMainAdmin.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.MouseHover += new System.EventHandler(this.newToolStripMenuItem_MouseHover);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.gamesToolStripMenuItem.Text = "Games";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.gamesToolStripMenuItem_Click);
            // 
            // OlympicsGamesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(205, 136);
            this.Controls.Add(this.mnuMod);
            this.Controls.Add(this.menuStripMainAdmin);
            this.Controls.Add(this.grpDisplay);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMainAdmin;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OlympicsGamesAdmin";
            this.Text = "Olympics Games";
            this.Load += new System.EventHandler(this.OlympicsGamesAdmin_Load);
            this.grpDisplay.ResumeLayout(false);
            this.mnuMod.ResumeLayout(false);
            this.mnuMod.PerformLayout();
            this.menuStripMainAdmin.ResumeLayout(false);
            this.menuStripMainAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAdd;
        private System.Windows.Forms.ComboBox cmbChange;
        private System.Windows.Forms.ComboBox cmbDelete;
        private System.Windows.Forms.GroupBox grpDisplay;
        private System.Windows.Forms.MenuStrip mnuMod;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuChange;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.MenuStrip menuStripMainAdmin;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
    }
}