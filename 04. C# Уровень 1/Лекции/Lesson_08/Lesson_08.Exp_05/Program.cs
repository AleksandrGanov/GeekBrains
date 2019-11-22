// Windows Forms-приложение — редактор вопросов для игры «Верю — не верю»

using System;
using System.Windows.Forms;

namespace Lesson_08.Exp_05
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            BelieveOrNotBelieve inintForm = new BelieveOrNotBelieve();
            Application.Run(inintForm);
        }
    }
}
