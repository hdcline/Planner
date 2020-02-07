namespace PlannerAppOfficial
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miCalenderView = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAddedToday = new System.Windows.Forms.Label();
            this.tbAdded = new System.Windows.Forms.TextBox();
            this.lblDueToday = new System.Windows.Forms.Label();
            this.tbDue = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRefresh,
            this.miAdd,
            this.miCalenderView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miRefresh
            // 
            this.miRefresh.BackColor = System.Drawing.Color.Aquamarine;
            this.miRefresh.ForeColor = System.Drawing.Color.Black;
            this.miRefresh.Name = "miRefresh";
            this.miRefresh.Size = new System.Drawing.Size(72, 24);
            this.miRefresh.Text = "Refresh";
            this.miRefresh.Click += new System.EventHandler(this.MiRefresh_Click);
            // 
            // miAdd
            // 
            this.miAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.miAdd.Name = "miAdd";
            this.miAdd.Size = new System.Drawing.Size(51, 24);
            this.miAdd.Text = "Add";
            this.miAdd.Click += new System.EventHandler(this.MiAdd_Click);
            // 
            // miCalenderView
            // 
            this.miCalenderView.BackColor = System.Drawing.Color.MediumOrchid;
            this.miCalenderView.Name = "miCalenderView";
            this.miCalenderView.Size = new System.Drawing.Size(118, 24);
            this.miCalenderView.Text = "Calender View";
            this.miCalenderView.Click += new System.EventHandler(this.MiCalenderView_Click);
            // 
            // lblAddedToday
            // 
            this.lblAddedToday.AutoSize = true;
            this.lblAddedToday.BackColor = System.Drawing.Color.Transparent;
            this.lblAddedToday.ForeColor = System.Drawing.Color.White;
            this.lblAddedToday.Location = new System.Drawing.Point(13, 32);
            this.lblAddedToday.Name = "lblAddedToday";
            this.lblAddedToday.Size = new System.Drawing.Size(98, 17);
            this.lblAddedToday.TabIndex = 1;
            this.lblAddedToday.Text = "Added Today-";
            // 
            // tbAdded
            // 
            this.tbAdded.BackColor = System.Drawing.Color.Gray;
            this.tbAdded.ForeColor = System.Drawing.Color.Black;
            this.tbAdded.Location = new System.Drawing.Point(16, 53);
            this.tbAdded.Multiline = true;
            this.tbAdded.Name = "tbAdded";
            this.tbAdded.ReadOnly = true;
            this.tbAdded.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAdded.Size = new System.Drawing.Size(393, 196);
            this.tbAdded.TabIndex = 2;
            this.tbAdded.TabStop = false;
            // 
            // lblDueToday
            // 
            this.lblDueToday.AutoSize = true;
            this.lblDueToday.ForeColor = System.Drawing.Color.White;
            this.lblDueToday.Location = new System.Drawing.Point(16, 257);
            this.lblDueToday.Name = "lblDueToday";
            this.lblDueToday.Size = new System.Drawing.Size(83, 17);
            this.lblDueToday.TabIndex = 3;
            this.lblDueToday.Text = "Due Today-";
            // 
            // tbDue
            // 
            this.tbDue.BackColor = System.Drawing.Color.Gray;
            this.tbDue.Location = new System.Drawing.Point(16, 277);
            this.tbDue.Multiline = true;
            this.tbDue.Name = "tbDue";
            this.tbDue.ReadOnly = true;
            this.tbDue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDue.Size = new System.Drawing.Size(393, 218);
            this.tbDue.TabIndex = 4;
            this.tbDue.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(421, 507);
            this.Controls.Add(this.tbDue);
            this.Controls.Add(this.lblDueToday);
            this.Controls.Add(this.tbAdded);
            this.Controls.Add(this.lblAddedToday);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miCalenderView;
        private System.Windows.Forms.Label lblAddedToday;
        private System.Windows.Forms.TextBox tbAdded;
        private System.Windows.Forms.Label lblDueToday;
        private System.Windows.Forms.TextBox tbDue;
        private System.Windows.Forms.ToolStripMenuItem miRefresh;
    }
}

