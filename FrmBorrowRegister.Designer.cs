namespace WindowsFormsLibrarySystem
{
    partial class FrmBorrowRegister
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
            this.pnlReader = new System.Windows.Forms.Panel();
            this.lblReaderTitle = new System.Windows.Forms.Label();
            this.tlpReader = new System.Windows.Forms.TableLayoutPanel();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.btnScanCard = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.cboBorrowed = new System.Windows.Forms.ComboBox();
            this.pnlGap = new System.Windows.Forms.Panel();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.tlpBook = new System.Windows.Forms.TableLayoutPanel();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnScanBook = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblCanBorrow = new System.Windows.Forms.Label();
            this.cboCanBorrow = new System.Windows.Forms.ComboBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlReader.SuspendLayout();
            this.tlpReader.SuspendLayout();
            this.pnlBook.SuspendLayout();
            this.tlpBook.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReader
            // 
            this.pnlReader.BackColor = System.Drawing.Color.White;
            this.pnlReader.Controls.Add(this.tlpReader);
            this.pnlReader.Controls.Add(this.lblReaderTitle);
            this.pnlReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReader.Location = new System.Drawing.Point(10, 10);
            this.pnlReader.Name = "pnlReader";
            this.pnlReader.Size = new System.Drawing.Size(1060, 116);
            this.pnlReader.TabIndex = 0;
            // 
            // lblReaderTitle
            // 
            this.lblReaderTitle.AutoSize = true;
            this.lblReaderTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.lblReaderTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblReaderTitle.Location = new System.Drawing.Point(16, 10);
            this.lblReaderTitle.Name = "lblReaderTitle";
            this.lblReaderTitle.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.lblReaderTitle.Size = new System.Drawing.Size(100, 27);
            this.lblReaderTitle.TabIndex = 0;
            this.lblReaderTitle.Text = "读者信息";
            // 
            // tlpReader
            // 
            this.tlpReader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpReader.ColumnCount = 9;
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpReader.Controls.Add(this.lblCardNo, 0, 0);
            this.tlpReader.Controls.Add(this.txtCardNo, 1, 0);
            this.tlpReader.Controls.Add(this.btnScanCard, 2, 0);
            this.tlpReader.Controls.Add(this.lblName, 3, 0);
            this.tlpReader.Controls.Add(this.txtName, 4, 0);
            this.tlpReader.Controls.Add(this.lblType, 5, 0);
            this.tlpReader.Controls.Add(this.txtType, 6, 0);
            this.tlpReader.Controls.Add(this.lblBorrowed, 7, 0);
            this.tlpReader.Controls.Add(this.cboBorrowed, 8, 0);
            this.tlpReader.Location = new System.Drawing.Point(16, 48);
            this.tlpReader.Name = "tlpReader";
            this.tlpReader.RowCount = 1;
            this.tlpReader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpReader.Size = new System.Drawing.Size(1028, 54);
            this.tlpReader.TabIndex = 1;
            // 
            // lblCardNo
            // 
            this.lblCardNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(3, 18);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(70, 17);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "证件号";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardNo.Location = new System.Drawing.Point(79, 14);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(180, 25);
            this.txtCardNo.TabIndex = 1;
            // 
            // btnScanCard
            // 
            this.btnScanCard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnScanCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(246)))));
            this.btnScanCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(230)))));
            this.btnScanCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.btnScanCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnScanCard.Location = new System.Drawing.Point(265, 11);
            this.btnScanCard.Name = "btnScanCard";
            this.btnScanCard.Size = new System.Drawing.Size(42, 32);
            this.btnScanCard.TabIndex = 2;
            this.btnScanCard.Text = "▣";
            this.btnScanCard.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(313, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtName.Location = new System.Drawing.Point(365, 14);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(112, 25);
            this.txtName.TabIndex = 4;
            this.txtName.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(485, 18);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 17);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "类型";
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtType.Location = new System.Drawing.Point(537, 14);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(112, 25);
            this.txtType.TabIndex = 6;
            this.txtType.TabStop = false;
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.Location = new System.Drawing.Point(661, 18);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(76, 17);
            this.lblBorrowed.TabIndex = 7;
            this.lblBorrowed.Text = "已借数量";
            // 
            // cboBorrowed
            // 
            this.cboBorrowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBorrowed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBorrowed.Location = new System.Drawing.Point(743, 14);
            this.cboBorrowed.Name = "cboBorrowed";
            this.cboBorrowed.Size = new System.Drawing.Size(124, 25);
            this.cboBorrowed.TabIndex = 8;
            // 
            // pnlGap
            // 
            this.pnlGap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.pnlGap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGap.Location = new System.Drawing.Point(10, 126);
            this.pnlGap.Name = "pnlGap";
            this.pnlGap.Size = new System.Drawing.Size(1060, 10);
            this.pnlGap.TabIndex = 1;
            // 
            // pnlBook
            // 
            this.pnlBook.BackColor = System.Drawing.Color.White;
            this.pnlBook.Controls.Add(this.tlpBook);
            this.pnlBook.Controls.Add(this.lblBookTitle);
            this.pnlBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBook.Location = new System.Drawing.Point(10, 136);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(1060, 116);
            this.pnlBook.TabIndex = 2;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblBookTitle.Location = new System.Drawing.Point(16, 10);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.lblBookTitle.Size = new System.Drawing.Size(100, 27);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "图书信息";
            // 
            // tlpBook
            // 
            this.tlpBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBook.ColumnCount = 9;
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpBook.Controls.Add(this.lblBarCode, 0, 0);
            this.tlpBook.Controls.Add(this.txtBarCode, 1, 0);
            this.tlpBook.Controls.Add(this.btnScanBook, 2, 0);
            this.tlpBook.Controls.Add(this.lblBookName, 3, 0);
            this.tlpBook.Controls.Add(this.txtBookName, 4, 0);
            this.tlpBook.Controls.Add(this.lblAuthor, 5, 0);
            this.tlpBook.Controls.Add(this.txtAuthor, 6, 0);
            this.tlpBook.Controls.Add(this.lblCanBorrow, 7, 0);
            this.tlpBook.Controls.Add(this.cboCanBorrow, 8, 0);
            this.tlpBook.Location = new System.Drawing.Point(16, 48);
            this.tlpBook.Name = "tlpBook";
            this.tlpBook.RowCount = 1;
            this.tlpBook.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpBook.Size = new System.Drawing.Size(1028, 54);
            this.tlpBook.TabIndex = 1;
            // 
            // lblBarCode
            // 
            this.lblBarCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(3, 18);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(70, 17);
            this.lblBarCode.TabIndex = 0;
            this.lblBarCode.Text = "图书条码";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarCode.Location = new System.Drawing.Point(79, 14);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(180, 25);
            this.txtBarCode.TabIndex = 1;
            // 
            // btnScanBook
            // 
            this.btnScanBook.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnScanBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(246)))));
            this.btnScanBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(230)))));
            this.btnScanBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanBook.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.btnScanBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnScanBook.Location = new System.Drawing.Point(265, 11);
            this.btnScanBook.Name = "btnScanBook";
            this.btnScanBook.Size = new System.Drawing.Size(42, 32);
            this.btnScanBook.TabIndex = 2;
            this.btnScanBook.Text = "▣";
            this.btnScanBook.UseVisualStyleBackColor = false;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(313, 18);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(46, 17);
            this.lblBookName.TabIndex = 3;
            this.lblBookName.Text = "书名";
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtBookName.Location = new System.Drawing.Point(365, 14);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(112, 25);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.TabStop = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(485, 18);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(46, 17);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "作者";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtAuthor.Location = new System.Drawing.Point(537, 14);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(112, 25);
            this.txtAuthor.TabIndex = 6;
            this.txtAuthor.TabStop = false;
            // 
            // lblCanBorrow
            // 
            this.lblCanBorrow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCanBorrow.AutoSize = true;
            this.lblCanBorrow.Location = new System.Drawing.Point(661, 18);
            this.lblCanBorrow.Name = "lblCanBorrow";
            this.lblCanBorrow.Size = new System.Drawing.Size(76, 17);
            this.lblCanBorrow.TabIndex = 7;
            this.lblCanBorrow.Text = "可借数量";
            // 
            // cboCanBorrow
            // 
            this.cboCanBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCanBorrow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCanBorrow.Location = new System.Drawing.Point(743, 14);
            this.cboCanBorrow.Name = "cboCanBorrow";
            this.cboCanBorrow.Size = new System.Drawing.Size(124, 25);
            this.cboCanBorrow.TabIndex = 8;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvBorrow);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(10, 252);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlGrid.Size = new System.Drawing.Size(1060, 358);
            this.pnlGrid.TabIndex = 3;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AllowUserToDeleteRows = false;
            this.dgvBorrow.AllowUserToResizeRows = false;
            this.dgvBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvBorrow.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorrow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBorrow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrow.ColumnHeadersHeight = 42;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colTitle,
            this.colDueDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrow.EnableHeadersVisualStyles = false;
            this.dgvBorrow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgvBorrow.Location = new System.Drawing.Point(16, 12);
            this.dgvBorrow.MultiSelect = false;
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.RowHeadersVisible = false;
            this.dgvBorrow.RowTemplate.Height = 44;
            this.dgvBorrow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(1028, 334);
            this.dgvBorrow.TabIndex = 0;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "代码";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 300;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "文书";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 400;
            // 
            // colDueDate
            // 
            this.colDueDate.HeaderText = "应还日期";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            this.colDueDate.Width = 240;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnFinish);
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(10, 610);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1060, 80);
            this.pnlBottom.TabIndex = 4;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(382, 20);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(160, 44);
            this.btnFinish.TabIndex = 0;
            this.btnFinish.Text = "确认借书";
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnCancel.Location = new System.Drawing.Point(558, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 44);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FrmBorrowRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlBook);
            this.Controls.Add(this.pnlGap);
            this.Controls.Add(this.pnlReader);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(820, 560);
            this.Name = "FrmBorrowRegister";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "借书登记";
            this.pnlReader.ResumeLayout(false);
            this.pnlReader.PerformLayout();
            this.tlpReader.ResumeLayout(false);
            this.tlpReader.PerformLayout();
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.tlpBook.ResumeLayout(false);
            this.tlpBook.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlReader;
        private System.Windows.Forms.Label lblReaderTitle;
        private System.Windows.Forms.TableLayoutPanel tlpReader;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Button btnScanCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.ComboBox cboBorrowed;
        private System.Windows.Forms.Panel pnlGap;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TableLayoutPanel tlpBook;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnScanBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblCanBorrow;
        private System.Windows.Forms.ComboBox cboCanBorrow;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel;
    }
}
