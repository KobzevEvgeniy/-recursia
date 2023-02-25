// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
using System;
using static System.Console;

Clear();
Write("Введите N Конец: ");
int n=int.Parse(ReadLine());
Write("Введите M Старт: ");
int m=int.Parse(ReadLine());

WriteLine(PrintNumbers(n, m));

string PrintNumbers(int end,int start)
{
    while(end == start)
    {
        Console.WriteLine(end);
        return start.ToString();
        
    }
    
    string s = PrintNumbers(end - 1, start)+' ' + end.ToString() ;
    Console.WriteLine(s);
    
    return (s);
}