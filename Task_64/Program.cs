// /Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// МЕТОДЫ
//Метод вывода всех чисел от N до 1:
int GapOutput(int N)
{
    if (N > 1)
    {
        System.Console.Write($"{N} ");
        return GapOutput(N - 1);
    }
    return 1;
}

//=======================================================================================
// ОСНОВНОЙ КОД

// Красивый вывод:
System.Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

System.Console.Write($"Все числа от {N} до 1: ");
System.Console.WriteLine(GapOutput(N));