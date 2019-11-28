/* Описание задания:
Ганов Александр Анатольевич
====================
Добавить свои объекты в иерархию объектов, чтобы получился красивый задний фон, похожий на полет в звездном пространстве
* Заменить кружочки картинками, используя метод DrawImage.
 */

using System;
using System.Windows.Forms;

namespace MyGame
{
    class Program
    {
        static void Main()
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 600;
            Application.Run(form);

            Game.Init(form);
            Game.Draw();
      
            Star.Init(form);
            // Star.Draw();
        }
    }
}