// Задача 2: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int Prompt(string message)
{
    Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int Sum(int n)
{
    int Sum = 0;
    while (n > 0)
    {
        int lastDigit = n % 10; // находим последнюю цифру по очереди до первой
        Sum = Sum + lastDigit; // находим cумму последних цифр (можно Sum += lastDigit)
        n = n / 10; // уменьшаем разрядность числа на единицу (можно n /= 10) 
    }
    return Sum;
}
int n = Prompt("Введите число N ");
int sum = Sum(n);
Console.WriteLine($"Сумма цифр в числе {n}  =  {sum}");