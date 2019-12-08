using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class GrForm : Form
    {
        public GrForm(int width, int height)
        {
            InitializeComponent();
            this.Width = width;
            this.Height = height;
        }
    }
}
