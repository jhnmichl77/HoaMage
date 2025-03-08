namespace HoaMage
{
    partial class Registration
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            cbxVehicleInformation = new CheckBox();
            cbxPropertyInformation = new CheckBox();
            cbxMemberInformation = new CheckBox();
            cbxAccountAccess = new CheckBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 26);
            label1.Name = "label1";
            label1.Size = new Size(197, 38);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.ErrorImage = Properties.Resources.fillup;
            pictureBox1.Image = Properties.Resources.fillup;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 202, 228);
            panel1.Controls.Add(cbxVehicleInformation);
            panel1.Controls.Add(cbxPropertyInformation);
            panel1.Controls.Add(cbxMemberInformation);
            panel1.Controls.Add(cbxAccountAccess);
            panel1.Location = new Point(0, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 2;
            // 
            // cbxVehicleInformation
            // 
            cbxVehicleInformation.AutoCheck = false;
            cbxVehicleInformation.AutoSize = true;
            cbxVehicleInformation.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxVehicleInformation.Location = new Point(587, 9);
            cbxVehicleInformation.Name = "cbxVehicleInformation";
            cbxVehicleInformation.Size = new Size(181, 25);
            cbxVehicleInformation.TabIndex = 3;
            cbxVehicleInformation.Text = "Vehicle Information";
            cbxVehicleInformation.UseVisualStyleBackColor = true;
            // 
            // cbxPropertyInformation
            // 
            cbxPropertyInformation.AutoCheck = false;
            cbxPropertyInformation.AutoSize = true;
            cbxPropertyInformation.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxPropertyInformation.Location = new Point(392, 9);
            cbxPropertyInformation.Name = "cbxPropertyInformation";
            cbxPropertyInformation.Size = new Size(189, 25);
            cbxPropertyInformation.TabIndex = 2;
            cbxPropertyInformation.Text = "Property Information";
            cbxPropertyInformation.UseVisualStyleBackColor = true;
            // 
            // cbxMemberInformation
            // 
            cbxMemberInformation.AutoCheck = false;
            cbxMemberInformation.AutoSize = true;
            cbxMemberInformation.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMemberInformation.Location = new Point(196, 9);
            cbxMemberInformation.Name = "cbxMemberInformation";
            cbxMemberInformation.Size = new Size(190, 25);
            cbxMemberInformation.TabIndex = 1;
            cbxMemberInformation.Text = "Member Information";
            cbxMemberInformation.UseVisualStyleBackColor = true;
            // 
            // cbxAccountAccess
            // 
            cbxAccountAccess.AutoCheck = false;
            cbxAccountAccess.AutoSize = true;
            cbxAccountAccess.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxAccountAccess.Location = new Point(32, 9);
            cbxAccountAccess.Name = "cbxAccountAccess";
            cbxAccountAccess.Size = new Size(158, 25);
            cbxAccountAccess.TabIndex = 0;
            cbxAccountAccess.Text = "Account Access";
            cbxAccountAccess.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 369);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ddada8a9_6050_435f_ad92_a666724f9114_removalai_preview;
            pictureBox2.Location = new Point(760, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(802, 500);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registration";
            ShowIcon = false;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private CheckBox cbxVehicleInformation;
        private CheckBox cbxPropertyInformation;
        private CheckBox cbxMemberInformation;
        private CheckBox cbxAccountAccess;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}