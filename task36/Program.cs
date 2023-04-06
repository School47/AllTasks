// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CountNumbersInOddPositions(int[] arr)
{
    int Summ = 0;
    for (int i = 0; i < arr.Length; i=i+2)
    {
        Summ+=arr[i];
    }
    return Summ;
}

int[] array = CreateArrayRndInt(5, 1, 99);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {CountNumbersInOddPositions(array)}");