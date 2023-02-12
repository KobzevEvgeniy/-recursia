// Рекурсия и двухмерный массив
string[,] table = new string [2,5];// так задается двухмерный массив с типом данных текст
// String.Empty
// table [0.0] table [0.1] table [0.2] table [0.3] table [0.4]
// table [1.0] table [1.1] table [1.2] table [1.3] table [1.4]
table[1,2]= "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows,columns]}-");
    } 
}


void PrintArray(int[,]matr) // метод для вывода двухмерного массива целых чисел
{
for (int i = 0; i < matr.GetLength(0); i++) // вместо i<3 пишем новую конструкцию
    {
    for (int j = 0; j < matr.GetLength(1); j++) // вместо i<4 пишем новую конструкцию
    {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine(); //это надо чтоб вывод был через разные строки, без нее выводит одной колонкой
    }
}

void FillArray(int[,] matr) //метод заполнения массива случайными числами
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10); // интервал чисел от 1-10
    }
}
}

int [,] matrix = new int [3,4]; // так задается двухмерный массив с типом данных целые числа
PrintArray(matrix);             // печатает пустой массив
FillArray(matrix);              //заполняет пустой массив случайными числами
Console.WriteLine();            // строка чтоб разделить путой массив от заполненного
PrintArray(matrix);             //печатает заполненный массив
