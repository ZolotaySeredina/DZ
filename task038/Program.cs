/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

double[] MaxMinNumber(double[] arr)
{
double max = arr[0];
double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= max)
        {
            max = arr[i];
        }
        if (arr[i] <= min)
        {
            min = arr[i];
        }
    }
    return new double[]{max, min};
}

double NumberDifference(double[] result)
{
double Diffirence = result[0] - result[1];
return Diffirence;
}

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArrayDouble(array);
Console.WriteLine();
double[] result = MaxMinNumber(array);
double diffirence = NumberDifference(result);
Console.WriteLine($"Разница между максимальным <<{result[0]:F1}>> и минимальным числом <<{result[1]:F1}>> -> {diffirence:F1}");
