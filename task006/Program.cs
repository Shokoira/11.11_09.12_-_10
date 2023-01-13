// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a<0)
    a=a*-1;
Console.WriteLine(a);
