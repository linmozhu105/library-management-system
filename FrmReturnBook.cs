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
    /// 还书登记窗体（借阅管理 → 还书登记）。
    /// 输入条码回车后自动带出书名、借阅人、借出日期；
    /// 逾期提示 GroupBox 显示逾期天数与费用（天数 × 0.2 元/天），未逾期时隐藏该分组。
    /// 相关联动与计算属于代码部分，按步骤补充。
    /// </summary>
    public partial class FrmReturnBook : Form
    {
        public FrmReturnBook()
        {
            InitializeComponent();
        }
    }
}
