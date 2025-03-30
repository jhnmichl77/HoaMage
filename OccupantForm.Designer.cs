namespace HoaMage
{
    partial class OccupantForm
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
            pbxOccupantImage = new PictureBox();
            lblBirthday = new Label();
            lblAge = new Label();
            lblGender = new Label();
            lblName = new Label();
            tbxOccupantName = new TextBox();
            tbxGender = new TextBox();
            tbxAge = new TextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            dtpBirthday = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxOccupantImage).BeginInit();
            SuspendLayout();
            // 
            // pbxOccupantImage
            // 
            pbxOccupantImage.Location = new Point(23, 105);
            pbxOccupantImage.Name = "pbxOccupantImage";
            pbxOccupantImage.Size = new Size(100, 100);
            pbxOccupantImage.TabIndex = 9;
            pbxOccupantImage.TabStop = false;
            pbxOccupantImage.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 12F);
            lblBirthday.Location = new Point(129, 169);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(71, 21);
            lblBirthday.TabIndex = 8;
            lblBirthday.Text = "Birthday:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F);
            lblAge.Location = new Point(160, 208);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(40, 21);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F);
            lblGender.Location = new Point(136, 130);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 21);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(145, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 21);
            lblName.TabIndex = 5;
            lblName.Text = "Name:";
            // 
            // tbxOccupantName
            // 
            tbxOccupantName.Location = new Point(197, 87);
            tbxOccupantName.Name = "tbxOccupantName";
            tbxOccupantName.Size = new Size(197, 23);
            tbxOccupantName.TabIndex = 10;
            // 
            // tbxGender
            // 
            tbxGender.Location = new Point(197, 130);
            tbxGender.Name = "tbxGender";
            tbxGender.Size = new Size(197, 23);
            tbxGender.TabIndex = 11;
            // 
            // tbxAge
            // 
            tbxAge.Location = new Point(197, 208);
            tbxAge.Name = "tbxAge";
            tbxAge.Size = new Size(197, 23);
            tbxAge.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(260, 240);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtpBirthday
            // 
            dtpBirthday.CustomFormat = "MMMM dd, yyyy";
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.Location = new Point(197, 169);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(197, 23);
            dtpBirthday.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(82, 208);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 16;
            label1.Text = "upload";
            label1.Click += label1_Click;
            // 
            // OccupantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 281);
            Controls.Add(label1);
            Controls.Add(dtpBirthday);
            Controls.Add(btnSave);
            Controls.Add(tbxAge);
            Controls.Add(tbxGender);
            Controls.Add(tbxOccupantName);
            Controls.Add(pbxOccupantImage);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblGender);
            Controls.Add(lblName);
            Name = "OccupantForm";
            Text = "Occupant";
            ((System.ComponentModel.ISupportInitialize)pbxOccupantImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxOccupantImage;
        private Label lblBirthday;
        private Label lblAge;
        private Label lblGender;
        private Label lblName;
        private TextBox tbxOccupantName;
        private TextBox tbxGender;
        private TextBox textBox3;
        private TextBox tbxAge;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private DateTimePicker dtpBirthday;
        private Label label1;
    }
}