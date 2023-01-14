/*
Задача 3: Напишите программу, которая на вход принимает число 
и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите любое целое число для проверки чётности   ->  ");
string? a = Console.ReadLine();
int value = Convert.ToInt32(a);
int result = value / 2;
if (result % 2 == 0)
{
    Console.WriteLine("Данное число чётное");
}
else Console.WriteLine("Данное число нечётное");