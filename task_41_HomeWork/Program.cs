//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string el = Console.ReadLine();
int[] baseArray = MasterArray(el);
Console.Write($"Количество чисел больше 0 = {CountNumbers(baseArray)}");

int[] MasterArray(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int CountNumbers(int [] array)
{ 
    int count=0;
    foreach (int number in array)
{ 
    if (number>0) count++;
}
    return count;
    
}