namespace toli_bichig
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textEn = new TextBox();
            cmbLang = new Label();
            cmdLang = new ComboBox();
            dgvSaved = new DataGridView();
            colSaved = new DataGridViewTextBoxColumn();
            dgvWords = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colEn = new DataGridViewTextBoxColumn();
            colMn = new DataGridViewTextBoxColumn();
            colRu = new DataGridViewTextBoxColumn();
            textMn = new TextBox();
            textRu = new TextBox();
            textSearch = new TextBox();
            lblSearch = new Label();
            lblDb1 = new Label();
            lblDb2 = new Label();
            lblEn = new Label();
            lblMn = new Label();
            lblRu = new Label();
            lblStatus = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSaved).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            SuspendLayout();
            // 
            // textEn
            // 
            textEn.Location = new Point(62, 404);
            textEn.Name = "textEn";
            textEn.Size = new Size(140, 27);
            textEn.TabIndex = 1;
            // 
            // cmbLang
            // 
            cmbLang.AutoSize = true;
            cmbLang.Location = new Point(490, 19);
            cmbLang.Name = "cmbLang";
            cmbLang.Size = new Size(40, 20);
            cmbLang.TabIndex = 2;
            cmbLang.Text = "Хэл :";
            // 
            // cmdLang
            // 
            cmdLang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmdLang.FormattingEnabled = true;
            cmdLang.Items.AddRange(new object[] { "Бүгд", "Англи", "Монгол", "Орос" });
            cmdLang.Location = new Point(536, 16);
            cmdLang.Name = "cmdLang";
            cmdLang.Size = new Size(105, 28);
            cmdLang.TabIndex = 3;
            // 
            // dgvSaved
            // 
            dgvSaved.AllowUserToAddRows = false;
            dgvSaved.AllowUserToDeleteRows = false;
            dgvSaved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaved.Columns.AddRange(new DataGridViewColumn[] { colSaved });
            dgvSaved.Location = new Point(428, 100);
            dgvSaved.MultiSelect = false;
            dgvSaved.Name = "dgvSaved";
            dgvSaved.ReadOnly = true;
            dgvSaved.RowHeadersVisible = false;
            dgvSaved.RowHeadersWidth = 51;
            dgvSaved.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaved.Size = new Size(200, 90);
            dgvSaved.TabIndex = 4;
            // 
            // colSaved
            // 
            colSaved.HeaderText = "Санасан үгс";
            colSaved.MinimumWidth = 6;
            colSaved.Name = "colSaved";
            colSaved.ReadOnly = true;
            // 
            // dgvWords
            // 
            dgvWords.AllowUserToAddRows = false;
            dgvWords.AllowUserToDeleteRows = false;
            dgvWords.BackgroundColor = Color.White;
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWords.Columns.AddRange(new DataGridViewColumn[] { colNo, colEn, colMn, colRu });
            dgvWords.Location = new Point(12, 100);
            dgvWords.MultiSelect = false;
            dgvWords.Name = "dgvWords";
            dgvWords.ReadOnly = true;
            dgvWords.RowHeadersVisible = false;
            dgvWords.RowHeadersWidth = 51;
            dgvWords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWords.Size = new Size(405, 285);
            dgvWords.TabIndex = 5;
            // 
            // colNo
            // 
            colNo.HeaderText = "№";
            colNo.MinimumWidth = 6;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            colNo.Width = 35;
            // 
            // colEn
            // 
            colEn.HeaderText = "Англи";
            colEn.MinimumWidth = 6;
            colEn.Name = "colEn";
            colEn.ReadOnly = true;
            colEn.Width = 120;
            // 
            // colMn
            // 
            colMn.HeaderText = "Монгол";
            colMn.MinimumWidth = 6;
            colMn.Name = "colMn";
            colMn.ReadOnly = true;
            colMn.Width = 120;
            // 
            // colRu
            // 
            colRu.HeaderText = "Орос";
            colRu.MinimumWidth = 6;
            colRu.Name = "colRu";
            colRu.ReadOnly = true;
            colRu.Width = 120;
            // 
            // textMn
            // 
            textMn.Location = new Point(270, 404);
            textMn.Name = "textMn";
            textMn.Size = new Size(140, 27);
            textMn.TabIndex = 6;
            // 
            // textRu
            // 
            textRu.Location = new Point(468, 404);
            textRu.Name = "textRu";
            textRu.Size = new Size(150, 27);
            textRu.TabIndex = 7;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(60, 16);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Хайх үг...";
            textSearch.Size = new Size(415, 27);
            textSearch.TabIndex = 8;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(5, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(49, 20);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Хайх :";
            // 
            // lblDb1
            // 
            lblDb1.AutoSize = true;
            lblDb1.Location = new Point(12, 78);
            lblDb1.Name = "lblDb1";
            lblDb1.Size = new Size(103, 20);
            lblDb1.TabIndex = 10;
            lblDb1.Text = "toli.db · words";
            // 
            // lblDb2
            // 
            lblDb2.AutoSize = true;
            lblDb2.Location = new Point(428, 78);
            lblDb2.Name = "lblDb2";
            lblDb2.Size = new Size(163, 20);
            lblDb2.TabIndex = 11;
            lblDb2.Text = "saved.db · saved_words";
            // 
            // lblEn
            // 
            lblEn.AutoSize = true;
            lblEn.Location = new Point(5, 407);
            lblEn.Name = "lblEn";
            lblEn.Size = new Size(51, 20);
            lblEn.TabIndex = 12;
            lblEn.Text = "Англи";
            // 
            // lblMn
            // 
            lblMn.AutoSize = true;
            lblMn.Location = new Point(201, 407);
            lblMn.Name = "lblMn";
            lblMn.Size = new Size(63, 20);
            lblMn.TabIndex = 13;
            lblMn.Text = "Монгол";
            // 
            // lblRu
            // 
            lblRu.AutoSize = true;
            lblRu.Location = new Point(417, 407);
            lblRu.Name = "lblRu";
            lblRu.Size = new Size(45, 20);
            lblRu.TabIndex = 14;
            lblRu.Text = "Орос";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Location = new Point(15, 500);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(160, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Нийт: 0 үг · Санасан: 0";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 445);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 34);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+ Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(125, 445);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 34);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Засах";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(235, 445);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 34);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(345, 445);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 34);
            btnClear.TabIndex = 19;
            btnClear.Text = "Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(455, 445);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 34);
            btnSave.TabIndex = 20;
            btnSave.Text = "Санах";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 540);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lblStatus);
            Controls.Add(lblRu);
            Controls.Add(lblMn);
            Controls.Add(lblEn);
            Controls.Add(lblDb2);
            Controls.Add(lblDb1);
            Controls.Add(lblSearch);
            Controls.Add(textSearch);
            Controls.Add(textRu);
            Controls.Add(textMn);
            Controls.Add(dgvWords);
            Controls.Add(dgvSaved);
            Controls.Add(cmdLang);
            Controls.Add(cmbLang);
            Controls.Add(textEn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Толь бичиг";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSaved).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textEn;
        private Label cmbLang;
        private ComboBox cmdLang;
        private DataGridView dgvSaved;
        private DataGridView dgvWords;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colEn;
        private DataGridViewTextBoxColumn colMn;
        private DataGridViewTextBoxColumn colRu;
        private DataGridViewTextBoxColumn colSaved;
        private TextBox textMn;
        private TextBox textRu;
        private TextBox textSearch;
        private Label lblSearch;
        private Label lblDb1;
        private Label lblDb2;
        private Label lblEn;
        private Label lblMn;
        private Label lblRu;
        private Label lblStatus;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
    }
}
