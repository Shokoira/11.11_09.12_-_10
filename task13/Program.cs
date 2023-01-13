// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int FindNumber(int num)
{
    if (num<100)
    {
        Console.WriteLine("третей цифры нет");
        return 0;
    }
    while (num>1000)
        num=num/10;
    return num%10;
}
Console.WriteLine(FindNumber(a));