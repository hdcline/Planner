namespace PlannerAppOfficial
{
    partial class frmAddPage
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
            this.lblAddItems = new System.Windows.Forms.Label();
            this.tbAddItems = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdatePlanner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddItems
            // 
            this.lblAddItems.AutoSize = true;
            this.lblAddItems.ForeColor = System.Drawing.Color.White;
            this.lblAddItems.Location = new System.Drawing.Point(13, 13);
            this.lblAddItems.Name = "lblAddItems";
            this.lblAddItems.Size = new System.Drawing.Size(68, 17);
            this.lblAddItems.TabIndex = 0;
            this.lblAddItems.Text = "Add Item-";
            // 
            // tbAddItems
            // 
            this.tbAddItems.AcceptsReturn = true;
            this.tbAddItems.BackColor = System.Drawing.Color.Gray;
            this.tbAddItems.ForeColor = System.Drawing.Color.Black;
            this.tbAddItems.Location = new System.Drawing.Point(16, 34);
            this.tbAddItems.Multiline = true;
            this.tbAddItems.Name = "tbAddItems";
            this.tbAddItems.Size = new System.Drawing.Size(352, 248);
            this.tbAddItems.TabIndex = 1;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.ForeColor = System.Drawing.Color.White;
            this.lblDueDate.Location = new System.Drawing.Point(16, 285);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(73, 17);
            this.lblDueDate.TabIndex = 2;
            this.lblDueDate.Text = "Due Date-";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.dtpDueDate.Location = new System.Drawing.Point(19, 306);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDueDate.TabIndex = 3;
            this.dtpDueDate.TabStop = false;
            // 
            // btnUpdatePlanner
            // 
            this.btnUpdatePlanner.BackColor = System.Drawing.Color.Aquamarine;
            this.btnUpdatePlanner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdatePlanner.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUpdatePlanner.Location = new System.Drawing.Point(0, 415);
            this.btnUpdatePlanner.Name = "btnUpdatePlanner";
            this.btnUpdatePlanner.Size = new System.Drawing.Size(380, 35);
            this.btnUpdatePlanner.TabIndex = 4;
            this.btnUpdatePlanner.Text = "Update Planner";
            this.btnUpdatePlanner.UseVisualStyleBackColor = false;
            this.btnUpdatePlanner.Click += new System.EventHandler(this.BtnUpdatePlanner_Click);
            // 
            // frmAddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.btnUpdatePlanner);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.tbAddItems);
            this.Controls.Add(this.lblAddItems);
            this.Name = "frmAddPage";
            this.Text = "AddPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddItems;
        private System.Windows.Forms.TextBox tbAddItems;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnUpdatePlanner;
    }
}