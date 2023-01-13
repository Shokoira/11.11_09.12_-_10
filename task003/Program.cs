// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int d = a*-1;
while (d<=a)
{
    Console.Write ($"{d} ");
    d=d+1;
}