// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Введите положительное число N (больше 1)");
int N = Convert.ToInt32(Console.ReadLine());

if(N<=0)
{
    Console.WriteLine("Данное число не подходит под условие, введите новое");
}

int count = 1;
int even_number;
while(count<=N)
{
    if(count % 2 == 0)
    {
    Console.Write(count);
    Console.Write(", ");
    count++;
    }
    else
    {
        count++;
    }
}