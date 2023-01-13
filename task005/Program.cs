// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int d = 0;
while (d<=a)
{
    if (d%2==0)
    Console.WriteLine($"{d}");
    d=d+1;
}
