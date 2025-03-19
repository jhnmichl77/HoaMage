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
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tbpHome = new TabPage();
            tbpProfile = new TabPage();
            panel1 = new Panel();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            tbxSearch = new TextBox();
            label1 = new Label();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            dgvDisplay = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAccounts = new MaterialSkin.Controls.MaterialButton();
            btnMembers = new MaterialSkin.Controls.MaterialButton();
            btnProperties = new MaterialSkin.Controls.MaterialButton();
            btnVehicles = new MaterialSkin.Controls.MaterialButton();
            btnOccupants = new MaterialSkin.Controls.MaterialButton();
            tbpRequest = new TabPage();
            tbpPayment = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tbpProfile.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tbpHome);
            materialTabControl1.Controls.Add(tbpProfile);
            materialTabControl1.Controls.Add(tbpRequest);
            materialTabControl1.Controls.Add(tbpPayment);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(871, 532);
            materialTabControl1.TabIndex = 0;
            // 
            // tbpHome
            // 
            tbpHome.ImageKey = "Home.png";
            tbpHome.Location = new Point(4, 39);
            tbpHome.Name = "tbpHome";
            tbpHome.Padding = new Padding(3);
            tbpHome.Size = new Size(863, 489);
            tbpHome.TabIndex = 1;
            tbpHome.Text = "Home";
            tbpHome.UseVisualStyleBackColor = true;
            // 
            // tbpProfile
            // 
            tbpProfile.Controls.Add(panel1);
            tbpProfile.Controls.Add(flowLayoutPanel1);
            tbpProfile.ImageKey = "Manage.png";
            tbpProfile.Location = new Point(4, 39);
            tbpProfile.Name = "tbpProfile";
            tbpProfile.Padding = new Padding(3);
            tbpProfile.Size = new Size(863, 489);
            tbpProfile.TabIndex = 0;
            tbpProfile.Text = "Profile";
            tbpProfile.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(tbxSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(dgvDisplay);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 441);
            panel1.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(536, 405);
            btnSearch.Margin = new Padding(4, 6, 4, 6);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(78, 36);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbxSearch.BorderStyle = BorderStyle.FixedSingle;
            tbxSearch.Location = new Point(74, 410);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(446, 23);
            tbxSearch.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.Location = new Point(3, 412);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 3;
            label1.Text = "Search:";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(780, 405);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(708, 405);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvDisplay
            // 
            dgvDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplay.Location = new Point(0, 0);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.ReadOnly = true;
            dgvDisplay.Size = new Size(857, 403);
            dgvDisplay.TabIndex = 0;
            dgvDisplay.CellEndEdit += dgvDisplay_CellEndEdit;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(36, 52, 60);
            flowLayoutPanel1.Controls.Add(btnAccounts);
            flowLayoutPanel1.Controls.Add(btnMembers);
            flowLayoutPanel1.Controls.Add(btnProperties);
            flowLayoutPanel1.Controls.Add(btnVehicles);
            flowLayoutPanel1.Controls.Add(btnOccupants);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(857, 42);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnAccounts
            // 
            btnAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAccounts.AutoSize = false;
            btnAccounts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAccounts.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAccounts.Depth = 0;
            btnAccounts.HighEmphasis = true;
            btnAccounts.Icon = null;
            btnAccounts.Location = new Point(4, 6);
            btnAccounts.Margin = new Padding(4, 6, 4, 6);
            btnAccounts.MouseState = MaterialSkin.MouseState.HOVER;
            btnAccounts.Name = "btnAccounts";
            btnAccounts.NoAccentTextColor = Color.Empty;
            btnAccounts.Size = new Size(163, 36);
            btnAccounts.TabIndex = 4;
            btnAccounts.Text = "Accounts";
            btnAccounts.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAccounts.UseAccentColor = false;
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // btnMembers
            // 
            btnMembers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMembers.AutoSize = false;
            btnMembers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMembers.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnMembers.Depth = 0;
            btnMembers.HighEmphasis = true;
            btnMembers.Icon = null;
            btnMembers.Location = new Point(175, 6);
            btnMembers.Margin = new Padding(4, 6, 4, 6);
            btnMembers.MouseState = MaterialSkin.MouseState.HOVER;
            btnMembers.Name = "btnMembers";
            btnMembers.NoAccentTextColor = Color.Empty;
            btnMembers.Size = new Size(163, 36);
            btnMembers.TabIndex = 0;
            btnMembers.Text = "Members";
            btnMembers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnMembers.UseAccentColor = false;
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnProperties
            // 
            btnProperties.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProperties.AutoSize = false;
            btnProperties.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProperties.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProperties.Depth = 0;
            btnProperties.HighEmphasis = true;
            btnProperties.Icon = null;
            btnProperties.Location = new Point(346, 6);
            btnProperties.Margin = new Padding(4, 6, 4, 6);
            btnProperties.MouseState = MaterialSkin.MouseState.HOVER;
            btnProperties.Name = "btnProperties";
            btnProperties.NoAccentTextColor = Color.Empty;
            btnProperties.Size = new Size(163, 36);
            btnProperties.TabIndex = 1;
            btnProperties.Text = "Properties";
            btnProperties.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProperties.UseAccentColor = false;
            btnProperties.UseVisualStyleBackColor = true;
            btnProperties.Click += btnProperties_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVehicles.AutoSize = false;
            btnVehicles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVehicles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVehicles.Depth = 0;
            btnVehicles.HighEmphasis = true;
            btnVehicles.Icon = null;
            btnVehicles.Location = new Point(517, 6);
            btnVehicles.Margin = new Padding(4, 6, 4, 6);
            btnVehicles.MouseState = MaterialSkin.MouseState.HOVER;
            btnVehicles.Name = "btnVehicles";
            btnVehicles.NoAccentTextColor = Color.Empty;
            btnVehicles.Size = new Size(163, 36);
            btnVehicles.TabIndex = 2;
            btnVehicles.Text = "Vehicles";
            btnVehicles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVehicles.UseAccentColor = false;
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnOccupants
            // 
            btnOccupants.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOccupants.AutoSize = false;
            btnOccupants.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOccupants.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOccupants.Depth = 0;
            btnOccupants.HighEmphasis = true;
            btnOccupants.Icon = null;
            btnOccupants.Location = new Point(688, 6);
            btnOccupants.Margin = new Padding(4, 6, 4, 6);
            btnOccupants.MouseState = MaterialSkin.MouseState.HOVER;
            btnOccupants.Name = "btnOccupants";
            btnOccupants.NoAccentTextColor = Color.Empty;
            btnOccupants.Size = new Size(163, 36);
            btnOccupants.TabIndex = 3;
            btnOccupants.Text = "Occupants";
            btnOccupants.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOccupants.UseAccentColor = false;
            btnOccupants.UseVisualStyleBackColor = true;
            btnOccupants.Click += btnOccupants_Click;
            // 
            // tbpRequest
            // 
            tbpRequest.ImageKey = "Request.png";
            tbpRequest.Location = new Point(4, 39);
            tbpRequest.Name = "tbpRequest";
            tbpRequest.Padding = new Padding(3);
            tbpRequest.Size = new Size(863, 489);
            tbpRequest.TabIndex = 2;
            tbpRequest.Text = "Request";
            tbpRequest.UseVisualStyleBackColor = true;
            // 
            // tbpPayment
            // 
            tbpPayment.ImageKey = "Payment.png";
            tbpPayment.Location = new Point(4, 39);
            tbpPayment.Name = "tbpPayment";
            tbpPayment.Padding = new Padding(3);
            tbpPayment.Size = new Size(863, 489);
            tbpPayment.TabIndex = 3;
            tbpPayment.Text = "Payment";
            tbpPayment.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Request.png");
            imageList1.Images.SetKeyName(1, "Payment.png");
            imageList1.Images.SetKeyName(2, "Manage.png");
            imageList1.Images.SetKeyName(3, "Home.png");
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 599);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            MinimumSize = new Size(877, 599);
            Name = "Dashboard";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HoaMage";
            materialTabControl1.ResumeLayout(false);
            tbpProfile.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tbpProfile;
        private TabPage tbpHome;
        private TabPage tbpRequest;
        private TabPage tbpPayment;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnMembers;
        private MaterialSkin.Controls.MaterialButton btnProperties;
        private MaterialSkin.Controls.MaterialButton btnVehicles;
        private MaterialSkin.Controls.MaterialButton btnOccupants;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private DataGridView dgvDisplay;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private TextBox tbxSearch;
        private Label label1;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btnAccounts;
    }
}