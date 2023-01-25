// Задача 1: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int Prompt(string message)
{
    Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int a = Prompt("Введите число A ");

int b = Prompt("Введите число B ");
    
    int Prod = 1;
    for (int i = 1; i <= b; i++)
    {
        Prod = Prod  * a;
    }
Console.WriteLine($"{a}, {b} -> {Prod}");
  