namespace HoaMage
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            tbxUsername = new MaterialSkin.Controls.MaterialTextBox2();
            tbxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            label1.Location = new Point(540, 74);
            label1.Name = "label1";
            label1.Size = new Size(173, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-30, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 452);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = Color.White;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(592, 297);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(74, 36);
            materialButton1.TabIndex = 14;
            materialButton1.Text = "Sign-in";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            materialButton1.Click += btnLogin_Click;
            // 
            // tbxUsername
            // 
            tbxUsername.AnimateReadOnly = false;
            tbxUsername.BackgroundImageLayout = ImageLayout.None;
            tbxUsername.CharacterCasing = CharacterCasing.Normal;
            tbxUsername.Depth = 0;
            tbxUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxUsername.HideSelection = true;
            tbxUsername.Hint = "Username";
            tbxUsername.LeadingIcon = Properties.Resources._274c61d5_e0b8_4c7a_bd67_f6adf21e17fa_removalai_preview;
            tbxUsername.Location = new Point(487, 156);
            tbxUsername.MaxLength = 32767;
            tbxUsername.MouseState = MaterialSkin.MouseState.OUT;
            tbxUsername.Name = "tbxUsername";
            tbxUsername.PasswordChar = '\0';
            tbxUsername.PrefixSuffixText = null;
            tbxUsername.ReadOnly = false;
            tbxUsername.RightToLeft = RightToLeft.No;
            tbxUsername.SelectedText = "";
            tbxUsername.SelectionLength = 0;
            tbxUsername.SelectionStart = 0;
            tbxUsername.ShortcutsEnabled = true;
            tbxUsername.Size = new Size(275, 48);
            tbxUsername.TabIndex = 12;
            tbxUsername.TabStop = false;
            tbxUsername.TextAlign = HorizontalAlignment.Left;
            tbxUsername.TrailingIcon = null;
            tbxUsername.UseSystemPasswordChar = false;
            // 
            // tbxPassword
            // 
            tbxPassword.AnimateReadOnly = false;
            tbxPassword.BackgroundImageLayout = ImageLayout.None;
            tbxPassword.CharacterCasing = CharacterCasing.Normal;
            tbxPassword.Depth = 0;
            tbxPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxPassword.HideSelection = true;
            tbxPassword.Hint = "Password";
            tbxPassword.LeadingIcon = Properties.Resources._0ac81286_c507_4f48_9480_59c2934c1aa3_removalai_preview;
            tbxPassword.Location = new Point(487, 210);
            tbxPassword.MaxLength = 32767;
            tbxPassword.MouseState = MaterialSkin.MouseState.OUT;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '●';
            tbxPassword.PrefixSuffixText = null;
            tbxPassword.ReadOnly = false;
            tbxPassword.RightToLeft = RightToLeft.No;
            tbxPassword.SelectedText = "";
            tbxPassword.SelectionLength = 0;
            tbxPassword.SelectionStart = 0;
            tbxPassword.ShortcutsEnabled = true;
            tbxPassword.Size = new Size(275, 48);
            tbxPassword.TabIndex = 13;
            tbxPassword.TabStop = false;
            tbxPassword.TextAlign = HorizontalAlignment.Left;
            tbxPassword.TrailingIcon = null;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ddada8a9_6050_435f_ad92_a666724f9114_removalai_preview;
            pictureBox2.Location = new Point(747, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += materialLabel2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(566, 339);
            label2.Name = "label2";
            label2.Size = new Size(133, 17);
            label2.TabIndex = 15;
            label2.Text = "Create an account";
            label2.Click += lblRegister_Click;
            // 
            // button1
            // 
            button1.Location = new Point(700, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(787, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(materialButton1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 tbxUsername;
        private MaterialSkin.Controls.MaterialTextBox2 tbxPassword;
        private PictureBox pictureBox2;
        private Label label2;
        private Button button1;
    }
}
