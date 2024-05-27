/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 2 натуральных числа");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        if (m > n)
        {
            int temp = m;
            m = n;
            n = temp;
        }

        Console.WriteLine("Числа в промежутке от " + m + " до " + n + ":");
        PrintFunktion(m, n);
    }

    static void PrintFunktion(int m, int n)
    {
        if (m < n)
        {
            Console.Write($"{m}, ");
            PrintFunktion(m + 1, n);
        }
        else if (m == n)
        {
            Console.Write(m);
        }
    }
}
