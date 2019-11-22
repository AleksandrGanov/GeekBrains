using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mlString;

namespace Lesson_08.HW_Task_02
{
    public partial class frmTask02 : Form
    {
        public frmTask02()
        {
            InitializeComponent();
            nudUpDown.Maximum = 999;
        }

        private void nudUpDown_ValueChanged(Object sender, EventArgs e)
        {
            tbxText.Text = nudUpDown.Value.ToString();
        }

        private void tbxText_TextChanged(Object sender, EventArgs e)
        {
            string txtVal = tbxText.Text;
            if (txtVal == "") nudUpDown.Value = 0;
            else if (int.Parse(txtVal) > 999) tbxText.Text="0";
            else nudUpDown.Value = int.Parse(tbxText.Text);
        }

        private void tbxText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
