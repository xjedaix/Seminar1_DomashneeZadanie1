﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write ("Введите число: ");
int num = int.Parse(Console.ReadLine());
int A1 = 2;
while (A1 <= num)
{
    Console.Write ($" {A1} ");
    A1 = A1 + 2; 
}