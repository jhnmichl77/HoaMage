namespace HoaMage
{
    partial class vPayment
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pbxProof = new PictureBox();
            pbxQR = new PictureBox();
            btnPay = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pbxProof).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxQR).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(100, 295);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(179, 19);
            materialLabel1.TabIndex = 15;
            materialLabel1.Text = "Upload Proof of payment";
            materialLabel1.Click += materialLabel1_Click;
            // 
            // pbxProof
            // 
            pbxProof.Location = new Point(83, 317);
            pbxProof.Name = "pbxProof";
            pbxProof.Size = new Size(210, 188);
            pbxProof.SizeMode = PictureBoxSizeMode.Zoom;
            pbxProof.TabIndex = 14;
            pbxProof.TabStop = false;
            // 
            // pbxQR
            // 
            pbxQR.Location = new Point(73, 67);
            pbxQR.Name = "pbxQR";
            pbxQR.Size = new Size(230, 216);
            pbxQR.SizeMode = PictureBoxSizeMode.Zoom;
            pbxQR.TabIndex = 13;
            pbxQR.TabStop = false;
            // 
            // btnPay
            // 
            btnPay.AutoSize = false;
            btnPay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPay.Depth = 0;
            btnPay.HighEmphasis = true;
            btnPay.Icon = null;
            btnPay.Location = new Point(47, 514);
            btnPay.Margin = new Padding(4, 6, 4, 6);
            btnPay.MouseState = MaterialSkin.MouseState.HOVER;
            btnPay.Name = "btnPay";
            btnPay.NoAccentTextColor = Color.Empty;
            btnPay.Size = new Size(266, 36);
            btnPay.TabIndex = 12;
            btnPay.Text = "Pay";
            btnPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPay.UseAccentColor = false;
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // vPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 555);
            Controls.Add(materialLabel1);
            Controls.Add(pbxProof);
            Controls.Add(pbxQR);
            Controls.Add(btnPay);
            Name = "vPayment";
            Text = "vPayment";
            ((System.ComponentModel.ISupportInitialize)pbxProof).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox pbxProof;
        private PictureBox pbxQR;
        private MaterialSkin.Controls.MaterialButton btnPay;
    }
}