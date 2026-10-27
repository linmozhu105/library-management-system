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
    /// 图书入库窗体（图书管理 → 图书入库）。
    /// 左右用 SplitContainer 分栏：左栏录入表单（GroupBox + TableLayoutPanel 两列网格），
    /// 右栏显示入库记录表格。本文件只保留窗体骨架，保存与校验逻辑按步骤补充。
    /// </summary>
    public partial class FrmBookIn : Form
    {
        public FrmBookIn()
        {
            InitializeComponent();
        }
    }
}
