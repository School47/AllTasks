// АБ
// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine($"Введите число для деления:");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;


bool result = IsMultiple2Div(number,number1,number2);
Console.WriteLine(result? $"да": $"нет");

bool IsMultiple2Div(int number, int num1, int  num2) // Возвращает true, если number кратен num1 и num2
{
   return (number%num1==0)&&(number%num2==0);
}

 