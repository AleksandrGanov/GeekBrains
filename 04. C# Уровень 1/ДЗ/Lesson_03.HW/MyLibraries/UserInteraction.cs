using System;

/// <summary>
/// 
/// </summary>
namespace UserInteraction
{
    public struct ConsoleInteraction
    {
        /// <summary>
        /// Реализует выдачу ответа "Да/Нет" на запрос пользователя
        /// </summary>
        /// <param name="question">Вопросы, выводимый пользователю</param>
        /// <returns>булево True/False</returns>
        public bool AnsYesNo(string question)
        {
            string ans;
            ans = AskUser(question).ToLower();
            while (!(ans == "y" || ans == "n"))
            {
                ans = AskUser("Введите \"y\" или \"n\", другие ответы не допускаются").ToLower();
            }
            if (ans == "y") return true; else return false;
        }
        /// <summary>
        /// Вывод запроса пользователю через консоль и возврат результата ввода
        /// </summary>
        /// <param name="str">вопрос пользователю</param>
        /// <returns>ответ пользователя</returns>
        public string AskUser(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }
        public int GetDenominator(string str)
        {
            int den;
            do
            {
                den = GetValueInt(str);
                try
                {
                    if (den == 0) throw new Exception($"Знаменатель не может быть равен нулю, введите другое число");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } while (den == 0);
            return den;
        }
        /// <summary>
        /// Запрос значения "Int" через консоль с проверкой на тип значения
        /// </summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        public int GetValueInt(string msg)
        {
            int x; bool flag;
            do
            {
                Console.Write(msg);
                flag = int.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);  //  Пока false(!false=true), повторять цикл
            return x;
        }
        /// <summary>
        /// Запрос значения "Double" через консоль с проверкой на тип значения
        /// </summary>
        /// <param name="msg">Сообщение, выдаваемое пользователю</param>
        /// <returns>Введенное в консоль значение</returns>
        public double GetValueDouble(string msg)
        {
            double x; bool flag;
            do
            {
                Console.Write(msg);
                flag = double.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);  //  Пока false(!false=true), повторять цикл
            return x;
        }
    }
}