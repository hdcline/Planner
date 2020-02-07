namespace PlannerAppOfficial
{
    partial class frmCalenderView
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
            this.mcCalenderView = new System.Windows.Forms.MonthCalendar();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mcCalenderView
            // 
            this.mcCalenderView.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.mcCalenderView.BackColor = System.Drawing.Color.Gray;
            this.mcCalenderView.ForeColor = System.Drawing.Color.Transparent;
            this.mcCalenderView.Location = new System.Drawing.Point(34, 40);
            this.mcCalenderView.Name = "mcCalenderView";
            this.mcCalenderView.TabIndex = 0;
            this.mcCalenderView.TitleForeColor = System.Drawing.Color.Red;
            this.mcCalenderView.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McCalenderView_DateSelected);
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.ForeColor = System.Drawing.Color.White;
            this.lblSelectDate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSelectDate.Location = new System.Drawing.Point(68, 14);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(190, 17);
            this.lblSelectDate.TabIndex = 1;
            this.lblSelectDate.Text = "Select date to view daily plan";
            this.lblSelectDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCalenderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(351, 277);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.mcCalenderView);
            this.Name = "frmCalenderView";
            this.Text = "Date Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectDate;
        public System.Windows.Forms.MonthCalendar mcCalenderView;
    }
}