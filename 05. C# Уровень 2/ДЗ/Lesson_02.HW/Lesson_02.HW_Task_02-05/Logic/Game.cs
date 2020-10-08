using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{
    /// <summary>
    /// Базовый класс игры
    /// </summary>
    static class Game
    {       
        public static BufferedGraphics buffer;
        public static BufferedGraphicsContext context;
                
        /// <summary>
        /// Генератор случайных значений
        /// </summary>
        public static Random rnd = new Random();

        /// <summary>
        /// Пуля
        /// </summary>
        private static Bullet bullet;
        /// <summary>
        /// Коллекция астероидов
        /// </summary>
        private static Asteroid[] asteroids;
        /// <summary>
        /// Коллекция базовых объектов игрового пространства
        /// </summary>
        public static BaseObject[] objs;

        /// <summary>
        /// Высота игрового окна
        /// </summary>
        public static int GameWindowHeight { get; set; }
        /// <summary>
        /// Ширина игрового окна
        /// </summary>
        public static int GameWindowsWidth { get; set; } 

        /// <summary>
        /// Метод инициализирует игру, устанавливает параметры игрового поля, запускает таймер
        /// </summary>
        /// <param name="form"></param>
        public static void Init(Form form)
        {            
            context = BufferedGraphicsManager.Current;
            Graphics g = form.CreateGraphics();
            GameWindowsWidth = form.ClientSize.Width;
            GameWindowHeight = form.ClientSize.Height;
            buffer = context.Allocate(g, new Rectangle(0, 0, GameWindowsWidth, GameWindowHeight));

            Load();
            var timer = new Timer { Interval = 100 };
            timer.Start();
            timer.Tick += Timer_Tick;
        }
        /// <summary>
        /// Метод создает массив обьектов разного типа для их дальнейшей прорисовки
        /// </summary>
        public static void Load()
        {
            // создаем внешний фон: базовые объекты, звезды, изображения
            objs = new BaseObject[50];
            for (int i = 0; i < objs.Length; i++)
            {
                int choice = rnd.Next(1, 100);
 
                if (choice < 60)
                {
                    int size = rnd.Next(5, 12);
                    objs[i] = new Spheres(new Point(20, i * rnd.Next(1, 25)), new Point(rnd.Next(1, 7) - i, rnd.Next(1, 7) - i), new Size(size, size));
                }
                else 
                {
                    int size = rnd.Next(10, 20);
                    objs[i] = new Star(new Point(20, rnd.Next(1, GameWindowHeight)), new Point(rnd.Next(5, 15), rnd.Next(1, 7)), new Size(size, size));
                }
            }

            // создаем Пули и Астероиды
            try
            {
                bullet = new Bullet(new Point(0, rnd.Next(100,650)), new Point(20, 0), new Size(50, 25));
            }
            catch (BulletException e)
            {
                MessageBox.Show(e.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            asteroids = new Asteroid[15];
            for (var i = 0; i < asteroids.Length; i++)
            {
                int rndVal = rnd.Next(15, 70);
                asteroids[i] = new Asteroid(new Point(GameWindowsWidth, rnd.Next(0, GameWindowHeight)), new Point(rnd.Next(-5,5), rnd.Next(-5, 5)), new Size(rndVal, rndVal));
            }
        }
        /// <summary>
        /// Метод отрисовывает каждый объект массива на игровом поле
        /// </summary>
        public static void Paint()
        {
            buffer.Graphics.Clear(Color.Black);
            buffer.Graphics.DrawImage(Properties.Resources.cosmos, 0, 0);
            foreach (BaseObject obj in objs) obj.Draw();
            foreach (Asteroid aster in asteroids) aster.Draw();
            bullet.Draw();
            buffer.Render();
        }
        /// <summary>
        /// Метод меняет позиции каждого объекта на игровом поле
        /// </summary>
        public static void UpdatePosition()
        {
            foreach (BaseObject obj in objs)
                try
                {
                    obj.Update();
                }
                catch { }
            bullet.Update();
            foreach (Asteroid aster in asteroids)
            {
                aster.Update();
                if (aster.Collision(bullet))
                { 
                    System.Media.SystemSounds.Hand.Play();
                    Console.WriteLine("столкновение пули и астероида");
                    aster.UpdateAfterCollision();
                    bullet.UpdateAfterCollision();
                }
            }
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