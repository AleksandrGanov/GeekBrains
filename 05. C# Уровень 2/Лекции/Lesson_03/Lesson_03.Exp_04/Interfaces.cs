using System.Drawing;

namespace Lesson_03.Exp_04
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
