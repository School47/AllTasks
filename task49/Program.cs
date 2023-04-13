// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

Console.WriteLine ("Введите количество строк таблицы");
int m = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количество столбцов таблицы");
int n = Convert.ToInt32 (Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n,-10,10);
PrintArray(resultArray);
Console.WriteLine("Модифицированная матрица:");

ReplaceToSquares(resultArray);
PrintArray(resultArray);



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

void ReplaceToSquares(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i=i+2)
    {
        for (int j = 0; j < arr.GetLength(1); j=j+2)
        {
            arr[i,j]*=arr[i,j];
        }
    }

}