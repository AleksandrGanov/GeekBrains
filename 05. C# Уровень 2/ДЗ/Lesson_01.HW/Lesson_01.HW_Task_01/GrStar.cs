using System.Drawing;

namespace MyGame
{
    /// <summary>
    /// Графический объект Звезда
    /// </summary>
    class GrStar : GrBaseObject
    {
        public GrStar(Point pos, Point dir, Size size) : base(pos, dir, size) { }

        /// <summary>
        /// Метод отрисовывает объект текущего класса на игровом пространстве
        /// </summary>
        public override void Draw()
        {
            GameLogic.buffer.Graphics.DrawLine(Pens.Yellow, Pos.X, Pos.Y, Pos.X + Size.Width, Pos.Y + Size.Height);
            GameLogic.buffer.Graphics.DrawLine(Pens.White, Pos.X + Size.Width, Pos.Y, Pos.X, Pos.Y + Size.Height);
        }
        /// <summary>
        /// Метод осуществляет изменение позиции объекта текущего класса на игровом пространстве
        /// </summary>
        public override void Update()
        {
            Pos.X -= Dir.X;
            if (Pos.X < 0) Pos.X = GameLogic.GameWindowWidth + Size.Width;
        }
    }
}