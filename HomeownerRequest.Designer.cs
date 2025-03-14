namespace HoaMage
{
    partial class HomeownerRequest
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
            tbxSubject = new MaterialSkin.Controls.MaterialTextBox2();
            materialMultiLineTextBox21 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            btnSed = new MaterialSkin.Controls.MaterialButton();
            cbxType = new MaterialSkin.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // tbxSubject
            // 
            tbxSubject.AnimateReadOnly = false;
            tbxSubject.BackgroundImageLayout = ImageLayout.None;
            tbxSubject.CharacterCasing = CharacterCasing.Normal;
            tbxSubject.Depth = 0;
            tbxSubject.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxSubject.HideSelection = true;
            tbxSubject.Hint = "Subject";
            tbxSubject.LeadingIcon = null;
            tbxSubject.Location = new Point(38, 66);
            tbxSubject.MaxLength = 32767;
            tbxSubject.MouseState = MaterialSkin.MouseState.OUT;
            tbxSubject.Name = "tbxSubject";
            tbxSubject.PasswordChar = '\0';
            tbxSubject.PrefixSuffixText = null;
            tbxSubject.ReadOnly = false;
            tbxSubject.RightToLeft = RightToLeft.No;
            tbxSubject.SelectedText = "";
            tbxSubject.SelectionLength = 0;
            tbxSubject.SelectionStart = 0;
            tbxSubject.ShortcutsEnabled = true;
            tbxSubject.Size = new Size(645, 48);
            tbxSubject.TabIndex = 0;
            tbxSubject.TabStop = false;
            tbxSubject.TextAlign = HorizontalAlignment.Left;
            tbxSubject.TrailingIcon = null;
            tbxSubject.UseSystemPasswordChar = false;
            // 
            // materialMultiLineTextBox21
            // 
            materialMultiLineTextBox21.AnimateReadOnly = false;
            materialMultiLineTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialMultiLineTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialMultiLineTextBox21.Depth = 0;
            materialMultiLineTextBox21.HideSelection = true;
            materialMultiLineTextBox21.Hint = "Description";
            materialMultiLineTextBox21.Location = new Point(38, 120);
            materialMultiLineTextBox21.MaxLength = 32767;
            materialMultiLineTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialMultiLineTextBox21.Name = "materialMultiLineTextBox21";
            materialMultiLineTextBox21.PasswordChar = '\0';
            materialMultiLineTextBox21.ReadOnly = false;
            materialMultiLineTextBox21.ScrollBars = ScrollBars.None;
            materialMultiLineTextBox21.SelectedText = "";
            materialMultiLineTextBox21.SelectionLength = 0;
            materialMultiLineTextBox21.SelectionStart = 0;
            materialMultiLineTextBox21.ShortcutsEnabled = true;
            materialMultiLineTextBox21.Size = new Size(645, 262);
            materialMultiLineTextBox21.TabIndex = 1;
            materialMultiLineTextBox21.TabStop = false;
            materialMultiLineTextBox21.TextAlign = HorizontalAlignment.Left;
            materialMultiLineTextBox21.UseSystemPasswordChar = false;
            // 
            // btnSed
            // 
            btnSed.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSed.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSed.Depth = 0;
            btnSed.HighEmphasis = true;
            btnSed.Icon = null;
            btnSed.Location = new Point(609, 391);
            btnSed.Margin = new Padding(4, 6, 4, 6);
            btnSed.MouseState = MaterialSkin.MouseState.HOVER;
            btnSed.Name = "btnSed";
            btnSed.NoAccentTextColor = Color.Empty;
            btnSed.Size = new Size(64, 36);
            btnSed.TabIndex = 2;
            btnSed.Text = "Send";
            btnSed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSed.UseAccentColor = false;
            btnSed.UseVisualStyleBackColor = true;
            // 
            // cbxType
            // 
            cbxType.AutoResize = false;
            cbxType.BackColor = Color.FromArgb(255, 255, 255);
            cbxType.Depth = 0;
            cbxType.DrawMode = DrawMode.OwnerDrawVariable;
            cbxType.DropDownHeight = 174;
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxType.DropDownWidth = 121;
            cbxType.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxType.FormattingEnabled = true;
            cbxType.Hint = "Type";
            cbxType.IntegralHeight = false;
            cbxType.ItemHeight = 43;
            cbxType.Items.AddRange(new object[] { "Request", "Complaints", "Maintainance", "Security", "Others" });
            cbxType.Location = new Point(38, 11);
            cbxType.MaxDropDownItems = 4;
            cbxType.MouseState = MaterialSkin.MouseState.OUT;
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(121, 49);
            cbxType.StartIndex = 0;
            cbxType.TabIndex = 3;
            // 
            // HomeownerRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbxType);
            Controls.Add(btnSed);
            Controls.Add(materialMultiLineTextBox21);
            Controls.Add(tbxSubject);
            Name = "HomeownerRequest";
            Size = new Size(727, 445);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbxSubject;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox21;
        private MaterialSkin.Controls.MaterialButton btnSed;
        private MaterialSkin.Controls.MaterialComboBox cbxType;
    }
}
