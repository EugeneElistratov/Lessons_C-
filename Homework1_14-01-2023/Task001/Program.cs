/* 
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите число а = ");
string a = Console.ReadLine();  // считывает с консоли строку ввода а= 
Console.Write("Введите число b = ");
string b = Console.ReadLine(); // считывает с консоли строку ввода b=
int value1 = Convert.ToInt32(a); // преобразует число в эквивалентное 32-битовое целое число со знаком
int value2 = Convert.ToInt32(b);
if (value1 > value2)
{
    Console.WriteLine("max = " + value1);
}
else
{
    Console.WriteLine("max = " + value2);
}