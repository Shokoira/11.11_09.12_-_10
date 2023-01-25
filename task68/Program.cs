﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(S(M,N));
int S (int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return S(m-1,1);
    else return S(m - 1,S(m,n-1));
}
