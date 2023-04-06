// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine($"Введите целое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int result = CountSummDigits(numberA);
Console.WriteLine($"Сумма цифр в числе:{result}");

int CountSummDigits(int inNumber)
{
    int SummDigits = 0;
    while (inNumber!=0)
    {
        SummDigits +=inNumber % 10;
        inNumber = inNumber / 10;
    }
    return SummDigits;
}
