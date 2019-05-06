using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_dz_06._05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "Нажмите, чтобы отобразить окно";
            notifyIcon1.BalloonTipTitle = "Подсказка";
            notifyIcon1.ShowBalloonTip(10);
            notifyIcon1.Click += NotifyIcon1_Click;
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnAddTopMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolMenuStripItem = (ToolStripMenuItem)menuStrip1.Items.Add(txbTopLevelMenu.Text);
        }

        private void btnAddSubMenu_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.Text == txbTopLevelMenu.Text)
                {
                    item.DropDownItems.Add(txbSubItem.Text);
                }
            }
        }
    }
}
