// Коллекции. Пример использования обобщенных (Generic) коллекций

using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string lastName;
    public string firstName;
    public string university;
    public string faculty;
    public int course;
    public string department;
    public int group;
    public string city;
    int age;

    public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.university = university;
        this.faculty = faculty;
        this.department = department;
        this.course = course;
        this.age = age;
        this.group = group;
        this.city = city;
    }
}
class Program
{
    static int Compare(Student st1, Student st2)
    {
        return String.Compare(st1.firstName, st2.firstName);
    }

    static void Main(string[] args)
    {
        int bakalavr = 0;
        int magistr = 0;
        List<Student> list = new List<Student>();
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("students.csv");
        
        sr.ReadLine();
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                if (int.Parse(s[5]) < 5) bakalavr++; else magistr++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            }
        }
        sr.Close();

        list.Sort(new Comparison<Student>(Compare));
        Console.WriteLine("Всего студентов:" + list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalavr);
        foreach (var v in list) Console.WriteLine($"{v.lastName} {v.firstName}");
        
        Console.WriteLine($"{(DateTime.Now - dt).TotalSeconds:F2} сек.".Replace(',', '.'));
        Console.ReadLine();
    }
}