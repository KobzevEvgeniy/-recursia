//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
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

int[, ,] myRandom = GetArray(rows, columns, quantity);
PrintArray(myRandom);
WriteLine();


int[, ,] GetArray(int m, int n, int q) 
{
   int[, ,] result = new int[m, n, q];
   int [] myRandom={10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,
   34,35,36,37,38,39,40,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,
   73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99};
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
    


