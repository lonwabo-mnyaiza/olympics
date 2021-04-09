namespace olympics
{
    partial class Day_by_Day_Events
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
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.mncEvents = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(2, 171);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.Size = new System.Drawing.Size(657, 150);
            this.dgvEvents.TabIndex = 0;
            // 
            // mncEvents
            // 
            this.mncEvents.Location = new System.Drawing.Point(183, 6);
            this.mncEvents.Name = "mncEvents";
            this.mncEvents.TabIndex = 1;
            this.mncEvents.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mncEvents_DateChanged);
            // 
            // Day_by_Day_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(671, 333);
            this.Controls.Add(this.mncEvents);
            this.Controls.Add(this.dgvEvents);
            this.Name = "Day_by_Day_Events";
            this.Text = "Day_by_Day_Events";
            this.Load += new System.EventHandler(this.Day_by_Day_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.MonthCalendar mncEvents;
    }
}