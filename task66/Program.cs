// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

if ((numberN > 0) && (numberM > 0))
{
    int result = SummMAndN(numberM, numberN);
    Console.WriteLine(result);
}
else
    Console.WriteLine("Некорректный ввод.");

int SummMAndN(int numM, int numN)
{
    if (numM < numN)
    {
        return numM + SummMAndN(numM + 1, numN);
    }
    else if (numM > numN)
    {
        return numM + SummMAndN(numM - 1, numN);
    }
    else //numM==numN
    {
        return numM;
    }
}