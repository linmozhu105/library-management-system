namespace WindowsFormsLibrarySystem
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReader = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReaderFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReaderLoss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrowIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrowOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrowOverdue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBookIn = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrow = new System.Windows.Forms.ToolStripButton();
            this.tsbReturn = new System.Windows.Forms.ToolStripButton();
            this.tsbReader = new System.Windows.Forms.ToolStripButton();
            this.tsbStat = new System.Windows.Forms.ToolStripButton();
            this.tsbSetting = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.flowNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNavBook = new System.Windows.Forms.Button();
            this.btnNavReader = new System.Windows.Forms.Button();
            this.btnNavBorrow = new System.Windows.Forms.Button();
            this.btnNavReturn = new System.Windows.Forms.Button();
            this.btnNavSearch = new System.Windows.Forms.Button();
            this.btnNavSetting = new System.Windows.Forms.Button();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.flowNav.SuspendLayout();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuBook,
            this.mnuReader,
            this.mnuBorrow,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserManage,
            this.mnuChangePwd,
            this.mnuExit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(72, 24);
            this.mnuSystem.Text = "系统(&S)";
            // 
            // mnuUserManage
            // 
            this.mnuUserManage.Name = "mnuUserManage";
            this.mnuUserManage.Size = new System.Drawing.Size(224, 26);
            this.mnuUserManage.Text = "用户管理(&U)";
            this.mnuUserManage.Click += new System.EventHandler(this.mnuUserManage_Click);
            // 
            // mnuChangePwd
            // 
            this.mnuChangePwd.Name = "mnuChangePwd";
            this.mnuChangePwd.Size = new System.Drawing.Size(173, 26);
            this.mnuChangePwd.Text = "修改密码(&P)";
            this.mnuChangePwd.Click += new System.EventHandler(this.mnuChangePwd_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(173, 26);
            this.mnuExit.Text = "退出(&X)";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuBook
            // 
            this.mnuBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBookIn,
            this.mnuBookCategory,
            this.mnuBookCheck});
            this.mnuBook.Name = "mnuBook";
            this.mnuBook.Size = new System.Drawing.Size(102, 24);
            this.mnuBook.Text = "图书管理(&B)";
            // 
            // mnuBookIn
            // 
            this.mnuBookIn.Name = "mnuBookIn";
            this.mnuBookIn.Size = new System.Drawing.Size(172, 26);
            this.mnuBookIn.Text = "图书入库(&I)";
            this.mnuBookIn.Click += new System.EventHandler(this.mnuBookIn_Click);
            // 
            // mnuBookCategory
            // 
            this.mnuBookCategory.Name = "mnuBookCategory";
            this.mnuBookCategory.Size = new System.Drawing.Size(172, 26);
            this.mnuBookCategory.Text = "图书分类(&C)";
            this.mnuBookCategory.Click += new System.EventHandler(this.mnuBookCategory_Click);
            // 
            // mnuBookCheck
            // 
            this.mnuBookCheck.Name = "mnuBookCheck";
            this.mnuBookCheck.Size = new System.Drawing.Size(172, 26);
            this.mnuBookCheck.Text = "图书盘点(&S)";
            this.mnuBookCheck.Click += new System.EventHandler(this.mnuBookCheck_Click);
            // 
            // mnuReader
            // 
            this.mnuReader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReaderFile,
            this.mnuReaderLoss});
            this.mnuReader.Name = "mnuReader";
            this.mnuReader.Size = new System.Drawing.Size(103, 24);
            this.mnuReader.Text = "读者管理(&R)";
            // 
            // mnuReaderFile
            // 
            this.mnuReaderFile.Name = "mnuReaderFile";
            this.mnuReaderFile.Size = new System.Drawing.Size(173, 26);
            this.mnuReaderFile.Text = "读者档案(&A)";
            this.mnuReaderFile.Click += new System.EventHandler(this.mnuReaderFile_Click);
            // 
            // mnuReaderLoss
            // 
            this.mnuReaderLoss.Name = "mnuReaderLoss";
            this.mnuReaderLoss.Size = new System.Drawing.Size(173, 26);
            this.mnuReaderLoss.Text = "读者挂失(&L)";
            this.mnuReaderLoss.Click += new System.EventHandler(this.mnuReaderLoss_Click);
            // 
            // mnuBorrow
            // 
            this.mnuBorrow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBorrowIn,
            this.mnuBorrowOut,
            this.mnuBorrowOverdue});
            this.mnuBorrow.Name = "mnuBorrow";
            this.mnuBorrow.Size = new System.Drawing.Size(101, 24);
            this.mnuBorrow.Text = "借阅管理(&L)";
            // 
            // mnuBorrowIn
            // 
            this.mnuBorrowIn.Name = "mnuBorrowIn";
            this.mnuBorrowIn.Size = new System.Drawing.Size(174, 26);
            this.mnuBorrowIn.Text = "借书登记(&B)";
            this.mnuBorrowIn.Click += new System.EventHandler(this.mnuBorrowIn_Click);
            // 
            // mnuBorrowOut
            // 
            this.mnuBorrowOut.Name = "mnuBorrowOut";
            this.mnuBorrowOut.Size = new System.Drawing.Size(174, 26);
            this.mnuBorrowOut.Text = "还书登记(&R)";
            this.mnuBorrowOut.Click += new System.EventHandler(this.mnuBorrowOut_Click);
            // 
            // mnuBorrowOverdue
            // 
            this.mnuBorrowOverdue.Name = "mnuBorrowOverdue";
            this.mnuBorrowOverdue.Size = new System.Drawing.Size(174, 26);
            this.mnuBorrowOverdue.Text = "逾期催还(&O)";
            this.mnuBorrowOverdue.Click += new System.EventHandler(this.mnuBorrowOverdue_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(75, 24);
            this.mnuHelp.Text = "帮助(&H)";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(173, 26);
            this.mnuAbout.Text = "关于系统(&A)";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBookIn,
            this.tsbBorrow,
            this.tsbReturn,
            this.tsbReader,
            this.tsbStat,
            this.tsbSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.toolStrip1.Size = new System.Drawing.Size(1080, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBookIn
            // 
            this.tsbBookIn.Image = global::WindowsFormsLibrarySystem.Properties.Resources.报表;
            this.tsbBookIn.Name = "tsbBookIn";
            this.tsbBookIn.Size = new System.Drawing.Size(93, 24);
            this.tsbBookIn.Text = "图书入库";
            this.tsbBookIn.Click += new System.EventHandler(this.tsbBookIn_Click);
            // 
            // tsbBorrow
            // 
            this.tsbBorrow.Image = global::WindowsFormsLibrarySystem.Properties.Resources.充值;
            this.tsbBorrow.Name = "tsbBorrow";
            this.tsbBorrow.Size = new System.Drawing.Size(93, 24);
            this.tsbBorrow.Text = "借书登记";
            this.tsbBorrow.Click += new System.EventHandler(this.tsbBorrow_Click);
            // 
            // tsbReturn
            // 
            this.tsbReturn.Image = global::WindowsFormsLibrarySystem.Properties.Resources.订单;
            this.tsbReturn.Name = "tsbReturn";
            this.tsbReturn.Size = new System.Drawing.Size(93, 24);
            this.tsbReturn.Text = "还书登记";
            this.tsbReturn.Click += new System.EventHandler(this.tsbReturn_Click);
            // 
            // tsbReader
            // 
            this.tsbReader.Image = global::WindowsFormsLibrarySystem.Properties.Resources.监控;
            this.tsbReader.Name = "tsbReader";
            this.tsbReader.Size = new System.Drawing.Size(93, 24);
            this.tsbReader.Text = "读者档案";
            this.tsbReader.Click += new System.EventHandler(this.tsbReader_Click);
            // 
            // tsbStat
            // 
            this.tsbStat.Image = global::WindowsFormsLibrarySystem.Properties.Resources.上网;
            this.tsbStat.Name = "tsbStat";
            this.tsbStat.Size = new System.Drawing.Size(93, 24);
            this.tsbStat.Text = "图书盘点";
            this.tsbStat.Click += new System.EventHandler(this.tsbStat_Click);
            // 
            // tsbSetting
            // 
            this.tsbSetting.Image = global::WindowsFormsLibrarySystem.Properties.Resources.区域;
            this.tsbSetting.Name = "tsbSetting";
            this.tsbSetting.Size = new System.Drawing.Size(93, 24);
            this.tsbSetting.Text = "系统设置";
            this.tsbSetting.Click += new System.EventHandler(this.tsbSetting_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUser,
            this.tslClock,
            this.tslVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1080, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslUser
            // 
            this.tslUser.Name = "tslUser";
            this.tslUser.Size = new System.Drawing.Size(129, 20);
            this.tslUser.Text = "当前登录：admin";
            // 
            // tslClock
            // 
            this.tslClock.Name = "tslClock";
            this.tslClock.Size = new System.Drawing.Size(801, 20);
            this.tslClock.Spring = true;
            this.tslClock.Text = "日期时间：";
            // 
            // tslVersion
            // 
            this.tslVersion.Name = "tslVersion";
            this.tslVersion.Size = new System.Drawing.Size(135, 20);
            this.tslVersion.Text = "图书管理系统 V1.0";
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.flowNav);
            this.pnlNav.Controls.Add(this.gbUser);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 59);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(200, 635);
            this.pnlNav.TabIndex = 6;
            // 
            // flowNav
            // 
            this.flowNav.AutoScroll = true;
            this.flowNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.flowNav.Controls.Add(this.btnNavBook);
            this.flowNav.Controls.Add(this.btnNavReader);
            this.flowNav.Controls.Add(this.btnNavBorrow);
            this.flowNav.Controls.Add(this.btnNavReturn);
            this.flowNav.Controls.Add(this.btnNavSearch);
            this.flowNav.Controls.Add(this.btnNavSetting);
            this.flowNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNav.Location = new System.Drawing.Point(0, 0);
            this.flowNav.Name = "flowNav";
            this.flowNav.Padding = new System.Windows.Forms.Padding(12, 14, 12, 12);
            this.flowNav.Size = new System.Drawing.Size(200, 539);
            this.flowNav.TabIndex = 1;
            this.flowNav.WrapContents = false;
            // 
            // btnNavBook
            // 
            this.btnNavBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavBook.Location = new System.Drawing.Point(15, 17);
            this.btnNavBook.Name = "btnNavBook";
            this.btnNavBook.Size = new System.Drawing.Size(176, 40);
            this.btnNavBook.TabIndex = 0;
            this.btnNavBook.Text = "图书管理";
            this.btnNavBook.UseVisualStyleBackColor = false;
            this.btnNavBook.Click += new System.EventHandler(this.btnNavBook_Click);
            // 
            // btnNavReader
            // 
            this.btnNavReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavReader.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavReader.Location = new System.Drawing.Point(15, 63);
            this.btnNavReader.Name = "btnNavReader";
            this.btnNavReader.Size = new System.Drawing.Size(176, 40);
            this.btnNavReader.TabIndex = 1;
            this.btnNavReader.Text = "读者档案";
            this.btnNavReader.UseVisualStyleBackColor = false;
            this.btnNavReader.Click += new System.EventHandler(this.btnNavReader_Click);
            // 
            // btnNavBorrow
            // 
            this.btnNavBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavBorrow.Location = new System.Drawing.Point(15, 109);
            this.btnNavBorrow.Name = "btnNavBorrow";
            this.btnNavBorrow.Size = new System.Drawing.Size(176, 40);
            this.btnNavBorrow.TabIndex = 2;
            this.btnNavBorrow.Text = "借书登记";
            this.btnNavBorrow.UseVisualStyleBackColor = false;
            this.btnNavBorrow.Click += new System.EventHandler(this.btnNavBorrow_Click);
            // 
            // btnNavReturn
            // 
            this.btnNavReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavReturn.Location = new System.Drawing.Point(15, 155);
            this.btnNavReturn.Name = "btnNavReturn";
            this.btnNavReturn.Size = new System.Drawing.Size(176, 40);
            this.btnNavReturn.TabIndex = 3;
            this.btnNavReturn.Text = "还书登记";
            this.btnNavReturn.UseVisualStyleBackColor = false;
            this.btnNavReturn.Click += new System.EventHandler(this.btnNavReturn_Click);
            // 
            // btnNavSearch
            // 
            this.btnNavSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavSearch.Location = new System.Drawing.Point(15, 201);
            this.btnNavSearch.Name = "btnNavSearch";
            this.btnNavSearch.Size = new System.Drawing.Size(176, 40);
            this.btnNavSearch.TabIndex = 4;
            this.btnNavSearch.Text = "图书查询";
            this.btnNavSearch.UseVisualStyleBackColor = false;
            this.btnNavSearch.Click += new System.EventHandler(this.btnNavSearch_Click);
            // 
            // btnNavSetting
            // 
            this.btnNavSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.btnNavSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNavSetting.Location = new System.Drawing.Point(15, 247);
            this.btnNavSetting.Name = "btnNavSetting";
            this.btnNavSetting.Size = new System.Drawing.Size(176, 40);
            this.btnNavSetting.TabIndex = 5;
            this.btnNavSetting.Text = "系统设置";
            this.btnNavSetting.UseVisualStyleBackColor = false;
            this.btnNavSetting.Click += new System.EventHandler(this.btnNavSetting_Click);
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.Color.White;
            this.gbUser.Controls.Add(this.lblUserInfo);
            this.gbUser.Controls.Add(this.picAvatar);
            this.gbUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbUser.Location = new System.Drawing.Point(0, 539);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.gbUser.Size = new System.Drawing.Size(200, 96);
            this.gbUser.TabIndex = 6;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "当前用户";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Location = new System.Drawing.Point(74, 28);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(116, 52);
            this.lblUserInfo.TabIndex = 0;
            this.lblUserInfo.Text = "管理员：admin\r\n角色：系统管理员";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(14, 26);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(52, 52);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统 - 主界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlNav.ResumeLayout(false);
            this.flowNav.ResumeLayout(false);
            this.gbUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslUser;
        private System.Windows.Forms.ToolStripStatusLabel tslClock;
        private System.Windows.Forms.ToolStripStatusLabel tslVersion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBookIn;
        private System.Windows.Forms.ToolStripButton tsbBorrow;
        private System.Windows.Forms.ToolStripButton tsbReturn;
        private System.Windows.Forms.ToolStripButton tsbReader;
        private System.Windows.Forms.ToolStripButton tsbStat;
        private System.Windows.Forms.ToolStripButton tsbSetting;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuUserManage;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePwd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBook;
        private System.Windows.Forms.ToolStripMenuItem mnuBookIn;
        private System.Windows.Forms.ToolStripMenuItem mnuBookCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuBookCheck;
        private System.Windows.Forms.ToolStripMenuItem mnuReader;
        private System.Windows.Forms.ToolStripMenuItem mnuReaderFile;
        private System.Windows.Forms.ToolStripMenuItem mnuReaderLoss;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrow;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrowIn;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrowOut;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrowOverdue;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.FlowLayoutPanel flowNav;
        private System.Windows.Forms.Button btnNavBook;
        private System.Windows.Forms.Button btnNavReader;
        private System.Windows.Forms.Button btnNavBorrow;
        private System.Windows.Forms.Button btnNavReturn;
        private System.Windows.Forms.Button btnNavSearch;
        private System.Windows.Forms.Button btnNavSetting;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.PictureBox picAvatar;
    }
}
