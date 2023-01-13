// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
void Weekend(int num)
{
    if(num == 6||num == 7)
        Console.WriteLine("выходные");
    else 
     Console.WriteLine("не выходные");
}
Weekend(a);