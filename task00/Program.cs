﻿// Задача 0. Напишите программу, которая 
// 1.на вход принимает число 
// 2. выдает его квадрат (число умноженное на само себя)
// например
// 4 -> 16
// -3 -> 9
// -7 -> 49


Console.WriteLine("Введите целое число: ");

int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");



