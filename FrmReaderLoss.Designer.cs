namespace WindowsFormsLibrarySystem
{
    partial class FrmReaderLoss
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlLoss = new System.Windows.Forms.Panel();
            this.lblLossTitle = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnLoss = new System.Windows.Forms.Button();
            this.pnlRecord = new System.Windows.Forms.Panel();
            this.lblRecordTitle = new System.Windows.Forms.Label();
            this.dgvLoss = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLossTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlLoss.SuspendLayout();
            this.pnlRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoss)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlLoss);
            this.splitContainer1.Panel1MinSize = 380;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlRecord);
            this.splitContainer1.Size = new System.Drawing.Size(1060, 700);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.SplitterWidth = 16;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlLoss
            // 
            this.pnlLoss.BackColor = System.Drawing.Color.White;
            this.pnlLoss.Controls.Add(this.lblLossTitle);
            this.pnlLoss.Controls.Add(this.lblCardNo);
            this.pnlLoss.Controls.Add(this.txtCardNo);
            this.pnlLoss.Controls.Add(this.lblName);
            this.pnlLoss.Controls.Add(this.txtName);
            this.pnlLoss.Controls.Add(this.lblType);
            this.pnlLoss.Controls.Add(this.txtType);
            this.pnlLoss.Controls.Add(this.lblReason);
            this.pnlLoss.Controls.Add(this.txtReason);
            this.pnlLoss.Controls.Add(this.btnLoss);
            this.pnlLoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoss.Location = new System.Drawing.Point(0, 0);
            this.pnlLoss.Name = "pnlLoss";
            this.pnlLoss.Size = new System.Drawing.Size(390, 700);
            this.pnlLoss.TabIndex = 0;
            // 
            // lblLossTitle
            // 
            this.lblLossTitle.AutoSize = true;
            this.lblLossTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLossTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblLossTitle.Location = new System.Drawing.Point(26, 22);
            this.lblLossTitle.Name = "lblLossTitle";
            this.lblLossTitle.Size = new System.Drawing.Size(74, 19);
            this.lblLossTitle.TabIndex = 0;
            this.lblLossTitle.Text = "挂失登记";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(30, 92);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(64, 17);
            this.lblCardNo.TabIndex = 1;
            this.lblCardNo.Text = "证件号：";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardNo.Location = new System.Drawing.Point(120, 88);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(270, 25);
            this.txtCardNo.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 152);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(120, 148);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(270, 25);
            this.txtName.TabIndex = 4;
            this.txtName.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(42, 212);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 17);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "类型：";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Location = new System.Drawing.Point(120, 208);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(270, 25);
            this.txtType.TabIndex = 6;
            this.txtType.TabStop = false;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(14, 268);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(76, 17);
            this.lblReason.TabIndex = 7;
            this.lblReason.Text = "挂失原因：";
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Location = new System.Drawing.Point(120, 264);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(270, 170);
            this.txtReason.TabIndex = 8;
            // 
            // btnLoss
            // 
            this.btnLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLoss.FlatAppearance.BorderSize = 0;
            this.btnLoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoss.ForeColor = System.Drawing.Color.White;
            this.btnLoss.Location = new System.Drawing.Point(129, 470);
            this.btnLoss.Name = "btnLoss";
            this.btnLoss.Size = new System.Drawing.Size(132, 42);
            this.btnLoss.TabIndex = 9;
            this.btnLoss.Text = "确认挂失";
            this.btnLoss.UseVisualStyleBackColor = false;
            // 
            // pnlRecord
            // 
            this.pnlRecord.BackColor = System.Drawing.Color.White;
            this.pnlRecord.Controls.Add(this.lblRecordTitle);
            this.pnlRecord.Controls.Add(this.dgvLoss);
            this.pnlRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecord.Location = new System.Drawing.Point(0, 0);
            this.pnlRecord.Name = "pnlRecord";
            this.pnlRecord.Size = new System.Drawing.Size(654, 700);
            this.pnlRecord.TabIndex = 0;
            // 
            // lblRecordTitle
            // 
            this.lblRecordTitle.AutoSize = true;
            this.lblRecordTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecordTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblRecordTitle.Location = new System.Drawing.Point(26, 22);
            this.lblRecordTitle.Name = "lblRecordTitle";
            this.lblRecordTitle.Size = new System.Drawing.Size(74, 19);
            this.lblRecordTitle.TabIndex = 0;
            this.lblRecordTitle.Text = "挂失记录";
            // 
            // dgvLoss
            // 
            this.dgvLoss.AllowUserToAddRows = false;
            this.dgvLoss.AllowUserToDeleteRows = false;
            this.dgvLoss.AllowUserToResizeRows = false;
            this.dgvLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoss.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvLoss.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoss.ColumnHeadersHeight = 42;
            this.dgvLoss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLoss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colCardNo,
            this.colName,
            this.colLossTime,
            this.colState});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoss.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoss.EnableHeadersVisualStyles = false;
            this.dgvLoss.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgvLoss.Location = new System.Drawing.Point(22, 60);
            this.dgvLoss.MultiSelect = false;
            this.dgvLoss.Name = "dgvLoss";
            this.dgvLoss.ReadOnly = true;
            this.dgvLoss.RowHeadersVisible = false;
            this.dgvLoss.RowTemplate.Height = 40;
            this.dgvLoss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoss.Size = new System.Drawing.Size(580, 616);
            this.dgvLoss.TabIndex = 1;
            // 
            // colNo
            // 
            this.colNo.Width = 52;
            this.colNo.HeaderText = "序号";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            // 
            // colCardNo
            // 
            this.colCardNo.Width = 104;
            this.colCardNo.HeaderText = "证件号";
            this.colCardNo.Name = "colCardNo";
            this.colCardNo.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.Width = 74;
            this.colName.HeaderText = "姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colLossTime
            // 
            this.colLossTime.Width = 112;
            this.colLossTime.HeaderText = "挂失时间";
            this.colLossTime.Name = "colLossTime";
            this.colLossTime.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.Width = 84;
            this.colState.HeaderText = "状态";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // FrmReaderLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(820, 560);
            this.Name = "FrmReaderLoss";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "读者挂失";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlLoss.ResumeLayout(false);
            this.pnlLoss.PerformLayout();
            this.pnlRecord.ResumeLayout(false);
            this.pnlRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoss)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlLoss;
        private System.Windows.Forms.Label lblLossTitle;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnLoss;
        private System.Windows.Forms.Panel pnlRecord;
        private System.Windows.Forms.Label lblRecordTitle;
        private System.Windows.Forms.DataGridView dgvLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLossTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
    }
}
