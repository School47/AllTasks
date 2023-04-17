// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

Console.WriteLine("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n, 1, 10);
Console.WriteLine("Исходная матрица:");
PrintArray(resultArray);
int[] coordinates = FindMinElementOfArray(resultArray);
// Console.WriteLine($"i={coordinates[0]}, j={coordinates[1]}");
Console.WriteLine("Конечная матрица:");
PrintWithRemovedRowAndCollumn(resultArray);

void PrintWithRemovedRowAndCollumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != coordinates[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != coordinates[1])
                    if (i < array.Length - 1) Console.Write($"{array[i, j],3} ");
                    else Console.Write($"{array[i, j]}");
            }
        Console.WriteLine();
        }
    }
}



int[] FindMinElementOfArray(int[,] array)
{
    int minElement = array[0, 0];
    int minPosi = 0;
    int minPosj = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minElement > array[i, j])
            {
                minElement = array[i, j];
                minPosi = i;
                minPosj = j;
            }
        }

    }
    // Console.WriteLine($"i={minPosi}, j={minPosj}");
    return new int[] { minPosi, minPosj };
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