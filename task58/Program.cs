// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задаем исходные матрицы
int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };

// Выводим исходные матрицы на экран
Console.WriteLine("Матрица 1:");
PrintArray(matrix1);

Console.WriteLine("Матрица 2:");
PrintArray(matrix2);

// Вычисляем произведение матриц
if (IsItPossibleToMultiplyMatrices(matrix1, matrix2))
{
    int[,] result = MultiplyMatrices(matrix1, matrix2);

    // Выводим результирующую матрицу на экран
    Console.WriteLine("Результирующая матрица:");
    PrintArray(result);
}
else
    Console.WriteLine("Невозможно перемножить матрицы. Количество столбцов первой матрицы не равно количеству строк второй матрицы.");

// Метод для вывода матрицы на экран
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

bool IsItPossibleToMultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows2 = matrix2.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    return (columns1 == rows2);
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);



    int[,] result = new int[rows1, columns2];

    // Умножаем каждый элемент первой матрицы на каждый элемент второй матрицы
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int k = 0; k < columns1; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}


