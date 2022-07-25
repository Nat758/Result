﻿//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
NaturalNumber(num);

void NaturalNumber ( int digit)
{
    if(digit==0) return;
    Console.Write($"{digit}");
    NaturalNumber (digit - 1);
}