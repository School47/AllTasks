Console.WriteLine ("Введите количество строк таблицы");
int m = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количество столбцов таблицы");
int n = Convert.ToInt32 (Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n);
PrintArray(resultArray);
Console.WriteLine();

int[,] CreateArrayMatrix(int rows, int colum)
{
    int[,] arr = new int[rows, colum];
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i+j;
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