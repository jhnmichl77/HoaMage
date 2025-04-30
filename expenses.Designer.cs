namespace HoaMage
{
    partial class expenses
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
            dgvExpenses = new DataGridView();
            label1 = new Label();
            tbxTitle = new TextBox();
            tbxSearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbxCategory = new ComboBox();
            tbxAmount = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtpDate = new DateTimePicker();
            tbxReferenceNum = new TextBox();
            label6 = new Label();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            btnEdit = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnPrint = new LinkLabel();
            panelPieChart = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // dgvExpenses
            // 
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(20, 98);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.Size = new Size(822, 206);
            dgvExpenses.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 323);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Title:";
            // 
            // tbxTitle
            // 
            tbxTitle.Location = new Point(101, 315);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(190, 23);
            tbxTitle.TabIndex = 2;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(71, 69);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(403, 23);
            tbxSearch.TabIndex = 4;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 77);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 352);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Category:";
            // 
            // cbxCategory
            // 
            cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Items.AddRange(new object[] { "Maintanance", "Security", "Salaries", "Others" });
            cbxCategory.Location = new Point(101, 344);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(190, 23);
            cbxCategory.TabIndex = 6;
            // 
            // tbxAmount
            // 
            tbxAmount.Location = new Point(101, 373);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(190, 23);
            tbxAmount.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 381);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 410);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(101, 404);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(190, 23);
            dtpDate.TabIndex = 10;
            // 
            // tbxReferenceNum
            // 
            tbxReferenceNum.Location = new Point(101, 433);
            tbxReferenceNum.Name = "tbxReferenceNum";
            tbxReferenceNum.Size = new Size(190, 23);
            tbxReferenceNum.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 441);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 11;
            label6.Text = "Reference #:";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = false;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(311, 315);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(75, 36);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = false;
            btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEdit.Depth = 0;
            btnEdit.HighEmphasis = true;
            btnEdit.Icon = null;
            btnEdit.Location = new Point(311, 368);
            btnEdit.Margin = new Padding(4, 6, 4, 6);
            btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnEdit.Name = "btnEdit";
            btnEdit.NoAccentTextColor = Color.Empty;
            btnEdit.Size = new Size(73, 36);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEdit.UseAccentColor = false;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(311, 420);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(73, 36);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPrint
            // 
            btnPrint.AutoSize = true;
            btnPrint.Location = new Point(749, 315);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(32, 15);
            btnPrint.TabIndex = 16;
            btnPrint.TabStop = true;
            btnPrint.Text = "Print";
            // 
            // panelPieChart
            // 
            panelPieChart.Location = new Point(404, 310);
            panelPieChart.Name = "panelPieChart";
            panelPieChart.Size = new Size(330, 195);
            panelPieChart.TabIndex = 17;
            // 
            // expenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 511);
            Controls.Add(panelPieChart);
            Controls.Add(btnPrint);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(tbxReferenceNum);
            Controls.Add(label6);
            Controls.Add(dtpDate);
            Controls.Add(label5);
            Controls.Add(tbxAmount);
            Controls.Add(label4);
            Controls.Add(cbxCategory);
            Controls.Add(label3);
            Controls.Add(tbxSearch);
            Controls.Add(label2);
            Controls.Add(tbxTitle);
            Controls.Add(label1);
            Controls.Add(dgvExpenses);
            Name = "expenses";
            Text = "Expenses";
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvExpenses;
        private Label label1;
        private TextBox tbxTitle;
        private TextBox tbxSearch;
        private Label label2;
        private Label label3;
        private ComboBox cbxCategory;
        private TextBox tbxAmount;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpDate;
        private TextBox tbxReferenceNum;
        private Label label6;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnEdit;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private LinkLabel btnPrint;
        private Panel panelPieChart;
    }
}