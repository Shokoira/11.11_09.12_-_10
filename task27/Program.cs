// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
int NumSum(int a)
{
    int d = 0;
    while (a>0)
    {
        d=d+a%10;
        a=a/10;
    }
    return d;
}
Console.WriteLine("введите число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (NumSum(m));