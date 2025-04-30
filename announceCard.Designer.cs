namespace HoaMage
{
    partial class announceCard
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            tbxDate = new TextBox();
            tbxContext = new TextBox();
            lblTitle = new Label();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(tbxDate);
            materialCard1.Controls.Add(tbxContext);
            materialCard1.Controls.Add(lblTitle);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(280, 177);
            materialCard1.TabIndex = 0;
            // 
            // tbxDate
            // 
            tbxDate.BackColor = SystemColors.ControlLightLight;
            tbxDate.BorderStyle = BorderStyle.None;
            tbxDate.Location = new Point(17, 32);
            tbxDate.Name = "tbxDate";
            tbxDate.ReadOnly = true;
            tbxDate.Size = new Size(245, 16);
            tbxDate.TabIndex = 2;
            tbxDate.TextChanged += tbxDate_TextChanged;
            // 
            // tbxContext
            // 
            tbxContext.BackColor = SystemColors.ControlLightLight;
            tbxContext.BorderStyle = BorderStyle.None;
            tbxContext.Location = new Point(0, 67);
            tbxContext.Multiline = true;
            tbxContext.Name = "tbxContext";
            tbxContext.ReadOnly = true;
            tbxContext.ScrollBars = ScrollBars.Vertical;
            tbxContext.Size = new Size(280, 107);
            tbxContext.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(27, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // announceCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "announceCard";
            Size = new Size(280, 177);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private TextBox tbxDate;
        private TextBox tbxContext;
        private Label lblTitle;
    }
}
