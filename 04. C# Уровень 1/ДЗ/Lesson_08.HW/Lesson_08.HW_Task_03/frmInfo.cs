using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Lesson_08.Exp_05
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        private void frmInfo_Shown(Object sender, EventArgs e)
        {
            lblAuthorText.Text = Application.CompanyName;
            lblVersionText.Text = Application.ProductVersion;
        }

        private void btnOK_Click(Object sender, EventArgs e)
        {
            Close();
        }
    }
}
