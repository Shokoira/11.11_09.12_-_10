// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2= Convert.ToInt32(Console.ReadLine());

if (num2==num1*num1) 
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
