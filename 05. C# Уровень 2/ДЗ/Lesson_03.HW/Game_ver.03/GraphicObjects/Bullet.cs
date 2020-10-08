using MyGame.Properties;

using System.Drawing;

namespace MyGame
{
    class Bullet : BaseObject
    {
        private readonly Image image;

        // Ограничения на размер пули
        const int bulletMaxWidth = 100;
        const int bulletMaxHeight = 100;

        public Bullet(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            image = new Bitmap(Resources.bullet);
            if (size.Width > bulletMaxWidth || size.Height > bulletMaxHeight)
            {
                throw new BulletException($"Слишком большая пуля, допустимые размеры: ширина - {bulletMaxWidth}, высота - {bulletMaxHeight}");
            }
        }

        /// <summary>
        /// Метод рисует звезду в форме пули
        /// </summary>
        public override void Draw() =>
            Game.buffer.Graphics.DrawImage(image, Pos.X, Pos.Y, Size.Width, Size.Height);

        /// <summary>
        /// Метод производит смещение позиции пули (в случае если пуля улета за правую сторону игровой области,
        /// смещает пулю обратно к левой стороне игровой области
        /// </summary>
        public override void Update()
        {
            if ((Pos.X += Dir.X) < Game.GameWindowsWidth) Pos.X += Dir.X;
            else
            {
                Pos.Y = Game.rnd.Next(10, Game.GameWindowHeight - 10);
                Pos.X = 0;
            }
        }
        /// <summary>
        /// Метод меняет начальную позицию Пули при столкновении с Астероидом на левый край игровой области
        /// </summary>
        /// <param name="bullet">Текущий экземпляр класса Bullet</param>
        public void UpdateAfterCollision()
        {
            Pos.X = 0;
            Pos.Y = Game.rnd.Next(10, Game.GameWindowHeight - 10);
        }
    }
}