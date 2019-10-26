using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdviser
{
    class Program
    {
        static void Main()
        {

            Int32 alc;

            Console.WriteLine("Введите Ваше имя");
            String name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);

            Console.WriteLine("Фильм какого жанра Вы хотели посмотреть: комедия, драма, фантастика");
            string genre = Console.ReadLine();
            Console.WriteLine("В таком случае рекомендуем посмотреть:");
            if (genre == "комедия")
            {
                Console.WriteLine("* Иван Васильевич меняет профессию");
                Console.WriteLine("* Операция \"Ы\" и другие приключения Шурика");
                Console.WriteLine("* Назад в будущее");
                Console.WriteLine("* В джазе только девушки");
            }
            else if (genre == "фантастика")
            {
                Console.WriteLine("* Люди икс");
                Console.WriteLine("* Черепашки ниндзя");
            }
            else
            {
                Console.WriteLine("* Зеленая миля");
                Console.WriteLine("* Побег из Шоушенка");
            }

            Console.ReadLine();
        }
    }
}
