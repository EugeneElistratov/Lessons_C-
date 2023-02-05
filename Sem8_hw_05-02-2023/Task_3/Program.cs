﻿// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


void FillArrayI(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArrayI(int[,] arrI)
{
    for (int i = 0; i < arrI.GetLength(0); i++)
    {
        for (int j = 0; j < arrI.GetLength(1); j++)
        {
            Console.Write($"{arrI[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArrayII(int[,] arrI)
{
    for (int i = 0; i < arrI.GetLength(0); i++)
    {
        for (int j = 0; j < arrI.GetLength(1); j++)
        {
            arrI[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArrayII(int[,] arrII)
{
    for (int i = 0; i < arrII.GetLength(0); i++)
    {
        for (int j = 0; j < arrII.GetLength(1); j++)
        {
            Console.Write($"{arrII[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Multiplication(int[,] arrI, int[,] arrII)
{
    if (arrI.GetLength(1) != arrII.GetLength(0)) throw new Exception("Матрицы нельзя перемножить.");
    int[,] result = new int[arrI.GetLength(0), arrII.GetLength(1)];
    for (int i = 0; i < arrI.GetLength(0); i++)
    {
        for (int j = 0; j < arrII.GetLength(1); j++)
        {
            for (int k = 0; k < arrII.GetLength(0); k++)
            {
                result[i, j] += arrI[i, k] * arrII[k, j];
            }
        }
    }
    return result;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write("{0}    ", arr[i, j]);
        }
        System.Console.WriteLine();
    }
}

int[,] massivI = new int[3, 2];
FillArrayI(massivI);
PrintArrayI(massivI);
Console.WriteLine();
int[,] massivII = new int[2, 3];
FillArrayII(massivII);
PrintArrayII(massivII);
System.Console.WriteLine("\nМатрица III = I * II");
int[,] arrIII = Multiplication(massivI, massivII);
Print(arrIII);