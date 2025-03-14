namespace HoaMage
{
    partial class AdminManage
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
            tbxSearch = new MaterialSkin.Controls.MaterialTextBox2();
            btnMember = new Button();
            btnProperty = new Button();
            btnVehicle = new Button();
            panel1 = new Panel();
            dgvAdminDisplay = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminDisplay).BeginInit();
            SuspendLayout();
            // 
            // tbxSearch
            // 
            tbxSearch.AnimateReadOnly = false;
            tbxSearch.BackgroundImageLayout = ImageLayout.None;
            tbxSearch.CharacterCasing = CharacterCasing.Normal;
            tbxSearch.Depth = 0;
            tbxSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxSearch.HideSelection = true;
            tbxSearch.Hint = "Search";
            tbxSearch.LeadingIcon = null;
            tbxSearch.Location = new Point(0, 3);
            tbxSearch.MaxLength = 32767;
            tbxSearch.MouseState = MaterialSkin.MouseState.OUT;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.PasswordChar = '\0';
            tbxSearch.PrefixSuffixText = null;
            tbxSearch.ReadOnly = false;
            tbxSearch.RightToLeft = RightToLeft.No;
            tbxSearch.SelectedText = "";
            tbxSearch.SelectionLength = 0;
            tbxSearch.SelectionStart = 0;
            tbxSearch.ShortcutsEnabled = true;
            tbxSearch.Size = new Size(354, 48);
            tbxSearch.TabIndex = 0;
            tbxSearch.TabStop = false;
            tbxSearch.TextAlign = HorizontalAlignment.Left;
            tbxSearch.TrailingIcon = null;
            tbxSearch.UseSystemPasswordChar = false;
            // 
            // btnMember
            // 
            btnMember.Cursor = Cursors.Hand;
            btnMember.FlatStyle = FlatStyle.Flat;
            btnMember.Location = new Point(0, 57);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(242, 40);
            btnMember.TabIndex = 1;
            btnMember.Text = "Members";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // btnProperty
            // 
            btnProperty.Cursor = Cursors.Hand;
            btnProperty.FlatStyle = FlatStyle.Flat;
            btnProperty.Location = new Point(242, 57);
            btnProperty.Name = "btnProperty";
            btnProperty.Size = new Size(242, 40);
            btnProperty.TabIndex = 2;
            btnProperty.Text = "Property";
            btnProperty.UseVisualStyleBackColor = true;
            // 
            // btnVehicle
            // 
            btnVehicle.Cursor = Cursors.Hand;
            btnVehicle.FlatStyle = FlatStyle.Flat;
            btnVehicle.Location = new Point(484, 57);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Size = new Size(242, 40);
            btnVehicle.TabIndex = 3;
            btnVehicle.Text = "Vehicles";
            btnVehicle.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbxSearch);
            panel1.Controls.Add(btnVehicle);
            panel1.Controls.Add(btnMember);
            panel1.Controls.Add(btnProperty);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 100);
            panel1.TabIndex = 4;
            // 
            // dgvAdminDisplay
            // 
            dgvAdminDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminDisplay.Location = new Point(2, 103);
            dgvAdminDisplay.Name = "dgvAdminDisplay";
            dgvAdminDisplay.Size = new Size(722, 304);
            dgvAdminDisplay.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(462, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(594, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // AdminManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvAdminDisplay);
            Controls.Add(panel1);
            Name = "AdminManage";
            Size = new Size(727, 445);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdminDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbxSearch;
        private Button btnMember;
        private Button btnProperty;
        private Button btnVehicle;
        private Panel panel1;
        private DataGridView dgvAdminDisplay;
        private Button btnAdd;
        private Button btnDelete;
    }
}
