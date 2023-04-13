// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
Console.WriteLine ("Введите количество строк таблицы");
int m = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количество столбцов таблицы");
int n = Convert.ToInt32 (Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n,-10,10);
PrintArray(resultArray);

Console.WriteLine ("Введите индекс строки m нужного элемента");
int mPosition = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите индекс столбца n нужного элемента");
int nPosition = Convert.ToInt32 (Console.ReadLine());

if  (CheckElementInMatrixPosition(mPosition, nPosition)) Console.Write($"Значение элемента =  {resultArray[mPosition, nPosition]} ");
else Console.Write($"Индекс за пределами массива.(такого числа в массиве нет)");


bool CheckElementInMatrixPosition(int mPos, int nPos)
{
    return (mPosition<=m && mPosition>=0 && nPosition<=n&& nPosition>=0);
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

