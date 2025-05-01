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
            tbpProfile = new TabPage();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            tbxSearch = new TextBox();
            label1 = new Label();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            dgvDisplay = new DataGridView();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            cntSC = new MaterialSkin.Controls.MaterialLabel();
            cntMinor = new MaterialSkin.Controls.MaterialLabel();
            cntAdult = new MaterialSkin.Controls.MaterialLabel();
            lblSenior = new MaterialSkin.Controls.MaterialLabel();
            lblMinor = new MaterialSkin.Controls.MaterialLabel();
            lblAdults = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            cntPopul = new MaterialSkin.Controls.MaterialLabel();
            lblPopulation = new MaterialSkin.Controls.MaterialLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAccounts = new MaterialSkin.Controls.MaterialButton();
            btnMembers = new MaterialSkin.Controls.MaterialButton();
            btnProperties = new MaterialSkin.Controls.MaterialButton();
            btnVehicles = new MaterialSkin.Controls.MaterialButton();
            btnOccupants = new MaterialSkin.Controls.MaterialButton();
            tbpRequest = new TabPage();
            linkLabel2 = new LinkLabel();
            materialCard9 = new MaterialSkin.Controls.MaterialCard();
            cntSolved = new Label();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialCard8 = new MaterialSkin.Controls.MaterialCard();
            cntUnresolved = new Label();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            cntRequest = new Label();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            btnView = new MaterialSkin.Controls.MaterialButton();
            dgvRequest = new DataGridView();
            tbpAnnouncement = new TabPage();
            btnDeleteAnnouncement = new MaterialSkin.Controls.MaterialButton();
            btnCreate = new MaterialSkin.Controls.MaterialButton();
            dgvAnnouncements = new DataGridView();
            tbpRulesEnforcement = new TabPage();
            panel3 = new Panel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            dgvViolators = new DataGridView();
            label3 = new Label();
            btnIssue = new LinkLabel();
            btnDeleteViolation = new LinkLabel();
            dgvViolations = new DataGridView();
            colRuleID = new DataGridViewTextBoxColumn();
            colRuleName = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colPenalty = new DataGridViewTextBoxColumn();
            btnNewViolation = new LinkLabel();
            tbpBills = new TabPage();
            panel2 = new Panel();
            btnRefund = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            cntAvailable = new MaterialSkin.Controls.MaterialLabel();
            cntOutstanding = new MaterialSkin.Controls.MaterialLabel();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            cntExpenses = new MaterialSkin.Controls.MaterialLabel();
            cntTotal = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnExpenses = new MaterialSkin.Controls.MaterialButton();
            label4 = new Label();
            btnDelFee = new MaterialSkin.Controls.MaterialButton();
            btnNew = new MaterialSkin.Controls.MaterialButton();
            dgvFees = new DataGridView();
            dgvPayables = new DataGridView();
            btnBill = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            linkLabel5 = new LinkLabel();
            materialTabControl1.SuspendLayout();
            tbpHome.SuspendLayout();
            tbpProfile.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            materialCard4.SuspendLayout();
            materialCard2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tbpRequest.SuspendLayout();
            materialCard9.SuspendLayout();
            materialCard8.SuspendLayout();
            materialCard7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequest).BeginInit();
            tbpAnnouncement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnnouncements).BeginInit();
            tbpRulesEnforcement.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViolators).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvViolations).BeginInit();
            tbpBills.SuspendLayout();
            panel2.SuspendLayout();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayables).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tbpHome);
            materialTabControl1.Controls.Add(tbpProfile);
            materialTabControl1.Controls.Add(tbpRequest);
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
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(857, 483);
            flowLayoutPanel2.TabIndex = 0;
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
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(tbxSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(dgvDisplay);
            panel1.Controls.Add(materialCard4);
            panel1.Controls.Add(materialCard2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 441);
            panel1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(819, 305);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(32, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Print";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
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
            btnAdd.Location = new Point(636, 405);
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
            dgvDisplay.Size = new Size(857, 239);
            dgvDisplay.TabIndex = 0;
            dgvDisplay.CellClick += dgvDisplay_CellClick;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(cntSC);
            materialCard4.Controls.Add(cntMinor);
            materialCard4.Controls.Add(cntAdult);
            materialCard4.Controls.Add(lblSenior);
            materialCard4.Controls.Add(lblMinor);
            materialCard4.Controls.Add(lblAdults);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(255, 290);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(254, 137);
            materialCard4.TabIndex = 7;
            // 
            // cntSC
            // 
            cntSC.AutoSize = true;
            cntSC.Depth = 0;
            cntSC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cntSC.Location = new Point(128, 104);
            cntSC.MouseState = MaterialSkin.MouseState.HOVER;
            cntSC.Name = "cntSC";
            cntSC.Size = new Size(19, 19);
            cntSC.TabIndex = 5;
            cntSC.Text = "00";
            // 
            // cntMinor
            // 
            cntMinor.AutoSize = true;
            cntMinor.Depth = 0;
            cntMinor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cntMinor.Location = new Point(128, 57);
            cntMinor.MouseState = MaterialSkin.MouseState.HOVER;
            cntMinor.Name = "cntMinor";
            cntMinor.Size = new Size(19, 19);
            cntMinor.TabIndex = 4;
            cntMinor.Text = "00";
            // 
            // cntAdult
            // 
            cntAdult.AutoSize = true;
            cntAdult.Depth = 0;
            cntAdult.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cntAdult.Location = new Point(128, 14);
            cntAdult.MouseState = MaterialSkin.MouseState.HOVER;
            cntAdult.Name = "cntAdult";
            cntAdult.Size = new Size(19, 19);
            cntAdult.TabIndex = 2;
            cntAdult.Text = "00";
            // 
            // lblSenior
            // 
            lblSenior.AutoSize = true;
            lblSenior.Depth = 0;
            lblSenior.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSenior.Location = new Point(13, 104);
            lblSenior.MouseState = MaterialSkin.MouseState.HOVER;
            lblSenior.Name = "lblSenior";
            lblSenior.Size = new Size(102, 19);
            lblSenior.TabIndex = 3;
            lblSenior.Text = "Senior Citizen:";
            // 
            // lblMinor
            // 
            lblMinor.AutoSize = true;
            lblMinor.Depth = 0;
            lblMinor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMinor.Location = new Point(61, 57);
            lblMinor.MouseState = MaterialSkin.MouseState.HOVER;
            lblMinor.Name = "lblMinor";
            lblMinor.Size = new Size(54, 19);
            lblMinor.TabIndex = 2;
            lblMinor.Text = "Minors:";
            // 
            // lblAdults
            // 
            lblAdults.AutoSize = true;
            lblAdults.Depth = 0;
            lblAdults.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAdults.Location = new Point(61, 14);
            lblAdults.MouseState = MaterialSkin.MouseState.HOVER;
            lblAdults.Name = "lblAdults";
            lblAdults.Size = new Size(50, 19);
            lblAdults.TabIndex = 1;
            lblAdults.Text = "Adults:";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(cntPopul);
            materialCard2.Controls.Add(lblPopulation);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(11, 290);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(232, 137);
            materialCard2.TabIndex = 6;
            // 
            // cntPopul
            // 
            cntPopul.AutoSize = true;
            cntPopul.Depth = 0;
            cntPopul.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cntPopul.Location = new Point(105, 14);
            cntPopul.MouseState = MaterialSkin.MouseState.HOVER;
            cntPopul.Name = "cntPopul";
            cntPopul.Size = new Size(19, 19);
            cntPopul.TabIndex = 1;
            cntPopul.Text = "00";
            // 
            // lblPopulation
            // 
            lblPopulation.AutoSize = true;
            lblPopulation.Depth = 0;
            lblPopulation.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPopulation.Location = new Point(17, 14);
            lblPopulation.MouseState = MaterialSkin.MouseState.HOVER;
            lblPopulation.Name = "lblPopulation";
            lblPopulation.Size = new Size(82, 19);
            lblPopulation.TabIndex = 0;
            lblPopulation.Text = "Population:";
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
            tbpRequest.Controls.Add(linkLabel2);
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
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(813, 372);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(32, 15);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Print";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // materialCard9
            // 
            materialCard9.BackColor = Color.FromArgb(255, 255, 255);
            materialCard9.Controls.Add(cntSolved);
            materialCard9.Controls.Add(materialLabel7);
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
            // cntSolved
            // 
            cntSolved.AutoSize = true;
            cntSolved.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cntSolved.Location = new Point(80, 44);
            cntSolved.Name = "cntSolved";
            cntSolved.Size = new Size(44, 31);
            cntSolved.TabIndex = 4;
            cntSolved.Text = "00";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(14, 10);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(110, 19);
            materialLabel7.TabIndex = 2;
            materialLabel7.Text = "Solved Request";
            // 
            // materialCard8
            // 
            materialCard8.BackColor = Color.FromArgb(255, 255, 255);
            materialCard8.Controls.Add(cntUnresolved);
            materialCard8.Controls.Add(materialLabel6);
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
            // cntUnresolved
            // 
            cntUnresolved.AutoSize = true;
            cntUnresolved.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cntUnresolved.Location = new Point(77, 44);
            cntUnresolved.Name = "cntUnresolved";
            cntUnresolved.Size = new Size(44, 31);
            cntUnresolved.TabIndex = 3;
            cntUnresolved.Text = "00";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(17, 10);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(140, 19);
            materialLabel6.TabIndex = 1;
            materialLabel6.Text = "Unresolved Request";
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(cntRequest);
            materialCard7.Controls.Add(materialLabel5);
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
            // cntRequest
            // 
            cntRequest.AutoSize = true;
            cntRequest.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cntRequest.Location = new Point(76, 44);
            cntRequest.Name = "cntRequest";
            cntRequest.Size = new Size(44, 31);
            cntRequest.TabIndex = 2;
            cntRequest.Text = "00";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(5, 10);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(178, 19);
            materialLabel5.TabIndex = 0;
            materialLabel5.Text = "Total Number of Request";
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
            btnDeleteAnnouncement.Location = new Point(680, 412);
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
            dgvAnnouncements.Location = new Point(26, 41);
            dgvAnnouncements.Name = "dgvAnnouncements";
            dgvAnnouncements.ReadOnly = true;
            dgvAnnouncements.Size = new Size(811, 349);
            dgvAnnouncements.TabIndex = 4;
            // 
            // tbpRulesEnforcement
            // 
            tbpRulesEnforcement.Controls.Add(panel3);
            tbpRulesEnforcement.ImageKey = "Rules";
            tbpRulesEnforcement.Location = new Point(4, 39);
            tbpRulesEnforcement.Name = "tbpRulesEnforcement";
            tbpRulesEnforcement.Padding = new Padding(3);
            tbpRulesEnforcement.Size = new Size(863, 489);
            tbpRulesEnforcement.TabIndex = 5;
            tbpRulesEnforcement.Text = "Rules Enforcement";
            tbpRulesEnforcement.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(linkLabel4);
            panel3.Controls.Add(linkLabel3);
            panel3.Controls.Add(dgvViolators);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnIssue);
            panel3.Controls.Add(btnDeleteViolation);
            panel3.Controls.Add(dgvViolations);
            panel3.Controls.Add(btnNewViolation);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(857, 483);
            panel3.TabIndex = 7;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(805, 302);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(32, 15);
            linkLabel4.TabIndex = 11;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Print";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(805, 22);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(32, 15);
            linkLabel3.TabIndex = 10;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Print";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // dgvViolators
            // 
            dgvViolators.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViolators.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViolators.Location = new Point(13, 320);
            dgvViolators.Name = "dgvViolators";
            dgvViolators.ReadOnly = true;
            dgvViolators.Size = new Size(826, 194);
            dgvViolators.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 17);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 1;
            label3.Text = "HOA Rules:";
            // 
            // btnIssue
            // 
            btnIssue.AutoSize = true;
            btnIssue.Location = new Point(238, 287);
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
            btnDeleteViolation.Location = new Point(472, 287);
            btnDeleteViolation.Name = "btnDeleteViolation";
            btnDeleteViolation.Size = new Size(90, 15);
            btnDeleteViolation.TabIndex = 5;
            btnDeleteViolation.TabStop = true;
            btnDeleteViolation.Text = "Delete Violation";
            btnDeleteViolation.LinkClicked += btnDeleteViolation_LinkClicked;
            // 
            // dgvViolations
            // 
            dgvViolations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViolations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViolations.Columns.AddRange(new DataGridViewColumn[] { colRuleID, colRuleName, colDescription, colPenalty });
            dgvViolations.Location = new Point(13, 40);
            dgvViolations.Name = "dgvViolations";
            dgvViolations.ReadOnly = true;
            dgvViolations.Size = new Size(826, 244);
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
            // btnNewViolation
            // 
            btnNewViolation.AutoSize = true;
            btnNewViolation.Location = new Point(369, 287);
            btnNewViolation.Name = "btnNewViolation";
            btnNewViolation.Size = new Size(81, 15);
            btnNewViolation.TabIndex = 2;
            btnNewViolation.TabStop = true;
            btnNewViolation.Text = "New Violation";
            btnNewViolation.LinkClicked += btnNewViolation_LinkClicked;
            // 
            // tbpBills
            // 
            tbpBills.AutoScroll = true;
            tbpBills.Controls.Add(panel2);
            tbpBills.ImageKey = "be7b74a4-ae2f-4cb3-88fa-98fbcfcd07e5_removalai_preview.png";
            tbpBills.Location = new Point(4, 39);
            tbpBills.Name = "tbpBills";
            tbpBills.Padding = new Padding(3);
            tbpBills.Size = new Size(863, 489);
            tbpBills.TabIndex = 6;
            tbpBills.Text = "Bills";
            tbpBills.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(linkLabel5);
            panel2.Controls.Add(btnRefund);
            panel2.Controls.Add(materialCard1);
            panel2.Controls.Add(btnExpenses);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnDelFee);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(dgvFees);
            panel2.Controls.Add(dgvPayables);
            panel2.Controls.Add(btnBill);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(857, 483);
            panel2.TabIndex = 5;
            // 
            // btnRefund
            // 
            btnRefund.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefund.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRefund.Depth = 0;
            btnRefund.HighEmphasis = true;
            btnRefund.Icon = null;
            btnRefund.Location = new Point(742, 343);
            btnRefund.Margin = new Padding(4, 6, 4, 6);
            btnRefund.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefund.Name = "btnRefund";
            btnRefund.NoAccentTextColor = Color.Empty;
            btnRefund.Size = new Size(64, 36);
            btnRefund.TabIndex = 14;
            btnRefund.Text = "Void";
            btnRefund.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRefund.UseAccentColor = false;
            btnRefund.UseVisualStyleBackColor = true;
            btnRefund.Click += btnRefund_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(cntAvailable);
            materialCard1.Controls.Add(cntOutstanding);
            materialCard1.Controls.Add(materialLabel16);
            materialCard1.Controls.Add(cntExpenses);
            materialCard1.Controls.Add(cntTotal);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(materialLabel11);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(399, 419);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(336, 174);
            materialCard1.TabIndex = 12;
            // 
            // cntAvailable
            // 
            cntAvailable.AutoSize = true;
            cntAvailable.Depth = 0;
            cntAvailable.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cntAvailable.Location = new Point(169, 122);
            cntAvailable.MouseState = MaterialSkin.MouseState.HOVER;
            cntAvailable.Name = "cntAvailable";
            cntAvailable.Size = new Size(19, 19);
            cntAvailable.TabIndex = 3;
            cntAvailable.Text = "00";
            // 
            // cntOutstanding
            // 
            cntOutstanding.AutoSize = true;
            cntOutstanding.Depth = 0;
            cntOutstanding.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cntOutstanding.Location = new Point(169, 51);
            cntOutstanding.MouseState = MaterialSkin.MouseState.HOVER;
            cntOutstanding.Name = "cntOutstanding";
            cntOutstanding.Size = new Size(19, 19);
            cntOutstanding.TabIndex = 7;
            cntOutstanding.Text = "00";
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel16.Location = new Point(75, 88);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(72, 19);
            materialLabel16.TabIndex = 1;
            materialLabel16.Text = "Expenses:";
            // 
            // cntExpenses
            // 
            cntExpenses.AutoSize = true;
            cntExpenses.Depth = 0;
            cntExpenses.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cntExpenses.Location = new Point(169, 88);
            cntExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            cntExpenses.Name = "cntExpenses";
            cntExpenses.Size = new Size(19, 19);
            cntExpenses.TabIndex = 2;
            cntExpenses.Text = "00";
            // 
            // cntTotal
            // 
            cntTotal.AutoSize = true;
            cntTotal.Depth = 0;
            cntTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cntTotal.Location = new Point(169, 14);
            cntTotal.MouseState = MaterialSkin.MouseState.HOVER;
            cntTotal.Name = "cntTotal";
            cntTotal.Size = new Size(19, 19);
            cntTotal.TabIndex = 5;
            cntTotal.Text = "00";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(29, 122);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(118, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Available Funds:";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(10, 51);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(153, 19);
            materialLabel11.TabIndex = 6;
            materialLabel11.Text = "Outstanding Balance:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 14);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(111, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Total Collected:";
            // 
            // btnExpenses
            // 
            btnExpenses.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExpenses.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExpenses.Depth = 0;
            btnExpenses.HighEmphasis = true;
            btnExpenses.Icon = null;
            btnExpenses.Location = new Point(641, 343);
            btnExpenses.Margin = new Padding(4, 6, 4, 6);
            btnExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            btnExpenses.Name = "btnExpenses";
            btnExpenses.NoAccentTextColor = Color.Empty;
            btnExpenses.Size = new Size(94, 36);
            btnExpenses.TabIndex = 11;
            btnExpenses.Text = "Expenses";
            btnExpenses.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExpenses.UseAccentColor = false;
            btnExpenses.UseVisualStyleBackColor = true;
            btnExpenses.Click += btnExpenses_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 313);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 10;
            label4.Text = "HOA Fees:";
            // 
            // btnDelFee
            // 
            btnDelFee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelFee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelFee.Depth = 0;
            btnDelFee.HighEmphasis = true;
            btnDelFee.Icon = null;
            btnDelFee.Location = new Point(453, 343);
            btnDelFee.Margin = new Padding(4, 6, 4, 6);
            btnDelFee.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelFee.Name = "btnDelFee";
            btnDelFee.NoAccentTextColor = Color.Empty;
            btnDelFee.Size = new Size(73, 36);
            btnDelFee.TabIndex = 9;
            btnDelFee.Text = "Delete";
            btnDelFee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelFee.UseAccentColor = false;
            btnDelFee.UseVisualStyleBackColor = true;
            btnDelFee.Click += btnDelFee_Click;
            // 
            // btnNew
            // 
            btnNew.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNew.Depth = 0;
            btnNew.HighEmphasis = true;
            btnNew.Icon = null;
            btnNew.Location = new Point(365, 343);
            btnNew.Margin = new Padding(4, 6, 4, 6);
            btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            btnNew.Name = "btnNew";
            btnNew.NoAccentTextColor = Color.Empty;
            btnNew.Size = new Size(82, 36);
            btnNew.TabIndex = 7;
            btnNew.Text = "New Fee";
            btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNew.UseAccentColor = false;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvFees
            // 
            dgvFees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFees.Location = new Point(16, 343);
            dgvFees.Name = "dgvFees";
            dgvFees.ReadOnly = true;
            dgvFees.Size = new Size(323, 290);
            dgvFees.TabIndex = 6;
            // 
            // dgvPayables
            // 
            dgvPayables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayables.Location = new Point(16, 17);
            dgvPayables.Name = "dgvPayables";
            dgvPayables.ReadOnly = true;
            dgvPayables.Size = new Size(820, 287);
            dgvPayables.TabIndex = 5;
            dgvPayables.CellClick += dgvPayables_CellClick;
            // 
            // btnBill
            // 
            btnBill.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBill.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBill.Depth = 0;
            btnBill.HighEmphasis = true;
            btnBill.Icon = null;
            btnBill.Location = new Point(532, 343);
            btnBill.Margin = new Padding(4, 6, 4, 6);
            btnBill.MouseState = MaterialSkin.MouseState.HOVER;
            btnBill.Name = "btnBill";
            btnBill.NoAccentTextColor = Color.Empty;
            btnBill.Size = new Size(101, 36);
            btnBill.TabIndex = 4;
            btnBill.Text = "Send Bills";
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
            imageList1.Images.SetKeyName(6, "be7b74a4-ae2f-4cb3-88fa-98fbcfcd07e5_removalai_preview.png");
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
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Location = new Point(804, 307);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(32, 15);
            linkLabel5.TabIndex = 15;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Print";
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
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
            tbpProfile.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tbpRequest.ResumeLayout(false);
            tbpRequest.PerformLayout();
            materialCard9.ResumeLayout(false);
            materialCard9.PerformLayout();
            materialCard8.ResumeLayout(false);
            materialCard8.PerformLayout();
            materialCard7.ResumeLayout(false);
            materialCard7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequest).EndInit();
            tbpAnnouncement.ResumeLayout(false);
            tbpAnnouncement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnnouncements).EndInit();
            tbpRulesEnforcement.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViolators).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvViolations).EndInit();
            tbpBills.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFees).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayables).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tbpProfile;
        private TabPage tbpHome;
        private TabPage tbpRequest;
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
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private TabPage tbpRulesEnforcement;
        private MaterialSkin.Controls.MaterialButton btnDeleteAnnouncement;
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
        private DataGridView dgvDisplay;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Label cntSolved;
        private Label cntUnresolved;
        private Label cntRequest;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblPopulation;
        private MaterialSkin.Controls.MaterialLabel cntSC;
        private MaterialSkin.Controls.MaterialLabel cntMinor;
        private MaterialSkin.Controls.MaterialLabel cntAdult;
        private MaterialSkin.Controls.MaterialLabel lblSenior;
        private MaterialSkin.Controls.MaterialLabel lblMinor;
        private MaterialSkin.Controls.MaterialLabel lblAdults;
        private MaterialSkin.Controls.MaterialLabel cntPopul;
        private Panel panel2;
        private DataGridView dgvFees;
        private DataGridView dgvPayables;
        private MaterialSkin.Controls.MaterialButton btnDelFee;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private Label label4;
        private Panel panel3;
        private DataGridView dgvViolators;
        private MaterialSkin.Controls.MaterialButton btnExpenses;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel cntOutstanding;
        private MaterialSkin.Controls.MaterialLabel cntTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel cntAvailable;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel cntExpenses;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnRefund;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel5;
    }
}