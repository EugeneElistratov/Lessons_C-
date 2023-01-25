// Задача 2: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Реализовать через функции.

Console.Clear();

int Prompt(string message)
{
    Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int Sum(int n)
{
    int Prod = 0;
    for (int i = 1; i <= n; i++)
    {
        Prod = Prod + i;
    }
    return Prod;
}
int n = Prompt("Введите число N ");
int sum = Sum(n);
System.Console.WriteLine($"Сумма цифр в числе {n}  =  {sum}");
