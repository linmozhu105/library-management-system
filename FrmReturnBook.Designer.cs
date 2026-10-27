namespace WindowsFormsLibrarySystem
{
    partial class FrmReturnBook
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlScan = new System.Windows.Forms.Panel();
            this.lblScanTitle = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnScanBook = new System.Windows.Forms.Button();
            this.tlpFields = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.txtBorrowDate = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.pnlOverdue = new System.Windows.Forms.Panel();
            this.lblOverdueTitle = new System.Windows.Forms.Label();
            this.lblOverdueDays = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.pnlRecord = new System.Windows.Forms.Panel();
            this.lblRecordTitle = new System.Windows.Forms.Label();
            this.btnCloseTitle = new System.Windows.Forms.Button();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnConfirmReturn = new System.Windows.Forms.Button();
            this.pnlScan.SuspendLayout();
            this.tlpFields.SuspendLayout();
            this.pnlOverdue.SuspendLayout();
            this.pnlRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScan
            // 
            this.pnlScan.BackColor = System.Drawing.Color.White;
            this.pnlScan.Controls.Add(this.tlpFields);
            this.pnlScan.Controls.Add(this.btnScanBook);
            this.pnlScan.Controls.Add(this.txtBarCode);
            this.pnlScan.Controls.Add(this.lblScanTitle);
            this.pnlScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlScan.Location = new System.Drawing.Point(10, 10);
            this.pnlScan.Name = "pnlScan";
            this.pnlScan.Size = new System.Drawing.Size(1060, 186);
            this.pnlScan.TabIndex = 0;
            // 
            // lblScanTitle
            // 
            this.lblScanTitle.AutoSize = true;
            this.lblScanTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblScanTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblScanTitle.Location = new System.Drawing.Point(18, 12);
            this.lblScanTitle.Name = "lblScanTitle";
            this.lblScanTitle.Size = new System.Drawing.Size(88, 19);
            this.lblScanTitle.TabIndex = 0;
            this.lblScanTitle.Text = "▌ 图书扫描";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.txtBarCode.Location = new System.Drawing.Point(20, 44);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(928, 29);
            this.txtBarCode.TabIndex = 1;
            // 
            // btnScanBook
            // 
            this.btnScanBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(246)))));
            this.btnScanBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(230)))));
            this.btnScanBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanBook.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnScanBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnScanBook.Location = new System.Drawing.Point(954, 42);
            this.btnScanBook.Name = "btnScanBook";
            this.btnScanBook.Size = new System.Drawing.Size(58, 33);
            this.btnScanBook.TabIndex = 2;
            this.btnScanBook.Text = "▣";
            this.btnScanBook.UseVisualStyleBackColor = false;
            // 
            // tlpFields
            // 
            this.tlpFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFields.ColumnCount = 8;
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFields.Controls.Add(this.lblBookName, 0, 0);
            this.tlpFields.Controls.Add(this.txtBookName, 1, 0);
            this.tlpFields.Controls.Add(this.lblAuthor, 2, 0);
            this.tlpFields.Controls.Add(this.txtAuthor, 3, 0);
            this.tlpFields.Controls.Add(this.lblBorrowDate, 4, 0);
            this.tlpFields.Controls.Add(this.txtBorrowDate, 5, 0);
            this.tlpFields.Controls.Add(this.lblDueDate, 6, 0);
            this.tlpFields.Controls.Add(this.txtDueDate, 7, 0);
            this.tlpFields.Location = new System.Drawing.Point(20, 96);
            this.tlpFields.Name = "tlpFields";
            this.tlpFields.RowCount = 1;
            this.tlpFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpFields.Size = new System.Drawing.Size(992, 54);
            this.tlpFields.TabIndex = 3;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(3, 18);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(56, 17);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "书名";
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtBookName.Location = new System.Drawing.Point(65, 14);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(197, 25);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.TabStop = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(268, 18);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(56, 17);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "作者";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtAuthor.Location = new System.Drawing.Point(330, 14);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(181, 25);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.TabStop = false;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(517, 18);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(76, 17);
            this.lblBorrowDate.TabIndex = 4;
            this.lblBorrowDate.Text = "借出日期";
            // 
            // txtBorrowDate
            // 
            this.txtBorrowDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBorrowDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtBorrowDate.Location = new System.Drawing.Point(599, 14);
            this.txtBorrowDate.Name = "txtBorrowDate";
            this.txtBorrowDate.ReadOnly = true;
            this.txtBorrowDate.Size = new System.Drawing.Size(189, 25);
            this.txtBorrowDate.TabIndex = 5;
            this.txtBorrowDate.TabStop = false;
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(790, 18);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(76, 17);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "应还日期";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDueDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtDueDate.Location = new System.Drawing.Point(872, 14);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(117, 25);
            this.txtDueDate.TabIndex = 7;
            this.txtDueDate.TabStop = false;
            // 
            // pnlOverdue
            // 
            this.pnlOverdue.BackColor = System.Drawing.Color.White;
            this.pnlOverdue.Controls.Add(this.pnlRecord);
            this.pnlOverdue.Controls.Add(this.lblFine);
            this.pnlOverdue.Controls.Add(this.lblOverdueDays);
            this.pnlOverdue.Controls.Add(this.lblOverdueTitle);
            this.pnlOverdue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverdue.Location = new System.Drawing.Point(10, 196);
            this.pnlOverdue.Name = "pnlOverdue";
            this.pnlOverdue.Size = new System.Drawing.Size(1060, 414);
            this.pnlOverdue.TabIndex = 1;
            // 
            // lblOverdueTitle
            // 
            this.lblOverdueTitle.AutoSize = true;
            this.lblOverdueTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOverdueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblOverdueTitle.Location = new System.Drawing.Point(18, 12);
            this.lblOverdueTitle.Name = "lblOverdueTitle";
            this.lblOverdueTitle.Size = new System.Drawing.Size(88, 19);
            this.lblOverdueTitle.TabIndex = 0;
            this.lblOverdueTitle.Text = "▌ 逾期信息";
            // 
            // lblOverdueDays
            // 
            this.lblOverdueDays.AutoSize = true;
            this.lblOverdueDays.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.lblOverdueDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblOverdueDays.Location = new System.Drawing.Point(24, 48);
            this.lblOverdueDays.Name = "lblOverdueDays";
            this.lblOverdueDays.Size = new System.Drawing.Size(120, 19);
            this.lblOverdueDays.TabIndex = 1;
            this.lblOverdueDays.Text = "◯ 已逾期 0 天";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.lblFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblFine.Location = new System.Drawing.Point(280, 48);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(150, 19);
            this.lblFine.TabIndex = 2;
            this.lblFine.Text = "◯ 逾期费用  0.00 元";
            // 
            // pnlRecord
            // 
            this.pnlRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecord.Controls.Add(this.dgvReturn);
            this.pnlRecord.Controls.Add(this.btnCloseTitle);
            this.pnlRecord.Controls.Add(this.lblRecordTitle);
            this.pnlRecord.Location = new System.Drawing.Point(20, 82);
            this.pnlRecord.Name = "pnlRecord";
            this.pnlRecord.Size = new System.Drawing.Size(1020, 318);
            this.pnlRecord.TabIndex = 3;
            // 
            // lblRecordTitle
            // 
            this.lblRecordTitle.AutoSize = true;
            this.lblRecordTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F);
            this.lblRecordTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblRecordTitle.Location = new System.Drawing.Point(4, 8);
            this.lblRecordTitle.Name = "lblRecordTitle";
            this.lblRecordTitle.Size = new System.Drawing.Size(64, 17);
            this.lblRecordTitle.TabIndex = 0;
            this.lblRecordTitle.Text = "还书记录";
            // 
            // btnCloseTitle
            // 
            this.btnCloseTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTitle.FlatAppearance.BorderSize = 0;
            this.btnCloseTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.btnCloseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.btnCloseTitle.Location = new System.Drawing.Point(988, 2);
            this.btnCloseTitle.Name = "btnCloseTitle";
            this.btnCloseTitle.Size = new System.Drawing.Size(28, 28);
            this.btnCloseTitle.TabIndex = 1;
            this.btnCloseTitle.Text = "×";
            this.btnCloseTitle.UseVisualStyleBackColor = true;
            // 
            // dgvReturn
            // 
            this.dgvReturn.AllowUserToAddRows = false;
            this.dgvReturn.AllowUserToDeleteRows = false;
            this.dgvReturn.AllowUserToResizeRows = false;
            this.dgvReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvReturn.BackgroundColor = System.Drawing.Color.White;
            this.dgvReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReturn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturn.ColumnHeadersHeight = 40;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colTitle,
            this.colBorrower,
            this.colReturnTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturn.EnableHeadersVisualStyles = false;
            this.dgvReturn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgvReturn.Location = new System.Drawing.Point(4, 34);
            this.dgvReturn.MultiSelect = false;
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            this.dgvReturn.RowHeadersVisible = false;
            this.dgvReturn.RowTemplate.Height = 40;
            this.dgvReturn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturn.Size = new System.Drawing.Size(1012, 278);
            this.dgvReturn.TabIndex = 2;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "密码";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 140;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "书名";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 260;
            // 
            // colBorrower
            // 
            this.colBorrower.HeaderText = "借阅人";
            this.colBorrower.Name = "colBorrower";
            this.colBorrower.ReadOnly = true;
            this.colBorrower.Width = 200;
            // 
            // colReturnTime
            // 
            this.colReturnTime.HeaderText = "还书时间";
            this.colReturnTime.Name = "colReturnTime";
            this.colReturnTime.ReadOnly = true;
            this.colReturnTime.Width = 220;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnConfirmReturn);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(10, 610);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1060, 80);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnConfirmReturn
            // 
            this.btnConfirmReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnConfirmReturn.FlatAppearance.BorderSize = 0;
            this.btnConfirmReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnConfirmReturn.ForeColor = System.Drawing.Color.White;
            this.btnConfirmReturn.Location = new System.Drawing.Point(450, 20);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(160, 44);
            this.btnConfirmReturn.TabIndex = 0;
            this.btnConfirmReturn.Text = "确认还书";
            this.btnConfirmReturn.UseVisualStyleBackColor = false;
            // 
            // FrmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.pnlOverdue);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlScan);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(820, 560);
            this.Name = "FrmReturnBook";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "还书登记";
            this.pnlScan.ResumeLayout(false);
            this.pnlScan.PerformLayout();
            this.tlpFields.ResumeLayout(false);
            this.tlpFields.PerformLayout();
            this.pnlOverdue.ResumeLayout(false);
            this.pnlOverdue.PerformLayout();
            this.pnlRecord.ResumeLayout(false);
            this.pnlRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlScan;
        private System.Windows.Forms.Label lblScanTitle;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnScanBook;
        private System.Windows.Forms.TableLayoutPanel tlpFields;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.TextBox txtBorrowDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Panel pnlOverdue;
        private System.Windows.Forms.Label lblOverdueTitle;
        private System.Windows.Forms.Label lblOverdueDays;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Panel pnlRecord;
        private System.Windows.Forms.Label lblRecordTitle;
        private System.Windows.Forms.Button btnCloseTitle;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrower;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnTime;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnConfirmReturn;
    }
}
