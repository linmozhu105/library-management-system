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
    /// 修改密码对话框（系统 → 修改密码）。
    /// 对话框型窗体：FormBorderStyle=FixedDialog、StartPosition=CenterParent、ControlBox=false，
    /// 用 ShowDialog() 打开，通过按钮的 DialogResult 判断用户点了确认还是取消。
    /// 本文件只保留窗体骨架，校验与改密逻辑按步骤补充。
    /// </summary>
    public partial class FrmChangePwd : Form
    {
        public FrmChangePwd()
        {
            InitializeComponent();
        }
    }
}
