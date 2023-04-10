// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101110
// 3 -> 11
// 2 -> 10

Console.WriteLine($"Введите десятичное число:");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string DecToBin(int dec)
{
    string temp = string.Empty;
    while (dec > 0)
    {
        temp = dec % 2 + temp;
        dec = dec / 2;
    }
    int bin = 0;
    return temp;
}
int DecToBinWithInt(int dec)
{
    int result = 0;
    int multiplier = 1;
    while (dec > 0)
    {
        result = result + (dec % 2) * multiplier;
        dec = dec / 2;
        multiplier *= 10;
    }
    return result;
}

string finalResult = DecToBin(decimalNumber);
Console.WriteLine(finalResult);

int FinalresultInt = DecToBinWithInt(decimalNumber);
Console.WriteLine(FinalresultInt);