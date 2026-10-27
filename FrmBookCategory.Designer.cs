namespace WindowsFormsLibrarySystem
{
    partial class FrmBookCategory
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
            this.pnlTree = new System.Windows.Forms.Panel();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.flpTool = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseTitle = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.colCategoryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTree.SuspendLayout();
            this.pnlTool.SuspendLayout();
            this.flpTool.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.pnlTree);
            this.splitContainer1.Panel1MinSize = 240;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlGrid);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTitle);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTool);
            this.splitContainer1.Size = new System.Drawing.Size(1020, 660);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlTree
            // 
            this.pnlTree.BackColor = System.Drawing.Color.White;
            this.pnlTree.Controls.Add(this.tvCategory);
            this.pnlTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTree.Location = new System.Drawing.Point(0, 0);
            this.pnlTree.Name = "pnlTree";
            this.pnlTree.Padding = new System.Windows.Forms.Padding(10, 12, 6, 10);
            this.pnlTree.Size = new System.Drawing.Size(290, 660);
            this.pnlTree.TabIndex = 0;
            // 
            // tvCategory
            // 
            this.tvCategory.BackColor = System.Drawing.Color.White;
            this.tvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.tvCategory.FullRowSelect = true;
            this.tvCategory.HideSelection = false;
            this.tvCategory.ItemHeight = 30;
            this.tvCategory.Location = new System.Drawing.Point(10, 12);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            new System.Windows.Forms.TreeNode("计算机类", new System.Windows.Forms.TreeNode[] {
            new System.Windows.Forms.TreeNode("C#"),
            new System.Windows.Forms.TreeNode("Java"),
            new System.Windows.Forms.TreeNode("Python"),
            new System.Windows.Forms.TreeNode("数据库")}),
            new System.Windows.Forms.TreeNode("文学类", new System.Windows.Forms.TreeNode[] {
            new System.Windows.Forms.TreeNode("小说"),
            new System.Windows.Forms.TreeNode("散文"),
            new System.Windows.Forms.TreeNode("诗歌")}),
            new System.Windows.Forms.TreeNode("历史类"),
            new System.Windows.Forms.TreeNode("哲学类"),
            new System.Windows.Forms.TreeNode("艺术类")})});
            this.tvCategory.ShowLines = false;
            this.tvCategory.ShowRootLines = false;
            this.tvCategory.Size = new System.Drawing.Size(274, 638);
            this.tvCategory.ExpandAll();
            this.tvCategory.TabIndex = 0;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.White;
            this.pnlTool.Controls.Add(this.flpTool);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(722, 58);
            this.pnlTool.TabIndex = 0;
            // 
            // flpTool
            // 
            this.flpTool.Controls.Add(this.btnAddCategory);
            this.flpTool.Controls.Add(this.btnEditCategory);
            this.flpTool.Controls.Add(this.btnDeleteCategory);
            this.flpTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTool.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpTool.Location = new System.Drawing.Point(0, 0);
            this.flpTool.Name = "flpTool";
            this.flpTool.Padding = new System.Windows.Forms.Padding(12, 12, 12, 8);
            this.flpTool.Size = new System.Drawing.Size(722, 58);
            this.flpTool.TabIndex = 0;
            this.flpTool.WrapContents = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(164)))), ((int)(((byte)(93)))));
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(15, 15);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(116, 34);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "＋  新增分类";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditCategory.Location = new System.Drawing.Point(144, 15);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(92, 34);
            this.btnEditCategory.TabIndex = 1;
            this.btnEditCategory.Text = "✎  编辑";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(249, 15);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(92, 34);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "✕  删除";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.btnCloseTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 58);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(722, 44);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(40, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "分类";
            // 
            // btnCloseTitle
            // 
            this.btnCloseTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTitle.FlatAppearance.BorderSize = 0;
            this.btnCloseTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.btnCloseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.btnCloseTitle.Location = new System.Drawing.Point(680, 8);
            this.btnCloseTitle.Name = "btnCloseTitle";
            this.btnCloseTitle.Size = new System.Drawing.Size(28, 28);
            this.btnCloseTitle.TabIndex = 1;
            this.btnCloseTitle.Text = "×";
            this.btnCloseTitle.UseVisualStyleBackColor = true;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvCategory);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 102);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(12, 2, 12, 12);
            this.pnlGrid.Size = new System.Drawing.Size(722, 558);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToResizeRows = false;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.ColumnHeadersHeight = 40;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategoryNo,
            this.colCategoryName,
            this.colParent,
            this.colBookCount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgvCategory.Location = new System.Drawing.Point(12, 2);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.RowTemplate.Height = 36;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(698, 544);
            this.dgvCategory.TabIndex = 0;
            // 
            // colCategoryNo
            // 
            this.colCategoryNo.FillWeight = 70F;
            this.colCategoryNo.HeaderText = "序号";
            this.colCategoryNo.Name = "colCategoryNo";
            this.colCategoryNo.ReadOnly = true;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FillWeight = 200F;
            this.colCategoryName.HeaderText = "分类名称";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.ReadOnly = true;
            // 
            // colParent
            // 
            this.colParent.FillWeight = 140F;
            this.colParent.HeaderText = "上级分类";
            this.colParent.Name = "colParent";
            this.colParent.ReadOnly = true;
            // 
            // colBookCount
            // 
            this.colBookCount.FillWeight = 120F;
            this.colBookCount.HeaderText = "图书数量";
            this.colBookCount.Name = "colBookCount";
            this.colBookCount.ReadOnly = true;
            // 
            // FrmBookCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1040, 680);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "FrmBookCategory";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图书分类管理";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTree.ResumeLayout(false);
            this.pnlTool.ResumeLayout(false);
            this.flpTool.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlTree;
        private System.Windows.Forms.TreeView tvCategory;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.FlowLayoutPanel flpTool;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCloseTitle;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookCount;
    }
}
