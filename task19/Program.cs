﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("введите число");
string a = Console.ReadLine();
if (a[0]==a[4] && a[1]==a[3])
    Console.WriteLine ("Да");
else 
    Console.WriteLine ("Нет");
