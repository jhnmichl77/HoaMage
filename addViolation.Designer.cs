namespace HoaMage
{
    partial class addViolation
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
            tbxRuleName = new MaterialSkin.Controls.MaterialTextBox2();
            tbxDescription = new TextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            tbxPenalty = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // tbxRuleName
            // 
            tbxRuleName.AnimateReadOnly = false;
            tbxRuleName.BackgroundImageLayout = ImageLayout.None;
            tbxRuleName.CharacterCasing = CharacterCasing.Normal;
            tbxRuleName.Depth = 0;
            tbxRuleName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxRuleName.HideSelection = true;
            tbxRuleName.Hint = "Rule Name";
            tbxRuleName.LeadingIcon = null;
            tbxRuleName.Location = new Point(24, 76);
            tbxRuleName.MaxLength = 32767;
            tbxRuleName.MouseState = MaterialSkin.MouseState.OUT;
            tbxRuleName.Name = "tbxRuleName";
            tbxRuleName.PasswordChar = '\0';
            tbxRuleName.PrefixSuffixText = null;
            tbxRuleName.ReadOnly = false;
            tbxRuleName.RightToLeft = RightToLeft.No;
            tbxRuleName.SelectedText = "";
            tbxRuleName.SelectionLength = 0;
            tbxRuleName.SelectionStart = 0;
            tbxRuleName.ShortcutsEnabled = true;
            tbxRuleName.Size = new Size(250, 48);
            tbxRuleName.TabIndex = 1;
            tbxRuleName.TabStop = false;
            tbxRuleName.TextAlign = HorizontalAlignment.Left;
            tbxRuleName.TrailingIcon = null;
            tbxRuleName.UseSystemPasswordChar = false;
            // 
            // tbxDescription
            // 
            tbxDescription.Location = new Point(24, 130);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(555, 170);
            tbxDescription.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(515, 313);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbxPenalty
            // 
            tbxPenalty.AnimateReadOnly = false;
            tbxPenalty.BackgroundImageLayout = ImageLayout.None;
            tbxPenalty.CharacterCasing = CharacterCasing.Normal;
            tbxPenalty.Depth = 0;
            tbxPenalty.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxPenalty.HideSelection = true;
            tbxPenalty.Hint = "Penalty";
            tbxPenalty.LeadingIcon = null;
            tbxPenalty.Location = new Point(24, 304);
            tbxPenalty.MaxLength = 32767;
            tbxPenalty.MouseState = MaterialSkin.MouseState.OUT;
            tbxPenalty.Name = "tbxPenalty";
            tbxPenalty.PasswordChar = '\0';
            tbxPenalty.PrefixSuffixText = null;
            tbxPenalty.ReadOnly = false;
            tbxPenalty.RightToLeft = RightToLeft.No;
            tbxPenalty.SelectedText = "";
            tbxPenalty.SelectionLength = 0;
            tbxPenalty.SelectionStart = 0;
            tbxPenalty.ShortcutsEnabled = true;
            tbxPenalty.Size = new Size(250, 48);
            tbxPenalty.TabIndex = 4;
            tbxPenalty.TabStop = false;
            tbxPenalty.TextAlign = HorizontalAlignment.Left;
            tbxPenalty.TrailingIcon = null;
            tbxPenalty.UseSystemPasswordChar = false;
            // 
            // addViolation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 358);
            Controls.Add(tbxPenalty);
            Controls.Add(btnSave);
            Controls.Add(tbxDescription);
            Controls.Add(tbxRuleName);
            Name = "addViolation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 tbxRuleName;
        private TextBox tbxDescription;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox2 tbxPenalty;
    }
}