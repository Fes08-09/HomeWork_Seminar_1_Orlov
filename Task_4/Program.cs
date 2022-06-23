// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.Write(max);
