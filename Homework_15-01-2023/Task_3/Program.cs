/*
Задача 3: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int a = Prompt("Введите день недели в виде числа:   ");
if (a < 1 || a > 7) System.Console.WriteLine("Введённое число не является днём недели");

else
    if (a >= 6)
{
    System.Console.WriteLine($"{a} ->  Да");
}
else
{
    System.Console.WriteLine($"{a} ->  Нет");
}