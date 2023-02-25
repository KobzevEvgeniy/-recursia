// //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int [] SumArray=GetSumArray(array);
WriteLine(String.Join(" ", (SumArray)));
WriteLine($"Минимальная сумма элементов находится в строке {Final(SumArray)}");



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

int[] GetSumArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)];
    int index = 0;
    
    for (int i = 0; i < inArray.GetLength(0); i++)
    {   int sum=0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {  
            sum+=inArray[i, j];  
        }
           result[index] = sum;index++;
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

int Final(int [] arraySum)
{  int count=arraySum.Length;
    int position=0;
    int index=0;
    int minNumber=arraySum[index];

    while(index<count)
    {
        if (arraySum[index]<minNumber)
        {   minNumber=arraySum[index];
            position=index+1;
        }
        index++;
    }
    return position; 
    
    
}
