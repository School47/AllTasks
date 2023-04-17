// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите n, чтобы создать массив n*n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n];
FillArray(array);
PrintArray(array);


void FillArray(int[,] arr)
{
    int currentValue = 1;
    int currentRow = 0;
    int currentCol = 0;

    while (currentValue <= n * n)
    {
        // заполнение верхней строки слева направо
        for (int i = currentCol; i < n - currentCol; i++)
        {
            arr[currentRow, i] = currentValue++;
        }

        // заполнение правого столбца сверху вниз
        for (int i = currentRow + 1; i < n - currentRow; i++)
        {
            arr[i, n - currentCol - 1] = currentValue++;
        }

        // заполнение нижней строки справа налево
        for (int i = n - currentCol - 2; i >= currentCol; i--)
        {
            arr[n - currentRow - 1, i] = currentValue++;
        }

        // заполнение левого столбца снизу вверх
        for (int i = n - currentRow - 2; i > currentRow; i--)
        {
            arr[i, currentCol] = currentValue++;
        }

        currentRow++;
        currentCol++;
    }
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0,3} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}