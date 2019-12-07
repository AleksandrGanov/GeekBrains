using System.Drawing;

namespace MyGame
{
    class Asteroid : BaseObject
    {
        public int Power { get; set; }

        public Asteroid(Point pos, Point dir, Size size) : base(pos, dir, size) { }

        /// <summary>
        /// Метод рисует объект Астероид
        /// </summary>
        public override void Draw()
        {
            Game.Buffer.Graphics.FillEllipse(Brushes.Yellow, Pos.X, Pos.Y, Size.Width, Size.Height);
        }
    }
}
