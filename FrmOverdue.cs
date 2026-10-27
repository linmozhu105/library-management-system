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
    /// 逾期催还窗体（借阅管理 → 逾期催还）。
    /// 顶部按逾期天数下限与读者类型筛选，表格每行带勾选列支持批量操作，
    /// 工具条提供发送催还通知与导出名单两个批量按钮；联系方式需脱敏显示。
    /// 批量逻辑与脱敏属于代码部分，按步骤补充。
    /// </summary>
    public partial class FrmOverdue : Form
    {
        public FrmOverdue()
        {
            InitializeComponent();
        }
    }
}
