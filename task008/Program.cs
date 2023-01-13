// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

int numMax=a;
if (numMax<b)
    numMax=b;
else if (numMax<c)
    numMax=c;
Console.WriteLine($"Максимальное число:{numMax}");