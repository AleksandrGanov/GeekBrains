using System.Drawing;

namespace Lesson_03.Exp_04
{
    public abstract class BaseObject : ICollision
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;

        public Rectangle Rect => new Rectangle(Pos, Size);
        public bool Collision(ICollision o) => o.Rect.IntersectsWith(Rect);

        public BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        /// <summary>
        /// Метод рисует базовый объект в виде окружности
        /// </summary>
        public abstract void Draw();

        /// <summary>
        /// Метод производит смещение позиции базового объекта 
        /// </summary>
        public abstract void Update();
    }
}
