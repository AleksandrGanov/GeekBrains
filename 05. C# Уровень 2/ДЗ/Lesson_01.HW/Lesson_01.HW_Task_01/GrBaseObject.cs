using System.Drawing;

namespace MyGame
{
    /// <summary>
    /// Базовый графический объект
    /// </summary>
    class GrBaseObject
    {
        /// <summary>
        /// Точка координат
        /// </summary>
        protected Point Pos;
        /// <summary>
        /// Направление движение
        /// </summary>
        protected Point Dir;
        /// <summary>
        /// Размер объекта
        /// </summary>
        protected Size Size;

        public GrBaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        /// <summary>
        /// Метод отрисовывает объект текущего класса на игровом пространстве
        /// </summary>
        public virtual void Draw()
        {
            GameLogic.buffer.Graphics.DrawEllipse(Pens.White, Pos.X, Pos.Y, Size.Width, Size.Height);
        }
        /// <summary>
        /// Метод осуществляет изменение позиции объекта текущего класса на игровом пространстве
        /// </summary>
        public virtual void Update()
        {
            Pos.X += Dir.X;
            Pos.Y += Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > GameLogic.GameWindowWidth) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > GameLogic.GameWindowHeight) Dir.Y = -Dir.Y;
        }
    }
}
