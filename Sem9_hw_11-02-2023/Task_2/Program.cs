// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Promt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNatNumbers(int M, int N, int sum = 0)
{
    if (M <= N)
    {
        sum += M;
        return SumNatNumbers((M + 1), N, sum);
    }
    return sum;
}

int M = Promt("Введите M ");
int N = Promt("Введите N ");
SumNatNumbers(M, N);
System.Console.Write($"M = {M}; N = {N} -> Сумма = ");
System.Console.Write(SumNatNumbers(M, N));
