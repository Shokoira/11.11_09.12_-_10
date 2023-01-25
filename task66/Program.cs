// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalNumbers(M,N));
int NaturalNumbers (int num1, int num2)
{
    if (num1 > num2) return 0;
    return NaturalNumbers (num1, num2 - 1)+num2;
}