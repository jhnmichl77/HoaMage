namespace HoaMage
{
    partial class Bill
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
            cbxAccounts = new MaterialSkin.Controls.MaterialComboBox();
            tbxDescription = new TextBox();
            label1 = new Label();
            dtpDueDate = new DateTimePicker();
            tbxAmount = new MaterialSkin.Controls.MaterialTextBox2();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            tbxName = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // cbxAccounts
            // 
            cbxAccounts.AutoResize = false;
            cbxAccounts.BackColor = Color.FromArgb(255, 255, 255);
            cbxAccounts.Depth = 0;
            cbxAccounts.DrawMode = DrawMode.OwnerDrawVariable;
            cbxAccounts.DropDownHeight = 174;
            cbxAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAccounts.DropDownWidth = 121;
            cbxAccounts.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxAccounts.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxAccounts.FormattingEnabled = true;
            cbxAccounts.IntegralHeight = false;
            cbxAccounts.ItemHeight = 43;
            cbxAccounts.Location = new Point(21, 67);
            cbxAccounts.MaxDropDownItems = 4;
            cbxAccounts.MouseState = MaterialSkin.MouseState.OUT;
            cbxAccounts.Name = "cbxAccounts";
            cbxAccounts.Size = new Size(290, 49);
            cbxAccounts.StartIndex = 0;
            cbxAccounts.TabIndex = 0;
            cbxAccounts.SelectedIndexChanged += cbxAccounts_SelectedIndexChanged;
            // 
            // tbxDescription
            // 
            tbxDescription.Location = new Point(16, 212);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(412, 203);
            tbxDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 184);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 2;
            label1.Text = "DueDate: ";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(101, 181);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(205, 23);
            dtpDueDate.TabIndex = 3;
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
            tbxAmount.Location = new Point(21, 432);
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
            tbxAmount.Size = new Size(250, 48);
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
            btnSave.Location = new Point(364, 444);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MaximumSize = new Size(64, 36);
            btnSave.MinimumSize = new Size(64, 36);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            tbxName.Location = new Point(21, 122);
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
            tbxName.Size = new Size(290, 48);
            tbxName.TabIndex = 6;
            tbxName.TabStop = false;
            tbxName.TextAlign = HorizontalAlignment.Left;
            tbxName.TrailingIcon = null;
            tbxName.UseSystemPasswordChar = false;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 490);
            Controls.Add(tbxName);
            Controls.Add(btnSave);
            Controls.Add(tbxAmount);
            Controls.Add(dtpDueDate);
            Controls.Add(label1);
            Controls.Add(tbxDescription);
            Controls.Add(cbxAccounts);
            Name = "Bill";
            Text = "Bill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbxAccounts;
        private TextBox tbxDescription;
        private Label label1;
        private DateTimePicker dtpDueDate;
        private MaterialSkin.Controls.MaterialTextBox2 tbxAmount;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox2 tbxName;
    }
}