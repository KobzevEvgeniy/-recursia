// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
using System;
using static System.Console;

Clear();
int size = 4;
int[,] NewArray = new int[size, size];

GetArrayS(NewArray, size);
PrintArray(NewArray);



void GetArrayS(int[,] array, int Length)
{
    int i = 0;
    int j = 0;
    int number = 1;
    for (int l = 0; l < Length * Length; l++)
    {
        int k = 0;
        do { array[i, j++] = number++;} 
        while (++k < Length - 1);
        for (k = 0; k < Length- 1; k++) 
        {
            array[i++, j] = number++;
        }
        for (k = 0; k < Length - 1; k++)
        {
            array[i, j--] = number++;
        } 
        for (k = 0; k < Length- 1; k++) 
        array[i--, j] = number++;
        ++i; ++j;
        Length = Length < 2 ? 0 : Length - 2;
    }
}


void PrintArray(int[,] myRandom)
{
    
     for (int i = 0; i < myRandom.GetLength(0); i++)
    {
        for (int j = 0; j < myRandom.GetLength(1); j++)
        {
            Write($"{myRandom[i, j]} ");
        }
        WriteLine();
    }
}




// Решение предопадавателя
// Clear();
// Write($"Введите размер матрицы: ");
// int s = int.Parse(ReadLine());
// int[,] arr = GetArray(s);
// PrintArray(arr);



// int[,] GetArray(int size)
// {
//     int[,] result = new int[size, size];
//     int i = 0;
//     int j = 0;
//     int rowE = size - 1;
//     int columnE = size - 1;
//     int rowS = 0;
//     int columnS = 0;
//     bool left = true;
//     bool top = true;
//     int count = 0;
//     while (count < size * size)
//     {
//         count++;
//         result[i, j] = count;
//         //идем вправо
//         if (left && top)
//         {
//             if (j == columnE)
//             {
//                 rowS++;
//                 top = true;
//                 left = false;
//                 i++;
//                 continue;
//             }
//             else
//             {
//                 j++;
//                 continue;
//             }
//         }
//         //идем вниз
//         if (!left && top)
//         {
//             if (i == rowE)
//             {
//                 columnE--;
//                 top = false;
//                 left = false;
//                 j--;
//                 continue;
//             }
//             else
//             {
//                 i++;
//                 continue;
//             }
//         }
//         //идем влево
//         if (!left && !top)
//         {
//             if (j == columnS)
//             {
//                 rowE--;
//                 top = false;
//                 left = true;
//                 i--;
//                 continue;
//             }
//             else
//             {
//                 j--;
//                 continue;
//             }
//         }
//         //Идем вверх
//         if (left && !top)
//         {
//             if (i == rowS)
//             {
//                 columnS++;
//                 top = true;
//                 left = true;
//                 j++;
//                 continue;
//             }
//             else
//             {
//                 i--;
//                 continue;
//             }
//         }

//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }