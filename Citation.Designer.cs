namespace HoaMage
{
    partial class Citation
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
            cbxRuleViolated = new MaterialSkin.Controls.MaterialComboBox();
            tbxContext = new TextBox();
            dtpViolationDay = new DateTimePicker();
            tbxAmount = new MaterialSkin.Controls.MaterialTextBox2();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            cbxViolator = new MaterialSkin.Controls.MaterialComboBox();
            tbxName = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // cbxRuleViolated
            // 
            cbxRuleViolated.AutoResize = false;
            cbxRuleViolated.BackColor = Color.FromArgb(255, 255, 255);
            cbxRuleViolated.Depth = 0;
            cbxRuleViolated.DrawMode = DrawMode.OwnerDrawVariable;
            cbxRuleViolated.DropDownHeight = 174;
            cbxRuleViolated.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRuleViolated.DropDownWidth = 121;
            cbxRuleViolated.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxRuleViolated.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxRuleViolated.FormattingEnabled = true;
            cbxRuleViolated.Hint = "Violation";
            cbxRuleViolated.IntegralHeight = false;
            cbxRuleViolated.ItemHeight = 43;
            cbxRuleViolated.Location = new Point(25, 185);
            cbxRuleViolated.MaxDropDownItems = 4;
            cbxRuleViolated.MouseState = MaterialSkin.MouseState.OUT;
            cbxRuleViolated.Name = "cbxRuleViolated";
            cbxRuleViolated.Size = new Size(327, 49);
            cbxRuleViolated.StartIndex = 0;
            cbxRuleViolated.TabIndex = 0;
            cbxRuleViolated.SelectedIndexChanged += cbxRuleViolated_SelectedIndexChanged;
            // 
            // tbxContext
            // 
            tbxContext.Location = new Point(25, 301);
            tbxContext.Multiline = true;
            tbxContext.Name = "tbxContext";
            tbxContext.Size = new Size(327, 168);
            tbxContext.TabIndex = 1;
            // 
            // dtpViolationDay
            // 
            dtpViolationDay.Format = DateTimePickerFormat.Short;
            dtpViolationDay.Location = new Point(25, 253);
            dtpViolationDay.Name = "dtpViolationDay";
            dtpViolationDay.Size = new Size(101, 23);
            dtpViolationDay.TabIndex = 2;
            // 
            // tbxAmount
            // 
            tbxAmount.AnimateReadOnly = false;
            tbxAmount.BackgroundImageLayout = ImageLayout.None;
            tbxAmount.CharacterCasing = CharacterCasing.Normal;
            tbxAmount.Depth = 0;
            tbxAmount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxAmount.HideSelection = true;
            tbxAmount.Hint = "Amount";
            tbxAmount.LeadingIcon = null;
            tbxAmount.Location = new Point(186, 240);
            tbxAmount.MaxLength = 32767;
            tbxAmount.MouseState = MaterialSkin.MouseState.OUT;
            tbxAmount.Name = "tbxAmount";
            tbxAmount.PasswordChar = '\0';
            tbxAmount.PrefixSuffixText = null;
            tbxAmount.ReadOnly = false;
            tbxAmount.RightToLeft = RightToLeft.No;
            tbxAmount.SelectedText = "";
            tbxAmount.SelectionLength = 0;
            tbxAmount.SelectionStart = 0;
            tbxAmount.ShortcutsEnabled = true;
            tbxAmount.Size = new Size(166, 48);
            tbxAmount.TabIndex = 4;
            tbxAmount.TabStop = false;
            tbxAmount.TextAlign = HorizontalAlignment.Left;
            tbxAmount.TrailingIcon = null;
            tbxAmount.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(288, 478);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 5;
            btnSave.Text = "SAve";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbxViolator
            // 
            cbxViolator.AutoResize = false;
            cbxViolator.BackColor = Color.FromArgb(255, 255, 255);
            cbxViolator.Depth = 0;
            cbxViolator.DrawMode = DrawMode.OwnerDrawVariable;
            cbxViolator.DropDownHeight = 174;
            cbxViolator.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxViolator.DropDownWidth = 121;
            cbxViolator.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxViolator.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxViolator.FormattingEnabled = true;
            cbxViolator.Hint = "AccountID";
            cbxViolator.IntegralHeight = false;
            cbxViolator.ItemHeight = 43;
            cbxViolator.Location = new Point(25, 76);
            cbxViolator.MaxDropDownItems = 4;
            cbxViolator.MouseState = MaterialSkin.MouseState.OUT;
            cbxViolator.Name = "cbxViolator";
            cbxViolator.Size = new Size(327, 49);
            cbxViolator.StartIndex = 0;
            cbxViolator.TabIndex = 6;
            cbxViolator.SelectedIndexChanged += cbxViolator_SelectedIndexChanged;
            // 
            // tbxName
            // 
            tbxName.AnimateReadOnly = false;
            tbxName.BackgroundImageLayout = ImageLayout.None;
            tbxName.CharacterCasing = CharacterCasing.Normal;
            tbxName.Depth = 0;
            tbxName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxName.HideSelection = true;
            tbxName.Hint = "Name";
            tbxName.LeadingIcon = null;
            tbxName.Location = new Point(25, 131);
            tbxName.MaxLength = 32767;
            tbxName.MouseState = MaterialSkin.MouseState.OUT;
            tbxName.Name = "tbxName";
            tbxName.PasswordChar = '\0';
            tbxName.PrefixSuffixText = null;
            tbxName.ReadOnly = false;
            tbxName.RightToLeft = RightToLeft.No;
            tbxName.SelectedText = "";
            tbxName.SelectionLength = 0;
            tbxName.SelectionStart = 0;
            tbxName.ShortcutsEnabled = true;
            tbxName.Size = new Size(327, 48);
            tbxName.TabIndex = 7;
            tbxName.TabStop = false;
            tbxName.TextAlign = HorizontalAlignment.Left;
            tbxName.TrailingIcon = null;
            tbxName.UseSystemPasswordChar = false;
            // 
            // Citation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 528);
            Controls.Add(tbxName);
            Controls.Add(cbxViolator);
            Controls.Add(btnSave);
            Controls.Add(tbxAmount);
            Controls.Add(dtpViolationDay);
            Controls.Add(tbxContext);
            Controls.Add(cbxRuleViolated);
            Name = "Citation";
            Text = "Citation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbxRuleViolated;
        private TextBox tbxContext;
        private DateTimePicker dtpViolationDay;
        private MaterialSkin.Controls.MaterialTextBox2 tbxAmount;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialComboBox cbxViolator;
        private MaterialSkin.Controls.MaterialTextBox2 tbxName;
    }
}