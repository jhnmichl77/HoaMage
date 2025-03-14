namespace HoaMage
{
    partial class Pay
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
            rbtCash = new RadioButton();
            rbtCard = new RadioButton();
            tbxName = new MaterialSkin.Controls.MaterialTextBox2();
            cbxType = new MaterialSkin.Controls.MaterialComboBox();
            rbtWallet = new RadioButton();
            panel1 = new Panel();
            btnPay = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            tbxAmount = new MaterialSkin.Controls.MaterialTextBox2();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rbtCash
            // 
            rbtCash.AutoSize = true;
            rbtCash.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtCash.Location = new Point(23, 121);
            rbtCash.Name = "rbtCash";
            rbtCash.Size = new Size(64, 24);
            rbtCash.TabIndex = 0;
            rbtCash.TabStop = true;
            rbtCash.Text = "Cash";
            rbtCash.UseVisualStyleBackColor = true;
            // 
            // rbtCard
            // 
            rbtCard.AutoSize = true;
            rbtCard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtCard.Location = new Point(93, 121);
            rbtCard.Name = "rbtCard";
            rbtCard.Size = new Size(61, 24);
            rbtCard.TabIndex = 1;
            rbtCard.TabStop = true;
            rbtCard.Text = "Card";
            rbtCard.UseVisualStyleBackColor = true;
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
            tbxName.Location = new Point(23, 12);
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
            tbxName.Size = new Size(308, 48);
            tbxName.TabIndex = 2;
            tbxName.TabStop = false;
            tbxName.TextAlign = HorizontalAlignment.Left;
            tbxName.TrailingIcon = null;
            tbxName.UseSystemPasswordChar = false;
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
            cbxType.IntegralHeight = false;
            cbxType.ItemHeight = 43;
            cbxType.Items.AddRange(new object[] { "Monthly Due", "Fines", "Donation", "Others" });
            cbxType.Location = new Point(23, 66);
            cbxType.MaxDropDownItems = 4;
            cbxType.MouseState = MaterialSkin.MouseState.OUT;
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(192, 49);
            cbxType.StartIndex = 0;
            cbxType.TabIndex = 3;
            // 
            // rbtWallet
            // 
            rbtWallet.AutoSize = true;
            rbtWallet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtWallet.Location = new Point(160, 121);
            rbtWallet.Name = "rbtWallet";
            rbtWallet.Size = new Size(80, 24);
            rbtWallet.TabIndex = 4;
            rbtWallet.TabStop = true;
            rbtWallet.Text = "eWallet";
            rbtWallet.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(materialCard1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 252);
            panel1.TabIndex = 5;
            // 
            // btnPay
            // 
            btnPay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPay.Depth = 0;
            btnPay.HighEmphasis = true;
            btnPay.Icon = null;
            btnPay.Location = new Point(276, 210);
            btnPay.Margin = new Padding(4, 6, 4, 6);
            btnPay.MouseState = MaterialSkin.MouseState.HOVER;
            btnPay.Name = "btnPay";
            btnPay.NoAccentTextColor = Color.Empty;
            btnPay.Size = new Size(64, 36);
            btnPay.TabIndex = 1;
            btnPay.Text = "Pay";
            btnPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPay.UseAccentColor = false;
            btnPay.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(326, 176);
            materialCard1.TabIndex = 0;
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
            tbxAmount.Location = new Point(23, 145);
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
            tbxAmount.Size = new Size(308, 48);
            tbxAmount.TabIndex = 6;
            tbxAmount.TabStop = false;
            tbxAmount.TextAlign = HorizontalAlignment.Left;
            tbxAmount.TrailingIcon = null;
            tbxAmount.UseSystemPasswordChar = false;
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 451);
            Controls.Add(tbxAmount);
            Controls.Add(panel1);
            Controls.Add(rbtWallet);
            Controls.Add(cbxType);
            Controls.Add(tbxName);
            Controls.Add(rbtCard);
            Controls.Add(rbtCash);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Pay";
            Text = "Payment Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtCash;
        private RadioButton rbtCard;
        private MaterialSkin.Controls.MaterialTextBox2 tbxName;
        private MaterialSkin.Controls.MaterialComboBox cbxType;
        private RadioButton rbtWallet;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnPay;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 tbxAmount;
    }
}