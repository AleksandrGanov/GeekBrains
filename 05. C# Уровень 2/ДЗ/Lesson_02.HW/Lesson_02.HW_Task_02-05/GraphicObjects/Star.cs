using System.Drawing;

namespace MyGame
{
    /// <summary>
    /// Графический объект "звезда"
    /// </summary>
    class Star : BaseObject
    {
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size) { }

        /// <summary>
        /// Метод рисует звезду в форме креста
        /// </summary>
        public override void Draw()
        {
            Game.buffer.Graphics.DrawLine(Pens.Yellow, Pos.X, Pos.Y, Pos.X + Size.Width, Pos.Y + Size.Height);
            Game.buffer.Graphics.DrawLine(Pens.White, Pos.X + Size.Width, Pos.Y, Pos.X, Pos.Y + Size.Height);
        }

        /// <summary>
        /// Метод производит смещение позиции звезды
        /// </summary>
        public override void Update()
        {
            Pos.X -= Dir.X;
            if (Pos.X < 0) Pos.X = Game.GameWindowsWidth + Size.Width;
        }
    }
}