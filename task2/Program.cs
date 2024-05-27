/* Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. */

Console.WriteLine("Введите 2 натуральных числа");

int m = int.Parse(Console.ReadLine());

int n = int.Parse(Console.ReadLine());

Console.WriteLine("Функция Аккермана: " + akkerman(m, n));

int akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return akkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return akkerman(m - 1, akkerman(m, n - 1));
    }
    else
    {
        return 0;
    }
}