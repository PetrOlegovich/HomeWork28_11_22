﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число  - a :");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите число - b :");
int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int sum = 1;
int i = 1;
for ( i= 1; i <= b; i++)
{
    sum = sum*a;
}
Console.WriteLine(sum);

