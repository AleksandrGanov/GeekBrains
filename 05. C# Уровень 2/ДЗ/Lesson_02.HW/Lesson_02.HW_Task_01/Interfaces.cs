using System.Drawing;

namespace MyGame
{
    /// <summary>
    /// Данный интерфейс используется для определения столкновений объектов
    /// </summary>
    interface ICollision
    {
        bool Collision(ICollision obj);
        Rectangle Rect { get; }
    }
}
