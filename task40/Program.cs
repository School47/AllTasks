// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine($"Введите первую сторону треугольника:");
int sideOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите вторую сторону треугольника:");
int sideTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите третью сторону треугольника:");
int sideThree = Convert.ToInt32(Console.ReadLine());


bool CheckTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

if (CheckTriangle(sideOne, sideTwo, sideThree)) Console.WriteLine($"Треугольник может существовать:");
else Console.WriteLine($"Треугольник НЕ может существовать:");
