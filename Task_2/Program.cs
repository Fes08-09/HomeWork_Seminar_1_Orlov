// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

if(A > B)
{
    Console.Write(A);
    Console.Write(" > ");
    Console.Write(B);
}
else
{
    Console.Write(B);
    Console.Write(" > ");
    Console.Write(A);
}