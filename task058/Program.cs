﻿/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
int[,] divMatrix =  new int[matrix1.GetLength(0), matrix1.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            divMatrix[i, j] += matrix1[i,k] * matrix2[k, j];
        }
    }
}
return divMatrix;
}
int[,] array2d = CreateMatrixRndInt(2, 2, 1, 6);
PrintMatrix(array2d);
Console.WriteLine();
int[,] array2dTwo = CreateMatrixRndInt(2, 2, 1, 6);
PrintMatrix(array2dTwo);
int[,] productOfNumbers = ProductMatrix(array2d, array2dTwo);
Console.WriteLine();
PrintMatrix(productOfNumbers);

