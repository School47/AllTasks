﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n, 1, 10);
Console.WriteLine("Исходная матрица:");
PrintArray(resultArray);
//
Console.WriteLine();
SumArray(resultArray);



void SumArray(int[,] array)
{
    int index = 0;
    int minsum = 0;
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов - {index + 1} строка. ");
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