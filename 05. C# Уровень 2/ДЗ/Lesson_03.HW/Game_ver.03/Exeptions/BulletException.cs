using System;

namespace MyGame
{
    /// <summary>
    ///  Ошибка создания пули, возникает при превышении размеров пули
    /// </summary>
    class BulletException : ArgumentException
    {
        public BulletException(string message) : base(message) { }
    }
}
