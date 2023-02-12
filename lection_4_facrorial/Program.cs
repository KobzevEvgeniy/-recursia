// программа вычисление факториала с помощью рекурсии
double Factorial(int n)
{   //1!=1 и 0!=1
    if (n==1) return 1;
    else return n * Factorial(n-1);
}
Console.WriteLine (Factorial(5));// факториал цифры 5, но если число большое надо использовать тип doable

for (int i=1; i<=40; i++)         //факториал числа 40 напримере в типе Int не помещается
{
    Console.WriteLine ($"{i}!   = {Factorial(i)}");
}

