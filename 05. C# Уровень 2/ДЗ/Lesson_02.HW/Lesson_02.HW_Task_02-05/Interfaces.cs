using System.Drawing;

namespace MyGame
{
    /// <summary>
    /// Данный интерфейс используется для определения столкновений объектов
    /// </summary>
    public interface ICollision
    {
        bool Collision(ICollision obj);
        Rectangle Rect { get; }
    }
}
