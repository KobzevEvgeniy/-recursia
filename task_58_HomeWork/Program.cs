// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using static System.Console;

Clear();

Write("Введите размер матриц: ");
int size = int.Parse(ReadLine());

int[,] array1 = GetArray(size, 0, 9);
int[,] array2 = GetArray(size, 0, 9);
int[,] resultArray = new int [size, size];

PrintArray(array1);
WriteLine( );
PrintArray(array2);
WriteLine( );



for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            resultArray[i, j] += array1[i, k] * array2[k, j];
        }
    }
}
PrintArray(resultArray);


int[,] GetArray(int size, int min, int max)
{
    int[,] result = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

