using System.Drawing;

namespace MyGame
{
    /// <summary>
    /// Графический объект Астероид
    /// </summary>
    class GrAsteriod : GrBaseObject
    {
        /// <summary>
        /// Графический объект игрового пространства
        /// </summary>
        readonly Image image;

        public GrAsteriod(Point pos, Point dir, Size size) : base(pos, dir, size) =>
            image = Image.FromFile("photo.png");

        /// <summary>
        /// Метод осуществляет отрисовку GrImage
        /// </summary>
        public override void Draw() =>
            GameLogic.buffer.Graphics.DrawImage(image, Pos.X, Pos.Y, Size.Width * image.Width / 100, Size.Width * image.Height / 100);
    }
}