/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7 */

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

int SumString(int[,] matrix)
{
    int minSum = int.MaxValue;
    int MinIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
           int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];

        }
         if (sum < minSum)
        {
            minSum = sum;
            MinIndex = i;
        }

    }
    return MinIndex;
}

int[,] array2d = CreateMatrixRndInt(4, 4, -9, 9);
PrintMatrix(array2d);
Console.WriteLine();
int minIndex = SumString(array2d);
Console.WriteLine(minIndex);
