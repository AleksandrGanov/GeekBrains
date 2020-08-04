using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            g.SmoothingMode = SmoothingMode.HighQuality;
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));
            
            Load();
            var timer = new Timer { Interval = 150 };
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
                    _objs[i] = new BaseObject(new Point(20, i * rnd.Next(1, 25)), new Point(rnd.Next(1, 5) - i, rnd.Next(1, 5) - i), new Size(size, size));
                }
                else if (choice >= 60 && choice <= 90)
                {
                    int size = rnd.Next(10, 20);
                    _objs[i] = new Star(new Point(20, i * rnd.Next(1, 25)), new Point(rnd.Next(1, 5) - i, rnd.Next(1, 5) - i), new Size(size, size));
                }
                else if (choice > 90)
                {
                    int size = rnd.Next(30, 80);
                    _objs[i] = new Image_(new Point(20, i * rnd.Next(1, 20)), new Point(rnd.Next(1, 15), rnd.Next(1, 15)), new Size(size, size));
                }

            }
        }
        public static void Paint()
        {
            Buffer.Graphics.Clear(Color.Black);
            //Buffer.Graphics.DrawImage(Image.FromFile("cosmos.jpg"), 0, 0);
            Buffer.Graphics.DrawImage(Properties.Resources.cosmos, 0, 0);
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