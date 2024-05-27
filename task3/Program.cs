// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    arr[i] = rnd.Next(0, 100);
}

PrintFunktion(arr);
Console.WriteLine("\n");
PrintBackWardFunktion(arr,arr.Length - 1);

void PrintFunktion (int [] array)
{
    if (array.Length > 0)
    {
        Console.Write(array[0] + " ");
        PrintFunktion(array.Skip(1).ToArray());
    }
}

void PrintBackWardFunktion (int [] array, int i)
{   
    if (i>=0)
    {
        Console.Write(array[i] + " ");
        PrintBackWardFunktion(array, i-1);
    }
}