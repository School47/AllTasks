// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое положительное число N:");
int number = Convert.ToInt32(Console.ReadLine());
int totalResult = SummOfDigitsOfNumber(number);
Console.WriteLine(totalResult);

int SummOfDigitsOfNumber(int num)
{
    return (num == 0)? 0 : num % 10 + SummOfDigitsOfNumber(num / 10);
}