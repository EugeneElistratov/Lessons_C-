/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

System.Console.Write("Введите пятизначное число   ->  ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Проверим, является ли оно палиндромом: ");
if ((n / 10000) == (n % 10) && (n / 1000 % 10) == (n / 10 % 10))
{
    System.Console.WriteLine($"{n}  ->  да");
}
else
{
    System.Console.WriteLine($"{n}  ->  нет");
}


