// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8
using System;
using static System.Console;


Clear();
Write("Введите число: ");
int m = int.Parse(ReadLine());
Write("Введите степень: ");
int n = int.Parse(ReadLine());

WriteLine($"{Pow(m, n)}");

int Pow(int number, int rank)
{
    if (rank == 0) return 1;
    return (number * Pow(number, rank - 1));
}
