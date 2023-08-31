
int CountDigits(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = CountDigits(number);
Console.WriteLine($"В числе {number} -> знаков {result}");