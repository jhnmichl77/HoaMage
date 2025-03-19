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
            tbxUsername.LeadingIcon = Properties.Resources._274c61d5_e0b8_4c7a_bd67_f6adf21e17fa_removalai_preview;
            tbxUsername.Location = new Point(37, 48);
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
            tbxPassword.LeadingIcon = Properties.Resources._0ac81286_c507_4f48_9480_59c2934c1aa3_removalai_preview;
            tbxPassword.Location = new Point(37, 102);
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
            tbxEmailAddress.LeadingIcon = Properties.Resources.c52ecfb6_cbc4_4ef2_b554_ebd49559bb66_removalai_preview;
            tbxEmailAddress.Location = new Point(37, 250);
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
            tbxEmailAddress.TabIndex = 16;
            tbxEmailAddress.TabStop = false;
            tbxEmailAddress.TextAlign = HorizontalAlignment.Left;
            tbxEmailAddress.TrailingIcon = null;
            tbxEmailAddress.UseSystemPasswordChar = false;
            // 
            // cbxRole
            // 
            cbxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRole.FormattingEnabled = true;
            cbxRole.Items.AddRange(new object[] { "Renter", "Homeowner" });
            cbxRole.Location = new Point(37, 304);
            cbxRole.Name = "cbxRole";
            cbxRole.Size = new Size(121, 23);
            cbxRole.TabIndex = 17;
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
            tbxConfirmPassword.Location = new Point(37, 156);
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
            tbxConfirmPassword.TabIndex = 15;
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
            btnNext.Location = new Point(238, 307);
            btnNext.Margin = new Padding(4, 6, 4, 6);
            btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            btnNext.Name = "btnNext";
            btnNext.NoAccentTextColor = Color.Empty;
            btnNext.Size = new Size(75, 36);
            btnNext.TabIndex = 18;
            btnNext.Text = "Submit";
            btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNext.UseAccentColor = false;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // AccountAccess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnNext);
            Controls.Add(tbxConfirmPassword);
            Controls.Add(cbxRole);
            Controls.Add(tbxEmailAddress);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Name = "AccountAccess";
            Size = new Size(800, 369);
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
    }
}
