// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double b1;
double k1;
double b2;
double k2;
double x;
double y;
InputData();
x = CalculateX(b1, k1, b2, k2);
y = CalculateY(x, k1, b1);
Console.WriteLine($"{x}, {y}");

void InputData()
{
    Console.WriteLine($"Введите b1:");
    b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите k1:");
    k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите b2:");
    b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите k2:");
    k2 = Convert.ToDouble(Console.ReadLine());
}

double CalculateX(double b1Num, double k1Num, double b2Num, double k2Num)
{
    return (b2Num - b1Num) / (k1Num - k2Num);
}

double CalculateY(double xNum, double k1Num, double b1Num)
{
    return Convert.ToDouble(k1Num * xNum + b1Num);
}

