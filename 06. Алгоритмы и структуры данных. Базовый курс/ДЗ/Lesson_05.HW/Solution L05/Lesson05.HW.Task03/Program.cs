/* Описание задания:
Ганов Александр Анатольевич
====================
Реализовать очередь:
1. С использованием массива
*/

using System;

using arrType = System.Int32;

namespace Lesson05.HW.Task03
{
    class Program
    {
        static int first = -1, last = -1;
        static readonly int Nmax = 100;
        static readonly arrType[] arrQueue = new arrType[Nmax];

        static void Main()
        {
            int i = 1;
            Enqueue(i++);
            Enqueue(i++);
            Enqueue(i++); // заполняем очередь
            Console.WriteLine(Dequeue());
            Console.WriteLine(Dequeue());
            Console.WriteLine(Dequeue());
            Console.WriteLine(Dequeue(true)); // Пытаемся получить первый элемент
            Enqueue(i++);
            Enqueue(i++);
            Enqueue(i++); // заполняем очередь
            ClearQueue(); // Очищаем очередь
            Dequeue(true); // Пытаемся получить первый элемент

            Console.ReadLine();
        }

        // Методы очереди
        static void Enqueue(arrType i)
        {
            last++;
            arrQueue[last] = i;
            if (first == -1 && last > 0) first++;
        }
        static arrType? Dequeue(bool printQueueEmpty=false)
        {
            arrType defValue = default; // Дефолтное значение для типа стека 
            arrType? res = null; // Возвращаемое значение
            if (IfElementsExists())
            {
                res = arrQueue[first];
                arrQueue[first] = defValue;
                if (first != last) first++;
                else first = last = -1;
            }
            else if(printQueueEmpty) Console.Write("Очередь пустая");
            return res;
        }
        static bool IfElementsExists()
        {
            if (first==-1&&last==-1) return false;
            else return true;
        }
        static void ClearQueue()
        {
            Array.Clear(arrQueue, 0, Nmax);
            first = last = -1;
        }
        }
    }