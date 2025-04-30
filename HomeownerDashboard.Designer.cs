namespace HoaMage
{
    partial class HomeownerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeownerDashboard));
            imageList1 = new ImageList(components);
            tbpPayables = new TabPage();
            dgvPayables = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnPay = new MaterialSkin.Controls.MaterialButton();
            tbpRequest = new TabPage();
            btnSubmit = new MaterialSkin.Controls.MaterialButton();
            tbxContext = new TextBox();
            tbxSubject = new MaterialSkin.Controls.MaterialTextBox2();
            cbxType = new MaterialSkin.Controls.MaterialComboBox();
            tbpProfile = new TabPage();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            tbpMember = new TabPage();
            linkLabel1 = new LinkLabel();
            btnMemberEdit = new MaterialSkin.Controls.MaterialSwitch();
            tbxContactNumber = new TextBox();
            tbxGender = new TextBox();
            tbxMiddleInitial = new TextBox();
            tbxLastname = new TextBox();
            tbxFirstname = new TextBox();
            dtpBirthdate = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbxMemberProfile = new PictureBox();
            tbpProperty = new TabPage();
            tbxBlockNumber = new TextBox();
            label14 = new Label();
            btnPropertyEdit = new MaterialSkin.Controls.MaterialSwitch();
            cbxOwnership = new ComboBox();
            label15 = new Label();
            label13 = new Label();
            tbxOccupantNum = new TextBox();
            tbxUnitNumber = new TextBox();
            tbxAddress = new TextBox();
            tbxResidence = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            tbpVehicle = new TabPage();
            btnVehicleEdit = new MaterialSkin.Controls.MaterialSwitch();
            label17 = new Label();
            tbxColor = new TextBox();
            tbxPlateNumber = new TextBox();
            tbxModel = new TextBox();
            tbxMake = new TextBox();
            label19 = new Label();
            label12 = new Label();
            label8 = new Label();
            pbxVehicleImage = new PictureBox();
            tbpOccupants = new TabPage();
            dgvOccupants = new DataGridView();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            pbxOccupantImage = new PictureBox();
            lblBirthday = new Label();
            lblAge = new Label();
            lblGender = new Label();
            lblName = new Label();
            btnEditOccupant = new MaterialSkin.Controls.MaterialButton();
            btnDeleteOccupant = new MaterialSkin.Controls.MaterialButton();
            btnAddOccupant = new MaterialSkin.Controls.MaterialButton();
            tbpHomeownerRequest = new TabPage();
            btnView = new MaterialSkin.Controls.MaterialButton();
            dgvRequest = new DataGridView();
            colType = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            colContext = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            tbpHome = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tbpPayables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayables).BeginInit();
            tbpRequest.SuspendLayout();
            tbpProfile.SuspendLayout();
            materialTabControl2.SuspendLayout();
            tbpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMemberProfile).BeginInit();
            tbpProperty.SuspendLayout();
            tbpVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVehicleImage).BeginInit();
            tbpOccupants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOccupants).BeginInit();
            materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxOccupantImage).BeginInit();
            tbpHomeownerRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequest).BeginInit();
            tbpHome.SuspendLayout();
            materialTabControl1.SuspendLayout();
            SuspendLayout();
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
            // tbpPayables
            // 
            tbpPayables.Controls.Add(dgvPayables);
            tbpPayables.Controls.Add(btnPay);
            tbpPayables.ImageKey = "Payment.png";
            tbpPayables.Location = new Point(4, 39);
            tbpPayables.Name = "tbpPayables";
            tbpPayables.Padding = new Padding(3);
            tbpPayables.Size = new Size(863, 489);
            tbpPayables.TabIndex = 3;
            tbpPayables.Text = "Payment";
            tbpPayables.UseVisualStyleBackColor = true;
            // 
            // dgvPayables
            // 
            dgvPayables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayables.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvPayables.Location = new Point(6, 6);
            dgvPayables.Name = "dgvPayables";
            dgvPayables.ReadOnly = true;
            dgvPayables.Size = new Size(850, 336);
            dgvPayables.TabIndex = 2;
            dgvPayables.CellClick += dgvPayables_CellClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 30F;
            Column1.HeaderText = "Reference";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Billed To";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 50F;
            Column3.HeaderText = "Description";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 35F;
            Column4.HeaderText = "Amount";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 25F;
            Column5.HeaderText = "Date";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.FillWeight = 25F;
            Column6.HeaderText = "Status";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // btnPay
            // 
            btnPay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPay.Depth = 0;
            btnPay.HighEmphasis = true;
            btnPay.Icon = null;
            btnPay.Location = new Point(766, 351);
            btnPay.Margin = new Padding(4, 6, 4, 6);
            btnPay.MouseState = MaterialSkin.MouseState.HOVER;
            btnPay.Name = "btnPay";
            btnPay.NoAccentTextColor = Color.Empty;
            btnPay.Size = new Size(90, 36);
            btnPay.TabIndex = 1;
            btnPay.Text = "Payment";
            btnPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPay.UseAccentColor = false;
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // tbpRequest
            // 
            tbpRequest.Controls.Add(btnSubmit);
            tbpRequest.Controls.Add(tbxContext);
            tbpRequest.Controls.Add(tbxSubject);
            tbpRequest.Controls.Add(cbxType);
            tbpRequest.ImageKey = "Request.png";
            tbpRequest.Location = new Point(4, 39);
            tbpRequest.Name = "tbpRequest";
            tbpRequest.Padding = new Padding(3);
            tbpRequest.Size = new Size(863, 489);
            tbpRequest.TabIndex = 2;
            tbpRequest.Text = "Request";
            tbpRequest.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSubmit.Depth = 0;
            btnSubmit.HighEmphasis = true;
            btnSubmit.Icon = (Image)resources.GetObject("btnSubmit.Icon");
            btnSubmit.Location = new Point(743, 466);
            btnSubmit.Margin = new Padding(4, 6, 4, 6);
            btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            btnSubmit.Name = "btnSubmit";
            btnSubmit.NoAccentTextColor = Color.Empty;
            btnSubmit.Size = new Size(103, 36);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSubmit.UseAccentColor = false;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxContext
            // 
            tbxContext.Location = new Point(21, 76);
            tbxContext.Multiline = true;
            tbxContext.Name = "tbxContext";
            tbxContext.Size = new Size(825, 380);
            tbxContext.TabIndex = 2;
            // 
            // tbxSubject
            // 
            tbxSubject.Anchor = AnchorStyles.Top;
            tbxSubject.AnimateReadOnly = false;
            tbxSubject.BackgroundImageLayout = ImageLayout.None;
            tbxSubject.CharacterCasing = CharacterCasing.Normal;
            tbxSubject.Depth = 0;
            tbxSubject.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxSubject.HideSelection = true;
            tbxSubject.Hint = "Subject";
            tbxSubject.LeadingIcon = null;
            tbxSubject.Location = new Point(220, 21);
            tbxSubject.MaxLength = 32767;
            tbxSubject.MouseState = MaterialSkin.MouseState.OUT;
            tbxSubject.Name = "tbxSubject";
            tbxSubject.PasswordChar = '\0';
            tbxSubject.PrefixSuffixText = null;
            tbxSubject.ReadOnly = false;
            tbxSubject.RightToLeft = RightToLeft.No;
            tbxSubject.SelectedText = "";
            tbxSubject.SelectionLength = 0;
            tbxSubject.SelectionStart = 0;
            tbxSubject.ShortcutsEnabled = true;
            tbxSubject.Size = new Size(626, 48);
            tbxSubject.TabIndex = 1;
            tbxSubject.TabStop = false;
            tbxSubject.TextAlign = HorizontalAlignment.Left;
            tbxSubject.TrailingIcon = null;
            tbxSubject.UseSystemPasswordChar = false;
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
            cbxType.Hint = "Type";
            cbxType.IntegralHeight = false;
            cbxType.ItemHeight = 43;
            cbxType.Items.AddRange(new object[] { "", "Complaints", "Maintainance", "Inquiry", "Report" });
            cbxType.Location = new Point(21, 20);
            cbxType.MaxDropDownItems = 4;
            cbxType.MouseState = MaterialSkin.MouseState.OUT;
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(193, 49);
            cbxType.StartIndex = 0;
            cbxType.TabIndex = 0;
            // 
            // tbpProfile
            // 
            tbpProfile.Controls.Add(materialTabSelector1);
            tbpProfile.Controls.Add(materialTabControl2);
            tbpProfile.ImageKey = "Manage.png";
            tbpProfile.Location = new Point(4, 39);
            tbpProfile.Name = "tbpProfile";
            tbpProfile.Padding = new Padding(3);
            tbpProfile.Size = new Size(863, 489);
            tbpProfile.TabIndex = 1;
            tbpProfile.Text = "Profile";
            tbpProfile.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl2;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(7, 6);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(849, 48);
            materialTabSelector1.TabIndex = 1;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl2
            // 
            materialTabControl2.Controls.Add(tbpMember);
            materialTabControl2.Controls.Add(tbpProperty);
            materialTabControl2.Controls.Add(tbpVehicle);
            materialTabControl2.Controls.Add(tbpOccupants);
            materialTabControl2.Controls.Add(tbpHomeownerRequest);
            materialTabControl2.Depth = 0;
            materialTabControl2.Dock = DockStyle.Bottom;
            materialTabControl2.Location = new Point(3, 63);
            materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl2.Multiline = true;
            materialTabControl2.Name = "materialTabControl2";
            materialTabControl2.SelectedIndex = 0;
            materialTabControl2.Size = new Size(857, 423);
            materialTabControl2.TabIndex = 0;
            // 
            // tbpMember
            // 
            tbpMember.Controls.Add(linkLabel1);
            tbpMember.Controls.Add(btnMemberEdit);
            tbpMember.Controls.Add(tbxContactNumber);
            tbpMember.Controls.Add(tbxGender);
            tbpMember.Controls.Add(tbxMiddleInitial);
            tbpMember.Controls.Add(tbxLastname);
            tbpMember.Controls.Add(tbxFirstname);
            tbpMember.Controls.Add(dtpBirthdate);
            tbpMember.Controls.Add(label6);
            tbpMember.Controls.Add(label5);
            tbpMember.Controls.Add(label4);
            tbpMember.Controls.Add(label3);
            tbpMember.Controls.Add(label2);
            tbpMember.Controls.Add(label1);
            tbpMember.Controls.Add(pbxMemberProfile);
            tbpMember.Location = new Point(4, 24);
            tbpMember.Name = "tbpMember";
            tbpMember.Padding = new Padding(3);
            tbpMember.Size = new Size(849, 395);
            tbpMember.TabIndex = 1;
            tbpMember.Text = "Member";
            tbpMember.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(36, 52, 60);
            linkLabel1.Location = new Point(798, 3);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnMemberEdit
            // 
            btnMemberEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMemberEdit.AutoSize = true;
            btnMemberEdit.Depth = 0;
            btnMemberEdit.Location = new Point(761, 355);
            btnMemberEdit.Margin = new Padding(0);
            btnMemberEdit.MouseLocation = new Point(-1, -1);
            btnMemberEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnMemberEdit.Name = "btnMemberEdit";
            btnMemberEdit.Ripple = true;
            btnMemberEdit.Size = new Size(85, 37);
            btnMemberEdit.TabIndex = 18;
            btnMemberEdit.Text = "Edit";
            btnMemberEdit.UseVisualStyleBackColor = true;
            btnMemberEdit.CheckedChanged += btnMemberEdit_CheckedChanged;
            // 
            // tbxContactNumber
            // 
            tbxContactNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxContactNumber.Enabled = false;
            tbxContactNumber.Location = new Point(406, 329);
            tbxContactNumber.Name = "tbxContactNumber";
            tbxContactNumber.Size = new Size(260, 23);
            tbxContactNumber.TabIndex = 17;
            // 
            // tbxGender
            // 
            tbxGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxGender.Enabled = false;
            tbxGender.Location = new Point(406, 271);
            tbxGender.Name = "tbxGender";
            tbxGender.Size = new Size(260, 23);
            tbxGender.TabIndex = 15;
            // 
            // tbxMiddleInitial
            // 
            tbxMiddleInitial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxMiddleInitial.Enabled = false;
            tbxMiddleInitial.Location = new Point(406, 155);
            tbxMiddleInitial.Name = "tbxMiddleInitial";
            tbxMiddleInitial.Size = new Size(260, 23);
            tbxMiddleInitial.TabIndex = 11;
            // 
            // tbxLastname
            // 
            tbxLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxLastname.Enabled = false;
            tbxLastname.Location = new Point(406, 97);
            tbxLastname.Name = "tbxLastname";
            tbxLastname.Size = new Size(260, 23);
            tbxLastname.TabIndex = 9;
            // 
            // tbxFirstname
            // 
            tbxFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxFirstname.Enabled = false;
            tbxFirstname.Location = new Point(406, 39);
            tbxFirstname.Name = "tbxFirstname";
            tbxFirstname.Size = new Size(260, 23);
            tbxFirstname.TabIndex = 2;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpBirthdate.Enabled = false;
            dtpBirthdate.Location = new Point(406, 213);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(260, 23);
            dtpBirthdate.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(269, 332);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 7;
            label6.Text = "Contact Number:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(320, 279);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 6;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(310, 221);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Birthdate:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(289, 163);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Middle Initial:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(307, 105);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Lastname:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(306, 47);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Firstname:";
            // 
            // pbxMemberProfile
            // 
            pbxMemberProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxMemberProfile.Location = new Point(95, 47);
            pbxMemberProfile.Name = "pbxMemberProfile";
            pbxMemberProfile.Size = new Size(148, 145);
            pbxMemberProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbxMemberProfile.TabIndex = 0;
            pbxMemberProfile.TabStop = false;
            // 
            // tbpProperty
            // 
            tbpProperty.Controls.Add(tbxBlockNumber);
            tbpProperty.Controls.Add(label14);
            tbpProperty.Controls.Add(btnPropertyEdit);
            tbpProperty.Controls.Add(cbxOwnership);
            tbpProperty.Controls.Add(label15);
            tbpProperty.Controls.Add(label13);
            tbpProperty.Controls.Add(tbxOccupantNum);
            tbpProperty.Controls.Add(tbxUnitNumber);
            tbpProperty.Controls.Add(tbxAddress);
            tbpProperty.Controls.Add(tbxResidence);
            tbpProperty.Controls.Add(label11);
            tbpProperty.Controls.Add(label9);
            tbpProperty.Controls.Add(label7);
            tbpProperty.Location = new Point(4, 24);
            tbpProperty.Name = "tbpProperty";
            tbpProperty.Padding = new Padding(3);
            tbpProperty.Size = new Size(849, 395);
            tbpProperty.TabIndex = 2;
            tbpProperty.Text = "Property";
            tbpProperty.UseVisualStyleBackColor = true;
            // 
            // tbxBlockNumber
            // 
            tbxBlockNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxBlockNumber.Enabled = false;
            tbxBlockNumber.Location = new Point(271, 167);
            tbxBlockNumber.Name = "tbxBlockNumber";
            tbxBlockNumber.Size = new Size(228, 23);
            tbxBlockNumber.TabIndex = 22;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(171, 175);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 23;
            label14.Text = "Block Number:";
            // 
            // btnPropertyEdit
            // 
            btnPropertyEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPropertyEdit.AutoSize = true;
            btnPropertyEdit.Depth = 0;
            btnPropertyEdit.Location = new Point(761, 355);
            btnPropertyEdit.Margin = new Padding(0);
            btnPropertyEdit.MouseLocation = new Point(-1, -1);
            btnPropertyEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnPropertyEdit.Name = "btnPropertyEdit";
            btnPropertyEdit.Ripple = true;
            btnPropertyEdit.Size = new Size(85, 37);
            btnPropertyEdit.TabIndex = 19;
            btnPropertyEdit.Text = "Edit";
            btnPropertyEdit.UseVisualStyleBackColor = true;
            btnPropertyEdit.CheckedChanged += btnPropertyEdit_CheckedChanged;
            // 
            // cbxOwnership
            // 
            cbxOwnership.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbxOwnership.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOwnership.Enabled = false;
            cbxOwnership.FormattingEnabled = true;
            cbxOwnership.Items.AddRange(new object[] { "Renter", "Owner-Occupied", "Vacant" });
            cbxOwnership.Location = new Point(271, 334);
            cbxOwnership.Name = "cbxOwnership";
            cbxOwnership.Size = new Size(228, 23);
            cbxOwnership.TabIndex = 18;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(186, 342);
            label15.Name = "label15";
            label15.Size = new Size(67, 15);
            label15.TabIndex = 17;
            label15.Text = "Ownership:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(122, 284);
            label13.Name = "label13";
            label13.Size = new Size(128, 15);
            label13.TabIndex = 13;
            label13.Text = "Number of Occupants:";
            // 
            // tbxOccupantNum
            // 
            tbxOccupantNum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxOccupantNum.Enabled = false;
            tbxOccupantNum.Location = new Point(271, 276);
            tbxOccupantNum.Name = "tbxOccupantNum";
            tbxOccupantNum.Size = new Size(228, 23);
            tbxOccupantNum.TabIndex = 12;
            // 
            // tbxUnitNumber
            // 
            tbxUnitNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxUnitNumber.Enabled = false;
            tbxUnitNumber.Location = new Point(271, 225);
            tbxUnitNumber.Name = "tbxUnitNumber";
            tbxUnitNumber.Size = new Size(228, 23);
            tbxUnitNumber.TabIndex = 8;
            // 
            // tbxAddress
            // 
            tbxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxAddress.Enabled = false;
            tbxAddress.Location = new Point(271, 109);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(228, 23);
            tbxAddress.TabIndex = 4;
            // 
            // tbxResidence
            // 
            tbxResidence.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxResidence.Enabled = false;
            tbxResidence.Location = new Point(271, 51);
            tbxResidence.Name = "tbxResidence";
            tbxResidence.Size = new Size(228, 23);
            tbxResidence.TabIndex = 0;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(171, 233);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 9;
            label11.Text = "Unit Number:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(162, 117);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 5;
            label9.Text = "Home Address:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(187, 59);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 1;
            label7.Text = "Residence:";
            // 
            // tbpVehicle
            // 
            tbpVehicle.Controls.Add(btnVehicleEdit);
            tbpVehicle.Controls.Add(label17);
            tbpVehicle.Controls.Add(tbxColor);
            tbpVehicle.Controls.Add(tbxPlateNumber);
            tbpVehicle.Controls.Add(tbxModel);
            tbpVehicle.Controls.Add(tbxMake);
            tbpVehicle.Controls.Add(label19);
            tbpVehicle.Controls.Add(label12);
            tbpVehicle.Controls.Add(label8);
            tbpVehicle.Controls.Add(pbxVehicleImage);
            tbpVehicle.Location = new Point(4, 24);
            tbpVehicle.Name = "tbpVehicle";
            tbpVehicle.Padding = new Padding(3);
            tbpVehicle.Size = new Size(849, 395);
            tbpVehicle.TabIndex = 3;
            tbpVehicle.Text = "Vehicle";
            tbpVehicle.UseVisualStyleBackColor = true;
            // 
            // btnVehicleEdit
            // 
            btnVehicleEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVehicleEdit.AutoSize = true;
            btnVehicleEdit.Depth = 0;
            btnVehicleEdit.Location = new Point(761, 355);
            btnVehicleEdit.Margin = new Padding(0);
            btnVehicleEdit.MouseLocation = new Point(-1, -1);
            btnVehicleEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnVehicleEdit.Name = "btnVehicleEdit";
            btnVehicleEdit.Ripple = true;
            btnVehicleEdit.Size = new Size(85, 37);
            btnVehicleEdit.TabIndex = 15;
            btnVehicleEdit.Text = "Edit";
            btnVehicleEdit.UseVisualStyleBackColor = true;
            btnVehicleEdit.CheckedChanged += btnVehicleEdit_CheckedChanged;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(443, 299);
            label17.Name = "label17";
            label17.Size = new Size(39, 15);
            label17.TabIndex = 14;
            label17.Text = "Color:";
            // 
            // tbxColor
            // 
            tbxColor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxColor.Enabled = false;
            tbxColor.Location = new Point(502, 291);
            tbxColor.Name = "tbxColor";
            tbxColor.Size = new Size(190, 23);
            tbxColor.TabIndex = 13;
            // 
            // tbxPlateNumber
            // 
            tbxPlateNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxPlateNumber.Enabled = false;
            tbxPlateNumber.Location = new Point(502, 233);
            tbxPlateNumber.Name = "tbxPlateNumber";
            tbxPlateNumber.Size = new Size(190, 23);
            tbxPlateNumber.TabIndex = 9;
            // 
            // tbxModel
            // 
            tbxModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxModel.Enabled = false;
            tbxModel.Location = new Point(502, 175);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(190, 23);
            tbxModel.TabIndex = 5;
            // 
            // tbxMake
            // 
            tbxMake.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxMake.Enabled = false;
            tbxMake.Location = new Point(502, 117);
            tbxMake.Name = "tbxMake";
            tbxMake.Size = new Size(190, 23);
            tbxMake.TabIndex = 1;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Location = new Point(399, 241);
            label19.Name = "label19";
            label19.Size = new Size(83, 15);
            label19.TabIndex = 10;
            label19.Text = "Plate Number:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(438, 183);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 6;
            label12.Text = "Model:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(443, 125);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 2;
            label8.Text = "Make:";
            // 
            // pbxVehicleImage
            // 
            pbxVehicleImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbxVehicleImage.Location = new Point(39, 41);
            pbxVehicleImage.Name = "pbxVehicleImage";
            pbxVehicleImage.Size = new Size(324, 314);
            pbxVehicleImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVehicleImage.TabIndex = 0;
            pbxVehicleImage.TabStop = false;
            // 
            // tbpOccupants
            // 
            tbpOccupants.Controls.Add(dgvOccupants);
            tbpOccupants.Controls.Add(materialCard6);
            tbpOccupants.Controls.Add(btnEditOccupant);
            tbpOccupants.Controls.Add(btnDeleteOccupant);
            tbpOccupants.Controls.Add(btnAddOccupant);
            tbpOccupants.Location = new Point(4, 24);
            tbpOccupants.Name = "tbpOccupants";
            tbpOccupants.Padding = new Padding(3);
            tbpOccupants.Size = new Size(849, 395);
            tbpOccupants.TabIndex = 5;
            tbpOccupants.Text = "Occupants";
            tbpOccupants.UseVisualStyleBackColor = true;
            // 
            // dgvOccupants
            // 
            dgvOccupants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOccupants.Location = new Point(6, 6);
            dgvOccupants.Name = "dgvOccupants";
            dgvOccupants.ReadOnly = true;
            dgvOccupants.Size = new Size(404, 383);
            dgvOccupants.TabIndex = 7;
            dgvOccupants.CellClick += dgvOccupants_CellClick_1;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(pbxOccupantImage);
            materialCard6.Controls.Add(lblBirthday);
            materialCard6.Controls.Add(lblAge);
            materialCard6.Controls.Add(lblGender);
            materialCard6.Controls.Add(lblName);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(427, 6);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(413, 217);
            materialCard6.TabIndex = 6;
            // 
            // pbxOccupantImage
            // 
            pbxOccupantImage.Location = new Point(27, 49);
            pbxOccupantImage.Name = "pbxOccupantImage";
            pbxOccupantImage.Size = new Size(100, 100);
            pbxOccupantImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbxOccupantImage.TabIndex = 4;
            pbxOccupantImage.TabStop = false;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 12F);
            lblBirthday.Location = new Point(164, 113);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(134, 21);
            lblBirthday.TabIndex = 3;
            lblBirthday.Text = "OccupantBirthday";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F);
            lblAge.Location = new Point(164, 151);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(103, 21);
            lblAge.TabIndex = 2;
            lblAge.Text = "OccupantAge";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F);
            lblGender.Location = new Point(164, 76);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(127, 21);
            lblGender.TabIndex = 1;
            lblGender.Text = "OccupantGender";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(164, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(118, 21);
            lblName.TabIndex = 0;
            lblName.Text = "OccupantName";
            // 
            // btnEditOccupant
            // 
            btnEditOccupant.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditOccupant.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditOccupant.Depth = 0;
            btnEditOccupant.HighEmphasis = true;
            btnEditOccupant.Icon = null;
            btnEditOccupant.Location = new Point(776, 232);
            btnEditOccupant.Margin = new Padding(4, 6, 4, 6);
            btnEditOccupant.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditOccupant.Name = "btnEditOccupant";
            btnEditOccupant.NoAccentTextColor = Color.Empty;
            btnEditOccupant.Size = new Size(64, 36);
            btnEditOccupant.TabIndex = 5;
            btnEditOccupant.Text = "Edit";
            btnEditOccupant.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditOccupant.UseAccentColor = false;
            btnEditOccupant.UseVisualStyleBackColor = true;
            btnEditOccupant.Click += btnEditOccupant_Click;
            // 
            // btnDeleteOccupant
            // 
            btnDeleteOccupant.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteOccupant.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteOccupant.Depth = 0;
            btnDeleteOccupant.HighEmphasis = true;
            btnDeleteOccupant.Icon = null;
            btnDeleteOccupant.Location = new Point(690, 232);
            btnDeleteOccupant.Margin = new Padding(4, 6, 4, 6);
            btnDeleteOccupant.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteOccupant.Name = "btnDeleteOccupant";
            btnDeleteOccupant.NoAccentTextColor = Color.Empty;
            btnDeleteOccupant.Size = new Size(73, 36);
            btnDeleteOccupant.TabIndex = 3;
            btnDeleteOccupant.Text = "Delete";
            btnDeleteOccupant.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteOccupant.UseAccentColor = false;
            btnDeleteOccupant.UseVisualStyleBackColor = true;
            btnDeleteOccupant.Click += btnDeleteOccupant_Click;
            // 
            // btnAddOccupant
            // 
            btnAddOccupant.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddOccupant.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddOccupant.Depth = 0;
            btnAddOccupant.HighEmphasis = true;
            btnAddOccupant.Icon = null;
            btnAddOccupant.Location = new Point(614, 232);
            btnAddOccupant.Margin = new Padding(4, 6, 4, 6);
            btnAddOccupant.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddOccupant.Name = "btnAddOccupant";
            btnAddOccupant.NoAccentTextColor = Color.Empty;
            btnAddOccupant.Size = new Size(64, 36);
            btnAddOccupant.TabIndex = 2;
            btnAddOccupant.Text = "Add";
            btnAddOccupant.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddOccupant.UseAccentColor = false;
            btnAddOccupant.UseVisualStyleBackColor = true;
            btnAddOccupant.Click += btnAddOccupant_Click;
            // 
            // tbpHomeownerRequest
            // 
            tbpHomeownerRequest.Controls.Add(btnView);
            tbpHomeownerRequest.Controls.Add(dgvRequest);
            tbpHomeownerRequest.Location = new Point(4, 24);
            tbpHomeownerRequest.Name = "tbpHomeownerRequest";
            tbpHomeownerRequest.Padding = new Padding(3);
            tbpHomeownerRequest.Size = new Size(849, 395);
            tbpHomeownerRequest.TabIndex = 4;
            tbpHomeownerRequest.Text = "Request";
            tbpHomeownerRequest.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnView.Depth = 0;
            btnView.HighEmphasis = true;
            btnView.Icon = null;
            btnView.Location = new Point(762, 318);
            btnView.Margin = new Padding(4, 6, 4, 6);
            btnView.MouseState = MaterialSkin.MouseState.HOVER;
            btnView.Name = "btnView";
            btnView.NoAccentTextColor = Color.Empty;
            btnView.Size = new Size(64, 36);
            btnView.TabIndex = 1;
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
            dgvRequest.Columns.AddRange(new DataGridViewColumn[] { colType, colSubject, colContext, colStatus, colDate });
            dgvRequest.Location = new Point(23, 40);
            dgvRequest.Name = "dgvRequest";
            dgvRequest.ReadOnly = true;
            dgvRequest.Size = new Size(803, 269);
            dgvRequest.TabIndex = 0;
            // 
            // colType
            // 
            colType.FillWeight = 68.17853F;
            colType.HeaderText = "Request Type";
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colSubject
            // 
            colSubject.FillWeight = 60.9137039F;
            colSubject.HeaderText = "Subject";
            colSubject.Name = "colSubject";
            colSubject.ReadOnly = true;
            // 
            // colContext
            // 
            colContext.FillWeight = 189.074234F;
            colContext.HeaderText = "Context";
            colContext.Name = "colContext";
            colContext.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 81.83353F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date Submitted";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // tbpHome
            // 
            tbpHome.Controls.Add(flowLayoutPanel2);
            tbpHome.ImageKey = "Home.png";
            tbpHome.Location = new Point(4, 39);
            tbpHome.Name = "tbpHome";
            tbpHome.Padding = new Padding(3);
            tbpHome.Size = new Size(863, 489);
            tbpHome.TabIndex = 0;
            tbpHome.Text = "Home";
            tbpHome.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(857, 483);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tbpHome);
            materialTabControl1.Controls.Add(tbpProfile);
            materialTabControl1.Controls.Add(tbpRequest);
            materialTabControl1.Controls.Add(tbpPayables);
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
            // HomeownerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(877, 599);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            MaximumSize = new Size(877, 599);
            MinimumSize = new Size(877, 599);
            Name = "HomeownerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homeowner Dashboard";
            tbpPayables.ResumeLayout(false);
            tbpPayables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayables).EndInit();
            tbpRequest.ResumeLayout(false);
            tbpRequest.PerformLayout();
            tbpProfile.ResumeLayout(false);
            materialTabControl2.ResumeLayout(false);
            tbpMember.ResumeLayout(false);
            tbpMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMemberProfile).EndInit();
            tbpProperty.ResumeLayout(false);
            tbpProperty.PerformLayout();
            tbpVehicle.ResumeLayout(false);
            tbpVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVehicleImage).EndInit();
            tbpOccupants.ResumeLayout(false);
            tbpOccupants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOccupants).EndInit();
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxOccupantImage).EndInit();
            tbpHomeownerRequest.ResumeLayout(false);
            tbpHomeownerRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequest).EndInit();
            tbpHome.ResumeLayout(false);
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private Button button1;
        private TabPage tbpPayables;
        private DataGridView dgvPayables;
        private MaterialSkin.Controls.MaterialButton btnPay;
        private TabPage tbpRequest;
        private MaterialSkin.Controls.MaterialButton btnSubmit;
        private TextBox tbxContext;
        private MaterialSkin.Controls.MaterialTextBox2 tbxSubject;
        private MaterialSkin.Controls.MaterialComboBox cbxType;
        private TabPage tbpProfile;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private TabPage tbpMember;
        private MaterialSkin.Controls.MaterialSwitch btnMemberEdit;
        private TextBox tbxContactNumber;
        private TextBox tbxGender;
        private TextBox tbxMiddleInitial;
        private TextBox tbxLastname;
        private TextBox tbxFirstname;
        private DateTimePicker dtpBirthdate;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pbxMemberProfile;
        private TabPage tbpProperty;
        private TextBox tbxBlockNumber;
        private Label label14;
        private MaterialSkin.Controls.MaterialSwitch btnPropertyEdit;
        private ComboBox cbxOwnership;
        private Label label15;
        private Label label13;
        private TextBox tbxOccupantNum;
        private TextBox tbxUnitNumber;
        private TextBox tbxAddress;
        private TextBox tbxResidence;
        private Label label11;
        private Label label9;
        private Label label7;
        private TabPage tbpVehicle;
        private MaterialSkin.Controls.MaterialSwitch btnVehicleEdit;
        private Label label17;
        private TextBox tbxColor;
        private TextBox tbxPlateNumber;
        private TextBox tbxModel;
        private TextBox tbxMake;
        private Label label19;
        private Label label12;
        private Label label8;
        private PictureBox pbxVehicleImage;
        private TabPage tbpOccupants;
        private MaterialSkin.Controls.MaterialButton btnEditOccupant;
        private MaterialSkin.Controls.MaterialButton btnDeleteOccupant;
        private MaterialSkin.Controls.MaterialButton btnAddOccupant;
        private TabPage tbpHomeownerRequest;
        private MaterialSkin.Controls.MaterialButton btnView;
        private DataGridView dgvRequest;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colContext;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colDate;
        private TabPage tbpHome;
        private FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridView dgvOccupants;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private PictureBox pbxOccupantImage;
        private Label lblBirthday;
        private Label lblAge;
        private Label lblGender;
        private Label lblName;
        private LinkLabel linkLabel1;
    }
}