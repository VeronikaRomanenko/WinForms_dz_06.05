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
