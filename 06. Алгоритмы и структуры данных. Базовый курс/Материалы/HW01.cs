//
//  VladislavIsaev_HomeWork_01.c
//  VladislavIsaev_HomeWork_01
//
//  Created by Vladislav Isaev on 10.02.2018.
//  Copyright © 2018 visaev. All rights reserved.
//

#include <stdio.h>
#include <math.h>
#include <stdlib.h> // для RAND_MAX

/*
 Алгоритмы и структуры данных. Домашнее задание к уроку 09.02.2018.
 Исаев Владислав Игоревич
 */

void my_mainMenu() {
    printf("________________\n");
    printf("Введите номер задания или введите \"0\" для выхода\n");
    printf("1 - Индекс массы тела\n");
    printf("2 - Максимум из четырех чисел\n");
    printf("3 - Обмен значений двух чисел\n");
    printf("4 - Корни квадратного уравнения\n");
    printf("5 - Время года по месяцу\n");
    printf("6 - Корректный вывод год/года/лет\n");
    printf("7 - Две точки шахматной доски, одного цвета?\n");
    printf("8 - Два числа. Квадрат и куб.\n");
    printf("9 - Частное и остаток от N/K\n");
    printf("10 - Нечетные числа в записи числа\n");
    printf("11 - Среднее арифметическое оканчивающихся на ноль положительных чисел\n");
    printf("12 - Максимум из трех чисел\n");
    printf("13 - Случайное число в промежутке [1;100]\n");
    printf("14 - Нахождение автоморфных чисел от 0 до N\n");
    printf("Введите ниже:\n");
}

// 1 Задача

void task1() {
    printf("1. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах.\n");
    float weight, growth = 0.0;
    printf("Введите массу в кг:\n");
    scanf("%f", &weight);
    printf("Введите рост в м:\n");
    scanf("%f", &growth);
    float index = weight/pow(growth, 2);
    printf("Масса: %.2f \nРост: %.2f \nИндекс: %0.2f \n", weight, growth, index);
}

// 2 Задача

int maxval(int a, int b) {
    if (a>b) {
        return a;
    } else {
        return b;
    }
}

void task2() {
    printf("2. Найти максимальное из четырех чисел. Массивы не использовать.\n");
    int a, b, c, d = 0;
    printf("Введите четыре числа, каждое с новой строчки\n");
    scanf("%i \n %i \n %i \n %i", &a, &b, &c, &d);
    int max = maxval(maxval(maxval(a, b), c), d);
    printf("Максимальное число %d \n", max);
}

// 3 Задача

void task3() {
    printf("3. Написать программу обмена значениями двух целочисленных переменных:\na. с использованием третьей переменной;\nb.*без использования третьей переменной.\n");
    int a, b = 0;
    printf("Введите два числа, каждое с новой строчки\n");
    scanf("%i \n %i", &a, &b);
//    int c = a;
//    a = b;
//    b = c;
    a = a ^ b;
    b = b ^ a;
    a = a ^ b;
    printf("Результат:\na=%d b=%d\n", a, b);
}

// 4 Задача

void task4() {
    printf("4. Написать программу нахождения корней заданного квадратного уравнения.\n");
    double a, b, c = 0;
    double x1, x2 = 0.0;
    printf("Введите коэффициенты уравнения, каждое с новой строчки\n");
    scanf("%lf \n %lf \n %lf", &a, &b, &c);
    double disk = (b * b) - (4 * a * c);
    if (disk) {
        double d = sqrt(disk);
        x1 = (d - b) / (2 * a);
        x2 = (-d - b) / (2 * a);
        if (x1 == x2) {
            printf ("x=%4.2f\n",x1);
        } else {
            printf ("x1 = %.2f x2 = %.2f\n", x1, x2);
        }
    } else {
        printf ("Уравнение не имеет корней\n");
    }
}

// 5 Задача

void task5() {
    printf("5. С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.\n");
    int a;
    printf("Введите номер месяца\n");
    scanf("%d", &a);
    if (a > 0 && a <= 12) 
	{
       (a <= 2 || a == 12)
		? printf("Зима\n") : (a <= 5)
		? printf("Весна\n") : (a <= 8)
		? printf("Лето\n") : printf("Осень\n");
    } else 
	{
        printf("В году 12 месяцев\n");
    }
}

// 6 Задача

void task6() {
    printf("6. Ввести возраст человека (от 1 до 150 лет) и вывести его вместе с последующим словом «год», «года» или «лет».\n");
    int a;
    printf("Введите кол-во лет\n");
    scanf("%d", &a);
    if (a > 0) {
        int c = a%100;
        if (c > 20) {
            c = a%10;
            (c == 0)? printf("%d лет\n", a) : (c == 1)? printf("%d год\n", a) : (c <= 4)? printf("%d года\n", a) : printf("%d лет\n", a);
        } else if (c >= 5) {
            printf("%d лет\n", a);
        } else {
            (a == 1)? printf("%d год\n", a) : printf("%d года\n", a);
        }
    } else {
        printf("Некорректные данные\n");
    }
}

// 7 Задача

struct point {
    int x;
    int y;
};

void task7() {
    printf("7. С клавиатуры вводятся числовые координаты двух полей шахматной доски (x1,y1,x2,y2). Требуется определить, относятся ли к поля к одному цвету или нет.\n");
    struct point p1;
    struct point p2;
    printf("Введите координаты точек, каждая координата и точка с новой строки\n");
    scanf("%d \n %d \n %d \n %d", &p1.x, &p1.y, &p2.x, &p2.y);
    if ((((p1.x > 0) && (p1.y > 0)) && ((p2.x > 0)&&(p2.y > 0))) && (((p1.x <= 8) && (p1.y <= 8)) && ((p2.x <= 8) && (p2.y <= 8)))) {
        if (((p1.x + p1.y) % 2) == ((p2.x + p2.y) % 2)) {
            printf("Да, одного цвета %d \n",(p1.x+p2.y)%2);
        } else {
            printf("Нет, разного цвета\n");
        }
    } else {
        printf("Некорректные данные\n");
    }
}

// 8 Задача

void task8() {
    printf("8. Ввести a и b и вывести квадраты и кубы чисел от a до b.\n");
    double a, b;
    printf("Введите числа, каждое с новой строки\n");
    scanf("%lf \n %lf", &a, &b);
    printf("a^2 %.2lf \nb^2 %.2lf \na^3 %.2lf \nb^3 %.2lf \n", pow(a, 2), pow(b, 2), pow(a, 3), pow(b, 3));
}

// 9 Задача

void task9() {
    printf("9. Даны целые положительные числа N и K. Используя только операции сложения и вычитания, найти частное от деления нацело N на K, а также остаток от этого деления.\n");
    int n, k;
    printf("Введите числа N и K, каждое с новой строки\n");
    scanf("%d \n %d", &n, &k);
    int c = 0;
    while (n >= k) {
        c = c + 1;
        n = n - k;
    }
    printf("Частное = %d\nОстаток = %d \n", c, n);
}

// 10 Задача

void task10() {
    printf("10. Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления определить, имеются ли в записи числа N нечетные цифры. Если имеются, то вывести True, если нет — вывести False.\n");
    int n;
    printf("Введите число n\n");
    scanf("%d", &n);
    while((n > 0) & ((n % 10) % 2 == 0 )) {
        n /= 10;
    }
    printf("%s\n", (n > 0)? "True\n" : "False\n");
}

// 11 Задача

void task11() {
    printf("11. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее арифметическое всех положительных четных чисел, оканчивающихся на 8.\n");
    int a = 0;
    int count = 0;
    double as = 0;
    printf("Каждое новое число вводите с новой строки\n");
    do {
        scanf("%d", &a);
        if (a > 0) {
            int c = 100;
            while (c > 10) {
                c = a % 10;
            }
            if (c == 8) {
                count = count + 1;
                as = as + a;
            }
        }
    } while (a != 0);
    printf("Реузльтат: %.2f \n", as/count);
}

// 12 Задача

int max3(int a, int b, int c) {
    return maxval(maxval(a, b), c);
}

void task12() {
    printf("12. Написать функцию нахождения максимального из трех чисел.\n");
    int a, b, c = 0;
    printf("Введите три числа, каждое с новой строчки\n");
    scanf("%i \n %i \n %i", &a, &b, &c);
    int max = max3(a, b, c); // Вызов написанной фукнции
    printf("Максимальное число %d \n", max);
}

// 13 Задача

unsigned long next = 1;

int my_rand() {
    next = next * 1103515245 + 12345;
    return ((unsigned int)(next / 65536) % RAND_MAX);
}

void task13() {
    printf("13. * Написать функцию, генерирующую случайное число от 1 до 100. \n а) с использованием стандартной функции rand() \n б) без использования стандартной функции rand()\n");
    for (int i=1; i<101; i++) {
        printf("%d\t", my_rand()%101);
        if ((i%10) == 0) {
            printf("\n");
        }
    }
    printf("\n");
}

// 14 Задача

void task14() {
    printf("14. *Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата. Например, 25^2 = 625. Напишите программу, которая вводит натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.\n");
    int n;
    printf("Введите N\n");
    scanf("%d", &n);
    while (n > 0) {
        if ((floor(sqrt(n))) == sqrt(n)) {
            int s = sqrt(n);
            int p = 1;
            while (p <= s) {
                p = p * 10;
            }
            if ((n%p) == s) {
                printf("%d^2 = %d \n", s, n);
            }
        }
        n = n - 1;
    }
}

int main(int argc, const char * argv[]) {
    // insert code here...
    printf("Добро пожаловать!\n");
    int task = 0;
    int count = 0;
    do {
        my_mainMenu();
        scanf("%d", &task);
        switch (task) {
            case 1:
                printf("\nЗдача №%i \n", task);
                task1();
                break;
            case 2:
                printf("\nЗдача №%i \n", task);
                task2();
                break;
            case 3:
                printf("\nЗдача №%i \n", task);
                task3();
                break;
            case 4:
                printf("\nЗдача №%i \n", task);
                task4();
                break;
            case 5:
                printf("\nЗдача №%i \n", task);
                task5();
                break;
            case 6:
                printf("\nЗдача №%i \n", task);
                task6();
                break;
            case 7:
                printf("\nЗдача №%i \n", task);
                task7();
                break;
            case 8:
                printf("\nЗдача №%i \n", task);
                task8();
                break;
            case 9:
                printf("\nЗдача №%i \n", task);
                task9();
                break;
            case 10:
                printf("\nЗдача №%i \n", task);
                task10();
                break;
            case 11:
                printf("\nЗдача №%i \n", task);
                task11();
                break;
            case 12:
                printf("\nЗдача №%i \n", task);
                task12();
                break;
            case 13:
                printf("\nЗдача №%i \n", task);
                task13();
                break;
            case 14:
                printf("\nЗдача №%i \n", task);
                task14();
                break;
            default:
                printf("\nВведен некорректный индекс\n");
                break;
        }
        count = count + 1;
    } while ((task != 0) && (count < 5));
    
    printf("Всего доброго!\n");
    
    return 0;
}


