using System;
using System.Drawing;
using System.Resources;

namespace MyGame
{
    class Image_ : BaseObject
    {
        Image _image;
        Random rnd =new Random();

        public Image_(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            _image = Image.FromFile("photo.png");

        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_image, Pos.X, Pos.Y, Size.Width*_image.Width/100, Size.Width * _image.Height/100);
        }
    }
}