namespace HoaMage
{
    partial class AdminPayments
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
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Search";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(2, 2);
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
            materialTextBox21.Size = new Size(724, 48);
            materialTextBox21.TabIndex = 1;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // AdminPayments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialTextBox21);
            Name = "AdminPayments";
            Size = new Size(727, 445);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
    }
}
