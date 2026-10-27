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
    /// 读者挂失窗体（读者管理 → 读者挂失）。
    /// 左右 SplitContainer：左栏挂失录入表单（含多行原因文本框），右栏挂失记录表格。
    /// 证号回车带出姓名与类型的联动属于代码部分，留待按步骤补充。
    /// </summary>
    public partial class FrmReaderLoss : Form
    {
        public FrmReaderLoss()
        {
            InitializeComponent();
        }
    }
}
