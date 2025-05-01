namespace HoaMage
{
    partial class viewRequest
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
            tbxReqType = new MaterialSkin.Controls.MaterialTextBox2();
            tbxReqSubject = new MaterialSkin.Controls.MaterialTextBox2();
            tbxReqContext = new TextBox();
            tbxReqDate = new MaterialSkin.Controls.MaterialTextBox2();
            cbxStatus = new MaterialSkin.Controls.MaterialComboBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // tbxReqType
            // 
            tbxReqType.AnimateReadOnly = false;
            tbxReqType.BackgroundImageLayout = ImageLayout.None;
            tbxReqType.CharacterCasing = CharacterCasing.Normal;
            tbxReqType.Depth = 0;
            tbxReqType.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxReqType.HideSelection = true;
            tbxReqType.Hint = "Type";
            tbxReqType.LeadingIcon = null;
            tbxReqType.Location = new Point(20, 82);
            tbxReqType.MaxLength = 32767;
            tbxReqType.MouseState = MaterialSkin.MouseState.OUT;
            tbxReqType.Name = "tbxReqType";
            tbxReqType.PasswordChar = '\0';
            tbxReqType.PrefixSuffixText = null;
            tbxReqType.ReadOnly = false;
            tbxReqType.RightToLeft = RightToLeft.No;
            tbxReqType.SelectedText = "";
            tbxReqType.SelectionLength = 0;
            tbxReqType.SelectionStart = 0;
            tbxReqType.ShortcutsEnabled = true;
            tbxReqType.Size = new Size(222, 48);
            tbxReqType.TabIndex = 0;
            tbxReqType.TabStop = false;
            tbxReqType.TextAlign = HorizontalAlignment.Left;
            tbxReqType.TrailingIcon = null;
            tbxReqType.UseSystemPasswordChar = false;
            // 
            // tbxReqSubject
            // 
            tbxReqSubject.AnimateReadOnly = false;
            tbxReqSubject.BackgroundImageLayout = ImageLayout.None;
            tbxReqSubject.CharacterCasing = CharacterCasing.Normal;
            tbxReqSubject.Depth = 0;
            tbxReqSubject.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxReqSubject.HideSelection = true;
            tbxReqSubject.Hint = "Subject";
            tbxReqSubject.LeadingIcon = null;
            tbxReqSubject.Location = new Point(20, 145);
            tbxReqSubject.MaxLength = 32767;
            tbxReqSubject.MouseState = MaterialSkin.MouseState.OUT;
            tbxReqSubject.Name = "tbxReqSubject";
            tbxReqSubject.PasswordChar = '\0';
            tbxReqSubject.PrefixSuffixText = null;
            tbxReqSubject.ReadOnly = false;
            tbxReqSubject.RightToLeft = RightToLeft.No;
            tbxReqSubject.SelectedText = "";
            tbxReqSubject.SelectionLength = 0;
            tbxReqSubject.SelectionStart = 0;
            tbxReqSubject.ShortcutsEnabled = true;
            tbxReqSubject.Size = new Size(222, 48);
            tbxReqSubject.TabIndex = 1;
            tbxReqSubject.TabStop = false;
            tbxReqSubject.TextAlign = HorizontalAlignment.Left;
            tbxReqSubject.TrailingIcon = null;
            tbxReqSubject.UseSystemPasswordChar = false;
            // 
            // tbxReqContext
            // 
            tbxReqContext.Location = new Point(20, 213);
            tbxReqContext.Multiline = true;
            tbxReqContext.Name = "tbxReqContext";
            tbxReqContext.Size = new Size(571, 268);
            tbxReqContext.TabIndex = 2;
            // 
            // tbxReqDate
            // 
            tbxReqDate.AnimateReadOnly = false;
            tbxReqDate.BackgroundImageLayout = ImageLayout.None;
            tbxReqDate.CharacterCasing = CharacterCasing.Normal;
            tbxReqDate.Depth = 0;
            tbxReqDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxReqDate.HideSelection = true;
            tbxReqDate.Hint = "Date Submitted";
            tbxReqDate.LeadingIcon = null;
            tbxReqDate.Location = new Point(369, 82);
            tbxReqDate.MaxLength = 32767;
            tbxReqDate.MouseState = MaterialSkin.MouseState.OUT;
            tbxReqDate.Name = "tbxReqDate";
            tbxReqDate.PasswordChar = '\0';
            tbxReqDate.PrefixSuffixText = null;
            tbxReqDate.ReadOnly = false;
            tbxReqDate.RightToLeft = RightToLeft.No;
            tbxReqDate.SelectedText = "";
            tbxReqDate.SelectionLength = 0;
            tbxReqDate.SelectionStart = 0;
            tbxReqDate.ShortcutsEnabled = true;
            tbxReqDate.Size = new Size(222, 48);
            tbxReqDate.TabIndex = 3;
            tbxReqDate.TabStop = false;
            tbxReqDate.TextAlign = HorizontalAlignment.Left;
            tbxReqDate.TrailingIcon = null;
            tbxReqDate.UseSystemPasswordChar = false;
            // 
            // cbxStatus
            // 
            cbxStatus.AutoResize = false;
            cbxStatus.BackColor = Color.FromArgb(255, 255, 255);
            cbxStatus.Depth = 0;
            cbxStatus.DrawMode = DrawMode.OwnerDrawVariable;
            cbxStatus.DropDownHeight = 174;
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.DropDownWidth = 121;
            cbxStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Hint = "Status";
            cbxStatus.IntegralHeight = false;
            cbxStatus.ItemHeight = 43;
            cbxStatus.Items.AddRange(new object[] { "Open", "Resolved", "Under Investigation", "Dismissed" });
            cbxStatus.Location = new Point(369, 145);
            cbxStatus.MaxDropDownItems = 4;
            cbxStatus.MouseState = MaterialSkin.MouseState.OUT;
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(222, 49);
            cbxStatus.StartIndex = 0;
            cbxStatus.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(527, 490);
            btnSave.Margin = new Padding(4, 6, 4, 6);
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
            // viewRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 540);
            Controls.Add(btnSave);
            Controls.Add(cbxStatus);
            Controls.Add(tbxReqDate);
            Controls.Add(tbxReqContext);
            Controls.Add(tbxReqSubject);
            Controls.Add(tbxReqType);
            Name = "viewRequest";
            Text = "Request";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbxReqType;
        private MaterialSkin.Controls.MaterialTextBox2 tbxReqSubject;
        private TextBox tbxReqContext;
        private MaterialSkin.Controls.MaterialTextBox2 tbxReqDate;
        private MaterialSkin.Controls.MaterialComboBox cbxStatus;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}