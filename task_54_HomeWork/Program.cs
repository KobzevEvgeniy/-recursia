// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 1, 9);

PrintArray(array);
WriteLine();
GetSortArray(array);
PrintArray(array);
WriteLine();

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void GetSortArray(int[,] array)
{ 
  for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {     
       for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, k] > array[i, j])
            {
                int sort = array[i, j];
                array[i, j] = array[i, k];
                 array[i, k] = sort;
            }
        }
        
    }
      
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
