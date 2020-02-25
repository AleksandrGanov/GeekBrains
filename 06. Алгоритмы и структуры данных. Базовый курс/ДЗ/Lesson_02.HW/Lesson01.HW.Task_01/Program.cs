/* Описание задания:
Ганов Александр Анатольевич
====================
Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах
 */

using System;

using static mlConsole.GetData;

namespace Lesson01.HW.Task01
{
    class Program
    {
        static void Main()
        {
            uint rost = GetValueUInt("Введите рост, см: ");
            uint massa = GetValueUInt("Введите массу тела, кг: ");
            Console.WriteLine($"Ваш ИМТ: {massa / Math.Pow(rost / 100d, 2):F0}");
            Console.ReadLine();
        }
    }
}