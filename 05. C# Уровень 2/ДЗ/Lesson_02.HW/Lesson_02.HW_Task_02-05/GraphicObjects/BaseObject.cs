using System.Drawing;

namespace MyGame
{
    /// <summary>
    /// Базовый графический объект
    /// </summary>
    public abstract class BaseObject : ICollision
    {
        /// <summary>
        /// Позиция объекта
        /// </summary>
        protected Point Pos;
        /// <summary>
        /// Направление движения объекта
        /// </summary>
        protected Point Dir;
        /// <summary>
        /// Размер объекта
        /// </summary>
        protected Size Size;
        
        public BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        // Реализация интерфейса ICollision
        /// <summary>
        /// Область столкновения объекта (упрощенное представление в виде прямоугольника)
        /// </summary>
        public Rectangle Rect => new Rectangle(Pos, Size);
        /// <summary>
        /// Определяет факт столкновения объектов
        /// </summary>
        public bool Collision(ICollision o) => o.Rect.IntersectsWith(Rect);

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
