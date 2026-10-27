using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLibrarySystem
{
    /// <summary>
    /// 图书管理系统主界面（MDI 父窗体）。
    /// 界面布局已经搭好：菜单栏、工具栏、左侧导航、状态栏直接挂在窗体上，
    /// 中间客户区由 MdiClient 承载各功能子窗体。
    /// 本文件只保留空方法骨架，事件绑定已在设计器里接好，逐个填方法体即可。
    /// </summary>
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
            //默认打开图书管理页面
            OpenMdiChild(new FrmBookList());
            // 提示：MDI 客户区默认是深灰色，想改成浅色可以遍历 this.Controls 找到 MdiClient 再设 BackColor。
        }

        private void OpenMdiChild(Form child)
        {
            //遍历父窗口的全部孩子
            foreach (var item in this.MdiChildren)
            {
                //如果同类型的子孩子  把他显示都最上面 GetType获取类型
                if (item.GetType() == child.GetType())
                {
                    item.Activate();    // 把已有窗口拉到最前面
                    child.Dispose();   // 刚 new 出来这个用不上，释放掉
                    return;            // 直接结束，不再往下执行
                }
            }
            //如果父窗体没有这个孩子
            child.MdiParent = this;     //把该窗口指定为父窗体

            child.WindowState = FormWindowState.Maximized;//把子窗口初始最大化
            child.Show();              // 子窗体用 Show，不能用 ShowDialog
        }

        #region 系统菜单

        private void mnuUserManage_Click(object sender, EventArgs e)
        {
            // TODO: 打开用户管理窗体
            //FrmUserManage frmUserManage = new FrmUserManage();
            //OpenMdiChild(frmUserManage);
            //等价写法
            OpenMdiChild(new FrmUserManage());
        }

        private void mnuChangePwd_Click(object sender, EventArgs e)
        {
            // TODO: 打开修改密码对话框（ShowDialog）
            using (FrmChangePwd dlg = new FrmChangePwd())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("密码修改成功，请重新登录。", "提示");
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            // TODO: 确认后退出程序
            if (MessageBox.Show("确定要退出系统吗？", "退出",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        #region 图书管理

        private void mnuBookIn_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书入库窗体
            OpenMdiChild(new FrmBookIn());
        }

        private void mnuBookCategory_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书分类窗体
            OpenMdiChild(new FrmBookCategory());
        }

        private void mnuBookCheck_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书盘点窗体
            OpenMdiChild(new FrmBookCheck());
        }

        #endregion

        #region 读者管理

        private void mnuReaderFile_Click(object sender, EventArgs e)
        {
            // TODO: 打开读者档案窗体
            OpenMdiChild(new FrmReaderFile());
        }

        private void mnuReaderLoss_Click(object sender, EventArgs e)
        {
            // TODO: 打开读者挂失窗体
            OpenMdiChild(new FrmReaderLoss());
        }

        #endregion

        #region 借阅管理

        private void mnuBorrowIn_Click(object sender, EventArgs e)
        {
            // TODO: 打开借书登记窗体
            OpenMdiChild(new FrmBorrowRegister());
        }

        private void mnuBorrowOut_Click(object sender, EventArgs e)
        {
            // TODO: 打开还书登记窗体
            OpenMdiChild(new FrmReturnBook());
        }

        private void mnuBorrowOverdue_Click(object sender, EventArgs e)
        {
            // TODO: 打开逾期催还窗体
            OpenMdiChild(new FrmOverdue());
        }

        #endregion

        #region 帮助

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            // TODO: 弹出关于对话框
        }

        #endregion

        #region 工具栏

        private void tsbBookIn_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书入库窗体
            OpenMdiChild(new FrmBookIn());
        }

        private void tsbBorrow_Click(object sender, EventArgs e)
        {
            // TODO: 打开借书登记窗体
            OpenMdiChild(new FrmBorrowRegister());
        }

        private void tsbReturn_Click(object sender, EventArgs e)
        {
            // TODO: 打开还书登记窗体
            OpenMdiChild(new FrmReturnBook());
        }

        private void tsbReader_Click(object sender, EventArgs e)
        {
            // TODO: 打开读者档案窗体
            OpenMdiChild(new FrmReaderFile());
        }

        private void tsbStat_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书盘点窗体
            OpenMdiChild(new FrmBookCheck());
        }

        private void tsbSetting_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 左侧导航

        private void btnNavBook_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书入库窗体
            OpenMdiChild(new FrmBookList());
        }

        private void btnNavReader_Click(object sender, EventArgs e)
        {
            // TODO: 打开读者档案窗体
            OpenMdiChild(new FrmReaderFile());
        }

        private void btnNavBorrow_Click(object sender, EventArgs e)
        {
            // TODO: 打开借书登记窗体
            OpenMdiChild(new FrmBorrowRegister());
        }

        private void btnNavReturn_Click(object sender, EventArgs e)
        {
            // TODO: 打开还书登记窗体
            OpenMdiChild(new FrmReturnBook());
        }

        private void btnNavSearch_Click(object sender, EventArgs e)
        {
            // TODO: 打开图书查询窗体（FrmBookList）
            OpenMdiChild(new FrmBookList());
        }

        private void btnNavSetting_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
