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
    /// 用户管理窗体（系统 → 用户管理）。
    /// 三个区域全部用 Dock 停靠：工具栏 Dock=Top、表格 Fill、分页条 Dock=Bottom，
    /// 窗口怎么拉伸都不会错位。本文件只保留窗体骨架，业务代码按步骤补充。
    /// </summary>
    public partial class FrmUserManage : Form
    {
        public FrmUserManage()
        {
            InitializeComponent();
        }
    }
}
