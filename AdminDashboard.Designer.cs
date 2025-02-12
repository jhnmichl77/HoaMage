namespace HoaMage
{
    partial class AdminDashboard
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
            btnUnits = new Button();
            btnResidents = new Button();
            btnPayment = new Button();
            btnRequest = new Button();
            btnMail = new Button();
            btnReport = new Button();
            Panel = new Panel();
            btnAnnounce = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 65);
            label1.TabIndex = 0;
            label1.Text = "HoaMage";
            // 
            // btnUnits
            // 
            btnUnits.Location = new Point(46, 97);
            btnUnits.Name = "btnUnits";
            btnUnits.Size = new Size(75, 23);
            btnUnits.TabIndex = 1;
            btnUnits.Text = "Units";
            btnUnits.UseVisualStyleBackColor = true;
            // 
            // btnResidents
            // 
            btnResidents.Location = new Point(46, 126);
            btnResidents.Name = "btnResidents";
            btnResidents.Size = new Size(75, 23);
            btnResidents.TabIndex = 2;
            btnResidents.Text = "Residents";
            btnResidents.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(46, 155);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(75, 23);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "Payments";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(46, 208);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(75, 23);
            btnRequest.TabIndex = 4;
            btnRequest.Text = "Requests";
            btnRequest.UseVisualStyleBackColor = true;
            // 
            // btnMail
            // 
            btnMail.Location = new Point(46, 237);
            btnMail.Name = "btnMail";
            btnMail.Size = new Size(75, 23);
            btnMail.TabIndex = 5;
            btnMail.Text = "Mail";
            btnMail.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(46, 266);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(75, 23);
            btnReport.TabIndex = 6;
            btnReport.Text = "Reports";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            Panel.Location = new Point(127, 77);
            Panel.Name = "Panel";
            Panel.Size = new Size(620, 361);
            Panel.TabIndex = 7;
            // 
            // btnAnnounce
            // 
            btnAnnounce.Location = new Point(46, 295);
            btnAnnounce.Name = "btnAnnounce";
            btnAnnounce.Size = new Size(75, 23);
            btnAnnounce.TabIndex = 8;
            btnAnnounce.Text = "Announce";
            btnAnnounce.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 450);
            Controls.Add(btnAnnounce);
            Controls.Add(Panel);
            Controls.Add(btnReport);
            Controls.Add(btnMail);
            Controls.Add(btnRequest);
            Controls.Add(btnPayment);
            Controls.Add(btnResidents);
            Controls.Add(btnUnits);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUnits;
        private Button btnResidents;
        private Button btnPayment;
        private Button btnRequest;
        private Button btnMail;
        private Button btnReport;
        private Panel Panel;
        private Button btnAnnounce;
    }
}