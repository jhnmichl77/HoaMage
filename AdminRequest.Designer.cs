namespace HoaMage
{
    partial class AdminRequest
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
            tbxSearch = new MaterialSkin.Controls.MaterialTextBox2();
            dgvRequestDisplay = new DataGridView();
            btnPayment = new Button();
            btnComplaint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRequestDisplay).BeginInit();
            SuspendLayout();
            // 
            // tbxSearch
            // 
            tbxSearch.AnimateReadOnly = false;
            tbxSearch.BackgroundImageLayout = ImageLayout.None;
            tbxSearch.CharacterCasing = CharacterCasing.Normal;
            tbxSearch.Depth = 0;
            tbxSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxSearch.HideSelection = true;
            tbxSearch.Hint = "Search";
            tbxSearch.LeadingIcon = null;
            tbxSearch.Location = new Point(3, 3);
            tbxSearch.MaxLength = 32767;
            tbxSearch.MouseState = MaterialSkin.MouseState.OUT;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PasswordChar = '\0';
            tbxSearch.PrefixSuffixText = null;
            tbxSearch.ReadOnly = false;
            tbxSearch.RightToLeft = RightToLeft.No;
            tbxSearch.SelectedText = "";
            tbxSearch.SelectionLength = 0;
            tbxSearch.SelectionStart = 0;
            tbxSearch.ShortcutsEnabled = true;
            tbxSearch.Size = new Size(354, 48);
            tbxSearch.TabIndex = 1;
            tbxSearch.TabStop = false;
            tbxSearch.TextAlign = HorizontalAlignment.Left;
            tbxSearch.TrailingIcon = null;
            tbxSearch.UseSystemPasswordChar = false;
            // 
            // dgvRequestDisplay
            // 
            dgvRequestDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequestDisplay.Location = new Point(3, 73);
            dgvRequestDisplay.Name = "dgvRequestDisplay";
            dgvRequestDisplay.Size = new Size(721, 209);
            dgvRequestDisplay.TabIndex = 2;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(551, 299);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(173, 23);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "Send Payment Reminder";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnComplaint
            // 
            btnComplaint.Location = new Point(551, 337);
            btnComplaint.Name = "btnComplaint";
            btnComplaint.Size = new Size(173, 23);
            btnComplaint.TabIndex = 4;
            btnComplaint.Text = "Send Complain Notice";
            btnComplaint.UseVisualStyleBackColor = true;
            // 
            // AdminRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnComplaint);
            Controls.Add(btnPayment);
            Controls.Add(dgvRequestDisplay);
            Controls.Add(tbxSearch);
            Name = "AdminRequest";
            Size = new Size(727, 445);
            ((System.ComponentModel.ISupportInitialize)dgvRequestDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbxSearch;
        private DataGridView dgvRequestDisplay;
        private Button btnPayment;
        private Button btnComplaint;
    }
}
