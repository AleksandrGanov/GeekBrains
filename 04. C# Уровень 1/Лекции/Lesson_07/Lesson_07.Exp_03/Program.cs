// Пример использования класса Forms

using System.Threading;// Для создания паузы перед закрытием приложения
using System.Windows.Forms;

class ShowForm
{
    public static void Main()
    {
        Form form = new Form();
        form.Text = "Это простое графическое окно";
        form.Width = 500;
        Application.Run(form);
    }
}