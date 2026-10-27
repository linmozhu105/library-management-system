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
    /// 借书登记窗体（借阅管理 → 借书登记）。
    /// 读者信息与图书信息两个 GroupBox 上下堆叠，各用 TableLayoutPanel 排成两行；
    /// 下方表格显示本次已借图书，底部显示已借数量（如 3/5，超过上限禁止借书）。
    /// 扫码带出信息与上限校验属于代码部分，按步骤补充。
    /// </summary>
    public partial class FrmBorrowRegister : Form
    {
        public FrmBorrowRegister()
        {
            InitializeComponent();
        }
    }
}
