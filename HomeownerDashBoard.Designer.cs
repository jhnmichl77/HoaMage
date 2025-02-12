namespace HoaMage
{
    partial class HomeownerDashBoard
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
            label1 = new Label();
            btnProfile = new Button();
            btnPayment = new Button();
            btnReport = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(172, 47);
            label1.TabIndex = 0;
            label1.Text = "HoaMage";
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(31, 99);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(75, 23);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "My Profile";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(31, 128);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(75, 23);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Payments";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(31, 157);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(75, 23);
            btnReport.TabIndex = 3;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(112, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 358);
            panel1.TabIndex = 4;
            // 
            // HomeownerDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnReport);
            Controls.Add(btnPayment);
            Controls.Add(btnProfile);
            Controls.Add(label1);
            Name = "HomeownerDashBoard";
            Text = "Dashboard";
            Load += HomeownerDashBoard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProfile;
        private Button btnPayment;
        private Button btnReport;
        private Panel panel1;
    }
}