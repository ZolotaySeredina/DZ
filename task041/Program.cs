
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());


int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreateArrayRndInt(size);
PrintArray(array);
Console.WriteLine();
int count = Count(array);
Console.WriteLine($"Элементов больше нуля -> {count} ");
