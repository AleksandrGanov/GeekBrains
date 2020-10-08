using MyGame.Properties;

using System;
using System.Drawing;

namespace MyGame
{
    /// <summary>
    /// Графический объект Астероид
    /// </summary>
    class Asteroid : BaseObject, IComparable, ICloneable
    {
        readonly Image image;
        /// <summary>
        /// Кол-во попаданий, необходимых для разрушения астероида
        /// </summary>
        public int Power { get; set; }

        public Asteroid(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            image = new Bitmap(Resources.asteroid);
            Power = 1;
        }

        /// <summary>
        /// Метод рисует объект Астероид
        /// </summary>
        public override void Draw() => Game.buffer.Graphics.DrawImage(image, Pos.X, Pos.Y, Size.Width, Size.Width);

        /// <summary>
        /// Метод производит смещение позиции Астероида 
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
        /// <summary>
        /// Метод меняет начальную позицию Астероида при столкновении с пулей на правый край игровой области
        /// </summary>
        /// <param name="bullet">Текущий экземпляр класса Asteroid</param>
        public void UpdateAfterCollision()
        {
            Pos.X = Game.GameWindowsWidth;
            Pos.Y = Game.rnd.Next(10, Game.GameWindowHeight - 10);
        }

        // Реализация интерфейсов
        public Int32 CompareTo(Object obj)
        {
            if (obj is Asteroid asteroid) return Power.CompareTo(asteroid.Power);
            else throw new ArgumentException("Переданный параметр не является Астероидом");
        }
        public Object Clone() => new Asteroid(new Point(Pos.X, Pos.Y), new Point(Dir.X, Dir.Y), new Size(Size.Width, Size.Height));
    }
}