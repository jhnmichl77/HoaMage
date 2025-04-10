namespace HoaMage
{
    partial class Payment
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
            tbxReference = new MaterialSkin.Controls.MaterialTextBox2();
            tbxBilled = new MaterialSkin.Controls.MaterialTextBox2();
            tbxDescription = new TextBox();
            tbxAmount = new MaterialSkin.Controls.MaterialTextBox2();
            tbxCardname = new MaterialSkin.Controls.MaterialTextBox2();
            tbxCardNumber = new MaterialSkin.Controls.MaterialTextBox2();
            tbxExpiry = new MaterialSkin.Controls.MaterialTextBox2();
            tbxCVV = new MaterialSkin.Controls.MaterialTextBox2();
            btnPay = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // tbxReference
            // 
            tbxReference.AnimateReadOnly = false;
            tbxReference.BackgroundImageLayout = ImageLayout.None;
            tbxReference.CharacterCasing = CharacterCasing.Normal;
            tbxReference.Depth = 0;
            tbxReference.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxReference.HideSelection = true;
            tbxReference.Hint = "Reference";
            tbxReference.LeadingIcon = null;
            tbxReference.Location = new Point(20, 85);
            tbxReference.MaxLength = 32767;
            tbxReference.MouseState = MaterialSkin.MouseState.OUT;
            tbxReference.Name = "tbxReference";
            tbxReference.PasswordChar = '\0';
            tbxReference.PrefixSuffixText = null;
            tbxReference.ReadOnly = false;
            tbxReference.RightToLeft = RightToLeft.No;
            tbxReference.SelectedText = "";
            tbxReference.SelectionLength = 0;
            tbxReference.SelectionStart = 0;
            tbxReference.ShortcutsEnabled = true;
            tbxReference.Size = new Size(109, 48);
            tbxReference.TabIndex = 0;
            tbxReference.TabStop = false;
            tbxReference.TextAlign = HorizontalAlignment.Left;
            tbxReference.TrailingIcon = null;
            tbxReference.UseSystemPasswordChar = false;
            // 
            // tbxBilled
            // 
            tbxBilled.AnimateReadOnly = false;
            tbxBilled.BackgroundImageLayout = ImageLayout.None;
            tbxBilled.CharacterCasing = CharacterCasing.Normal;
            tbxBilled.Depth = 0;
            tbxBilled.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxBilled.HideSelection = true;
            tbxBilled.Hint = "Billed To:";
            tbxBilled.LeadingIcon = null;
            tbxBilled.Location = new Point(135, 85);
            tbxBilled.MaxLength = 32767;
            tbxBilled.MouseState = MaterialSkin.MouseState.OUT;
            tbxBilled.Name = "tbxBilled";
            tbxBilled.PasswordChar = '\0';
            tbxBilled.PrefixSuffixText = null;
            tbxBilled.ReadOnly = false;
            tbxBilled.RightToLeft = RightToLeft.No;
            tbxBilled.SelectedText = "";
            tbxBilled.SelectionLength = 0;
            tbxBilled.SelectionStart = 0;
            tbxBilled.ShortcutsEnabled = true;
            tbxBilled.Size = new Size(216, 48);
            tbxBilled.TabIndex = 1;
            tbxBilled.TabStop = false;
            tbxBilled.TextAlign = HorizontalAlignment.Left;
            tbxBilled.TrailingIcon = null;
            tbxBilled.UseSystemPasswordChar = false;
            // 
            // tbxDescription
            // 
            tbxDescription.Location = new Point(20, 154);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(331, 85);
            tbxDescription.TabIndex = 2;
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
            tbxAmount.Location = new Point(20, 255);
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
            tbxAmount.Size = new Size(156, 48);
            tbxAmount.TabIndex = 3;
            tbxAmount.TabStop = false;
            tbxAmount.TextAlign = HorizontalAlignment.Left;
            tbxAmount.TrailingIcon = null;
            tbxAmount.UseSystemPasswordChar = false;
            // 
            // tbxCardname
            // 
            tbxCardname.AnimateReadOnly = false;
            tbxCardname.BackgroundImageLayout = ImageLayout.None;
            tbxCardname.CharacterCasing = CharacterCasing.Normal;
            tbxCardname.Depth = 0;
            tbxCardname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxCardname.HideSelection = true;
            tbxCardname.Hint = "Card Name";
            tbxCardname.LeadingIcon = null;
            tbxCardname.Location = new Point(52, 332);
            tbxCardname.MaxLength = 32767;
            tbxCardname.MouseState = MaterialSkin.MouseState.OUT;
            tbxCardname.Name = "tbxCardname";
            tbxCardname.PasswordChar = '\0';
            tbxCardname.PrefixSuffixText = null;
            tbxCardname.ReadOnly = false;
            tbxCardname.RightToLeft = RightToLeft.No;
            tbxCardname.SelectedText = "";
            tbxCardname.SelectionLength = 0;
            tbxCardname.SelectionStart = 0;
            tbxCardname.ShortcutsEnabled = true;
            tbxCardname.Size = new Size(266, 48);
            tbxCardname.TabIndex = 4;
            tbxCardname.TabStop = false;
            tbxCardname.TextAlign = HorizontalAlignment.Left;
            tbxCardname.TrailingIcon = null;
            tbxCardname.UseSystemPasswordChar = false;
            // 
            // tbxCardNumber
            // 
            tbxCardNumber.AnimateReadOnly = false;
            tbxCardNumber.BackgroundImageLayout = ImageLayout.None;
            tbxCardNumber.CharacterCasing = CharacterCasing.Normal;
            tbxCardNumber.Depth = 0;
            tbxCardNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxCardNumber.HideSelection = true;
            tbxCardNumber.Hint = "Card Number";
            tbxCardNumber.LeadingIcon = null;
            tbxCardNumber.Location = new Point(52, 386);
            tbxCardNumber.MaxLength = 32767;
            tbxCardNumber.MouseState = MaterialSkin.MouseState.OUT;
            tbxCardNumber.Name = "tbxCardNumber";
            tbxCardNumber.PasswordChar = '\0';
            tbxCardNumber.PrefixSuffixText = null;
            tbxCardNumber.ReadOnly = false;
            tbxCardNumber.RightToLeft = RightToLeft.No;
            tbxCardNumber.SelectedText = "";
            tbxCardNumber.SelectionLength = 0;
            tbxCardNumber.SelectionStart = 0;
            tbxCardNumber.ShortcutsEnabled = true;
            tbxCardNumber.Size = new Size(266, 48);
            tbxCardNumber.TabIndex = 5;
            tbxCardNumber.TabStop = false;
            tbxCardNumber.TextAlign = HorizontalAlignment.Left;
            tbxCardNumber.TrailingIcon = null;
            tbxCardNumber.UseSystemPasswordChar = false;
            // 
            // tbxExpiry
            // 
            tbxExpiry.AnimateReadOnly = false;
            tbxExpiry.BackgroundImageLayout = ImageLayout.None;
            tbxExpiry.CharacterCasing = CharacterCasing.Normal;
            tbxExpiry.Depth = 0;
            tbxExpiry.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxExpiry.HideSelection = true;
            tbxExpiry.Hint = "Expiry";
            tbxExpiry.LeadingIcon = null;
            tbxExpiry.Location = new Point(52, 450);
            tbxExpiry.MaxLength = 32767;
            tbxExpiry.MouseState = MaterialSkin.MouseState.OUT;
            tbxExpiry.Name = "tbxExpiry";
            tbxExpiry.PasswordChar = '\0';
            tbxExpiry.PrefixSuffixText = null;
            tbxExpiry.ReadOnly = false;
            tbxExpiry.RightToLeft = RightToLeft.No;
            tbxExpiry.SelectedText = "";
            tbxExpiry.SelectionLength = 0;
            tbxExpiry.SelectionStart = 0;
            tbxExpiry.ShortcutsEnabled = true;
            tbxExpiry.Size = new Size(109, 48);
            tbxExpiry.TabIndex = 6;
            tbxExpiry.TabStop = false;
            tbxExpiry.TextAlign = HorizontalAlignment.Left;
            tbxExpiry.TrailingIcon = null;
            tbxExpiry.UseSystemPasswordChar = false;
            // 
            // tbxCVV
            // 
            tbxCVV.AnimateReadOnly = false;
            tbxCVV.BackgroundImageLayout = ImageLayout.None;
            tbxCVV.CharacterCasing = CharacterCasing.Normal;
            tbxCVV.Depth = 0;
            tbxCVV.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxCVV.HideSelection = true;
            tbxCVV.Hint = "CVV";
            tbxCVV.LeadingIcon = null;
            tbxCVV.Location = new Point(209, 450);
            tbxCVV.MaxLength = 32767;
            tbxCVV.MouseState = MaterialSkin.MouseState.OUT;
            tbxCVV.Name = "tbxCVV";
            tbxCVV.PasswordChar = '\0';
            tbxCVV.PrefixSuffixText = null;
            tbxCVV.ReadOnly = false;
            tbxCVV.RightToLeft = RightToLeft.No;
            tbxCVV.SelectedText = "";
            tbxCVV.SelectionLength = 0;
            tbxCVV.SelectionStart = 0;
            tbxCVV.ShortcutsEnabled = true;
            tbxCVV.Size = new Size(109, 48);
            tbxCVV.TabIndex = 7;
            tbxCVV.TabStop = false;
            tbxCVV.TextAlign = HorizontalAlignment.Left;
            tbxCVV.TrailingIcon = null;
            tbxCVV.UseSystemPasswordChar = false;
            // 
            // btnPay
            // 
            btnPay.AutoSize = false;
            btnPay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPay.Depth = 0;
            btnPay.HighEmphasis = true;
            btnPay.Icon = null;
            btnPay.Location = new Point(52, 514);
            btnPay.Margin = new Padding(4, 6, 4, 6);
            btnPay.MouseState = MaterialSkin.MouseState.HOVER;
            btnPay.Name = "btnPay";
            btnPay.NoAccentTextColor = Color.Empty;
            btnPay.Size = new Size(266, 36);
            btnPay.TabIndex = 8;
            btnPay.Text = "Pay";
            btnPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPay.UseAccentColor = false;
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 555);
            Controls.Add(btnPay);
            Controls.Add(tbxCVV);
            Controls.Add(tbxExpiry);
            Controls.Add(tbxCardNumber);
            Controls.Add(tbxCardname);
            Controls.Add(tbxAmount);
            Controls.Add(tbxDescription);
            Controls.Add(tbxBilled);
            Controls.Add(tbxReference);
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbxReference;
        private MaterialSkin.Controls.MaterialTextBox2 tbxBilled;
        private TextBox tbxDescription;
        private MaterialSkin.Controls.MaterialTextBox2 tbxAmount;
        private MaterialSkin.Controls.MaterialTextBox2 tbxCardname;
        private MaterialSkin.Controls.MaterialTextBox2 tbxCardNumber;
        private MaterialSkin.Controls.MaterialTextBox2 tbxExpiry;
        private MaterialSkin.Controls.MaterialTextBox2 tbxCVV;
        private MaterialSkin.Controls.MaterialButton btnPay;
    }
}