/* Описание задания:
Ганов Александр Анатольевич
====================
Добавить свои объекты в иерархию объектов, чтобы получился красивый задний фон, похожий на полет в звездном пространстве
* Заменить кружочки картинками, используя метод DrawImage.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{
    class Program
    {
        static void Main()
        {
            var form = new GrForm();
            Game.Init(form);
            Application.Run(form);
        }
    }
}