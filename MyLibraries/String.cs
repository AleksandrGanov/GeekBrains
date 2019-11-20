// Some Methods to work with Strings

namespace mlString
{
    public struct CheckValues
    {
        /// <summary>
        /// Метод проверяет строку на содержание в ней цифр
        /// </summary>
        /// <param name="str">Проверяемая строка</param>
        /// <returns>Булево</returns>
        public static bool ContainsDigits(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i])) return true;
            }
            return false;
        }
    }
}