using System.Drawing;

namespace MyGame
{
    class Bullet : BaseObject
    {
        // Ограничения на размер пули
        const int bulletMaxWidth = 20;
        const int bulletMaxHeight = 10;

        public Bullet(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            if (size.Width > bulletMaxWidth || size.Height> bulletMaxHeight)
            {
                throw new BulletException($"Слишком большая пуля, допустимые размеры: ширина - {bulletMaxWidth}, высота - {bulletMaxHeight}");
            }  
        }

        /// <summary>
        /// Метод рисует звезду в форме пули
        /// </summary>
        public override void Draw()
        {
            Game.Buffer.Graphics.FillRectangle(Brushes.Red, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        /// <summary>
        /// Метод производит смещение позиции пули (в случае если пуля улета за правую сторону игровой области,
        /// смещает пулю обратно к левой стороне игровой области
        /// </summary>
        public override void Update()
        {
            if ((Pos.X += Dir.X) < Game.Width)
            {
                Pos.X += Dir.X;
            }
            else
            {
                Pos.X = this.Size.Width;
            }
        }

        /// <summary>
        /// Метод меняет начальную позицию Пули при столкновении с Астероидом на левый край игровой области
        /// </summary>
        /// <param name="bullet">Текущий экземпляр класса Bullet</param>
        public void Update(Bullet bullet)
        {
            Pos.X = bullet.Size.Width;
        }
    }
}