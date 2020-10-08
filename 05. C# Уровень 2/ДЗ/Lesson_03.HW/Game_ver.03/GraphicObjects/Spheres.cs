using System.Drawing;

namespace MyGame
{
    class Spheres : BaseObject
    {
        public Spheres(Point pos, Point dir, Size size) : base(pos, dir, size) { }
        
        /// <summary>
        /// Метод рисует сферу
        /// </summary>
        public override void Draw() => Game.buffer.Graphics.DrawEllipse(Pens.White, Pos.X, Pos.Y, Size.Width, Size.Height);

        /// <summary>
        /// Метод производит смещение позиции сферы
        /// </summary>
        public override void Update()
        {
            Pos.X += Dir.X;
            Pos.Y += Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > Game.GameWindowsWidth) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > Game.GameWindowHeight) Dir.Y = -Dir.Y;
        }
    }
}
