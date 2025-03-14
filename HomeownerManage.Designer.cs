namespace HoaMage
{
    partial class HomeownerManage
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
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            MemberInformation = new TabPage();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            tbxGender = new MaterialSkin.Controls.MaterialTextBox2();
            tbxContactNumber = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            tbxBirthday = new MaterialSkin.Controls.MaterialTextBox2();
            tbxMiddleInitial = new MaterialSkin.Controls.MaterialTextBox2();
            tbxFirstName = new MaterialSkin.Controls.MaterialTextBox2();
            tbxLastName = new MaterialSkin.Controls.MaterialTextBox2();
            PropertyInformation = new TabPage();
            btnAdd = new MaterialSkin.Controls.MaterialFloatingActionButton();
            label1 = new Label();
            lbxOccupants = new MaterialSkin.Controls.MaterialListView();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            tbxOwnership = new MaterialSkin.Controls.MaterialTextBox2();
            tbxOccupantNum = new MaterialSkin.Controls.MaterialTextBox2();
            tbxUnitNumber = new MaterialSkin.Controls.MaterialTextBox2();
            tbxHomeAddress = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            tbxResidence = new MaterialSkin.Controls.MaterialTextBox2();
            VehicleInformation = new TabPage();
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            tbxColor = new MaterialSkin.Controls.MaterialTextBox2();
            tbxModel = new MaterialSkin.Controls.MaterialTextBox2();
            tbxMake = new MaterialSkin.Controls.MaterialTextBox2();
            tbxPlateNumber = new MaterialSkin.Controls.MaterialTextBox2();
            label2 = new Label();
            materialTabControl1.SuspendLayout();
            MemberInformation.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            PropertyInformation.SuspendLayout();
            materialCard1.SuspendLayout();
            VehicleInformation.SuspendLayout();
            materialCard4.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(3, 3);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(721, 48);
            materialTabSelector1.TabIndex = 0;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(MemberInformation);
            materialTabControl1.Controls.Add(PropertyInformation);
            materialTabControl1.Controls.Add(VehicleInformation);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new Point(3, 48);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(721, 397);
            materialTabControl1.TabIndex = 1;
            // 
            // MemberInformation
            // 
            MemberInformation.Controls.Add(materialCard3);
            MemberInformation.Controls.Add(materialCard2);
            MemberInformation.Location = new Point(4, 24);
            MemberInformation.Name = "MemberInformation";
            MemberInformation.Padding = new Padding(3);
            MemberInformation.Size = new Size(713, 339);
            MemberInformation.TabIndex = 0;
            MemberInformation.Text = "Member Information";
            MemberInformation.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(tbxGender);
            materialCard3.Controls.Add(tbxContactNumber);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(326, 42);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(346, 222);
            materialCard3.TabIndex = 1;
            // 
            // tbxGender
            // 
            tbxGender.AnimateReadOnly = false;
            tbxGender.BackgroundImageLayout = ImageLayout.None;
            tbxGender.CharacterCasing = CharacterCasing.Normal;
            tbxGender.Depth = 0;
            tbxGender.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxGender.HideSelection = true;
            tbxGender.Hint = "Gender";
            tbxGender.LeadingIcon = null;
            tbxGender.Location = new Point(17, 116);
            tbxGender.MaxLength = 32767;
            tbxGender.MouseState = MaterialSkin.MouseState.OUT;
            tbxGender.Name = "tbxGender";
            tbxGender.PasswordChar = '\0';
            tbxGender.PrefixSuffixText = null;
            tbxGender.ReadOnly = false;
            tbxGender.RightToLeft = RightToLeft.No;
            tbxGender.SelectedText = "";
            tbxGender.SelectionLength = 0;
            tbxGender.SelectionStart = 0;
            tbxGender.ShortcutsEnabled = true;
            tbxGender.Size = new Size(144, 48);
            tbxGender.TabIndex = 7;
            tbxGender.TabStop = false;
            tbxGender.TextAlign = HorizontalAlignment.Left;
            tbxGender.TrailingIcon = null;
            tbxGender.UseSystemPasswordChar = false;
            // 
            // tbxContactNumber
            // 
            tbxContactNumber.AnimateReadOnly = false;
            tbxContactNumber.BackgroundImageLayout = ImageLayout.None;
            tbxContactNumber.CharacterCasing = CharacterCasing.Normal;
            tbxContactNumber.Depth = 0;
            tbxContactNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxContactNumber.HideSelection = true;
            tbxContactNumber.Hint = "Contact Number";
            tbxContactNumber.LeadingIcon = null;
            tbxContactNumber.Location = new Point(17, 28);
            tbxContactNumber.MaxLength = 32767;
            tbxContactNumber.MouseState = MaterialSkin.MouseState.OUT;
            tbxContactNumber.Name = "tbxContactNumber";
            tbxContactNumber.PasswordChar = '\0';
            tbxContactNumber.PrefixSuffixText = null;
            tbxContactNumber.ReadOnly = false;
            tbxContactNumber.RightToLeft = RightToLeft.No;
            tbxContactNumber.SelectedText = "";
            tbxContactNumber.SelectionLength = 0;
            tbxContactNumber.SelectionStart = 0;
            tbxContactNumber.ShortcutsEnabled = true;
            tbxContactNumber.Size = new Size(298, 48);
            tbxContactNumber.TabIndex = 6;
            tbxContactNumber.TabStop = false;
            tbxContactNumber.TextAlign = HorizontalAlignment.Left;
            tbxContactNumber.TrailingIcon = null;
            tbxContactNumber.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(tbxBirthday);
            materialCard2.Controls.Add(tbxMiddleInitial);
            materialCard2.Controls.Add(tbxFirstName);
            materialCard2.Controls.Add(tbxLastName);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(30, 42);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(268, 222);
            materialCard2.TabIndex = 0;
            // 
            // tbxBirthday
            // 
            tbxBirthday.AnimateReadOnly = false;
            tbxBirthday.BackgroundImageLayout = ImageLayout.None;
            tbxBirthday.CharacterCasing = CharacterCasing.Normal;
            tbxBirthday.Depth = 0;
            tbxBirthday.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxBirthday.HideSelection = true;
            tbxBirthday.Hint = "Birthdate";
            tbxBirthday.LeadingIcon = null;
            tbxBirthday.Location = new Point(130, 147);
            tbxBirthday.MaxLength = 32767;
            tbxBirthday.MouseState = MaterialSkin.MouseState.OUT;
            tbxBirthday.Name = "tbxBirthday";
            tbxBirthday.PasswordChar = '\0';
            tbxBirthday.PrefixSuffixText = null;
            tbxBirthday.ReadOnly = false;
            tbxBirthday.RightToLeft = RightToLeft.No;
            tbxBirthday.SelectedText = "";
            tbxBirthday.SelectionLength = 0;
            tbxBirthday.SelectionStart = 0;
            tbxBirthday.ShortcutsEnabled = true;
            tbxBirthday.Size = new Size(121, 48);
            tbxBirthday.TabIndex = 5;
            tbxBirthday.TabStop = false;
            tbxBirthday.TextAlign = HorizontalAlignment.Left;
            tbxBirthday.TrailingIcon = null;
            tbxBirthday.UseSystemPasswordChar = false;
            // 
            // tbxMiddleInitial
            // 
            tbxMiddleInitial.AnimateReadOnly = false;
            tbxMiddleInitial.BackgroundImageLayout = ImageLayout.None;
            tbxMiddleInitial.CharacterCasing = CharacterCasing.Normal;
            tbxMiddleInitial.Depth = 0;
            tbxMiddleInitial.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxMiddleInitial.HideSelection = true;
            tbxMiddleInitial.Hint = "M.I.";
            tbxMiddleInitial.LeadingIcon = null;
            tbxMiddleInitial.Location = new Point(17, 147);
            tbxMiddleInitial.MaxLength = 32767;
            tbxMiddleInitial.MouseState = MaterialSkin.MouseState.OUT;
            tbxMiddleInitial.Name = "tbxMiddleInitial";
            tbxMiddleInitial.PasswordChar = '\0';
            tbxMiddleInitial.PrefixSuffixText = null;
            tbxMiddleInitial.ReadOnly = false;
            tbxMiddleInitial.RightToLeft = RightToLeft.No;
            tbxMiddleInitial.SelectedText = "";
            tbxMiddleInitial.SelectionLength = 0;
            tbxMiddleInitial.SelectionStart = 0;
            tbxMiddleInitial.ShortcutsEnabled = true;
            tbxMiddleInitial.Size = new Size(107, 48);
            tbxMiddleInitial.TabIndex = 4;
            tbxMiddleInitial.TabStop = false;
            tbxMiddleInitial.TextAlign = HorizontalAlignment.Left;
            tbxMiddleInitial.TrailingIcon = null;
            tbxMiddleInitial.UseSystemPasswordChar = false;
            // 
            // tbxFirstName
            // 
            tbxFirstName.AnimateReadOnly = false;
            tbxFirstName.BackgroundImageLayout = ImageLayout.None;
            tbxFirstName.CharacterCasing = CharacterCasing.Normal;
            tbxFirstName.Depth = 0;
            tbxFirstName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxFirstName.HideSelection = true;
            tbxFirstName.Hint = "Firstname";
            tbxFirstName.LeadingIcon = null;
            tbxFirstName.Location = new Point(17, 83);
            tbxFirstName.MaxLength = 32767;
            tbxFirstName.MouseState = MaterialSkin.MouseState.OUT;
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.PasswordChar = '\0';
            tbxFirstName.PrefixSuffixText = null;
            tbxFirstName.ReadOnly = false;
            tbxFirstName.RightToLeft = RightToLeft.No;
            tbxFirstName.SelectedText = "";
            tbxFirstName.SelectionLength = 0;
            tbxFirstName.SelectionStart = 0;
            tbxFirstName.ShortcutsEnabled = true;
            tbxFirstName.Size = new Size(234, 48);
            tbxFirstName.TabIndex = 3;
            tbxFirstName.TabStop = false;
            tbxFirstName.TextAlign = HorizontalAlignment.Left;
            tbxFirstName.TrailingIcon = null;
            tbxFirstName.UseSystemPasswordChar = false;
            // 
            // tbxLastName
            // 
            tbxLastName.AnimateReadOnly = false;
            tbxLastName.BackgroundImageLayout = ImageLayout.None;
            tbxLastName.CharacterCasing = CharacterCasing.Normal;
            tbxLastName.Depth = 0;
            tbxLastName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxLastName.HideSelection = true;
            tbxLastName.Hint = "Lastname";
            tbxLastName.LeadingIcon = null;
            tbxLastName.Location = new Point(17, 17);
            tbxLastName.MaxLength = 32767;
            tbxLastName.MouseState = MaterialSkin.MouseState.OUT;
            tbxLastName.Name = "tbxLastName";
            tbxLastName.PasswordChar = '\0';
            tbxLastName.PrefixSuffixText = null;
            tbxLastName.ReadOnly = false;
            tbxLastName.RightToLeft = RightToLeft.No;
            tbxLastName.SelectedText = "";
            tbxLastName.SelectionLength = 0;
            tbxLastName.SelectionStart = 0;
            tbxLastName.ShortcutsEnabled = true;
            tbxLastName.Size = new Size(234, 48);
            tbxLastName.TabIndex = 2;
            tbxLastName.TabStop = false;
            tbxLastName.TextAlign = HorizontalAlignment.Left;
            tbxLastName.TrailingIcon = null;
            tbxLastName.UseSystemPasswordChar = false;
            // 
            // PropertyInformation
            // 
            PropertyInformation.Controls.Add(btnAdd);
            PropertyInformation.Controls.Add(label1);
            PropertyInformation.Controls.Add(lbxOccupants);
            PropertyInformation.Controls.Add(materialCard1);
            PropertyInformation.Location = new Point(4, 24);
            PropertyInformation.Name = "PropertyInformation";
            PropertyInformation.Padding = new Padding(3);
            PropertyInformation.Size = new Size(713, 369);
            PropertyInformation.TabIndex = 1;
            PropertyInformation.Text = "Property Information";
            PropertyInformation.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Depth = 0;
            btnAdd.Icon = Properties.Resources._5b3376c4_b705_4da0_b92e_eea6c7a0561a_removalai_preview;
            btnAdd.Location = new Point(259, 296);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 58);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "materialFloatingActionButton1";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F);
            label1.Location = new Point(318, 17);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 2;
            label1.Text = "Occupants";
            // 
            // lbxOccupants
            // 
            lbxOccupants.AutoSizeTable = false;
            lbxOccupants.BackColor = Color.FromArgb(255, 255, 255);
            lbxOccupants.BorderStyle = BorderStyle.None;
            lbxOccupants.Depth = 0;
            lbxOccupants.FullRowSelect = true;
            lbxOccupants.Location = new Point(318, 42);
            lbxOccupants.MinimumSize = new Size(200, 100);
            lbxOccupants.MouseLocation = new Point(-1, -1);
            lbxOccupants.MouseState = MaterialSkin.MouseState.OUT;
            lbxOccupants.Name = "lbxOccupants";
            lbxOccupants.OwnerDraw = true;
            lbxOccupants.Size = new Size(381, 286);
            lbxOccupants.TabIndex = 1;
            lbxOccupants.UseCompatibleStateImageBehavior = false;
            lbxOccupants.View = View.Details;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(tbxOwnership);
            materialCard1.Controls.Add(tbxOccupantNum);
            materialCard1.Controls.Add(tbxUnitNumber);
            materialCard1.Controls.Add(tbxHomeAddress);
            materialCard1.Controls.Add(tbxResidence);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(296, 265);
            materialCard1.TabIndex = 0;
            // 
            // tbxOwnership
            // 
            tbxOwnership.AnimateReadOnly = false;
            tbxOwnership.BackgroundImageLayout = ImageLayout.None;
            tbxOwnership.CharacterCasing = CharacterCasing.Normal;
            tbxOwnership.Depth = 0;
            tbxOwnership.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxOwnership.HideSelection = true;
            tbxOwnership.Hint = "Ownership";
            tbxOwnership.LeadingIcon = null;
            tbxOwnership.Location = new Point(147, 155);
            tbxOwnership.MaxLength = 32767;
            tbxOwnership.MouseState = MaterialSkin.MouseState.OUT;
            tbxOwnership.Name = "tbxOwnership";
            tbxOwnership.PasswordChar = '\0';
            tbxOwnership.PrefixSuffixText = null;
            tbxOwnership.ReadOnly = false;
            tbxOwnership.RightToLeft = RightToLeft.No;
            tbxOwnership.SelectedText = "";
            tbxOwnership.SelectionLength = 0;
            tbxOwnership.SelectionStart = 0;
            tbxOwnership.ShortcutsEnabled = true;
            tbxOwnership.Size = new Size(132, 48);
            tbxOwnership.TabIndex = 5;
            tbxOwnership.TabStop = false;
            tbxOwnership.TextAlign = HorizontalAlignment.Left;
            tbxOwnership.TrailingIcon = null;
            tbxOwnership.UseSystemPasswordChar = false;
            // 
            // tbxOccupantNum
            // 
            tbxOccupantNum.AnimateReadOnly = false;
            tbxOccupantNum.BackgroundImageLayout = ImageLayout.None;
            tbxOccupantNum.CharacterCasing = CharacterCasing.Normal;
            tbxOccupantNum.Depth = 0;
            tbxOccupantNum.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxOccupantNum.HideSelection = true;
            tbxOccupantNum.Hint = "Num of Occupants";
            tbxOccupantNum.LeadingIcon = null;
            tbxOccupantNum.Location = new Point(17, 209);
            tbxOccupantNum.MaxLength = 32767;
            tbxOccupantNum.MouseState = MaterialSkin.MouseState.OUT;
            tbxOccupantNum.Name = "tbxOccupantNum";
            tbxOccupantNum.PasswordChar = '\0';
            tbxOccupantNum.PrefixSuffixText = null;
            tbxOccupantNum.ReadOnly = false;
            tbxOccupantNum.RightToLeft = RightToLeft.No;
            tbxOccupantNum.SelectedText = "";
            tbxOccupantNum.SelectionLength = 0;
            tbxOccupantNum.SelectionStart = 0;
            tbxOccupantNum.ShortcutsEnabled = true;
            tbxOccupantNum.Size = new Size(167, 48);
            tbxOccupantNum.TabIndex = 4;
            tbxOccupantNum.TabStop = false;
            tbxOccupantNum.TextAlign = HorizontalAlignment.Left;
            tbxOccupantNum.TrailingIcon = null;
            tbxOccupantNum.UseSystemPasswordChar = false;
            // 
            // tbxUnitNumber
            // 
            tbxUnitNumber.AnimateReadOnly = false;
            tbxUnitNumber.BackgroundImageLayout = ImageLayout.None;
            tbxUnitNumber.CharacterCasing = CharacterCasing.Normal;
            tbxUnitNumber.Depth = 0;
            tbxUnitNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxUnitNumber.HideSelection = true;
            tbxUnitNumber.Hint = "Unit Number";
            tbxUnitNumber.LeadingIcon = null;
            tbxUnitNumber.Location = new Point(17, 155);
            tbxUnitNumber.MaxLength = 32767;
            tbxUnitNumber.MouseState = MaterialSkin.MouseState.OUT;
            tbxUnitNumber.Name = "tbxUnitNumber";
            tbxUnitNumber.PasswordChar = '\0';
            tbxUnitNumber.PrefixSuffixText = null;
            tbxUnitNumber.ReadOnly = false;
            tbxUnitNumber.RightToLeft = RightToLeft.No;
            tbxUnitNumber.SelectedText = "";
            tbxUnitNumber.SelectionLength = 0;
            tbxUnitNumber.SelectionStart = 0;
            tbxUnitNumber.ShortcutsEnabled = true;
            tbxUnitNumber.Size = new Size(124, 48);
            tbxUnitNumber.TabIndex = 3;
            tbxUnitNumber.TabStop = false;
            tbxUnitNumber.TextAlign = HorizontalAlignment.Left;
            tbxUnitNumber.TrailingIcon = null;
            tbxUnitNumber.UseSystemPasswordChar = false;
            // 
            // tbxHomeAddress
            // 
            tbxHomeAddress.AnimateReadOnly = false;
            tbxHomeAddress.BackgroundImageLayout = ImageLayout.None;
            tbxHomeAddress.CharacterCasing = CharacterCasing.Normal;
            tbxHomeAddress.Depth = 0;
            tbxHomeAddress.HideSelection = true;
            tbxHomeAddress.Hint = "HomeAddress";
            tbxHomeAddress.Location = new Point(17, 71);
            tbxHomeAddress.MaxLength = 32767;
            tbxHomeAddress.MouseState = MaterialSkin.MouseState.OUT;
            tbxHomeAddress.Name = "tbxHomeAddress";
            tbxHomeAddress.PasswordChar = '\0';
            tbxHomeAddress.ReadOnly = false;
            tbxHomeAddress.ScrollBars = ScrollBars.None;
            tbxHomeAddress.SelectedText = "";
            tbxHomeAddress.SelectionLength = 0;
            tbxHomeAddress.SelectionStart = 0;
            tbxHomeAddress.ShortcutsEnabled = true;
            tbxHomeAddress.Size = new Size(262, 78);
            tbxHomeAddress.TabIndex = 2;
            tbxHomeAddress.TabStop = false;
            tbxHomeAddress.TextAlign = HorizontalAlignment.Left;
            tbxHomeAddress.UseSystemPasswordChar = false;
            // 
            // tbxResidence
            // 
            tbxResidence.AnimateReadOnly = false;
            tbxResidence.BackgroundImageLayout = ImageLayout.None;
            tbxResidence.CharacterCasing = CharacterCasing.Normal;
            tbxResidence.Depth = 0;
            tbxResidence.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxResidence.HideSelection = true;
            tbxResidence.Hint = "Residence";
            tbxResidence.LeadingIcon = null;
            tbxResidence.Location = new Point(17, 17);
            tbxResidence.MaxLength = 32767;
            tbxResidence.MouseState = MaterialSkin.MouseState.OUT;
            tbxResidence.Name = "tbxResidence";
            tbxResidence.PasswordChar = '\0';
            tbxResidence.PrefixSuffixText = null;
            tbxResidence.ReadOnly = false;
            tbxResidence.RightToLeft = RightToLeft.No;
            tbxResidence.SelectedText = "";
            tbxResidence.SelectionLength = 0;
            tbxResidence.SelectionStart = 0;
            tbxResidence.ShortcutsEnabled = true;
            tbxResidence.Size = new Size(262, 48);
            tbxResidence.TabIndex = 0;
            tbxResidence.TabStop = false;
            tbxResidence.TextAlign = HorizontalAlignment.Left;
            tbxResidence.TrailingIcon = null;
            tbxResidence.UseSystemPasswordChar = false;
            // 
            // VehicleInformation
            // 
            VehicleInformation.Controls.Add(label2);
            VehicleInformation.Controls.Add(materialListBox1);
            VehicleInformation.Controls.Add(materialCard4);
            VehicleInformation.Location = new Point(4, 24);
            VehicleInformation.Name = "VehicleInformation";
            VehicleInformation.Size = new Size(713, 369);
            VehicleInformation.TabIndex = 2;
            VehicleInformation.Text = "Vehicle Information";
            VehicleInformation.UseVisualStyleBackColor = true;
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBox1.Location = new Point(320, 31);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(377, 323);
            materialListBox1.TabIndex = 1;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(tbxColor);
            materialCard4.Controls.Add(tbxModel);
            materialCard4.Controls.Add(tbxMake);
            materialCard4.Controls.Add(tbxPlateNumber);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(23, 14);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(280, 253);
            materialCard4.TabIndex = 0;
            // 
            // tbxColor
            // 
            tbxColor.AnimateReadOnly = false;
            tbxColor.BackgroundImageLayout = ImageLayout.None;
            tbxColor.CharacterCasing = CharacterCasing.Normal;
            tbxColor.Depth = 0;
            tbxColor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxColor.HideSelection = true;
            tbxColor.Hint = "Color";
            tbxColor.LeadingIcon = null;
            tbxColor.Location = new Point(13, 179);
            tbxColor.MaxLength = 32767;
            tbxColor.MouseState = MaterialSkin.MouseState.OUT;
            tbxColor.Name = "tbxColor";
            tbxColor.PasswordChar = '\0';
            tbxColor.PrefixSuffixText = null;
            tbxColor.ReadOnly = false;
            tbxColor.RightToLeft = RightToLeft.No;
            tbxColor.SelectedText = "";
            tbxColor.SelectionLength = 0;
            tbxColor.SelectionStart = 0;
            tbxColor.ShortcutsEnabled = true;
            tbxColor.Size = new Size(250, 48);
            tbxColor.TabIndex = 3;
            tbxColor.TabStop = false;
            tbxColor.TextAlign = HorizontalAlignment.Left;
            tbxColor.TrailingIcon = null;
            tbxColor.UseSystemPasswordChar = false;
            // 
            // tbxModel
            // 
            tbxModel.AnimateReadOnly = false;
            tbxModel.BackgroundImageLayout = ImageLayout.None;
            tbxModel.CharacterCasing = CharacterCasing.Normal;
            tbxModel.Depth = 0;
            tbxModel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxModel.HideSelection = true;
            tbxModel.Hint = "Model";
            tbxModel.LeadingIcon = null;
            tbxModel.Location = new Point(13, 125);
            tbxModel.MaxLength = 32767;
            tbxModel.MouseState = MaterialSkin.MouseState.OUT;
            tbxModel.Name = "tbxModel";
            tbxModel.PasswordChar = '\0';
            tbxModel.PrefixSuffixText = null;
            tbxModel.ReadOnly = false;
            tbxModel.RightToLeft = RightToLeft.No;
            tbxModel.SelectedText = "";
            tbxModel.SelectionLength = 0;
            tbxModel.SelectionStart = 0;
            tbxModel.ShortcutsEnabled = true;
            tbxModel.Size = new Size(250, 48);
            tbxModel.TabIndex = 2;
            tbxModel.TabStop = false;
            tbxModel.TextAlign = HorizontalAlignment.Left;
            tbxModel.TrailingIcon = null;
            tbxModel.UseSystemPasswordChar = false;
            // 
            // tbxMake
            // 
            tbxMake.AnimateReadOnly = false;
            tbxMake.BackgroundImageLayout = ImageLayout.None;
            tbxMake.CharacterCasing = CharacterCasing.Normal;
            tbxMake.Depth = 0;
            tbxMake.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxMake.HideSelection = true;
            tbxMake.Hint = "Make";
            tbxMake.LeadingIcon = null;
            tbxMake.Location = new Point(13, 71);
            tbxMake.MaxLength = 32767;
            tbxMake.MouseState = MaterialSkin.MouseState.OUT;
            tbxMake.Name = "tbxMake";
            tbxMake.PasswordChar = '\0';
            tbxMake.PrefixSuffixText = null;
            tbxMake.ReadOnly = false;
            tbxMake.RightToLeft = RightToLeft.No;
            tbxMake.SelectedText = "";
            tbxMake.SelectionLength = 0;
            tbxMake.SelectionStart = 0;
            tbxMake.ShortcutsEnabled = true;
            tbxMake.Size = new Size(250, 48);
            tbxMake.TabIndex = 1;
            tbxMake.TabStop = false;
            tbxMake.TextAlign = HorizontalAlignment.Left;
            tbxMake.TrailingIcon = null;
            tbxMake.UseSystemPasswordChar = false;
            // 
            // tbxPlateNumber
            // 
            tbxPlateNumber.AnimateReadOnly = false;
            tbxPlateNumber.BackgroundImageLayout = ImageLayout.None;
            tbxPlateNumber.CharacterCasing = CharacterCasing.Normal;
            tbxPlateNumber.Depth = 0;
            tbxPlateNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxPlateNumber.HideSelection = true;
            tbxPlateNumber.Hint = "Plate Number";
            tbxPlateNumber.LeadingIcon = null;
            tbxPlateNumber.Location = new Point(13, 17);
            tbxPlateNumber.MaxLength = 32767;
            tbxPlateNumber.MouseState = MaterialSkin.MouseState.OUT;
            tbxPlateNumber.Name = "tbxPlateNumber";
            tbxPlateNumber.PasswordChar = '\0';
            tbxPlateNumber.PrefixSuffixText = null;
            tbxPlateNumber.ReadOnly = false;
            tbxPlateNumber.RightToLeft = RightToLeft.No;
            tbxPlateNumber.SelectedText = "";
            tbxPlateNumber.SelectionLength = 0;
            tbxPlateNumber.SelectionStart = 0;
            tbxPlateNumber.ShortcutsEnabled = true;
            tbxPlateNumber.Size = new Size(250, 48);
            tbxPlateNumber.TabIndex = 0;
            tbxPlateNumber.TabStop = false;
            tbxPlateNumber.TextAlign = HorizontalAlignment.Left;
            tbxPlateNumber.TrailingIcon = null;
            tbxPlateNumber.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(320, 8);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Vehicles";
            // 
            // HomeownerManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialTabControl1);
            Controls.Add(materialTabSelector1);
            Name = "HomeownerManage";
            Size = new Size(727, 445);
            materialTabControl1.ResumeLayout(false);
            MemberInformation.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            PropertyInformation.ResumeLayout(false);
            PropertyInformation.PerformLayout();
            materialCard1.ResumeLayout(false);
            VehicleInformation.ResumeLayout(false);
            VehicleInformation.PerformLayout();
            materialCard4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage MemberInformation;
        private TabPage PropertyInformation;
        private TabPage VehicleInformation;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox2 tbxGender;
        private MaterialSkin.Controls.MaterialTextBox2 tbxContactNumber;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox2 tbxBirthday;
        private MaterialSkin.Controls.MaterialTextBox2 tbxMiddleInitial;
        private MaterialSkin.Controls.MaterialTextBox2 tbxFirstName;
        private MaterialSkin.Controls.MaterialTextBox2 tbxLastName;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialListView lbxOccupants;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 tbxOwnership;
        private MaterialSkin.Controls.MaterialTextBox2 tbxOccupantNum;
        private MaterialSkin.Controls.MaterialTextBox2 tbxUnitNumber;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbxHomeAddress;
        private MaterialSkin.Controls.MaterialTextBox2 tbxResidence;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnAdd;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialTextBox2 tbxColor;
        private MaterialSkin.Controls.MaterialTextBox2 tbxModel;
        private MaterialSkin.Controls.MaterialTextBox2 tbxMake;
        private MaterialSkin.Controls.MaterialTextBox2 tbxPlateNumber;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private Label label2;
    }
}
