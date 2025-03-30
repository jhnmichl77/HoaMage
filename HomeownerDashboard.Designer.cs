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
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tbpHome = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            tbpProfile = new TabPage();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            tbpMember = new TabPage();
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
            pictureBox2 = new PictureBox();
            tbpProperty = new TabPage();
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
            pictureBox3 = new PictureBox();
            tbpHomeownerRequest = new TabPage();
            dataGridView1 = new DataGridView();
            tbpOccupants = new TabPage();
            dgvOccupants = new MaterialSkin.Controls.MaterialListView();
            tbpRequest = new TabPage();
            btnSubmit = new MaterialSkin.Controls.MaterialButton();
            textBox1 = new TextBox();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            tbpPayment = new TabPage();
            btnPay = new MaterialSkin.Controls.MaterialButton();
            tbxCVV = new MaterialSkin.Controls.MaterialTextBox2();
            tbxExpiry = new MaterialSkin.Controls.MaterialTextBox2();
            tbxCardNumber = new MaterialSkin.Controls.MaterialTextBox2();
            tbxCardName = new MaterialSkin.Controls.MaterialTextBox2();
            tbxReference = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            dgvTransactions = new DataGridView();
            imageList1 = new ImageList(components);
            btnAddOccupant = new MaterialSkin.Controls.MaterialButton();
            btnDeleteOccupant = new MaterialSkin.Controls.MaterialButton();
            btnEditOccupant = new MaterialSkin.Controls.MaterialButton();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            lblName = new Label();
            lblGender = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            pbxOccupantImage = new PictureBox();
            materialTabControl1.SuspendLayout();
            tbpHome.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tbpProfile.SuspendLayout();
            materialTabControl2.SuspendLayout();
            tbpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tbpProperty.SuspendLayout();
            tbpVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tbpHomeownerRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbpOccupants.SuspendLayout();
            tbpRequest.SuspendLayout();
            tbpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxOccupantImage).BeginInit();
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
            tbpHome.Controls.Add(flowLayoutPanel1);
            tbpHome.ImageKey = "Home.png";
            tbpHome.Location = new Point(4, 39);
            tbpHome.Name = "tbpHome";
            tbpHome.Padding = new Padding(3);
            tbpHome.Size = new Size(863, 489);
            tbpHome.TabIndex = 0;
            tbpHome.Text = "Home";
            tbpHome.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(materialCard2);
            flowLayoutPanel1.Controls.Add(materialCard3);
            flowLayoutPanel1.Controls.Add(materialCard4);
            flowLayoutPanel1.Controls.Add(materialCard5);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(857, 483);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(14, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(186, 109);
            materialCard2.TabIndex = 0;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(228, 14);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(186, 109);
            materialCard3.TabIndex = 1;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(442, 14);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(186, 109);
            materialCard4.TabIndex = 2;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(656, 14);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(186, 109);
            materialCard5.TabIndex = 3;
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
            materialTabControl2.Controls.Add(tbpHomeownerRequest);
            materialTabControl2.Controls.Add(tbpOccupants);
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
            tbpMember.Controls.Add(pictureBox2);
            tbpMember.Location = new Point(4, 24);
            tbpMember.Name = "tbpMember";
            tbpMember.Padding = new Padding(3);
            tbpMember.Size = new Size(849, 395);
            tbpMember.TabIndex = 1;
            tbpMember.Text = "Member";
            tbpMember.UseVisualStyleBackColor = true;
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
            // 
            // tbxContactNumber
            // 
            tbxContactNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxContactNumber.Location = new Point(406, 329);
            tbxContactNumber.Name = "tbxContactNumber";
            tbxContactNumber.Size = new Size(260, 23);
            tbxContactNumber.TabIndex = 17;
            // 
            // tbxGender
            // 
            tbxGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxGender.Location = new Point(406, 271);
            tbxGender.Name = "tbxGender";
            tbxGender.Size = new Size(260, 23);
            tbxGender.TabIndex = 15;
            // 
            // tbxMiddleInitial
            // 
            tbxMiddleInitial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxMiddleInitial.Location = new Point(406, 155);
            tbxMiddleInitial.Name = "tbxMiddleInitial";
            tbxMiddleInitial.Size = new Size(260, 23);
            tbxMiddleInitial.TabIndex = 11;
            // 
            // tbxLastname
            // 
            tbxLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxLastname.Location = new Point(406, 97);
            tbxLastname.Name = "tbxLastname";
            tbxLastname.Size = new Size(260, 23);
            tbxLastname.TabIndex = 9;
            // 
            // tbxFirstname
            // 
            tbxFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxFirstname.Location = new Point(406, 39);
            tbxFirstname.Name = "tbxFirstname";
            tbxFirstname.Size = new Size(260, 23);
            tbxFirstname.TabIndex = 2;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Location = new Point(89, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 145);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tbpProperty
            // 
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
            // 
            // cbxOwnership
            // 
            cbxOwnership.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbxOwnership.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOwnership.FormattingEnabled = true;
            cbxOwnership.Items.AddRange(new object[] { "Renter", "Owner-Occupied", "Vacant" });
            cbxOwnership.Location = new Point(271, 283);
            cbxOwnership.Name = "cbxOwnership";
            cbxOwnership.Size = new Size(228, 23);
            cbxOwnership.TabIndex = 18;
            cbxOwnership.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(186, 291);
            label15.Name = "label15";
            label15.Size = new Size(67, 15);
            label15.TabIndex = 17;
            label15.Text = "Ownership:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(122, 233);
            label13.Name = "label13";
            label13.Size = new Size(128, 15);
            label13.TabIndex = 13;
            label13.Text = "Number of Occupants:";
            // 
            // tbxOccupantNum
            // 
            tbxOccupantNum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxOccupantNum.Location = new Point(271, 225);
            tbxOccupantNum.Name = "tbxOccupantNum";
            tbxOccupantNum.Size = new Size(228, 23);
            tbxOccupantNum.TabIndex = 12;
            // 
            // tbxUnitNumber
            // 
            tbxUnitNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxUnitNumber.Location = new Point(271, 167);
            tbxUnitNumber.Name = "tbxUnitNumber";
            tbxUnitNumber.Size = new Size(228, 23);
            tbxUnitNumber.TabIndex = 8;
            // 
            // tbxAddress
            // 
            tbxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxAddress.Location = new Point(271, 109);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(228, 23);
            tbxAddress.TabIndex = 4;
            // 
            // tbxResidence
            // 
            tbxResidence.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxResidence.Location = new Point(271, 51);
            tbxResidence.Name = "tbxResidence";
            tbxResidence.Size = new Size(228, 23);
            tbxResidence.TabIndex = 0;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(171, 175);
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
            tbpVehicle.Controls.Add(pictureBox3);
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
            tbxColor.Location = new Point(502, 291);
            tbxColor.Name = "tbxColor";
            tbxColor.Size = new Size(190, 23);
            tbxColor.TabIndex = 13;
            // 
            // tbxPlateNumber
            // 
            tbxPlateNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxPlateNumber.Location = new Point(502, 233);
            tbxPlateNumber.Name = "tbxPlateNumber";
            tbxPlateNumber.Size = new Size(190, 23);
            tbxPlateNumber.TabIndex = 9;
            // 
            // tbxModel
            // 
            tbxModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxModel.Location = new Point(502, 175);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(190, 23);
            tbxModel.TabIndex = 5;
            // 
            // tbxMake
            // 
            tbxMake.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Location = new Point(36, 54);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(324, 314);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // tbpHomeownerRequest
            // 
            tbpHomeownerRequest.Controls.Add(dataGridView1);
            tbpHomeownerRequest.Location = new Point(4, 24);
            tbpHomeownerRequest.Name = "tbpHomeownerRequest";
            tbpHomeownerRequest.Padding = new Padding(3);
            tbpHomeownerRequest.Size = new Size(849, 395);
            tbpHomeownerRequest.TabIndex = 4;
            tbpHomeownerRequest.Text = "Request";
            tbpHomeownerRequest.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(837, 383);
            dataGridView1.TabIndex = 0;
            // 
            // tbpOccupants
            // 
            tbpOccupants.Controls.Add(materialCard6);
            tbpOccupants.Controls.Add(btnEditOccupant);
            tbpOccupants.Controls.Add(btnDeleteOccupant);
            tbpOccupants.Controls.Add(btnAddOccupant);
            tbpOccupants.Controls.Add(dgvOccupants);
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
            dgvOccupants.AutoSizeTable = false;
            dgvOccupants.BackColor = Color.FromArgb(255, 255, 255);
            dgvOccupants.BorderStyle = BorderStyle.None;
            dgvOccupants.Depth = 0;
            dgvOccupants.FullRowSelect = true;
            dgvOccupants.Location = new Point(6, 6);
            dgvOccupants.MinimumSize = new Size(200, 100);
            dgvOccupants.MouseLocation = new Point(-1, -1);
            dgvOccupants.MouseState = MaterialSkin.MouseState.OUT;
            dgvOccupants.Name = "dgvOccupants";
            dgvOccupants.OwnerDraw = true;
            dgvOccupants.Size = new Size(380, 383);
            dgvOccupants.TabIndex = 0;
            dgvOccupants.UseCompatibleStateImageBehavior = false;
            dgvOccupants.View = View.Details;
            // 
            // tbpRequest
            // 
            tbpRequest.Controls.Add(btnSubmit);
            tbpRequest.Controls.Add(textBox1);
            tbpRequest.Controls.Add(materialTextBox21);
            tbpRequest.Controls.Add(materialComboBox1);
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 76);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(825, 380);
            textBox1.TabIndex = 2;
            // 
            // materialTextBox21
            // 
            materialTextBox21.Anchor = AnchorStyles.Top;
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Subject";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(220, 21);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(626, 48);
            materialTextBox21.TabIndex = 1;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.Hint = "Type";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "", "Complaints", "Maintainance", "Inquiry", "Report" });
            materialComboBox1.Location = new Point(21, 20);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(193, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 0;
            // 
            // tbpPayment
            // 
            tbpPayment.Controls.Add(btnPay);
            tbpPayment.Controls.Add(tbxCVV);
            tbpPayment.Controls.Add(tbxExpiry);
            tbpPayment.Controls.Add(tbxCardNumber);
            tbpPayment.Controls.Add(tbxCardName);
            tbpPayment.Controls.Add(tbxReference);
            tbpPayment.Controls.Add(materialCard1);
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
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPay.AutoSize = false;
            btnPay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPay.Depth = 0;
            btnPay.HighEmphasis = true;
            btnPay.Icon = null;
            btnPay.Location = new Point(557, 466);
            btnPay.Margin = new Padding(4, 6, 4, 6);
            btnPay.MouseState = MaterialSkin.MouseState.HOVER;
            btnPay.Name = "btnPay";
            btnPay.NoAccentTextColor = Color.Empty;
            btnPay.Size = new Size(277, 36);
            btnPay.TabIndex = 7;
            btnPay.Text = "Pay";
            btnPay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPay.UseAccentColor = false;
            btnPay.UseVisualStyleBackColor = true;
            // 
            // tbxCVV
            // 
            tbxCVV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tbxCVV.AnimateReadOnly = false;
            tbxCVV.BackgroundImageLayout = ImageLayout.None;
            tbxCVV.CharacterCasing = CharacterCasing.Normal;
            tbxCVV.Depth = 0;
            tbxCVV.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxCVV.HideSelection = true;
            tbxCVV.Hint = "CVV";
            tbxCVV.LeadingIcon = null;
            tbxCVV.Location = new Point(714, 409);
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
            tbxCVV.Size = new Size(120, 48);
            tbxCVV.TabIndex = 6;
            tbxCVV.TabStop = false;
            tbxCVV.TextAlign = HorizontalAlignment.Left;
            tbxCVV.TrailingIcon = null;
            tbxCVV.UseSystemPasswordChar = false;
            // 
            // tbxExpiry
            // 
            tbxExpiry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tbxExpiry.AnimateReadOnly = false;
            tbxExpiry.BackgroundImageLayout = ImageLayout.None;
            tbxExpiry.CharacterCasing = CharacterCasing.Normal;
            tbxExpiry.Depth = 0;
            tbxExpiry.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxExpiry.HideSelection = true;
            tbxExpiry.Hint = "Expiry (mm/yyyy)";
            tbxExpiry.LeadingIcon = null;
            tbxExpiry.Location = new Point(557, 409);
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
            tbxExpiry.Size = new Size(151, 48);
            tbxExpiry.TabIndex = 5;
            tbxExpiry.TabStop = false;
            tbxExpiry.TextAlign = HorizontalAlignment.Left;
            tbxExpiry.TrailingIcon = null;
            tbxExpiry.UseSystemPasswordChar = false;
            // 
            // tbxCardNumber
            // 
            tbxCardNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxCardNumber.AnimateReadOnly = false;
            tbxCardNumber.BackgroundImageLayout = ImageLayout.None;
            tbxCardNumber.CharacterCasing = CharacterCasing.Normal;
            tbxCardNumber.Depth = 0;
            tbxCardNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxCardNumber.HideSelection = true;
            tbxCardNumber.Hint = "Card Number";
            tbxCardNumber.LeadingIcon = null;
            tbxCardNumber.Location = new Point(557, 355);
            tbxCardNumber.MaxLength = 32767;
            tbxCardNumber.MouseState = MaterialSkin.MouseState.OUT;
            tbxCardNumber.Name = "tbxCardNumber";
            tbxCardNumber.PasswordChar = '●';
            tbxCardNumber.PrefixSuffixText = null;
            tbxCardNumber.ReadOnly = false;
            tbxCardNumber.RightToLeft = RightToLeft.No;
            tbxCardNumber.SelectedText = "";
            tbxCardNumber.SelectionLength = 0;
            tbxCardNumber.SelectionStart = 0;
            tbxCardNumber.ShortcutsEnabled = true;
            tbxCardNumber.Size = new Size(277, 48);
            tbxCardNumber.TabIndex = 4;
            tbxCardNumber.TabStop = false;
            tbxCardNumber.TextAlign = HorizontalAlignment.Left;
            tbxCardNumber.TrailingIcon = null;
            tbxCardNumber.UseSystemPasswordChar = true;
            // 
            // tbxCardName
            // 
            tbxCardName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxCardName.AnimateReadOnly = false;
            tbxCardName.BackgroundImageLayout = ImageLayout.None;
            tbxCardName.CharacterCasing = CharacterCasing.Normal;
            tbxCardName.Depth = 0;
            tbxCardName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxCardName.HideSelection = true;
            tbxCardName.Hint = "Account Name";
            tbxCardName.LeadingIcon = null;
            tbxCardName.Location = new Point(557, 301);
            tbxCardName.MaxLength = 32767;
            tbxCardName.MouseState = MaterialSkin.MouseState.OUT;
            tbxCardName.Name = "tbxCardName";
            tbxCardName.PasswordChar = '\0';
            tbxCardName.PrefixSuffixText = null;
            tbxCardName.ReadOnly = false;
            tbxCardName.RightToLeft = RightToLeft.No;
            tbxCardName.SelectedText = "";
            tbxCardName.SelectionLength = 0;
            tbxCardName.SelectionStart = 0;
            tbxCardName.ShortcutsEnabled = true;
            tbxCardName.Size = new Size(277, 48);
            tbxCardName.TabIndex = 3;
            tbxCardName.TabStop = false;
            tbxCardName.TextAlign = HorizontalAlignment.Left;
            tbxCardName.TrailingIcon = null;
            tbxCardName.UseSystemPasswordChar = false;
            // 
            // tbxReference
            // 
            tbxReference.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbxReference.AnimateReadOnly = false;
            tbxReference.BackgroundImageLayout = ImageLayout.None;
            tbxReference.CharacterCasing = CharacterCasing.Normal;
            tbxReference.Depth = 0;
            tbxReference.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxReference.HideSelection = true;
            tbxReference.Hint = "Reference";
            tbxReference.LeadingIcon = null;
            tbxReference.Location = new Point(557, 247);
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
            tbxReference.Size = new Size(277, 48);
            tbxReference.TabIndex = 2;
            tbxReference.TabStop = false;
            tbxReference.TextAlign = HorizontalAlignment.Left;
            tbxReference.TrailingIcon = null;
            tbxReference.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(557, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MaximumSize = new Size(277, 172);
            materialCard1.MinimumSize = new Size(277, 172);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(277, 172);
            materialCard1.TabIndex = 1;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(18, 20);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(512, 449);
            dgvTransactions.TabIndex = 0;
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
            // pbxOccupantImage
            // 
            pbxOccupantImage.Location = new Point(27, 49);
            pbxOccupantImage.Name = "pbxOccupantImage";
            pbxOccupantImage.Size = new Size(100, 100);
            pbxOccupantImage.TabIndex = 4;
            pbxOccupantImage.TabStop = false;
            // 
            // HomeownerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 599);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            MaximumSize = new Size(877, 599);
            MinimumSize = new Size(877, 599);
            Name = "HomeownerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homeowner Dashboard";
            materialTabControl1.ResumeLayout(false);
            tbpHome.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tbpProfile.ResumeLayout(false);
            materialTabControl2.ResumeLayout(false);
            tbpMember.ResumeLayout(false);
            tbpMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tbpProperty.ResumeLayout(false);
            tbpProperty.PerformLayout();
            tbpVehicle.ResumeLayout(false);
            tbpVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tbpHomeownerRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbpOccupants.ResumeLayout(false);
            tbpOccupants.PerformLayout();
            tbpRequest.ResumeLayout(false);
            tbpRequest.PerformLayout();
            tbpPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxOccupantImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tbpHome;
        private TabPage tbpProfile;
        private TabPage tbpRequest;
        private TabPage tbpPayment;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton btnSubmit;
        private TextBox textBox1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private DataGridView dgvTransactions;
        private MaterialSkin.Controls.MaterialButton btnPay;
        private MaterialSkin.Controls.MaterialTextBox2 tbxCVV;
        private MaterialSkin.Controls.MaterialTextBox2 tbxExpiry;
        private MaterialSkin.Controls.MaterialTextBox2 tbxCardNumber;
        private MaterialSkin.Controls.MaterialTextBox2 tbxCardName;
        private MaterialSkin.Controls.MaterialTextBox2 tbxReference;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private TabPage tbpMember;
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
        private PictureBox pictureBox2;
        private TabPage tbpProperty;
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
        private Label label17;
        private TextBox tbxColor;
        private TextBox tbxPlateNumber;
        private TextBox tbxModel;
        private TextBox tbxMake;
        private Label label19;
        private Label label12;
        private Label label8;
        private PictureBox pictureBox3;
        private TabPage tbpHomeownerRequest;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialSwitch btnMemberEdit;
        private MaterialSkin.Controls.MaterialSwitch btnPropertyEdit;
        private MaterialSkin.Controls.MaterialSwitch btnVehicleEdit;
        private TabPage tbpOccupants;
        private MaterialSkin.Controls.MaterialListView dgvOccupants;
        private MaterialSkin.Controls.MaterialButton btnAddOccupant;
        private MaterialSkin.Controls.MaterialButton btnDeleteOccupant;
        private MaterialSkin.Controls.MaterialButton btnEditOccupant;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private PictureBox pbxOccupantImage;
        private Label lblBirthday;
        private Label lblAge;
        private Label lblGender;
        private Label lblName;
        private Button button1;
    }
}