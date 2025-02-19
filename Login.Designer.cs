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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tbxUsername = new MaterialSkin.Controls.MaterialTextBox2();
            tbxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            materialButton1.TabIndex = 10;
            materialButton1.Text = "Sign-in";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            materialButton1.Click += btnLogin_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(567, 339);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(129, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Create an account";
            materialLabel1.Click += lblRegister_Click;
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
            tbxUsername.LeadingIcon = null;
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
            tbxPassword.LeadingIcon = null;
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
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.ForeColor = Color.DarkRed;
            materialLabel2.Location = new Point(764, 9);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(11, 19);
            materialLabel2.TabIndex = 14;
            materialLabel2.Text = "X";
            materialLabel2.Click += materialLabel2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(787, 450);
            Controls.Add(materialLabel2);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(materialLabel1);
            Controls.Add(materialButton1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 tbxUsername;
        private MaterialSkin.Controls.MaterialTextBox2 tbxPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
