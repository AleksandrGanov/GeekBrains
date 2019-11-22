// Сериализация массива, коллекции

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerializer_List
{
    [Serializable]
    public class Student
    {
        public string firstName;
        public string lastName;
        int age;

        public int Age
        {
            get { return age; }
            set { if (value > 0) age = value; }
        }

        public Student()
        {
        }
        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }
    
    class Program
    {
        static void SaveAsXmlFormat(List<Student> obj, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, obj);
            fStream.Close();
        }
        static void LoadFromXmlFormat(ref List<Student> obj, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            obj = (List<Student>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
            {
                new Student("Иван", "Иванов", 20),
                new Student("Петр", "Петров", 21)
            };
            SaveAsXmlFormat(list, "data.xml");
            LoadFromXmlFormat(ref list, "data.xml");
            foreach (var v in list)
            {
                Console.WriteLine("{0} {1} {2}", v.firstName, v.lastName, v.Age);
            }
            Console.ReadKey();
        }
    }
}