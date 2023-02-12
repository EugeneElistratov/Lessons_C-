// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке 
// от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Promt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
void ChetnNumbers(int M, int N)
{
    if (M <= N)
    {
        if (M % 2 == 0)
        {
            System.Console.Write($"{M}, ");
        }
    }
    else return;
    ChetnNumbers(M + 1, N);
}

int M = Promt("Введите M ");
int N = Promt("Введите N ");
ChetnNumbers(M, N);