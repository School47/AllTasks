// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите целое положительное число A (основание степени):");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число B (степень):");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB >= 0)
{
    int totalResult = RaiseToDegree(numberA, numberB);
    Console.WriteLine(totalResult);
}
else Console.WriteLine("B должно быть целым неотрицательным!");

int RaiseToDegree(int a, int b)
{
   return (b == 0)? 1: a * RaiseToDegree(a, b - 1);
}
