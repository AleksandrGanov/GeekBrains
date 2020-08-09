using System;
using System.Drawing;

namespace Lesson_03.Exp_04
{
    class Asteroid : BaseObject, ICloneable, IComparable, IComparable<Asteroid>
    {
        Brush brush = Brushes.Yellow;
        private readonly Object GS;

        public int Power { get; set; } = 3;

        public Asteroid(Point pos, Point dir, Size size) : base(pos, dir, size) { }

        /// <summary>
        /// Метод рисует объект Астероид
        /// </summary>
        public override void Draw()
        {
            // Game.Buffer.Graphics.FillEllipse(brush, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        /// <summary>
        /// Метод производит смещение позиции Астероида 
        /// </summary>
        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            // if (Pos.X > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            // if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
            brush = Brushes.Yellow;
        }

        /// <summary>
        /// Метод меняет начальную позицию Астероида при столкновении с пулей на правый край игровой области
        /// </summary>
        /// <param name="bullet">Текущий экземпляр класса Asteroid</param>
        public void Update(Asteroid aster)
        {
            // Pos.X = Game.Width - aster.Size.Width;
            Pos.Y = aster.Pos.Y;
            brush = Brushes.Green;
        }

        // Реализация интерфейсов
        public Object Clone() => new Asteroid(Pos, Dir, Size) { Power = Power };
        public int CompareTo(Object obj)
        {
            if (obj is Asteroid aster) 
            {
                if (Power > aster.Power) return 1;
                if (Power < aster.Power) return -1;
                else return 0;
            }
            throw new ArgumentException("Parametr is not Asteroid");
        }
        public int CompareTo(Asteroid aster)
        {
            if (Power > aster.Power) return 1;
            if (Power < aster.Power) return -1;
            else return 0;
        }
    }
}
