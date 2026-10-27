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
    /// 图书分类管理窗体（图书管理 → 图书分类）。
    /// 左侧 TreeView 展示分类层级，右侧 GroupBox 内工具条 + DataGridView 显示明细。
    /// 树节点与表格的选中联动属于代码部分，按步骤补充。
    /// </summary>
    public partial class FrmBookCategory : Form
    {
        public FrmBookCategory()
        {
            InitializeComponent();
        }
    }
}
