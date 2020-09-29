using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyGame
{
    /// <summary>
    /// Базовый класс игры
    /// </summary>
    static class GameLogic
    {
        public static BufferedGraphics buffer;
        public static BufferedGraphicsContext context;

        /// <summary>
        /// Массив объектов игрового пространства
        /// </summary>
        public static GrBaseObject[] gameObjects;

        /// <summary>
        /// Высота игрового окна
        /// </summary>
        public static int GameWindowHeight { get; set; }
        /// <summary>
        /// Ширина игрового окна
        /// </summary>
        public static int GameWindowWidth { get; set; }

        /// <summary>
        /// Метод инициализирует игровое пространство, вызывает метод наполнения объектов, 
        /// запускает таймер игры
        /// </summary>
        /// <param name="form">Базовая форма игры</param>
        public static void Init(Form form)
        {
            context = BufferedGraphicsManager.Current;
            var graficSurface = form.CreateGraphics();

            GameWindowWidth = form.ClientSize.Width;
            GameWindowHeight = form.ClientSize.Height;
            graficSurface.SmoothingMode = SmoothingMode.HighQuality;
            buffer = context.Allocate(graficSurface, new Rectangle(0, 0, GameWindowWidth, GameWindowHeight));

            Load();
            var timer = new Timer { Interval = 150 };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Метод производит заполнение массива объектов игрового пространства
        /// </summary>
        public static void Load()
        {
            var rnd = new Random();
            gameObjects = new GrBaseObject[1000];

            for (int i = 0; i < gameObjects.Length; i++)
            {
                int choice = rnd.Next(1, 100);

                if (choice < 60)
                {
                    int size = rnd.Next(5, 12);
                    gameObjects[i] = new GrBaseObject(new Point(20, i * rnd.Next(1, 25)), new Point(rnd.Next(1, 5) - i, rnd.Next(1, 5) - i), new Size(size, size));
                }
                else if (choice >= 60 && choice <= 90)
                {
                    int size = rnd.Next(10, 20);
                    gameObjects[i] = new GrStar(new Point(20, i * rnd.Next(1, 25)), new Point(rnd.Next(1, 5) - i, rnd.Next(1, 5) - i), new Size(size, size));
                }
                else if (choice > 90)
                {
                    int size = rnd.Next(30, 80);
                    gameObjects[i] = new GrAsteriod(new Point(20, i * rnd.Next(1, 20)), new Point(rnd.Next(1, 15), rnd.Next(1, 15)), new Size(size, size));
                }

            }
        }
        /// <summary>
        /// Метод осуществляет перерисовку игрового пространства
        /// </summary>
        public static void Paint()
        {
            buffer.Graphics.Clear(Color.Black);
            buffer.Graphics.DrawImage(Properties.Resources.cosmos, 0, 0);
            foreach (GrBaseObject obj in gameObjects) obj.Draw();
            buffer.Render();
        }
        /// <summary>
        /// Метод производить обновление позиций объектов игрового пространства
        /// </summary>
        public static void UpdatePosition()
        {
            foreach (GrBaseObject obj in gameObjects)
                obj.Update();
        }

        /// <summary>
        /// Метод, запускающий по событию таймера, запускает методы 
        /// перерисовки и обновление позиций объектов игрового пространства 
        /// </summary>
        private static void Timer_Tick(object sender, EventArgs e)
        {
            Paint();
            UpdatePosition();
        }
    }
}