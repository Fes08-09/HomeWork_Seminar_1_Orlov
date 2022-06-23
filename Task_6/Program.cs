// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());

if(Convert.ToBoolean(a%2 == 0))
{
    Console.Write("Это число четное");
}
else
{
    Console.Write("Это число не четное");
}