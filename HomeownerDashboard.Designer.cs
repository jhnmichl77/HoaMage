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
            tbpProfile = new TabPage();
            materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            tbpAccount = new TabPage();
            tbpMember = new TabPage();
            tbpProperty = new TabPage();
            tbpVehicle = new TabPage();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            tbpRequest = new TabPage();
            tbpPayment = new TabPage();
            imageList1 = new ImageList(components);
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            textBox1 = new TextBox();
            btnSubmit = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            materialTabControl1.SuspendLayout();
            tbpProfile.SuspendLayout();
            materialTabControl2.SuspendLayout();
            tbpRequest.SuspendLayout();
            tbpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tbpHome.TabIndex = 0;
            tbpHome.Text = "Home";
            tbpHome.UseVisualStyleBackColor = true;
            // 
            // tbpProfile
            // 
            tbpProfile.Controls.Add(materialTabControl2);
            tbpProfile.Controls.Add(materialTabSelector1);
            tbpProfile.ImageKey = "Manage.png";
            tbpProfile.Location = new Point(4, 39);
            tbpProfile.Name = "tbpProfile";
            tbpProfile.Padding = new Padding(3);
            tbpProfile.Size = new Size(863, 489);
            tbpProfile.TabIndex = 1;
            tbpProfile.Text = "Profile";
            tbpProfile.UseVisualStyleBackColor = true;
            // 
            // materialTabControl2
            // 
            materialTabControl2.Controls.Add(tbpAccount);
            materialTabControl2.Controls.Add(tbpMember);
            materialTabControl2.Controls.Add(tbpProperty);
            materialTabControl2.Controls.Add(tbpVehicle);
            materialTabControl2.Depth = 0;
            materialTabControl2.Dock = DockStyle.Fill;
            materialTabControl2.Location = new Point(3, 45);
            materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl2.Multiline = true;
            materialTabControl2.Name = "materialTabControl2";
            materialTabControl2.SelectedIndex = 0;
            materialTabControl2.Size = new Size(857, 441);
            materialTabControl2.TabIndex = 0;
            // 
            // tbpAccount
            // 
            tbpAccount.Location = new Point(4, 24);
            tbpAccount.Name = "tbpAccount";
            tbpAccount.Padding = new Padding(3);
            tbpAccount.Size = new Size(849, 413);
            tbpAccount.TabIndex = 0;
            tbpAccount.Text = "Account";
            tbpAccount.UseVisualStyleBackColor = true;
            // 
            // tbpMember
            // 
            tbpMember.Location = new Point(4, 24);
            tbpMember.Name = "tbpMember";
            tbpMember.Padding = new Padding(3);
            tbpMember.Size = new Size(849, 413);
            tbpMember.TabIndex = 1;
            tbpMember.Text = "Member";
            tbpMember.UseVisualStyleBackColor = true;
            // 
            // tbpProperty
            // 
            tbpProperty.Location = new Point(4, 24);
            tbpProperty.Name = "tbpProperty";
            tbpProperty.Padding = new Padding(3);
            tbpProperty.Size = new Size(849, 413);
            tbpProperty.TabIndex = 2;
            tbpProperty.Text = "Property";
            tbpProperty.UseVisualStyleBackColor = true;
            // 
            // tbpVehicle
            // 
            tbpVehicle.Location = new Point(4, 24);
            tbpVehicle.Name = "tbpVehicle";
            tbpVehicle.Padding = new Padding(3);
            tbpVehicle.Size = new Size(849, 413);
            tbpVehicle.TabIndex = 3;
            tbpVehicle.Text = "Vehicle";
            tbpVehicle.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl2;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Dock = DockStyle.Top;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(3, 3);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(857, 42);
            materialTabSelector1.TabIndex = 1;
            materialTabSelector1.Text = "materialTabSelector1";
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
            // tbpPayment
            // 
            tbpPayment.Controls.Add(dataGridView1);
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
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.Hint = "Type";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(22, 5);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(193, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 0;
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Subject";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(221, 6);
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
            // textBox1
            // 
            textBox1.Location = new Point(22, 61);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(825, 380);
            textBox1.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSubmit.Depth = 0;
            btnSubmit.HighEmphasis = true;
            btnSubmit.Icon = null;
            btnSubmit.Location = new Point(689, 447);
            btnSubmit.Margin = new Padding(4, 6, 4, 6);
            btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            btnSubmit.Name = "btnSubmit";
            btnSubmit.NoAccentTextColor = Color.Empty;
            btnSubmit.Size = new Size(75, 36);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSubmit.UseAccentColor = false;
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(512, 449);
            dataGridView1.TabIndex = 0;
            // 
            // HomeownerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 599);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Name = "HomeownerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homeowner Dashboard";
            materialTabControl1.ResumeLayout(false);
            tbpProfile.ResumeLayout(false);
            materialTabControl2.ResumeLayout(false);
            tbpRequest.ResumeLayout(false);
            tbpRequest.PerformLayout();
            tbpPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tbpHome;
        private TabPage tbpProfile;
        private TabPage tbpRequest;
        private TabPage tbpPayment;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private TabPage tbpAccount;
        private TabPage tbpMember;
        private TabPage tbpProperty;
        private TabPage tbpVehicle;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton btnSubmit;
        private TextBox textBox1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private DataGridView dataGridView1;
    }
}