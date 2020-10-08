using System.Drawing;

namespace MyGame
{
    /// <summary>
    /// Реализует механимз определения столкновений объектов
    /// </summary>
    public interface ICollision
    {
        bool Collision(ICollision obj);
        Rectangle Rect { get; }
    }
}