namespace HoaMage
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox1 = new PictureBox();
            sidebarContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            btnMenu = new Button();
            panel2 = new Panel();
            tbxID = new TextBox();
            panel3 = new Panel();
            btnHome = new Button();
            panel4 = new Panel();
            btnManage = new Button();
            panel5 = new Panel();
            button1 = new Button();
            panel6 = new Panel();
            btnRequest = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            btnLogout = new Button();
            pnlTitlebar = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pnlDisplay = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebarContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._85d55f04_b184_4c4d_b8af_b0aa7631c8bb_removalai_preview;
            pictureBox1.Location = new Point(212, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(0, 119, 182);
            sidebarContainer.Controls.Add(panel1);
            sidebarContainer.Controls.Add(panel2);
            sidebarContainer.Controls.Add(panel3);
            sidebarContainer.Controls.Add(panel4);
            sidebarContainer.Controls.Add(panel5);
            sidebarContainer.Controls.Add(panel6);
            sidebarContainer.Controls.Add(panel7);
            sidebarContainer.Controls.Add(panel8);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 0);
            sidebarContainer.MaximumSize = new Size(210, 521);
            sidebarContainer.MinimumSize = new Size(70, 521);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(210, 521);
            sidebarContainer.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMenu);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 67);
            panel1.TabIndex = 8;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Image = Properties.Resources._9f9c30b3_fafd_460c_b5cb_f5a787db96d8_removalai_preview;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(3, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(200, 60);
            btnMenu.TabIndex = 9;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tbxID);
            panel2.Location = new Point(3, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 35);
            panel2.TabIndex = 8;
            // 
            // tbxID
            // 
            tbxID.Enabled = false;
            tbxID.Location = new Point(0, 3);
            tbxID.Name = "tbxID";
            tbxID.ReadOnly = true;
            tbxID.Size = new Size(203, 23);
            tbxID.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnHome);
            panel3.Location = new Point(3, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 67);
            panel3.TabIndex = 10;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Image = Properties.Resources._3c7a66b1_ecd0_4ba6_b17c_6698159ea704_removalai_preview;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 60);
            btnHome.TabIndex = 9;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnManage);
            panel4.Location = new Point(3, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 67);
            panel4.TabIndex = 11;
            // 
            // btnManage
            // 
            btnManage.Cursor = Cursors.Hand;
            btnManage.FlatStyle = FlatStyle.Popup;
            btnManage.Image = (Image)resources.GetObject("btnManage.Image");
            btnManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnManage.Location = new Point(3, 4);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(200, 60);
            btnManage.TabIndex = 9;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Location = new Point(3, 263);
            panel5.Name = "panel5";
            panel5.Size = new Size(208, 67);
            panel5.TabIndex = 12;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(200, 60);
            button1.TabIndex = 9;
            button1.Text = "Payments";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnRequest);
            panel6.Location = new Point(3, 336);
            panel6.Name = "panel6";
            panel6.Size = new Size(208, 67);
            panel6.TabIndex = 13;
            // 
            // btnRequest
            // 
            btnRequest.Cursor = Cursors.Hand;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Image = (Image)resources.GetObject("btnRequest.Image");
            btnRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequest.Location = new Point(3, 4);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(200, 60);
            btnRequest.TabIndex = 9;
            btnRequest.Text = "Request";
            btnRequest.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 409);
            panel7.Name = "panel7";
            panel7.Size = new Size(203, 31);
            panel7.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnLogout);
            panel8.Location = new Point(3, 446);
            panel8.Name = "panel8";
            panel8.Size = new Size(208, 67);
            panel8.TabIndex = 14;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(202, 60);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // pnlTitlebar
            // 
            pnlTitlebar.Dock = DockStyle.Top;
            pnlTitlebar.Location = new Point(210, 0);
            pnlTitlebar.Name = "pnlTitlebar";
            pnlTitlebar.Size = new Size(734, 70);
            pnlTitlebar.TabIndex = 8;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // pnlDisplay
            // 
            pnlDisplay.Location = new Point(217, 76);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(727, 445);
            pnlDisplay.TabIndex = 9;
            // 
            // HomeownerDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 521);
            Controls.Add(pnlDisplay);
            Controls.Add(pictureBox1);
            Controls.Add(pnlTitlebar);
            Controls.Add(sidebarContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeownerDashBoard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebarContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel sidebarContainer;
        private Panel panel1;
        private Button btnMenu;
        private Panel panel2;
        private Panel panel3;
        private Button btnHome;
        private Panel panel4;
        private Button btnManage;
        private Panel panel5;
        private Button button1;
        private Panel panel6;
        private Button btnRequest;
        private Panel panel7;
        private Panel panel8;
        private Button btnLogout;
        private Panel pnlTitlebar;
        private System.Windows.Forms.Timer sidebarTimer;
        private TextBox tbxID;
        private Panel pnlDisplay;
    }
}