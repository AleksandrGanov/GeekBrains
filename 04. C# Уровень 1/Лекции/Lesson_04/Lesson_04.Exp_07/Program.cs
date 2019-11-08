// Индексируемые свойства (индексаторы)

namespace Lesson_04.Exp_07
{
    namespace IndexerSample
    {
        class MyArray
        {
            int[] a;  // он приватный
            public MyArray(int n)
            {
                a = new int[n];
            }
            // либо мы делаем метод для получения элемента массива
            public int Get(int i)
            {
                return a[i];
            }
            // и метод для того, чтобы задать элемент
            public void Set(int i, int value)
            {
                a[i] = value;
            }
            // либо создаем индексируемое свойство
            public int this[int i]
            {
                get { return a[i]; }
                set { a[i] = value; }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                MyArray array = new MyArray(10);
                for (int i = 0; i < 10; i++)
                    // Для доступа можно использовать либо метод
                    array.Set(i, i * 10);
                for (int i = 0; i < 10; i++)
                    // Или индексируемое свойство, что более удобно
                    array[i] = i * 10;
            }
        }
    }
}
