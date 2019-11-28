using System.Drawing;

namespace MyGame
{
    class Image_ : BaseObject
    {
        Image _image = Image.FromFile("photo.jpg");

        public Image_(Point pos, Point dir, Size size) : base(pos, dir, size) { }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(_image, Pos);
        }
    }
}