//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

Write("Введите количество двухмерных массивов в трехмерном: ");
int quantity= int.Parse(ReadLine());

int [] myRandom= GetmyRandom(rows,columns,quantity);
Console.Write($"[{String.Join(", ", myRandom)}]");
WriteLine();
int[, ,] myArray = GetArray(rows, columns, quantity, myRandom);
PrintArray(myArray);
WriteLine();



int [] GetmyRandom (int rows, int columns, int quantity)
{
    int Length= rows*columns*quantity;
    
    int[] result = new int[Length];
    for (int i = 0; i < Length; i++){
        int number=i+10;
        result[i] = number+1;
    }
    return result;
}


int[, ,] GetArray(int m, int n, int q, int [] myRandom) 
{
   int[, ,] result = new int[m, n, q];
   int Length= myRandom.Length;
for (int k = 0; k < q; k++)
   {
    for (int i = 0; i < m; i++)
        { 
            for (int j = 0; j < n; j++)
            { 
             result[i, j, k]=myRandom[Length-1];
             Length--;
            }                                                
        }
    }
    return result;
}


void PrintArray(int[,,] myRandom)
{
    for (int k = 0; k < quantity; k++)
    {
        for (int i = 0; i < myRandom.GetLength(0); i++)
    {
        for (int j = 0; j < myRandom.GetLength(1); j++)
        {
            Write($"{myRandom[i, j, k]} ({i},{j},{k});   ");
        }
        WriteLine();
    }
    }
}
    


