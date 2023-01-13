// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b=1;
while (a>=b)
{
    if (b%2==0)
        Console.Write($"{b} ");
    b=b+1;
}
