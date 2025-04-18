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
            flowLayoutPanel2 = new FlowLayoutPanel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
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
            materialCard9 = new MaterialSkin.Controls.MaterialCard();
            materialCard8 = new MaterialSkin.Controls.MaterialCard();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            btnView = new MaterialSkin.Controls.MaterialButton();
            dgvRequest = new DataGridView();
            tbpPayment = new TabPage();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label2 = new Label();
            dgvTransactions = new DataGridView();
            tbpAnnouncement = new TabPage();
            btnDeleteAnnouncement = new MaterialSkin.Controls.MaterialButton();
            btnCreate = new MaterialSkin.Controls.MaterialButton();
            dgvAnnouncements = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colRe = new DataGridViewTextBoxColumn();
            colContext = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            tbpRulesEnforcement = new TabPage();
            btnIssue = new LinkLabel();
            btnDeleteViolation = new LinkLabel();
            btnNewViolation = new LinkLabel();
            label3 = new Label();
            dgvViolations = new DataGridView();
            colRuleID = new DataGridViewTextBoxColumn();
            colRuleName = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colPenalty = new DataGridViewTextBoxColumn();
            tbpBills = new TabPage();
            dgvPayables = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnDelBill = new MaterialSkin.Controls.MaterialButton();
            btnBill = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            materialTabControl1.SuspendLayout();
            tbpHome.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tbpProfile.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tbpRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequest).BeginInit();
            tbpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            tbpAnnouncement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnnouncements).BeginInit();
            tbpRulesEnforcement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViolations).BeginInit();
            tbpBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayables).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tbpHome);
            materialTabControl1.Controls.Add(tbpProfile);
            materialTabControl1.Controls.Add(tbpRequest);
            materialTabControl1.Controls.Add(tbpPayment);
            materialTabControl1.Controls.Add(tbpAnnouncement);
            materialTabControl1.Controls.Add(tbpRulesEnforcement);
            materialTabControl1.Controls.Add(tbpBills);
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
            tbpHome.Controls.Add(flowLayoutPanel2);
            tbpHome.ImageKey = "Home.png";
            tbpHome.Location = new Point(4, 39);
            tbpHome.Name = "tbpHome";
            tbpHome.Padding = new Padding(3);
            tbpHome.Size = new Size(863, 489);
            tbpHome.TabIndex = 1;
            tbpHome.Text = "Home";
            tbpHome.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(materialCard3);
            flowLayoutPanel2.Controls.Add(materialCard6);
            flowLayoutPanel2.Controls.Add(materialCard5);
            flowLayoutPanel2.Controls.Add(materialCard4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(857, 483);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(14, 14);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(186, 93);
            materialCard3.TabIndex = 0;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(228, 14);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(186, 93);
            materialCard6.TabIndex = 1;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(442, 14);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(186, 93);
            materialCard5.TabIndex = 1;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(656, 14);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(186, 93);
            materialCard4.TabIndex = 1;
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
            tbpRequest.Controls.Add(materialCard9);
            tbpRequest.Controls.Add(materialCard8);
            tbpRequest.Controls.Add(materialCard7);
            tbpRequest.Controls.Add(btnView);
            tbpRequest.Controls.Add(dgvRequest);
            tbpRequest.ImageKey = "Request.png";
            tbpRequest.Location = new Point(4, 39);
            tbpRequest.Name = "tbpRequest";
            tbpRequest.Padding = new Padding(3);
            tbpRequest.Size = new Size(863, 489);
            tbpRequest.TabIndex = 2;
            tbpRequest.Text = "Request";
            tbpRequest.UseVisualStyleBackColor = true;
            // 
            // materialCard9
            // 
            materialCard9.BackColor = Color.FromArgb(255, 255, 255);
            materialCard9.Depth = 0;
            materialCard9.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard9.Location = new Point(460, 372);
            materialCard9.Margin = new Padding(14);
            materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard9.Name = "materialCard9";
            materialCard9.Padding = new Padding(14);
            materialCard9.Size = new Size(209, 100);
            materialCard9.TabIndex = 5;
            // 
            // materialCard8
            // 
            materialCard8.BackColor = Color.FromArgb(255, 255, 255);
            materialCard8.Depth = 0;
            materialCard8.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard8.Location = new Point(234, 372);
            materialCard8.Margin = new Padding(14);
            materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard8.Name = "materialCard8";
            materialCard8.Padding = new Padding(14);
            materialCard8.Size = new Size(209, 100);
            materialCard8.TabIndex = 4;
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Depth = 0;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(18, 372);
            materialCard7.Margin = new Padding(14);
            materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(14);
            materialCard7.Size = new Size(200, 100);
            materialCard7.TabIndex = 3;
            // 
            // btnView
            // 
            btnView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnView.Depth = 0;
            btnView.HighEmphasis = true;
            btnView.Icon = null;
            btnView.Location = new Point(685, 372);
            btnView.Margin = new Padding(4, 6, 4, 6);
            btnView.MouseState = MaterialSkin.MouseState.HOVER;
            btnView.Name = "btnView";
            btnView.NoAccentTextColor = Color.Empty;
            btnView.Size = new Size(64, 36);
            btnView.TabIndex = 2;
            btnView.Text = "View";
            btnView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnView.UseAccentColor = false;
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // dgvRequest
            // 
            dgvRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequest.Location = new Point(18, 17);
            dgvRequest.Name = "dgvRequest";
            dgvRequest.ReadOnly = true;
            dgvRequest.Size = new Size(827, 341);
            dgvRequest.TabIndex = 0;
            // 
            // tbpPayment
            // 
            tbpPayment.Controls.Add(materialCard2);
            tbpPayment.Controls.Add(materialCard1);
            tbpPayment.Controls.Add(label2);
            tbpPayment.Controls.Add(dgvTransactions);
            tbpPayment.ImageKey = "Payment.png";
            tbpPayment.Location = new Point(4, 39);
            tbpPayment.Name = "tbpPayment";
            tbpPayment.Padding = new Padding(3);
            tbpPayment.Size = new Size(863, 489);
            tbpPayment.TabIndex = 3;
            tbpPayment.Text = "Payment";
            tbpPayment.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(371, 333);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(304, 142);
            materialCard2.TabIndex = 3;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(22, 333);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(304, 142);
            materialCard1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(22, 14);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 1;
            label2.Text = "Transaction History";
            // 
            // dgvTransactions
            // 
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column11, Column12, Column13, Column14 });
            dgvTransactions.Location = new Point(22, 42);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.Size = new Size(819, 274);
            dgvTransactions.TabIndex = 0;
            // 
            // tbpAnnouncement
            // 
            tbpAnnouncement.Controls.Add(btnDeleteAnnouncement);
            tbpAnnouncement.Controls.Add(btnCreate);
            tbpAnnouncement.Controls.Add(dgvAnnouncements);
            tbpAnnouncement.ImageKey = "0e604856-d18d-4a30-a36e-ee92b6581865_removalai_preview.png";
            tbpAnnouncement.Location = new Point(4, 39);
            tbpAnnouncement.Name = "tbpAnnouncement";
            tbpAnnouncement.Padding = new Padding(3);
            tbpAnnouncement.Size = new Size(863, 489);
            tbpAnnouncement.TabIndex = 4;
            tbpAnnouncement.Text = "Announcement";
            tbpAnnouncement.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAnnouncement
            // 
            btnDeleteAnnouncement.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteAnnouncement.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteAnnouncement.Depth = 0;
            btnDeleteAnnouncement.HighEmphasis = true;
            btnDeleteAnnouncement.Icon = null;
            btnDeleteAnnouncement.Location = new Point(595, 412);
            btnDeleteAnnouncement.Margin = new Padding(4, 6, 4, 6);
            btnDeleteAnnouncement.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteAnnouncement.Name = "btnDeleteAnnouncement";
            btnDeleteAnnouncement.NoAccentTextColor = Color.Empty;
            btnDeleteAnnouncement.Size = new Size(73, 36);
            btnDeleteAnnouncement.TabIndex = 8;
            btnDeleteAnnouncement.Text = "Delete";
            btnDeleteAnnouncement.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteAnnouncement.UseAccentColor = false;
            btnDeleteAnnouncement.UseVisualStyleBackColor = true;
            btnDeleteAnnouncement.Click += materialButton1_Click;
            // 
            // btnCreate
            // 
            btnCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreate.Depth = 0;
            btnCreate.HighEmphasis = true;
            btnCreate.Icon = null;
            btnCreate.Location = new Point(761, 412);
            btnCreate.Margin = new Padding(4, 6, 4, 6);
            btnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreate.Name = "btnCreate";
            btnCreate.NoAccentTextColor = Color.Empty;
            btnCreate.Size = new Size(76, 36);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreate.UseAccentColor = false;
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvAnnouncements
            // 
            dgvAnnouncements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnnouncements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnnouncements.Columns.AddRange(new DataGridViewColumn[] { colID, colRe, colContext, colDate });
            dgvAnnouncements.Location = new Point(26, 41);
            dgvAnnouncements.Name = "dgvAnnouncements";
            dgvAnnouncements.ReadOnly = true;
            dgvAnnouncements.Size = new Size(811, 349);
            dgvAnnouncements.TabIndex = 4;
            // 
            // colID
            // 
            colID.FillWeight = 20F;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colRe
            // 
            colRe.FillWeight = 60F;
            colRe.HeaderText = "Re:";
            colRe.Name = "colRe";
            colRe.ReadOnly = true;
            // 
            // colContext
            // 
            colContext.FillWeight = 178.0676F;
            colContext.HeaderText = "Context";
            colContext.Name = "colContext";
            colContext.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.FillWeight = 45F;
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // tbpRulesEnforcement
            // 
            tbpRulesEnforcement.Controls.Add(btnIssue);
            tbpRulesEnforcement.Controls.Add(btnDeleteViolation);
            tbpRulesEnforcement.Controls.Add(btnNewViolation);
            tbpRulesEnforcement.Controls.Add(label3);
            tbpRulesEnforcement.Controls.Add(dgvViolations);
            tbpRulesEnforcement.ImageKey = "Rules";
            tbpRulesEnforcement.Location = new Point(4, 39);
            tbpRulesEnforcement.Name = "tbpRulesEnforcement";
            tbpRulesEnforcement.Padding = new Padding(3);
            tbpRulesEnforcement.Size = new Size(863, 489);
            tbpRulesEnforcement.TabIndex = 5;
            tbpRulesEnforcement.Text = "Rules Enforcement";
            tbpRulesEnforcement.UseVisualStyleBackColor = true;
            // 
            // btnIssue
            // 
            btnIssue.AutoSize = true;
            btnIssue.Location = new Point(528, 412);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(91, 15);
            btnIssue.TabIndex = 6;
            btnIssue.TabStop = true;
            btnIssue.Text = "Issue a violation";
            btnIssue.LinkClicked += btnIssue_LinkClicked;
            // 
            // btnDeleteViolation
            // 
            btnDeleteViolation.AutoSize = true;
            btnDeleteViolation.Location = new Point(762, 412);
            btnDeleteViolation.Name = "btnDeleteViolation";
            btnDeleteViolation.Size = new Size(90, 15);
            btnDeleteViolation.TabIndex = 5;
            btnDeleteViolation.TabStop = true;
            btnDeleteViolation.Text = "Delete Violation";
            btnDeleteViolation.LinkClicked += btnDeleteViolation_LinkClicked;
            // 
            // btnNewViolation
            // 
            btnNewViolation.AutoSize = true;
            btnNewViolation.Location = new Point(659, 412);
            btnNewViolation.Name = "btnNewViolation";
            btnNewViolation.Size = new Size(81, 15);
            btnNewViolation.TabIndex = 2;
            btnNewViolation.TabStop = true;
            btnNewViolation.Text = "New Violation";
            btnNewViolation.LinkClicked += btnNewViolation_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 1;
            label3.Text = "List of Violations:";
            // 
            // dgvViolations
            // 
            dgvViolations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViolations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViolations.Columns.AddRange(new DataGridViewColumn[] { colRuleID, colRuleName, colDescription, colPenalty });
            dgvViolations.Location = new Point(6, 23);
            dgvViolations.Name = "dgvViolations";
            dgvViolations.ReadOnly = true;
            dgvViolations.Size = new Size(851, 386);
            dgvViolations.TabIndex = 0;
            // 
            // colRuleID
            // 
            colRuleID.FillWeight = 20F;
            colRuleID.HeaderText = "RuleID";
            colRuleID.Name = "colRuleID";
            colRuleID.ReadOnly = true;
            // 
            // colRuleName
            // 
            colRuleName.FillWeight = 40F;
            colRuleName.HeaderText = "Rule Name";
            colRuleName.Name = "colRuleName";
            colRuleName.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            // 
            // colPenalty
            // 
            colPenalty.FillWeight = 30F;
            colPenalty.HeaderText = "Penalty";
            colPenalty.Name = "colPenalty";
            colPenalty.ReadOnly = true;
            // 
            // tbpBills
            // 
            tbpBills.AutoScroll = true;
            tbpBills.Controls.Add(dgvPayables);
            tbpBills.Controls.Add(btnDelBill);
            tbpBills.Controls.Add(btnBill);
            tbpBills.Location = new Point(4, 39);
            tbpBills.Name = "tbpBills";
            tbpBills.Padding = new Padding(3);
            tbpBills.Size = new Size(863, 489);
            tbpBills.TabIndex = 6;
            tbpBills.Text = "Bills";
            tbpBills.UseVisualStyleBackColor = true;
            // 
            // dgvPayables
            // 
            dgvPayables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayables.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvPayables.Location = new Point(6, 6);
            dgvPayables.Name = "dgvPayables";
            dgvPayables.Size = new Size(851, 297);
            dgvPayables.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.FillWeight = 30F;
            Column1.Frozen = true;
            Column1.HeaderText = "Reference";
            Column1.Name = "Column1";
            Column1.Width = 135;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.Frozen = true;
            Column2.HeaderText = "Billed To";
            Column2.Name = "Column2";
            Column2.Width = 134;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column3.Frozen = true;
            Column3.HeaderText = "Description";
            Column3.Name = "Column3";
            Column3.Width = 135;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column4.FillWeight = 30F;
            Column4.HeaderText = "Amount";
            Column4.Name = "Column4";
            Column4.Width = 135;
            // 
            // Column5
            // 
            Column5.FillWeight = 30F;
            Column5.HeaderText = "Date";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.FillWeight = 30F;
            Column6.HeaderText = "Status";
            Column6.Name = "Column6";
            // 
            // btnDelBill
            // 
            btnDelBill.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelBill.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelBill.Depth = 0;
            btnDelBill.HighEmphasis = true;
            btnDelBill.Icon = null;
            btnDelBill.Location = new Point(766, 324);
            btnDelBill.Margin = new Padding(4, 6, 4, 6);
            btnDelBill.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelBill.Name = "btnDelBill";
            btnDelBill.NoAccentTextColor = Color.Empty;
            btnDelBill.Size = new Size(73, 36);
            btnDelBill.TabIndex = 5;
            btnDelBill.Text = "Delete";
            btnDelBill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelBill.UseAccentColor = false;
            btnDelBill.UseVisualStyleBackColor = true;
            btnDelBill.Click += btnDelBill_Click;
            // 
            // btnBill
            // 
            btnBill.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBill.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBill.Depth = 0;
            btnBill.HighEmphasis = true;
            btnBill.Icon = null;
            btnBill.Location = new Point(678, 324);
            btnBill.Margin = new Padding(4, 6, 4, 6);
            btnBill.MouseState = MaterialSkin.MouseState.HOVER;
            btnBill.Name = "btnBill";
            btnBill.NoAccentTextColor = Color.Empty;
            btnBill.Size = new Size(64, 36);
            btnBill.TabIndex = 4;
            btnBill.Text = "Bill";
            btnBill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBill.UseAccentColor = false;
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
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
            imageList1.Images.SetKeyName(4, "0e604856-d18d-4a30-a36e-ee92b6581865_removalai_preview.png");
            imageList1.Images.SetKeyName(5, "Rules");
            // 
            // Column7
            // 
            Column7.HeaderText = "ID";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "AccountID";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Billed To";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.HeaderText = "Amount";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.HeaderText = "Date";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Status";
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.HeaderText = "Paid";
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 599);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            MaximumSize = new Size(877, 599);
            MinimumSize = new Size(877, 599);
            Name = "Dashboard";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HoaMage";
            materialTabControl1.ResumeLayout(false);
            tbpHome.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            tbpProfile.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tbpRequest.ResumeLayout(false);
            tbpRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequest).EndInit();
            tbpPayment.ResumeLayout(false);
            tbpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            tbpAnnouncement.ResumeLayout(false);
            tbpAnnouncement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnnouncements).EndInit();
            tbpRulesEnforcement.ResumeLayout(false);
            tbpRulesEnforcement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViolations).EndInit();
            tbpBills.ResumeLayout(false);
            tbpBills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayables).EndInit();
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
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private TextBox tbxSearch;
        private Label label1;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btnAccounts;
        private TabPage tbpAnnouncement;
        private MaterialSkin.Controls.MaterialButton btnCreate;
        private DataGridView dgvAnnouncements;
        private DataGridView dgvRequest;
        private MaterialSkin.Controls.MaterialButton btnMail;
        private MaterialSkin.Controls.MaterialButton btnView;
        private FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label label2;
        private DataGridView dgvTransactions;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private TabPage tbpRulesEnforcement;
        private MaterialSkin.Controls.MaterialButton btnDeleteAnnouncement;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colRe;
        private DataGridViewTextBoxColumn colContext;
        private DataGridViewTextBoxColumn colDate;
        private DataGridView dgvViolations;
        private LinkLabel btnNewViolation;
        private Label label3;
        private LinkLabel btnDeleteViolation;
        private LinkLabel btnIssue;
        private DataGridViewTextBoxColumn colRuleID;
        private DataGridViewTextBoxColumn colRuleName;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colPenalty;
        private TabPage tbpBills;
        private MaterialSkin.Controls.MaterialButton btnBill;
        private MaterialSkin.Controls.MaterialButton btnDelBill;
        private DataGridView dgvPayables;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridView dgvDisplay;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
    }
}