//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите количество строк массива m: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива n: ");
int columns = int.Parse(Console.ReadLine());

double[,] Array1 = GetArray(rows, columns,-10,10);
PrintArray(Array1);


double[,] GetArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] result = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
         for (int j = 0; j < columns; j++)
        {
        result[i,j] = Math.Round((new Random().NextDouble()*(maxValue-minValue)+minValue),2);
        }
    
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i,  j]} ");
        }
        Console.WriteLine();
    }
}
