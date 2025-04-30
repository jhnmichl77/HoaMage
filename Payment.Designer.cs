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
            btnPay = new MaterialSkin.Controls.MaterialButton();
            pbxQR = new PictureBox();
            pictureBox1 = new PictureBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pbxQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // pbxQR
            // 
            pbxQR.Location = new Point(63, 67);
            pbxQR.Name = "pbxQR";
            pbxQR.Size = new Size(230, 216);
            pbxQR.SizeMode = PictureBoxSizeMode.Zoom;
            pbxQR.TabIndex = 9;
            pbxQR.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(73, 317);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(90, 295);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(179, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Upload Proof of payment";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 555);
            Controls.Add(materialLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(pbxQR);
            Controls.Add(btnPay);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)pbxQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnPay;
        private PictureBox pbxQR;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}