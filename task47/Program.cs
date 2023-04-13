// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк таблицы m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы n");
int n = Convert.ToInt32(Console.ReadLine());

double[,] resultArray = CreateArrayMatrix(m, n, 1, 10);
PrintArray(resultArray);
Console.WriteLine();



double[,] CreateArrayMatrix(int rows, int colum, double min, double max)
{
    double[,] arr = new double[rows, colum];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.NextDouble()*(max-min)+min;
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    Console.WriteLine("Итоговая Матрица:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i, j],2), 6}  ");
            else Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }

}