// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine($"Введите целое положительное число А:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите целое положительное число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB>0)
{
    int Totalresult = StepenChisla(numberA, numberB);
    Console.WriteLine($"Результат = {Totalresult}");
}
else
{
    Console.WriteLine($"Число B={numberB} не является натуральным.");
}


int StepenChisla(int num, int stepen)
{
    int result = num;
    for (int i = 2; i <= stepen; i++)
    {
        result = result * num;
    }
    return result;
}
