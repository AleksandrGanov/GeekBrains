using System.Drawing;

namespace MyGame
{
    class Image_ : BaseObject
    {
        Image _image;

        public Image_(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            _image = Image.FromFile("photo.jpg");
        }
        
        /// <summary>
        /// Метод рисует изображение из файла
        /// </summary>
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_image, Pos);
        }
    }
}