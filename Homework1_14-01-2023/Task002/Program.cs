/*
Задача 2: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три числа ниже");
Console.Write("a = ");
string? a = Console.ReadLine();
Console.Write("b = ");
string? b = Console.ReadLine();
Console.Write("c = ");
string? c = Console.ReadLine();
int value1 = Convert.ToInt32(a);
int value2 = Convert.ToInt32(b);
int value3 = Convert.ToInt32(c);
if ((value1 > value2) & (value1 > value3))
{
    Console.WriteLine("max = " + value1);
}
else if ((value2 > value1) & (value2 > value3))
{
    Console.WriteLine("max = " + value2);
}
else if ((value3 > value1) & (value3 > value2))
{
    Console.WriteLine("max = " + value3);
}