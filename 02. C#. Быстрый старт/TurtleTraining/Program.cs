using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void Main()
        {
            Turtle.Speed = 9;
            Turtle.X = 200;
            Turtle.Y = 200;
            
            
            int i = 0;

            while (i<4)
            {
                Turtle.Move(100);
                Turtle.TurnRight();
                i++;
            }

            i = 0;
            Turtle.Turn(90);
            Turtle.Move(100);

            while (i < 4)
            {
                Turtle.Move(20);
                Turtle.TurnLeft();
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnRight();
                Turtle.Move(20);
                Turtle.TurnLeft();
                i++;
            }

            i = 0;
            Turtle.Turn(-60);
            Turtle.Move(50);

            while (i < 5)
            {
                Turtle.Turn(60);
                Turtle.Move(50);
                i++;
            }

        }
    }
}
