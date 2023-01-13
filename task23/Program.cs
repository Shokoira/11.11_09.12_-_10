

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
while (a>b)
{
    Console.WriteLine(Math.Pow(b,3));
    b=b+1;
}