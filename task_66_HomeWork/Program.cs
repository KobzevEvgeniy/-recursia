// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;
using static System.Console;

Clear();
Write("Введите M Старт: ");
int m=int.Parse(ReadLine());
Write("Введите N Конец: ");
int n=int.Parse(ReadLine());

Write($"Сумма чисел  от {m} до {n} = {PrintNumbers(m,n)}");

int PrintNumbers(int start,int end)
{
    if (start == end) return start;
    return (start+PrintNumbers(start+1, end));
}