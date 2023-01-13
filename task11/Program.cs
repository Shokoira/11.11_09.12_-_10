// Напишите программу, которая 
// 1. выводит слуайное трехзначное число
// 2. удаляет вторую цифру этого числа

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайне трехзначное число = {number}");

int RemoveSecondDigit(int numb)
{
    int firstDigit = numb / 100;
    int thirdDigit = numb % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;

}
Console.WriteLine("Удаляем вторую цифру числа");
Console.WriteLine($"Результат = {RemoveSecondDigit(number)}");