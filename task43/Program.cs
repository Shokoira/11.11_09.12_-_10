﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Lines(double k1, double k2, double b1, double b2)
{
    if ((k1-k2)!=0)
    {
        double x=(b2-b1)/(k1-k2);
        double y=k1*x+b1;
        Console.WriteLine($"точка пересечения {x}, {y}");
    }
    else if (k1==k2 && b1==b2)
    Console.WriteLine("лежат на одной прямой");
    else 
    Console.WriteLine("параллельны");

}
Console.WriteLine("введите k1");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите k2");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b1");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b2");
double num4 = Convert.ToDouble(Console.ReadLine());
Lines (num1, num2, num3, num4);