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
    /// 图书盘点窗体（图书管理 → 图书盘点）。
    /// 顶部条件条按分类/书名筛选，中间表格显示账面与实盘数量，底部四个统计标签。
    /// 条件染色（RowPrePaint）与统计计算属于代码部分，按步骤补充。
    /// </summary>
    public partial class FrmBookCheck : Form
    {
        public FrmBookCheck()
        {
            InitializeComponent();
        }
    }
}
