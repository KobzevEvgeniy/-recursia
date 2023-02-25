// /***Задача 67:**Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9*/
using System;
using static System.Console;

Clear();
Write("Введите число  ");
int number=int.Parse(ReadLine());
WriteLine(SumNumber(number));
//number = 453
int SumNumber(int end) //end =12
{
    if(end == 0)
    {
        
        return 0;
        
    }
    
    int s = end % 10 + SumNumber(end / 10);//PM(2 + 1)
    Console.WriteLine(s);
    
    return (s);
}