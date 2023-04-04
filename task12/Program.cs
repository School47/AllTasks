// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine($"Введите первое  числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int RemainderDivision(int num1, int num2) // Возвращает остаток от деления
{
    return num1 % num2;
}

void WriteResult(int remainder)
{
    if (remainder == 0)
    {
        Console.WriteLine($"кратно");
    }
    else
    {
        Console.WriteLine($"не кратно, остаток {remainder}");
    }
}



int result = RemainderDivision(number1, number2);
WriteResult(result);
