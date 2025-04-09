namespace HoaMage
{
    partial class createAnnouncement
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
            btnSave = new MaterialSkin.Controls.MaterialButton();
            tbxRe = new MaterialSkin.Controls.MaterialTextBox2();
            tbxText = new TextBox();
            dtpDate = new DateTimePicker();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(311, 266);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbxRe
            // 
            tbxRe.AnimateReadOnly = false;
            tbxRe.BackgroundImageLayout = ImageLayout.None;
            tbxRe.CharacterCasing = CharacterCasing.Normal;
            tbxRe.Depth = 0;
            tbxRe.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxRe.HideSelection = true;
            tbxRe.Hint = "Re:";
            tbxRe.LeadingIcon = null;
            tbxRe.Location = new Point(28, 67);
            tbxRe.MaxLength = 32767;
            tbxRe.MouseState = MaterialSkin.MouseState.OUT;
            tbxRe.Name = "tbxRe";
            tbxRe.PasswordChar = '\0';
            tbxRe.PrefixSuffixText = null;
            tbxRe.ReadOnly = false;
            tbxRe.RightToLeft = RightToLeft.No;
            tbxRe.SelectedText = "";
            tbxRe.SelectionLength = 0;
            tbxRe.SelectionStart = 0;
            tbxRe.ShortcutsEnabled = true;
            tbxRe.Size = new Size(419, 48);
            tbxRe.TabIndex = 1;
            tbxRe.TabStop = false;
            tbxRe.TextAlign = HorizontalAlignment.Left;
            tbxRe.TrailingIcon = null;
            tbxRe.UseSystemPasswordChar = false;
            // 
            // tbxText
            // 
            tbxText.Location = new Point(28, 142);
            tbxText.Multiline = true;
            tbxText.Name = "tbxText";
            tbxText.Size = new Size(419, 115);
            tbxText.TabIndex = 2;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(349, 117);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(98, 23);
            dtpDate.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(383, 266);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(64, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // createAnnouncement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 311);
            Controls.Add(btnDelete);
            Controls.Add(dtpDate);
            Controls.Add(tbxText);
            Controls.Add(tbxRe);
            Controls.Add(btnSave);
            Name = "createAnnouncement";
            Text = "Announcement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialTextBox2 tbxRe;
        private TextBox tbxText;
        private DateTimePicker dtpDate;
        private MaterialSkin.Controls.MaterialButton btnDelete;
    }
}