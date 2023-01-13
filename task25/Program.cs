// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
double NumPow(int a, int b)
{
    double Sum = 1;
    for (int i = 1; i<=b; i++)
        Sum=Sum*a;
    return Sum;
}
Console.WriteLine("введите число a");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (NumPow (num1, num2));