// Диспетчер очереди сообщений Windows

using System.Windows.Forms;

class TwoForms
{
    public static void Main()
    {
        Form form1 = new Form();
        Form form2 = new Form();
        form1.Text = "Эта форма запущена с использованием метода Run класса Application";
        form2.Text = "Это форма для демонстрации возможности создавать несколько форм";
        form2.Show();
        Application.Run(form1);
        MessageBox.Show("Application.Run() вернул " +
        "управление в метод Main. До свидания", "Приложение \"Две формы\"");
    }
}