namespace HoaMage
{
    partial class AccountAccess
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxUsername = new MaterialSkin.Controls.MaterialTextBox2();
            tbxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            tbxEmailAddress = new MaterialSkin.Controls.MaterialTextBox2();
            cbxRole = new ComboBox();
            tbxConfirmPassword = new MaterialSkin.Controls.MaterialTextBox2();
            btnNext = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            tbxUsername.Location = new Point(63, 49);
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
            tbxUsername.TabIndex = 13;
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
            tbxPassword.Location = new Point(63, 103);
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
            tbxPassword.TabIndex = 14;
            tbxPassword.TabStop = false;
            tbxPassword.TextAlign = HorizontalAlignment.Left;
            tbxPassword.TrailingIcon = null;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxEmailAddress
            // 
            tbxEmailAddress.AnimateReadOnly = false;
            tbxEmailAddress.BackgroundImageLayout = ImageLayout.None;
            tbxEmailAddress.CharacterCasing = CharacterCasing.Normal;
            tbxEmailAddress.Depth = 0;
            tbxEmailAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxEmailAddress.HideSelection = true;
            tbxEmailAddress.Hint = "Email Address";
            tbxEmailAddress.LeadingIcon = null;
            tbxEmailAddress.Location = new Point(63, 251);
            tbxEmailAddress.MaxLength = 32767;
            tbxEmailAddress.MouseState = MaterialSkin.MouseState.OUT;
            tbxEmailAddress.Name = "tbxEmailAddress";
            tbxEmailAddress.PasswordChar = '\0';
            tbxEmailAddress.PrefixSuffixText = null;
            tbxEmailAddress.ReadOnly = false;
            tbxEmailAddress.RightToLeft = RightToLeft.No;
            tbxEmailAddress.SelectedText = "";
            tbxEmailAddress.SelectionLength = 0;
            tbxEmailAddress.SelectionStart = 0;
            tbxEmailAddress.ShortcutsEnabled = true;
            tbxEmailAddress.Size = new Size(275, 48);
            tbxEmailAddress.TabIndex = 15;
            tbxEmailAddress.TabStop = false;
            tbxEmailAddress.TextAlign = HorizontalAlignment.Left;
            tbxEmailAddress.TrailingIcon = null;
            tbxEmailAddress.UseSystemPasswordChar = false;
            // 
            // cbxRole
            // 
            cbxRole.FormattingEnabled = true;
            cbxRole.Items.AddRange(new object[] { "Admin", "Homeowner" });
            cbxRole.Location = new Point(63, 305);
            cbxRole.Name = "cbxRole";
            cbxRole.Size = new Size(121, 23);
            cbxRole.TabIndex = 16;
            // 
            // tbxConfirmPassword
            // 
            tbxConfirmPassword.AnimateReadOnly = false;
            tbxConfirmPassword.BackgroundImageLayout = ImageLayout.None;
            tbxConfirmPassword.CharacterCasing = CharacterCasing.Normal;
            tbxConfirmPassword.Depth = 0;
            tbxConfirmPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxConfirmPassword.HideSelection = true;
            tbxConfirmPassword.Hint = "Confirm Password";
            tbxConfirmPassword.LeadingIcon = null;
            tbxConfirmPassword.Location = new Point(63, 157);
            tbxConfirmPassword.MaxLength = 32767;
            tbxConfirmPassword.MouseState = MaterialSkin.MouseState.OUT;
            tbxConfirmPassword.Name = "tbxConfirmPassword";
            tbxConfirmPassword.PasswordChar = '●';
            tbxConfirmPassword.PrefixSuffixText = null;
            tbxConfirmPassword.ReadOnly = false;
            tbxConfirmPassword.RightToLeft = RightToLeft.No;
            tbxConfirmPassword.SelectedText = "";
            tbxConfirmPassword.SelectionLength = 0;
            tbxConfirmPassword.SelectionStart = 0;
            tbxConfirmPassword.ShortcutsEnabled = true;
            tbxConfirmPassword.Size = new Size(275, 48);
            tbxConfirmPassword.TabIndex = 17;
            tbxConfirmPassword.TabStop = false;
            tbxConfirmPassword.TextAlign = HorizontalAlignment.Left;
            tbxConfirmPassword.TrailingIcon = null;
            tbxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnNext
            // 
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.BackColor = Color.White;
            btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNext.Depth = 0;
            btnNext.HighEmphasis = true;
            btnNext.Icon = null;
            btnNext.Location = new Point(264, 308);
            btnNext.Margin = new Padding(4, 6, 4, 6);
            btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            btnNext.Name = "btnNext";
            btnNext.NoAccentTextColor = Color.Empty;
            btnNext.Size = new Size(75, 36);
            btnNext.TabIndex = 19;
            btnNext.Text = "Submit";
            btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNext.UseAccentColor = false;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._274c61d5_e0b8_4c7a_bd67_f6adf21e17fa_removalai_preview;
            pictureBox1.Location = new Point(19, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._0ac81286_c507_4f48_9480_59c2934c1aa3_removalai_preview;
            pictureBox2.Location = new Point(19, 112);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.c52ecfb6_cbc4_4ef2_b554_ebd49559bb66_removalai_preview;
            pictureBox3.Location = new Point(19, 259);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // AccountAccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnNext);
            Controls.Add(tbxConfirmPassword);
            Controls.Add(cbxRole);
            Controls.Add(tbxEmailAddress);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Name = "AccountAccess";
            Size = new Size(800, 369);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbxUsername;
        private MaterialSkin.Controls.MaterialTextBox2 tbxPassword;
        private MaterialSkin.Controls.MaterialTextBox2 tbxEmailAddress;
        private ComboBox cbxRole;
        private MaterialSkin.Controls.MaterialTextBox2 tbxConfirmPassword;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
