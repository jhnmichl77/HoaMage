namespace HoaMage
{
    partial class PropertyInformation
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
            tbxHomeAddress = new MaterialSkin.Controls.MaterialTextBox2();
            tbxUnitNumber = new MaterialSkin.Controls.MaterialTextBox2();
            tbxNumOfOccupants = new MaterialSkin.Controls.MaterialTextBox2();
            cbxType = new MaterialSkin.Controls.MaterialComboBox();
            tbxResidenceName = new MaterialSkin.Controls.MaterialTextBox2();
            btnNext = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // tbxHomeAddress
            // 
            tbxHomeAddress.AnimateReadOnly = false;
            tbxHomeAddress.BackgroundImageLayout = ImageLayout.None;
            tbxHomeAddress.CharacterCasing = CharacterCasing.Normal;
            tbxHomeAddress.Depth = 0;
            tbxHomeAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxHomeAddress.HideSelection = true;
            tbxHomeAddress.Hint = "Home Address";
            tbxHomeAddress.LeadingIcon = null;
            tbxHomeAddress.Location = new Point(29, 78);
            tbxHomeAddress.MaxLength = 32767;
            tbxHomeAddress.MouseState = MaterialSkin.MouseState.OUT;
            tbxHomeAddress.Name = "tbxHomeAddress";
            tbxHomeAddress.PasswordChar = '\0';
            tbxHomeAddress.PrefixSuffixText = null;
            tbxHomeAddress.ReadOnly = false;
            tbxHomeAddress.RightToLeft = RightToLeft.No;
            tbxHomeAddress.SelectedText = "";
            tbxHomeAddress.SelectionLength = 0;
            tbxHomeAddress.SelectionStart = 0;
            tbxHomeAddress.ShortcutsEnabled = true;
            tbxHomeAddress.Size = new Size(703, 48);
            tbxHomeAddress.TabIndex = 0;
            tbxHomeAddress.TabStop = false;
            tbxHomeAddress.TextAlign = HorizontalAlignment.Left;
            tbxHomeAddress.TrailingIcon = null;
            tbxHomeAddress.UseSystemPasswordChar = false;
            // 
            // tbxUnitNumber
            // 
            tbxUnitNumber.AnimateReadOnly = false;
            tbxUnitNumber.BackgroundImageLayout = ImageLayout.None;
            tbxUnitNumber.CharacterCasing = CharacterCasing.Normal;
            tbxUnitNumber.Depth = 0;
            tbxUnitNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxUnitNumber.HideSelection = true;
            tbxUnitNumber.Hint = "Unit Number";
            tbxUnitNumber.LeadingIcon = null;
            tbxUnitNumber.Location = new Point(29, 132);
            tbxUnitNumber.MaxLength = 32767;
            tbxUnitNumber.MouseState = MaterialSkin.MouseState.OUT;
            tbxUnitNumber.Name = "tbxUnitNumber";
            tbxUnitNumber.PasswordChar = '\0';
            tbxUnitNumber.PrefixSuffixText = null;
            tbxUnitNumber.ReadOnly = false;
            tbxUnitNumber.RightToLeft = RightToLeft.No;
            tbxUnitNumber.SelectedText = "";
            tbxUnitNumber.SelectionLength = 0;
            tbxUnitNumber.SelectionStart = 0;
            tbxUnitNumber.ShortcutsEnabled = true;
            tbxUnitNumber.Size = new Size(408, 48);
            tbxUnitNumber.TabIndex = 1;
            tbxUnitNumber.TabStop = false;
            tbxUnitNumber.TextAlign = HorizontalAlignment.Left;
            tbxUnitNumber.TrailingIcon = null;
            tbxUnitNumber.UseSystemPasswordChar = false;
            // 
            // tbxNumOfOccupants
            // 
            tbxNumOfOccupants.AnimateReadOnly = false;
            tbxNumOfOccupants.BackgroundImageLayout = ImageLayout.None;
            tbxNumOfOccupants.CharacterCasing = CharacterCasing.Normal;
            tbxNumOfOccupants.Depth = 0;
            tbxNumOfOccupants.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxNumOfOccupants.HideSelection = true;
            tbxNumOfOccupants.Hint = "Number of Occupants";
            tbxNumOfOccupants.LeadingIcon = null;
            tbxNumOfOccupants.Location = new Point(29, 186);
            tbxNumOfOccupants.MaxLength = 32767;
            tbxNumOfOccupants.MouseState = MaterialSkin.MouseState.OUT;
            tbxNumOfOccupants.Name = "tbxNumOfOccupants";
            tbxNumOfOccupants.PasswordChar = '\0';
            tbxNumOfOccupants.PrefixSuffixText = null;
            tbxNumOfOccupants.ReadOnly = false;
            tbxNumOfOccupants.RightToLeft = RightToLeft.No;
            tbxNumOfOccupants.SelectedText = "";
            tbxNumOfOccupants.SelectionLength = 0;
            tbxNumOfOccupants.SelectionStart = 0;
            tbxNumOfOccupants.ShortcutsEnabled = true;
            tbxNumOfOccupants.Size = new Size(408, 48);
            tbxNumOfOccupants.TabIndex = 2;
            tbxNumOfOccupants.TabStop = false;
            tbxNumOfOccupants.TextAlign = HorizontalAlignment.Left;
            tbxNumOfOccupants.TrailingIcon = null;
            tbxNumOfOccupants.UseSystemPasswordChar = false;
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
            cbxType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxType.FormattingEnabled = true;
            cbxType.Hint = "Ownership Type";
            cbxType.IntegralHeight = false;
            cbxType.ItemHeight = 43;
            cbxType.Items.AddRange(new object[] { "Renter", "Owner-Occupied", "Vacant" });
            cbxType.Location = new Point(29, 253);
            cbxType.MaxDropDownItems = 4;
            cbxType.MouseState = MaterialSkin.MouseState.OUT;
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(213, 49);
            cbxType.StartIndex = 0;
            cbxType.TabIndex = 3;
            // 
            // tbxResidenceName
            // 
            tbxResidenceName.AnimateReadOnly = false;
            tbxResidenceName.BackgroundImageLayout = ImageLayout.None;
            tbxResidenceName.CharacterCasing = CharacterCasing.Normal;
            tbxResidenceName.Depth = 0;
            tbxResidenceName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxResidenceName.HideSelection = true;
            tbxResidenceName.Hint = "Name of Residence";
            tbxResidenceName.LeadingIcon = null;
            tbxResidenceName.Location = new Point(29, 24);
            tbxResidenceName.MaxLength = 32767;
            tbxResidenceName.MouseState = MaterialSkin.MouseState.OUT;
            tbxResidenceName.Name = "tbxResidenceName";
            tbxResidenceName.PasswordChar = '\0';
            tbxResidenceName.PrefixSuffixText = null;
            tbxResidenceName.ReadOnly = false;
            tbxResidenceName.RightToLeft = RightToLeft.No;
            tbxResidenceName.SelectedText = "";
            tbxResidenceName.SelectionLength = 0;
            tbxResidenceName.SelectionStart = 0;
            tbxResidenceName.ShortcutsEnabled = true;
            tbxResidenceName.Size = new Size(703, 48);
            tbxResidenceName.TabIndex = 4;
            tbxResidenceName.TabStop = false;
            tbxResidenceName.TextAlign = HorizontalAlignment.Left;
            tbxResidenceName.TrailingIcon = null;
            tbxResidenceName.UseSystemPasswordChar = false;
            // 
            // btnNext
            // 
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNext.Depth = 0;
            btnNext.HighEmphasis = true;
            btnNext.Icon = null;
            btnNext.Location = new Point(668, 302);
            btnNext.Margin = new Padding(4, 6, 4, 6);
            btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            btnNext.Name = "btnNext";
            btnNext.NoAccentTextColor = Color.Empty;
            btnNext.Size = new Size(75, 36);
            btnNext.TabIndex = 5;
            btnNext.Text = "Submit";
            btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNext.UseAccentColor = false;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnSubmit_Click;
            // 
            // PropertyInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(tbxResidenceName);
            Controls.Add(cbxType);
            Controls.Add(tbxNumOfOccupants);
            Controls.Add(tbxUnitNumber);
            Controls.Add(tbxHomeAddress);
            Name = "PropertyInformation";
            Size = new Size(800, 369);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbxHomeAddress;
        private MaterialSkin.Controls.MaterialTextBox2 tbxUnitNumber;
        private MaterialSkin.Controls.MaterialTextBox2 tbxNumOfOccupants;
        private MaterialSkin.Controls.MaterialComboBox cbxType;
        private MaterialSkin.Controls.MaterialTextBox2 tbxResidenceName;
        private MaterialSkin.Controls.MaterialButton btnNext;
    }
}
