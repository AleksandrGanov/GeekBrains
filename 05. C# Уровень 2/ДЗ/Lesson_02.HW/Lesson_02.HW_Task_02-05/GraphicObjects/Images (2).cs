using System.Drawing;

namespace MyGame
{
    class Images : BaseObject
    {
        Image _image;

        public Images(Point pos, Point dir, Size size) : base(pos, dir, size)
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

        /// <summary>
        /// Метод производит смещение позиции изображения из файла 
        /// </summary>
        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
        }
    }
}