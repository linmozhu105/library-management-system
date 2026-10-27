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
    /// 图书查询页（原主界面右侧的查询条件 + 图书列表）。
    /// 主界面改成 MDI 父窗体后，这部分内容独立成子窗体，由「图书查询」入口打开。
    /// </summary>
    public partial class FrmBookList : Form
    {
        public FrmBookList()
        {
            InitializeComponent();
        }
        private void FrmBookList_Load(object sender, EventArgs e)
        {
            dgvBooks.Rows.Add("B001", "C#高级编程", "Christian Nagel", "清华大学出版社", "计算机", "128.00", 5, 3);
            dgvBooks.Rows.Add("B002", "Java核心技术", "Cay S. Horstmann", "机械工业出版社", "计算机", "119.00", 6, 4);
            dgvBooks.Rows.Add("B003", "平凡的世界", "路遥", "北京十月文艺出版社", "文学", "98.00", 8, 5);
        }
    }
}
