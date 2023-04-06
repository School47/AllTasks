// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 1, 33, 6]

int[] array = new int[8];
array = GenerateRandom(array);
PrintArray(array);

int[] GenerateRandom(int[] innerArray)
{
    int ArrayLengnt = innerArray.Length;
    Random rnd = new Random();
    for (int i = 0; i < ArrayLengnt; i++)
    {
        innerArray[i]= rnd.Next(1,100);
    }
    return innerArray;
}

void PrintArray(int[] innerArray)
{
    int ArrayLengnt = innerArray.Length;
    for (int i = 0; i < ArrayLengnt; i++)
    {
        Console.Write($"{innerArray[i]} ");  
    }
}

