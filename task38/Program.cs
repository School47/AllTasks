// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 1)}; ");
        else Console.Write($"{Math.Round(arr[i], 1)}");
    }
    Console.Write("]");
}

double FindMinInArray(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}
double FindMaxInArray(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double FindDifferenceMaxMin(double max, double min)
{
    return max-min;
}

double[] array = CreateArrayRndDouble(5, 1, 99);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
double MaxResult = FindMaxInArray(array);
double MinResult = FindMinInArray(array);
Console.WriteLine($"Max: {Math.Round(MaxResult,1)}");
Console.WriteLine($"Min: {Math.Round(MinResult,1)}");
double result = FindDifferenceMaxMin(MaxResult,MinResult);
Console.WriteLine($"Разница между максимальным и минимальынм элементом: {Math.Round(result,1)}");