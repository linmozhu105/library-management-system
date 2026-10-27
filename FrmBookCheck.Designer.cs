namespace WindowsFormsLibrarySystem
{
    partial class FrmBookCheck
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.tlpQuery = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnStartCheck = new System.Windows.Forms.Button();
            this.dgvCheck = new System.Windows.Forms.DataGridView();
            this.colBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRealCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStat = new System.Windows.Forms.Panel();
            this.flpStat = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSumBook = new System.Windows.Forms.Label();
            this.txtSumBook = new System.Windows.Forms.TextBox();
            this.lblSumReal = new System.Windows.Forms.Label();
            this.txtSumReal = new System.Windows.Forms.TextBox();
            this.lblSumLost = new System.Windows.Forms.Label();
            this.txtSumLost = new System.Windows.Forms.TextBox();
            this.lblSumMore = new System.Windows.Forms.Label();
            this.txtSumMore = new System.Windows.Forms.TextBox();
            this.pnlTitle.SuspendLayout();
            this.gbQuery.SuspendLayout();
            this.tlpQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).BeginInit();
            this.pnlStat.SuspendLayout();
            this.flpStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(10, 10);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1060, 44);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "分类";
            // 
            // gbQuery
            // 
            this.gbQuery.BackColor = System.Drawing.Color.White;
            this.gbQuery.Controls.Add(this.tlpQuery);
            this.gbQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQuery.Location = new System.Drawing.Point(10, 54);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbQuery.Size = new System.Drawing.Size(1060, 96);
            this.gbQuery.TabIndex = 1;
            this.gbQuery.TabStop = false;
            // 
            // tlpQuery
            // 
            this.tlpQuery.ColumnCount = 5;
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tlpQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tlpQuery.Controls.Add(this.lblCategory, 0, 0);
            this.tlpQuery.Controls.Add(this.cboCategory, 1, 0);
            this.tlpQuery.Controls.Add(this.lblBookName, 2, 0);
            this.tlpQuery.Controls.Add(this.txtBookName, 3, 0);
            this.tlpQuery.Controls.Add(this.btnStartCheck, 4, 0);
            this.tlpQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpQuery.Location = new System.Drawing.Point(8, 26);
            this.tlpQuery.Name = "tlpQuery";
            this.tlpQuery.Padding = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.tlpQuery.RowCount = 1;
            this.tlpQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpQuery.Size = new System.Drawing.Size(1044, 56);
            this.tlpQuery.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(19, 22);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(54, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "分类：";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(79, 20);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(304, 28);
            this.cboCategory.TabIndex = 1;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(391, 22);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(54, 20);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "书名：";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.Location = new System.Drawing.Point(451, 18);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(422, 27);
            this.txtBookName.TabIndex = 3;
            // 
            // btnStartCheck
            // 
            this.btnStartCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnStartCheck.FlatAppearance.BorderSize = 0;
            this.btnStartCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCheck.ForeColor = System.Drawing.Color.White;
            this.btnStartCheck.Location = new System.Drawing.Point(879, 15);
            this.btnStartCheck.Name = "btnStartCheck";
            this.btnStartCheck.Size = new System.Drawing.Size(156, 34);
            this.btnStartCheck.TabIndex = 4;
            this.btnStartCheck.Text = "▣  开始盘点";
            this.btnStartCheck.UseVisualStyleBackColor = false;
            // 
            // dgvCheck
            // 
            this.dgvCheck.AllowUserToAddRows = false;
            this.dgvCheck.AllowUserToDeleteRows = false;
            this.dgvCheck.AllowUserToResizeRows = false;
            this.dgvCheck.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheck.ColumnHeadersHeight = 40;
            this.dgvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookId,
            this.colTitle,
            this.colBookCount,
            this.colRealCount,
            this.colDiff,
            this.colState});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheck.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheck.EnableHeadersVisualStyles = false;
            this.dgvCheck.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgvCheck.Location = new System.Drawing.Point(10, 150);
            this.dgvCheck.MultiSelect = false;
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.RowHeadersVisible = false;
            this.dgvCheck.RowHeadersWidth = 51;
            this.dgvCheck.RowTemplate.Height = 36;
            this.dgvCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheck.Size = new System.Drawing.Size(1060, 464);
            this.dgvCheck.TabIndex = 2;
            // 
            // colBookId
            // 
            this.colBookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBookId.FillWeight = 80F;
            this.colBookId.HeaderText = "图书编号";
            this.colBookId.MinimumWidth = 6;
            this.colBookId.Name = "colBookId";
            this.colBookId.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.FillWeight = 210F;
            this.colTitle.HeaderText = "书名";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colBookCount
            // 
            this.colBookCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBookCount.FillWeight = 90F;
            this.colBookCount.HeaderText = "账面数量";
            this.colBookCount.MinimumWidth = 6;
            this.colBookCount.Name = "colBookCount";
            this.colBookCount.ReadOnly = true;
            // 
            // colRealCount
            // 
            this.colRealCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRealCount.FillWeight = 90F;
            this.colRealCount.HeaderText = "实盘数量";
            this.colRealCount.MinimumWidth = 6;
            this.colRealCount.Name = "colRealCount";
            this.colRealCount.ReadOnly = true;
            // 
            // colDiff
            // 
            this.colDiff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiff.FillWeight = 80F;
            this.colDiff.HeaderText = "差异";
            this.colDiff.MinimumWidth = 6;
            this.colDiff.Name = "colDiff";
            this.colDiff.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colState.FillWeight = 80F;
            this.colState.HeaderText = "状态";
            this.colState.MinimumWidth = 6;
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // pnlStat
            // 
            this.pnlStat.BackColor = System.Drawing.Color.White;
            this.pnlStat.Controls.Add(this.flpStat);
            this.pnlStat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStat.Location = new System.Drawing.Point(10, 614);
            this.pnlStat.Name = "pnlStat";
            this.pnlStat.Size = new System.Drawing.Size(1060, 76);
            this.pnlStat.TabIndex = 3;
            // 
            // flpStat
            // 
            this.flpStat.Controls.Add(this.lblSumBook);
            this.flpStat.Controls.Add(this.txtSumBook);
            this.flpStat.Controls.Add(this.lblSumReal);
            this.flpStat.Controls.Add(this.txtSumReal);
            this.flpStat.Controls.Add(this.lblSumLost);
            this.flpStat.Controls.Add(this.txtSumLost);
            this.flpStat.Controls.Add(this.lblSumMore);
            this.flpStat.Controls.Add(this.txtSumMore);
            this.flpStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStat.Location = new System.Drawing.Point(0, 0);
            this.flpStat.Name = "flpStat";
            this.flpStat.Padding = new System.Windows.Forms.Padding(16, 20, 12, 10);
            this.flpStat.Size = new System.Drawing.Size(1060, 76);
            this.flpStat.TabIndex = 0;
            this.flpStat.WrapContents = false;
            // 
            // lblSumBook
            // 
            this.lblSumBook.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSumBook.AutoSize = true;
            this.lblSumBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSumBook.Location = new System.Drawing.Point(19, 26);
            this.lblSumBook.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.lblSumBook.Name = "lblSumBook";
            this.lblSumBook.Size = new System.Drawing.Size(69, 20);
            this.lblSumBook.TabIndex = 0;
            this.lblSumBook.Text = "账面总数";
            // 
            // txtSumBook
            // 
            this.txtSumBook.BackColor = System.Drawing.Color.White;
            this.txtSumBook.Location = new System.Drawing.Point(99, 23);
            this.txtSumBook.Margin = new System.Windows.Forms.Padding(3, 3, 34, 3);
            this.txtSumBook.Name = "txtSumBook";
            this.txtSumBook.ReadOnly = true;
            this.txtSumBook.Size = new System.Drawing.Size(92, 27);
            this.txtSumBook.TabIndex = 1;
            this.txtSumBook.TabStop = false;
            this.txtSumBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSumReal
            // 
            this.lblSumReal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSumReal.AutoSize = true;
            this.lblSumReal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSumReal.Location = new System.Drawing.Point(228, 26);
            this.lblSumReal.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.lblSumReal.Name = "lblSumReal";
            this.lblSumReal.Size = new System.Drawing.Size(69, 20);
            this.lblSumReal.TabIndex = 2;
            this.lblSumReal.Text = "实盘总数";
            // 
            // txtSumReal
            // 
            this.txtSumReal.BackColor = System.Drawing.Color.White;
            this.txtSumReal.Location = new System.Drawing.Point(308, 23);
            this.txtSumReal.Margin = new System.Windows.Forms.Padding(3, 3, 34, 3);
            this.txtSumReal.Name = "txtSumReal";
            this.txtSumReal.ReadOnly = true;
            this.txtSumReal.Size = new System.Drawing.Size(92, 27);
            this.txtSumReal.TabIndex = 3;
            this.txtSumReal.TabStop = false;
            this.txtSumReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSumLost
            // 
            this.lblSumLost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSumLost.AutoSize = true;
            this.lblSumLost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSumLost.Location = new System.Drawing.Point(437, 26);
            this.lblSumLost.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.lblSumLost.Name = "lblSumLost";
            this.lblSumLost.Size = new System.Drawing.Size(39, 20);
            this.lblSumLost.TabIndex = 4;
            this.lblSumLost.Text = "盘亏";
            // 
            // txtSumLost
            // 
            this.txtSumLost.BackColor = System.Drawing.Color.White;
            this.txtSumLost.Location = new System.Drawing.Point(487, 23);
            this.txtSumLost.Margin = new System.Windows.Forms.Padding(3, 3, 34, 3);
            this.txtSumLost.Name = "txtSumLost";
            this.txtSumLost.ReadOnly = true;
            this.txtSumLost.Size = new System.Drawing.Size(92, 27);
            this.txtSumLost.TabIndex = 5;
            this.txtSumLost.TabStop = false;
            this.txtSumLost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSumMore
            // 
            this.lblSumMore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSumMore.AutoSize = true;
            this.lblSumMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSumMore.Location = new System.Drawing.Point(616, 26);
            this.lblSumMore.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.lblSumMore.Name = "lblSumMore";
            this.lblSumMore.Size = new System.Drawing.Size(39, 20);
            this.lblSumMore.TabIndex = 6;
            this.lblSumMore.Text = "盘盈";
            // 
            // txtSumMore
            // 
            this.txtSumMore.BackColor = System.Drawing.Color.White;
            this.txtSumMore.Location = new System.Drawing.Point(666, 23);
            this.txtSumMore.Margin = new System.Windows.Forms.Padding(3, 3, 34, 3);
            this.txtSumMore.Name = "txtSumMore";
            this.txtSumMore.ReadOnly = true;
            this.txtSumMore.Size = new System.Drawing.Size(92, 27);
            this.txtSumMore.TabIndex = 7;
            this.txtSumMore.TabStop = false;
            this.txtSumMore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmBookCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.dgvCheck);
            this.Controls.Add(this.pnlStat);
            this.Controls.Add(this.gbQuery);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(940, 580);
            this.Name = "FrmBookCheck";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图书盘点";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.gbQuery.ResumeLayout(false);
            this.tlpQuery.ResumeLayout(false);
            this.tlpQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).EndInit();
            this.pnlStat.ResumeLayout(false);
            this.flpStat.ResumeLayout(false);
            this.flpStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.TableLayoutPanel tlpQuery;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnStartCheck;
        private System.Windows.Forms.DataGridView dgvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRealCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.Panel pnlStat;
        private System.Windows.Forms.FlowLayoutPanel flpStat;
        private System.Windows.Forms.Label lblSumBook;
        private System.Windows.Forms.TextBox txtSumBook;
        private System.Windows.Forms.Label lblSumReal;
        private System.Windows.Forms.TextBox txtSumReal;
        private System.Windows.Forms.Label lblSumLost;
        private System.Windows.Forms.TextBox txtSumLost;
        private System.Windows.Forms.Label lblSumMore;
        private System.Windows.Forms.TextBox txtSumMore;
    }
}
