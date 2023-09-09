
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);

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

bool FindNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(4, -9, 999);
Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());
bool findNum = FindNum(array, number);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(findNum ? "Число присутствует" : "Число отсутсвует");