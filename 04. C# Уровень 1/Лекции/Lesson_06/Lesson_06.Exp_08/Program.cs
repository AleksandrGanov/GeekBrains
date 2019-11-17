// Коллекции. Пример использования колллекций №1

using System;
using System.Collections;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int bakalavr = 0;
        int magistr = 0;
        ArrayList list = new ArrayList();
        
        // Запомним время в начале обработки данных
        DateTime dt = DateTime.Now;
        
        StreamReader sr = new StreamReader("students_1.csv");
        sr.ReadLine();
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                list.Add($"{s[1]} {s[0]}");// Добавляем склееные имя и фамилию
                if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
            }
            catch
            {
            }
        }
        sr.Close();
        list.Sort();

        Console.WriteLine("Всего студентов:{0}", list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalavr);
        foreach (var v in list) Console.WriteLine(v);

        Console.WriteLine($"{(DateTime.Now - dt).TotalSeconds:F2} сек.".Replace(',','.')) ;
        Console.ReadLine();
    }
}