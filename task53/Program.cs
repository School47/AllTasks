// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

Console.WriteLine("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n, 1, 10);
Console.WriteLine("Исходная матрица:");
PrintArray(resultArray);
EditArray(resultArray);
Console.WriteLine("Конечная матрица:");
PrintArray(resultArray);
// Console.WriteLine("Результат:");

// int result = CountTotalSummInDiagonalFast(resultArray);
// Console.WriteLine(result);


void EditArray (int[,] array)
{  
    int firstRow = 0;
    int lastRow = array.GetLength(0)-1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[firstRow,i];
        array[firstRow,i]=array[lastRow,i];
        array[lastRow,i]=temp;
    }
}

int[,] CreateArrayMatrix(int rows, int colum, int min, int max)
{
    int[,] arr = new int[rows, colum];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i, j],3} ");
            else Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}