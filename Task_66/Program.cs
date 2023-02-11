// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// МЕТОДЫ
// Метод по поиску суммы элементов от M до N с рекурсией:
int Recursion(int M, int N)
{
    if (N >= M)
    {
        int res = (N + Recursion(M, N - 1));
        return res;
    }
    return 0;
}

// Метод по вводу числа с клавиатуры:
int InputNumber(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


//=======================================================================================
// ОСНОВНОЙ КОД

// Вариант с заданными числами (как в примере)
// Первый пример (с красивым выводом):
int M = 1;
int N = 15;
int result = Recursion(M, N);
System.Console.WriteLine($"Сумма чисел от {M} до {N} равна: {result}");

// Второй пример (с красивым выводом):
int m = 4;
int n = 8;
int resultSecond = Recursion(m, n);
System.Console.WriteLine($"Сумма чисел от {m} до {n} равна: {resultSecond}");

System.Console.WriteLine("===========================================================");

// Вариант с вводом чисел с клавиатуры:
int startNumber = InputNumber("Введите число M(первое число): ");
int endNumber = InputNumber("Введите число N(второе число): ");
System.Console.WriteLine();

// Вывод суммы чисел с проверкой ввода чисел (числа можно вводить в любом порядке) - вывод в обратную сторону (например, от 8 до 4):
if (endNumber > startNumber)
{
    System.Console.WriteLine($"Сумма чисел от {startNumber} до {endNumber} равна: {Recursion(startNumber, endNumber)}");
}
else
{
    System.Console.WriteLine($"Сумма чисел от {startNumber} до {endNumber} равна: {Recursion(endNumber, startNumber)}");    
}