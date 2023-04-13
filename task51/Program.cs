// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n, 1, 10);
PrintArray(resultArray);
Console.WriteLine("Результат:");

int result = CountTotalSummInDiagonalFast(resultArray);
Console.WriteLine(result);



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

int CountTotalSummInDiagonalFast(int[,] arr)
{
    int totalSumm = 0;

    for (int j = 0; j < arr.GetLength(0) && j < arr.GetLength(1); j++)
    {
        totalSumm += arr[j, j];
    }

    return totalSumm;
}