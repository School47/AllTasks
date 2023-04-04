// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int numberRandom = new Random().Next(100, 1000);

int DelSecondDigit(int numRandom)
{
    int firstDigit = numRandom / 100;
    int thirdNumber = numRandom % 10;
    int result = firstDigit * 10 + thirdNumber;
    return result;
}

Console.WriteLine($"Трехзначное число: {numberRandom}");
Console.WriteLine($"Удалили вторую цифру числа: { DelSecondDigit(numberRandom)}");