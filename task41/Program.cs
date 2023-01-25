// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3
int CountSum(int a)
{
    int d = 0;
    for (int i = 1; i<=a; i++)
    {
        Console.WriteLine($"введите число{i}");
        int m = Convert.ToInt32(Console.ReadLine());
        if (m>0)
            d++;
    }
    return d;
}
Console.WriteLine("введите число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (CountSum(m));