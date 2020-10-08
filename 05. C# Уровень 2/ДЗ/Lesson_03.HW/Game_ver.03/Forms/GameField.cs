using System;
using System.Windows.Forms;

namespace MyGame
{
    public partial class GameField : Form
    {
        public GameField(int width, int height)
        {
            // генерим ошибку если форма слишком большая
            if (width > 1500 || height > 1200) throw new Exception("Форма слишком большая, так не пойдет!!!");

            InitializeComponent();
            Width = width;
            Height = height;
        }

        private void GrForm_Load(Object sender, EventArgs e)
        {

        }
    }
}
