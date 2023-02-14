// // *Задача 45: Напишите программу,
//  которая будет создавать копию заданного массива с помощью поэлементного копирования.*/
Console.Clear();
int [] NewArray =GetArray(11,0,10);
Console.Write($"[{String.Join(", ", NewArray)}]");
Console.WriteLine("");
Console.Write($"[{String.Join(", ", CopyArray(NewArray))}]");


int [] GetArray (int size, int minValue, int maxValue)
{
int [] res = new int [size];
for (int i=0; i<size; i++)
{
    res[i] =new Random().Next(minValue, maxValue);
}
return res;
}

int[] CopyArray(int[] array)
{
    int size = (array.Length );
    int[] result = new int[size];
    for (int i = 0; i < size ; i++)
    {        
        result[i]= array[i];
    }
    return result;
}
