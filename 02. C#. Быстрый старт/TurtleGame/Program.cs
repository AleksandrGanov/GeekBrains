using System;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    class Program
    {
        static void Main()
        {
            string s;

            TextWindow.Show();

            // запрашиваем размер еды и проверяем на допустимость
            do
            {
                TextWindow.WriteLine("Введите размер еды от 10 до 50px");
                s = TextWindow.Read();
            } while (!((int.TryParse(s, out int i)) && int.Parse(s) >= 10 && int.Parse(s) <= 50));

            TextWindow.Hide();

            int eatSize = int.Parse(s);

            Turtle.Speed = 4;
            Turtle.PenUp();

            GraphicsWindow.CanResize = false;
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(eatSize, eatSize);
            int x = 200;
            int y = 200;
            Shapes.Move(eat, x, y);

            Random rand = new Random();

            GraphicsWindow.Title = "Погнали!";
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;

            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X >= x && Turtle.X <= x + eatSize && Turtle.Y >= y && Turtle.Y <= y + eatSize)
                {

                    if (Turtle.Speed < 9)
                    { Turtle.Speed++; }
                    if (Turtle.Speed < 9)
                    {
                        GraphicsWindow.Title = "Переключились на скорость: " + (Turtle.Speed - 3);
                    }
                    else if (Turtle.Speed == 9 && GraphicsWindow.BrushColor != "Yellow")
                    {
                        GraphicsWindow.Title = "Вышли на максимальную скорость!";
                        GraphicsWindow.BackgroundColor = "Red";
                        GraphicsWindow.BrushColor = "Yellow";
                        Shapes.Remove(eat);
                        eat = Shapes.AddRectangle(eatSize, eatSize);
                    }

                    x = rand.Next(eatSize, GraphicsWindow.Width - eatSize);
                    y = rand.Next(eatSize, GraphicsWindow.Height - eatSize);
                    Shapes.Move(eat, x, y);
                }
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
