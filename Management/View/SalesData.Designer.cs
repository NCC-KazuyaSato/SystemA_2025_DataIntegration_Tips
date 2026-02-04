namespace Management
{
    partial class frmSalesData
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblCaption = new Label();
            gbxFilter = new GroupBox();
            cbxOther = new CheckBox();
            cbxLiving = new CheckBox();
            cbxEquipment = new CheckBox();
            cbxFood = new CheckBox();
            txtName = new TextBox();
            txtNumber = new TextBox();
            dtpEnd = new DateTimePicker();
            lblSeparator = new Label();
            dtpStart = new DateTimePicker();
            lblName = new Label();
            lblNumber = new Label();
            lblCategory = new Label();
            lblRange = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            dgvResult = new DataGridView();
            sale_date = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            item_no = new DataGridViewTextBoxColumn();
            item_name = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            btnSend = new Button();
            btnClose = new Button();
            btnUpdate = new Button();
            gbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.Font = new Font("Yu Gothic UI Semibold", 14F, FontStyle.Bold);
            lblCaption.Location = new Point(32, 24);
            lblCaption.Margin = new Padding(4, 0, 4, 0);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(110, 32);
            lblCaption.TabIndex = 0;
            lblCaption.Text = "売上管理";
            // 
            // gbxFilter
            // 
            gbxFilter.Controls.Add(cbxOther);
            gbxFilter.Controls.Add(cbxLiving);
            gbxFilter.Controls.Add(cbxEquipment);
            gbxFilter.Controls.Add(cbxFood);
            gbxFilter.Controls.Add(txtName);
            gbxFilter.Controls.Add(txtNumber);
            gbxFilter.Controls.Add(dtpEnd);
            gbxFilter.Controls.Add(lblSeparator);
            gbxFilter.Controls.Add(dtpStart);
            gbxFilter.Controls.Add(lblName);
            gbxFilter.Controls.Add(lblNumber);
            gbxFilter.Controls.Add(lblCategory);
            gbxFilter.Controls.Add(lblRange);
            gbxFilter.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            gbxFilter.Location = new Point(32, 76);
            gbxFilter.Margin = new Padding(4);
            gbxFilter.Name = "gbxFilter";
            gbxFilter.Padding = new Padding(4);
            gbxFilter.Size = new Size(669, 226);
            gbxFilter.TabIndex = 21;
            gbxFilter.TabStop = false;
            gbxFilter.Text = "検索条件";
            // 
            // cbxOther
            // 
            cbxOther.AutoSize = true;
            cbxOther.Checked = true;
            cbxOther.CheckState = CheckState.Checked;
            cbxOther.Location = new Point(489, 86);
            cbxOther.Margin = new Padding(4);
            cbxOther.Name = "cbxOther";
            cbxOther.Size = new Size(69, 24);
            cbxOther.TabIndex = 14;
            cbxOther.Text = "その他";
            cbxOther.UseVisualStyleBackColor = true;
            // 
            // cbxLiving
            // 
            cbxLiving.AutoSize = true;
            cbxLiving.Checked = true;
            cbxLiving.CheckState = CheckState.Checked;
            cbxLiving.Location = new Point(369, 88);
            cbxLiving.Margin = new Padding(4);
            cbxLiving.Name = "cbxLiving";
            cbxLiving.Size = new Size(91, 24);
            cbxLiving.TabIndex = 13;
            cbxLiving.Text = "生活用品";
            cbxLiving.UseVisualStyleBackColor = true;
            // 
            // cbxEquipment
            // 
            cbxEquipment.AutoSize = true;
            cbxEquipment.Checked = true;
            cbxEquipment.CheckState = CheckState.Checked;
            cbxEquipment.Location = new Point(281, 88);
            cbxEquipment.Margin = new Padding(4);
            cbxEquipment.Name = "cbxEquipment";
            cbxEquipment.Size = new Size(61, 24);
            cbxEquipment.TabIndex = 12;
            cbxEquipment.Text = "機器";
            cbxEquipment.UseVisualStyleBackColor = true;
            // 
            // cbxFood
            // 
            cbxFood.AutoSize = true;
            cbxFood.Checked = true;
            cbxFood.CheckState = CheckState.Checked;
            cbxFood.Location = new Point(170, 88);
            cbxFood.Margin = new Padding(4);
            cbxFood.Name = "cbxFood";
            cbxFood.Size = new Size(76, 24);
            cbxFood.TabIndex = 11;
            cbxFood.Text = "食料品";
            cbxFood.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 171);
            txtName.Margin = new Padding(4);
            txtName.MaxLength = 30;
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 27);
            txtName.TabIndex = 18;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(170, 128);
            txtNumber.Margin = new Padding(4);
            txtNumber.MaxLength = 5;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(290, 27);
            txtNumber.TabIndex = 16;
            txtNumber.KeyPress += txtNumber_KeyPress;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "yyyy/MM";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(335, 40);
            dtpEnd.Margin = new Padding(4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(125, 27);
            dtpEnd.TabIndex = 9;
            // 
            // lblSeparator
            // 
            lblSeparator.AutoSize = true;
            lblSeparator.Location = new Point(304, 45);
            lblSeparator.Margin = new Padding(4, 0, 4, 0);
            lblSeparator.Name = "lblSeparator";
            lblSeparator.Size = new Size(24, 20);
            lblSeparator.TabIndex = 8;
            lblSeparator.Text = "～";
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "yyyy/MM";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(170, 40);
            dtpStart.Margin = new Padding(4);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(125, 27);
            dtpStart.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.BackColor = Color.FromArgb(224, 224, 224);
            lblName.Location = new Point(36, 170);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(119, 29);
            lblName.TabIndex = 17;
            lblName.Text = "商品名";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNumber
            // 
            lblNumber.BackColor = Color.FromArgb(224, 224, 224);
            lblNumber.Location = new Point(36, 126);
            lblNumber.Margin = new Padding(4, 0, 4, 0);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(119, 29);
            lblNumber.TabIndex = 15;
            lblNumber.Text = "商品番号";
            lblNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            lblCategory.BackColor = Color.FromArgb(224, 224, 224);
            lblCategory.Location = new Point(36, 82);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(119, 29);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "商品分類";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRange
            // 
            lblRange.BackColor = Color.FromArgb(224, 224, 224);
            lblRange.Location = new Point(36, 40);
            lblRange.Margin = new Padding(4, 0, 4, 0);
            lblRange.Name = "lblRange";
            lblRange.Size = new Size(119, 29);
            lblRange.TabIndex = 6;
            lblRange.Text = "期間";
            lblRange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnSearch.Location = new Point(774, 240);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 62);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "検索";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnClear.Location = new Point(947, 240);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 62);
            btnClear.TabIndex = 3;
            btnClear.Text = "条件クリア";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvResult
            // 
            dgvResult.AllowUserToDeleteRows = false;
            dgvResult.AllowUserToResizeColumns = false;
            dgvResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Columns.AddRange(new DataGridViewColumn[] { sale_date, category, item_no, item_name, quantity, discount, amount });
            dgvResult.Location = new Point(32, 326);
            dgvResult.Margin = new Padding(4);
            dgvResult.Name = "dgvResult";
            dgvResult.ReadOnly = true;
            dgvResult.RowHeadersVisible = false;
            dgvResult.RowHeadersWidth = 51;
            dgvResult.RowTemplate.Height = 22;
            dgvResult.RowTemplate.ReadOnly = true;
            dgvResult.ScrollBars = ScrollBars.Vertical;
            dgvResult.Size = new Size(1070, 360);
            dgvResult.TabIndex = 19;
            // 
            // sale_date
            // 
            sale_date.HeaderText = "販売日時";
            sale_date.MinimumWidth = 6;
            sale_date.Name = "sale_date";
            sale_date.ReadOnly = true;
            sale_date.Width = 180;
            // 
            // category
            // 
            category.HeaderText = "分類";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 125;
            // 
            // item_no
            // 
            item_no.HeaderText = "商品番号";
            item_no.MinimumWidth = 6;
            item_no.Name = "item_no";
            item_no.ReadOnly = true;
            item_no.Width = 125;
            // 
            // item_name
            // 
            item_name.HeaderText = "商品名";
            item_name.MinimumWidth = 6;
            item_name.Name = "item_name";
            item_name.ReadOnly = true;
            item_name.Width = 240;
            // 
            // quantity
            // 
            quantity.HeaderText = "売上数量";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 125;
            // 
            // discount
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            discount.DefaultCellStyle = dataGridViewCellStyle2;
            discount.HeaderText = "割引適用額";
            discount.MinimumWidth = 6;
            discount.Name = "discount";
            discount.ReadOnly = true;
            discount.Width = 125;
            // 
            // amount
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            amount.DefaultCellStyle = dataGridViewCellStyle3;
            amount.HeaderText = "売上額";
            amount.MinimumWidth = 6;
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Width = 125;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnSend.Location = new Point(32, 709);
            btnSend.Margin = new Padding(4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(275, 62);
            btnSend.TabIndex = 3;
            btnSend.Text = "売上データ送信";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnClose.Location = new Point(952, 709);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 62);
            btnClose.TabIndex = 5;
            btnClose.Text = "閉じる";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnUpdate.Location = new Point(779, 709);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 62);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "更新";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmSalesData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 793);
            ControlBox = false;
            Controls.Add(btnUpdate);
            Controls.Add(btnClose);
            Controls.Add(btnSend);
            Controls.Add(dgvResult);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(gbxFilter);
            Controls.Add(lblCaption);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmSalesData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "売上管理";
            gbxFilter.ResumeLayout(false);
            gbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCaption;
        private GroupBox gbxFilter;
        private Label lblRange;
        private Label lblCategory;
        private Label lblName;
        private Label lblNumber;
        private DateTimePicker dtpStart;
        private Label lblSeparator;
        private DateTimePicker dtpEnd;
        private TextBox txtNumber;
        private TextBox txtName;
        private Button btnSearch;
        private Button btnClear;
        private CheckBox cbxFood;
        private CheckBox cbxEquipment;
        private CheckBox cbxLiving;
        private CheckBox cbxOther;
        private DataGridView dgvResult;
        private Button btnSend;
        private Button btnClose;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn sale_date;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn item_no;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn amount;
    }
}