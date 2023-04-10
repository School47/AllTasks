// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine($"Количество чисел(М), которые вы будете вводить:");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = InputDataInArray(m);
int result = CountNumbers(array, 0);
Console.WriteLine(result);


int[] InputDataInArray(int mNumbers)
{
    int[] arrayForNumbers = new int[mNumbers];
    for (int i = 0; i < mNumbers; i++)
    {
        Console.Write($"Введите {i + 1}-ое число:");
        arrayForNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrayForNumbers;
}

int CountNumbers(int[] arrayForNumbers, int moreThanThisNumber)
{
    int counter = 0;
    for (int i = 0; i < arrayForNumbers.Length; i++)
    {
        if (arrayForNumbers[i] > moreThanThisNumber) counter++;
    }
    return counter;
}