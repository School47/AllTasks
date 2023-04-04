// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
array = GenerateRandom(array);
PrintArray(array);

int[] GenerateRandom(int[] innerArray)
{
    int ArrayLengnt = innerArray.Length;
    Random rnd = new Random();
    for (int i = 0; i < ArrayLengnt; i++)
    {
        innerArray[i]= rnd.Next(0,2);
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

