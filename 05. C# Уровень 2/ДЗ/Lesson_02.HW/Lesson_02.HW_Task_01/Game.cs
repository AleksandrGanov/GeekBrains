using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{
    static class Game
    {
        private static Bullet _bullet;
        private static Asteroid[] _asteroids;
        public static BufferedGraphics Buffer;
        public static BufferedGraphicsContext _context;
        public static BaseObject[] _objs;

        public static int Height { get; set; }
        public static int Width { get; set; }

        /// <summary>
        /// Метод инициализирует игру, устанавливает параметры игрового поля, запускает таймер
        /// </summary>
        /// <param name="form"></param>
        public static void Init(Form form)
        {
            _context = BufferedGraphicsManager.Current;
            Graphics g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));

            Load();
            Timer timer = new Timer { Interval = 150 };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Метод создает массив обьектов разного типа для их дальнейшей прорисовки
        /// </summary>
        public static void Load()
        {

            // создаем внешний фон: базовые объекты, звезды, изображения
            Random rnd = new Random();
            _objs = new BaseObject[50];
            for (int i = 0; i < _objs.Length; i++)
            {
                int choice = rnd.Next(1, 100);

                if (choice < 60)
                {
                    int size = rnd.Next(5, 12);
                    _objs[i] = new BaseObject(new Point(20, i * rnd.Next(1, 25)), new Point(rnd.Next(1, 7) - i, rnd.Next(1, 7) - i), new Size(size, size));
                }
                else 
                {
                    int size = rnd.Next(10, 20);
                    _objs[i] = new Star(new Point(20, rnd.Next(1, Height)), new Point(rnd.Next(5, 15), rnd.Next(1, 7)), new Size(size, size));
                }
            }

            // создаем Пули и Астероиды
            _bullet = new Bullet(new Point(0, 500), new Point(25, 0), new Size(8, 5));
            _asteroids = new Asteroid[20];
            for (var i = 0; i < _asteroids.Length; i++)
            {
                int r = rnd.Next(1, 50);
                _asteroids[i] = new Asteroid(new Point(1000, rnd.Next(0, Game.Height)), new Point(-rnd.Next(1,5), rnd.Next(1, 5)), new Size(r, r));
            }
        }

        /// <summary>
        /// Метод отрисовывает каждый объект массива на игровом поле
        /// </summary>
        public static void Paint()
        {
            Buffer.Graphics.Clear(Color.Black);
            foreach (BaseObject obj in _objs)
            {
                try
                {
                    obj.Draw();
                }
                catch { }
            }
            foreach (Asteroid aster in _asteroids)
            {
                aster.Draw();
            }
            _bullet.Draw();
            Buffer.Render();
        }

        /// <summary>
        /// Метод меняет позиции каждого объекта на игровом поле
        /// </summary>
        public static void UpdatePosition()
        {
            foreach (BaseObject obj in _objs)
                try
                {
                    obj.Update();
                }
                catch { }
            foreach (Asteroid aster in _asteroids)
            {
                aster.Update();
                if (aster.Collision(_bullet))
                { 
                    System.Media.SystemSounds.Hand.Play();
                    Console.WriteLine("столкновение пули и астероида");
                }
            }
            _bullet.Update();

        }

        /// <summary>
        /// Метод, инициализируемый таймер для запуска отрисовки и изменения позиции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Timer_Tick(object sender, EventArgs e)
        {
            Paint();
            UpdatePosition();
        }
    }
}