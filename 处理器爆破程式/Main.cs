using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace 处理器爆破程式
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Low frm = new Low();//实例化
            frm.Show();//打开窗口
        }

        private void button2_Click(object sender, EventArgs e)
        {
            High frm = new High();//实例化
            frm.Show();//打开窗口
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hentai frm = new Hentai();//实例化
            frm.Show();//打开窗口
        }
    }
}
