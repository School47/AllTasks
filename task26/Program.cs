// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine($"Введите целое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int result = CountDigits(numberA);
Console.WriteLine($"Количество цифр в числе:{result}");

int CountDigits(int inNumber)
{
    int counter = 0;
    while (inNumber!=0)
    {
        counter++;
        inNumber = inNumber / 10;
    }
    return counter;
}
