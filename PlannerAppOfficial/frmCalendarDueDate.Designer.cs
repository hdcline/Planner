namespace PlannerAppOfficial
{
    partial class frmCalendarDueDate
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
            this.lblDue = new System.Windows.Forms.Label();
            this.tbDue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.ForeColor = System.Drawing.Color.White;
            this.lblDue.Location = new System.Drawing.Point(12, 18);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(82, 17);
            this.lblDue.TabIndex = 0;
            this.lblDue.Text = "Due today- ";
            // 
            // tbDue
            // 
            this.tbDue.BackColor = System.Drawing.Color.Gray;
            this.tbDue.Location = new System.Drawing.Point(15, 38);
            this.tbDue.Multiline = true;
            this.tbDue.Name = "tbDue";
            this.tbDue.Size = new System.Drawing.Size(324, 363);
            this.tbDue.TabIndex = 1;
            this.tbDue.TabStop = false;
            // 
            // frmCalendarDueDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.tbDue);
            this.Controls.Add(this.lblDue);
            this.Name = "frmCalendarDueDate";
            this.Text = "frmCalendarDueDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.TextBox tbDue;
    }
}