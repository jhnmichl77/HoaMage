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
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
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
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Number of Occupants";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(29, 186);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(408, 48);
            materialTextBox21.TabIndex = 2;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.Hint = "Ownership Type";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "Renter", "Owner-Occupied", "Vacant" });
            materialComboBox1.Location = new Point(29, 253);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(213, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 3;
            // 
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.BackgroundImageLayout = ImageLayout.None;
            materialTextBox22.CharacterCasing = CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox22.HideSelection = true;
            materialTextBox22.Hint = "Name of Residence";
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new Point(29, 24);
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.PrefixSuffixText = null;
            materialTextBox22.ReadOnly = false;
            materialTextBox22.RightToLeft = RightToLeft.No;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.Size = new Size(703, 48);
            materialTextBox22.TabIndex = 4;
            materialTextBox22.TabStop = false;
            materialTextBox22.TextAlign = HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
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
            btnNext.Click += materialButton1_Click;
            // 
            // PropertyInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNext);
            Controls.Add(materialTextBox22);
            Controls.Add(materialComboBox1);
            Controls.Add(materialTextBox21);
            Controls.Add(tbxUnitNumber);
            Controls.Add(tbxHomeAddress);
            Name = "PropertyInformation";
            Size = new Size(800, 369);
            Load += PropertyInformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbxHomeAddress;
        private MaterialSkin.Controls.MaterialTextBox2 tbxUnitNumber;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialButton btnNext;
    }
}
