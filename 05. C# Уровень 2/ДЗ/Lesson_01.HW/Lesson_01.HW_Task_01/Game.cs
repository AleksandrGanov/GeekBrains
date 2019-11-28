using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{
    static class Game
    {
        public static BufferedGraphics Buffer;
        public static BufferedGraphicsContext _context;
        public static BaseObject[] _objs;

        public static int Height { get; set; }
        public static int Width { get; set; }

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
        public static void Load()
        {
            Random rnd = new Random();
            _objs = new BaseObject[1000];
            for (int i = 0; i < _objs.Length; i++)
            {
                int choice = rnd.Next(1, 100);

                if (choice < 60)
                {
                    int size = rnd.Next(5, 12);
                    _objs[i] = new BaseObject(new Point(20, i * rnd.Next(1, 25)), new Point(rnd.Next(1, 7) - i, rnd.Next(1, 7) - i), new Size(size, size));
                }
                else if (choice >= 60 && choice <= 90)
                {
                    int size = rnd.Next(10, 20);
                    _objs[i] = new Star(new Point(20, i * rnd.Next(1, 25)), new Point(rnd.Next(5, 15) - i, rnd.Next(1, 7) - i), new Size(size, size));
                }
                else if (choice > 90)
                {
                    int size = rnd.Next(10, 20);
                    _objs[i] = new Image_(new Point(20, i * rnd.Next(1, 20)), new Point(i, i), new Size(size, size));
                }

            }
        }
        public static void Paint()
        {
            Buffer.Graphics.Clear(Color.Black);
            foreach (BaseObject obj in _objs)
            {
                obj.Draw();
            }
            Buffer.Render();
        }
        public static void UpdatePosition()
        {
            foreach (BaseObject obj in _objs)
                obj.Update();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Paint();
            UpdatePosition();
        }
    }
}